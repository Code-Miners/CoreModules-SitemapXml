//-----------------------------------------------------------------------
// <copyright file="ImageSitemapTests.cs" company="Code Miners Limited">
//  Copyright (c) 2019 Code Miners Limited
//   
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//  
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//  GNU Lesser General Public License for more details.
//  
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.If not, see<https://www.gnu.org/licenses/>.
// </copyright>
//-----------------------------------------------------------------------

namespace LibraryTests
{
    using System;
    using Core.Modules.Web.Sitemap.Model;
    using Core.Modules.Web.Sitemap.Model.NodeTypes;
    using Core.Modules.Web.Sitemap.Serialization;
    using Core.Modules.Web.Sitemap.Validation;
    using NUnit.Framework;

    [TestFixture]
    public class ImageSitemapTests
    {
        [Test]
        public void GenerationAndSerialisationTest()
        {
            ImageNode imageNode = new ImageNode("http://www.example.com/images/pic1.png");
            imageNode.Title = "Picture 1";
            imageNode.Caption = "This is my picture";

            ImageNode imageNode2 = new ImageNode("http://www.example.com/images/pic2.png");
            SitemapNode page = new SitemapNode("http://www.example.com/directory.html");
            page.Images.Add(imageNode);
            page.Images.Add(imageNode2);

            ImageSitemap sitemap = new ImageSitemap(new [] { page });

            XmlSerializer serializer = new XmlSerializer();

            string output = serializer.Serialize(sitemap);

            Assert.IsNotNull(output);

            Console.Error.WriteLine(output);
        }

        /// <summary>
        /// Ensures validation is true, the schema from Google is an extension
        /// </summary>
        [Test]
        public void ValidateGeneratedXmlAgainstImageSchemaTest()
        {
            ImageSitemapValidator validator = new ImageSitemapValidator();

            ImageNode imageNode = new ImageNode("http://www.example.com/images/pic1.png");
            SitemapNode page = new SitemapNode("http://www.example.com/directory.html");
            page.Images.Add(imageNode);

            ImageSitemap sitemap = new ImageSitemap(new[] { page });

            ValidationResult result = validator.ValidateSitemap(sitemap);

            Assert.IsFalse(result.IsValid, "Generated sitemap doesn't validate against the sitemap schema");
        }
    }
}
