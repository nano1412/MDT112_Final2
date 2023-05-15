using System;

class Program
{
  static void Main(string[] args)
  {
    WaterSupply();
    Treasurer();
  }

  static void WaterSupply()
  {
    double vMax = double.Parse(Console.ReadLine());
    double vDrink = double.Parse(Console.ReadLine());
    double vFill = double.Parse(Console.ReadLine());
    double tDrink = double.Parse(Console.ReadLine());
    double tFill = double.Parse(Console.ReadLine());
    double tDay = double.Parse(Console.ReadLine());

    double currentWater = vMax;
    bool isOverflow = false;

    for (double currentTime = 1; currentTime <= tDay; currentTime++)
    {
      if (currentTime % tDrink == 0)
      {
        currentWater -= vDrink;
      }
      if (currentWater < 0)
      {
        break;
      }
      if (currentTime % tFill == 0)
      {
        currentWater += vFill;
      }
      if (currentWater > vMax)
      {
        currentWater = vMax;
        isOverflow = true;
      }
      currentWater = Math.Round(currentWater, 2);
    }

    if (currentWater >= 0)
    {
      Console.WriteLine("Enough Water, {0} left", currentWater);
    }
    else
    {
      Console.WriteLine("Not Enough Water");
    }
    if (isOverflow)
    {
      Console.WriteLine("Overflow Water");
    }
  }

  static void Treasurer()
  {
    double[] b = new double[3];
    double l = 0;
    double itemPrice;

    b[0] = double.Parse(Console.ReadLine());
    b[1] = double.Parse(Console.ReadLine());
    b[2] = double.Parse(Console.ReadLine());

    do
    {
      itemPrice = double.Parse(Console.ReadLine());
      if (itemPrice <= 0) { break; }
      if (itemPrice < b[0])
      {
        b[0] = b[0] - itemPrice;
      }
      else if (itemPrice < b[1])
      {
        b[1] = b[1] - itemPrice;
      }
      else if (itemPrice < b[2])
      {
        b[2] = b[2] - itemPrice;
      }
      else
      {
        l = l + itemPrice;
      }


      Math.Round(b[0], 2);
      Math.Round(b[1], 2);
      Math.Round(b[2], 2);
      Math.Round(l, 2);

    } while (itemPrice > 0);

    Console.WriteLine("Balance 1 : {0:0.00}, Balance 2 : {1:0.00}, Balance 3 : {2:0.00}", b[0], b[1], b[2]);
    if (l > 0)
    {
      Console.WriteLine("Left: {0:0.00}", l);
    }
  }
}