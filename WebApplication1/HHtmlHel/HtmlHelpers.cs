﻿using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using GameStore.WebUi.Models;

namespace GameStore.WebUi.HHtmlHel
{
    public static class PagingHelpers 
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html,
                                              PagingInfo pagingInfo,
                                                Func<int, string> pageUrl)
        {

            StringBuilder resurt = new StringBuilder();
            for (int i = 1; i <= pagingInfo.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();
                if (i == pagingInfo.CurrentPage)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                resurt.Append(tag.ToString());
            }
            return MvcHtmlString.Create(resurt.ToString());

        }
    }
}

