﻿using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Repository
{
    public interface IRepository<T> where T: BaseEntity
    {

        T Create(T item);

        T FindById(long id);

        T Update(T item);

        void Delete(long id);

        List<T> FindAll();

    }
}
