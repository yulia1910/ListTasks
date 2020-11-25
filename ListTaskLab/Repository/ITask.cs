using ListTaskLab.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListTaskLab.Repository
{
    public interface ITask
    {
        List<ResponseData> returnTasks(string title);
        List<ResponseData> returnAllTasks();
    }
}
