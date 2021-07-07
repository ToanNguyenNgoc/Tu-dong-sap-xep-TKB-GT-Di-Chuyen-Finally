using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThoiKhoaBieu 
{
  static class Program
  {
    public static NhiemSacThe nst;
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      nst = new NhiemSacThe();
     Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
           frmMain fMain = new frmMain();
            //Application.Run(fMain);
            frmDangKy frmDk = new frmDangKy();
            frmDN frmdn = new frmDN();
            frmError frmE = new frmError();
            
           
      Application.Run(frmdn);
      Application.Exit();
    }
  }
}
