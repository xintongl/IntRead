using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IntRead
{
    public class WebQuery
    {
        public string Url { get; set; }

        public string Res { get; set; }

        public WebQuery(string url)
        {
            Url = url;
        }

        public void Execute()
        {
            if (Url == null)
            {
                return;
            }

            var request = WebRequest.Create(Url);
            var response = request.GetResponse();

            var stream = response.GetResponseStream();
            var reader = new StreamReader(stream);

            Res = reader.ReadToEnd();

            reader.Close();
            stream.Close();
            response.Close();
        }
    }
}
