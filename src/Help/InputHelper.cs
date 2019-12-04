using System.IO;
using System.Reflection;

namespace Help
{
    public static class InputHelper
    {
        public static Stream GetInputStream()
        {
            var callingAssembly = Assembly.GetCallingAssembly();

            var resourceName = FormatResourceName(callingAssembly, "input.txt");

            return callingAssembly.GetManifestResourceStream(resourceName);
        }

        private static string FormatResourceName(Assembly assembly, string resourceName)
        {
            return assembly.GetName().Name + "." + resourceName.Replace(" ", "_")
                                                                .Replace("\\", ".")
                                                                .Replace("/", ".");
        }
    }
}
