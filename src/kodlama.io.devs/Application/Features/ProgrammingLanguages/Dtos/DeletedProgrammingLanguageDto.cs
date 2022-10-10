using Application.Features.ProgrammingLanguages.Constants;
using Core.Persistence.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProgrammingLanguages.Dtos
{
    public class DeletedProgrammingLanguageDto : CommandDto
    {
        public int Id { get; set; }

        public DeletedProgrammingLanguageDto()
        {
            Message = ProgrammingLanguageMessages.DeleteProgrammingLanguageMessage;
        }
    }
}
