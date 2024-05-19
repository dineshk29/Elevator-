namespace system
{
    class A

    {
        static void Main(string[] args)
        {
            int f, g = 0,s=0 ;
            Console.WriteLine("                 DINESH ELEVATORS               ");
            while (s<4)
            {
                Console.Write("ENTER THE FLOOR NUMBER(1-5):");
                f = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if(f<0)
                {
                    Console.Write(" DONT ENTER NEGITIVE VALUES");
                    Console.WriteLine();
                }
               
                if (f >= 0 && f < 6)
                {
                    if (g == f)
                    {
                        Console.WriteLine("UR ON CURRENT FLOOR "+g);
                        Console.WriteLine();
                    }
                    else if (g < f)
                    {
                        Console.WriteLine("PLEASE CLOSE THE DOOR!!!!!!!!!!!");
                        for (int i = g; i < f; i++)
                        {                           
                            Thread.Sleep(2000);                            
                            Console.WriteLine("YOU RAECHED  " + i + " FLOOR");
                            Thread.Sleep(2000);
                            Console.WriteLine("YOU DEPARTED " + i + " FLOOR");
                            Console.WriteLine();
                            g = g + 1;
                        }
                        Thread.Sleep(2000);
                        Console.Clear();                       
                        Console.WriteLine("YOU REACHED " + g + " FLOOR");
                        Console.WriteLine();
                    }
                    else if (g > f)
                    {
                        for (int i = g; i > f; i--)
                        {                            
                            Thread.Sleep(2000);
                            Console.WriteLine("YOU REACHED  " + i + " FLOOR");
                            Thread.Sleep(1000);
                            Console.WriteLine("YOU DEPARTED " + i + " FLOOR");
                            Console.WriteLine();
                            g = g - 1;
                        }
                        Thread.Sleep(2000);
                        Console.Clear();  
                        Console.WriteLine("YOU REACHED " + g + " FLOOR");
                        Console.WriteLine();
                    }
                    s++;
                    if(s==4)
                    {
                        Console.WriteLine();
                        Console.WriteLine("THIS IS NOT A PLAY STATION ");   
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("PLEASE SELECT THE VALID FLOOR:");
                }
            }
        }
    }
}