namespace RunAs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Command = new System.Windows.Forms.TextBox();
            this.Run = new System.Windows.Forms.Button();
            this.RunAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Command
            // 
            this.Command.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Command.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.Command.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Command.ForeColor = System.Drawing.Color.Black;
            this.Command.Location = new System.Drawing.Point(12, 37);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(553, 30);
            this.Command.TabIndex = 0;
            // 
            // Run
            // 
            this.Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Run.Location = new System.Drawing.Point(12, 73);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 37);
            this.Run.TabIndex = 1;
            this.Run.Text = "&Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // RunAdmin
            // 
            this.RunAdmin.FlatAppearance.BorderSize = 0;
            this.RunAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunAdmin.Location = new System.Drawing.Point(423, 73);
            this.RunAdmin.Name = "RunAdmin";
            this.RunAdmin.Size = new System.Drawing.Size(142, 37);
            this.RunAdmin.TabIndex = 2;
            this.RunAdmin.Text = "Run as &Admin";
            this.RunAdmin.UseVisualStyleBackColor = true;
            this.RunAdmin.Click += new System.EventHandler(this.RunAdmin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 141);
            this.Controls.Add(this.RunAdmin);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.Command);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(595, 188);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(595, 188);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "RunAs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Command;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button RunAdmin;
    }
}

