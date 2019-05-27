//-----------------------------------------------------------------------
// <copyright file="UrlElementCollection.cs" company="Code Miners Limited">
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
    using System.Collections.Generic;
    using System.Configuration;

    /// <summary>
    /// The url element collection which maps the configuration file entries to internal objects
    /// </summary>
    [ConfigurationCollection(typeof(UrlElement), AddItemName = "url", CollectionType = ConfigurationElementCollectionType.BasicMap)]
    public class UrlElementCollection : ConfigurationElementCollection, IEnumerable<UrlElement>
    {
        /// <summary>
        /// Gets the base url for the collection of urls when available in the config file
        /// </summary>
        [ConfigurationProperty("baseUrl", IsRequired = false)]
        public string BaseUrl => this["baseUrl"] as string;

        /// <summary>
        /// Gets or sets a url element from the collection by index
        /// </summary>
        /// <param name="index">The index</param>
        /// <returns>The url element</returns>
        public UrlElement this[int index]
        {
            get => BaseGet(index) as UrlElement;
            set
            {
                if (Count <= 0)
                {
                    BaseAdd(index, value);
                    return;
                }

                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }

                BaseAdd(index, value);
            }
        }

        /// <summary>
        /// Iterator for returning url elements from the collection
        /// </summary>
        /// <returns>A url element</returns>
        public new IEnumerator<UrlElement> GetEnumerator()
        {
            int count = Count;
            for (int i = 0; i < count; i++)
            {
                yield return BaseGet(i) as UrlElement;
            }
        }

        /// <summary>
        /// Required protected method for returning a configuration element compatible with this
        /// collection
        /// </summary>
        /// <returns>The configuration element</returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new UrlElement();
        }

        /// <summary>
        /// Gets the configuration element key from the provided element
        /// </summary>
        /// <param name="element">The configuration element base class</param>
        /// <returns>The actual instance required</returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((UrlElement)element).Name;
        }
    }
}
