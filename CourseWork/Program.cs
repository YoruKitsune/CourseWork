using CourseWork.DocumentsClasses;

using (ApplicationContext db = new ApplicationContext())
{
    // создаем два объекта User
    PersonClass tom = new PersonClass("Tom", "Person","Moscow" ,"Lvovich");
    PersonClass alice = new PersonClass("Alice", "Walter", "Omsk");
    CertificateOfAdoption test = new CertificateOfAdoption(1, 1, DateTime.Now, "here", DateTime.Now, 1, tom, alice);
    tom.BrokenCertificates?.Add(test);
    alice.BrokenCertificates?.Add(test);
    // добавляем их в бд
    db.Persons.Add(tom);
    db.Persons.Add(alice);
    db.SaveChanges();
    Console.WriteLine("Объекты успешно сохранены");

    // получаем объекты из бд и выводим на консоль
    var users = db.Persons.ToList();
    Console.WriteLine("Список объектов:");
    foreach (PersonClass u in users)
    {
        db.Persons.Remove(u);
        u.ChangeStatus(StatusEnum.divorced);
        db.Persons.Add(u);

        Console.WriteLine($"{u.Id} - {u.Surname} {u.Name} {u.Patronymic} {u.Status} {u.BrokenCertificates}");
    }
    
}