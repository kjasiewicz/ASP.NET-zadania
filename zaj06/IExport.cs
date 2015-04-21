using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj06
{
    interface IExport
    {
        string Export(List<ExamResult> examResults);
        
    }
}
