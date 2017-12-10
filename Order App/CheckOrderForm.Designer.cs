namespace Order_App
{
    partial class CheckOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOrderForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelIDOrder = new System.Windows.Forms.Label();
            this.labelIDCustomer = new System.Windows.Forms.Label();
            this.labelShipDate = new System.Windows.Forms.Label();
            this.labelActualDate = new System.Windows.Forms.Label();
            this.labelIDEmp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID pedido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID cliente:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID empleado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Día procesado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Día de despacho:";
            // 
            // listViewItems
            // 
            this.listViewItems.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listViewItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewItems.FullRowSelect = true;
            this.listViewItems.GridLines = true;
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(17, 157);
            this.listViewItems.MultiSelect = false;
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(561, 269);
            this.listViewItems.TabIndex = 6;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            this.listViewItems.SelectedIndexChanged += new System.EventHandler(this.listViewItems_SelectedIndexChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(392, 429);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(130, 29);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "000000000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(312, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelIDOrder
            // 
            this.labelIDOrder.AutoSize = true;
            this.labelIDOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDOrder.Location = new System.Drawing.Point(219, 9);
            this.labelIDOrder.Name = "labelIDOrder";
            this.labelIDOrder.Size = new System.Drawing.Size(39, 29);
            this.labelIDOrder.TabIndex = 9;
            this.labelIDOrder.Text = "00";
            // 
            // labelIDCustomer
            // 
            this.labelIDCustomer.AutoSize = true;
            this.labelIDCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDCustomer.Location = new System.Drawing.Point(219, 38);
            this.labelIDCustomer.Name = "labelIDCustomer";
            this.labelIDCustomer.Size = new System.Drawing.Size(39, 29);
            this.labelIDCustomer.TabIndex = 10;
            this.labelIDCustomer.Text = "00";
            // 
            // labelShipDate
            // 
            this.labelShipDate.AutoSize = true;
            this.labelShipDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShipDate.Location = new System.Drawing.Point(219, 125);
            this.labelShipDate.Name = "labelShipDate";
            this.labelShipDate.Size = new System.Drawing.Size(39, 29);
            this.labelShipDate.TabIndex = 11;
            this.labelShipDate.Text = "00";
            // 
            // labelActualDate
            // 
            this.labelActualDate.AutoSize = true;
            this.labelActualDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActualDate.Location = new System.Drawing.Point(219, 96);
            this.labelActualDate.Name = "labelActualDate";
            this.labelActualDate.Size = new System.Drawing.Size(39, 29);
            this.labelActualDate.TabIndex = 12;
            this.labelActualDate.Text = "00";
            // 
            // labelIDEmp
            // 
            this.labelIDEmp.AutoSize = true;
            this.labelIDEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDEmp.Location = new System.Drawing.Point(219, 67);
            this.labelIDEmp.Name = "labelIDEmp";
            this.labelIDEmp.Size = new System.Drawing.Size(39, 29);
            this.labelIDEmp.TabIndex = 13;
            this.labelIDEmp.Text = "00";
            // 
            // CheckOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 484);
            this.Controls.Add(this.labelIDEmp);
            this.Controls.Add(this.labelActualDate);
            this.Controls.Add(this.labelShipDate);
            this.Controls.Add(this.labelIDCustomer);
            this.Controls.Add(this.labelIDOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.listViewItems);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckOrderForm";
            this.Text = "CheckOrderForm";
            this.Load += new System.EventHandler(this.CheckOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelIDOrder;
        private System.Windows.Forms.Label labelIDCustomer;
        private System.Windows.Forms.Label labelShipDate;
        private System.Windows.Forms.Label labelActualDate;
        private System.Windows.Forms.Label labelIDEmp;
    }
}