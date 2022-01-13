using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;

namespace ROS_AGV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Modbus modbus = new Modbus();
        Modbus modbus2 = new Modbus();
        Port_open port_Open = new Port_open();
        string car_status;
        string car_status2;
        string Robot_status;
        int counter = 0;
        int counter2 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.LabelEdit = false;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Iteam", 50);
            listView1.Columns.Add("Action", 100);
            pictureBox_PLC.BackColor = Color.Silver;
            Arrive_P1.Enabled = false;
            Arrive_P2.Enabled = false;
            Arrive_P3.Enabled = false;
            //timer1.Enabled = true;
            //timer1.Interval = 100;
            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.LabelEdit = false;
            listView2.FullRowSelect = true;
            listView2.Columns.Add("Iteam", 50);
            listView2.Columns.Add("Action", 100);
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            modbus.Connert("TCP", txb_Tcp_Ip.Text, txb_Tcp_Port.Text);
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            modbus.Disconnect();
            //Arrive_P1.Enabled = false;
            //Arrive_P2.Enabled = false;
            //Arrive_P3.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            modbus.IsOpen();
            if (modbus.isopen)
            {
                pictureBox_PLC.BackColor = Color.GreenYellow;
                Arrive_P1.Enabled = true;
                Arrive_P2.Enabled = true;
                Arrive_P3.Enabled = true;

            }
            else
            {
                pictureBox_PLC.BackColor = Color.Silver;
                Arrive_P1.Enabled = false;
                Arrive_P2.Enabled = false;
                Arrive_P3.Enabled = false;
            }
        }

        private void Arrive_P1_Click(object sender, EventArgs e)
        {
            string _reply = "";            
            _reply = modbus.Command("0106"+"0080"+"0000", "TCP");
            rtb_response.Text = _reply;
        }

        private void Arrive_P2_Click(object sender, EventArgs e)
        {
            string _reply = "";
            _reply = modbus.Command("0106" + "0080" + "0002", "TCP");            
            rtb_response.Text = _reply;
        }

        private void Arrive_P3_Click(object sender, EventArgs e)
        {
            string _reply = "";
            _reply = modbus.Command("0106" + "0080" + "0003", "TCP");
            rtb_response.Text = _reply;
        }
        
        private void SQL_Download_Click(object sender, EventArgs e)
        {
            string _car_status = "";
            port_Open.read(txb_sql_severip.Text, txb_sql_port.Text, txb_sql_userid.Text, txb_sql_password.Text, txb_sql_database.Text,
                        txb_sql_uptable.Text, out _car_status);
            label1.Text = _car_status;
            //string zzz = Upload_test.Text;
            //webBrowser1.Navigate("http://192.168.1.153:8080/pub_repeatly?topic_name=zzz&message_type=std_msgs%2FString&message="+ zzz + "&frequency=10");
        }

        private void SQL_Upload_Click(object sender, EventArgs e)
        {

            port_Open.upload(txb_sql_severip.Text, txb_sql_port.Text, txb_sql_userid.Text, txb_sql_password.Text, txb_sql_database.Text,
                        txb_sql_uptable.Text,
                       Upload_test.Text);
            //webBrowser1.Navigate("http://192.168.1.153:8080/pub_once?topic_name=turtlesim&message_type=turtlesim_node&message=+");
        }

        private void ROS_RUN_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://"+ROS_IP.Text+":8080/pub_once?topic_name="+package_name.Text+"&message_type="+node_name.Text+"&message=+");
        }

        private void read_Click(object sender, EventArgs e)
        {
            counter = 0;
            listView1.Items.Clear();            
            string line;
            //System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\steamnfu\Desktop\test.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line != "")
                {
                    var item = new ListViewItem(counter + "");
                    item.SubItems.Add(line);
                    listView1.Items.Add(item);
                    counter++;
                }                
            }
            file.Close();
            Action_start.Enabled = true;
        }
        private void Action_start_Click(object sender, EventArgs e)
        {
            string action = "";
            car_status = "";
            for (int X = 0; X < counter; X++)
            {
                ListViewItem item2 = listView1.Items[X];
                action = item2.SubItems[1].Text;                
                switch (action)
                {
                    case ("GOP1"):
                        Console.WriteLine(action+","+X);                        
                        Car_Action("GOP1_SQL.py");                        
                        break;
                    case ("GOP2"):
                        Console.WriteLine(action+","+X);                       
                        Car_Action("GOP2_SQL.py");                        
                        break;
                    case ("GOP3"):
                        Console.WriteLine(action+","+X);
                        Car_Action("GOP3_SQL.py");                        
                        break;
                    case ("GOHOME"):
                        Console.WriteLine(action+","+X);
                        Car_Action("GOHOME_SQL.py");                        
                        break;
                    case ("ToControlPC_0806"):
                        Console.WriteLine(action + "," + X);
                        Car_Action("ToControlPC_0806.py");
                        break;
                    case ("ROBOT_ACTION_H"):
                        Console.WriteLine(action + "," + X);
                        Robot_Action("0001");
                        break;
                    case ("ROBOT_ACTION_M"):
                        Console.WriteLine(action + "," + X);
                        Robot_Action("0002");
                        break;
                    case ("ROBOT_ACTION_L"):
                        Console.WriteLine(action + "," + X);
                        Robot_Action("0003");
                        break;
                }                
            }            
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            modbus.Connert("TCP", txb_Tcp_Ip.Text, txb_Tcp_Port.Text);
            modbus.Command("0106" + "0080" + "0001", "TCP");
            Thread.Sleep(100);
            modbus.Command("0106" + "0080" + "0000", "TCP");
            Thread.Sleep(100);
            modbus.Command("0106" + "0082" + "0000", "TCP");
            modbus.Disconnect();
            Thread.Sleep(1000);
            //check_robot.Enabled = true;
            //check Robot
            while (true)
            {
                string reply = "";
                List<string> pos_TCP = new List<string>();
                modbus.Connert("TCP", txb_Tcp_Ip.Text, txb_Tcp_Port.Text);
                reply = modbus.Command("010300810001", "TCP").PadLeft(24, '0');
                modbus.Disconnect();
                for (int i = 0; i < reply.Length; i = i + 4)
                {
                    pos_TCP.Add(reply.Substring(i, 4));
                }
                if (pos_TCP[5] == "0001")
                {
                    Robot_status = "Done";
                }                
                if (Robot_status == "Done")
                {
                    modbus.Connert("TCP", txb_Tcp_Ip.Text, txb_Tcp_Port.Text);
                    modbus.Command("0106" + "0082" + "0001", "TCP");
                    modbus.Disconnect();
                    //check_robot.Enabled = false;
                    Console.WriteLine("actionOK");
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Robot_Action("0001");
        }

        public void Robot_Action(string _cmd)//0001(H),0002(M),0003(L)
        {
            Console.WriteLine(_cmd + "Robot_Action");
            modbus.Connert("TCP", txb_Tcp_Ip.Text, txb_Tcp_Port.Text);
            modbus.Command("0106" + "0080" + _cmd, "TCP");
            Thread.Sleep(100);
            modbus.Command("0106" + "0080" + "0000", "TCP");
            Thread.Sleep(100);
            modbus.Command("0106" + "0082" + "0000", "TCP");
            modbus.Disconnect();
            Thread.Sleep(1000);
            while (true)
            {
                string reply = "";
                List<string> pos_TCP = new List<string>();
                modbus.Connert("TCP", txb_Tcp_Ip.Text, txb_Tcp_Port.Text);
                reply = modbus.Command("010300810001", "TCP").PadLeft(24, '0');
                modbus.Disconnect();
                for (int i = 0; i < reply.Length; i = i + 4)
                {
                    pos_TCP.Add(reply.Substring(i, 4));
                }
                if (pos_TCP[5] == "0001")
                {
                    Robot_status = "Done";
                }
                else Robot_status = "Wait";

                if (Robot_status == "Done")
                {
                    modbus.Connert("TCP", txb_Tcp_Ip.Text, txb_Tcp_Port.Text);
                    modbus.Command("0106" + "0082" + "0001", "TCP");
                    modbus.Disconnect();
                    //check_robot.Enabled = false;
                    Console.WriteLine("Robot_actionOK");
                    break;
                }
            }

        }
        public void Car_Action(string Point) //P1,P2,P3,HOME
        {
            string ppp = "";
            Console.WriteLine(Point+ "Car_Action");
            webBrowser1.Navigate("http://" + ROS_IP.Text + ":8080/pub_once?topic_name= movetest&message_type=" + Point + "&message=+");
            if (Point== "GOP1_SQL.py")
            {
                ppp = "P1";
                while (true)
                {
                    port_Open.read(txb_sql_severip.Text, txb_sql_port.Text, txb_sql_userid.Text, txb_sql_password.Text, txb_sql_database.Text,
                                txb_sql_uptable.Text, out car_status);
                    if (car_status == "arrival_" + ppp)
                    {
                        break;
                    }
                    else if (car_status == "Unreachable_" + ppp)
                    {
                        goto finsh1;
                    }
                }
            finsh1: Console.WriteLine("Action_Stop");
            }
            else if (Point == "GOP2_SQL.py")
            {
                ppp = "P2";
                while (true)
                {
                    port_Open.read(txb_sql_severip.Text, txb_sql_port.Text, txb_sql_userid.Text, txb_sql_password.Text, txb_sql_database.Text,
                                txb_sql_uptable.Text, out car_status);
                    if (car_status == "arrival_" + ppp)
                    {
                        break;
                    }
                    else if (car_status == "Unreachable_" + ppp)
                    {
                        goto finsh2;
                    }
                }
            finsh2: Console.WriteLine("Action_Stop");
            }
            else if (Point == "GOP3_SQL.py")
            {
                ppp = "P3";
                while (true)
                {
                    port_Open.read(txb_sql_severip.Text, txb_sql_port.Text, txb_sql_userid.Text, txb_sql_password.Text, txb_sql_database.Text,
                                txb_sql_uptable.Text, out car_status);
                    if (car_status == "arrival_" + ppp)
                    {
                        break;
                    }
                    else if (car_status == "Unreachable_" + ppp)
                    {
                        goto finsh3;
                    }
                }
            finsh3: Console.WriteLine("Action_Stop");
            }
            else if (Point == "GOHOME_SQL.py")
            {
                ppp = "HOME";
                while (true)
                {
                    port_Open.read(txb_sql_severip.Text, txb_sql_port.Text, txb_sql_userid.Text, txb_sql_password.Text, txb_sql_database.Text,
                                txb_sql_uptable.Text, out car_status);
                    if (car_status == "arrival_" + ppp)
                    {
                        break;
                    }
                    else if (car_status == "Unreachable_" + ppp)
                    {
                        goto finsh4;
                    }
                }
            finsh4: Console.WriteLine("Action_Stop");
            }
            else
            {

            }
            //while (true)
            //{
            //    port_Open.read(txb_sql_severip.Text, txb_sql_port.Text, txb_sql_userid.Text, txb_sql_password.Text, txb_sql_database.Text,
            //                txb_sql_uptable.Text, out car_status);
            //    if (car_status == "arrival_" + ppp)
            //    {
            //        break;
            //    }
            //    else if (car_status == "Unreachable_" + ppp)
            //    {
            //        goto finsh;
            //    }
            //}
            //finsh: Console.WriteLine("Action_Stop");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://" + ROS2_IP.Text + ":8080/pub_once?topic_name=" + package_name2.Text + "&message_type=" + node_name2.Text + "&message=+");
        }

        private void SQL2_Upload_Click(object sender, EventArgs e)
        {
            port_Open.upload(txb_sql_severip2.Text, txb_sql_port2.Text, txb_sql_userid2.Text, txb_sql_password2.Text, txb_sql_database2.Text,
                        txb_sql_uptable2.Text,
                       Upload_test2.Text);
        }

        private void SQL2_Download_Click(object sender, EventArgs e)
        {
            string _car_status2 = "";
            port_Open.read(txb_sql_severip2.Text, txb_sql_port2.Text, txb_sql_userid2.Text, txb_sql_password2.Text, txb_sql_database2.Text,
                        txb_sql_uptable2.Text, out _car_status2);
            label10.Text = _car_status2;
        }

        private void read2_Click(object sender, EventArgs e)
        {
            counter2 = 0;
            listView2.Items.Clear();
            string line2;
            //System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
            System.IO.StreamReader file2 = new System.IO.StreamReader(@"C:\Users\steamnfu\Desktop\test2.txt");
            while ((line2 = file2.ReadLine()) != null)
            {
                if (line2 != "")
                {
                    var item3 = new ListViewItem(counter2 + "");
                    item3.SubItems.Add(line2);
                    listView2.Items.Add(item3);
                    counter2++;
                }
            }
            file2.Close();
            Action_start2.Enabled = true;
        }

        private void Action_start2_Click(object sender, EventArgs e)
        {
            string action2 = "";
            car_status2 = "";
            for (int X = 0; X < counter2; X++)
            {
                ListViewItem item4 = listView2.Items[X];
                action2 = item4.SubItems[1].Text;
                switch (action2)
                {
                    case ("GOP1"):
                        Console.WriteLine(action2 + "," + X);
                        Car_Action2("GOP1_SQL.py");
                        break;
                    case ("GOP2"):
                        Console.WriteLine(action2 + "," + X);
                        Car_Action2("GOP2_SQL.py");
                        break;
                    case ("GOP3"):
                        Console.WriteLine(action2 + "," + X);
                        Car_Action2("GOP3_SQL.py");
                        break;
                    case ("GOHOME"):
                        Console.WriteLine(action2 + "," + X);
                        Car_Action2("GOHOME_SQL.py");
                        break;
                    case ("AI"):
                        Console.WriteLine(action2 + "," + X);
                        Car_Action2("AI.py");
                        break;
                    case ("UR10"):
                        Console.WriteLine(action2 + "," + X);
                        Robot_Action2("100");
                        break;
                    case ("FANUC"):
                        Console.WriteLine(action2 + "," + X);
                        Robot_Action2("200");
                        break;

                }
            }
        }
        public void Car_Action2(string Point2) //P1,P2,P3,HOME
        {
            string ppp2 = "";
            Console.WriteLine(Point2 + "Car_Action");
            webBrowser1.Navigate("http://" + ROS2_IP.Text + ":8080/pub_once?topic_name= movetest&message_type=" + Point2 + "&message=+");
            if (Point2 == "GOP1_SQL.py")
            {
                ppp2 = "P1";
                while (true)
                {
                    port_Open.read(txb_sql_severip2.Text, txb_sql_port2.Text, txb_sql_userid2.Text, txb_sql_password2.Text, txb_sql_database2.Text,
                                txb_sql_uptable2.Text, out car_status2);
                    if (car_status2 == "arrival_" + ppp2)
                    {
                        break;
                    }
                    else if (car_status2 == "Unreachable_" + ppp2)
                    {
                        goto finsh11;
                    }
                }
            finsh11: Console.WriteLine("Action_Stop");
            }
            else if (Point2 == "GOP2_SQL.py")
            {
                ppp2 = "P2";
                while (true)
                {
                    port_Open.read(txb_sql_severip2.Text, txb_sql_port2.Text, txb_sql_userid2.Text, txb_sql_password2.Text, txb_sql_database2.Text,
                                txb_sql_uptable2.Text, out car_status2);
                    if (car_status2 == "arrival_" + ppp2)
                    {
                        break;
                    }
                    else if (car_status2 == "Unreachable_" + ppp2)
                    {
                        goto finsh12;
                    }
                }
            finsh12: Console.WriteLine("Action_Stop");
            }
            else if (Point2 == "GOP3_SQL.py")
            {
                ppp2 = "P3";
                while (true)
                {
                    port_Open.read(txb_sql_severip2.Text, txb_sql_port2.Text, txb_sql_userid2.Text, txb_sql_password2.Text, txb_sql_database2.Text,
                                txb_sql_uptable2.Text, out car_status2);
                    if (car_status2 == "arrival_" + ppp2)
                    {
                        break;
                    }
                    else if (car_status2 == "Unreachable_" + ppp2)
                    {
                        goto finsh13;
                    }
                }
            finsh13: Console.WriteLine("Action_Stop");
            }
            else if (Point2 == "GOHOME_SQL.py")
            {
                ppp2 = "HOME";
                while (true)
                {
                    port_Open.read(txb_sql_severip2.Text, txb_sql_port2.Text, txb_sql_userid2.Text, txb_sql_password2.Text, txb_sql_database2.Text,
                                txb_sql_uptable2.Text, out car_status2);
                    if (car_status2 == "arrival_" + ppp2)
                    {
                        break;
                    }
                    else if (car_status2 == "Unreachable_" + ppp2)
                    {
                        goto finsh14;
                    }
                }
            finsh14: Console.WriteLine("Action_Stop");
            }
            else if (Point2 == "AI.py")
            {
                ppp2 = "AI";
                while (true)
                {
                    port_Open.read(txb_sql_severip2.Text, txb_sql_port2.Text, txb_sql_userid2.Text, txb_sql_password2.Text, txb_sql_database2.Text,
                                txb_sql_uptable2.Text, out car_status2);
                    if (car_status2 == "arrival_" + ppp2)
                    {
                        break;
                    }
                    else if (car_status2 == "Unreachable_" + ppp2)
                    {
                        goto finsh15;
                    }
                }
            finsh15: Console.WriteLine("Action_Stop");
            }
            else
            {

            }
        }

        public void Robot_Action2(string _cmd)
        {
            if (_cmd == "100")
            {
                string _reply = "";
                modbus.Connert("TCP", "192.168.21.20", "502");
                modbus.Command("0105" + "0501" + "FF00", "TCP");
                Thread.Sleep(5000);
                _reply = "";
                modbus.Command("0105" + "0501" + "0000", "TCP");
                _reply = modbus.Command("0105" + "0501" + "0000", "TCP");
                rtb_response.Text = _reply;
                modbus.Disconnect();
            }
            else if (_cmd=="200")
            {
                string _reply = "";
                modbus.Connert("TCP", "192.168.21.25", "502");
                modbus.Command("0105" + "0500" + "FF00", "TCP");
                Thread.Sleep(5000);
                _reply = "";
                modbus.Command("0105" + "0500" + "0000", "TCP");
                _reply = modbus.Command("0105" + "0500" + "0000", "TCP");
                rtb_response.Text = _reply;
                modbus.Disconnect();
            }
            else
            {

            }
            
        }

    }
}
