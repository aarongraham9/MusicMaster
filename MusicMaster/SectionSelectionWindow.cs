using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MM.Models;

namespace MusicMaster
{
    public partial class SectionSelectionWindow : Form
    {
        public SectionSelectionWindow(UserModel userDataIn)
        {
            InitializeComponent();

            SetFormOptions();
        }

        private void SetFormOptions()
        {
            //this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(LoginWindow_KeyDown);
        }
    }
}
