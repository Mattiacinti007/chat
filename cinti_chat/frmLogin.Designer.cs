namespace cinti_chat
{
    partial class frmLogin
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
            lblLogin = new Label();
            txtNome = new TextBox();
            btnInvia = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 20F);
            lblLogin.Location = new Point(115, 33);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(112, 46);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login ";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(30, 110);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(274, 27);
            txtNome.TabIndex = 1;
            // 
            // btnInvia
            // 
            btnInvia.Location = new Point(30, 152);
            btnInvia.Name = "btnInvia";
            btnInvia.Size = new Size(274, 29);
            btnInvia.TabIndex = 2;
            btnInvia.Text = "Login";
            btnInvia.UseVisualStyleBackColor = true;
            btnInvia.Click += btnInvia_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 213);
            Controls.Add(btnInvia);
            Controls.Add(txtNome);
            Controls.Add(lblLogin);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private TextBox txtNome;
        private Button btnInvia;
    }
}