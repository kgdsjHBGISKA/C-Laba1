namespace LB1_LARINM_ADB_23_06
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
            this.drawPanel1 = new LB1_LARINM_ADB_23_06.DrawPanel();
            this.drowBox1 = new LB1_LARINM_ADB_23_06.DrowBox();
            this.SuspendLayout();
            // 
            // drawPanel1
            // 
            this.drawPanel1.Location = new System.Drawing.Point(12, 12);
            this.drawPanel1.Name = "drawPanel1";
            this.drawPanel1.Size = new System.Drawing.Size(199, 248);
            this.drawPanel1.TabIndex = 11;
            // 
            // drowBox1
            // 
            this.drowBox1.Location = new System.Drawing.Point(233, 24);
            this.drowBox1.Name = "drowBox1";
            this.drowBox1.Size = new System.Drawing.Size(280, 236);
            this.drowBox1.TabIndex = 12;
            this.drowBox1.Load += new System.EventHandler(this.drowBox1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drowBox1);
            this.Controls.Add(this.drawPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DrawPanel drawPanel1;
        private DrowBox drowBox1;
    }
}

