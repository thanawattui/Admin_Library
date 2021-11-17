
namespace adminlibrary
{
    partial class Welcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            this.btn_teacher = new System.Windows.Forms.Button();
            this.btn_borrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome admin";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_Back.Location = new System.Drawing.Point(607, 390);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(181, 48);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_student
            // 
            this.btn_student.Location = new System.Drawing.Point(33, 165);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(141, 41);
            this.btn_student.TabIndex = 3;
            this.btn_student.Text = "student";
            this.btn_student.UseVisualStyleBackColor = true;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // btn_teacher
            // 
            this.btn_teacher.Location = new System.Drawing.Point(212, 165);
            this.btn_teacher.Name = "btn_teacher";
            this.btn_teacher.Size = new System.Drawing.Size(141, 40);
            this.btn_teacher.TabIndex = 4;
            this.btn_teacher.Text = "teacher";
            this.btn_teacher.UseVisualStyleBackColor = true;
            this.btn_teacher.Click += new System.EventHandler(this.btn_teacher_Click);
            // 
            // btn_borrow
            // 
            this.btn_borrow.Location = new System.Drawing.Point(404, 165);
            this.btn_borrow.Name = "btn_borrow";
            this.btn_borrow.Size = new System.Drawing.Size(141, 40);
            this.btn_borrow.TabIndex = 4;
            this.btn_borrow.Text = "borrow";
            this.btn_borrow.UseVisualStyleBackColor = true;
            this.btn_borrow.Click += new System.EventHandler(this.btn_borrow_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_borrow);
            this.Controls.Add(this.btn_teacher);
            this.Controls.Add(this.btn_student);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label1);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Button btn_teacher;
        private System.Windows.Forms.Button btn_borrow;
    }
}