namespace sortingAlgorithms
{
    partial class sortingForm
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
            this.generateButton = new System.Windows.Forms.Button();
            this.randBox = new System.Windows.Forms.ListBox();
            this.outputBox = new System.Windows.Forms.ListBox();
            this.quickSortButton = new System.Windows.Forms.Button();
            this.bubbleSortButton = new System.Windows.Forms.Button();
            this.mergeSortButton = new System.Windows.Forms.Button();
            this.insertionSortButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.heapSortButton = new System.Windows.Forms.Button();
            this.selectSortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(39, 342);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // randBox
            // 
            this.randBox.FormattingEnabled = true;
            this.randBox.Location = new System.Drawing.Point(39, 41);
            this.randBox.Name = "randBox";
            this.randBox.Size = new System.Drawing.Size(192, 290);
            this.randBox.TabIndex = 1;
            // 
            // outputBox
            // 
            this.outputBox.FormattingEnabled = true;
            this.outputBox.Location = new System.Drawing.Point(548, 41);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(192, 290);
            this.outputBox.TabIndex = 2;
            // 
            // quickSortButton
            // 
            this.quickSortButton.Location = new System.Drawing.Point(271, 64);
            this.quickSortButton.Name = "quickSortButton";
            this.quickSortButton.Size = new System.Drawing.Size(92, 48);
            this.quickSortButton.TabIndex = 3;
            this.quickSortButton.Text = "Quick Sort";
            this.quickSortButton.UseVisualStyleBackColor = true;
            // 
            // bubbleSortButton
            // 
            this.bubbleSortButton.Location = new System.Drawing.Point(271, 139);
            this.bubbleSortButton.Name = "bubbleSortButton";
            this.bubbleSortButton.Size = new System.Drawing.Size(92, 48);
            this.bubbleSortButton.TabIndex = 4;
            this.bubbleSortButton.Text = "Bubble Sort";
            this.bubbleSortButton.UseVisualStyleBackColor = true;
            // 
            // mergeSortButton
            // 
            this.mergeSortButton.Location = new System.Drawing.Point(415, 64);
            this.mergeSortButton.Name = "mergeSortButton";
            this.mergeSortButton.Size = new System.Drawing.Size(92, 48);
            this.mergeSortButton.TabIndex = 5;
            this.mergeSortButton.Text = "Merge Sort";
            this.mergeSortButton.UseVisualStyleBackColor = true;
            // 
            // insertionSortButton
            // 
            this.insertionSortButton.Location = new System.Drawing.Point(415, 139);
            this.insertionSortButton.Name = "insertionSortButton";
            this.insertionSortButton.Size = new System.Drawing.Size(92, 48);
            this.insertionSortButton.TabIndex = 6;
            this.insertionSortButton.Text = "Insertion Sort";
            this.insertionSortButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(665, 342);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // heapSortButton
            // 
            this.heapSortButton.Location = new System.Drawing.Point(271, 217);
            this.heapSortButton.Name = "heapSortButton";
            this.heapSortButton.Size = new System.Drawing.Size(92, 48);
            this.heapSortButton.TabIndex = 8;
            this.heapSortButton.Text = "Heap Sort";
            this.heapSortButton.UseVisualStyleBackColor = true;
            // 
            // selectSortButton
            // 
            this.selectSortButton.Location = new System.Drawing.Point(415, 217);
            this.selectSortButton.Name = "selectSortButton";
            this.selectSortButton.Size = new System.Drawing.Size(92, 48);
            this.selectSortButton.TabIndex = 9;
            this.selectSortButton.Text = "Selection Sort";
            this.selectSortButton.UseVisualStyleBackColor = true;
            // 
            // sortingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 407);
            this.Controls.Add(this.selectSortButton);
            this.Controls.Add(this.heapSortButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.insertionSortButton);
            this.Controls.Add(this.mergeSortButton);
            this.Controls.Add(this.bubbleSortButton);
            this.Controls.Add(this.quickSortButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.randBox);
            this.Controls.Add(this.generateButton);
            this.Name = "sortingForm";
            this.Text = "Sorting Algorithms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.ListBox randBox;
        private System.Windows.Forms.ListBox outputBox;
        private System.Windows.Forms.Button quickSortButton;
        private System.Windows.Forms.Button bubbleSortButton;
        private System.Windows.Forms.Button mergeSortButton;
        private System.Windows.Forms.Button insertionSortButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button heapSortButton;
        private System.Windows.Forms.Button selectSortButton;
    }
}

