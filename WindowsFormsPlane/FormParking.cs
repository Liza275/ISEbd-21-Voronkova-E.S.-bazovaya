using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPlane
{
    public partial class FormParking : Form
    {
        private readonly Parking<Warplane> parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<Warplane>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
     
        private void buttonSetWarplane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var warplane = new Warplane(100, 100, dialog.Color);
                if (parking + warplane)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        private void buttonSetFighter_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var fighter = new Fighter(100, 100, dialog.Color, dialogDop.Color, true, true);

                    if (parking + fighter)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }

        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var warplane = parking - Convert.ToInt32(maskedTextBox.Text);
                if (warplane != null)
                {
                    Formfighter form = new Formfighter();
                    form.SetWarplane(warplane);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
