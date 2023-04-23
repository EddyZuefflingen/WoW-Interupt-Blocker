using Gma.System.MouseKeyHook;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace InteruptBlocker
{
    public partial class MainForm : MetroForm
    {
        Point castbarLocation = new Point(1534, 1061); //Point on Screen where the cast bar of the enemy is
        Color interuptableCastbarColor = Color.FromArgb(255, 186, 41); //Color of the interupable cast

        public MainForm()
        {
            InitializeComponent();
            StartKeyListener();
        }

        IKeyboardMouseEvents m_GlobalHook;
        int InteruptBlockedCount = 0;

        public void StartKeyListener()
        {
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyDown += GlobalHookKeyDown;
        }

        private void GlobalHookKeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys != Keys.Shift && e.KeyCode == Keys.F)
            {
                var color = GetColorAt(castbarLocation);
                if (GetActiveWindowTitle() == "World of Warcraft")
                {
                    if (color.R == interuptableCastbarColor.R && color.G == interuptableCastbarColor.R && color.B == interuptableCastbarColor.B)
                    {
                        lblInteruptCountVal.Text = "" + InteruptBlockedCount;
                        InteruptBlockedCount++;
                        Console.WriteLine($"Keys Supressed: {InteruptBlockedCount}");
                        e.SuppressKeyPress = true;
                    }
                }
            }
        }

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        public Color GetColorAt(Point location)
        {
            Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }
    }
}
