

using System.Collections.Generic;
using System.Runtime.Remoting.Channels;

namespace LibraryTests
{
    using System;
    using Core.Modules.Web.Sitemap.Model;
    using Core.Modules.Web.Sitemap.Model.NodeTypes;
    using Core.Modules.Web.Sitemap.Serialization;
    using Core.Modules.Web.Sitemap.Validation;
    using NUnit.Framework;
    using Core.Modules.Web.Sitemap.mRSSModel;

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
                Url = "http://www.example.com/examples/mrss/example.flv",
                Medium = "video",
                Duration = "120",
                Title = new Title()
                {
                    Title_ = "Grilling Steaks for Summer"
                },
                Description = new Description()
                {
                    Description_ = "Get perfectly done steaks every time"
                },
                Player = new Player()
                {
                    PlayerUrl = "http://www.example.com/shows/example/video.swf?flash_params"
                },
                Thumbnail = new Thumbnail()
                {
                    ThumbnailUrl = "http://www.example.com/examples/mrss/example.png"
                }
            };

            MediaContent Content1_1_2 = new MediaContent()
            {
                Url = "http://www.example.com/examples/mrss/example.flv",
                Medium = "video",
                Duration = "120",
                Title = new Title()
                {
                    Title_ = "Grilling Steaks for Summer"
                },
                Description = new Description()
                {
                    Description_ = "Get perfectly done steaks every time"
                },
                Player = new Player()
                {
                    PlayerUrl = "http://www.example.com/shows/example/video.swf?flash_params"
                },
                Thumbnail = new Thumbnail()
                {
                    ThumbnailUrl = "http://www.example.com/examples/mrss/example.png"
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
            Item1_1.Content.Add(Content1_1_2);
            channel1.Items.Add(Item1_1);
            mrssNode.Channels.Add(channel1);

            XmlSerializer serializer = new XmlSerializer();

            string output = serializer.Serialize(mrssNode);

            Assert.IsNotNull(output);

            Console.Error.WriteLine(output);
        }
    }
}
