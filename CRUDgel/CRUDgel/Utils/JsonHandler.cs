using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using CRUDgel.Models;
using System.IO;

namespace CRUDgel.Utils
{    
    public class JsonHandler  
    {
        const string fileName = "characters.json";
        public static List<CharacterModel> LoadCharacters()
        {
            string jsonString = File.ReadAllText(fileName);
            var characters = JsonSerializer.Deserialize<List<CharacterModel>>(jsonString);

            return characters;

        }
        public async static void SaveCharacters(List<CharacterModel> characters)
        {
            using FileStream stream = File.Create(fileName);
            await JsonSerializer.SerializeAsync(stream, characters);
        }
    }
}
