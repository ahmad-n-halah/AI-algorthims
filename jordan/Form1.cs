using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jordan
{
    public partial class Form1 : Form
    {
        int num = 12;
        int num2;
        List<int> horistic = new List<int>();
        List<int> path = new List<int>();
        int[,] matrix = new int[12, 12];
        int index;

        void expand(int n, int g)
        {
            for (int i = 0; i < num; i++)
                if (matrix[g, i] != 0)
                    matrix[g, i] += n;
                  
                
        }


        int b;
        void paths(int p)
        {
            if (p != 0)
            {
                for (b = 0; b <num; b++)
                    if (matrix[b,p] > 0)
                    {
                        path.Add(p);
                        paths(b);
                    }
            }
            else
                path.Add(p);
        }
  
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // Astar s = new Astar();
            
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            horistic.Add(Convert.ToInt32(h0.Text));
            horistic.Add(Convert.ToInt32(h1.Text));
            horistic.Add(Convert.ToInt32(h2.Text));
            horistic.Add(Convert.ToInt32(h3.Text));
            horistic.Add(Convert.ToInt32(h4.Text));
            horistic.Add(Convert.ToInt32(h4.Text));
            horistic.Add(Convert.ToInt32(h5.Text));
            horistic.Add(Convert.ToInt32(h6.Text));
            horistic.Add(Convert.ToInt32(h7.Text));
            horistic.Add(Convert.ToInt32(h8.Text));
            horistic.Add(Convert.ToInt32(h9.Text));
            horistic.Add(Convert.ToInt32(h10.Text));
            horistic.Add(Convert.ToInt32(h11.Text));

            matrix[0, 1] = 89;
            matrix[0, 2] = 32;
          
            matrix[0, 4] = 50;

            matrix[1, 6] = 29;
            matrix[1, 5] = 75;

            matrix[2, 3] = 25;
            matrix[2, 6] = 42;

            matrix[3, 4] = 89;
            matrix[3, 7] = 45;

            matrix[5, 6] = 32;
            matrix[5, 8] = 36;

            matrix[6, 8] = 118;
            matrix[6, 7] = 22;

            matrix[8, 9] = 63;

            matrix[9, 10] = 90;
            matrix[9, 11] = 159;

            matrix[10, 11] = 116;
          


            //f(x)=g(n)+h(n)
            for (int i = 0; i < num; i++)
                for (int j = 0; j < num; j++)
                {
                    if (matrix[i, j] != 0)
                        matrix[i, j] += horistic[j];
                    
                }

            // calculate each path
            for (int i = 0; i < num - 1; i++)
                for (int j = 0; j < num - 1; j++)
                    if (matrix[i, j] != 0)
                    {
                        num2 = matrix[i, j];
                        expand(num2, j);
                    }

            //astar                

            int goal, cost = 0;
            path.Clear();


            goal = Convert.ToInt32(textBox1.Text);

           
            for (int i = 0; i < num; i++)
            {
                
                if (cost > 0)//compare smaller cost
                {

                    if (matrix[i,goal] > 0 && matrix[i,goal] < cost)
                    {
                        cost = matrix[i, goal];
                        index = i;
                    }
                }
                 else
                   {//cost at least one time
                        
                        if (matrix[i,goal] > 0)
                        {
                            cost = matrix[i,goal];
                            index = i;
                        }
                    }



                }
            


            path.Add(goal);//add goal in stack
            paths(index);
            MessageBox.Show("cost "+cost.ToString());

           // cout << "the cost is  " << cost << endl;
            //cout << "the path is ";
            string pat="";
            for (int i = path.Count - 1; i >= 0; i--)
                   pat+= " --> "+path[i].ToString();

            label48.Text = pat;
        }

        private void ovalShape11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            matrix[0, 1] = 1;
            matrix[0, 2] = 1;
          
            matrix[0, 4] = 1;

            matrix[1, 6] = 1;
            matrix[1, 5] = 1;

            matrix[2, 3] = 1;
            matrix[2, 6] = 1;

            matrix[3, 4] = 1;
            matrix[3, 7] = 1;

            matrix[5, 6] = 1;
            matrix[5, 8] = 1;

            matrix[6, 8] = 1;
            matrix[6, 7] = 1;

            matrix[8, 9] = 1;

            matrix[9, 10] = 1;
            matrix[9, 11] = 1;

            matrix[10, 11] = 1;
          


     
                


         

            //astar                

            int goal;
            path.Clear();


            goal = Convert.ToInt32(textBox2.Text);


            for (int i = 0; i < num; i++)
            {
                    if (matrix[i, goal] > 0)
                    {
                        index = i;
                        break;
                    }
                }
            



                
            


            path.Add(goal);//add goal in stack
            paths(index);
           

           // cout << "the cost is  " << cost << endl;
            //cout << "the path is ";
            string pat="";
            for (int i = path.Count - 1; i >= 0; i--)
                   pat+= " --> "+path[i].ToString();

            label49.Text = pat;
        
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            matrix[0, 1] = 89;
            matrix[0, 2] = 32;

            matrix[0, 4] = 50;

            matrix[1, 6] = 29;
            matrix[1, 5] = 75;

            matrix[2, 3] = 25;
            matrix[2, 6] = 42;

            matrix[3, 4] = 89;
            matrix[3, 7] = 45;

            matrix[5, 6] = 32;
            matrix[5, 8] = 36;

            matrix[6, 8] = 118;
            matrix[6, 7] = 22;

            matrix[8, 9] = 63;

            matrix[9, 10] = 90;
            matrix[9, 11] = 159;

            matrix[10, 11] = 116;




            // calculate each path
            for (int i = 0; i < num - 1; i++)
                for (int j = 0; j < num - 1; j++)
                    if (matrix[i, j] != 0)
                    {
                        num2 = matrix[i, j];
                        expand(num2, j);
                    }

            //astar                
            int goal, cost = 0;
            path.Clear();


            goal = Convert.ToInt32(textBox15.Text);


            for (int i = 0; i < num; i++)
            {

                if (cost > 0)//compare smaller cost
                {

                    if (matrix[i, goal] > 0 && matrix[i, goal] < cost)
                    {
                        cost = matrix[i, goal];
                        index = i;
                    }
                }
                else
                {//cost at least one time

                    if (matrix[i, goal] > 0)
                    {
                        cost = matrix[i, goal];
                        index = i;
                    }
                }
            }
            path.Add(goal);//add goal in stack
            paths(index);
            MessageBox.Show("cost " + cost.ToString());

            // cout << "the cost is  " << cost << endl;
            //cout << "the path is ";
            string pat = "";
            for (int i = path.Count - 1; i >= 0; i--)
                pat += " --> " + path[i].ToString();

            label51.Text = pat;
        }

      
    }
}
