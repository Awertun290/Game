namespace Практика_7_.Net._8._0
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    static class Global
    {
        public static List<string> images = new List<string>() { @"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7_.Net.8.0\Практика_7_.Net.8.0\Стрелочки\Гнутая красная стрелка.png",
        @"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7_.Net.8.0\Практика_7_.Net.8.0\Стрелочки\Гнутая красная стрелка.png",
        @"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7_.Net.8.0\Практика_7_.Net.8.0\Стрелочки\Коричневый крендель.png",
        @"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7_.Net.8.0\Практика_7_.Net.8.0\Стрелочки\Коричневый крендель.png",
        @"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7_.Net.8.0\Практика_7_.Net.8.0\Стрелочки\Наикривейшая фиолетовая стрелка.png",
        @"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7_.Net.8.0\Практика_7_.Net.8.0\Стрелочки\Наикривейшая фиолетовая стрелка.png",
        @"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7_.Net.8.0\Практика_7_.Net.8.0\Стрелочки\Неплохая оранжевая стрелочка.png",
        @"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7_.Net.8.0\Практика_7_.Net.8.0\Стрелочки\Неплохая оранжевая стрелочка.png",
        @"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7_.Net.8.0\Практика_7_.Net.8.0\Стрелочки\Нормальная красная стрелка.png",
        @"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7_.Net.8.0\Практика_7_.Net.8.0\Стрелочки\Нормальная красная стрелка.png",
        @"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7_.Net.8.0\Практика_7_.Net.8.0\Стрелочки\Ужастная зелёная стрелка.png",
        @"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7_.Net.8.0\Практика_7_.Net.8.0\Стрелочки\Ужастная зелёная стрелка.png",
        @"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7_.Net.8.0\Практика_7_.Net.8.0\Стрелочки\Хорошая синяя стрелочка.png",
        @"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7_.Net.8.0\Практика_7_.Net.8.0\Стрелочки\Хорошая синяя стрелочка.png",
        @"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7_.Net.8.0\Практика_7_.Net.8.0\Стрелочки\Чёрная упоротая стрелка.png",
        @"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7_.Net.8.0\Практика_7_.Net.8.0\Стрелочки\Чёрная упоротая стрелка.png"};
        
        public static List<Button> buttons = new List<Button>();
        public static List<object> pair = new List<object>(2);
    }
}