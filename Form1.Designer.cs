using System.Windows.Forms;

namespace _1._9Calculator
{
    partial class FoeCalculator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoeCalculator));
            this.maxPR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentPR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prBack = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currentOnPlace = new System.Windows.Forms.TextBox();
            this.getResult = new System.Windows.Forms.Button();
            this.resultDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // maxPR
            // 
            this.maxPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.maxPR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maxPR.ForeColor = System.Drawing.Color.Orange;
            this.maxPR.Location = new System.Drawing.Point(221, 84);
            this.maxPR.Multiline = true;
            this.maxPR.Name = "maxPR";
            this.maxPR.Size = new System.Drawing.Size(108, 40);
            this.maxPR.TabIndex = 1;
            this.maxPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxPR.Click += new System.EventHandler(this.txtBoxClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Maksymalna ilość PR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ilość zajętych PR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentPR
            // 
            this.currentPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.currentPR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentPR.ForeColor = System.Drawing.Color.Orange;
            this.currentPR.Location = new System.Drawing.Point(221, 137);
            this.currentPR.Multiline = true;
            this.currentPR.Name = "currentPR";
            this.currentPR.Size = new System.Drawing.Size(108, 40);
            this.currentPR.TabIndex = 4;
            this.currentPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentPR.Click += new System.EventHandler(this.txtBoxClick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zwrot PR za dane miejsce";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prBack
            // 
            this.prBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.prBack.ForeColor = System.Drawing.Color.Orange;
            this.prBack.Location = new System.Drawing.Point(221, 190);
            this.prBack.Multiline = true;
            this.prBack.Name = "prBack";
            this.prBack.Size = new System.Drawing.Size(108, 40);
            this.prBack.TabIndex = 6;
            this.prBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prBack.Click += new System.EventHandler(this.txtBoxClick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(12, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "Obecna ilość PR na danym miejscu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentOnPlace
            // 
            this.currentOnPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.currentOnPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentOnPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentOnPlace.ForeColor = System.Drawing.Color.Orange;
            this.currentOnPlace.Location = new System.Drawing.Point(221, 243);
            this.currentOnPlace.Multiline = true;
            this.currentOnPlace.Name = "currentOnPlace";
            this.currentOnPlace.Size = new System.Drawing.Size(108, 40);
            this.currentOnPlace.TabIndex = 8;
            this.currentOnPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentOnPlace.Click += new System.EventHandler(this.txtBoxClick);
            // 
            // getResult
            // 
            this.getResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("getResult.BackgroundImage")));
            this.getResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.getResult.ForeColor = System.Drawing.Color.Orange;
            this.getResult.Location = new System.Drawing.Point(124, 298);
            this.getResult.Name = "getResult";
            this.getResult.Size = new System.Drawing.Size(100, 44);
            this.getResult.TabIndex = 9;
            this.getResult.Text = "Oblicz";
            this.getResult.UseVisualStyleBackColor = true;
            this.getResult.Click += new System.EventHandler(this.getResult_Click);
            // 
            // resultDisplay
            // 
            this.resultDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resultDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.resultDisplay.ForeColor = System.Drawing.Color.Orange;
            this.resultDisplay.Location = new System.Drawing.Point(12, 12);
            this.resultDisplay.Multiline = true;
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.ReadOnly = true;
            this.resultDisplay.Size = new System.Drawing.Size(317, 60);
            this.resultDisplay.TabIndex = 0;
            this.resultDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FoeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(353, 357);
            this.Controls.Add(this.getResult);
            this.Controls.Add(this.currentOnPlace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentPR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxPR);
            this.Controls.Add(this.resultDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FoeCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1.9 Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox maxPR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currentPR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox currentOnPlace;
        private System.Windows.Forms.Button getResult;
        private TextBox resultDisplay;
    }
}

