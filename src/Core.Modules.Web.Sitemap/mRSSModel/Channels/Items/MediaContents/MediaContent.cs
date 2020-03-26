//-----------------------------------------------------------------------
// <copyright file="MediaContent.cs" company="Code Miners Limited">
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

namespace Core.Modules.Web.Sitemap.mRSSModel.Channels.Items.MediaContents
{
    using System.Xml.Serialization;
    using Core.Modules.Web.Sitemap.mRSSModel.Channels.Items.MediaContents.Media;
    public class MediaContent
    {
        // Attributes for the Content tag
        [XmlAttribute("url")]
        public string ContentUrl { get; set; }

        [XmlAttribute("medium")]
        public string ContentMedium { get; set; }

        [XmlAttribute("filesize")]
        public string ContentFileSize { get; set; }

        [XmlAttribute("type")]
        public string ContentType { get; set; }

        [XmlAttribute("duration")]
        public string ContentDuration { get; set; }

        [XmlAttribute("height")]
        public string ContentHeight { get; set; }

        [XmlAttribute("width")]
        public string ContentWidth { get; set; }

        [XmlAttribute("lang")]
        public string ContentLang { get; set; }


        // Sub elements of the Content tag 
        [XmlElement(ElementName = "title", Order = 1)]
        public Title Title { get; set; }

        [XmlElement(ElementName = "description", Order = 2)]
        public Description Description { get; set; }

        [XmlElement(ElementName = "player", Order = 3)]
        public Player Player { get; set; }

        [XmlElement(ElementName = "thumbnail", Order = 4)]
        public Thumbnail Thumbnail { get; set; }
    }
}
