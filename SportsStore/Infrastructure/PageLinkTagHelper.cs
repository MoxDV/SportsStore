using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc;
using SportsStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory _urlHelper;

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public PagingInfo PagingInfo { get; set; }

        public string PageAction { get; set; }

        public PageLinkTagHelper(IUrlHelperFactory urlHelper) {
            _urlHelper = urlHelper;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output) {
            var _url = _urlHelper.GetUrlHelper(ViewContext);
            var _div = new TagBuilder("div");
            for(int i = 0; i <= PagingInfo.TotalPages; i++) {
                var _a = new TagBuilder("a");
                _a.Attributes["href"] = _url.Action(PageAction, new { page = i });
                _a.InnerHtml.Append(i.ToString());
                _div.InnerHtml.AppendHtml(_a);
            }
            output.Content.AppendHtml(_div.InnerHtml);
        }
    }
}
