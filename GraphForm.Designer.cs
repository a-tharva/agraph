namespace agraph
{
    partial class GraphForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.NodesInput = new System.Windows.Forms.TextBox();
            this.ConnectionInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw new";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NodesInput
            // 
            this.NodesInput.Location = new System.Drawing.Point(12, 213);
            this.NodesInput.Name = "NodesInput";
            this.NodesInput.PlaceholderText = "Node numbers";
            this.NodesInput.Size = new System.Drawing.Size(125, 27);
            this.NodesInput.TabIndex = 1;
            // 
            // ConnectionInput
            // 
            this.ConnectionInput.Location = new System.Drawing.Point(12, 180);
            this.ConnectionInput.Name = "ConnectionInput";
            this.ConnectionInput.PlaceholderText = "Connection number";
            this.ConnectionInput.Size = new System.Drawing.Size(125, 27);
            this.ConnectionInput.TabIndex = 2;
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 591);
            this.Controls.Add(this.ConnectionInput);
            this.Controls.Add(this.NodesInput);
            this.Controls.Add(this.button1);
            this.Name = "GraphForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox NodesInput;
        private TextBox ConnectionInput;
    }
}