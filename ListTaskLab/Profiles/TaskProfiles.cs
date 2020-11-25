using AutoMapper;
using ListTaskLab.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListTaskLab.Profiles
{
    public class TaskProfile : Profile
    {
        public TaskProfile()
        {
            CreateMap<Data, ResponseData>();
        }
    }
}
