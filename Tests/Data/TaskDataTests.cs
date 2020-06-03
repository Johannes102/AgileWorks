using AgileWorks.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgileWorks.Test.Data
{
    [TestClass]
    public class TaskDataTests: ClassTests<TaskData>
    {
        [TestMethod]
        public void IdTest() => isNullableProperty(() => obj.Id, x => obj.Id = x);
        [TestMethod]
        public void NameTest() => isNullableProperty(() => obj.Name, x => obj.Name = x);
        [TestMethod]
        public void DescriptionTest() => isNullableProperty(() => obj.Description, x => obj.Description = x);
        [TestMethod]
        public void ValidFromTest() => isNullableProperty(() => obj.ValidFrom, x => obj.ValidFrom = x);
        [TestMethod]
        public void ValidToTest() => isNullableProperty(() => obj.ValidTo, x => obj.ValidTo = x);
        [TestMethod]
        public void CompletedTest() => isNullableProperty(() => obj.Completed, x => obj.Completed = x);
    }
}
