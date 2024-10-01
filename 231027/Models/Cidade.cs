﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Linq.Expressions;


namespace _231027.Models
{
    internal class Cidade
    {
         public int id { get;set; }
         public string nome { get;set; }
         public string uf { get; set; }

        public void Incluir()
        {
            try
            {
                // Abre a conexão com o banco
                Banco.AbrirConexao();
                // Alimenta o método Command com a instrução e indica a conexão utilizada
                Banco.Comando = new MySqlCommand("INSERT INTO cidades (nome, uf) VALUES (@nome, @uf)", Banco.Conexao);
                // Cria os parâmetros utilizados na instrução SQL com seu respectivo conteúdo
                Banco.Comando.Parameters.AddWithValue("@nome", nome); // Parâmetro String
                Banco.Comando.Parameters.AddWithValue("@uf", uf);
                // Executa o Comando, no MySQL, tem a função do Raio do Workbench
                Banco.Comando.ExecuteNonQuery();
                // Fecha a conexãoi
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar()
        {
            try
            {
                // Abre a conexão com o banco
                Banco.AbrirConexao();
                // Alimenta o método Command com a instrução desejada e indica a conexão utilizada
                Banco.Comando = new MySqlCommand("Update cidades set nome = @nome, uf = @uf where id = @id", Banco.Conexao);
                // Cria os parâmetros utilizados na instrução SQL com seu respectivo conteúdo
                Banco.Comando.Parameters.AddWithValue("@nome", nome); // Parâmetro String
                Banco.Comando.Parameters.AddWithValue("@uf", uf);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                // Executa o Comando, no MySQL, tem a função do Raio do Workbench
                Banco.Comando.ExecuteNonQuery();
                // Fecha a conexão
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Excluir()
        {
            try
            {
                // Abre a conexão com o banco
                Banco.AbrirConexao();
                // Alimenta o método Command com a instrução desejada e indica a conexão utilizada
                Banco.Comando = new MySqlCommand("delete from cidades where id = @id", Banco.Conexao);
                // Cria os parâmetros utilizados na instrução SQL com seu respectivo conteúdo
                Banco.Comando.Parameters.AddWithValue("@id", id);
                // Executa o Comando, no MySQL, tem a função do Raio do Workbench
                Banco.Comando.ExecuteNonQuery();
                // Fecha a conexão
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("SELECT * FROM Cidades where nome like @Nome " + "order by nome", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@Nome", nome + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);
                Banco.FecharConexao();
                return Banco.datTabela;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}