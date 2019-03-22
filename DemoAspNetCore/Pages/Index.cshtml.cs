﻿using DemoAspNetCore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoAspNetCore.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public Customer Customer { get; set; }
    }
}