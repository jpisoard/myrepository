using System;
using System.Diagnostics;

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRepository.Domain;
using System.Configuration;
using NHibernate.Cfg;
using NHibernate;
using System.Reflection;


namespace MyRepository
{
    class StartClass
    {
        static void Main()
        {

            try {
                Configuration configuration = new Configuration();
                configuration.AddAssembly(typeof (Movie).Assembly);
                ISessionFactory SessionFactory = configuration.BuildSessionFactory();
                ISession session = SessionFactory.OpenSession();

                using (ITransaction transaction = session.BeginTransaction())
                {
                    Movie movie = new Movie();
                    movie.Title = "SpiderMan";
                    movie.Author = "Warner";
                    session.Save(movie);
                    transaction.Commit();
                }
                
                IQuery query = session.CreateQuery("FROM Movie");
                IList<Movie> movies = query.List<Movie>();
                Debug.WriteLine("count" + movies.Count);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.StackTrace);
            }
        }
    }
}
