using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Technologies.Rules
{
    public class TechnologyBusinessRules
    {
        private readonly ITechnologyRepository _technologyRepository;
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;

        public TechnologyBusinessRules(ITechnologyRepository technologyRepository,IProgrammingLanguageRepository programmingLanguageRepository)
        {
            _technologyRepository = technologyRepository;
            _programmingLanguageRepository = programmingLanguageRepository;
        }

        public async Task TechnologyNameCanNotBeDuplicatedWhenInseted(string name)
        {
            IPaginate<Technology> result = await _technologyRepository.GetListAsync(p => p.Name == name);
            if (result.Items.Any()) throw new BusinessException("This programming language is already exist");
        }
        public async Task TechnologyMustExistWhenRequested(int id)
        {
            _ = await _technologyRepository.GetByIdAsync(id, enableTracking: false) ??
             throw new BusinessException("Requested technology does not exist");
        }
        
        public async Task ProgrammingLanguageMustExistWhenRequested(int id)
        {
            _ = await _programmingLanguageRepository.GetByIdAsync(id, enableTracking: false) ??
             throw new BusinessException("Requested technology does not exist");
        }
    }
}
