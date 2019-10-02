using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Measurement
    {
        public Measurement()
        {
            Id = new Guid();
            MeasurementsFile1 = new List<DataMeasurement>();
            MeasurementsFile2 = new List<DataMeasurement>();
            Results = new List<ResultSet>();
        }

        public Guid Id { get; set; }

        public string Struct { get; set; }

        public string CaseName { get; set; }

        public DateTime Date { get; set; }

        public double Temperature { get; set; }

        public double AtmosphericPressure { get; set; }

        public double MicDistance { get; set; }

        public double furtherMicDistance { get; set; }

        public string LineColor { get; set; }

        public string FileName1 { get; set; }

        public List<DataMeasurement> MeasurementsFile1 { get; set; }

        public string FileName2 { get; set; }

        public List<DataMeasurement> MeasurementsFile2 { get; set; }

        //Calculate
        public List<ResultSet> Results { get; set; }
    }
}
