using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentSystem.Data.Context
{
    public class AppointmentSystemDbFactory : IDesignTimeDbContextFactory<AppointmentSystemContext>
    {
        public AppointmentSystemContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppointmentSystemContext>();
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=AppointmentSystemDB;Trusted_Connection=True;Integrated Security=True");

            return new AppointmentSystemContext(optionsBuilder.Options);
        }
    }
}
