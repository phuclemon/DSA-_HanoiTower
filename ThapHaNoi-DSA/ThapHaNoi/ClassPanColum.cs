namespace ThapHaNoi
{
    public class ClassPanColum:System.Windows.Forms.Panel 
    {
        private int soDia = 0;
        private string chuoixuat="xuat chuoi";
        private string chuoiStack = "chuoi stack";
        private ClassColum colA, colB, colC;
        private ClassOutPutText myOut;
        private ClassPanStack myStack;
        public void xuatChuoi(ClassOutPutText tmp)
        {
            this.myOut = tmp;
        }
        public void nhapStack(ClassPanStack tmp)
        {
            this.myStack = tmp;
        }
        private void themPT()
        {
            this.myStack.push(this.chuoiStack);
        }
        private void xoaPT()
        {
            this.myStack.pop();
        }
        private void upDateOutPut()
        {
            myOut.setOutText(this.chuoixuat);
            myOut.addOutList(this.chuoixuat);
        }
        public void creat()
        {
            //
            //Creat 3 colum
            //
            int khoangCachGiua2Cot = (this.Width/4);
            
            colA = new ClassColum( khoangCachGiua2Cot, this.Location.Y - 30, this.Height-50,10);
            colB = new ClassColum(colA.Location.X + khoangCachGiua2Cot, this.Location.Y - 30,this.Height-50, 10);
            colC = new ClassColum(colB.Location.X + khoangCachGiua2Cot, this.Location.Y - 30,this.Height-50, 10);
            this.Controls.Add(colA);
            this.Controls.Add(colB);
            this.Controls.Add(colC);
            colA.Visible = true;
            colB.Visible = true;
            colC.Visible = true;
            colC.Show(); colB.Show();
            colA.Show();
            //
            // creat disk
            //
            int widthMax = khoangCachGiua2Cot;
            for (int i = 0; i < this.soDia; i++)
            {
                System.Windows.Forms.Button tmp = new System.Windows.Forms.Button();
                tmp.Size = new System.Drawing.Size(widthMax, 20);
                colA.addDisk(tmp);
                this.Controls.Add(tmp);
                widthMax -= 15;
            }            
        }
        public void clear()
        {
            this.colA.Visible = false;
            this.colB.Visible = false;
            this.colC.Visible = false;
            for (int i=0;i<colA.listDisk.Count;i++)
            {
                colA.listDisk[i].Visible = false;
                colA.removeDisk();
            }
            for (int i=0;i<colB.listDisk.Count;i++)
            {
                colB.listDisk[i].Visible = false;
                colB.removeDisk();
            }
            for (int i = 0; i < colC.listDisk.Count;i++ )
            {
                colC.listDisk[i].Visible = false;
                colC.removeDisk();
            }
        }
        public void setsoDia(int k)
        { this.soDia = k; }
        private void move(ClassColum x, ClassColum y)
        {
            System.Threading.Thread.Sleep(1500);
            
            {               
                System.Windows.Forms.Button tmp = new System.Windows.Forms.Button();
                tmp = x.listDisk[x.listDisk.Count - 1];
                x.removeDisk();
                y.addDisk(tmp);
                this.Controls.Add(tmp);
                this.chuoixuat = "Move 1 disk from "+x.Text +" to disk "+y.Text;
              //  System.Windows.Forms.MessageBox.Show(x.Name);
                this.upDateOutPut();
                
            }
            System.Windows.Forms.Application.DoEvents();          
            this.xoaPT();

        }
        //
        // Move disk from colum a to colum b su dung trung gian c;
        //
        public void deQuy(int numOfDisk, ClassColum a, ClassColum b, ClassColum c)
        {
            System.Threading.Thread.Sleep(1000);
            this.chuoiStack = (numOfDisk).ToString() + "," + a.Text + "," + b.Text + "," + c.Text;
            this.themPT();
            System.Windows.Forms.Application.DoEvents();

            if (numOfDisk == 1)
            {
                this.move(a, b);
            }
            else
            {
                deQuy(numOfDisk - 1, a, c, b);
                deQuy(1, a, b, c);
                deQuy(numOfDisk - 1, c, b, a);
                System.Threading.Thread.Sleep(1000);
                this.xoaPT();
                System.Windows.Forms.Application.DoEvents();
            }
        }
        //
        //run
        // 
        public void run()
        {
            this.colA.setText("A");
            this.colB.setText("B");
            this.colC.setText("C");
            deQuy(soDia, this.colA, this.colC, this.colB);
        }
    }
}
