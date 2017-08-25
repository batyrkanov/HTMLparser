using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlParser.Core.OcKg
{
    class OsSettings : IParserSettings
    {
        public OsSettings (int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }
        public string BaseUrl { get; set; } = "oc.kg";
        public string Prefix { get; set; } = "page/{CurrentId}";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}
