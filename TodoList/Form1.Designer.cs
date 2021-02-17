
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle76 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle77 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle78 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgTodo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle76.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle76.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle76.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle76.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle76.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle76.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle76.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTodo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle76;
            this.dgTodo.ColumnHeadersHeight = 28;
            this.dgTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgTodo.ColumnHeadersVisible = false;
            dataGridViewCellStyle77.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle77.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle77.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle77.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle77.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle77.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle77.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTodo.DefaultCellStyle = dataGridViewCellStyle77;
            this.dgTodo.EnableHeadersVisualStyles = false;
            this.dgTodo.Location = new System.Drawing.Point(176, 238);
            this.dgTodo.Name = "dgTodo";
            this.dgTodo.RowHeadersVisible = false;
            dataGridViewCellStyle78.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle78.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle78.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTodo.RowsDefaultCellStyle = dataGridViewCellStyle78;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = global::TodoList.Properties.Resources.neon_pink_ladscape_53876_91654;
            this.ClientSize = new System.Drawing.Size(715, 873);
            this.ControlBox = false;
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
    }
}

