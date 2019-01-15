using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
	class Program
	{
		
		static void Main(string[] args)
		{
            //q1(); 
            //q2();
            //q3();
            //q4();
            //q5(5,5,189,54);
            //q6();in a text file 
            //firstQITheSecondePart();
            SecondeQInTheSecondPart();
		}

        private static void SecondeQInTheSecondPart()
        {
            int size = 3;
            int[,]XOBoard= new int[size, size];
            Random t = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    XOBoard[i, j] = t.Next(0, 2);
                    Console.Write(XOBoard[i, j] +"|");
                }
                Console.WriteLine();
                Console.WriteLine("------");
            }
            int winner =CheckWin(XOBoard);
            switch(winner)
            {
                case (-3):
                    Console.WriteLine("draw");
                    break;
                case (-2):
                    Console.WriteLine("illigal input");
                    break;
                case (-1):
                    Console.WriteLine("illigal Board size");
                    break;
                case (0):
                    Console.WriteLine("no winner");
                    break;
                case (1):
                    Console.WriteLine("first player win");
                    break;
                case (2):
                    Console.WriteLine("second player win ");
                    break;

            }
            
                
        }

        private static int CheckWin(int[,] xOBoard)
        {
            bool x=false, o=false; 
            if ((xOBoard.GetLength(0) != 3) || (xOBoard.GetLength(1) != 3))
                return -1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (xOBoard[i, j] != 0 && xOBoard[i, j] != 1)
                        return -2;  
                }
            }// check the input
            for (int i = 0; i < 3; i++)
            {
                if (xOBoard[i, 0] == xOBoard[i, 1] && xOBoard[i, 1] == xOBoard[i, 2] && xOBoard[i, 0] == 1)
                {
                    x = true;
                }//rows x
                if (xOBoard[0, i] == xOBoard[1, i] && xOBoard[1, i] == xOBoard[2, i] && xOBoard[1, i] == 1)
                {
                    x = true;
                }// column x
                if (xOBoard[0, 0] == xOBoard[1, 1] && xOBoard[1, 1] == xOBoard[2, 2] && xOBoard[1, 1] == 1)
                {
                    x = true;
                }// \ x
                if (xOBoard[2, 0] == xOBoard[1, 1] && xOBoard[1, 1] == xOBoard[0, 2] && xOBoard[1, 1] == 1)
                {
                    x = true;
                }// / x
            
                if (xOBoard[i, 0] == xOBoard[i, 1] && xOBoard[i, 1] == xOBoard[i, 2] && xOBoard[i, 0] == 0)
                {
                    o = true;
                }// row o
                if (xOBoard[0, i] == xOBoard[1, i] && xOBoard[1, i] == xOBoard[2, i] && xOBoard[1, i] == 0)
                {
                    o = true;
                }// column o
                if (xOBoard[0, 0] == xOBoard[1, 1] && xOBoard[1, 1] == xOBoard[2, 2] && xOBoard[1, 1] == 0)
                {
                    o  = true;
                }// \ o
                if (xOBoard[2, 0] == xOBoard[1, 1] && xOBoard[1, 1] == xOBoard[0, 2] && xOBoard[1, 1] == 0)
                {
                    o = true;
                }// / o
            }
            if (x&&o)
            {
                return -3;
            }
            if (x)
            {
                return 1;
            }
            if (o)
            {
                return 2;
            }
            return 0;
        }

        private static void firstQITheSecondePart()
		{
			Random rnd = new Random();
			int[] a = new int[rnd.Next(15)];
			int[] b = new int[rnd.Next(15)];
			for (int i = 0; i < a.Length; i++)
			{
				a[i] = rnd.Next(-200, 200);
			}
			for (int i = 0; i < b.Length; i++)
			{
				b[i] = rnd.Next(-200, 200);
			}
			Console.WriteLine(	 Measure( a, b));
			
		}
		private static int Measure( int[] a, int[] b)
		{
			int acounter = 0, bcounter = 0;
			int len = a.Length;
			if (b.Length < a.Length)
				len = b.Length;
			for (int i = 0; i < len; i++)
			{
				if (a[i] > b[i])
					acounter++;
				else
					if (a[i] < b[i])
					bcounter++;
				}
			if (acounter > bcounter)
					return 1;
			else
				if (acounter < bcounter)
					return -1;
			else return 0;
			
		}




		private static void q5(params int [] show)
		{
			for (int i = 0; i < show.Length; i++)
			{
				Console.Write(show[i] + " ");
			}
			Console.WriteLine();
		}//params

		private static void q4()
		{
			int[] a, b;
			InitializeArrays(out a,out b);
			for (int i = 0; i < a.Length; i++)
			{
				Console.WriteLine(a[i]);
			}
			for (int i = 0; i < b.Length; i++)
			{
				Console.WriteLine(b[i]);
			}
		}
		private static void InitializeArrays(out int[] a,out int[] b)
		{
			Random r = new Random();
			a = new int[10];
			b = new int[10];
			for (int i = 0; i < 10; i++)
			{
				a[i] = r.Next(101);
				b[i] = r.Next(101);
			}
		}//for q4

			private static void q3()
		{
			int[] a = { 5, 4, -5 };
			Updateq3(a);
			Console.WriteLine(a[0]);
		}
		static void Updateq3(int[] a)
		{
			a = new int[3];
			a[0] = 1;
		}//for q3



		private static void q2()
		{
			int[] a = { 5, 4, -5 };
			Updateq3(a);
			
		}
		static void Updateq2(int[] a)
		{
			a[0] = 1;
		}//for q2
		  


		static void q1()
		{
			Console.WriteLine("Enter a number:");
			int x = Convert.ToInt32(Console.ReadLine());
			Power2(ref x);
			Console.WriteLine($"power 2 of your number is {x}");
		}
		private static void Power2(ref int i)
		{
			i = i * 2;
		}// for q1

	
	}
}
