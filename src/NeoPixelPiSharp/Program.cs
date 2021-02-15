using System;
using System.Diagnostics;
using System.IO;

namespace NeoPixelPiSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            const string PythonExecutable = "python3";

            var ScriptFilename = $"{Guid.NewGuid()}.py";
            var scriptContents = string.Join(Environment.NewLine, new[]
            {
                "import board",
                "import neopixel",
                "",
                "pixels = neopixel.NeoPixel(board.D18, 1, pixel_order = neopixel.GRB)",
                "pixels.fill((0, 255, 0))",
            });
            File.WriteAllText(ScriptFilename, scriptContents);

            var processStartInfo = new ProcessStartInfo
            {
                FileName = PythonExecutable,
                Arguments = ScriptFilename,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
            using (var process = Process.Start(processStartInfo))
            using (var reader = process.StandardOutput)
            {
                string result = reader.ReadToEnd();
                Console.Write(result);
            }

            File.Delete(ScriptFilename);
        }
    }
}
