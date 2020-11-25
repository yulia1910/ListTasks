using AutoMapper;
using ListTaskLab.Models;
using ListTaskLab.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListTaskLab.Repository
{
    public class Task : ITask
    {
        private readonly IMapper _mapper;
        public Task(IMapper mapper)
        {
            _mapper = mapper;
        }
        public List<ResponseData> returnTasks(string title)
        {
            List<Data> list = StoreAllTasks.listTasks.FindAll((task) => task.title.Contains(title));
            return _mapper.Map<List<ResponseData>>(list);
        }

        public List<ResponseData> returnAllTasks()
        {
            return _mapper.Map<List<ResponseData>>(StoreAllTasks.listTasks);
        }

    }
}
