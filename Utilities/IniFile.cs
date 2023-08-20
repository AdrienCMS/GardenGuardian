using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace GardenGuardian.Utilities
{
    /// <summary>
    /// Classe relative à l'utilisation de fichiers ini
    /// </summary>
    class IniFile
    {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        /// <summary>
        /// Initialise le fichier 
        /// </summary>
        /// <param name="IniPath"> Chemin du fichier créé, si null utilise [nom de l'exécutable].ini</param>
        public IniFile(string IniPath = null)
        {
            string chemin = IniPath ?? EXE + ".ini";
            Path = new FileInfo(chemin).FullName;
        }

        /// <summary>
        /// Récupère la valeur d'un champ donné
        /// </summary>
        /// <param name="Key">Nom du champ</param>
        /// <param name="Section">Optionnel : Nom de section (par défaut la section portera le nom du programme)</param>
        /// <returns></returns>
        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        /// <summary>
        /// Écrit une valeur dans le fichier
        /// </summary>
        /// <param name="Key">Nom du champ</param>
        /// <param name="Value">Valeur du champ</param>
        /// <param name="Section">Optionnel : Nom de section (par défaut la section portera le nom du programme)</param>
        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        /// <summary>
        /// Permet de supprimer une entrée existante
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Section"></param>
        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        /// <summary>
        /// Permet de supprimer une section existante
        /// </summary>
        /// <param name="Section"></param>
        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        /// <summary>
        /// Permet de vérifier l'existance d'une entrée
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Section"></param>
        /// <returns></returns>
        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}
