
namespace Pastelaria
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_finalizar = new System.Windows.Forms.Button();
            this.lst_compras = new System.Windows.Forms.ListBox();
            this.lst_produtos = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_total
            // 
            this.label_total.BackColor = System.Drawing.Color.White;
            this.label_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_total.Location = new System.Drawing.Point(278, 342);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(189, 31);
            this.label_total.TabIndex = 11;
            this.label_total.Text = "TOTAL";
            this.label_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "COMPRAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "PRODUTOS";
            // 
            // button_finalizar
            // 
            this.button_finalizar.Location = new System.Drawing.Point(359, 387);
            this.button_finalizar.Name = "button_finalizar";
            this.button_finalizar.Size = new System.Drawing.Size(108, 41);
            this.button_finalizar.TabIndex = 8;
            this.button_finalizar.Text = "FINALIZAR";
            this.button_finalizar.UseVisualStyleBackColor = true;
            this.button_finalizar.Click += new System.EventHandler(this.button_finalizar_Click);
            // 
            // lst_compras
            // 
            this.lst_compras.FormattingEnabled = true;
            this.lst_compras.Location = new System.Drawing.Point(278, 36);
            this.lst_compras.Name = "lst_compras";
            this.lst_compras.Size = new System.Drawing.Size(189, 303);
            this.lst_compras.TabIndex = 7;
            // 
            // lst_produtos
            // 
            this.lst_produtos.FormattingEnabled = true;
            this.lst_produtos.Location = new System.Drawing.Point(29, 36);
            this.lst_produtos.Name = "lst_produtos";
            this.lst_produtos.Size = new System.Drawing.Size(174, 303);
            this.lst_produtos.TabIndex = 6;
            this.lst_produtos.SelectedIndexChanged += new System.EventHandler(this.lst_produtos_SelectedIndexChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 83);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(506, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_finalizar);
            this.Controls.Add(this.lst_compras);
            this.Controls.Add(this.lst_produtos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_finalizar;
        private System.Windows.Forms.ListBox lst_compras;
        private System.Windows.Forms.ListBox lst_produtos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}