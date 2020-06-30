using System.CodeDom.Compiler;

[assembly: global::Xunit.TestFramework("TechTalk.SpecFlow.xUnit.SpecFlowPlugin.XunitTestFrameworkWithAssemblyFixture", "TechTalk.SpecFlow.xUnit.SpecFlowPlugin")]
[assembly: global::TechTalk.SpecFlow.xUnit.SpecFlowPlugin.AssemblyFixture(typeof(global::Eventos_IO_TestesAutomatizados_XUnitAssemblyFixture))]

[GeneratedCode("SpecFlow", "3.1.97")]
public class Eventos_IO_TestesAutomatizados_XUnitAssemblyFixture : global::System.IDisposable
{
    private readonly global::System.Reflection.Assembly _currentAssembly;

    public Eventos_IO_TestesAutomatizados_XUnitAssemblyFixture()
    {
        _currentAssembly = typeof(Eventos_IO_TestesAutomatizados_XUnitAssemblyFixture).Assembly;
        global::TechTalk.SpecFlow.TestRunnerManager.OnTestRunStart(_currentAssembly);
    }

    public void Dispose()
    {
        global::TechTalk.SpecFlow.TestRunnerManager.OnTestRunEnd(_currentAssembly);
    }
}
