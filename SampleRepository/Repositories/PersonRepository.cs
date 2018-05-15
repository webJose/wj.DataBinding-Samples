using SampleRepository.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleRepository.Repositories
{
    public static class PersonRepository
    {
        public static List<Person> GetAll()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person() { Id = 1, FirstName = "Ingrid", LastName = "Valderrama" });
            persons.Add(new Person() { Id = 2, FirstName = "Adriana", LastName = "Cambronero" });
            persons.Add(new Person() { Id = 3, FirstName = "Antonio", LastName = "Jara" });
            persons.Add(new Person() { Id = 4, FirstName = "Jose", LastName = "Ramírez" });
            persons.Add(new Person() { Id = 5, FirstName = "María", LastName = "Vargas" });
            return persons;
        }
    }
}
