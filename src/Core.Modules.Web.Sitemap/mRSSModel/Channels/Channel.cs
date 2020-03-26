//-----------------------------------------------------------------------
// <copyright file="Channel.cs" company="Code Miners Limited">
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

namespace Core.Modules.Web.Sitemap.mRSSModel.Channels
{
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using Core.Modules.Web.Sitemap.mRSSModel.Channels.Items;

    public class Channel
    {
        [XmlElement(ElementName = "title", Order = 1)]
        public string Title { get; set; }

        [XmlElement(ElementName = "link", Order = 2)]
        public string Link { get; set; }

        [XmlElement(ElementName = "description", Order = 3)]
        public string Description { get; set; }

        [XmlElement(ElementName = "item", Type = typeof(Item), Order = 4)]
        public List<Item> Items { get; set; }
    }
}
