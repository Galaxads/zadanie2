using AvaloniaApplication6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication6
{
    internal class SavingDate
    {
        public static List<Product> products = Helper.defaultDbContext.Products.ToList();
        public static List<Manuf> manufactrur = Helper.defaultDbContext.Manufs.ToList();
        public static List<int> tag=[];
    }
}
