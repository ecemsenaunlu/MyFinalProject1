using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bir Kategori de en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExist="Bu isimde ürün zaten var";
        public static string CategoryLimitExceded="Kategori limiti aşıldı";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserRegistered;
        public static string UserNotFound="kullanıcı bulunamadı";
        public static string PasswordError="parola hatası";
        public static string SuccessfulLogin="giriş başarılı";
        public static string UserAlreadyExists="kullanıcı zaten var";
        public static string AccessTokenCreated="Token oluşturuldu";
    }
}
