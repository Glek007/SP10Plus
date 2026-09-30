using System;
using System.Collections.Generic;

namespace SP10Plus
{
    class Question
    {
        public string Text { get; set; }
        public int Scale { get; set; }
        public bool Reversed { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("========================================");
            Console.WriteLine("   ТЕСТ СП-10+   ");
            Console.WriteLine("========================================\n");

            Console.WriteLine("Инструкция:");
            Console.WriteLine("Для шкал 1-6, 8, 9 отвечайте от 1 до 5:");
            Console.WriteLine("1 - Совсем не про меня");
            Console.WriteLine("2 - Скорее не про меня");
            Console.WriteLine("3 - Нечто среднее");
            Console.WriteLine("4 - Скорее про меня");
            Console.WriteLine("5 - Точно про меня\n");

            Console.WriteLine("Для шкал 7 и 10 отвечайте от 0 до 4:");
            Console.WriteLine("0 - Никогда, 1 - Редко, 2 - Иногда, 3 - Часто, 4 - Всегда\n");

            Console.WriteLine("Нажмите Enter, чтобы начать...");
            Console.ReadLine();

            var questions = new List<Question>
            {
                // Шкала 1. Доброжелательность
                new Question { Text = "Я склонен доверять людям, пока они не докажут обратное.", Scale = 1, Reversed = false },
                new Question { Text = "Мне нравится помогать другим, даже если это невыгодно.", Scale = 1, Reversed = false },
                new Question { Text = "Я стараюсь избегать конфликтов.", Scale = 1, Reversed = true },
                new Question { Text = "Я считаю, что большинство людей в основе своей хорошие.", Scale = 1, Reversed = false },
                new Question { Text = "Я легко прощаю обиды.", Scale = 1, Reversed = false },
                new Question { Text = "Мне трудно говорить «нет».", Scale = 1, Reversed = true },

                // Шкала 2. Экстраверсия
                new Question { Text = "Я чувствую себя заряженным после общения с людьми.", Scale = 2, Reversed = false },
                new Question { Text = "Я легко завожу новые знакомства.", Scale = 2, Reversed = false },
                new Question { Text = "Я часто оказываюсь в центре внимания.", Scale = 2, Reversed = false },
                new Question { Text = "Мне нравится быть в шумных компаниях.", Scale = 2, Reversed = false },
                new Question { Text = "Я говорю громко и уверенно.", Scale = 2, Reversed = false },
                new Question { Text = "Я предпочитаю активный отдых с людьми, а не одиночество.", Scale = 2, Reversed = false },

                // Шкала 3. Нейротизм
                new Question { Text = "Я часто чувствую тревогу без причины.", Scale = 3, Reversed = false },
                new Question { Text = "Моё настроение часто меняется.", Scale = 3, Reversed = false },
                new Question { Text = "Я легко расстраиваюсь из-за мелочей.", Scale = 3, Reversed = false },
                new Question { Text = "Я часто чувствую себя уставшим и разбитым.", Scale = 3, Reversed = false },
                new Question { Text = "Мне трудно расслабиться.", Scale = 3, Reversed = false },
                new Question { Text = "Я склонен к самокритике.", Scale = 3, Reversed = false },

                // Шкала 4. Когнитивная эмпатия
                new Question { Text = "Я легко понимаю точку зрения другого человека.", Scale = 4, Reversed = false },
                new Question { Text = "Я могу представить, что чувствует другой, даже если не согласен с ним.", Scale = 4, Reversed = false },
                new Question { Text = "Я часто анализирую мотивы поведения людей.", Scale = 4, Reversed = false },
                new Question { Text = "Мне интересно, почему люди поступают так, а не иначе.", Scale = 4, Reversed = false },
                new Question { Text = "Я замечаю, когда человек говорит одно, а думает другое.", Scale = 4, Reversed = false },

                // Шкала 5. Эмоциональная эмпатия
                new Question { Text = "Мне больно видеть, как страдают другие.", Scale = 5, Reversed = false },
                new Question { Text = "Я часто сопереживаю героям фильмов или книг.", Scale = 5, Reversed = false },
                new Question { Text = "Я чувствую чужую радость как свою.", Scale = 5, Reversed = false },
                new Question { Text = "Мне трудно оставаться равнодушным, когда кто-то плачет.", Scale = 5, Reversed = false },
                new Question { Text = "Я часто думаю о чувствах других людей.", Scale = 5, Reversed = false },

                // Шкала 6. Привязанность
                new Question { Text = "Я боюсь, что меня бросят.", Scale = 6, Reversed = true },
                new Question { Text = "Мне трудно полностью довериться партнёру.", Scale = 6, Reversed = true },
                new Question { Text = "Я часто нуждаюсь в подтверждении, что меня любят.", Scale = 6, Reversed = true },
                new Question { Text = "Я чувствую себя некомфортно, когда кто-то хочет слишком близко.", Scale = 6, Reversed = true },
                new Question { Text = "Я легко сближаюсь с людьми.", Scale = 6, Reversed = false },
                new Question { Text = "Мне важно, чтобы партнёр был рядом постоянно.", Scale = 6, Reversed = true },

                // Шкала 7. Социальная тревожность
                new Question { Text = "Нервничаю при разговоре с незнакомцем.", Scale = 7, Reversed = false },
                new Question { Text = "Боюсь, что меня осудят.", Scale = 7, Reversed = false },
                new Question { Text = "Избегаю звонить по телефону.", Scale = 7, Reversed = false },
                new Question { Text = "Мне трудно выступать перед группой.", Scale = 7, Reversed = false },
                new Question { Text = "Чувствую дискомфорт на вечеринках.", Scale = 7, Reversed = false },
                new Question { Text = "Предпочитаю писать, а не говорить.", Scale = 7, Reversed = false },

                // Шкала 8. Открытость
                new Question { Text = "Я люблю пробовать новое.", Scale = 8, Reversed = false },
                new Question { Text = "Мне нравятся необычные идеи.", Scale = 8, Reversed = false },
                new Question { Text = "Я легко меняю своё мнение под влиянием новых фактов.", Scale = 8, Reversed = false },
                new Question { Text = "Я интересуюсь искусством, философией или наукой.", Scale = 8, Reversed = false },
                new Question { Text = "Я предпочитаю разнообразие, а не рутину.", Scale = 8, Reversed = false },

                // Шкала 9. Импульсивность
                new Question { Text = "Я часто делаю что-то, не подумав.", Scale = 9, Reversed = false },
                new Question { Text = "Я легко поддаюсь соблазнам.", Scale = 9, Reversed = false },
                new Question { Text = "Я могу потратить деньги, не планируя.", Scale = 9, Reversed = false },
                new Question { Text = "Я часто меняю решения в последний момент.", Scale = 9, Reversed = false },
                new Question { Text = "Мне трудно ждать.", Scale = 9, Reversed = false },

                // Шкала 10. Текущий стресс
                new Question { Text = "Я чувствовал напряжение.", Scale = 10, Reversed = false },
                new Question { Text = "Мне было трудно заснуть из-за мыслей.", Scale = 10, Reversed = false },
                new Question { Text = "Я раздражался по мелочам.", Scale = 10, Reversed = false },
                new Question { Text = "Я чувствовал, что не справляюсь.", Scale = 10, Reversed = false },
                new Question { Text = "Я чувствовал усталость без причины.", Scale = 10, Reversed = false }
            };

            var scaleSums = new Dictionary<int, int>();
            for (int i = 1; i <= 10; i++) scaleSums[i] = 0;

            int qNum = 1;
            foreach (var q in questions)
            {
                int minVal = (q.Scale == 7 || q.Scale == 10) ? 0 : 1;
                int maxVal = (q.Scale == 7 || q.Scale == 10) ? 4 : 5;

                Console.Write($"{qNum}. {q.Text} ({minVal}-{maxVal}): ");
                int answer = GetValidInput(minVal, maxVal);

                int score = q.Reversed ? (maxVal + minVal) - answer : answer;
                scaleSums[q.Scale] += score;
                qNum++;
            }

            // Шкала 11
            Console.WriteLine("\n--- Шкала 11 (1 - Да, 0 - Нет) ---");
            string[] lieQuestions =
            {
                "Л1. Я никогда не опаздываю.",
                "Л2. Я никогда никого не осуждал.",
                "Л3. Я всегда говорю только правду.",
                "Л4. Я никогда не раздражался на близких.",
                "Л5. Я всегда выполняю обещания."
            };
            int lieYes = 0;
            foreach (var lq in lieQuestions)
            {
                Console.Write($"{lq} (1 - Да, 0 - Нет): ");
                int ans = GetValidInput(0, 1);
                if (ans == 1) lieYes++;
            }

            // Ситуационные
            Console.WriteLine("\n--- Ситуационные вопросы ---");

            Console.WriteLine("С1. Коллега занял вашу идею и выдал за свою. Что вы сделаете?");
            Console.WriteLine("1) Промолчу\n2) Скажу ему наедине\n3) Скажу при всех\n4) Пожалуюсь начальнику");
            Console.Write("Ваш выбор: ");
            int s1 = GetValidInput(1, 4);
            int[] s1Score = { 0, 1, 3, 2, 1 };
            scaleSums[1] += s1Score[s1];

            Console.WriteLine("С2. Друг просит денег в долг, а вы знаете, что он не вернёт.");
            Console.WriteLine("1) Дам\n2) Откажу\n3) Дам половину\n4) Скажу, что нет денег");
            Console.Write("Ваш выбор: ");
            int s2 = GetValidInput(1, 4);
            int[] s2Score = { 0, 3, 1, 2, 1 };
            scaleSums[1] += s2Score[s2];

            Console.WriteLine("С3. Вы видите, что незнакомец плачет на улице.");
            Console.WriteLine("1) Подойду\n2) Пройду мимо\n3) Позвоню кому-то\n4) Зависит от ситуации");
            Console.Write("Ваш выбор: ");
            int s3 = GetValidInput(1, 4);
            int[] s3Score = { 0, 3, 1, 2, 2 };
            scaleSums[5] += s3Score[s3];

            // ================== РЕЗУЛЬТАТЫ ==================
            Console.WriteLine("\n========================================");
            Console.WriteLine("            РЕЗУЛЬТАТЫ");
            Console.WriteLine("========================================\n");

            // Проверка шкалы лжи
            if (lieYes >= 3)
            {
                Console.WriteLine($"⚠ РЕЗУЛЬТАТ НЕДОСТОВЕРЕН (шкала лжи: {lieYes} из 5).");
                Console.WriteLine("Рекомендации не выдаются. Пройдите тест заново честно.");
                Console.WriteLine("\nНажмите Enter, чтобы выйти...");
                Console.ReadLine();
                return;
            }

            string[] scaleNames =
            {
                "", "Доброжелательность", "Экстраверсия", "Нейротизм",
                "Когнитивная эмпатия", "Эмоциональная эмпатия", "Привязанность (надёжность)",
                "Социальная тревожность", "Открытость опыту", "Импульсивность", "Текущий стресс"
            };

            for (int s = 1; s <= 10; s++)
                Console.WriteLine($"{scaleNames[s]}: {scaleSums[s]} баллов");

            // ================== ФИЛЬТР ЦЕЛЕВОЙ ГРУППЫ ==================
            Console.WriteLine("\n========================================");
            Console.WriteLine("       ВЕРДИКТ ПРОГРАММЫ");
            Console.WriteLine("========================================\n");

            int добро = scaleSums[1];
            int нейро = scaleSums[3];
            int эмоцЭмп = scaleSums[5];
            int привяз = scaleSums[6];
            int тревога = scaleSums[7];
            int стресс = scaleSums[10];

            // Критерии целевой группы
            bool низкаяТревога = тревога <= 10;
            bool низкийНейротизм = нейро <= 14;
            bool высокаяПривяз = привяз >= 20;
            bool низкийСтресс = стресс <= 8;
            bool естьОснова = (добро >= 20) || (эмоцЭмп >= 18);

            bool inTargetGroup = низкаяТревога && низкийНейротизм && высокаяПривяз && низкийСтресс && естьОснова;

            if (!inTargetGroup)
            {
                Console.WriteLine("❌ ВЫ НЕ ВХОДИТЕ В ЦЕЛЕВУЮ ГРУППУ.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Ваш профиль показывает, что поведенческий протокол");
                Console.WriteLine("сам по себе не даст нужного эффекта.");
                Console.WriteLine();
                if (!низкаяТревога) Console.WriteLine($"  • Тревожность слишком высокая ({тревога}). Нужно снижать.");
                if (!низкийНейротизм) Console.WriteLine($"  • Нейротизм слишком высокий ({нейро}). Нужна работа с эмоциями.");
                if (!высокаяПривяз) Console.WriteLine($"  • Способность к привязанности низкая ({привяз}). Нужна терапия.");
                if (!низкийСтресс) Console.WriteLine($"  • Текущий стресс высокий ({стресс}). Сначала антистресс.");
                Console.WriteLine();
                Console.WriteLine("Рекомендация: обратитесь к специалисту.");
                Console.WriteLine("\nНажмите Enter, чтобы выйти...");
                Console.ReadLine();
                return;
            }

            // ================== ЦЕЛЕВАЯ ГРУППА ==================
            Console.WriteLine("✅ ВЫ ВХОДИТЕ В ЦЕЛЕВУЮ ГРУППУ!");
            Console.WriteLine();
            Console.WriteLine("У вас есть природная основа для эффекта.");
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("     УЛУЧШЕНИЕ РАБОТЫ МОЗГА ПРОТОКОЛ (30 дней)");
            Console.WriteLine("========================================\n");
            Console.WriteLine("1. Объятия с близкими — 8 раз в день по 20 секунд.");
            Console.WriteLine("2. Смех — ежедневно (комедии, игры, шутки).");
            Console.WriteLine("3. Пение (хор, караоке, в душе) — 3-4 раза в неделю.");
            Console.WriteLine("4. Питомцы — гладить 10-15 минут в день.");
            Console.WriteLine("5. Природа — 30 минут в день (лес, вода, парк).");
            Console.WriteLine("6. Волонтёрство — 1-2 часа в неделю.");
            Console.WriteLine("7. Медитация любящей доброты — 10 минут в день.");
            Console.WriteLine("8. Сон — 7-9 часов, ложиться до 23:00.");
            Console.WriteLine();
            Console.WriteLine("Это ваш новый образ жизни!");
            Console.WriteLine("30 дней минимум.");
            Console.WriteLine("Моя почта gleb95052@gmail.com пожалуйста по желанию отправте результаты и ФИО и место жительства, может прийти ответ.");

            Console.WriteLine("\nНажмите Enter, чтобы выйти...");
            Console.ReadLine();
        }

        static int GetValidInput(int min, int max)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int value) && value >= min && value <= max)
                    return value;
                Console.Write($"Ошибка. Введите число от {min} до {max}: ");
            }
        }
    }
}
