using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Airborne.Commander.AspNetCore.Models;

namespace Airborne.Commander.AspNetCore.TagHelpers
{
    [HtmlTargetElement("abc-rbf-code")]
    public class RbfCodeTagHelper : TagHelper
    {
        public ReadBeforeFlight rbf { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Content.SetHtmlContent($@"<strong>RBF-{rbf.Id:0000} {rbf.ShortDescription(20)}</strong>");
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}
