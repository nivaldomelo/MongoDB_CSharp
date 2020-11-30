using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EtlMongoDB
{
    class manipulandoClasses
    {
        static void Main(String[] args)
        {
            // Inicializar uma variavel do tipo livro
            Livro livro = new Livro();
            livro.Titulo = "Sobre a Redoma";
            livro.Autor = "Stepahn King";
            livro.Ano = 2012;
            livro.Paginas = 679;
            List<string> listaAssuntos = new List<string>();

            listaAssuntos.Add("Ficção Científica");
            listaAssuntos.Add("Terror");
            listaAssuntos.Add("Ação");

            livro.Assunto = listaAssuntos;

            // Acesso ao servidor Mongo
            string stringConexao = "mongodb+srv://#######################################################################";
            IMongoClient cliente = new MongoClient(stringConexao);

            // Acesso ao banco de dados
            IMongoDatabase bancoDados = cliente.GetDatabase("Biblioteca");

            // Acesso a coleção
            IMongoCollection<Livro> colecao = bancoDados.GetCollection<Livro>("Livros");

            // Incluindo documento
            colecao.InsertOne(livro);

            Console.WriteLine("Documento Incluido");
        }
        
    }
}
