﻿namespace InventoryManagementSystem
{
    partial class MainForm
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
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.partsSearchTextBox = new System.Windows.Forms.TextBox();
            this.partsListView = new System.Windows.Forms.ListView();
            this.partsLabel = new System.Windows.Forms.Label();
            this.partsAddButton = new System.Windows.Forms.Button();
            this.partsModifyButton = new System.Windows.Forms.Button();
            this.partsDeleteButton = new System.Windows.Forms.Button();
            this.productsDeleteButton = new System.Windows.Forms.Button();
            this.productsModifyButton = new System.Windows.Forms.Button();
            this.productsAddButton = new System.Windows.Forms.Button();
            this.productsLabel = new System.Windows.Forms.Label();
            this.productsListView = new System.Windows.Forms.ListView();
            this.productsSearchTextbox = new System.Windows.Forms.TextBox();
            this.productsSearchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Location = new System.Drawing.Point(155, 46);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.partsSearchButton.TabIndex = 1;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            // 
            // partsSearchTextBox
            // 
            this.partsSearchTextBox.Location = new System.Drawing.Point(236, 46);
            this.partsSearchTextBox.Name = "partsSearchTextBox";
            this.partsSearchTextBox.Size = new System.Drawing.Size(163, 20);
            this.partsSearchTextBox.TabIndex = 2;
            // 
            // partsListView
            // 
            this.partsListView.HideSelection = false;
            this.partsListView.Location = new System.Drawing.Point(16, 75);
            this.partsListView.Name = "partsListView";
            this.partsListView.Size = new System.Drawing.Size(383, 305);
            this.partsListView.TabIndex = 3;
            this.partsListView.UseCompatibleStateImageBehavior = false;
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(16, 56);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(31, 13);
            this.partsLabel.TabIndex = 4;
            this.partsLabel.Text = "Parts";
            // 
            // partsAddButton
            // 
            this.partsAddButton.Location = new System.Drawing.Point(186, 386);
            this.partsAddButton.Name = "partsAddButton";
            this.partsAddButton.Size = new System.Drawing.Size(51, 30);
            this.partsAddButton.TabIndex = 5;
            this.partsAddButton.Text = "Add";
            this.partsAddButton.UseVisualStyleBackColor = true;
            // 
            // partsModifyButton
            // 
            this.partsModifyButton.Location = new System.Drawing.Point(267, 386);
            this.partsModifyButton.Name = "partsModifyButton";
            this.partsModifyButton.Size = new System.Drawing.Size(51, 30);
            this.partsModifyButton.TabIndex = 6;
            this.partsModifyButton.Text = "Modify";
            this.partsModifyButton.UseVisualStyleBackColor = true;
            // 
            // partsDeleteButton
            // 
            this.partsDeleteButton.Location = new System.Drawing.Point(348, 386);
            this.partsDeleteButton.Name = "partsDeleteButton";
            this.partsDeleteButton.Size = new System.Drawing.Size(51, 30);
            this.partsDeleteButton.TabIndex = 7;
            this.partsDeleteButton.Text = "Delete";
            this.partsDeleteButton.UseVisualStyleBackColor = true;
            // 
            // productsDeleteButton
            // 
            this.productsDeleteButton.Location = new System.Drawing.Point(767, 386);
            this.productsDeleteButton.Name = "productsDeleteButton";
            this.productsDeleteButton.Size = new System.Drawing.Size(51, 30);
            this.productsDeleteButton.TabIndex = 14;
            this.productsDeleteButton.Text = "Delete";
            this.productsDeleteButton.UseVisualStyleBackColor = true;
            // 
            // productsModifyButton
            // 
            this.productsModifyButton.Location = new System.Drawing.Point(686, 386);
            this.productsModifyButton.Name = "productsModifyButton";
            this.productsModifyButton.Size = new System.Drawing.Size(51, 30);
            this.productsModifyButton.TabIndex = 13;
            this.productsModifyButton.Text = "Modify";
            this.productsModifyButton.UseVisualStyleBackColor = true;
            // 
            // productsAddButton
            // 
            this.productsAddButton.Location = new System.Drawing.Point(605, 386);
            this.productsAddButton.Name = "productsAddButton";
            this.productsAddButton.Size = new System.Drawing.Size(51, 30);
            this.productsAddButton.TabIndex = 12;
            this.productsAddButton.Text = "Add";
            this.productsAddButton.UseVisualStyleBackColor = true;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Location = new System.Drawing.Point(435, 56);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(49, 13);
            this.productsLabel.TabIndex = 11;
            this.productsLabel.Text = "Products";
            // 
            // productsListView
            // 
            this.productsListView.HideSelection = false;
            this.productsListView.Location = new System.Drawing.Point(435, 75);
            this.productsListView.Name = "productsListView";
            this.productsListView.Size = new System.Drawing.Size(383, 305);
            this.productsListView.TabIndex = 10;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            // 
            // productsSearchTextbox
            // 
            this.productsSearchTextbox.Location = new System.Drawing.Point(655, 46);
            this.productsSearchTextbox.Name = "productsSearchTextbox";
            this.productsSearchTextbox.Size = new System.Drawing.Size(163, 20);
            this.productsSearchTextbox.TabIndex = 9;
            // 
            // productsSearchButton
            // 
            this.productsSearchButton.Location = new System.Drawing.Point(574, 46);
            this.productsSearchButton.Name = "productsSearchButton";
            this.productsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.productsSearchButton.TabIndex = 8;
            this.productsSearchButton.Text = "Search";
            this.productsSearchButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(767, 425);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(51, 30);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 467);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.productsDeleteButton);
            this.Controls.Add(this.productsModifyButton);
            this.Controls.Add(this.productsAddButton);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.productsListView);
            this.Controls.Add(this.productsSearchTextbox);
            this.Controls.Add(this.productsSearchButton);
            this.Controls.Add(this.partsDeleteButton);
            this.Controls.Add(this.partsModifyButton);
            this.Controls.Add(this.partsAddButton);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.partsListView);
            this.Controls.Add(this.partsSearchTextBox);
            this.Controls.Add(this.partsSearchButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.TextBox partsSearchTextBox;
        private System.Windows.Forms.ListView partsListView;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Button partsAddButton;
        private System.Windows.Forms.Button partsModifyButton;
        private System.Windows.Forms.Button partsDeleteButton;
        private System.Windows.Forms.Button productsDeleteButton;
        private System.Windows.Forms.Button productsModifyButton;
        private System.Windows.Forms.Button productsAddButton;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.ListView productsListView;
        private System.Windows.Forms.TextBox productsSearchTextbox;
        private System.Windows.Forms.Button productsSearchButton;
        private System.Windows.Forms.Button exitButton;
    }
}

