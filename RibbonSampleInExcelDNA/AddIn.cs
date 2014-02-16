using ExcelDna.Integration;

namespace RibbonSampleInExcelDNA
{
    /// <summary>
    ///  Deals with lifecycle events.
    /// </summary>
    public class AddIn : IExcelAddIn
    {
        /// <summary>
        /// Note that the autoopen method is 
        /// only called after the ribbon has been
        /// initialised.  As such, it's not the
        /// first entry point and is therefore 
        /// not suitable for DI configuration.
        /// </summary>
        public void AutoOpen()
        {
        }

        public void AutoClose()
        {
        }
    }
}