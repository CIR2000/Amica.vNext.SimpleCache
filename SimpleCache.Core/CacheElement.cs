﻿using System;
using SQLite;

namespace Amica.vNext.SimpleCache
{
    class CacheElement
    {
	[PrimaryKey]
	public string Key { get; set; }
	[Indexed]
	public string TypeName { get; set; }
        public byte[] Value { get; set; }
	[Indexed]
	public DateTime? Expiration { get; set; }
	public DateTimeOffset CreatedAt { get; set; }
    }
}
