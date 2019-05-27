//-----------------------------------------------------------------------
// <copyright file="SerializerTests.cs" company="Code Miners Limited">
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
    using System.IO;
    using System.Text;
    using Core.Modules.Web.Sitemap.Model;
    using Core.Modules.Web.Sitemap.Providers;
    using Core.Modules.Web.Sitemap.Serialization;
    using NUnit.Framework;

    [TestFixture]
    public class SerializerTests
    {
        [Test]
        public void SerializeToStringTest()
        {
            ISitemapProvider provider = new ConfiguredSitemapProvider();
            Sitemap data = provider.GetSiteMap();

            XmlSerializer serializer = new XmlSerializer();
            string text = serializer.Serialize(data);
            Assert.IsFalse(string.IsNullOrWhiteSpace(text), "Serialised sitemap has no text");

            Console.Error.WriteLine(text);
        }

        [Test]
        public void SerializeToStreamTest()
        {
            ISitemapProvider provider = new ConfiguredSitemapProvider();
            Sitemap data = provider.GetSiteMap();
            string text;

            using (MemoryStream stream = new MemoryStream(new byte[40960], true))
            {
                XmlSerializer serializer = new XmlSerializer();
                serializer.SerializeToStream(data, stream);

                stream.Position = 0;
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                text = reader.ReadToEnd();

                Assert.IsFalse(string.IsNullOrWhiteSpace(text), "Serialised sitemap has no text");
            }

            Console.Error.WriteLine(text);
        }
    }
}