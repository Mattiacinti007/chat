namespace cinti_chat
{
    partial class frmChat
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
            lbMessaggi = new ListBox();
            txtMessaggio = new TextBox();
            btnInvia = new Button();
            lblTitolo = new Label();
            SuspendLayout();
            // 
            // lbMessaggi
            // 
            lbMessaggi.FormattingEnabled = true;
            lbMessaggi.Location = new Point(12, 53);
            lbMessaggi.Name = "lbMessaggi";
            lbMessaggi.Size = new Size(776, 344);
            lbMessaggi.TabIndex = 0;
            // 
            // txtMessaggio
            // 
            txtMessaggio.Location = new Point(12, 411);
            txtMessaggio.Name = "txtMessaggio";
            txtMessaggio.Size = new Size(656, 27);
            txtMessaggio.TabIndex = 1;
            // 
            // btnInvia
            // 
            btnInvia.Location = new Point(674, 411);
            btnInvia.Name = "btnInvia";
            btnInvia.Size = new Size(114, 29);
            btnInvia.TabIndex = 2;
            btnInvia.Text = "Invia";
            btnInvia.UseVisualStyleBackColor = true;
            btnInvia.Click += btnInvia_Click;
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Font = new Font("Segoe UI", 18F);
            lblTitolo.Location = new Point(12, 4);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(219, 41);
            lblTitolo.TabIndex = 3;
            lblTitolo.Text = "Chat di gruppo";
            // 
            // frmChat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitolo);
            Controls.Add(btnInvia);
            Controls.Add(txtMessaggio);
            Controls.Add(lbMessaggi);
            Name = "frmChat";
            Text = "frmChat";
            FormClosing += FormChat_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbMessaggi;
        private TextBox txtMessaggio;
        private Button btnInvia;
        private Label lblTitolo;
    }
}