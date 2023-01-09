using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Api.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Number { get; set; }
        public DateTime? Dob { get; set; }
        public string? Gender { get; set; }
        public string? Designation { get; set; }
        public string? Description { get; set; }
    }
}
