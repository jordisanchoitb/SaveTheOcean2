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
            xmlDocument = new XmlDocument();
            try {
                xmlDocument.Load(PATH);
            }
            catch (Exception e)
            {
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

        private static void CreateXMl()
        {
            var xmlDocument = new XmlDocument();
            var rootNode = xmlDocument.CreateElement("Scores");
            xmlDocument.AppendChild(rootNode);
            xmlDocument.Save(PATH);
        }

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

        /*public void ConvertToXml(List<ComarcaDTO> comarcas)
        {
            var xmlDocument = new XmlDocument();
            var rootNode = xmlDocument.CreateElement("Comarques");
            xmlDocument.AppendChild(rootNode);

            foreach (var comarca in comarcas)
            {
                var comarcaNode = xmlDocument.CreateElement("Comarca");
                rootNode.AppendChild(comarcaNode);

                var anyNode = xmlDocument.CreateElement("Any");
                anyNode.InnerText = comarca.Any.ToString();
                comarcaNode.AppendChild(anyNode);

                var codiNode = xmlDocument.CreateElement("Codi");
                codiNode.InnerText = comarca.CodiComarca.ToString();
                comarcaNode.AppendChild(codiNode);

                var nomNode = xmlDocument.CreateElement("Nom");
                nomNode.InnerText = comarca.NomComarca;
                comarcaNode.AppendChild(nomNode);

                var poblacioNode = xmlDocument.CreateElement("Poblacio");
                poblacioNode.InnerText = comarca.Poblacio.ToString();
                comarcaNode.AppendChild(poblacioNode);

                var domesticNode = xmlDocument.CreateElement("DomesticXarxa");
                domesticNode.InnerText = comarca.DomesticXarxa.ToString();
                comarcaNode.AppendChild(domesticNode);

                var activitatsNode = xmlDocument.CreateElement("ActivitatsEconomiques");
                activitatsNode.InnerText = comarca.ActivitatsEconomiques.ToString();
                comarcaNode.AppendChild(activitatsNode);

                var totalNode = xmlDocument.CreateElement("Total");
                totalNode.InnerText = comarca.Total.ToString();
                comarcaNode.AppendChild(totalNode);

                var consumNode = xmlDocument.CreateElement("ConsumDomesticPerCapita");
                consumNode.InnerText = comarca.ConsumDomesticPerCapita.ToString();
                comarcaNode.AppendChild(consumNode);
            }
            xmlDocument.Save(PATH);
        }*/
    }
}
