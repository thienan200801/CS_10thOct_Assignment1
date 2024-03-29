﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ConsoleApp1
{
    internal class Program
    {
        private static int par1;
        private static TextBox para1;
        private static Label MultiplyResult, AddResult;
        static MyMatrix A, B;

        static void Main(string[] args)
        {
            Form form = new Form();
            form.Text = "Form Properties";
            form.BackColor = System.Drawing.Color.BlanchedAlmond;
            form.Width *= 2;
            form.Height *= 2;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.Cursor = Cursors.Hand;
            form.StartPosition = FormStartPosition.CenterScreen;            

            Label mylab1 = new Label();
            mylab1.Text = "Length: ";
            mylab1.Location = new Point(100, 30);
            mylab1.AutoSize = true;
            mylab1.Font = new Font("Calibri", 18);
            mylab1.ForeColor = Color.Green;
            mylab1.Padding = new Padding(6);
            form.Controls.Add(mylab1);

            para1 = new TextBox();
            para1.Text = "0";
            para1.Location = new Point(270, 38);
            para1.AutoSize = true;
            para1.Font = new Font("Calibri", 18);
            para1.Size = new Size(250, 50);
            par1 = int.Parse(para1.Text);
            form.Controls.Add(para1);

            Button AddButton = new Button();
            AddButton.Text = "Add";
            AddButton.Location = new Point(150, 200);
            AddButton.Size = new Size(100, 50);
            AddButton.Font = new Font("Calibri", 18);
            AddButton.Click += new EventHandler(AddFunction_Click);
            form.Controls.Add(AddButton);

            Button MultiplyButton = new Button();
            MultiplyButton.Text = "Multiply";
            MultiplyButton.Location = new Point(150, 300);
            MultiplyButton.Size = new Size(100, 50);
            MultiplyButton.Font = new Font("Calibri", 18);
            MultiplyButton.Click += new EventHandler(MultiplyFunction_Click);
            form.Controls.Add(MultiplyButton);

            AddResult = new Label();
            AddResult.Text = "0";
            AddResult.Location = new Point(270, 206);
            AddResult.AutoSize = true;
            AddResult.Font = new Font("Calibri", 18);
            AddResult.Size = new Size(250, 50);
            form.Controls.Add(AddResult);            

            MultiplyResult = new Label();
            MultiplyResult.Text = "0";
            MultiplyResult.Location = new Point(270, 306);
            MultiplyResult.AutoSize = true;
            MultiplyResult.Font = new Font("Calibri", 18);
            MultiplyResult.Size = new Size(250, 100);
            form.Controls.Add(MultiplyResult);

            Button Clear = new Button();
            Clear.Text = "Clear";
            Clear.Location = new Point(300, 490);
            Clear.Size = new Size(100, 50);
            Clear.Font = new Font("Calibri", 18);
            Clear.Click += new EventHandler(Clear_Click);
            form.Controls.Add(Clear);

            Application.Run(form);
        }
        public static void AddFunction_Click(Object sender, EventArgs e)
        {
            par1 = int.Parse(para1.Text);
            A = new MyMatrix(par1);
            B = new MyMatrix(par1);

            Console.WriteLine("A: ");
            A.Print();

            Console.WriteLine("B: ");
            B.Print();

            AddResult.Text = A.Add(B).MyToString();
        }
        public static void MultiplyFunction_Click(Object sender, EventArgs e)
        {
            par1 = int.Parse(para1.Text);
            A = new MyMatrix(par1);
            B = new MyMatrix(par1);

            Console.WriteLine("A: ");
            A.Print();

            Console.WriteLine("B: ");
            B.Print();

            MultiplyResult.Text = A.Multiply(B).MyToString();
        }
        public static void Clear_Click(Object sender, EventArgs e)
        {
            para1.Text = "";
        }
    }
}
