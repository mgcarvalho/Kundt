namespace Repository.XMLData
{
    using System.Collections.Generic;

    public interface IXMLStruct
    {
        Dictionary<string, string> GetStructureFiles();

        Dictionary<string, int> GetDataIndex();
    }
}
