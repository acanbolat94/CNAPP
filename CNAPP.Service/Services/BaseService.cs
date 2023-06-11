using CNAPP.Entity.Context;
using CNAPP.Repository.Abstract;
using CNAPP.Service.Concrete;
using System;
using System.Linq;

namespace CNAPP.Service.Services
{
    public class BaseService<TRepository, TDto, TEntity> where TRepository : IBaseRepository<TEntity>
    {
        protected ServiceResponse response { get; set; }
        protected TRepository repository { get; set; }
        protected SingletonContext<CNAPPContext> singleTon { get; set; } = new SingletonContext<CNAPPContext>();
        public BaseService()
        {
            repository = (TRepository)Activator.CreateInstance(typeof(TRepository), singleTon.DbContext);
        }

        public ServiceResponse GetAll()
        {
            try
            {
                response = new ServiceResponse();
                var entity = repository.GetAll().ToList();
                response.Data = entity;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.ResponseType = Enum.ResponseType.error;
                response.Success = false;
            }
            return response;
        }

        public ServiceResponse GetById(int id)
        {
            try
            {
                response = new ServiceResponse();
                var entity = Mapping.Mapper.Map<TDto>(repository.GetById(id));
                response.Data = entity;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.ResponseType = Enum.ResponseType.error;
                response.Success = false;
            }
            return response;
        }

        public ServiceResponse Insert(TDto dto)
        {
            try
            {
                response = new ServiceResponse();
                var entity = Mapping.Mapper.Map<TEntity>(dto);
                repository.Insert(entity);
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.ResponseType = Enum.ResponseType.error;
                response.Success = false;
            }
            return response;
        }

        public ServiceResponse InsertAndComplete(TDto dto)
        {
            try
            {
                response = new ServiceResponse();
                var entity = Mapping.Mapper.Map<TEntity>(dto);
                repository.InsertAndComplete(entity);
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.ResponseType = Enum.ResponseType.error;
                response.Success = false;
            }
            return response;
        }

        public ServiceResponse Update(TDto dto)
        {
            try
            {
                response = new ServiceResponse();
                var entity = Mapping.Mapper.Map<TEntity>(dto);
                repository.Update(entity);
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.ResponseType = Enum.ResponseType.error;
                response.Success = false;
            }
            return response;
        }

        public ServiceResponse UpdateAndComplete(TDto dto)
        {
            try
            {
                response = new ServiceResponse();
                var entity = Mapping.Mapper.Map<TEntity>(dto);
                repository.UpdateAndComplete(entity);
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.ResponseType = Enum.ResponseType.error;
                response.Success = false;
            }
            return response;
        }

        public ServiceResponse Delete(TDto dto)
        {
            try
            {
                response = new ServiceResponse();
                var entity = Mapping.Mapper.Map<TEntity>(dto);
                repository.Delete(entity);
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.ResponseType = Enum.ResponseType.error;
                response.Success = false;
            }
            return response;
        }

        public ServiceResponse DeleteAndComplete(TDto dto)
        {
            try
            {
                response = new ServiceResponse();
                var entity = Mapping.Mapper.Map<TEntity>(dto);
                repository.DeleteAndComplete(entity);
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.ResponseType = Enum.ResponseType.error;
                response.Success = false;
            }
            return response;
        }
    }
}
