using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Infrastructure.Interface
{
public interface IDapperRepositoryBase
{

        IEnumerable<T> GetItems<T>(CommandType commandType, string sql, object parameters = null);
        int Execute(CommandType commandType, string sql, object parameters = null);
        //T Select<T>(T criteria);
        IEnumerable<T> SelectAll<T>();


        T Select<T>(int Id);

        void Insert<T>(T obj);

        void Update<T>(T obj);

        void Delete<T>(int Id);


     

}
}
