namespace NumerosPrimos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCalcular = new Button();
            lstNum = new ListBox();
            numInicio = new NumericUpDown();
            numFin = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numInicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 54);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Inicio=>";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 92);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Fin=>";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(145, 7);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 2;
            label3.Text = "Rango";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(51, 150);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(115, 42);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Filtrar";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lstNum
            // 
            lstNum.Dock = DockStyle.Bottom;
            lstNum.FormattingEnabled = true;
            lstNum.Location = new Point(0, 226);
            lstNum.Name = "lstNum";
            lstNum.Size = new Size(404, 224);
            lstNum.TabIndex = 4;
            // 
            // numInicio
            // 
            numInicio.Location = new Point(135, 47);
            numInicio.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numInicio.Name = "numInicio";
            numInicio.Size = new Size(120, 27);
            numInicio.TabIndex = 7;
            // 
            // numFin
            // 
            numFin.Location = new Point(135, 85);
            numFin.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numFin.Name = "numFin";
            numFin.Size = new Size(120, 27);
            numFin.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 450);
            Controls.Add(numFin);
            Controls.Add(numInicio);
            Controls.Add(lstNum);
            Controls.Add(btnCalcular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numInicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCalcular;
        private ListBox lstNum;
        private NumericUpDown numInicio;
        private NumericUpDown numFin;
    }
}
