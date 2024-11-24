uusing System.Text.Json.Serialization;

namespace HPlusSport.Model
{
	public class Category
	{
		public int Id { get; set; }
		public string Stu { get; set; } = string.Empty;
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public decimal price { get; set; }
		public bool IsAvailable { get; set; }

		public int CategoryId { get; set; }

		public virtual Category Category { get; set; }

		[Required]
        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category? Category { get; set; }
	}
}

