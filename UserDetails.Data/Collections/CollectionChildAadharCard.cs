using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDetails.Data.Model;

namespace UserDetails.Data.Collections
{
    public class CollectionChildAadharCard
    {
        public int Id { get; set; }
        public CTest CTestobj { get; set; }
        public List<Test> tests { get; set; }

      
    }
}
