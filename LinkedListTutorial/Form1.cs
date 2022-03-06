using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedListTutorial
{
    public partial class Form1 : Form
    {
        private LinkedList linkedList;

        private void PrintList()
        {
            ShowList.Items.Clear();

            if (linkedList != null)
            {
                LinkedListNode runner = linkedList.head;
                while (runner != null)
                {
                    ShowList.Items.Add(runner.data);
                    runner = runner.next;
                }
            }            
        }


        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index;
            try
            {
                index = int.Parse(Addindex.Text);

                if (index < 0 || index > linkedList.count + 1)
                    throw new Exception();

                if (index == 1)
                {
                    //MessageBox.Show(Addvalue.Text);
                    linkedList.AddFront(Addvalue.Text);
                }
                else if (index == linkedList.count + 1)
                {
                    //MessageBox.Show(Addvalue.Text);
                    linkedList.AddBack(Addvalue.Text);
                }
                else
                {
                    linkedList.AddWithIndex(int.Parse(Addindex.Text), Addvalue.Text);
                }

                PrintList();

                Addindex.Text = "";
                Addvalue.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("To'g'ri son kiriting!");
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkedList = new LinkedList();
        }

        private void BtnClearList_Click(object sender, EventArgs e)
        {
            linkedList = null;

            PrintList();
        }

        private void BtnDelWithVal_Click(object sender, EventArgs e)
        {
            linkedList.DeleteWithVaL(DelWithVal.Text);

            PrintList();

            DelWithVal.Text = "";
        }

        private void BtnDelWithIndex_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(DelWithIndex.Text);

                if(index < 0 || index > linkedList.count + 1 )
                    throw new Exception();
                

                if(index == 1)
                {
                    linkedList.DeleteFront();
                }
                else if(index == linkedList.count)
                {
                    linkedList.DeleteLast();
                }
                else
                {
                    // delete value in index
                    linkedList.DeleteWithIndex(index);
                }


                PrintList();

                DelWithIndex.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("To'g'ri son kiriting!");
            }
            
        }

        private void AddFrontBtn_Click(object sender, EventArgs e)
        {
            linkedList.AddFront(AddFrontValue.Text);

            PrintList();

            AddFrontValue.Text = "";
        }

        private void AddBackBtn_Click(object sender, EventArgs e)
        {
            linkedList.AddBack(AddBackValue.Text);

            PrintList();

            AddBackValue.Text = "";

        }

    }
}
