﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelloOOApp
{

    /// <summary>
    /// Plain Old CLR Object (POCO).
    /// </summary>
    internal class Student
    {
        private int _id;
        private string? _firstname;
        private string? _lastname;

        public Student()
        {

        }

        public Student(int id, string? firstname, string? lastname)
        {
            _id = id;
            _firstname = firstname;
            _lastname = lastname;
        }

        /* public int Id { get { return _id; } set { _id = value; } }
         public string? Firstname { get { return _firstname; } set { _firstname = value; } }
         public string? Lastname { get { return _lastname; } set { _lastname = value; } }*/

        public int Id { get => _id; set => _id = value; }
        public string? Firstname { get => _firstname; set => _firstname = value;  }
        public string? Lastname { get => _lastname; set => _lastname = value; } 

    }
}
