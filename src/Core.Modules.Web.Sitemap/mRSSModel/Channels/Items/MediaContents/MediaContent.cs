

namespace Core.Modules.Web.Sitemap.mRSSModel.Channels.Items.MediaContents
{
    using System.Xml.Serialization;
    using Core.Modules.Web.Sitemap.mRSSModel.Channels.Items.MediaContents.Media;
    public class MediaContent
    {
        // Attributes for the Content tag
        [XmlAttribute("url")]
        public string ContentUrl { get; set; }

        [XmlAttribute("medium")]
        public string ContentMedium { get; set; }

        [XmlAttribute("filesize")]
        public string ContentFileSize { get; set; }

        [XmlAttribute("type")]
        public string ContentType { get; set; }

        [XmlAttribute("duration")]
        public string ContentDuration { get; set; }

        [XmlAttribute("height")]
        public string ContentHeight { get; set; }

        [XmlAttribute("width")]
        public string ContentWidth { get; set; }

        [XmlAttribute("lang")]
        public string ContentLang { get; set; }


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
}
