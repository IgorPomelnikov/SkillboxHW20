using SkillboxHW20.Interfaces;
using SkillboxHW20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillboxHW20.Mocks
{
    public class MockPersonCollection : IPersonCollection
    {
        public IEnumerable<Person> Persons
        {
            get
            {
                return new List<Person>
                {
                    new Person{ID = 0, FirstName = "John", LastName = "Vasnetsky", Age = 30, Mail = "joahnvas@skillboxhw20.com", Telephone = "+78005553535", Adress ="142902, Томская область, город Балашиха, пл. Ломоносова, 40", Description = "Место для написания описания))", ImgPhoto = "", Male = true},
                    new Person{ID = 1, FirstName = "Mary", LastName = "Petrovich", Age = 30, Mail = "marmarpet@skillboxhw20.com", Telephone = "+78005553538", Adress ="121521, Владимирская область, город Можайск, наб. Ломоносова, 50", Description = "Место для написания описания))", ImgPhoto = "", Male = false},
                    new Person{ID = 2, FirstName = "Fried", LastName = "Dock", Age = 30, Mail = "ffffdock@skillboxhw20.com", Telephone = "+78005553578", Adress ="761310, Ростовская область, город Можайск, наб. Чехова, 30", Description = "Место для написания описания))", ImgPhoto = "", Male = true},
                    new Person{ID = 3, FirstName = "Anna", LastName = "Li", Age = 30, Mail = "aaannnnaaa@skillboxhw20.com", Telephone = "+78005553500", Adress ="952266, Рязанская область, город Мытищи, въезд Славы, 37", Description = "Место для написания описания))", ImgPhoto = "", Male = false},
                    new Person{ID = 4, FirstName = "Michael", LastName = "Shumaher", Age = 30, Mail = "mickmick@skillboxhw20.com", Telephone = "+78005553572", Adress ="492552, Ярославская область, город Клин, шоссе Славы, 52", Description = "Место для написания описания))", ImgPhoto = "", Male = true}
                };
            }
        }
    }
}
