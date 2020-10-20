using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    public class Parking<T> where T : class, IFlyingTransport
    {
        private readonly T[] _places;
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly int _placeSizeWidth = 210;
        private readonly int _placeSizeHeight = 125;

        public Parking(int picWidht, int picHeight)
        {
            int widht = picWidht / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[widht * height];
            pictureWidth = picWidht;
            pictureHeight = picHeight;
        }

        public static bool operator +(Parking<T> p, T plane)
        {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p._places[i] == null)
                {
                    p._places[i] = plane;
                    if (i > (p._places.Length / 2) - 1)
                    {
                        plane.SetPosition(p._placeSizeWidth, (i - (p._places.Length / 2)) * p._placeSizeHeight + p._placeSizeHeight / 2, 1000, 1000);
                    }
                    else
                    {
                        plane.SetPosition(0, i * p._placeSizeHeight + p._placeSizeHeight / 2, 1000, 1000);
                    }
                    return true;
                }
            }
            return false;
        }

        public static T operator -(Parking<T> p, int index)
        {
            if (index >= p._places.Length || index < 0)
            {
                return null;
            }
            T result = p._places[index];
            p._places[index] = null;
            return result;
        }

        //отрисовка парковки
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
