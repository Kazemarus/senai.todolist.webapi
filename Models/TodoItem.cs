using System;

namespace senai.todolist.webapi.Models
{
    public class TodoItem
    {
    public TodoItem()
    {
        id = Guid.NewGuid();
    }
    public Guid id {get; private set;}
    public string Nome {get; set;}
    public DateTime DataEntrega {get; set;}
    public bool Completa {get; set;}
    }

}