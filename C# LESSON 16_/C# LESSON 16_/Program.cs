using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;

 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press Enter To Take Screeshot");

 

        while (true)
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {

                CaptureScreenAndSaveToDesktop();
                Console.WriteLine("ScreenShot Took");
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.Q)
            {

                break;
            }
        }
    }

 

    static void CaptureScreenAndSaveToDesktop()
    { 
        int screenWidth = 2000;
        int screenHeight = 2000;

 

       
        using (Bitmap screenshot = new Bitmap(screenHeight,screenWidth))
        {
            using (Graphics graphics = Graphics.FromImage(screenshot))
            {
                graphics.CopyFromScreen(0, 0, 0, 0, new Size(screenHeight, screenWidth));
            }

 

          
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string screenshotPath = System.IO.Path.Combine(desktopPath, "screenshot.png");

 

            screenshot.Save(screenshotPath, ImageFormat.Png);
        }
    }
}