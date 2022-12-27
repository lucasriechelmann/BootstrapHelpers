using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BootstrapHelpers.Extensions
{
    public class RowTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var content = await output.GetChildContentAsync();
            output.Attributes.SetAttribute("class", "row");
            output.Content.SetHtmlContent(content.GetContent());
        }
    }
}
