using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Common.Aspects.Postsharp.ExceptionAspects;
using Common.Aspects.Postsharp.LogAspects;
using Common.Aspects.Postsharp.PerformanceAspects;
using Common.CrossCuttingConcerns.Logging.Log4Net.Loggers;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Business")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Business")]
[assembly: AssemblyCopyright("Copyright ©  2020")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Aspects .....
[assembly: LogAspect(typeof(DatabaseLogger),AttributeTargetTypes = "Business.Concrete.*")]
[assembly: ExceptionLogAspect(typeof(DatabaseLogger),AttributeTargetTypes = "Business.Concrete.*")]
[assembly: PerformanceCounterAspect(10,AttributeTargetTypes = "Business.Concrete.*")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("fe3d7157-a534-48b4-8d16-48e979281de0")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
