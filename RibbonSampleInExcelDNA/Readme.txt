Skeleton C# Excel DNA project
=============================

This is a C# Skeleton project showing an Excel DNA ribbon and user defined
function.

* The UI is defined in "RibbonSampleInExcelDNA-AddIn.dna"
* When adding images for the ribbon be sure to add a line
  to your .dna file to ensure that the image is embedded 
  into the .xll.  The line should be of the form: 

	<Image Name="M" Path="M.png" Pack="true" />

  Add the image to the project and ensure that "Copy if newer"
  is selected for the file or ExcelDNA won't find it.
* The sample shows how to use Castle Windsor if you're comfortable
  with and would like to use that style.

