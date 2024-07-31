using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Constanst
{
    public static class Messages
    {
        public static string CarCountOfBrandError = "Bir markaya ait en fazla 10 araç olabilir";
        public static string CarNameAlreadyExists = "Aynı isme ait farklı bir araç var";
        public static string BrandLimitExceded = "Marka sınır aşıldı";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Araçlar listelendi";
        public static string CarAdded = "Araç Eklendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string CarUpdated = "Araç güncellendi";
        public static string CarDeleted = "Araç silindi";

    }
}
