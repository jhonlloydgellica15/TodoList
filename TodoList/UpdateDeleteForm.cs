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

namespace TodoList
{
    public partial class UpdateDeleteForm : Form
    {
        Form1 f1;
        TODO todo = new TODO();
        public UpdateDeleteForm(Form1 frm1)
        {
            InitializeComponent();
            f1 = frm1;
        }

        private void UpdateDeleteForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UPDATE();
        }

        public void UPDATE()
        {
            todo.task = txtUpdate.Text;
            todo.id = lblId.Text;
            todo.UPDATE();
            f1.READ();
            this.Dispose();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DELETE();
        }
        public void DELETE()
        {
            todo.id = lblId.Text;
            todo.DELETE();
            f1.READ();
            this.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
