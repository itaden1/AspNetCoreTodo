using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreTodo.Services;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Controllers{
    public class TodoController : Controller
    {
        // read only property of type ITodoItemService
        private readonly ITodoItemService _todoItemService;

        // Public constructor method assigning value of type ITodoItemService to private
        // property defined above. Using an interface means any class can be passed as long
        // as it conforms to the defined interface
        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public async Task<IActionResult> Index()
        // IAction can return any response eg Http code, JSON, or a View
        {
            
            // Get data from the database service
            var items = await _todoItemService.GetIncompleteItemsAsync();
            
            // Put data from above into a model
            var model = new TodoViewModel()
            {
                Items = items
            };

            // Render a view using the model
            return View(model);
        }
    }
}