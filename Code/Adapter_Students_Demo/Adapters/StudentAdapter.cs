using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter_Students_Begin.ViewModels;
using Structural_Models;

namespace Adapter_Students_Begin.Adapters
{
    class StudentAdapter
    {
        public List<StudentViewModel> ConvertToViewModelList(IEnumerable<Student> students)
        {
            var studentsVMs = new List<StudentViewModel>();
            foreach (var student in students)
            {
                studentsVMs.Add(new StudentViewModel(student.Id, student.Name, student.Surname));
            }
            return studentsVMs;
        }
    }
}
