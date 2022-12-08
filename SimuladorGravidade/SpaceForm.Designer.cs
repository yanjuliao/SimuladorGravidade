namespace WindowsFormsApp1
{
    partial class SpaceForm
    {
        private System.ComponentModel.IContainer components = null;
        /// <param name="disposing"
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.volumeNumeric = new System.Windows.Forms.NumericUpDown();
            this.diameterLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.bNumeric = new System.Windows.Forms.NumericUpDown();
            this.gNumeric = new System.Windows.Forms.NumericUpDown();
            this.rNumeric = new System.Windows.Forms.NumericUpDown();
            this.bLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.gLabel = new System.Windows.Forms.Label();
            this.massLabel = new System.Windows.Forms.Label();
            this.rLabel = new System.Windows.Forms.Label();
            this.massNumeric = new System.Windows.Forms.NumericUpDown();
            this.Renew = new System.Windows.Forms.Timer(this.components);
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIteracao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQtdCorpos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volumeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // volumeNumeric
            // 
            this.volumeNumeric.Location = new System.Drawing.Point(0, 0);
            this.volumeNumeric.Name = "volumeNumeric";
            this.volumeNumeric.Size = new System.Drawing.Size(120, 23);
            this.volumeNumeric.TabIndex = 0;
            // 
            // diameterLabel
            // 
            this.diameterLabel.Location = new System.Drawing.Point(0, 0);
            this.diameterLabel.Name = "diameterLabel";
            this.diameterLabel.Size = new System.Drawing.Size(100, 23);
            this.diameterLabel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(0, 0);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(100, 50);
            this.colorBox.TabIndex = 0;
            this.colorBox.TabStop = false;
            // 
            // bNumeric
            // 
            this.bNumeric.Location = new System.Drawing.Point(0, 0);
            this.bNumeric.Name = "bNumeric";
            this.bNumeric.Size = new System.Drawing.Size(120, 23);
            this.bNumeric.TabIndex = 0;
            // 
            // gNumeric
            // 
            this.gNumeric.Location = new System.Drawing.Point(0, 0);
            this.gNumeric.Name = "gNumeric";
            this.gNumeric.Size = new System.Drawing.Size(120, 23);
            this.gNumeric.TabIndex = 0;
            // 
            // rNumeric
            // 
            this.rNumeric.Location = new System.Drawing.Point(0, 0);
            this.rNumeric.Name = "rNumeric";
            this.rNumeric.Size = new System.Drawing.Size(120, 23);
            this.rNumeric.TabIndex = 0;
            // 
            // bLabel
            // 
            this.bLabel.Location = new System.Drawing.Point(0, 0);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(100, 23);
            this.bLabel.TabIndex = 0;
            // 
            // colorLabel
            // 
            this.colorLabel.Location = new System.Drawing.Point(0, 0);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(100, 23);
            this.colorLabel.TabIndex = 0;
            // 
            // gLabel
            // 
            this.gLabel.Location = new System.Drawing.Point(0, 0);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(100, 23);
            this.gLabel.TabIndex = 0;
            // 
            // massLabel
            // 
            this.massLabel.Location = new System.Drawing.Point(0, 0);
            this.massLabel.Name = "massLabel";
            this.massLabel.Size = new System.Drawing.Size(100, 23);
            this.massLabel.TabIndex = 0;
            // 
            // rLabel
            // 
            this.rLabel.Location = new System.Drawing.Point(0, 0);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(100, 23);
            this.rLabel.TabIndex = 0;
            // 
            // massNumeric
            // 
            this.massNumeric.Location = new System.Drawing.Point(0, 0);
            this.massNumeric.Name = "massNumeric";
            this.massNumeric.Size = new System.Drawing.Size(120, 23);
            this.massNumeric.TabIndex = 0;
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBemVindo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBemVindo.Location = new System.Drawing.Point(731, 22);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(245, 32);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "Bem Vindo ao Espaço";
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(798, 57);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(83, 23);
            this.BtnIniciar.TabIndex = 2;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnIniciar_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Iteração:";
            // 
            // lblIteracao
            // 
            this.lblIteracao.AutoSize = true;
            this.lblIteracao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIteracao.Location = new System.Drawing.Point(74, 22);
            this.lblIteracao.Name = "lblIteracao";
            this.lblIteracao.Size = new System.Drawing.Size(0, 15);
            this.lblIteracao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantidade de corpos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(144, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 6;
            // 
            // lblQtdCorpos
            // 
            this.lblQtdCorpos.AutoSize = true;
            this.lblQtdCorpos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQtdCorpos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQtdCorpos.Location = new System.Drawing.Point(144, 39);
            this.lblQtdCorpos.Name = "lblQtdCorpos";
            this.lblQtdCorpos.Size = new System.Drawing.Size(0, 15);
            this.lblQtdCorpos.TabIndex = 7;
            // 
            // SpaceForm
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.lblQtdCorpos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIteracao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.lblBemVindo);
            this.Name = "SpaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SpaceForm_Paint_1);
            ((System.ComponentModel.ISupportInitialize)(this.volumeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown volumeNumeric;
        private System.Windows.Forms.Label diameterLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label massLabel;
        private System.Windows.Forms.NumericUpDown massNumeric;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.NumericUpDown bNumeric;
        private System.Windows.Forms.NumericUpDown gNumeric;
        private System.Windows.Forms.NumericUpDown rNumeric;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.Timer Renew;
        private Label lblBemVindo;
        private Button BtnIniciar;
        private Label label1;
        private Label lblIteracao;
        private Label label2;
        private Label label3;
        private Label lblQtdCorpos;
    }
}

