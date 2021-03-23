using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Models.Dto
{
    public class OrderBookDto
    {
        [JsonProperty("kolvo")]
        public int kolvo { get; set; }
        [JsonProperty("bookId")]
        public int bookId { get; set; }
        public string bookImage { get; set; }
        public string bookName { get; set; }

        public OrderBookDto()
        {
        }

        public OrderBookDto(int kolvo, int bookId)
        {
            this.kolvo = kolvo;
            this.bookId = bookId;
        }

        public OrderBookDto(int kolvo, int bookId, string bookImage, string bookName)
        {
            this.kolvo = kolvo;
            this.bookId = bookId;
            this.bookImage = bookImage;
            this.bookName = bookName;
        }
    }
}
