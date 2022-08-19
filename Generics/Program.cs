using Generics;
using Generics.Data;
using Generics.Domain;
using Microsoft.Extensions.DependencyInjection;


var provider = configInjecaoDeDependencia();

var produtoRepositorio = provider.GetRequiredService<IRepositorio<Produto>>();
var categoriaRepositorio = provider.GetRequiredService<IRepositorio<Categoria>>();

produtoRepositorio.Adicionar(new Produto("Produto 01", 200));
produtoRepositorio.Adicionar(new Produto("Produto 02", 400));

//categoriaRepositorio.Adicionar(new Categoria("Produto 01"));

produtoRepositorio.ObterTodos().Imprimir();
categoriaRepositorio.ObterTodos().Imprimir();

ServiceProvider configInjecaoDeDependencia()
{
    var serviceColecction = new ServiceCollection();

    serviceColecction.AddScoped(typeof(IRepositorio<>), typeof (Repositorio<>));

    return serviceColecction.BuildServiceProvider();
}