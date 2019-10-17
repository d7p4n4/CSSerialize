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
    public class PlanProperty
    {
        [XmlElement]
        public string Name { get; set; }
        [XmlElement]
        public string DataType { get; set; }
        [XmlElement]
        public string GUID { get; set; }

        public PlanProperty() { }

        public PlanProperty(string aName, string aDataType, string aGUID)
        {
            Name = aName;
            DataType = aDataType;
            GUID = aGUID;
        }
    }
}
