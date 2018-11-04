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

        private void generateButton_Click(object sender, EventArgs e)
        {
            clearLists();

            Random blop = new Random();

            for (int i = 0; i < 100; i++)
            {
                numbers.Add(blop.Next(1, 101));
            }
            foreach(int j in numbers)
            {
                randBox.Items.Add(numbers[j-1]);
            }

            Console.Write("Items in numbers list: " + numbers.Count()); //making sure my number generator works
        }

        public void clearLists()
        {
            randBox.Items.Clear();
            outputBox.Items.Clear();
            numbers.Clear();
        }

        public void quickSort(List<int> nums, int lo, int hi) // Lomuto partition scheme
        {
            int low = lo;
            int high = hi;
            List<int> quickNums = new List<int>();
            foreach(int k in nums)
            {
                quickNums.Add(k);
            }
            if(low < high)
            {
                // p := partition(Array, low, high)
                // quickSort(Array, low, p - 1)
                // quickSort(Array, p + 1, high)
            }
        }
    }
}
