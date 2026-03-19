namespace EchoMessenger
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
            label1 = new Label();
            logBox = new ListBox();
            textLine = new TextBox();
            enterButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 129);
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(259, 45);
            label1.TabIndex = 0;
            label1.Text = "EchoMessenger";
            // 
            // logBox
            // 
            logBox.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            logBox.FormattingEnabled = true;
            logBox.Location = new Point(21, 77);
            logBox.Name = "logBox";
            logBox.Size = new Size(751, 229);
            logBox.TabIndex = 1;
            // 
            // textLine
            // 
            textLine.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            textLine.Location = new Point(21, 345);
            textLine.Name = "textLine";
            textLine.Size = new Size(616, 33);
            textLine.TabIndex = 2;
            // 
            // enterButton
            // 
            enterButton.BackColor = SystemColors.GradientInactiveCaption;
            enterButton.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            enterButton.Location = new Point(667, 333);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(105, 50);
            enterButton.TabIndex = 3;
            enterButton.Text = "전송";
            enterButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(enterButton);
            Controls.Add(textLine);
            Controls.Add(logBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox logBox;
        private TextBox textLine;
        private Button enterButton;
    }
}
