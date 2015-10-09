using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using IBatisNet.DataMapper.MappedStatements;
using IBatisNet.DataMapper.Scope;
using System.Data;
using IBatisNet.DataMapper.SessionStore;

namespace MvcMusicStore.Query
{
    public interface IQuerier
    {
        TResult One<TResult>(string command, object parameter);

        IList<TResult> All<TResult>(string command, object parameter);
    }

    public class Querier : IQuerier
    {
        private static ISqlMapper _mapper;


        public Querier(string configPath)
        {

            if (_mapper == null)
            {
                _mapper = new DomSqlMapBuilder().Configure(configPath);

                _mapper.SessionStore = new HybridWebThreadSessionStore(_mapper.Id);
            }
        }

        public TResult One<TResult>(string command, object parameter)
        {
            try
            {
                _mapper.OpenConnection();


                return _mapper.QueryForObject<TResult>(command, parameter);
            }
            finally
            {
                _mapper.CloseConnection();
            }
        }

        public IList<TResult> All<TResult>(string command, object parameter)
        {
            try
            {
                _mapper.OpenConnection();


                return _mapper.QueryForList<TResult>(command, parameter);
            }
            finally
            {
                _mapper.CloseConnection();
            }
        }

        private string GetRuntimeSql(ISqlMapper sqlMapper, string statementName, object paramObject)
        {
            string result = string.Empty;
            try
            {
                IMappedStatement mappedStatement = sqlMapper.GetMappedStatement(statementName);

                if (sqlMapper.IsSessionStarted)
                {
                    RequestScope requestScope = mappedStatement.Statement.Sql.GetRequestScope(mappedStatement, paramObject, sqlMapper.LocalSession);

                    result = requestScope.PreparedStatement.PreparedSql;
                }
                else
                {
                    result = "尚未打开链接";
                }
            }
            catch (Exception ex)
            {
                result = "获取SQL语句出现异常:" + ex.Message;
            }
            return result;
        }
    }
}
