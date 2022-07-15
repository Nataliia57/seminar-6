// написать программу которая найдет точку пересечения двух прямых

        void Zadacha43()
        {
            Console.WriteLine("введите первое значение b1: ");
            double b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе значение k1: ");
            double k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе значение b2: ");
            double b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе значение k2: ");
            double k2 = Convert.ToInt32(Console.ReadLine());
            double x;
            double y;

            if (k1 != k2)
            {
                x = ((b2 - b1) / (k1 - k2));
            Console.WriteLine("точка пересечения x равна: " + x);
            y = (k2 * x + b2);
             Console.WriteLine("точка пересечения y равна: " + y);
             }
             else Console.WriteLine("прямые параллельны");
            

            

        }

        Zadacha43();