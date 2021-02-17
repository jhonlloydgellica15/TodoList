
namespace TodoList
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgTodo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_task = new System.Windows.Forms.TextBox();
            this.btn_addT = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lblOne = new System.Windows.Forms.Label();

           

            this.lbl_txt1 = new System.Windows.Forms.Label();
            this.lbl_txt2 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgTodo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTodo
            // 
            this.dgTodo.AllowUserToAddRows = false;
            this.dgTodo.AllowUserToDeleteRows = false;
            this.dgTodo.AllowUserToResizeColumns = false;
            this.dgTodo.AllowUserToResizeRows = false;
            this.dgTodo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgTodo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgTodo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTodo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTodo.ColumnHeadersHeight = 28;
            this.dgTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgTodo.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTodo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgTodo.EnableHeadersVisualStyles = false;
            this.dgTodo.Location = new System.Drawing.Point(176, 238);
            this.dgTodo.Name = "dgTodo";
            this.dgTodo.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTodo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgTodo.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgTodo.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgTodo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgTodo.RowTemplate.Height = 50;
            this.dgTodo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTodo.Size = new System.Drawing.Size(347, 568);
            this.dgTodo.TabIndex = 0;
            this.dgTodo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTodo_CellClick);
            this.dgTodo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTodo_CellContentDoubleClick);
            this.dgTodo.SelectionChanged += new System.EventHandler(this.dgTodo_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wednesday";
            // 
            // txt_task
            // 
            this.txt_task.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_task.Location = new System.Drawing.Point(176, 209);
            this.txt_task.Multiline = true;
            this.txt_task.Name = "txt_task";
            this.txt_task.Size = new System.Drawing.Size(255, 23);
            this.txt_task.TabIndex = 2;
            // 
            // btn_addT
            // 
            this.btn_addT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btn_addT.FlatAppearance.BorderSize = 0;
            this.btn_addT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addT.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addT.ForeColor = System.Drawing.Color.White;
            this.btn_addT.Location = new System.Drawing.Point(448, 209);
            this.btn_addT.Name = "btn_addT";
            this.btn_addT.Size = new System.Drawing.Size(75, 23);
            this.btn_addT.TabIndex = 3;
            this.btn_addT.Text = "Add";
            this.btn_addT.UseVisualStyleBackColor = false;
            this.btn_addT.Click += new System.EventHandler(this.btn_addT_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_exit.Location = new System.Drawing.Point(670, 7);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 23);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOne.Location = new System.Drawing.Point(256, 158);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(151, 25);
            this.lblOne.TabIndex = 5;
            this.lblOne.Text = "AWEEEEETT";
            // 


            // lbl_txt1
            // 
            this.lbl_txt1.AutoSize = true;
            this.lbl_txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt1.Location = new System.Drawing.Point(231, 70);
            this.lbl_txt1.Name = "lbl_txt1";
            this.lbl_txt1.Size = new System.Drawing.Size(78, 25);
            this.lbl_txt1.TabIndex = 5;
            this.lbl_txt1.Text = "Achup";
            // 
            // lbl_txt2
            // 
            this.lbl_txt2.AutoSize = true;
            this.lbl_txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt2.Location = new System.Drawing.Point(361, 70);
            this.lbl_txt2.Name = "lbl_txt2";
            this.lbl_txt2.Size = new System.Drawing.Size(162, 25);
            this.lbl_txt2.TabIndex = 5;
            this.lbl_txt2.Text = "Wampipti 👉👈";
            // 
            // lbl_txt
            // 
            this.lbl_txt.AutoSize = true;
            this.lbl_txt.Location = new System.Drawing.Point(65, 136);
            this.lbl_txt.Name = "lbl_txt";
            this.lbl_txt.Size = new System.Drawing.Size(71, 13);
            this.lbl_txt.TabIndex = 6;
            this.lbl_txt.Text = "vincent bayot";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = global::TodoList.Properties.Resources.neon_pink_ladscape_53876_91654;
            this.ClientSize = new System.Drawing.Size(715, 873);
            this.ControlBox = false;

            this.Controls.Add(this.lbl_txt2);
            this.Controls.Add(this.lbl_txt1);

            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_addT);
            this.Controls.Add(this.txt_task);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgTodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        } 

        #endregion

        private System.Windows.Forms.DataGridView dgTodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_task;
        private System.Windows.Forms.Button btn_addT;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lblOne;

        private System.Windows.Forms.Label lbl_text;

        private System.Windows.Forms.Label lbl_txt1;
        private System.Windows.Forms.Label lbl_txt2;
        private System.Windows.Forms.Label lbl_txt;

    }
}

