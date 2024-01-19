using Microsoft.AspNetCore.Mvc;

namespace project3.Views.Shared.Components.SearchBar
{
    public class SearchBarViewComponent : ViewComponent
    {
        public SearchBarViewComponent()
        { 
        }

        public IViewComponentResult Invoke(SPager SearchPager, bool BottomBar = false)
        {
            if(BottomBar==true)
            {
                return View("bottomBar", SearchPager);
            }
            else
            {
                return View("default", SearchPager);
            }
            
        }
    }
}
