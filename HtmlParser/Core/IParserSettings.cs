using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlParser.Core
{
    interface IParserSettings
    {
        // здесь будет храниться ссылка сайта которую будем парсить
        string BaseUrl { get; set; }


        // 
        string Prefix { get; set; }

        // с какой страницы парсить данные
        int StartPoint { get; set; }

        // конечная страница для парсинга
        int EndPoint { get; set; }
    }
}
