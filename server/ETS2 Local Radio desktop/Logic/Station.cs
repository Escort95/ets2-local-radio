﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using ETS2_Local_Radio_server.Properties;
using Svg;

namespace ETS2_Local_Radio_server
{
    static class Station
    {
        [DllImport("gpcomms.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GPSL_SetTextLineData(
            byte cObjectNumber,
            int wTextPosX,
            int wTextPosY,
            string pTextLine,
            int dwTextColor,
            bool bBlackBackground,
            byte cSize,
            bool bTextBold,
            byte cFontFamily
        );
        [DllImport("gpcomms.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GPSL_ShowText(
            byte cObjectNumber,
            bool bShowIt
        );
        [DllImport("gpcomms.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GPPIC_LoadNewPicture(
            string sPathToFile
        );
        [DllImport("gpcomms.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GPPICI_LoadNewInternalPicture(
            byte[] pData,
            int uiDataSize
        );
        [DllImport("gpcomms.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GPPIC_ShowPicturePos(
            bool bShowIt,
            int wPosX,
            int wPosY
        );
        [DllImport("gpcomms.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GPPICI_ShowInternalPicturePos(
            bool bShowIt,
            int wPosX,
            int wPosY
        );

        [DllImport("gpcomms.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GPSI_GetScreenSize(
            ref int piScreenX,
            ref int piScreenY
        );

        public static string NowPlaying = "Now playing: ";

        public static System.Timers.Timer Timer = new System.Timers.Timer();

        public static void SetStation(string name, string signal, string logoPath = null)
        {
            try
            {
                if (Settings.Overlay)
                {
                    int width = 0, height = 0;
                    GPSI_GetScreenSize(ref width, ref height);
                    System.Threading.Thread.Sleep(10);
                    GPSI_GetScreenSize(ref width, ref height);

                    if (width == 0 || height == 0)
                    {
                        width = Screen.PrimaryScreen.WorkingArea.Width;
                        height = Screen.PrimaryScreen.WorkingArea.Height;
                    }

                    //GPSL_SetTextLineData(0, 10, 10, name, Color.FromArgb(255, 174, 0).ToArgb(), false, 25, true, 0);
                    //GPSL_ShowText(0, true);

                    Image bmp = new Bitmap(Resources.overlay_double);

                    RectangleF rectf = new RectangleF(0, 0, bmp.Width, bmp.Height);

                    Graphics g = Graphics.FromImage(bmp);

                    //g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                    StringFormat format = new StringFormat()
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    var font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);

                    var stringSize = g.MeasureString(NowPlaying + " " + name, font);
                    var nowPlayingSize = g.MeasureString(NowPlaying + " ", font);
                    var topLeft = new PointF((512 / 2) - (stringSize.Width / 2) + 123,
                        (bmp.Height / 2) - (stringSize.Height / 2));
                    //var rectangle = new Rectangle(0, 0, (int)stringSize.Width, (int)stringSize.Height);
                    var brush = new SolidBrush(Color.FromArgb(255, 174, 0));
                    //var brush = new LinearGradientBrush(rectangle, Color.White, Color.FromArgb(255, 174, 0), 0.0f, false);
                    g.DrawString(name, font, brush, new PointF(topLeft.X + nowPlayingSize.Width, topLeft.Y));
                    g.DrawString(NowPlaying, font, Brushes.White, topLeft);

                    switch (signal)
                    {
                        case "0":
                            g.DrawImage(Resources.signal_0, 593, bmp.Height - 36, 32, 32);
                            break;
                        case "1":
                            g.DrawImage(Resources.signal_1, 593, bmp.Height - 36, 32, 32);
                            break;
                        case "2":
                            g.DrawImage(Resources.signal_2, 593, bmp.Height - 36, 32, 32);
                            break;
                        case "3":
                            g.DrawImage(Resources.signal_3, 593, bmp.Height - 36, 32, 32);
                            break;
                        case "4":
                            g.DrawImage(Resources.signal_4, 593, bmp.Height - 36, 32, 32);
                            break;
                        case "5":
                            g.DrawImage(Resources.signal_5, 593, bmp.Height - 36, 32, 32);
                            break;
                    }
                    if (logoPath != null)
                    {
                        if (logoPath.StartsWith("http"))
                        {
                            using (var client = new WebClient())
                            {
                                var newPath = Directory.GetCurrentDirectory() + "\\tmp" + Path.GetExtension(logoPath);
                                client.DownloadFile(logoPath, newPath);
                                logoPath = newPath;
                            }
                        }
                        else
                        {
                            logoPath = Directory.GetCurrentDirectory() +
                                       @"\web\" + logoPath.Replace("/", "\\");
                        }
                        //var logo = Image.FromFile(Directory.GetCurrentDirectory() + @"\web\stations\images-america\tucson\La Caliente.png");
                        //MessageBox.Show(Directory.GetCurrentDirectory() +
                        //                @"\web\" + logoPath.Replace("/", "\\"));
                        try
                        {
                            
                            if (logoPath.EndsWith("svg"))
                            {
                                try
                                {
                                    var img = SvgDocument.Open(logoPath);
                                    logoPath = logoPath.Replace(".svg", ".png");
                                    using (Bitmap tempImage = new Bitmap(img.Draw()))
                                    {
                                        tempImage.Save(logoPath);
                                    }
                                    //img.Save(logoPath, ImageFormat.Png);
                                }
                                catch (Exception)
                                {
                                    logoPath = logoPath.Replace(".svg", ".png");
                                }
                            }

                            var logo = new Bitmap(logoPath);

                            var logoHeight = (float)logo.Height;
                            var logoWidth = (float)logo.Width;
                            if (logoHeight > 0.41f * logoWidth)
                            {
                                logoWidth = (float)((90f / logoHeight) * logoWidth);
                                logoHeight = 90;
                            }
                            else if (logoHeight <= 0.41f * logoWidth)
                            {
                                logoHeight = (float)((220f / logoWidth) * logoHeight);
                                logoWidth = 220;
                            }

                            //MessageBox.Show("bmpw: " + bmp.Width + "; bmph: " + bmp.Height + "; logow: " + logoWidth.ToString() + "; logoh: " + logoHeight.ToString());

                            g.DrawImage(logo, (256 / 2) - (logoWidth / 2) + 645, (bmp.Height / 2) - (logoHeight / 2), logoWidth,
                                logoHeight);
                        }
                        catch (Exception ex)
                        {
                            Log.Write(logoPath);
                            Log.Write(ex.ToString());
                        }
                    }


                    g.Flush();

                    //TODO: Get memory picture to work.
                    //MemoryStream ms = new MemoryStream();
                    //bmp.Save(ms, ImageFormat.Png);

                    //GPPICI_LoadNewInternalPicture(ms.ToArray(), (int) ms.Length);
                    //GPPICI_ShowInternalPicturePos(true, (width/2) - (Resources.overlay.Width/2), (height/4));

                    bmp.Save(Directory.GetCurrentDirectory() + @"\overlay.png");

                    GPPIC_LoadNewPicture(Directory.GetCurrentDirectory() + @"\overlay.png");
                    GPPIC_ShowPicturePos(true, (width / 2) - (bmp.Width / 2), (height / 4));

                    Timer.Interval = 4000;
                    Timer.Elapsed += (sender, args) =>
                    {
                        Timer.Enabled = false;
                        Timer.Stop();
                        GPPIC_ShowPicturePos(false, (width / 2) - (Resources.overlay.Width / 2), (height / 4));
                        //GPPICI_ShowInternalPicturePos(false, (width/2) - (Resources.overlay.Width/2), (height/4));
                        //Log.Write("Hide overlay");
                    };
                    Timer.Enabled = true;
                    Timer.Start();
                }
            }
            catch (Exception ex)
            {
                Log.Write(ex.ToString());
            }
        }
    }
}
