namespace cinti_chat
{
    partial class frmChatUtente1
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
            lblNome = new Label();
            btnLogin = new Button();
            txtNomeUtente = new TextBox();
            panelMessaggi = new Panel();
            SuspendLayout();
            // 
            // btnInvia
            // 
            btnInvia.Location = new Point(817, 409);
            btnInvia.Name = "btnInvia";
            btnInvia.Size = new Size(110, 29);
            btnInvia.TabIndex = 5;
            btnInvia.Text = "Invia";
            btnInvia.UseVisualStyleBackColor = true;
            btnInvia.Click += btnInvia_Click;
            // 
            // txtMessaggio
            // 
            txtMessaggio.Location = new Point(6, 411);
            txtMessaggio.Name = "txtMessaggio";
            txtMessaggio.Size = new Size(805, 27);
            txtMessaggio.TabIndex = 4;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(99, 20);
            lblNome.TabIndex = 9;
            lblNome.Text = "Nome utente:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(134, 47);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(103, 29);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtNomeUtente
            // 
            txtNomeUtente.Location = new Point(12, 47);
            txtNomeUtente.Name = "txtNomeUtente";
            txtNomeUtente.Size = new Size(116, 27);
            txtNomeUtente.TabIndex = 7;
            // 
            // panelMessaggi
            // 
            panelMessaggi.AutoScroll = true;
            panelMessaggi.Location = new Point(6, 12);
            panelMessaggi.Name = "panelMessaggi";
            panelMessaggi.Size = new Size(921, 393);
            panelMessaggi.TabIndex = 10;
            // 
            // frmChatUtente1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 450);
            Controls.Add(panelMessaggi);
            Controls.Add(lblNome);
            Controls.Add(btnLogin);
            Controls.Add(txtNomeUtente);
            Controls.Add(btnInvia);
            Controls.Add(txtMessaggio);
            Name = "frmChatUtente1";
            Text = "frmChatUtente1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInvia;
        private TextBox txtMessaggio;
        private Label lblNome;
        private Button btnLogin;
        private TextBox txtNomeUtente;
        private Panel panelMessaggi;
    }
}