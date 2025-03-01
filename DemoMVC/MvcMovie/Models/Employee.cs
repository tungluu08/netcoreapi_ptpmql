namespace MvcMovie.Models;

public class Employee : Person
{
    public string EmployeeId { get; set; } = string.Empty;
    public int Age { get; set; }
}