using Monstrosity.BLL.Models;
using System.Collections.Generic;

namespace Monstrosity.BLL.Interfaces
{
    public interface IContactService : IBaseService<ContactDTO, int>
    {
        IEnumerable<ContactDTO> GetRegular();
        IEnumerable<ContactDTO> GetEmployees();
        IEnumerable<ContactDTO> GetPotential();
    }
}
