using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThapHaNoi
{
    public partial class FormHaNoiTower : Form
    {
        public FormHaNoiTower()
        {
            InitializeComponent();
        }
        private void butCreate_Click(object sender, EventArgs e)
        {
            this.panColum.nhapStack(this.panStack);
            this.panColum.xuatChuoi(this.panCode);
            if (this.txtSoDia.Text != "")
            {
                if (int.Parse(this.txtSoDia.Text) > 0 && int.Parse(this.txtSoDia.Text) < 7)
                {
                    this.panCode.setOutText("Sẵn sàng!");
                    this.butCreate.Enabled = false;
                    this.butRun.Enabled = true;
                    this.panColum.setsoDia(int.Parse(this.txtSoDia.Text));
                    this.panColum.creat();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Số đĩa từ 1 tới 6");
                    this.txtSoDia.Text = "";
                    this.txtSoDia.Focus();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nhập số đĩa!");
                this.txtSoDia.Focus();
            }

        }

        private void panColum_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.butRun.Enabled = false;
            this.panColum.run();
            this.butPlayAgain.Enabled = true;
        }
        private void butPlayAgain_Click(object sender, EventArgs e)
        {
            this.panCode.clearList();
            this.panCode.setOutText("");
            this.panColum.clear();
            this.butCreate.Enabled = true;
            this.txtSoDia.Text = "";
            this.txtSoDia.Focus();
            this.butPlayAgain.Enabled = false;
        }

        private void panCode_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormHaNoiTower_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panStack.pop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.panStack.push("asdfasfasfsd fasfs");
        }

        private void txtSoDia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
