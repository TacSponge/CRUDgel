using System;
using Xunit;
using CRUDgel.Controllers;
using CRUDgel.Models;

namespace CRUDGelTests
{
    public class UnitTest1
    {
        //These unit tests need to be decoupled so that
        //they do not tet both the controller and the model together 
        Characters _charactersModel = new Characters();
        [Fact]
        public void New_Controller_Is_Empty()
        {
            var controller = new CharacterController(_charactersModel);
            Assert.Empty(controller.Get());
        }
        [Fact]
        public void Can_Add_Character()
        {
            var controller = new CharacterController(_charactersModel);
            controller.Post(new CharacterModel());
            Assert.NotEmpty(controller.Get());
        }
        [Fact]
        public void Can_Get_Added_Character()
        {
            var controller = new CharacterController(_charactersModel);
            CharacterModel character = new CharacterModel();
            character.Id = 3;
            character.ForeName = "NewChar";

            controller.Post(character);

            Assert.Equal("NewChar", controller.Get(3).ForeName);
        }

        [Fact]
        public void Can_Add_Multiple_Characters()
        {
            var controller = new CharacterController(_charactersModel);
            var character1 = new CharacterModel();
            character1.Id = 1;
            controller.Post(character1);

            var character2 = new CharacterModel();
            controller.Post(character1);
            character2.Id = 2;

            Assert.Equal(2, controller.Get().Count); 
        }

        [Fact]
        public void Can_Delete_Character()
        {
            var controller = new CharacterController(_charactersModel);
            var character1 = new CharacterModel();
            character1.Id = 1;
            controller.Post(character1);

            var character2 = new CharacterModel();
            character2.Id = 2;
            controller.Post(character2);

            controller.Delete(1);

            Assert.Single(controller.Get());
        }

    }
}