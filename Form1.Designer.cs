namespace ComputerPartsClientGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxRequest = new System.Windows.Forms.TextBox();
            this.listBoxResponses = new System.Windows.Forms.ListBox();
            this.SendRequestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRequest
            // 
            this.textBoxRequest.Location = new System.Drawing.Point(26, 45);
            this.textBoxRequest.Name = "textBoxRequest";
            this.textBoxRequest.Size = new System.Drawing.Size(200, 22);
            this.textBoxRequest.TabIndex = 1;
            // 
            // listBoxResponses
            // 
            this.listBoxResponses.FormattingEnabled = true;
            this.listBoxResponses.ItemHeight = 16;
            this.listBoxResponses.Location = new System.Drawing.Point(26, 114);
            this.listBoxResponses.Name = "listBoxResponses";
            this.listBoxResponses.Size = new System.Drawing.Size(400, 196);
            this.listBoxResponses.TabIndex = 0;
            // 
            // SendRequestButton
            // 
            this.SendRequestButton.Location = new System.Drawing.Point(250, 43);
            this.SendRequestButton.Name = "SendRequestButton";
            this.SendRequestButton.Size = new System.Drawing.Size(135, 24);
            this.SendRequestButton.TabIndex = 2;
            this.SendRequestButton.Text = "Отправить";
            this.SendRequestButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.SendRequestButton);
            this.Controls.Add(this.textBoxRequest);
            this.Controls.Add(this.listBoxResponses);
            this.Name = "MainForm";
            this.Text = "Клиент - Цены на запчасти";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxResponses;
        private System.Windows.Forms.TextBox textBoxRequest;
        private System.Windows.Forms.Button SendRequestButton;
    }
}

