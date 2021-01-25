using System;
using System.Collections.Generic;
/**
* Тема: Наследование. Интерфейсы
Задание 1. Реализовать программу “Строительство дома” со следующим описанием:
Бригада строителей (Team) строит дом (House). Дом состоит из следующих частей
(IPart) фундамента (Basement), стен (Wall), окон (Window), дверей (Door), крыши (Roof).
Согласно проекту, в доме должно быть 1 фундамент, 4 стены, 1 дверь, 4 окна и 1 крыша. 
Бригада начинает работу, и строители последовательно “строят” дом, начиная с фундамента.
Каждый строитель (Builder) не знает заранее, на чём завершился предыдущий этап строительства,
поэтому он “проверяет”, что уже построено и продолжает работу. Бригадир (TeamLeader),
он не строит, а формирует отчёт, что уже построено, и какая часть работы выполнена.
В конечном итоге на консоль выводится сообщение, что строительство дома завершено.
Требования к заданию:
•	Реализовать интерфейс работника бригады IWorker с минимум одним методом и свойством
•	Реализовать интерфейс части дома IPart с минимум одним методом и свойством
•	Каждый вид работника и части дома, а также бригада и непосредственно дом 
должен быть реализован отдельным классом и содержаться в отдельном файле.
•	Бригада принимает в качестве параметра конструктора набор работников,
который обязательно должен содержать минимум по одному строителю и бригадиру. 
o	Количество строителей и бригадиров в команде определяется из консоли.
•	Дом принимает в качестве параметра конструктора план, состоящий из частей дома,
расположенных в произвольном порядке.
•	Работники в бригаде работают над заданиями по очереди. Когда работает строитель, 
на экран выводится его должность, имя и название части дома над которой он работает.
Когда работает бригадир, выводится его должность, имя, список того,
что построено и процент выполненных работ по строительству дома.
•	Приступая к работе, строитель «проверяет» что ему нужно сделать,
и выполняет задания в разумном порядке – например,
дверь должна быть установлена только после стен и т.д.
 
•	*: Если строитель получает из плана дома задание, которое он не может выполнить,
выводится причина, по которой он не может её выполнить (напр.: перед тем,
как приступить к стенам, нужно установить фундамент).
•	**: Работники начинают работу над домом со случайным уровнем энергии, 
который колеблется от 80 до 100%. 
o	Уровень энергии – вероятность того, что строитель откажется работать в свою очередь, попросив перерыв.
o	После произведенной работы уровень энергии работника падает на значение от 10 до 20%
o	После перерыва уровень энергии работника повышается на значение от 5 до 15%

*/
namespace HouseBuilding
{
    class Program
    {
        static void Main(string[] args)
        {


            ProjectHouse projectHouse = new ProjectHouse();

            projectHouse.AddPart(new Window());
            projectHouse.AddPart(new Wall());
            projectHouse.AddPart(new Roof());
            projectHouse.AddPart(new Wall());
            projectHouse.AddPart(new Window());
            projectHouse.AddPart(new Wall());
            projectHouse.AddPart(new Door());
            projectHouse.AddPart(new Window());
            projectHouse.AddPart(new Basement());
            projectHouse.AddPart(new Wall());
            projectHouse.AddPart(new Window());

            Team team = new Team(RecruitBuilder(), RecruitTeamLeaders());

            //  team.Work(ref projectHouse);
            House house = new House(team.Work(ref projectHouse));


        }


        private static List<TeamLeader> RecruitTeamLeaders()
        {

            List<TeamLeader> teamLeaders = new List<TeamLeader>();

            Console.WriteLine("Количество TeamLeader");
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                for (int i = 0; i < result; i++)
                {
                    teamLeaders.Add(new TeamLeader());
                }
                //   Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine($"Введено не число, по умолчанию присвоено {result}");
            }

            return teamLeaders;
        }

        private static List<Builder> RecruitBuilder()
        {

            List<Builder> builders = new List<Builder>();

            Console.WriteLine("Количество Builder");
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                for (int i = 0; i < result; i++)
                {
                    builders.Add(new Builder());
                }
                //   Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine($"Введено не число, по умолчанию присвоено {result}");
            }

            return builders;
        }
    }
}
