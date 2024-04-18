namespace FactorialNumeros
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
            txtNums = new TextBox();
            btnAdd = new Button();
            btnFactoriales = new Button();
            lstFactoriales = new ListBox();
            lstNums = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 41);
            label1.Name = "label1";
            label1.Size = new Size(204, 27);
            label1.TabIndex = 0;
            label1.Text = "Ingrese los números:";
            // 
            // txtNums
            // 
            txtNums.Location = new Point(202, 41);
            txtNums.Name = "txtNums";
            txtNums.Size = new Size(100, 27);
            txtNums.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(56, 98);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 31);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnFactoriales
            // 
            btnFactoriales.Location = new Point(165, 98);
            btnFactoriales.Name = "btnFactoriales";
            btnFactoriales.Size = new Size(184, 31);
            btnFactoriales.TabIndex = 3;
            btnFactoriales.Text = "Mostrar Factoriales";
            btnFactoriales.UseVisualStyleBackColor = true;
            btnFactoriales.Click += btnFactoriales_Click;
            // 
            // lstFactoriales
            // 
            lstFactoriales.Dock = DockStyle.Bottom;
            lstFactoriales.FormattingEnabled = true;
            lstFactoriales.Location = new Point(0, 279);
            lstFactoriales.Name = "lstFactoriales";
            lstFactoriales.Size = new Size(545, 84);
            lstFactoriales.TabIndex = 4;
            // 
            // lstNums
            // 
            lstNums.Dock = DockStyle.Bottom;
            lstNums.FormattingEnabled = true;
            lstNums.Location = new Point(0, 195);
            lstNums.Name = "lstNums";
            lstNums.Size = new Size(545, 84);
            lstNums.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 363);
            Controls.Add(lstNums);
            Controls.Add(lstFactoriales);
            Controls.Add(btnFactoriales);
            Controls.Add(btnAdd);
            Controls.Add(txtNums);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNums;
        private Button btnAdd;
        private Button btnFactoriales;
        private ListBox lstFactoriales;
        private ListBox lstNums;
    }
}
