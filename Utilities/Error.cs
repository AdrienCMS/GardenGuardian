using System.Windows.Forms;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Diagnostics;


namespace GardenGuardian.Utilities
{

    /// <summary>
    /// Type d'erreur disponibles lors d'un log.
    /// </summary>
    public enum ErrorType
    {
        /// <summary>
        /// Lorsqu'une erreur est survenue.
        /// </summary>
        Error,
        /// <summary>
        /// Lorsqu'un évènement non critique se produit mais qu'il est tout de même nécessaire d'être informé.
        /// </summary>
        Warning,
        /// <summary>
        /// Utilisé pour debugguer, afficher de simples messages dans le fichier de logs.
        /// </summary>
        Info,
        /// <summary>
        /// Utilisé pour afficher un appel de fonction.
        /// </summary>
        FunctionCall,
        /// <summary>
        /// Utilisé pour afficher l'appel d'une fonction DLL.
        /// </summary>
        DllCall,
        /// <summary>
        /// Utilisé lors du succès d'une action.
        /// </summary>
        Success
    }

    static class Error
    {

        /// <summary>
        /// Permet d'indiquer si une erreur est survenue ou non, si une fonction a la possibilité de retourner une erreur, mettre cette variable à false
        /// au début de la fonction.
        /// </summary>
        public static bool ErrorOccured = false;

        /// <summary>
        /// Nom de l'erreur, quand une erreur survient, mettre cette variable à la valeur de Message.
        /// </summary>
        public static string ErrorName;

        /// <summary>
        /// Contenu de l'erreur, quand une erreur survient, mettre cette variable à l'erreur.ToString().
        /// </summary>
        public static string ErrorDescription;

        /// <summary>
        /// Chemin du dossier contenant les fichiers logs, par défaut ils sont dans un dossier appelé "logs" dans le dossier courant de
        /// l'exécutable.
        /// </summary>
        private static string _logsFilePath;

        /// <summary>
        /// Flux de données du fichier log constamment ouvert durant l'exécution du programme. Permet d'écrire dans le fichier.
        /// </summary>
        private static FileStream _logsFile;

        /// <summary>
        /// Cette fonction sera automatiquement appelée la 1ère fois que le programme aura besoin de cette classe.
        /// C'est comme un constructeur mais pour une classe statique.
        /// </summary>
        static Error()
        {
            // Crée le dossier s'il n'existe pas déjà
            Directory.CreateDirectory("logs");

            // Le nom du fichier log contiendra la date et l'heure du moment où le programme a pour la 1ère fois besoin de cette classe
            _logsFilePath = "logs\\logs_" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".txt";
            // Ouvre le fichier en mode d'écriture en partant de la fin du fichier si déjà existant, partage le mode de lecture permettant
            // la lecture du fichier log par un autre logiciel
            _logsFile = File.Open(_logsFilePath, FileMode.Append, FileAccess.Write, FileShare.Read);

            // Ajoute le "destructeur" à la liste des fonctions exécutées lors de la fermeture du programme, permettant de fermer le flux de données
            AppDomain.CurrentDomain.ProcessExit += destructor;
        }

        /// <summary>
        /// Cette fonction est automatiquement appelée dès que le programme s'arrête.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void destructor(object sender, EventArgs e)
        {
            _logsFile.Dispose();
        }

        /// <summary>
        /// Affiche un MessageBox avec le contenu de l'erreur.
        /// </summary>
        public static void showErrorBox()
        {
            MessageBox.Show(ErrorName + ": " + ErrorDescription, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Ajoute une entrée dans le fichier log.
        /// </summary>
        /// <param name="type">Type d'erreur à logguer.</param>
        /// <param name="value">Chaîne de caractères à ajouter au fichier log. Le saut de ligne se fait automatiquement.</param>
        public static void log(ErrorType type, string value)
        {
            DateTime now = DateTime.Now;
            string toWrite = "[" + now.Hour.ToString("00") + ":" + now.Minute.ToString("00") + ":" + now.Second.ToString("00") + "] [" + Thread.CurrentThread.Name + "] [" + type.ToString().ToUpper() + "] " + value.Replace("\r", "\\r").Replace("\n", "\\n") + "\n";
            byte[] bytes = Encoding.UTF8.GetBytes(toWrite);
            _logsFile.Write(bytes, 0, bytes.Length);

            // Permet d'écrire manuellement le buffer du flux de données, car des fois mal géré
            _logsFile.Flush();
        }

        /// <summary>
        /// Permet de logguer la dernière erreur survenue avec la liste des fonctions appelées jusqu'à la dite erreur. Permet d'avoir une trace complète
        /// sur l'erreur.
        /// </summary>
        public static void logError()
        {
            string line = "========================================================================================================================";
            string toWrite =
                line + '\n' +
                Thread.CurrentThread.Name + '\n' +
                ErrorName + "\n" +
                ErrorDescription +
                "\nListe des fonctions:\n";

            // Permet de récupérer toutes les informations de debug,
            // le paramètre true indique qu'on se sert du fichier debug pour avoir le nom du fichier, la ligne et la colonne
            StackTrace st = new StackTrace(true);
            int frameCount = st.FrameCount;
            int i;

            // On commence à 1 pour ne pas prendre la fonction logError
            for (i = 1; i < frameCount; ++i)
            {
                StackFrame frame = st.GetFrame(i);
                string filename = frame.GetFileName();

                toWrite += "  " + frame.GetMethod().Name;

                if (filename != null)
                    toWrite += " dans " + filename + ":ligne " + frame.GetFileLineNumber() + '\n';
                else
                    toWrite += '\n';
            }

            toWrite += line + '\n';
            byte[] bytes = Encoding.UTF8.GetBytes(toWrite);
            _logsFile.Write(bytes, 0, bytes.Length);

            // Permet d'écrire manuellement le buffer du flux de données, car des fois mal géré
            _logsFile.Flush();
        }

    }
}

