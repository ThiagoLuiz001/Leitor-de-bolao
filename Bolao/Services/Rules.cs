using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolao.Models.Entities;
using Bolao.Models.Enums;
namespace Bolao.Services
{
    public class Rules
    {
        public static Game GamesRules(EnumTypes type)
        {
            Game game;
            if(type == EnumTypes.Mega_Sena)
            {
                return game = new Game(6, 20, 60, new HashSet<int> {4,6});
            }
            if(type == EnumTypes.Lotofácil)
            {
                return game = new Game(15, 20, 25, new HashSet<int> {11,15});
            }
            if(type == EnumTypes.Quina)
            {
                return game = new Game(5, 15, 80, new HashSet<int> { 2,5 });
            }
            if(type == EnumTypes.LotoMania)
            {
                return game = new Game(50, 50, 100, new HashSet<int> {0,15,20});
            }
            if(type == EnumTypes.TimeMania)
            {
                return game = new Game(10, 10, 80, new HashSet<int> { 3, 7 });
            }
            if(type == EnumTypes.Dupla_Sena)
            {
                return game = new Game(6, 15, 50, new HashSet<int> { 3, 6});
            }
            if(type == EnumTypes.Dia_de_Sorte)
            {
                return game = new Game(7, 15, 31, new HashSet<int> { 4, 7 });
            }
            throw new Exception("Fora de parametro!");
        }
    }
}
