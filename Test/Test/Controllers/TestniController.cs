using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudijeDataAccess; //dodajte StudijeDataAccess

namespace Test.Controllers
{
	public class TestniController : ApiController
	{
		public static STUDIJEEntities s = new STUDIJEEntities();

		public IEnumerable<Studenti> Get()
		{
			return s.Studentis.ToList();

		}

		public static void Post(Studenti student)
		{
			s.Studentis.Add(student);
			s.SaveChanges();
		}

		public static void Put(short indeks, short upisan, string imes)
		{
			var stud = (from st in s.Studentis
						where st.Indeks == indeks && st.Upisan == upisan
						select st).FirstOrDefault();

			stud.Imes = imes;
			s.SaveChanges();
		}

		public static void Delete(short indeks, short upisan)
		{
			var stud = (from st in s.Studentis
						where st.Indeks == indeks && st.Upisan == upisan
						select st).FirstOrDefault();

			s.Studentis.Remove(stud);
			s.SaveChanges();
		}
	}
}
