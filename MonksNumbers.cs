﻿namespace Monks
{
    internal static class MonksNumbers
    {
        // Cistercian monks' numbering system from the 13th century (added zero)
        private static readonly int[][,] _monkNumbers = new int[37][,] {
            // 0
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 1
            new int[,] {
                {0,0,0,1,1,1,1},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 2
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,1,1,1},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 3
            new int[,] {
                {0,0,0,1,1,0,0},
                {0,0,0,1,0,1,0},
                {0,0,0,1,0,0,1},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 4
            new int[,] {
                {0,0,0,1,0,0,1},
                {0,0,0,1,0,1,0},
                {0,0,0,1,1,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 5
            new int[,] {
                {0,0,0,1,1,1,1},
                {0,0,0,1,0,1,0},
                {0,0,0,1,1,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 6
            new int[,] {
                {0,0,0,1,0,0,1},
                {0,0,0,1,0,0,1},
                {0,0,0,1,0,0,1},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 7
            new int[,] {
                {0,0,0,1,1,1,1},
                {0,0,0,1,0,0,1},
                {0,0,0,1,0,0,1},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 8
            new int[,] {
                {0,0,0,1,0,0,1},
                {0,0,0,1,0,0,1},
                {0,0,0,1,1,1,1},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 9
            new int[,] {
                {0,0,0,1,1,1,1},
                {0,0,0,1,0,0,1},
                {0,0,0,1,1,1,1},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 10
            new int[,] {
                {1,1,1,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 20
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {1,1,1,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 30
            new int[,] {
                {0,0,1,1,0,0,0},
                {0,1,0,1,0,0,0},
                {1,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 40
            new int[,] {
                {1,0,0,1,0,0,0},
                {0,1,0,1,0,0,0},
                {0,0,1,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 50
            new int[,] {
                {1,1,1,1,0,0,0},
                {0,1,0,1,0,0,0},
                {0,0,1,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 60
            new int[,] {
                {1,0,0,1,0,0,0},
                {1,0,0,1,0,0,0},
                {1,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 70
            new int[,] {
                {1,1,1,1,0,0,0},
                {1,0,0,1,0,0,0},
                {1,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 80
            new int[,] {
                {1,0,0,1,0,0,0},
                {1,0,0,1,0,0,0},
                {1,1,1,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 90
            new int[,] {
                {1,1,1,1,0,0,0},
                {1,0,0,1,0,0,0},
                {1,1,1,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 100
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,1,1,1}
            },
            // 200
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,1,1,1},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 300
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,1},
                {0,0,0,1,0,1,0},
                {0,0,0,1,1,0,0}
            },
            // 400
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,1,0,0},
                {0,0,0,1,0,1,0},
                {0,0,0,1,0,0,1}
            },
            // 500
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,1,0,0},
                {0,0,0,1,0,1,0},
                {0,0,0,1,1,1,1}
            },
            // 600
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,1},
                {0,0,0,1,0,0,1},
                {0,0,0,1,0,0,1}
            },
            // 700
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,1},
                {0,0,0,1,0,0,1},
                {0,0,0,1,1,1,1}
            },
            // 800
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,1,1,1},
                {0,0,0,1,0,0,1},
                {0,0,0,1,0,0,1}
            },
            // 900
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,1,1,1},
                {0,0,0,1,0,0,1},
                {0,0,0,1,1,1,1}
            },
            // 1000
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {1,1,1,1,0,0,0}
            },
            // 2000
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {1,1,1,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0}
            },
            // 3000
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {1,0,0,1,0,0,0},
                {0,1,0,1,0,0,0},
                {0,0,1,1,0,0,0}
            },
            // 4000
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,1,1,0,0,0},
                {0,1,0,1,0,0,0},
                {1,0,0,1,0,0,0}
            },
            // 5000
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,1,1,0,0,0},
                {0,1,0,1,0,0,0},
                {1,1,1,1,0,0,0}
            },
            // 6000
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {1,0,0,1,0,0,0},
                {1,0,0,1,0,0,0},
                {1,0,0,1,0,0,0}
            },
            // 7000
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {1,0,0,1,0,0,0},
                {1,0,0,1,0,0,0},
                {1,1,1,1,0,0,0}
            },
            // 8000
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {1,1,1,1,0,0,0},
                {1,0,0,1,0,0,0},
                {1,0,0,1,0,0,0}
            },
            // 9000
            new int[,] {
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {0,0,0,1,0,0,0},
                {1,1,1,1,0,0,0},
                {1,0,0,1,0,0,0},
                {1,1,1,1,0,0,0}
            }
        };

        public static int[,] GetMonksNumber(int number) {
            if (number < 0 || number > 9999)
            {
                return new int[6, 7];
            }

            if (number < 10)
            {
                return _monkNumbers[number];
            }

            var numbers = number.ToString().ToCharArray();
            var singleArr = _monkNumbers[int.Parse(numbers[^1].ToString())]; // index 0-9 = 0=0,1=1,2=2,3=3,4=4,5=5,6=6,7=7,8=8,9=9
            var tensArr = new int[6, 7]; // index 10-18 = 10=10,11=20,12=30,13=40,14=50,15=60,16=70,17=80,18=90
            var hundredsArr = new int[6, 7]; // index 19-27 = 19=100,20=200,21=300,22=400,23=500,24=600,25=700,26=800,27=900
            var tousandsArr = new int[6, 7]; // index 28-36 = 28=1000,29=2000,30=3000,31=4000,32=5000,33=6000,34=7000,35=8000,26=9000

            if (numbers.Length > 1 && numbers[^2] != '0')
            {
                tensArr = _monkNumbers[9 + int.Parse(numbers[^2].ToString())];
            }
            if (numbers.Length > 2 && numbers[^3] != '0')
            {
                hundredsArr = _monkNumbers[18 + int.Parse(numbers[^3].ToString())];
            }
            if (numbers.Length == 4 && numbers[0] != '0')
            {
                tousandsArr = _monkNumbers[27 + int.Parse(numbers[0].ToString())];
            }

            // add all arrays into one combined one
            int[,] result = new int[6, 7];
            for (int i = 0; i < singleArr.GetLength(0); i++)
            {
                for (int j = 0; j < singleArr.GetLength(1); j++)
                {
                    result[i, j] = singleArr[i, j] == 1 || tensArr[i, j] == 1 || hundredsArr[i, j] == 1 || tousandsArr[i, j] == 1 ? 1 : 0;
                }
            }

            return result;
        }
    }
}