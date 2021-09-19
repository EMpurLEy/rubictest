using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rubictest.Controllers
{
    public class DbContext
    {
        private DbContextOptions<BudgetContext> options;

        public DbContext(DbContextOptions<BudgetContext> options)
        {
            this.options = options;
        }
    }
}
