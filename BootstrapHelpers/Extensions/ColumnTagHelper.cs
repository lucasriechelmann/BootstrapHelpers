using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BootstrapHelpers.Extensions
{
    public class ColumnTagHelper : TagHelper
    {
        public int ExtraSmall { get; set; }
        public int Small { get; set; }
        public int Medium { get; set; }
        public int Large { get; set; }
        public int ExtraLarge { get; set; }
        const string COLUMN_EXTRA_SMALL = "col";
        const string COLUMN_SMALL = "col-sm";
        const string COLUMN_MEDIUM = "col-md";
        const string COLUMN_LARGE = "col-lg";
        const string COLUMN_EXTRA_LARGE = "col-xl";
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var content = await output.GetChildContentAsync();
            output.Attributes.SetAttribute("class", GetCssClass());
            output.Content.SetHtmlContent(content.GetContent());
        }
        string GetCssClass()
        {
            var classes = new List<string>();
            classes.Add(GetExtraSmall());
            classes.Add(GetSmall());
            classes.Add(GetMedium());
            classes.Add(GetLarge());
            classes.Add(GetExtraLarge());
            return string.Join(" ", classes.Where(x => x != ""));
        }

        string GetExtraSmall()
        {
            if (ExtraSmall <= 0)
                return "";

            if (ExtraSmall > 12)
                ExtraSmall = 12;

            return $"{COLUMN_EXTRA_SMALL}-{ExtraSmall}";
        }

        string GetSmall()
        {
            if (Small <= 0)
                return "";

            if (Small > 12)
                Small = 12;

            return $"{COLUMN_SMALL}-{Small}";
        }

        string GetMedium()
        {
            if (Medium <= 0)
                return "";

            if (Medium > 12)
                Medium = 12;

            return $"{COLUMN_MEDIUM}-{Medium}";
        }
        string GetLarge()
        {
            if (Large <= 0)
                return "";

            if (Large > 12)
                Large = 12;

            return $"{COLUMN_LARGE}-{Large}";
        }

        string GetExtraLarge()
        {
            if (ExtraLarge <= 0)
                return "";

            if (ExtraLarge > 12)
                ExtraLarge = 12;

            return $"{COLUMN_EXTRA_LARGE}-{ExtraLarge}";
        }
    }
}
