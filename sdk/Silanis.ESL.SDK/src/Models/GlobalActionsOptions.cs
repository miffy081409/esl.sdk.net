//
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Silanis.ESL.API
{
	
	
	internal class GlobalActionsOptions
	{
		
		// Fields
		
		// Accessors
		    
    [JsonProperty("confirm")]
    public Boolean Confirm
    {
                get; set;
        }
    
		    
    [JsonProperty("download")]
    public Boolean Download
    {
                get; set;
        }
    
		    
    [JsonProperty("saveAsLayout")]
    public Boolean SaveAsLayout
    {
                get; set;
        }
    
		
	
	}
}