﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ToDoListApp
{
    class TodoListViewModel
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }
        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();
            TodoItems.Add(new TodoItem("todo 1", false));
            TodoItems.Add(new TodoItem("todo 2", false));
            TodoItems.Add(new TodoItem("todo 3", false));
        }
    }
}