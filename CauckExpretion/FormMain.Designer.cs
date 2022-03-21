namespace CauckExpretion
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxExpretion = new System.Windows.Forms.TextBox();
            this.textBoxBackExpretion = new System.Windows.Forms.TextBox();
            this.buttonCalkBackExpretion = new System.Windows.Forms.Button();
            this.buttonCalckExpretion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxExpretion
            // 
            this.textBoxExpretion.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExpretion.Location = new System.Drawing.Point(386, 84);
            this.textBoxExpretion.Name = "textBoxExpretion";
            this.textBoxExpretion.Size = new System.Drawing.Size(494, 47);
            this.textBoxExpretion.TabIndex = 0;
            this.textBoxExpretion.Text = "(21*3-(7+1)/(4-5))*(4+2*3)";
            this.textBoxExpretion.TextChanged += new System.EventHandler(this.textBoxExpretion_TextChanged);
            // 
            // textBoxBackExpretion
            // 
            this.textBoxBackExpretion.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBackExpretion.Location = new System.Drawing.Point(386, 223);
            this.textBoxBackExpretion.Name = "textBoxBackExpretion";
            this.textBoxBackExpretion.Size = new System.Drawing.Size(494, 47);
            this.textBoxBackExpretion.TabIndex = 1;
            // 
            // buttonCalkBackExpretion
            // 
            this.buttonCalkBackExpretion.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalkBackExpretion.Location = new System.Drawing.Point(386, 148);
            this.buttonCalkBackExpretion.Name = "buttonCalkBackExpretion";
            this.buttonCalkBackExpretion.Size = new System.Drawing.Size(494, 51);
            this.buttonCalkBackExpretion.TabIndex = 2;
            this.buttonCalkBackExpretion.Text = "Получить польскую запись";
            this.buttonCalkBackExpretion.UseVisualStyleBackColor = true;
            this.buttonCalkBackExpretion.Click += new System.EventHandler(this.buttonCalkBackExpretion_Click);
            // 
            // buttonCalckExpretion
            // 
            this.buttonCalckExpretion.Enabled = false;
            this.buttonCalckExpretion.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalckExpretion.Location = new System.Drawing.Point(386, 287);
            this.buttonCalckExpretion.Name = "buttonCalckExpretion";
            this.buttonCalckExpretion.Size = new System.Drawing.Size(494, 52);
            this.buttonCalckExpretion.TabIndex = 3;
            this.buttonCalckExpretion.Text = "Вычислить по обр.записи";
            this.buttonCalckExpretion.UseVisualStyleBackColor = true;
            this.buttonCalckExpretion.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ввести выражение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Польская запись";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(379, 362);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(36, 39);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalckExpretion);
            this.Controls.Add(this.buttonCalkBackExpretion);
            this.Controls.Add(this.textBoxBackExpretion);
            this.Controls.Add(this.textBoxExpretion);
            this.Name = "FormMain";
            this.Text = "Вычисление выражений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxExpretion;
        private System.Windows.Forms.TextBox textBoxBackExpretion;
        private System.Windows.Forms.Button buttonCalkBackExpretion;
        private System.Windows.Forms.Button buttonCalckExpretion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResult;
    }
}

