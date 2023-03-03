namespace PRIMER_PARCIAL
{
    partial class FDESCUENTO
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CBdiscount = new System.Windows.Forms.ComboBox();
            this.CBitems = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBqty = new System.Windows.Forms.TextBox();
            this.TBprice = new System.Windows.Forms.TextBox();
            this.bCalc = new System.Windows.Forms.Button();
            this.BnewItem = new System.Windows.Forms.Button();
            this.Bexit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBtotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TBitbis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TBdiscount = new System.Windows.Forms.TextBox();
            this.TBsubTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBdiscount
            // 
            this.CBdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBdiscount.FormattingEnabled = true;
            this.CBdiscount.Items.AddRange(new object[] {
            "CATEGORÍA  1",
            "CATEGORÍA  2 ",
            "CATEGORÍA  3",
            "CATEGORÍA  4"});
            this.CBdiscount.Location = new System.Drawing.Point(135, 253);
            this.CBdiscount.Name = "CBdiscount";
            this.CBdiscount.Size = new System.Drawing.Size(300, 32);
            this.CBdiscount.TabIndex = 2;
            this.CBdiscount.Text = "SELECCIONA LA CATEGORÍA";
            // 
            // CBitems
            // 
            this.CBitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBitems.FormattingEnabled = true;
            this.CBitems.Items.AddRange(new object[] {
            "Aceite de Higado de Bacalao Emulsión Frasco 180 ml",
            "Acetaminofén (Paracetamol) Tableta 500 mg",
            "Acetaminofen (Paracetamol) 100 mg Supositorio",
            "Acetaminofén (Paracetamol) Gotas Pedatricas 100 mg/ml",
            "Acetaminofen (Paracetamol) Jbe. 125mg/5ml",
            "Acetaminofen+Cafeina Tableta 500mg/65 mg",
            "Acetato De Medroxiprogesterona Inyección de Liberación Retardada 150 mg/ml",
            "Acetilcisteína Ampolla 300 mg/3 ml",
            "Aciclovir Tableta 400 mg",
            "Aciclovir 200 mg/5 mL Suspensión",
            "Aciclovir Crema Tubo de 5 g",
            "Acido Acetilsalicílico 325mg"});
            this.CBitems.Location = new System.Drawing.Point(135, 117);
            this.CBitems.Name = "CBitems";
            this.CBitems.Size = new System.Drawing.Size(416, 32);
            this.CBitems.TabIndex = 1;
            this.CBitems.Text = "SELECCIONA UN ARTICULO";
            this.CBitems.SelectedIndexChanged += new System.EventHandler(this.CBitems_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Articulo.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio.:";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10);
            this.label5.Size = new System.Drawing.Size(632, 50);
            this.label5.TabIndex = 6;
            this.label5.Text = "DESCUENTOS POR CATEGORÍA ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(632, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Estudiante:. Natanael - 16-EISN-6-061";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TBqty
            // 
            this.TBqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBqty.Location = new System.Drawing.Point(135, 161);
            this.TBqty.Name = "TBqty";
            this.TBqty.Size = new System.Drawing.Size(139, 29);
            this.TBqty.TabIndex = 8;
            this.TBqty.TextChanged += new System.EventHandler(this.onChange);
            this.TBqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onPressPriceQty);
            // 
            // TBprice
            // 
            this.TBprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBprice.Location = new System.Drawing.Point(135, 207);
            this.TBprice.Name = "TBprice";
            this.TBprice.Size = new System.Drawing.Size(139, 29);
            this.TBprice.TabIndex = 9;
            this.TBprice.TextChanged += new System.EventHandler(this.onChange);
            this.TBprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onPressPriceQty);
            // 
            // bCalc
            // 
            this.bCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCalc.Location = new System.Drawing.Point(12, 6);
            this.bCalc.Name = "bCalc";
            this.bCalc.Size = new System.Drawing.Size(158, 49);
            this.bCalc.TabIndex = 10;
            this.bCalc.Text = "Calcular";
            this.bCalc.UseVisualStyleBackColor = true;
            this.bCalc.Click += new System.EventHandler(this.calculate);
            // 
            // BnewItem
            // 
            this.BnewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnewItem.Location = new System.Drawing.Point(12, 74);
            this.BnewItem.Name = "BnewItem";
            this.BnewItem.Size = new System.Drawing.Size(158, 46);
            this.BnewItem.TabIndex = 11;
            this.BnewItem.Text = "Nuevo articulo";
            this.BnewItem.UseVisualStyleBackColor = true;
            this.BnewItem.Click += new System.EventHandler(this.newItem);
            // 
            // Bexit
            // 
            this.Bexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bexit.Location = new System.Drawing.Point(12, 139);
            this.Bexit.Name = "Bexit";
            this.Bexit.Size = new System.Drawing.Size(158, 46);
            this.Bexit.TabIndex = 12;
            this.Bexit.Text = "Salir";
            this.Bexit.UseVisualStyleBackColor = true;
            this.Bexit.Click += new System.EventHandler(this.exitApp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.TBtotal);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TBitbis);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TBdiscount);
            this.panel1.Controls.Add(this.Bexit);
            this.panel1.Controls.Add(this.BnewItem);
            this.panel1.Controls.Add(this.TBsubTotal);
            this.panel1.Controls.Add(this.bCalc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 197);
            this.panel1.TabIndex = 13;
            // 
            // TBtotal
            // 
            this.TBtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtotal.Location = new System.Drawing.Point(479, 153);
            this.TBtotal.Name = "TBtotal";
            this.TBtotal.ReadOnly = true;
            this.TBtotal.Size = new System.Drawing.Size(139, 29);
            this.TBtotal.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(396, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Total.:";
            // 
            // TBitbis
            // 
            this.TBitbis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBitbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBitbis.Location = new System.Drawing.Point(479, 107);
            this.TBitbis.Name = "TBitbis";
            this.TBitbis.ReadOnly = true;
            this.TBitbis.Size = new System.Drawing.Size(139, 29);
            this.TBitbis.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(393, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "ITBIS.:";
            // 
            // TBdiscount
            // 
            this.TBdiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBdiscount.Location = new System.Drawing.Point(479, 58);
            this.TBdiscount.Name = "TBdiscount";
            this.TBdiscount.ReadOnly = true;
            this.TBdiscount.Size = new System.Drawing.Size(139, 29);
            this.TBdiscount.TabIndex = 13;
            // 
            // TBsubTotal
            // 
            this.TBsubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBsubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBsubTotal.Location = new System.Drawing.Point(479, 12);
            this.TBsubTotal.Name = "TBsubTotal";
            this.TBsubTotal.ReadOnly = true;
            this.TBsubTotal.Size = new System.Drawing.Size(139, 29);
            this.TBsubTotal.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(346, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descuento.:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(370, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Subtotal.:";
            // 
            // FDESCUENTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TBprice);
            this.Controls.Add(this.TBqty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBitems);
            this.Controls.Add(this.CBdiscount);
            this.Name = "FDESCUENTO";
            this.Text = "DESCUENTO POR CATEGORIA";
            this.Load += new System.EventHandler(this.FDESCUENTO_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBdiscount;
        private System.Windows.Forms.ComboBox CBitems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBqty;
        private System.Windows.Forms.TextBox TBprice;
        private System.Windows.Forms.Button bCalc;
        private System.Windows.Forms.Button BnewItem;
        private System.Windows.Forms.Button Bexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBtotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBitbis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBdiscount;
        private System.Windows.Forms.TextBox TBsubTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

