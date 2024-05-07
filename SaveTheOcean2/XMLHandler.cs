using System.Xml;
using SaveTheOcean2.DTOs;

namespace SaveTheOcean2
{
    public class XMLHandler
    {
        const bool DEBUG = false;

        public static string PATH { get; set; }
        public static XmlDocument xmlDocument { get; set; }

        public XMLHandler(string path) 
        {
            PATH = path;
            // Prova de carregar el document XML
            xmlDocument = new XmlDocument();
            try {
                xmlDocument.Load(PATH);
            }
            catch (Exception e)
            {
                // En cas de que no es pugui carregar el document XML, es crea un nou document XML
                CreateXMl();
                try
                {
                    xmlDocument.Load(PATH);
                } catch (Exception a)
                {
                    if (DEBUG)
                    {
                        Console.WriteLine("Could not create the XML document.");
                        Console.WriteLine(a.Message);
                    }
                    return;
                }
                if (DEBUG)
                {
                    Console.WriteLine("Could not load the XML document.");
                    Console.WriteLine(e.Message);
                }
                return;
            }
        }

        /// <summary>
        /// Crea un arxiu XML amb la estructura necessaria per guardar les puntuacions
        /// </summary>
        private static void CreateXMl()
        {
            var xmlDocument = new XmlDocument();
            var rootNode = xmlDocument.CreateElement("Scores");
            xmlDocument.AppendChild(rootNode);
            xmlDocument.Save(PATH);
        }

        /// <summary>
        /// Afegeix la puntuació d'un jugador al document XML
        /// </summary>
        /// <param name="player">Objecte player</param>
        public void AddScore(Player player)
        {
            var rootNode = xmlDocument.DocumentElement;
            var playerNode = xmlDocument.CreateElement("Score");

            var nameNode = xmlDocument.CreateElement("Name");
            nameNode.InnerText = player.Name;
            playerNode.AppendChild(nameNode);

            var experienceNode = xmlDocument.CreateElement("Experience");
            experienceNode.InnerText = player.Experience.ToString();
            playerNode.AppendChild(experienceNode);

            var roleNode = xmlDocument.CreateElement("Role");
            roleNode.InnerText = player.Role;
            playerNode.AppendChild(roleNode);

            var animalRescuedNode = xmlDocument.CreateElement("AnimalRescued");
            animalRescuedNode.InnerText = player.AnimalRescued.ToString();
            playerNode.AppendChild(animalRescuedNode);

            rootNode.AppendChild(playerNode);
            
            xmlDocument.Save(PATH);
        }
    }
}
