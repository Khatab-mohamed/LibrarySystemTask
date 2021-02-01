using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem.Application.ViewModels;

namespace LibrarySystem.Application.Interfaces
{
    public interface IAnswersService
    {
        Task<AnswersModel> GetAnswers();
    }
}
