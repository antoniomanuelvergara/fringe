using avergara.Fringe.Domain.Entity;
using avergara.Fringe.Infrastructure.Interface;
using avergara.Fringe.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Domain.Core
{
public class DomainBase<T>
{

        private IDapperRepositoryBase _dapperRepositoryBase;

      

        public IDapperRepositoryBase DapperRepositoryBase
        {
            get { return _dapperRepositoryBase; }
            set { _dapperRepositoryBase = value; }
        }



        #region sincronos

        public bool Insert(T data)
        {          

            _dapperRepositoryBase.Insert<T>(data);
            return true;

        
        }

        public bool Delete(int Id)
        {
            _dapperRepositoryBase.Delete<T>(Id);

            return true;
        }

        public T Get(int Id)
        {
      
            return _dapperRepositoryBase.Select<T>(Id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dapperRepositoryBase.SelectAll<T>();
        }

        public bool Update(T data)
        {
            _dapperRepositoryBase.Update<T>(data);
            return true;
        }

        #endregion



        #region asincronos

        public async Task<bool> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }


        public async Task<IEnumerable<T>> GetAllAsync(string tableName)
        {
            throw new NotImplementedException();
        }
        public async Task<T> GetAsync(int Id)
        {
            throw new NotImplementedException();
        }


        public Task<bool> InsertAsync(T data)
        {
            throw new NotImplementedException();
        }


        public async Task<bool> UpdateAsync(T data)
        {
            throw new NotImplementedException();
        }


        #endregion

    }
}
