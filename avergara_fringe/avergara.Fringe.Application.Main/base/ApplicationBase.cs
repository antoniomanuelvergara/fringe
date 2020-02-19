using AutoMapper;
using avergara.Fringe.Domain.Interface;
using avergara.Fringe.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Application.Main
{
    public class ApplicationBase<T, E>
    {

        
        private IDomainBase<E> _domainBase;

        public IDomainBase<E> DomainBase
        {
            get { return _domainBase; }
            set { _domainBase = value; }
        }


        public IMapper _mapper { get; set; }



        #region sincronos



        public Response<bool> Delete(int Id)
        {
            var response = new Response<bool>();
            try
            {
                
                bool a = _domainBase.Delete(Id);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Se ha borrado registro!!!";
                }
            }
            catch (Exception e)
            {

                response.Message = e.Message;
            }

            return response;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Response<T> Get(int Id)
        {
            var response = new Response<T>();

            try
            {

                var dataResult = _domainBase.Get(Id);

                response.Data = _mapper.Map<T>(dataResult);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }


            }
            catch (Exception e)
            {

                response.Message = e.Message;
            }

            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Response<IEnumerable<T>> GetAll()
        {
            var response = new Response<IEnumerable<T>>();
            try
            {



                var datas = _domainBase.GetAll();
                //como el resultado lo obtengo en forma de entidad, lo mapeo  a una lista de fringeDTO, lo que hago es que le especifico el destino
                response.Data = _mapper.Map<IEnumerable<T>>(datas);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }


        public Response<bool> Insert(T dataDto)
        {
            var data = _mapper.Map<E>(dataDto);

            var response = new Response<bool>();
            bool a=_domainBase.Insert(data);

            if (response.Data)
            {
                response.IsSuccess = true;
                response.Message = "Se ha insertado registro!!!";
            }


            return response;
        }


        public Response<bool> Update(T dataDto)
        {
            var data = _mapper.Map<E>(dataDto);

            var response = new Response<bool>();
            bool a = _domainBase.Update(data);

            if (response.Data)
            {
                response.IsSuccess = true;
                response.Message = "Se ha insertado registro!!!";
            }


            return response;
        }
        #endregion



        #region asincronos

        public Task<Response<bool>> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<IEnumerable<T>>> GetAllAsync(string TableName)
        {
            throw new NotImplementedException();
        }

        public Task<Response<T>> GetAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> InsertAsync(T dataDto)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> UpdateAsync(T dataDto)
        {
            throw new NotImplementedException();
        }




        #endregion
    }
}

