using System;
using System.Collections.Generic;
using System.IO;

namespace AbstractFactory
{/// <summary>
 /// Класс для реализации задачи
 /// </summary>
    class Program
    {
        /// <summary>
        /// Общий интерфейс редактора
        /// </summary>
        public interface IAbstractRedactor
        {
            /// <summary>
            /// Функция для возврата настроек для определенных стран
            /// </summary>
            /// <returns>Изменяемые настройки</returns>
            IAbstractSettings GetSettings();
        }
        /// <summary>
        /// Класс Китая редактора
        /// </summary>
        class ChinaRedactor : IAbstractRedactor
        {
            /// <summary>
            /// Функция для настроек Китая
            /// </summary>
            /// <returns>Настройки редактора под Китай</returns>
            public IAbstractSettings GetSettings()
            {
                return new ChinaSettings();
            }
        }
        /// <summary>
        /// Класс России редактора
        /// </summary>
        class RussiaRedactor : IAbstractRedactor
        {
            /// <summary>
            /// Функция для настроек России
            /// </summary>
            /// <returns>Настройки редактора под Россию</returns>
            public IAbstractSettings GetSettings()
            {
                return new RussiaSettings();
            }
        }
        /// <summary>
        /// Класс Германии редактора
        /// </summary>
        class GermanyRedactor : IAbstractRedactor
        {
            /// <summary>
            /// Функция для настроек Германии
            /// </summary>
            /// <returns>Настройки редактора под Германию</returns>
            public IAbstractSettings GetSettings()
            {
                return new GermanySettings();
            }
        }
        /// <summary>
        /// Интерфейс настроек
        /// </summary>
        public interface IAbstractSettings
        {/// <summary>
         /// Изменение настройки Language
         /// </summary>
         /// <returns>Изменяется настройка Language</returns>
            string Language();
            /// <summary>
            /// Изменение настройки Currency
            /// </summary>
            /// <returns>Изменяется настройка Currency</returns>
            string Currency();
            /// <summary>
            /// Изменение настройки CodeOffTheCountry
            /// </summary>
            /// <returns>Изменяется настройка CodeOffTheCountry</returns>
            string CodeOffTheCountry();
            /// <summary>
            /// Изменение настройки WeatherToday
            /// </summary>
            /// <returns>Изменяется настройка WeatherToday</returns>
            string WeatherToday();
            /// <summary>
            /// Изменение настройки DateOfEstablishment
            /// </summary>
            /// <returns>Изменяется настройка DateOfEstablishment</returns>
            string DateOfEstablishment();
            /// <summary>
            /// Изменение настройки PartOfTheWorld
            /// </summary>
            /// <returns>Изменяется настройка PartOfTheWorld</returns>
            string PartOfTheWorld();
            /// <summary>
            /// Изменение настройки Capital
            /// </summary>
            /// <returns>Изменяется настройка Capital</returns>
            string Capital();
            /// <summary>
            /// Изменение настройки Religion
            /// </summary>
            /// <returns>Изменяется настройка Religion</returns>
            string Religion();
            /// <summary>
            /// Изменение настройки Population
            /// </summary>
            /// <returns>Изменяется настройка Population</returns>
            string Population();
            /// <summary>
            /// Изменение настройки AdditionalSettings
            /// </summary>
            /// <returns>Изменяется настройка AdditionalSettings</returns>
            string AdditionalSettings();

        }
        /// <summary>
        /// Класс настроек Китая
        /// </summary>
        class ChinaSettings : IAbstractSettings
        {/// <summary>
         /// Задание значения настройке Language
         /// </summary>
         /// <returns>Заданное значение</returns>
            public string Language()
            {
                return "Chinese";
            }
            /// <summary>
            /// Задание значения настройке Currency
            /// </summary>
            /// <returns>Заданное значение</returns>
            public string Currency()
            {
                return "Yuan";
            }
            /// <summary>
            /// Задание значения настройке CodeOffTheCountry
            /// </summary>
            /// <returns>Заданное значение</returns>
            public string CodeOffTheCountry()
            {
                return "CH";
            }
            /// <summary>
            /// Задание значение настройке WeatherToday
            /// </summary>
            /// <returns>Заданное значение</returns>
            public string WeatherToday()
            {
                return "Sunny, +34";
            }
            /// <summary>
            /// Задание значение настройке DateOfEstablishment
            /// </summary>
            /// <returns>Заданное значение</returns>
            public string DateOfEstablishment()
            {
                return "1 October of 1949";
            }
            /// <summary>
            /// Задание значение настройке PartOfTheWorld
            /// </summary>
            /// <returns>Заданное значение</returns>
            public string PartOfTheWorld()
            {
                return "Asia";
            }
            /// <summary>
            /// Задание значения настройке Capital
            /// </summary>
            /// <returns>Заданное значение</returns>
            public string Capital()
            {
                return "Beijing";
            }
            /// <summary>
            /// Задание значения настройке Religion
            /// </summary>
            /// <returns>Заданное значение</returns>
            public string Religion()
            {
                return "Confucianism and Buddhism";
            }
            /// <summary>
            /// Задание значения настройке Population
            /// </summary>
            /// <returns>Заданное значение</returns>
            public string Population()
            {
                return "1,427,647,786";
            }
            /// <summary>
            /// Задание значения настройке AdditionalSettings
            /// </summary>
            /// <returns>Заданное значение</returns>
            public string AdditionalSettings()
            {
                return "Nothing more";
            }


        }
        /// <summary>
        /// Класс настроек России
        /// </summary>
        class RussiaSettings : IAbstractSettings
        {
            public string Language()
            {
                return "Russian";
            }

            public string Currency()
            {
                return "Rubble";
            }

            public string CodeOffTheCountry()
            {
                return "RU";
            }

            public string WeatherToday()
            {
                return "Cool and Windly, +18";
            }
            public string DateOfEstablishment()
            {
                return "25 December of 1991";
            }

            public string PartOfTheWorld()
            {
                return "Asia and Europe";
            }

            public string Capital()
            {
                return "Moscow";
            }

            public string Religion()
            {
                return "Christianity and Islam";
            }

            public string Population()
            {
                return "146,745,098";
            }

            public string AdditionalSettings()
            {
                return "Nothing more";
            }



        }
        /// <summary>
        /// Класс настроек Германии
        /// </summary>
        class GermanySettings : IAbstractSettings
        {
            public string Language()
            {
                return "German";
            }

            public string Currency()
            {
                return "Euro";
            }

            public string CodeOffTheCountry()
            {
                return "D";
            }

            public string WeatherToday()
            {
                return "Cold and Cloudly, +10";
            }
            public string DateOfEstablishment()
            {
                return "3 October of 1990";
            }

            public string PartOfTheWorld()
            {
                return "Europe";
            }

            public string Capital()
            {
                return "Berlin";
            }

            public string Religion()
            {
                return "Christianity";
            }

            public string Population()
            {
                return "83,564,087";
            }

            public string AdditionalSettings()
            {
                return "Nothing more";
            }


        }
        /// <summary>
        /// Класс под клиента
        /// </summary>
        class Client
        {/// <summary>
         /// Вывод настроек для Китая
         /// </summary>
            public void China()
            {
                ClientMethod(new ChinaRedactor());
                Console.WriteLine();
            }
            /// <summary>
            /// Вывод настроек для России
            /// </summary>
            public void Russia()
            {
                ClientMethod(new RussiaRedactor());
                Console.WriteLine();
            }
            /// <summary>
            /// Вывод настроек для Германии
            /// </summary>
            public void Germany()
            {
                ClientMethod(new GermanyRedactor());
                Console.WriteLine();
            }
            /// <summary>
            /// Вывод на экран настроек с редактора
            /// </summary>
            /// <param name="redactor">обращение к функциям интерфейса редактора</param>
            public void ClientMethod(IAbstractRedactor redactor)
            {
                var Settings = redactor.GetSettings();
                Console.WriteLine(Settings.Language());
                Console.WriteLine(Settings.Currency());
                Console.WriteLine(Settings.CodeOffTheCountry());
                Console.WriteLine(Settings.WeatherToday());
                Console.WriteLine(Settings.DateOfEstablishment());
                Console.WriteLine(Settings.PartOfTheWorld());
                Console.WriteLine(Settings.Capital());
                Console.WriteLine(Settings.Religion());
                Console.WriteLine(Settings.Population());
                Console.WriteLine(Settings.AdditionalSettings());
            }
        }

        /// <summary>
        /// Основное тело программы
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {


            string name;
            Console.WriteLine("Назовите страну:China, Russia, Germany");
            name = Console.ReadLine();
            switch (name)
            {
                case "China":
                    new Client().China();
                    break;
                case "Russia":
                    new Client().Russia();
                    break;
                case "Germany":
                    new Client().Germany();
                    break;
                default:
                    Console.WriteLine("Invalid title of country!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
