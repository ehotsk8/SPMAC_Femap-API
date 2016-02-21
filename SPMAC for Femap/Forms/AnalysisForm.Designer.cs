namespace SPMAC_for_Femap
{
    partial class AnalysisForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.MaterialButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoadButton);
            this.groupBox1.Controls.Add(this.MaterialButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 333);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор параметров для анализа";
            // 
            // LoadButton
            // 
            this.LoadButton.Enabled = false;
            this.LoadButton.Location = new System.Drawing.Point(128, 19);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(117, 23);
            this.LoadButton.TabIndex = 9;
            this.LoadButton.Text = "Нагрузка";
            this.LoadButton.UseVisualStyleBackColor = true;
            // 
            // MaterialButton
            // 
            this.MaterialButton.Enabled = false;
            this.MaterialButton.Location = new System.Drawing.Point(7, 19);
            this.MaterialButton.Name = "MaterialButton";
            this.MaterialButton.Size = new System.Drawing.Size(112, 23);
            this.MaterialButton.TabIndex = 8;
            this.MaterialButton.Text = "Материал";
            this.MaterialButton.UseVisualStyleBackColor = true;
            this.MaterialButton.Click += new System.EventHandler(this.MaterialButton_Click);
            // 
            // AnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 357);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnalysisForm";
            this.Text = "Анализ";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button MaterialButton;
    }
}