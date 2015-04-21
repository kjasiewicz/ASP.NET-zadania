using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj06
{
    class CsvExporter:IExport
    {

        public string Export(List<ExamResult> examResults)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in examResults)
            {
                sb.AppendFormat("{0};{1}",
                    item.IndexNo,
                    item.Grade);
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
