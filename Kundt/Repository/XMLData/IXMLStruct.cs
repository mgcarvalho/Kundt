namespace Repository.XMLData
{
    using System.Collections.Generic;

    using DTO;

    public interface IXMLStruct
    {
        Dictionary<string, string> GetStructureFiles();

        List<StructFile> GetStruct(string structName);
    }
}
