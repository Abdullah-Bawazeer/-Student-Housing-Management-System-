using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentProject
{
    public class AddUserControlToPanel
    {
        private static Panel _pnContainer;
      

        public static void  InitilializePanel(Panel panel)
        {
              _pnContainer = panel?? throw new ArgumentNullException(nameof(panel),"panel cannot be null");
        }
        public static void ShowUserControl(UserControl UC)
        {
            if(_pnContainer == null)
            {
                throw new InvalidOperationException("Manager not initilaized!");
            }
            if(UC == null)
            {
                throw new ArgumentNullException(nameof(UC), "Controls cannot be null");
            }
           
            _pnContainer.Controls.Clear();
            _pnContainer.Controls.Add(UC);
            UC.Dock = DockStyle.Fill;
            UC.BringToFront();
        }
    }
}
