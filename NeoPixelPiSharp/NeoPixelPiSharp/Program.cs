using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace NeoPixelPiSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ScriptEngine pythonEngine = Python.CreateEngine();
            ScriptSource pythonScript = pythonEngine.CreateScriptSourceFromString("print 'Hello World!'");
            pythonScript.Execute();
        }
    }
}
