namespace SvoyaIgraOpenVersion
{
    partial class Form200
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdQuestion,
            this.QuestionText,
            this.Answer,
            this.QuestionPoint,
            this.QuestionCategory});
            this.dataGridView1.Location = new System.Drawing.Point(13, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 556);
            this.dataGridView1.TabIndex = 0;
            // 
            // IdQuestion
            // 
            this.IdQuestion.HeaderText = "IdQuestion";
            this.IdQuestion.Name = "IdQuestion";
            this.IdQuestion.ReadOnly = true;
            // 
            // QuestionText
            // 
            this.QuestionText.HeaderText = "QuestionText";
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.ReadOnly = true;
            // 
            // Answer
            // 
            this.Answer.HeaderText = "Answer";
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            // 
            // QuestionPoint
            // 
            this.QuestionPoint.HeaderText = "QuestionPoint";
            this.QuestionPoint.Name = "QuestionPoint";
            this.QuestionPoint.ReadOnly = true;
            // 
            // QuestionCategory
            // 
            this.QuestionCategory.HeaderText = "QuestionCategory";
            this.QuestionCategory.Name = "QuestionCategory";
            this.QuestionCategory.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 30);
            this.button1.TabIndex = 104;
            this.button1.Text = "Экспорт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form200
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 615);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form200";
            this.Text = "Form200";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form200_FormClosing);
            this.Load += new System.EventHandler(this.Form200_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionCategory;
        private System.Windows.Forms.Button button1;
    }
}