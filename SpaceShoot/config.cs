using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace SpaceShoot
{
    class Config
    {
        public SqlConnection con;
        public string str;

        public Config()
        {
            str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Works\CSharp\SpaceShoot\SpaceShoot\SpaceShoot\DataDB.mdf;Integrated Security=True";

            try
            {
                con = new SqlConnection(str);
                con.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

    }
}
