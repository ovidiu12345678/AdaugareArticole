namespace AdaugareArticole
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.lstArticole = new System.Windows.Forms.ListView();
            this.colArticol = new System.Windows.Forms.ColumnHeader();
            this.colPret = new System.Windows.Forms.ColumnHeader();
            this.colCantitate = new System.Windows.Forms.ColumnHeader();
            this.colTotal = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSergereElementeDinLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAdaugare.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdaugare.Location = new System.Drawing.Point(57, 379);
            this.btnAdaugare.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(109, 39);
            this.btnAdaugare.TabIndex = 2;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // lstArticole
            // 
            this.lstArticole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstArticole.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lstArticole.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colArticol,
            this.colPret,
            this.colCantitate,
            this.colTotal});
            this.lstArticole.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstArticole.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lstArticole.FullRowSelect = true;
            this.lstArticole.GridLines = true;
            this.lstArticole.Location = new System.Drawing.Point(69, 50);
            this.lstArticole.Margin = new System.Windows.Forms.Padding(4);
            this.lstArticole.Name = "lstArticole";
            this.lstArticole.Size = new System.Drawing.Size(688, 291);
            this.lstArticole.TabIndex = 1;
            this.lstArticole.UseCompatibleStateImageBehavior = false;
            this.lstArticole.View = System.Windows.Forms.View.Details;
            // 
            // colArticol
            // 
            this.colArticol.Text = "Articol";
            this.colArticol.Width = 200;
            // 
            // colPret
            // 
            this.colPret.Text = "Pret";
            this.colPret.Width = 150;
            // 
            // colCantitate
            // 
            this.colCantitate.Text = "Cantitate";
            this.colCantitate.Width = 150;
            // 
            // colTotal
            // 
            this.colTotal.Text = "Total";
            this.colTotal.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(600, 389);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total";
            // 
            // textTotal
            // 
            this.textTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTotal.Location = new System.Drawing.Point(675, 383);
            this.textTotal.Margin = new System.Windows.Forms.Padding(4);
            this.textTotal.Multiline = true;
            this.textTotal.Name = "textTotal";
            this.textTotal.ReadOnly = true;
            this.textTotal.Size = new System.Drawing.Size(140, 31);
            this.textTotal.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(201, 381);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 37);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSergereElementeDinLista
            // 
            this.btnSergereElementeDinLista.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSergereElementeDinLista.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSergereElementeDinLista.Location = new System.Drawing.Point(343, 381);
            this.btnSergereElementeDinLista.Name = "btnSergereElementeDinLista";
            this.btnSergereElementeDinLista.Size = new System.Drawing.Size(225, 35);
            this.btnSergereElementeDinLista.TabIndex = 5;
            this.btnSergereElementeDinLista.Text = "Stergeti Articol";
            this.btnSergereElementeDinLista.UseVisualStyleBackColor = false;
            this.btnSergereElementeDinLista.Click += new System.EventHandler(this.btnSergereElementeDinLista_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdaugare;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 446);
            this.Controls.Add(this.btnSergereElementeDinLista);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstArticole);
            this.Controls.Add(this.btnAdaugare);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdaugare;
        private ListView lstArticole;
        private ColumnHeader colArticol;
        private ColumnHeader colPret;
        private ColumnHeader colCantitate;
        private ColumnHeader colTotal;
        private Label label1;
        private TextBox textTotal;
        private Button btnCancel;
        private Button btnSergereElementeDinLista;
    }
}