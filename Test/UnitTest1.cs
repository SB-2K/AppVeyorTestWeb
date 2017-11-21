using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppVeyorTestWeb;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetEntity()
        {
            EntityService service = new EntityService();
            Entity entity = service.GetEntity(1);
            Assert.Equals(entity.EntityID, 1);
        }
    }
}
