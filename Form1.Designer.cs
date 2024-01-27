namespace JSON_Explorer
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
            this.controlFlowGraph = new System.Windows.Forms.GroupBox();
            this.memoryViewer = new System.Windows.Forms.GroupBox();
            this.funtionViewer = new System.Windows.Forms.GroupBox();
            this.registerViewer = new System.Windows.Forms.GroupBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.importFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.registerViewerDisplay = new System.Windows.Forms.DataGridView();
            this.functionViewBox = new System.Windows.Forms.ListBox();
            this.memoryViewBox = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.controlFlowGraph.SuspendLayout();
            this.memoryViewer.SuspendLayout();
            this.funtionViewer.SuspendLayout();
            this.registerViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerViewerDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // controlFlowGraph
            // 
            this.controlFlowGraph.Controls.Add(this.richTextBox1);
            this.controlFlowGraph.Location = new System.Drawing.Point(314, 77);
            this.controlFlowGraph.Name = "controlFlowGraph";
            this.controlFlowGraph.Size = new System.Drawing.Size(480, 372);
            this.controlFlowGraph.TabIndex = 0;
            this.controlFlowGraph.TabStop = false;
            this.controlFlowGraph.Text = "controlFlowGraph";
            // 
            // memoryViewer
            // 
            this.memoryViewer.Controls.Add(this.memoryViewBox);
            this.memoryViewer.Location = new System.Drawing.Point(13, 77);
            this.memoryViewer.Name = "memoryViewer";
            this.memoryViewer.Size = new System.Drawing.Size(255, 372);
            this.memoryViewer.TabIndex = 1;
            this.memoryViewer.TabStop = false;
            this.memoryViewer.Text = "Memory Viewer";
            // 
            // funtionViewer
            // 
            this.funtionViewer.Controls.Add(this.functionViewBox);
            this.funtionViewer.Location = new System.Drawing.Point(832, 77);
            this.funtionViewer.Name = "funtionViewer";
            this.funtionViewer.Size = new System.Drawing.Size(244, 372);
            this.funtionViewer.TabIndex = 2;
            this.funtionViewer.TabStop = false;
            this.funtionViewer.Text = "Funtion Viewer";
            // 
            // registerViewer
            // 
            this.registerViewer.Controls.Add(this.registerViewerDisplay);
            this.registerViewer.Location = new System.Drawing.Point(263, 455);
            this.registerViewer.Name = "registerViewer";
            this.registerViewer.Size = new System.Drawing.Size(575, 129);
            this.registerViewer.TabIndex = 3;
            this.registerViewer.TabStop = false;
            this.registerViewer.Text = "Register Viewer";
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(78, 469);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(100, 100);
            this.previousButton.TabIndex = 4;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(920, 469);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 100);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // importFileButton
            // 
            this.importFileButton.Location = new System.Drawing.Point(647, 12);
            this.importFileButton.Name = "importFileButton";
            this.importFileButton.Size = new System.Drawing.Size(106, 43);
            this.importFileButton.TabIndex = 6;
            this.importFileButton.Text = "Import File";
            this.importFileButton.UseVisualStyleBackColor = true;
            this.importFileButton.Click += new System.EventHandler(this.importFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(468, 345);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // registerViewerDisplay
            // 
            this.registerViewerDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.registerViewerDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registerViewerDisplay.Location = new System.Drawing.Point(6, 14);
            this.registerViewerDisplay.Name = "registerViewerDisplay";
            this.registerViewerDisplay.RowHeadersWidth = 25;
            this.registerViewerDisplay.RowTemplate.Height = 24;
            this.registerViewerDisplay.Size = new System.Drawing.Size(563, 109);
            this.registerViewerDisplay.TabIndex = 0;
            this.registerViewerDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registerViewerDisplay_CellContentClick);
            // 
            // functionViewBox
            // 
            this.functionViewBox.FormattingEnabled = true;
            this.functionViewBox.ItemHeight = 16;
            this.functionViewBox.Location = new System.Drawing.Point(7, 22);
            this.functionViewBox.Name = "functionViewBox";
            this.functionViewBox.Size = new System.Drawing.Size(231, 340);
            this.functionViewBox.TabIndex = 0;
            // 
            // memoryViewBox
            // 
            this.memoryViewBox.FormattingEnabled = true;
            this.memoryViewBox.ItemHeight = 16;
            this.memoryViewBox.Location = new System.Drawing.Point(7, 21);
            this.memoryViewBox.Name = "memoryViewBox";
            this.memoryViewBox.Size = new System.Drawing.Size(242, 340);
            this.memoryViewBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1101, 596);
            this.Controls.Add(this.importFileButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.registerViewer);
            this.Controls.Add(this.funtionViewer);
            this.Controls.Add(this.memoryViewer);
            this.Controls.Add(this.controlFlowGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.controlFlowGraph.ResumeLayout(false);
            this.memoryViewer.ResumeLayout(false);
            this.funtionViewer.ResumeLayout(false);
            this.registerViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.registerViewerDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controlFlowGraph;
        private System.Windows.Forms.GroupBox memoryViewer;
        private System.Windows.Forms.GroupBox funtionViewer;
        private System.Windows.Forms.GroupBox registerViewer;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button importFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView registerViewerDisplay;
        private System.Windows.Forms.ListBox functionViewBox;
        private System.Windows.Forms.ListBox memoryViewBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

