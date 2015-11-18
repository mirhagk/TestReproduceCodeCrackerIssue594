using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReproduceCodeCrackerIssue594
{
    class Program
    {
        class ChangePasswordMessageId
        {
        }
        static string AlterPassword(ChangePasswordMessageId message)
        {
            if (message != null)
                return "";
            return "AlterPassword";
        }
        static void Main(string[] args)
        {
        }
    }
}
