using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Game
{
    public class GameFactory
    {
        StreamWriter sw;
        XmlSerializer serial;
        public List<Game> GameList = new List<Game>();

        public void CreateGameList()
        {
            Game g = new Game("Hornets", "Bulldogs", 50, 75);
            GameList.Add(g);
            g = new Game("Lions", "Tigers", 25, 43);
            GameList.Add(g);
            g = new Game("Wolves", "Panthers", 57, 51);
            GameList.Add(g);
            g = new Game("Sharks", "Dolphins", 78, 46);
            GameList.Add(g);
            g = new Game("Ducks", "Penguins", 110, 89);
            GameList.Add(g);
            g = new Game("Geese", "Swans", 68, 49);
            GameList.Add(g);
        }

        public string FilePath = @"..\..\patients.xml";

        public bool SerializeGameList()
        {
            serial = new XmlSerializer(GameList.GetType());
            sw = new StreamWriter(FilePath);
            serial.Serialize(sw, GameList);
            sw.Close();
            return true;
        }

        public void DeserializeGameList()
        {
           
        }
    }

    
}
