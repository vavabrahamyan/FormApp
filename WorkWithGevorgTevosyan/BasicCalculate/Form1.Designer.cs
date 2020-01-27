namespace BasicCalculate
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CEButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.PrcentButton = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eith = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minusOrPlus = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Location = new System.Drawing.Point(3, 3);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(253, 20);
            this.UserInputText.TabIndex = 2;
            this.UserInputText.Text = "write any";
            this.UserInputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonsPanel.Controls.Add(this.CButton, 1, 0);
            this.ButtonsPanel.Controls.Add(this.DelButton, 2, 0);
            this.ButtonsPanel.Controls.Add(this.PrcentButton, 3, 0);
            this.ButtonsPanel.Controls.Add(this.seven, 0, 1);
            this.ButtonsPanel.Controls.Add(this.eith, 1, 1);
            this.ButtonsPanel.Controls.Add(this.nine, 2, 1);
            this.ButtonsPanel.Controls.Add(this.multiply, 3, 1);
            this.ButtonsPanel.Controls.Add(this.four, 0, 2);
            this.ButtonsPanel.Controls.Add(this.five, 1, 2);
            this.ButtonsPanel.Controls.Add(this.six, 2, 2);
            this.ButtonsPanel.Controls.Add(this.minus, 3, 2);
            this.ButtonsPanel.Controls.Add(this.one, 0, 3);
            this.ButtonsPanel.Controls.Add(this.two, 1, 3);
            this.ButtonsPanel.Controls.Add(this.three, 2, 3);
            this.ButtonsPanel.Controls.Add(this.plus, 3, 3);
            this.ButtonsPanel.Controls.Add(this.minusOrPlus, 0, 4);
            this.ButtonsPanel.Controls.Add(this.zero, 1, 4);
            this.ButtonsPanel.Controls.Add(this.dot, 2, 4);
            this.ButtonsPanel.Controls.Add(this.Equals, 3, 4);
            this.ButtonsPanel.Location = new System.Drawing.Point(3, 61);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(253, 239);
            this.ButtonsPanel.TabIndex = 5;
            this.ButtonsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonsPanel_Paint);
            // 
            // CEButton
            // 
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(57, 41);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // CButton
            // 
            this.CButton.AutoSize = true;
            this.CButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CButton.Location = new System.Drawing.Point(66, 3);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(57, 41);
            this.CButton.TabIndex = 1;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            // 
            // DelButton
            // 
            this.DelButton.AutoSize = true;
            this.DelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelButton.Location = new System.Drawing.Point(129, 3);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(57, 41);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "Del";
            this.DelButton.UseVisualStyleBackColor = true;
            // 
            // PrcentButton
            // 
            this.PrcentButton.AutoSize = true;
            this.PrcentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrcentButton.Location = new System.Drawing.Point(192, 3);
            this.PrcentButton.Name = "PrcentButton";
            this.PrcentButton.Size = new System.Drawing.Size(58, 41);
            this.PrcentButton.TabIndex = 3;
            this.PrcentButton.Text = "%";
            this.PrcentButton.UseVisualStyleBackColor = true;
            // 
            // seven
            // 
            this.seven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seven.Location = new System.Drawing.Point(3, 50);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(57, 41);
            this.seven.TabIndex = 4;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            // 
            // eith
            // 
            this.eith.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eith.Location = new System.Drawing.Point(66, 50);
            this.eith.Name = "eith";
            this.eith.Size = new System.Drawing.Size(57, 41);
            this.eith.TabIndex = 5;
            this.eith.Text = "8";
            this.eith.UseVisualStyleBackColor = true;
            // 
            // nine
            // 
            this.nine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nine.Location = new System.Drawing.Point(129, 50);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(57, 41);
            this.nine.TabIndex = 6;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            this.multiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiply.Location = new System.Drawing.Point(192, 50);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(58, 41);
            this.multiply.TabIndex = 7;
            this.multiply.Text = "X";
            this.multiply.UseVisualStyleBackColor = true;
            // 
            // four
            // 
            this.four.Dock = System.Windows.Forms.DockStyle.Fill;
            this.four.Location = new System.Drawing.Point(3, 97);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(57, 41);
            this.four.TabIndex = 8;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            // 
            // five
            // 
            this.five.Dock = System.Windows.Forms.DockStyle.Fill;
            this.five.Location = new System.Drawing.Point(66, 97);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(57, 41);
            this.five.TabIndex = 9;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            // 
            // six
            // 
            this.six.Dock = System.Windows.Forms.DockStyle.Fill;
            this.six.Location = new System.Drawing.Point(129, 97);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(57, 41);
            this.six.TabIndex = 10;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            this.minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minus.Location = new System.Drawing.Point(192, 97);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(58, 41);
            this.minus.TabIndex = 11;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            // 
            // one
            // 
            this.one.Dock = System.Windows.Forms.DockStyle.Fill;
            this.one.Location = new System.Drawing.Point(3, 144);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(57, 41);
            this.one.TabIndex = 12;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            // 
            // two
            // 
            this.two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.two.Location = new System.Drawing.Point(66, 144);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(57, 41);
            this.two.TabIndex = 13;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            // 
            // three
            // 
            this.three.Dock = System.Windows.Forms.DockStyle.Fill;
            this.three.Location = new System.Drawing.Point(129, 144);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(57, 41);
            this.three.TabIndex = 14;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            // 
            // plus
            // 
            this.plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plus.Location = new System.Drawing.Point(192, 144);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(58, 41);
            this.plus.TabIndex = 15;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            // 
            // minusOrPlus
            // 
            this.minusOrPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minusOrPlus.Location = new System.Drawing.Point(3, 191);
            this.minusOrPlus.Name = "minusOrPlus";
            this.minusOrPlus.Size = new System.Drawing.Size(57, 45);
            this.minusOrPlus.TabIndex = 16;
            this.minusOrPlus.Text = "+/-";
            this.minusOrPlus.UseVisualStyleBackColor = true;
            // 
            // zero
            // 
            this.zero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zero.Location = new System.Drawing.Point(66, 191);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(57, 45);
            this.zero.TabIndex = 17;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            // 
            // dot
            // 
            this.dot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dot.Location = new System.Drawing.Point(129, 191);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(57, 45);
            this.dot.TabIndex = 18;
            this.dot.Text = ",";
            this.dot.UseVisualStyleBackColor = true;
            // 
            // Equals
            // 
            this.Equals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Equals.Location = new System.Drawing.Point(192, 191);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(58, 45);
            this.Equals.TabIndex = 19;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "press Enter for see result";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(259, 301);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.UserInputText);
            this.MinimumSize = new System.Drawing.Size(275, 340);
            this.Name = "Form1";
            this.Text = "Calculater";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button PrcentButton;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eith;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minusOrPlus;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Label label1;
    }
}

