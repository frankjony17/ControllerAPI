using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllerAPI.Entities
{
    public class ResponseService
    {
		public int Id { get; set; }
		public string ClientIdentifier { get; set; }
		public int Status { get; set; }
		public string Response { get; set; }
		public int NumberOfResponse { get; set; }
		public bool ByTokens { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
		public int SystemClientId { get; set; }
		public int NeonServiceId { get; set; }
		public virtual SystemClient SystemClient { get; set; }
		public virtual NeonService NeonService { get; set; }
	}
}
