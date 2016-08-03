using Ninject;

namespace Tasky
{
    public static class App
    {
        public static StandardKernel Container { get; set; }

        public static void Initialize()
        {
            var kernel = new Ninject.StandardKernel(new NinjectBindings());

            App.Container = kernel;
        }
    }
}