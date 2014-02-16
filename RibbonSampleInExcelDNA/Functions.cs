using ExcelDna.Integration;

namespace RibbonSampleInExcelDNA
{
    public static class Functions
    {
        // This adds a description only.  Excel DNA will expose the 
        // function without this description.
        [ExcelFunction(Description = "My first .NET function")]
        public static string HelloDna(string name)
        {
            return "Hello " + name;
        }
    }
}
