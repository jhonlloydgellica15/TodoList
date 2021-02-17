using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoList.MyClasses;
using MySql.Data.MySqlClient;
namespace TodoList
{
    public partial class Form1 : Form
    {
        TODO todo = new TODO();

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.DayOfWeek.ToString();


            

            READ();

            
        }

        public void READ()
        {
            todo.READ();
            dgTodo.DataSource = todo.dt;
            dgTodo.Columns["todo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgTodo.Columns["todo"].ReadOnly = true;
            dgTodo.Columns["id"].Visible = false;

        }

        private void dgTodo_SelectionChanged(object sender, EventArgs e)
        {
         
        }

        private void dgTodo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeleteForm frm = new UpdateDeleteForm(this);
            frm.lblId.Text = (dgTodo.Rows[e.RowIndex].Cells[0].Value.ToString());
            frm.txtUpdate.Text = (dgTodo.Rows[e.RowIndex].Cells[1].Value.ToString());
            frm.ShowDialog();
        }

        private void dgTodo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        
        }

        private void btn_addT_Click(object sender, EventArgs e)
        {
          
                //string task = txt_task.ToString();
                todo.INSERT(txt_task);
                txt_task.Clear();
                READ();

           
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }
    }
}
