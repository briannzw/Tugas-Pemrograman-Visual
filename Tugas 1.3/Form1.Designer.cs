namespace Tugas_1._3
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
            this.btn_rock = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lb_dialog = new System.Windows.Forms.ListBox();
            this.btn_scissors = new System.Windows.Forms.Button();
            this.btn_paper = new System.Windows.Forms.Button();
            this.lbl_statusNum = new System.Windows.Forms.Label();
            this.lbl_totalMatch = new System.Windows.Forms.Label();
            this.lbl_winRate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_rock
            // 
            this.btn_rock.Location = new System.Drawing.Point(12, 368);
            this.btn_rock.Name = "btn_rock";
            this.btn_rock.Size = new System.Drawing.Size(182, 70);
            this.btn_rock.TabIndex = 0;
            this.btn_rock.Text = "Batu";
            this.btn_rock.UseVisualStyleBackColor = true;
            this.btn_rock.Click += new System.EventHandler(this.btn_rock_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Black;
            this.lbl_status.Location = new System.Drawing.Point(590, 368);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(198, 70);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "-";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_dialog
            // 
            this.lb_dialog.FormattingEnabled = true;
            this.lb_dialog.ItemHeight = 16;
            this.lb_dialog.Location = new System.Drawing.Point(12, 60);
            this.lb_dialog.Name = "lb_dialog";
            this.lb_dialog.Size = new System.Drawing.Size(776, 292);
            this.lb_dialog.TabIndex = 2;
            // 
            // btn_scissors
            // 
            this.btn_scissors.Location = new System.Drawing.Point(200, 368);
            this.btn_scissors.Name = "btn_scissors";
            this.btn_scissors.Size = new System.Drawing.Size(182, 70);
            this.btn_scissors.TabIndex = 3;
            this.btn_scissors.Text = "Gunting";
            this.btn_scissors.UseVisualStyleBackColor = true;
            this.btn_scissors.Click += new System.EventHandler(this.btn_scissors_Click);
            // 
            // btn_paper
            // 
            this.btn_paper.Location = new System.Drawing.Point(388, 368);
            this.btn_paper.Name = "btn_paper";
            this.btn_paper.Size = new System.Drawing.Size(182, 70);
            this.btn_paper.TabIndex = 4;
            this.btn_paper.Text = "Kertas";
            this.btn_paper.UseVisualStyleBackColor = true;
            this.btn_paper.Click += new System.EventHandler(this.btn_paper_Click);
            // 
            // lbl_statusNum
            // 
            this.lbl_statusNum.Location = new System.Drawing.Point(483, 9);
            this.lbl_statusNum.Name = "lbl_statusNum";
            this.lbl_statusNum.Size = new System.Drawing.Size(305, 32);
            this.lbl_statusNum.TabIndex = 5;
            this.lbl_statusNum.Text = "Menang : 0 | Seri : 0 | Kalah : 0";
            this.lbl_statusNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_totalMatch
            // 
            this.lbl_totalMatch.AutoSize = true;
            this.lbl_totalMatch.Location = new System.Drawing.Point(12, 17);
            this.lbl_totalMatch.Name = "lbl_totalMatch";
            this.lbl_totalMatch.Size = new System.Drawing.Size(122, 16);
            this.lbl_totalMatch.TabIndex = 6;
            this.lbl_totalMatch.Text = "Total Permainan : 0";
            // 
            // lbl_winRate
            // 
            this.lbl_winRate.Location = new System.Drawing.Point(15, 41);
            this.lbl_winRate.Name = "lbl_winRate";
            this.lbl_winRate.Size = new System.Drawing.Size(773, 16);
            this.lbl_winRate.TabIndex = 7;
            this.lbl_winRate.Text = "Win Rate : - %";
            this.lbl_winRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_winRate);
            this.Controls.Add(this.lbl_totalMatch);
            this.Controls.Add(this.lbl_statusNum);
            this.Controls.Add(this.btn_paper);
            this.Controls.Add(this.btn_scissors);
            this.Controls.Add(this.lb_dialog);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_rock);
            this.Name = "Form1";
            this.Text = "Batu Gunting Kertas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_rock;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ListBox lb_dialog;
        private System.Windows.Forms.Button btn_scissors;
        private System.Windows.Forms.Button btn_paper;
        private System.Windows.Forms.Label lbl_statusNum;
        private System.Windows.Forms.Label lbl_totalMatch;
        private System.Windows.Forms.Label lbl_winRate;
    }
}

