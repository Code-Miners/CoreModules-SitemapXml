using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Modules.Web.Sitemap.mRSSModel;

namespace Core.Modules.Web.Sitemap.Validation
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Xml;
    using System.Xml.Schema;
    using Model;
    using Serialization;

    public sealed class MrssSitemapValidator
    {
        public ValidationResult ValidateSitemap(MRssNode candidate)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer();
                string text = serializer.Serialize(candidate);

                XmlReaderSettings settings = new XmlReaderSettings();
                settings.Schemas.Add("http://search.yahoo.com/mrss/", new XmlTextReader(LoadSchema()));
                settings.ValidationEventHandler += ValidationEventHandler;
                settings.ValidationFlags = settings.ValidationFlags | XmlSchemaValidationFlags.ReportValidationWarnings;
                settings.ValidationType = ValidationType.Schema;

                XmlDocument document = new XmlDocument();
                XmlReader reader = XmlReader.Create(new StringReader(text), settings);
                document.Load(reader);

                document.Validate(ValidationEventHandler);

                return new ValidationResult(true, "ok");
            }
            catch (Exception ex)
            {
                return new ValidationResult(false, ex.Message);
            }
        }

        private TextReader LoadSchema()
        {
            TextReader textreader;
            using (StreamReader reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("Core.Modules.Web.Sitemap.Validation.MrssSitemapSchema.xsd")))
            {
                string xsd = reader.ReadToEnd();

                textreader = new StringReader(xsd);
            }

            return textreader;
        }

        private static void ValidationEventHandler(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning || args.Severity == XmlSeverityType.Error)
            {
                if (args.Exception != null)
                {
                    throw args.Exception;
                }

                throw new XmlSchemaException("There is an unknown problem with the document");
            }
        }
    }
}
