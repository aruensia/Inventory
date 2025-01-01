using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Weapon
    {
        public bool[,] weaponBool;

        public Weapon()
        {

        }

        public Weapon(bool[,] weaponBool)
        {
            this.weaponBool = weaponBool;
        }
    }

    internal class Inventory
    {
        public bool[,] bools;
        public int setXNum = 0;
        public int setYNum = 0;

        public void SetInventory(int X, int Y)
        {
            bools = new bool[X, Y];
        }

        public bool[,] SetInvenArr(Inventory inventory)
        {
            bool[,] arr;

            setXNum = 5;
            setYNum = 5;

            inventory.SetInventory(setXNum, setYNum);
            return arr = inventory.bools;
        }

        public bool[,] SetItem(bool[,] myinventory, Weapon weapon)
        {
            int itemXSize = int.Parse(Console.ReadLine());
            int itemYSize = int.Parse(Console.ReadLine());

            bool[,] arr = new bool[itemXSize, itemYSize];
            
            weapon.weaponBool = arr;
            return weapon.weaponBool;
        }

        public bool[,] SellctAddItemPos()
        {
            Console.WriteLine("배치할 위치");
            int bools1 = int.Parse(Console.ReadLine());
            int bools2 = int.Parse(Console.ReadLine());
            bool[,] SellctBoolPos = new bool[bools1, bools2];

            return SellctBoolPos;
        }

        public void AddItem(bool[,] bools, bool[,] weaponbools, bool[,] SellectBoolPos)
        {
            if (weaponbools != null)
            {
                int sumnum1 = SellectBoolPos.GetLength(0) + weaponbools.GetLength(0);
                int sumnum2 = SellectBoolPos.GetLength(1) + weaponbools.GetLength(1);


                Console.WriteLine(sumnum1);
                Console.WriteLine(sumnum2);


                if (SellectBoolPos.GetLength(0)+weaponbools.GetLength(0) < bools.GetLength(0) || SellectBoolPos.GetLength(1) + weaponbools.GetLength(1) < bools.GetLength(1))
                {
                    for (int i = 0; i < weaponbools.GetLength(0); i++)
                    {
                        for (int j = 0; j < weaponbools.GetLength(1); j++)
                        {
                            bools[i, j] = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("아이템이 인벤토리에 안들어갑니다.");
                }
            }
        }
    }
}
