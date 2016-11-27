using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMCS
{
    class Requirement
    {
        String type, description, effortMisc, effortAnalysis, effortDesign, effortImpl, effortTest, effortManage;
        List<ReqTask> tasks = new List<ReqTask>();
        public Requirement(String type, String description, String effortMisc, String effortAnalysis, String effortDesign, 
            String effortImpl, String effortTest, String effortManage)
        {
            this.type = type;
            this.description = description;
            this.effortMisc = effortMisc;
            this.effortManage = effortManage;
            this.effortAnalysis = effortAnalysis;
            this.effortDesign = effortDesign;
            this.effortImpl = effortImpl;
            this.effortTest = effortTest;
        }
        public void addTask(ReqTask task)
        {
            tasks.Add(task);
        }
    }
}
