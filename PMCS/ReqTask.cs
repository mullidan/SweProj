using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMCS
{
    class ReqTask
    {
        String taskName, discription, parentRequirement, taskType, estimatedEffort, appliedEffort;
        DateTime dueDate;
        public ReqTask(String name, String description, String parentRequirement, String type, 
            DateTime dueDate, String estimatedEffort, String appliedEffort)
        {
            taskName = name;
            discription = description;
            this.parentRequirement = parentRequirement;
            taskType = type;
            this.dueDate = dueDate;
            this.estimatedEffort = estimatedEffort;
            this.appliedEffort = appliedEffort;
        }
    }
}
