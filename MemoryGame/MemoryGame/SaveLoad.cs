using System.IO;
using System.Xml.Serialization;

namespace MemoryGame
{
    public class SaveLoad<T>
    {
        private XmlSerializer serializer;
        private StreamWriter writer;

        private SaveLoad()
        {

        }
    }
}