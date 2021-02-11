
namespace Converting_To_Black_And_White
{
    partial class ConvertingToBlackAndWhite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertingToBlackAndWhite));
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.PictureOriginal = new System.Windows.Forms.PictureBox();
            this.PictureGray = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureGray)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Location = new System.Drawing.Point(12, 493);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(111, 37);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(773, 493);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 37);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.Control;
            this.btnConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvert.Location = new System.Drawing.Point(400, 493);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(111, 37);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // PictureOriginal
            // 
            this.PictureOriginal.Location = new System.Drawing.Point(12, 12);
            this.PictureOriginal.Name = "PictureOriginal";
            this.PictureOriginal.Size = new System.Drawing.Size(400, 400);
            this.PictureOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureOriginal.TabIndex = 3;
            this.PictureOriginal.TabStop = false;
            // 
            // PictureGray
            // 
            this.PictureGray.Location = new System.Drawing.Point(484, 12);
            this.PictureGray.Name = "PictureGray";
            this.PictureGray.Size = new System.Drawing.Size(400, 400);
            this.PictureGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureGray.TabIndex = 4;
            this.PictureGray.TabStop = false;
            // 
            // ConvertingToBlackAndWhite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(896, 542);
            this.Controls.Add(this.PictureGray);
            this.Controls.Add(this.PictureOriginal);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConvertingToBlackAndWhite";
            this.Text = "ConvertingToBlackAndWhite";
            ((System.ComponentModel.ISupportInitialize)(this.PictureOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureGray)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.PictureBox PictureOriginal;
        private System.Windows.Forms.PictureBox PictureGray;
    }
}

