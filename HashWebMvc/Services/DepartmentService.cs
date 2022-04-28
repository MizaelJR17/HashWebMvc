using HashWebMvc.Models;
using HashWebMvc.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HashWebMvc.Services
{
    public class DepartmentService
    {

        private readonly HashWebMvcContext _context;

        public DepartmentService(HashWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

    }
}
