// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IndianCensusAdapter.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
using IndiaCensusDataClass.DataDAO;
using IndianCensusDataClass.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndianCensusDataClass
{
    /// <summary>
    /// Class inhereting from the Census Adapter Class thereby having Adapter class for Single Country
    /// </summary>
    class IndianCensusAdapter : CensusAdapter
    {
        /// string to store the data from the csv file in form of string array delimited by ','
        string[] censusData;
        /// <summary>
        /// dictionary to match the header data with the census dto class instance
        /// </summary>
        Dictionary<string, CensusDTO> datamap;
        /// <summary>
        /// Load census data method returning the mapped dictionary of data loaded from the csv files
        /// </summary>
        /// <param name="csvFilePath"></param>
        /// <param name="dataHeaders"></param>
        /// <returns></returns>
        public Dictionary<string, CensusDTO> LoadCensusData(string csvFilePath, string dataHeaders)
        {
            /// Initialising the instance for this dictionary
            datamap = new Dictionary<string, CensusDTO>();
            /// census data getting the data as the string array when passed the csv file path and correct heade
            censusData = GetCensusData(csvFilePath, dataHeaders);
            /// iterating over the string array and skipping the header row written in the string array
            /// when loaded from the csv file
            foreach (string data in censusData.Skip(1))
            {
                /// Exception check for the wrong delimeter and returning the custom exception for wrong delimeter
                if (!data.Contains(","))
                {
                    throw new CensusAnalyserException("File Containers Wrong Delimiter", CensusAnalyserException.Exception.INCORRECT_DELIMITER);
                }
                /// splitting the array delimited at ','
                string[] column = data.Split(",");
                /// adding the data for the Indian State Code csv file
                if (csvFilePath.Contains("IndiaStateCode.csv"))
                    datamap.Add(column[1], new CensusDTO(new StateCodeDataDAO(column[0], column[1], column[2], column[3])));
                /// adding the data for the Indian State census csv file
                if (csvFilePath.Contains("IndiaStateCensusData.csv"))
                    datamap.Add(column[1], new CensusDTO(new CensusDataDAO(column[0], column[1], column[2], column[3])));
            }
            /// returning the dictionary mapped as header and data from the csv file
            return datamap.ToDictionary(records => records.Key, records => records.Value);
        }

    }
}