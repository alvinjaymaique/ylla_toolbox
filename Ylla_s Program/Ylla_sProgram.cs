using System;
namespace Ylla
{
	class Revenue
	{
		double profit, cost, pPerUnit, qProduced;
		int choice;
		public void Revenue1()
		{
			Console.WriteLine("Choose Formula");
			Console.WriteLine("1.) [Revenue = Profit + Cost]\n2.) [Revenue = Price Per Unit Sold X Quantity Sold]");
			Console.Write("Enter Input(Other Number to Exit): ");
			choice = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			switch (choice)
			{
				case 1:
					Console.Write("Formula: [Revenue = Profit + Cost]\nEnter Profit: ");
			        profit = Convert.ToDouble(Console.ReadLine());
			        Console.Write("Enter Cost: ");
			        cost = Convert.ToDouble(Console.ReadLine());
			        Console.WriteLine("Revenue = {0}\n", profit+cost);
					break;
				case 2:
					Console.Write("[Revenue = Price Per Unit Sold X Quantity Sold]\nEnter Price Per Unit Sold: ");
					pPerUnit = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Quantity Sold: ");
					qProduced = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Revenue = {0}\n",pPerUnit*qProduced);
					break;
			}
		}
	}
	class Profit
	{
		double revenue, cost, pPerUnit, qProduced, sPrice, qSold, fCost;
		int choice;
		public void Profit1()
		{
			Console.WriteLine("Choose Formula");
			Console.WriteLine("1.) [Profit = Revenue - Cost]\n2.) [Profit = Revenue - (Fixed Cost + Price Per Unit X Quantity Produced)]");
			Console.WriteLine("3.) [Profit = Selling Price X Quantity Sold - (Fixed Cost + Price Per Unit X Quantity Produced)]");
			Console.Write("Enter Input: ");
			choice = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			switch (choice)
			{
				case 1:
					Console.Write("[Profit = Revenue - Cost]\nEnter Revenue: ");
			        revenue = Convert.ToDouble(Console.ReadLine());
			        Console.Write("Enter Cost: ");
			        cost = Convert.ToDouble(Console.ReadLine());
			        Console.WriteLine("Profit = {0}\n", revenue-cost);
					break;
				case 2:
					Console.Write("[Profit = Revenue - (Fixed Cost + Price Per Unit X Quantity Produced)]\nEnter Revenue: ");
					revenue = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Fixed Cost: ");
					fCost = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Price Per Unit: ");
					pPerUnit = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Quantity of Product: ");
					qProduced = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Revenue = {0}\n",revenue-(fCost+(pPerUnit*qProduced)));
					break;
				case 3:
					Console.Write("[Profit = Selling Price X Quantity Sold - (Fixed Cost + Price Per Unit X Quantity Produced)]\nEnter Selling Price: ");
					sPrice = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Quantity Sold: ");
					qSold = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Fixed Cost: ");
					fCost = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Price Per Unit: ");
					pPerUnit = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Quantity Produced: ");
					qProduced = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Revenue = {0}\n",(sPrice*qSold)-(fCost+(pPerUnit*qProduced)));
					break;
			}
			
		}
	}
	class Cost
	{
		int choice;
		double revenue, profit, fCost, vCost, pPerUnit, qProduced;
		public void Cost1()
		{
			Console.WriteLine("Choose Formula");
			Console.WriteLine("1.) [Cost = Revenue - Profit]\n2.) [Cost = Fixed Cost + Variable Cost]");
			Console.WriteLine("3.) [Cost = Fixed Cost + Price Per Unit X Quantity Produced]");
			Console.Write("Enter Input(Other Number to Exit): ");
			choice = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			switch (choice)
			{
				case 1:
					Console.Write("[Cost = Revenue - Profit]\nEnter Revenue: ");
					revenue = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Profit: ");
					profit = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Cost = {0}\n",revenue-profit);
					break;
				case 2:
					Console.Write("[Cost = Fixed Cost + Variable Cost]\nEnter Fixed Cost: ");
					fCost = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Variable Cost: ");
					vCost = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Cost = {0}\n",fCost+vCost);
					break;
				case 3:
					Console.Write("[Cost = Fixed Cost + Price Per Unit X Quantity Produced]\nEnter Fixed Cost: ");
					fCost = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Price Per Unit: ");
					pPerUnit = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Quantity Produced: ");
					qProduced = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Cost = {0}\n",fCost+(pPerUnit*qProduced));
					break;
			}
			
		}
	}
	class FixedCost
	{
		int choice;
		double cost, vCost, pPerUnit, qProduced;
		public void FixedCost1()
		{
			Console.WriteLine("Choose Formula");
			Console.WriteLine("1.) [Fixed Cost = Cost - Variable Cost]\n2.) [Fixed Cost = Cost - Price Per Unit X Quantity Produced]");
			Console.Write("Enter Input(Other Number to Exit): ");
			choice = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			switch (choice)
			{
				case 1:
					Console.Write("[Fixed Cost = Cost - Variable Cost]\nEnter Cost: ");
					cost = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Variable Cost: ");
					vCost = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Fixed Cost = {0}\n",cost-vCost);
					break;
				case 2:
					Console.Write("[Fixed Cost = Cost - Price Per Unit X Quantity Produced]\nEnter Cost: ");
					cost = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Price Per Unit: ");
					pPerUnit = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Quantity Produced: ");
					qProduced = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Fixed Cost = {0}\n",cost+(pPerUnit*qProduced));
					break;
			}
		}
	}
	class VariableCost
	{
		int choice;
		double cost, fCost, pPerUnit, qProduced;
		public void VariableCost1()
		{
			Console.WriteLine("Choose Formula");
			Console.WriteLine("1.) [Variable Cost = Cost - Fixed Cost]\n2.) [Variable Cost = Price Per Unit X Quantity Produced]");
			Console.Write("Enter Input(Other Number to Exit): ");
			choice = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			switch (choice)
			{
				case 1:
					Console.Write("[Variable Cost = Cost - Fixed Cost]\nEnter Cost: ");
					cost = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Fixed Cost: ");
					fCost = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Variable Cost = {0}\n",cost-fCost);
					break;
				case 2:
					Console.Write("[Variable Cost = Price Per Unit X Quantity Produced]\nEnter Price Per Unit: ");
					pPerUnit = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Quantity Produced: ");
					qProduced = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Variable Cost = {0}\n",pPerUnit*qProduced);
					break;
			}
		}
	}
	class PricePerUnit
	{
		double vCost, qProduced, cost, fCost;
		int choice;
		public void PPerUnit1()
		{
			Console.WriteLine("Choose Formula");
			Console.WriteLine("1.) [Price Per Unit = Variable Cost / Quantity Produced]\n2.) [Price Per Unit = (Cost - Fixed Cost) / Quantity Produced]");
			Console.Write("Enter Input(Other Number to Exit): ");
			choice = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			switch (choice)
			{
				case 1:
					Console.Write("Formula: [Price Per Unit = Variable Cost / Quantity Produced]\nEnter Variable Cost: ");
			        vCost = Convert.ToDouble(Console.ReadLine());
			        Console.Write("Enter Quantity Produced: ");
			        qProduced = Convert.ToDouble(Console.ReadLine());
			        Console.WriteLine("Price Per Unit = {0}\n",vCost/qProduced);
			        break;
				case 2:
					Console.Write("[Price Per Unit = (Cost - Fixed Cost) / Quantity Produced]\nEnter Cost: ");
					cost = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Fixed Cost: ");
					fCost = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Quantity Produced: ");
					qProduced = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Price Per Unit = {0}\n",(cost-fCost)/qProduced);
					break;
			}
		}
	}
	class QuantityProduced
	{
		double vCost, pPerUnit, cost, fCost;
		int choice;
		public void QProduced1()
		{
			Console.WriteLine("Choose Formula");
			Console.WriteLine("1.) [Quantity Produced = Variable Cost / Price Per Unit]\n2.) [Quantity Produced = (Cost - Fixed Cost) / Price Per Unit]");
			Console.Write("Enter Input(Other Number to Exit): ");
			choice = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			switch (choice)
			{
				case 1:
					Console.Write("Formula: [Quantity Produced = Variable Cost / Price Per Unit]\nEnter Variable Cost: ");
			        vCost = Convert.ToDouble(Console.ReadLine());
			        Console.Write("Enter Price Per Unit: ");
			        pPerUnit = Convert.ToDouble(Console.ReadLine());
			        Console.WriteLine("Quantity Produced = {0}\n",vCost/pPerUnit);
			        break;
				case 2:
					Console.Write("[Quantity Produced = (Cost - Fixed Cost) / Price Per Unit]\nEnter Cost: ");
					cost = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Fixed Cost: ");
					fCost = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter Price Per Unit: ");
					pPerUnit = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Quantity Produced = {0}\n",(cost-fCost)/pPerUnit);
					break;
			}
		}
	}
	class Business
	{
		public static void Main()
		{
			sbyte choice=-1;
			Revenue revenue = new Revenue();
			Profit profit = new Profit();
			Cost cost = new Cost();
			FixedCost fcost = new FixedCost();
			VariableCost vCost = new VariableCost();
			PricePerUnit pPerUnit = new PricePerUnit();
			QuantityProduced qProduct= new QuantityProduced();
			
			
			string block = new String('=',65);
			Console.WriteLine("\n\n\t\t\t"+block);
			Console.WriteLine("\t\t\t||\t\t\t\t\t\t\t\t||");
			Console.Write("\t\t\t||");
			Console.Write("\t\tYLLA's Calculator for Business");
			Console.WriteLine("\t\t\t||");
			Console.WriteLine("\t\t\t||\t\t\t\t\t\t\t\t||");
			Console.WriteLine("\t\t\t"+block);
			
			
			Console.WriteLine("\n\n\n\n\t\t\t Enter one of the digit corresponding to the one you want to access. \n\n");
			while(choice!=0)
			{
				Console.WriteLine(block);
				Console.WriteLine("1.) Revenue\n2.) Profit\n3.) Cost\n4.) Fixed Cost\n5.) Variable Cost");
				Console.WriteLine("6.) Price Per Unit\n7.) Quantity Produced\n9.) Clear Screen\n0.) Exit");
				Console.Write("\nPick a Number: ");
				choice=Convert.ToSByte(Console.ReadLine());
				Console.WriteLine("");
				switch (choice)
				{
					case 1:
						revenue.Revenue1();
						break;
					case 2:
						profit.Profit1();
						break;
					case 3:
						cost.Cost1();
						break;
					case 4:
						fcost.FixedCost1();
						break;
					case 5:
						vCost.VariableCost1();
						break;
					case 6:
						pPerUnit.PPerUnit1();
						break;
					case 7:
						qProduct.QProduced1();
						break;
					case 9:
						Console.Clear();
						break;
				}
			}
		}
	}
}