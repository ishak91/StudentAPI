using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAPI.Model;
using StudentAPI.Services;

namespace StudentAPI.DataAccess
{
    public class DataContext
    {

        private List<Student> _studentList = new List<Student>
        {
            new Student() {Id = 1, City = "Colombo", FirstName = "Kid", LastName = "Lupus"},
            new Student() {Id = 2, City = "Kandy", FirstName = "Roger ", LastName = "Flopple"},
            new Student() {Id = 3, City = "Negambo", FirstName = "Flip", LastName = "Jupiter"},
            new Student() {Id = 4, City = "Jaffna", FirstName = "Silk", LastName = "Teddy"},
            new Student() {Id = 5, City = "Gampaha", FirstName = "Max", LastName = "Colorado"},


        };


        public IEnumerable<Student> Student => _studentList;
    }
}
