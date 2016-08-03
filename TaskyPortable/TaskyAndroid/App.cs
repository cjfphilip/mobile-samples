using System;
using System.IO;
using SQLite;
using Android.App;
using Tasky.PortableLibrary.Managers;
using Android.Runtime;
using Ninject;

namespace TaskyAndroid
{
	[Application]
	public class App : Application {
		public static App Current { get; private set; }

		public TodoItemManager TodoManager { get; set; }
		
        public static IKernel Container { get; set; }

        public App(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
        {
			Current = this;
		}

		public override void OnCreate()
		{
            Container = new Ninject.StandardKernel(new NinjectBindings());

            base.OnCreate();

            TodoManager = Container.Get<TodoItemManager>();
        }
	}
}

