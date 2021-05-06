using System;
using System.IO;
using System.Text;                  
using System.Windows.Forms;         
//Событие по изменению состояния радиобутон не работает , если в двух разных
//Стоящих друг за другом вопросах правильные ответы находятся на одних и тех
//же позициях
//Нажатие на радиобаттон- переход к новому вопросу
//Сохранение выбора пользователя , при переходе на прошлый вопрос
//Рандомная расстановка вариантов ответов
namespace QuickQuiz
{

    public partial class Form1 : Form
    {
        string[] Questions;                     //Массив , содержащий вопросы
        string[,] Answers;                      //Массив , содержащий ответы
        string quiz_file_path = "Quiz.txt";     //Название файла , содержайщего вопросы и ответы
        bool[,] radioButtonsState;              //Массив , содержащий состояния radiobutton
        string[,] ArrayWithMixedAnswer;         //Массив , сохраняющий состояния radiobutton.text
        bool flag;                              //Флаг , для повторного прохождения теста
        int total;                              //Поля для размерности массивов
        int current_nr;                         //Счетчик 
        int score;                              //Очки 
        int [] correct_number;                  //Массив , содержащий правильные ответы
        Random rnd = new Random();              //Рандомайзер для перемешивания вопросов
        
        public Form1()
        {
            InitializeComponent();
            LoadQuiz();                         //Загрузка строк из файла
        }
        private void LoadQuiz()                                    //Метод , для загрузки вопросов из файла с дальнейшим
        {                                                          //Распределением их по разным массивам
            try
            {
                string[] lines = File.ReadAllLines(quiz_file_path,Encoding.UTF8);   //Загрузка текста из файла
                total = lines.Length / 4;              //мы знаем , что  на 1 вопрос с 3 ответами приходится 4 строки
                Answers = new string[total, 3];        //=> кол-во строк вопросов равно строки поделить на 4       
                Questions = new string[total];         //В дальнейшем в двумерный массив с ответами выделяем место
                correct_number = new int[total];       //где под 1 вопрос 3 ответа , затем  выделяем память , для массива
                ArrayWithMixedAnswer = new string[total, 3];  //который будет содержать в себе индексы правильных ответов
                radioButtonsState = new bool[total, 3];  //Задаем размер массиву 
                score = 0;                             //Первоначально количество очков=0
                flag = true;                           //Переключаем флаг
                current_nr = 0;                        //Счетчик в положение 0
                for (int i = 0; i < total; i++)        //Заполнение массива 
                {                                                   
                    Questions[i] = lines[i * 4];       //Заполняем массив строками с вопросами
                    for (int j = 0; j < Answers.GetLength(1); j++)
                    {
                        Answers[i, j] = lines[i * 4 + j + 1];   //Этот массив заполняем строками с ответами
                        ArrayWithMixedAnswer[i, j] = "";        //Этотм массив "кастыль"
                    }
                }
                 MixQuestion();                        //Перемешиваем массив с вопросами
            }
            catch                       //Отлавливаем экзепшен , если не найден файл с вопросами/ответами
            {
                MessageBox.Show("Не найден файл с тестом!");
            }
        }
        private void ShowQuiz(int nr)                              //Метод , отображающий вопросы и ответы
        {
            if (nr < 0 | nr > total) return;        //Если счетчик меньше 0 или больше , чем количество вопросов - отмена
            label_question1.Text = Questions[nr];   //Задаем в label текст вопроса
            MixAnswer(nr);                          //Перемешиваем ответы
            if (radioButtonsState[nr, 0] != null)   //Если в массиве с radiobutton , есть значения на текущий вопрос
                     ShowLastState();               //Отобразить состояния тех radiobutton
            else                                    //Иначе состояния всех переключателей 
            {                                       //Перевести в false
             radioButton_answer1.Checked = false;
             radioButton_answer2.Checked = false;
             radioButton_answer3.Checked = false;
            }
        }
        private void Form1_Shown(object sender, EventArgs e)       //При загрузке формы
        {
            ShowQuiz(current_nr);                                  //Отобразить первый вопрос
        }
        private void button_last_Click(object sender, EventArgs e) //При нажатии кнопкни
        {
            if (flag)                                              //Если флаг для прохождения , то 
            {                                                           
                if (current_nr > 0)                                //Проверка счетчика, если вопрос не последний , то       
                {                                                   
                    CheckAnswer();                                 //Проверяем текущий ответ
                    if (score > 0) score--;                        //Если количество очков больше 0 , то отнимаем
                    current_nr--;                                  //Отнимаем 1 у счетчика
                    ShowQuiz(current_nr);                          //Отображаем вопрос от нового значения счетчика
                    ShowLastState();                               //Отображаем состояния radiobutton по текущему счетчику
                }
            }
            else
            {
                label_result.Text = "";                            //Если флаг равен false
                button_last.Text = "Previous";                     //Меняем надпись кнопки
                LoadQuiz();                                        //Загружаем по новой список вопросов , конечно можно было
                ShowQuiz(current_nr);                              //бы использовать старый массив , но ради интереса хочется
                                                                   //чтобы вопросы снова перемешались
            }
        }
        private void ShowLastState()                               //Метод отображения состояний radibutton по счетчику
        {
            radioButton_answer1.Checked = radioButtonsState[current_nr, 0];
            radioButton_answer2.Checked = radioButtonsState[current_nr, 1];
            radioButton_answer3.Checked = radioButtonsState[current_nr, 2];   
        }
        private void MixAnswer(int nr)                              //Перемешка ответов
        {
            if (ArrayWithMixedAnswer[nr, 0] == "")                  //Если в массиве нет записей о прошлом состоянии поля
            {                                                       //Text в radiobutton
                int[] array = new int[3];                           //Создаем массив с номерами , через который будем мешать
                for (byte b = 0; b < array.Length; b++)             //ответы на вопросы
                {                                                   
                label1: array[b] = rnd.Next(0, 3);                  //Если элемент повторился  , то оказываемся здесь 
                    for (byte d = 0; d < b; d++)                    //Цикл для проверки на повторяемость 
                    {
                        if (array[b] == array[d]) goto label1;      //При обнаржуении повтора , переходим по метке для 
                    }                                               //новой инициализации рандомного значения
                }                                                   //После того , как массив инициализировался разными не
                radioButton_answer1.Text = Answers[nr, array[0]];   //повторяющимися значениями , мы присваиваем radiobutton
                radioButton_answer2.Text = Answers[nr, array[1]];   //разные значения массива с ответами с помощью массива  
                radioButton_answer3.Text = Answers[nr, array[2]];   //с разными значениями , которые используем ,как индексы
                correct_number[nr] = Array.IndexOf(array, 0);           //Записываем индекс правильного ответа в переменную
            }
            else                                                    //Если  же у нас в массиве записей уже есть состояния полей
            {                                                       //То для отображения прошлых значений , отображаем значения
                radioButton_answer1.Text = ArrayWithMixedAnswer[nr,0];  //Этого массива
                radioButton_answer2.Text = ArrayWithMixedAnswer[nr,1];  //СИТУАЦИЯ ДЛЯ РАЗМЫШЛЕНИЯ: Допустим , что пользователь
                radioButton_answer3.Text = ArrayWithMixedAnswer[nr,2];  //впервые отвечает на вопрос(ответил неправильно)
                                                    //переключился на новый вопрос , ответил и на него
                                                    //вспомнил , что ответ на один вопрос назад , неправильный
                                                    //переменная correctnumber уже изменила свое значение 
                                                    //как ему снова ответить на вопрос , но уже чтобы ответ засчитался , как
                                                    //правильный? 
            //ИЗМЕНЕНИЯ: изменил поле current_answer на массив , для записей всех правильных ответов
            }
        }
        private void MixQuestion()                                   //Метод , для перемешивания вопросов
        {                                                            //Размер метода определяется количеством вопросов
            int[] array = new int[total];                            //Мы создаем здесь копии массива вопросов и ответом
            string[] CopyQuestion = new string[Questions.Length];    //Чтобы в дальнейшем в уже рабочем массивах тусовать
            string[,] CopyAnswers = new string[Answers.GetLength(0), //позции из копий
                                              Answers.GetLength(1)];
            for (int i = 0; i < total; i++)                          //Заполнение массивов копий
            {                                                                               
                CopyQuestion[i] = Questions[i];
                for (int j = 0; j < Answers.GetLength(1); j++)
                    CopyAnswers[i, j] = Answers[i, j];
            }
            for (byte b = 0; b < array.Length; b++)                  //Абсолютно  алгоритм для тусовки , но уже вопросов и  
            {                                                        //соответствующих вопросов
            label2: array[b] = rnd.Next(0, total);
                for (byte d = 0; d < b; d++)
                    if (array[b] == array[d]) goto label2;
            }
            for(int i = 0; i < array.Length; i++)                    //Тусовка и присвоение значений
            {
                Questions[i] = CopyQuestion[array[i]];
                for(int k = 0; k < CopyAnswers.GetLength(1); k++)
                    Answers[i, k] = CopyAnswers[array[i], k];
            }
        }
        private void CheckAnswer()
        {
            switch (correct_number[current_nr])         //Проверяем ответ в зависимости от текущего счетчика
            {
                case 0:
                    if (radioButton_answer1.Checked)
                        score++;
                    break;
                case 1:
                    if (radioButton_answer2.Checked)
                        score++;
                    break;
                case 2:
                    if (radioButton_answer3.Checked)
                        score++;
                    break;
            }
        }                               //Метод для проверки правильности ТЕКУЩЕГО ответа на вопрос
        private void Result()                                       //Метод , отображающий результат прохождения
        {
            flag = false;                                           //Ставим флаг на false 
            double result = (score *100) / total;                   //Нахождение процентого составляющего
            label_result.Text = "Результат " + result + "%";        //Отображение
            button_last.Text = "Try again?";       
        }                                    
        private void radioButton_answer1_MouseClick(object sender, MouseEventArgs e) //События для ответа на вопрос
        {
            CheckAnswer();                                                           //Проверка текущего ответа
            if (current_nr + 1 < total)                                              //Если счетчик меньше максимального 
            {                                                                        //положения , то состояния radiobutton
                radioButtonsState[current_nr, 0] = radioButton_answer1.Checked;      //записываются в массив состояний
                radioButtonsState[current_nr, 1] = radioButton_answer2.Checked;      //Текущие значения полей записываются в    
                radioButtonsState[current_nr, 2] = radioButton_answer3.Checked;      //"костыльный" массив
                ArrayWithMixedAnswer[current_nr, 0] = radioButton_answer1.Text;
                ArrayWithMixedAnswer[current_nr, 1] = radioButton_answer2.Text;
                ArrayWithMixedAnswer[current_nr, 2] = radioButton_answer3.Text;
                current_nr++;                                                       //Значения счетчика увеличивается
                ShowQuiz(current_nr);                                               //Отображение вопросов следующего
            }                                                                       //положения счетчика
            else Result();                                                          //Иначе вызвать результат     
        }
    }
}
