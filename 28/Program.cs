using System;
class TrianglePrism
{
    public static double ans;
    public static void Main(string[] args)
    {
        int side1;
        int side2;
        int side3;
        int height;
        int bottom1;
        int bottom_height;
        int ci;
        
        while (true) {
            Console.WriteLine("三角柱の底面積の求め方を選択してください\n3辺の長さ:1\n底辺の長さと底辺の高さ:2");
            ci = int.Parse(Console.ReadLine());
            
            if (ci==1)
            {
                Console.WriteLine("3辺の長さ\n----------");
                Console.WriteLine("1つ目の辺の長さ");
                side1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2つ目の辺の長さ");
                side2 = int.Parse(Console.ReadLine());
                Console.WriteLine("3つ目の辺の長さ");
                side3= int.Parse(Console.ReadLine());
                Console.WriteLine("三角柱の高さ");
                height = int.Parse(Console.ReadLine());
                if (side1 < side2 + side3 || side2 < side1 + side3 || side3 < side1 + side2)
                {
                    TrianglePrism bottom = new TrianglePrism(side1,side2,side3,height);
                    Console.WriteLine("答え:" + ans);
                    break;
                }
            }
            else if (ci == 2)
            {
                Console.WriteLine("底辺の長さと底辺の高さ\n----------");
                Console.WriteLine("三角形の底辺の長さ");
                bottom1 = int.Parse(Console.ReadLine());
                Console.WriteLine("底辺の高さ");
                bottom_height = int.Parse(Console.ReadLine());
                Console.WriteLine("三角柱の高さ");
                height = int.Parse(Console.ReadLine());
                TrianglePrism bottom = new TrianglePrism(bottom1, bottom_height, height);
                Console.WriteLine("答え:" + ans);
                break;
            }
            else
            {
                Console.WriteLine("もう一度やり直してください");
            }
        }
    }
    public TrianglePrism(int side1,int side2,int side3,int height)
    {
       
        double s = (side1 + side2 + side3) / 2;
        ans = Math.Sqrt(s*(s-side1)*(s-side2)*(s-side3));
    }
    public TrianglePrism(int bottom,int bottom_height,int height)
    {
        ans = bottom * bottom_height / 2;
    }
}
