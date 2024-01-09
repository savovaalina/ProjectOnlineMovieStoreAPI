
namespace OnlineMovieStore.Services
{
    using OnlineMovieStore.Entities;
    using OnlineMovieStore.Repository.Interfaces;
    using OnlineMovieStore.Service.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LanguageService : ILanguageService
    {

        private readonly ILanguageRepository _languageRepository;

        public LanguageService(ILanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }

        public void Add(Language language)
        {
            _languageRepository.Add(language);
        }

        public void Delete(Language language)
        {
            _languageRepository.Delete(language);
        }

        public void Edit(Language language)
        {
            _languageRepository.Edit(language);
        }

        public IEnumerable<Language> GetAllLanguages(Language language)
        {
            var result = _languageRepository.GetAllLanguages(language);
            return result;
        }

        public Language GetLanguageById(int id)
        {
            var result = _languageRepository.GetLanguageById(id);
            return result;
        }

    }
}
