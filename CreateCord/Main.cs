using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace CreateCord
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public bool SqlStatu;
        string ConnectionString = string.Empty;
        private void BtnTest_Click(object sender, EventArgs e)
        {
            if (ServerName.Text.Trim() == "" || Port.Text.Trim() == "" || DBName.Text.Trim() == "" || UId.Text.Trim() == "" || Password.Text.Trim() == "")
            {
                MessageBox.Show("请完善必填的信息！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                label6.Text = "正在测试请稍后。。。";

                ConnectionString += "Server=" + ServerName.Text.Trim();
                ConnectionString += ";Port=" + Port.Text.Trim();
                ConnectionString += ";Database=" + DBName.Text.Trim();
                ConnectionString += ";Password=" + UId.Text.Trim();
                ConnectionString += ";User Id=" + Password.Text.Trim();
                // SqlStatu = ConnectionTest("Server=12.168.31.117;Port=5432;User Id=postgres;Password=postgres;Database=ABC");

                SqlStatu = ConnectionTest(ConnectionString);
                if (SqlStatu)
                {
                    label6.Text = "测试成功！！！";
                }
                else
                {
                    label6.Text = "测试失败！！！";
                    MessageBox.Show("配置出现错误，请检查配置是否正确！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }

        }
        /// <summary>
        /// 测试连接数据库是否成功
        /// </summary>
        /// <returns></returns>
        public static bool ConnectionTest(string ConnectionString)
        {
            NpgsqlConnection mySqlConnection;

            bool IsCanConnectioned = false;


            //获取数据库连接字符串
            //ConnectionString = ConnectionInfo.ConnectionString();
            //创建连接对象
            mySqlConnection = new NpgsqlConnection(ConnectionString);

            try
            {
                //Open DataBase
                //打开数据库
                mySqlConnection.Open();
                IsCanConnectioned = true;
            }
            catch 
            {
               
                //Can not Open DataBase
                //打开不成功 则连接不成功
                IsCanConnectioned = false;

            }
            finally
            {
                //Close DataBase
                //关闭数据库连接
                mySqlConnection.Close();
            }
            return IsCanConnectioned;
        }

        private void BtnIffrm_Click(object sender, EventArgs e)
        {
            if (SqlStatu)
            {
                this.Hide();
                createCode from = new createCode(ConnectionString);
                DialogResult dr = from.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("请配置正确的链接！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
      
    }
}
