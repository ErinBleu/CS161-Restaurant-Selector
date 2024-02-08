namespace RestaurantSelector
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
            groupBox1 = new GroupBox();
            choicescheckedList = new CheckedListBox();
            label1 = new Label();
            calculateButton = new Button();
            exitButton = new Button();
            restaurantsLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(choicescheckedList);
            groupBox1.Location = new Point(61, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select dietary restrictions:";
            // 
            // choicescheckedList
            // 
            choicescheckedList.BackColor = SystemColors.Control;
            choicescheckedList.BorderStyle = BorderStyle.None;
            choicescheckedList.FormattingEnabled = true;
            choicescheckedList.Items.AddRange(new object[] { "Vegetarian", "Vegan", "Gluten-Free" });
            choicescheckedList.Location = new Point(47, 40);
            choicescheckedList.Name = "choicescheckedList";
            choicescheckedList.Size = new Size(180, 84);
            choicescheckedList.TabIndex = 0;
            choicescheckedList.SelectedIndexChanged += choicescheckedList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 210);
            label1.Name = "label1";
            label1.Size = new Size(322, 25);
            label1.TabIndex = 0;
            label1.Text = "These are your local restaurant options:";
            label1.Click += label1_Click;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(61, 436);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(112, 59);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Show Restaurants";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(249, 436);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 59);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // restaurantsLabel
            // 
            restaurantsLabel.BackColor = Color.Transparent;
            restaurantsLabel.BorderStyle = BorderStyle.Fixed3D;
            restaurantsLabel.Location = new Point(61, 260);
            restaurantsLabel.Name = "restaurantsLabel";
            restaurantsLabel.Size = new Size(300, 133);
            restaurantsLabel.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 522);
            Controls.Add(restaurantsLabel);
            Controls.Add(exitButton);
            Controls.Add(calculateButton);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Restaurant Selector";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button calculateButton;
        private Button exitButton;
        private CheckedListBox choicescheckedList;
        private Label restaurantsLabel;
    }
}
