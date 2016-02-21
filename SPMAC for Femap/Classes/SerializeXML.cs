using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;
using Telerik.WinControls;

namespace SPMAC_for_Femap.Classes
{
    public class SerializeXML
    {
        private readonly static List<SIZE> sizes = new List<SIZE>();
        private readonly string path;

        public SerializeXML(string path)
        {
            this.path = path;
        }

        public void Serialize(object obj)
        {
            var serializer = new XmlSerializer(obj.GetType());
            using (TextWriter writer = new StreamWriter(path))
                serializer.Serialize(writer, obj);
        }

        public List<SIZE> DeSerializer()
        {
            var deserializer = new XmlSerializer(typeof(List<SIZE>));
            var reader = new StreamReader(path);
            var obj = deserializer.Deserialize(reader);
            reader.Close();
            return (List<SIZE>)obj;
        }

        public static List<SIZE> Values()
        {
            return sizes;
        }

        public static void Clear()
        {
            sizes.Clear();
        }

        public static void Add(string ID, double Value)
        {
            var s = new SIZE() { Id = ID, Value = Value };
            sizes.Add(s);
        }

        public static bool Check(List<SIZE> LIST, string ID)
        {
            var check = false;
            if (LIST.Count > 0)
                foreach (var VARIABLE in LIST)
                {
                    if (VARIABLE.Id != ID)
                        check = true;
                    else return false;
                }
            else return true;
            return check;
        }
    }

    public class SIZE
    {
        [XmlElement("Значение")]
        public double Value { get; set; }
        [XmlElement("Размер")]
        public string Id { get; set; }
    }
}
