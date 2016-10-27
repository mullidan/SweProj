using System;
using System.Collections.Generic;

namespace ProjectModels.Model
{
    [Serializable]
    public enum RequirementType { Functional, NonFunctional }

    public interface IRequirement
    {
        RequirementType Type { get; set; }
        IList<ITask> Tasks { get; set; }
    }

    [Serializable]
    public class Requirement : IRequirement
    {
        public Requirement() : this(RequirementType.Functional) { }

        public Requirement(RequirementType type)
        {
            Type = type;
            Tasks = new List<ITask>();
        }

        public RequirementType Type { get; set; }
        public IList<ITask> Tasks { get; set; }
    }
}
