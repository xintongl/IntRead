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
    public class WebQueryTests
    {
        [TestMethod()]
        public void WebQueryTest()
        {
            var fakeUrl = "http://weixin.sogou.com/";
            var query = new WebQuery(fakeUrl);
            query.Execute();
            var res = query.Res;
            StringAssert.Contains(res, "<html>");
        }
    }
}