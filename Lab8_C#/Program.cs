public class Array<T>{
    private List<T> list;

    public Array(int size){
        list = new List<T>(size);
    }

    //метод для получения элемента из списка по индексу
    public T GetItem(int index){
        if (index < 0 || index >= list.Count) throw new IndexOutOfRangeException("Неправильный индекс");
        return list[index];
    }

    //метод для добавления значения в список
    public void SetItem(T value){
        list.Add(value);
    }

    //метод для удаления значения из список
    public void RemoveItem(int index){
        if (index < 0 || index >= list.Count) throw new IndexOutOfRangeException("Неправильный индекс");
        list = list.Where((source, i) => i != index).ToList();
    }

    //метод для возвращения длинны списка
    public int Size(){
        return list.Count;
    }

    //метод для вывода занчений списка
    public void PrintAllItems(string name){
        Console.WriteLine($"{name} список ({Size()} элементов):"); ;
        for (int i = 0; i < list.Count; i++){
            Console.Write(list[i] + (i < list.Count - 1 ? "; " : "\n"));
        }
        Console.WriteLine("-------------------------------");
    }
}

public class Program{
    public static void Main(string[] args){
        LoginArray loginArray = new LoginArray(10);
        PasswordArray passwordArray = new PasswordArray(10);

        // Регистрация пользователей
        loginArray.RegisterLogin("Mel");
        passwordArray.RegisterPassword("Ababa7");

        loginArray.RegisterLogin("Croos");
        passwordArray.RegisterPassword("Sictivcar12");

        // Вывод зарегистрированных логинов и паролей
        loginArray.PrintAllItems("Логины");
        passwordArray.PrintAllItems("Пароли");

    }
}
public class LoginArray : Array<string>{
    public LoginArray(int size) : base(size){
    }

    public void RegisterLogin(string login){
        SetItem(login);
    }
}

public class PasswordArray : Array<string>{
    public PasswordArray(int size) : base(size){
    }

    public void RegisterPassword(string password){
        SetItem(password);
    }
}