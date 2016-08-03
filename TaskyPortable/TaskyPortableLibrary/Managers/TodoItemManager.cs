using System;
using System.Collections.Generic;
using SQLite;
using Tasky.PortableLibrary.Repositories;
using Tasky.PortableLibrary.Models;
using TaskyPortableLibrary.Contracts;

namespace Tasky.PortableLibrary.Managers
{
	/// <summary>
	/// Manager classes are an abstraction on the data access layers
	/// </summary>
	public class TodoItemManager 
	{
	    readonly TodoItemRepository repository; 

		public TodoItemManager (ISQLiteConnectionManager connectionManager)
		{
			repository = new TodoItemRepository (connectionManager);
		}
		
		public TodoItem GetTask(int id)
		{
            //Here we would have code to make a REST call, potentially return the cached version straightaway with alongside the async task.
			return repository.GetTask(id);
		}
		
		public IList<TodoItem> GetTasks ()
		{
			return new List<TodoItem>(repository.GetTasks());
		}
		
		public int SaveTask (TodoItem item)
		{
			return repository.SaveTask(item);
		}
		
		public int DeleteTask(int id)
		{
			return repository.DeleteTask(id);
		}
	}
}