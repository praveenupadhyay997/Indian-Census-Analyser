// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IndianCensusDataClass.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
using IndianCensusDataClass.DTO;
using System;
using System.Collections.Generic;

namespace IndianCensusDataClass
{
    class Program
    {
        /// <summary>
        /// File path and header details of the CSV File
        /// </summary>
        public static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        public static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
        public static string indianStateCensusFilePath = @"F:\Program files(x64)\Microsoft Visual Studio\BridgeLabzAssignments\Indian-Census-Analyser\IndianCensusDataClass\IndianCensusDataClass\CSVFiles\IndiaStateCensusData.csv";
        public static string indianStateCodeFilePath = @"F:\Program files(x64)\Microsoft Visual Studio\BridgeLabzAssignments\Indian-Census-Analyser\IndianCensusDataClass\IndianCensusDataClass\CSVFiles\IndiaStateCode.csv";
        /// <summary>
        /// Dictionary to fetch the total Record present in the Indian State Census File
        /// </summary>
        public static Dictionary<string, CensusDTO> totalRecord = new Dictionary<string, CensusDTO>();
        /// <summary>
        /// Dictionary to fetch the total Record present in the Indian State Code File
        /// </summary>
        public static Dictionary<string, CensusDTO> stateRecord = new Dictionary<string, CensusDTO>();
        static void Main(string[] args)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("Welcome to Indian State Census Analyser Proogram");
            Console.WriteLine("================================================");
            /// Creating an Instance of the Census analyser Class to access the File Load Process
            CensusAnalyser censusAnalyser = new CensusAnalyser();
            /// Fetching the records from the Indian State Census File
            totalRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            /// Fetching the records from the Indian State Code File
            stateRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indianStateCodeFilePath, indianStateCodeHeaders);
            /// UC1 - Accessing the Census Analyser Class to invoke the file access process
            /// Loading the file onto the dictionary created
            /// Displaying the record counts to the console
            Console.WriteLine("Total Records present in the Indian State Census File = "+ totalRecord.Count);
            Console.WriteLine("Total Records present in the Indian State Code File = "+ stateRecord.Count);


        }
    }
}
