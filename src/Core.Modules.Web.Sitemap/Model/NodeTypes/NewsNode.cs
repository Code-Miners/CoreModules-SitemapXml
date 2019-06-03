//-----------------------------------------------------------------------
// <copyright file="NewsNode.cs" company="Code Miners Limited">
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
    /// Describes a single news item in a sitemap
    /// </summary>
    public class NewsNode
    {
        /// <summary>
        /// Gets or sets the URL of the News Item.
        /// </summary>
        [XmlElement("url", Order = 1)]
        public string Url { get; set; }


        /// <summary>
        /// Gets or sets the genre of the News Item.
        /// </summary>
        [XmlElement("genre", Order = 2)]
        public string Genre { get; set; }

        /// <summary>
        /// Gets or sets the publication date of the News Item
        /// </summary>
        [XmlElement("publicationDate", Order = 3)]
        public string PublicationDate { get; set; }

        /// <summary>
        /// Gets or sets the title location of the News Item.
        /// </summary>
        [XmlElement("title", Order = 4)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the Keywords of the News Item.
        /// </summary>
        [XmlElement("keywords", Order = 5)]
        public string Keywords { get; set; }

        /// <summary>
        /// Gets or sets the stock ticker for the News Item
        /// </summary>
        [XmlElement("stockTickers", Order = 6)]
        public string StockTickers { get; set; }
        
        /// <summary>
        /// Gets or sets additional publication information for this news node
        /// </summary>
        [XmlElement (elementName: "publication", Order =  7)]
        public NewsPublicationNode Publication { get; set; }

        /// <summary>
        /// Default constructor, required for the serializer
        /// </summary>
        public NewsNode()
        {

        }

        /// <summary>
        /// Creates an instance of the news node
        /// </summary>
        /// <param name="url">The URL of the image.</param>
        public NewsNode(string url)
        {
            Url = url;
        }
    }
}
