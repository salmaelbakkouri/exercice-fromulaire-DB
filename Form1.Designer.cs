
namespace exercice_fromulaire_DB
{
    partial class Form1
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
            this.ajouterBTN = new System.Windows.Forms.Button();
            this.modifierBTN = new System.Windows.Forms.Button();
            this.supprimerBTN = new System.Windows.Forms.Button();
            this.confirmerBTN = new System.Windows.Forms.Button();
            this.annulerBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idCombobox = new System.Windows.Forms.ComboBox();
            this.nomTextbox = new System.Windows.Forms.TextBox();
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ajouterBTN
            // 
            this.ajouterBTN.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterBTN.Location = new System.Drawing.Point(196, 255);
            this.ajouterBTN.Name = "ajouterBTN";
            this.ajouterBTN.Size = new System.Drawing.Size(122, 35);
            this.ajouterBTN.TabIndex = 0;
            this.ajouterBTN.Text = "ajouter";
            this.ajouterBTN.UseVisualStyleBackColor = true;
            this.ajouterBTN.Click += new System.EventHandler(this.ajouterBTN_Click);
            // 
            // modifierBTN
            // 
            this.modifierBTN.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierBTN.Location = new System.Drawing.Point(324, 255);
            this.modifierBTN.Name = "modifierBTN";
            this.modifierBTN.Size = new System.Drawing.Size(122, 35);
            this.modifierBTN.TabIndex = 1;
            this.modifierBTN.Text = "modifier";
            this.modifierBTN.UseVisualStyleBackColor = true;
            this.modifierBTN.Click += new System.EventHandler(this.modifierBTN_Click);
            // 
            // supprimerBTN
            // 
            this.supprimerBTN.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimerBTN.Location = new System.Drawing.Point(452, 255);
            this.supprimerBTN.Name = "supprimerBTN";
            this.supprimerBTN.Size = new System.Drawing.Size(122, 35);
            this.supprimerBTN.TabIndex = 2;
            this.supprimerBTN.Text = "supprimer";
            this.supprimerBTN.UseVisualStyleBackColor = true;
            this.supprimerBTN.Click += new System.EventHandler(this.supprimerBTN_Click);
            // 
            // confirmerBTN
            // 
            this.confirmerBTN.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmerBTN.Location = new System.Drawing.Point(261, 313);
            this.confirmerBTN.Name = "confirmerBTN";
            this.confirmerBTN.Size = new System.Drawing.Size(122, 35);
            this.confirmerBTN.TabIndex = 3;
            this.confirmerBTN.Text = "confirmer";
            this.confirmerBTN.UseVisualStyleBackColor = true;
            this.confirmerBTN.Click += new System.EventHandler(this.confirmerBTN_Click);
            // 
            // annulerBTN
            // 
            this.annulerBTN.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annulerBTN.Location = new System.Drawing.Point(389, 313);
            this.annulerBTN.Name = "annulerBTN";
            this.annulerBTN.Size = new System.Drawing.Size(122, 35);
            this.annulerBTN.TabIndex = 4;
            this.annulerBTN.Text = "annuler";
            this.annulerBTN.UseVisualStyleBackColor = true;
            this.annulerBTN.Click += new System.EventHandler(this.annulerBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "ville";
            // 
            // idCombobox
            // 
            this.idCombobox.FormattingEnabled = true;
            this.idCombobox.Location = new System.Drawing.Point(349, 79);
            this.idCombobox.Name = "idCombobox";
            this.idCombobox.Size = new System.Drawing.Size(162, 21);
            this.idCombobox.TabIndex = 9;
            this.idCombobox.SelectedIndexChanged += new System.EventHandler(this.idCombobox_SelectedIndexChanged);
            // 
            // nomTextbox
            // 
            this.nomTextbox.Location = new System.Drawing.Point(349, 121);
            this.nomTextbox.Name = "nomTextbox";
            this.nomTextbox.Size = new System.Drawing.Size(162, 20);
            this.nomTextbox.TabIndex = 11;
            this.nomTextbox.TextChanged += new System.EventHandler(this.nomTextbox_TextChanged);
            // 
            // villeTextBox
            // 
            this.villeTextBox.Location = new System.Drawing.Point(349, 211);
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.Size = new System.Drawing.Size(162, 20);
            this.villeTextBox.TabIndex = 12;
            this.villeTextBox.TextChanged += new System.EventHandler(this.villeTextBox_TextChanged);
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.Location = new System.Drawing.Point(349, 168);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(162, 20);
            this.prenomTextBox.TabIndex = 13;
            this.prenomTextBox.TextChanged += new System.EventHandler(this.prenomTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(this.villeTextBox);
            this.Controls.Add(this.nomTextbox);
            this.Controls.Add(this.idCombobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.annulerBTN);
            this.Controls.Add(this.confirmerBTN);
            this.Controls.Add(this.supprimerBTN);
            this.Controls.Add(this.modifierBTN);
            this.Controls.Add(this.ajouterBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ajouterBTN;
        private System.Windows.Forms.Button modifierBTN;
        private System.Windows.Forms.Button supprimerBTN;
        private System.Windows.Forms.Button confirmerBTN;
        private System.Windows.Forms.Button annulerBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox idCombobox;
        private System.Windows.Forms.TextBox nomTextbox;
        private System.Windows.Forms.TextBox villeTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
    }
}

