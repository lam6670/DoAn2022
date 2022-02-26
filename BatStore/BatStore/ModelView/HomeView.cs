using BatStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatStore.ModelView
{
    public class HomeView // HomeViewVM
    {
        public List<ProductHomeView> Products { get; set; }
        public Category Categories { get; set; }
        //public List<TinDang> Tintucs { get; set; }
    }
}
