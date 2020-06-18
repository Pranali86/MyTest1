using crudmvc.ConstructorStudy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crudmvc
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public delegate void MyDelegateString(string text);
        //public delegate string MyDelegateString(string text); //for string
        public delegate int MyDelegate(int x, int y);
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void OnConfirm()
        {
            string confirmValue = Request.Form["confirm_value"];
            if (confirmValue == "Yes")
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You clicked YES!')", true);
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You clicked NO!')", true);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = 1990;
            Classconst cs = new Classconst(a);
        }
        public static void ShowText(string text)// in case return type string then void
        {
            Console.WriteLine(text);
            //return text;  // for string
        }
        static int Sum(int x, int y) 
        {
            return x + y;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            //MyDelegate d = new MyDelegate(Sum);
            // int result = d.Invoke(12, 15);
            //Response.Write("<srcipt>alert('" + result + "')</srcipt>");
            MyDelegateString d = new MyDelegateString(ShowText);
            //string msg = d("Hello World..."); // for string
            d("Hello World...");
           // Response.Write("<srcipt>alert('" + msg + "')</srcipt>");
            //Console.WriteLine(result);
            //Console.ReadLine();
        }
    }
}