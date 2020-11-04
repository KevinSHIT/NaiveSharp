using System.ComponentModel;

namespace NaiveSharp.View
{
    partial class AdvanceWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvanceWindow));
            this.btnDebug = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDebug = new System.Windows.Forms.Label();
            this.btnResetFormSize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDebug
            // 
            this.btnDebug.AutoSize = true;
            this.btnDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDebug.Location = new System.Drawing.Point(119, 3);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(110, 53);
            this.btnDebug.TabIndex = 0;
            this.btnDebug.Text = "DEBUG";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnResetFormSize, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDebug, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDebug, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(232, 118);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblDebug
            // 
            this.lblDebug.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(13, 21);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(89, 17);
            this.lblDebug.TabIndex = 2;
            this.lblDebug.Text = "Debug Mode";
            // 
            // btnResetFormSize
            // 
            this.btnResetFormSize.AutoSize = true;
            this.btnResetFormSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResetFormSize.Location = new System.Drawing.Point(119, 62);
            this.btnResetFormSize.Name = "btnResetFormSize";
            this.btnResetFormSize.Size = new System.Drawing.Size(110, 53);
            this.btnResetFormSize.TabIndex = 3;
            this.btnResetFormSize.Text = "OK";
            this.btnResetFormSize.UseVisualStyleBackColor = true;
            this.btnResetFormSize.Click += new System.EventHandler(this.btnResetFormSize_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reset FormSize";
            // 
            // AdvanceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(232, 118);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdvanceWindow";
            this.Text = "Advance";
            this.Load += new System.EventHandler(this.AdvanceWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnResetFormSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDebug;
    }
}