using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class User
    {
        bool _status;
        public bool Status 
        { 
            get 
            { 
            return _status;
            
            } 
            set 
            { 
            _status = value;    
            
            }
        }


        public void Login(string username, string password)
        {
           // bool status=false;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                Status=false;
            }
            else if (username == "anushka" && password == "Anu@123")
            {
                Status = true;
            }
            else {

                Status = false;
            }
             
        }

        public void Login(string username, int otp)
        { 
        }

        public void Login(string emailid, string password, int otp)
        { 
        
        }
        public void Login(int otp, string password, string  emailid)
        { 
        }

        public void Login(string emailid)
        { }
        public void Login(long mobileNo)
        { }


    }
}
