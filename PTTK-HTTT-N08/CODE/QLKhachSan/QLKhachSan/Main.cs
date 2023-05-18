using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace ATBMHTTT
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private Form formchild = null;
        private void OpenChildForm(Form childForm)
        {
            if (formchild != null)
            {
                formchild.Close(); 
            }
            formchild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            //panelChildForm.Tag = childForm;
            //childForm.BringToFront();
            childForm.Show();
        }

        private void SwitchColorMenu(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.FromArgb(255, 212, 178))
            {
                btn.BackColor = Color.FromArgb(255, 246, 189);
            }
            else
            {
                foreach (Control prebtn in panelMenu.Controls)
                {
                    if (prebtn.GetType() == typeof(Button))
                    {
                        prebtn.BackColor = Color.FromArgb(255, 246, 189);
                        prebtn.ForeColor = Color.Black;
                    }
                }
                btn.BackColor = Color.FromArgb(255, 212, 178);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void buttonThongTinUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XemDanhSachUser());
            SwitchColorMenu(sender, e);
        }

        private void buttonThongTinQuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinQuyen());
            SwitchColorMenu(sender, e);
        }

        private void buttonQuanLyUserRole_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyUserRole());
            SwitchColorMenu(sender, e);
        }

        private void buttonQuanLyQuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyQuyen());
            SwitchColorMenu(sender, e);
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelUsername_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelAdmin_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonUser_Click(object sender, EventArgs e)
        {

        }

        private void buttonRole_Click(object sender, EventArgs e)
        {

        }
    }
}
