namespace SPMAC_for_Femap.Forms
{
    partial class ParamPistonForm
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
            this.CreatePistonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatePistonBtn
            // 
            this.CreatePistonBtn.Location = new System.Drawing.Point(12, 12);
            this.CreatePistonBtn.Name = "CreatePistonBtn";
            this.CreatePistonBtn.Size = new System.Drawing.Size(166, 23);
            this.CreatePistonBtn.TabIndex = 0;
            this.CreatePistonBtn.Text = "Построить деталь";
            this.CreatePistonBtn.UseVisualStyleBackColor = true;
            this.CreatePistonBtn.Click += new System.EventHandler(this.CreatePistonBtn_Click);
            // 
            // ParamPistonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 332);
            this.Controls.Add(this.CreatePistonBtn);
            this.Name = "ParamPistonForm";
            this.Text = "ParamPistonForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreatePistonBtn;
    }
}