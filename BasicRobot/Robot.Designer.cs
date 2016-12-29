namespace Lab3
{
    partial class Robot
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
            this.pnlNav = new System.Windows.Forms.Panel();
            this.lblArrow = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnGoOne = new System.Windows.Forms.Button();
            this.btnGoTen = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNav.Controls.Add(this.lblArrow);
            this.pnlNav.Location = new System.Drawing.Point(12, 38);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(200, 200);
            this.pnlNav.TabIndex = 0;
            // 
            // lblArrow
            // 
            this.lblArrow.AutoSize = true;
            this.lblArrow.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblArrow.Location = new System.Drawing.Point(0, 0);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(47, 12);
            this.lblArrow.TabIndex = 0;
            this.lblArrow.Text = "Arrow";
            this.lblArrow.Click += new System.EventHandler(this.lblArrow_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(9, 9);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(51, 13);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Location:";
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(97, 244);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(31, 23);
            this.btnNorth.TabIndex = 1;
            this.btnNorth.Text = "N";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(97, 287);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(31, 23);
            this.btnSouth.TabIndex = 2;
            this.btnSouth.Text = "S";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(60, 263);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(31, 23);
            this.btnWest.TabIndex = 3;
            this.btnWest.Text = "W";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(134, 263);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(31, 23);
            this.btnEast.TabIndex = 4;
            this.btnEast.Text = "E";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnGoOne
            // 
            this.btnGoOne.Location = new System.Drawing.Point(12, 317);
            this.btnGoOne.Name = "btnGoOne";
            this.btnGoOne.Size = new System.Drawing.Size(75, 23);
            this.btnGoOne.TabIndex = 5;
            this.btnGoOne.Text = "Go 1";
            this.btnGoOne.UseVisualStyleBackColor = true;
            this.btnGoOne.Click += new System.EventHandler(this.btnGoOne_Click);
            // 
            // btnGoTen
            // 
            this.btnGoTen.Location = new System.Drawing.Point(134, 317);
            this.btnGoTen.Name = "btnGoTen";
            this.btnGoTen.Size = new System.Drawing.Size(75, 23);
            this.btnGoTen.TabIndex = 6;
            this.btnGoTen.Text = "Go 10";
            this.btnGoTen.UseVisualStyleBackColor = true;
            this.btnGoTen.Click += new System.EventHandler(this.btnGoTen_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(76, 360);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Robot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 395);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoTen);
            this.Controls.Add(this.btnGoOne);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.pnlNav);
            this.Name = "Robot";
            this.Text = "Robot";
            this.Load += new System.EventHandler(this.Robot_Load);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnGoOne;
        private System.Windows.Forms.Button btnGoTen;
        private System.Windows.Forms.Button btnExit;
    }
}

