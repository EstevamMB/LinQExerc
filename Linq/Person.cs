namespace LinQExerc;

public class Person {

    public string Name {get; set;}
    public int Age {get; set;}
    public string City {get; set;}

    public Person() {
        Name = string.Empty;
        City = string.Empty;
    }

    public static void Main(string[] args) {
    
        //Criando a lista
        List<Person> people = new List<Person> {

            new Person {Name = "João", Age = 30, City = "São Paulo"},
            new Person {Name = "Paulo", Age = 29, City = "Belo Horizonte"},
            new Person {Name = "José", Age = 32, City = "Rio de Janeiro"},
            new Person {Name = "Joaquim", Age = 27, City = "Vitória"},
            new Person {Name = "Joberson", Age = 35, City = "Curitiba"},
            new Person {Name = "Jobercleide", Age = 15, City = "Florianópolis"},
            new Person {Name = "Jobercleia", Age = 12, City = "Cuiabá"},
            new Person {Name = "Joberneide", Age = 17, City = "Campo Grande"},
        };

        //utilizando linq para verificar maiores de 18 anos
        var adults = from person in people where person.Age >= 18 select person;

        //ordenando por idade
        var orderedByAge = from person in people orderby person.Age select person;

        //ordenando por cidade
        var groupByCity = from person in people group person by person.City;
    }    

}
