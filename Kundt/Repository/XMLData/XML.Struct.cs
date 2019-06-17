namespace Repository.XMLData
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Linq;
    using System.IO;
    using System.Text;
    using System.Reflection;
    using System.Linq;
    using System.Xml;

    using DTO;
    using KundtExceptions;

    public class XMLStruct : IXMLStruct
    {

        const string prefix = "Repository.XMLData.";

        public Dictionary<string, string> GetStructureFiles()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            foreach (XElement files in XElement.Load(GetEmbeddedXMLFile("StructFiles.xml")).Elements("File"))
            {
                result.Add(files.Attribute("Name").Value, files.Attribute("Desc").Value);
            }
            return result;

        }

        public List<StructFile> GetStruct(string structName)
        {
            var result = new List<StructFile>();
            bool find = false;

            foreach (XElement structNode in XElement.Load(GetEmbeddedXMLFile("Structures.xml")).Elements("Struct"))
            {
                //Find for Name node element in XML
                try
                {
                    if (structNode.HasElements && structNode.Attribute("value").Value.Equals(structName))
                    {
                        find = true;
                        using (XmlReader reader = structNode.CreateReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.NodeType!=XmlNodeType.EndElement && Enum.TryParse(reader.Name, out StructType _type))
                                {
                                    result.Add(CreateStruct(reader, _type));
                                }
                            }
                        }
                    }
                }
                catch
                {
                    throw new LoadExceptions($"Structure <{structName}> not configurated. Error call XML Structures.");
                }

            }

            if (!find) { throw new LoadExceptions($"Structure <{structName}> not found. Error call XML Structures."); }

            /*

              <Struct value ="Default">
                
                
                <AtmosphericPressure value="MANUAL"  describe="Atmospheric Pressure"  field="-" line="-1" IndexPosition="-1"></AtmosphericPressure>
                <Data structLine="2" startData="12" stopData="-"></Data>
                <MIC1Time          value="MIC 1 Time"                describe="[A]"  field="C1:  Time[s]"                 unit="s" ></MIC1Time>
                <MIC1Pressure      value="MIC 1 Pressure"            describe="[A]"  field="C1:  [Pa]"                    unit="Pa"></MIC1Pressure>
                <MIC2Time          value="MIC 2 Time"                describe="[A]"  field="C2:  Time[s]"                 unit="s"></MIC2Time>
                <MIC2Pressure      value="MIC 2 Pressure"            describe="[A]"  field="C2:  [Pa]"                    unit="Pa"></MIC2Pressure>
                <FRF1Frequency     value="FRF(C1, C2) Frequency"     describe="[A]"  field="M1: FRF(C1,C2) Frequency[Hz]" unit="Hz"></FRF1Frequency>
                <FRF1Amplification value="FRF(C1, C2) Amplification" describe="[A]"  field="M1: FRF(C1,C2) [](A)"         unit="-"></FRF1Amplification>
                <FRF2Frequency     value="FRF(C2,C1) Frequency"      describe="[A]"  field="M2: FRF(C2,C1) Frequency[Hz]" unit="Hz"></FRF2Frequency>
                <FRF2Amplification value="FRF(C2,C1) Amplification"  describe="[A]"  field="M2: FRF(C2,C1) [](A)"         unit="-"></FRF2Amplification>
                <FFT1Frequency     value="FFT(C1) Frequency"         describe="[A]"  field="M3: FFT(C1) Frequency[Hz]"    unit="Hz"></FFT1Frequency>
                <FFT1Amplitude     value="FFT(C1) (A)"               describe="[A]"  field="M3: FFT(C1) [Pa](A)"          unit="-"></FFT1Amplitude>
                <FFT2Frequency     value="FFT(C2) Frequency"         describe="[A]"  field="M4: FFT(C2) Frequency[Hz]"    unit="Hz"></FFT2Frequency>
                <FFT2Amplitude     value="FFT(C2) (A)"               describe="[A]"  field="M4: FFT(C2) [Pa](A)"          unit="-"></FFT2Amplitude>
              </Struct>

             */
            return result;

        }


        private Stream GetEmbeddedXMLFile(string file)
        {
            string foundFile = prefix + file;
            var verify = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames();
            if (!verify.Any(x => x == foundFile))
            {
                throw new LoadExceptions($"Embedded File <{file}> not found. Error XML call.");
            }
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(foundFile);
            return stream;
        }

        private StructFile CreateStruct(XmlReader reader, StructType type) => new StructFile()
        {
            Type = type,
            Value = reader["value"],
            Field = reader["field"],
            Unit = reader["unit"]
        };



        /*
            <Name                value="Default"                   field="Default struct"               unit="-" ></Name>
            <Temperature         value="MANUAL"                    field="Temperature"                  unit="C" ></Temperature>
            <AtmosphericPressure value="MANUAL"                    field="Atmospheric Pressure"         unit="KPa" ></AtmosphericPressure>
            <DataIndex           value="2"                         field="File Struct Line"             unit="-"></DataIndex>
            <DataStart           value="12"                        field="Start Line Data"              unit="-"></DataStart>
            <DataEnd             value="0"                         field="End Line Data (0 for all)"    unit="-"></DataEnd>
            <MIC1Time            value="MIC 1 Time"                field="C1:  Time[s]"                 unit="s" ></MIC1Time>
            <MIC1Pressure        value="MIC 1 Pressure"            field="C1:  [Pa]"                    unit="Pa"></MIC1Pressure>
            <MIC2Time            value="MIC 2 Time"                field="C2:  Time[s]"                 unit="s"></MIC2Time>
            <MIC2Pressure        value="MIC 2 Pressure"            field="C2:  [Pa]"                    unit="Pa"></MIC2Pressure>
            <FRF1Frequency       value="FRF(C1, C2) Frequency"     field="M1: FRF(C1,C2) Frequency[Hz]" unit="Hz"></FRF1Frequency>
            <FRF1Amplification   value="FRF(C1, C2) Amplification" field="M1: FRF(C1,C2) [](A)"         unit="-"></FRF1Amplification>
            <FRF2Frequency       value="FRF(C2,C1) Frequency"      field="M2: FRF(C2,C1) Frequency[Hz]" unit="Hz"></FRF2Frequency>
            <FRF2Amplification   value="FRF(C2,C1) Amplification"  field="M2: FRF(C2,C1) [](A)"         unit="-"></FRF2Amplification>
            <FFT1Frequency       value="FFT(C1) Frequency"         field="M3: FFT(C1) Frequency[Hz]"    unit="Hz"></FFT1Frequency>
            <FFT1Amplitude       value="FFT(C1) (A)"               field="M3: FFT(C1) [Pa](A)"          unit="Pa"></FFT1Amplitude>
            <FFT2Frequency       value="FFT(C2) Frequency"         field="M4: FFT(C2) Frequency[Hz]"    unit="Hz"></FFT2Frequency>
            <FFT2Amplitude       value="FFT(C2) (A)"               field="M4: FFT(C2) [Pa](A)"          unit="Pa"></FFT2Amplitude>
        */



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
