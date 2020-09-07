using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IAccountRepo
    {
        bool InsertAccount(Account acc);
        bool DeleteAccount(Account acc);
        bool UpdateAccount(Account acc);
       
        Account GetAccount(string billno);
        List<Account> GetAllAccount();





        
    }
}
