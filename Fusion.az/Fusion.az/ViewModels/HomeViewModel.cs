using Fusion.az.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fusion.az.ViewModels
{
    public class HomeViewModel
    {
        public List<Feature> Features { get; set; }
        public List<Header> Headers { get; set; } 
        public List<FunFact> FunFacts { get; set; }
        public List<Course> Courses { get; set; }
    }
}
