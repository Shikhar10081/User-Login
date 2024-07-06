using Repo_DB.Abstract;
using Repo_DB.Model;
using Repo_DB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class BL_Function
    {
        IFunction fun= new Function();

        public string Adddata(User user)
        {
            var data = fun.AddData(user);
            return data; 


        }

        public User Login(User user)
        {
            var data= fun.GetLogin(user);
            return data;
        }

    }
}
