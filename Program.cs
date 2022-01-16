using NestedObjects;

Advisor compSciAdvisor = new()
{ Email = "BillyBob@cptc.edu",
    FullName = "Billy Bob",
  OfficeLocation = "B18 Rm 130"
};

Student stu1 = new() { 
    FirstName = "Stewie",
    LastName = "Griffin",
    DateOfBirth = new DateOnly(2000, 3, 20),
    AssignedAdvisor = compSciAdvisor,
    PhoneNumber = "253-555-4523",
    SchoolEmail = "Stewie.Griffin@students.cptc.edu"

};

Console.WriteLine($"Student: {stu1.FirstName} has {stu1.AssignedAdvisor.FullName} as their advisor");
Console.WriteLine($"His last name is {stu1.LastName} and his assigned advisors' " +
    $"building is {stu1.AssignedAdvisor.OfficeLocation}");