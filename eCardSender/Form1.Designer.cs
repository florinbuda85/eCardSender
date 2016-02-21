namespace eCardSender
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
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeigth = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonSendMail = new System.Windows.Forms.Button();
            this.waterMarkTextBoxSubject = new eCardSender.CustomUIComponents.WaterMarkTextBox();
            this.waterMarkTextBoxMessage = new eCardSender.CustomUIComponents.WaterMarkTextBox();
            this.waterMarkTextBoxTo = new eCardSender.CustomUIComponents.WaterMarkTextBox();
            this.drawingPanel1 = new eCardSender.CustomComponents.DrawingPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(524, 527);
            this.nudWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(97, 22);
            this.nudWidth.TabIndex = 1;
            this.nudWidth.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudWidth.ValueChanged += new System.EventHandler(this.nudWidth_ValueChanged);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(524, 507);
            this.labelWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(48, 17);
            this.labelWidth.TabIndex = 2;
            this.labelWidth.Text = "Width:";
            // 
            // labelHeigth
            // 
            this.labelHeigth.AutoSize = true;
            this.labelHeigth.Location = new System.Drawing.Point(520, 574);
            this.labelHeigth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeigth.Name = "labelHeigth";
            this.labelHeigth.Size = new System.Drawing.Size(53, 17);
            this.labelHeigth.TabIndex = 4;
            this.labelHeigth.Text = "Heigth:";
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(524, 594);
            this.nudHeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(97, 22);
            this.nudHeight.TabIndex = 3;
            this.nudHeight.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudHeight.ValueChanged += new System.EventHandler(this.nudHeight_ValueChanged);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(517, 708);
            this.buttonColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(104, 23);
            this.buttonColor.TabIndex = 5;
            this.buttonColor.Text = "change color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(517, 739);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(104, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save file";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSendMail
            // 
            this.buttonSendMail.ForeColor = System.Drawing.Color.Gray;
            this.buttonSendMail.Location = new System.Drawing.Point(205, 734);
            this.buttonSendMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSendMail.Name = "buttonSendMail";
            this.buttonSendMail.Size = new System.Drawing.Size(100, 28);
            this.buttonSendMail.TabIndex = 10;
            this.buttonSendMail.Text = "Send Mail !";
            this.buttonSendMail.UseVisualStyleBackColor = true;
            this.buttonSendMail.Click += new System.EventHandler(this.buttonEmail_Click);
            // 
            // waterMarkTextBoxSubject
            // 
            this.waterMarkTextBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBoxSubject.Location = new System.Drawing.Point(44, 615);
            this.waterMarkTextBoxSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.waterMarkTextBoxSubject.Name = "waterMarkTextBoxSubject";
            this.waterMarkTextBoxSubject.Size = new System.Drawing.Size(260, 23);
            this.waterMarkTextBoxSubject.TabIndex = 15;
            this.waterMarkTextBoxSubject.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBoxSubject.WaterMarkText = "Subject:";
            // 
            // waterMarkTextBoxMessage
            // 
            this.waterMarkTextBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBoxMessage.Location = new System.Drawing.Point(44, 647);
            this.waterMarkTextBoxMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.waterMarkTextBoxMessage.Multiline = true;
            this.waterMarkTextBoxMessage.Name = "waterMarkTextBoxMessage";
            this.waterMarkTextBoxMessage.Size = new System.Drawing.Size(260, 78);
            this.waterMarkTextBoxMessage.TabIndex = 14;
            this.waterMarkTextBoxMessage.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBoxMessage.WaterMarkText = "Type your message";
            // 
            // waterMarkTextBoxTo
            // 
            this.waterMarkTextBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBoxTo.Location = new System.Drawing.Point(44, 583);
            this.waterMarkTextBoxTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.waterMarkTextBoxTo.Name = "waterMarkTextBoxTo";
            this.waterMarkTextBoxTo.Size = new System.Drawing.Size(260, 23);
            this.waterMarkTextBoxTo.TabIndex = 13;
            this.waterMarkTextBoxTo.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBoxTo.WaterMarkText = "To:";
            // 
            // drawingPanel1
            // 
            this.drawingPanel1.BackColor = System.Drawing.Color.Black;
            this.drawingPanel1.Location = new System.Drawing.Point(16, 15);
            this.drawingPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drawingPanel1.Name = "drawingPanel1";
            this.drawingPanel1.Size = new System.Drawing.Size(605, 462);
            this.drawingPanel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 828);
            this.Controls.Add(this.waterMarkTextBoxSubject);
            this.Controls.Add(this.waterMarkTextBoxMessage);
            this.Controls.Add(this.waterMarkTextBoxTo);
            this.Controls.Add(this.buttonSendMail);
            this.Controls.Add(this.drawingPanel1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.labelHeigth);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.nudWidth);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeigth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CustomComponents.DrawingPanel drawingPanel1;
        private System.Windows.Forms.Button buttonSendMail;
        private CustomUIComponents.WaterMarkTextBox waterMarkTextBoxTo;
        private CustomUIComponents.WaterMarkTextBox waterMarkTextBoxMessage;
        private CustomUIComponents.WaterMarkTextBox waterMarkTextBoxSubject;
    }
}

