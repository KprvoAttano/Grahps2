namespace Графы1
{
    partial class FormDeleteEdge
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbNode1 = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.tbNode2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(237, 74);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(25, 74);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // tbNode1
            // 
            this.tbNode1.Location = new System.Drawing.Point(147, 29);
            this.tbNode1.Name = "tbNode1";
            this.tbNode1.Size = new System.Drawing.Size(79, 20);
            this.tbNode1.TabIndex = 5;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 29);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(125, 13);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Укажите номер узлов: ";
            // 
            // tbNode2
            // 
            this.tbNode2.Location = new System.Drawing.Point(237, 29);
            this.tbNode2.Name = "tbNode2";
            this.tbNode2.Size = new System.Drawing.Size(79, 20);
            this.tbNode2.TabIndex = 8;
            // 
            // FormDeleteEdge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 123);
            this.Controls.Add(this.tbNode2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbNode1);
            this.Controls.Add(this.lblText);
            this.Name = "FormDeleteEdge";
            this.Text = "FormDeleteEdge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbNode1;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox tbNode2;
    }
}