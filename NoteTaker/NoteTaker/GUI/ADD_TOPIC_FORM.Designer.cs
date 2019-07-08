namespace GeneralForm.GUI
{
    partial class ADD_TOPIC_FORM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_topic_TB = new System.Windows.Forms.TextBox();
            this.definition_topic_TB = new System.Windows.Forms.TextBox();
            this.accept_BTN = new System.Windows.Forms.Button();
            this.cancel_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Definition";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // name_topic_TB
            // 
            this.name_topic_TB.Location = new System.Drawing.Point(56, 25);
            this.name_topic_TB.Name = "name_topic_TB";
            this.name_topic_TB.Size = new System.Drawing.Size(704, 20);
            this.name_topic_TB.TabIndex = 2;
            // 
            // definition_topic_TB
            // 
            this.definition_topic_TB.Location = new System.Drawing.Point(15, 110);
            this.definition_topic_TB.Multiline = true;
            this.definition_topic_TB.Name = "definition_topic_TB";
            this.definition_topic_TB.Size = new System.Drawing.Size(745, 270);
            this.definition_topic_TB.TabIndex = 3;
            // 
            // accept_BTN
            // 
            this.accept_BTN.Location = new System.Drawing.Point(15, 401);
            this.accept_BTN.Name = "accept_BTN";
            this.accept_BTN.Size = new System.Drawing.Size(356, 37);
            this.accept_BTN.TabIndex = 4;
            this.accept_BTN.Text = "Accept";
            this.accept_BTN.UseVisualStyleBackColor = true;
            this.accept_BTN.Click += new System.EventHandler(this.Accept_BTN_Click);
            // 
            // cancel_BTN
            // 
            this.cancel_BTN.Location = new System.Drawing.Point(404, 401);
            this.cancel_BTN.Name = "cancel_BTN";
            this.cancel_BTN.Size = new System.Drawing.Size(356, 37);
            this.cancel_BTN.TabIndex = 5;
            this.cancel_BTN.Text = "Cancel";
            this.cancel_BTN.UseVisualStyleBackColor = true;
            // 
            // ADD_TOPIC_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel_BTN);
            this.Controls.Add(this.accept_BTN);
            this.Controls.Add(this.definition_topic_TB);
            this.Controls.Add(this.name_topic_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ADD_TOPIC_FORM";
            this.Text = "ADD_TOPIC_FORM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_topic_TB;
        private System.Windows.Forms.TextBox definition_topic_TB;
        private System.Windows.Forms.Button accept_BTN;
        private System.Windows.Forms.Button cancel_BTN;
    }
}