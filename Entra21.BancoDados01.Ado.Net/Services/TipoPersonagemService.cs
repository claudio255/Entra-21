﻿using Entra21.BancoDados01.Ado.Net.BancoDados;
using Entra21.BancoDados01.Ado.Net.Models;
using System.Data;
using System.Data.SqlClient;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    //Dois pontos seguido de uma interface, quer dizer que a classe
    //Será obrigada a implementar os métodos(contratos) estabelecidos na interface
    internal class TipoPersonagemService : ITipoPersonagemService
    {
        public void Apagar(int id)
        {
            //Conectar com o banco de dados
            var conexao = new Conexao().Conectar();

            //Criar comando para executar o delete
            var comando = conexao.CreateCommand();

            //Definido o comando para apagar o registro
            comando.CommandText = "DELETE FROM tipos_personagens WHERE id = " + id;

            //Executado o comando para apagar o registro
            comando.ExecuteNonQuery();

            //Fechar conexão com o banco de dados
            comando.Connection.Close();
        }

        public void Cadastrar(TipoPersonagem tipoPersonagem)
        {
            //Será descrito a implementação do contrato definido na interface

            //Criado conexão com o BancoDeDados e aberta a conexão
            var conexao = new Conexao().Conectar();

            //Criar o comando para executar no banco de dados
            SqlCommand comando = conexao.CreateCommand();

            //Especificado o comando que será executado
            comando.CommandText = "INSERT INTO tipos_personagens (tipo) VALUES ('" +
                tipoPersonagem.Tipo + "')";

            //Executando o comando de insert na tabela de tipos personagens
            comando.ExecuteNonQuery();

            //Fechamento da conexão
            conexao.Close();
        }

        public void Editar(TipoPersonagem tipoPersonagem)
        {
            var conexao = new Conexao().Conectar();

            //Conectado no banco de dados e definido a query que será executada
            var comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE tipos_personagens SET tipo = '" + tipoPersonagem.Tipo + "' WHERE id = " + tipoPersonagem.Id;

            //Executa o UPDATE na tabela de tipos_personagens
            comando.ExecuteNonQuery();

            //Fechar conexao
            comando.Connection.Close();
        }

        public TipoPersonagem ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            //Conectado no banco de dados e definido a query que será executada
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, tipo FROM tipos_personagens WHERE id = '" + id + "'";

            //Instanciado tabela em memoria de tipos_personagens armazenar os registros retornandos da consulta SELECT
            var tabelaEmMemoria = new DataTable();

            //Executando a consulta na tabela de tipos_personagens armazenando-os na tabela em memoria
            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var primeiroRegistro = tabelaEmMemoria.Rows[0];

            var tipoPersonagem = new TipoPersonagem();
            //Obter a primeira coluna do select que é o Id
            tipoPersonagem.Id = Convert.ToInt32(primeiroRegistro[0]);
            //Obter a segunda coluna do select que é o tipo
            tipoPersonagem.Tipo = primeiroRegistro[1].ToString();

            //Fechar conexao
            comando.Connection.Close();

            return tipoPersonagem;
        }

        public List<TipoPersonagem> ObterTodos()
        {
            //Criado conexão com o BancoDeDados e aberta a conexão
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, tipo FROM tipos_personagens";

            //Criando tabela em memoria para posteriormente carregar os registros obtidos com o SELECT
            var tabelaEmMemoria = new DataTable();

            //Carregando na tabela em memoria os registros encontrados com o comando SELECT
            tabelaEmMemoria.Load(comando.ExecuteReader());

            //Criado uma lista para armazenar os registros da consulta do SELECT
            var tiposPersonagens = new List<TipoPersonagem>();

            //Percorrido cada um dos registros da tabelaEmMemoria(registros do SELECT)
            for(int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                //Obtido o registro da linha que está sendo percorrida
                var linha = tabelaEmMemoria.Rows[i];

                //Instanciado o objeto da classe TipoPersonagem 
                //Preenchendo com as informações do SELECT, da linha que está endo percorrida
                var tipoPersonagem = new TipoPersonagem();
                tipoPersonagem.Id = Convert.ToInt32(linha["id"].ToString());
                tipoPersonagem.Tipo = linha["tipo"].ToString();

                //Adicionado tipoPersonagem instanciado na lista de TipoPersonagens
                tiposPersonagens.Add(tipoPersonagem);
            }
            //Fechado a conexão com o banco de dados
            comando.Connection.Close();

            return tiposPersonagens;
        }

    }
}
