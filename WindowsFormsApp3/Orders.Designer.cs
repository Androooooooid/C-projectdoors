namespace WindowsFormsApp3
{
    partial class Orders
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
            this.ComponentList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ComponentList
            // 
            this.ComponentList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.ComponentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComponentList.FullRowSelect = true;
            this.ComponentList.GridLines = true;
            this.ComponentList.Location = new System.Drawing.Point(29, 41);
            this.ComponentList.Name = "ComponentList";
            this.ComponentList.Size = new System.Drawing.Size(1065, 452);
            this.ComponentList.TabIndex = 20;
            this.ComponentList.UseCompatibleStateImageBehavior = false;
            this.ComponentList.View = System.Windows.Forms.View.Details;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 537);
            this.Controls.Add(this.ComponentList);
            this.Name = "Orders";
            this.Text = "Orders";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ComponentList;
    }
}