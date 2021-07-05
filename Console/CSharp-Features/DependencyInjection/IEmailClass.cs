using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
   public interface IEmailClass
    {
        void AccountRecorary(string email);

        public void UseEmail(string email);

        public void FullEmail(List<string> emails, string subject, string body);
    }
}
