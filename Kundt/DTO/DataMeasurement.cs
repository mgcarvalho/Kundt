using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DataMeasurement
    {
        public DataMeasurement()
        {
            C1 = new Mic();
            C2 = new Mic();
            M1 = new FRF();
            M2 = new FRF();
            M3 = new FFT();
            M4 = new FFT();
        }

        public int Id { get; set; }

        public Mic C1 { get; set; }

        public Mic C2 { get; set; }

        public FRF M1 { get; set; }

        public FRF M2 { get; set; }

        public FFT M3 { get; set; }

        public FFT M4 { get; set; }

    }
}
