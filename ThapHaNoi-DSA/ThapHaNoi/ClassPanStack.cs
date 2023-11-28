
namespace ThapHaNoi
{
    public class ClassPanStack:System.Windows.Forms.Panel
    {
        private System.Collections.Generic.Stack<System.Windows.Forms.Button> myStack;
        public ClassPanStack()
        {
            myStack = new System.Collections.Generic.Stack<System.Windows.Forms.Button>();

        }
        public void push(string tmp)
        {
            System.Windows.Forms.Button a = new System.Windows.Forms.Button();
            a.Size = new System.Drawing.Size(this.Width-1, 30);
            if (this.myStack.Count == 0)
            {
                a.Location = new System.Drawing.Point(0,this.Height-32);
            }
            else
            {
                a.Location = new System.Drawing.Point(0, this.Height - 32*(this.myStack.Count+1));
            }
            a.Text = tmp;
            a.Visible = true;
            this.Controls.Add(a);
            this.myStack.Push(a);
        }
        public void pop()
        {
            System.Windows.Forms.Button tmp = new System.Windows.Forms.Button();
            tmp=this.myStack.Peek();
            tmp.Visible = false; 
            this.myStack.Pop();
        }
    }
}
