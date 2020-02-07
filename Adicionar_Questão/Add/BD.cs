using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Add
{
    class BD
    {
        public static OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.Environment.CurrentDirectory + "\\NAPNEM.mdb");
        public static OleDbCommand comando;
        public static OleDbDataReader leitor;
        public static string x,qt,a,b,c,d,e,g, tz;
        public static string ds, tp;
        public static int y;
        public static string dis, top;
        public static int z,j=0;
        public static int[] cont = new int[1000];
       

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
            BD.execute("SELECT cod_q from "+Menu_de_Questões.pastor+"");
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

        public static void insert()
        {
            BD.execute("INSERT INTO " + x + "(tópico, pergunta, a, b, c, d, e, gabarito) VALUES ('"+tz+"','" + qt + "','" + a + "','" + b + "','" + c + "','" + d + "','" + e + "','"+g+"');");
            BD.conn.Close();
        }
        public static string push()
        {

            string[] num = new string[70];
          
            int i = 0;
            
            BD.execute("select cod_q from "+dis+" where tópico = '"+top+"'");
            try
            {

                z = 0;
                while (BD.leitor.Read())
                {

                    cont[z] = Convert.ToInt32(leitor.GetValue(0));
                    z++;

                }

            }

            catch
            {
                return "erro";

            }

            if (j <= z)
                
            {

                BD.execute("SELECT * from "+dis+" where cod_q = "+cont[j]+"");
                try
                {
                    if (BD.leitor.Read())
                    {
                        
                        num[0] = j+1 + ") " + BD.leitor.GetString(1);

                        num[1] = "A) " + BD.leitor.GetString(2);
                        num[2] = "B) " + BD.leitor.GetString(3);
                        num[3] = "C) " + BD.leitor.GetString(4);
                        num[4] = "D) " + BD.leitor.GetString(5);
                        num[5] = "E) " + BD.leitor.GetString(6);
                        num[6] = BD.leitor.GetString(7);
                   

                    }
                    //   label1.MaximumSize = new Size(884, 300);
                    

                    string b = num[0] + " ; " + num[1] + " ; " + num[2] + " ; " + num[3] + " ; " + num[4] + " ; " + num[5] + " ; " + num[6];
                    return b;




                }

                catch
                {
                    return "erro";

                }
            }
            else
                return "erro";
        }

       

    }
}
