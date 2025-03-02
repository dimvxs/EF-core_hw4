using System;


namespace Models
{
	public class Worker
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public int PositionId { get; set; }
        public Position Position { get; set; }

		public Worker()
		{
		}
	}
}
