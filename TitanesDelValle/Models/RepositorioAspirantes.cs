using System.Collections.Generic;

namespace TitanesDelValle.Models
{
    public static class RepositorioAspirantes
    {
        private static List<Aspirante> aspirantes = new List<Aspirante>();

        public static void Agregar(Aspirante aspirante)
        {
            aspirante.Id = aspirantes.Count + 1;
            aspirantes.Add(aspirante);
        }

        public static List<Aspirante> ObtenerTodos()
        {
            return aspirantes;
        }
    }
}