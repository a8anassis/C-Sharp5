using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  HelloOOApp
{

    /// <summary>
    /// <c>School</c> POCO class.
    /// </summary>
    internal class School
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public SchoolType SchoolType { get; set; }

        public School()
        {
            
        }

        public School(int id, string? title, SchoolType schoolType)
        {
            Id = id;
            Title = title;
            SchoolType = schoolType;
        }

        public override string? ToString()
        {
            return $"{{ {Id} {Title} {SchoolType} }}";
        }

        public override bool Equals(object? obj)
        {
            return obj is School school &&
                   Id == school.Id &&
                   Title == school.Title &&
                   SchoolType == school.SchoolType;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Title, SchoolType);
        }

        public static bool operator ==(School? left, School? right)
        {
            return EqualityComparer<School>.Default.Equals(left, right);
        }


        public static bool operator !=(School? left, School? right)
        {
            return !(left == right);
        }
    }
}
