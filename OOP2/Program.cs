using System;
using System.Collections.Generic;

namespace ConsoleApp38
{
     class Medicine
    {

        public string Name { get; set; }
        public double Price { get {
                return this.Price;
            
            
            } set {

                if (value > 0)
                {
                    this.Price = value;


                }
            
            } }
        public int Count { get { return this.Count; } set {
                if (value >= 0)
                { this.Count = value; }
            } }
        public Medicine(string name, double price)
        {
            Name = name;
            Price = price;
        }


    }

    class Pharmacy
    {
        private static double TotalIncome{ get; set; }

        List<Medicine> medicines = new List<Medicine>();
        public Medicine this[int index]
        {
            set
            {
                if(index>=0 && index < medicines.Count)
                {
                    medicines[index] = value;
                }
            }
            get
            {
                if (index >= 0 && index < medicines.Count)
                {
                    return medicines[index];
                }
            return ;
            }
        }
        public void Sell(string name,int count)
        {
            Medicine m=medicines.Find(m => m.Name == name && m.Count >= count);
            if (m == null)
            {
                Console.WriteLine("Your medicine has not found!");
            }
            else
            {
                TotalIncome += m.Count * m.Price;
                m.Count -= count;
            }


        }
        public Medicine FindMedicineByName(string name)
        {
            return medicines.Find(m=>m.Name.Equals(name));
        }
        public void AddMedicine(Medicine medicine)
        {
            Medicine m = medicines.Find(m => m.Name == medicine.Name);
            if (m == null)
            {
                medicines.Add(medicine);
            }
            else
            {
                m.Count += medicine.Count;
            }
        }
        public double GetTotalIncome()
        {
            return Pharmacy.TotalIncome;
        }







    class Program
    {





        static void Main(string[] args)
        {
                Medicine med1 = new Medicine("med1", 20);
                Medicine med2 = new Medicine("med2", 30);
                Medicine med3 = new Medicine("med3", 40);
                Pharmacy p = new Pharmacy();
                p[0] = med1;
                p[1] = med2;
                p[2] = med3;

                p.Sell("med1",10);
                Console.WriteLine(med1.Count);

            
        }
    
}
