using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntRead
{
    public class ArticlePage : BasePage
    {
        public ArticlePage(string url) : base(url) { }

        protected override void ExtractContent()
        {
            base.ExtractContent();

            var posBegin = Raw.IndexOf("<div id=\"img-content\" class=\"rich_media_area_primary\">");
            var posEnd = Raw.IndexOf("<div class=\"rich_media_area_primary sougou\" id=\"sg_tj\" style=\"display:none\">");

            var tmpStr = Raw.Substring(posBegin, posEnd - posBegin);
            tmpStr.Trim(new char[] { ' ' });

            Content = tmpStr;
        }

        protected override void ParseContent()
        {
            base.ParseContent();
        }
    }
}
