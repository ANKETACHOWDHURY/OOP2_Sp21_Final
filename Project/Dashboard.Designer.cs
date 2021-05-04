
namespace ReceptionistForm
{
    partial class Dashboard
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
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.btnEditDoctor = new System.Windows.Forms.Button();
            this.btnShowDoctor = new System.Windows.Forms.Button();
            this.btnDeleteDoctor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.BackColor = System.Drawing.Color.Silver;
            this.btnAddDoctor.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDoctor.Location = new System.Drawing.Point(37, 161);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(289, 41);
            this.btnAddDoctor.TabIndex = 0;
            this.btnAddDoctor.Text = "   Add    Doctor";
            this.btnAddDoctor.UseVisualStyleBackColor = false;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // btnEditDoctor
            // 
            this.btnEditDoctor.BackColor = System.Drawing.Color.Silver;
            this.btnEditDoctor.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDoctor.Location = new System.Drawing.Point(37, 208);
            this.btnEditDoctor.Name = "btnEditDoctor";
            this.btnEditDoctor.Size = new System.Drawing.Size(289, 37);
            this.btnEditDoctor.TabIndex = 1;
            this.btnEditDoctor.Text = "    Edit     Doctor";
            this.btnEditDoctor.UseVisualStyleBackColor = false;
            this.btnEditDoctor.Click += new System.EventHandler(this.EditClick);
            // 
            // btnShowDoctor
            // 
            this.btnShowDoctor.BackColor = System.Drawing.Color.Silver;
            this.btnShowDoctor.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDoctor.Location = new System.Drawing.Point(37, 110);
            this.btnShowDoctor.Name = "btnShowDoctor";
            this.btnShowDoctor.Size = new System.Drawing.Size(289, 45);
            this.btnShowDoctor.TabIndex = 2;
            this.btnShowDoctor.Text = " Show ALL   Doctor";
            this.btnShowDoctor.UseVisualStyleBackColor = false;
            this.btnShowDoctor.Click += new System.EventHandler(this.ShowClick);
            // 
            // btnDeleteDoctor
            // 
            this.btnDeleteDoctor.BackColor = System.Drawing.Color.Silver;
            this.btnDeleteDoctor.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDoctor.Location = new System.Drawing.Point(37, 251);
            this.btnDeleteDoctor.Name = "btnDeleteDoctor";
            this.btnDeleteDoctor.Size = new System.Drawing.Size(289, 43);
            this.btnDeleteDoctor.TabIndex = 3;
            this.btnDeleteDoctor.Text = "   Delete   Doctor";
            this.btnDeleteDoctor.UseVisualStyleBackColor = false;
            this.btnDeleteDoctor.Click += new System.EventHandler(this.btnDeleteDoctor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 33);
            this.label1.TabIndex = 30;
            this.label1.Text = "CLICK ! WHERE YOU GO";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteDoctor);
            this.Controls.Add(this.btnShowDoctor);
            this.Controls.Add(this.btnEditDoctor);
            this.Controls.Add(this.btnAddDoctor);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Button btnEditDoctor;
        private System.Windows.Forms.Button btnShowDoctor;
        private System.Windows.Forms.Button btnDeleteDoctor;
        private System.Windows.Forms.Label label1;
    }
}