
namespace QuickQuiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_result = new System.Windows.Forms.Label();
            this.button_last = new System.Windows.Forms.Button();
            this.radioButton_answer3 = new System.Windows.Forms.RadioButton();
            this.radioButton_answer2 = new System.Windows.Forms.RadioButton();
            this.label_question1 = new System.Windows.Forms.Label();
            this.radioButton_answer1 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label_result, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.button_last, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_answer3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_answer2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_question1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_answer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 571);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_result
            // 
            this.label_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_result.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_result.Location = new System.Drawing.Point(3, 486);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(613, 85);
            this.label_result.TabIndex = 6;
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_last
            // 
            this.button_last.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_last.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_last.Location = new System.Drawing.Point(30, 420);
            this.button_last.Margin = new System.Windows.Forms.Padding(30, 15, 30, 0);
            this.button_last.Name = "button_last";
            this.button_last.Size = new System.Drawing.Size(559, 66);
            this.button_last.TabIndex = 5;
            this.button_last.Text = "Previous";
            this.button_last.UseVisualStyleBackColor = true;
            this.button_last.Click += new System.EventHandler(this.button_last_Click);
            // 
            // radioButton_answer3
            // 
            this.radioButton_answer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_answer3.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_answer3.Location = new System.Drawing.Point(3, 246);
            this.radioButton_answer3.Name = "radioButton_answer3";
            this.radioButton_answer3.Size = new System.Drawing.Size(613, 75);
            this.radioButton_answer3.TabIndex = 3;
            this.radioButton_answer3.TabStop = true;
            this.radioButton_answer3.Tag = "2";
            this.radioButton_answer3.Text = "Ответ3";
            this.radioButton_answer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_answer3.UseVisualStyleBackColor = true;
            this.radioButton_answer3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton_answer1_MouseClick);
            // 
            // radioButton_answer2
            // 
            this.radioButton_answer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_answer2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_answer2.Location = new System.Drawing.Point(3, 165);
            this.radioButton_answer2.Name = "radioButton_answer2";
            this.radioButton_answer2.Size = new System.Drawing.Size(613, 75);
            this.radioButton_answer2.TabIndex = 2;
            this.radioButton_answer2.TabStop = true;
            this.radioButton_answer2.Tag = "1";
            this.radioButton_answer2.Text = "Ответ2";
            this.radioButton_answer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_answer2.UseVisualStyleBackColor = true;
            this.radioButton_answer2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton_answer1_MouseClick);
            // 
            // label_question1
            // 
            this.label_question1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_question1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_question1.Location = new System.Drawing.Point(3, 0);
            this.label_question1.Name = "label_question1";
            this.label_question1.Size = new System.Drawing.Size(613, 81);
            this.label_question1.TabIndex = 0;
            this.label_question1.Text = "Вопрос";
            this.label_question1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton_answer1
            // 
            this.radioButton_answer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_answer1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_answer1.Location = new System.Drawing.Point(3, 84);
            this.radioButton_answer1.Name = "radioButton_answer1";
            this.radioButton_answer1.Size = new System.Drawing.Size(613, 75);
            this.radioButton_answer1.TabIndex = 1;
            this.radioButton_answer1.TabStop = true;
            this.radioButton_answer1.Tag = "0";
            this.radioButton_answer1.Text = "Ответ1";
            this.radioButton_answer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_answer1.UseVisualStyleBackColor = true;
            this.radioButton_answer1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton_answer1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 571);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Тест";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.RadioButton radioButton_answer3;
        private System.Windows.Forms.RadioButton radioButton_answer2;
        private System.Windows.Forms.Label label_question1;
        private System.Windows.Forms.RadioButton radioButton_answer1;
        private System.Windows.Forms.Label label_result;
    }
}

