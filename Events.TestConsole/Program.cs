using Events.Dal.Model;
using Events.Dal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var etRepo = new RepositoryBase<EventTypes>();
            //etRepo.Add(new EventTypes { Name = "Conference" });

            var et = etRepo.Get(1);
            etRepo.Dispose();
            etRepo = new RepositoryBase<EventTypes>();

            et.Name = "Conference2";
            etRepo.Update(et);
            etRepo.Commit();
        }
    }
}
