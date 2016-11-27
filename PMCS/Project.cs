using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMCS
{
    class Project
    {
        public List<Requirement> requirements = new List<Requirement>();
        public String name;
        public Project(String name)
        {
            this.name = name;
        }

        public void addRequirement(Requirement req)
        {
            requirements.Add(req);
        }


    }
}
