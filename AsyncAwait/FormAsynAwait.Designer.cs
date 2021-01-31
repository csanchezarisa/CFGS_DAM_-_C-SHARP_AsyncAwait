
namespace AsyncAwait
{
    partial class FormAsynAwait
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
            this.btnSequential = new System.Windows.Forms.Button();
            this.ListBoxSequential = new System.Windows.Forms.ListBox();
            this.listBoxTPL = new System.Windows.Forms.ListBox();
            this.btnTPL = new System.Windows.Forms.Button();
            this.progressBarSequential = new System.Windows.Forms.ProgressBar();
            this.progressBarTPL = new System.Windows.Forms.ProgressBar();
            this.txtSequential = new System.Windows.Forms.TextBox();
            this.txtTPL = new System.Windows.Forms.TextBox();
            this.btnTime = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSequential
            // 
            this.btnSequential.Location = new System.Drawing.Point(12, 12);
            this.btnSequential.Name = "btnSequential";
            this.btnSequential.Size = new System.Drawing.Size(75, 23);
            this.btnSequential.TabIndex = 0;
            this.btnSequential.Text = "Sequential";
            this.btnSequential.UseVisualStyleBackColor = true;
            this.btnSequential.Click += new System.EventHandler(this.btnSequential_Click);
            // 
            // ListBoxSequential
            // 
            this.ListBoxSequential.FormattingEnabled = true;
            this.ListBoxSequential.Location = new System.Drawing.Point(93, 12);
            this.ListBoxSequential.Name = "ListBoxSequential";
            this.ListBoxSequential.Size = new System.Drawing.Size(229, 173);
            this.ListBoxSequential.TabIndex = 1;
            // 
            // listBoxTPL
            // 
            this.listBoxTPL.FormattingEnabled = true;
            this.listBoxTPL.Location = new System.Drawing.Point(328, 12);
            this.listBoxTPL.Name = "listBoxTPL";
            this.listBoxTPL.Size = new System.Drawing.Size(229, 173);
            this.listBoxTPL.TabIndex = 2;
            // 
            // btnTPL
            // 
            this.btnTPL.Location = new System.Drawing.Point(563, 12);
            this.btnTPL.Name = "btnTPL";
            this.btnTPL.Size = new System.Drawing.Size(75, 23);
            this.btnTPL.TabIndex = 3;
            this.btnTPL.Text = "TPL";
            this.btnTPL.UseVisualStyleBackColor = true;
            this.btnTPL.Click += new System.EventHandler(this.btnTPL_Click);
            // 
            // progressBarSequential
            // 
            this.progressBarSequential.Location = new System.Drawing.Point(93, 191);
            this.progressBarSequential.Name = "progressBarSequential";
            this.progressBarSequential.Size = new System.Drawing.Size(229, 23);
            this.progressBarSequential.TabIndex = 4;
            // 
            // progressBarTPL
            // 
            this.progressBarTPL.Location = new System.Drawing.Point(328, 191);
            this.progressBarTPL.Name = "progressBarTPL";
            this.progressBarTPL.Size = new System.Drawing.Size(229, 23);
            this.progressBarTPL.TabIndex = 5;
            // 
            // txtSequential
            // 
            this.txtSequential.Location = new System.Drawing.Point(93, 221);
            this.txtSequential.Name = "txtSequential";
            this.txtSequential.ReadOnly = true;
            this.txtSequential.Size = new System.Drawing.Size(229, 20);
            this.txtSequential.TabIndex = 6;
            // 
            // txtTPL
            // 
            this.txtTPL.Location = new System.Drawing.Point(328, 221);
            this.txtTPL.Name = "txtTPL";
            this.txtTPL.ReadOnly = true;
            this.txtTPL.Size = new System.Drawing.Size(229, 20);
            this.txtTPL.TabIndex = 7;
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(93, 292);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(75, 23);
            this.btnTime.TabIndex = 8;
            this.btnTime.Text = "Time?";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(174, 294);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(383, 20);
            this.txtTime.TabIndex = 9;
            // 
            // FormAsynAwait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.txtTPL);
            this.Controls.Add(this.txtSequential);
            this.Controls.Add(this.progressBarTPL);
            this.Controls.Add(this.progressBarSequential);
            this.Controls.Add(this.btnTPL);
            this.Controls.Add(this.listBoxTPL);
            this.Controls.Add(this.ListBoxSequential);
            this.Controls.Add(this.btnSequential);
            this.Name = "FormAsynAwait";
            this.Text = "Async / Await";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSequential;
        private System.Windows.Forms.ListBox ListBoxSequential;
        private System.Windows.Forms.ListBox listBoxTPL;
        private System.Windows.Forms.Button btnTPL;
        private System.Windows.Forms.ProgressBar progressBarSequential;
        private System.Windows.Forms.ProgressBar progressBarTPL;
        private System.Windows.Forms.TextBox txtSequential;
        private System.Windows.Forms.TextBox txtTPL;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.TextBox txtTime;
    }
}

