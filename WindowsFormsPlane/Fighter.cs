using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    public class Fighter : WarPlane
    {
        public Color DopColor { private set; get; }
        public bool isEngines { private set; get; }
        public bool isRockets { private set; get; }

        public Fighter(int maxSpeed, float weight, Color mainColor, Color dopColor, bool IsEngines, bool IsRockets) :
            base(maxSpeed, weight, mainColor, 113, 128)
        {
            DopColor = dopColor;
            isEngines = IsEngines;
            isRockets = IsRockets;
        }

        public Fighter(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                isEngines = Convert.ToBoolean(strs[4]);
                isRockets = Convert.ToBoolean(strs[5]);
            }
        }
        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);

            Brush dopBrush = new SolidBrush(DopColor);
            if (isRockets)
            {
                PointF[] upRocket = new PointF[3];
                upRocket[0].X = _startPosX + 56;
                upRocket[0].Y = _startPosY - 12;
                upRocket[1].X = _startPosX + 40;
                upRocket[1].Y = _startPosY - 16;
                upRocket[2].X = _startPosX + 56;
                upRocket[2].Y = _startPosY - 20;
                g.FillPolygon(dopBrush, upRocket);
                PointF[] downRocket = new PointF[3];
                downRocket[0].X = _startPosX + 56;
                downRocket[0].Y = _startPosY + 12;
                downRocket[1].X = _startPosX + 40;
                downRocket[1].Y = _startPosY + 16;
                downRocket[2].X = _startPosX + 56;
                downRocket[2].Y = _startPosY + 20;
                g.FillPolygon(dopBrush, downRocket);
            }

            if (isEngines)
            {
                g.FillRectangle(dopBrush, _startPosX + 104, _startPosY - 8, 9, 7);
                g.FillRectangle(dopBrush, _startPosX + 104, _startPosY + 1, 9, 7);
            }
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{isEngines}{separator}{isRockets}";
        }
    }
}
