//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using System.ComponentModel.DataAnnotations.Schema;

namespace Bozor.Web.Models.Foundations.Product
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.Now;
    }


}
