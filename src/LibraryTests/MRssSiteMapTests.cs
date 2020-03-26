//-----------------------------------------------------------------------
// <copyright file="MRssSiteMapeTests.cs" company="Code Miners Limited">
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
    using NUnit.Framework;

    using System;
    using System.Collections.Generic;
    using System.Runtime.Remoting.Channels;
    
    using Core.Modules.Web.Sitemap.Validation;
    using Core.Modules.Web.Sitemap.Serialization;
    using Core.Modules.Web.Sitemap.Model;
    using Core.Modules.Web.Sitemap.Model.NodeTypes;
    using Core.Modules.Web.Sitemap.mRSSModel;
    using Core.Modules.Web.Sitemap.mRSSModel.Channels;
    using Core.Modules.Web.Sitemap.mRSSModel.Channels.Items;
    using Core.Modules.Web.Sitemap.mRSSModel.Channels.Items.MediaContents;
    using Core.Modules.Web.Sitemap.mRSSModel.Channels.Items.MediaContents.Media;

    [TestFixture]
    public class MRssSiteMapTests
    {
        [Test]
        public void GenerationAndSerialisationTest()
        {
            MRssNode mrssNode = new MRssNode("2.0");

            MediaContent Content1_1_1 = new MediaContent()
            {
                ContentUrl = "http://www.example.com/examples/mrss/example.flv",
                ContentFileSize = "12216320",
                ContentType = "video",
                ContentMedium = "video",
                ContentDuration = "185",
                ContentHeight = "200",
                ContentWidth = "300",
                ContentLang = "en",
                Title = new Title()
                {
                    MediaTitle = "Grilling Steaks for Summer"
                },
                Description = new Description()
                {
                    MediaDescription = "Get perfectly done steaks every time"
                },
                Player = new Player()
                {
                    MediaPlayerUrl = "http://www.example.com/shows/example/video.swf?flash_params"
                },
                Thumbnail = new Thumbnail()
                {
                    MediaThumbnailUrl = "http://www.example.com/examples/mrss/example.png"
                }
            };

            Item Item1_1 = new Item()
            {
                Link = "http://www.example.com/examples/mrss/example.html",
                Content = new List<MediaContent>()
            };

            Channel channel1 = new Channel()
            {
                Description = "MRSS Example",
                Link = "http://www.example.com/examples/mrss/",
                Title = "Example MRSS",
                Items = new List<Item>()
            };


            mrssNode.Channels = new List<Channel>();
            Item1_1.Content.Add(Content1_1_1);
            channel1.Items.Add(Item1_1);
            mrssNode.Channels.Add(channel1);

            XmlSerializer serializer = new XmlSerializer();

            string output = serializer.Serialize(mrssNode);

            Assert.IsNotNull(output);

            Console.Error.WriteLine(output);
        }

        [Test]
        public void ValidateGeneratedXmlAgainstMrssSchemaTest()
        {
            MrssSitemapValidator validator = new MrssSitemapValidator();

            MRssNode mrssNode = new MRssNode("2.0");

            ValidationResult result = validator.ValidateSitemap(mrssNode);

            Assert.IsFalse(result.IsValid, "Generated sitemap doesn't validate against the sitemap schema");
        }
    }
}
