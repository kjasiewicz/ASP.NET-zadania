using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using zaj04.Models;
using zaj04.Repository.Concrete;
using zaj04.ViewModel;

namespace zaj04.BLL
{
    [DataObject]
    public class ConferenceService
    {
        private StaticConferenceRepository _conferenceRepository;
        public ConferenceService()
        {
            _conferenceRepository = new StaticConferenceRepository();
        }

        public void Register(ConferenceViewModel conferenceViewModel)
        {
            _conferenceRepository.Add(new Conference
            {
                AuthorFirstName = conferenceViewModel.AuthorFirstName,
                AuthorLastName = conferenceViewModel.AuthorLastName,
                AuthorMail = conferenceViewModel.AuthorMail,
                ArticleTitle = conferenceViewModel.ArticleTitle,
                ArticleAbstract = conferenceViewModel.ArticleAbstract
            });
        }

        public IList<ConferenceViewModel> Get()
        {
            return _conferenceRepository.GetAll().Select(n =>
                new ConferenceViewModel
                {
                    AuthorFirstName = n.AuthorFirstName,
                    AuthorLastName = n.AuthorLastName,
                    AuthorMail = n.AuthorMail,
                    ArticleTitle = n.ArticleTitle,
                    ArticleAbstract = n.ArticleAbstract
                }).ToList();
        }

        public IList<ConferenceViewModel> Get(int maximumRows, int StartRowIndex)
        {
            return Get().Skip(StartRowIndex).Take(maximumRows).ToList();
        }
        public int GetCount()
        {
            return _conferenceRepository.GetAll().Count();
        }
    }
}