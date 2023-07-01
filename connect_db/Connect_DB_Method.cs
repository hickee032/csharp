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

//데이터 입력은 Main()에서 받기
//1.데이터 추가메뉴를 추가해서 학번 이름 나이 주소를 입력받아 DB에 insert
//2.랜덤 데이터를 생성해서 데이터를 추가하기



namespace Connect_DB_Method {
    internal class DB_PR_02 {
        static string ORA_ADDR =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
            "(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)" +
            "(SERVICE_NAME=XE)));" +
            "user Id=test;Password=1234;";

        //오라클 접속
        static OracleConnection conn = new OracleConnection(ORA_ADDR);

        //명령어를  쓰기위한 객체 
        static OracleCommand cmd = new OracleCommand();

        static void Main(string[] args) {

            connectDB();

            while (true) {
                switch (mainmenu()) {

                    case 1:
                        createTable();
                        break;
                    case 2:
                        dropTable();
                        break;
                    case 3:
                        showTable();
                        break;
                    case 4:
                        Console.Write("이름 입력 :");
                        string nameSearch = Console.ReadLine();
                        searchName(nameSearch);
                        break;
                    case 5:

                        Console.Write("이름 입력 :");
                        string name = Console.ReadLine();
                        Console.Write("나이 입력 :");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("주소 입력 :");
                        string addr = Console.ReadLine();

                        insertTable(name, age, addr);
                        break;
                    case 6:

                        Console.Write("업데이트 할 학번을 입력 :");

                        int inputId = int.Parse(Console.ReadLine());

                        updateTable(inputId);

                        break;
                    case 7:

                        Console.WriteLine("랜덤 데이터 추가");
                        string[] arrAddr = new string[5] { "seoul", "daegu", "busan", "jenju", "kangwon" };

                        Random rand = new Random();

                        for (int i = 0; i < 100; i++) {
                            //이름
                            char nameR = (char)rand.Next(65, 91);
                            //나이
                            int ageR = rand.Next(20, 27);

                            insertTable(char.ToString(nameR), ageR, arrAddr[rand.Next(arrAddr.Length)]);

                        }
                        break;
                    case 8:

                        Console.WriteLine("데이터 삭제 (이름 검색)");
                        Console.Write("삭제할 이름을 입력 :");
                        string delName = Console.ReadLine();
                        deleteDataTable(delName);
                        break;

                    case 9:

                        Console.WriteLine("시퀀스 추가");
                        createSeq();
                        break;

                    case 10:

                        Console.WriteLine("시퀀스 삭제");
                        createSeq();
                        break;

                    case 11:
                        Console.WriteLine("프로그램 종료");
                        disconnectDB();
                        Environment.Exit(0);
                        break;
                    default:

                        break;

                }
            }
        }
        static int mainmenu() {

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("DBMS 관리 프로그램");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. 테이블 생성");
            Console.WriteLine("2. 테이블 삭제");
            Console.WriteLine("3. 테이블 보기");
            Console.WriteLine("4. 테이블 검색 (이름 검색)");
            Console.WriteLine("5. 데이터 추가");
            Console.WriteLine("6. 데이터 업데이트 (이름 나이 주소)");
            Console.WriteLine("7. 랜덤 데이터 추가");
            Console.WriteLine("8. 데이터 삭제 (이름 검색)");
            Console.WriteLine("9. 시퀀스 삭제");
            Console.WriteLine("10. 시퀀스 추가");
            Console.WriteLine("11. 종료");
            Console.WriteLine("----------------------------------------");

            while (true) {

                try {

                    Console.Write("입력 >>");
                    int n = int.Parse(Console.ReadLine());
                    return n;
                }
                catch (Exception e) {
                    Console.WriteLine("잘못된 입력 : " + e.Message);
                    //return 3;
                }

            }


        }
        static void connectDB() {
            //try catch 예외처리
            //if else 경우 개발자가 예외를 예상하고 사용
            //try catch 경우 예상하지 못한 예외 생겨 문제가 발생할 경우 
            //파일제어, 네트워크, DB 경우 try catch의 사용을 권장 
            try {
                conn.Open(); //DB 접속
                Console.WriteLine("오라클 DB 접속 성공");
            }
            catch (OracleException oe) {
                Console.WriteLine("오라클 DB 접속 에러 : " + oe.Message);
            }
        }
        static void disconnectDB() {
            try {
                if (conn != null) {
                    conn.Close(); //DB 접속 해제
                    Console.WriteLine("오라클 DB 접속 해제");
                }
            }
            catch (OracleException oe) {

                Console.WriteLine("오라클 DB 접속 해제 오류 : " + oe.Message);
            }


        }
        static void createTable() {
            //create, insert, delete, update 동일           
            Console.WriteLine("테이블 생성");

            try {
                //사용할 SQL문 -> 문자열
                string sql = "create table stud_t(" +
                               "id number primary key," +
                               "name varchar2(20)," +
                               "age number not null," +
                               "addr varchar2(50) not null)";

                cmd.Transaction = conn.BeginTransaction(); //커밋을 사용하기위해 트랜잭션 활용

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                //테이블 생성시 시퀀스 생성
                /*
                string sqlseq = "CREATE SEQUENCE id_SEQ INCREMENT BY 1START WITH 1MINVALUE 1 NOCYCLE";

                cmd.Transaction = conn.BeginTransaction(); //커밋을 사용하기위해 트랜잭션 활용

                cmd.Connection = conn;
                cmd.CommandText = sqlseq;
                cmd.ExecuteNonQuery();
                */
                cmd.Transaction.Commit();//커밋을 사용

            }
            catch (OracleException e) {

                Console.WriteLine("테이블 생성 오류 :" + e.Message);
                //테이블 생성시 오류가 발생 -> 롤백해줘야한다
                cmd.Transaction.Rollback(); //롤백
            }
        }
        static void dropTable() {
            Console.WriteLine("테이블 삭제");
            try {
                string sql = "drop table stud_t";

                cmd.Transaction = conn.BeginTransaction();

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                cmd.Transaction.Rollback();
            }
            catch (OracleException e) {

                Console.WriteLine("테이블 삭제 오류 :" + e.Message);
                cmd.Transaction.Rollback();
            }

        }
        static void insertTable(string name, int age, string addr) {
            Console.WriteLine("테이블 데이터 추가");

            try {
                //string sql = "insert into stud_t values(id_SEQ.nextval," + $"'{name}'" + "," + age + "," + $"'{addr}'" + ")";
                //string sql = $"insert into stud_t values(id_SEQ.nextval,'{name}',{age},'{addr}')";
                string sql = string.Format("insert into stud_t values(id_SEQ.nextval,'{0}',{1},'{2}')", name, age, addr);

                // string sql = "insert into stud_t values(100,'rla',14,'skarn')";

                Console.WriteLine(sql);

                cmd.Transaction = conn.BeginTransaction(); //커밋을 사용하기위해 트랜잭션 활용

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                cmd.Transaction.Commit();
            }
            catch (Exception e) {

                Console.WriteLine("데이터 추가 오류 : " + e.Message);
            }


        }
        static void showTable() {

            string query = "select * from stud_t";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text; ;

            //오라클 데이터를 읽어 오기 위한 클래스 (오라클 커서와 비슷) 
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows) {
                while (dr.Read()) {

                    Console.WriteLine($"학번 : {dr["id"]}");
                    Console.WriteLine($"이름 : {dr["name"]}");
                    Console.WriteLine($"나이 : {dr["age"]}");
                    Console.WriteLine($"주소 : {dr["addr"]}");
                    Console.WriteLine("-------------------------------");
                }
            }
            else {
                Console.WriteLine("데이터가 존재하지 않습니다");
            }
        }
        static void searchName(string inname) {

            string query = "select * from stud_t where name = '" + inname+"'";
            Console.WriteLine(query);   
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType= System.Data.CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows) {
                while (dr.Read()) {

                    Console.WriteLine($"학번 : {dr["id"]}");
                    Console.WriteLine($"이름 : {dr["name"]}");
                    Console.WriteLine($"나이 : {dr["age"]}");
                    Console.WriteLine($"주소 : {dr["addr"]}");
                    Console.WriteLine("-------------------------------");
                }
            }
            else {
                Console.WriteLine("데이터가 존재하지 않습니다");
            }

        }
        static void deleteDataTable(string delName) {


            string sql = "DELETE FROM stud_t" + "WHERE name = " + $"'{delName}'";

            cmd.Transaction = conn.BeginTransaction(); //커밋을 사용하기위해 트랜잭션 활용

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            cmd.Transaction.Commit();//커밋을 사용
        }
        static void createSeq() {

            try {

                string sql = "CREATE SEQUENCE id_SEQ INCREMENT BY 1 START WITH 1 MINVALUE 1 NOCYCLE";

                cmd.Transaction = conn.BeginTransaction(); //커밋을 사용하기위해 트랜잭션 활용

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                cmd.Transaction.Commit();
            }
            catch (Exception e) {

                Console.WriteLine("시퀀스 생성 오류" + e.Message);


            }
        }
        static void dropSeq() {

            try {

                string sql = "drop SEQUENCE id_SEQ";

                cmd.Transaction = conn.BeginTransaction(); //커밋을 사용하기위해 트랜잭션 활용

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                cmd.Transaction.Commit();
            }
            catch (Exception e) {

                Console.WriteLine("시퀀스 삭제 오류" + e.Message);


            }
        }

        static void updateTable(int id) {

            //create, insert, delete, update 동일           
            Console.WriteLine("테이블 생성");

            try {

                Console.Write("이름 입력 :");
                string name = Console.ReadLine();
                Console.Write("나이 입력 :");
                int age = int.Parse(Console.ReadLine());
                Console.Write("주소 입력 :");
                string addr = Console.ReadLine();

                string sql = $"update stud_t set name = '{name}', age = {age},addr = '{addr}' where id = {id}";

                cmd.Transaction = conn.BeginTransaction(); //커밋을 사용하기위해 트랜잭션 활용

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                cmd.Transaction.Commit();//커밋을 사용
            }
            catch (OracleException e) {

                Console.WriteLine("업데이트 오류 :" + e.Message);
                //테이블 생성시 오류가 발생 -> 롤백해줘야한다
                cmd.Transaction.Rollback(); //롤백
            }
        }    
    }
}
