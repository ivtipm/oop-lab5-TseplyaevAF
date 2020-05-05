namespace GameOfLife
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox_NotGrid = new System.Windows.Forms.PictureBox();
            this.pictureBox_Grid = new System.Windows.Forms.PictureBox();
            this.pictureBox_Settings = new System.Windows.Forms.PictureBox();
            this.pictureBox_Pause = new System.Windows.Forms.PictureBox();
            this.pictureBox_Clear = new System.Windows.Forms.PictureBox();
            this.pictureBox_Step = new System.Windows.Forms.PictureBox();
            this.pictureBox_Fill = new System.Windows.Forms.PictureBox();
            this.pictureBox_Play = new System.Windows.Forms.PictureBox();
            this.pictureBox_GameField = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NotGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Step)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Fill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GameField)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(344, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.файлToolStripMenuItem.Text = "Меню";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить конфиг";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть конфиг";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox_NotGrid
            // 
            this.pictureBox_NotGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_NotGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_NotGrid.Image = global::GameOfLife.Properties.Resources.не_сетка;
            this.pictureBox_NotGrid.Location = new System.Drawing.Point(219, 353);
            this.pictureBox_NotGrid.Name = "pictureBox_NotGrid";
            this.pictureBox_NotGrid.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_NotGrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_NotGrid.TabIndex = 10;
            this.pictureBox_NotGrid.TabStop = false;
            this.pictureBox_NotGrid.Visible = false;
            this.pictureBox_NotGrid.Click += new System.EventHandler(this.pictureBox_NotGrid_Click);
            // 
            // pictureBox_Grid
            // 
            this.pictureBox_Grid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Grid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Grid.Image = global::GameOfLife.Properties.Resources.сетка;
            this.pictureBox_Grid.Location = new System.Drawing.Point(219, 353);
            this.pictureBox_Grid.Name = "pictureBox_Grid";
            this.pictureBox_Grid.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_Grid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Grid.TabIndex = 9;
            this.pictureBox_Grid.TabStop = false;
            this.pictureBox_Grid.Click += new System.EventHandler(this.pictureBox_Grid_Click);
            // 
            // pictureBox_Settings
            // 
            this.pictureBox_Settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Settings.Image = global::GameOfLife.Properties.Resources.settings1;
            this.pictureBox_Settings.Location = new System.Drawing.Point(265, 353);
            this.pictureBox_Settings.Name = "pictureBox_Settings";
            this.pictureBox_Settings.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Settings.TabIndex = 8;
            this.pictureBox_Settings.TabStop = false;
            this.pictureBox_Settings.Click += new System.EventHandler(this.pictureBox_Settings_Click);
            // 
            // pictureBox_Pause
            // 
            this.pictureBox_Pause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Pause.Image = global::GameOfLife.Properties.Resources.pause;
            this.pictureBox_Pause.Location = new System.Drawing.Point(127, 353);
            this.pictureBox_Pause.Name = "pictureBox_Pause";
            this.pictureBox_Pause.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Pause.TabIndex = 6;
            this.pictureBox_Pause.TabStop = false;
            this.pictureBox_Pause.Visible = false;
            this.pictureBox_Pause.Click += new System.EventHandler(this.pictureBox_Pause_Click);
            // 
            // pictureBox_Clear
            // 
            this.pictureBox_Clear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Clear.Image = global::GameOfLife.Properties.Resources._new;
            this.pictureBox_Clear.Location = new System.Drawing.Point(173, 353);
            this.pictureBox_Clear.Name = "pictureBox_Clear";
            this.pictureBox_Clear.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_Clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Clear.TabIndex = 4;
            this.pictureBox_Clear.TabStop = false;
            this.pictureBox_Clear.Click += new System.EventHandler(this.pictureBox_Clear_Click);
            // 
            // pictureBox_Step
            // 
            this.pictureBox_Step.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Step.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Step.Image = global::GameOfLife.Properties.Resources.step;
            this.pictureBox_Step.Location = new System.Drawing.Point(81, 353);
            this.pictureBox_Step.Name = "pictureBox_Step";
            this.pictureBox_Step.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_Step.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Step.TabIndex = 3;
            this.pictureBox_Step.TabStop = false;
            this.pictureBox_Step.Click += new System.EventHandler(this.pictureBox_Step_Click);
            // 
            // pictureBox_Fill
            // 
            this.pictureBox_Fill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Fill.Image = global::GameOfLife.Properties.Resources.filll;
            this.pictureBox_Fill.Location = new System.Drawing.Point(35, 353);
            this.pictureBox_Fill.Name = "pictureBox_Fill";
            this.pictureBox_Fill.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_Fill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Fill.TabIndex = 2;
            this.pictureBox_Fill.TabStop = false;
            this.pictureBox_Fill.Click += new System.EventHandler(this.pictureBox_Fill_Click);
            // 
            // pictureBox_Play
            // 
            this.pictureBox_Play.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Play.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Play.Image")));
            this.pictureBox_Play.Location = new System.Drawing.Point(127, 353);
            this.pictureBox_Play.Name = "pictureBox_Play";
            this.pictureBox_Play.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Play.TabIndex = 1;
            this.pictureBox_Play.TabStop = false;
            this.pictureBox_Play.Click += new System.EventHandler(this.pictureBox_Play_Click);
            // 
            // pictureBox_GameField
            // 
            this.pictureBox_GameField.BackColor = System.Drawing.Color.Black;
            this.pictureBox_GameField.Location = new System.Drawing.Point(12, 27);
            this.pictureBox_GameField.MaximumSize = new System.Drawing.Size(320, 320);
            this.pictureBox_GameField.MinimumSize = new System.Drawing.Size(320, 320);
            this.pictureBox_GameField.Name = "pictureBox_GameField";
            this.pictureBox_GameField.Size = new System.Drawing.Size(320, 320);
            this.pictureBox_GameField.TabIndex = 0;
            this.pictureBox_GameField.TabStop = false;
            this.pictureBox_GameField.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_GameField_Paint);
            this.pictureBox_GameField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_GameField_MouseDown);
            this.pictureBox_GameField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_GameField_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 400);
            this.Controls.Add(this.pictureBox_NotGrid);
            this.Controls.Add(this.pictureBox_Grid);
            this.Controls.Add(this.pictureBox_Settings);
            this.Controls.Add(this.pictureBox_Pause);
            this.Controls.Add(this.pictureBox_Clear);
            this.Controls.Add(this.pictureBox_Step);
            this.Controls.Add(this.pictureBox_Fill);
            this.Controls.Add(this.pictureBox_Play);
            this.Controls.Add(this.pictureBox_GameField);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(360, 439);
            this.MinimumSize = new System.Drawing.Size(360, 439);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conway\'s Game of Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NotGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Step)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Fill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GameField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_GameField;
        private System.Windows.Forms.PictureBox pictureBox_Play;
        private System.Windows.Forms.PictureBox pictureBox_Fill;
        private System.Windows.Forms.PictureBox pictureBox_Step;
        private System.Windows.Forms.PictureBox pictureBox_Clear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox_Pause;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox_Settings;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox_Grid;
        private System.Windows.Forms.PictureBox pictureBox_NotGrid;
    }
}

