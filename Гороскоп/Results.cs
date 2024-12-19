using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Гороскоп
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Вы уверенны, что хотите сохранить данные?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result1 == DialogResult.Yes)
            {
                //Сохранение 
                Directory.CreateDirectory(@"C:\Users\Timofey\Desktop\Афанасьев работы\Гороскоп\goroscope");

                FileStream fs0 = new FileStream(@"C:\Users\Timofey\Desktop\Афанасьев работы\Гороскоп\goroscope\goroscope results.txt", FileMode.OpenOrCreate, FileAccess.Write);
                fs0.Close();
                FileStream fs = new FileStream(@"C:\Users\Timofey\Desktop\Афанасьев работы\Гороскоп\goroscope\goroscope results.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(result);
                sw.Close();
                fs.Close();
                MessageBox.Show($"Данные гороскопа сохранены");
                buttonDel.Enabled = true;
            }
            else if (result1 == DialogResult.No)
            {
                //отмена сохранения
                MessageBox.Show("Сохранение отменено");

            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //Диалоговое окно для выбора удаления
            DialogResult result2 = MessageBox.Show("Вы уверенны, что хотите удалить данные?", "ВНИМАНИЕ!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result2 == DialogResult.Yes)
            {
                //если ДА
                File.Delete(@"C:\Users\Timofey\Desktop\Афанасьев работы\Гороскоп\goroscope\goroscope results.txt");
                MessageBox.Show("Удаление успешно");
                buttonDel.Enabled = false;
            }
            else if (result2 == DialogResult.No)
            {
                //если НЕТ
                MessageBox.Show("Удаление отменено");
            }
        }
        public string result;
        
        private void button1_Click(object sender, EventArgs e)
        {
            //получение выбранного даты и месяца из формы 1
            int month = Form1.month;
            int day = Form1.day;
            resultLbl.Text = month + " " + day;
            
            //Загрузка изображения, изменение текста сверху и совета в соответствии со знаком ЗЗ
            if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
            {
                this.picture.Image = Image.FromFile(@"C:\Users\Timofey\Desktop\Афанасьев работы\Гороскоп\pictures\козерог.jpg");
                topLbl.Text = ("Ваш знак зодиака: Козерог");
                resultLbl.Text = "Трудолюбие и настойчивость помогут вам достичь поставленных целей. \nВремя сосредоточиться на карьере и профессиональных задачах. \nВаши усилия обязательно будут вознаграждены.";
                //запись в переменную результата
                result = $"{topLbl.Text} \n {resultLbl.Text}";
            }
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
            {
                this.picture.Image = Image.FromFile(@"C:\Users\Timofey\Desktop\Афанасьев работы\Гороскоп\pictures\водолей.jpg");
                topLbl.Text = ("Ваш знак зодиака: Водолей");
                resultLbl.Text = "Инновации и нестандартные идеи будут вашим преимуществом. \nОкружающие оценят ваше оригинальное мышление. \nПоддерживайте дружеские связи и развивайте творческие проекты.";
                //запись в переменную результата
                result = $"{topLbl.Text} \n {resultLbl.Text}";
            }
            else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
            {
                this.picture.Image = Image.FromFile(@"C:\Users\Timofey\Desktop\Афанасьев работы\Гороскоп\pictures\рыбы.jpg");
                topLbl.Text = ("Ваш знак зодиака: Рыбы");
                resultLbl.Text = "Эмоциональная чувствительность может сыграть важную роль. \nУделите время духовному развитию и самопознанию. \nВаши мечты могут стать реальностью, если вы будете верить в них.";
                //запись в переменную результата
                result = $"{topLbl.Text}  \n  {resultLbl.Text}";
            }
            else if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
            {
                this.picture.Image = Image.FromFile(@"C:\Users\Timofey\Desktop\Афанасьев работы\Гороскоп\pictures\овен.jpg");
                topLbl.Text = ("Ваш знак зодиака: Овен");
                resultLbl.Text = "Вам предстоит период активной деятельности. \nИспользуйте свою энергию для достижения целей. \nНе бойтесь рисковать и проявлять инициативу.";
                //запись в переменную результата
                result = $"{topLbl.Text}  \n  {resultLbl.Text}";
            }
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
            {
                this.picture.Image = Image.FromFile(@"C:\Users\Timofey\Desktop\Афанасьев работы\Гороскоп\pictures\телец.jpg");
                topLbl.Text = ("Ваш знак зодиака: Телец");
                resultLbl.Text = "Финансовое благополучие ожидает вас. \nБудьте внимательны к своим ресурсам и не тратьте их впустую. \nЭмоциональная стабильность поможет вам справиться со всеми трудностями.";
                //запись в переменную результата
                result = $"{topLbl.Text}  \n  {resultLbl.Text}";
            }
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
            {
                this.picture.Image = Image.FromFile(@"C:\Users\Timofey\Desktop\Афанасьев работы\Гороскоп\pictures\близнецы.jpg");
                topLbl.Text = ("Ваш знак зодиака: Близнецы");
                resultLbl.Text = "Вас ждут интересные встречи и новые знакомства. \nОбщайтесь больше, делитесь идеями и будьте открыты для нового опыта. \nВаши коммуникативные навыки помогут вам достичь успеха.";
                //запись в переменную результата
                result = $"{topLbl.Text}  \n  {resultLbl.Text}";
            }
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
            {
                this.picture.Image = Image.FromFile(@"C:\Users\Timofey\Desktop\Афанасьев работы\Гороскоп\pictures\рак.jpg");
                topLbl.Text = ("Ваш знак зодиака: Рак");
                resultLbl.Text = "Время уделить внимание своему дому и семье. \nЗабота о близких принесет вам удовлетворение. \nНе забывайте заботиться и о себе, отдыхайте и восстанавливайте силы.";

                //запись в переменную результата
                result = $"{topLbl.Text}  \n  {resultLbl.Text}";
            }
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
            {
                this.picture.Image = Image.FromFile(@"C:\Users\Timofey\Desktop\Афанасьев работы\Гороскоп\pictures\лев.jpg");
                topLbl.Text = ("Ваш знак зодиака: Лев");
                resultLbl.Text = "Период творчества и самовыражения. \nВаше стремление к лидерству и желание быть в центре внимания принесут плоды. \nНе стесняйтесь демонстрировать свои таланты.";

                //запись в переменную результата
                result = $"{topLbl.Text}  \n  {resultLbl.Text}";
            }
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
            {
                this.picture.Image = Image.FromFile(@"C:\Users\Timofey\Desktop\Афанасьев работы\Гороскоп\pictures\дева.jpg");
                topLbl.Text = ("Ваш знак зодиака: Дева");
                resultLbl.Text = "Внимание к деталям и аналитический подход помогут вам решить сложные задачи. \nОрганизованность и дисциплина приведут к успеху в работе и личной жизни.";
                //запись в переменную результата
                result = $"{topLbl.Text}  \n  {resultLbl.Text}";
            }
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
            {
                this.picture.Image = Image.FromFile(@"C:\Users\Timofey\Desktop\Афанасьев работы\Гороскоп\pictures\весы.jpg");
                topLbl.Text = ("Ваш знак зодиака: Весы");
                resultLbl.Text = "Стабильность и гармония станут вашими спутниками. \nСтарайтесь находить баланс во всем, особенно в отношениях. \nВаша дипломатичность поможет избежать конфликтов.";
                //запись в переменную результата
                result = $"{topLbl.Text}   \n   {resultLbl.Text}";
            }
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
            {
                this.picture.Image = Image.FromFile(@"C:\Users\Timofey\Desktop\Афанасьев работы\Гороскоп\pictures\скорпион.jpg");
                topLbl.Text = ("Ваш знак зодиака: Скорпион");
                resultLbl.Text = "Время для глубоких размышлений и самоанализа. \nИспользуйте свою интуицию и эмоциональную силу для решения сложных вопросов. \nБудьте готовы к переменам.";
                //запись в переменную результата
                result = $"{topLbl.Text}   \n   {resultLbl.Text}";
            }
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
            {
                this.picture.Image = Image.FromFile(@"C:\Users\Timofey\Desktop\Афанасьев работы\Гороскоп\pictures\стрелец.jpg");
                topLbl.Text = ("Ваш знак зодиака: Стрелец");
                resultLbl.Text = "Путешествия и новые впечатления ждут вас. \nОткройте себя миру, расширяйте кругозор и не бойтесь выходить из зоны комфорта. \nВаши приключения принесут много радости.";
                //запись в переменную результата
                result = $"{topLbl.Text}   \n   {resultLbl.Text}";
            }
            //открытие кнопки сохранения
            buttonSave.Enabled = true;
        }

        private void buttonEXIT_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
