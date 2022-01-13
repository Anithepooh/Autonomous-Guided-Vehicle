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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.node_name2 = new System.Windows.Forms.TextBox();
            this.package_name2 = new System.Windows.Forms.TextBox();
            this.ROS2_IP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Upload_test2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_sql_rdtable2 = new System.Windows.Forms.TextBox();
            this.SQL2_Upload = new System.Windows.Forms.Button();
            this.SQL2_Download = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txb_sql_uptable2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_sql_severip2 = new System.Windows.Forms.TextBox();
            this.txb_sql_port2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txb_sql_userid2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txb_sql_password2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txb_sql_database2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Action_start2 = new System.Windows.Forms.Button();
            this.read2 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PLC)).BeginInit();
            this.gpb_Type_TCP.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_PLC
            // 
            this.pictureBox_PLC.Location = new System.Drawing.Point(183, 34);
            this.pictureBox_PLC.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_PLC.Name = "pictureBox_PLC";
            this.pictureBox_PLC.Size = new System.Drawing.Size(53, 46);
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
            this.gpb_Type_TCP.Location = new System.Drawing.Point(11, 15);
            this.gpb_Type_TCP.Margin = new System.Windows.Forms.Padding(4);
            this.gpb_Type_TCP.Name = "gpb_Type_TCP";
            this.gpb_Type_TCP.Padding = new System.Windows.Forms.Padding(4);
            this.gpb_Type_TCP.Size = new System.Drawing.Size(400, 186);
            this.gpb_Type_TCP.TabIndex = 8;
            this.gpb_Type_TCP.TabStop = false;
            this.gpb_Type_TCP.Text = "Robot_IP";
            // 
            // rtb_response
            // 
            this.rtb_response.Location = new System.Drawing.Point(244, 129);
            this.rtb_response.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_response.Name = "rtb_response";
            this.rtb_response.Size = new System.Drawing.Size(133, 48);
            this.rtb_response.TabIndex = 12;
            this.rtb_response.Text = "";
            // 
            // txb_Tcp_Port
            // 
            this.txb_Tcp_Port.Location = new System.Drawing.Point(51, 61);
            this.txb_Tcp_Port.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Tcp_Port.Name = "txb_Tcp_Port";
            this.txb_Tcp_Port.Size = new System.Drawing.Size(123, 25);
            this.txb_Tcp_Port.TabIndex = 5;
            this.txb_Tcp_Port.Text = "502";
            // 
            // Arrive_P3
            // 
            this.Arrive_P3.Location = new System.Drawing.Point(244, 92);
            this.Arrive_P3.Margin = new System.Windows.Forms.Padding(4);
            this.Arrive_P3.Name = "Arrive_P3";
            this.Arrive_P3.Size = new System.Drawing.Size(135, 29);
            this.Arrive_P3.TabIndex = 9;
            this.Arrive_P3.Text = "Arrive_P3";
            this.Arrive_P3.UseVisualStyleBackColor = true;
            this.Arrive_P3.Click += new System.EventHandler(this.Arrive_P3_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(127, 101);
            this.btn_Disconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(100, 76);
            this.btn_Disconnect.TabIndex = 10;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // Arrive_P2
            // 
            this.Arrive_P2.Location = new System.Drawing.Point(244, 56);
            this.Arrive_P2.Margin = new System.Windows.Forms.Padding(4);
            this.Arrive_P2.Name = "Arrive_P2";
            this.Arrive_P2.Size = new System.Drawing.Size(135, 29);
            this.Arrive_P2.TabIndex = 9;
            this.Arrive_P2.Text = "Arrive_P2";
            this.Arrive_P2.UseVisualStyleBackColor = true;
            this.Arrive_P2.Click += new System.EventHandler(this.Arrive_P2_Click);
            // 
            // txb_Tcp_Ip
            // 
            this.txb_Tcp_Ip.Location = new System.Drawing.Point(51, 26);
            this.txb_Tcp_Ip.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Tcp_Ip.Name = "txb_Tcp_Ip";
            this.txb_Tcp_Ip.Size = new System.Drawing.Size(123, 25);
            this.txb_Tcp_Ip.TabIndex = 5;
            this.txb_Tcp_Ip.Text = "192.168.50.217";
            // 
            // Arrive_P1
            // 
            this.Arrive_P1.Location = new System.Drawing.Point(244, 20);
            this.Arrive_P1.Margin = new System.Windows.Forms.Padding(4);
            this.Arrive_P1.Name = "Arrive_P1";
            this.Arrive_P1.Size = new System.Drawing.Size(135, 29);
            this.Arrive_P1.TabIndex = 9;
            this.Arrive_P1.Text = "Arrive_P1";
            this.Arrive_P1.UseVisualStyleBackColor = true;
            this.Arrive_P1.Click += new System.EventHandler(this.Arrive_P1_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(8, 101);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(100, 76);
            this.btn_Connect.TabIndex = 9;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 15);
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
            this.groupBox19.Location = new System.Drawing.Point(11, 209);
            this.groupBox19.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox19.Size = new System.Drawing.Size(400, 250);
            this.groupBox19.TabIndex = 33;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "SQL Setting";
            // 
            // Upload_test
            // 
            this.Upload_test.Location = new System.Drawing.Point(105, 170);
            this.Upload_test.Margin = new System.Windows.Forms.Padding(4);
            this.Upload_test.Name = "Upload_test";
            this.Upload_test.Size = new System.Drawing.Size(107, 25);
            this.Upload_test.TabIndex = 37;
            this.Upload_test.Text = "arrival_P1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "\"\"";
            // 
            // txb_sql_rdtable
            // 
            this.txb_sql_rdtable.Location = new System.Drawing.Point(313, 94);
            this.txb_sql_rdtable.Margin = new System.Windows.Forms.Padding(4);
            this.txb_sql_rdtable.Name = "txb_sql_rdtable";
            this.txb_sql_rdtable.Size = new System.Drawing.Size(64, 25);
            this.txb_sql_rdtable.TabIndex = 32;
            this.txb_sql_rdtable.Text = "agv";
            // 
            // SQL_Upload
            // 
            this.SQL_Upload.Location = new System.Drawing.Point(13, 170);
            this.SQL_Upload.Margin = new System.Windows.Forms.Padding(4);
            this.SQL_Upload.Name = "SQL_Upload";
            this.SQL_Upload.Size = new System.Drawing.Size(84, 29);
            this.SQL_Upload.TabIndex = 34;
            this.SQL_Upload.Text = "SQL_Utest";
            this.SQL_Upload.UseVisualStyleBackColor = true;
            this.SQL_Upload.Click += new System.EventHandler(this.SQL_Upload_Click);
            // 
            // SQL_Download
            // 
            this.SQL_Download.Location = new System.Drawing.Point(13, 206);
            this.SQL_Download.Margin = new System.Windows.Forms.Padding(4);
            this.SQL_Download.Name = "SQL_Download";
            this.SQL_Download.Size = new System.Drawing.Size(84, 29);
            this.SQL_Download.TabIndex = 34;
            this.SQL_Download.Text = "SQL_Dtest";
            this.SQL_Download.UseVisualStyleBackColor = true;
            this.SQL_Download.Click += new System.EventHandler(this.SQL_Download_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(221, 98);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(71, 15);
            this.label40.TabIndex = 31;
            this.label40.Text = "Read Table";
            // 
            // txb_sql_uptable
            // 
            this.txb_sql_uptable.Location = new System.Drawing.Point(313, 62);
            this.txb_sql_uptable.Margin = new System.Windows.Forms.Padding(4);
            this.txb_sql_uptable.Name = "txb_sql_uptable";
            this.txb_sql_uptable.Size = new System.Drawing.Size(64, 25);
            this.txb_sql_uptable.TabIndex = 29;
            this.txb_sql_uptable.Text = "agv";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(221, 66);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(84, 15);
            this.label39.TabIndex = 30;
            this.label39.Text = "Upload Table";
            // 
            // txb_sql_severip
            // 
            this.txb_sql_severip.Location = new System.Drawing.Point(105, 28);
            this.txb_sql_severip.Margin = new System.Windows.Forms.Padding(4);
            this.txb_sql_severip.Name = "txb_sql_severip";
            this.txb_sql_severip.Size = new System.Drawing.Size(107, 25);
            this.txb_sql_severip.TabIndex = 18;
            this.txb_sql_severip.Text = "192.168.50.59";
            // 
            // txb_sql_port
            // 
            this.txb_sql_port.Location = new System.Drawing.Point(105, 62);
            this.txb_sql_port.Margin = new System.Windows.Forms.Padding(4);
            this.txb_sql_port.Name = "txb_sql_port";
            this.txb_sql_port.Size = new System.Drawing.Size(107, 25);
            this.txb_sql_port.TabIndex = 19;
            this.txb_sql_port.Text = "3306";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(221, 31);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(57, 15);
            this.label36.TabIndex = 28;
            this.label36.Text = "Database";
            // 
            // txb_sql_userid
            // 
            this.txb_sql_userid.Location = new System.Drawing.Point(105, 98);
            this.txb_sql_userid.Margin = new System.Windows.Forms.Padding(4);
            this.txb_sql_userid.Name = "txb_sql_userid";
            this.txb_sql_userid.Size = new System.Drawing.Size(107, 25);
            this.txb_sql_userid.TabIndex = 20;
            this.txb_sql_userid.Text = "pallet";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(13, 136);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(60, 15);
            this.label35.TabIndex = 27;
            this.label35.Text = "Password";
            // 
            // txb_sql_password
            // 
            this.txb_sql_password.Location = new System.Drawing.Point(105, 132);
            this.txb_sql_password.Margin = new System.Windows.Forms.Padding(4);
            this.txb_sql_password.Name = "txb_sql_password";
            this.txb_sql_password.Size = new System.Drawing.Size(107, 25);
            this.txb_sql_password.TabIndex = 21;
            this.txb_sql_password.Text = "12345678";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(13, 101);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(48, 15);
            this.label34.TabIndex = 26;
            this.label34.Text = "UserID";
            // 
            // txb_sql_database
            // 
            this.txb_sql_database.Location = new System.Drawing.Point(313, 28);
            this.txb_sql_database.Margin = new System.Windows.Forms.Padding(4);
            this.txb_sql_database.Name = "txb_sql_database";
            this.txb_sql_database.Size = new System.Drawing.Size(64, 25);
            this.txb_sql_database.TabIndex = 22;
            this.txb_sql_database.Text = "agx";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(13, 66);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(31, 15);
            this.label33.TabIndex = 25;
            this.label33.Text = "Port";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(13, 31);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(56, 15);
            this.label32.TabIndex = 24;
            this.label32.Text = "Sever IP";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(296, 32);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(27, 119);
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
            this.groupBox1.Location = new System.Drawing.Point(437, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(343, 185);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ROS";
            // 
            // ROS_RUN
            // 
            this.ROS_RUN.Location = new System.Drawing.Point(28, 128);
            this.ROS_RUN.Margin = new System.Windows.Forms.Padding(4);
            this.ROS_RUN.Name = "ROS_RUN";
            this.ROS_RUN.Size = new System.Drawing.Size(100, 29);
            this.ROS_RUN.TabIndex = 2;
            this.ROS_RUN.Text = "ROS_RUN";
            this.ROS_RUN.UseVisualStyleBackColor = true;
            this.ROS_RUN.Click += new System.EventHandler(this.ROS_RUN_Click);
            // 
            // node_name
            // 
            this.node_name.Location = new System.Drawing.Point(115, 88);
            this.node_name.Margin = new System.Windows.Forms.Padding(4);
            this.node_name.Name = "node_name";
            this.node_name.Size = new System.Drawing.Size(173, 25);
            this.node_name.TabIndex = 1;
            this.node_name.Text = "GOP1_SQL.py";
            // 
            // package_name
            // 
            this.package_name.Location = new System.Drawing.Point(115, 58);
            this.package_name.Margin = new System.Windows.Forms.Padding(4);
            this.package_name.Name = "package_name";
            this.package_name.Size = new System.Drawing.Size(173, 25);
            this.package_name.TabIndex = 1;
            this.package_name.Text = "movetest";
            // 
            // ROS_IP
            // 
            this.ROS_IP.Location = new System.Drawing.Point(115, 25);
            this.ROS_IP.Margin = new System.Windows.Forms.Padding(4);
            this.ROS_IP.Name = "ROS_IP";
            this.ROS_IP.Size = new System.Drawing.Size(173, 25);
            this.ROS_IP.TabIndex = 1;
            this.ROS_IP.Text = "192.168.50.132";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Node_name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Package_name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Master_IP";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(437, 249);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(149, 164);
            this.listView1.TabIndex = 36;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(437, 218);
            this.read.Margin = new System.Windows.Forms.Padding(4);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(149, 29);
            this.read.TabIndex = 37;
            this.read.Text = "Read";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // Action_start
            // 
            this.Action_start.Enabled = false;
            this.Action_start.Location = new System.Drawing.Point(437, 421);
            this.Action_start.Margin = new System.Windows.Forms.Padding(4);
            this.Action_start.Name = "Action_start";
            this.Action_start.Size = new System.Drawing.Size(149, 36);
            this.Action_start.TabIndex = 39;
            this.Action_start.Text = "Action_Start";
            this.Action_start.UseVisualStyleBackColor = true;
            this.Action_start.Click += new System.EventHandler(this.Action_start_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.webBrowser2);
            this.groupBox2.Controls.Add(this.node_name2);
            this.groupBox2.Controls.Add(this.package_name2);
            this.groupBox2.Controls.Add(this.ROS2_IP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(816, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(343, 185);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ROS_2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 125);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "ROS2_RUN";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(296, 32);
            this.webBrowser2.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(27, 119);
            this.webBrowser2.TabIndex = 34;
            // 
            // node_name2
            // 
            this.node_name2.Location = new System.Drawing.Point(115, 88);
            this.node_name2.Margin = new System.Windows.Forms.Padding(4);
            this.node_name2.Name = "node_name2";
            this.node_name2.Size = new System.Drawing.Size(173, 25);
            this.node_name2.TabIndex = 1;
            this.node_name2.Text = "GOP3_SQL.py";
            // 
            // package_name2
            // 
            this.package_name2.Location = new System.Drawing.Point(115, 58);
            this.package_name2.Margin = new System.Windows.Forms.Padding(4);
            this.package_name2.Name = "package_name2";
            this.package_name2.Size = new System.Drawing.Size(173, 25);
            this.package_name2.TabIndex = 1;
            this.package_name2.Text = "movetest";
            // 
            // ROS2_IP
            // 
            this.ROS2_IP.Location = new System.Drawing.Point(115, 25);
            this.ROS2_IP.Margin = new System.Windows.Forms.Padding(4);
            this.ROS2_IP.Name = "ROS2_IP";
            this.ROS2_IP.Size = new System.Drawing.Size(173, 25);
            this.ROS2_IP.TabIndex = 1;
            this.ROS2_IP.Text = "192.168.21.164";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Node_name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Package_name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Master_IP";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Upload_test2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txb_sql_rdtable2);
            this.groupBox3.Controls.Add(this.SQL2_Upload);
            this.groupBox3.Controls.Add(this.SQL2_Download);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txb_sql_uptable2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txb_sql_severip2);
            this.groupBox3.Controls.Add(this.txb_sql_port2);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txb_sql_userid2);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txb_sql_password2);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txb_sql_database2);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(604, 209);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(400, 250);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SQL Setting_2";
            // 
            // Upload_test2
            // 
            this.Upload_test2.Location = new System.Drawing.Point(105, 170);
            this.Upload_test2.Margin = new System.Windows.Forms.Padding(4);
            this.Upload_test2.Name = "Upload_test2";
            this.Upload_test2.Size = new System.Drawing.Size(107, 25);
            this.Upload_test2.TabIndex = 37;
            this.Upload_test2.Text = "arrival_P1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 212);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 15);
            this.label10.TabIndex = 36;
            this.label10.Text = "\"\"";
            // 
            // txb_sql_rdtable2
            // 
            this.txb_sql_rdtable2.Location = new System.Drawing.Point(313, 94);
            this.txb_sql_rdtable2.Margin = new System.Windows.Forms.Padding(4);
            this.txb_sql_rdtable2.Name = "txb_sql_rdtable2";
            this.txb_sql_rdtable2.Size = new System.Drawing.Size(64, 25);
            this.txb_sql_rdtable2.TabIndex = 32;
            this.txb_sql_rdtable2.Text = "agv";
            // 
            // SQL2_Upload
            // 
            this.SQL2_Upload.Location = new System.Drawing.Point(13, 170);
            this.SQL2_Upload.Margin = new System.Windows.Forms.Padding(4);
            this.SQL2_Upload.Name = "SQL2_Upload";
            this.SQL2_Upload.Size = new System.Drawing.Size(84, 29);
            this.SQL2_Upload.TabIndex = 34;
            this.SQL2_Upload.Text = "SQL_Utest";
            this.SQL2_Upload.UseVisualStyleBackColor = true;
            this.SQL2_Upload.Click += new System.EventHandler(this.SQL2_Upload_Click);
            // 
            // SQL2_Download
            // 
            this.SQL2_Download.Location = new System.Drawing.Point(13, 206);
            this.SQL2_Download.Margin = new System.Windows.Forms.Padding(4);
            this.SQL2_Download.Name = "SQL2_Download";
            this.SQL2_Download.Size = new System.Drawing.Size(84, 29);
            this.SQL2_Download.TabIndex = 34;
            this.SQL2_Download.Text = "SQL_Dtest";
            this.SQL2_Download.UseVisualStyleBackColor = true;
            this.SQL2_Download.Click += new System.EventHandler(this.SQL2_Download_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 98);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "Read Table";
            // 
            // txb_sql_uptable2
            // 
            this.txb_sql_uptable2.Location = new System.Drawing.Point(313, 62);
            this.txb_sql_uptable2.Margin = new System.Windows.Forms.Padding(4);
            this.txb_sql_uptable2.Name = "txb_sql_uptable2";
            this.txb_sql_uptable2.Size = new System.Drawing.Size(64, 25);
            this.txb_sql_uptable2.TabIndex = 29;
            this.txb_sql_uptable2.Text = "agv";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(221, 66);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 15);
            this.label12.TabIndex = 30;
            this.label12.Text = "Upload Table";
            // 
            // txb_sql_severip2
            // 
            this.txb_sql_severip2.Location = new System.Drawing.Point(105, 28);
            this.txb_sql_severip2.Margin = new System.Windows.Forms.Padding(4);
            this.txb_sql_severip2.Name = "txb_sql_severip2";
            this.txb_sql_severip2.Size = new System.Drawing.Size(107, 25);
            this.txb_sql_severip2.TabIndex = 18;
            this.txb_sql_severip2.Text = "192.168.21.137";
            // 
            // txb_sql_port2
            // 
            this.txb_sql_port2.Location = new System.Drawing.Point(105, 62);
            this.txb_sql_port2.Margin = new System.Windows.Forms.Padding(4);
            this.txb_sql_port2.Name = "txb_sql_port2";
            this.txb_sql_port2.Size = new System.Drawing.Size(107, 25);
            this.txb_sql_port2.TabIndex = 19;
            this.txb_sql_port2.Text = "3306";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(221, 31);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "Database";
            // 
            // txb_sql_userid2
            // 
            this.txb_sql_userid2.Location = new System.Drawing.Point(105, 98);
            this.txb_sql_userid2.Margin = new System.Windows.Forms.Padding(4);
            this.txb_sql_userid2.Name = "txb_sql_userid2";
            this.txb_sql_userid2.Size = new System.Drawing.Size(107, 25);
            this.txb_sql_userid2.TabIndex = 20;
            this.txb_sql_userid2.Text = "pallet";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 136);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "Password";
            // 
            // txb_sql_password2
            // 
            this.txb_sql_password2.Location = new System.Drawing.Point(105, 132);
            this.txb_sql_password2.Margin = new System.Windows.Forms.Padding(4);
            this.txb_sql_password2.Name = "txb_sql_password2";
            this.txb_sql_password2.Size = new System.Drawing.Size(107, 25);
            this.txb_sql_password2.TabIndex = 21;
            this.txb_sql_password2.Text = "40227000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 101);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 15);
            this.label15.TabIndex = 26;
            this.label15.Text = "UserID";
            // 
            // txb_sql_database2
            // 
            this.txb_sql_database2.Location = new System.Drawing.Point(313, 28);
            this.txb_sql_database2.Margin = new System.Windows.Forms.Padding(4);
            this.txb_sql_database2.Name = "txb_sql_database2";
            this.txb_sql_database2.Size = new System.Drawing.Size(64, 25);
            this.txb_sql_database2.TabIndex = 22;
            this.txb_sql_database2.Text = "agvkw";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 66);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 15);
            this.label16.TabIndex = 25;
            this.label16.Text = "Port";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 31);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 15);
            this.label17.TabIndex = 24;
            this.label17.Text = "Sever IP";
            // 
            // Action_start2
            // 
            this.Action_start2.Enabled = false;
            this.Action_start2.Location = new System.Drawing.Point(1012, 421);
            this.Action_start2.Margin = new System.Windows.Forms.Padding(4);
            this.Action_start2.Name = "Action_start2";
            this.Action_start2.Size = new System.Drawing.Size(149, 36);
            this.Action_start2.TabIndex = 45;
            this.Action_start2.Text = "Action_Start";
            this.Action_start2.UseVisualStyleBackColor = true;
            this.Action_start2.Click += new System.EventHandler(this.Action_start2_Click);
            // 
            // read2
            // 
            this.read2.Location = new System.Drawing.Point(1012, 218);
            this.read2.Margin = new System.Windows.Forms.Padding(4);
            this.read2.Name = "read2";
            this.read2.Size = new System.Drawing.Size(149, 29);
            this.read2.TabIndex = 44;
            this.read2.Text = "Read";
            this.read2.UseVisualStyleBackColor = true;
            this.read2.Click += new System.EventHandler(this.read2_Click);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(1012, 249);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(149, 164);
            this.listView2.TabIndex = 43;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 468);
            this.Controls.Add(this.Action_start2);
            this.Controls.Add(this.read2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Action_start);
            this.Controls.Add(this.read);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox19);
            this.Controls.Add(this.gpb_Type_TCP);
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.TextBox node_name2;
        private System.Windows.Forms.TextBox package_name2;
        private System.Windows.Forms.TextBox ROS2_IP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Upload_test2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_sql_rdtable2;
        private System.Windows.Forms.Button SQL2_Upload;
        private System.Windows.Forms.Button SQL2_Download;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txb_sql_uptable2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb_sql_severip2;
        private System.Windows.Forms.TextBox txb_sql_port2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txb_sql_userid2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txb_sql_password2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txb_sql_database2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button Action_start2;
        private System.Windows.Forms.Button read2;
        private System.Windows.Forms.ListView listView2;
    }
}

