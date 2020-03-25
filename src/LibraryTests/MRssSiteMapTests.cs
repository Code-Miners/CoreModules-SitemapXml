

using System.Collections.Generic;
using System.Runtime.Remoting.Channels;

namespace LibraryTests
{
    using System;
    using NUnit.Framework;

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
            MRssNode mrssNode = new MRssNode();

            mrssNode.Version = "2.0";

            MediaContent Content1_1_1 = new MediaContent()
            {
                ContentUrl = "http://www.example.com/examples/mrss/example.flv",
                ContentFileSize = "",
                ContentType =  "",
                ContentMedium = "video",
                ContentDuration = "120",
                ContentHeight = "",
                ContentWidth = "",
                ContentLang = "",
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
    }
}
