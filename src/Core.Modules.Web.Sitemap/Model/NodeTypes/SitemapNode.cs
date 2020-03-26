//-----------------------------------------------------------------------
// <copyright file="SitemapNode.cs" company="Code Miners Limited">
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
    using System.Collections.Generic;
    using System.Xml.Serialization;
    using Serialization;
    using Video;

    /// <summary>
    /// Encloses all information about a specific URL.
    /// </summary>
    [XmlRoot("url", Namespace = XmlNamespaces.Sitemap)]
    public sealed class SitemapNode
    {
        public SitemapNode()
        {
            Images = new List<ImageNode>();
            Videos = new List<VideoNode>();
            News = new List<NewsNode>();
            Translations = new List<AlternativeLanguageVersionNode>();
        }

        /// <summary>
        /// Creates a sitemap node
        /// </summary>
        /// <param name="url">Specifies the URL. For images and video, specifies the landing page (aka play page).</param>
        public SitemapNode(string url) : this()
        {
            Url = url;
        }

        /// <summary>
        /// URL of the page.
        /// This URL must begin with the protocol (such as http) and end with a trailing slash, if your web server requires it.
        /// This value must be less than 2,048 characters.
        /// </summary>
        [XmlElement("loc", Order = 1)]
        public string Url { get; set; }

        /// <summary>
        /// Shows the date the URL was last modified, value is optional.
        /// </summary>
        [XmlElement("lastmod", Order = 2)]
        public DateTime? LastModificationDate { get; set; }

        /// <summary>
        /// How frequently the page is likely to change. 
        /// This value provides general information to search engines and may not correlate exactly to how often they crawl the page.
        /// </summary>
        [XmlElement("changefreq", Order = 3)]
        public ChangeFrequency? ChangeFrequency { get; set; }

        /// <summary>
        /// The priority of this URL relative to other URLs on your site. Valid values range from 0.0 to 1.0. This value does not affect how your pages are compared to pages on other sites—it only lets the search engines know which pages you deem most important for the crawlers.
        /// The default priority of a page is 0.5.
        /// Please note that the priority you assign to a page is not likely to influence the position of your URLs in a search engine's result pages.
        /// Search engines may use this information when selecting between URLs on the same site, 
        /// so you can use this tag to increase the likelihood that your most important pages are present in a search index.
        /// Also, please note that assigning a high priority to all of the URLs on your site is not likely to help you.
        /// Since the priority is relative, it is only used to select between URLs on your site.
        /// </summary>
        [XmlElement("priority", Order = 4)]
        public decimal? Priority { get; set; }

        [XmlElement("video", Order = 5, Namespace = XmlNamespaces.Video)]
        public List<VideoNode> Videos { get; set; }

        /// <summary>
        /// Additional information about important images on the page.
        /// It can include up to 1000 images.
        /// </summary>
        [XmlElement("image", Order = 6, Namespace = XmlNamespaces.Image)]
        public List<ImageNode> Images { get; set; }

        /// <summary>
        /// Alternative language versions of the URL
        /// </summary>
        [XmlElement("link", Order = 7, Namespace = XmlNamespaces.Xhtml)]
        public List<AlternativeLanguageVersionNode> Translations { get; set; }

        /// <summary>
        /// News.
        /// </summary>
        [XmlElement("news", Order = 8, Namespace = XmlNamespaces.News)]
        public List<NewsNode> News { get; set; }

        /// <summary>
        /// Used for not serializing null values.
        /// </summary>
        public bool ShouldSerializeLastModificationDate()
        {
            return LastModificationDate.HasValue;
        }

        /// <summary>
        /// Used for not serializing null values.
        /// </summary>
        public bool ShouldSerializeChangeFrequency()
        {
            return ChangeFrequency.HasValue;
        }

        /// <summary>
        /// Used for not serializing null values.
        /// </summary>
        public bool ShouldSerializePriority()
        {
            return Priority.HasValue;
        }
    }
}