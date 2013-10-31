using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

///This file contains all the typed enums that the client rest api spec exposes.
///This file is automatically generated from https://github.com/elasticsearch/elasticsearch-rest-api-spec
///Generated of commit 8537d3f55e
namespace Nest
{
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ConsistencyOptions 
	{
		[JsonProperty("one")]
		One,
		[JsonProperty("quorum")]
		Quorum,
		[JsonProperty("all")]
		All
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ReplicationOptions 
	{
		[JsonProperty("sync")]
		Sync,
		[JsonProperty("async")]
		Async
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LevelOptions 
	{
		[JsonProperty("cluster")]
		Cluster,
		[JsonProperty("indices")]
		Indices,
		[JsonProperty("shards")]
		Shards
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum WaitForStatusOptions 
	{
		[JsonProperty("green")]
		Green,
		[JsonProperty("yellow")]
		Yellow,
		[JsonProperty("red")]
		Red
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TypeOptions 
	{
		[JsonProperty("cpu")]
		Cpu,
		[JsonProperty("wait")]
		Wait,
		[JsonProperty("block")]
		Block
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum IgnoreIndicesOptions 
	{
		[JsonProperty("none")]
		None,
		[JsonProperty("missing")]
		Missing
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum VersionTypeOptions 
	{
		[JsonProperty("internal")]
		Internal,
		[JsonProperty("external")]
		External
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DefaultOperatorOptions 
	{
		[JsonProperty("AND")]
		And,
		[JsonProperty("OR")]
		Or
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OpTypeOptions 
	{
		[JsonProperty("index")]
		Index,
		[JsonProperty("create")]
		Create
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FormatOptions 
	{
		[JsonProperty("detailed")]
		Detailed,
		[JsonProperty("text")]
		Text
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SearchTypeOptions 
	{
		[JsonProperty("query_then_fetch")]
		QueryThenFetch,
		[JsonProperty("query_and_fetch")]
		QueryAndFetch,
		[JsonProperty("dfs_query_then_fetch")]
		DfsQueryThenFetch,
		[JsonProperty("dfs_query_and_fetch")]
		DfsQueryAndFetch,
		[JsonProperty("count")]
		Count,
		[JsonProperty("scan")]
		Scan
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SuggestModeOptions 
	{
		[JsonProperty("missing")]
		Missing,
		[JsonProperty("popular")]
		Popular,
		[JsonProperty("always")]
		Always
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MetricFamilyOptions 
	{
		[JsonProperty("all")]
		All,
		[JsonProperty("fs")]
		Fs,
		[JsonProperty("http")]
		Http,
		[JsonProperty("indices")]
		Indices,
		[JsonProperty("jvm")]
		Jvm,
		[JsonProperty("network")]
		Network,
		[JsonProperty("os")]
		Os,
		[JsonProperty("process")]
		Process,
		[JsonProperty("thread_pool")]
		ThreadPool,
		[JsonProperty("transport")]
		Transport
	}
	
	
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MetricOptions 
	{
		[JsonProperty("completion")]
		Completion,
		[JsonProperty("docs")]
		Docs,
		[JsonProperty("fielddata")]
		Fielddata,
		[JsonProperty("filter_cache")]
		FilterCache,
		[JsonProperty("flush")]
		Flush,
		[JsonProperty("get")]
		Get,
		[JsonProperty("id_cache")]
		IdCache,
		[JsonProperty("indexing")]
		Indexing,
		[JsonProperty("merges")]
		Merges,
		[JsonProperty("refresh")]
		Refresh,
		[JsonProperty("search")]
		Search,
		[JsonProperty("store")]
		Store,
		[JsonProperty("warmer")]
		Warmer
	}
	
}
 