﻿namespace Avatar_Explorer.Forms
{
    sealed partial class AddItem
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
            FolderTextBox = new TextBox();
            BoothURLTextBox = new TextBox();
            GetButton = new Button();
            label4 = new Label();
            TypeComboBox = new ComboBox();
            label5 = new Label();
            SelectAvatar = new Button();
            AuthorTextBox = new TextBox();
            TitleTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ErrorLabel = new Label();
            AddButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans JP", 12F);
            label1.Location = new Point(41, 64);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 0;
            label1.Text = "フォルダ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Noto Sans JP", 12F);
            label2.Location = new Point(22, 109);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 1;
            label2.Text = "Booth URL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans JP", 20F);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(174, 37);
            label3.TabIndex = 2;
            label3.Text = "アイテムの追加";
            // 
            // FolderTextBox
            // 
            FolderTextBox.AllowDrop = true;
            FolderTextBox.Font = new Font("Noto Sans JP", 12F);
            FolderTextBox.Location = new Point(124, 61);
            FolderTextBox.Name = "FolderTextBox";
            FolderTextBox.Size = new Size(407, 29);
            FolderTextBox.TabIndex = 3;
            FolderTextBox.DragDrop += FolderTextBox_DragDrop;
            FolderTextBox.DragEnter += FolderTextBox_DragEnter;
            // 
            // BoothURLTextBox
            // 
            BoothURLTextBox.Font = new Font("Noto Sans JP", 12F);
            BoothURLTextBox.Location = new Point(124, 101);
            BoothURLTextBox.Name = "BoothURLTextBox";
            BoothURLTextBox.Size = new Size(407, 29);
            BoothURLTextBox.TabIndex = 4;
            // 
            // GetButton
            // 
            GetButton.Location = new Point(409, 314);
            GetButton.Name = "GetButton";
            GetButton.Size = new Size(122, 36);
            GetButton.TabIndex = 5;
            GetButton.Text = "情報を取得";
            GetButton.UseVisualStyleBackColor = true;
            GetButton.Click += GetButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Noto Sans JP", 12F);
            label4.Location = new Point(61, 274);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 7;
            label4.Text = "タイプ";
            // 
            // TypeComboBox
            // 
            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "アバター", "衣装", "テクスチャ", "ギミック", "アクセサリー", "髪型", "アニメーション", "ツール", "シェーダー" });
            TypeComboBox.Location = new Point(129, 276);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(186, 23);
            TypeComboBox.TabIndex = 8;
            TypeComboBox.SelectedIndexChanged += TypeComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Noto Sans JP", 12F);
            label5.Location = new Point(17, 319);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 9;
            label5.Text = "対応アバター";
            // 
            // SelectAvatar
            // 
            SelectAvatar.Location = new Point(129, 312);
            SelectAvatar.Name = "SelectAvatar";
            SelectAvatar.Size = new Size(140, 38);
            SelectAvatar.TabIndex = 10;
            SelectAvatar.Text = "選択";
            SelectAvatar.UseVisualStyleBackColor = true;
            SelectAvatar.Click += SelectAvatar_Click;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Enabled = false;
            AuthorTextBox.Font = new Font("Noto Sans JP", 10F);
            AuthorTextBox.Location = new Point(129, 235);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(407, 25);
            AuthorTextBox.TabIndex = 14;
            AuthorTextBox.Text = "作者未取得";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Enabled = false;
            TitleTextBox.Font = new Font("Noto Sans JP", 10F);
            TitleTextBox.Location = new Point(129, 199);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(407, 25);
            TitleTextBox.TabIndex = 13;
            TitleTextBox.Text = "タイトル未取得";
            TitleTextBox.TextChanged += TitleTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Noto Sans JP", 12F);
            label6.Location = new Point(64, 235);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 12;
            label6.Text = "作者";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Noto Sans JP", 12F);
            label7.Location = new Point(49, 203);
            label7.Name = "label7";
            label7.Size = new Size(57, 21);
            label7.TabIndex = 11;
            label7.Text = "タイトル";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Noto Sans JP", 18F);
            label8.Location = new Point(22, 154);
            label8.Name = "label8";
            label8.Size = new Size(206, 32);
            label8.TabIndex = 15;
            label8.Text = "Booth アイテム情報";
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Noto Sans JP", 13F);
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(17, 369);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 25);
            ErrorLabel.TabIndex = 16;
            ErrorLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // AddButton
            // 
            AddButton.Enabled = false;
            AddButton.Location = new Point(409, 366);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(122, 36);
            AddButton.TabIndex = 17;
            AddButton.Text = "追加";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 414);
            Controls.Add(AddButton);
            Controls.Add(ErrorLabel);
            Controls.Add(label8);
            Controls.Add(AuthorTextBox);
            Controls.Add(TitleTextBox);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(SelectAvatar);
            Controls.Add(label5);
            Controls.Add(TypeComboBox);
            Controls.Add(label4);
            Controls.Add(GetButton);
            Controls.Add(BoothURLTextBox);
            Controls.Add(FolderTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox FolderTextBox;
        private TextBox BoothURLTextBox;
        private Button GetButton;
        private Label label4;
        private ComboBox TypeComboBox;
        private Label label5;
        private Button SelectAvatar;
        private TextBox AuthorTextBox;
        private TextBox TitleTextBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label ErrorLabel;
        private Button AddButton;
    }
}