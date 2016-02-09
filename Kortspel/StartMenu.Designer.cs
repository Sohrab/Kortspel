namespace Kortspel
{
    partial class StartMenu
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
            this.btn1pl = new System.Windows.Forms.Button();
            this.btn2pl = new System.Windows.Forms.Button();
            this.btnInstr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1pl
            // 
            this.btn1pl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1pl.Location = new System.Drawing.Point(157, 114);
            this.btn1pl.Name = "btn1pl";
            this.btn1pl.Size = new System.Drawing.Size(111, 37);
            this.btn1pl.TabIndex = 0;
            this.btn1pl.Text = "1 Spelare";
            this.btn1pl.UseVisualStyleBackColor = true;
            this.btn1pl.Click += new System.EventHandler(this.btn1pl_Click);
            // 
            // btn2pl
            // 
            this.btn2pl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2pl.Location = new System.Drawing.Point(157, 157);
            this.btn2pl.Name = "btn2pl";
            this.btn2pl.Size = new System.Drawing.Size(111, 37);
            this.btn2pl.TabIndex = 1;
            this.btn2pl.Text = "2 Spelare";
            this.btn2pl.UseVisualStyleBackColor = true;
            this.btn2pl.Click += new System.EventHandler(this.btn2pl_Click);
            // 
            // btnInstr
            // 
            this.btnInstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstr.Location = new System.Drawing.Point(157, 200);
            this.btnInstr.Name = "btnInstr";
            this.btnInstr.Size = new System.Drawing.Size(111, 37);
            this.btnInstr.TabIndex = 2;
            this.btnInstr.Text = "Instruktioner";
            this.btnInstr.UseVisualStyleBackColor = true;
            this.btnInstr.Click += new System.EventHandler(this.btnInstr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "TjugoEtt";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(157, 243);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 37);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 337);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInstr);
            this.Controls.Add(this.btn2pl);
            this.Controls.Add(this.btn1pl);
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1pl;
        private System.Windows.Forms.Button btn2pl;
        private System.Windows.Forms.Button btnInstr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}