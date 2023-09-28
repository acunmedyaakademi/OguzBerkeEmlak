using Emlak.WebUI.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Emlak.WebUI.Components
{
    public class PagerViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}
