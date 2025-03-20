using System;
using System.Linq;
using Models;

namespace Data
{
    public static class DbInitializer
    {
        public static void Initialize(RecipeDbContext context)
        {
            if (context.Recipes.Any())
            {
                return; // Veritabanı zaten dolu
            }

            var recipes = new Recipe[]
            {
                new Recipe
                {
                    Title = "3 Malzemeli Dondurma",
                    Description = "Ev yapımı, katkısız ve lezzetli dondurma",
                    PrepTime = 15,
                    CreatedDate = DateTime.Now,
                    ImageUrl = "/images/recipes/dondurma.jpg",
                    Ingredients = @"2 su bardağı soğuk krema
1 kutu tatlandırılmış süt (397 gr)
1 paket vanilya",
                    Instructions = @"1. Kremayı derin bir kasede mikserle çırpın.
2. Krema kıvam almaya başlayınca tatlandırılmış sütü ekleyin.
3. Vanilyayı ekleyip karışım koyulaşana kadar çırpmaya devam edin.
4. Karışımı kapaklı bir kaba aktarın.
5. Dondurucuda en az 6 saat bekletin.
6. Servis yapmadan 10 dakika önce çıkarıp yumuşamasını bekleyin."
                },
                new Recipe
                {
                    Title = "Közlenmiş Patlıcan Ezmesi",
                    Description = "Mangal tadında nefis bir meze",
                    PrepTime = 30,
                    CreatedDate = DateTime.Now,
                    ImageUrl = "/images/recipes/patlican-ezmesi.jpg",
                    Ingredients = @"3 adet büyük patlıcan
3 diş sarımsak
2 yemek kaşığı zeytinyağı
Tuz
Karabiber
1/2 limon suyu",
                    Instructions = @"1. Patlıcanları ocakta veya fırında közleyin.
2. Közlenen patlıcanların kabuklarını soyup bir kaseye alın.
3. Sarımsakları ezin.
4. Patlıcanları çatalla ezin ve sarımsakları ekleyin.
5. Zeytinyağı, tuz, karabiber ve limon suyunu ekleyip karıştırın.
6. Üzerine zeytinyağı gezdirip servis yapın."
                },
                new Recipe
                {
                    Title = "Havuçlu Tarator",
                    Description = "Farklı ve lezzetli bir meze alternatifi",
                    PrepTime = 20,
                    CreatedDate = DateTime.Now,
                    ImageUrl = "/images/recipes/havuclu-tarator.jpg",
                    Ingredients = @"3 adet orta boy havuç
3 diş sarımsak
1/2 su bardağı yoğurt
2 yemek kaşığı mayonez
Tuz
Dereotu",
                    Instructions = @"1. Havuçları rendeleyin.
2. Rendelenen havuçları az suda haşlayın.
3. Havuçları süzüp soğumaya bırakın.
4. Sarımsakları ezin.
5. Yoğurt ve mayonezi çırpın.
6. Soğuyan havuçları ve sarımsakları ekleyip karıştırın.
7. Tuz ekleyip karıştırın.
8. Üzerini dereotu ile süsleyip servis yapın."
                },
                new Recipe
                {
                    Title = "Kırmızı Biber Mezesi",
                    Description = "Kahvaltıların vazgeçilmezi",
                    PrepTime = 25,
                    CreatedDate = DateTime.Now,
                    ImageUrl = "/images/recipes/biber-mezesi.jpg",
                    Ingredients = @"4 adet kırmızı kapya biber
3 diş sarımsak
3 yemek kaşığı zeytinyağı
Tuz
Pul biber",
                    Instructions = @"1. Biberleri közleyin ve kabuklarını soyun.
2. Közlenmiş biberleri küçük küçük doğrayın.
3. Sarımsakları ince ince doğrayın.
4. Zeytinyağını tavada ısıtın.
5. Sarımsakları hafifçe kavurun.
6. Biberleri ekleyip 5 dakika pişirin.
7. Tuz ve pul biber ekleyip karıştırın.
8. Soğuduktan sonra servis yapın."
                },
                new Recipe
                {
                    Title = "Yoğurtlu Semizotu",
                    Description = "Hafif ve sağlıklı bir meze",
                    PrepTime = 15,
                    CreatedDate = DateTime.Now,
                    ImageUrl = "/images/recipes/yogurtlu-semizotu.jpg",
                    Ingredients = @"1 demet semizotu
2 su bardağı yoğurt
2 diş sarımsak
Tuz",
                    Instructions = @"1. Semizotlarını ayıklayıp yıkayın.
2. Semizotlarını ince ince doğrayın.
3. Sarımsakları ezin.
4. Yoğurdu çırpın.
5. Doğranmış semizotlarını ve sarımsakları yoğurda ekleyin.
6. Tuz ekleyip karıştırın.
7. Buzdolabında 30 dakika dinlendirip servis yapın."
                }
            };

            context.Recipes.AddRange(recipes);
            context.SaveChanges();
        }
    }
} 