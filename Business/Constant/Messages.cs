using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constant
{
    public static class Messages  //newlememek için static yaparız.
    {
        public static string CarAdded = "Araba Eklendi.";
        public static string CarNameInvalıd = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Bakımdadır.";
        public static string CarListed = "Arabalar Listelendi.";
        public static string CarDeleted = "Araç Silindi.";
        public static string CarUpdated = "Araç güncellendi.";

        public static string BrandListed = "Brand Listelendi.";
        public static string BrandAdded = "Brand Eklendi.";
        public static string BrandDeleted = "Brand Silindi.";
        public static string BrandUpdated = "Brand güncellendi.";
        public static string BrandNameInvalıd = "Brand ismi geçersiz";

        public static string ColorListed = "Color Listelendi.";
        public static string ColorAdded = "Color Eklendi.";
        public static string ColorDeleted = "Color Silindi.";
        public static string ColorUpdated = "Color güncellendi.";
        public static string ColorNameInvalıd = "Color ismi geçersiz";

        public static string UserListed = "User Listelendi.";
        public static string UserAdded = "User Eklendi.";
        public static string UserDeleted = "User Silindi.";
        public static string UserUpdated = "User güncellendi.";
        public static string UserNameInvalıd = "User ismi geçersiz";

        public static string CustomerListed = "Customer Listelendi.";
        public static string CustomerAdded = "Customer Eklendi.";
        public static string CustomerDeleted = "Customer Silindi.";
        public static string CustomerUpdated = "Customer güncellendi.";
        public static string CustomerNameInvalıd = "Customer ismi geçersiz";

        public static string RentalListed = "Rental Listelendi.";
        public static string RentalAdded = "Rental Eklendi.";
        public static string RentalDeleted = "Rental Silindi.";
        public static string RentalUpdated = "Rental güncellendi.";
        public static string RentalNameInvalıd = "Rentalismi geçersiz";

        public static string CarImageLimitExceeded = "CarImageLimitExceeded";
        public static string AuthorizationDenied = "AuthorizationDenied";
    }
}
