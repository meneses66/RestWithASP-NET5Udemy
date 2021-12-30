﻿using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Business
{
    public interface IPersonBusiness
    {

        Person Create(Person person);

        Person FindById(long id);

        Person Update(Person person);

        void Delete(long id);

        List<Person> FindAll();

        bool Exists(long id);
    }
}
