using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.Common;
using Services.Common.CRUD;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace TripSystemTest.Controllers.CRUD
{
    public abstract class CrudController<T, TDTO, TService, TSM> : AppBaseController
                where T : class
        where TDTO : class, new()
        where TSM : SMBase
        where TService : ICrudService<T, TDTO, TSM>
    {
        protected TService service;
        protected IMapper mapper;

        protected CrudController(TService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        [Route("listRecords")]
        public virtual List<TDTO> GetAll()
        {
            return this.service.GetAll();
        }

        [Route("List")]
        public virtual DTOPaginatedList<TDTO> List([FromBody] TSM searchModel)
        {
            var list = this.service.List(searchModel);
            return list;
        }
 
        [Route("{id}")]
        public virtual IActionResult Get(int id)
        {
            T entity = this.service.GetById(id);
            if (entity == null)
                return NotFound();
            TDTO dto = mapper.Map<TDTO>(entity);
            return Ok(dto);
        }

        [Route("Default")]
        public virtual IActionResult GetDefaultEntity()
        {
            TDTO entity = new TDTO();
            return Ok(entity);
        }

        [HttpPost]
        public virtual async Task<IActionResult> PostAsync([FromBody] TDTO dto)
        {
            try
            {
                T entity = ConvertDTOTOEntity(dto);
                entity = await InsertAsync(entity, dto);
                await HandleSuccessCreateAsync(entity);
                return Ok(mapper.Map<TDTO>(entity));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpPut]
        public virtual async Task<IActionResult> PutAsync([FromBody] TDTO dto)
        {
            try
            {
                T entity = ConvertDTOTOEntity(dto);
                entity = await UpdateAsync(entity, dto);
                return Ok(mapper.Map<TDTO>(entity));
            }

            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        

        [HttpDelete]
        [Route("{id}")]
        public virtual async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                await service.Delete(id);
                await HandleSuccessDeleteAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

         
        protected virtual async Task<T> UpdateAsync(T entity, TDTO dto)
        {
            await service.Update(entity);
            return entity;
        }

        protected virtual async Task<T> InsertAsync(T entity, TDTO dto)
        {

            return await service.CreateAndGet(entity);
        }

        protected virtual Task HandleSuccessCreateAsync(T entity)
        {
            return Task.CompletedTask;
        }

        protected virtual Task HandleSuccessDeleteAsync(int id)
        {
            return Task.CompletedTask;
        }


        protected virtual T ConvertDTOTOEntity(TDTO dto)
        {
            return mapper.Map<T>(dto);
        }

    }
}
