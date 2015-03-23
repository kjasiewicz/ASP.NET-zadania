using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using zaj04.Models;
using zaj04.Repository.Intefaces;

namespace zaj04.Repository.Concrete
{
    public class StaticConferenceRepository : IConferenceRepository
    {
        private static List<Conference> _conferenceRegistrations;
        static StaticConferenceRepository()
        {
            _conferenceRegistrations = new List<Conference>();
        }
        public StaticConferenceRepository()
        {

        }
        public void Add(Models.Conference conference)
        {
            _conferenceRegistrations.Add(conference);
        }

        public IQueryable<Models.Conference> GetAll()
        {
            return _conferenceRegistrations.AsQueryable();
        }
    }
}