namespace WindowsFormsApp3
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.name_comp = new System.Windows.Forms.ListBox();
            this.price_up = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Указать новую стоимость";
            // 
            // name_comp
            // 
            this.name_comp.FormattingEnabled = true;
            this.name_comp.Location = new System.Drawing.Point(71, 78);
            this.name_comp.Name = "name_comp";
            this.name_comp.Size = new System.Drawing.Size(397, 368);
            this.name_comp.TabIndex = 9;
            this.name_comp.SelectedIndexChanged += new System.EventHandler(this.name_comp_SelectedIndexChanged);
            // 
            // price_up
            // 
            this.price_up.Location = new System.Drawing.Point(627, 245);
            this.price_up.Name = "price_up";
            this.price_up.Size = new System.Drawing.Size(148, 20);
            this.price_up.TabIndex = 18;
            this.price_up.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 530);
            this.Controls.Add(this.price_up);
            this.Controls.Add(this.name_comp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Установка стоимости";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox name_comp;
        private System.Windows.Forms.TextBox price_up;
    }
}

