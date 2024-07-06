using Repo_DB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo_DB.Abstract
{
    public interface IFunction
    {
        string AddData(User user);
        User GetLogin(User user);
    }

}
