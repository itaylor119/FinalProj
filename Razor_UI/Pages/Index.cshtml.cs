using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PubsServiceBus;
using ViewModels;

namespace Razor_UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly ServiceBus _service;

        public IEnumerable<AuthorViewModel> Authors;

        public IndexModel(ILogger<IndexModel> logger,
            ServiceBus service)
        {
            _logger = logger;
            _service = service;
        }

        public void OnGet()
        {
            // web page asked for data
            Authors = _service.findAllAuthors();
        }

        public void OnPost()
        {
            // data arriving from web page
        }
    }
}
