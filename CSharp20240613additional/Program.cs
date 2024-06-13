
using System;

namespace CSharp20240613additional {

    internal class Program {
        static void Main(string[] args) {
            /*  int i = 0;

              List<string> strings = new List<string>();
              strings.Add("Pink");
              strings.Add("Red");
              strings.Add("Magenta");
              strings.Add("Burgundy");
              strings.Add("Black");

              strings.AddRange(new string[] { "Yellow", "Green" });
              //var count = strings.Count; //5

              Console.WriteLine("Enter your color here:");
              var color = Console.ReadLine();
              Console.ReadKey();
              if (!strings.Contains(color)) {
                  Console.WriteLine("Color already exists");
              } else {
                  strings.Add(color);
                  Console.WriteLine("Color Added");
              }
              strings.Add(color);
          }
      }           
  }*/
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Fred" });
            students.Add(new Student { Id = 2, Name = "Wilma" });
            students.Add(new Student { Id = 3, Name = "Barney" });
            Dictionary<int, Student> StudentDictionary = new Dictionary<int, Student>();
            foreach (var student in students) {
                StudentDictionary.Add(student.Id, student);
            }
        }
            internal class Student {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }

        }
   
           /* Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "one");
            dictionary.Add(22, "twenty-two");
            dictionary.Add(14, "fourteen");

            Console.WriteLine(dictionary[22]);

            )*/
