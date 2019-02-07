﻿using System.Collections.Generic;
using System.Threading.Tasks;
using DMACC.CIS174.Shared.ViewModels;

namespace DMACC.CIS174.Shared.Orchestrators.Interfaces
{
    public interface IStudentOrchestrator
    {
        Task<List<StudentViewModel>> GetAllStudents();
        Task<int> CreateStudent(StudentViewModel student);
        Task<bool> UpdateStudent(StudentViewModel student);
        Task<StudentViewModel> SearchStudent(string searchString);
    }
}
