using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    // static yaparız ki newlemeyelim!!
    public static class Messages
    {
        public static string ProductAdded = "✔️ Ürün eklendi.";
        public static string ProductNameInvalid = "❌ Ürün ismi geçersiz.";
        public static string MaintenanceTime = "😓 Sistem bakımda";
        public static string ProductsListed = "✔️ Ürünler listelendi.";

        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün bulunabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde zaten bir ürün mevcut.";
        public static string CategoryLimitExceded = "Kategori limiti maksimum boyuta ulaştığı için yeni ürün eklenemiyor.";
    }
}
