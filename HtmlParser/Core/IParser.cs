using AngleSharp.Dom.Html;

namespace HtmlParser.Core
{

    interface IParser<T> where T : class
    {

        T Parse(IHtmlDocument document); 


    }
}
