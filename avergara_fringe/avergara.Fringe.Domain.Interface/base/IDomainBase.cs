using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Domain.Interface
{ 
public interface IDomainBase<T>
{
    #region Metodos sincronos

    bool Insert(T data);
    bool Update(T data);
    bool Delete(int Id);
    T Get(int Id);
    IEnumerable<T> GetAll();

    #endregion



    #region Metodos asincronos

    Task<bool> InsertAsync(T data);
    Task<bool> UpdateAsync(T data);
    Task<bool> DeleteAsync(int Id);
    Task<T> GetAsync(int Id);
    Task<IEnumerable<T>> GetAllAsync(string TableName);
   

        #endregion
    }
}
