namespace SlutProvReal
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
            this.lblCompany = new System.Windows.Forms.Label();
            this.tbxCompany = new System.Windows.Forms.TextBox();
            this.tbxEmployees = new System.Windows.Forms.TextBox();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lbxCompanies = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(28, 50);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(113, 20);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "Företagsnamn";
            // 
            // tbxCompany
            // 
            this.tbxCompany.Location = new System.Drawing.Point(147, 44);
            this.tbxCompany.Name = "tbxCompany";
            this.tbxCompany.Size = new System.Drawing.Size(167, 26);
            this.tbxCompany.TabIndex = 1;
            // 
            // tbxEmployees
            // 
            this.tbxEmployees.Location = new System.Drawing.Point(147, 76);
            this.tbxEmployees.Name = "tbxEmployees";
            this.tbxEmployees.Size = new System.Drawing.Size(167, 26);
            this.tbxEmployees.TabIndex = 3;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(28, 79);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(116, 20);
            this.lblEmployees.TabIndex = 2;
            this.lblEmployees.Text = "Antal Anställda";
            // 
            // lbxCompanies
            // 
            this.lbxCompanies.FormattingEnabled = true;
            this.lbxCompanies.ItemHeight = 20;
            this.lbxCompanies.Location = new System.Drawing.Point(32, 178);
            this.lbxCompanies.Name = "lbxCompanies";
            this.lbxCompanies.Size = new System.Drawing.Size(136, 164);
            this.lbxCompanies.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(136, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Registrera";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(250, 108);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 30);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Radera";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(183, 210);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 27);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "Filtrera";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // tbxFilter
            // 
            this.tbxFilter.Location = new System.Drawing.Point(183, 178);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(100, 26);
            this.tbxFilter.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbxCompanies);
            this.Controls.Add(this.tbxEmployees);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.tbxCompany);
            this.Controls.Add(this.lblCompany);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox tbxCompany;
        private System.Windows.Forms.TextBox tbxEmployees;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.ListBox lbxCompanies;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox tbxFilter;
    }
}

