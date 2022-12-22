 Console.Clear();
 Console.WriteLine("Введите 8 чисел массива : ");
            int[] a = new int[8];
            for(int i = 0; i<8;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("\n: {0}",String.Join(" ",a));
            
