using System;
using System.Collections.Generic;
using SQLite;
using Tasky.PortableLibrary.Models;
using Tasky.PortableLibrary.Database;
using TaskyPortableLibrary.Contracts;

namespace Tasky.PortableLibrary.Repositories
{
	public class TodoItemRepository
	{
		TodoDatabase db = null;

		public TodoItemRepository (ISQLiteConnectionManager connectionManager)
		{
			db = new TodoDatabase(connectionManager);
		}

		public TodoItem GetTask(int id)
		{
			return db.GetItem(id);
		}

		public IEnumerable<TodoItem> GetTasks ()
		{
			return db.GetItems();
		}

		public int SaveTask (TodoItem item)
		{
			return db.SaveItem(item);
		}

		public int DeleteTask(int id)
		{
			return db.DeleteItem(id);
		}
	}
}

