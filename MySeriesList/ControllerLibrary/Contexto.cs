using ModelLibrary;
using System;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace ControllerLibrary
{
	class Contexto : DbContext
	{
		public Contexto() : base("strConn")
		{

		}
		public DbSet<Serie> Series { get; set; }

		public override int SaveChanges()
		{
			try
			{
				return base.SaveChanges();
			}
			catch (DbEntityValidationException e)
			{
				foreach (var eve in e.EntityValidationErrors)
				{
					Console.WriteLine("Entidade do tipo \"{0}\" no estado \"{1}\" tem os seguintes erros de validação:",
						eve.Entry.Entity.GetType().Name, eve.Entry.State);
					foreach (var ve in eve.ValidationErrors)
					{
						Console.WriteLine("- Property: \"{0}\", Erro: \"{1}\"",
							ve.PropertyName, ve.ErrorMessage);
					}
				}
				throw;
			}
		}
	}
}




