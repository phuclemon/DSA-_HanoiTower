namespace ThapHaNoi
{
    partial class FormHaNoiTower
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHaNoiTower));
            this.txtSoDia = new System.Windows.Forms.TextBox();
            this.butCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butRun = new System.Windows.Forms.Button();
            this.butPlayAgain = new System.Windows.Forms.Button();
            this.panStack = new ThapHaNoi.ClassPanStack();
            this.panCode = new ThapHaNoi.ClassOutPutText();
            this.panColum = new ThapHaNoi.ClassPanColum();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSoDia
            // 
            resources.ApplyResources(this.txtSoDia, "txtSoDia");
            this.txtSoDia.Name = "txtSoDia";
            // 
            // butCreate
            // 
            resources.ApplyResources(this.butCreate, "butCreate");
            this.butCreate.Name = "butCreate";
            this.butCreate.UseVisualStyleBackColor = true;
            this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // butRun
            // 
            resources.ApplyResources(this.butRun, "butRun");
            this.butRun.Name = "butRun";
            this.butRun.UseVisualStyleBackColor = true;
            this.butRun.Click += new System.EventHandler(this.button2_Click);
            // 
            // butPlayAgain
            // 
            resources.ApplyResources(this.butPlayAgain, "butPlayAgain");
            this.butPlayAgain.Name = "butPlayAgain";
            this.butPlayAgain.UseVisualStyleBackColor = true;
            this.butPlayAgain.Click += new System.EventHandler(this.butPlayAgain_Click);
            // 
            // panStack
            // 
            this.panStack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panStack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.panStack, "panStack");
            this.panStack.Name = "panStack";
            // 
            // panCode
            // 
            this.panCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.panCode, "panCode");
            this.panCode.Name = "panCode";
            this.panCode.Paint += new System.Windows.Forms.PaintEventHandler(this.panCode_Paint);
            // 
            // panColum
            // 
            this.panColum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panColum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.panColum, "panColum");
            this.panColum.Name = "panColum";
            this.panColum.Paint += new System.Windows.Forms.PaintEventHandler(this.panColum_Paint);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // FormHaNoiTower
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panStack);
            this.Controls.Add(this.panCode);
            this.Controls.Add(this.panColum);
            this.Controls.Add(this.butPlayAgain);
            this.Controls.Add(this.butRun);
            this.Controls.Add(this.txtSoDia);
            this.Controls.Add(this.butCreate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormHaNoiTower";
            this.Load += new System.EventHandler(this.FormHaNoiTower_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public int soDia()
        {
            return int.Parse(this.txtSoDia.Text);
        }

        #endregion

        private System.Windows.Forms.TextBox txtSoDia;
        private System.Windows.Forms.Button butCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butRun;
        private System.Windows.Forms.Button butPlayAgain;
        private ClassPanColum panColum;
        private ClassOutPutText panCode;
        private ClassPanStack panStack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

