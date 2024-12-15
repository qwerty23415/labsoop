namespace projectoop
{
    partial class FormTruck
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
            pictureTruck = new PictureBox();
            buttonCreate = new Button();
            buttonLeft = new Button();
            buttonDown = new Button();
            buttonRight = new Button();
            buttonUp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureTruck).BeginInit();
            SuspendLayout();
            // 
            // pictureTruck
            // 
            pictureTruck.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureTruck.Location = new Point(0, 0);
            pictureTruck.Name = "pictureTruck";
            pictureTruck.Size = new Size(800, 450);
            pictureTruck.TabIndex = 0;
            pictureTruck.TabStop = false;
            pictureTruck.Click += pictureTruck_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCreate.Location = new Point(12, 408);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(76, 30);
            buttonCreate.TabIndex = 1;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = true;
            // 
            // buttonLeft
            // 
            buttonLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLeft.BackgroundImage = Properties.Resources.left1;
            buttonLeft.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLeft.Location = new Point(617, 403);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(35, 35);
            buttonLeft.TabIndex = 2;
            buttonLeft.UseVisualStyleBackColor = true;
            // 
            // buttonDown
            // 
            buttonDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDown.BackgroundImage = Properties.Resources.down1;
            buttonDown.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDown.Location = new Point(658, 403);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(35, 35);
            buttonDown.TabIndex = 3;
            buttonDown.UseVisualStyleBackColor = true;
            // 
            // buttonRight
            // 
            buttonRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRight.BackgroundImage = Properties.Resources.right1;
            buttonRight.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRight.Location = new Point(699, 403);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(35, 35);
            buttonRight.TabIndex = 4;
            buttonRight.UseVisualStyleBackColor = true;
            // 
            // buttonUp
            // 
            buttonUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUp.BackgroundImage = Properties.Resources.up1;
            buttonUp.BackgroundImageLayout = ImageLayout.Stretch;
            buttonUp.Location = new Point(658, 362);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(35, 35);
            buttonUp.TabIndex = 5;
            buttonUp.UseVisualStyleBackColor = true;
            // 
            // FormTruck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonUp);
            Controls.Add(buttonRight);
            Controls.Add(buttonDown);
            Controls.Add(buttonLeft);
            Controls.Add(buttonCreate);
            Controls.Add(pictureTruck);
            Name = "FormTruck";
            Text = "Самосвал";
            ((System.ComponentModel.ISupportInitialize)pictureTruck).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureTruck;
        private Button buttonCreate;
        private Button buttonLeft;
        private Button buttonDown;
        private Button buttonRight;
        private Button buttonUp;
    }
}