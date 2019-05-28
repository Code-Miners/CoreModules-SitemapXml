//-----------------------------------------------------------------------
// <copyright file="Sitemap.cs" company="Code Miners Limited">
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

namespace Core.Modules.Web.Sitemap.Model
{
    using System.Collections.Generic;
    using System.Xml.Serialization;
    using NodeTypes;
    using Serialization;

    /// <summary>
    /// Encapsulates the sitemap file and references the current protocol standard.
    /// </summary>
    [XmlRoot("urlset", Namespace = XmlNamespaces.Sitemap)]
    public class Sitemap : IXmlNamespaceProvider
    {
        /// <summary>
        /// Sitemap nodes linking to documents
        /// </summary>
        [XmlElement("url")]
        public virtual List<SitemapNode> Nodes { get; }

        internal Sitemap()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sitemap"/> class.
        /// </summary>
        /// <param name="nodes">Sitemap nodes.</param>
        public Sitemap(IEnumerable<SitemapNode> nodes)
        {
            Nodes = new List<SitemapNode>(nodes);
        }

        /// <inheritDoc/>
        public virtual IEnumerable<string> GetNamespaces()
        {
            // Importing the namespace, even without the elements is ok
            yield return XmlNamespaces.Xhtml;
        }
    }
}