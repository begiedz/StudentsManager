using StudentsManager.Domain.Entities;

namespace StudentsManager.Application.Interfaces;

public interface IStudentService
{
    Task<IReadOnlyList<Student>> GetAllAsync();
    Task<Student?> GetByIdAsync(Guid id);
    Task AddAsync(Student student);
    Task UpdateAsync(Student student);
    Task DeleteAsync(Guid id);
    double AvarageGrade();
}