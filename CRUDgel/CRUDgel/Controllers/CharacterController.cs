using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDgel.Models;
using CRUDgel.Utils;
using Microsoft.AspNetCore.Mvc;


namespace CRUDgel.Controllers
{
    [ApiController]  
    [Route("api")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacters _charactersModel;

        public CharacterController(ICharacters characters)
        {
            _charactersModel = characters;
        }
        
        [HttpGet]
        public List<CharacterModel> Get()
        {
            return _charactersModel.getCharacterList();
        }

        [HttpGet("{id}")]
        public CharacterModel Get(int id)
        {
            return _charactersModel.getCharacterList(id).First();
        }

        [HttpPost]
        public void Post(CharacterModel character)
        {
            _charactersModel.addCharacter(character);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _charactersModel.Delete(id);
        }
    }
}
