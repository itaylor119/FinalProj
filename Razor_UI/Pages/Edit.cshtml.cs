using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using PubsServiceBus;
using Model;

namespace Razor_UI.Pages
{
    public class EditModel : PageModel
    {
        private readonly ServiceBus _service;

        public Author author { get; set; }

        public EditModel(ServiceBus service)
        {
            _service = service;
        }

        public void OnGet(string aid)
        {
            //author = _service.findAuthor(aid); // add this method to servicebus
        }

        public void OnPost()
        {

        }
    }
}
