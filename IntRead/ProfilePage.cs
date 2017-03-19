using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntRead
{
    public class ProfilePage : BasePage
    {
        public MsgList MsgList { get; set; }

        public ProfilePage(string url) : base(url) { }
        
        protected override void ExtractContent()
        {
            base.ExtractContent();

            var posBegin = Raw.IndexOf("var msgList =");
            var posEnd = Raw.IndexOf("seajs.use(");

            if (posBegin == -1 || posEnd == -1) {
                return;
            }

            var msgListStr = Raw.Substring(posBegin, posEnd - posBegin);
            msgListStr = msgListStr.Replace("var msgList = ", "");
            msgListStr = msgListStr.TrimStart(new char[] { ' ' });
            msgListStr = msgListStr.TrimEnd(new char[] { ';', ' ', '\r', '\n' });

            Content = msgListStr;
        }

        protected override void ParseContent()
        {
            base.ParseContent();

            MsgList = JsonConvert.DeserializeObject<MsgList>(Content);
        }
    }

    public class MsgList {
        public IList<MsgItem> Items => list;

        public IList<MsgItem> list;
    }

    public class MsgItem
    {
        public string Title => app_msg_ext_info.title;

        public string ArticleUrl => app_msg_ext_info.content_url;

        public string CoverUrl => app_msg_ext_info.cover;

        public string Author => app_msg_ext_info.author;

        public string Digest => app_msg_ext_info.digest;

        public MsgInfo app_msg_ext_info;
    }

    public class MsgInfo
    {
        public string author;
        public string content_url;
        public string cover;
        public string digest;
        public string source_url;
        public string title;
    }
}
