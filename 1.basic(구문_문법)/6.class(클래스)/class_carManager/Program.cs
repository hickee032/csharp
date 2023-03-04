using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*고객 차량 관리 클래스
 * 4개의 클래스를 사용
 * 
 * Car 클래스 모델명 색상 연식 제조사
 * 매개변수가 있는 생성자 추가
 * getter setter 추가
 * 모든 속성을 출력하는 메서드
 * 
 * 고객(customer) 클래스 고객명 전화번호 주소 Car 클래스 속성 생성하고 접근 제한
 * 매개변수가 있는 생성자 추가
 * getter setter 추가
 * 모든 속성을 출력하는 메서드 
 * 고객 정보와 차량정보를 출력하는 메서드 추가
 * 
 * RandomData 클래스를 추가
 * 
 * 10명의 고객 정보를 위한 객체생성
 * 모든 고객 정보와 차량정보를 랜덤으로 설정하고 출력
 */

namespace Class_CarMG {
    internal class Program {
        static void Main(string[] args) {

            RandData rd = new RandData();
            List<Customer> customer = new List<Customer>();

            for (int i = 0; i < 10; i++) {

                customer.Add(new Customer(rd.getName(), rd.getTel(), rd.getAddr(), 
                    new Car(rd.getModel(), rd.getColor(), rd.getYear(), rd.getFac())));
            }

            for (int i = 0; i < 10; i++) {

                customer[i].CustomerInfo();
            }
        }
    }
}
