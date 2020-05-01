using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIdemo.Models;

namespace WebAPIdemo.Data
{
    public interface IRepositoryStudents
    {
        IEnumerable<Student> GetStudents();
        Task<Student> GetStudent(int id);
        Task<Student> CreateStudent(Student student);
        Task<Student> RemoveStudent(int id);

    }
}
