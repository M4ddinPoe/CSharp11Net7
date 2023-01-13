//- .NET benutzt UTF-16
//- Das Internet basiert jedoch auf UTF-8

using System;
using System.Text;

string text = "My Text"; // UTF-16

// Wenn z.B. ein Http-Header oder ähnliches geschrieben werden soll, sollte dieser UTF-8 codiert werden 
ReadOnlySpan<byte> utf8 = "My Header"u8;

ReadOnlySpan<byte> u16A = Encoding.Unicode.GetBytes("A"); // 2 Byte
ReadOnlySpan<byte> u8A = "A"u8; // 1 byte 
