using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntRead;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntRead.Tests
{
    [TestClass()]
    public class ArticlePageTests
    {
        [TestMethod()]
        public void ArticlePageTest()
        {
            var fakeUrl = "http://mp.weixin.qq.com/s?timestamp=1489929493&src=3&ver=1&signature=j5iuKbKjnGMvbOU*ysO7T52rx26d0UQRyeTTcW1K4dxOvFMteZbvV*mV*oJ9BSMQI2l4UiDPLWtOdDn88y7rhg*MAuoZQY9kBJYgQcxdnFX0--H-8cZqgMuT9DxrPqnvyUozQmCOLe04BUUgdlgRngHtm-v8n2gvGS8Saxc96OU=";
            var article = new ArticlePage(fakeUrl);
            Assert.IsNotNull(article.Content);
        }
    }
}