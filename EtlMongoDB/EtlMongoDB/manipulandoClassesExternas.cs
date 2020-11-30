using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EtlMongoDB
{
    class manipulandoClassesExternas
    {
        static void Main(String[] args)
        {
            // Inicializar uma variavel do tipo livro
            Livro livro = new Livro();
            livro.Titulo = "Star Wars Legends";
            livro.Autor = "Timothy Zahn";
            livro.Ano = 2010;
            livro.Paginas = 245;
            List<string> listaAssuntos = new List<string>();

            listaAssuntos.Add("Ficção Científica");
            listaAssuntos.Add("Ação");
            livro.Assunto = listaAssuntos;

            // Acessando atraves da classe conexao
            var conexaoBiblioteca = new conexaoMongoDb();

            // Incluindo documento
            conexaoBiblioteca.Livros.InsertOne(livro);

            Console.WriteLine("Documento Incluido");
        }
    }
}
