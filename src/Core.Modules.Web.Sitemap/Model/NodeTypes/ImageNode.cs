//-----------------------------------------------------------------------
// <copyright file="SitemapImageNode.cs" company="Code Miners Limited">
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
    using System.Xml.Serialization;

    /// <summary>
    /// Encloses all information about a single image
    /// </summary>
    public sealed class ImageNode
    {
        public ImageNode()
        {

        }

        /// <summary>
        /// Creates an instance of SitemapImage
        /// </summary>
        /// <param name="url">The URL of the image.</param>
        public ImageNode(string url)
        {
            Url = url;
        }

        /// <summary>
        /// The URL of the image.
        /// </summary>
        [XmlElement("loc", Order = 1)]
        public string Url { get; set; }

        /// <summary>
        /// The caption of the image.
        /// </summary>
        [XmlElement("caption", Order = 2)]
        public string Caption { get; set; }

        /// <summary>
        /// The geographic location of the image.
        /// </summary>
        [XmlElement("geo_location", Order = 3)]
        public string Location { get; set; }

        /// <summary>
        /// The title of the image.
        /// </summary>
        [XmlElement("title", Order = 4)]
        public string Title { get; set; }

        /// <summary>
        /// A URL to the license of the image.
        /// </summary>
        [XmlElement("license", Order = 5)]
        public string License { get; set; }
    }
}