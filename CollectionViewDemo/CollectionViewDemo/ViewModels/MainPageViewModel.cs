using CollectionViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CollectionViewDemo.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<Product> Products { get; set; }
        public MainPageViewModel()
        {
            this.Products = new ObservableCollection<Product>()
            {
                new Product()
                {
                    Name = "Watermelon",
                    Price = 30.0m,
                    Image = "watermelon.png",
                    HassOffer = false
                },
                new Product()
                {
                    Name = "Yogurt",
                    Price = 60.0m,
                    Image = "yogurt.png",
                    HassOffer = false
                },
                new Product
                {
                    Name = "Botella de agua",
                    Price = 80.0m,
                    Image = "water_bottle.png.png",
                    HassOffer = true,
                    OfferPrice = 69.99m
                },
                new Product
                {
                    Name = "Tomate",
                    Price = 120.0m,
                    Image = "tomato.png.png",
                    HassOffer = false
                },
                new Product
                {
                    Name = "Tea",
                    Price = 65.1m,
                    Image = "tea.png.png",
                    HassOffer = false
                },
                                new Product()
                {
                    Name = "Watermelon",
                    Price = 30.0m,
                    Image = "watermelon.png",
                    HassOffer = false
                },
                new Product()
                {
                    Name = "Yogurt",
                    Price = 60.0m,
                    Image = "yogurt.png",
                    HassOffer = false
                },
                new Product
                {
                    Name = "Botella de agua",
                    Price = 80.0m,
                    Image = "water_bottle.png.png",
                    HassOffer = true,
                    OfferPrice = 69.99m
                },
                new Product
                {
                    Name = "Tomate",
                    Price = 120.0m,
                    Image = "tomato.png.png",
                    HassOffer = false
                },
                new Product
                {
                    Name = "Tea",
                    Price = 65.1m,
                    Image = "tea.png.png",
                    HassOffer = false
                }
            };
        }
    }
}
