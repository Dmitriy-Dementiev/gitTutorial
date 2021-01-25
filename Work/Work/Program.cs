using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Work
{
   
    class Program
    {
       private static void Main(string[] args)
        {
                string task = "Выполнить проверку рабочих";
                string check = "Проверка выполнена, замечаний нет!";
                Employee emp = new Employee("Казанцев Вадим Юрьевич", "13.07.1989", "16.10.2011", 2021, "warehouse", "White Acacia", Dolgnost.Рабочий);
                emp.Show();
                Employee emp1 = new Employee("Макаров Владимир Александрович", "05.10.1995", "16.12.2012", 2021, "warehouse", "White Acacia", Dolgnost.Менеджер);
                emp1.Show();
                Employee emp2 = new Employee("Бакин Николай Семёнович", "27.11.1992", "09.02.2014", 2021, "warehouse", "White Acacia", Dolgnost.Бригадир);
                emp2.Show();




                Console.WriteLine("Менеджер: " + task);
                Console.WriteLine("Бригадир: " + check);




                if (emp.Equals(emp1) == true)
                {
                    Console.WriteLine("\nЭкземпляр сотрудника существует!");
                }
                else
                {
                    Console.WriteLine("\nЭкземпляр сотрудника не существует!");
                }
            }
        }

    class Employee
        {
            private string fio;

            public string Fio
            {
                get { return fio; }
                set { fio = value; }
            }

            private string dateBirthday;

            public string DateBirthday
            {
                get { return dateBirthday; }
                set { dateBirthday = value; }
            }

            private string datePrin;

            public string DatePrin
            {
                get { return datePrin; }
                set { datePrin = value; }
            }

            private int outPut;

            public int OutPut
            {
                get { return outPut; }
                set { outPut = value; }
            }

            private string cOrders;

            public string Corders
            {
                get { return cOrders; }
                set { cOrders = value; }
            }

            private string pMaterials;

            public string Pmaterials
            {
                get { return pMaterials; }
                set { pMaterials = value; }
            }



            Dolgnost dolgnost = new Dolgnost();




        public Employee()
            { }

            public Employee(string fio, string dateBirthday, string datePrin, int outPut, string cOrders, string pMaterials, Dolgnost dolgnost)
            {
                this.Fio = fio;
                this.DateBirthday = dateBirthday;
                this.DatePrin = datePrin;
                this.OutPut = outPut;
                this.Corders = cOrders;
                this.Pmaterials = pMaterials;
                this.dolgnost = dolgnost;
            }



            public void Show()
            {
                Console.WriteLine("Информация о сотруднике:");
                Console.WriteLine(@"
                    ФИО сотрудника: {0}
                    Дата рождения: {1}
                    Дата приема на роботу: {2}
                    Выпуск Продукции : {3}
                    Сбор заказов: {4}
                    Закупка материалов: {5}
                    Должность: {6}", Fio, DateBirthday, DatePrin, OutPut, Corders, Pmaterials, dolgnost);
                Console.WriteLine();
            }

            public static Boolean operator ==(Employee One, Employee Two)
            {
                return object.Equals(One, Two);
            }

            public static Boolean operator !=(Employee One, Employee Two)
            {
                return !object.Equals(One, Two);
            }

            public override bool Equals(object obj)  //Перегрузка метода 
            {
                Employee temp = (Employee)obj;
                return (Fio == temp.Fio && DateBirthday == temp.DateBirthday && DatePrin == temp.DatePrin && OutPut == temp.OutPut && Corders == temp.Corders &&
                        Pmaterials == temp.Pmaterials && dolgnost == temp.dolgnost);
            }
        }
    
class Delete
{
    private static int workers;

    ////объявляем переменную workers
    public static void Main2(string[] args)
    {
        List<string> myWorkers = new List<String>(workers); ////Создаём массив из сотрудника
        myWorkers.Add("Никитенко Илья Сергеевич");          //// Создаем работника
        myWorkers.Remove("Казанцев Вадим Юрьевич");         //// Удаляем ненужного нам сотрудника
        myWorkers.AddRange(new string[] { "Зайцев Александр Николаевич", "Антипов Михаил Антонович" });  ////Добавляем диапазон из двух сотрудников
        myWorkers.RemoveAt(2); ////удаляем два массива(сотрудника)
        Console.WriteLine(myWorkers[0]);
    }
}

class Employees
{
    public string Id { get; set; }
    public int Num { get; set; }

    public static void Main3(string[] args)
    {
        Employees empl1 = new Employees();
        Employees empl2 = new Employees();
        Employees empl3 = new Employees();
        Employees empl4 = new Employees();
        Employees empl5 = new Employees();
        Employees empl6 = new Employees();
        Employees empl7 = new Employees();
        empl1.Id = "\nКазанцев Вадим Юрьевич";
        empl2.Id = "\nМакаров Владимир Александрович";
        empl3.Id = "\nБакин Николай Семёнович";
        empl4.Num = 3;
        empl5.Id = "Рабочий";
        empl6.Id = "Менеджер";
        empl7.Id = "Бригадир";

        string employee1 = (string)empl1.Id;
        string employee2 = (string)empl2.Id;
        string employee3 = (string)empl3.Id;
        int Num = (int)empl4.Num;
        string employee5 = (string)empl5.Id;
        string employee6 = (string)empl6.Id;
        string employee7 = (string)empl7.Id;
        Console.WriteLine($"Сотрудники: {employee1}  {employee2}  {employee3} {employee5}  {employee6}  {employee7} \nКоличество Сотрудников: {Num}");
        Console.ReadKey();
    }
}

    enum Dolgnost
    {
        Рабочий,
        Менеджер,
        Бригадир

    }
}
















