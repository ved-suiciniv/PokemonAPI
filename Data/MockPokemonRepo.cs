﻿using PokemonAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonAPI.Data
{
    public class MockPokemonRepo : IPokemonRepo
    {
        public void CreatePokemon(Pokemon pkm)
        {
            throw new NotImplementedException();
        }

        public void DeletePokemon(Pokemon pkm)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pokemon> GetAllPokemons()
        {
            var pokemons = new List<Pokemon>
            {
                new Pokemon { Id = 0, Name = "Pikachu", Local = "Kanto" },
                new Pokemon { Id = 1, Name = "Raichu", Local = "Kanto" },
                new Pokemon { Id = 2, Name = "Pichu", Local = "Kanto" }
            };
            return pokemons;
        }

        public Pokemon GetPokemonById(int Id)
        {
            return new Pokemon { Id = 2, Name = "Pichu", Local = "Kanto" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdatePokemon(Pokemon pkm)
        {
            throw new NotImplementedException();
        }
    }
}
