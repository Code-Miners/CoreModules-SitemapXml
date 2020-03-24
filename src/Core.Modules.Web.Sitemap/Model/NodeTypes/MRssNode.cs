

namespace Core.Modules.Web.Sitemap.Model.NodeTypes
{
    using System;
    using Core.Modules.Web.Sitemap.Model;
    using Core.Modules.Web.Sitemap.Model.NodeTypes;
    using Core.Modules.Web.Sitemap.Serialization;
    using Core.Modules.Web.Sitemap.Validation;
    using System.Xml.Serialization;
    using System.Collections.Generic;

    [XmlRootAttribute(ElementName = "rss", Namespace = XmlNamespaces.Sitemap)]
    public class MRssNode : IXmlNamespaceProvider
    {
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        [XmlElement(ElementName = "channel", Type = typeof(Channel))]
        public List<Channel> Channels { get; set; }

        /// <inheritDoc/>
        public virtual IEnumerable<string> GetNamespaces()
        {
            // Returning an unused namespace is ok. So just return it.
            yield return XmlNamespaces.Mrss;
            yield return XmlNamespaces.Dcterms;
        }
    }

    public class Channel
    {
        [XmlElement(ElementName = "title", Order = 1)]
        public string Title { get; set; }

        [XmlElement(ElementName = "link", Order = 2)]
        public string Link { get; set; }

        [XmlElement(ElementName = "description", Order = 3)]
        public string Description { get; set; }

        [XmlElement(ElementName = "item", Type = typeof(Item), Order = 4)]
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        [XmlElement(ElementName = "link", Order = 1)]
        public string Link { get; set; }

        [XmlElement(ElementName = "content", Type = typeof(MediaContent), Order = 2)]
        public List<MediaContent> Content { get; set; }
    }

    public class MediaContent
    {
        // Attributes for the Content tag
        [XmlAttribute("url")]
        public string Url { get; set; }

        [XmlAttribute("medium")]
        public string Medium { get; set; }

        [XmlAttribute("duration")]
        public string Duration { get; set; }


        // Sub elements of the Content tag 
        [XmlElement(ElementName = "title", Order = 1)]
        public Title Title { get; set; }

        [XmlElement(ElementName = "description", Order = 2)]
        public Description Description { get; set; }

        [XmlElement(ElementName = "player", Order = 3)]
        public Player Player { get; set; }

        [XmlElement(ElementName = "thumbnail", Order = 4)]
        public Thumbnail Thumbnail { get; set; }
    }

    public class Title
    {
        [XmlText]
        public string Title_ { get; set; }
    }

    public class Description
    {
        [XmlText]
        public string Description_ { get; set; }
    }

    public class Player
    {
        [XmlAttribute(AttributeName = "url")]
        public string PlayerUrl { get; set; }
    }

    public class Thumbnail
    {
        [XmlAttribute(AttributeName = "url")]
        public string ThumbnailUrl { get; set; }
    }
}
