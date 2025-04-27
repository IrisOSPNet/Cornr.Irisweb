//-YtmjNf12PxW6k9VGjO6Rt1yG1cDLvj6Ger7u1lOnZgE46FOgX53vDsJf7TFogs9
namespace IrisCornr
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAddressBar;
        private System.Windows.Forms.Button btnGo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            button1 = new Button();
            txtAddressBar = new TextBox();
            btnGo = new Button();
            btnDeleteTab = new Button();
            btnBack = new Button();
            btnForward = new Button();
            textBox1 = new TextBox();
            copyright = new TextBox();
            SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtAddressBar
            // 
            resources.ApplyResources(txtAddressBar, "txtAddressBar");
            txtAddressBar.Name = "txtAddressBar";
            // 
            // btnGo
            // 
            resources.ApplyResources(btnGo, "btnGo");
            btnGo.Name = "btnGo";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // btnDeleteTab
            // 
            resources.ApplyResources(btnDeleteTab, "btnDeleteTab");
            btnDeleteTab.Name = "btnDeleteTab";
            btnDeleteTab.UseVisualStyleBackColor = true;
            btnDeleteTab.Click += btnDeleteTab_Click;
            // 
            // btnBack
            // 
            resources.ApplyResources(btnBack, "btnBack");
            btnBack.Name = "btnBack";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnForward
            // 
            resources.ApplyResources(btnForward, "btnForward");
            btnForward.Name = "btnForward";
            btnForward.UseVisualStyleBackColor = true;
            btnForward.Click += btnForward_Click;
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Name = "textBox1";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // copyright
            // 
            resources.ApplyResources(copyright, "copyright");
            copyright.Name = "copyright";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(copyright);
            Controls.Add(tabControl1);
            Controls.Add(textBox1);
            Controls.Add(btnForward);
            Controls.Add(btnBack);
            Controls.Add(btnDeleteTab);
            Controls.Add(btnGo);
            Controls.Add(txtAddressBar);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnDeleteTab;
        private Button btnBack;
		private Button btnForward;
		private TextBox textBox1;
        private TextBox copyright;
    }
}
