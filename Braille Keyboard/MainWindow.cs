using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;


namespace BrailleKeyboard
{
    public partial class MainWindow : Form
    {
        KinectTracker kinectController;

        public MainWindow()
        {
            InitializeComponent();
            kinectController = new KinectTracker();

            kinectController.setEventColorReady(drawColorImage);

            if (kinectController.isConnected())
            {
                kinectController.start();

                // Show the default values of the Kinect settings
                double initialTheta = kinectController.settings.theta / (Math.PI / 180);
                //thetaTextBox.Text = initialTheta.ToString();
                //thetaTrackBar.Value = (int)initialTheta;

                int initialK = kinectController.settings.k;
                //kTextBox.Text = initialK.ToString();
                //kTrackBar.Value = initialK;

                float initialNearSpace = kinectController.settings.nearSpacePerc;
                //NearSpaceTextBox.Text = initialNearSpace.ToString();
                //NearSpaceTrackBar.Value = (int)(initialNearSpace * 100);

                textMarginLeft.Text = kinectController.settings.marginLeftPerc.ToString();
                textMarginRight.Text = kinectController.settings.marginRightPerc.ToString();
                textMarginTop.Text = kinectController.settings.marginTopPerc.ToString();
                textMarginBot.Text = kinectController.settings.marginBotPerc.ToString();

                //smoothTextBox.Text = kinectController.settings.smoothingIterations.ToString();
                //smoothTrackBar.Value = kinectController.settings.smoothingIterations;

                //boxReductionTextBox.Text = ((int)(kinectController.settings.containerBoxReduction * 100)).ToString();
                //boxReductionTrackBar.Value = (int)(kinectController.settings.containerBoxReduction * 100);
            }
            else
            {
                // Show an error
                Console.WriteLine("Kinect device unavailable. Please connect Kinect and restart.\n");
            }

        }

        // Show the color image in both image elements
        private void drawColorImage()
        {
            colorImage.Image = kinectController.getColorImage();
            trackingImage.Image = kinectController.getColorImage();
        }

        // Show the color and tracked images in the image elements
        private void drawDepthImage()
        {
            colorImage.Image = kinectController.getColorImage();
            trackingImage.Image = kinectController.getDepthImage();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            // Do nothing after the depth image is ready
            kinectController.clearEventDepthReady();

            // Show the image after the color image is ready
            KinectTracker.afterReady a = drawColorImage;
            kinectController.setEventColorReady(a);
        }

        private void depthButton_Click(object sender, EventArgs e)
        {
           // int img_count = 0;
            // Do nothing after the Camera color image is ready
            kinectController.clearEventColorReady();

            // After the depth image is ready and the tracking done
            KinectTracker.afterReady a = drawDepthImage; // Show the depth image
           // img_count += 1;
            Application.DoEvents();
            //if (KinectTracker.img_count % 5 == 0)
            //{
                a = a + showNumberFingers; // Show the number of fingers
            //}
            kinectController.setEventDepthReady(a);
        }

        //private void thetaTrackBar_Scroll(object sender, EventArgs e)
        //{
        //    kinectController.settings.theta = thetaTrackBar.Value * (Math.PI / 180);
        //    thetaTextBox.Text = thetaTrackBar.Value.ToString();
        //}

        //private void kTrackBar_Scroll(object sender, EventArgs e)
        //{
        //    kinectController.settings.k = kTrackBar.Value;
        //    kTextBox.Text = kTrackBar.Value.ToString();
        //}

        private void showNumberFingers()
        {
            ThreadPool.QueueUserWorkItem(delegate
            {

                    if (kinectController.hands.Count == 1)
                    {
                        Invoke(new Action(delegate { alphabetbox.Text = "Show Both Hands"; }));
                    }
                if (kinectController.hands.Count > 1)
                {
                    if (kinectController.hands[0].fingertips.Count > 0 && kinectController.hands[1].fingertips.Count == 0)
                    {
                        //fingersTextBox1.Text = kinectController.hands[0].fingertips.Count.ToString();
                        if (kinectController.hands[0].fingertips.Count == 2)
                        {
                                if (Math.Abs(kinectController.hands[0].fingertips[0].X - kinectController.hands[0].fingertips[1].X) < 17)
                                {
                                    Invoke(new Action(delegate { alphabetbox.Text = "B"; }));
                                    Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.B);
                                    Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.B);
                                    Thread.Sleep(10000);
                                }
                                else
                                {
                                    Invoke(new Action(delegate { alphabetbox.Text = "K"; }));
                                    Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.K);
                                    Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.K);
                                    Thread.Sleep(10000);
                                }
                        }
                        else if (kinectController.hands[0].fingertips.Count == 1)
                        {
                            Invoke(new Action(delegate { alphabetbox.Text = "A"; }));
                            Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.A);
                            Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.A);
                            Thread.Sleep(10000);

                        }
                        else if (kinectController.hands[0].fingertips.Count == 3)
                        {
                            Invoke(new Action(delegate { alphabetbox.Text = "L"; }));
                            Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.L);
                            Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.L);
                            Thread.Sleep(10000);
                        }
                    }
                    if (kinectController.hands.Count > 1)
                    {

                        if (kinectController.hands[0].palm.Y > kinectController.hands[1].palm.Y)
                        {

                            HandDetection temp = kinectController.hands[0];
                            kinectController.hands[0] = kinectController.hands[1];
                            kinectController.hands[1] = temp;

                        }
                        //fingersTextBox2.Text = kinectController.hands[1].fingertips.Count.ToString();
                        if (kinectController.hands[0].fingertips.Count == 1 && kinectController.hands[1].fingertips.Count == 1)
                        {
                            if (Math.Abs(kinectController.hands[0].fingertips[0].X - kinectController.hands[1].fingertips[0].X) < 10)
                            {
                                Invoke(new Action(delegate { alphabetbox.Text = "C"; }));
                                Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.C);
                                Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.C);
                                Thread.Sleep(10000);
                            }
                            else if ((kinectController.hands[0].fingertips[0].X - kinectController.hands[1].fingertips[0].X) > 10)
                            {
                                Invoke(new Action(delegate { alphabetbox.Text = "I"; }));
                                Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.I);
                                Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.I);
                                Thread.Sleep(10000);
                            }
                            else if ((kinectController.hands[0].fingertips[0].X - kinectController.hands[1].fingertips[0].X) < -10)
                            {
                                Invoke(new Action(delegate { alphabetbox.Text = "E"; }));
                                Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.E);
                                Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.E);
                                Thread.Sleep(10000);
                            }
                            //DIFFERENTIATE B/W I AND E

                        }
                        else if ((kinectController.hands[0].fingertips.Count == 1 && kinectController.hands[1].fingertips.Count == 2)) //|| (kinectController.hands[0].fingertips.Count == 2 && kinectController.hands[1].fingertips.Count == 1))
                        {
                            if (Math.Abs(kinectController.hands[0].fingertips[0].X - kinectController.hands[1].fingertips[0].X) < 10)
                            {
                                Invoke(new Action(delegate { alphabetbox.Text = "D"; }));
                                Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.D);
                                Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.D);
                                Thread.Sleep(10000);
                            }
                            else
                            {
                                Invoke(new Action(delegate { alphabetbox.Text = "J"; }));
                                Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.J);
                                Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.J);
                                Thread.Sleep(10000);
                            }
                        }
                        else if ((kinectController.hands[0].fingertips.Count == 2 && kinectController.hands[1].fingertips.Count == 1)) //|| (kinectController.hands[0].fingertips.Count == 2 && kinectController.hands[1].fingertips.Count == 1))
                        {
                            if (Math.Abs(kinectController.hands[0].fingertips[0].X - kinectController.hands[1].fingertips[0].X) < 10)
                            {
                                if (Math.Abs(kinectController.hands[0].fingertips[0].X - kinectController.hands[0].fingertips[1].X) < 20)
                                {
                                    Invoke(new Action(delegate { alphabetbox.Text = "F"; }));
                                    Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.F);
                                    Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.F);
                                    Thread.Sleep(10000);
                                }
                                else
                                {
                                    Invoke(new Action(delegate { alphabetbox.Text = "M"; }));
                                    Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.M);
                                    Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.M);
                                    Thread.Sleep(10000);
                                }
                            }
                            else if (Math.Abs(kinectController.hands[0].fingertips[1].X - kinectController.hands[1].fingertips[0].X) < 10)
                            {
                                if (Math.Abs(kinectController.hands[0].fingertips[0].X - kinectController.hands[0].fingertips[1].X) < 20)
                                {
                                    Invoke(new Action(delegate { alphabetbox.Text = "H"; }));
                                    Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.H);
                                    Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.H);
                                    Thread.Sleep(10000);
                                }
                                else
                                {
                                    Invoke(new Action(delegate { alphabetbox.Text = "U"; }));
                                    Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.U);
                                    Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.U);
                                    Thread.Sleep(10000);
                                }
                            }
                            else if (Math.Abs(kinectController.hands[0].fingertips[0].X - kinectController.hands[0].fingertips[1].X) < 20)
                            {
                                Invoke(new Action(delegate { alphabetbox.Text = "S"; }));
                                Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.S);
                                Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.S);
                                Thread.Sleep(10000);
                            }
                            else
                            {
                                Invoke(new Action(delegate { alphabetbox.Text = "O"; }));
                                Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.O);
                                Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.O);
                                Thread.Sleep(10000);
                            }
                        }
                        else if (kinectController.hands[0].fingertips.Count == 2 && kinectController.hands[1].fingertips.Count == 2)
                        {
                            if (Math.Abs(kinectController.hands[0].fingertips[0].X - kinectController.hands[1].fingertips[0].X) < 10)
                            {
                                if (Math.Abs(kinectController.hands[0].fingertips[1].X - kinectController.hands[1].fingertips[1].X) < 10)
                                {
                                    if (Math.Abs(kinectController.hands[0].fingertips[0].X - kinectController.hands[0].fingertips[1].X) < 20)
                                    {
                                        Invoke(new Action(delegate { alphabetbox.Text = "G"; }));
                                        Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.G);
                                        Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.G);
                                        Thread.Sleep(10000);
                                    }
                                    else if (Math.Abs(kinectController.hands[0].fingertips[1].X - kinectController.hands[1].fingertips[1].X) < 10)
                                    {
                                        Invoke(new Action(delegate { alphabetbox.Text = "X"; }));
                                        Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.X);
                                        Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.X);
                                        Thread.Sleep(10000);
                                    }
                                }
                                else
                                {
                                    Invoke(new Action(delegate { alphabetbox.Text = "N"; }));
                                    Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.N);
                                    Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.N);
                                    Thread.Sleep(10000);
                                }
                            }
                            else if (Math.Abs(kinectController.hands[0].fingertips[0].X - kinectController.hands[1].fingertips[1].X) < 10)
                            {
                                if (Math.Abs(kinectController.hands[0].fingertips[0].X - kinectController.hands[0].fingertips[1].X) < 20)
                                {
                                    Invoke(new Action(delegate { alphabetbox.Text = "T"; }));
                                    Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.T);
                                    Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.T);
                                    Thread.Sleep(10000);
                                }
                            }
                            else if (Math.Abs(kinectController.hands[0].fingertips[1].X - kinectController.hands[1].fingertips[1].X) < 10)
                            {
                                if (Math.Abs(kinectController.hands[1].fingertips[0].X - kinectController.hands[1].fingertips[1].X) < 20)
                                {
                                    Invoke(new Action(delegate { alphabetbox.Text = "Z"; }));
                                    Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.Z);
                                    Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.Z);
                                    Thread.Sleep(10000);
                                }

                            }
                        }
                        /// Make others difference b/w same fingers <10
                        else if (kinectController.hands[0].fingertips.Count == 3 && kinectController.hands[1].fingertips.Count == 1)
                        {
                            if (Math.Abs(kinectController.hands[0].fingertips[0].X - kinectController.hands[1].fingertips[0].X) < 10)
                            {
                                Invoke(new Action(delegate { alphabetbox.Text = "P"; }));
                                Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.P);
                                Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.P);
                                Thread.Sleep(10000);
                            }
                            else if (Math.Abs(kinectController.hands[0].fingertips[1].X - kinectController.hands[1].fingertips[0].X) < 10)
                            {
                                Invoke(new Action(delegate { alphabetbox.Text = "R"; }));
                                Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.R);
                                Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.R);
                                Thread.Sleep(10000);
                            }
                            else if (Math.Abs(kinectController.hands[0].fingertips[2].X - kinectController.hands[1].fingertips[0].X) < 10)
                            {
                                Invoke(new Action(delegate { alphabetbox.Text = "V"; }));
                                Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.V);
                                Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.V);
                                Thread.Sleep(10000);
                            }
                        }

                        else if (kinectController.hands[0].fingertips.Count == 1 && kinectController.hands[1].fingertips.Count == 3)
                        {
                            Invoke(new Action(delegate { alphabetbox.Text = "W"; }));
                            Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.W);
                            Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.W);
                            Thread.Sleep(10000);
                        }
                        else if (kinectController.hands[0].fingertips.Count == 3 && kinectController.hands[1].fingertips.Count == 2)
                        {
                            Invoke(new Action(delegate { alphabetbox.Text = "Q"; }));
                            Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.Q);
                            Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.Q);
                            Thread.Sleep(10000);
                        }
                        else if (kinectController.hands[0].fingertips.Count == 2 && kinectController.hands[1].fingertips.Count == 3)
                        {
                            Invoke(new Action(delegate { alphabetbox.Text = "Y"; }));
                            Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.Y);
                            Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.Y);
                            Thread.Sleep(10000);
                        }
                        // Backspace keypress required,
                        else if (kinectController.hands[0].fingertips.Count == 3 && kinectController.hands[1].fingertips.Count == 3)
                        {
                            Invoke(new Action(delegate { alphabetbox.Text = "Backspace"; }));
                            Mouse.VirtualKeyboard.KeyDown(System.Windows.Forms.Keys.Back);
                            Mouse.VirtualKeyboard.KeyUp(System.Windows.Forms.Keys.Back);
                            Thread.Sleep(10000);
                        }
                    }

                }
            });
        }

        //private void NearSpaceTrackBar_Scroll(object sender, EventArgs e)
        //{
        //    if (AbsoluteCheckBox.Checked)
        //    {
        //        kinectController.settings.absoluteSpace = NearSpaceTrackBar.Value * 50;
        //        NearSpaceTextBox.Text = kinectController.settings.absoluteSpace.ToString();
        //    }
        //    else
        //    {
        //        kinectController.settings.absoluteSpace = -1;
        //        kinectController.settings.nearSpacePerc = NearSpaceTrackBar.Value / 100.0f;
        //        NearSpaceTextBox.Text = kinectController.settings.nearSpacePerc.ToString();
        //    }
        //}

        //private void Smooth_Scroll(object sender, EventArgs e)
        //{
        //    kinectController.settings.smoothingIterations = smoothTrackBar.Value;
        //    smoothTextBox.Text = smoothTrackBar.Value.ToString();
        //}

        //private void BoxReduction_Scroll(object sender, EventArgs e)
        //{
        //    kinectController.settings.containerBoxReduction = (smoothTrackBar.Value / 100.0f);
        //    smoothTextBox.Text = smoothTrackBar.Value.ToString();
        //}

        private void marginsChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            float perc = 0;
            if (!box.Text.Equals(""))
            {
                try
                {
                    perc = Convert.ToSingle(box.Text);
                }
                catch (Exception exception)
                {
                    perc = 0;
                }
            }
            perc = Math.Min(perc, 30);
            String percStr = perc.ToString();

            if (checkSameMargins.Checked)
            {
                kinectController.settings.marginLeftPerc = perc;
                textMarginLeft.Text = percStr;
                kinectController.settings.marginRightPerc = perc;
                textMarginRight.Text = percStr;
                kinectController.settings.marginTopPerc = perc;
                textMarginTop.Text = percStr;
                kinectController.settings.marginBotPerc = perc;
                textMarginBot.Text = percStr;
            }
            else
            {
                if (box.Name.Equals("textMarginLeft"))
                {
                    kinectController.settings.marginLeftPerc = perc;
                    textMarginLeft.Text = percStr;
                }
                else if (box.Name.Equals("textMarginRight"))
                {
                    kinectController.settings.marginRightPerc = perc;
                    textMarginRight.Text = percStr;
                }
                else if (box.Name.Equals("textMarginTop"))
                {
                    kinectController.settings.marginTopPerc = perc;
                    textMarginTop.Text = percStr;
                }
                else if (box.Name.Equals("textMarginBot"))
                {
                    kinectController.settings.marginBotPerc = perc;
                    textMarginBot.Text = percStr;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process notepad = new Process();
            notepad.StartInfo.FileName = "notepad.exe";
            notepad.Start();
        }
    }
}

// Remember that designer will always use the first class of a file. MainWindow.cs has design components, hence The Fingertracking namespace
// containing the MainWindow Form must be the first class. Order matters here.
