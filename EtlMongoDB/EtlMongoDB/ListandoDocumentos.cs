using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EtlMongoDB
{
    class ListandoDocumentos
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Listando Documentos");
            // Acessando atraves da classe conexao
            var conexaoBiblioteca = new conexaoMongoDb();
            
            var listaLivros = conexaoBiblioteca.Livros.Find(new BsonDocument()).ToList();
            foreach(var doc in listaLivros)
            {
                Console.WriteLine(doc.ToJson<Livro>());
            }
            Console.WriteLine("Fim da Lista");
        }
    }
}
