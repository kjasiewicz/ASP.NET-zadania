using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace zaj06
{
    class JsonExporter :IExport
    {

        public string Export(List<ExamResult> examResults)
        {
            return JsonConvert.SerializeObject(examResults);
        }
    }
}
