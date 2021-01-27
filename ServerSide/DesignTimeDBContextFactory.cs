using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ServerSide;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServerSideData
{
    class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CockTailsDBContext>
    {
        public CockTailsDBContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CockTailsDBContext>();
            builder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CockTailsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            return new CockTailsDBContext(builder.Options);
        }
    }
}