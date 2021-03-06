// <auto-generated />
namespace Microsoft.Framework.DependencyInjection.Interfaces
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.Framework.DependencyInjection.Interfaces.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// Unable to locate suitable constructor for type '{0}'. Ensure the type is concrete and all parameters are accepted by a constructor.
        /// </summary>
        internal static string NoConstructorMatch
        {
            get { return GetString("NoConstructorMatch"); }
        }

        /// <summary>
        /// Unable to locate suitable constructor for type '{0}'. Ensure the type is concrete and all parameters are accepted by a constructor.
        /// </summary>
        internal static string FormatNoConstructorMatch(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NoConstructorMatch"), p0);
        }

        /// <summary>
        /// No service for type '{0}' has been registered.
        /// </summary>
        internal static string NoServiceRegistered
        {
            get { return GetString("NoServiceRegistered"); }
        }

        /// <summary>
        /// No service for type '{0}' has been registered.
        /// </summary>
        internal static string FormatNoServiceRegistered(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NoServiceRegistered"), p0);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
