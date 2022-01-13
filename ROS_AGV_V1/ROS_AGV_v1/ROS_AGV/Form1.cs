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
        string Robot_status;
        int counter = 0;

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
                        Car_Action("P1");                        
                        break;
                    case ("GOP2"):
                        Console.WriteLine(action+","+X);                       
                        Car_Action("P2");                        
                        break;
                    case ("GOP3"):
                        Console.WriteLine(action+","+X);
                        Car_Action("P3");                        
                        break;
                    case ("GOHOME"):
                        Console.WriteLine(action+","+X);
                        Car_Action("HOME");                        
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
            Console.WriteLine(Point+ "Car_Action");
            webBrowser1.Navigate("http://" + ROS_IP.Text + ":8080/pub_once?topic_name= movetest&message_type=GO" + Point + "_SQL.py&message=+");
            while (true)
            {
                port_Open.read(txb_sql_severip.Text, txb_sql_port.Text, txb_sql_userid.Text, txb_sql_password.Text, txb_sql_database.Text,
                            txb_sql_uptable.Text, out car_status);
                if (car_status == "arrival_" + Point)
                {
                    break;
                }
                else if (car_status == "Unreachable_" + Point)
                {
                    goto finsh;
                }
            }
            finsh: Console.WriteLine("Action_Stop");
        }
    }
}
