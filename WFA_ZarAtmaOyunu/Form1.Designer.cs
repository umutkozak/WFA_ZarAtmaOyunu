namespace WFA_ZarAtmaOyunu
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
            components=new System.ComponentModel.Container();
            lblZar1=new Label();
            lblZar2=new Label();
            btnZarAt=new Button();
            timer1=new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblZar1
            // 
            lblZar1.BorderStyle=BorderStyle.Fixed3D;
            lblZar1.Font=new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblZar1.Location=new Point(72, 20);
            lblZar1.Name="lblZar1";
            lblZar1.Size=new Size(62, 90);
            lblZar1.TabIndex=0;
            // 
            // lblZar2
            // 
            lblZar2.BorderStyle=BorderStyle.Fixed3D;
            lblZar2.Font=new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblZar2.Location=new Point(140, 20);
            lblZar2.Name="lblZar2";
            lblZar2.Size=new Size(62, 90);
            lblZar2.TabIndex=1;
            // 
            // btnZarAt
            // 
            btnZarAt.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnZarAt.Location=new Point(73, 124);
            btnZarAt.Name="btnZarAt";
            btnZarAt.Size=new Size(129, 29);
            btnZarAt.TabIndex=2;
            btnZarAt.Text="Zar At";
            btnZarAt.UseVisualStyleBackColor=true;
            btnZarAt.Click+=btnZarAt_Click;
            // 
            // timer1
            // 
            timer1.Tick+=timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(285, 197);
            Controls.Add(btnZarAt);
            Controls.Add(lblZar2);
            Controls.Add(lblZar1);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label lblZar1;
        private Label lblZar2;
        private Button btnZarAt;
        private System.Windows.Forms.Timer timer1;
    }
}