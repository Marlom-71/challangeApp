﻿namespace ConsoleApp1projekt21
{
    public class Employee
    {

        private List<int> score = new List<int>();

        public Employee(string imie, string nazwisko,int wiek )
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
        }
        public string imie { get; private set; }
        public string nazwisko { get; private set; }
        public int wiek { get; private set; }
        public int Rezult
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int score)
        {
            this.score.Add(score);
        }
    }
}
