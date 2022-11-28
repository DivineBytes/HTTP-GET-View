
namespace HTTP_GET_View.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TB_View = new System.Windows.Forms.TextBox();
            this.UC_Request = new HTTP_GET_View.UserControls.RequestControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TB_View, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UC_Request, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TB_View
            // 
            this.TB_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_View.Location = new System.Drawing.Point(3, 94);
            this.TB_View.Multiline = true;
            this.TB_View.Name = "TB_View";
            this.TB_View.ReadOnly = true;
            this.TB_View.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_View.Size = new System.Drawing.Size(478, 364);
            this.TB_View.TabIndex = 0;
            this.TB_View.WordWrap = false;
            // 
            // UC_Request
            // 
            this.UC_Request.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_Request.Location = new System.Drawing.Point(3, 3);
            this.UC_Request.Name = "UC_Request";
            this.UC_Request.Size = new System.Drawing.Size(478, 85);
            this.UC_Request.TabIndex = 1;
            this.UC_Request.RequestResponseChanged += new HTTP_GET_View.UserControls.RequestControl.RequestResponseChangedDelegate(this.UC_Request_RequestResponseChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Main";
            this.Text = "HTTP-GET View";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TB_View;
        private HTTP_GET_View.UserControls.RequestControl UC_Request;
    }
}