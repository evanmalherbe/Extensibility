using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbMigrator dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();
        }
    }
}
