using Monstrosity.DAL.Entities;
using System.Collections.Generic;

namespace Monstrosity.DAL.Interfaces
{
    public interface IContactRepository : IRepository<Contact, int>
    {
        IEnumerable<Contact> GetRegular();
        IEnumerable<Contact> GetEmployees();
        IEnumerable<Contact> GetPotential();
    }
}
