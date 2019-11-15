namespace APS_4.View.Forms
{
    partial class frmConfiguration
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
            this.gbEntryWays = new System.Windows.Forms.GroupBox();
            this.rbExternalFile = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbAutomatic = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.gbEntryWays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEntryWays
            // 
            this.gbEntryWays.Controls.Add(this.rbExternalFile);
            this.gbEntryWays.Controls.Add(this.rbManual);
            this.gbEntryWays.Controls.Add(this.rbAutomatic);
            this.gbEntryWays.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEntryWays.Location = new System.Drawing.Point(20, 16);
            this.gbEntryWays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbEntryWays.Name = "gbEntryWays";
            this.gbEntryWays.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbEntryWays.Size = new System.Drawing.Size(198, 187);
            this.gbEntryWays.TabIndex = 0;
            this.gbEntryWays.TabStop = false;
            this.gbEntryWays.Text = "Tipo de entrada de dados";
            // 
            // rbExternalFile
            // 
            this.rbExternalFile.AutoSize = true;
            this.rbExternalFile.Location = new System.Drawing.Point(44, 126);
            this.rbExternalFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbExternalFile.Name = "rbExternalFile";
            this.rbExternalFile.Size = new System.Drawing.Size(111, 20);
            this.rbExternalFile.TabIndex = 2;
            this.rbExternalFile.Text = "Arquivo Externo";
            this.rbExternalFile.UseVisualStyleBackColor = true;
            this.rbExternalFile.CheckedChanged += new System.EventHandler(this.RbExternalFile_CheckedChanged);
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(44, 83);
            this.rbManual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(69, 20);
            this.rbManual.TabIndex = 1;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.RbManual_CheckedChanged);
            // 
            // rbAutomatic
            // 
            this.rbAutomatic.AutoSize = true;
            this.rbAutomatic.Checked = true;
            this.rbAutomatic.Location = new System.Drawing.Point(44, 40);
            this.rbAutomatic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbAutomatic.Name = "rbAutomatic";
            this.rbAutomatic.Size = new System.Drawing.Size(89, 20);
            this.rbAutomatic.TabIndex = 0;
            this.rbAutomatic.TabStop = true;
            this.rbAutomatic.Text = "Automático";
            this.rbAutomatic.UseVisualStyleBackColor = true;
            this.rbAutomatic.CheckedChanged += new System.EventHandler(this.RbAutomatic_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(123, 326);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 31);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Criar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(28, 329);
            this.btnClean.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(87, 28);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Fechar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantidade de dados";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.Location = new System.Drawing.Point(12, 266);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(47, 13);
            this.lblFile.TabIndex = 3;
            this.lblFile.Text = "Arquivo: ";
            this.lblFile.Visible = false;
            // 
            // lblFileName
            // 
            this.lblFileName.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(12, 279);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(214, 43);
            this.lblFileName.TabIndex = 4;
            this.lblFileName.Text = "Nome";
            this.lblFileName.Visible = false;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(20, 232);
            this.nudQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(198, 21);
            this.nudQuantity.TabIndex = 5;
            this.nudQuantity.ThousandsSeparator = true;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // frmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(238, 368);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbEntryWays);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmConfiguration";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConfiguration_FormClosed);
            this.gbEntryWays.ResumeLayout(false);
            this.gbEntryWays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEntryWays;
        private System.Windows.Forms.RadioButton rbExternalFile;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAutomatic;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.NumericUpDown nudQuantity;
    }
}