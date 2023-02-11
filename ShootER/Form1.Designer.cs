namespace ShootER
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
            this.MoveBGTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveLeftT = new System.Windows.Forms.Timer(this.components);
            this.MoveRightT = new System.Windows.Forms.Timer(this.components);
            this.MoveUpT = new System.Windows.Forms.Timer(this.components);
            this.MoveDownT = new System.Windows.Forms.Timer(this.components);
            this.HeroBox = new System.Windows.Forms.PictureBox();
            this.MoveBulletT = new System.Windows.Forms.Timer(this.components);
            this.MoveEnemyT = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HeroBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBGTimer
            // 
            this.MoveBGTimer.Enabled = true;
            this.MoveBGTimer.Interval = 10;
            this.MoveBGTimer.Tick += new System.EventHandler(this.MoveBGTimer_Tick);
            // 
            // MoveLeftT
            // 
            this.MoveLeftT.Interval = 10;
            this.MoveLeftT.Tick += new System.EventHandler(this.MoveLeftT_Tick);
            // 
            // MoveRightT
            // 
            this.MoveRightT.Interval = 10;
            this.MoveRightT.Tick += new System.EventHandler(this.MoveRightT_Tick);
            // 
            // MoveUpT
            // 
            this.MoveUpT.Interval = 10;
            this.MoveUpT.Tick += new System.EventHandler(this.MoveUpT_Tick);
            // 
            // MoveDownT
            // 
            this.MoveDownT.Interval = 10;
            this.MoveDownT.Tick += new System.EventHandler(this.MoveDownT_Tick);
            // 
            // HeroBox
            // 
            this.HeroBox.BackColor = System.Drawing.Color.Transparent;
            this.HeroBox.Image = global::ShootER.Properties.Resources.cowboy_idble;
            this.HeroBox.Location = new System.Drawing.Point(160, 480);
            this.HeroBox.Name = "HeroBox";
            this.HeroBox.Size = new System.Drawing.Size(100, 100);
            this.HeroBox.TabIndex = 0;
            this.HeroBox.TabStop = false;
            // 
            // MoveBulletT
            // 
            this.MoveBulletT.Enabled = true;
            this.MoveBulletT.Interval = 10;
            this.MoveBulletT.Tick += new System.EventHandler(this.MoveBulletT_Tick);
            // 
            // MoveEnemyT
            // 
            this.MoveEnemyT.Enabled = true;
            this.MoveEnemyT.Interval = 10;
            this.MoveEnemyT.Tick += new System.EventHandler(this.MoveEnemyT_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(373, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeroBox);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.Text = "ShootER v 0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.HeroBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoveBGTimer;
        private System.Windows.Forms.PictureBox HeroBox;
        private System.Windows.Forms.Timer MoveLeftT;
        private System.Windows.Forms.Timer MoveRightT;
        private System.Windows.Forms.Timer MoveUpT;
        private System.Windows.Forms.Timer MoveDownT;
        private System.Windows.Forms.Timer MoveBulletT;
        private System.Windows.Forms.Timer MoveEnemyT;
        private System.Windows.Forms.Label label1;
    }
}

