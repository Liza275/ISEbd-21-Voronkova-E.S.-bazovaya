using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace WindowsFormsPlane
{
    public partial class FormAirport : Form
    {
        private readonly AirportCollection airportCollection;

        public FormAirport()
        {
            InitializeComponent();
            airportCollection = new AirportCollection(pictureBoxAirport.Width, pictureBoxAirport.Height);
            Draw();
        }

        private void ReloadLevels()
        {
            int index = listBoxAiports.SelectedIndex;
            listBoxAiports.Items.Clear();
            for (int i = 0; i < airportCollection.Keys.Count; i++)
            {
                listBoxAiports.Items.Add(airportCollection.Keys[i]);
            }
            if (listBoxAiports.Items.Count > 0 && (index == -1 || index >= listBoxAiports.Items.Count))
            {
                listBoxAiports.SelectedIndex = 0;
            }
            else if (listBoxAiports.Items.Count > 0 && index > -1 && index < listBoxAiports.Items.Count)
            {
                listBoxAiports.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxAiports.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxAirport.Width, pictureBoxAirport.Height);
                Graphics gr = Graphics.FromImage(bmp);
                if (listBoxAiports.SelectedIndex > -1)
                {
                    airportCollection[listBoxAiports.SelectedItem.ToString()].Draw(gr);
                }
                else
                {
                    gr.FillRectangle(new SolidBrush(System.Drawing.Color.Transparent), 0, 0, pictureBoxAirport.Width, pictureBoxAirport.Height);
                }
                pictureBoxAirport.Image = bmp;//000000
            }

        }

        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (listBoxAiports.SelectedIndex > -1 && maskedTextBox.Text != "")
            {

                var warplane = airportCollection[listBoxAiports.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                if (warplane != null)
                {
                    Formfighter form = new Formfighter();
                    form.SetWarplane(warplane);
                    form.ShowDialog();
                }
                Draw();

            }
        }

        private void ButtonAddAirport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            airportCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels();
            listBoxAiports.SetSelected(listBoxAiports.Items.Count - 1, true);
            Draw();
        }

        private void ButtonDelAirport_Click(object sender, EventArgs e)
        {
            if (listBoxAiports.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку {listBoxAiports.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    airportCollection.DelParking(listBoxAiports.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }
        private void buttonSetWarplane_Click(object sender, EventArgs e)
        {
            if (listBoxAiports.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var warplane = new WarPlane(100, 100, dialog.Color);
                    if (airportCollection[listBoxAiports.SelectedItem.ToString()] + warplane)
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
        private void buttonSetFighter_Click(object sender, EventArgs e)
        {
            if (listBoxAiports.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var fighter = new Fighter(100, 100, dialog.Color, dialogDop.Color, true, true);

                        if (airportCollection[listBoxAiports.SelectedItem.ToString()] + fighter)
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
        }

        private void ListBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
