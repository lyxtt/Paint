namespace Paint
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_redo = new System.Windows.Forms.Button();
            this.btn_undo = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lineWidth = new System.Windows.Forms.TrackBar();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_AddText = new System.Windows.Forms.Button();
            this.btn_elipse = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_triangle = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Zoomin = new System.Windows.Forms.Button();
            this.trB_zoom = new System.Windows.Forms.TrackBar();
            this.btn_Zoomout = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trB_zoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btn_redo);
            this.panel1.Controls.Add(this.btn_undo);
            this.panel1.Controls.Add(this.btn_open);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lineWidth);
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1880, 168);
            this.panel1.TabIndex = 0;
            // 
            // btn_redo
            // 
            this.btn_redo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_redo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_redo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_redo.Image = global::Paint.Properties.Resources.redo_24;
            this.btn_redo.Location = new System.Drawing.Point(1659, 92);
            this.btn_redo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_redo.Name = "btn_redo";
            this.btn_redo.Size = new System.Drawing.Size(70, 65);
            this.btn_redo.TabIndex = 8;
            this.btn_redo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_redo.UseVisualStyleBackColor = true;
            this.btn_redo.Click += new System.EventHandler(this.btn_redo_Click);
            // 
            // btn_undo
            // 
            this.btn_undo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_undo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_undo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_undo.Image = global::Paint.Properties.Resources.undo_24;
            this.btn_undo.Location = new System.Drawing.Point(1659, 18);
            this.btn_undo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(70, 65);
            this.btn_undo.TabIndex = 7;
            this.btn_undo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_undo.UseVisualStyleBackColor = true;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // btn_open
            // 
            this.btn_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_open.Image = global::Paint.Properties.Resources.folder_open_solid_24;
            this.btn_open.Location = new System.Drawing.Point(1766, 9);
            this.btn_open.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(70, 45);
            this.btn_open.TabIndex = 6;
            this.btn_open.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1506, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Line width";
            // 
            // lineWidth
            // 
            this.lineWidth.BackColor = System.Drawing.Color.Brown;
            this.lineWidth.Location = new System.Drawing.Point(1461, 41);
            this.lineWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lineWidth.Minimum = 1;
            this.lineWidth.Name = "lineWidth";
            this.lineWidth.Size = new System.Drawing.Size(156, 69);
            this.lineWidth.TabIndex = 3;
            this.lineWidth.Value = 1;
            this.lineWidth.Scroll += new System.EventHandler(this.lineWidth_Scroll);
            // 
            // color_picker
            // 
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Image = global::Paint.Properties.Resources.color_palette;
            this.color_picker.Location = new System.Drawing.Point(52, 18);
            this.color_picker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(346, 131);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 4;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_clear.Image = global::Paint.Properties.Resources.trash_regular_24;
            this.btn_clear.Location = new System.Drawing.Point(1766, 115);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(70, 42);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_save.Image = global::Paint.Properties.Resources.save_regular_24;
            this.btn_save.Location = new System.Drawing.Point(1766, 63);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(70, 45);
            this.btn_save.TabIndex = 1;
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_color.Location = new System.Drawing.Point(408, 63);
            this.pic_color.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(50, 45);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            this.pic_color.Click += new System.EventHandler(this.pic_color_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.btn_AddText);
            this.panel3.Controls.Add(this.btn_elipse);
            this.panel3.Controls.Add(this.btn_eraser);
            this.panel3.Controls.Add(this.btn_triangle);
            this.panel3.Controls.Add(this.btn_line);
            this.panel3.Controls.Add(this.btn_pencil);
            this.panel3.Controls.Add(this.btn_rect);
            this.panel3.Controls.Add(this.btn_fill);
            this.panel3.Location = new System.Drawing.Point(466, 18);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 131);
            this.panel3.TabIndex = 3;
            // 
            // btn_AddText
            // 
            this.btn_AddText.BackColor = System.Drawing.Color.White;
            this.btn_AddText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_AddText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AddText.Image = global::Paint.Properties.Resources.addtext_24;
            this.btn_AddText.Location = new System.Drawing.Point(360, 17);
            this.btn_AddText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_AddText.Name = "btn_AddText";
            this.btn_AddText.Size = new System.Drawing.Size(92, 94);
            this.btn_AddText.TabIndex = 3;
            this.btn_AddText.Text = "Add Text";
            this.btn_AddText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_AddText.UseVisualStyleBackColor = false;
            this.btn_AddText.Click += new System.EventHandler(this.btn_AddText_Click);
            // 
            // btn_elipse
            // 
            this.btn_elipse.BackColor = System.Drawing.Color.White;
            this.btn_elipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_elipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_elipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_elipse.Image = global::Paint.Properties.Resources.circle_regular_24;
            this.btn_elipse.Location = new System.Drawing.Point(474, 17);
            this.btn_elipse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_elipse.Name = "btn_elipse";
            this.btn_elipse.Size = new System.Drawing.Size(92, 94);
            this.btn_elipse.TabIndex = 1;
            this.btn_elipse.Text = "Ellipse";
            this.btn_elipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elipse.UseVisualStyleBackColor = false;
            this.btn_elipse.Click += new System.EventHandler(this.btn_elipse_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.Color.White;
            this.btn_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_eraser.Image = global::Paint.Properties.Resources.eraser_solid_24;
            this.btn_eraser.Location = new System.Drawing.Point(245, 17);
            this.btn_eraser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(92, 95);
            this.btn_eraser.TabIndex = 1;
            this.btn_eraser.Text = "Eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = false;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_triangle
            // 
            this.btn_triangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_triangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_triangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_triangle.Image = global::Paint.Properties.Resources.shape_triangle_regular_24;
            this.btn_triangle.Location = new System.Drawing.Point(833, 17);
            this.btn_triangle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_triangle.Name = "btn_triangle";
            this.btn_triangle.Size = new System.Drawing.Size(92, 92);
            this.btn_triangle.TabIndex = 2;
            this.btn_triangle.Text = "Triangle";
            this.btn_triangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_triangle.UseVisualStyleBackColor = true;
            this.btn_triangle.Click += new System.EventHandler(this.btn_polygon_Click);
            // 
            // btn_line
            // 
            this.btn_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_line.Image = global::Paint.Properties.Resources.minus_regular_24;
            this.btn_line.Location = new System.Drawing.Point(591, 17);
            this.btn_line.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(93, 94);
            this.btn_line.TabIndex = 1;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_pencil.Image = global::Paint.Properties.Resources.pencil_regular_24;
            this.btn_pencil.Location = new System.Drawing.Point(132, 17);
            this.btn_pencil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(92, 95);
            this.btn_pencil.TabIndex = 1;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = true;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_rect.Image = global::Paint.Properties.Resources.rectangle_regular_24;
            this.btn_rect.Location = new System.Drawing.Point(705, 17);
            this.btn_rect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(106, 91);
            this.btn_rect.TabIndex = 1;
            this.btn_rect.Text = "Rectangle";
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = true;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_fill.Image = global::Paint.Properties.Resources.color_fill_solid_24;
            this.btn_fill.Location = new System.Drawing.Point(20, 19);
            this.btn_fill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(92, 95);
            this.btn_fill.TabIndex = 1;
            this.btn_fill.Text = "Fill";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btn_Zoomin);
            this.panel2.Controls.Add(this.trB_zoom);
            this.panel2.Controls.Add(this.btn_Zoomout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1005);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1880, 45);
            this.panel2.TabIndex = 1;
            // 
            // btn_Zoomin
            // 
            this.btn_Zoomin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Zoomin.Location = new System.Drawing.Point(1814, -2);
            this.btn_Zoomin.Name = "btn_Zoomin";
            this.btn_Zoomin.Size = new System.Drawing.Size(50, 46);
            this.btn_Zoomin.TabIndex = 9;
            this.btn_Zoomin.Text = "+";
            this.btn_Zoomin.UseVisualStyleBackColor = true;
            this.btn_Zoomin.Click += new System.EventHandler(this.btn_Zoomin_Click);
            // 
            // trB_zoom
            // 
            this.trB_zoom.AutoSize = false;
            this.trB_zoom.BackColor = System.Drawing.Color.RosyBrown;
            this.trB_zoom.Location = new System.Drawing.Point(1612, 0);
            this.trB_zoom.Minimum = 1;
            this.trB_zoom.Name = "trB_zoom";
            this.trB_zoom.Size = new System.Drawing.Size(196, 45);
            this.trB_zoom.TabIndex = 7;
            this.trB_zoom.Value = 10;
            this.trB_zoom.Scroll += new System.EventHandler(this.trB_zoom_Scroll);
            this.trB_zoom.ValueChanged += new System.EventHandler(this.trB_zoom_ValueChanged);
            // 
            // btn_Zoomout
            // 
            this.btn_Zoomout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Zoomout.Location = new System.Drawing.Point(1562, 0);
            this.btn_Zoomout.Name = "btn_Zoomout";
            this.btn_Zoomout.Size = new System.Drawing.Size(46, 45);
            this.btn_Zoomout.TabIndex = 8;
            this.btn_Zoomout.Text = "-";
            this.btn_Zoomout.UseVisualStyleBackColor = true;
            this.btn_Zoomout.Click += new System.EventHandler(this.btn_Zoomout_Click);
            // 
            // pic
            // 
            this.pic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Location = new System.Drawing.Point(0, 168);
            this.pic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1880, 934);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1880, 1050);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trB_zoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_elipse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TrackBar lineWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_triangle;
        private System.Windows.Forms.Button btn_Zoomin;
        private System.Windows.Forms.TrackBar trB_zoom;
        private System.Windows.Forms.Button btn_Zoomout;
        private System.Windows.Forms.Button btn_AddText;
        private System.Windows.Forms.Button btn_redo;
        private System.Windows.Forms.Button btn_undo;
    }
}

