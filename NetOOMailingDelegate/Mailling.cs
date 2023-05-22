using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetOOMailingDelegate
{
    public class Mailling
    {

        delegate void Mail(string content);

        Mail news = null;

        Mail pubs = null;

        public void SendNews(string content)
        {
            news(content);
        }

        public void SendPubs(string content)
        {
            pubs(content);
        }

        public void SubToNews(User user)
        {
            news += user.ReceiveNews;
        }

        public void SubToPubs(User user)
        {
            pubs += user.ReceivePub;
        }

        public void UnSubToNews(User user)
        {
            news -= user.ReceiveNews;
        }

        public void UnSubToPubs(User user)
        {
            pubs -= user.ReceivePub;
        }

    }
}
