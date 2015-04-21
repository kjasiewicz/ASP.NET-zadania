using Autofac;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dependency Injection = IoC
            

            //var builder = new ContainerBuilder();
            ////builder.RegisterType<CsvExporter>().As<IExport>();
            //builder.RegisterType<JsonExporter>().As<IExport>();
            //builder.RegisterType<StaticDataGetter>().As<IExportDataGetter>();
            //builder.RegisterType<ExportManager>();
            //var container = builder.Build();

            //Unity

            IUnityContainer container = new UnityContainer();
            container.RegisterType<IExport, JsonExporter>();
            container.RegisterType<IExportDataGetter, StaticDataGetter>();

            var data = new List<ExamResult>
            {
                new ExamResult{IndexNo=Guid.NewGuid(), Grade=3},
                new ExamResult{IndexNo=Guid.NewGuid(), Grade=4},
                new ExamResult{IndexNo=Guid.NewGuid(), Grade=5},
                new ExamResult{IndexNo=Guid.NewGuid(), Grade=3},
            };
            ExportManager em = container.Resolve<ExportManager>(); //new ExportManager(new CsvExporter());
            em.RunExport(data);
        }
    }
}
