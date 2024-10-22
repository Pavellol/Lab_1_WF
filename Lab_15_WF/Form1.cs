using Microsoft.VisualBasic.Logging;

namespace Lab_15_WF
{
    public partial class Form1 : Form
    {
        Sort sort;
        Show show;

        public Form1()
        {
            InitializeComponent();

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int[] array = new int[100];
            Random rand = new Random();

            label5.Text = "Сгенерированный массив: ";
            label6.Text = "Отсортированный массив: ";

            for (int i = 0; i < array.Length; i++)
            {
                int randomValue = rand.Next(0, 100);
                array[i] = randomValue;
                label5.Text += randomValue.ToString() + ",";
            }

            ref int[] arrayRef = ref array;
            sort = new(ref arrayRef);
        }

        private void GanerateArrayButton_Click(object sender, EventArgs e)
        {
            textBox1_TextChanged(sender, e);

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
        }

        private void BubbleSortButton_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Отсортированный массив: ";
            label1.Text = "Количество итераций: ";
        }

        private void SelectionSortButton_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Отсортированный массив: ";
            label1.Text = "Количество итераций: ";
        }

        private void QuickSort_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Отсортированный массив: ";
            label1.Text = "Количество итераций: ";
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                sort.BubbleSort();
            else if (radioButton2.Checked == true)
                sort.SelectionSort();
            else if (radioButton3.Checked == true)
                sort.QuickSort(0, 99);
                
            show = new(sort.Array);
            show.ShowArray(label6);

            label1.Text = "Количество итераций: " + sort.IterationCount.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                sort.BubbleSort();
        }      
    }

    public class Sort
    {
        private int[] array;
        private int iterationCount = 0;

        public int[] Array { get { return array; } }
        public int IterationCount { get { return iterationCount; } }

        public Sort(ref int[] array)
        {
            this.array = array;
        }

        public void BubbleSort()
        {
            iterationCount = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    iterationCount++;  // Считаем количество сравнений
                    if (array[j] > array[j + 1])
                    {
                        int t = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = t;
                    }
                }
            }
        }

        public void QuickSort(int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);
                QuickSort(low, pivotIndex - 1);
                QuickSort(pivotIndex + 1, high);
            }
        }

        public int Partition(int[] array, int low, int high)
        {
            
            int pivot = array[(low + high) / 2];
            int i = low - 1;
            int j = high + 1;
            while (true)
            {
                do
                {
                    iterationCount++;
                    i++;
                } while (array[i] < pivot);

                do
                {
                    iterationCount++;
                    j--;
                } while (array[j] > pivot);

                if (i >= j)
                    return j;

                Swap(array, i, j);
                iterationCount += 3;
            }
        }

        public void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public void SelectionSort()
        {
            iterationCount = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    iterationCount++;
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    int t = array[i];
                    array[i] = array[min];
                    array[min] = t;
                }
            }
        }
    }

    public class Show
    {
        private int[] array;

        public int[] Array { get { return array; } }

        public Show(int[] array)
        {
            this.array = array;
        }

        public void ShowArray(Label label)
        {
            for (int i = 0; i < array.Length; i++)
            {
                label.Text += array[i].ToString() + ",";
            }
        }
    }
}
