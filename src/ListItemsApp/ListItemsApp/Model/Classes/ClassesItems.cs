using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

class Items
{
    private string name, manufacturer;
    private int count, index;

    // Путь к файлу
    private static readonly string DataFilePath = "products.json";


    public string Name
    {
        get { return name; }
        set
        {
            name = Validator.AssertValueInRange(value, 0, 100, "Name");
        }
    }

    public string Manufacturer
    {
        get { return manufacturer; }
        set
        {
            manufacturer = Validator.AssertValueInRange(value, 0, 100, "Manufacturer");
        }
    }

    public int Count { get; set; }
    public int Index { get; set; }


    /// <summary>
    /// Создаёт экземпляр класса <see cref="Items"/>.
    /// </summary>
    /// <param name="name">Название товара.</param>
    /// <param name="manufacturer">Производитель товара.</param>
    /// <param name="count">Количество товара на складе. Целое число, больше 0.</param>
    public Items(string name, string manufacturer, int count, int index)
    {
        Name = name;
        Manufacturer = manufacturer;
        Count = count;
        Index = index;
    }

    public Items()
    {

    }


    // Сохранение списка товаров в файл
    public static void SaveToFile(string filePath, List<Items> items)
    {
        string json = JsonConvert.SerializeObject(items, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    // Загрузка списка товаров из файла
    public static List<Items> LoadFromFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<List<Items>>(json);
        }

        // Возврат пустого списка, если не загрузились данные из файла
        return new List<Items>();
    }

    // Получить путь к файлу данных
    public static string GetDataFilePath()
    {
        return DataFilePath;
    }
}