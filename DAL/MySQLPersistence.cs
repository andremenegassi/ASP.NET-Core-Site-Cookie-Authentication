using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HelloWorld.DAL
{
    public class MySQLPersistence
    {
        MySqlConnection _con;
        MySqlCommand _cmd;
        bool _autoFecharConexao;

        int _lastInsertedId;

        public int LastInsertedId { get => _lastInsertedId; }

        public MySQLPersistence(bool autoFecharConexao = true)
        {
            _autoFecharConexao = autoFecharConexao;
            string strCon =
                @"Server=den1.mysql6.gear.host;
                  Database=aperf;
                  Uid=aperf;
                  Pwd=123456$;";

            _con = new MySqlConnection(strCon);
            _cmd = _con.CreateCommand();
        }


        public void Abrir()
        {
            if (_con.State != System.Data.ConnectionState.Open)
                _con.Open();
        }

        public void Fechar()
        {
            _con.Close();
        }

        /// <summary>
        /// Executa comados SELECT.
        /// </summary>
        /// <param name="select">Comando SELECT</param>
        /// <param name="parametros">Dictionary de parâmetros</param>
        /// <returns>DataTable com os dados.</returns>
        public DataTable ExecutarSelect(string select, 
            Dictionary<string, object> parametros = null)
        {
            DataTable dt = new DataTable();
            try
            {
                Abrir();
                _cmd.CommandText = select;
                _cmd.Parameters.Clear();

                if (parametros != null)
                {
                    foreach (var item in parametros)
                    {
                        _cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }

                dt.Load(_cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                throw new Exception("Erro em ExecutarSelect", ex);
            }
            finally
            {
                if (_autoFecharConexao)
                    Fechar();
            }

            return dt;
        }

    
        public object ExecutarScalar(string select,
            Dictionary<string, object> parametros = null)
        {
            Abrir();
            _cmd.CommandText = select;
            _cmd.Parameters.Clear();

            if (parametros != null)
            {
                foreach (var item in parametros)
                {
                    _cmd.Parameters.AddWithValue(item.Key, item.Value);
                }
            }

            object valor = _cmd.ExecuteScalar();

            if (_autoFecharConexao)
                Fechar();

            return valor;

        }

        public int ExecutarComando(string comando,
            Dictionary<string, object> parametros = null)
        {
            Abrir();
            _cmd.CommandText = comando;
            _cmd.Parameters.Clear();

            if (parametros != null)
            {
                foreach (var item in parametros)
                {
                    _cmd.Parameters.AddWithValue(item.Key, item.Value);
                }
            }

            int linhasAfetadas =
                _cmd.ExecuteNonQuery();

            _lastInsertedId = (int)_cmd.LastInsertedId;


            if (_autoFecharConexao)
                Fechar();

            return linhasAfetadas;

        }


    }
}
