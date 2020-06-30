using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Eventos.IO.Services.Api.ViewModels
{
    public class CategoriaViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public SelectList Categorias()
        {
            return new SelectList(ListarCategorias(), "Id", "Nome");
        }

        public List<CategoriaViewModel> ListarCategorias()
        {
            var categoriaList = new List<CategoriaViewModel>()
            {
                new CategoriaViewModel() { Id = new Guid("5fdf00b9-4577-4b3c-a79d-685ef923e6d2"), Nome = "Congresso" },
                new CategoriaViewModel() { Id = new Guid("42083bb8-d2b4-4677-8127-0afb1925fa37"), Nome = "Meetup" },
                new CategoriaViewModel() { Id = new Guid("20de7c23-1ebf-4268-ab25-6e7df1914cd1"), Nome = "Workshop" }
            };

            return categoriaList;
        }
    }
}
