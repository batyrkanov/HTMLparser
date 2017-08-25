﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom.Html;

namespace HtmlParser.Core.OcKg
{
    class OsParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("title"));

            foreach(var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray();
        }
    }
}
