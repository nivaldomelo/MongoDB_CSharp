using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EtlMongoDB
{
    class IncluindoMuitosLivros
    {
        static void Main(String[] args)
        {
            // Acessando atraves da classe conexao
            var conexaoBiblioteca = new conexaoMongoDb();

            List<Livro> Livros = new List<Livro>();
            Livros.Add(valoresLivro.incluiValoresLivro("A Dança com Dragões", "George R R Martin", 2011, 934, "Fantasia, Ação"));
            Livros.Add(valoresLivro.incluiValoresLivro("A Tormenta das Espadas", "George R R Martin", 2006, 1276, "Fantasia, Ação"));
            Livros.Add(valoresLivro.incluiValoresLivro("Saúde e Sabor", "Yeomans Matthew", 2012, 245, "Culinária, Didático"));
            Livros.Add(valoresLivro.incluiValoresLivro("O Senhor dos Anéis", "J R R Token", 1948, 1956, "Fantasia, Ação"));
            Livros.Add(valoresLivro.incluiValoresLivro("Da Rússia com Amor", "Iam Fleming", 1956, 267, "Espionagem, Ação"));
          
            conexaoBiblioteca.Livros.InsertMany(Livros);

            Console.WriteLine("Documentos Incluidos");
        }
    }
}
