using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntRead
{
    public class BasePage
    {
        public string Url { get; set; }

        public string Raw { get; set; }

        public string Content { get; set; }

        public BasePage(string url)
        {
            Url = url;
            var query = new WebQuery(url);
            query.Execute();
            Raw = query.Res;

            ExtractContent();
            ParseContent();
        }

        protected virtual void ExtractContent() { }

        protected virtual void ParseContent() { }
    }
}
