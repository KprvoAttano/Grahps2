namespace Графы1
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
            this.rBtnNode = new System.Windows.Forms.RadioButton();
            this.rBtnEdge = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rBtnDistInfo = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnSaveGraph = new System.Windows.Forms.Button();
            this.btnOpenGraph = new System.Windows.Forms.Button();
            this.oFD = new System.Windows.Forms.OpenFileDialog();
            this.sFD = new System.Windows.Forms.SaveFileDialog();
            this.btnDeleteNode = new System.Windows.Forms.Button();
            this.btnDeleteEdge = new System.Windows.Forms.Button();
            this.btnGearTurn = new System.Windows.Forms.Button();
            this.tBResult = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rBtnNode
            // 
            this.rBtnNode.AutoSize = true;
            this.rBtnNode.Location = new System.Drawing.Point(3, 3);
            this.rBtnNode.Name = "rBtnNode";
            this.rBtnNode.Size = new System.Drawing.Size(79, 17);
            this.rBtnNode.TabIndex = 0;
            this.rBtnNode.TabStop = true;
            this.rBtnNode.Text = "Draw Node";
            this.rBtnNode.UseVisualStyleBackColor = true;
            // 
            // rBtnEdge
            // 
            this.rBtnEdge.AutoSize = true;
            this.rBtnEdge.Location = new System.Drawing.Point(4, 26);
            this.rBtnEdge.Name = "rBtnEdge";
            this.rBtnEdge.Size = new System.Drawing.Size(78, 17);
            this.rBtnEdge.TabIndex = 1;
            this.rBtnEdge.TabStop = true;
            this.rBtnEdge.Text = "Draw Edge";
            this.rBtnEdge.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rBtnDistInfo);
            this.panel1.Controls.Add(this.rBtnNode);
            this.panel1.Controls.Add(this.rBtnEdge);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 79);
            this.panel1.TabIndex = 2;
            // 
            // rBtnDistInfo
            // 
            this.rBtnDistInfo.AutoSize = true;
            this.rBtnDistInfo.Location = new System.Drawing.Point(3, 49);
            this.rBtnDistInfo.Name = "rBtnDistInfo";
            this.rBtnDistInfo.Size = new System.Drawing.Size(64, 17);
            this.rBtnDistInfo.TabIndex = 7;
            this.rBtnDistInfo.TabStop = true;
            this.rBtnDistInfo.Text = "Dist Info";
            this.rBtnDistInfo.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(109, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 38);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(109, 56);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(138, 35);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Number of lowest";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnSaveGraph
            // 
            this.btnSaveGraph.Location = new System.Drawing.Point(714, 52);
            this.btnSaveGraph.Name = "btnSaveGraph";
            this.btnSaveGraph.Size = new System.Drawing.Size(74, 35);
            this.btnSaveGraph.TabIndex = 5;
            this.btnSaveGraph.Text = "Save Graph";
            this.btnSaveGraph.UseVisualStyleBackColor = true;
            this.btnSaveGraph.Click += new System.EventHandler(this.btnSaveGraph_Click);
            // 
            // btnOpenGraph
            // 
            this.btnOpenGraph.Location = new System.Drawing.Point(714, 12);
            this.btnOpenGraph.Name = "btnOpenGraph";
            this.btnOpenGraph.Size = new System.Drawing.Size(74, 35);
            this.btnOpenGraph.TabIndex = 6;
            this.btnOpenGraph.Text = "Open Graph";
            this.btnOpenGraph.UseVisualStyleBackColor = true;
            this.btnOpenGraph.Click += new System.EventHandler(this.btnOpenGraph_Click);
            // 
            // oFD
            // 
            this.oFD.FileName = "openFileDialog1";
            // 
            // btnDeleteNode
            // 
            this.btnDeleteNode.Location = new System.Drawing.Point(332, 15);
            this.btnDeleteNode.Name = "btnDeleteNode";
            this.btnDeleteNode.Size = new System.Drawing.Size(75, 35);
            this.btnDeleteNode.TabIndex = 7;
            this.btnDeleteNode.Text = "Delete Node";
            this.btnDeleteNode.UseVisualStyleBackColor = true;
            this.btnDeleteNode.Click += new System.EventHandler(this.btnDeleteNode_Click);
            // 
            // btnDeleteEdge
            // 
            this.btnDeleteEdge.Location = new System.Drawing.Point(413, 15);
            this.btnDeleteEdge.Name = "btnDeleteEdge";
            this.btnDeleteEdge.Size = new System.Drawing.Size(75, 35);
            this.btnDeleteEdge.TabIndex = 8;
            this.btnDeleteEdge.Text = "Delete Edge";
            this.btnDeleteEdge.UseVisualStyleBackColor = true;
            this.btnDeleteEdge.Click += new System.EventHandler(this.btnDeleteEdge_Click);
            // 
            // btnGearTurn
            // 
            this.btnGearTurn.Location = new System.Drawing.Point(544, 14);
            this.btnGearTurn.Name = "btnGearTurn";
            this.btnGearTurn.Size = new System.Drawing.Size(75, 35);
            this.btnGearTurn.TabIndex = 9;
            this.btnGearTurn.Text = "TurnGear";
            this.btnGearTurn.UseVisualStyleBackColor = true;
            this.btnGearTurn.Click += new System.EventHandler(this.btnGearTurn_Click);
            // 
            // tBResult
            // 
            this.tBResult.Location = new System.Drawing.Point(625, 23);
            this.tBResult.Name = "tBResult";
            this.tBResult.Size = new System.Drawing.Size(83, 20);
            this.tBResult.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBResult);
            this.Controls.Add(this.btnGearTurn);
            this.Controls.Add(this.btnDeleteEdge);
            this.Controls.Add(this.btnDeleteNode);
            this.Controls.Add(this.btnOpenGraph);
            this.Controls.Add(this.btnSaveGraph);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Graph1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBtnNode;
        private System.Windows.Forms.RadioButton rBtnEdge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnSaveGraph;
        private System.Windows.Forms.Button btnOpenGraph;
        private System.Windows.Forms.OpenFileDialog oFD;
        private System.Windows.Forms.SaveFileDialog sFD;
        private System.Windows.Forms.RadioButton rBtnDistInfo;
        private System.Windows.Forms.Button btnDeleteNode;
        private System.Windows.Forms.Button btnDeleteEdge;
        private System.Windows.Forms.Button btnGearTurn;
        private System.Windows.Forms.TextBox tBResult;
    }
}

