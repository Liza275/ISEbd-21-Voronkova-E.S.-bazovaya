namespace WindowsFormsPlane
{
    partial class Formfighter
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxfighter = new System.Windows.Forms.PictureBox();
            this.buttonCreateFighter = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonCreateWarplane = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfighter)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxfighter
            // 
            this.pictureBoxfighter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxfighter.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxfighter.Name = "pictureBoxfighter";
            this.pictureBoxfighter.Size = new System.Drawing.Size(892, 455);
            this.pictureBoxfighter.TabIndex = 0;
            this.pictureBoxfighter.TabStop = false;
            // 
            // buttonCreateFighter
            // 
            this.buttonCreateFighter.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateFighter.Name = "buttonCreateFighter";
            this.buttonCreateFighter.Size = new System.Drawing.Size(105, 54);
            this.buttonCreateFighter.TabIndex = 1;
            this.buttonCreateFighter.Text = "Истребитель";
            this.buttonCreateFighter.UseVisualStyleBackColor = true;
            this.buttonCreateFighter.Click += new System.EventHandler(this.ButtonCreateFighter_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::WindowsFormsPlane.Properties.Resources.kisspng_the_station_church_arrow_clip_art_5b38af4e54ea72_2767045215304415503478;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(814, 413);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 2;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::WindowsFormsPlane.Properties.Resources.green_arrow_arrow_up;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(814, 377);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 3;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::WindowsFormsPlane.Properties.Resources.left_arrow_318_61472;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(778, 413);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::WindowsFormsPlane.Properties.Resources.computer_icons_arrow_symbol_direction;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(850, 413);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonCreateWarplane
            // 
            this.buttonCreateWarplane.Location = new System.Drawing.Point(141, 12);
            this.buttonCreateWarplane.Name = "buttonCreateWarplane";
            this.buttonCreateWarplane.Size = new System.Drawing.Size(105, 54);
            this.buttonCreateWarplane.TabIndex = 6;
            this.buttonCreateWarplane.Text = "Военный самолет";
            this.buttonCreateWarplane.UseVisualStyleBackColor = true;
            this.buttonCreateWarplane.Click += new System.EventHandler(this.ButtonCreateWarplane_Click);
            // 
            // Formfighter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 455);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.pictureBoxfighter);
            this.Controls.Add(this.buttonCreateWarplane);
            this.Controls.Add(this.buttonCreateFighter);
            this.Name = "Formfighter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Истребитель";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfighter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxfighter;
        private System.Windows.Forms.Button buttonCreateFighter;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonCreateWarplane;
    }
}

