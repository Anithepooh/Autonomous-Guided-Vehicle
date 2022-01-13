namespace ROS_AGV
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox_PLC = new System.Windows.Forms.PictureBox();
            this.gpb_Type_TCP = new System.Windows.Forms.GroupBox();
            this.rtb_response = new System.Windows.Forms.RichTextBox();
            this.txb_Tcp_Port = new System.Windows.Forms.TextBox();
            this.Arrive_P3 = new System.Windows.Forms.Button();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.Arrive_P2 = new System.Windows.Forms.Button();
            this.txb_Tcp_Ip = new System.Windows.Forms.TextBox();
            this.Arrive_P1 = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.Upload_test = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_sql_rdtable = new System.Windows.Forms.TextBox();
            this.SQL_Upload = new System.Windows.Forms.Button();
            this.SQL_Download = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.txb_sql_uptable = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txb_sql_severip = new System.Windows.Forms.TextBox();
            this.txb_sql_port = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txb_sql_userid = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txb_sql_password = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txb_sql_database = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ROS_RUN = new System.Windows.Forms.Button();
            this.node_name = new System.Windows.Forms.TextBox();
            this.package_name = new System.Windows.Forms.TextBox();
            this.ROS_IP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.read = new System.Windows.Forms.Button();
            this.Action_start = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PLC)).BeginInit();
            this.gpb_Type_TCP.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_PLC
            // 
            this.pictureBox_PLC.Location = new System.Drawing.Point(137, 27);
            this.pictureBox_PLC.Name = "pictureBox_PLC";
            this.pictureBox_PLC.Size = new System.Drawing.Size(40, 37);
            this.pictureBox_PLC.TabIndex = 4;
            this.pictureBox_PLC.TabStop = false;
            // 
            // gpb_Type_TCP
            // 
            this.gpb_Type_TCP.Controls.Add(this.pictureBox_PLC);
            this.gpb_Type_TCP.Controls.Add(this.rtb_response);
            this.gpb_Type_TCP.Controls.Add(this.txb_Tcp_Port);
            this.gpb_Type_TCP.Controls.Add(this.Arrive_P3);
            this.gpb_Type_TCP.Controls.Add(this.btn_Disconnect);
            this.gpb_Type_TCP.Controls.Add(this.Arrive_P2);
            this.gpb_Type_TCP.Controls.Add(this.txb_Tcp_Ip);
            this.gpb_Type_TCP.Controls.Add(this.Arrive_P1);
            this.gpb_Type_TCP.Controls.Add(this.btn_Connect);
            this.gpb_Type_TCP.Controls.Add(this.label6);
            this.gpb_Type_TCP.Controls.Add(this.label5);
            this.gpb_Type_TCP.Location = new System.Drawing.Point(8, 12);
            this.gpb_Type_TCP.Name = "gpb_Type_TCP";
            this.gpb_Type_TCP.Size = new System.Drawing.Size(300, 149);
            this.gpb_Type_TCP.TabIndex = 8;
            this.gpb_Type_TCP.TabStop = false;
            this.gpb_Type_TCP.Text = "Robot_IP";
            // 
            // rtb_response
            // 
            this.rtb_response.Location = new System.Drawing.Point(183, 103);
            this.rtb_response.Name = "rtb_response";
            this.rtb_response.Size = new System.Drawing.Size(101, 39);
            this.rtb_response.TabIndex = 12;
            this.rtb_response.Text = "";
            // 
            // txb_Tcp_Port
            // 
            this.txb_Tcp_Port.Location = new System.Drawing.Point(38, 49);
            this.txb_Tcp_Port.Name = "txb_Tcp_Port";
            this.txb_Tcp_Port.Size = new System.Drawing.Size(93, 22);
            this.txb_Tcp_Port.TabIndex = 5;
            this.txb_Tcp_Port.Text = "502";
            // 
            // Arrive_P3
            // 
            this.Arrive_P3.Location = new System.Drawing.Point(183, 74);
            this.Arrive_P3.Name = "Arrive_P3";
            this.Arrive_P3.Size = new System.Drawing.Size(101, 23);
            this.Arrive_P3.TabIndex = 9;
            this.Arrive_P3.Text = "Arrive_P3";
            this.Arrive_P3.UseVisualStyleBackColor = true;
            this.Arrive_P3.Click += new System.EventHandler(this.Arrive_P3_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(95, 81);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(75, 61);
            this.btn_Disconnect.TabIndex = 10;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // Arrive_P2
            // 
            this.Arrive_P2.Location = new System.Drawing.Point(183, 45);
            this.Arrive_P2.Name = "Arrive_P2";
            this.Arrive_P2.Size = new System.Drawing.Size(101, 23);
            this.Arrive_P2.TabIndex = 9;
            this.Arrive_P2.Text = "Arrive_P2";
            this.Arrive_P2.UseVisualStyleBackColor = true;
            this.Arrive_P2.Click += new System.EventHandler(this.Arrive_P2_Click);
            // 
            // txb_Tcp_Ip
            // 
            this.txb_Tcp_Ip.Location = new System.Drawing.Point(38, 21);
            this.txb_Tcp_Ip.Name = "txb_Tcp_Ip";
            this.txb_Tcp_Ip.Size = new System.Drawing.Size(93, 22);
            this.txb_Tcp_Ip.TabIndex = 5;
            this.txb_Tcp_Ip.Text = "192.168.50.217";
            // 
            // Arrive_P1
            // 
            this.Arrive_P1.Location = new System.Drawing.Point(183, 16);
            this.Arrive_P1.Name = "Arrive_P1";
            this.Arrive_P1.Size = new System.Drawing.Size(101, 23);
            this.Arrive_P1.TabIndex = 9;
            this.Arrive_P1.Text = "Arrive_P1";
            this.Arrive_P1.UseVisualStyleBackColor = true;
            this.Arrive_P1.Click += new System.EventHandler(this.Arrive_P1_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(6, 81);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 61);
            this.btn_Connect.TabIndex = 9;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "IP";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.Upload_test);
            this.groupBox19.Controls.Add(this.label1);
            this.groupBox19.Controls.Add(this.txb_sql_rdtable);
            this.groupBox19.Controls.Add(this.SQL_Upload);
            this.groupBox19.Controls.Add(this.SQL_Download);
            this.groupBox19.Controls.Add(this.label40);
            this.groupBox19.Controls.Add(this.txb_sql_uptable);
            this.groupBox19.Controls.Add(this.label39);
            this.groupBox19.Controls.Add(this.txb_sql_severip);
            this.groupBox19.Controls.Add(this.txb_sql_port);
            this.groupBox19.Controls.Add(this.label36);
            this.groupBox19.Controls.Add(this.txb_sql_userid);
            this.groupBox19.Controls.Add(this.label35);
            this.groupBox19.Controls.Add(this.txb_sql_password);
            this.groupBox19.Controls.Add(this.label34);
            this.groupBox19.Controls.Add(this.txb_sql_database);
            this.groupBox19.Controls.Add(this.label33);
            this.groupBox19.Controls.Add(this.label32);
            this.groupBox19.Location = new System.Drawing.Point(8, 167);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(300, 200);
            this.groupBox19.TabIndex = 33;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "SQL Setting";
            // 
            // Upload_test
            // 
            this.Upload_test.Location = new System.Drawing.Point(79, 136);
            this.Upload_test.Name = "Upload_test";
            this.Upload_test.Size = new System.Drawing.Size(81, 22);
            this.Upload_test.TabIndex = 37;
            this.Upload_test.Text = "arrival_P1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 12);
            this.label1.TabIndex = 36;
            this.label1.Text = "\"\"";
            // 
            // txb_sql_rdtable
            // 
            this.txb_sql_rdtable.Location = new System.Drawing.Point(235, 75);
            this.txb_sql_rdtable.Name = "txb_sql_rdtable";
            this.txb_sql_rdtable.Size = new System.Drawing.Size(49, 22);
            this.txb_sql_rdtable.TabIndex = 32;
            this.txb_sql_rdtable.Text = "agv";
            // 
            // SQL_Upload
            // 
            this.SQL_Upload.Location = new System.Drawing.Point(10, 136);
            this.SQL_Upload.Name = "SQL_Upload";
            this.SQL_Upload.Size = new System.Drawing.Size(63, 23);
            this.SQL_Upload.TabIndex = 34;
            this.SQL_Upload.Text = "SQL_Utest";
            this.SQL_Upload.UseVisualStyleBackColor = true;
            this.SQL_Upload.Click += new System.EventHandler(this.SQL_Upload_Click);
            // 
            // SQL_Download
            // 
            this.SQL_Download.Location = new System.Drawing.Point(10, 165);
            this.SQL_Download.Name = "SQL_Download";
            this.SQL_Download.Size = new System.Drawing.Size(63, 23);
            this.SQL_Download.TabIndex = 34;
            this.SQL_Download.Text = "SQL_Dtest";
            this.SQL_Download.UseVisualStyleBackColor = true;
            this.SQL_Download.Click += new System.EventHandler(this.SQL_Download_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(166, 78);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(58, 12);
            this.label40.TabIndex = 31;
            this.label40.Text = "Read Table";
            // 
            // txb_sql_uptable
            // 
            this.txb_sql_uptable.Location = new System.Drawing.Point(235, 50);
            this.txb_sql_uptable.Name = "txb_sql_uptable";
            this.txb_sql_uptable.Size = new System.Drawing.Size(49, 22);
            this.txb_sql_uptable.TabIndex = 29;
            this.txb_sql_uptable.Text = "agv";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(166, 53);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(68, 12);
            this.label39.TabIndex = 30;
            this.label39.Text = "Upload Table";
            // 
            // txb_sql_severip
            // 
            this.txb_sql_severip.Location = new System.Drawing.Point(79, 22);
            this.txb_sql_severip.Name = "txb_sql_severip";
            this.txb_sql_severip.Size = new System.Drawing.Size(81, 22);
            this.txb_sql_severip.TabIndex = 18;
            this.txb_sql_severip.Text = "192.168.21.137";
            // 
            // txb_sql_port
            // 
            this.txb_sql_port.Location = new System.Drawing.Point(79, 50);
            this.txb_sql_port.Name = "txb_sql_port";
            this.txb_sql_port.Size = new System.Drawing.Size(81, 22);
            this.txb_sql_port.TabIndex = 19;
            this.txb_sql_port.Text = "3306";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(166, 25);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(46, 12);
            this.label36.TabIndex = 28;
            this.label36.Text = "Database";
            // 
            // txb_sql_userid
            // 
            this.txb_sql_userid.Location = new System.Drawing.Point(79, 78);
            this.txb_sql_userid.Name = "txb_sql_userid";
            this.txb_sql_userid.Size = new System.Drawing.Size(81, 22);
            this.txb_sql_userid.TabIndex = 20;
            this.txb_sql_userid.Text = "pallet";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(10, 109);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(48, 12);
            this.label35.TabIndex = 27;
            this.label35.Text = "Password";
            // 
            // txb_sql_password
            // 
            this.txb_sql_password.Location = new System.Drawing.Point(79, 106);
            this.txb_sql_password.Name = "txb_sql_password";
            this.txb_sql_password.Size = new System.Drawing.Size(81, 22);
            this.txb_sql_password.TabIndex = 21;
            this.txb_sql_password.Text = "40227000";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(10, 81);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(38, 12);
            this.label34.TabIndex = 26;
            this.label34.Text = "UserID";
            // 
            // txb_sql_database
            // 
            this.txb_sql_database.Location = new System.Drawing.Point(235, 22);
            this.txb_sql_database.Name = "txb_sql_database";
            this.txb_sql_database.Size = new System.Drawing.Size(49, 22);
            this.txb_sql_database.TabIndex = 22;
            this.txb_sql_database.Text = "agvkw";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(10, 53);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(24, 12);
            this.label33.TabIndex = 25;
            this.label33.Text = "Port";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(10, 25);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(44, 12);
            this.label32.TabIndex = 24;
            this.label32.Text = "Sever IP";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(192, 26);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(20, 95);
            this.webBrowser1.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ROS_RUN);
            this.groupBox1.Controls.Add(this.webBrowser1);
            this.groupBox1.Controls.Add(this.node_name);
            this.groupBox1.Controls.Add(this.package_name);
            this.groupBox1.Controls.Add(this.ROS_IP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(328, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 148);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ROS";
            // 
            // ROS_RUN
            // 
            this.ROS_RUN.Location = new System.Drawing.Point(21, 102);
            this.ROS_RUN.Name = "ROS_RUN";
            this.ROS_RUN.Size = new System.Drawing.Size(75, 23);
            this.ROS_RUN.TabIndex = 2;
            this.ROS_RUN.Text = "ROS_RUN";
            this.ROS_RUN.UseVisualStyleBackColor = true;
            this.ROS_RUN.Click += new System.EventHandler(this.ROS_RUN_Click);
            // 
            // node_name
            // 
            this.node_name.Location = new System.Drawing.Point(86, 70);
            this.node_name.Name = "node_name";
            this.node_name.Size = new System.Drawing.Size(100, 22);
            this.node_name.TabIndex = 1;
            this.node_name.Text = "GOP1_SQL.py";
            // 
            // package_name
            // 
            this.package_name.Location = new System.Drawing.Point(86, 46);
            this.package_name.Name = "package_name";
            this.package_name.Size = new System.Drawing.Size(100, 22);
            this.package_name.TabIndex = 1;
            this.package_name.Text = "movetest";
            // 
            // ROS_IP
            // 
            this.ROS_IP.Location = new System.Drawing.Point(86, 20);
            this.ROS_IP.Name = "ROS_IP";
            this.ROS_IP.Size = new System.Drawing.Size(100, 22);
            this.ROS_IP.TabIndex = 1;
            this.ROS_IP.Text = "192.168.21.120";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Node_name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Package_name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Master_IP";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(328, 199);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(138, 132);
            this.listView1.TabIndex = 36;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(328, 174);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(138, 23);
            this.read.TabIndex = 37;
            this.read.Text = "Read";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // Action_start
            // 
            this.Action_start.Enabled = false;
            this.Action_start.Location = new System.Drawing.Point(328, 337);
            this.Action_start.Name = "Action_start";
            this.Action_start.Size = new System.Drawing.Size(138, 29);
            this.Action_start.TabIndex = 39;
            this.Action_start.Text = "Action_Start";
            this.Action_start.UseVisualStyleBackColor = true;
            this.Action_start.Click += new System.EventHandler(this.Action_start_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 372);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Action_start);
            this.Controls.Add(this.read);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox19);
            this.Controls.Add(this.gpb_Type_TCP);
            this.Name = "Form1";
            this.Text = "AGV";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PLC)).EndInit();
            this.gpb_Type_TCP.ResumeLayout(false);
            this.gpb_Type_TCP.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_PLC;
        private System.Windows.Forms.GroupBox gpb_Type_TCP;
        private System.Windows.Forms.TextBox txb_Tcp_Port;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.TextBox txb_Tcp_Ip;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Arrive_P1;
        private System.Windows.Forms.Button Arrive_P2;
        private System.Windows.Forms.Button Arrive_P3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox rtb_response;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.TextBox txb_sql_rdtable;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txb_sql_uptable;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txb_sql_severip;
        private System.Windows.Forms.TextBox txb_sql_port;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txb_sql_userid;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txb_sql_password;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txb_sql_database;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button SQL_Download;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox Upload_test;
        private System.Windows.Forms.Button SQL_Upload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ROS_RUN;
        private System.Windows.Forms.TextBox node_name;
        private System.Windows.Forms.TextBox package_name;
        private System.Windows.Forms.TextBox ROS_IP;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button Action_start;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

