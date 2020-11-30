using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EtlMongoDB
{
    class listandoDocumentosFiltroBson
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Listando Documentos");
            // Acessando atraves da classe conexao
            var conexaoBiblioteca = new conexaoMongoDb();
            var Filtro = new BsonDocument 
            {
                {"Autor", "Iam Fleming" }
            };
            var listaLivros = conexaoBiblioteca.Livros.Find(Filtro).ToList();
            foreach (var doc in listaLivros)
            {
                Console.WriteLine(doc.ToJson<Livro>());
            }
            Console.WriteLine("Fim da Lista");
        }
    }
}
