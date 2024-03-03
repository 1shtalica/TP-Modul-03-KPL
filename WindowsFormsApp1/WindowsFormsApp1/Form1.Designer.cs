namespace TP_MOD_3_1302223110_Adib_Faizulhaq_Armadhani
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Submit1 = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit1
            // 
            this.Submit1.BackColor = System.Drawing.Color.Maroon;
            this.Submit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Submit1.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.Submit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Submit1.ForeColor = System.Drawing.Color.FloralWhite;
            this.Submit1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Submit1.Location = new System.Drawing.Point(462, 18);
            this.Submit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Submit1.Name = "Submit1";
            this.Submit1.Size = new System.Drawing.Size(186, 50);
            this.Submit1.TabIndex = 0;
            this.Submit1.Text = "Submit";
            this.Submit1.UseVisualStyleBackColor = false;
            this.Submit1.Click += new System.EventHandler(this.Submit1_Click);
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.Maroon;
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Input.Location = new System.Drawing.Point(42, 18);
            this.Input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(416, 50);
            this.Input.TabIndex = 1;
            this.Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.Maroon;
            this.Output.Location = new System.Drawing.Point(42, 89);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(606, 42);
            this.Output.TabIndex = 3;
            this.Output.Text = "Output";
            this.Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(721, 192);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Submit1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.Button Submit1;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Output;


    }
}

