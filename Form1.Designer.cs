namespace Lab_6_Hotel
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
            this.listBoxList = new System.Windows.Forms.ListBox();
            this.listBoxMoreThenHour = new System.Windows.Forms.ListBox();
            this.labelList = new System.Windows.Forms.Label();
            this.labelMoreThenHour = new System.Windows.Forms.Label();
            this.labelSortByRoom = new System.Windows.Forms.Label();
            this.listBoxSortByRoom = new System.Windows.Forms.ListBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonWriteMoreThenHour = new System.Windows.Forms.Button();
            this.buttonWriteSortByRoom = new System.Windows.Forms.Button();
            this.labelDetailInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.textBoxArriveDate = new System.Windows.Forms.TextBox();
            this.textBoxDepartureDate = new System.Windows.Forms.TextBox();
            this.textBoxRoom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxList
            // 
            this.listBoxList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxList.FormattingEnabled = true;
            this.listBoxList.ItemHeight = 16;
            this.listBoxList.Location = new System.Drawing.Point(50, 80);
            this.listBoxList.Name = "listBoxList";
            this.listBoxList.Size = new System.Drawing.Size(300, 292);
            this.listBoxList.TabIndex = 0;
            this.listBoxList.SelectedIndexChanged += new System.EventHandler(this.listBoxList_SelectedIndexChanged);
            // 
            // listBoxMoreThenHour
            // 
            this.listBoxMoreThenHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxMoreThenHour.FormattingEnabled = true;
            this.listBoxMoreThenHour.ItemHeight = 16;
            this.listBoxMoreThenHour.Location = new System.Drawing.Point(354, 80);
            this.listBoxMoreThenHour.Name = "listBoxMoreThenHour";
            this.listBoxMoreThenHour.Size = new System.Drawing.Size(300, 292);
            this.listBoxMoreThenHour.TabIndex = 1;
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelList.Location = new System.Drawing.Point(50, 50);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(197, 20);
            this.labelList.TabIndex = 2;
            this.labelList.Text = "Список відвідувачів";
            // 
            // labelMoreThenHour
            // 
            this.labelMoreThenHour.AutoSize = true;
            this.labelMoreThenHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoreThenHour.Location = new System.Drawing.Point(350, 50);
            this.labelMoreThenHour.Name = "labelMoreThenHour";
            this.labelMoreThenHour.Size = new System.Drawing.Size(252, 20);
            this.labelMoreThenHour.TabIndex = 3;
            this.labelMoreThenHour.Text = "Ті хто були більше години";
            // 
            // labelSortByRoom
            // 
            this.labelSortByRoom.AutoSize = true;
            this.labelSortByRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSortByRoom.Location = new System.Drawing.Point(660, 50);
            this.labelSortByRoom.Name = "labelSortByRoom";
            this.labelSortByRoom.Size = new System.Drawing.Size(240, 20);
            this.labelSortByRoom.TabIndex = 4;
            this.labelSortByRoom.Text = "Посортовані за номером";
            // 
            // listBoxSortByRoom
            // 
            this.listBoxSortByRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSortByRoom.FormattingEnabled = true;
            this.listBoxSortByRoom.ItemHeight = 16;
            this.listBoxSortByRoom.Location = new System.Drawing.Point(664, 80);
            this.listBoxSortByRoom.Name = "listBoxSortByRoom";
            this.listBoxSortByRoom.Size = new System.Drawing.Size(300, 292);
            this.listBoxSortByRoom.TabIndex = 5;
            this.listBoxSortByRoom.SelectedIndexChanged += new System.EventHandler(this.listBoxSortByRoom_SelectedIndexChanged);
            // 
            // buttonRead
            // 
            this.buttonRead.AutoSize = true;
            this.buttonRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRead.Location = new System.Drawing.Point(50, 400);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(202, 30);
            this.buttonRead.TabIndex = 6;
            this.buttonRead.Text = "Прочитати з файлу";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonWriteMoreThenHour
            // 
            this.buttonWriteMoreThenHour.AutoSize = true;
            this.buttonWriteMoreThenHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWriteMoreThenHour.Location = new System.Drawing.Point(354, 400);
            this.buttonWriteMoreThenHour.Name = "buttonWriteMoreThenHour";
            this.buttonWriteMoreThenHour.Size = new System.Drawing.Size(282, 30);
            this.buttonWriteMoreThenHour.TabIndex = 7;
            this.buttonWriteMoreThenHour.Text = "Показати і записати у файл";
            this.buttonWriteMoreThenHour.UseVisualStyleBackColor = true;
            this.buttonWriteMoreThenHour.Click += new System.EventHandler(this.buttonWriteMoreThenHour_Click);
            // 
            // buttonWriteSortByRoom
            // 
            this.buttonWriteSortByRoom.AutoSize = true;
            this.buttonWriteSortByRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWriteSortByRoom.Location = new System.Drawing.Point(664, 400);
            this.buttonWriteSortByRoom.Name = "buttonWriteSortByRoom";
            this.buttonWriteSortByRoom.Size = new System.Drawing.Size(282, 30);
            this.buttonWriteSortByRoom.TabIndex = 8;
            this.buttonWriteSortByRoom.Text = "Показати і записати у файл";
            this.buttonWriteSortByRoom.UseVisualStyleBackColor = true;
            this.buttonWriteSortByRoom.Click += new System.EventHandler(this.buttonWriteSortByRoom_Click);
            // 
            // labelDetailInfo
            // 
            this.labelDetailInfo.AutoSize = true;
            this.labelDetailInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDetailInfo.Location = new System.Drawing.Point(50, 460);
            this.labelDetailInfo.Name = "labelDetailInfo";
            this.labelDetailInfo.Size = new System.Drawing.Size(388, 20);
            this.labelDetailInfo.TabIndex = 9;
            this.labelDetailInfo.Text = "Детальніша інформація про відвідувача";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(550, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Повне ім\'я";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(480, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Дата і час прибуття";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(447, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Дата і час відправлення";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(579, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Номер";
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.AutoSize = true;
            this.buttonAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddNew.Location = new System.Drawing.Point(664, 578);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(220, 26);
            this.buttonAddNew.TabIndex = 14;
            this.buttonAddNew.Text = "Додати нового відвідувача";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddName.Location = new System.Drawing.Point(664, 454);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(300, 22);
            this.textBoxAddName.TabIndex = 15;
            // 
            // textBoxArriveDate
            // 
            this.textBoxArriveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxArriveDate.Location = new System.Drawing.Point(664, 484);
            this.textBoxArriveDate.Name = "textBoxArriveDate";
            this.textBoxArriveDate.Size = new System.Drawing.Size(300, 22);
            this.textBoxArriveDate.TabIndex = 16;
            // 
            // textBoxDepartureDate
            // 
            this.textBoxDepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDepartureDate.Location = new System.Drawing.Point(664, 514);
            this.textBoxDepartureDate.Name = "textBoxDepartureDate";
            this.textBoxDepartureDate.Size = new System.Drawing.Size(300, 22);
            this.textBoxDepartureDate.TabIndex = 17;
            // 
            // textBoxRoom
            // 
            this.textBoxRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRoom.Location = new System.Drawing.Point(664, 544);
            this.textBoxRoom.Name = "textBoxRoom";
            this.textBoxRoom.Size = new System.Drawing.Size(300, 22);
            this.textBoxRoom.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 616);
            this.Controls.Add(this.textBoxRoom);
            this.Controls.Add(this.textBoxDepartureDate);
            this.Controls.Add(this.textBoxArriveDate);
            this.Controls.Add(this.textBoxAddName);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDetailInfo);
            this.Controls.Add(this.buttonWriteSortByRoom);
            this.Controls.Add(this.buttonWriteMoreThenHour);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.listBoxSortByRoom);
            this.Controls.Add(this.labelSortByRoom);
            this.Controls.Add(this.labelMoreThenHour);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.listBoxMoreThenHour);
            this.Controls.Add(this.listBoxList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxList;
        private System.Windows.Forms.ListBox listBoxMoreThenHour;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Label labelMoreThenHour;
        private System.Windows.Forms.Label labelSortByRoom;
        private System.Windows.Forms.ListBox listBoxSortByRoom;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonWriteMoreThenHour;
        private System.Windows.Forms.Button buttonWriteSortByRoom;
        private System.Windows.Forms.Label labelDetailInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.TextBox textBoxArriveDate;
        private System.Windows.Forms.TextBox textBoxDepartureDate;
        private System.Windows.Forms.TextBox textBoxRoom;
    }
}

