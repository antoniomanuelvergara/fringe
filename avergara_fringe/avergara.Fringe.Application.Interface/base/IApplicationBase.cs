using avergara.Fringe.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Application.Interface
{

public interface IApplicationBase<T>
{
        #region Metodos sincronos

        Response<bool> Insert(T dataDto);
        Response<bool> Update(T dataDto);
        Response<bool> Delete(int Id);
        Response<T> Get(int Id);
        Response<IEnumerable<T>> GetAll();
        

        #endregion

        #region Metodos asincronos

        Task<Response<bool>> InsertAsync(T dataDto);
        Task<Response<bool>> UpdateAsync(T dataDto);
        Task<Response<bool>> DeleteAsync(int Id);
        Task<Response<T>> GetAsync(int Id);
        Task<Response<IEnumerable<T>>> GetAllAsync(string TableName);

        #endregion

    }


}
