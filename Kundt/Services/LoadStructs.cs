


namespace KundtManager
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Repository.XMLData;

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

    }
}
