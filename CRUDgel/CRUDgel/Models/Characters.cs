using CRUDgel.Utils;
using System.Collections.Generic;
using System.Linq;


namespace CRUDgel.Models
{
    public class Characters : ICharacters
    {
        private List<CharacterModel> characterList = new List<CharacterModel>();

        public Characters()
        {
            
        }
        public void Load()
        {
            characterList = JsonHandler.LoadCharacters();
        }

        private void Save()
        {
            JsonHandler.SaveCharacters(characterList);
        }

        public List<CharacterModel> getCharacterList()
        {
            return characterList;
        }

        public List<CharacterModel> getCharacterList(int id)
        {
            return characterList.Where(x => x.Id == id).ToList();
        }
        public void addCharacter(CharacterModel character)
        {
            characterList.Add(character);
            Save();
            
        }

        public void save()
        {
            JsonHandler.SaveCharacters(characterList);
            Save();
        }
        public void Delete(int id)
        {
            characterList = characterList.Where(x => x.Id != id).ToList();
        }
    }
}
