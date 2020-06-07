using SecureEntrance.DesktopUI.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureEntrance.DesktopUI.EntityFramework
{
    public class MyInitializer : CreateDatabaseIfNotExists<SecureEntranceContext>
    {
        protected override void Seed(SecureEntranceContext context)
        {

            List<Country> countries = new List<Country>
            {
                new Country
                {
                    ID = 1,
                    CountryName = "Azerbaijan",
                    IsDeleted = false
                },
                new Country
                {
                    ID = 2,
                    CountryName = "Turkey",
                    IsDeleted = false
                },
                new Country
                {
                    ID = 3,
                    CountryName = "Russia",
                    IsDeleted = false
                },
                new Country
                {
                    ID = 4,
                    CountryName = "England",
                    IsDeleted = false
                },
                new Country
                {
                    ID = 5,
                    CountryName = "Ukraine",
                    IsDeleted = false
                },
                new Country
                {
                    ID = 6,
                    CountryName = "Japan",
                    IsDeleted = false
                },new Country
                {
                    ID = 7,
                    CountryName = "Germany",
                    IsDeleted = false
                },
                new Country
                {
                    ID = 8,
                    CountryName = "Italy",
                    IsDeleted = false
                },
                new Country
                {
                    ID = 9,
                    CountryName = "Spain",
                    IsDeleted = false
                },
                new Country
                {
                    ID = 10,
                    CountryName = "France",
                    IsDeleted = false
                },new Country
                {
                    ID = 11,
                    CountryName = "Greece",
                    IsDeleted = false
                },new Country
                {
                    ID = 12,
                    CountryName = "Portugal",
                    IsDeleted = false
                },
                new Country
                {
                    ID = 13,
                    CountryName = "Czech Republic",
                    IsDeleted = false
                },
                new Country
                {
                    ID = 14,
                    CountryName = "Norway",
                    IsDeleted = false
                },
                new Country
                {
                    ID = 15,
                    CountryName = "Georgia",
                    IsDeleted = false
                },
                new Country
                {
                    ID = 16,
                    CountryName = "Iran",
                    IsDeleted = false
                },
                new Country
                {
                    ID = 17,
                    CountryName = "Serbia",
                    IsDeleted = false
                },
                new Country
                {
                    ID = 18,
                    CountryName = "Brasil",
                    IsDeleted = false
                },
                new Country
                {
                    ID = 19,
                    CountryName = "Argentina",
                    IsDeleted = false
                },
                new Country
                {
                    ID = 20,
                    CountryName = "Belgium",
                    IsDeleted = false
                },
            };
            List<string> passwords = new List<string>
            {
                "12345678",
                "abc123abc",
                "ilkin123",
                "20202020"
            };
            List<string> passwordHelpers = new List<string>
            {
                "12",
                "ab",
                "il",
                "20"
            };

            foreach (Country country in countries)
            {
                context.Countries.Add(country);
            }
            context.SaveChanges();


            for (int i = 0; i < 150; i++)
            {
                Passenger passenger = new Passenger
                {
                    Gender = i % 2 == 1 ? true : false,
                    Age = Convert.ToByte(FakeData.NumberData.GetNumber(19, 55)),
                    IdentitySerie = $"{FakeData.NumberData.GetNumber(100, 999)}{FakeData.TextData.GetAlphabetical(2).ToUpper()}{FakeData.NumberData.GetNumber(10, 99)}{FakeData.TextData.GetAlphabetical(1).ToUpper()}",
                    IsDeleted = false,
                    Name = i % 2 == 1 ? FakeData.NameData.GetMaleFirstName() : FakeData.NameData.GetFemaleFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    NowCountryID = FakeData.NumberData.GetNumber(1, 20),
                    Image = i % 2 == 1 ? $"Images/boy_identityImage_{FakeData.NumberData.GetNumber(1, 10)}.jpg" : $"Images/girl_identityImage_{FakeData.NumberData.GetNumber(1, 10)}.jpg"
                };
                passenger.Nationality = countries[FakeData.NumberData.GetNumber(1, 20) - 1];
                context.Passengers.Add(passenger);
            }
            context.SaveChanges();

            for (int i = 0; i < 20; i++)
            {
                int indexPsw = FakeData.NumberData.GetNumber(1, 4);
                Worker worker = new Worker
                {
                    EnteredWork = DateTime.Now.AddDays(-FakeData.NumberData.GetNumber(50, 365)),
                    IdentitySerie = $"{FakeData.NumberData.GetNumber(100, 999)}{FakeData.TextData.GetAlphabetical(2).ToUpper()}{FakeData.NumberData.GetNumber(10, 99)}{FakeData.TextData.GetAlphabetical(1).ToUpper()}",
                    IsDeleted = false,
                    ModifiedWork = DateTime.Now.AddDays(-FakeData.NumberData.GetNumber(10, 45)),
                    Name = i % 2 == 1 ? FakeData.NameData.GetMaleFirstName() : FakeData.NameData.GetFemaleFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber(),
                    Password = CryptoHelper.Crypto.HashPassword(passwords[indexPsw - 1]),
                    pswHelper = passwordHelpers[indexPsw - 1]
                };
                context.Workers.Add(worker);
            }
            context.SaveChanges();
        }
    }
}
