using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.IO;
using System.Text;
using System.Reflection;
using System.Linq;

namespace Repository.XMLData
{
    public class XMLStruct : IXMLStruct
    {

        const string  prefix = "Repository.XMLData.";

        public Dictionary<string,string> GetStructureFiles()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();       
            foreach (XElement files in XElement.Load(GetEmbeddedXMLFile("StructFiles.xml")).Elements("File"))
            {
                result.Add(files.Attribute("Name").Value, files.Attribute("Desc").Value);
            }
            return result;

        }

        public Dictionary<string, int> GetDataIndex()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            //string pathXMLFiles = FullPathXMLFiles();
            //....
            //line start
            //line end
            //StructLine
            //....
            //foreach (XElement files in XElement.Load(pathXMLFiles).Elements("File"))
            //{
            //    result.Add(files.Attribute("name").Value, files.Attribute("Local").Value);
            //}
            return result;

        }


        private Stream GetEmbeddedXMLFile(string file)
        {
            string foundFile = prefix + file;
            var verify = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames();
            if (!verify.Any(x => x== foundFile))
            {
                throw new FileNotFoundException($"Embedded File <{file}> not found. Error XML call.");
            }
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(foundFile);
            return stream;
        }

       
        // GetResourceTextFile("myXmlDoc.xml")

        /*
		 
		 public string GetResourceTextFile(string filename)
			{
				string result = string.Empty;

				using (Stream stream = this.GetType().Assembly.
						   GetManifestResourceStream("assembly.folder."+filename))
				{
					using (StreamReader sr = new StreamReader(stream))
					{
						result = sr.ReadToEnd();
					}
				}
				return result;
			}
		 
		 
		 */
    }
}
