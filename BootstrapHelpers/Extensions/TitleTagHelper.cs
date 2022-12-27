using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstrapHelpers.Extensions
{
    public class TitleTagHelper : TagHelper
    {
        public int Type { get; set; }
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = $"h{GetTitleType()}";
            var content = await output.GetChildContentAsync();
            //output.Attributes.SetAttribute("class", "container");
            output.Content.SetHtmlContent(content.GetContent());
        }

        int GetTitleType()
        {
            if (Type <= 0) return 1;
            if (Type > 6) Type = 6;
            return Type;
        }
    }
}
