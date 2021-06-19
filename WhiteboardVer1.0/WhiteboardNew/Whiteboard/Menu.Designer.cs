
namespace Whiteboard
{
    partial class Menu
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
            this.name = new System.Windows.Forms.Label();
            this.join = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.Font = new System.Drawing.Font("UTM Helve", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(189, 162);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(203, 41);
            this.name.TabIndex = 0;
            this.name.Text = "wHiTeBoArD";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // join
            // 
            this.join.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.join.AutoSize = true;
            this.join.BackColor = System.Drawing.Color.White;
            this.join.Cursor = System.Windows.Forms.Cursors.Default;
            this.join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.join.Font = new System.Drawing.Font("UTM Helve", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.join.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.join.Location = new System.Drawing.Point(229, 242);
            this.join.Name = "join";
            this.join.Size = new System.Drawing.Size(123, 46);
            this.join.TabIndex = 1;
            this.join.Text = "JOIN";
            this.join.UseVisualStyleBackColor = false;
            this.join.Click += new System.EventHandler(this.join_Click);
            // 
            // create
            // 
            this.create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create.AutoSize = true;
            this.create.BackColor = System.Drawing.Color.White;
            this.create.Cursor = System.Windows.Forms.Cursors.Default;
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Font = new System.Drawing.Font("UTM Helve", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.create.Location = new System.Drawing.Point(229, 302);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(123, 47);
            this.create.TabIndex = 2;
            this.create.Text = "CREATE";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // quit
            // 
            this.quit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quit.AutoSize = true;
            this.quit.BackColor = System.Drawing.Color.White;
            this.quit.Cursor = System.Windows.Forms.Cursors.Default;
            this.quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit.Font = new System.Drawing.Font("UTM Helve", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.quit.Location = new System.Drawing.Point(229, 362);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(123, 45);
            this.quit.TabIndex = 3;
            this.quit.Text = "QUIT";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("UTM Helve", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(189, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "54010N";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.create);
            this.Controls.Add(this.join);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button join;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label label1;
    }
}

