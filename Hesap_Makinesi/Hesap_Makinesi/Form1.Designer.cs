namespace Hesap_Makinesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFibonacci = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.btnCe = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnKk = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMatris = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnFact = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFibonacci
            // 
            this.btnFibonacci.Font = new System.Drawing.Font("Sofachrome Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFibonacci.Location = new System.Drawing.Point(12, 123);
            this.btnFibonacci.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new System.Drawing.Size(148, 56);
            this.btnFibonacci.TabIndex = 2;
            this.btnFibonacci.TabStop = false;
            this.btnFibonacci.Text = "Fibonacci";
            this.btnFibonacci.UseVisualStyleBackColor = true;
            this.btnFibonacci.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnLog
            // 
            this.btnLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLog.Font = new System.Drawing.Font("Sofachrome Rg", 8.25F);
            this.btnLog.Location = new System.Drawing.Point(12, 184);
            this.btnLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(55, 56);
            this.btnLog.TabIndex = 2;
            this.btnLog.TabStop = false;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnSin
            // 
            this.btnSin.Font = new System.Drawing.Font("Sofachrome Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.Location = new System.Drawing.Point(73, 184);
            this.btnSin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(55, 56);
            this.btnSin.TabIndex = 2;
            this.btnSin.TabStop = false;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnCos
            // 
            this.btnCos.Font = new System.Drawing.Font("Sofachrome Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.Location = new System.Drawing.Point(134, 184);
            this.btnCos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(55, 56);
            this.btnCos.TabIndex = 2;
            this.btnCos.TabStop = false;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnTan
            // 
            this.btnTan.Font = new System.Drawing.Font("Sofachrome Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.Location = new System.Drawing.Point(195, 184);
            this.btnTan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(55, 56);
            this.btnTan.TabIndex = 2;
            this.btnTan.TabStop = false;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnX2
            // 
            this.btnX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnX2.Image = ((System.Drawing.Image)(resources.GetObject("btnX2.Image")));
            this.btnX2.Location = new System.Drawing.Point(12, 245);
            this.btnX2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(55, 56);
            this.btnX2.TabIndex = 2;
            this.btnX2.TabStop = false;
            this.btnX2.Text = "   ²";
            this.btnX2.UseVisualStyleBackColor = true;
            this.btnX2.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnCe
            // 
            this.btnCe.Font = new System.Drawing.Font("Sofachrome Rg", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCe.Location = new System.Drawing.Point(73, 245);
            this.btnCe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCe.Name = "btnCe";
            this.btnCe.Size = new System.Drawing.Size(55, 56);
            this.btnCe.TabIndex = 2;
            this.btnCe.TabStop = false;
            this.btnCe.Text = "CE";
            this.btnCe.UseVisualStyleBackColor = true;
            this.btnCe.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Sofachrome Rg", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(134, 245);
            this.btnC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(55, 56);
            this.btnC.TabIndex = 2;
            this.btnC.TabStop = false;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnErase
            // 
            this.btnErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErase.Location = new System.Drawing.Point(195, 245);
            this.btnErase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(55, 56);
            this.btnErase.TabIndex = 2;
            this.btnErase.TabStop = false;
            this.btnErase.Text = "←";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnKk
            // 
            this.btnKk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKk.Location = new System.Drawing.Point(12, 306);
            this.btnKk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKk.Name = "btnKk";
            this.btnKk.Size = new System.Drawing.Size(55, 56);
            this.btnKk.TabIndex = 2;
            this.btnKk.TabStop = false;
            this.btnKk.Text = "√";
            this.btnKk.UseVisualStyleBackColor = true;
            this.btnKk.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Sofachrome Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(73, 306);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 56);
            this.btn7.TabIndex = 2;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Sofachrome Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(134, 306);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 56);
            this.btn8.TabIndex = 2;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Sofachrome Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(195, 306);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 56);
            this.btn9.TabIndex = 2;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnMatris
            // 
            this.btnMatris.Font = new System.Drawing.Font("Sofachrome Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatris.Location = new System.Drawing.Point(163, 123);
            this.btnMatris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMatris.Name = "btnMatris";
            this.btnMatris.Size = new System.Drawing.Size(148, 56);
            this.btnMatris.TabIndex = 2;
            this.btnMatris.TabStop = false;
            this.btnMatris.Text = "Matris";
            this.btnMatris.UseVisualStyleBackColor = true;
            this.btnMatris.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Sofachrome Rg", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(256, 184);
            this.btnMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(55, 56);
            this.btnMod.TabIndex = 2;
            this.btnMod.TabStop = false;
            this.btnMod.Text = "mod";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Sofachrome Rg", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(256, 245);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(55, 56);
            this.btnDiv.TabIndex = 2;
            this.btnDiv.TabStop = false;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnMul
            // 
            this.btnMul.Font = new System.Drawing.Font("Sofachrome Rg", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.Location = new System.Drawing.Point(256, 306);
            this.btnMul.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(55, 56);
            this.btnMul.TabIndex = 2;
            this.btnMul.TabStop = false;
            this.btnMul.Text = "x";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnFact
            // 
            this.btnFact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFact.Image = ((System.Drawing.Image)(resources.GetObject("btnFact.Image")));
            this.btnFact.Location = new System.Drawing.Point(12, 368);
            this.btnFact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFact.Name = "btnFact";
            this.btnFact.Size = new System.Drawing.Size(55, 56);
            this.btnFact.TabIndex = 2;
            this.btnFact.TabStop = false;
            this.btnFact.Text = "    !";
            this.btnFact.UseVisualStyleBackColor = true;
            this.btnFact.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Sofachrome Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(73, 368);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 56);
            this.btn4.TabIndex = 2;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Sofachrome Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(134, 368);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 56);
            this.btn5.TabIndex = 2;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Sofachrome Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(195, 368);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 56);
            this.btn6.TabIndex = 2;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Sofachrome Rg", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(256, 368);
            this.btnSub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(55, 56);
            this.btnSub.TabIndex = 2;
            this.btnSub.TabStop = false;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnSign
            // 
            this.btnSign.Font = new System.Drawing.Font("Sofachrome Rg", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.Location = new System.Drawing.Point(12, 428);
            this.btnSign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(55, 56);
            this.btnSign.TabIndex = 2;
            this.btnSign.TabStop = false;
            this.btnSign.Text = "+/-";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Sofachrome Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(73, 428);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 56);
            this.btn1.TabIndex = 2;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Sofachrome Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(134, 428);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 56);
            this.btn2.TabIndex = 2;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Sofachrome Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(195, 428);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 56);
            this.btn3.TabIndex = 2;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Sofachrome Rg", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(256, 428);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 56);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Sofachrome Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(12, 489);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(55, 56);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.TabStop = false;
            this.btnLeft.Text = "(";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Sofachrome Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(73, 489);
            this.btnRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(55, 56);
            this.btnRight.TabIndex = 2;
            this.btnRight.TabStop = false;
            this.btnRight.Text = ")";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Sofachrome Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(134, 489);
            this.btn0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(55, 56);
            this.btn0.TabIndex = 2;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnComma
            // 
            this.btnComma.Font = new System.Drawing.Font("Sofachrome Rg", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComma.Location = new System.Drawing.Point(195, 489);
            this.btnComma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(55, 56);
            this.btnComma.TabIndex = 2;
            this.btnComma.TabStop = false;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = true;
            this.btnComma.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Sofachrome Rg", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(256, 489);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(55, 56);
            this.btnEqual.TabIndex = 2;
            this.btnEqual.TabStop = false;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.AnaFonksiyon);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Digital-7", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(5, 56);
            this.textBox1.MaxLength = 14;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(313, 55);
            this.textBox1.TabIndex = 6;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 516);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "3";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(5, 20);
            this.textBox2.MaxLength = 17;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(313, 36);
            this.textBox2.TabIndex = 8;
            this.textBox2.TabStop = false;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(324, 551);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnCe);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnMatris);
            this.Controls.Add(this.btnFact);
            this.Controls.Add(this.btnKk);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnFibonacci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFibonacci;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Button btnCe;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnKk;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMatris;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnFact;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}

