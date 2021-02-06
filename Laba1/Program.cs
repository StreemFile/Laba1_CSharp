using System;
using System.Drawing;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            // exerciseOne();
            // exerciseTwo();
            // exerciseThree();
            ExerciseFour();
        }

        static void ExerciseOne()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Завдання 2.1");
            Console.WriteLine("Введіть радіус кола");
            int radius = Convert.ToInt32(Console.ReadLine());
            if (radius <= 0)
            {
                Console.WriteLine("Невірно заданий радіус!");
            }
            Console.WriteLine("Введіть координату х");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть координату у");
            int y = Convert.ToInt32(Console.ReadLine());
            if (IsInZone(x,y,radius))
            {
               Console.WriteLine("Точка лежить в заштрихованій зоні"); 
            } else if (IsOnEdge(x,y,radius))
            {
                Console.WriteLine("Точка лежить на межі"); 
            } else
            {
                Console.WriteLine("Точка не лежить в заштрихованій зоні");  
            }
        }

        static bool IsInZone(int x, int y,int radius)
        {
            if ((y >= 0 && x >= 0) || (y <= 0 && x <= 0))
            {
                if ((y <= 0) && (y <= x) && ((-1*y) < radius))
                {
                    return true;
                }
                if ((y >= 0) && (y >= x) && (y < radius))
                {
                    return true;
                }
            }

            return false;
        }

        static bool IsOnEdge(int x, int y, int radius)
        {
            if ((Math.Abs(y) < radius) && (x == radius))
            {
                return true;
            }

            if ((Math.Abs(x) < radius) && (y == radius))
            {
                return true;
            }

            return false;
        }
        
        static void ExerciseTwo()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Завдання 2.2");
            Console.WriteLine("Скільки купити лотерейних білетів?");
            int amountOfTickets = Convert.ToInt32(Console.ReadLine());
            if (amountOfTickets >= 100) 
            {
                Console.WriteLine("Ви виграли водокачку!");
            }
            else
            {
                if (amountOfTickets == 0)
                {
                    Console.WriteLine("Відключити газ");
                }
                else
                {
                    Console.WriteLine("Ви нічого не виграли");
                }
            }
        }
        
        static void ExerciseThree()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Завдання 2.3");
            Console.WriteLine("Введіть порядковий номер місяця: ");
            int numberOfMonth = Convert.ToInt32(Console.ReadLine());
            switch (numberOfMonth)
            {
                case 1:
                    Console.WriteLine("Лютий, березень, квітень, травень, " +
                                      "червень, липень, серпень, вересень, " +
                                      "жовтень, листопад, грудень");
                    break;
                case 2:
                    Console.WriteLine("Березень, квітень, травень, " +
                                      "червень, липень, серпень, вересень, " +
                                      "жовтень, листопад, грудень");
                    break;
                case 3:
                    Console.WriteLine("Квітень, травень, червень, липень, " +
                                      "серпень, вересень, жовтень, листопад, " +
                                      "грудень");
                    break;
                case 4:
                    Console.WriteLine("Травень, червень, липень, серпень," +
                                      " вересень, жовтень, листопад, грудень");
                    break;
                case 5:
                    Console.WriteLine("Червень, липень, серпень, вересень, " +
                                      "жовтень, листопад, грудень");
                    break;
                case 6:
                    Console.WriteLine("Липень, серпень, вересень, " +
                                      "жовтень, листопад, грудень");
                    break;
                case 7:
                    Console.WriteLine("Серпень, вересень, " +
                                      "жовтень, листопад, грудень");
                    break;
                case 8:
                    Console.WriteLine("Вересень, жовтень, листопад, грудень");
                    break;
                case 9:
                    Console.WriteLine("Жовтень, листопад, грудень");
                    break;
                case 10:
                    Console.WriteLine("Ллистопад, грудень");
                    break;
                case 11:
                    Console.WriteLine("Грудень");
                    break;
                case 12:
                    Console.WriteLine("Грудень є останнім місяцем року!");
                    break;
                default:
                    Console.WriteLine("Невірно введений номер місяца!");
                    break;
            }
        }

        static void ExerciseFour()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Завдання 2.4");
            Console.WriteLine("Введіть координату x білого ферзі: ");
            int ferzX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть координату y білого ферзі: ");
            int ferzY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть координату x чорного короля: ");
            int kingX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть координату y чорного короля: ");
            int kingY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть координату x чорного пішака: ");
            int pishakX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть координату y чорного пішака: ");
            int pishakY = Convert.ToInt32(Console.ReadLine());
            
            if ((ferzX > 8 || ferzX <= 0) || (ferzY > 8 || ferzY <= 0))
            {
                Console.WriteLine("Координати ферзі введені невірно.");
            }
            else if ((pishakX > 8 || pishakX <= 0) || (pishakY > 8 || pishakY <= 0))
            {
                Console.WriteLine("Координати пішака введені невірно.");
            }
            else if ((kingX > 8 || kingX <= 0) || (kingY > 8 || kingY <= 0))
            {
                Console.WriteLine("Координати ферзі введені невірно.");
            }
            else if (ferzX == pishakX && ferzY == pishakY)
            {
                Console.WriteLine("Координати ферзі та пішака введені невірно." +
                                  "Вони стоять на одній клітинці");
            }
            else if (ferzX == kingX && ferzY == kingY)
            {
                Console.WriteLine("Координати ферзі та короля введені невірно." +
                                  "Вони стоять на одній клітинці");
            }
            else if (pishakX == kingX && pishakY == kingY)
            {
                Console.WriteLine("Координати пішака та короля введені невірно." +
                                  "Вони стоять на одній клітинці");
            }

            if (IsOnDiagonal(ferzX,ferzY,pishakX,pishakY))
            {
                if (IsOnDiagonal(ferzX, ferzY, kingX, kingY))
                {
                    if (ferzX - pishakX < ferzX - kingX)
                    {
                        Console.WriteLine("Пішак захищає короля");
                    }
                    else
                    {
                        Console.WriteLine("Ферзь має можливість атакувати короля");
                    }
                }
                else
                {
                    Console.WriteLine("Ферзь має можливість атакувати пішака");
                }
            }

            if (IsOnVerticalOrHorizontal(ferzX, ferzY, pishakX, pishakY))
            {
                if (IsOnVerticalOrHorizontal(ferzX, ferzY, kingX, kingY))
                {
                    if ((ferzX - pishakX < ferzX - kingX) || (ferzY - pishakY < ferzX - kingX))
                    {
                        Console.WriteLine("Пішак захищає короля");
                    }
                    else
                    {
                        Console.WriteLine("Ферзь має можливість атакувати короля");
                    }
                }
                else
                {
                    Console.WriteLine("Ферзь має можливість атакувати пішака"); 
                }
            }

            if (IsHorseMove(ferzX, ferzY, pishakX, pishakY))
            {
                if (IsHorseMove(ferzX,ferzY,pishakX,pishakY))
                {
                    Console.WriteLine("Ферзь має можливість атакувати короля");
                }
                else
                {
                    Console.WriteLine("Ферзь має можливість атакувати пішака");
                }
            }

            if (IsOnPishakMove(pishakX, pishakY, ferzX, ferzY))
            {
                Console.WriteLine("Пішак має можливість атакувати ферзя");
            }

            if (IsOnKingMove(kingX, kingY, ferzX, ferzY))
            {
                Console.WriteLine("Король має можливість атакувати ферзя");
            }
        }

        private static bool IsOnDiagonal(int ferzX, int ferzY, int checkedX, int checkedY)
        {
            return Math.Abs(ferzX - checkedX) == Math.Abs(ferzY - checkedY);
        }

        private static bool IsOnVerticalOrHorizontal(int ferzX, int ferzY, int checkedX, int checkedY)
        {
            return (ferzX == checkedX) || (ferzY == checkedY);
        }

        private static bool IsHorseMove(int ferzX, int ferzY, int checkedX, int checkedY)
        {
            if ((ferzX + 2 == checkedX) && (ferzY + 1 == checkedY)) return true;
            if ((ferzX + 2 == checkedX) && (ferzY - 1 == checkedY)) return true;
            if ((ferzX - 2 == checkedX) && (ferzY + 1 == checkedY)) return true;
            if ((ferzX - 2 == checkedX) && (ferzY - 1 == checkedY)) return true;
            
            if ((ferzX + 1 == checkedX) && (ferzY + 2 == checkedY)) return true;
            if ((ferzX + 1 == checkedX) && (ferzY - 2 == checkedY)) return true;
            if ((ferzX - 1 == checkedX) && (ferzY + 2 == checkedY)) return true;
            if ((ferzX - 1 == checkedX) && (ferzY - 2 == checkedY)) return true;
            return false;
        }

        private static bool IsOnPishakMove(int pishakX, int pishakY, int checkedX, int checkedY)
        {
            if ((pishakX + 1 == checkedX) && (pishakY + 1 == checkedY)) return true;
            if ((pishakX - 1 == checkedX) && (pishakY + 1 == checkedY)) return true;
            return false;
        }

        private static bool IsOnKingMove(int kingX, int kingY, int checkedX, int checkedY)
        {
            if (kingX + 1 == checkedX && kingY == checkedY) return true;
            if (kingX - 1 == checkedX && kingY == checkedY) return true;
            if (kingX == checkedX && kingY + 1 == checkedY) return true;
            if (kingX == checkedX && kingY - 1 == checkedY) return true;
            
            return false;
        }
    }
}