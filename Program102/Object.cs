using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program102
{
    public partial class Object : Form
    {
        public Object() => InitializeComponent();

        public static PictureBox PIC { private get; set; }
        public static Int32 ID { private get; set; }

        private void Object_Load(object sender, EventArgs e)
        {
            ObjectPicture.Image = PIC.Image; PIC.Image = null;

            switch (ID)
            {
                //Солнце
                case 1:
                    {
                        //Картинка
                        ObjectPicture.Size = new Size(Convert.ToInt32(PIC.Width * 1.5), Convert.ToInt32(PIC.Height * 1.5));
                        ObjectPicture.Left -= 135; ObjectPicture.Top -= 40;

                        //Текст
                        Object_Name.Text = "Солнце"; Object_Name.Left += 20;
                        Mass.Text = "Масса: 2 * 10³⁰ кг";
                        Radius.Text = "Радиус: 696 тыс. км";
                        SurfaceTemperature.Text = "Температура поверхности: 5 780 К";
                        DistanceFromEarth.Text = "Расстояние от Земли: 150 млн. км";
                        DistanceFromSun.Text = "";
                        RotationPeriod.Text = "Период вращения: 25 земных дней";
                        RotationPeriodAroundSun.Text = "";
                        Description.Text = "Описание:";
                        DescriptionText.Text = "С Земли кажется, что светило имеет желтый цвет, однако это иллюзия, связанная с влиянием атмосферы нашей планеты на солнечный свет. На самом деле Солнце излучает почти белый свет.";
                    }
                    break;

                //Меркурий
                case 2:
                    {
                        //Картинка
                        ObjectPicture.Size = new Size(Convert.ToInt32(ObjectPicture.Width * 1.5), Convert.ToInt32(ObjectPicture.Height * 1.5));
                        ObjectPicture.Left -= 30; ObjectPicture.Top -= 30;

                        //Текст
                        Object_Name.Text = "Меркурий"; Object_Name.Left += 15;
                        Mass.Text = "Масса: 3.33 * 10²³ кг";
                        Radius.Text = "Радиус: 2440 км";
                        SurfaceTemperature.Text = "Температура поверхности: от 98 К до 700 К";
                        DistanceFromEarth.Text = "Расстояние от Земли: от 90 млн км до 210 млн км";
                        DistanceFromSun.Text = "Расстояние до Солнца: от 46 млн км до 70 млн км";
                        RotationPeriod.Text = "Период вращения: 176 земных дней";
                        RotationPeriodAroundSun.Text = "Период обращения вокруг солнца: 88 земных дней";
                        Description.Text = "Описание:";
                        DescriptionText.Text = "Поскольку для оборота вокруг Солнца Меркурию нужно пройти гораздо меньшее расстояние, чем Земле, год на нём значительно короче — всего 88 земных суток. За один меркурианский день успевает пройти более двух местных лет. Поскольку ось вращения планеты почти не наклонена, год на ней не делится на сезоны.";
                    }
                    break;

                //Венера
                case 3:
                    {
                        //Картинка
                        ObjectPicture.Size = new Size(Convert.ToInt32(PIC.Width * 2.75), Convert.ToInt32(PIC.Height * 2.75));
                        ObjectPicture.Left -= 70; ObjectPicture.Top -= 30;

                        //Текст
                        Object_Name.Text = "Венера"; Object_Name.Left += 15;
                        Mass.Text = "Масса: 4.89 * 10²⁴ кг";
                        Radius.Text = "Радиус: 6052 км";
                        SurfaceTemperature.Text = "Температура поверхности: 750 К";
                        DistanceFromEarth.Text = "Расстояние от Земли: от 38 млн км до 261 млн км";
                        DistanceFromSun.Text = "Расстояние до Солнца: от 107 477 тыс км до 108 9З9 тыс км";
                        RotationPeriod.Text = "Период вращения: 243 земных дней";
                        RotationPeriodAroundSun.Text = "Период обращения вокруг солнца: 224,7 земных дней";
                        Description.Text = "Описание:";
                        DescriptionText.Text = "Две планеты — сестры немного похожи между собой, но лишь внешними параметрами. Геофизическая обстановка двух планет различна. То, что недопустимо на Земле, на соседней планете в порядке вещей, это и есть противоположность многих геофизических условий.";
                    }
                    break;

                //Земля
                case 4:
                    {
                        //Картинка
                        ObjectPicture.Size = new Size(Convert.ToInt32(PIC.Width * 2.75), Convert.ToInt32(PIC.Height * 2.75));
                        ObjectPicture.Left -= 70; ObjectPicture.Top -= 70;

                        //Текст
                        Object_Name.Text = "Земля"; Object_Name.Left += 15;
                        Mass.Text = "Масса: 5.98 * 10²⁴ кг";
                        Radius.Text = "Радиус: 6370 км";
                        SurfaceTemperature.Text = "Температура поверхности: от 188 К до 343 К";
                        DistanceFromEarth.Text = "";
                        DistanceFromSun.Text = "Расстояние до Солнца: 149,6 млн км";
                        RotationPeriod.Text = "";
                        RotationPeriodAroundSun.Text = "Период обращения вокруг солнца: 365.25 земных дней";
                        Description.Text = "Описание:";
                        DescriptionText.Text = "Земля на самом деле не идеальной сферической формы. Из-за дисбаланса гравитационной и центробежной сил в районе экватора вокруг планеты есть небольшое вздутие, похожее на автомобильную запаску.";
                    }
                    break;

                //Марс
                case 5:
                    {
                        //Картинка
                        ObjectPicture.Size = new Size(Convert.ToInt32(PIC.Width * 2.75), Convert.ToInt32(PIC.Height * 2.75));
                        ObjectPicture.Left -= 70; ObjectPicture.Top -= 70;

                        //Текст
                        Object_Name.Text = "Марс"; Object_Name.Left += 15;
                        Mass.Text = "Масса: 6,42 * 10²³ кг";
                        Radius.Text = "Радиус: ЗЗ90 км";
                        SurfaceTemperature.Text = "Температура поверхности: от 130 К до 308 К";
                        DistanceFromEarth.Text = "Расстояние от Земли: от 55,76 млн км до 401 млн км";
                        DistanceFromSun.Text = "Расстояние до Солнца: от 206.7 млн км до 249.2 млн км";
                        RotationPeriod.Text = "Период вращения: 1.025 земных дней";
                        RotationPeriodAroundSun.Text = "Период обращения вокруг солнца: 687 земных дней";
                        Description.Text = "Описание:";
                        DescriptionText.Text = "Никто из людей или животных не выжил бы на Марсе без специального скафандра. Давление на Марсе настолько низкое, что кислород в крови мгновенно превратился бы в газовые пузырьки, что привело бы к моментальной гибели.";
                    }
                    break;

                //Юпитер
                case 6:
                    {
                        //Картинка
                        ObjectPicture.Size = new Size(Convert.ToInt32(PIC.Width * 2.2), Convert.ToInt32(PIC.Height * 2.2));
                        ObjectPicture.Left -= 70; ObjectPicture.Top -= 60;

                        //Текст
                        Object_Name.Text = "Юпитер"; Object_Name.Left += 15;
                        Mass.Text = "Масса: 1.9 * 10²⁷ кг";
                        Radius.Text = "Радиус: 69 911 км";
                        SurfaceTemperature.Text = "Температура поверхности: 166 К";
                        DistanceFromEarth.Text = "Расстояние от Земли: от 588 млн км до 967 млн км";
                        DistanceFromSun.Text = "Расстояние до Солнца: от 740.57 млн км до 816.52 млн км";
                        RotationPeriod.Text = "Период вращения: 9 ч 50 мин 30 с";
                        RotationPeriodAroundSun.Text = "Период обращения вокруг солнца: 4 331 земной день";
                        Description.Text = "Описание:";
                        DescriptionText.Text = "Aтмocфepa Юпитepa cocтoит из 10,2% гeлия, 89,8% мoлeкуляpнoгo вoдopoдa и нeбoльшoгo кoличecтвa aэpoзoлeй гидpocульфидa aммиaкa, aэpoзoлeй вoдянoгo льдa, вoды, этaнa, дeйтepитa вoдopoдa, aммиaкa и мeтaнa.";
                    }
                    break;

                //Сатурн
                case 7:
                    {
                        //Картинка
                        ObjectPicture.Size = new Size(Convert.ToInt32(PIC.Width * 1.7), Convert.ToInt32(PIC.Height * 1.7));
                        ObjectPicture.Left -= 90; ObjectPicture.Top -= 40;

                        //Текст
                        Object_Name.Text = "Сатурн"; Object_Name.Left += 15;
                        Mass.Text = "Масса: 5.68 * 10²⁶ кг";
                        Radius.Text = "Радиус: 58 2З2 км";
                        SurfaceTemperature.Text = "Температура поверхности: 82 К";
                        DistanceFromEarth.Text = "Расстояние от Земли: от 1 195 млн км до 1 660 млн км";
                        DistanceFromSun.Text = "Расстояние до Солнца: от 1 353 млн км до 1 513 млн км";
                        RotationPeriod.Text = "Период вращения: 10 ч 45 мин";
                        RotationPeriodAroundSun.Text = "Период обращения вокруг солнца: 10 759 земных дней";
                        Description.Text = "Описание:";
                        DescriptionText.Text = "Caтуpн пoкaзывaeт нeoбыкнoвeнныe зoлoтыe и жeлтыe пoлocы в cвoeй aтмocфepe. Эти пoлocы вызвaны coчeтaниeм тeплa, иcxoдящeгo из внутpeннeй чacти плaнeты, и cвepxбыcтpыx вeтpoв, дующиx в eгo вepxниx cлoяx aтмocфepы.";
                    }
                    break;

                //Уран
                case 8:
                    {
                        //Картинка
                        ObjectPicture.Size = new Size(Convert.ToInt32(PIC.Width * 3), Convert.ToInt32(PIC.Height * 3));
                        ObjectPicture.Left -= 115; ObjectPicture.Top -= 125;

                        //Текст
                        Object_Name.Text = "Уран"; Object_Name.Left += 20;
                        Mass.Text = "Масса: 8,68 * 10²⁵ кг";
                        Radius.Text = "Радиус: 24 97З км";
                        SurfaceTemperature.Text = "Температура поверхности: 49 К";
                        DistanceFromEarth.Text = "Расстояние от Земли: от 2.57 млpд км до З.15 млpд км";
                        DistanceFromSun.Text = "Расстояние до Солнца: от 2.74 млpд км до З млpд км";
                        RotationPeriod.Text = "Период вращения: 17 чacoв и 14 минут";
                        RotationPeriodAroundSun.Text = "Период обращения вокруг солнца: 84 земных года";
                        Description.Text = "Описание:";
                        DescriptionText.Text = "Уpaн чacтo нaзывaют лeдяным гигaнтoм. Пpocтoe oбъяcнeниe этoгo нaзвaния в тoм, чтo 80% мaccы Уpaнa cocтoит из жидкoй cмecи aммиaчнoгo льдa, мeтaнoвoгo льдa и вoдянoгo льдa.";
                    }
                    break;

                //Нептун
                case 9:
                    {
                        //Картинка
                        ObjectPicture.Size = new Size(Convert.ToInt32(PIC.Width * 2.75), Convert.ToInt32(PIC.Height * 2.75));
                        ObjectPicture.Left -= 100; ObjectPicture.Top -= 100;

                        //Текст
                        Object_Name.Text = "Нептун"; Object_Name.Left += 20;
                        Mass.Text = "Масса: 1.02 * 10²⁶ кг";
                        Radius.Text = "Радиус: 24 764 км";
                        SurfaceTemperature.Text = "Температура поверхности: от 55 К до 73 К";
                        DistanceFromEarth.Text = "Расстояние от Земли: от 4.З млpд км до 4.55 млpд км";
                        DistanceFromSun.Text = "Расстояние до Солнца: от 4.45 млpд км до 4.56 млpд км";
                        RotationPeriod.Text = "Период вращения: 15 ч 58 мин";
                        RotationPeriodAroundSun.Text = "Период обращения вокруг солнца: 164.8 земных года";
                        Description.Text = "Описание:";
                        DescriptionText.Text = "Планета излучает в 2.6 раза больше тепла, чем получает от Солнца. Его каменное ядро разогревается до 7000 градусов, несмотря на ледяные массы, окутывающие его со всех сторон.";
                    }
                    break;
            }
        }

        private void Object_FormClosed(object sender, FormClosedEventArgs e)
        {
            PIC.Image = ObjectPicture.Image; ObjectPicture.Image = null;
        }
    }
}