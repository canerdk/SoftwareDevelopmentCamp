using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductCannotAdded = "Ürün eklenemedi";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün var";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler listelendi";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string ProductDetailsListed = "Ürün detayı listelendi";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı oluşturuldu";
        public static string UserNotFound = "Kullanıcı bulanamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Üye zaten var";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
