


namespace KundtManager
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Repository.XMLData;
    using DTO;

    public class LoadStructs
    {
        private readonly IXMLStruct _xmlData;

        public LoadStructs()
        {
            IXMLStruct xmlData = new XMLStruct();
            _xmlData = xmlData ?? throw new ArgumentNullException(nameof(xmlData));
        }

        public Dictionary<string, string> GetSavedStructs()
        {
            return _xmlData.GetStructureFiles();
        }

        public List<StructFile> GetStructs(string name)
        {
            return _xmlData.GetStruct(name);

        }

    }
}
