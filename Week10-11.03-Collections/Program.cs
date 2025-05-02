using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List<T> - Öğrenci isimleri listesi
        var students = new List<string> { "John", "Alice", "Bob" };
        students.Add("Jane");
        students.ForEach(student => Console.WriteLine($"Student: {student}"));

        // SortedList<TKey,TValue> - Ürün fiyatları (otomatik sıralı)
        var productPrices = new SortedList<string, decimal>
        {
            { "Laptop", 1200m },
            { "Smartphone", 800m }
        };
        productPrices.Add("Tablet", 450m);
        foreach (var item in productPrices)
            Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");

        // Stack<T> - Tarayıcı geçmişi
        var browserHistory = new Stack<string>();
        browserHistory.Push("HomePage");
        browserHistory.Push("ProfilePage");
        browserHistory.Push("SettingsPage");
        Console.WriteLine($"Back to: {browserHistory.Pop()}");

        // Queue<T> - Yazıcı sırası
        var printerQueue = new Queue<string>();
        printerQueue.Enqueue("Document1.pdf");
        printerQueue.Enqueue("Document2.docx");
        Console.WriteLine($"Printing: {printerQueue.Dequeue()}");

        // Dictionary<TKey,TValue> - Kullanıcı bilgileri
        var users = new Dictionary<int, string>
        {
            {101, "John Doe"},
            {102, "Jane Smith"}
        };
        Console.WriteLine($"User 101: {users[101]}");

        // HashSet<T> - Benzersiz ürün kodları
        var productCodes = new HashSet<string> { "A001", "A002", "A001" }; // A001 tekrar edilmez
        foreach (var code in productCodes)
            Console.WriteLine($"Product code: {code}");

        // SortedSet<T> - Sıralı müşteri puanları
        var customerScores = new SortedSet<int> { 85, 92, 70 };
        customerScores.Add(90);
        foreach (var score in customerScores)
            Console.WriteLine($"Customer Score: {score}");

        // LinkedList<T> - Playlist yönetimi
        var playlist = new LinkedList<string>();
        playlist.AddLast("Song1");
        playlist.AddLast("Song2");
        playlist.AddFirst("Intro");
        Console.WriteLine($"Current song: {playlist.First.Value}");

        // KeyValuePair<TKey,TValue> - Ayarlar anahtar-değer çiftleri
        var setting = new KeyValuePair<string, string>("Theme", "DarkMode");
        Console.WriteLine($"Setting: {setting.Key} - {setting.Value}");

        // Custom Tree<T> ve Graph<T> genellikle sınıf tanımı gerektirir, örnek basitleştirilmiş hali:

        // Custom Tree - Organizasyon yapısı
        var orgTree = new TreeNode<string>("CEO");
        var managerNode = new TreeNode<string>("Manager");
        orgTree.Children.Add(managerNode);
        managerNode.Children.Add(new TreeNode<string>("Employee"));
        Console.WriteLine($"Root of organization: {orgTree.Value}, First Child: {orgTree.Children[0].Value}");

        // Custom Graph - Sosyal bağlantılar
        var socialGraph = new Dictionary<string, HashSet<string>>();
        socialGraph["Alice"] = new HashSet<string> { "Bob", "Charlie" };
        socialGraph["Bob"] = new HashSet<string> { "Alice" };
        foreach (var friend in socialGraph["Alice"])
            Console.WriteLine($"Alice's friend: {friend}");
    }
}

public class TreeNode<T>
{
    public T Value { get; set; }
    public List<TreeNode<T>> Children { get; set; } = new List<TreeNode<T>>();

    public TreeNode(T value)
    {
        Value = value;
    }
}
