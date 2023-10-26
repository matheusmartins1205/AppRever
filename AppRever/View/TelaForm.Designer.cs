namespace AppRever
{
    partial class TelaForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_valor1 = new TextBox();
            txt_valor2 = new TextBox();
            txt_valor3 = new TextBox();
            btn_calcular = new Button();
            lbl_resultado = new Label();
            btn_limpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("BankGothic Lt BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(106, 36);
            label1.Name = "label1";
            label1.Size = new Size(278, 22);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Maior Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("BankGothic Lt BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 115);
            label2.Name = "label2";
            label2.Size = new Size(149, 17);
            label2.TabIndex = 1;
            label2.Text = "Primeiro Valor :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("BankGothic Lt BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(74, 145);
            label3.Name = "label3";
            label3.Size = new Size(160, 17);
            label3.TabIndex = 2;
            label3.Text = "Segundo Valor : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("BankGothic Lt BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(74, 176);
            label4.Name = "label4";
            label4.Size = new Size(149, 17);
            label4.TabIndex = 3;
            label4.Text = "Terceiro Valor :";
            // 
            // txt_valor1
            // 
            txt_valor1.Location = new Point(229, 113);
            txt_valor1.Name = "txt_valor1";
            txt_valor1.Size = new Size(100, 23);
            txt_valor1.TabIndex = 4;
            // 
            // txt_valor2
            // 
            txt_valor2.Location = new Point(229, 145);
            txt_valor2.Name = "txt_valor2";
            txt_valor2.Size = new Size(100, 23);
            txt_valor2.TabIndex = 5;
            // 
            // txt_valor3
            // 
            txt_valor3.Location = new Point(229, 174);
            txt_valor3.Name = "txt_valor3";
            txt_valor3.Size = new Size(100, 23);
            txt_valor3.TabIndex = 6;
            // 
            // btn_calcular
            // 
            btn_calcular.Font = new Font("BankGothic Lt BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_calcular.Location = new Point(51, 226);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(355, 41);
            btn_calcular.TabIndex = 7;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click_1;
            // 
            // lbl_resultado
            // 
            lbl_resultado.BackColor = SystemColors.MenuHighlight;
            lbl_resultado.Font = new Font("BankGothic Lt BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_resultado.ForeColor = SystemColors.ButtonFace;
            lbl_resultado.Location = new Point(51, 365);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(355, 123);
            lbl_resultado.TabIndex = 8;
            lbl_resultado.Text = "label5";
            lbl_resultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_limpar
            // 
            btn_limpar.Font = new Font("BankGothic Lt BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_limpar.Location = new Point(51, 289);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(355, 43);
            btn_limpar.TabIndex = 9;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // TelaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(501, 544);
            Controls.Add(btn_limpar);
            Controls.Add(lbl_resultado);
            Controls.Add(btn_calcular);
            Controls.Add(txt_valor3);
            Controls.Add(txt_valor2);
            Controls.Add(txt_valor1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sistema de Valor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_valor1;
        private TextBox txt_valor2;
        private TextBox txt_valor3;
        private Button btn_calcular;
        private Label lbl_resultado;
        private Button btn_limpar;
    }
}