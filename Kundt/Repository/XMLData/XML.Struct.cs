using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.IO;
using System.Text;

namespace Repository.XMLData
{
    public class XMLStruct
    {

        public Dictionary<string,string> GetStructureFiles()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            string pathXMLFiles = FullPathXMLFiles();          
            foreach (XElement files in XElement.Load(pathXMLFiles).Elements("File"))
            {
                result.Add(files.Attribute("name").Value, files.Attribute("Local").Value);
            }
            return result;

        }

        public Dictionary<string, int> GetDataIndex()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            string pathXMLFiles = FullPathXMLFiles();
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

        private string FullPathXMLFiles(bool forceCreate = true)
        {
            string result;
            result = AppDomain.CurrentDomain.BaseDirectory +  @"\XML\StructureFiles.xml";

            if (!Directory.Exists(result) && forceCreate)
            {
                Directory.CreateDirectory(result);
                CreateStructDefaultFile();
            }

            result = result + @"\StructureFiles.xml";
            if (!File.Exists(result))
            {
                if (forceCreate)
                {
                    CreateStructDefaultFile();
                }
                else
                {
                    throw new FileNotFoundException("Structure File not found. Error XML call.");
                }
            }

            return @result;
        }

        private void CreateStructDefaultFile()
        {
            //TODO:
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
