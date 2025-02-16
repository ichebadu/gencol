using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace gencol.Views.Account
{
    public class VerifyEmail.cshtml : PageModel
    {
        private readonly ILogger<VerifyEmail.cshtml> _logger;

        public VerifyEmail.cshtml(ILogger<VerifyEmail.cshtml> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}