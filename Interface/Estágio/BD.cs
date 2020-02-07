using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Estágio
{
    class BD
    {
        public static OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.Environment.CurrentDirectory + "\\enem.mdb");
        public static OleDbCommand comando;
        public static OleDbDataReader leitor;
        //public static string thresh;
        public static void execute(string st)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            comando = new OleDbCommand(st, conn);
            if (st.Split(' ')[0].ToUpper() == "SELECT")
                leitor = comando.ExecuteReader();
            else
                comando.ExecuteNonQuery();
        }
        public static int nha() 
        {
            int i = 0;
            BD.execute("SELECT cod_q from mat");
            try
            {
                while (BD.leitor.Read())
                {
                    i++;
                }
                return i;
            }

            catch
            {
                return i;

            }
        } 
        public static string push(int x) 
        {
            
             string[] num = new string[70];
             BD.execute("SELECT * from mat where cod_q="+x+"");
            try
            {
                while (BD.leitor.Read())
                {
                    num[0] = x  + ") " + BD.leitor.GetString(1);
                    num[1] = "A) " + BD.leitor.GetString(2);
                    num[2] = "B) " + BD.leitor.GetString(3);
                    num[3] = "C) " + BD.leitor.GetString(4);
                    num[4] = "D) " + BD.leitor.GetString(5);
                    num[5] = "E) " + BD.leitor.GetString(6);                 
                }
                //   label1.MaximumSize = new Size(884, 300);
               

                string b = num[0] + ";" + num[1] + ";" + num[2] + ";" + num[3] + ";" + num[4] + ";" + num[5];
                return b;




            }

            catch
            {
                return "erro";

            }
        }
    }
}
