using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Portfolio.TagHelpers
{
    /*Icon Part*/
    [HtmlTargetElement("social-icon")]
    public class IconTagHelper : TagHelper
    {
        public string IconType { get; set; }
        public string Href { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("class", "social-icon");
            output.Attributes.SetAttribute("href", Href);

            var icon = new TagBuilder("i");
            icon.AddCssClass($"fab fa-{IconType}");

            output.Content.AppendHtml(icon);
        }
    }

    

}

