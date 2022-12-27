using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstrapHelpers.Extensions
{
    public class ContainerTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var content = await output.GetChildContentAsync();
            output.Attributes.SetAttribute("class", "container");
            output.Content.SetHtmlContent(content.GetContent());
        }
    }
}
