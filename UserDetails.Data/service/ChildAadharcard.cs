using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDetails.Data.Collections;
using UserDetails.Data.Model;

namespace UserDetails.Data.service
{
    public class ChildAadharcard
    {
        List<CollectionChildAadharCard> children;
        public ChildAadharcard()
        {
            children = new List<CollectionChildAadharCard>()
            { 
                new CollectionChildAadharCard
                {   Id = 1, 
                    CTestobj = new CTest{CAge = 1,CDescription = "ABC" , CName="XYZ" }, 
                    tests = new List<Test>(){ new Test {CAge = 50, CName = "QWE",CDescription="POQ", TName="Ravi", Id=1}} 
                },
                 new CollectionChildAadharCard
                {   Id = 2,
                    CTestobj = new CTest{CAge = 2,CDescription = "DABC" , CName="XYZ" },
                    tests = new List<Test>(){ new Test {CAge = 50, CName = "QWE",CDescription="POQ", TName="Akash", Id=1}}
                }
            };
        }
        public IEnumerable<CollectionChildAadharCard> GetAll()
        {
            return children;
        }
        public CollectionChildAadharCard GetChild(int id) 
        {
            return children.FirstOrDefault(e=>e.Id ==id);
        }

    }
}
