using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication2.Models;

namespace WebApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new Model1();

            var newEntry = new fileInfo() { volID = 1, pciFlag = 1, confidentialFlag = 1 };

            ctx.fileInfoes.Add(newEntry);

            ctx.SaveChanges();

            //List<fileInfo> departments = new List<fileInfo>();

            //Data Source=DESKTOP-VSI09HO\SQLEXPRESS;Initial Catalog=V1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False

            Console.WriteLine(newEntry);
            Console.ReadKey();

        }
    }
}