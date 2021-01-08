using System.Collections.Generic;
using System.IO;

namespace MVC_Console.Models
{
    public class Produto
    {
        public Produto(int codigo, string nome, float preco) 
        {
            this.Codigo = codigo;
                this.Nome = nome;
                this.Preco = preco;
               
        }
                public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        
        private const string PATH = "Database/Produto.csv";

        public Produto(){

            // Verificar se o arquivo existe
            string pasta = PATH.Split("/")[0];
            // [0] Detabase
            // [1] Produto.csv

            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }


            // Verificar se o arquivo existe
            if(!File.Exists(PATH))
            {
                File.Create(PATH);
            }


        } 


        public List<Produto> Ler()
        {
            // Crio uma lista para armazenar os produtos
            List<Produto> produtos = new List<Produto>();

            // Lemos as listas do CSV
            string[] linhas = File.ReadAllLines(PATH);

            // Percorremos as linhas do csv
            foreach (string item in linhas)
            {
                // Separamos os elementos de cada linha
                string[] atributos = item.Split(";");
                // 1;JBL;5000,00
                // [0] = 1
                // [1] = JBL
                // [2] = 5000,00

                // Passamos para um objeto do tipo Produto
                Produto prod = new Produto();
                prod.Codigo = int.Parse(atributos[0]);
                prod.Nome = atributos[1];
                prod.Preco = float.Parse(atributos[2]);

                produtos.Add(prod);

            }

            return produtos;

        }

        public void Inserir(Produto produto)
        {
            // Criamos um array de linhas para inserir no CSV
            string[] linhas = {PrepararLinhasCSV(produto)};

            // Método responsável por inserir linhas em um arquivo
            File.AppendAllLines(PATH, linhas);
        }

        public string PrepararLinhasCSV(Produto prod)
        {
            return $"{prod.Codigo};{prod.Nome};{prod.Preco}";
        }
        
    }
}