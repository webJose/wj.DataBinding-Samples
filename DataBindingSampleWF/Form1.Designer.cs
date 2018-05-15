namespace DataBindingSampleWF
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMoveToOtherDGV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.Id,
            this.FirstName,
            this.LastName});
            this.dgv1.Location = new System.Drawing.Point(12, 72);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(505, 198);
            this.dgv1.TabIndex = 0;
            // 
            // Selected
            // 
            this.Selected.DataPropertyName = "Selected";
            this.Selected.HeaderText = "";
            this.Selected.Name = "Selected";
            this.Selected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Selected.Width = 24;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 48;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 105;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 105;
            // 
            // btnMoveToOtherDGV
            // 
            this.btnMoveToOtherDGV.Location = new System.Drawing.Point(12, 276);
            this.btnMoveToOtherDGV.Name = "btnMoveToOtherDGV";
            this.btnMoveToOtherDGV.Size = new System.Drawing.Size(312, 39);
            this.btnMoveToOtherDGV.TabIndex = 1;
            this.btnMoveToOtherDGV.Text = "Move selected to the next grid";
            this.btnMoveToOtherDGV.UseVisualStyleBackColor = true;
            this.btnMoveToOtherDGV.Click += new System.EventHandler(this.btnMoveToOtherDGV_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "There are two grids in this form:  Selected items in the first grid can be moved " +
    "to the second grid.  Just select the row by putting a checkmark in the first col" +
    "umn and then click the provided button.";
            // 
            // dgv2
            // 
            this.dgv2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgv2.Location = new System.Drawing.Point(12, 321);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowTemplate.Height = 24;
            this.dgv2.Size = new System.Drawing.Size(505, 198);
            this.dgv2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 48;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 105;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 105;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 531);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMoveToOtherDGV);
            this.Controls.Add(this.dgv1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.Button btnMoveToOtherDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

