using OnlineMovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Repository.Interfaces
{
	public interface ILanguageRepository
    {
        void Add(Language language);
        void Edit(Language language);

        void Delete(Language language);

        Language GetLanguageById(int id);
        IEnumerable<Language> GetAllLanguages(Language language);
    }
}
