using IndianCensusDataClass.DTO;
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CensusAnalyser.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace IndianCensusDataClass
{
    /// <summary>
    /// Class Analyser which handles the instance attributes of multiple countries
    /// </summary>
    public class CensusAnalyser
    {
        /// <summary>
        /// Enumerator to create instance for multiple countries
        /// Here with two countries 0- India 1- USA
        /// </summary>
        public enum Country
        {
            INDIA, USA
        }
        // Dictionary to load the data from the CSV file using CsvHelper
        public Dictionary<string, CensusDTO> datamap;
        /// <summary>
        /// Function to load the data from Csv files
        /// </summary>
        /// <param name="country"></param>
        /// <param name="csvFilePath"></param>
        /// <param name="dataHeaders"></param>
        /// <returns></returns>
        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath, string dataHeaders)
        {
            //datamap using instance of the CSV Adapter factory to load the Csv Data
            datamap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return datamap;
        }
    }
}
