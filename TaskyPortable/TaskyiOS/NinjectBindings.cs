using Ninject.Modules;
using Tasky.Managers;
using TaskyPortableLibrary.Contracts;

namespace Tasky
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            this.Bind<ISQLiteConnectionManager>().To<SQLiteConnectionManager>();
        }
    }
}