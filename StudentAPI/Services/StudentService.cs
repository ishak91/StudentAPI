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
        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetById(int studentId)
        {
            throw new NotImplementedException();
        }
    }

   
}
