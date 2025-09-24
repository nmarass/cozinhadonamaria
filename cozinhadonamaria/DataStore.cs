// Remova ou renomeie esta definição se já existir outra classe DataStore no mesmo namespace.
// Solução: Renomear a classe para evitar duplicidade.

using System.Collections.Generic;

namespace cozinhadonamaria
{
    // Renomeado para DataStoreCozinha para evitar conflito com outra definição de DataStore.
    public static class DataStoreCozinha
    {
        public static List<string> TiposCozinha { get; } = new();
        public static List<Ingrediente> ListaIngredientes { get; } = new();
        public static List<Receita> ListaReceitas { get; } = new();
    }
}