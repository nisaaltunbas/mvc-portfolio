using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Portfolio.TagHelpers
{
    /*Nav-Scroll Part*/
    [HtmlTargetElement("scroll-link")]
    public class ScrollLinkTagHelper : TagHelper
    {
        public string Href { get; set; }
        public string Text { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "li";
            output.Attributes.SetAttribute("class", "nav-item");

            var link = new TagBuilder("a");
            link.AddCssClass("nav-link js-scroll-trigger");
            link.Attributes.Add("href",Href);
            link.InnerHtml.Append(Text);

            output.Content.AppendHtml(link);

        }
    }

    

}

