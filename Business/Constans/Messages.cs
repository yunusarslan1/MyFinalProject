using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategorıde en fazla 10 ürün olmalıdır";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka ürün var";
        public static string CategoryLimitExceded="Kategory limiti aşıldığı için yeni ürün eklenemiyor...";
        public static string AuthorizationDenied="Yetkiniz yok.";

        // AuthManager
        public static string UserRegistered = "Kayıt Olundu...";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Parola hatası";
        public static string SuccessfulLogin="Login başarılı";
        public static string UserAlreadyExists="Kullanıcı başarılı";
        public static string AccessTokenCreated="Token oluşturuldu";
    }
}
