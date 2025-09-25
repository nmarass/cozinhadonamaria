using System.Collections.Generic;

namespace cozinhadonamaria
{
    public static class DataStoreCozinha
    {
        public static List<string> TiposCozinha { get; } = new();
        public static List<Ingrediente> ListaIngredientes { get; } = new();
        public static List<Receita> ListaReceitas { get; } = new();
    }
}