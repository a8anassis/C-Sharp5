using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowDeepCopies.Model
{
    internal class Student
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public Address? Address { get; set; }

        public Student GetCopyRef()
        {
            return this;
        }

        public Student GetShallowCopy()
        {
            return (Student) MemberwiseClone();
        }

        public Student GetDeepCopy()
        {
            Student student = (Student) MemberwiseClone();
            student.Address = new()
            {
                Street = Address?.Street,
                Number = Address?.Number,
                ZipCode = Address?.ZipCode
            };
            return student;
        }

        public Student(Student? student)
        {       
            Id = student!.Id;
            Firstname = student.Firstname;
            Lastname = student.Lastname;
            Address = new()
            {
                Street = student.Address?.Street,
                Number = student.Address?.Number,
                ZipCode = student.Address?.ZipCode
            };
        }

        
    }
}
