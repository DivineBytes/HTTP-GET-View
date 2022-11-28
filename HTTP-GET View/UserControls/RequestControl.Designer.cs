
namespace HTTP_GET_View.UserControls
{
    partial class RequestControl
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

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.L_Url = new System.Windows.Forms.Label();
            this.BTN_GET = new System.Windows.Forms.Button();
            this.TB_Url = new System.Windows.Forms.TextBox();
            this.L_UserAgent = new System.Windows.Forms.Label();
            this.TB_UserAgent = new System.Windows.Forms.TextBox();
            this.CB_Type = new System.Windows.Forms.ComboBox();
            this.L_Type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // L_Url
            // 
            this.L_Url.AutoSize = true;
            this.L_Url.Location = new System.Drawing.Point(3, 10);
            this.L_Url.Name = "L_Url";
            this.L_Url.Size = new System.Drawing.Size(32, 13);
            this.L_Url.TabIndex = 5;
            this.L_Url.Text = "URL:";
            // 
            // BTN_GET
            // 
            this.BTN_GET.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_GET.Location = new System.Drawing.Point(308, 5);
            this.BTN_GET.Name = "BTN_GET";
            this.BTN_GET.Size = new System.Drawing.Size(75, 23);
            this.BTN_GET.TabIndex = 4;
            this.BTN_GET.Text = "Get";
            this.BTN_GET.UseVisualStyleBackColor = true;
            this.BTN_GET.Click += new System.EventHandler(this.BTN_GET_Click);
            // 
            // TB_Url
            // 
            this.TB_Url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Url.Location = new System.Drawing.Point(73, 7);
            this.TB_Url.Name = "TB_Url";
            this.TB_Url.Size = new System.Drawing.Size(229, 20);
            this.TB_Url.TabIndex = 3;
            // 
            // L_UserAgent
            // 
            this.L_UserAgent.AutoSize = true;
            this.L_UserAgent.Location = new System.Drawing.Point(4, 36);
            this.L_UserAgent.Name = "L_UserAgent";
            this.L_UserAgent.Size = new System.Drawing.Size(63, 13);
            this.L_UserAgent.TabIndex = 6;
            this.L_UserAgent.Text = "User-Agent:";
            // 
            // TB_UserAgent
            // 
            this.TB_UserAgent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_UserAgent.Location = new System.Drawing.Point(73, 33);
            this.TB_UserAgent.Name = "TB_UserAgent";
            this.TB_UserAgent.Size = new System.Drawing.Size(310, 20);
            this.TB_UserAgent.TabIndex = 7;
            // 
            // CB_Type
            // 
            this.CB_Type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Type.FormattingEnabled = true;
            this.CB_Type.Items.AddRange(new object[] {
            "Content",
            "Header"});
            this.CB_Type.Location = new System.Drawing.Point(73, 59);
            this.CB_Type.Name = "CB_Type";
            this.CB_Type.Size = new System.Drawing.Size(310, 21);
            this.CB_Type.TabIndex = 9;
            // 
            // L_Type
            // 
            this.L_Type.AutoSize = true;
            this.L_Type.Location = new System.Drawing.Point(4, 62);
            this.L_Type.Name = "L_Type";
            this.L_Type.Size = new System.Drawing.Size(34, 13);
            this.L_Type.TabIndex = 10;
            this.L_Type.Text = "Type:";
            // 
            // RequestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.L_Type);
            this.Controls.Add(this.CB_Type);
            this.Controls.Add(this.TB_UserAgent);
            this.Controls.Add(this.L_UserAgent);
            this.Controls.Add(this.L_Url);
            this.Controls.Add(this.BTN_GET);
            this.Controls.Add(this.TB_Url);
            this.Name = "RequestControl";
            this.Size = new System.Drawing.Size(386, 86);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Url;
        private System.Windows.Forms.Button BTN_GET;
        private System.Windows.Forms.TextBox TB_Url;
        private System.Windows.Forms.Label L_UserAgent;
        private System.Windows.Forms.TextBox TB_UserAgent;
        private System.Windows.Forms.ComboBox CB_Type;
        private System.Windows.Forms.Label L_Type;
    }
}
