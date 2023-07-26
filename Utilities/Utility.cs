using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using static System.Math;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PAC_APP_V2.Utilities
{
    #region constantes
    /// <summary>
    /// Classe regroupant les constantes du programme en général
    /// </summary>
    public static class Constants
    {
        public const string PROJECT_DATA_REPERTORY = @"C:\ProgramData\PA";//Répertoire des fichiers de données du projet générés par le programme (binaires et ini)
        public static string PROJECT_DOCUMENTS_REPERTORY = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\PACAPP\";//Emplacement des fichiers générés par le programme et utilisables par l'utilisateur
        
        public const double OPENING_ANGLE = 45.0; //Ouverture verticale du diagramme (et des mesures)
        public const double LIGHT_DRONE_DIST = 3.0; //Distance entre le drone et les points calculés 
        public const double EARTH_RADIUS = 6371000.0; //Rayon moyen de la terre
        
        public const int LINEARIZATION_SCALE = 10; //Nombre d'échantillons à créer lors des linéarisation (! Affecte grandement le temps de post process !)
    }
    #endregion

   
}
