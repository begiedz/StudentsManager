namespace StudentsManager.Domain.Entities;

public class Student
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public required DateTime BirthDate { get; init; }
    public required int Grade { get; init; }
}
