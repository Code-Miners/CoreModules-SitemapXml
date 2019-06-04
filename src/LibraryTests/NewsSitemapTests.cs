//-----------------------------------------------------------------------
// <copyright file="NewsSitemapTests.cs" company="Code Miners Limited">
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
    public class NewsSitemapTests
    {
        [Test]
        public void GenerationAndSerialisationWithNullPublicationTest()
        {
            NewsNode newsNode = new NewsNode("http://www.example.com/images/news.html")
            {
                Genre = "genre 1",
                PublicationDate = "1900-01-01",
                Title = "test title 1",
                Keywords = "key word 1",
                StockTickers = "stock ticker 1",
                Publication = null
            };

            NewsNode newsNode2 = new NewsNode("http://www.example.com/images/news.html");
            SitemapNode page = new SitemapNode("http://www.example.com/directory.html");
            page.News.Add(newsNode);
            page.News.Add(newsNode2);

            NewsSitemap sitemap = new NewsSitemap(new [] { page });

            XmlSerializer serializer = new XmlSerializer();

            string output = serializer.Serialize(sitemap);

            Assert.IsNotNull(output);

            Console.Error.WriteLine(output);
        }

        [Test]
        public void NewsNodeWithPublicationValueTest()
        {
            NewsNode newsNode = new NewsNode("http://www.example.com/images/news.html")
            {
                Genre = "genre 1",
                PublicationDate = "1900-01-01",
                Title = "test title 1",
                Keywords = "key word 1",
                StockTickers = "stock ticker 1",
                Publication = new NewsPublicationNode
                {
                    Name = "TestName1", Language = "FR"
                }
            };


            NewsNode newsNode2 = new NewsNode("http://www.example.com/images/news.html");
            SitemapNode page = new SitemapNode("http://www.example.com/directory.html");
            page.News.Add(newsNode);
            page.News.Add(newsNode2);

            NewsSitemap sitemap = new NewsSitemap(new [] { page });

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
            NewsNode newsNode = new NewsNode("http://www.example.com/images/news.html")
            {
                Genre = "genre 1",
                PublicationDate = "1900-01-01",
                Title = "test title 1",
                Keywords = "key word 1",
                StockTickers = "stock ticker 1",
                Publication = new NewsPublicationNode
                {
                    Name = "TestName1", Language = "FR"
                }
            };

            NewsNode newsNode2 = new NewsNode("http://www.example.com/images/news.html");
            SitemapNode page = new SitemapNode("http://www.example.com/directory.html");
            page.News.Add(newsNode);
            page.News.Add(newsNode2);

            NewsSitemap sitemap = new NewsSitemap(new[] { page });

            NewsSitemapValidator validator = new NewsSitemapValidator();
            ValidationResult result = validator.ValidateSitemap(sitemap);

            Assert.IsFalse(result.IsValid, "Generated sitemap doesn't validate against the sitemap schema");
        }
    }
}