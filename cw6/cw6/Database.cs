using cw6.Models;

namespace cw6;

public class Database
{
    public static List<Test> Tests = new List<Test>()
    {
        new Test() { Id = 1, Name = "test1" },
        new Test() { Id = 2, Name = "test2" },
        new Test() { Id = 3, Name = "test3" }
    };
}