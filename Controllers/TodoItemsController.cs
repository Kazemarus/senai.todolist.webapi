using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using senai.todolist.webapi.Models;

namespace senai.todolist.webapi.controllers
    {
        [Route("api/todoitems")]
        [ApiController]
        public class TodoItemsController : ControllerBase
        {
            private static List<TodoItem> todoItems =  new List<TodoItem>();
            [HttpGet]
            public IActionResult Get(){
                if (todoItems.Count == 0)
                    return NoContent();
                return Ok(todoItems);
            }

           [HttpPost]
           public IActionResult Post(TodoItem todoItem){

               todoItems.Add(todoItem);
                
                return Ok(todoItem);

           }

           [HttpGet("{id}")]
           public IActionResult Get(Guid id){

               int todoIndex = todoItems.FindIndex (t => t.id == id);

               if (todoIndex == -1)
                    return BadRequest(new {message = "Item não encontrado"});
                
                return Ok(todoItems[todoIndex]);
           }
           [HttpPut("{id}")]
           public IActionResult Put(Guid id, TodoItem todoItem){

               int todoIndex = todoItems.FindIndex (t => t.id == id);

               if (todoIndex == -1)
                    return BadRequest(new {message = "Item não encontrado"});
                
                    todoItems.Remove(todoItems[todoIndex]);
                return Ok(todoItems);
           } 

        }
    }