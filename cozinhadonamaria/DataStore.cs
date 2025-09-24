// Remova ou renomeie esta defini��o se j� existir outra classe DataStore no mesmo namespace.
// Solu��o: Renomear a classe para evitar duplicidade.

using System.Collections.Generic;

namespace cozinhadonamaria
{
    // Renomeado para DataStoreCozinha para evitar conflito com outra defini��o de DataStore.
    public static class DataStoreCozinha
    {
        public static List<string> TiposCozinha { get; } = new();
        public static List<Ingrediente> ListaIngredientes { get; } = new();
        public static List<Receita> ListaReceitas { get; } = new();
    }
}