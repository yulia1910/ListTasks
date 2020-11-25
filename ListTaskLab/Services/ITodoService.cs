using ListTaskLab.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListTaskLab.Services
{
    public interface ITodoService
    {
        List<ResponseData> returnTasks(string title);
        List<ResponseData> getAllTasks();
    }
}
