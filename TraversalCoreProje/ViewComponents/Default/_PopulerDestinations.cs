﻿using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _PopulerDestinations : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
