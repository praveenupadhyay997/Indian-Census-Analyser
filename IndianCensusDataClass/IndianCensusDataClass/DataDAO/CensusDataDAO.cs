// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CensusDataDAO.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace IndiaCensusDataClass.DataDAO
{
    // Class defining the attribute for the indian state census class
    public class CensusDataDAO
    {
        /// <summary>
        /// Attributes from the state census class matching the header for the CSV Class
        /// </summary>
        public string state;
        public long population;
        public long area;
        public long density;
        /// <summary>
        /// Parameterised constructor defining the instance of the Indian Census Class Attributes and assigning them the value passed
        /// </summary>
        /// <param name="state"></param>
        /// <param name="population"></param>
        /// <param name="area"></param>
        /// <param name="density"></param>
        public CensusDataDAO(string state, string population, string area, string density)
        {
            this.state = state;
            this.population = Convert.ToUInt32(population);
            this.area = Convert.ToUInt32(area);
            this.density = Convert.ToUInt32(density);
        }
    }
}
