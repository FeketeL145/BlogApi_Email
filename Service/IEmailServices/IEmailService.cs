using BlogApi.Models.Dtos;
using System;

namespace BlogApi.Service.IEmailServices
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
