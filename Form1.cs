using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmojiTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.htmlEditControl1.DocumentHTML = "<div id=\"docs-internal-guid-65641a6d-7fff-4c31-d654-7ca831d6b3ef\" style=\"color: rgb(0, 0, 0); font-family: Arial,sans-serif; font-size: 24pt; font-style: normal; font-variant: normal; font-weight: 400; text-decoration: none; vertical-align: baseline; white-space: pre-wrap; background-color: transparent;\">&#x1F604;&#x1F61D;&#x1F61A;&#x1F6B3;</div>" +
                "<div id=\"docs-internal-guid-65641a6d-7fff-4c31-d654-7ca831d6b3ef\" style=\"color: rgb(0, 0, 0); font-family: Arial,sans-serif; font-size: 24pt; font-style: normal; font-variant: normal; font-weight: 400; text-decoration: none; vertical-align: baseline; white-space: pre-wrap; background-color: transparent;\">😄😝😚🚳</div>";
        }
    }
}
