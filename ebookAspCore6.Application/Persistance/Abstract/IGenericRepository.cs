﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebookAspCore6.Application.Persistance.Abstract
{
    public interface IGenericRepository<T> where T:class
    {
        Task<T> GetById(int Id);
        Task<IReadOnlyList<T>> GetAll();
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
        
    }
}
