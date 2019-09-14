using APS_4.Model.Entities;
using APS_4.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_4.Model.Services
{
    public class OrderArray : IOrderArray
    {
        /// <summary>
        /// This method will call each ordering type and return a list with their time
        /// </summary>
        /// <param name="userList"></param>
        /// <returns></returns>
        IList<UserList> IOrderArray.OrderArray(UserList userList)
        {
            return null;
        }
    }
}
