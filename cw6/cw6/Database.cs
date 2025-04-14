using cw6.Models;

namespace cw6;

public class Database
{
    public static List<Animal> Tests = new List<Animal>()
    {
        new Animal() { Id = 1, Name = "puszek1", Kategoria = "Pies", Masa  = 20,kolorSiersci="biały"},
        new Animal() { Id = 2, Name = "puszek2", Kategoria = "Pies", Masa  = 20,kolorSiersci="czarny" },
        new Animal() { Id = 3, Name = "puszek3", Kategoria = "Pies", Masa  = 20,kolorSiersci="szary" }
    };

    public static List<Visit> TestVisits = new List<Visit>()
    {

    };
}