using System;
using System.Collections.Generic;

namespace WinFormsGUI
{
	public interface IRelation
	{
	}

	public class Relation<T1,T2> : IRelation
	{
	}

	public class Model
	{
		List<IRelation> relations = new List<IRelation> ();
		public Model ()
		{
			relations.Add (new Relation<Setup, LocalRepository> ());
			relations.Add (new Relation<Setup, Overlay> ());
			relations.Add (new Relation<Overlay, LocalRepository> ());
			relations.Add (new Relation<LocalRepository, Category> ());
			relations.Add (new Relation<Category, Ebuild> ());
		}

		private bool IsDatabaseExists()
		{
			return true;
		}

		public void CreateDatabase()
		{
		}

		public Setup LoadOrCreateSetup()
		{
			if (IsDatabaseExists() == false) {
				CreateDatabase ();
			}
			return new Setup ();
		}
	}
}

