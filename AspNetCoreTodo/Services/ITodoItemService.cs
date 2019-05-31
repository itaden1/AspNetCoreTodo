using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public interface ITodoItemService
    // interfaces define the properties, methods and events the inheriting class
    // should follow. It is up to the class itself to define the methods which the interface has declared
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();
        // task is similar to a future or promise in js and is asynchronous
    }
}