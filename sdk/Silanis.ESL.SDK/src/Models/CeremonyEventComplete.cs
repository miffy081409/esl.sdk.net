//
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Silanis.ESL.API
{
	
	
	public class CeremonyEventComplete
	{
		
		// Fields
		
		// Accessors
		    
    [JsonProperty("dialog")]
    public Boolean Dialog
    {
                get; set;
        }
    
		    
    [JsonProperty("redirect")]
    public String Redirect
    {
                get; set;
        }
    
		
	
	}
}