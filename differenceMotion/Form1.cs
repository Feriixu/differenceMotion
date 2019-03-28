using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;

namespace differenceMotion
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo;
        private Bitmap oldBitmap = null;
        private Bitmap newBitmap = null;
        private double sensitivity = 0.15;
        private int averageDetections = 0;

        public Form1()
        {
            InitializeComponent();
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo VideoCaptureDevice in VideoCaptureDevices)
            {
                comboBoxDevices.Items.Add(VideoCaptureDevice.Name);
            }

            comboBoxDevices.SelectedIndex = 0;

            FinalVideo = new VideoCaptureDevice(VideoCaptureDevices[comboBoxDevices.SelectedIndex].MonikerString);

            foreach (var capability in FinalVideo.VideoCapabilities)
            {
                comboBoxModes.Items.Add(capability.FrameSize.ToString() + ":" + capability.FrameRate.ToString());
            }

            comboBoxModes.SelectedIndex = 0;

            FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
        }

        private void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap tempFrame = (Bitmap)eventArgs.Frame.Clone();
            int detections = 0;
            if (oldBitmap != null)
            {
                newBitmap = new Bitmap(tempFrame, tempFrame.Width, tempFrame.Height);
                for (int width = 0; width < tempFrame.Width; width+=4)
                {
                    for (int height = 0; height < tempFrame.Height; height+=4)
                    {
                        Color oldColor = oldBitmap.GetPixel(width, height);
                        Color newColor = tempFrame.GetPixel(width, height);
                        float difference = Math.Abs(oldColor.GetBrightness() - newColor.GetBrightness());
                        if (difference > sensitivity)
                        {
                            detections++;
                            for (int i = 0; i < 4; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    newBitmap.SetPixel(width + i, height + j, Color.Red);
                                }
                            }
                        }
                        //if (oldColor.GetBrightness() > 0.999)
                        //{
                        //    for (int i = 0; i < 4; i++)
                        //    {
                        //        for (int j = 0; j < 4; j++)
                        //        {
                        //            newBitmap.SetPixel(width + i, height + j, Color.Green);
                        //        }
                        //    }
                        //}
                        else
                        {
                        }
                    }
                }

                averageDetections = ((averageDetections * 5) + detections) / 6;

                if (detections - averageDetections > 20)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 2; j < 12; j++)
                        {
                            newBitmap.SetPixel(i, j, Color.Green);
                        }

                    }
                }

                try
                {
                    for (int i = 0; i < detections; i++)
                    {
                        newBitmap.SetPixel(i, 0, Color.Blue);
                    }
                }
                catch { }
                try
                {
                    for (int i = 0; i < averageDetections; i++)
                    {
                        newBitmap.SetPixel(i, 1, Color.Red);
                    }
                }
                catch { }
                
                pictureBox1.BackgroundImage = newBitmap;
                oldBitmap = tempFrame;
            }
            else
            {
                pictureBox1.BackgroundImage = (Image)tempFrame;
                oldBitmap = tempFrame;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalVideo != null) FinalVideo.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinalVideo.VideoResolution = FinalVideo.VideoCapabilities[comboBoxModes.SelectedIndex];
            FinalVideo.Start();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            sensitivity = (double)trackBarSensitivity.Value / 100;
        }
         
    }
}
