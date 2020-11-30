using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EtlMongoDB
{
    class alterandoDocumentosClasse
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
            var construtorAlteracao = Builders<Livro>.Update;
            var condicaoAlteracao = construtorAlteracao.Set(x => x.Ano, 2020);
            conexaoBiblioteca.Livros.UpdateOne(condicao, condicaoAlteracao);
        }
    }
}
