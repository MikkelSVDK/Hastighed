
namespace Hastighed
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SpeedText = new System.Windows.Forms.Label();
            this.SpeedNumber = new System.Windows.Forms.Label();
            this.SpeedType = new System.Windows.Forms.Label();
            this.TypeRadio1 = new System.Windows.Forms.RadioButton();
            this.TypeRadio2 = new System.Windows.Forms.RadioButton();
            this.NumberInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumberInput)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateButton.Location = new System.Drawing.Point(12, 216);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(230, 67);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Konvater";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // SpeedText
            // 
            this.SpeedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedText.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpeedText.Location = new System.Drawing.Point(12, 9);
            this.SpeedText.Name = "SpeedText";
            this.SpeedText.Size = new System.Drawing.Size(230, 37);
            this.SpeedText.TabIndex = 2;
            this.SpeedText.Text = "Hastighed";
            this.SpeedText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpeedNumber
            // 
            this.SpeedNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpeedNumber.Location = new System.Drawing.Point(12, 46);
            this.SpeedNumber.Name = "SpeedNumber";
            this.SpeedNumber.Size = new System.Drawing.Size(230, 28);
            this.SpeedNumber.TabIndex = 3;
            this.SpeedNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpeedType
            // 
            this.SpeedType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedType.Location = new System.Drawing.Point(12, 74);
            this.SpeedType.Name = "SpeedType";
            this.SpeedType.Size = new System.Drawing.Size(230, 19);
            this.SpeedType.TabIndex = 4;
            this.SpeedType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypeRadio1
            // 
            this.TypeRadio1.AllowDrop = true;
            this.TypeRadio1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeRadio1.AutoSize = true;
            this.TypeRadio1.Checked = true;
            this.TypeRadio1.Location = new System.Drawing.Point(12, 158);
            this.TypeRadio1.Name = "TypeRadio1";
            this.TypeRadio1.Size = new System.Drawing.Size(91, 19);
            this.TypeRadio1.TabIndex = 5;
            this.TypeRadio1.TabStop = true;
            this.TypeRadio1.Text = "km/t -> m/s";
            this.TypeRadio1.UseVisualStyleBackColor = true;
            this.TypeRadio1.CheckedChanged += new System.EventHandler(this.TypeRadio1_CheckedChanged);
            // 
            // TypeRadio2
            // 
            this.TypeRadio2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeRadio2.AutoSize = true;
            this.TypeRadio2.Location = new System.Drawing.Point(12, 183);
            this.TypeRadio2.Name = "TypeRadio2";
            this.TypeRadio2.Size = new System.Drawing.Size(92, 19);
            this.TypeRadio2.TabIndex = 6;
            this.TypeRadio2.Text = "m/s -> km/s";
            this.TypeRadio2.UseVisualStyleBackColor = true;
            this.TypeRadio2.CheckedChanged += new System.EventHandler(this.TypeRadio2_CheckedChanged);
            // 
            // NumberInput
            // 
            this.NumberInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberInput.DecimalPlaces = 2;
            this.NumberInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumberInput.Location = new System.Drawing.Point(12, 124);
            this.NumberInput.Name = "NumberInput";
            this.NumberInput.Size = new System.Drawing.Size(230, 23);
            this.NumberInput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 295);
            this.Controls.Add(this.NumberInput);
            this.Controls.Add(this.TypeRadio2);
            this.Controls.Add(this.TypeRadio1);
            this.Controls.Add(this.SpeedType);
            this.Controls.Add(this.SpeedNumber);
            this.Controls.Add(this.SpeedText);
            this.Controls.Add(this.CalculateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumberInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label SpeedText;
        private System.Windows.Forms.Label SpeedNumber;
        private System.Windows.Forms.Label SpeedType;
        private System.Windows.Forms.RadioButton TypeRadio1;
        private System.Windows.Forms.RadioButton TypeRadio2;
        private System.Windows.Forms.NumericUpDown NumberInput;
    }
}

