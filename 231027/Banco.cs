﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;
using System.Data.SqlClient;

namespace _231027
{
    internal class Banco
    {
        // Criando as variáveis publicas para conexão  e consultaserão usadas em todo o projeto
        // Connection responsável pela conexão com o MySQL
        public static MySqlConnection Conexao;
        // Command responsável pelas instruções SQL a serem executadas
        public static MySqlCommand Comando;
        // Adapter responsável por inserir dados em um dataTable
        public static MySqlDataAdapter Adaptador;
        // DataTable responsável por ligar o banco em controles com a propriedade DataSource
        public static DataTable datTabela;

        public static void AbrirConexao()
        {
            try
            {
                //Estabelece os parâmetros para a conexão com o banco
                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");

                // Abre a conexão com o banco de dados
                Conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                // Fecha a Conexao com o banco de dados
                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CriarBanco()
        {
            try
            {
                AbrirConexao();

                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas; USE vendas", Conexao);
                // Executa a query no MySQL (raio do workbench)
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Cidades " +
                                           "(id integer auto_increment primary key, " +
                                           "nome char(40), " +
                                           "uf char(02))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Marcas " +
                                            "(id integer auto_increment primary key, " +
                                            "marca char(20))", Conexao);
                Comando.ExecuteNonQuery();
                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Categorias " +
                                            "(id integer auto_increment primary key, " +
                                            "categoria char(20))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Clientes" +
                                            "(Id integer auto_increment primary key, " +
                                            "nome char(40), " +
                                            "idCidade integer, " +
                                            "dataNasc date, " +
                                            "renda decimal(10,2), " +
                                            "cpf char(14), " +
                                            "foto varchar(100), " +
                                            "venda boolean)", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Produtos " +
                                            "(Id integer auto_increment primary key, " +
                                            "descricao char(40), " +
                                            "idCategoria integer, " +
                                            "idMarca integer, " +
                                            "estoque decimal(10,3), " +
                                            "valorVenda decimal(10,2), " +
                                            "foto varchar(100))", Conexao);
                Comando.ExecuteNonQuery();

                // Chama a função para fechar a conexao com o banco
                FecharConexao();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
