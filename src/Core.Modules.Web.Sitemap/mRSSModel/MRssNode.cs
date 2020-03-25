

namespace Core.Modules.Web.Sitemap.mRSSModel
{
    using Core.Modules.Web.Sitemap.Serialization;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using Core.Modules.Web.Sitemap.mRSSModel.Channels;

    [XmlRoot(ElementName = "rss", Namespace = XmlNamespaces.Sitemap)]
    public class MRssNode : IXmlNamespaceProvider
    {
        public MRssNode()
        {

        }

        public MRssNode(string version)
        {
            Version = version;
        }

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
}
