
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Castle.Windsor;
using Castle.Windsor.Installer;
using ExcelDna.Integration.CustomUI;

namespace RibbonSampleInExcelDNA
{
    [ComVisible(true)]
    public class Ribbon : ExcelRibbon
    {
        private static readonly WindsorContainer Container;

        // DI configuration must happen before
        // the ribbon constructor is called.
        // May want to move this out to another
        // class so that testing this class
        // doesn't spin up a container.
        // Alterbatively, simply DON'T put 
        // anything of consequence in this class.
        static Ribbon()
        {
            Container = new WindsorContainer();
            Container.Install(FromAssembly.This());
        }

        private readonly ISampleService _sampleService;

        // It's not great to be referincing the 
        // container here but ExcelDNA doesn't know 
        // about the DI container we're using and
        // and doesn't offer a facility for DI,
        // as such.
        public Ribbon() : this(Container.Resolve<ISampleService>())
        {
        }
       
        public Ribbon(ISampleService sampleService)
        {
            _sampleService = sampleService;
        }

        public void OnButtonPressed(IRibbonControl control)
        {
            string altredControlName = _sampleService.ReturnName(control.Id);
            MessageBox.Show("My Button Pressed on control " + altredControlName, "ExcelDna Ribbon!");
        }
    }

}
