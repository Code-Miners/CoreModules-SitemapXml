//-----------------------------------------------------------------------
// <copyright file="ChangeFrequency.cs" company="Code Miners Limited">
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

namespace Core.Modules.Web.Sitemap.Model
{
    using System.Xml.Serialization;

    /// <summary>
    /// Change frequency of the linked document
    /// </summary>
    public enum ChangeFrequency
    {
        /// <summary>
        /// The value "always" should be used to describe documents that change each time they are accessed.
        /// </summary>
        [XmlEnum("always")]
        Always,

        /// <summary>
        /// Hourly change
        /// </summary>
        [XmlEnum("hourly")]
        Hourly,

        /// <summary>
        /// Daily change
        /// </summary>
        [XmlEnum("daily")]
        Daily,

        /// <summary>
        /// Weekly change
        /// </summary>
        [XmlEnum("weekly")]
        Weekly,

        /// <summary>
        /// Monthly change
        /// </summary>
        [XmlEnum("monthly")]
        Monthly,

        /// <summary>
        /// Yearly change
        /// </summary>
        [XmlEnum("yearly")]
        Yearly,

        /// <summary>
        /// The value "never" should be used to describe archived URLs.
        /// </summary>
        [XmlEnum("never")]
        Never
    }
}