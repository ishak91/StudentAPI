using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAPI.DataAccess;
using StudentAPI.Model;

namespace StudentAPI.Services
{
    public interface IStudentService
    {
        public List<Student> GetAll();
        public Student GetById(int studentId);
    }
    public class StudentService : IStudentService
    {
        private readonly DataContext _context;

        public StudentService(DataContext context)
        {
            _context = context;
        }
        public List<Student> GetAll()
        {
            return _context.Student.ToList();
        }

        public Student GetById(int studentId)
        {
            return _context.Student.SingleOrDefault(s => s.Id == studentId);
        }
    }

   
}
