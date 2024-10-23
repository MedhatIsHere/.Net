public class Complex
{

    int real;
    int img;


    public void SetReal(int _real) { real = _real; }
    public void SetImg(int _img) { img = _img; }
    public int GetReal() { return real; }
    public int GetImg() { return img; }


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