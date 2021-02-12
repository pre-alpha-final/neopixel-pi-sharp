using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace NeoPixelPiSharp
{
    class Program
    {
        const string script =
            "import board" +
            "import neopixel" +
            "" +
            "pixels = neopixel.NeoPixel(board.D18, 1, pixel_order = neopixel.RGBW)" +
            "pixels.fill((0, 255, 0))";

        static void Main(string[] args)
        {
            ScriptEngine pythonEngine = Python.CreateEngine();
            ScriptSource pythonScript = pythonEngine.CreateScriptSourceFromString(script);
            pythonScript.Execute();
        }
    }
}
