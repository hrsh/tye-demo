using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Frontend.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string Message { get; set; }

        public async Task<IActionResult> OnGetAsync([FromServices] WebClient webClient)
        {
            var result = await webClient.GetMessageAsync();
            Message = result ?? "nil";

            return Page();
        }
    }
}
