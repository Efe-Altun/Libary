using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Libary.Books;

public class Book : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }

    public BookType Type { get; set; }

    public DateTime PublishDate { get; set; }

    public float Price { get; set; }

    public string Image { get; set; }

}



