using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIdemo.Models;

namespace WebAPIdemo.Data
{

    public class RepositoryStudents:IRepositoryStudents
    {
        private readonly StudentDbContext context;

        public RepositoryStudents(StudentDbContext _context)
        {
            context = _context;
        }

        public async Task<Student> CreateStudent(Student student)
        {
            if(student != null)
            {
               
                await context.Students.AddAsync(student);
                await context.SaveChangesAsync();
                return student;
            }
            return student;

        }

        public async Task<Student> GetStudent(int id)
        {
            return await context.Students.FindAsync(id);
       
        }

        public IEnumerable<Student> GetStudents()
        {
            return context.Students;
        }

        public async Task<Student> RemoveStudent(int id)
        {
            var student = await context.Students.FindAsync(id);
            if(student != null)
            {
                context.Students.Remove(student);
                await context.SaveChangesAsync();
            }
            return student;
        }
    }
}
