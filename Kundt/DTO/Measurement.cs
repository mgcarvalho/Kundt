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
            Measurements = new List<DataMeasurement>();
        }

        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public double Temperature { get; set; }

        public double AtmosphericPressure { get; set; }

        public List<DataMeasurement> Measurements { get; set; }


    }
}
