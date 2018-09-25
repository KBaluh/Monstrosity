using AutoMapper;
using Monstrosity.BLL.Interfaces;
using Monstrosity.BLL.Models;
using Monstrosity.DAL.Entities;
using Monstrosity.DAL.Interfaces;
using System.Collections.Generic;

namespace Monstrosity.BLL.Services
{
    public class ContactService : IContactService
    {
        private readonly IActivityUoW _unitOfWork;
        private readonly IMapper _mapper;

        public ContactService(IActivityUoW unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = new MapperConfiguration(cfg => cfg.CreateMap<Contact, ContactDTO>()).CreateMapper();
        }

        public ContactDTO Get(int id)
        {
            var entity = _unitOfWork.Contacts.Get(id);
            return _mapper.Map<Contact, ContactDTO>(entity);
        }

        public IEnumerable<ContactDTO> GetAll()
        {
            var entities = _unitOfWork.Contacts.GetAll();
            return _mapper.Map<IEnumerable<Contact>, IEnumerable<ContactDTO>>(entities);
        }

        public void Create(ContactDTO model)
        {
            var entity = _mapper.Map<ContactDTO, Contact>(model);
            try
            {
                _unitOfWork.Contacts.Create(entity);
                _unitOfWork.Commit();
            }
            catch
            {
                _unitOfWork.RejectChanges();
            }
        }

        public void Update(ContactDTO model)
        {
            var entity = _mapper.Map<ContactDTO, Contact>(model);
            try
            {
                _unitOfWork.Contacts.Update(entity);
                _unitOfWork.Commit();
            }
            catch
            {
                _unitOfWork.RejectChanges();
            }
        }

        public void Delete(int id)
        {
            try
            {
                _unitOfWork.Contacts.Delete(id);
                _unitOfWork.Commit();
            }
            catch
            {
                _unitOfWork.RejectChanges();
            }
        }

        public IEnumerable<ContactDTO> GetRegular()
        {
            var entities = _unitOfWork.Contacts.GetRegular();
            return _mapper.Map<IEnumerable<Contact>, IEnumerable<ContactDTO>>(entities);
        }

        public IEnumerable<ContactDTO> GetEmployees()
        {
            var entities = _unitOfWork.Contacts.GetEmployees();
            return _mapper.Map<IEnumerable<Contact>, IEnumerable<ContactDTO>>(entities);
        }

        public IEnumerable<ContactDTO> GetPotential()
        {
            var entities = _unitOfWork.Contacts.GetPotential();
            return _mapper.Map<IEnumerable<Contact>, IEnumerable<ContactDTO>>(entities);
        }
    }
}
