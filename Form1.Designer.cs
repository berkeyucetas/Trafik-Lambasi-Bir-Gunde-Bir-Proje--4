namespace Trafik_Lambası
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnKirmizi = new System.Windows.Forms.Button();
            this.btnSari = new System.Windows.Forms.Button();
            this.btnYesil = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnKirmizi
            // 
            this.btnKirmizi.Location = new System.Drawing.Point(57, 13);
            this.btnKirmizi.Name = "btnKirmizi";
            this.btnKirmizi.Size = new System.Drawing.Size(160, 167);
            this.btnKirmizi.TabIndex = 0;
            this.btnKirmizi.UseVisualStyleBackColor = true;
            // 
            // btnSari
            // 
            this.btnSari.Location = new System.Drawing.Point(57, 186);
            this.btnSari.Name = "btnSari";
            this.btnSari.Size = new System.Drawing.Size(160, 167);
            this.btnSari.TabIndex = 1;
            this.btnSari.UseVisualStyleBackColor = true;
            // 
            // btnYesil
            // 
            this.btnYesil.Location = new System.Drawing.Point(57, 359);
            this.btnYesil.Name = "btnYesil";
            this.btnYesil.Size = new System.Drawing.Size(160, 167);
            this.btnYesil.TabIndex = 2;
            this.btnYesil.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(276, 575);
            this.Controls.Add(this.btnYesil);
            this.Controls.Add(this.btnSari);
            this.Controls.Add(this.btnKirmizi);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Trafik Lambası";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKirmizi;
        private System.Windows.Forms.Button btnSari;
        private System.Windows.Forms.Button btnYesil;
        private System.Windows.Forms.Timer timer1;
    }
}

