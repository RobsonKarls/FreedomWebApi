using System.Collections.Generic;
using Freedom.Domain.Entities;
using Freedom.Domain.Enum;
using Freedom.Infrastructure.DataAccess.Factories;
using Freedom.Infrastructure.DataAccess.Repositories;
using Machine.Specifications;

namespace Freedom.Infrastructure.Test.Repositories
{
    [Subject(typeof(Product))]
    public class When_adding_products : DatabaseSpec
    {
        private static Product _product { get; set; }
        private static Repository<Product> _repository { get; set; }

        private Establish c = () => _repository = new Repository<Product>(ContextFactory.GetContext());

        Because of = () =>
        {
            _product = new Product
            {
                Category = new Category {ParentId = null, Title = "Derivados do Leite"},
                Farm = new Farm {Name = "Sitio do Gilmar"},
                MeasureUnit = MeasureUnit.Kilograms,
                Size = 1.1,
                Name = "Queijo Minas"
            };
            _repository.Save(_product);
            UnitOfWork.Commit();
        };

        It should_Id_be_type_of_int = () =>
            _product.Id.ShouldBeOfExactType(typeof(int));

        It should_have_a_farm = () =>
            _product.Farm.ShouldNotBeNull();

        It should_have_a_category = () =>
            _product.Category.ShouldNotBeNull();

    }
}
