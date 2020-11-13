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
            this.pictureBoxAirport = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTakePlane = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAiports = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddAirport = new System.Windows.Forms.Button();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonDelAirport = new System.Windows.Forms.Button();
            this.buttonAddWarplane = new System.Windows.Forms.Button();
            this.buttonAddFighter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAirport
            // 
            this.pictureBoxAirport.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAirport.Name = "pictureBoxAirport";
            this.pictureBoxAirport.Size = new System.Drawing.Size(794, 620);
            this.pictureBoxAirport.TabIndex = 0;
            this.pictureBoxAirport.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTakePlane);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(800, 497);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать самолет";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место:";
            // 
            // listBoxAiports
            // 
            this.listBoxAiports.FormattingEnabled = true;
            this.listBoxAiports.ItemHeight = 16;
            this.listBoxAiports.Location = new System.Drawing.Point(797, 112);
            this.listBoxAiports.Name = "listBoxAiports";
            this.listBoxAiports.Size = new System.Drawing.Size(140, 68);
            this.listBoxAiports.TabIndex = 4;
            this.listBoxAiports.SelectedIndexChanged += new System.EventHandler(this.ListBoxParkings_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(835, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Аэропорт";
            // 
            // buttonAddAirport
            // 
            this.buttonAddAirport.Location = new System.Drawing.Point(797, 55);
            this.buttonAddAirport.Name = "buttonAddAirport";
            this.buttonAddAirport.Size = new System.Drawing.Size(140, 51);
            this.buttonAddAirport.TabIndex = 6;
            this.buttonAddAirport.Text = "Добавить аэропорт";
            this.buttonAddAirport.UseVisualStyleBackColor = true;
            this.buttonAddAirport.Click += new System.EventHandler(this.ButtonAddAirport_Click);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(797, 27);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(140, 22);
            this.textBoxNewLevelName.TabIndex = 7;
            // 
            // buttonDelAirport
            // 
            this.buttonDelAirport.Location = new System.Drawing.Point(797, 186);
            this.buttonDelAirport.Name = "buttonDelAirport";
            this.buttonDelAirport.Size = new System.Drawing.Size(140, 55);
            this.buttonDelAirport.TabIndex = 8;
            this.buttonDelAirport.Text = "Удалить аэропорт";
            this.buttonDelAirport.UseVisualStyleBackColor = true;
            this.buttonDelAirport.Click += new System.EventHandler(this.ButtonDelAirport_Click);
            // 
            // buttonAddWarplane
            // 
            this.buttonAddWarplane.Location = new System.Drawing.Point(797, 348);
            this.buttonAddWarplane.Name = "buttonAddWarplane";
            this.buttonAddWarplane.Size = new System.Drawing.Size(140, 64);
            this.buttonAddWarplane.TabIndex = 9;
            this.buttonAddWarplane.Text = "Припарковать военный самолет";
            this.buttonAddWarplane.UseVisualStyleBackColor = true;
            this.buttonAddWarplane.Click += new System.EventHandler(this.buttonSetWarplane_Click);
            // 
            // buttonAddFighter
            // 
            this.buttonAddFighter.Location = new System.Drawing.Point(797, 418);
            this.buttonAddFighter.Name = "buttonAddFighter";
            this.buttonAddFighter.Size = new System.Drawing.Size(140, 64);
            this.buttonAddFighter.TabIndex = 10;
            this.buttonAddFighter.Text = "Припарковать истребитель";
            this.buttonAddFighter.UseVisualStyleBackColor = true;
            this.buttonAddFighter.Click += new System.EventHandler(this.buttonSetFighter_Click);
            // 
            // FormAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 619);
            this.Controls.Add(this.buttonAddFighter);
            this.Controls.Add(this.buttonAddWarplane);
            this.Controls.Add(this.buttonDelAirport);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.buttonAddAirport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxAiports);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxAirport);
            this.Name = "FormAirport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аэропорт";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAirport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTakePlane;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAiports;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddAirport;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonDelAirport;
        private System.Windows.Forms.Button buttonAddWarplane;
        private System.Windows.Forms.Button buttonAddFighter;
    }
}