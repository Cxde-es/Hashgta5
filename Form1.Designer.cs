
namespace hashFivem
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.b_convert = new System.Windows.Forms.Button();
            this.lb_footer = new System.Windows.Forms.Label();
            this.tb_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_min = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_min)).BeginInit();
            this.SuspendLayout();
            // 
            // b_convert
            // 
            this.b_convert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(181)))), ((int)(((byte)(139)))));
            this.b_convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_convert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.b_convert.Location = new System.Drawing.Point(76, 116);
            this.b_convert.Name = "b_convert";
            this.b_convert.Size = new System.Drawing.Size(178, 24);
            this.b_convert.TabIndex = 4;
            this.b_convert.Text = "Get Hash";
            this.b_convert.UseVisualStyleBackColor = false;
            this.b_convert.Click += new System.EventHandler(this.b_convert_Click);
            // 
            // lb_footer
            // 
            this.lb_footer.AutoSize = true;
            this.lb_footer.ForeColor = System.Drawing.Color.White;
            this.lb_footer.Location = new System.Drawing.Point(73, 166);
            this.lb_footer.Name = "lb_footer";
            this.lb_footer.Size = new System.Drawing.Size(135, 13);
            this.lb_footer.TabIndex = 5;
            this.lb_footer.Text = "Powered by CXDE, join our";
            this.lb_footer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tb_text
            // 
            this.tb_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_text.Location = new System.Drawing.Point(88, 90);
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(178, 20);
            this.tb_text.TabIndex = 6;
            this.tb_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(181)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(204, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Discord";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_footer);
            this.panel1.Controls.Add(this.b_convert);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 182);
            this.panel1.TabIndex = 9;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pic_close
            // 
            this.pic_close.Image = ((System.Drawing.Image)(resources.GetObject("pic_close.Image")));
            this.pic_close.Location = new System.Drawing.Point(328, 6);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(13, 13);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 10;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // pic_min
            // 
            this.pic_min.Image = ((System.Drawing.Image)(resources.GetObject("pic_min.Image")));
            this.pic_min.Location = new System.Drawing.Point(304, 6);
            this.pic_min.Name = "pic_min";
            this.pic_min.Size = new System.Drawing.Size(15, 15);
            this.pic_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_min.TabIndex = 11;
            this.pic_min.TabStop = false;
            this.pic_min.Click += new System.EventHandler(this.pic_min_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(355, 206);
            this.Controls.Add(this.pic_min);
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_text);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HASH GTA5";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_convert;
        private System.Windows.Forms.Label lb_footer;
        private System.Windows.Forms.TextBox tb_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.PictureBox pic_min;
    }
}

