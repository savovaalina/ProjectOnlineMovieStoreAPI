

namespace OnlineMovieStore.Service.Interfaces
{
    using OnlineMovieStore.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ILanguageService
    {
        void Add(Language language);
        void Edit(Language language);

        void Delete(Language language);

        Language GetLanguageById(int id);
        IEnumerable<Language> GetAllLanguages(Language language);
    }
}
