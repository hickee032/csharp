using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Connect_DB_Method_02 {
    internal class Connect_DB_PR {

        static string ORAC_ADDR =
           "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
           "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
           "(PORT=1521)))" +
           "(CONNECT_DATA=(SERVER=DEDICATED)" +
           "(SERVICE_NAME=XE)));" +
           "user Id=PERSNAL;Password=1234;";

        static OracleConnection conn = new OracleConnection(ORAC_ADDR);
        static OracleCommand cmd = new OracleCommand();

        static void Main(string[] args) {
            connectDB();
            while (true) {

                switch (menuSelect()) {
                    case 1:
                        Console.WriteLine("테이블 생성 선택");
                        CTableEmp();
                        CTableDep();
                        CTableSal();
                        break; 
                    case 2:
                        break;
                    case 3:
                        Console.WriteLine("랜덤 데이터 추가");
                        Console.Write("몇개의 데이터 : ");
                        int dNum = int.Parse(Console.ReadLine());

                        Random rand = new Random();

                        for (int i = 0; i < dNum; i++) {

                            string nameR = ((char)rand.Next(65, 91)).ToString() +
                                ((char)rand.Next(65, 91)).ToString() + ((char)rand.Next(65, 91)).ToString();

                            string[] arrJob = new string[]{
                                "사원","과장","차장","부장"
                            };

                            DateTime start = new DateTime(1998, 1, 1);
                            int dateR = ((TimeSpan)(DateTime.Today - start)).Days;
                            Console.WriteLine("int : " + start.AddDays(rand.Next(dateR)));
                            DateTime dt = start.AddDays(rand.Next(dateR));

                            

                            InsertTb(nameR, arrJob[rand.Next(arrJob.Length)],rand.Next(1,1000), dt.ToString("yyyy/MM/dd"),rand.Next(1300,5000),0, ((rand.Next(10, 50)) / 10) * 10);

                        }


                        
                        break;
                    case 4:
                        break;




                }
            }
        }

        static void connectDB() {

            try {
                conn.Open();
                Console.WriteLine("오라클 DB 접속 성공");
            }
            catch (OracleException oe) {
                Console.WriteLine("오라클 DB 접속 에러 : " + oe.Message);
            }
        }

        static int menuSelect() {
            int select = 0;
            Console.WriteLine("=====================================");
            Console.WriteLine("1.테이블 생성");
            Console.WriteLine("2.데이터 추가");
            Console.WriteLine("3.랜덤 데이터 추가");
            Console.WriteLine("4.종료");
            Console.WriteLine("=====================================");

            select = int.Parse(Console.ReadLine());
            return select;
        }

        static void CTableEmp() {

            try {

                string sql = "create table employee ( " +
                    "eNo number PRIMARY KEY," +
                    "ename varchar2(20)," +
                    "job varchar2(20)," +
                    "manager number," +
                    "hiredate date," +
                    "salary number," +
                    "commission number," +
                    "dno number)";

                cmd.Transaction = conn.BeginTransaction();

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                string seqc = "CREATE SEQUENCE eno_SEQ INCREMENT BY 1 START WITH 1 MINVALUE 1 NOCYCLE";

                cmd.Connection = conn;
                cmd.CommandText = seqc;
                cmd.ExecuteNonQuery();

                cmd.Transaction.Commit();

            }
            catch (OracleException e) {

                Console.WriteLine("emp 테이블 오류 : "+e.Message);
                cmd.Transaction.Rollback();
            }
        }

        static void CTableDep() {

            try {
                string sql = "create table department ( " +
                               "dno number," +
                               "dname varchar2(20)," +
                               "loc varchar2(20)";

                cmd.Transaction = conn.BeginTransaction();

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            catch (OracleException e) {

                Console.WriteLine("dep 테이블 오류 : " + e.Message);
            }

        }

        static void CTableSal() {

            try {
                string sql = "create table salgrade ( " +
                             "eno number," +
                             "sal number";

                cmd.Transaction = conn.BeginTransaction();

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            catch (OracleException e) {

                Console.WriteLine("sal 테이블 오류 : " + e.Message);
            }


 
        }
        static void InsertTb(string ename,string job, int manager, string hiredate,int salary , int commission,int dno) {

            string sql = $"insert into employee values(ENO_SEQ.nextval,'{ename}','{job}',{manager},'{hiredate}',{salary},{commission},{dno})";

            Console.WriteLine(sql);

            cmd.Transaction = conn.BeginTransaction(); 

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            cmd.Transaction.Commit();

        }

    }
}
