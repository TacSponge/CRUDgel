using System.Collections.Generic;

namespace CRUDgel.Models
{
    public interface ICharacters
    {
        void addCharacter(CharacterModel character);
        void Delete(int id);
        List<CharacterModel> getCharacterList();
        List<CharacterModel> getCharacterList(int id);
        void save();
    }
}