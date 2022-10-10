using Application.Features.Technologies.Constants;
using Core.Persistence.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Technologies.Dtos
{
    public class UpdatedTechnologyDto : CommandDto
    {
        public int Id { get; set; }
        public int ProgrammingLanguageId { get; set; }
        public string Name { get; set; }

        public UpdatedTechnologyDto()
        {
            Message = TechnologyMessages.UpdateTechnologyMessage; 
        }
        
    }
}
