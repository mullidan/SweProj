using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectModels;
using ProjectModels.Model;
using System.Reflection;

namespace ProjectModelsTest
{
    [TestClass]
    public class ProjectModelsTests
    {
        [TestMethod]
        public void TestThatARequirementCanBeAddedToAProject()
        {
            IProject proj = new Project();
            var req = new Requirement(RequirementType.Functional);      
                  
            proj.Requirements.Add(req);
            Assert.AreEqual(1, proj.Requirements.Count);
        }

        [TestMethod]
        public void TestThatAProjectCanBeSavedToDisk()
        {
            IProject proj = new Project("TestProj");            

            var req = new Requirement(RequirementType.Functional);
            req.Tasks.Add(
                new Task()
                {
                    Type = new TaskType(TaskTypes.Design) { },
                    Title = "Task1",
                    Description = "Description",
                    Parent = req,
                    EstimatedEffort = 1,
                    ActualEffort = 0,
                    RemainingTime = 1,
                    Siblings = null,
                    Attachments = null
                }
            );
            proj.Requirements.Add(req);
            var fileName = string.Concat(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "\\test.bin");
            Support.SaveToDisk(fileName, (Project)proj);
            Assert.IsTrue(File.Exists(fileName));
        }

        [TestMethod]
        public void TestThatAProjectCanBeLoadedFromDisk()
        {
            var fileName = string.Concat(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "\\test.bin");
            IProject proj = Support.LoadFromDisk(fileName);
            Assert.IsNotNull(proj);
            Assert.AreEqual("TestProj", proj.Name);
            Assert.AreEqual(1, proj.Requirements.Count);
            Assert.AreEqual(1, proj.Requirements[0].Tasks.Count);
            Assert.AreEqual("Task1", proj.Requirements[0].Tasks[0].Title);
            Assert.AreEqual("Description", proj.Requirements[0].Tasks[0].Description);
            Assert.AreEqual(1, proj.Requirements[0].Tasks[0].EstimatedEffort);
            Assert.AreEqual(0, proj.Requirements[0].Tasks[0].ActualEffort);
            Assert.AreEqual(1, proj.Requirements[0].Tasks[0].RemainingTime);
            Assert.IsNull(proj.Requirements[0].Tasks[0].Siblings);
            Assert.IsNull(proj.Requirements[0].Tasks[0].Attachments);
        }
    }
}
