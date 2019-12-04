using System.IO;
using System.Reflection;

namespace AdventOfCode2019
{
    public static class InputHelper
    {
        public static Stream GetInputStream(string embeddedResource)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var resourceName = FormatResourceName(assembly, embeddedResource);

            return assembly.GetManifestResourceStream(resourceName);
        }

        private static string FormatResourceName(Assembly assembly, string resourceName)
        {
            return assembly.GetName().Name + "." + resourceName.Replace(" ", "_")
                                                                .Replace("\\", ".")
                                                                .Replace("/", ".");
        }
    }
}
