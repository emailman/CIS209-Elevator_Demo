namespace CIS209_Elevator_Demo
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
            this.btn5 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.lblFloorCalled = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(13, 13);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "Floor 5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnFloor_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 129);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Floor 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnFloor_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(12, 100);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Floor 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnFloor_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(13, 71);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "Floor 3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnFloor_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(13, 42);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "Floor 4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnFloor_Click);
            // 
            // lblFloorCalled
            // 
            this.lblFloorCalled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFloorCalled.Location = new System.Drawing.Point(13, 159);
            this.lblFloorCalled.Name = "lblFloorCalled";
            this.lblFloorCalled.Size = new System.Drawing.Size(112, 23);
            this.lblFloorCalled.TabIndex = 5;
            this.lblFloorCalled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 192);
            this.Controls.Add(this.lblFloorCalled);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn5);
            this.Name = "Form1";
            this.Text = "Elevator Buttons";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Label lblFloorCalled;
    }
}

