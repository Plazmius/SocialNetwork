using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web.Mvc;

namespace Njinx.Service.Tools
{
    public static class HtmlButtonExtension
    {

        public static MvcHtmlString Button(this HtmlHelper helper,
                                           string innerHtml,
                                           object htmlAttributes)
        {
            return Button(helper, innerHtml,
                          HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes)
            );
        }

        public static MvcHtmlString Button(this HtmlHelper helper,
                                           string innerHtml,
                                           IDictionary<string, object> htmlAttributes)
        {
            var builder = new TagBuilder("button");
            builder.InnerHtml = innerHtml;
            builder.MergeAttributes(htmlAttributes);
            return MvcHtmlString.Create(builder.ToString());
        }

        public static byte[] ToBytes(this Image image, ImageFormat format)
        {
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, format);
            return memoryStream.ToArray();
        }
    }
}