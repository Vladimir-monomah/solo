namespace Solo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_text = new System.Windows.Forms.Label();
            this.text_type = new System.Windows.Forms.TextBox();
            this.labe_typed = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label_speed = new System.Windows.Forms.Label();
            this.label_speed_info = new System.Windows.Forms.Label();
            this.label_time_info = new System.Windows.Forms.Label();
            this.label_type_info = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_text
            // 
            this.label_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_text.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_text.Location = new System.Drawing.Point(12, 9);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(776, 129);
            this.label_text.TabIndex = 0;
            this.label_text.Text = "label1";
            // 
            // text_type
            // 
            this.text_type.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_type.Location = new System.Drawing.Point(12, 141);
            this.text_type.Multiline = true;
            this.text_type.Name = "text_type";
            this.text_type.Size = new System.Drawing.Size(776, 152);
            this.text_type.TabIndex = 1;
            this.text_type.KeyUp += new System.Windows.Forms.KeyEventHandler(this.text_type_KeyUp);
            // 
            // labe_typed
            // 
            this.labe_typed.AutoSize = true;
            this.labe_typed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labe_typed.Location = new System.Drawing.Point(12, 309);
            this.labe_typed.Name = "labe_typed";
            this.labe_typed.Size = new System.Drawing.Size(78, 18);
            this.labe_typed.TabIndex = 2;
            this.labe_typed.Text = "Набрано:";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_time.Location = new System.Drawing.Point(323, 309);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(61, 18);
            this.label_time.TabIndex = 3;
            this.label_time.Text = "Время:";
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_speed.Location = new System.Drawing.Point(583, 309);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(85, 18);
            this.label_speed.TabIndex = 4;
            this.label_speed.Text = "Скорость:";
            // 
            // label_speed_info
            // 
            this.label_speed_info.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_speed_info.Location = new System.Drawing.Point(674, 309);
            this.label_speed_info.Name = "label_speed_info";
            this.label_speed_info.Size = new System.Drawing.Size(114, 18);
            this.label_speed_info.TabIndex = 7;
            this.label_speed_info.Text = "-";
            this.label_speed_info.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_time_info
            // 
            this.label_time_info.AutoSize = true;
            this.label_time_info.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_time_info.Location = new System.Drawing.Point(390, 309);
            this.label_time_info.Name = "label_time_info";
            this.label_time_info.Size = new System.Drawing.Size(14, 18);
            this.label_time_info.TabIndex = 6;
            this.label_time_info.Text = "-";
            // 
            // label_type_info
            // 
            this.label_type_info.AutoSize = true;
            this.label_type_info.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_type_info.Location = new System.Drawing.Point(96, 309);
            this.label_type_info.Name = "label_type_info";
            this.label_type_info.Size = new System.Drawing.Size(14, 18);
            this.label_type_info.TabIndex = 5;
            this.label_type_info.Text = "-";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.label_speed_info);
            this.Controls.Add(this.label_time_info);
            this.Controls.Add(this.label_type_info);
            this.Controls.Add(this.label_speed);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.labe_typed);
            this.Controls.Add(this.text_type);
            this.Controls.Add(this.label_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проверка скорости печати";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.TextBox text_type;
        private System.Windows.Forms.Label labe_typed;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.Label label_speed_info;
        private System.Windows.Forms.Label label_time_info;
        private System.Windows.Forms.Label label_type_info;
        private System.Windows.Forms.Timer timer;
    }
}

