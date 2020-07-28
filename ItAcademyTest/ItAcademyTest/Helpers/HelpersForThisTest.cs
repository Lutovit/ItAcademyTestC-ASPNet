using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ItAcademyTest.Models;
using ItAcademyTest.SomeLogic;


namespace ItAcademyTest.Helpers
{
    public static class HelpersForThisTest
    {
        public static MvcHtmlString ArrayHelper(this HtmlHelper html, int[] items)
        {
            TagBuilder ul = new TagBuilder("ul");
            foreach (int item in items)
            {
                TagBuilder li = new TagBuilder("li");
                li.SetInnerText(item.ToString());
                ul.InnerHtml += li.ToString();
            }
            return new MvcHtmlString(ul.ToString());
        }
    }
}