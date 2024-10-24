using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw7.Interface
{
    public interface IAutentication
    {

        public string Regester( string username , string password , string email);
        public string Login(string username , string password);
    }
}
