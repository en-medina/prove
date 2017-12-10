namespace Order_App
{
    partial class ProceedToCheckForm
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
            this.listViewProceedToCheck = new System.Windows.Forms.ListView();
            this.ProceedCheckIDCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEmpID = new System.Windows.Forms.Label();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.labelIDCustomer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artículos Selecionados";
            // 
            // listViewProceedToCheck
            // 
            this.listViewProceedToCheck.FullRowSelect = true;
            this.listViewProceedToCheck.GridLines = true;
            this.listViewProceedToCheck.Location = new System.Drawing.Point(12, 41);
            this.listViewProceedToCheck.Name = "listViewProceedToCheck";
            this.listViewProceedToCheck.Size = new System.Drawing.Size(566, 247);
            this.listViewProceedToCheck.TabIndex = 1;
            this.listViewProceedToCheck.UseCompatibleStateImageBehavior = false;
            this.listViewProceedToCheck.View = System.Windows.Forms.View.Details;
            this.listViewProceedToCheck.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ProceedCheckIDCustomer
            // 
            this.ProceedCheckIDCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProceedCheckIDCustomer.Location = new System.Drawing.Point(230, 305);
            this.ProceedCheckIDCustomer.Name = "ProceedCheckIDCustomer";
            this.ProceedCheckIDCustomer.Size = new System.Drawing.Size(202, 35);
            this.ProceedCheckIDCustomer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID del Cliente:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelEmpID
            // 
            this.labelEmpID.AutoSize = true;
            this.labelEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpID.Location = new System.Drawing.Point(225, 410);
            this.labelEmpID.Name = "labelEmpID";
            this.labelEmpID.Size = new System.Drawing.Size(39, 29);
            this.labelEmpID.TabIndex = 5;
            this.labelEmpID.Text = "00";
            // 
            // labelEmpName
            // 
            this.labelEmpName.AutoSize = true;
            this.labelEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpName.Location = new System.Drawing.Point(225, 381);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(39, 29);
            this.labelEmpName.TabIndex = 6;
            this.labelEmpName.Text = "00";
            // 
            // labelIDCustomer
            // 
            this.labelIDCustomer.AutoSize = true;
            this.labelIDCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDCustomer.Location = new System.Drawing.Point(225, 352);
            this.labelIDCustomer.Name = "labelIDCustomer";
            this.labelIDCustomer.Size = new System.Drawing.Size(39, 29);
            this.labelIDCustomer.TabIndex = 7;
            this.labelIDCustomer.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "ID Empleado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 29);
            this.label9.TabIndex = 10;
            this.label9.Text = "Nombre Empleado:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(60, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 29);
            this.label11.TabIndex = 12;
            this.label11.Text = "ID del Cliente:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(438, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Chequear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(361, 484);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 78);
            this.button3.TabIndex = 15;
            this.button3.Text = "Realizar Orden";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 484);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 78);
            this.button4.TabIndex = 16;
            this.button4.Text = "Volver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Total:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(396, 439);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(156, 29);
            this.Total.TabIndex = 18;
            this.Total.Text = "00000000000";
            // 
            // ProceedToCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 574);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelIDCustomer);
            this.Controls.Add(this.labelEmpName);
            this.Controls.Add(this.labelEmpID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProceedCheckIDCustomer);
            this.Controls.Add(this.listViewProceedToCheck);
            this.Controls.Add(this.label1);
            this.Name = "ProceedToCheckForm";
            this.Text = "ProceedToCheckForm";
            this.Load += new System.EventHandler(this.ProceedToCheckForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewProceedToCheck;
        private System.Windows.Forms.TextBox ProceedCheckIDCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEmpID;
        private System.Windows.Forms.Label labelEmpName;
        private System.Windows.Forms.Label labelIDCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Total;
    }
}