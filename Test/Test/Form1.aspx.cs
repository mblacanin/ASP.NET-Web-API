using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudijeDataAccess; // obavezno importujte
using Test.Controllers; // obavezno importujte

namespace Test
{
	public partial class Form1 : System.Web.UI.Page
	{
		STUDIJEEntities s = new STUDIJEEntities();


		protected void Button1_Click(object sender, EventArgs e)
		{
			Studenti student = new Studenti();
			student.Indeks = short.Parse(TextBox1.Text);
			student.Upisan = short.Parse(TextBox2.Text);
			student.Imes = TextBox3.Text;
			student.Mesto = TextBox4.Text;
			student.Ssmer = short.Parse(TextBox5.Text);

			TestniController.Post(student);
		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			TestniController.Put(short.Parse(TextBox1.Text), short.Parse(TextBox2.Text), TextBox3.Text);
		}

		protected void Button3_Click(object sender, EventArgs e)
		{
			TestniController.Delete(short.Parse(TextBox1.Text), short.Parse(TextBox2.Text));
		}
	}
}