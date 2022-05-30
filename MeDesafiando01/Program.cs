using System;

namespace MeDesafiando01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, xy, x2, y2, n, t1, t2, total, 
                v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, 
                v11, v12, v13, v14, v15, v16, v17, v18, v19, v20,               
                va21,va22, va23, va24, va25, va26, va27, va28, va29, va30,
                va31, va32, va33, va34, va35, va36, va37, va38, va39, va40,
                va41, va42, va43, va44, va45, va46, va47, va48, va49, va50;

            n = 10;

            v1 = 165; v2 = 169; v3 = 166; v4 = 158; v5 = 172; v6 = 160; v7 = 167; v8 = 155; v9 = 169; v10 = 166;
            v11 = 168; v12 = 170; v13 = 168; v14 = 160; v15 = 172; v16 = 164; v17 = 165; v18 = 158; v19 = 172; v20 = 164;

            va21 = 27720; va22 = 28730; va23 = 27888; va24 = 25280; va25 = 29584; va26 = 26240; va27 = 27545; va28 = 24496; va29 = 24068; va30 = 27224;
            va31 = 27225; va32 = 28562; va33 = 27556; va34 = 24964; va35 = 29584; va36 = 25600; va37 = 27839; va38 = 24025; va39 = 28563; va40 = 27556;
            va41 = 28224; va42 = 28900; va43 = 28224; va44 = 25600; va45 = 21581; va46 = 26896; va47 = 27325; va48 = 24964; va49 = 29534; va50 = 26896;


            x = v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8 + v9 + v10;
            y = v11 + v12 + v13 + v14 + v15 + v16 + v17 + v18 + v19 + v20;

            xy = va21 + va22 + va23 + va24 + va25 + va26 + va27 + va28 + va29 + va30;
            x2 = va31 + va32 + va33 + va34 + va35 + va36 + va37 + va38 + va39 + va40;
            y2 = va41 + va42 + va43 + va44 + va45 + va46 + va47 + va48 + va49 + va50;

            t1 = n * (xy) - (x * y);
            t2 = Math.Sqrt(n) * (x2 - Math.Pow(x, 2.0)) * Math.Sqrt(n) * (y2 - Math.Pow(y, 2.0));

            total = t1 / t2;

            Console.WriteLine("Total = " + total);
        }
    }
}
