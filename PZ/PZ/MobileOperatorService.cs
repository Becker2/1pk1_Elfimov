using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PZ;

public class MobileOperatorService
{
    public string ServiceProvider { get; private set; }

    public MobileOperatorService(string providerName)
    {
        ServiceProvider = providerName;
    }

    public void ActivatePhone(Phone phone)
    {
        if (phone.details != null)
        {
            phone.details.IsActive = true;
            Console.WriteLine($"Телефон {phone.GetPhoneNumber()} активирован у оператора {ServiceProvider}");
        }
    }

    public void DeactivatePhone(Phone phone)
    {
        if (phone.details != null)
        {
            phone.details.IsActive = false;
            Console.WriteLine($"Телефон {phone.GetPhoneNumber()} деактивирован у оператора {ServiceProvider}");
        }
    }

    public bool ValidatePhoneNumber(Phone phone)
    {
        return phone.number.Length == 7 &&
               phone.code.Length == 3 &&
               !string.IsNullOrEmpty(phone.prefix);
    }

    public decimal CalculateMonthlyCost(Phone phone)
    {
        // Простая логика расчета стоимости
        decimal baseCost = 300m;
        if (phone.type == "Корпоративный") baseCost += 200m;
        if (phone.prefix == "+1") baseCost += 100m; // Международные звонки дороже

        return baseCost;
    }
}
