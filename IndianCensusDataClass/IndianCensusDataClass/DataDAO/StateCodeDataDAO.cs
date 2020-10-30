// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StateCodeDataClass.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace IndiaCensusDataClass.DataDAO
{
    public class StateCodeDataDAO
    {
        /// <summary>
        /// Attributes from the state code class matching the header for the CSV Class
        /// </summary>
        public int serialNumber;
        public string stateName;
        public int tin;
        public string stateCode;
        /// <summary>
        /// Parameterised constructor defining the instance of the Indian State code Class Attributes and assigning them the value passed
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <param name="stateName"></param>
        /// <param name="tin"></param>
        /// <param name="stateCode"></param>
        public StateCodeDataDAO(string serialNumber, string stateName, string tin, string stateCode)
        {
            this.serialNumber = Convert.ToInt32(serialNumber);
            this.stateName = stateName;
            this.tin = Convert.ToInt32(tin);
            this.stateCode = stateCode;
        }
    }
}
