namespace Week2SecondSession
{
    public class Complex
    {
        private int real;
        private int img;

        
        public Complex()
        {
            real = 0;
            img = 0;
        }

        
        public Complex(int real, int img)
        {
            this.real = real;
            this.img = img;
        }

        
        public Complex(int real)
        {
            this.real = real;
            this.img = 0;
        }

        public string Print()
        {
            if (real == 0 && img == 0)
            {
                return "0";
            }
            else if (real == 0)
            {
                if (img == 1)
                    return "i";
                else if (img == -1)
                    return "-i";
                else
                    return $"{img}i";
            }
            else if (img == 0)
            {
                return $"{real}";
            }
            else
            {
                string imgPart;
                if (img == 1)
                {
                    imgPart = "i";
                }
                else if (img == -1)
                {
                    imgPart = "-i";
                }
                else
                {
                    imgPart = $"{Math.Abs(img)}i";
                }
                string sign;
                if (img > 0)
                {
                    sign = "+";
                }
                else
                {
                    sign = "-";
                }
                return $"{real} {sign} {imgPart}";
            }
        }

        public Complex Add(Complex right)
        {
            Complex result = new Complex();
            result.real = real + right.real;
            result.img = img + right.img;
            return result;
        }
    }
}
