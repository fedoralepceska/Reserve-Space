﻿using Homework.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Repository.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(Guid? id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
