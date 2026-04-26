using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Messanger
{
    public class Accounts
    {
        public string Username { get; set; }
        public string EMail {  get; set; }
        public byte[] PasswordHash {  get; set; }
        public byte[] PasswordSalt {  get; set; }
    }
}
