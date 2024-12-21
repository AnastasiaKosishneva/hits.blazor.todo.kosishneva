//обеспечивает структуру задачи

using System.ComponentModel.DataAnnotations;

namespace TodoServerApp.Data
{
	public class TaskItem //класс задачи
	{
		public int Id { get; set; }
		[Required]
		public string? Product { get; set; }
		[Required]
		public string? Category { get; set; }

        public string? Order { get; set; }
        public bool IsAddedToCart { get; set; } = false; // Флаг для состояния корзины
        public int Quantity { get; set; } = 0; // Количество товаров

        public bool IsHovered { get; set; } // Новое поле

        public bool IsSelected { get; set; } // Указывает, выбрана ли карточка
 
    }
}
