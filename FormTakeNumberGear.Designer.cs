namespace Графы1
{
    partial class FormTakeNumberGear
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
            this.tbNumberNode = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.cBoxTurn = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(245, 113);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(12, 113);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // tbNumberNode
            // 
            this.tbNumberNode.Location = new System.Drawing.Point(155, 24);
            this.tbNumberNode.Name = "tbNumberNode";
            this.tbNumberNode.Size = new System.Drawing.Size(165, 20);
            this.tbNumberNode.TabIndex = 5;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(4, 27);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(145, 13);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Укажите номер шестерни: ";
            // 
            // cBoxTurn
            // 
            this.cBoxTurn.FormattingEnabled = true;
            this.cBoxTurn.Items.AddRange(new object[] {
            "Вправо",
            "Влево"});
            this.cBoxTurn.Location = new System.Drawing.Point(12, 65);
            this.cBoxTurn.Name = "cBoxTurn";
            this.cBoxTurn.Size = new System.Drawing.Size(308, 21);
            this.cBoxTurn.TabIndex = 8;
            this.cBoxTurn.Text = "Укажите поворот шестерни: ";
            // 
            // FormTakeNumberGear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 149);
            this.Controls.Add(this.cBoxTurn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbNumberNode);
            this.Controls.Add(this.lblText);
            this.Name = "FormTakeNumberGear";
            this.Text = "FormTakeNumberGear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbNumberNode;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.ComboBox cBoxTurn;
    }
}