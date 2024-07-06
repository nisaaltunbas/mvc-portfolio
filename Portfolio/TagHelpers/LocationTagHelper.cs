using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Portfolio.TagHelpers
{
    [HtmlTargetElement("location")]
    public class LocationTagHelper : TagHelper
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("class", "google-map-link");
            output.Attributes.SetAttribute("href", $"https://google.com/maps?q={Latitude},{Longitude}");
            output.Content.SetContent("3542 Berry Street · Cheyenne Wells, CO 80810");
        }
    }

    

}

