using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortingAlgorithms
{
    public partial class sortingForm : Form
    {
        List<int> numbers = new List<int>();
        public sortingForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearLists();
        }
        public void clearLists()
        {
            randBox.Items.Clear();
            outputBox.Items.Clear();
            numbers.Clear();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            clearLists();

            Random blop = new Random();

            for (int i = 1; i <= 20; i++)
            {
                int num = blop.Next(1, 101);
                numbers.Add(num);
                randBox.Items.Add(num);
            }
        }

        private void quickSortButton_Click(object sender, EventArgs e)
        {
            outputBox.Items.Clear();
            quickSort(numbers, 0, numbers.Count-1);
            foreach(int item in numbers)
            {
                outputBox.Items.Add(item);
            }

        }

        public void quickSort(List<int> input, int low, int high)
        {
            int pivot_loc = 0;

            if (low < high)
            {
                pivot_loc = quickPart(input, low, high);
                quickSort(input, low, pivot_loc - 1);
                quickSort(input, pivot_loc + 1, high);
            }
        }

        public int quickPart(List<int> input, int low, int high)
        {
            int pivot = input[high];
            int i = low - 1;

            for (int j = low; j < high - 1; j++)
            {
                if (input[j] <= pivot)
                {
                    i++;
                    swap(input, i, j);
                }
            }
            swap(input, i + 1, high);
            return i + 1;
        }

        public void swap(List<int> array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
