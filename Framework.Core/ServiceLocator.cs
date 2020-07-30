using System.Diagnostics;

namespace Framework.Core
{
    public static class ServiceLocator
    {
        public static IServiceLocator Current { get; private set; }
        public static void Set(IServiceLocator serviceLocator)
        {
            Debug.Assert(Current == null, "Service locator is not null");

            Current = serviceLocator;
        }
    }
}
