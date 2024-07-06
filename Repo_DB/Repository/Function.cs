using Microsoft.EntityFrameworkCore;
using Repo_DB.Abstract;
using Repo_DB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo_DB.Repository
{
     public class Function:IFunction
    {
        Context_User _user = new Context_User();
        public string AddData(User user) 
        {
          String name = String.Empty;
            try
            {
                _user.UserInfo.Add(user);
                _user.SaveChanges();
                name = "Done";

            }
            catch (Exception ex) { 
             name = ex.Message;
            
            }    
            return name;        
        }

     

        public User GetLogin(User user)
        {
            var data = _user.UserInfo.FirstOrDefault(p => p.Password == user.Password && p.Email == user.Email);
            return data;
        }

    }
}
