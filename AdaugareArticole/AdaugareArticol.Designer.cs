namespace AdaugareArticole
{
    partial class AdaugareArticol
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
            this.textArticol = new System.Windows.Forms.TextBox();
            this.textPret = new System.Windows.Forms.TextBox();
            this.textCantitate = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textArticol
            // 
            this.textArticol.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textArticol.Location = new System.Drawing.Point(92, 12);
            this.textArticol.Name = "textArticol";
            this.textArticol.Size = new System.Drawing.Size(215, 27);
            this.textArticol.TabIndex = 1;
            // 
            // textPret
            // 
            this.textPret.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textPret.Location = new System.Drawing.Point(92, 45);
            this.textPret.Name = "textPret";
            this.textPret.Size = new System.Drawing.Size(103, 27);
            this.textPret.TabIndex = 2;
            // 
            // textCantitate
            // 
            this.textCantitate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textCantitate.Location = new System.Drawing.Point(92, 78);
            this.textCantitate.Name = "textCantitate";
            this.textCantitate.Size = new System.Drawing.Size(103, 27);
            this.textCantitate.TabIndex = 3;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdauga.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdauga.Location = new System.Drawing.Point(92, 132);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(94, 29);
            this.btnAdauga.TabIndex = 4;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancel.Location = new System.Drawing.Point(213, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Articol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantitate";
            // 
            // AdaugareArticol
            // 
            this.AcceptButton = this.btnAdauga;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(369, 180);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.textCantitate);
            this.Controls.Add(this.textPret);
            this.Controls.Add(this.textArticol);
            this.Name = "AdaugareArticol";
            this.Text = "AdaugareArticol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textArticol;
        private TextBox textPret;
        private TextBox textCantitate;
        private Button btnAdauga;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}