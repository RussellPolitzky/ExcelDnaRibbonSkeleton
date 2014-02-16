using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace RibbonSampleInExcelDNA
{

    public interface ISampleService
    {
        string ReturnName(string name);
    }

    public class SampleService : ISampleService
    {
        public string ReturnName(string name)
        {
            return "Name is: " + name;
        }
    }


    public class DIConfiguration : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                    Component
                        .For<ISampleService>()
                        .ImplementedBy<SampleService>()
                );
        }
    }
}
