using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person)
            }
            return persons;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Alex",
                LastName = "Melo",
                Address = "RP - SP - BR",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }

        private Person MockPerson(object i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Name" + i,
                LastName = "Last Name" + i,
                Address = "ADDR - SP - BR" +i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
