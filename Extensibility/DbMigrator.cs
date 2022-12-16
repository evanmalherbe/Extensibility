using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at: " + DateTime.Now);

            // Details of migrating db

            _logger.LogInfo("Migration stopped at: " + DateTime.Now);
            
        }
    }
}
