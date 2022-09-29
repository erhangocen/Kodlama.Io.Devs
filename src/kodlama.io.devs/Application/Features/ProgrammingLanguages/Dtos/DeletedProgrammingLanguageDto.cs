﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProgrammingLanguages.Dtos
{
    public class DeletedProgrammingLanguageDto
    {
        public string Name { get; set; }
        public string Message { get; set; }

        public DeletedProgrammingLanguageDto()
        {
            Message = "Programming language has been deleted";
        }
    }
}
