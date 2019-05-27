//-----------------------------------------------------------------------
// <copyright file="SitemapIndexNode.cs" company="Code Miners Limited">
//  The MIT License(MIT)
//
//  Copyright(c) 2013 Ufuk Hacıoğulları and contributors
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy of
//  this software and associated documentation files (the "Software"), to deal in
//  the Software without restriction, including without limitation the rights to
//  use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
//  the Software, and to permit persons to whom the Software is furnished to do so,
//  subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
//  FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
//  COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
//  IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
//  CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
//-----------------------------------------------------------------------

namespace Core.Modules.Web.Sitemap.Model.NodeTypes
{
    using System;
    using System.Xml.Serialization;
    using Serialization;

    /// <summary>
    /// Encapsulates information about an individual Sitemap.
    /// </summary>
    [XmlRoot("sitemap", Namespace = XmlNamespaces.Sitemap)]
    public sealed class SitemapIndexNode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SitemapIndexNode"/> class.
        /// </summary>
        /// <param name="url">The URL.</param>
        public SitemapIndexNode(string url)
        {
            Url = url;
        }

        /// <summary>
        /// Identifies the location of the Sitemap.
        /// This location can be a Sitemap, an Atom file, RSS file or a simple text file.
        /// </summary>
        [XmlElement("loc", Order = 1)]
        public string Url { get; set; }

        /// <summary>
        /// Identifies the time that the corresponding Sitemap file was modified.
        /// It does not correspond to the time that any of the pages listed in that Sitemap were changed.
        /// By providing the last modification timestamp, you enable search engine crawlers to retrieve only a subset of the Sitemaps in the index
        ///  i.e. a crawler may only retrieve Sitemaps that were modified since a certain date.
        /// This incremental Sitemap fetching mechanism allows for the rapid discovery of new URLs on very large sites.
        /// </summary>
        [XmlElement("lastmod", Order = 2)]
        public DateTime? LastModificationDate { get; set; }

        /// <summary>
        /// Provides the base URL for converting relative URLs to absolute ones
        /// </summary>
        public bool ShouldSerializeLastModificationDate()
        {
            return LastModificationDate != null;
        }
    }
}