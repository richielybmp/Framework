using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace System.IO_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("If you want to try ASP.NET, you can install Visual Web Developer Express using the Microsoft Web Platform Installer, which is a free tool that makes it simple to download, install, and service components of the Microsoft Web Platform. These components include Visual Web Developer Express, Internet Information Services (IIS), SQL Server Express, and the .NET Framework. All of these are tools that you use to create ASP.NET Web applications. You can also use the Microsoft Web Platform Installer to install open-source ASP.NET and PHP Web applications.");
            File.AppendAllText(@"d:\1.txt", sb.ToString());

            string [] values = {"Line 1", "Line 2", "Line 3"};
            File.AppendAllLines(@"d:\2.txt", values);

            //File.Copy(@"d:\1.txt", @"d:\3.txt");

            //File.Encrypt(@"d:\3.txt");

            File.Decrypt(@"d:\3.txt");

            


        }
    }
}
