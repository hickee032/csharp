using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_DB {
    internal class Connect_Oracle {

        static string ORA_ADDR =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
            "(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)" +
            "(SERVICE_NAME=XE)));" + //오라클 정식버전은 XE에 이름을 바꿔줘야한다
            "user Id=test;Password=1234;";

        //드라이버 설치 필요
        //Nuget 패키지 관리 >> 찾아보기 >> Oracle.ManagedDataAccess 설치
        //적용한 프로젝트에만 적용됨
        static OracleConnection conn = new OracleConnection(ORA_ADDR);

        //명령어를  쓰기위한 객체 
        static OracleCommand cmd = new OracleCommand();
        static void Main(string[] args) {

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("DBMS 관리 프로그램");
            Console.WriteLine("----------------------------------------");
            connectDB();
            disconnectDB();
        }


        //DB연결 메서드
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
    }
}
