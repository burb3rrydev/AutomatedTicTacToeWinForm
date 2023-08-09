namespace TicTacToe
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
            tlpGameBoard = new TableLayoutPanel();
            btn22 = new Button();
            btn21 = new Button();
            btn20 = new Button();
            btn12 = new Button();
            btn10 = new Button();
            btn02 = new Button();
            btn01 = new Button();
            btn00 = new Button();
            btn11 = new Button();
            btnNewGame = new Button();
            lblResults = new Label();
            tlpGameBoard.SuspendLayout();
            SuspendLayout();
            // 
            // tlpGameBoard
            // 
            tlpGameBoard.ColumnCount = 3;
            tlpGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpGameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpGameBoard.Controls.Add(btn22, 2, 2);
            tlpGameBoard.Controls.Add(btn21, 1, 2);
            tlpGameBoard.Controls.Add(btn20, 0, 2);
            tlpGameBoard.Controls.Add(btn12, 2, 1);
            tlpGameBoard.Controls.Add(btn10, 0, 1);
            tlpGameBoard.Controls.Add(btn02, 2, 0);
            tlpGameBoard.Controls.Add(btn01, 1, 0);
            tlpGameBoard.Controls.Add(btn00, 0, 0);
            tlpGameBoard.Controls.Add(btn11, 1, 1);
            tlpGameBoard.Location = new Point(53, 97);
            tlpGameBoard.Name = "tlpGameBoard";
            tlpGameBoard.RowCount = 3;
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpGameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpGameBoard.Size = new Size(433, 276);
            tlpGameBoard.TabIndex = 0;
            // 
            // btn22
            // 
            btn22.BackColor = SystemColors.MenuHighlight;
            btn22.FlatStyle = FlatStyle.Flat;
            btn22.Location = new Point(291, 187);
            btn22.Name = "btn22";
            btn22.Size = new Size(138, 86);
            btn22.TabIndex = 8;
            btn22.UseVisualStyleBackColor = false;
            // 
            // btn21
            // 
            btn21.BackColor = SystemColors.MenuHighlight;
            btn21.FlatStyle = FlatStyle.Flat;
            btn21.Location = new Point(147, 187);
            btn21.Name = "btn21";
            btn21.Size = new Size(138, 86);
            btn21.TabIndex = 7;
            btn21.UseVisualStyleBackColor = false;
            // 
            // btn20
            // 
            btn20.BackColor = SystemColors.MenuHighlight;
            btn20.FlatStyle = FlatStyle.Flat;
            btn20.Location = new Point(3, 187);
            btn20.Name = "btn20";
            btn20.Size = new Size(138, 86);
            btn20.TabIndex = 6;
            btn20.UseVisualStyleBackColor = false;
            // 
            // btn12
            // 
            btn12.BackColor = SystemColors.MenuHighlight;
            btn12.FlatStyle = FlatStyle.Flat;
            btn12.Location = new Point(291, 95);
            btn12.Name = "btn12";
            btn12.Size = new Size(138, 86);
            btn12.TabIndex = 5;
            btn12.UseVisualStyleBackColor = false;
            // 
            // btn10
            // 
            btn10.BackColor = SystemColors.MenuHighlight;
            btn10.FlatStyle = FlatStyle.Flat;
            btn10.Location = new Point(3, 95);
            btn10.Name = "btn10";
            btn10.Size = new Size(138, 86);
            btn10.TabIndex = 3;
            btn10.UseVisualStyleBackColor = false;
            // 
            // btn02
            // 
            btn02.BackColor = SystemColors.MenuHighlight;
            btn02.FlatStyle = FlatStyle.Flat;
            btn02.Location = new Point(291, 3);
            btn02.Name = "btn02";
            btn02.Size = new Size(138, 86);
            btn02.TabIndex = 2;
            btn02.UseVisualStyleBackColor = false;
            // 
            // btn01
            // 
            btn01.BackColor = SystemColors.MenuHighlight;
            btn01.FlatStyle = FlatStyle.Flat;
            btn01.Location = new Point(147, 3);
            btn01.Name = "btn01";
            btn01.Size = new Size(138, 86);
            btn01.TabIndex = 1;
            btn01.UseVisualStyleBackColor = false;
            // 
            // btn00
            // 
            btn00.BackColor = SystemColors.MenuHighlight;
            btn00.FlatStyle = FlatStyle.Flat;
            btn00.Location = new Point(3, 3);
            btn00.Name = "btn00";
            btn00.Size = new Size(138, 86);
            btn00.TabIndex = 0;
            btn00.UseVisualStyleBackColor = false;
            // 
            // btn11
            // 
            btn11.BackColor = SystemColors.MenuHighlight;
            btn11.FlatStyle = FlatStyle.Flat;
            btn11.Location = new Point(147, 95);
            btn11.Name = "btn11";
            btn11.Size = new Size(138, 86);
            btn11.TabIndex = 4;
            btn11.UseVisualStyleBackColor = false;
            // 
            // btnNewGame
            // 
            btnNewGame.BackColor = SystemColors.MenuHighlight;
            btnNewGame.FlatStyle = FlatStyle.Popup;
            btnNewGame.ForeColor = SystemColors.MenuText;
            btnNewGame.Location = new Point(213, 23);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(109, 43);
            btnNewGame.TabIndex = 1;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = false;
            btnNewGame.Click += btnNewGame_Click_1;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblResults.ForeColor = SystemColors.Window;
            lblResults.Location = new Point(200, 386);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(65, 28);
            lblResults.TabIndex = 2;
            lblResults.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(536, 432);
            Controls.Add(lblResults);
            Controls.Add(btnNewGame);
            Controls.Add(tlpGameBoard);
            Name = "Form1";
            Text = "Tic Tac Toe";
            Load += Form1_Load;
            tlpGameBoard.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlpGameBoard;
        private Button btn00;
        private Button btn21;
        private Button btn20;
        private Button btn12;
        private Button btn11;
        private Button btn10;
        private Button btn02;
        private Button btn01;
        private Button btn22;
        private Button btnNewGame;
        private Label lblResults;
    }
}