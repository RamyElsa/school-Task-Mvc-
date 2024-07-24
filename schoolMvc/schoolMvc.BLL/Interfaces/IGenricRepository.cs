﻿using schoolMvc.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolMvc.BLL.Interfaces
{
    public interface IGenricRepository<T> where T : ApplicationUser
    {


        Task<IEnumerable<T>> GetAll();
        Task<T> Get(string id);


    }
}
