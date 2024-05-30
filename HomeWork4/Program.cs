using System.Text;

namespace HomeWork4
{

    //enum Operation 
    //    {
    //        Plus = '+',
    //        Minus = '-',
    //        Multiply = '*',
    //        Divide = '/'
    //    }

    enum PizzaType
    {
        Pizza1 = 1,
        Pizza2 = 2,
        Pizza3 = 3,
        Pizza4 = 4
    }
    enum DrinkType
    {
        Drink1 = 1,
        Drink2 = 2,
        Drink3 = 3
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Task1  
            //try
            //{

            //    double num1, num2, result;

            //    Console.WriteLine("Привіт! Це калькулятор :)");
            //    Console.WriteLine("Введіть перше число:");
            //    num1 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Введіть операцію (+, -, *, /):");
            //    var Operarion = (Operation)Convert.ToChar(Console.ReadLine() ?? string.Empty);

            //    Console.WriteLine("Введіть друге число:");
            //    num2 = Convert.ToDouble(Console.ReadLine());

            //    switch (Operarion)
            //    {
            //        case Operation.Plus:
            //            result = num1 + num2;
            //            break;
            //        case Operation.Minus:
            //            result = num1 - num2;
            //            break;
            //        case Operation.Multiply:
            //            result = num1 * num2;
            //            break;
            //        case Operation.Divide:
            //            if (num2 != 0)
            //            {
            //                result = num1 / num2;
            //            }
            //            else
            //            {
            //                throw new DivideByZeroException("Помилка: Ділення на нуль неможливе!");

            //            }
            //            break;
            //        default:
            //            throw new ArgumentException("Помилка: Неправильна операція!");  //Не вірно введене якесь значення


            //    }
            //    Console.WriteLine("Результат:" + result);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Невірний формат!");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("Занадто велике значення!");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");

            //}





            //Task2

            try
            {
                Console.WriteLine("Вітаємо в нашій піцерії! Наше меню: ");

                Console.WriteLine("Піци:");
                Console.WriteLine("1.Піца Маргарита - $10.0");
                Console.WriteLine("2. Піца Папероні - $12.0");
                Console.WriteLine("3. Піца Гавайська - $11.0");
                Console.WriteLine("4. Піца Веган - $9.0");
                Console.WriteLine("0.Вихід");

                Console.WriteLine("Напої:");
                Console.WriteLine("1. Кола - $2.0");
                Console.WriteLine("2. Спрайт - $2.5");
                Console.WriteLine("3. Фанта - $3.0");
                Console.WriteLine("0.Вихід");


                Console.WriteLine("Введіть код піци, який бажаєте замовити:");
                int PizzaCode = Convert.ToInt32(Console.ReadLine());

                if (PizzaCode == 0)
                {
                    Console.WriteLine("Допобачення!");
                    return;
                }

                PizzaType pizzaType = (PizzaType)PizzaCode;

                Console.WriteLine("Веведіть кількість піц у замовленні:");
                var PizzaQuantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть код напою, який бажаєте замовити:");
                int DrinkCode = Convert.ToInt32(Console.ReadLine());
                if (DrinkCode == 0)
                {
                    Console.WriteLine("Допобачення!");
                    return;
                }
                DrinkType drinkType = (DrinkType)DrinkCode;

                Console.WriteLine("Веведіть кількість напоїв у замовленні:");
                var DrinkQuantity = Convert.ToInt32(Console.ReadLine());

                // Піца
                decimal pizzaUnitPrice;
                switch (pizzaType)
                {
                    case PizzaType.Pizza1:
                        pizzaUnitPrice = 10.0m;
                        break;
                    case PizzaType.Pizza2:
                        pizzaUnitPrice = 12.0m;
                        break;
                    case PizzaType.Pizza3:
                        pizzaUnitPrice = 11.0m;
                        break;
                    case PizzaType.Pizza4:
                        pizzaUnitPrice = 9.0m;
                        break;
                    default:
                        throw new ArgumentException("Неправильний код піци");

                }
                //Акції піца
                
                int freePizzas = PizzaQuantity / 5;
                int paidPizzas = PizzaQuantity - freePizzas;
                decimal pizzaTotal = pizzaUnitPrice * paidPizzas;

                
                //Напої 
                decimal drinkUnitPrice;
                switch (drinkType)
                {
                    case DrinkType.Drink1:
                        drinkUnitPrice = 2.0m;
                        break;
                    case DrinkType.Drink2:
                        drinkUnitPrice = 2.5m;
                        break;
                    case DrinkType.Drink3:
                        drinkUnitPrice = 3.0m;
                        break;
                    default: throw new ArgumentException("Неправильний код напою");
                }
                //Акції Напої
                decimal drinkTotal = drinkUnitPrice * DrinkQuantity;
                if (drinkUnitPrice > 2.0m && DrinkQuantity > 3)
                {
                    drinkTotal *= 0.85m;
                }

                //Загальна сума замовлення 
                decimal grandTotal = pizzaTotal + drinkTotal;

                if (grandTotal > 50)
                {
                    grandTotal *= 0.8m;

                }
                // Результат замовлення
                Console.WriteLine("\nВаше замовлення:");
                Console.WriteLine($"Піца - {PizzaQuantity}шт. - ${pizzaTotal}");
                Console.WriteLine($"Напої - {DrinkQuantity}шт. - ${drinkTotal}");
                Console.WriteLine($"Загальна сума: ${grandTotal}");
            }
            catch (FormatException) 
            {
                Console.WriteLine("Невірний формат");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }













        }








    }












}           
                
               

                



















            

         
            











               
