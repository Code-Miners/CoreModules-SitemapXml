//-----------------------------------------------------------------------
// <copyright file="VideoSitemapTests.cs" company="Code Miners Limited">
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


using Core.Modules.Web.Sitemap.Model;
using Core.Modules.Web.Sitemap.Serialization;

namespace LibraryTests
{
    using System;
    using Core.Modules.Web.Sitemap.Model;
    using Core.Modules.Web.Sitemap.Model.NodeTypes;
    using Core.Modules.Web.Sitemap.Serialization;
    using Core.Modules.Web.Sitemap.Validation;
    using NUnit.Framework;

    [TestFixture]
    public class VideoSitemapTests
    {
        [Test]
        public void GenerationAndSerialisationTest()
        {
            VideoNode videoNode = new VideoNode(url: "http://www.example.com/Videos/video1.mp3");
            
            videoNode.ThumbnailLoc = "http://www.example.com/thumbs/123.jpg";
            videoNode.Title = "Example Title";
            videoNode.Description = "Example Description of the Video";
            videoNode.ContentLoc = "http://streamserver.example.com/video123.mp4";
            videoNode.PlayerLoc = "http://www.example.com/videoplayer.php?video=123";
            videoNode.Duration = "60";
            videoNode.ExpireDate = "0000-00-00";
            videoNode.Rating = "0.0";
            videoNode.ViewCount = "0";
            videoNode.PubDate = "0000-00-00";
            videoNode.FamFriendly = "yes";
            videoNode.Restrict = new Restrict()
            {
                Countries = "CA MX", relationship = "allow"
            };
            videoNode.Platform = new Platform()
            {
                Platforms = "web mobile tv", relationship = "allow"
            };
            videoNode.Price = new Price()
            {
                Amount = "00.00", currency = "GBP", type = "rent", resolution = "sd"
            };
            videoNode.Uploader = new Uploader()
            {
                UploaderName = "Example Name",
                info = "http://www.example.com/UploaderDetails"
            };
            videoNode.RequirSub = "yes";
            videoNode.LiveVideo = "yes";
            videoNode.CategoryDesc = "Example Category Description";

            SitemapNode page = new SitemapNode(url: "http://www.example.com/videos/some_video_landing_page.html");

            page.Videos.Add(videoNode);
            
            VideoSitemap sitemap = new VideoSitemap(nodes:new [] { page });

            XmlSerializer serializer = new XmlSerializer();

            string output = serializer.Serialize(sitemap);

            Assert.IsNotNull(output);

            Console.Error.WriteLine(output);
        }   

        [Test]
        public void ValidateGeneratedXmlAgainstImageSchemaTest()
        {
            VideoSitemapValidator validator = new VideoSitemapValidator();
            VideoNode videoNode = new VideoNode(url: "http://www.example.com/Videos/video1.mp3");
            SitemapNode page = new SitemapNode(url: "http://www.example.com/videos/some_video_landing_page.html");

            page.Videos.Add(videoNode);

            VideoSitemap sitemap = new VideoSitemap(nodes: new[] { page });

            ValidationResult result = validator.ValidateSitemap(sitemap);

            Assert.IsFalse(result.IsValid, "Generated sitemap doesn't validate against the sitemap schema");
        }
    }
}
