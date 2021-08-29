using System.Windows.Forms;

namespace ProjectAD
{
    public static class FullScreen
    {
        public static void EnterFullScreenMode(Form targetForm)
        {
            targetForm.WindowState = FormWindowState.Normal;
            targetForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            targetForm.WindowState = FormWindowState.Maximized;
        }

        public static void LeaveFullScreenMode(Form targetForm)
        {
            targetForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            targetForm.WindowState = FormWindowState.Normal;
        }
    }
}
