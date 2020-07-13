namespace CalculadoraApp
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
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.bt0 = new System.Windows.Forms.Button();
            this.btcoma = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btDivision = new System.Windows.Forms.Button();
            this.btProducto = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.btResta = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btSuma = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.lbListaCalculos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbDisplay
            // 
            this.tbDisplay.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDisplay.Location = new System.Drawing.Point(29, 23);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(243, 47);
            this.tbDisplay.TabIndex = 0;
            this.tbDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(29, 305);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(69, 49);
            this.bt0.TabIndex = 1;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btcoma
            // 
            this.btcoma.Location = new System.Drawing.Point(118, 305);
            this.btcoma.Name = "btcoma";
            this.btcoma.Size = new System.Drawing.Size(69, 49);
            this.btcoma.TabIndex = 1;
            this.btcoma.Text = ",";
            this.btcoma.UseVisualStyleBackColor = true;
            this.btcoma.Click += new System.EventHandler(this.btcoma_Click);
            // 
            // btIgual
            // 
            this.btIgual.Location = new System.Drawing.Point(208, 305);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(69, 49);
            this.btIgual.TabIndex = 1;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // btDivision
            // 
            this.btDivision.Location = new System.Drawing.Point(296, 305);
            this.btDivision.Name = "btDivision";
            this.btDivision.Size = new System.Drawing.Size(69, 49);
            this.btDivision.TabIndex = 1;
            this.btDivision.Text = "/";
            this.btDivision.UseVisualStyleBackColor = true;
            this.btDivision.Click += new System.EventHandler(this.btDivision_Click);
            // 
            // btProducto
            // 
            this.btProducto.Location = new System.Drawing.Point(296, 234);
            this.btProducto.Name = "btProducto";
            this.btProducto.Size = new System.Drawing.Size(69, 49);
            this.btProducto.TabIndex = 1;
            this.btProducto.Text = "*";
            this.btProducto.UseVisualStyleBackColor = true;
            this.btProducto.Click += new System.EventHandler(this.btProducto_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(208, 234);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(69, 49);
            this.bt3.TabIndex = 1;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(118, 234);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(69, 49);
            this.bt2.TabIndex = 1;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(29, 234);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(69, 49);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btResta
            // 
            this.btResta.Location = new System.Drawing.Point(296, 163);
            this.btResta.Name = "btResta";
            this.btResta.Size = new System.Drawing.Size(69, 49);
            this.btResta.TabIndex = 1;
            this.btResta.Text = "-";
            this.btResta.UseVisualStyleBackColor = true;
            this.btResta.Click += new System.EventHandler(this.btResta_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(208, 163);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(69, 49);
            this.bt6.TabIndex = 1;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(118, 163);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(69, 49);
            this.bt5.TabIndex = 1;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(29, 163);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(69, 49);
            this.bt4.TabIndex = 1;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // btSuma
            // 
            this.btSuma.Location = new System.Drawing.Point(296, 94);
            this.btSuma.Name = "btSuma";
            this.btSuma.Size = new System.Drawing.Size(69, 49);
            this.btSuma.TabIndex = 1;
            this.btSuma.Text = "+";
            this.btSuma.UseVisualStyleBackColor = true;
            this.btSuma.Click += new System.EventHandler(this.btSuma_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(208, 94);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(69, 49);
            this.bt9.TabIndex = 1;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(118, 94);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(69, 49);
            this.bt8.TabIndex = 1;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(29, 94);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(69, 49);
            this.bt7.TabIndex = 1;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // btC
            // 
            this.btC.Location = new System.Drawing.Point(296, 23);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(69, 49);
            this.btC.TabIndex = 1;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // lbListaCalculos
            // 
            this.lbListaCalculos.FormattingEnabled = true;
            this.lbListaCalculos.ItemHeight = 15;
            this.lbListaCalculos.Location = new System.Drawing.Point(417, 23);
            this.lbListaCalculos.Name = "lbListaCalculos";
            this.lbListaCalculos.Size = new System.Drawing.Size(281, 334);
            this.lbListaCalculos.TabIndex = 2;
            this.lbListaCalculos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 381);
            this.Controls.Add(this.lbListaCalculos);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.btSuma);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.btResta);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.btProducto);
            this.Controls.Add(this.btDivision);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btcoma);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.tbDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btcoma;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btDivision;
        private System.Windows.Forms.Button btProducto;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btResta;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btSuma;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.ListBox lbListaCalculos;
    }
}

