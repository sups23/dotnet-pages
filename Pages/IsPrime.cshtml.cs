using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesIsPrime.Pages
{
    public class IsPrimeModel : PageModel
    {
        public string TotalMessage = "";
        public int Num;
        public bool isPrime(int n)
        {
            bool isPrime = true;

            for (int i = 2; i < Convert.ToInt32(n / 2); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
        public void OnPost(int num)
        {
            Num = num;
            if (isPrime(Num))
            {
                TotalMessage = Num + " is prime.";
            } else {
                TotalMessage = Num + " is composite.";
            }
        }
    }
}
