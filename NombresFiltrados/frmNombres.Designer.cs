namespace NombresFiltrados
{
    partial class frmNombres
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
            btnAdd = new Button();
            btnFiltrar = new Button();
            label1 = new Label();
            txtNames = new TextBox();
            lstNombres = new ListBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(143, 168);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 35);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(343, 167);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 36);
            btnFiltrar.TabIndex = 1;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 79);
            label1.Name = "label1";
            label1.Size = new Size(226, 30);
            label1.TabIndex = 2;
            label1.Text = "Ingrese los nombres:";
            // 
            // txtNames
            // 
            txtNames.Location = new Point(309, 83);
            txtNames.Name = "txtNames";
            txtNames.Size = new Size(147, 27);
            txtNames.TabIndex = 3;
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(57, 244);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(399, 124);
            lstNombres.TabIndex = 4;
            // 
            // frmNombres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 450);
            Controls.Add(lstNombres);
            Controls.Add(txtNames);
            Controls.Add(label1);
            Controls.Add(btnFiltrar);
            Controls.Add(btnAdd);
            Name = "frmNombres";
            Text = "frmNombres";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnFiltrar;
        private Label label1;
        private TextBox txtNames;
        private ListBox lstNombres;
    }
}