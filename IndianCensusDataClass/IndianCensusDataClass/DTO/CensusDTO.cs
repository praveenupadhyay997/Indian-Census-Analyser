// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CensusDTO.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
using IndiaCensusDataClass.DataDAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndianCensusDataClass.DTO
{
    /// <summary>
    /// Class to contain the detailed attribute for the census data
    /// </summary>
    public class CensusDTO
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public int tin;
        public string stateCode;
        public long population;
        public long area;
        public long density;
        public double totalArea;
        public double waterArea;
        public double landArea;
        /// <summary>
        /// Parameterised constructor to define the necessary attribute for the Indian State census Data
        /// </summary>
        /// <param name="stateCodeDataDAO"></param>
        public CensusDTO(StateCodeDataDAO stateCodeDataDAO)
        {
            this.serialNumber = stateCodeDataDAO.serialNumber;
            this.stateName = stateCodeDataDAO.stateName;
            this.tin = stateCodeDataDAO.tin;
            this.stateCode = stateCodeDataDAO.stateCode;
        }
        /// <summary>
        /// Parameterised constructor to define the necessary attribute for the Indian State Code Data
        /// </summary>
        /// <param name="censusDataDAO"></param>
        public CensusDTO(CensusDataDAO censusDataDAO)
        {
            this.state = censusDataDAO.state;
            this.population = censusDataDAO.population;
            this.area = censusDataDAO.area;
            this.density = censusDataDAO.density;
        }

    }
}
