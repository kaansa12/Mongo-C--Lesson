namespace MongoDB_Lesson_Example
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            insertTB=new TextBox();
            readTB=new TextBox();
            updateTB=new TextBox();
            idTB=new TextBox();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            insertBT=new Button();
            readBT=new Button();
            updateBT=new Button();
            deleteBT=new Button();
            IDListBox=new ListBox();
            SuspendLayout();
            // 
            // insertTB
            // 
            insertTB.Location=new Point(64, 39);
            insertTB.Name="insertTB";
            insertTB.Size=new Size(100, 23);
            insertTB.TabIndex=0;
            // 
            // readTB
            // 
            readTB.Location=new Point(64, 115);
            readTB.Name="readTB";
            readTB.Size=new Size(100, 23);
            readTB.TabIndex=1;
            // 
            // updateTB
            // 
            updateTB.Location=new Point(64, 144);
            updateTB.Name="updateTB";
            updateTB.Size=new Size(100, 23);
            updateTB.TabIndex=2;
            // 
            // idTB
            // 
            idTB.Location=new Point(15, 143);
            idTB.Name="idTB";
            idTB.Size=new Size(33, 23);
            idTB.TabIndex=4;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(170, 42);
            label1.Name="label1";
            label1.Size=new Size(36, 15);
            label1.TabIndex=5;
            label1.Text="Insert";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(170, 147);
            label2.Name="label2";
            label2.Size=new Size(45, 15);
            label2.TabIndex=6;
            label2.Text="Update";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(170, 118);
            label3.Name="label3";
            label3.Size=new Size(33, 15);
            label3.TabIndex=7;
            label3.Text="Read";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(170, 176);
            label4.Name="label4";
            label4.Size=new Size(40, 15);
            label4.TabIndex=8;
            label4.Text="Delete";
            // 
            // insertBT
            // 
            insertBT.Location=new Point(222, 39);
            insertBT.Name="insertBT";
            insertBT.Size=new Size(75, 23);
            insertBT.TabIndex=9;
            insertBT.Text="INSERT";
            insertBT.UseVisualStyleBackColor=true;
            insertBT.Click+=insertBT_Click;
            // 
            // readBT
            // 
            readBT.Location=new Point(222, 115);
            readBT.Name="readBT";
            readBT.Size=new Size(75, 23);
            readBT.TabIndex=10;
            readBT.Text="READ";
            readBT.UseVisualStyleBackColor=true;
            readBT.Click+=readBT_Click;
            // 
            // updateBT
            // 
            updateBT.Location=new Point(222, 143);
            updateBT.Name="updateBT";
            updateBT.Size=new Size(75, 23);
            updateBT.TabIndex=11;
            updateBT.Text="UPDATE";
            updateBT.UseVisualStyleBackColor=true;
            updateBT.Click+=updateBT_Click;
            // 
            // deleteBT
            // 
            deleteBT.Location=new Point(78, 172);
            deleteBT.Name="deleteBT";
            deleteBT.Size=new Size(75, 23);
            deleteBT.TabIndex=12;
            deleteBT.Text="DELETE";
            deleteBT.UseVisualStyleBackColor=true;
            deleteBT.Click+=deleteBT_Click;
            // 
            // IDListBox
            // 
            IDListBox.FormattingEnabled=true;
            IDListBox.ItemHeight=15;
            IDListBox.Location=new Point(349, 39);
            IDListBox.Name="IDListBox";
            IDListBox.Size=new Size(120, 169);
            IDListBox.TabIndex=13;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(500, 251);
            Controls.Add(IDListBox);
            Controls.Add(deleteBT);
            Controls.Add(updateBT);
            Controls.Add(readBT);
            Controls.Add(insertBT);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(idTB);
            Controls.Add(updateTB);
            Controls.Add(readTB);
            Controls.Add(insertTB);
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox insertTB;
        private TextBox readTB;
        private TextBox updateTB;
        private TextBox idTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button insertBT;
        private Button readBT;
        private Button updateBT;
        private Button deleteBT;
        private ListBox IDListBox;
    }
}