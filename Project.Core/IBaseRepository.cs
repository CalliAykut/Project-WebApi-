﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core
{
    public interface IBaseRepository<T> where T : class
    {
        public List<T> List();
        public T Find(int Id);
        public T Find(int Id, int Id2);
        public bool Update(T entity);
        public bool Delete(T entity, int Id);
        public bool Add(T entity);
        public DbSet<T> Set();
    }
}
