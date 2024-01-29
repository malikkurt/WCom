using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCom
{
    public partial class loginScreenForm : Form
    {
        private Button button1;

        public loginScreenForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // loginScreenForm
            // 
            this.ClientSize = new System.Drawing.Size(458, 375);
            this.Controls.Add(this.button1);
            this.Name = "loginScreenForm";
            this.ResumeLayout(false);

        }
    }
}
