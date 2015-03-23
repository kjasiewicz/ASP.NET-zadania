using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zaj04.Models;

namespace zaj04.Repository.Intefaces
{
    public interface IConferenceRepository
    {
        void Add(Conference conference);
        IQueryable<Conference> GetAll();

    }
}
