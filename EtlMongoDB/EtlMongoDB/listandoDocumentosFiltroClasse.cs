using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EtlMongoDB
{
    class listandoDocumentosFiltroClasse
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Listando Documentos do Autor J R R Token");
            var conexaoBiblioteca = new conexaoMongoDb();

            var construtor = Builders<Livro>.Filter;
            var condicao = construtor.Eq(x => x.Autor, "J R R Token");

            var listaLivros = conexaoBiblioteca.Livros.Find(condicao).ToList();
            foreach (var doc in listaLivros)
            {
                Console.WriteLine(doc.ToJson<Livro>());
            }
            Console.WriteLine("------------------------------xxx--------------------------------------------");

            Console.WriteLine("Listando Documentos do Autor maior ou igual ao ano 2010 e com mais de 600 páginas");

            construtor = Builders<Livro>.Filter;
            condicao = construtor.Gte(x => x.Ano, 2010) & construtor.Gte(x => x.Paginas, 600);

            listaLivros = conexaoBiblioteca.Livros.Find(condicao).ToList();
            foreach (var doc in listaLivros)
            {
                Console.WriteLine(doc.ToJson<Livro>());
            }
            Console.WriteLine("Fim da Lista");
            // AnyEq busca informações iguais a __ tipo buscar alguma coisa sobre assuntos
        }
    }
}
