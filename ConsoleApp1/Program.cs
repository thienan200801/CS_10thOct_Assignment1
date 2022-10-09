﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApp1
{
    internal class Program
    {
        private static int par1;
        private static TextBox AddResult, MultiplyResult, para1;
        private static int[,] A, B;

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

            AddResult = new TextBox();
            AddResult.Text = "0";
            AddResult.Location = new Point(270, 206);
            AddResult.AutoSize = true;
            AddResult.Font = new Font("Calibri", 18);
            AddResult.Size = new Size(250, 50);
            AddResult.ReadOnly = true;
            form.Controls.Add(AddResult);

            MultiplyResult = new TextBox();
            MultiplyResult.Text = "0";
            MultiplyResult.Location = new Point(270, 306);
            MultiplyResult.AutoSize = true;
            MultiplyResult.Font = new Font("Calibri", 18);
            MultiplyResult.Size = new Size(250, 50);
            MultiplyResult.ReadOnly = true;          
            form.Controls.Add(MultiplyResult);

            Button Clear = new Button();
            Clear.Text = "Clear";
            Clear.Location = new Point(300, 380);
            Clear.Size = new Size(100, 50);
            Clear.Font = new Font("Calibri", 18);
            Clear.Click += new EventHandler(Clear_Click);
            form.Controls.Add(Clear);

            Application.Run(form);
        }
        public static void AddFunction_Click(Object sender, EventArgs e)
        {
            par1 = int.Parse(para1.Text);
            A = new int[par1, par1];
            Random rand = new Random();
            for (int i = 0; i < par1; i++)
            {
                for (int j = 0; j < par1; j++)
                {
                    A[i, j] = rand.Next(10);
                }
            }
            for (int i = 0; i < par1; i++)
            {
                for (int j = 0; j < par1; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
            AddResult.Text = par1.ToString();
        }
        public static void MultiplyFunction_Click(Object sender, EventArgs e)
        {
            par1 = int.Parse(para1.Text);
            MultiplyResult.Text = par1.ToString();
        }
        public static void Clear_Click(Object sender, EventArgs e)
        {
            para1.Text = "";
        }
    }
}
