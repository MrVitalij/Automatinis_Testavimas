using System;
using NUnit.Framework;

namespace uzduotis13
{
    [TestFixture]
    public class Tests
    {
        // 1. Testas “žalias” jeigu 995 dalijasi iš 3 (be liekanos)

        [Test]
        public void TestDivisibleByThree()
        {
            int number = 995;
            Assert.AreEqual(0, number % 3, "995 should be divisible by 3 without remainder");
        }

        // 2. Testas “žalias” jeigu šiandien trečiadienis

        [Test]
        public void TestTodayIsWednesday()
        {
            DateTime today = DateTime.Now;
            Assert.AreEqual(DayOfWeek.Wednesday, today.DayOfWeek, "Today should be Wednesday");
        }

        // 3. Testas “žalias” jeigu dabar yra 13h

        [Test]
        public void TestCurrentHourIs13()
        {
            int currentHour = DateTime.Now.Hour;
            Assert.AreEqual(13, currentHour, "The current hour should be 13");
        }

        // 4. Bonus: Testas “žalias” jei nuo 1 iki 10 (imtinai) yra 4 lyginiai skaičiai

        [Test]
        public void TestFourEvenNumbersBetween1And10()
        {
            int evenCount = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    evenCount++;
                }
            }

            Assert.AreEqual(4, evenCount, "There should be 4 even numbers between 1 and 10 (inclusive)");
        }
    }
}