
namespace MouseClick
{
    partial class frm_Clickity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Clickity));
            this.pnl_Point = new System.Windows.Forms.Panel();
            this.lbl_Point = new System.Windows.Forms.Label();
            this.lbl_Click = new System.Windows.Forms.Label();
            this.num_Click = new System.Windows.Forms.NumericUpDown();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Startauto = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_SetPoint = new System.Windows.Forms.Button();
            this.lbl_PointPosition = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lbl_Progress = new System.Windows.Forms.Label();
            this.pnl_Point.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Click)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Point
            // 
            this.pnl_Point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Point.Controls.Add(this.lbl_Point);
            this.pnl_Point.Location = new System.Drawing.Point(12, 12);
            this.pnl_Point.Name = "pnl_Point";
            this.pnl_Point.Size = new System.Drawing.Size(99, 97);
            this.pnl_Point.TabIndex = 0;
            // 
            // lbl_Point
            // 
            this.lbl_Point.AutoSize = true;
            this.lbl_Point.Location = new System.Drawing.Point(40, 37);
            this.lbl_Point.Name = "lbl_Point";
            this.lbl_Point.Size = new System.Drawing.Size(14, 17);
            this.lbl_Point.TabIndex = 7;
            this.lbl_Point.Text = "x";
            // 
            // lbl_Click
            // 
            this.lbl_Click.AutoSize = true;
            this.lbl_Click.Location = new System.Drawing.Point(130, 18);
            this.lbl_Click.Name = "lbl_Click";
            this.lbl_Click.Size = new System.Drawing.Size(112, 17);
            this.lbl_Click.TabIndex = 1;
            this.lbl_Click.Text = "Number of clicks";
            // 
            // num_Click
            // 
            this.num_Click.Location = new System.Drawing.Point(249, 18);
            this.num_Click.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.num_Click.Name = "num_Click";
            this.num_Click.Size = new System.Drawing.Size(120, 22);
            this.num_Click.TabIndex = 2;
            this.num_Click.ValueChanged += new System.EventHandler(this.num_Click_ValueChanged);
            this.num_Click.KeyUp += new System.Windows.Forms.KeyEventHandler(this.num_Click_KeyUp);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(133, 50);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(109, 31);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "Start Click";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Startauto
            // 
            this.btn_Startauto.Location = new System.Drawing.Point(248, 50);
            this.btn_Startauto.Name = "btn_Startauto";
            this.btn_Startauto.Size = new System.Drawing.Size(121, 31);
            this.btn_Startauto.TabIndex = 4;
            this.btn_Startauto.Text = "Start Autoclick";
            this.btn_Startauto.UseVisualStyleBackColor = true;
            this.btn_Startauto.Click += new System.EventHandler(this.btn_Startauto_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(133, 84);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(236, 29);
            this.btn_Stop.TabIndex = 5;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_SetPoint
            // 
            this.btn_SetPoint.Location = new System.Drawing.Point(12, 138);
            this.btn_SetPoint.Name = "btn_SetPoint";
            this.btn_SetPoint.Size = new System.Drawing.Size(99, 30);
            this.btn_SetPoint.TabIndex = 6;
            this.btn_SetPoint.Text = "Set Point";
            this.btn_SetPoint.UseVisualStyleBackColor = true;
            this.btn_SetPoint.Click += new System.EventHandler(this.btn_SetPoint_Click);
            // 
            // lbl_PointPosition
            // 
            this.lbl_PointPosition.AutoSize = true;
            this.lbl_PointPosition.Location = new System.Drawing.Point(12, 116);
            this.lbl_PointPosition.Name = "lbl_PointPosition";
            this.lbl_PointPosition.Size = new System.Drawing.Size(32, 17);
            this.lbl_PointPosition.TabIndex = 7;
            this.lbl_PointPosition.Text = "0, 0";
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.LightCoral;
            this.progressBar.Location = new System.Drawing.Point(133, 129);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(192, 32);
            this.progressBar.TabIndex = 8;
            // 
            // lbl_Progress
            // 
            this.lbl_Progress.AutoSize = true;
            this.lbl_Progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Progress.Location = new System.Drawing.Point(331, 135);
            this.lbl_Progress.Name = "lbl_Progress";
            this.lbl_Progress.Size = new System.Drawing.Size(21, 18);
            this.lbl_Progress.TabIndex = 9;
            this.lbl_Progress.Text = "%";
            // 
            // frm_Clickity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 178);
            this.Controls.Add(this.lbl_Progress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lbl_PointPosition);
            this.Controls.Add(this.btn_SetPoint);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Startauto);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.num_Click);
            this.Controls.Add(this.lbl_Click);
            this.Controls.Add(this.pnl_Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Clickity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angry Click";
            this.Load += new System.EventHandler(this.frm_Clickity_Load);
            this.pnl_Point.ResumeLayout(false);
            this.pnl_Point.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Click)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Point;
        private System.Windows.Forms.Label lbl_Click;
        private System.Windows.Forms.NumericUpDown num_Click;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Startauto;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_SetPoint;
        private System.Windows.Forms.Label lbl_Point;
        private System.Windows.Forms.Label lbl_PointPosition;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lbl_Progress;
    }
}

