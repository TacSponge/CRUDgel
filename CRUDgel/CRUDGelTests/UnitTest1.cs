using System;
using Xunit;
using CRUDgel.Controllers;
using CRUDgel.Models;

namespace CRUDGelTests
{
    public class UnitTest1
    {
        [Fact]
        public void Can_Get_Default_Character()
        {
            var controller = new CharacterController();
            Assert.NotNull(controller.Get());
        }
    }
}
