using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AirPlayerRunner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;

        private void Form1_Load(object sender, EventArgs e)
        {
            string appPath = @"AirPlayer.exe"; // Path to the application you want to run

            // Start the application
            Process.Start(appPath);

            // Simulate a mouse click after a short delay to ensure the application is launched
            System.Threading.Thread.Sleep(1000); // Adjust this delay as needed

            // Get the handle of the application's main window
            IntPtr hWnd = FindWindow(null, "Airplayer"); // Provide the window title here

            if (hWnd != IntPtr.Zero)
            {
                Point OldPosition = Cursor.Position;

                // Calculate screen coordinates relative to the application's window
                Point point1 = new Point(500, 420);
                ClientToScreen(hWnd, ref point1);

                // Perform mouse click at the specified coordinates
                Cursor.Position = new System.Drawing.Point(point1.X, point1.Y);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)point1.X, (uint)point1.Y, 0, 0);

                System.Threading.Thread.Sleep(500); // Adjust this delay as needed

                Point point2 = new Point(740, 10);
                ClientToScreen(hWnd, ref point2);

                // Perform mouse click at the specified coordinates
                Cursor.Position = new System.Drawing.Point(point2.X, point2.Y);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)point2.X, (uint)point2.Y, 0, 0);

                System.Threading.Thread.Sleep(100); // Adjust this delay as needed

                Cursor.Position = OldPosition;
            }
            else
            {
                MessageBox.Show("Application window not found.");
            }
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
