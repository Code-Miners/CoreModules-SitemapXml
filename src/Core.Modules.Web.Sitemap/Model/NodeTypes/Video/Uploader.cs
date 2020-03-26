//-----------------------------------------------------------------------
// <copyright file="Uploader.cs" company="Code Miners Limited">
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

namespace Core.Modules.Web.Sitemap.Model.NodeTypes.Video
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// The Platform Property has both a Text and Attribute element for the xml request
    /// The UploadName should be the owner of the video
    /// info [Optional] Specifies the URL of a webpage with additional information about this uploader. This URL must be in the same domain as the <loc> tag.
    /// E.g. Output XML:
    /// <video:uploader info="http://www.example.com/UploaderDetails">Example Name</video:uploader>
    /// </summary>
    [Serializable]
    public class Uploader
    {
        [XmlText]
        public string UploaderName { get; set; }

        [XmlAttribute("info")]
        public string Info { get; set; }
    }
}