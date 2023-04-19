using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLab.Core.Services
{
    public interface IEmailService // bu arabirimde SendMail metodunun cagrildiginda yapacagi isleri tanimladik, bir alici(recipient) bir konu ve bir icerik olacak dedik
    {
        Task SendMail(string recipient, string subject, string body);
    }
}
