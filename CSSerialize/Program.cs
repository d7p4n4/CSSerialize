using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSSerialize
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> dict = GetProps.getProps(typeof(PersonStart));
            List<string> names = new List<string>();
            List<string> types = new List<string>();

            foreach(var d in dict)
            {
                names.Add(d.Key);
                types.Add(d.Value);
            }

            PersonStartSerialize ps = new PersonStartSerialize(names, types);

            XmlSerializer xs = new XmlSerializer(typeof(PersonStartSerialize));

            TextWriter txtWriter = new StreamWriter("d:\\Server\\Visual_studio\\CSSerialize\\CSSerialize\\Serialization.xml");

            xs.Serialize(txtWriter, ps);

            txtWriter.Close();
            /*
            using (FileStream fileStream = new FileStream("d:\\Server\\Visual_studio\\Serialization.xml", FileMode.Open))
            {
                Employee result = (Employee)xs.Deserialize(fileStream);
                Console.WriteLine(result.name);
            }*/
        }
    }
}
