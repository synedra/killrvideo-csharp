// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: search/search_service.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace KillrVideo.Search {
  /// <summary>
  ///  Searches for videos
  /// </summary>
  public static class SearchService
  {
    static readonly string __ServiceName = "killrvideo.search.SearchService";

    static readonly Marshaller<global::KillrVideo.Search.SearchVideosRequest> __Marshaller_SearchVideosRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.Search.SearchVideosRequest.Parser.ParseFrom);
    static readonly Marshaller<global::KillrVideo.Search.SearchVideosResponse> __Marshaller_SearchVideosResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.Search.SearchVideosResponse.Parser.ParseFrom);
    static readonly Marshaller<global::KillrVideo.Search.GetQuerySuggestionsRequest> __Marshaller_GetQuerySuggestionsRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.Search.GetQuerySuggestionsRequest.Parser.ParseFrom);
    static readonly Marshaller<global::KillrVideo.Search.GetQuerySuggestionsResponse> __Marshaller_GetQuerySuggestionsResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.Search.GetQuerySuggestionsResponse.Parser.ParseFrom);

    static readonly Method<global::KillrVideo.Search.SearchVideosRequest, global::KillrVideo.Search.SearchVideosResponse> __Method_SearchVideos = new Method<global::KillrVideo.Search.SearchVideosRequest, global::KillrVideo.Search.SearchVideosResponse>(
        MethodType.Unary,
        __ServiceName,
        "SearchVideos",
        __Marshaller_SearchVideosRequest,
        __Marshaller_SearchVideosResponse);

    static readonly Method<global::KillrVideo.Search.GetQuerySuggestionsRequest, global::KillrVideo.Search.GetQuerySuggestionsResponse> __Method_GetQuerySuggestions = new Method<global::KillrVideo.Search.GetQuerySuggestionsRequest, global::KillrVideo.Search.GetQuerySuggestionsResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetQuerySuggestions",
        __Marshaller_GetQuerySuggestionsRequest,
        __Marshaller_GetQuerySuggestionsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::KillrVideo.Search.SearchServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SearchService</summary>
    public abstract class SearchServiceBase
    {
      /// <summary>
      ///  Searches for videos by a given query term
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::KillrVideo.Search.SearchVideosResponse> SearchVideos(global::KillrVideo.Search.SearchVideosRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Gets search query suggestions (could be used for typeahead support)
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::KillrVideo.Search.GetQuerySuggestionsResponse> GetQuerySuggestions(global::KillrVideo.Search.GetQuerySuggestionsRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SearchService</summary>
    public class SearchServiceClient : ClientBase<SearchServiceClient>
    {
      /// <summary>Creates a new client for SearchService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SearchServiceClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SearchService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SearchServiceClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SearchServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SearchServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  Searches for videos by a given query term
      /// </summary>
      public virtual global::KillrVideo.Search.SearchVideosResponse SearchVideos(global::KillrVideo.Search.SearchVideosRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SearchVideos(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Searches for videos by a given query term
      /// </summary>
      public virtual global::KillrVideo.Search.SearchVideosResponse SearchVideos(global::KillrVideo.Search.SearchVideosRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SearchVideos, null, options, request);
      }
      /// <summary>
      ///  Searches for videos by a given query term
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.Search.SearchVideosResponse> SearchVideosAsync(global::KillrVideo.Search.SearchVideosRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SearchVideosAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Searches for videos by a given query term
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.Search.SearchVideosResponse> SearchVideosAsync(global::KillrVideo.Search.SearchVideosRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SearchVideos, null, options, request);
      }
      /// <summary>
      ///  Gets search query suggestions (could be used for typeahead support)
      /// </summary>
      public virtual global::KillrVideo.Search.GetQuerySuggestionsResponse GetQuerySuggestions(global::KillrVideo.Search.GetQuerySuggestionsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetQuerySuggestions(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets search query suggestions (could be used for typeahead support)
      /// </summary>
      public virtual global::KillrVideo.Search.GetQuerySuggestionsResponse GetQuerySuggestions(global::KillrVideo.Search.GetQuerySuggestionsRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetQuerySuggestions, null, options, request);
      }
      /// <summary>
      ///  Gets search query suggestions (could be used for typeahead support)
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.Search.GetQuerySuggestionsResponse> GetQuerySuggestionsAsync(global::KillrVideo.Search.GetQuerySuggestionsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetQuerySuggestionsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets search query suggestions (could be used for typeahead support)
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.Search.GetQuerySuggestionsResponse> GetQuerySuggestionsAsync(global::KillrVideo.Search.GetQuerySuggestionsRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetQuerySuggestions, null, options, request);
      }
      protected override SearchServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SearchServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(SearchServiceBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SearchVideos, serviceImpl.SearchVideos)
          .AddMethod(__Method_GetQuerySuggestions, serviceImpl.GetQuerySuggestions).Build();
    }

  }
}
#endregion