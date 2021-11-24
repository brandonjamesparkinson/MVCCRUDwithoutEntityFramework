using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCCRUDwithoutEntityFramework.Models;

namespace MVCCRUDwithoutEntityFramework.Data
{
    public class MVCCRUDwithoutEntityFrameworkContext : DbContext
    {
        public MVCCRUDwithoutEntityFrameworkContext (DbContextOptions<MVCCRUDwithoutEntityFrameworkContext> options)
            : base(options)
        {
        }

        public DbSet<MVCCRUDwithoutEntityFramework.Models.BookViewModel> BookViewModel { get; set; }
    }
}
