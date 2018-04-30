using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// by Mark Hawes
// WebAddress program
// Week 5
// actual converter code - in its own class, takes company name
// and generates a website from it

namespace WebAddress
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    } // end main

    public class WebAddressConverter
    {
        // private variables - security!
        private string company, webAddress = null;
        private string WEB_PREFIX = "www.", WEB_POSTFIX = ".com";

        // initializes converter with a given company name
        public WebAddressConverter(string company)
        {
            this.company = company;
        }

        // initializes class no constructor
        public WebAddressConverter()
        {
            this.company = null;
        }

        // method to convert given company name into a webaddress
        // and save it to the webAddress variable
        public void RunConvert()
        {
            webAddress = WEB_PREFIX + company.Replace(" ", "").ToLower()
                + WEB_POSTFIX;
        }

        // changes company name to input name then runs converter
        // method, and returns address all at once
        public string WebConverter(string company)
        {
            // saves input as company name
            this.company = company;

            // runs converter
            RunConvert();

            // returns current saved web address
            return GetWebAddress();
        }

        // returns web address
        public string GetWebAddress()
        {
            return webAddress;
        }
    } // end WebAddressConverter
}
