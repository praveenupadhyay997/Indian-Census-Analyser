using NUnit.Framework;
using IndiaCensusDataClass;
using IndianCensusDataClass;
using System.Collections.Generic;
using IndianCensusDataClass.DTO;

namespace NUnitTestCensusAnalyser
{
    public class Tests
    {
        public static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        public static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
        public static string indianStateCensusFilePath = @"F:\Program files(x64)\Microsoft Visual Studio\BridgeLabzAssignments\Indian-Census-Analyser\IndianCensusDataClass\IndianCensusDataClass\CSVFiles\IndiaStateCensusData.csv";
        public static string indianStateCodeFilePath = @"F:\Program files(x64)\Microsoft Visual Studio\BridgeLabzAssignments\Indian-Census-Analyser\IndianCensusDataClass\IndianCensusDataClass\CSVFiles\IndiaStateCode.csv";

        CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;
        Dictionary<string, CensusDTO> stateRecord;
        /// <summary>
        /// Initialising the instance of the Class objects
        /// </summary>
        [SetUp]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();
            stateRecord = new Dictionary<string, CensusDTO>();
        }
        /// <summary>
        /// TC 1.1 - To get the records and to assert whether the count of all the records matches to manually addressed or not
        /// Using the Dictionary Collection to store the Indian State Census Records and then Count it
        /// </summary>
        [Test]
        public void GivenIndianStateDataCensus_ReturnsCorrectCount()
        {
            totalRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            stateRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indianStateCodeFilePath, indianStateCodeHeaders);

            Assert.AreEqual(29, totalRecord.Count);
            Assert.AreEqual(37, stateRecord.Count);
        }
    }
}