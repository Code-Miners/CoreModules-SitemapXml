﻿//-----------------------------------------------------------------------
// <copyright file="XmlNamespaces.cs" company="Code Miners Limited">
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

namespace Core.Modules.Web.Sitemap.Serialization
{
    internal static class XmlNamespaces
    {
        public const string Sitemap = "http://www.sitemaps.org/schemas/sitemap/0.9";
        public const string SitemapPrefix = "";

        public const string Image = "http://www.google.com/schemas/sitemap-image/1.1";
        public const string ImagePrefix = "image";

        public const string News = "http://www.google.com/schemas/sitemap-news/0.9";
        public const string NewsPrefix = "news";

        public const string Video = "http://www.google.com/schemas/sitemap-video/1.1";
        public const string VideoPrefix = "video";

        public const string Xhtml = "http://www.w3.org/1999/xhtml";
        public const string XhtmlPrefix = "xhtml";
    }
}
