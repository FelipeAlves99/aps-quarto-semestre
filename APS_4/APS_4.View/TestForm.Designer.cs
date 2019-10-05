namespace APS_4.View
{
    partial class TestForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBubble = new System.Windows.Forms.RadioButton();
            this.rbInsertion = new System.Windows.Forms.RadioButton();
            this.rbmerge = new System.Windows.Forms.RadioButton();
            this.rbQuick = new System.Windows.Forms.RadioButton();
            this.rbSelection = new System.Windows.Forms.RadioButton();
            this.rbShell = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEfetuar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMoves = new System.Windows.Forms.Label();
            this.btnArray = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbShell);
            this.groupBox1.Controls.Add(this.rbSelection);
            this.groupBox1.Controls.Add(this.rbQuick);
            this.groupBox1.Controls.Add(this.rbmerge);
            this.groupBox1.Controls.Add(this.rbInsertion);
            this.groupBox1.Controls.Add(this.rbBubble);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenações";
            // 
            // rbBubble
            // 
            this.rbBubble.AutoSize = true;
            this.rbBubble.Location = new System.Drawing.Point(7, 19);
            this.rbBubble.Name = "rbBubble";
            this.rbBubble.Size = new System.Drawing.Size(80, 17);
            this.rbBubble.TabIndex = 0;
            this.rbBubble.TabStop = true;
            this.rbBubble.Text = "Bubble Sort";
            this.rbBubble.UseVisualStyleBackColor = true;
            // 
            // rbInsertion
            // 
            this.rbInsertion.AutoSize = true;
            this.rbInsertion.Location = new System.Drawing.Point(7, 54);
            this.rbInsertion.Name = "rbInsertion";
            this.rbInsertion.Size = new System.Drawing.Size(87, 17);
            this.rbInsertion.TabIndex = 1;
            this.rbInsertion.TabStop = true;
            this.rbInsertion.Text = "Insertion Sort";
            this.rbInsertion.UseVisualStyleBackColor = true;
            // 
            // rbmerge
            // 
            this.rbmerge.AutoSize = true;
            this.rbmerge.Location = new System.Drawing.Point(7, 89);
            this.rbmerge.Name = "rbmerge";
            this.rbmerge.Size = new System.Drawing.Size(77, 17);
            this.rbmerge.TabIndex = 2;
            this.rbmerge.TabStop = true;
            this.rbmerge.Text = "Merge Sort";
            this.rbmerge.UseVisualStyleBackColor = true;
            // 
            // rbQuick
            // 
            this.rbQuick.AutoSize = true;
            this.rbQuick.Location = new System.Drawing.Point(147, 18);
            this.rbQuick.Name = "rbQuick";
            this.rbQuick.Size = new System.Drawing.Size(75, 17);
            this.rbQuick.TabIndex = 3;
            this.rbQuick.TabStop = true;
            this.rbQuick.Text = "Quick Sort";
            this.rbQuick.UseVisualStyleBackColor = true;
            // 
            // rbSelection
            // 
            this.rbSelection.AutoSize = true;
            this.rbSelection.Location = new System.Drawing.Point(147, 53);
            this.rbSelection.Name = "rbSelection";
            this.rbSelection.Size = new System.Drawing.Size(91, 17);
            this.rbSelection.TabIndex = 4;
            this.rbSelection.TabStop = true;
            this.rbSelection.Text = "Selection Sort";
            this.rbSelection.UseVisualStyleBackColor = true;
            // 
            // rbShell
            // 
            this.rbShell.AutoSize = true;
            this.rbShell.Location = new System.Drawing.Point(147, 88);
            this.rbShell.Name = "rbShell";
            this.rbShell.Size = new System.Drawing.Size(70, 17);
            this.rbShell.TabIndex = 5;
            this.rbShell.TabStop = true;
            this.rbShell.Text = "Shell Sort";
            this.rbShell.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnArray);
            this.groupBox2.Controls.Add(this.lblMoves);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // btnEfetuar
            // 
            this.btnEfetuar.Location = new System.Drawing.Point(12, 276);
            this.btnEfetuar.Name = "btnEfetuar";
            this.btnEfetuar.Size = new System.Drawing.Size(239, 23);
            this.btnEfetuar.TabIndex = 2;
            this.btnEfetuar.Text = "Efetuar Ordenação";
            this.btnEfetuar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(136, 40);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(32, 13);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Movimentos";
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.Location = new System.Drawing.Point(136, 87);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(32, 13);
            this.lblMoves.TabIndex = 3;
            this.lblMoves.Text = "result";
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(7, 27);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(91, 73);
            this.btnArray.TabIndex = 3;
            this.btnArray.Text = "Array Ordenado";
            this.btnArray.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 309);
            this.Controls.Add(this.btnEfetuar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TestForm";
            this.Text = "Tela de Teste";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbShell;
        private System.Windows.Forms.RadioButton rbSelection;
        private System.Windows.Forms.RadioButton rbQuick;
        private System.Windows.Forms.RadioButton rbmerge;
        private System.Windows.Forms.RadioButton rbInsertion;
        private System.Windows.Forms.RadioButton rbBubble;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEfetuar;
    }
}

