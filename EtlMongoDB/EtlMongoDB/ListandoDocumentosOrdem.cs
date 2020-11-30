using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EtlMongoDB
{
    class ListandoDocumentosOrdem
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Listando Documentos com mais de 500 páginas ordenado");
            var conexaoBiblioteca = new conexaoMongoDb();

            var construtor = Builders<Livro>.Filter;
            var condicao = construtor.Gt(x => x.Paginas, 500);

            var listaLivros = conexaoBiblioteca.Livros.Find(condicao).SortBy(x => x.Titulo).ToList();
            foreach (var doc in listaLivros)
            {
                Console.WriteLine(doc.ToJson<Livro>());
            }
            
        }
    }
}
