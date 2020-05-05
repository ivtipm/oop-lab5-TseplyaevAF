using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace GameOfLife
{
    // Класс Поколение
    public class Generation
    {
        Boolean[,] lifeGeneration; // текущее поколение
        Boolean[,] nextGeneration; // следующее поколение
        ushort lifeSize; // кол-во жизненных клеток

        /// <summary>
        /// Конструктор принимает длину массива
        /// </summary>
        public Generation(ushort size)
        {
            lifeSize = size;
            lifeGeneration = new Boolean[lifeSize, lifeSize];
            nextGeneration = new Boolean[lifeSize, lifeSize];
        }

        // Доступ к полям класса
        public Boolean getNextGeneration(int i, int j)
        {
            return nextGeneration[i, j];
        }

        public Boolean getLifeGeneration(int i, int j)
        {
            return lifeGeneration[i, j];
        }

        public ushort LifeSize
        {
            get
            {
                return lifeSize;
            }
        }

        /// <summary>
        /// Сгенерировать первое (начальное) поколение
        /// </summary>
        public void RandomGeneration()
        {
            Random rnd = new Random();
            for (int i = 0; i < lifeSize; i++)
            {
                for (int j = 0; j < lifeSize; j++)
                {
                    lifeGeneration[i, j] = Convert.ToBoolean(rnd.Next(0, 2));
                    nextGeneration[i, j] = lifeGeneration[i, j];
                }
            }
        }

        private void CopyArray()
        {
            for (int i = 0; i < lifeSize; i++)
            {
                for (int j = 0; j < lifeSize; j++)
                {
                    lifeGeneration[i, j] = nextGeneration[i, j];
                }
            }
        }

        public void NextGeneration()
        {
            int count;
            for (int i = 0; i < lifeSize; i++)
            {
                for (int j = 0; j < lifeSize; j++)
                {
                    count = CountNeighbors(i, j);
                    nextGeneration[i, j] = lifeGeneration[i, j];
                    // если кол-во соседей у данной клетки 3 и клетка "живая"
                    nextGeneration[i, j] = (count == 3) && !nextGeneration[i, j] ? true : nextGeneration[i, j];
                    // если кол-во соседей у данной клетки 2 или 1 и клетка не "живая"
                    nextGeneration[i, j] = ((count < 2) || (count > 3)) &&
                        nextGeneration[i, j] ? false : nextGeneration[i, j];
                }
            }
            CopyArray();
        }

        /// <summary>
        /// Посчитать кол-во соседей у клетки заданной своими координатами
        /// </summary>
        public int CountNeighbors(int x, int y)
        {
            int count = 0;
            for (int dx = -1; dx < 2; dx++)
            {
                for (int dy = -1; dy < 2; dy++)
                {
                    int nX = x + dx;
                    int nY = y + dy;
                    nX = (nX < 0) ? lifeSize - 1 : nX;
                    nY = (nY < 0) ? lifeSize - 1 : nY;
                    nX = (nX > lifeSize - 1) ? 0 : nX;
                    nY = (nY > lifeSize - 1) ? 0 : nY;
                    count += (lifeGeneration[nX, nY]) ? 1 : 0;
                }
            }
            // если заданная клетка "живая", то отбавляем ее от общего кол-ва
            if (lifeGeneration[x, y]) count--;
            return count;
        }

        /// <summary>
        /// Изменение состояния у элемента массива
        /// </summary>
        public void ChangeColorCell(int x, int y)
        {
            lifeGeneration[x, y] = !lifeGeneration[x, y];
        }

        public void Clear()
        {
            for (int i = 0; i < lifeSize; i++)
            {
                for (int j = 0; j < lifeSize; j++)
                {
                    lifeGeneration[i, j] = false;
                    nextGeneration[i, j] = false;
                }
            }
        }

        /// <summary>
        /// Сохранить массив в файл
        /// </summary>
        public void SaveToFile(string filename)
        {
            File.WriteAllText(filename, JsonConvert.SerializeObject(lifeGeneration));
        }

        /// <summary>
        /// Восстановить массив из файла
        /// </summary>
        public void RestoreFromFile(string filename)
        {
            if (!System.IO.File.Exists(filename))
                throw new Exception("Файл не существует");
            try
            {
                lifeGeneration = JsonConvert.DeserializeObject<Boolean[,]>(File.ReadAllText(filename));
                nextGeneration = JsonConvert.DeserializeObject<Boolean[,]>(File.ReadAllText(filename));
            } catch
            {
                throw new Exception("Ошибка при открытии файла");
            }
            lifeSize = (ushort)lifeGeneration.GetLength(0);
        }
    }
}
