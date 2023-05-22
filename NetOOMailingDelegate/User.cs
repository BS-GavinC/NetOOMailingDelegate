using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetOOMailingDelegate
{
    public class User
    {

        public User(string email)
        {
            Email = email;
        }

        public string Email { get; set; }

        public void ReceiveNews(string content)
        {
            Console.WriteLine($"{Email} a recu la news : {content}");
        }

        public void ReceivePub(string content)
        {
            Console.WriteLine($"{Email} a recu la pub : {content}");
        }


    }
}
