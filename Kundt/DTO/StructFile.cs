using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StructFile
    {
        public StructType Type { get; set; }

        public string Value { get; set; }

        public string Field { get; set; }

        public string Unit { get; set; }

    }


    public enum StructType
    {
        Name,
        Temperature,
        AtmosphericPressure,
        DataIndex,
        DataStart,
        DataEnd,
        MIC1Time,
        MIC1Pressure,
        MIC2Time,
        MIC2Pressure,
        FRF1Frequency,
        FRF1Amplification,
        FRF2Frequency,
        FRF2Amplification,
        FFT1Frequency,
        FFT1Amplitude,
        FFT2Frequency,
        FFT2Amplitude
    }
    
}
