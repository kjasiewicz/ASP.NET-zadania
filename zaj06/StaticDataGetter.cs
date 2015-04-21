using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj06
{
    class StaticDataGetter : IExportDataGetter
    {
        public List<ExamResult> Get()
        {
            return new List<ExamResult>
           {
                new ExamResult{IndexNo=Guid.NewGuid(), Grade=3},
                new ExamResult{IndexNo=Guid.NewGuid(), Grade=4},
                new ExamResult{IndexNo=Guid.NewGuid(), Grade=5},
                new ExamResult{IndexNo=Guid.NewGuid(), Grade=3},
           };

        }
    }
}
