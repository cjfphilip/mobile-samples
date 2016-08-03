using Ninject.Modules;
using TaskyAndroid.Managers;
using TaskyPortableLibrary.Contracts;

namespace TaskyAndroid
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ISQLiteConnectionManager>().To<SQLiteConnectionManager>();
        }
    }
}