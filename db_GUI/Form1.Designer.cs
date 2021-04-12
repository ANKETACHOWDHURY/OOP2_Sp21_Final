
namespace db_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCName = new System.Windows.Forms.TextBox();
            this.tbCCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtCourses = new System.Windows.Forms.DataGridView();
            this.loadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name";
            // 
            // tbCName
            // 
            this.tbCName.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCName.Location = new System.Drawing.Point(274, 38);
            this.tbCName.Name = "tbCName";
            this.tbCName.Size = new System.Drawing.Size(189, 43);
            this.tbCName.TabIndex = 1;
            // 
            // tbCCode
            // 
            this.tbCCode.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCCode.Location = new System.Drawing.Point(274, 87);
            this.tbCCode.Name = "tbCCode";
            this.tbCCode.Size = new System.Drawing.Size(189, 43);
            this.tbCCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Code";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(350, 159);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtCourses
            // 
            this.dtCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCourses.Location = new System.Drawing.Point(501, 38);
            this.dtCourses.Name = "dtCourses";
            this.dtCourses.RowHeadersWidth = 51;
            this.dtCourses.RowTemplate.Height = 24;
            this.dtCourses.Size = new System.Drawing.Size(287, 257);
            this.dtCourses.TabIndex = 6;
            // 
            // loadData
            // 
            this.loadData.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadData.Location = new System.Drawing.Point(170, 159);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(113, 40);
            this.loadData.TabIndex = 7;
            this.loadData.Text = "Load";
            this.loadData.UseVisualStyleBackColor = true;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.dtCourses);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbCCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCName;
        private System.Windows.Forms.TextBox tbCCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtCourses;
        private System.Windows.Forms.Button loadData;
    }
}

