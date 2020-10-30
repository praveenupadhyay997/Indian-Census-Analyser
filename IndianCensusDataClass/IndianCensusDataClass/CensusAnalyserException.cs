// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomAnalyserException.cs" company="Bridgelabz">
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
    /// Custom exception class to inherit from the exception class to display custom messages
    /// </summary>
    public class CensusAnalyserException : Exception
    {
        // Creating an instance of the exception class to inherit the messages returned from base Exception Class
        public Exception exception;
        /// <summary>
        /// Enum to store the exception type 0- File not found, 1- invalid file type
        /// 2- incorrect header 3- no such country 4- incorrect delimiter
        /// </summary>
        public enum Exception
        {
            FILE_NOT_FOUND, 
            INVALID_FILE_TYPE,
            INCORRECT_HEADER,
            NO_SUCH_COUNTRY,
            INCORRECT_DELIMITER
        }
        /// <summary>
        /// Parameterised constructor intended to overwrite the base message from the exception class
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public CensusAnalyserException(string message, Exception exception) : base(message)
        {
            this.exception = exception;
        }
    }
}