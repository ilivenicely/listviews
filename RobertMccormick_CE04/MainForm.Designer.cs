namespace WinformTutorial
{
    partial class MainForm
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
            this.btnOpenInputForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalInputForm = new System.Windows.Forms.Label();
            this.btnOpenListForm = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.lblTotalItem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenInputForm
            // 
            this.btnOpenInputForm.Location = new System.Drawing.Point(23, 33);
            this.btnOpenInputForm.Name = "btnOpenInputForm";
            this.btnOpenInputForm.Size = new System.Drawing.Size(195, 23);
            this.btnOpenInputForm.TabIndex = 0;
            this.btnOpenInputForm.Text = "Open new Input form";
            this.btnOpenInputForm.UseVisualStyleBackColor = true;
            this.btnOpenInputForm.Click += new System.EventHandler(this.btnOpenInputForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Input form:";
            // 
            // lblTotalInputForm
            // 
            this.lblTotalInputForm.AutoSize = true;
            this.lblTotalInputForm.Location = new System.Drawing.Point(337, 38);
            this.lblTotalInputForm.Name = "lblTotalInputForm";
            this.lblTotalInputForm.Size = new System.Drawing.Size(13, 13);
            this.lblTotalInputForm.TabIndex = 2;
            this.lblTotalInputForm.Text = "0";
            // 
            // btnOpenListForm
            // 
            this.btnOpenListForm.Location = new System.Drawing.Point(23, 62);
            this.btnOpenListForm.Name = "btnOpenListForm";
            this.btnOpenListForm.Size = new System.Drawing.Size(195, 23);
            this.btnOpenListForm.TabIndex = 3;
            this.btnOpenListForm.Text = "Open List Form";
            this.btnOpenListForm.UseVisualStyleBackColor = true;
            this.btnOpenListForm.Click += new System.EventHandler(this.btnOpenListForm_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(23, 91);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(195, 23);
            this.btnClearData.TabIndex = 4;
            this.btnClearData.Text = "Clear stored data";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // lblTotalItem
            // 
            this.lblTotalItem.AutoSize = true;
            this.lblTotalItem.Location = new System.Drawing.Point(337, 62);
            this.lblTotalItem.Name = "lblTotalItem";
            this.lblTotalItem.Size = new System.Drawing.Size(13, 13);
            this.lblTotalItem.TabIndex = 6;
            this.lblTotalItem.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total items:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(366, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 128);
            this.Controls.Add(this.lblTotalItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.btnOpenListForm);
            this.Controls.Add(this.lblTotalInputForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenInputForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenInputForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalInputForm;
        private System.Windows.Forms.Button btnOpenListForm;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Label lblTotalItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
    }
}

