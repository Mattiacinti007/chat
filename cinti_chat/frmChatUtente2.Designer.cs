namespace cinti_chat
{
    partial class frmChatUtente2
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
            btnInvia = new Button();
            txtMessaggio = new TextBox();
            btnLogin = new Button();
            txtNomeUtente = new TextBox();
            lblNome = new Label();
            SuspendLayout();
            // 
            // btnInvia
            // 
            btnInvia.Location = new Point(685, 409);
            btnInvia.Name = "btnInvia";
            btnInvia.Size = new Size(103, 29);
            btnInvia.TabIndex = 3;
            btnInvia.Text = "Invia";
            btnInvia.UseVisualStyleBackColor = true;
            btnInvia.Click += btnInvia_Click;
            // 
            // txtMessaggio
            // 
            txtMessaggio.Location = new Point(12, 411);
            txtMessaggio.Name = "txtMessaggio";
            txtMessaggio.Size = new Size(667, 27);
            txtMessaggio.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(149, 53);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(103, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtNomeUtente
            // 
            txtNomeUtente.Location = new Point(27, 53);
            txtNomeUtente.Name = "txtNomeUtente";
            txtNomeUtente.Size = new Size(116, 27);
            txtNomeUtente.TabIndex = 4;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(27, 30);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(99, 20);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome utente:";
            // 
            // frmChatUtente2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNome);
            Controls.Add(btnLogin);
            Controls.Add(txtNomeUtente);
            Controls.Add(btnInvia);
            Controls.Add(txtMessaggio);
            Name = "frmChatUtente2";
            Text = "frmChatUtente2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInvia;
        private TextBox txtMessaggio;
        private Button btnLogin;
        private TextBox txtNomeUtente;
        private Label lblNome;
    }
}