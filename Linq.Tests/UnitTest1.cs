using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace LinQExerc.Test;

public class PersonTests
    {
        private List<Person> people = new List<Person>();

       /* public PersonTests() {
            Setup();
        } */

        [SetUp]
        public void Setup()
        {
            people = new List<Person> {
                new Person { Name = "João", Age = 30, City = "São Paulo" },
                new Person { Name = "Paulo", Age = 29, City = "Belo Horizonte" },
                new Person { Name = "José", Age = 32, City = "Rio de Janeiro" },
                new Person { Name = "Joaquim", Age = 27, City = "Vitória" },
                new Person { Name = "Joberson", Age = 35, City = "Curitiba" },
                new Person { Name = "Jobercleide", Age = 15, City = "Florianópolis" },
                new Person { Name = "Jobercleia", Age = 12, City = "Cuiabá" },
                new Person { Name = "Joberneide", Age = 17, City = "Campo Grande" }
            };
        }

        [Test]
        public void TestAdults()
        {
            var adults = people.Where(person => person.Age >= 18);
            Assert.AreEqual(5, adults.Count());
        }

        [Test]
        public void TestOrderByAge()
        {
            var orderedByAge = people.OrderBy(person => person.Age);
            Assert.AreEqual("Jobercleia", orderedByAge.First().Name);
        }

        [Test]
        public void TestGroupByCity()
        {
            var groupByCity = people.GroupBy(person => person.City);
            Assert.AreEqual(8, groupByCity.Count());
        }
}