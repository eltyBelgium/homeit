using System;
using System.Data.Entity;
using Microsoft.Extensions.Configuration;

namespace HomeIt.Db
{
   
    public class DataContext : DbContext    
    {
        string connectionString = Configuration.GetConnectionString("myConnectionString");
    }
}
