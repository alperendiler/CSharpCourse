
using Events;

Product harddisk = new Product(50);

harddisk.ProductName = "Hard disk";


Product gsm = new Product(50);
gsm.ProductName = "GSM";
gsm.StockControlEvent += Gsm_StockControlEvent;

void Gsm_StockControlEvent()
{
    Console.WriteLine("Dur");
    gsm.Sell(-10);
}

for (int i = 0; i < 10; i++)
{
    harddisk.Sell(10);
    gsm.Sell(10);
    Console.ReadLine();
}











