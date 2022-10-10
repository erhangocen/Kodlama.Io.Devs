using Application.Features.ProgrammingLanguages.Constants;
using Core.Persistence.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProgrammingLanguages.Dtos
{
    public class UpdatedProgrammingLanguageDto : CommandDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public UpdatedProgrammingLanguageDto()
        {
            Message = ProgrammingLanguageMessages.UpdateProgrammingLanguageMessage;
        }
    }
}
