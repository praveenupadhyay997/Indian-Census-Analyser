// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CSVAdapterFactory.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
using IndianCensusDataClass.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndianCensusDataClass
{
    /// <summary>
    /// Class containing the load Csv data function
    /// </summary>
    public class CSVAdapterFactory
    {
        /// <summary>
        /// Load Csv Data returning the mapped dictionary loaded from the Csv File
        /// </summary>
        /// <param name="country"></param>
        /// <param name="csvFilePath"></param>
        /// <param name="dataHeaders"></param>
        /// <returns></returns>
        public Dictionary<string, CensusDTO> LoadCsvData(CensusAnalyser.Country country, string csvFilePath, string dataHeaders)
        {
            switch (country)
            {
                /// Case for Country India Calling the function Load Census Data to load the data from CSV file
                /// Return the default exception of no such country from the custom exception class
                case (CensusAnalyser.Country.INDIA):
                    return new IndianCensusAdapter().LoadCensusData(csvFilePath, dataHeaders);
                default:
                    throw new CensusAnalyserException("No Such Country", CensusAnalyserException.Exception.NO_SUCH_COUNTRY);

            }
        }
    }
}