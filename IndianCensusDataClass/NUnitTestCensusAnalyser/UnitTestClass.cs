using NUnit.Framework;
using IndiaCensusDataClass;
using IndianCensusDataClass;
using System.Collections.Generic;
using IndianCensusDataClass.DTO;
using System.Security;

namespace NUnitTestCensusAnalyser
{
    public class Tests
    {
        //File path and header definition stored in a string
        public static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        public static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
        public static string indianStateCensusFilePath = @"F:\Program files(x64)\Microsoft Visual Studio\BridgeLabzAssignments\Indian-Census-Analyser\IndianCensusDataClass\IndianCensusDataClass\CSVFiles\IndiaStateCensusData.csv";
        public static string indianStateCodeFilePath = @"F:\Program files(x64)\Microsoft Visual Studio\BridgeLabzAssignments\Indian-Census-Analyser\IndianCensusDataClass\IndianCensusDataClass\CSVFiles\IndiaStateCode.csv";
       
        public static string wrongIndianStateCensusFilePath = @"C:\Program files(x64)\Microsoft Visual Studio\BridgeLabzAssignments\Indian-Census-Analyser\IndianCensusDataClass\IndianCensusDataClass\CSVFiles\IndiaStateCensusData.csv";
        public static string wrongIndianStateCensusFileType = @"F:\Program files(x64)\Microsoft Visual Studio\BridgeLabzAssignments\Indian-Census-Analyser\IndianCensusDataClass\IndianCensusDataClass\CSVFiles\IndiaStateCensusData.txt";

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
            Assert.AreEqual(29, totalRecord.Count);
        }
        /// <summary>
        /// TC 1.2 - To pass a wrong file path and assert whether the custom exception of file not found is returned or not
        /// </summary>
        [Test]
        public void GivenWrongFile_ShouldReturnCustomException()
        {
            var indianStateCensusResult = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongIndianStateCensusFilePath, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.Exception.FILE_NOT_FOUND, indianStateCensusResult.exception);
        }
        /// <summary>
        /// TC 1.3 - To pass a wrong file type and the correct file name and assert whether the custom exception of file not found is returned or not
        /// </summary>
        [Test]
        public void GivenWrongFileType_ShouldReturnCustomException()
        {
            var indianStateCensusResult = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongIndianStateCensusFileType, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.Exception.INVALID_FILE_TYPE, indianStateCensusResult.exception);
        }

    }
}