
using System;

namespace ProjectModels.Model
{
    [Serializable]
    public enum TaskTypes { Undefined, Analysis, Design, Implementation, Testing, Management }

    public interface ITaskType
    {
        TaskTypes Type { get; set; }
    }

    [Serializable]
    public class TaskType : ITaskType
    {
        public TaskType() : this(TaskTypes.Undefined) { }

        public TaskType(TaskTypes type)
        {
            Type = type;
        }

        public TaskTypes Type { get; set; }
    }
}
