// See https://aka.ms/new-console-template for more information


Customer customer1 = new Customer {Id = 1, FirstName ="Büşra",LastName = "inci", City = "istanbul"};
Customer customer2 = new Customer(2, "Yaser", "Ulutürk", "Samsun"); //normal parantez ile bu şekilde yazılırsa bu bilgiler bir metotta yerine alacak kavramlar olur.
Method(3, "Buğlem", "İnci", "İstanbul");


static void Method(int Id,string Firstname,string Lastname,string City) // burada biz nelerin girilmesi gerektiğiini yazdığımız için main bölümüne method yazıp parantez içine sadece bilgileri girebiliriz.
{
   
}
class Customer
{

    public Customer()
    {
        //bunu yapmamızın sebeb ise Customer2 için alttaki publici oluşturduğumuz da customer  kızarmıştı,iki türlüsünü de kullanabilmek için bunu da yazdık ve bu da tanımlandığı için her türlü çalışır durumda oldu.
    }

    //defoult constructor deniliyor bu public Customer yapısına public void falan yazmıyoruz sadece böyle yazarsak defoult constructor olur.
    //kolay bir kullanım olsun diye kullanılır.
    public Customer(int Id, string Firstname, string Lastname, string City)
    {
        // parantez içinde bilgiler verdiğimiz için customer 2 rahatadı.
        Id = Id;
        Firstname = FirstName;
        Lastname = LastName;
        City = City;

    }
   

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}

