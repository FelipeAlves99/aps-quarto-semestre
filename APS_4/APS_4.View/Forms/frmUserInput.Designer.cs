namespace APS_4.View.Forms
{
    partial class frmUserInput
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
            this.lblArrayCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAutoFill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArrayCount
            // 
            this.lblArrayCount.Location = new System.Drawing.Point(18, 11);
            this.lblArrayCount.Name = "lblArrayCount";
            this.lblArrayCount.Size = new System.Drawing.Size(225, 20);
            this.lblArrayCount.TabIndex = 0;
            this.lblArrayCount.Text = "0/0";
            this.lblArrayCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de entrada";
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(18, 63);
            this.txtUserInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(225, 21);
            this.txtUserInput.TabIndex = 2;
            // 
            // btnAddValue
            // 
            this.btnAddValue.Location = new System.Drawing.Point(134, 142);
            this.btnAddValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(87, 28);
            this.btnAddValue.TabIndex = 3;
            this.btnAddValue.Text = "Adicionar";
            this.btnAddValue.UseVisualStyleBackColor = true;
            this.btnAddValue.Click += new System.EventHandler(this.BtnAddValue_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(40, 142);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 28);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnAutoFill
            // 
            this.btnAutoFill.Location = new System.Drawing.Point(18, 92);
            this.btnAutoFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAutoFill.Name = "btnAutoFill";
            this.btnAutoFill.Size = new System.Drawing.Size(225, 28);
            this.btnAutoFill.TabIndex = 5;
            this.btnAutoFill.Text = "Preencher Automaticamente";
            this.btnAutoFill.UseVisualStyleBackColor = true;
            this.btnAutoFill.Click += new System.EventHandler(this.BtnAutoFill_Click);
            // 
            // frmUserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(261, 192);
            this.Controls.Add(this.btnAutoFill);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddValue);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblArrayCount);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmUserInput";
            this.ShowIcon = false;
            this.Text = "Entrada de dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArrayCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnAddValue;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAutoFill;
    }
}