using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSSerialize
{
    [Serializable]
    [XmlRoot]
    public class PlanClass
    {
        [XmlElement]
        public string Name { get; set; }
        [XmlElement]
        public List<PlanProperty> PlanProperties { get; set; }

        public PlanClass() { }

        public PlanClass(string newName, List<PlanProperty> newValue)
        {
            Name = newName;
            PlanProperties = newValue;
        }
    }
}
