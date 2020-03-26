//-----------------------------------------------------------------------
// <copyright file="VideoNode.cs" company="Code Miners Limited">
//  The MIT License(MIT)
//
//  Copyright(c) 2013 Ufuk Hacıoğulları and contributors
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy of
//  this software and associated documentation files (the "Software"), to deal in
//  the Software without restriction, including without limitation the rights to
//  use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
//  the Software, and to permit persons to whom the Software is furnished to do so,
//  subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
//  FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
//  COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
//  IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
//  CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
//-----------------------------------------------------------------------

namespace Core.Modules.Web.Sitemap.Model.NodeTypes.Video
{
    using System.Xml.Serialization;

    /// <summary>
    /// Encloses all information Required about a single Video
    /// </summary>
    public sealed class VideoNode
    {
        public VideoNode()
        {

        }

        public VideoNode(string url)
        {
            Url = url;
        }

        /// <summary>
        /// The URL of the image
        /// </summary>
        [XmlElement("loc", Order = 1)]
        public string Url { get; set; }

        /// <summary>
        /// The URL pointing to the video thumbnail image file.
        /// </summary>
        [XmlElement("thumbnail_loc", Order = 3)]
        public string ThumbnailLoc { get; set; }

        /// <summary>
        /// The title of the video
        /// </summary>
        [XmlElement("title", Order = 4)]
        public string Title { get; set; }

        /// <summary>
        /// The description of the video
        /// </summary>
        [XmlElement("description", Order = 5)]
        public string Description { get; set; }


        /// <summary>
        /// The URL pointing to the action video media file
        /// </summary>
        [XmlElement("content_loc", Order = 6)]
        public string ContentLoc { get; set; }

        /// <summary>
        /// The URL pointing to a player for a the video
        /// </summary>
        [XmlElement("player_loc", Order = 7)]
        public string PlayerLoc { get; set; }
        
        /// <summary>
        /// The duration of the video in seconds (1 to 28800)
        /// </summary>
        [XmlElement("duration", Order = 8)]
        public string Duration { get; set; }

        /// <summary>
        /// The date at which Google will not show your video. Format (YYYY-MM-DD) || (YYYY-MM-DDThh:mm:ss+TZD)
        /// </summary>
        [XmlElement("expiration_date", Order = 9)]
        public string ExpireDate { get; set; }

        /// <summary>
        /// The rating of the video. (0.0 LOW, 5.0 HIGH)
        /// </summary>
        [XmlElement("rating", Order = 10)]
        public string Rating { get; set; }

        /// <summary>
        /// The number of views the video has had
        /// </summary>
        [XmlElement("view_count", Order = 11)]
        public string ViewCount { get; set; }

        /// <summary>
        /// The date the video was first published. Format (YYYY-MM-DD) || (YYYY-MM-DDThh:mm:ss+TZD)
        /// </summary>
        [XmlElement("publication_date", Order = 12)]
        public string PubDate { get; set; }

        /// <summary>
        /// 'yes' available with SafeSearch on, 'no' available with SafeSearch off.
        /// </summary>
        [XmlElement("family_friendly", Order = 13)]
        public string FamFriendly { get; set; }

        /// <summary>
        /// Restriction from specific countries, see above class.
        /// </summary>
        [XmlElement("restriction", Order = 14)]
        public Restrict Restrict { get; set; }

        /// <summary>
        /// Restricted from specific platforms, see about class.
        /// </summary>
        [XmlElement("platform", Order = 15)]
        public Platform Platform { get; set; }

        /// <summary>
        /// The Price of the Movie, see above class.
        /// </summary>
        [XmlElement("price", Order = 16)]
        public Price Price { get; set; }

        /// <summary>
        /// The videos subscription, yes or no.
        /// </summary>
        [XmlElement("requires_subscription", Order = 17)]
        public string RequirSub { get; set; }

        /// <summary>
        /// The uploader of the videos details.
        /// </summary>
        [XmlElement("uploader", Order = 18)]
        public Uploader Uploader { get; set; }

        /// <summary>
        /// The indication if the video is live streamed.
        /// </summary>
        [XmlElement("live", Order = 19)]
        public string LiveVideo { get; set; }

        /// <summary>
        /// The Description tags for the video.
        /// </summary>
        [XmlElement("tag", Order = 20)]
        public string Tag { get; set; }

        /// <summary>
        /// The short description of the broad categories this video belongs to.
        /// </summary>
        [XmlElement("category", Order = 21)]
        public string CategoryDesc { get; set; }

    }
}
