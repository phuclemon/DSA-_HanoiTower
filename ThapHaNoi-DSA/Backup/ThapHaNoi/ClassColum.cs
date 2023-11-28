
namespace ThapHaNoi
{
    public class ClassColum : System.Windows.Forms.Button
    {
        //Khoi tao cac field
        int locX, locY, height, width;
        public System.Collections.Generic.List<System.Windows.Forms.Button> listDisk;        
        //Khoi tao cac method
        public void setText(string name)
        {
            this.Text = name;
        }
        public void addDisk(System.Windows.Forms.Button a)
        {
            if (this.listDisk.Count == 0)
            {
                a.Location = new System.Drawing.Point(this.Location.X - a.Width/2,this.Location.Y+this.height-a.Height);                
                this.listDisk.Add(a);
            }
            else {
                a.Location = new System.Drawing.Point((this.Location.X - a.Width / 2), (this.listDisk[listDisk.Count-1].Location.Y-a.Height));
                this.listDisk.Add(a);
            }
            a.Visible = true; a.Show();                
        }
        public void removeDisk ()
        {
            if (this.listDisk.Count > 0)
            {
                this.listDisk[listDisk.Count - 1].Visible = false;
                this.listDisk.RemoveAt(listDisk.Count - 1);
            }
        }
        // khoi tao doi tuong
        public ClassColum(int locX, int locY, int height, int width)
        {
            this.locX = locX;
            this.locY = locY;
            this.height = height;
            this.width = width;
            this.Size = new System.Drawing.Size(width,height);
            this.Location = new System.Drawing.Point(locX, locY);
            this.Visible = true;
            this.Show();
            this.listDisk = new System.Collections.Generic.List<System.Windows.Forms.Button>();
        }
    }
}
