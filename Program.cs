using Classes;

Sleigh santa = new Sleigh("Slitta di Babbo Natale", 100.0, 1000.0);
Gift gift1 = new Gift("Trenino", "Nero", 10.0, 100.0);
Gift gift2 = new Gift("Trenino", "Nero", 100.0, 100.0);

santa.AddGift(gift1);
santa.AddGift(gift2);
santa.ShowContent();

