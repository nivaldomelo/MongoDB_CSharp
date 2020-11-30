using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EtlMongoDB
{
    class excluindoDocumentos
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Listando livro Sobre a Redoma");
            var conexaoBiblioteca = new conexaoMongoDb();

            var construtor = Builders<Livro>.Filter;
            var condicao = construtor.Eq(x => x.Titulo, "Sobre a Redoma");

            var listaLivros = conexaoBiblioteca.Livros.Find(condicao).ToList();
            foreach (var doc in listaLivros)
            {
                Console.WriteLine(doc.ToJson<Livro>());
            }
            conexaoBiblioteca.Livros.DeleteMany(condicao);
        }
    }
}
