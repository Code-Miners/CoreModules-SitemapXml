//-----------------------------------------------------------------------
// <copyright file="Price.cs" company="Code Miners Limited">
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
    /// The Price Property has both a Text and multiple Attribute elements for the xml request
    /// The amount should be actual price.
    /// currency [Required] Specifies the currency in ISO 4217 format.
    /// type [Optional] Specifies the purchase option. Supported values are rent and own. If this is not specified, the default value is own.
    /// resolution [Optional] Specifies the resolution of the purchased version. Supported values are hd and sd.
    /// E.g. Output XML:
    /// <video:price currency="GBP" type="rent" resolution="sd">00.00</video:price>
    /// </summary>
    [Serializable]
    public class Price
    {
        [XmlText]
        public string Amount { get; set; }

        [XmlAttribute("currency")]
        public string Currency { get; set; }

        [XmlAttribute("type")]
        public string PriceType { get; set; }

        [XmlAttribute("resolution")]
        public string Resolution { get; set; }
    }
}