﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Nest
{
	[JsonObject]
	public class ExplanationDetail
	{
		[JsonProperty(PropertyName = "value")]
		public float Value { get; internal set; }
		[JsonProperty(PropertyName = "description")]
		public string Description { get; internal set; }
	}
}
