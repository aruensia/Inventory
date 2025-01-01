using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] setbools;
            bool[,] invenArr;
            bool[,] CheckPos;

            Weapon weapon = new Weapon();
            Inventory inventory = new Inventory();

            invenArr = inventory.SetInvenArr(inventory);
            setbools = inventory.SetItem(invenArr, weapon);

            Console.WriteLine("------5*5 이하 크기의 아이템을 넣음------");
            CheckPos = inventory.SellctAddItemPos();
            inventory.AddItem(invenArr, setbools, CheckPos);

            Console.WriteLine($"{invenArr[0, 0]},{invenArr[0, 1]},{invenArr[0, 2]},{invenArr[0, 3]},{invenArr[0, 4]}");
            Console.WriteLine($"{invenArr[1, 0]},{invenArr[1, 1]},{invenArr[1, 2]},{invenArr[1, 3]},{invenArr[1, 4]}");
            Console.WriteLine($"{invenArr[2, 0]},{invenArr[2, 1]},{invenArr[2, 2]},{invenArr[2, 3]},{invenArr[2, 4]}");
            Console.WriteLine($"{invenArr[3, 0]},{invenArr[3, 1]},{invenArr[3, 2]},{invenArr[3, 3]},{invenArr[3, 4]}");
            Console.WriteLine($"{invenArr[4, 0]},{invenArr[4, 1]},{invenArr[4, 2]},{invenArr[4, 3]},{invenArr[4, 4]}");
        }
    }
}
