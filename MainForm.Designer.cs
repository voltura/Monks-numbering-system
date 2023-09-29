namespace Monks
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            txtNumber = new TextBox();
            lblEnterNumber = new Label();
            btnGet = new Button();
            txtMonksNumber = new TextBox();
            toolTip = new ToolTip(components);
            SuspendLayout();
            //
            // txtNumber
            //
            txtNumber.Location = new Point(201, 12);
            txtNumber.MaxLength = 4;
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(225, 43);
            txtNumber.TabIndex = 0;
            toolTip.SetToolTip(txtNumber, "\r\nValid number is 0-9999\r\n");
            //
            // lblEnterNumber
            //
            lblEnterNumber.AutoSize = true;
            lblEnterNumber.Location = new Point(12, 15);
            lblEnterNumber.Name = "lblEnterNumber";
            lblEnterNumber.Size = new Size(183, 37);
            lblEnterNumber.TabIndex = 1;
            lblEnterNumber.Text = "Enter number:";
            //
            // btnGet
            //
            btnGet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGet.Location = new Point(432, 12);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(356, 43);
            btnGet.TabIndex = 2;
            btnGet.Text = "Get Monks number";
            toolTip.SetToolTip(btnGet, "\r\nValid number is 0-9999\r\n");
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += Get_Click;
            //
            // txtMonksNumber
            //
            txtMonksNumber.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMonksNumber.Font = new Font("Aurulent Sans Mono", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonksNumber.Location = new Point(11, 89);
            txtMonksNumber.Multiline = true;
            txtMonksNumber.Name = "txtMonksNumber";
            txtMonksNumber.ReadOnly = true;
            txtMonksNumber.Size = new Size(777, 349);
            txtMonksNumber.TabIndex = 3;
            //
            // toolTip
            //
            toolTip.ShowAlways = true;
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Monks numbering system";
            //
            // MainForm
            //
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMonksNumber);
            Controls.Add(btnGet);
            Controls.Add(lblEnterNumber);
            Controls.Add(txtNumber);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MainForm";
            ShowIcon = false;
            Text = "Monks numbering system";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber;
        private Label lblEnterNumber;
        private Button btnGet;
        private TextBox txtMonksNumber;
        private ToolTip toolTip;
    }
}