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
        private const int TENS_OFFSET = 9;
        private const int HUNDREDS_OFFSET = 18;
        private const int THOUSANDS_OFFSET = 27;

        public static int[,] GetMonksNumber(int number)
        {
            if (number < 0 || number > 9999)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Number must be in the range [0, 9999].");
            }

            if (number < 10)
            {
                return _monkNumbers[number];
            }

            var numbers = number.ToString().ToCharArray();
            var singleDigit2DArray = _monkNumbers[int.Parse(numbers[^1].ToString())];
            var tens2DArray = new int[6, 7];
            var hundreds2DArray = new int[6, 7];
            var thousands2DArray = new int[6, 7];

            if (numbers.Length > 1 && numbers[^2] != '0')
            {
                tens2DArray = _monkNumbers[TENS_OFFSET + int.Parse(numbers[^2].ToString())];
            }
            if (numbers.Length > 2 && numbers[^3] != '0')
            {
                hundreds2DArray = _monkNumbers[HUNDREDS_OFFSET + int.Parse(numbers[^3].ToString())];
            }
            if (numbers.Length == 4 && numbers[0] != '0')
            {
                thousands2DArray = _monkNumbers[THOUSANDS_OFFSET + int.Parse(numbers[0].ToString())];
            }

            // Combine arrays
            int[,] combined2DArray = new int[6, 7];
            for (int i = 0; i < singleDigit2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < singleDigit2DArray.GetLength(1); j++)
                {
                    combined2DArray[i, j] = singleDigit2DArray[i, j] == 1 || tens2DArray[i, j] == 1 || hundreds2DArray[i, j] == 1 || thousands2DArray[i, j] == 1 ? 1 : 0;
                }
            }

            return combined2DArray;
        }
    }
}
