//-----------------------------------------------------------------------
// <copyright file="UrlElement.cs" company="Code Miners Limited">
//  Copyright (c) 2019 Code Miners Limited
//   
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//  
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//  GNU Lesser General Public License for more details.
//  
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.If not, see<https://www.gnu.org/licenses/>.
// </copyright>
//-----------------------------------------------------------------------

namespace Core.Modules.Web.Sitemap.Configuration
{
    using System.Configuration;

    /// <summary>
    /// The url element maps a single configuration file entry to a strongly
    /// typed object
    /// </summary>
    public class UrlElement : ConfigurationElement
    {
        /// <summary>
        /// The unique url element key
        /// </summary>
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name => this["name"] as string;

        /// <summary>
        /// The url element value. This will be the fully qualified url for the endpoint
        /// </summary>
        [ConfigurationProperty("value", IsRequired = true)]
        public string Value => this["value"] as string;

        /// <summary>
        /// Default constructor. Present to allow for debug constructor only
        /// </summary>
        public UrlElement()
        {
        }

        /// <summary>
        /// Debug constructor for supporting unit tests.
        /// </summary>
        /// <param name="name">The name</param>
        /// <param name="value">The value</param>
        internal UrlElement(string name, string value)
        {
            this["name"] = name;
            this["value"] = value;
        }
    }
}
