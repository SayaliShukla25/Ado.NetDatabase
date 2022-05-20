
namespace Ado.NetDatabase
{
    partial class Form7
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
            this.btnShowAllStudentDetails = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowAllStudentDetails
            // 
            this.btnShowAllStudentDetails.Location = new System.Drawing.Point(667, 350);
            this.btnShowAllStudentDetails.Name = "btnShowAllStudentDetails";
            this.btnShowAllStudentDetails.Size = new System.Drawing.Size(183, 23);
            this.btnShowAllStudentDetails.TabIndex = 41;
            this.btnShowAllStudentDetails.Text = "Show All Student Details";
            this.btnShowAllStudentDetails.UseVisualStyleBackColor = true;
            this.btnShowAllStudentDetails.Click += new System.EventHandler(this.btnShowAllStudentDetails_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(613, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(292, 179);
            this.dataGridView1.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Percentage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Branch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Roll No";
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(436, 313);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(100, 22);
            this.txtPercentage.TabIndex = 35;
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(436, 247);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(100, 22);
            this.txtBranch.TabIndex = 34;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(436, 176);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 33;
            // 
            // txtRollNo
            // 
            this.txtRollNo.Location = new System.Drawing.Point(436, 117);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(100, 22);
            this.txtRollNo.TabIndex = 32;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(492, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(356, 420);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(215, 420);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(72, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 561);
            this.Controls.Add(this.btnShowAllStudentDetails);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Name = "Form7";
            this.Text = "Dal Student Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAllStudentDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
    }
}