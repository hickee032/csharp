using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomb2D_02 {
    internal class Bomb2D_02 {
        static void Main(string[] args) {

            string[,] dmz = { { "#", "B", "B" }, { "#","B", "#" }, { "#", "B", "#" } };
            int[,] cnt_dmz = new int[3,3];
            int leftWall = -1, upWall = -1;
            int rightWall = dmz.GetLength(0), downWall = dmz.GetLength(1);

            for (int i = 0; i < rightWall; i++) {
                for (int j = 0; j < downWall; j++) {
                    
                    if (dmz[i,j]=="B") {
                        cnt_dmz[i,j] ++;
                    }
                    //왼
                    if ((i-1) > leftWall && dmz[i-1, j] == "B") {
                        cnt_dmz[i, j]++;
                    }
                    //오른
                    if ((i + 1) < rightWall && dmz[i + 1, j] == "B") {
                        cnt_dmz[i, j]++;
                    }
                    //위
                    if ((j - 1) > upWall && dmz[i, j-1] == "B") {
                        cnt_dmz[i, j]++;
                    }
                    //아래
                    if ((j + 1) < downWall && dmz[i, j+1] == "B") {
                        cnt_dmz[i, j]++;
                    }

                    Console.Write(cnt_dmz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            


        }
    }
}
