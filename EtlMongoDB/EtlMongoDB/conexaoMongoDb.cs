using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;

namespace EtlMongoDB
{
    class conexaoMongoDb
    {
        public const string STRING_DE_CONEXAO = "mongodb+srv://#######################################################################";
        public const string NOME_DO_BANCO = "Biblioteca";
        public const string COLECAO = "Livros";

        private static readonly IMongoClient _cliente;
        private static readonly IMongoDatabase _banco;

        static conexaoMongoDb()
        {
            _cliente = new MongoClient(STRING_DE_CONEXAO);
            _banco = _cliente.GetDatabase(NOME_DO_BANCO);
        }

        public IMongoClient Cliente
        {
            get { return _cliente; }
        }

        public IMongoCollection<Livro> Livros
        {
            get { return _banco.GetCollection<Livro>(COLECAO); }
        }
    }
}
