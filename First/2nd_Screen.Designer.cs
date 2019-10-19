namespace First {
    partial class _2nd_Screen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.btnDonation = new System.Windows.Forms.Button();
            this.btnAdoption = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a opção que desejas executar";
            // 
            // btnDonation
            // 
            this.btnDonation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonation.Location = new System.Drawing.Point(211, 91);
            this.btnDonation.Name = "btnDonation";
            this.btnDonation.Size = new System.Drawing.Size(181, 32);
            this.btnDonation.TabIndex = 1;
            this.btnDonation.Text = "Cadastrar uma doação";
            this.btnDonation.UseVisualStyleBackColor = true;
            this.btnDonation.Click += new System.EventHandler(this.BtnDonation_Click);
            // 
            // btnAdoption
            // 
            this.btnAdoption.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdoption.Location = new System.Drawing.Point(211, 145);
            this.btnAdoption.Name = "btnAdoption";
            this.btnAdoption.Size = new System.Drawing.Size(181, 32);
            this.btnAdoption.TabIndex = 2;
            this.btnAdoption.Text = "Fazer uma adoção";
            this.btnAdoption.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(211, 203);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(181, 32);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "Exibir listagem";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "<< Voltar";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // _2nd_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 304);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnAdoption);
            this.Controls.Add(this.btnDonation);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "_2nd_Screen";
            this.Text = "JJA Dogs&Cats";
            this.Load += new System.EventHandler(this._2nd_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDonation;
        private System.Windows.Forms.Button btnAdoption;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label2;
    }
}