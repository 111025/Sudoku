﻿namespace Sudoku
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainGamePanel = new System.Windows.Forms.Panel();
            this.btnMainGameBack = new System.Windows.Forms.Button();
            this.startPanel = new System.Windows.Forms.Panel();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioHardMode = new System.Windows.Forms.RadioButton();
            this.radioMediumMode = new System.Windows.Forms.RadioButton();
            this.radioEasyMode = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioSquigglyMode = new System.Windows.Forms.RadioButton();
            this.radioStandardMode = new System.Windows.Forms.RadioButton();
            this.btnToLoadGame = new System.Windows.Forms.Button();
            this.btnScores = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.highScorePanel = new System.Windows.Forms.Panel();
            this.btnMainMenuBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mainGamePanel.SuspendLayout();
            this.startPanel.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.highScorePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(49, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(230, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellLeave);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // mainGamePanel
            // 
            this.mainGamePanel.Controls.Add(this.btnMainGameBack);
            this.mainGamePanel.Controls.Add(this.dataGridView1);
            this.mainGamePanel.Location = new System.Drawing.Point(12, 12);
            this.mainGamePanel.Name = "mainGamePanel";
            this.mainGamePanel.Size = new System.Drawing.Size(327, 286);
            this.mainGamePanel.TabIndex = 1;
            this.mainGamePanel.Visible = false;
            // 
            // btnMainGameBack
            // 
            this.btnMainGameBack.Location = new System.Drawing.Point(6, 259);
            this.btnMainGameBack.Name = "btnMainGameBack";
            this.btnMainGameBack.Size = new System.Drawing.Size(75, 23);
            this.btnMainGameBack.TabIndex = 1;
            this.btnMainGameBack.Text = "<< Back";
            this.btnMainGameBack.UseVisualStyleBackColor = true;
            this.btnMainGameBack.Click += new System.EventHandler(this.btnMainGameBack_Click);
            // 
            // startPanel
            // 
            this.startPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.startPanel.Controls.Add(this.panelOptions);
            this.startPanel.Controls.Add(this.btnToLoadGame);
            this.startPanel.Controls.Add(this.btnScores);
            this.startPanel.Controls.Add(this.btnNewGame);
            this.startPanel.Controls.Add(this.panel1);
            this.startPanel.Location = new System.Drawing.Point(12, 12);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(327, 286);
            this.startPanel.TabIndex = 2;
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.groupBox3);
            this.panelOptions.Controls.Add(this.groupBox2);
            this.panelOptions.Location = new System.Drawing.Point(158, 147);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(169, 137);
            this.panelOptions.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioHardMode);
            this.groupBox3.Controls.Add(this.radioMediumMode);
            this.groupBox3.Controls.Add(this.radioEasyMode);
            this.groupBox3.Location = new System.Drawing.Point(8, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 87);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Difficulty";
            // 
            // radioHardMode
            // 
            this.radioHardMode.AutoSize = true;
            this.radioHardMode.Location = new System.Drawing.Point(14, 63);
            this.radioHardMode.Name = "radioHardMode";
            this.radioHardMode.Size = new System.Drawing.Size(48, 17);
            this.radioHardMode.TabIndex = 2;
            this.radioHardMode.TabStop = true;
            this.radioHardMode.Text = "Hard";
            this.radioHardMode.UseVisualStyleBackColor = true;
            // 
            // radioMediumMode
            // 
            this.radioMediumMode.AutoSize = true;
            this.radioMediumMode.Location = new System.Drawing.Point(14, 40);
            this.radioMediumMode.Name = "radioMediumMode";
            this.radioMediumMode.Size = new System.Drawing.Size(62, 17);
            this.radioMediumMode.TabIndex = 1;
            this.radioMediumMode.TabStop = true;
            this.radioMediumMode.Text = "Medium";
            this.radioMediumMode.UseVisualStyleBackColor = true;
            // 
            // radioEasyMode
            // 
            this.radioEasyMode.AutoSize = true;
            this.radioEasyMode.Checked = true;
            this.radioEasyMode.Location = new System.Drawing.Point(14, 17);
            this.radioEasyMode.Name = "radioEasyMode";
            this.radioEasyMode.Size = new System.Drawing.Size(48, 17);
            this.radioEasyMode.TabIndex = 0;
            this.radioEasyMode.TabStop = true;
            this.radioEasyMode.Text = "Easy";
            this.radioEasyMode.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioSquigglyMode);
            this.groupBox2.Controls.Add(this.radioStandardMode);
            this.groupBox2.Location = new System.Drawing.Point(8, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 40);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode";
            // 
            // radioSquigglyMode
            // 
            this.radioSquigglyMode.AutoSize = true;
            this.radioSquigglyMode.Location = new System.Drawing.Point(79, 15);
            this.radioSquigglyMode.Name = "radioSquigglyMode";
            this.radioSquigglyMode.Size = new System.Drawing.Size(65, 17);
            this.radioSquigglyMode.TabIndex = 1;
            this.radioSquigglyMode.Text = "Squiggly";
            this.radioSquigglyMode.UseVisualStyleBackColor = true;
            // 
            // radioStandardMode
            // 
            this.radioStandardMode.AutoSize = true;
            this.radioStandardMode.Checked = true;
            this.radioStandardMode.Location = new System.Drawing.Point(14, 15);
            this.radioStandardMode.Name = "radioStandardMode";
            this.radioStandardMode.Size = new System.Drawing.Size(68, 17);
            this.radioStandardMode.TabIndex = 0;
            this.radioStandardMode.TabStop = true;
            this.radioStandardMode.Text = "Standard";
            this.radioStandardMode.UseVisualStyleBackColor = true;
            // 
            // btnToLoadGame
            // 
            this.btnToLoadGame.Location = new System.Drawing.Point(6, 208);
            this.btnToLoadGame.Name = "btnToLoadGame";
            this.btnToLoadGame.Size = new System.Drawing.Size(128, 32);
            this.btnToLoadGame.TabIndex = 2;
            this.btnToLoadGame.Text = "Load Game";
            this.btnToLoadGame.UseVisualStyleBackColor = true;
            // 
            // btnScores
            // 
            this.btnScores.Location = new System.Drawing.Point(6, 248);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(128, 32);
            this.btnScores.TabIndex = 1;
            this.btnScores.Text = "High Scores";
            this.btnScores.UseVisualStyleBackColor = true;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(6, 149);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(128, 51);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = " New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Sudoku.Properties.Resources.SudokuLogo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 143);
            this.panel1.TabIndex = 5;
            // 
            // highScorePanel
            // 
            this.highScorePanel.Controls.Add(this.btnMainMenuBack);
            this.highScorePanel.Controls.Add(this.groupBox1);
            this.highScorePanel.Location = new System.Drawing.Point(12, 12);
            this.highScorePanel.Name = "highScorePanel";
            this.highScorePanel.Size = new System.Drawing.Size(327, 286);
            this.highScorePanel.TabIndex = 3;
            this.highScorePanel.TabStop = true;
            this.highScorePanel.Visible = false;
            // 
            // btnMainMenuBack
            // 
            this.btnMainMenuBack.Location = new System.Drawing.Point(6, 260);
            this.btnMainMenuBack.Name = "btnMainMenuBack";
            this.btnMainMenuBack.Size = new System.Drawing.Size(75, 23);
            this.btnMainMenuBack.TabIndex = 1;
            this.btnMainMenuBack.Text = "<< Back";
            this.btnMainMenuBack.UseVisualStyleBackColor = true;
            this.btnMainMenuBack.Click += new System.EventHandler(this.btnMainMenuBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rank List";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 134);
            this.listBox1.TabIndex = 0;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Column1";
            this.Column1.MaxInputLength = 1;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 25;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Column2";
            this.Column2.MaxInputLength = 1;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 25;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Column3";
            this.Column3.MaxInputLength = 1;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 25;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Column4";
            this.Column4.MaxInputLength = 1;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 25;
            // 
            // Column5
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "Column5";
            this.Column5.MaxInputLength = 1;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 25;
            // 
            // Column6
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Column6.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column6.HeaderText = "Column6";
            this.Column6.MaxInputLength = 1;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 25;
            // 
            // Column7
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Column7.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column7.HeaderText = "Column7";
            this.Column7.MaxInputLength = 1;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 25;
            // 
            // Column8
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Column8.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column8.HeaderText = "Column8";
            this.Column8.MaxInputLength = 1;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 25;
            // 
            // Column9
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Column9.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column9.HeaderText = "Column9";
            this.Column9.MaxInputLength = 1;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 310);
            this.Controls.Add(this.mainGamePanel);
            this.Controls.Add(this.startPanel);
            this.Controls.Add(this.highScorePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mainGamePanel.ResumeLayout(false);
            this.startPanel.ResumeLayout(false);
            this.panelOptions.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.highScorePanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel mainGamePanel;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Panel highScorePanel;
        private System.Windows.Forms.Button btnMainMenuBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnMainGameBack;
        private System.Windows.Forms.Button btnToLoadGame;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioSquigglyMode;
        private System.Windows.Forms.RadioButton radioStandardMode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioHardMode;
        private System.Windows.Forms.RadioButton radioMediumMode;
        private System.Windows.Forms.RadioButton radioEasyMode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;

    }
}

