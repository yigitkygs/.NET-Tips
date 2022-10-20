using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot.net_Tips
{
    /// <summary>
    /// We can use this class for validating any object type change the conditions according to its parameters.
    /// </summary>
    
        public class GenericTypeValidations<T> : AbstractValidator<T> where T : class
        {
            public GenericTypeValidations(T obj)
            {
                foreach (var item in obj.GetType().GetProperties())
                {
                    if (item.PropertyType == typeof(string))
                    {
                        if (item.Name.Contains("Password"))
                        {
                            RuleFor(a => item.GetValue(obj, null).ToString()).NotEmpty().MinimumLength(2).MaximumLength(20).WithMessage("Şifre en az 2 en çok 20 harften oluşmalı");
                        }
                        else if (item.Name.Contains("Email"))
                        {
                            RuleFor(a => item.GetValue(obj, null).ToString()).NotEmpty().EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz..");
                        }
                        else RuleFor(a => item.GetValue(obj, null)).NotNull();
                    }
                }
            }
        }
    
}
