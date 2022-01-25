using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGenerator
{
    public class RandomGenerator
    {
        public int RandomInteger(int min, int max)
        {
            int fail = 0;
            int r = 0;

            if (min > max)
            {
                MessageBox.Show("Minimum can't be bigger than maximum!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fail += 1;
            }
            if (max < min)
            {
                MessageBox.Show("Maximum can't be smaller than minimum!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fail += 1;
            }
            if (min == max)
            {
                r = min;
                fail += 1;
            }

            if (fail == 0)
            {
                Random random = new Random();
                r = random.Next(min, max);
            }

            return r;
        }

        public float RandomFloat(float min, float max)
        {
            int fail = 0;
            double r = 0d;

            if (min > max)
            {
                MessageBox.Show("Minimum can't be bigger than maximum!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fail += 1;
            }
            if (max < min)
            {
                MessageBox.Show("Maximum can't be smaller than minimum!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fail += 1;
            }
            if (min == max)
            {

                fail += 1;
            }

            if (fail == 0)
            {
                Random random = new Random();
                r = (random.NextDouble() * (max - min) + min);
            }

            return (float)r;
        }

        public bool RandomBoolean()
        {
            Random random = new Random();
            int rint = random.Next(0, 5);
            bool rbool = false;
            if (rint < 3)
            {
                rbool = false;
            }
            else if (rint > 2)
            {
                rbool = true;
            }
            return rbool;
        }
    }
}