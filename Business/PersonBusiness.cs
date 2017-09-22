using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Repository;
using Repository.Interfaces;
using Business.Exceptions;

namespace Business
{
    public class PersonBusiness : IPersonBusiness
    {

        private IUnitOfWork _uow = null;

        public PersonBusiness()
        {
            this._uow = new UnitOfWork();
        }

        public PersonBusiness(IUnitOfWork uow)
        {
           this. _uow = uow;
        }

        public Person Insert(Person entity)
        {
            try
            {
                var entityReturn = _uow.PersonRepository.Add(entity);
                _uow.Commit();
                return entityReturn;
            }
            catch(Exception e)
            {
                throw new BusinessException(e.Message);
            }
        }

        public Person GetById(int id)
        {
            try
            {
                return _uow.PersonRepository.Get(id);
            }
            catch (Exception ex)
            {
                throw new BusinessException(ex.Message);
            }
        }

        public bool Update(Person entity)
        {
            throw new NotImplementedException();
        }

        public IList<Person> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
