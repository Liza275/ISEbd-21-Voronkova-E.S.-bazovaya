namespace WindowsFormsPlane
{
    partial class FormAirport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBoxPlane = new System.Windows.Forms.GroupBox();
            this.buttonTakePlane = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.listBoxAiports = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddAirport = new System.Windows.Forms.Button();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonDelAirport = new System.Windows.Forms.Button();
            this.buttonAddPlane = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttinSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxPlane.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 27);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(794, 593);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBoxPlane
            // 
            this.groupBoxPlane.Controls.Add(this.buttonTakePlane);
            this.groupBoxPlane.Controls.Add(this.maskedTextBox);
            this.groupBoxPlane.Controls.Add(this.labelPlace);
            this.groupBoxPlane.Location = new System.Drawing.Point(800, 497);
            this.groupBoxPlane.Name = "groupBoxPlane";
            this.groupBoxPlane.Size = new System.Drawing.Size(143, 110);
            this.groupBoxPlane.TabIndex = 3;
            this.groupBoxPlane.TabStop = false;
            this.groupBoxPlane.Text = "Забрать самолет";
            // 
            // buttonTakePlane
            // 
            this.buttonTakePlane.Location = new System.Drawing.Point(20, 80);
            this.buttonTakePlane.Name = "buttonTakePlane";
            this.buttonTakePlane.Size = new System.Drawing.Size(102, 24);
            this.buttonTakePlane.TabIndex = 2;
            this.buttonTakePlane.Text = "Забрать";
            this.buttonTakePlane.UseVisualStyleBackColor = true;
            this.buttonTakePlane.Click += new System.EventHandler(this.buttonTakePlane_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(78, 35);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(59, 22);
            this.maskedTextBox.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(6, 35);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(53, 17);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место:";
            // 
            // listBoxAiports
            // 
            this.listBoxAiports.FormattingEnabled = true;
            this.listBoxAiports.ItemHeight = 16;
            this.listBoxAiports.Location = new System.Drawing.Point(797, 136);
            this.listBoxAiports.Name = "listBoxAiports";
            this.listBoxAiports.Size = new System.Drawing.Size(140, 68);
            this.listBoxAiports.TabIndex = 4;
            this.listBoxAiports.SelectedIndexChanged += new System.EventHandler(this.ListBoxParkings_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(835, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Аэропорт";
            // 
            // buttonAddAirport
            // 
            this.buttonAddAirport.Location = new System.Drawing.Point(800, 79);
            this.buttonAddAirport.Name = "buttonAddAirport";
            this.buttonAddAirport.Size = new System.Drawing.Size(133, 51);
            this.buttonAddAirport.TabIndex = 6;
            this.buttonAddAirport.Text = "Добавить аэропорт";
            this.buttonAddAirport.UseVisualStyleBackColor = true;
            this.buttonAddAirport.Click += new System.EventHandler(this.ButtonAddAirport_Click);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(806, 51);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(127, 22);
            this.textBoxNewLevelName.TabIndex = 7;
            // 
            // buttonDelAirport
            // 
            this.buttonDelAirport.Location = new System.Drawing.Point(806, 210);
            this.buttonDelAirport.Name = "buttonDelAirport";
            this.buttonDelAirport.Size = new System.Drawing.Size(131, 55);
            this.buttonDelAirport.TabIndex = 8;
            this.buttonDelAirport.Text = "Удалить аэропорт";
            this.buttonDelAirport.UseVisualStyleBackColor = true;
            this.buttonDelAirport.Click += new System.EventHandler(this.ButtonDelAirport_Click);
            // 
            // buttonAddPlane
            // 
            this.buttonAddPlane.Location = new System.Drawing.Point(809, 385);
            this.buttonAddPlane.Name = "buttonAddPlane";
            this.buttonAddPlane.Size = new System.Drawing.Size(128, 69);
            this.buttonAddPlane.TabIndex = 9;
            this.buttonAddPlane.Text = "Добавить самолет";
            this.buttonAddPlane.UseVisualStyleBackColor = true;
            this.buttonAddPlane.Click += new System.EventHandler(this.ButtonAddPlane_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(945, 30);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.ЗагрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // buttinSort
            // 
            this.buttinSort.Location = new System.Drawing.Point(809, 319);
            this.buttinSort.Name = "buttinSort";
            this.buttinSort.Size = new System.Drawing.Size(124, 38);
            this.buttinSort.TabIndex = 11;
            this.buttinSort.Text = "Сортировать";
            this.buttinSort.UseVisualStyleBackColor = true;
            this.buttinSort.Click += new System.EventHandler(this.ButtinSort_Click);
            // 
            // FormAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 619);
            this.Controls.Add(this.buttinSort);
            this.Controls.Add(this.buttonAddPlane);
            this.Controls.Add(this.buttonDelAirport);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.buttonAddAirport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxAiports);
            this.Controls.Add(this.groupBoxPlane);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormAirport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxPlane.ResumeLayout(false);
            this.groupBoxPlane.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxPlane;
        private System.Windows.Forms.Button buttonTakePlane;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.ListBox listBoxAiports;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddAirport;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonDelAirport;
        private System.Windows.Forms.Button buttonAddPlane;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttinSort;
    }
}