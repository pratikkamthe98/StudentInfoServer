using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentInfo.Model;
using Microsoft.EntityFrameworkCore;

namespace StudentInfo.Context
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; }

    }
}
