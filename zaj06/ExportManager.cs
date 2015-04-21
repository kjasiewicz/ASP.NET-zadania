using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace zaj06
{
    class ExportManager
    {
        private IExport _exporter;
        private IExportDataGetter _exportDataGetter;
        public ExportManager(IExport exporter, IExportDataGetter exportDataGetter)
        {
            _exporter = exporter;
            _exportDataGetter = exportDataGetter;
        }
        public void RunExport(List<ExamResult> results=null)
        {
            var sw = Stopwatch.StartNew();
            if (results!=null)
            {
                Console.WriteLine(_exporter.Export(results));
            }
            else
            {
                Console.WriteLine("From Getter");
                Console.WriteLine(_exporter.Export(_exportDataGetter.Get()));
            }
            Console.WriteLine(_exporter.Export(results));
            Console.WriteLine("ElapsedMilliseconds: {0})",
                sw.ElapsedMilliseconds);
        }
    }
}
