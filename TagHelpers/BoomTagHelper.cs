using System;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;
using System.Text;

namespace Airborne.Commander.AspNetCore.TagHelpers
{
    public class BoomTagHelper : TagHelper
    {
        public int TickTock { get; set; }
        public string Bang { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";

            output.Attributes.SetAttribute("href", "#" + TickTock);
            var childContent = (await output.GetChildContentAsync()).GetContent();
            output.Content.SetHtmlContent($"{Countdown(TickTock)}...{(String.IsNullOrEmpty(Bang) ? "BANG" : Bang)}<br /><strong>{childContent}</strong>");
        }

        private string Countdown(int Start)
        {
            var countdown = new StringBuilder();

            for (int i = Start; i > 0; i--)
            {
                countdown.Append(i).Append(", ");
            }
            countdown.Append(0);

            return countdown.ToString();
        }
    }
}
