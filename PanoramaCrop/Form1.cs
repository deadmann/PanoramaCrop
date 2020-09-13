using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PanoramaCrop
{
    public partial class Form1 : Form
    {
        private Image _img;
        private Image _preview;

        private CropType _cropType;

        private string _outputDirectory;
        private string _prefix;
        private string _suffix;
        private Color _backColor;


        public Form1()
        {
            InitializeComponent();
            _img = null; 
            _backColor = Color.White;
        }

        private void chooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) != DialogResult.OK) return;
            lblLoadedFilePath.Text = openFileDialog1.FileName;

            using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
            {
                _img = Image.FromStream(fs);
            }

            //picturePreview.Image = _img;

            CalculateAndShow();
        }

        private void rbFindResolution_CheckedChanged(object sender, EventArgs e)
        {
            rbFindNumber.Checked = false;
            _cropType = CropType.FindResolution;
        }
        
        private void rbFindNumber_CheckedChanged(object sender, EventArgs e)
        {
            rbFindResolution.Checked = false;
            _cropType = CropType.FindNumber;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CalculateAndShow();
        }

        private void CalculateAndShow()
        {
            if (_img == null) return;

            var rectangles = CalculateRectangles();

            ReDraw(_img.Width, _img.Height, rectangles);
        }

        private List<Rectangle> CalculateRectangles()
        {
            // Width
            decimal w = _img.Width;
            // Height
            decimal h = _img.Height;

            // Rectangle Number Horizontal
            decimal rnHor = numHorSlide.Value;
            // Rectangle Number Vertical
            decimal rnVer = numVerSlide.Value;
            // Center X
            decimal cx = _img.Width / 2m;
            // Center Y
            decimal cy = _img.Height / 2m;
            // Rectangle Width
            decimal rw = 0;
            // Rectangle Height
            decimal rh = 0;
            // Total Width
            decimal tw = 0;
            // Total Height
            decimal th = 0;

            List<Rectangle> rectangles = null;
            if (_cropType == CropType.FindResolution)
            {
                if (!chkNoCrop.Checked)
                {
                    decimal whRatio = ((decimal) w / (decimal) h);
                    decimal horVerRatio = (rnHor / rnVer);
                    if (whRatio >= horVerRatio)
                    {
                        rh = h / rnVer;
                        rw = rh;

                        tw = rnHor * rw;
                        th = rnVer * rh;

                        // we can apply scale here on tw & th, ... also moving offset

                        var recWholeCropArea = GetCenteredRectangle(_img.Width, _img.Height, tw, th);
                        // Half Width
                        decimal hw = tw / 2;
                        // Half Height
                        decimal hh = th / 2;

                        rectangles = new List<Rectangle>();
                        decimal px = 0;
                        for (decimal x = recWholeCropArea.Left; x <= recWholeCropArea.Right /*+telorance?*/; px = x, x += rw)
                        {
                            decimal py = 0;
                            for (decimal y = recWholeCropArea.Top;
                                y <= recWholeCropArea.Bottom /*+telorance?*/;
                                py = y, y += rh)
                            {
                                if (x == recWholeCropArea.Left || y == recWholeCropArea.Top)
                                    continue;
                                var rec = new Rectangle((int) px, (int) py, (int) (x - px), (int) (y - py));
                                rectangles.Add(rec);
                            }
                        }
                    }
                    else
                    {
                        rw = w / rnHor;
                        rh = rw;

                        tw = rnHor * rw;
                        th = rnVer * rh;

                        // we can apply scale here on tw & th, ... also moving offset

                        var recWholeCropArea = GetCenteredRectangle(_img.Width, _img.Height, tw, th);
                        // Half Width
                        decimal hw = tw / 2;
                        // Half Height
                        decimal hh = th / 2;

                        rectangles = new List<Rectangle>();
                        decimal px = 0;
                        for (decimal x = recWholeCropArea.Left; x <= recWholeCropArea.Right /*+telorance?*/; px = x, x += rw)
                        {
                            decimal py = 0;
                            for (decimal y = recWholeCropArea.Top;
                                y <= recWholeCropArea.Bottom /*+telorance?*/;
                                py = y, y += rh)
                            {
                                if (x == recWholeCropArea.Left || y == recWholeCropArea.Top)
                                    continue;
                                var rec = new Rectangle((int) px, (int) py, (int) (x - px), (int) (y - py));
                                rectangles.Add(rec);
                            }
                        }
                    }
                }
                else
                {
                }
            }
            else if (_cropType == CropType.FindNumber)
            {
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

            return rectangles;
        }

        /// <summary>
        /// Draw a preview version of what we will earn
        /// </summary>
        /// <param name="imgWidth"></param>
        /// <param name="imgHeight"></param>
        /// <param name="rectangles"></param>
        private void ReDraw(int imgWidth, int imgHeight, List<Rectangle> rectangles)
        {
            _preview = new Bitmap(imgWidth, imgHeight);
            using (Graphics g = Graphics.FromImage(_preview))
            {

                g.DrawImage(_img, 0, 0, imgWidth, imgHeight);

                foreach (var rectangle in rectangles)
                {
                    g.DrawLines(Pens.White, new Point[]
                    {
                        new Point(rectangle.Left, rectangle.Top), 
                        new Point(rectangle.Left, rectangle.Bottom),
                        new Point(rectangle.Right, rectangle.Bottom), 
                        new Point(rectangle.Right, rectangle.Top),
                        new Point(rectangle.Left, rectangle.Top), 
                    });
                }

                g.Flush();
            }

            picturePreview.Image = _preview;
            picturePreview.Refresh();
        }

        /// <summary>
        /// Centering Second rectangle with respect to First rectangle, knowing X and Y of first rectangle start at 0;
        /// </summary>
        /// <param name="widthA"></param>
        /// <param name="heightA"></param>
        /// <param name="widthB"></param>
        /// <param name="heightB"></param>
        /// <returns></returns>
        private Rectangle GetCenteredRectangle(decimal widthA, decimal heightA, decimal widthB, decimal heightB)
        {
            var rx = (widthA - widthB) / 2;
            var rh = (heightA - heightB) / 2;

            return new Rectangle((int) rx, (int) rh, (int) widthB, (int) heightB);
        }

        #region Choose output location
        private void chooseOutput_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) != DialogResult.OK) return;

            _outputDirectory = folderBrowserDialog1.SelectedPath;
            PreviewSampleOutputDirectory();
        }

        private void txtPrefix_TextChanged(object sender, EventArgs e)
        {
            _prefix = txtPrefix.Text;
            PreviewSampleOutputDirectory();
        }

        private void txtSuffix_TextChanged(object sender, EventArgs e)
        {
            _suffix = txtSuffix.Text;
            PreviewSampleOutputDirectory();
        }

        private void PreviewSampleOutputDirectory()
        {
            if (string.IsNullOrWhiteSpace(_outputDirectory))
            {
                lblExportPath.Text = string.Empty;
                return;
            }

            string txtSampleFile;
            if (string.IsNullOrWhiteSpace(_prefix) && string.IsNullOrWhiteSpace(_suffix))
                txtSampleFile = "PanoramaCrop" + 1;
            else
                txtSampleFile = _prefix.TrimStart() + 1 + _suffix.TrimEnd();

            lblExportPath.Text = $@"{_outputDirectory}\{txtSampleFile}.jpg";
        }

        #endregion Choose output location

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string GetFileName(int i)
            {
                return $@"{_outputDirectory}\{_prefix}{i + 1}{_suffix}.jpg";
            }

            var rectangles = CalculateRectangles();

            START: 
            for (int i = 0; i < rectangles.Count; i++)
            {
                if (File.Exists(GetFileName(i)))
                {
                    if (MessageBox.Show(this, "File Exists", "File Exists", MessageBoxButtons.RetryCancel,
                            MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1) == DialogResult.Retry)
                        goto START;
                    return;
                }

            }

            
            for (int i = 0; i < rectangles.Count; i++)
            {
                Rectangle rect = rectangles[i];

                Image imgResult = new Bitmap(rect.Width, rect.Height);
                using (Graphics g = Graphics.FromImage(imgResult))
                {
                    g.Clear(_backColor);

                    var cropRect = new Rectangle(rect.Left, rect.Top, rect.Width, rect.Height);
                    g.DrawImage(_img, new Rectangle(0, 0, rect.Width, rect.Height), cropRect, GraphicsUnit.Pixel);

                    g.Flush();
                }

                imgResult.Save(GetFileName(i), ImageFormat.Jpeg);
            }
        }

        //private void btnBackColor_Click(object sender, EventArgs e)
        //{
        //    progressBar1.Value = 0;
        //    if (colorDialog1.ShowDialog(this) == DialogResult.OK)
        //    {
        //        lblBackColor.Text = colorDialog1.Color.Name;
        //        _backColor = colorDialog1.Color;
        //    }
        //}
    }
}
