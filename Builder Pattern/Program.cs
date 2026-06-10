using Builder_Pattern;

var user = new UserBuilder()
    .setFirstName("Sadaf Hossain")
    .setLastName("Samir")
    .setEmail("samir@gmail.com")
    .Build();
Console.WriteLine(user.FirstName);
Console.WriteLine(user.LastName);
Console.WriteLine(user.Email);