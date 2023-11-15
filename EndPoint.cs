using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MAUI_Parte_2_Rick_And_Morty
{
    internal class EndPoint
    {
        public static string GetRMChar()
        {
            return $"https://rickandmortyapi.com/api/character";
        }
    }
}
