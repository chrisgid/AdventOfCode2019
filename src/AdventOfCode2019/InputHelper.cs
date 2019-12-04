using System.Diagnostics;
using System.IO;

namespace AdventOfCode2019
{
    public static class InputHelper
    {
        /// <summary>
        /// Creates a Stream for the embedded input.txt from the same namespace as the calling class
        /// </summary>
        public static Stream GetInputTxtStream()
        {
            var frame = new StackFrame(1);
            var callingMethod = frame.GetMethod();
            var type = callingMethod.DeclaringType;
            var typeNamespace = type.Namespace;
            var assembly = type.Assembly;

            return assembly.GetManifestResourceStream($"{typeNamespace}.input.txt");
        }
    }
}
