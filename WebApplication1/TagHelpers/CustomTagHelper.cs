using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.TagHelpers
{
    public class CustomTagHelper:TagHelper
    {
        public string Name { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "CustomTag";
            string data = $"<span>Hi {Name}</span>";
            output.PreContent.SetHtmlContent(data);
            //base.Process(context, output);
        }
    }
    [HtmlTargetElement(tag:"div",Attributes ="Info")]
    public class DivTagHelper : TagHelper
    {
        public bool Info { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (Info)
            {
                output.TagName=("a");
                output.Attributes.Add("class", "btn btn-info");
            }
        }
    }
    public class CardTagHelper : TagHelper
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var card = new TagBuilder("div");
            card.AddCssClass("container");
            var sec1 = new TagBuilder("div");
            sec1.InnerHtml.Append(Name);
            card.InnerHtml.AppendHtml(sec1);
            output.SuppressOutput();
            output.Content.AppendHtml(card);
        }
    }
}
