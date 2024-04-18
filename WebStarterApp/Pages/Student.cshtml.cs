using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebStarterApp.DTO;
using WebStarterApp.Model;

namespace WebStarterApp.Pages
{
    public class StudentModel : PageModel
    {
        public List<StudentReadOnlyDTO>? StudentReadOnlyDTOs { get; set; } = new();
        public List<Student>? Students { get; set; } = new();

        public IActionResult OnGet()
        {
            ViewData["Title"] = "Coding Factory Students";

            if (Request.Query.TryGetValue("lastname", out var lastname))
            {
                if (lastname == "Androutsos")
                {
                    Students = new()
                    {
                        new Student()
                        {
                            Id = 1,
                            Firstname = "Athana",
                            Lastname = "Androutsos"
                        }
                    };
                }
            }
            else
            {
                Students = new()
                    {
                        new Student()
                        {
                            Id = 1,
                            Firstname = "Athana",
                            Lastname = "Androutsos"
                        },
                        new Student()
                        {
                            Id = 2,
                            Firstname = "Anna",
                            Lastname = "Androutsos"
                        },
                        new Student()
                        {
                            Id = 1,
                            Firstname = "Makis",
                            Lastname = "Kapetis"
                        }
                    };
            }

            foreach (var student in Students!)
            {
                StudentReadOnlyDTOs!.Add(MapToDTO(student)!);
            }

            return Page();
        }

        private StudentReadOnlyDTO? MapToDTO(Student? student)
        {
            return new StudentReadOnlyDTO()
            {
                Id = student!.Id,
                Firstname = student.Firstname,
                Lastname = student.Lastname
            };
        }
    }
}
