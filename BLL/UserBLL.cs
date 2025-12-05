using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyThi_490.DAL;
namespace MyThi_490.BLL
{
    internal class UserBLL
    {
        public void Insert(User objUser)
        {
           UserDAL objUserDAL = new UserDAL();
            objUserDAL.Insert(objUser);

        }

    }
}
