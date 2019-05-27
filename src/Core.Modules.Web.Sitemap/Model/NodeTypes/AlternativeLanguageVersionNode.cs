//-----------------------------------------------------------------------
// <copyright file="SitemapPageTranslation.cs" company="Code Miners Limited">
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

namespace Core.Modules.Web.Sitemap.Model.NodeTypes
{
    using System.ComponentModel;
    using System.Xml.Serialization;

    /// <summary>
    /// Encloses alternative links to a url for another language or locale
    /// </summary>
    public sealed class AlternativeLanguageVersionNode
    {
        /// <summary>
        /// The URL of the alternative language version of the URL
        /// </summary>
        [XmlAttribute("href")]
        public string Url { get; set; }

        /// <summary>
        /// Defaults to alternate
        /// </summary>
        [XmlAttribute("rel")]
        [DefaultValue("alternative")]
        public string Rel { get; set; }

        /// <summary>
        /// The locale of the alternative version, e.g. de-DE
        /// </summary>
        [XmlAttribute("hreflang")]
        public string Language { get; set; }

        public AlternativeLanguageVersionNode()
        {

        }

        /// <summary>
        /// Set an alternative link for a URL
        /// </summary>
        /// <param name="url">The URL to the translation page</param>
        /// <param name="language">The locale for the other resource, e.g. 'de-DE'</param>
        /// <param name="rel">Defaults to 'alternate'</param>
        public AlternativeLanguageVersionNode(string url, string language, string rel = "alternate")
        {
            Url = url;
            Language = language;
            Rel = rel;
        }
    }
}
