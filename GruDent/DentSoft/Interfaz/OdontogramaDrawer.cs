using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentSoft.Interfaz
{
    public class OdontogramaDrawer
    {
        private Bitmap _canvas;
        private Graphics _graphics;
        private Pen _pen;
        private Point _oldPoint;

        public Bitmap Canvas => _canvas;

        public void SetCanvas(Image img)
        {
            if (_canvas != null)
                _canvas.Dispose();

            _canvas = new Bitmap(img.Width, img.Height);
            _graphics = Graphics.FromImage(_canvas);
            _graphics.SmoothingMode = SmoothingMode.AntiAlias;

            _graphics.DrawImage(img, 0, 0, img.Width, img.Height);
        }

        public void CargarImagenBase(byte[] imagenBytes)
        {
            using (MemoryStream ms = new MemoryStream(imagenBytes))
            {
                Image imagenBase = Image.FromStream(ms);

                _graphics.DrawImage(imagenBase, new Rectangle(0, 0, _canvas.Width, _canvas.Height));
            }
        }


        public OdontogramaDrawer(int width, int height)
        {
            _canvas = new Bitmap(width, height);
            _graphics = Graphics.FromImage(_canvas);
            _graphics.SmoothingMode = SmoothingMode.AntiAlias;

            _pen = new Pen(Color.Black, 5)
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round
            };
        }

        public void SetColor(Color color)
        {
            _pen.Color = color;
        }

        public void MouseDown(Point location)
        {
            _oldPoint = location;
        }

        public void MouseMove(Point location)
        {
            _graphics.DrawLine(_pen, _oldPoint, location);
            _oldPoint = location;
        }

        public byte[] GetImageBytes()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                _canvas.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public void Clear()
        {
            _graphics.Clear(Color.White);
        }
    }
}
