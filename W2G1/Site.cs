using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2G1
{
    class Site
    {
        public string url;
        public static int cnt;
        public Site() { }
        public Site(string url)
        {
            this.url = url;
        }
        public void View()
        {
            cnt++;
        }
    }
}
