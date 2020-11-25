using ListTaskLab.Models;
using ListTaskLab.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListTaskLab.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITask _getTodo;
        public TodoService(ITask getTodo)
        {
            _getTodo = getTodo;
        }

        public List<ResponseData> returnTasks(string title)
        {
            return _getTodo.returnTasks(title);
        }

        public List<ResponseData> getAllTasks()
        {
            return _getTodo.returnAllTasks();
        }
    }
}
