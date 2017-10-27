using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Airborne.Commander.AspNetCore.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string Address { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + Address);
            var childContent = (await output.GetChildContentAsync()).GetContent();
            var elementContent = String.IsNullOrWhiteSpace(childContent) ? Address : childContent;

            output.Content.SetContent(elementContent);
        }
    }
}
