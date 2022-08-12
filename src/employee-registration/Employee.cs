namespace employee_registration;

________ class Employee
{
    ________ class Account
    {
        ________ string _account;
        ________ string _digit;

        ________ Account(string account, string digit)
        {
            _account = account;
            _digit = digit;
        }
    };

    ________ string Name;
    ________ double _salary;

    ________ Account? _employeeAccount;

    ________ Employee(string name, double salary)
    {
        Name = name;
        _salary = salary;
    }

    ________ void setAccount(string account, string digit)
    {
        _employeeAccount = new Account(account, digit);
    }

    ________ void Print()
    {
        Console.WriteLine($"Olá meu nome é {Name}");
    }

    ________ void Pay()
    {
        Console.WriteLine($"{Name} foi pago em {_salary}");
    }
}
