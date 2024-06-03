namespace Projekt_8
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonGeneruj = new System.Windows.Forms.Button();
            this.buttonOblicz = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(29, 21);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(127, 46);
            this.buttonZapisz.TabIndex = 0;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // buttonGeneruj
            // 
            this.buttonGeneruj.Location = new System.Drawing.Point(162, 21);
            this.buttonGeneruj.Name = "buttonGeneruj";
            this.buttonGeneruj.Size = new System.Drawing.Size(127, 46);
            this.buttonGeneruj.TabIndex = 1;
            this.buttonGeneruj.Text = "Generuj";
            this.buttonGeneruj.UseVisualStyleBackColor = true;
            this.buttonGeneruj.Click += new System.EventHandler(this.buttonGeneruj_Click);
            // 
            // buttonOblicz
            // 
            this.buttonOblicz.Location = new System.Drawing.Point(295, 21);
            this.buttonOblicz.Name = "buttonOblicz";
            this.buttonOblicz.Size = new System.Drawing.Size(127, 46);
            this.buttonOblicz.TabIndex = 2;
            this.buttonOblicz.Text = "Oblicz";
            this.buttonOblicz.UseVisualStyleBackColor = true;
            this.buttonOblicz.Click += new System.EventHandler(this.buttonOblicz_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 84);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(350, 56);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(135, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(309, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(554, 256);
            this.dataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(595, 466);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.buttonOblicz);
            this.Controls.Add(this.buttonGeneruj);
            this.Controls.Add(this.buttonZapisz);
            this.Name = "Form1";
            this.Text = "My Windows Forms App";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonGeneruj;
        private System.Windows.Forms.Button buttonOblicz;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        #endregion
    }
}