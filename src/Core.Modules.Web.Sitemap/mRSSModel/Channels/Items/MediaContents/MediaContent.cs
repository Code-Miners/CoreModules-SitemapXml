

namespace Core.Modules.Web.Sitemap.mRSSModel.Channels.Items.MediaContents
{
    using System.Xml.Serialization;
    using Core.Modules.Web.Sitemap.mRSSModel.Channels.Items.MediaContents.Media;
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
}
