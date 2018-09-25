using Monstrosity.DAL.EF;
using Monstrosity.DAL.Entities;
using Monstrosity.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Monstrosity.DAL.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly MonsterContext _context;

        public ContactRepository(MonsterContext context)
        {
            _context = context;
        }

        public void Create(Contact entity)
        {
            _context.Contacts.Add(entity);
        }

        public void Delete(int key)
        {
            var entity = _context.Contacts.Find(key);
            if (entity != null)
                _context.Contacts.Remove(entity);
        }

        public Contact Get(int key)
        {
            return _context.Contacts.Find(key);
        }

        public IEnumerable<Contact> GetAll()
        {
            return _context.Contacts.Take(100).ToList();
        }

        public IEnumerable<Contact> GetAll(Func<Contact, bool> filter)
        {
            return _context.Contacts.Where(filter).ToList();
        }

        public IEnumerable<Contact> GetEmployees()
        {
            return _context.Contacts.Where(c => c.ContactTypeId == 3);
        }

        public IEnumerable<Contact> GetPotential()
        {
            return _context.Contacts.Where(c => c.ContactTypeId == 2);
        }

        public IEnumerable<Contact> GetRegular()
        {
            return _context.Contacts.Where(c => c.ContactTypeId == 1);
        }

        public void Update(Contact entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
