using SoftwareLab.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLab.Infrastructure.Services
{
    public class EmailService : IEmailService
    {
        public Task SendMail(string recipient, string subject, string body)
        {
            //TODO: Send mail operaions
            return Task.CompletedTask;
        }
    }
}
