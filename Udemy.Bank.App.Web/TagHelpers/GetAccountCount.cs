using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Linq;
using Udemy.Bank.App.Web.Data.Context;

namespace Udemy.Bank.App.Web.TagHelpers
{
    [HtmlTargetElement("getAccountCount")]
    public class GetAccountCount:TagHelper
    {
        public int ApplicationUserId { get; set; }
        private readonly BankContext _contex;
        public GetAccountCount(BankContext contex)
        {
            _contex = contex;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var accountCount = _contex.Accounts.Count(x =>x.ApplicationUserId==ApplicationUserId);
            var html = $"<span class='badge bg-danger'>{accountCount}</span>";
            //tag helper'da çıktı alabilmek için
            output.Content.SetHtmlContent(html);
        }
    }
}
