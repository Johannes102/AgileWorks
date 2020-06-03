using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgileWorks.Test
{
    public abstract class ClassTests<TClass>: BaseClassTests<TClass> where TClass : new()
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            obj = new TClass();
            type = obj.GetType();
        }

        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(obj);
        }
    }
}
