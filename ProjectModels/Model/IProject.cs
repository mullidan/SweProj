using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjectModels.Model
{
    public interface IProject
    {
        string Name { get; set; }
        IList<IRequirement> Requirements { get; set; }
    }

    [Serializable]
    public class Project : IProject
    {
        public Project() : this("Undefined") { }

        public Project(string name)
        {
            Name = name;
            Requirements = new List<IRequirement>();
        }

        public string Name { get; set; }

        public IList<IRequirement> Requirements { get; set; }
    }
}
