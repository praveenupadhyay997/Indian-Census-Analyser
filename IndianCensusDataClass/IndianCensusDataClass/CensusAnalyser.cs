using IndianCensusDataClass.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndianCensusDataClass
{
    public class CensusAnalyser
    {
       public enum Country
        {
            INDIA, USA
        }
        public Dictionary<string, CensusDTO> datamap;
        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath, string dataHeaders)
        {
            datamap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return datamap;
        }
    }
}
