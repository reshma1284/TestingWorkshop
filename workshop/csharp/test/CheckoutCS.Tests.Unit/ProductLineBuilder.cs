﻿using System;

namespace CheckoutCS.Tests.Unit
{
    internal class ProductLineBuilder
    {
        private Guid id = Guid.Parse("62a8420a-83a5-4848-ba2e-2c1a761bc21b");
        private string code = "P0001";
        private string name = "Test Product";
        private string description = "Test Product Description is Awesome!";
        private decimal amount = 1.0m;
        private long version = 0;
        private int quantity = 1;

        public ProductLine Build()
        {
            return new ProductLine(id, code, name, description, amount, quantity, version);
        }

        public static implicit operator ProductLine(ProductLineBuilder builder) => builder.Build();

        internal ProductLineBuilder WithId(Guid id)
        {
            this.id = id;
            return this;
        }

        internal ProductLineBuilder WithCode(string code)
        {
            this.code = code;
            return this;
        }

        internal ProductLineBuilder WithName(string name)
        {
            this.name = name;
            return this;
        }

        internal ProductLineBuilder WithDescription(string description)
        {
            this.description = description;
            return this;
        }

        internal ProductLineBuilder WithAmount(decimal amount)
        {
            this.amount = amount;
            return this;
        }

        internal ProductLineBuilder WithVersion(long version)
        {
            this.version = version;
            return this;
        }

        internal ProductLineBuilder WithQuantity(int quantity)
        {
            this.quantity = quantity;
            return this;
        }
    }
}