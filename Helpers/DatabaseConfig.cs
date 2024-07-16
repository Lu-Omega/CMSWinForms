using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSWinForms.Helpers
{
    public static class DatabaseConfig
    {
        public static string ConnectionString { get; } = "Server=Thando-LT\\SQLEXPRESS;Database=PRISM;Trusted_Connection=True;";
        public static string TestConnectionString { get; } = "Server=Thando-LT\\SQLEXPRESS;Database=PRISM_Test;Trusted_Connection=True;";
    }
}

