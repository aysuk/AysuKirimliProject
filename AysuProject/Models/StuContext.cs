using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AysuProject.Models
{
    public class StuContext : DbContext
    {
        public StuContext(DbContextOptions<StuContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}