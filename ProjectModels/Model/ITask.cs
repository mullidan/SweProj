using System;
using System.Collections.Generic;
using ProjectModels.Model;

namespace ProjectModels
{
    /// <summary>
    /// A task is any child work item of a requirement. 
    /// e.g. Requirements Analysis is a task. It takes time. That time should be tracked
    /// e.g. Designing is a task. It also takes time. 
    /// 
    /// A task has a single parent requirement
    /// </summary>
    public interface ITask
    {
        ITaskType Type { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        IList<ITask> Siblings { get; set; }
        IRequirement Parent { get; set; }
        IList<IAttachment> Attachments { get; set; }
        float EstimatedEffort { get; set; }
        float ActualEffort { get; set; }
        float RemainingTime { get; set; }
    }


    [Serializable]
    public class Task : ITask
    {
        public Task() : this(null, new TaskType(TaskTypes.Undefined)) { }

        public Task(IRequirement parent, ITaskType type)
        {
            Parent = parent;
            Type = type;
            Siblings = new List<ITask>();
            Attachments = new List<IAttachment>();
        }

        public ITaskType Type { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public IRequirement Parent { get; set; }

        public IList<ITask> Siblings { get; set; }

        public float EstimatedEffort { get; set; }

        public float ActualEffort { get; set; }

        public float RemainingTime { get; set; }

        public IList<IAttachment> Attachments { get; set; }
    }
}
