#region Header

// Program.cs: The main entry point of QrCodeGeneratorWithLogo
// Copyright© 2021 ArdeshirV@protonmail.com, Licensed under LGPLv3+

using System;
using ArdeshirV.Forms;
using System.Windows.Forms;

#endregion Header
//---------------------------------------------------------------------------------------
namespace ArdeshirV.Applications.QrCodeGeneratorWithLogo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        	FormMain formMain = null;
        	try {
	            Application.EnableVisualStyles();
	            Application.SetCompatibleTextRenderingDefault(false);
	            formMain = new FormMain();
	            Application.Run(formMain);
        	} catch(Exception exp) {
        		FormErrorHandler.Show(formMain, exp);
        	}
        }
    }
}
