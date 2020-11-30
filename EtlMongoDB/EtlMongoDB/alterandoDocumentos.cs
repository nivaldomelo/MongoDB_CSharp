using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EtlMongoDB
{
    class alterandoDocumentos
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Listando livro Guerra dos Tronos");
            var conexaoBiblioteca = new conexaoMongoDb();

            var construtor = Builders<Livro>.Filter;
            var condicao = construtor.Eq(x => x.Titulo, "Guerra dos Tronos");

            var listaLivros = conexaoBiblioteca.Livros.Find(condicao).ToList();
            foreach (var doc in listaLivros)
            {
                Console.WriteLine(doc.ToJson<Livro>());
            }
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Atualizando livro Guerra dos Tronos");
            conexaoBiblioteca = new conexaoMongoDb();

            construtor = Builders<Livro>.Filter;
            condicao = construtor.Eq(x => x.Titulo, "Guerra dos Tronos");

            listaLivros = conexaoBiblioteca.Livros.Find(condicao).ToList();
            foreach (var doc in listaLivros)
            {
                doc.Ano = 2005;
                doc.Paginas = 2000;
                conexaoBiblioteca.Livros.ReplaceOne(condicao, doc);
            }
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Listando de novo livro Guerra dos Tronos");
            conexaoBiblioteca = new conexaoMongoDb();

            construtor = Builders<Livro>.Filter;
            condicao = construtor.Eq(x => x.Titulo, "Guerra dos Tronos");

            listaLivros = conexaoBiblioteca.Livros.Find(condicao).ToList();
            foreach (var doc in listaLivros)
            {
                Console.WriteLine(doc.ToJson<Livro>());
            }
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}
