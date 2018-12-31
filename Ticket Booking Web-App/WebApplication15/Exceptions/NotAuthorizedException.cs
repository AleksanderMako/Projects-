using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace WebApplication15.Exceptions
{
    public class NotAuthorizedException:Exception
    {


        public string errorSource;
        public NotAuthorizedException() { }
        public NotAuthorizedException(string soucre)
        {


            this.errorSource = soucre;

        }

    }


    public class Admin
    {
        public Admin() { }
        public static string isAdmin(string check, string location)
        {
            string message;
            try
            {
                if (check == "stoilov") message = "Acces granted,you can check all functionalities now";
                else throw new NotAuthorizedException();
            }
            catch (NotAuthorizedException ex)
            {
                ex.Source = location;
                message = "Error in : " + ex.Source + " to access this content you must be admin so type stoilov in the box";
                return message;



            }return "";
        }


    }
}