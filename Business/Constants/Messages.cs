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
        public static string CarAdded = "Ürün eklendi";
        public static string CarNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string CarListed;


        public static string BrandAdded = "Marka eklendi.";
        public static string BrandDeleted = "MarkaÜrün eklendi.";
        public static string BrandUpdated = "Marka eklendi.";
        public static string BrandListed = "Marka eklendi.";


        public static string ColorAdded = "Renk eklendi.";
        public static string ColorDeleted = "Renk eklendi.";
        public static string ColorUpdated = "Renk eklendi.";
        public static string ColorListed = "Renk eklendi.";

        public static string RentalInvalid = "Kiraya verme işlemi geçersiz";
        public static string RentalAdded = "Kiraya verme işlemi eklendi.";
        public static string RentalDeleted = "Kiraya verme işlemi  eklendi.";
        public static string RentalUpdated = "Kiraya verme işlemi  güncellendi.";
        public static string RentalListed = "Kiraya verme işlemi listelendi.";

        public static string CustomerInvalid = "Müşteri geçersiz";
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri eklendi.";
        public static string CustomerUpdated = "Müşteri  güncellendi.";
        public static string CustomerListed = "Müşteri listelendi.";

        public static string UserInvalid = "Kullanıcı geçersiz";
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı eklendi.";
        public static string UserUpdated = "Kullanıcı  güncellendi.";
        public static string UserListed = "Kullanıcı listelendi.";

        public static string CarDeleted { get; internal set; }
        public static string CarUpdated { get; internal set; }
        public static string ProductCountOfCarError { get; internal set; }
        public static string DescriptionsAlreadyExits { get; internal set; }
        public static string CarImageLimitExceeded { get; internal set; }

        public static string UserNotFound = "User not found";
        public static string PasswordError = "PasswordError";
        public static string UserAlreadyExists = "UserAlreadyExists";
        public static string UserRegistered = "SuccessUserRegistered";
        public static string AccessTokenCreated = "Access token created";
        public static string AuthorizationDenied = "AuthorizationDenied";
        public static string CardExist = "There is the credit card";
    }
}

