using System;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Portfolio.TagHelpers
{
    /*Personal Info Part*/
    [HtmlTargetElement("email")]
	public class EmailTagHelper : TagHelper
	{
		public required string Address { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", $"mailto:{Address}");
            output.Content.SetContent(Address);
        }
    }    
}

