namespace ClientApi
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
            BtnFind = new Button();
            TxtNumInicial = new TextBox();
            TxtMax = new TextBox();
            TxtUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblResponse = new Label();
            BtnPersistence = new Button();
            groupBox1 = new GroupBox();
            dtgPersistence = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgPersistence).BeginInit();
            SuspendLayout();
            // 
            // BtnFind
            // 
            BtnFind.Location = new Point(112, 172);
            BtnFind.Name = "BtnFind";
            BtnFind.Size = new Size(75, 23);
            BtnFind.TabIndex = 0;
            BtnFind.Text = "Buscar";
            BtnFind.UseVisualStyleBackColor = true;
            BtnFind.Click += BtnFind_Click;
            // 
            // TxtNumInicial
            // 
            TxtNumInicial.Location = new Point(97, 41);
            TxtNumInicial.Name = "TxtNumInicial";
            TxtNumInicial.Size = new Size(90, 23);
            TxtNumInicial.TabIndex = 1;
            // 
            // TxtMax
            // 
            TxtMax.Location = new Point(97, 80);
            TxtMax.Name = "TxtMax";
            TxtMax.Size = new Size(90, 23);
            TxtMax.TabIndex = 2;
            // 
            // TxtUser
            // 
            TxtUser.Location = new Point(97, 122);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(146, 23);
            TxtUser.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 4;
            label1.Text = "Numero Inicial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 88);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 5;
            label2.Text = "Cantidad Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 130);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 6;
            label3.Text = "Usuario:";
            // 
            // lblResponse
            // 
            lblResponse.AutoSize = true;
            lblResponse.Location = new Point(6, 219);
            lblResponse.Name = "lblResponse";
            lblResponse.Size = new Size(0, 15);
            lblResponse.TabIndex = 7;
            // 
            // BtnPersistence
            // 
            BtnPersistence.Location = new Point(511, 23);
            BtnPersistence.Name = "BtnPersistence";
            BtnPersistence.Size = new Size(126, 32);
            BtnPersistence.TabIndex = 8;
            BtnPersistence.Text = "Ver Persistencia";
            BtnPersistence.UseVisualStyleBackColor = true;
            BtnPersistence.Click += BtnPersistence_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtNumInicial);
            groupBox1.Controls.Add(BtnFind);
            groupBox1.Controls.Add(lblResponse);
            groupBox1.Controls.Add(TxtMax);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtUser);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 269);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Numero Primos";
            // 
            // dtgPersistence
            // 
            dtgPersistence.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPersistence.Location = new Point(302, 61);
            dtgPersistence.Name = "dtgPersistence";
            dtgPersistence.RowTemplate.Height = 25;
            dtgPersistence.Size = new Size(611, 220);
            dtgPersistence.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 450);
            Controls.Add(dtgPersistence);
            Controls.Add(groupBox1);
            Controls.Add(BtnPersistence);
            Name = "Form1";
            Text = "Numero primos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgPersistence).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnFind;
        private TextBox TxtNumInicial;
        private TextBox TxtMax;
        private TextBox TxtUser;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResponse;
        private Button BtnPersistence;
        private GroupBox groupBox1;
        private DataGridView dtgPersistence;
    }
}