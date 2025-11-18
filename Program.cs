using MongoDB.Driver;

var client = new MongoClient("mongodb+srv://felipelmmoreira_db_user:vpbHVcYLUZmV5AQN@interacaomongo.unnu8jr.mongodb.net/");
//var client = new MongoClient("mongodb://localhost:27017");

var database = client.GetDatabase("InterAcaoMongoDb");

var collection = database.GetCollection<User>("Usuarios");

//var usuario = new User("Felipe", "123@mudar");
//collection.InsertOne(usuario);

//var usuarios = collection.Find(_ => true).ToList();

//var usuariosNovos = await collection.FindAsync(x => x.IsActive == true).Result.ToListAsync();

foreach (var user in await collection.FindAsync(x => x.IsActive == true).Result.ToListAsync())
{
    Console.WriteLine(user);
    Console.WriteLine("---");
}

Console.WriteLine("aqui continua minha aplicação");



//var usuarioNovos = new List<User>();
//for (int i = 0; i < 100000; i++)
//{

//    usuarioNovos.Add(new User("João", "123@mudar"));
//    usuarioNovos.Add(new User("Maria", "123@mudar"));
//    usuarioNovos.Add(new User("Ana", "123@mudar"));
//}

//collection.InsertMany(usuarioNovos);

//usuarios = collection.Find(_ => true).ToList();

//foreach (var user in usuarios)
//{
//    Console.WriteLine(user);
//    Console.WriteLine("---");
//}

//var usuario = collection.Find(x => x.Id == "6917391adb6ae87ee4e1b126").FirstOrDefault();
//var usuario = collection.Find(x => x.Password == "123@mudar").ToList();

//Console.WriteLine("Chegou do Banco assim: \n" + usuario);
//usuario.Password = "456@mudar"; //troca em memoria
//usuario.UpdatedAt = DateTime.Now;
//usuario.IsActive = false;

//collection.ReplaceOne(x => x.Id == usuario.Id, usuario);

//Console.WriteLine(collection.Find(x => x.Id == "6917391adb6ae87ee4e1b126").FirstOrDefault());

//collection.UpdateOne(
//    x => x.Id == "6917391adb6ae87ee4e1b128",
//    Builders<User>.Update.Set(x => x.Password, "789@mudar")
//);

//Console.WriteLine(collection.Find(x => x.Id == "6917391adb6ae87ee4e1b128").FirstOrDefault());

//collection.DeleteOne(x => x.Id == "6917391adb6ae87ee4e1b126");