using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    //--------------------------------------------------------------
    // Игра «Жизнь» (англ. Conway's Game of Life) — клеточный автомат, 
    // придуманный английским математиком Джоном Конвеем в 1970 году.
    //--------------------------------------------------------------
    //--------------------Правила игры------------------------------
    // Место действия игры -"вселенная", имеющая размеченная на клетки поверхность.
    // Каждая клетка может быть "живой" либо "мертвой"
    // Игра начинается с нулевого поколения.
    // Каждый шаг игры - это зарождение нового поколения.
    // Каждая клетка имеет вокруг себя 8 соседей.
    // Поколение появляется следующим образом:
    //      1. в "мертвой" клетке, рядом с которой ровно 3 живые клетки - зарождается жизнь
    //      2. если у живой клетки есть две или три живые соседки, то эта клетка продолжает жить; 
    //      3. в противном случае, если соседей меньше двух или больше трёх, клетка умирает 
    //      («от одиночества» или «от перенаселённости»)
    public partial class Form1 : Form
    {
        Graphics g; // для рисования клеточного поля
        static ushort lifeSize = 32; // кол-во клеток на поле
        static float pointSize; // размер одной клетки
        Generation gen = new Generation(lifeSize); // для реализации бизнес-логики
        SolidBrush blackBrush, greenBrush; // для закраски клеток
        Rectangle[,] Cells = new Rectangle[lifeSize, lifeSize]; // массив из прямоугольников для отрисовки поля
        Boolean isAlive = false; // для рисования только "живых" клеток
        Boolean isDead = false; // для рисования только "мертвых" клеток
        string filename; // название файла для хранения массива
        Color myColor, gray;
        Pen p;
        Boolean isGrid = true; // показ сетки

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
            pictureBox_GameField.Image = 
                new Bitmap(pictureBox_GameField.Width, pictureBox_GameField.Height);
            g = Graphics.FromImage(pictureBox_GameField.Image);
            pointSize = (pictureBox_GameField.Height / (lifeSize));
            blackBrush = new SolidBrush(Color.Black);
            greenBrush = new SolidBrush(Color.Green);
            toolTip1.SetToolTip(pictureBox_Fill, "Сгенировать поколение");
            toolTip1.SetToolTip(pictureBox_Step, "Перейти к следующему поколению");
            toolTip1.SetToolTip(pictureBox_Play, "Запустить генерацию поколений");
            toolTip1.SetToolTip(pictureBox_Clear, "Очистить поле");
            toolTip1.SetToolTip(pictureBox_Settings, "Настройки игры");
            toolTip1.SetToolTip(pictureBox_Grid, "Скрыть сетку");
            toolTip1.SetToolTip(pictureBox_NotGrid, "Показать сетку");
            openFileDialog1.Filter = "Life files(*.life)|*.life";
            saveFileDialog1.Filter = "Life files(*.life)|*.life";
            gray = Color.FromArgb(126, 145, 121);
            myColor = Color.FromArgb(45, gray);
            p = new Pen(myColor);
            PaintGrid();
        }

        // Задать новые данные и отрисовать по ним новое поле
        public void SetData(Generation gen1, ushort lifeSize1, ushort Speed)
        {
            gen = gen1;
            lifeSize = lifeSize1;
            timer1.Interval = Speed;
            Cells = new Rectangle[lifeSize, lifeSize];
            pointSize = ((float)pictureBox_GameField.Height / (float)(lifeSize));
            pictureBox_GameField_Paint(pictureBox_GameField, null);
            PaintField();
        }

        // Кнопка "Play" которая активирует таймер
        private void pictureBox_Play_Click(object sender, EventArgs e)
        {

            pictureBox_Play.Visible = false;
            pictureBox_Pause.Visible = true;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void InitializeTimer()
        {
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        /// <summary>
        /// Отрисовать клеточное поле
        /// </summary>
        private void PaintField()
        {
            g = Graphics.FromHwnd(pictureBox_GameField.Handle);
            g.FillRectangle(blackBrush, 0, 0,
                pictureBox_GameField.Width, pictureBox_GameField.Height);
            for (int i = 0; i < lifeSize; i++)
            {
                for (int j = 0; j < lifeSize; j++)
                {
                    if (gen.getLifeGeneration(i, j))
                    {
                        g.FillRectangle(greenBrush, Cells[i, j]);
                    }
                }
            }
            // при запущенном таймере убрать отрисовку сетки, чтоб избежать мигания
            if ((!timer1.Enabled) && (isGrid))
                PaintGrid();
        }

        // Отрисовка сетки
        private void PaintGrid()
        {
            
            for (int i = 0; i < lifeSize; i++)
            {
                // Vertical 
                g.DrawLine(p, i * pointSize, 0, i * pointSize, lifeSize * pointSize);
                // Horizontal 
                g.DrawLine(p, 0, i * pointSize, lifeSize * pointSize, i * pointSize);
            }
        }

        // Кнопка Clear очищает булевский массив и поле
        private void pictureBox_Clear_Click(object sender, EventArgs e)
        {
            gen.Clear();
            PaintField();
        }

        // Кнопка Step отвечает за генерацию одного поколения и отрисовки его на поле
        private void pictureBox_Step_Click(object sender, EventArgs e)
        {
            gen.NextGeneration();
            PaintField();
        }

        // Каждый заданный интервал времени вызывается событие генерирующее одно поколение
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox_Step_Click(pictureBox_Step, null);
        }

        private void pictureBox_Pause_Click(object sender, EventArgs e)
        {
            pictureBox_Play.Visible = true;
            pictureBox_Pause.Visible = false;
            timer1.Enabled = false;
            timer1.Stop();
            if (isGrid)
                PaintGrid();
        }

        /// <summary>
        /// Начальная отрисовка клеточного поля.
        /// Инициализация массива из прямоугольников.
        /// </summary>
        private void pictureBox_GameField_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < lifeSize; i++)
            {
                for (int j = 0; j < lifeSize; j++)
                {
                    Cells[i, j] = new Rectangle(
                        i * pictureBox_GameField.Width / (lifeSize)+1,
                        j * pictureBox_GameField.Height / (lifeSize)+1, (int)pointSize-1, (int)pointSize-1);
                    g.FillRectangle(blackBrush, Cells[i, j]);
                }
            }
        }

        // Событие, позволяющее закрашивать множество клеток проведением мыши
        private void pictureBox_GameField_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < lifeSize; i++)
                {
                    for (int j = 0; j < lifeSize; j++)
                    {
                        if ((e.Y >= (Cells[i, j].Location.Y)) &&
                        (e.Y <= (Cells[i, j].Location.Y + pointSize)) &&
                        (e.X >= Cells[i, j].Location.X) &&
                        (e.X <= (Cells[i, j].Location.X + pointSize)))
                        {
                            if (isDead)
                            {   
                                if (gen.getLifeGeneration(i, j))
                                {
                                    // будем закрашивать черным "живые" клетки
                                    gen.ChangeColorCell(i, j);
                                    g.FillRectangle(blackBrush, Cells[i, j]);
                                }
                            }
                            else
                            {
                                if (isAlive)
                                if (!gen.getLifeGeneration(i, j))
                                {
                                    // будем закрашивать зеленым "мертвые" клетки
                                    gen.ChangeColorCell(i, j);                           
                                    g.FillRectangle(greenBrush, Cells[i, j]);
                                }
                            }
                                
                        }
                    }
                }
            }
        }

        // Событие, позволяющее закарсить только одну клетку, по которой кликнули мышкой
        private void pictureBox_GameField_MouseDown(object sender, MouseEventArgs e)
        {
            g = Graphics.FromHwnd(pictureBox_GameField.Handle);
            var location = e.Location;
            int x = location.X;
            int y = location.Y;
            for (int i = 0; i < lifeSize; i++)
            {
                for (int j = 0; j < lifeSize; j++)
                {
                    if (Cells[i, j].Contains(x, y))
                    {
                        if (gen.getLifeGeneration(i, j))
                        {
                            gen.ChangeColorCell(i, j);
                            isDead = true; // значит в событии mouse_move будем закрашивать ТОЛЬКО "живые" клетки
                            isAlive = false;
                            g.FillRectangle(blackBrush, Cells[i, j]);
                        }
                        else
                        {
                            gen.ChangeColorCell(i, j);
                            isAlive = true; // значит в событии mouse_move будем закрашивать ТОЛЬКО "мертвые" клетки
                            isDead = false;
                            g.FillRectangle(greenBrush, Cells[i, j]);
                        }
                        break;
                    }
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filename = saveFileDialog1.FileName;
            gen.SaveToFile(filename);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filename = openFileDialog1.FileName;
            try
            {
                // сначала нужно восстановить массив
                gen.RestoreFromFile(filename);
                // затем задать новые данные и отрисовать
                SetData(gen, gen.LifeSize, (ushort)timer1.Interval);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Упс...", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox_GameField.Paint += new PaintEventHandler(pictureBox_GameField_Paint);
        }

        private void pictureBox_NotGrid_Click(object sender, EventArgs e)
        {
            isGrid = true;
            pictureBox_NotGrid.Visible = false;
            PaintField();
        }

        private void pictureBox_Grid_Click(object sender, EventArgs e)
        {
            isGrid = false;
            pictureBox_NotGrid.Visible = true;
            PaintField();
        }

        private void pictureBox_Settings_Click(object sender, EventArgs e)
        {
            Form f = new FormSettings((ushort)timer1.Interval, lifeSize);
            f.Owner = this;
            f.Left = this.Left + this.Left/10; // задаём открываемой форме позицию слева равную позиции текущей формы
            f.Top = this.Top + this.Top/2; // задаём открываемой форме позицию сверху равную позиции текущей формы
            f.ShowDialog(); // отображаем Form2
        }

        // Рандомная генерация клеток и их отрисовка
        private void pictureBox_Fill_Click(object sender, EventArgs e)
        {
            gen.RandomGeneration();
            PaintField();
        }
    }
}