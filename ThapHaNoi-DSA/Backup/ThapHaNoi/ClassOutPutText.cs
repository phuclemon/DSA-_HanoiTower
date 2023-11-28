using System;
using System.Collections.Generic;
using System.Text;

namespace ThapHaNoi
{
    public class ClassOutPutText:System.Windows.Forms.Panel
    {
        //
        //field
        //
        private System.Windows.Forms.TextBox outText;
        private System.Windows.Forms.ListBox outList;
        //
        // method
        //
        public void setOutText(string giatri)
        {
            this.outText.Text = giatri;
        }
        public void addOutList(string tmp)
        {
            this.outList.Items.Add(tmp);
        }
        public void clearList()
        {
            this.outList.Items.Clear();
        }
        //create
        public ClassOutPutText()
        {
            outText = new System.Windows.Forms.TextBox();
            this.Controls.Add(outText);
            this.outText.Size = new System.Drawing.Size(this.Width+150 , this.Height / 5);
            this.outText.Location = new System.Drawing.Point(this.Location.X + 25, this.Location.Y + 10);
            this.outText.Visible = true; this.outText.Show();
            //
            this.outList = new System.Windows.Forms.ListBox();
            this.Controls.Add(outList);
            this.outList.Size = new System.Drawing.Size(this.Width+150, this.Height+25);
            this.outList.Location = new System.Drawing.Point(this.Location.X + 25, this.Location.Y + 50);
            this.outList.Sorted = false;
            this.outList.Visible = true; this.outList.Show();
        }
    }
}
