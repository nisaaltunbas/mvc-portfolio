using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Portfolio.TagHelpers
{
    [HtmlTargetElement("tel")]
    public class TelTagHelper : TagHelper
    {
        public required string Number { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            string n = Regex.Replace(Number, @"[^\d\+]", "");
            output.Attributes.SetAttribute("href", $"tel:{n}");
            output.Content.SetContent(Number);
        }
    }

    

}

