// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CensusAdapter.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndianCensusDataClass
{
    /// <summary>
    /// Census Adapter Class to return the data for the census csv files or the State code files
    /// </summary>
    public class CensusAdapter
    {
        /// <summary>
        /// Function returning the header as the string file
        /// </summary>
        /// <param name="csvFilePath"></param>
        /// <param name="dataHeaders"></param>
        /// <returns></returns>
        public string[] GetCensusData(string csvFilePath, string dataHeaders)
        {
            // String to store the data from the csv file
            string[] censusData;
            // Checking if the file exists for the path or not
            // Throwing the custom exception for the file not found
            if (!File.Exists(csvFilePath))
                throw new CensusAnalyserException("File Not Found", CensusAnalyserException.Exception.FILE_NOT_FOUND);
            // Checking for the extension of the file path
            // Throwing the custom exception for the invalid file type
            if (Path.GetExtension(csvFilePath) != ".csv")
                throw new CensusAnalyserException("Invalid file type", CensusAnalyserException.Exception.INVALID_FILE_TYPE);
            // Reading all the file data at the present file path 
            censusData = File.ReadAllLines(csvFilePath);
            // Checking for the file header present at the 0th position in the string array
            // Throwing the custom exception for incorrect header in the data file
            if (censusData[0] != dataHeaders)
            {
                throw new CensusAnalyserException("Incorrect header in Data", CensusAnalyserException.Exception.INCORRECT_HEADER);
            }
            // Returning the string array data read as a line seperated by delimiter , in the csv  file
            return censusData;
        }
    }
}