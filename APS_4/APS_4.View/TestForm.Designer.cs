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
            this.gbOrdering = new System.Windows.Forms.GroupBox();
            this.rbShell = new System.Windows.Forms.RadioButton();
            this.rbSelection = new System.Windows.Forms.RadioButton();
            this.rbQuick = new System.Windows.Forms.RadioButton();
            this.rbMerge = new System.Windows.Forms.RadioButton();
            this.rbInsertion = new System.Windows.Forms.RadioButton();
            this.rbBubble = new System.Windows.Forms.RadioButton();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.btnArray = new System.Windows.Forms.Button();
            this.lblMoves = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEfetuar = new System.Windows.Forms.Button();
            this.gbOrdering.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOrdering
            // 
            this.gbOrdering.Controls.Add(this.rbShell);
            this.gbOrdering.Controls.Add(this.rbSelection);
            this.gbOrdering.Controls.Add(this.rbQuick);
            this.gbOrdering.Controls.Add(this.rbMerge);
            this.gbOrdering.Controls.Add(this.rbInsertion);
            this.gbOrdering.Controls.Add(this.rbBubble);
            this.gbOrdering.Location = new System.Drawing.Point(12, 12);
            this.gbOrdering.Name = "gbOrdering";
            this.gbOrdering.Size = new System.Drawing.Size(247, 124);
            this.gbOrdering.TabIndex = 0;
            this.gbOrdering.TabStop = false;
            this.gbOrdering.Text = "Ordenações";
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
            // rbMerge
            // 
            this.rbMerge.AutoSize = true;
            this.rbMerge.Location = new System.Drawing.Point(7, 89);
            this.rbMerge.Name = "rbMerge";
            this.rbMerge.Size = new System.Drawing.Size(77, 17);
            this.rbMerge.TabIndex = 2;
            this.rbMerge.TabStop = true;
            this.rbMerge.Text = "Merge Sort";
            this.rbMerge.UseVisualStyleBackColor = true;
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
            // gbResult
            // 
            this.gbResult.Controls.Add(this.btnArray);
            this.gbResult.Controls.Add(this.lblMoves);
            this.gbResult.Controls.Add(this.label3);
            this.gbResult.Controls.Add(this.lblTime);
            this.gbResult.Controls.Add(this.label1);
            this.gbResult.Location = new System.Drawing.Point(12, 143);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(247, 127);
            this.gbResult.TabIndex = 1;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Resultado";
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(7, 27);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(91, 73);
            this.btnArray.TabIndex = 3;
            this.btnArray.Text = "Array Ordenado";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.BtnArray_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Movimentos";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo";
            // 
            // btnEfetuar
            // 
            this.btnEfetuar.Location = new System.Drawing.Point(12, 276);
            this.btnEfetuar.Name = "btnEfetuar";
            this.btnEfetuar.Size = new System.Drawing.Size(247, 23);
            this.btnEfetuar.TabIndex = 2;
            this.btnEfetuar.Text = "Efetuar Ordenação";
            this.btnEfetuar.UseVisualStyleBackColor = true;
            this.btnEfetuar.Click += new System.EventHandler(this.BtnEfetuar_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 309);
            this.Controls.Add(this.btnEfetuar);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbOrdering);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Teste";
            this.gbOrdering.ResumeLayout(false);
            this.gbOrdering.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrdering;
        private System.Windows.Forms.RadioButton rbShell;
        private System.Windows.Forms.RadioButton rbSelection;
        private System.Windows.Forms.RadioButton rbQuick;
        private System.Windows.Forms.RadioButton rbMerge;
        private System.Windows.Forms.RadioButton rbInsertion;
        private System.Windows.Forms.RadioButton rbBubble;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEfetuar;
    }
}

