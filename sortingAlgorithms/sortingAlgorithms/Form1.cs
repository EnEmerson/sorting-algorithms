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

            //making sure my number generator works
            Console.WriteLine("Items in numbers list: " + numbers.Count()); 
        }

        public void clearLists()
        {
            randBox.Items.Clear();
            outputBox.Items.Clear();
            numbers.Clear();
        }

        
        public void quickSort(List<int> nums, int lo, int hi) 
        {
            int low = lo;
            int high = hi;
            int p;
            List<int> quickNums = new List<int>();
            foreach(int k in nums)
            {
                quickNums.Add(k);
            }
            if(low < high)
            {
                p = partition(quickNums, low, high);
                quickSort(quickNums, low, p - 1);
                quickSort(quickNums, p + 1, high);
            }
        }

        // Lomuto partition scheme
        public int partition(List<int> nums, int lo, int hi)
        {
            int low = lo;
            int high = hi;
            int pivot = 0;
            List<int> partNums = new List<int>();
            List<int> swaps = new List<int>();

            //puts everything from the given array into the partition array
            foreach (int num in nums)
            {
                partNums.Add(nums[num]);
            }

            //duplicates array for easy swapping later on
            foreach(int item in partNums)
            {
                swaps.Add(partNums[item]);
            }

            pivot = partNums[high];

            int i = low - 1;
            for(int j = low; j <= high-1; j++)
            {
                if(partNums[j] < pivot)
                {
                    if(i != j)
                    {
                        i++;
                        partNums[i] = swaps[j];
                        partNums[j] = swaps[i];

                    }
                }
            }
            i++;
            partNums[i] = swaps[high];
            partNums[high] = swaps[i];

            
            return i;
        }
        private void quickSortButton_Click(object sender, EventArgs e)
        {
            outputBox.Items.Clear();
            quickSort(numbers, 0, numbers.Count-1);

        }
    }
}
