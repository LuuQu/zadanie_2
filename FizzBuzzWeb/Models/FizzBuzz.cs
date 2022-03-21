using System.ComponentModel.DataAnnotations;


namespace FizzBuzzWeb.Models
{
    public class FizzBuzz
    {
        [Display(Name = "Twój szczęśliwy numerek")]
        [Required, Range(1, 1000, ErrorMessage = "Oczekiwana wartość {0} z zakredu {1} i {2}.")]

        public int? Number { get; set; }
        public (string, string) Komunikat()
        {
            string wiadomosc;
            string typ;
            if (Number < 1 || Number > 1000) { return (" ", " "); }
            if (Number % 15 == 0)
            {
                wiadomosc = "FizzBuzz";
                typ = "success";
                return (wiadomosc, typ);
            }
            else if (Number % 3 == 0)
            {
                wiadomosc = "Fizz";
                typ = "success";
                return (wiadomosc, typ);
            }
            else if (Number % 5 == 0)
            {
                wiadomosc = "Buzz";
                typ = "success";
                return (wiadomosc, typ);
            }
            else
            {
                wiadomosc = ("Liczba: " + Number + " nie spełnia kryteriów FizzBuzz");
                typ = "danger";
                return (wiadomosc, typ);
            }

        }
    }

}
