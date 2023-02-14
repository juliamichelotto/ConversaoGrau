namespace tp
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
            this.lblConverter = new System.Windows.Forms.Label();
            this.cboTipoConversao = new System.Windows.Forms.ComboBox();
            this.txtValorRecebido = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConversão = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConverter
            // 
            this.lblConverter.AutoSize = true;
            this.lblConverter.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConverter.Location = new System.Drawing.Point(12, 106);
            this.lblConverter.Name = "lblConverter";
            this.lblConverter.Size = new System.Drawing.Size(217, 23);
            this.lblConverter.TabIndex = 0;
            this.lblConverter.Text = "Valor para Converter:";
            // 
            // cboTipoConversao
            // 
            this.cboTipoConversao.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoConversao.FormattingEnabled = true;
            this.cboTipoConversao.Items.AddRange(new object[] {
            "Celsius para Fahrenheit",
            "Fahrenheit para Celsius "});
            this.cboTipoConversao.Location = new System.Drawing.Point(310, 39);
            this.cboTipoConversao.Name = "cboTipoConversao";
            this.cboTipoConversao.Size = new System.Drawing.Size(248, 31);
            this.cboTipoConversao.TabIndex = 1;
            this.cboTipoConversao.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorRecebido.Location = new System.Drawing.Point(310, 103);
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Size = new System.Drawing.Size(179, 31);
            this.txtValorRecebido.TabIndex = 2;
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(310, 273);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(179, 31);
            this.txtResultado.TabIndex = 3;
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.Color.MistyRose;
            this.btnConverter.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(186, 183);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(159, 48);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "Converter\r\n";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor Convertido:";
            // 
            // lblConversão
            // 
            this.lblConversão.AutoSize = true;
            this.lblConversão.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversão.Location = new System.Drawing.Point(12, 42);
            this.lblConversão.Name = "lblConversão";
            this.lblConversão.Size = new System.Drawing.Size(292, 23);
            this.lblConversão.TabIndex = 6;
            this.lblConversão.Text = "Escolha o tipo de Conversão:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 386);
            this.Controls.Add(this.lblConversão);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValorRecebido);
            this.Controls.Add(this.cboTipoConversao);
            this.Controls.Add(this.lblConverter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConverter;
        private System.Windows.Forms.ComboBox cboTipoConversao;
        private System.Windows.Forms.TextBox txtValorRecebido;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConversão;
    }
}

