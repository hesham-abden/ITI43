namespace XML
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
            this.name = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.building = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prev = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(82, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(231, 20);
            this.name.TabIndex = 0;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(82, 53);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(231, 20);
            this.phone.TabIndex = 1;
            // 
            // building
            // 
            this.building.Location = new System.Drawing.Point(82, 105);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(143, 20);
            this.building.TabIndex = 2;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(82, 193);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(231, 20);
            this.email.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email :";
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(138, 219);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(53, 23);
            this.prev.TabIndex = 9;
            this.prev.Text = "<<";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(197, 219);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(53, 23);
            this.update.TabIndex = 10;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(256, 219);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(57, 23);
            this.insert.TabIndex = 11;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(82, 219);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(50, 23);
            this.next.TabIndex = 8;
            this.next.Text = ">>";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(235, 161);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(78, 28);
            this.search.TabIndex = 12;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // delete
            // 
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delete.Location = new System.Drawing.Point(235, 118);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(78, 28);
            this.delete.TabIndex = 13;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(235, 77);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(78, 28);
            this.save.TabIndex = 14;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Street :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Building :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Address :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Address :";
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(82, 79);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(143, 20);
            this.street.TabIndex = 19;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(82, 135);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(143, 20);
            this.city.TabIndex = 20;
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(82, 161);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(143, 20);
            this.country.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(338, 255);
            this.Controls.Add(this.country);
            this.Controls.Add(this.city);
            this.Controls.Add(this.street);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.save);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.search);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.update);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.building);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox building;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox country;
    }
}

