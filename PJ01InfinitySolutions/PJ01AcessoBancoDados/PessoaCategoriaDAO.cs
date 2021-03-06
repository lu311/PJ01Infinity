﻿using PJ01DAO_SQL;
using System;
using System.Collections.Generic;
using System.Data;

namespace PJ01Model
{
    public class PessoaCategoriaDAO
    {
        Banco banco = new Banco();
        DataTable tabelaSelect; 
        
        /// <summary>
        /// Metodo que recebe um datatable de categorias e o converte em sql para ser enviado ao banco de dados.
        /// </summary>
        /// <param name="categoria"></param>
        public void GravarCategoria(DataTable categoria)
        {
            List<string> listSql = new List<string>();

            // recupera as linhas deletadas de uma Datatable e adiciona as mesma um Array de objetos DataRow
            DataRow[] delRows = categoria.Select(null, null, DataViewRowState.Deleted);

            // recupera as linhas Inseridas de uma Datatable e adiciona as mesma um Array de objetos DataRow
            DataRow[] insertRows = categoria.Select(null, null, DataViewRowState.Added);

            // recupera as linhas alteradas de uma Datatable e adiciona as mesma um Array de objetos DataRow
            DataRow[] updateRows = categoria.Select(null, null, DataViewRowState.ModifiedCurrent);

            foreach (DataRow row in delRows)
            {
                listSql.Add("delete from PESSOACATEGORIA where categoriaID = " + row["categoriaid", DataRowVersion.Original].ToString());
                Console.WriteLine("InserirCategoria linha deletada: " + row["categoriaid", DataRowVersion.Original].ToString());
            }

            foreach (DataRow row in insertRows)
            {
                string sql = "INSERT INTO PESSOACATEGORIA (categoria) VALUES ('" + row["categoria"].ToString() + "')";
                
                listSql.Add(sql);
                Console.WriteLine("InserirCategoria linha insert: \n" + sql);
            }

            foreach (DataRow row in updateRows)
            {
                string sql = "UPDATE PESSOACATEGORIA set "
                    + "categoria='" + row["categoria"].ToString() + "' "
                    + "where categoriaid = " + row["categoriaID"].ToString();

                listSql.Add(sql);
                Console.WriteLine("InserirCategoria linha update: \n" + sql);
            }


            try
            {
                banco.abrirConexaoTransacao();

                foreach (string sql in listSql)
                {
                    banco.Gravar(sql);
                }

                banco.Commit();     
            }
            catch (Exception e)
            {
                banco.Rollback();
                Console.WriteLine("CategoriaDao.GravarCategoria erro: " + e.Message);
                throw;
            }
            finally
            {
                banco.fecharConexao();
            }       
        }

        /// <summary>
        /// Pesquisa e delete uma categoria no banco de dados utilizando o ID como base da busca.
        /// </summary>
        /// <param name="categoriaId"></param>
        public void ExcluirCategoria(int categoriaId)
        {
            try
            {
                banco.abrirConexaoTransacao();
                banco.Gravar("delete from pessoacategoria where categoriaID = " + categoriaId);
                banco.Commit();
            }
            catch (Exception e)
            {
                banco.Rollback();
                Console.WriteLine("ExcluirCategoria erro: " + e.Message);
            }
            finally
            {
                banco.fecharConexao();
            }
        }
     
        /// <summary>
        /// Pesquisa em banco de dados e retorna todas as categorias 
        /// </summary>
        /// <returns></returns>
        public DataTable PesquisaCategorias()
        {
            try
            {
                banco.abrirConexao();
                tabelaSelect = banco.Select("SELECT * from pessoacategoria order by categoria");                   
            }
            catch (Exception e)
            {
                Console.WriteLine("PesquisaCategorias erro: " + e.Message);
            }
            finally
            {
                banco.fecharConexao();
            }

            return tabelaSelect;
        }        
    }
}
