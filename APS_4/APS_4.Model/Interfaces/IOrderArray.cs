using APS_4.Model.Entities;
using System.Collections.Generic;

namespace APS_4.Model.Interfaces
{
    public interface IOrderArray
    {
        IList<UserList> OrderArray(UserList userList);
    }
}
