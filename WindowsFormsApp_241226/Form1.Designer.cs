
namespace calculating_machine
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_prevalue = new System.Windows.Forms.TextBox();
            this.textBox_presentvalue = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_float = new System.Windows.Forms.Button();
            this.button_number0 = new System.Windows.Forms.Button();
            this.button_covertsign = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_number3 = new System.Windows.Forms.Button();
            this.button_number2 = new System.Windows.Forms.Button();
            this.button_number1 = new System.Windows.Forms.Button();
            this.button_subtract = new System.Windows.Forms.Button();
            this.button_number6 = new System.Windows.Forms.Button();
            this.button_number5 = new System.Windows.Forms.Button();
            this.button_number4 = new System.Windows.Forms.Button();
            this.button_multiple = new System.Windows.Forms.Button();
            this.button_number9 = new System.Windows.Forms.Button();
            this.button_number8 = new System.Windows.Forms.Button();
            this.button_number7 = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_squareroot = new System.Windows.Forms.Button();
            this.button_spuare = new System.Windows.Forms.Button();
            this.button_invert = new System.Windows.Forms.Button();
            this.button_backspace = new System.Windows.Forms.Button();
            this.button_c = new System.Windows.Forms.Button();
            this.button_ce = new System.Windows.Forms.Button();
            this.button_percent = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_prevalue
            // 
            this.textBox_prevalue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_prevalue.Location = new System.Drawing.Point(11, 30);
            this.textBox_prevalue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_prevalue.Multiline = true;
            this.textBox_prevalue.Name = "textBox_prevalue";
            this.textBox_prevalue.ReadOnly = true;
            this.textBox_prevalue.Size = new System.Drawing.Size(330, 29);
            this.textBox_prevalue.TabIndex = 0;
            // 
            // textBox_presentvalue
            // 
            this.textBox_presentvalue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_presentvalue.Location = new System.Drawing.Point(10, 62);
            this.textBox_presentvalue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_presentvalue.Multiline = true;
            this.textBox_presentvalue.Name = "textBox_presentvalue";
            this.textBox_presentvalue.ReadOnly = true;
            this.textBox_presentvalue.Size = new System.Drawing.Size(330, 46);
            this.textBox_presentvalue.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button_equal, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_float, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_number0, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_covertsign, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_add, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_number3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_number2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_number1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_subtract, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_number6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_number5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_number4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_multiple, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_number9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_number8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_number7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_divide, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_squareroot, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_spuare, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_invert, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_backspace, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_c, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_ce, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_percent, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 113);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 286);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button_equal
            // 
            this.button_equal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_equal.Location = new System.Drawing.Point(249, 237);
            this.button_equal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(77, 42);
            this.button_equal.TabIndex = 23;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = false;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // button_float
            // 
            this.button_float.Location = new System.Drawing.Point(167, 237);
            this.button_float.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_float.Name = "button_float";
            this.button_float.Size = new System.Drawing.Size(76, 42);
            this.button_float.TabIndex = 22;
            this.button_float.Text = ".";
            this.button_float.UseVisualStyleBackColor = true;
          //  this.button_float.Click += new System.EventHandler(this.button_float_Click);
            // 
            // button_number0
            // 
            this.button_number0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_number0.Location = new System.Drawing.Point(85, 237);
            this.button_number0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number0.Name = "button_number0";
            this.button_number0.Size = new System.Drawing.Size(76, 42);
            this.button_number0.TabIndex = 21;
            this.button_number0.Text = "0";
            this.button_number0.UseVisualStyleBackColor = false;
            this.button_number0.Click += new System.EventHandler(this.button_number0_Click);
            // 
            // button_covertsign
            // 
            this.button_covertsign.Location = new System.Drawing.Point(3, 237);
            this.button_covertsign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_covertsign.Name = "button_covertsign";
            this.button_covertsign.Size = new System.Drawing.Size(76, 42);
            this.button_covertsign.TabIndex = 20;
            this.button_covertsign.Text = "+/-";
            this.button_covertsign.UseVisualStyleBackColor = true;
           // this.button_covertsign.Click += new System.EventHandler(this.button_covertsign_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(249, 190);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(77, 42);
            this.button_add.TabIndex = 19;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_number3
            // 
            this.button_number3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_number3.Location = new System.Drawing.Point(167, 190);
            this.button_number3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number3.Name = "button_number3";
            this.button_number3.Size = new System.Drawing.Size(76, 42);
            this.button_number3.TabIndex = 18;
            this.button_number3.Text = "3";
            this.button_number3.UseVisualStyleBackColor = false;
            this.button_number3.Click += new System.EventHandler(this.button_number3_Click);
            // 
            // button_number2
            // 
            this.button_number2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_number2.Location = new System.Drawing.Point(85, 190);
            this.button_number2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number2.Name = "button_number2";
            this.button_number2.Size = new System.Drawing.Size(76, 42);
            this.button_number2.TabIndex = 17;
            this.button_number2.Text = "2";
            this.button_number2.UseVisualStyleBackColor = false;
            this.button_number2.Click += new System.EventHandler(this.button_number2_Click);
            // 
            // button_number1
            // 
            this.button_number1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_number1.Location = new System.Drawing.Point(3, 190);
            this.button_number1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number1.Name = "button_number1";
            this.button_number1.Size = new System.Drawing.Size(76, 42);
            this.button_number1.TabIndex = 16;
            this.button_number1.Text = "1";
            this.button_number1.UseVisualStyleBackColor = false;
            this.button_number1.Click += new System.EventHandler(this.button_number1_Click);
            // 
            // button_subtract
            // 
            this.button_subtract.Location = new System.Drawing.Point(249, 143);
            this.button_subtract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_subtract.Name = "button_subtract";
            this.button_subtract.Size = new System.Drawing.Size(77, 42);
            this.button_subtract.TabIndex = 15;
            this.button_subtract.Text = "-";
            this.button_subtract.UseVisualStyleBackColor = true;
            this.button_subtract.Click += new System.EventHandler(this.button_subtract_Click);
            // 
            // button_number6
            // 
            this.button_number6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_number6.Location = new System.Drawing.Point(167, 143);
            this.button_number6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number6.Name = "button_number6";
            this.button_number6.Size = new System.Drawing.Size(76, 42);
            this.button_number6.TabIndex = 14;
            this.button_number6.Text = "6";
            this.button_number6.UseVisualStyleBackColor = false;
            this.button_number6.Click += new System.EventHandler(this.button_number6_Click);
            // 
            // button_number5
            // 
            this.button_number5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_number5.Location = new System.Drawing.Point(85, 143);
            this.button_number5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number5.Name = "button_number5";
            this.button_number5.Size = new System.Drawing.Size(76, 42);
            this.button_number5.TabIndex = 13;
            this.button_number5.Text = "5";
            this.button_number5.UseVisualStyleBackColor = false;
            this.button_number5.Click += new System.EventHandler(this.button_number5_Click);
            // 
            // button_number4
            // 
            this.button_number4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_number4.Location = new System.Drawing.Point(3, 143);
            this.button_number4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number4.Name = "button_number4";
            this.button_number4.Size = new System.Drawing.Size(76, 42);
            this.button_number4.TabIndex = 12;
            this.button_number4.Text = "4";
            this.button_number4.UseVisualStyleBackColor = false;
            this.button_number4.Click += new System.EventHandler(this.button_number4_Click);
            // 
            // button_multiple
            // 
            this.button_multiple.Location = new System.Drawing.Point(249, 96);
            this.button_multiple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_multiple.Name = "button_multiple";
            this.button_multiple.Size = new System.Drawing.Size(77, 42);
            this.button_multiple.TabIndex = 11;
            this.button_multiple.Text = "×";
            this.button_multiple.UseVisualStyleBackColor = true;
            this.button_multiple.Click += new System.EventHandler(this.button_multiple_Click);
            // 
            // button_number9
            // 
            this.button_number9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_number9.Location = new System.Drawing.Point(167, 96);
            this.button_number9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number9.Name = "button_number9";
            this.button_number9.Size = new System.Drawing.Size(76, 42);
            this.button_number9.TabIndex = 10;
            this.button_number9.Text = "9";
            this.button_number9.UseVisualStyleBackColor = false;
            this.button_number9.Click += new System.EventHandler(this.button_number9_Click);
            // 
            // button_number8
            // 
            this.button_number8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_number8.Location = new System.Drawing.Point(85, 96);
            this.button_number8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number8.Name = "button_number8";
            this.button_number8.Size = new System.Drawing.Size(76, 42);
            this.button_number8.TabIndex = 9;
            this.button_number8.Text = "8";
            this.button_number8.UseVisualStyleBackColor = false;
            this.button_number8.Click += new System.EventHandler(this.button_number8_Click);
            // 
            // button_number7
            // 
            this.button_number7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_number7.Location = new System.Drawing.Point(3, 96);
            this.button_number7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number7.Name = "button_number7";
            this.button_number7.Size = new System.Drawing.Size(76, 42);
            this.button_number7.TabIndex = 8;
            this.button_number7.Text = "7";
            this.button_number7.UseVisualStyleBackColor = false;
            this.button_number7.Click += new System.EventHandler(this.button_number7_Click);
            // 
            // button_divide
            // 
            this.button_divide.Location = new System.Drawing.Point(249, 49);
            this.button_divide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(77, 42);
            this.button_divide.TabIndex = 7;
            this.button_divide.Text = "÷";
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // button_squareroot
            // 
            this.button_squareroot.Location = new System.Drawing.Point(167, 49);
            this.button_squareroot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_squareroot.Name = "button_squareroot";
            this.button_squareroot.Size = new System.Drawing.Size(76, 42);
            this.button_squareroot.TabIndex = 6;
            this.button_squareroot.Text = "√x";
            this.button_squareroot.UseVisualStyleBackColor = true;
          //  this.button_squareroot.Click += new System.EventHandler(this.button_squareroot_Click);
            // 
            // button_spuare
            // 
            this.button_spuare.Location = new System.Drawing.Point(85, 49);
            this.button_spuare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_spuare.Name = "button_spuare";
            this.button_spuare.Size = new System.Drawing.Size(76, 42);
            this.button_spuare.TabIndex = 5;
            this.button_spuare.Text = "x²";
            this.button_spuare.UseVisualStyleBackColor = true;
          //  this.button_spuare.Click += new System.EventHandler(this.button_spuare_Click);
            // 
            // button_invert
            // 
            this.button_invert.Location = new System.Drawing.Point(3, 49);
            this.button_invert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_invert.Name = "button_invert";
            this.button_invert.Size = new System.Drawing.Size(76, 42);
            this.button_invert.TabIndex = 4;
            this.button_invert.Text = "1/x";
            this.button_invert.UseVisualStyleBackColor = true;
          //  this.button_invert.Click += new System.EventHandler(this.button_invert_Click);
            // 
            // button_backspace
            // 
            this.button_backspace.Location = new System.Drawing.Point(249, 2);
            this.button_backspace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_backspace.Name = "button_backspace";
            this.button_backspace.Size = new System.Drawing.Size(77, 42);
            this.button_backspace.TabIndex = 3;
            this.button_backspace.Text = "←";
            this.button_backspace.UseVisualStyleBackColor = true;
            this.button_backspace.Click += new System.EventHandler(this.button_backspace_Click);
            // 
            // button_c
            // 
            this.button_c.Location = new System.Drawing.Point(167, 2);
            this.button_c.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_c.Name = "button_c";
            this.button_c.Size = new System.Drawing.Size(76, 42);
            this.button_c.TabIndex = 2;
            this.button_c.Text = "C";
            this.button_c.UseVisualStyleBackColor = true;
            this.button_c.Click += new System.EventHandler(this.button_c_Click);
            // 
            // button_ce
            // 
            this.button_ce.Location = new System.Drawing.Point(85, 2);
            this.button_ce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ce.Name = "button_ce";
            this.button_ce.Size = new System.Drawing.Size(76, 42);
            this.button_ce.TabIndex = 1;
            this.button_ce.Text = "CE";
            this.button_ce.UseVisualStyleBackColor = true;
            this.button_ce.Click += new System.EventHandler(this.button_ce_Click);
            // 
            // button_percent
            // 
            this.button_percent.Location = new System.Drawing.Point(3, 2);
            this.button_percent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_percent.Name = "button_percent";
            this.button_percent.Size = new System.Drawing.Size(76, 42);
            this.button_percent.TabIndex = 0;
            this.button_percent.Text = "%";
            this.button_percent.UseVisualStyleBackColor = true;
           // this.button_percent.Click += new System.EventHandler(this.button_percent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 409);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox_presentvalue);
            this.Controls.Add(this.textBox_prevalue);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "y7";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_prevalue;
        private System.Windows.Forms.TextBox textBox_presentvalue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_float;
        private System.Windows.Forms.Button button_number0;
        private System.Windows.Forms.Button button_covertsign;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_number3;
        private System.Windows.Forms.Button button_number2;
        private System.Windows.Forms.Button button_number1;
        private System.Windows.Forms.Button button_subtract;
        private System.Windows.Forms.Button button_number6;
        private System.Windows.Forms.Button button_number5;
        private System.Windows.Forms.Button button_number4;
        private System.Windows.Forms.Button button_multiple;
        private System.Windows.Forms.Button button_number9;
        private System.Windows.Forms.Button button_number8;
        private System.Windows.Forms.Button button_number7;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_squareroot;
        private System.Windows.Forms.Button button_spuare;
        private System.Windows.Forms.Button button_invert;
        private System.Windows.Forms.Button button_backspace;
        private System.Windows.Forms.Button button_c;
        private System.Windows.Forms.Button button_ce;
        private System.Windows.Forms.Button button_percent;
    }
}

