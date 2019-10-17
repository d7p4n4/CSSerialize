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
            List<PlanProperty> list = new List<PlanProperty>();
            PlanProperty prop = new PlanProperty("a","a","a");
            list.Add(prop);
            Console.WriteLine(prop.GetType().Name);

            PlanClass pc = new PlanClass(prop.GetType().Name, list);


            XmlSerializer xs = new XmlSerializer(typeof(PlanClass));

            TextWriter txtWriter = new StreamWriter("d:\\Server\\Visual_studio\\CSSerialize\\CSSerialize\\Serialization.xml");

            xs.Serialize(txtWriter, pc);

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
