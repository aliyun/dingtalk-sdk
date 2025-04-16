// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkdoc_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCommentRequest
        /// </param>
        /// <param name="headers">
        /// AddCommentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCommentResponse
        /// </returns>
        public AddCommentResponse AddCommentWithOptions(string docId, AddCommentRequest request, AddCommentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommentContent))
            {
                body["commentContent"] = request.CommentContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommentType))
            {
                body["commentType"] = request.CommentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddComment",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/docs/" + docId + "/comments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCommentResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCommentRequest
        /// </param>
        /// <param name="headers">
        /// AddCommentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCommentResponse
        /// </returns>
        public async Task<AddCommentResponse> AddCommentWithOptionsAsync(string docId, AddCommentRequest request, AddCommentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommentContent))
            {
                body["commentContent"] = request.CommentContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommentType))
            {
                body["commentType"] = request.CommentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddComment",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/docs/" + docId + "/comments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCommentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCommentRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCommentResponse
        /// </returns>
        public AddCommentResponse AddComment(string docId, AddCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCommentHeaders headers = new AddCommentHeaders();
            return AddCommentWithOptions(docId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCommentRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCommentResponse
        /// </returns>
        public async Task<AddCommentResponse> AddCommentAsync(string docId, AddCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCommentHeaders headers = new AddCommentHeaders();
            return await AddCommentWithOptionsAsync(docId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加知识库文档成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddWorkspaceDocMembersRequest
        /// </param>
        /// <param name="headers">
        /// AddWorkspaceDocMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddWorkspaceDocMembersResponse
        /// </returns>
        public AddWorkspaceDocMembersResponse AddWorkspaceDocMembersWithOptions(string workspaceId, string nodeId, AddWorkspaceDocMembersRequest request, AddWorkspaceDocMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWorkspaceDocMembers",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<AddWorkspaceDocMembersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加知识库文档成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddWorkspaceDocMembersRequest
        /// </param>
        /// <param name="headers">
        /// AddWorkspaceDocMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddWorkspaceDocMembersResponse
        /// </returns>
        public async Task<AddWorkspaceDocMembersResponse> AddWorkspaceDocMembersWithOptionsAsync(string workspaceId, string nodeId, AddWorkspaceDocMembersRequest request, AddWorkspaceDocMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWorkspaceDocMembers",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<AddWorkspaceDocMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加知识库文档成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddWorkspaceDocMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddWorkspaceDocMembersResponse
        /// </returns>
        public AddWorkspaceDocMembersResponse AddWorkspaceDocMembers(string workspaceId, string nodeId, AddWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceDocMembersHeaders headers = new AddWorkspaceDocMembersHeaders();
            return AddWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加知识库文档成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddWorkspaceDocMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddWorkspaceDocMembersResponse
        /// </returns>
        public async Task<AddWorkspaceDocMembersResponse> AddWorkspaceDocMembersAsync(string workspaceId, string nodeId, AddWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceDocMembersHeaders headers = new AddWorkspaceDocMembersHeaders();
            return await AddWorkspaceDocMembersWithOptionsAsync(workspaceId, nodeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加知识库成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddWorkspaceMembersRequest
        /// </param>
        /// <param name="headers">
        /// AddWorkspaceMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddWorkspaceMembersResponse
        /// </returns>
        public AddWorkspaceMembersResponse AddWorkspaceMembersWithOptions(string workspaceId, AddWorkspaceMembersRequest request, AddWorkspaceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWorkspaceMembers",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWorkspaceMembersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加知识库成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddWorkspaceMembersRequest
        /// </param>
        /// <param name="headers">
        /// AddWorkspaceMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddWorkspaceMembersResponse
        /// </returns>
        public async Task<AddWorkspaceMembersResponse> AddWorkspaceMembersWithOptionsAsync(string workspaceId, AddWorkspaceMembersRequest request, AddWorkspaceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWorkspaceMembers",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWorkspaceMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加知识库成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddWorkspaceMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddWorkspaceMembersResponse
        /// </returns>
        public AddWorkspaceMembersResponse AddWorkspaceMembers(string workspaceId, AddWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceMembersHeaders headers = new AddWorkspaceMembersHeaders();
            return AddWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加知识库成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddWorkspaceMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddWorkspaceMembersResponse
        /// </returns>
        public async Task<AddWorkspaceMembersResponse> AddWorkspaceMembersAsync(string workspaceId, AddWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceMembersHeaders headers = new AddWorkspaceMembersHeaders();
            return await AddWorkspaceMembersWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>追加行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppendRowsRequest
        /// </param>
        /// <param name="headers">
        /// AppendRowsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AppendRowsResponse
        /// </returns>
        public AppendRowsResponse AppendRowsWithOptions(string workbookId, string sheetId, AppendRowsRequest request, AppendRowsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Values))
            {
                body["values"] = request.Values;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AppendRows",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/appendRows",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<AppendRowsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>追加行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppendRowsRequest
        /// </param>
        /// <param name="headers">
        /// AppendRowsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AppendRowsResponse
        /// </returns>
        public async Task<AppendRowsResponse> AppendRowsWithOptionsAsync(string workbookId, string sheetId, AppendRowsRequest request, AppendRowsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Values))
            {
                body["values"] = request.Values;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AppendRows",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/appendRows",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<AppendRowsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>追加行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppendRowsRequest
        /// </param>
        /// 
        /// <returns>
        /// AppendRowsResponse
        /// </returns>
        public AppendRowsResponse AppendRows(string workbookId, string sheetId, AppendRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendRowsHeaders headers = new AppendRowsHeaders();
            return AppendRowsWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>追加行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppendRowsRequest
        /// </param>
        /// 
        /// <returns>
        /// AppendRowsResponse
        /// </returns>
        public async Task<AppendRowsResponse> AppendRowsAsync(string workbookId, string sheetId, AppendRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendRowsHeaders headers = new AppendRowsHeaders();
            return await AppendRowsWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量执行表格操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRequest
        /// </param>
        /// <param name="headers">
        /// BatchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchResponse
        /// </returns>
        public BatchResponse BatchWithOptions(string workbookId, BatchRequest request, BatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Requests))
            {
                body["requests"] = request.Requests;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Batch",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量执行表格操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRequest
        /// </param>
        /// <param name="headers">
        /// BatchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchResponse
        /// </returns>
        public async Task<BatchResponse> BatchWithOptionsAsync(string workbookId, BatchRequest request, BatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Requests))
            {
                body["requests"] = request.Requests;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Batch",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量执行表格操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchResponse
        /// </returns>
        public BatchResponse Batch(string workbookId, BatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchHeaders headers = new BatchHeaders();
            return BatchWithOptions(workbookId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量执行表格操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchResponse
        /// </returns>
        public async Task<BatchResponse> BatchAsync(string workbookId, BatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchHeaders headers = new BatchHeaders();
            return await BatchWithOptionsAsync(workbookId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetWorkspaceDocsRequest
        /// </param>
        /// <param name="headers">
        /// BatchGetWorkspaceDocsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetWorkspaceDocsResponse
        /// </returns>
        public BatchGetWorkspaceDocsResponse BatchGetWorkspaceDocsWithOptions(BatchGetWorkspaceDocsRequest request, BatchGetWorkspaceDocsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                body["nodeIds"] = request.NodeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetWorkspaceDocs",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/docs/infos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetWorkspaceDocsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetWorkspaceDocsRequest
        /// </param>
        /// <param name="headers">
        /// BatchGetWorkspaceDocsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetWorkspaceDocsResponse
        /// </returns>
        public async Task<BatchGetWorkspaceDocsResponse> BatchGetWorkspaceDocsWithOptionsAsync(BatchGetWorkspaceDocsRequest request, BatchGetWorkspaceDocsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                body["nodeIds"] = request.NodeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetWorkspaceDocs",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/docs/infos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetWorkspaceDocsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetWorkspaceDocsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetWorkspaceDocsResponse
        /// </returns>
        public BatchGetWorkspaceDocsResponse BatchGetWorkspaceDocs(BatchGetWorkspaceDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetWorkspaceDocsHeaders headers = new BatchGetWorkspaceDocsHeaders();
            return BatchGetWorkspaceDocsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetWorkspaceDocsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetWorkspaceDocsResponse
        /// </returns>
        public async Task<BatchGetWorkspaceDocsResponse> BatchGetWorkspaceDocsAsync(BatchGetWorkspaceDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetWorkspaceDocsHeaders headers = new BatchGetWorkspaceDocsHeaders();
            return await BatchGetWorkspaceDocsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>知识库批量查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetWorkspacesRequest
        /// </param>
        /// <param name="headers">
        /// BatchGetWorkspacesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetWorkspacesResponse
        /// </returns>
        public BatchGetWorkspacesResponse BatchGetWorkspacesWithOptions(BatchGetWorkspacesRequest request, BatchGetWorkspacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeRecent))
            {
                body["includeRecent"] = request.IncludeRecent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                body["workspaceIds"] = request.WorkspaceIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetWorkspaces",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/infos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetWorkspacesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>知识库批量查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetWorkspacesRequest
        /// </param>
        /// <param name="headers">
        /// BatchGetWorkspacesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetWorkspacesResponse
        /// </returns>
        public async Task<BatchGetWorkspacesResponse> BatchGetWorkspacesWithOptionsAsync(BatchGetWorkspacesRequest request, BatchGetWorkspacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeRecent))
            {
                body["includeRecent"] = request.IncludeRecent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                body["workspaceIds"] = request.WorkspaceIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetWorkspaces",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/infos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetWorkspacesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>知识库批量查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetWorkspacesResponse
        /// </returns>
        public BatchGetWorkspacesResponse BatchGetWorkspaces(BatchGetWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetWorkspacesHeaders headers = new BatchGetWorkspacesHeaders();
            return BatchGetWorkspacesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>知识库批量查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetWorkspacesResponse
        /// </returns>
        public async Task<BatchGetWorkspacesResponse> BatchGetWorkspacesAsync(BatchGetWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetWorkspacesHeaders headers = new BatchGetWorkspacesHeaders();
            return await BatchGetWorkspacesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据入参批量调用多个文档API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchOperateRequest
        /// </param>
        /// <param name="headers">
        /// BatchOperateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchOperateResponse
        /// </returns>
        public BatchOperateResponse BatchOperateWithOptions(string documentId, BatchOperateRequest request, BatchOperateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Requests))
            {
                body["requests"] = request.Requests;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchOperate",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + documentId + "/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchOperateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据入参批量调用多个文档API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchOperateRequest
        /// </param>
        /// <param name="headers">
        /// BatchOperateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchOperateResponse
        /// </returns>
        public async Task<BatchOperateResponse> BatchOperateWithOptionsAsync(string documentId, BatchOperateRequest request, BatchOperateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Requests))
            {
                body["requests"] = request.Requests;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchOperate",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + documentId + "/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchOperateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据入参批量调用多个文档API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchOperateRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchOperateResponse
        /// </returns>
        public BatchOperateResponse BatchOperate(string documentId, BatchOperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchOperateHeaders headers = new BatchOperateHeaders();
            return BatchOperateWithOptions(documentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据入参批量调用多个文档API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchOperateRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchOperateResponse
        /// </returns>
        public async Task<BatchOperateResponse> BatchOperateAsync(string documentId, BatchOperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchOperateHeaders headers = new BatchOperateHeaders();
            return await BatchOperateWithOptionsAsync(documentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关联文档酷应用到表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindCoolAppToSheetRequest
        /// </param>
        /// <param name="headers">
        /// BindCoolAppToSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindCoolAppToSheetResponse
        /// </returns>
        public BindCoolAppToSheetResponse BindCoolAppToSheetWithOptions(string workbookId, BindCoolAppToSheetRequest request, BindCoolAppToSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindCoolAppToSheet",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/coolApps",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindCoolAppToSheetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关联文档酷应用到表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindCoolAppToSheetRequest
        /// </param>
        /// <param name="headers">
        /// BindCoolAppToSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindCoolAppToSheetResponse
        /// </returns>
        public async Task<BindCoolAppToSheetResponse> BindCoolAppToSheetWithOptionsAsync(string workbookId, BindCoolAppToSheetRequest request, BindCoolAppToSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindCoolAppToSheet",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/coolApps",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindCoolAppToSheetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关联文档酷应用到表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindCoolAppToSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// BindCoolAppToSheetResponse
        /// </returns>
        public BindCoolAppToSheetResponse BindCoolAppToSheet(string workbookId, BindCoolAppToSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BindCoolAppToSheetHeaders headers = new BindCoolAppToSheetHeaders();
            return BindCoolAppToSheetWithOptions(workbookId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关联文档酷应用到表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindCoolAppToSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// BindCoolAppToSheetResponse
        /// </returns>
        public async Task<BindCoolAppToSheetResponse> BindCoolAppToSheetAsync(string workbookId, BindCoolAppToSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BindCoolAppToSheetHeaders headers = new BindCoolAppToSheetHeaders();
            return await BindCoolAppToSheetWithOptionsAsync(workbookId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清除单元格区域内所有内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearRequest
        /// </param>
        /// <param name="headers">
        /// ClearHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ClearResponse
        /// </returns>
        public ClearResponse ClearWithOptions(string workbookId, string sheetId, string rangeAddress, ClearRequest request, ClearHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Clear",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/clear",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清除单元格区域内所有内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearRequest
        /// </param>
        /// <param name="headers">
        /// ClearHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ClearResponse
        /// </returns>
        public async Task<ClearResponse> ClearWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, ClearRequest request, ClearHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Clear",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/clear",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清除单元格区域内所有内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearRequest
        /// </param>
        /// 
        /// <returns>
        /// ClearResponse
        /// </returns>
        public ClearResponse Clear(string workbookId, string sheetId, string rangeAddress, ClearRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearHeaders headers = new ClearHeaders();
            return ClearWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清除单元格区域内所有内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearRequest
        /// </param>
        /// 
        /// <returns>
        /// ClearResponse
        /// </returns>
        public async Task<ClearResponse> ClearAsync(string workbookId, string sheetId, string rangeAddress, ClearRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearHeaders headers = new ClearHeaders();
            return await ClearWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清除单元格区域内数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearDataRequest
        /// </param>
        /// <param name="headers">
        /// ClearDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ClearDataResponse
        /// </returns>
        public ClearDataResponse ClearDataWithOptions(string workbookId, string sheetId, string rangeAddress, ClearDataRequest request, ClearDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearData",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/clearData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清除单元格区域内数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearDataRequest
        /// </param>
        /// <param name="headers">
        /// ClearDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ClearDataResponse
        /// </returns>
        public async Task<ClearDataResponse> ClearDataWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, ClearDataRequest request, ClearDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearData",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/clearData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清除单元格区域内数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearDataRequest
        /// </param>
        /// 
        /// <returns>
        /// ClearDataResponse
        /// </returns>
        public ClearDataResponse ClearData(string workbookId, string sheetId, string rangeAddress, ClearDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearDataHeaders headers = new ClearDataHeaders();
            return ClearDataWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清除单元格区域内数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearDataRequest
        /// </param>
        /// 
        /// <returns>
        /// ClearDataResponse
        /// </returns>
        public async Task<ClearDataResponse> ClearDataAsync(string workbookId, string sheetId, string rangeAddress, ClearDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearDataHeaders headers = new ClearDataHeaders();
            return await ClearDataWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建条件格式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConditionalFormattingRuleRequest
        /// </param>
        /// <param name="headers">
        /// CreateConditionalFormattingRuleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConditionalFormattingRuleResponse
        /// </returns>
        public CreateConditionalFormattingRuleResponse CreateConditionalFormattingRuleWithOptions(string workbookId, string sheetId, CreateConditionalFormattingRuleRequest request, CreateConditionalFormattingRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CellStyle))
            {
                body["cellStyle"] = request.CellStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicateCondition))
            {
                body["duplicateCondition"] = request.DuplicateCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberCondition))
            {
                body["numberCondition"] = request.NumberCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ranges))
            {
                body["ranges"] = request.Ranges;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConditionalFormattingRule",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/conditionalFormattingRules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConditionalFormattingRuleResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建条件格式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConditionalFormattingRuleRequest
        /// </param>
        /// <param name="headers">
        /// CreateConditionalFormattingRuleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConditionalFormattingRuleResponse
        /// </returns>
        public async Task<CreateConditionalFormattingRuleResponse> CreateConditionalFormattingRuleWithOptionsAsync(string workbookId, string sheetId, CreateConditionalFormattingRuleRequest request, CreateConditionalFormattingRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CellStyle))
            {
                body["cellStyle"] = request.CellStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicateCondition))
            {
                body["duplicateCondition"] = request.DuplicateCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberCondition))
            {
                body["numberCondition"] = request.NumberCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ranges))
            {
                body["ranges"] = request.Ranges;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConditionalFormattingRule",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/conditionalFormattingRules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConditionalFormattingRuleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建条件格式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConditionalFormattingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConditionalFormattingRuleResponse
        /// </returns>
        public CreateConditionalFormattingRuleResponse CreateConditionalFormattingRule(string workbookId, string sheetId, CreateConditionalFormattingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateConditionalFormattingRuleHeaders headers = new CreateConditionalFormattingRuleHeaders();
            return CreateConditionalFormattingRuleWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建条件格式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConditionalFormattingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConditionalFormattingRuleResponse
        /// </returns>
        public async Task<CreateConditionalFormattingRuleResponse> CreateConditionalFormattingRuleAsync(string workbookId, string sheetId, CreateConditionalFormattingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateConditionalFormattingRuleHeaders headers = new CreateConditionalFormattingRuleHeaders();
            return await CreateConditionalFormattingRuleWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建开发者元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeveloperMetadataRequest
        /// </param>
        /// <param name="headers">
        /// CreateDeveloperMetadataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeveloperMetadataResponse
        /// </returns>
        public CreateDeveloperMetadataResponse CreateDeveloperMetadataWithOptions(string workbookId, CreateDeveloperMetadataRequest request, CreateDeveloperMetadataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociatedColumn))
            {
                body["associatedColumn"] = request.AssociatedColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociatedRow))
            {
                body["associatedRow"] = request.AssociatedRow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeveloperMetadata",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/developerMetadatas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeveloperMetadataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建开发者元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeveloperMetadataRequest
        /// </param>
        /// <param name="headers">
        /// CreateDeveloperMetadataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeveloperMetadataResponse
        /// </returns>
        public async Task<CreateDeveloperMetadataResponse> CreateDeveloperMetadataWithOptionsAsync(string workbookId, CreateDeveloperMetadataRequest request, CreateDeveloperMetadataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociatedColumn))
            {
                body["associatedColumn"] = request.AssociatedColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociatedRow))
            {
                body["associatedRow"] = request.AssociatedRow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeveloperMetadata",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/developerMetadatas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeveloperMetadataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建开发者元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeveloperMetadataRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDeveloperMetadataResponse
        /// </returns>
        public CreateDeveloperMetadataResponse CreateDeveloperMetadata(string workbookId, CreateDeveloperMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeveloperMetadataHeaders headers = new CreateDeveloperMetadataHeaders();
            return CreateDeveloperMetadataWithOptions(workbookId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建开发者元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeveloperMetadataRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDeveloperMetadataResponse
        /// </returns>
        public async Task<CreateDeveloperMetadataResponse> CreateDeveloperMetadataAsync(string workbookId, CreateDeveloperMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeveloperMetadataHeaders headers = new CreateDeveloperMetadataHeaders();
            return await CreateDeveloperMetadataWithOptionsAsync(workbookId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建单元格锁定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRangeProtectionRequest
        /// </param>
        /// <param name="headers">
        /// CreateRangeProtectionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRangeProtectionResponse
        /// </returns>
        public CreateRangeProtectionResponse CreateRangeProtectionWithOptions(string workbookId, string sheetId, string rangeAddress, CreateRangeProtectionRequest request, CreateRangeProtectionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditableSetting))
            {
                body["editableSetting"] = request.EditableSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherUserPermission))
            {
                body["otherUserPermission"] = request.OtherUserPermission;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRangeProtection",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/protections",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRangeProtectionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建单元格锁定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRangeProtectionRequest
        /// </param>
        /// <param name="headers">
        /// CreateRangeProtectionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRangeProtectionResponse
        /// </returns>
        public async Task<CreateRangeProtectionResponse> CreateRangeProtectionWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, CreateRangeProtectionRequest request, CreateRangeProtectionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditableSetting))
            {
                body["editableSetting"] = request.EditableSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherUserPermission))
            {
                body["otherUserPermission"] = request.OtherUserPermission;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRangeProtection",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/protections",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRangeProtectionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建单元格锁定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRangeProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRangeProtectionResponse
        /// </returns>
        public CreateRangeProtectionResponse CreateRangeProtection(string workbookId, string sheetId, string rangeAddress, CreateRangeProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRangeProtectionHeaders headers = new CreateRangeProtectionHeaders();
            return CreateRangeProtectionWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建单元格锁定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRangeProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRangeProtectionResponse
        /// </returns>
        public async Task<CreateRangeProtectionResponse> CreateRangeProtectionAsync(string workbookId, string sheetId, string rangeAddress, CreateRangeProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRangeProtectionHeaders headers = new CreateRangeProtectionHeaders();
            return await CreateRangeProtectionWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSheetRequest
        /// </param>
        /// <param name="headers">
        /// CreateSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSheetResponse
        /// </returns>
        public CreateSheetResponse CreateSheetWithOptions(string workbookId, CreateSheetRequest request, CreateSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSheet",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSheetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSheetRequest
        /// </param>
        /// <param name="headers">
        /// CreateSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSheetResponse
        /// </returns>
        public async Task<CreateSheetResponse> CreateSheetWithOptionsAsync(string workbookId, CreateSheetRequest request, CreateSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSheet",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSheetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSheetResponse
        /// </returns>
        public CreateSheetResponse CreateSheet(string workbookId, CreateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSheetHeaders headers = new CreateSheetHeaders();
            return CreateSheetWithOptions(workbookId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSheetResponse
        /// </returns>
        public async Task<CreateSheetResponse> CreateSheetAsync(string workbookId, CreateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSheetHeaders headers = new CreateSheetHeaders();
            return await CreateSheetWithOptionsAsync(workbookId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// CreateWorkspaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public CreateWorkspaceResponse CreateWorkspaceWithOptions(CreateWorkspaceRequest request, CreateWorkspaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// CreateWorkspaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public async Task<CreateWorkspaceResponse> CreateWorkspaceWithOptionsAsync(CreateWorkspaceRequest request, CreateWorkspaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkspaceHeaders headers = new CreateWorkspaceHeaders();
            return CreateWorkspaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public async Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkspaceHeaders headers = new CreateWorkspaceHeaders();
            return await CreateWorkspaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceDocRequest
        /// </param>
        /// <param name="headers">
        /// CreateWorkspaceDocHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceDocResponse
        /// </returns>
        public CreateWorkspaceDocResponse CreateWorkspaceDocWithOptions(string workspaceId, CreateWorkspaceDocRequest request, CreateWorkspaceDocHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["docType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentNodeId))
            {
                body["parentNodeId"] = request.ParentNodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["templateType"] = request.TemplateType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspaceDoc",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId + "/docs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceDocResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceDocRequest
        /// </param>
        /// <param name="headers">
        /// CreateWorkspaceDocHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceDocResponse
        /// </returns>
        public async Task<CreateWorkspaceDocResponse> CreateWorkspaceDocWithOptionsAsync(string workspaceId, CreateWorkspaceDocRequest request, CreateWorkspaceDocHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["docType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentNodeId))
            {
                body["parentNodeId"] = request.ParentNodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["templateType"] = request.TemplateType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspaceDoc",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId + "/docs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceDocResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceDocRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceDocResponse
        /// </returns>
        public CreateWorkspaceDocResponse CreateWorkspaceDoc(string workspaceId, CreateWorkspaceDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkspaceDocHeaders headers = new CreateWorkspaceDocHeaders();
            return CreateWorkspaceDocWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceDocRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceDocResponse
        /// </returns>
        public async Task<CreateWorkspaceDocResponse> CreateWorkspaceDocAsync(string workspaceId, CreateWorkspaceDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkspaceDocHeaders headers = new CreateWorkspaceDocHeaders();
            return await CreateWorkspaceDocWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除列</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteColumnsRequest
        /// </param>
        /// <param name="headers">
        /// DeleteColumnsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteColumnsResponse
        /// </returns>
        public DeleteColumnsResponse DeleteColumnsWithOptions(string workbookId, string sheetId, DeleteColumnsRequest request, DeleteColumnsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnCount))
            {
                body["columnCount"] = request.ColumnCount;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteColumns",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/deleteColumns",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteColumnsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除列</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteColumnsRequest
        /// </param>
        /// <param name="headers">
        /// DeleteColumnsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteColumnsResponse
        /// </returns>
        public async Task<DeleteColumnsResponse> DeleteColumnsWithOptionsAsync(string workbookId, string sheetId, DeleteColumnsRequest request, DeleteColumnsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnCount))
            {
                body["columnCount"] = request.ColumnCount;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteColumns",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/deleteColumns",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteColumnsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除列</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteColumnsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteColumnsResponse
        /// </returns>
        public DeleteColumnsResponse DeleteColumns(string workbookId, string sheetId, DeleteColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteColumnsHeaders headers = new DeleteColumnsHeaders();
            return DeleteColumnsWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除列</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteColumnsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteColumnsResponse
        /// </returns>
        public async Task<DeleteColumnsResponse> DeleteColumnsAsync(string workbookId, string sheetId, DeleteColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteColumnsHeaders headers = new DeleteColumnsHeaders();
            return await DeleteColumnsWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除下拉列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDropdownListsRequest
        /// </param>
        /// <param name="headers">
        /// DeleteDropdownListsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDropdownListsResponse
        /// </returns>
        public DeleteDropdownListsResponse DeleteDropdownListsWithOptions(string workbookId, string sheetId, string rangeAddress, DeleteDropdownListsRequest request, DeleteDropdownListsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDropdownLists",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/deleteDropdownLists",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDropdownListsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除下拉列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDropdownListsRequest
        /// </param>
        /// <param name="headers">
        /// DeleteDropdownListsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDropdownListsResponse
        /// </returns>
        public async Task<DeleteDropdownListsResponse> DeleteDropdownListsWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, DeleteDropdownListsRequest request, DeleteDropdownListsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDropdownLists",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/deleteDropdownLists",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDropdownListsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除下拉列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDropdownListsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDropdownListsResponse
        /// </returns>
        public DeleteDropdownListsResponse DeleteDropdownLists(string workbookId, string sheetId, string rangeAddress, DeleteDropdownListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDropdownListsHeaders headers = new DeleteDropdownListsHeaders();
            return DeleteDropdownListsWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除下拉列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDropdownListsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDropdownListsResponse
        /// </returns>
        public async Task<DeleteDropdownListsResponse> DeleteDropdownListsAsync(string workbookId, string sheetId, string rangeAddress, DeleteDropdownListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDropdownListsHeaders headers = new DeleteDropdownListsHeaders();
            return await DeleteDropdownListsWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除单元格锁定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRangeProtectionRequest
        /// </param>
        /// <param name="headers">
        /// DeleteRangeProtectionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRangeProtectionResponse
        /// </returns>
        public DeleteRangeProtectionResponse DeleteRangeProtectionWithOptions(string workbookId, string sheetId, string rangeAddress, string protectionId, DeleteRangeProtectionRequest request, DeleteRangeProtectionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRangeProtection",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/protections/" + protectionId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRangeProtectionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除单元格锁定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRangeProtectionRequest
        /// </param>
        /// <param name="headers">
        /// DeleteRangeProtectionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRangeProtectionResponse
        /// </returns>
        public async Task<DeleteRangeProtectionResponse> DeleteRangeProtectionWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, string protectionId, DeleteRangeProtectionRequest request, DeleteRangeProtectionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRangeProtection",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/protections/" + protectionId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRangeProtectionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除单元格锁定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRangeProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRangeProtectionResponse
        /// </returns>
        public DeleteRangeProtectionResponse DeleteRangeProtection(string workbookId, string sheetId, string rangeAddress, string protectionId, DeleteRangeProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRangeProtectionHeaders headers = new DeleteRangeProtectionHeaders();
            return DeleteRangeProtectionWithOptions(workbookId, sheetId, rangeAddress, protectionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除单元格锁定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRangeProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRangeProtectionResponse
        /// </returns>
        public async Task<DeleteRangeProtectionResponse> DeleteRangeProtectionAsync(string workbookId, string sheetId, string rangeAddress, string protectionId, DeleteRangeProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRangeProtectionHeaders headers = new DeleteRangeProtectionHeaders();
            return await DeleteRangeProtectionWithOptionsAsync(workbookId, sheetId, rangeAddress, protectionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRowsRequest
        /// </param>
        /// <param name="headers">
        /// DeleteRowsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRowsResponse
        /// </returns>
        public DeleteRowsResponse DeleteRowsWithOptions(string workbookId, string sheetId, DeleteRowsRequest request, DeleteRowsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                body["rowCount"] = request.RowCount;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRows",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/deleteRows",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRowsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRowsRequest
        /// </param>
        /// <param name="headers">
        /// DeleteRowsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRowsResponse
        /// </returns>
        public async Task<DeleteRowsResponse> DeleteRowsWithOptionsAsync(string workbookId, string sheetId, DeleteRowsRequest request, DeleteRowsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                body["rowCount"] = request.RowCount;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRows",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/deleteRows",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRowsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRowsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRowsResponse
        /// </returns>
        public DeleteRowsResponse DeleteRows(string workbookId, string sheetId, DeleteRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRowsHeaders headers = new DeleteRowsHeaders();
            return DeleteRowsWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRowsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRowsResponse
        /// </returns>
        public async Task<DeleteRowsResponse> DeleteRowsAsync(string workbookId, string sheetId, DeleteRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRowsHeaders headers = new DeleteRowsHeaders();
            return await DeleteRowsWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSheetRequest
        /// </param>
        /// <param name="headers">
        /// DeleteSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSheetResponse
        /// </returns>
        public DeleteSheetResponse DeleteSheetWithOptions(string workbookId, string sheetId, DeleteSheetRequest request, DeleteSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSheet",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSheetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSheetRequest
        /// </param>
        /// <param name="headers">
        /// DeleteSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSheetResponse
        /// </returns>
        public async Task<DeleteSheetResponse> DeleteSheetWithOptionsAsync(string workbookId, string sheetId, DeleteSheetRequest request, DeleteSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSheet",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSheetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSheetResponse
        /// </returns>
        public DeleteSheetResponse DeleteSheet(string workbookId, string sheetId, DeleteSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSheetHeaders headers = new DeleteSheetHeaders();
            return DeleteSheetWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSheetResponse
        /// </returns>
        public async Task<DeleteSheetResponse> DeleteSheetAsync(string workbookId, string sheetId, DeleteSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSheetHeaders headers = new DeleteSheetHeaders();
            return await DeleteSheetWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceDocRequest
        /// </param>
        /// <param name="headers">
        /// DeleteWorkspaceDocHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceDocResponse
        /// </returns>
        public DeleteWorkspaceDocResponse DeleteWorkspaceDocWithOptions(string workspaceId, string nodeId, DeleteWorkspaceDocRequest request, DeleteWorkspaceDocHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspaceDoc",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteWorkspaceDocResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceDocRequest
        /// </param>
        /// <param name="headers">
        /// DeleteWorkspaceDocHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceDocResponse
        /// </returns>
        public async Task<DeleteWorkspaceDocResponse> DeleteWorkspaceDocWithOptionsAsync(string workspaceId, string nodeId, DeleteWorkspaceDocRequest request, DeleteWorkspaceDocHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspaceDoc",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteWorkspaceDocResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceDocRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceDocResponse
        /// </returns>
        public DeleteWorkspaceDocResponse DeleteWorkspaceDoc(string workspaceId, string nodeId, DeleteWorkspaceDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceDocHeaders headers = new DeleteWorkspaceDocHeaders();
            return DeleteWorkspaceDocWithOptions(workspaceId, nodeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceDocRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceDocResponse
        /// </returns>
        public async Task<DeleteWorkspaceDocResponse> DeleteWorkspaceDocAsync(string workspaceId, string nodeId, DeleteWorkspaceDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceDocHeaders headers = new DeleteWorkspaceDocHeaders();
            return await DeleteWorkspaceDocWithOptionsAsync(workspaceId, nodeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库文档成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceDocMembersRequest
        /// </param>
        /// <param name="headers">
        /// DeleteWorkspaceDocMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceDocMembersResponse
        /// </returns>
        public DeleteWorkspaceDocMembersResponse DeleteWorkspaceDocMembersWithOptions(string workspaceId, string nodeId, DeleteWorkspaceDocMembersRequest request, DeleteWorkspaceDocMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspaceDocMembers",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + "/members/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteWorkspaceDocMembersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库文档成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceDocMembersRequest
        /// </param>
        /// <param name="headers">
        /// DeleteWorkspaceDocMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceDocMembersResponse
        /// </returns>
        public async Task<DeleteWorkspaceDocMembersResponse> DeleteWorkspaceDocMembersWithOptionsAsync(string workspaceId, string nodeId, DeleteWorkspaceDocMembersRequest request, DeleteWorkspaceDocMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspaceDocMembers",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + "/members/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteWorkspaceDocMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库文档成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceDocMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceDocMembersResponse
        /// </returns>
        public DeleteWorkspaceDocMembersResponse DeleteWorkspaceDocMembers(string workspaceId, string nodeId, DeleteWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceDocMembersHeaders headers = new DeleteWorkspaceDocMembersHeaders();
            return DeleteWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库文档成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceDocMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceDocMembersResponse
        /// </returns>
        public async Task<DeleteWorkspaceDocMembersResponse> DeleteWorkspaceDocMembersAsync(string workspaceId, string nodeId, DeleteWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceDocMembersHeaders headers = new DeleteWorkspaceDocMembersHeaders();
            return await DeleteWorkspaceDocMembersWithOptionsAsync(workspaceId, nodeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceMembersRequest
        /// </param>
        /// <param name="headers">
        /// DeleteWorkspaceMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceMembersResponse
        /// </returns>
        public DeleteWorkspaceMembersResponse DeleteWorkspaceMembersWithOptions(string workspaceId, DeleteWorkspaceMembersRequest request, DeleteWorkspaceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspaceMembers",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId + "/members/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteWorkspaceMembersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceMembersRequest
        /// </param>
        /// <param name="headers">
        /// DeleteWorkspaceMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceMembersResponse
        /// </returns>
        public async Task<DeleteWorkspaceMembersResponse> DeleteWorkspaceMembersWithOptionsAsync(string workspaceId, DeleteWorkspaceMembersRequest request, DeleteWorkspaceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspaceMembers",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId + "/members/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteWorkspaceMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceMembersResponse
        /// </returns>
        public DeleteWorkspaceMembersResponse DeleteWorkspaceMembers(string workspaceId, DeleteWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceMembersHeaders headers = new DeleteWorkspaceMembersHeaders();
            return DeleteWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceMembersResponse
        /// </returns>
        public async Task<DeleteWorkspaceMembersResponse> DeleteWorkspaceMembersAsync(string workspaceId, DeleteWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceMembersHeaders headers = new DeleteWorkspaceMembersHeaders();
            return await DeleteWorkspaceMembersWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>追加指定段落元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocAppendParagraphRequest
        /// </param>
        /// <param name="headers">
        /// DocAppendParagraphHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocAppendParagraphResponse
        /// </returns>
        public DocAppendParagraphResponse DocAppendParagraphWithOptions(string docKey, string blockId, DocAppendParagraphRequest request, DocAppendParagraphHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElementType))
            {
                body["elementType"] = request.ElementType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                body["properties"] = request.Properties;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocAppendParagraph",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + docKey + "/blocks/" + blockId + "/paragraph/appendElement",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocAppendParagraphResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>追加指定段落元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocAppendParagraphRequest
        /// </param>
        /// <param name="headers">
        /// DocAppendParagraphHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocAppendParagraphResponse
        /// </returns>
        public async Task<DocAppendParagraphResponse> DocAppendParagraphWithOptionsAsync(string docKey, string blockId, DocAppendParagraphRequest request, DocAppendParagraphHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElementType))
            {
                body["elementType"] = request.ElementType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                body["properties"] = request.Properties;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocAppendParagraph",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + docKey + "/blocks/" + blockId + "/paragraph/appendElement",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocAppendParagraphResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>追加指定段落元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocAppendParagraphRequest
        /// </param>
        /// 
        /// <returns>
        /// DocAppendParagraphResponse
        /// </returns>
        public DocAppendParagraphResponse DocAppendParagraph(string docKey, string blockId, DocAppendParagraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocAppendParagraphHeaders headers = new DocAppendParagraphHeaders();
            return DocAppendParagraphWithOptions(docKey, blockId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>追加指定段落元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocAppendParagraphRequest
        /// </param>
        /// 
        /// <returns>
        /// DocAppendParagraphResponse
        /// </returns>
        public async Task<DocAppendParagraphResponse> DocAppendParagraphAsync(string docKey, string blockId, DocAppendParagraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocAppendParagraphHeaders headers = new DocAppendParagraphHeaders();
            return await DocAppendParagraphWithOptionsAsync(docKey, blockId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在段落后追加文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocAppendTextRequest
        /// </param>
        /// <param name="headers">
        /// DocAppendTextHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocAppendTextResponse
        /// </returns>
        public DocAppendTextResponse DocAppendTextWithOptions(string docKey, string blockId, DocAppendTextRequest request, DocAppendTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocAppendText",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + docKey + "/blocks/" + blockId + "/paragraph/appendText",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocAppendTextResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在段落后追加文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocAppendTextRequest
        /// </param>
        /// <param name="headers">
        /// DocAppendTextHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocAppendTextResponse
        /// </returns>
        public async Task<DocAppendTextResponse> DocAppendTextWithOptionsAsync(string docKey, string blockId, DocAppendTextRequest request, DocAppendTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocAppendText",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + docKey + "/blocks/" + blockId + "/paragraph/appendText",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocAppendTextResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在段落后追加文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocAppendTextRequest
        /// </param>
        /// 
        /// <returns>
        /// DocAppendTextResponse
        /// </returns>
        public DocAppendTextResponse DocAppendText(string docKey, string blockId, DocAppendTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocAppendTextHeaders headers = new DocAppendTextHeaders();
            return DocAppendTextWithOptions(docKey, blockId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在段落后追加文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocAppendTextRequest
        /// </param>
        /// 
        /// <returns>
        /// DocAppendTextResponse
        /// </returns>
        public async Task<DocAppendTextResponse> DocAppendTextAsync(string docKey, string blockId, DocAppendTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocAppendTextHeaders headers = new DocAppendTextHeaders();
            return await DocAppendTextWithOptionsAsync(docKey, blockId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档中的块元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocBlocksModifyRequest
        /// </param>
        /// <param name="headers">
        /// DocBlocksModifyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocBlocksModifyResponse
        /// </returns>
        public DocBlocksModifyResponse DocBlocksModifyWithOptions(string documentId, string blockId, DocBlocksModifyRequest request, DocBlocksModifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Element))
            {
                body["element"] = request.Element;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocBlocksModify",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + documentId + "/blocks/" + blockId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocBlocksModifyResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档中的块元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocBlocksModifyRequest
        /// </param>
        /// <param name="headers">
        /// DocBlocksModifyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocBlocksModifyResponse
        /// </returns>
        public async Task<DocBlocksModifyResponse> DocBlocksModifyWithOptionsAsync(string documentId, string blockId, DocBlocksModifyRequest request, DocBlocksModifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Element))
            {
                body["element"] = request.Element;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocBlocksModify",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + documentId + "/blocks/" + blockId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocBlocksModifyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档中的块元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocBlocksModifyRequest
        /// </param>
        /// 
        /// <returns>
        /// DocBlocksModifyResponse
        /// </returns>
        public DocBlocksModifyResponse DocBlocksModify(string documentId, string blockId, DocBlocksModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocBlocksModifyHeaders headers = new DocBlocksModifyHeaders();
            return DocBlocksModifyWithOptions(documentId, blockId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档中的块元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocBlocksModifyRequest
        /// </param>
        /// 
        /// <returns>
        /// DocBlocksModifyResponse
        /// </returns>
        public async Task<DocBlocksModifyResponse> DocBlocksModifyAsync(string documentId, string blockId, DocBlocksModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocBlocksModifyHeaders headers = new DocBlocksModifyHeaders();
            return await DocBlocksModifyWithOptionsAsync(documentId, blockId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定Block元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocBlocksQueryRequest
        /// </param>
        /// <param name="headers">
        /// DocBlocksQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocBlocksQueryResponse
        /// </returns>
        public DocBlocksQueryResponse DocBlocksQueryWithOptions(string docKey, DocBlocksQueryRequest request, DocBlocksQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockType))
            {
                query["blockType"] = request.BlockType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndIndex))
            {
                query["endIndex"] = request.EndIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartIndex))
            {
                query["startIndex"] = request.StartIndex;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocBlocksQuery",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + docKey + "/blocks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocBlocksQueryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定Block元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocBlocksQueryRequest
        /// </param>
        /// <param name="headers">
        /// DocBlocksQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocBlocksQueryResponse
        /// </returns>
        public async Task<DocBlocksQueryResponse> DocBlocksQueryWithOptionsAsync(string docKey, DocBlocksQueryRequest request, DocBlocksQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockType))
            {
                query["blockType"] = request.BlockType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndIndex))
            {
                query["endIndex"] = request.EndIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartIndex))
            {
                query["startIndex"] = request.StartIndex;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocBlocksQuery",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + docKey + "/blocks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocBlocksQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定Block元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocBlocksQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// DocBlocksQueryResponse
        /// </returns>
        public DocBlocksQueryResponse DocBlocksQuery(string docKey, DocBlocksQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocBlocksQueryHeaders headers = new DocBlocksQueryHeaders();
            return DocBlocksQueryWithOptions(docKey, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定Block元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocBlocksQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// DocBlocksQueryResponse
        /// </returns>
        public async Task<DocBlocksQueryResponse> DocBlocksQueryAsync(string docKey, DocBlocksQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocBlocksQueryHeaders headers = new DocBlocksQueryHeaders();
            return await DocBlocksQueryWithOptionsAsync(docKey, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定位置的 Block</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocDeleteBlockRequest
        /// </param>
        /// <param name="headers">
        /// DocDeleteBlockHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocDeleteBlockResponse
        /// </returns>
        public DocDeleteBlockResponse DocDeleteBlockWithOptions(string docKey, string blockId, DocDeleteBlockRequest request, DocDeleteBlockHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocDeleteBlock",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + docKey + "/blocks/" + blockId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocDeleteBlockResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定位置的 Block</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocDeleteBlockRequest
        /// </param>
        /// <param name="headers">
        /// DocDeleteBlockHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocDeleteBlockResponse
        /// </returns>
        public async Task<DocDeleteBlockResponse> DocDeleteBlockWithOptionsAsync(string docKey, string blockId, DocDeleteBlockRequest request, DocDeleteBlockHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocDeleteBlock",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + docKey + "/blocks/" + blockId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocDeleteBlockResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定位置的 Block</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocDeleteBlockRequest
        /// </param>
        /// 
        /// <returns>
        /// DocDeleteBlockResponse
        /// </returns>
        public DocDeleteBlockResponse DocDeleteBlock(string docKey, string blockId, DocDeleteBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocDeleteBlockHeaders headers = new DocDeleteBlockHeaders();
            return DocDeleteBlockWithOptions(docKey, blockId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定位置的 Block</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocDeleteBlockRequest
        /// </param>
        /// 
        /// <returns>
        /// DocDeleteBlockResponse
        /// </returns>
        public async Task<DocDeleteBlockResponse> DocDeleteBlockAsync(string docKey, string blockId, DocDeleteBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocDeleteBlockHeaders headers = new DocDeleteBlockHeaders();
            return await DocDeleteBlockWithOptionsAsync(docKey, blockId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据传入的文档ID将文档导出为截图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocExportSnapshotRequest
        /// </param>
        /// <param name="headers">
        /// DocExportSnapshotHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocExportSnapshotResponse
        /// </returns>
        public DocExportSnapshotResponse DocExportSnapshotWithOptions(string documentId, DocExportSnapshotRequest request, DocExportSnapshotHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocExportSnapshot",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + documentId + "/export/snapshot",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocExportSnapshotResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据传入的文档ID将文档导出为截图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocExportSnapshotRequest
        /// </param>
        /// <param name="headers">
        /// DocExportSnapshotHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocExportSnapshotResponse
        /// </returns>
        public async Task<DocExportSnapshotResponse> DocExportSnapshotWithOptionsAsync(string documentId, DocExportSnapshotRequest request, DocExportSnapshotHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocExportSnapshot",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + documentId + "/export/snapshot",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocExportSnapshotResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据传入的文档ID将文档导出为截图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocExportSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// DocExportSnapshotResponse
        /// </returns>
        public DocExportSnapshotResponse DocExportSnapshot(string documentId, DocExportSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocExportSnapshotHeaders headers = new DocExportSnapshotHeaders();
            return DocExportSnapshotWithOptions(documentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据传入的文档ID将文档导出为截图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocExportSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// DocExportSnapshotResponse
        /// </returns>
        public async Task<DocExportSnapshotResponse> DocExportSnapshotAsync(string documentId, DocExportSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocExportSnapshotHeaders headers = new DocExportSnapshotHeaders();
            return await DocExportSnapshotWithOptionsAsync(documentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插入指定Block元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocInsertBlocksRequest
        /// </param>
        /// <param name="headers">
        /// DocInsertBlocksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocInsertBlocksResponse
        /// </returns>
        public DocInsertBlocksResponse DocInsertBlocksWithOptions(string docKey, DocInsertBlocksRequest request, DocInsertBlocksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockId))
            {
                body["blockId"] = request.BlockId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Element))
            {
                body["element"] = request.Element;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Index))
            {
                body["index"] = request.Index;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Where))
            {
                body["where"] = request.Where;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocInsertBlocks",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + docKey + "/blocks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocInsertBlocksResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插入指定Block元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocInsertBlocksRequest
        /// </param>
        /// <param name="headers">
        /// DocInsertBlocksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocInsertBlocksResponse
        /// </returns>
        public async Task<DocInsertBlocksResponse> DocInsertBlocksWithOptionsAsync(string docKey, DocInsertBlocksRequest request, DocInsertBlocksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockId))
            {
                body["blockId"] = request.BlockId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Element))
            {
                body["element"] = request.Element;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Index))
            {
                body["index"] = request.Index;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Where))
            {
                body["where"] = request.Where;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocInsertBlocks",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + docKey + "/blocks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocInsertBlocksResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插入指定Block元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocInsertBlocksRequest
        /// </param>
        /// 
        /// <returns>
        /// DocInsertBlocksResponse
        /// </returns>
        public DocInsertBlocksResponse DocInsertBlocks(string docKey, DocInsertBlocksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocInsertBlocksHeaders headers = new DocInsertBlocksHeaders();
            return DocInsertBlocksWithOptions(docKey, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插入指定Block元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocInsertBlocksRequest
        /// </param>
        /// 
        /// <returns>
        /// DocInsertBlocksResponse
        /// </returns>
        public async Task<DocInsertBlocksResponse> DocInsertBlocksAsync(string docKey, DocInsertBlocksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocInsertBlocksHeaders headers = new DocInsertBlocksHeaders();
            return await DocInsertBlocksWithOptionsAsync(docKey, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据传入参数更新文档插槽</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocSlotsModifyRequest
        /// </param>
        /// <param name="headers">
        /// DocSlotsModifyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocSlotsModifyResponse
        /// </returns>
        public DocSlotsModifyResponse DocSlotsModifyWithOptions(string documentId, DocSlotsModifyRequest request, DocSlotsModifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["request"] = request.Request;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocSlotsModify",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + documentId + "/slots",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocSlotsModifyResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据传入参数更新文档插槽</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocSlotsModifyRequest
        /// </param>
        /// <param name="headers">
        /// DocSlotsModifyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocSlotsModifyResponse
        /// </returns>
        public async Task<DocSlotsModifyResponse> DocSlotsModifyWithOptionsAsync(string documentId, DocSlotsModifyRequest request, DocSlotsModifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["request"] = request.Request;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocSlotsModify",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + documentId + "/slots",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocSlotsModifyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据传入参数更新文档插槽</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocSlotsModifyRequest
        /// </param>
        /// 
        /// <returns>
        /// DocSlotsModifyResponse
        /// </returns>
        public DocSlotsModifyResponse DocSlotsModify(string documentId, DocSlotsModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocSlotsModifyHeaders headers = new DocSlotsModifyHeaders();
            return DocSlotsModifyWithOptions(documentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据传入参数更新文档插槽</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocSlotsModifyRequest
        /// </param>
        /// 
        /// <returns>
        /// DocSlotsModifyResponse
        /// </returns>
        public async Task<DocSlotsModifyResponse> DocSlotsModifyAsync(string documentId, DocSlotsModifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocSlotsModifyHeaders headers = new DocSlotsModifyHeaders();
            return await DocSlotsModifyWithOptionsAsync(documentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据传入参数查询文档中所有的插槽</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocSlotsQueryRequest
        /// </param>
        /// <param name="headers">
        /// DocSlotsQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocSlotsQueryResponse
        /// </returns>
        public DocSlotsQueryResponse DocSlotsQueryWithOptions(string documentId, DocSlotsQueryRequest request, DocSlotsQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocSlotsQuery",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + documentId + "/slots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocSlotsQueryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据传入参数查询文档中所有的插槽</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocSlotsQueryRequest
        /// </param>
        /// <param name="headers">
        /// DocSlotsQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocSlotsQueryResponse
        /// </returns>
        public async Task<DocSlotsQueryResponse> DocSlotsQueryWithOptionsAsync(string documentId, DocSlotsQueryRequest request, DocSlotsQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocSlotsQuery",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + documentId + "/slots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocSlotsQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据传入参数查询文档中所有的插槽</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocSlotsQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// DocSlotsQueryResponse
        /// </returns>
        public DocSlotsQueryResponse DocSlotsQuery(string documentId, DocSlotsQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocSlotsQueryHeaders headers = new DocSlotsQueryHeaders();
            return DocSlotsQueryWithOptions(documentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据传入参数查询文档中所有的插槽</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocSlotsQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// DocSlotsQueryResponse
        /// </returns>
        public async Task<DocSlotsQueryResponse> DocSlotsQueryAsync(string documentId, DocSlotsQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocSlotsQueryHeaders headers = new DocSlotsQueryHeaders();
            return await DocSlotsQueryWithOptionsAsync(documentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>覆写全文</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocUpdateContentRequest
        /// </param>
        /// <param name="headers">
        /// DocUpdateContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocUpdateContentResponse
        /// </returns>
        public DocUpdateContentResponse DocUpdateContentWithOptions(string docKey, DocUpdateContentRequest request, DocUpdateContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["dataType"] = request.DataType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocUpdateContent",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + docKey + "/overwriteContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocUpdateContentResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>覆写全文</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocUpdateContentRequest
        /// </param>
        /// <param name="headers">
        /// DocUpdateContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocUpdateContentResponse
        /// </returns>
        public async Task<DocUpdateContentResponse> DocUpdateContentWithOptionsAsync(string docKey, DocUpdateContentRequest request, DocUpdateContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["dataType"] = request.DataType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocUpdateContent",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + docKey + "/overwriteContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocUpdateContentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>覆写全文</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocUpdateContentRequest
        /// </param>
        /// 
        /// <returns>
        /// DocUpdateContentResponse
        /// </returns>
        public DocUpdateContentResponse DocUpdateContent(string docKey, DocUpdateContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocUpdateContentHeaders headers = new DocUpdateContentHeaders();
            return DocUpdateContentWithOptions(docKey, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>覆写全文</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocUpdateContentRequest
        /// </param>
        /// 
        /// <returns>
        /// DocUpdateContentResponse
        /// </returns>
        public async Task<DocUpdateContentResponse> DocUpdateContentAsync(string docKey, DocUpdateContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocUpdateContentHeaders headers = new DocUpdateContentHeaders();
            return await DocUpdateContentWithOptionsAsync(docKey, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllSheetsRequest
        /// </param>
        /// <param name="headers">
        /// GetAllSheetsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllSheetsResponse
        /// </returns>
        public GetAllSheetsResponse GetAllSheetsWithOptions(string workbookId, GetAllSheetsRequest request, GetAllSheetsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAllSheets",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllSheetsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllSheetsRequest
        /// </param>
        /// <param name="headers">
        /// GetAllSheetsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllSheetsResponse
        /// </returns>
        public async Task<GetAllSheetsResponse> GetAllSheetsWithOptionsAsync(string workbookId, GetAllSheetsRequest request, GetAllSheetsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAllSheets",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllSheetsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllSheetsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAllSheetsResponse
        /// </returns>
        public GetAllSheetsResponse GetAllSheets(string workbookId, GetAllSheetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllSheetsHeaders headers = new GetAllSheetsHeaders();
            return GetAllSheetsWithOptions(workbookId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllSheetsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAllSheetsResponse
        /// </returns>
        public async Task<GetAllSheetsResponse> GetAllSheetsAsync(string workbookId, GetAllSheetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllSheetsHeaders headers = new GetAllSheetsHeaders();
            return await GetAllSheetsWithOptionsAsync(workbookId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取开发者元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeveloperMetadataRequest
        /// </param>
        /// <param name="headers">
        /// GetDeveloperMetadataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeveloperMetadataResponse
        /// </returns>
        public GetDeveloperMetadataResponse GetDeveloperMetadataWithOptions(string workbookId, string developerMetadataId, GetDeveloperMetadataRequest request, GetDeveloperMetadataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeveloperMetadata",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/developerMetadatas/" + developerMetadataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeveloperMetadataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取开发者元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeveloperMetadataRequest
        /// </param>
        /// <param name="headers">
        /// GetDeveloperMetadataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeveloperMetadataResponse
        /// </returns>
        public async Task<GetDeveloperMetadataResponse> GetDeveloperMetadataWithOptionsAsync(string workbookId, string developerMetadataId, GetDeveloperMetadataRequest request, GetDeveloperMetadataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeveloperMetadata",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/developerMetadatas/" + developerMetadataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeveloperMetadataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取开发者元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeveloperMetadataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeveloperMetadataResponse
        /// </returns>
        public GetDeveloperMetadataResponse GetDeveloperMetadata(string workbookId, string developerMetadataId, GetDeveloperMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeveloperMetadataHeaders headers = new GetDeveloperMetadataHeaders();
            return GetDeveloperMetadataWithOptions(workbookId, developerMetadataId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取开发者元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeveloperMetadataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeveloperMetadataResponse
        /// </returns>
        public async Task<GetDeveloperMetadataResponse> GetDeveloperMetadataAsync(string workbookId, string developerMetadataId, GetDeveloperMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeveloperMetadataHeaders headers = new GetDeveloperMetadataHeaders();
            return await GetDeveloperMetadataWithOptionsAsync(workbookId, developerMetadataId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档标签信息查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImportDocumentMarkRequest
        /// </param>
        /// <param name="headers">
        /// GetImportDocumentMarkHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImportDocumentMarkResponse
        /// </returns>
        public GetImportDocumentMarkResponse GetImportDocumentMarkWithOptions(string docId, GetImportDocumentMarkRequest request, GetImportDocumentMarkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImportDocumentMark",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/docs/" + docId + "/marks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImportDocumentMarkResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档标签信息查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImportDocumentMarkRequest
        /// </param>
        /// <param name="headers">
        /// GetImportDocumentMarkHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImportDocumentMarkResponse
        /// </returns>
        public async Task<GetImportDocumentMarkResponse> GetImportDocumentMarkWithOptionsAsync(string docId, GetImportDocumentMarkRequest request, GetImportDocumentMarkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImportDocumentMark",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/docs/" + docId + "/marks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImportDocumentMarkResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档标签信息查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImportDocumentMarkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImportDocumentMarkResponse
        /// </returns>
        public GetImportDocumentMarkResponse GetImportDocumentMark(string docId, GetImportDocumentMarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetImportDocumentMarkHeaders headers = new GetImportDocumentMarkHeaders();
            return GetImportDocumentMarkWithOptions(docId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档标签信息查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImportDocumentMarkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImportDocumentMarkResponse
        /// </returns>
        public async Task<GetImportDocumentMarkResponse> GetImportDocumentMarkAsync(string docId, GetImportDocumentMarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetImportDocumentMarkHeaders headers = new GetImportDocumentMarkHeaders();
            return await GetImportDocumentMarkWithOptionsAsync(docId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单元格区域</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRangeRequest
        /// </param>
        /// <param name="headers">
        /// GetRangeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRangeResponse
        /// </returns>
        public GetRangeResponse GetRangeWithOptions(string workbookId, string sheetId, string rangeAddress, GetRangeRequest request, GetRangeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Select))
            {
                query["select"] = request.Select;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRange",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRangeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单元格区域</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRangeRequest
        /// </param>
        /// <param name="headers">
        /// GetRangeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRangeResponse
        /// </returns>
        public async Task<GetRangeResponse> GetRangeWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, GetRangeRequest request, GetRangeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Select))
            {
                query["select"] = request.Select;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRange",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRangeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单元格区域</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRangeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRangeResponse
        /// </returns>
        public GetRangeResponse GetRange(string workbookId, string sheetId, string rangeAddress, GetRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRangeHeaders headers = new GetRangeHeaders();
            return GetRangeWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单元格区域</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRangeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRangeResponse
        /// </returns>
        public async Task<GetRangeResponse> GetRangeAsync(string workbookId, string sheetId, string rangeAddress, GetRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRangeHeaders headers = new GetRangeHeaders();
            return await GetRangeWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近编辑文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecentEditDocsRequest
        /// </param>
        /// <param name="headers">
        /// GetRecentEditDocsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecentEditDocsResponse
        /// </returns>
        public GetRecentEditDocsResponse GetRecentEditDocsWithOptions(GetRecentEditDocsRequest request, GetRecentEditDocsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRecentEditDocs",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/docs/recentEditDocs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecentEditDocsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近编辑文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecentEditDocsRequest
        /// </param>
        /// <param name="headers">
        /// GetRecentEditDocsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecentEditDocsResponse
        /// </returns>
        public async Task<GetRecentEditDocsResponse> GetRecentEditDocsWithOptionsAsync(GetRecentEditDocsRequest request, GetRecentEditDocsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRecentEditDocs",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/docs/recentEditDocs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecentEditDocsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近编辑文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecentEditDocsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecentEditDocsResponse
        /// </returns>
        public GetRecentEditDocsResponse GetRecentEditDocs(GetRecentEditDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecentEditDocsHeaders headers = new GetRecentEditDocsHeaders();
            return GetRecentEditDocsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近编辑文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecentEditDocsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecentEditDocsResponse
        /// </returns>
        public async Task<GetRecentEditDocsResponse> GetRecentEditDocsAsync(GetRecentEditDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecentEditDocsHeaders headers = new GetRecentEditDocsHeaders();
            return await GetRecentEditDocsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近打开文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecentOpenDocsRequest
        /// </param>
        /// <param name="headers">
        /// GetRecentOpenDocsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecentOpenDocsResponse
        /// </returns>
        public GetRecentOpenDocsResponse GetRecentOpenDocsWithOptions(GetRecentOpenDocsRequest request, GetRecentOpenDocsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRecentOpenDocs",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/docs/recentOpenDocs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecentOpenDocsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近打开文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecentOpenDocsRequest
        /// </param>
        /// <param name="headers">
        /// GetRecentOpenDocsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecentOpenDocsResponse
        /// </returns>
        public async Task<GetRecentOpenDocsResponse> GetRecentOpenDocsWithOptionsAsync(GetRecentOpenDocsRequest request, GetRecentOpenDocsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRecentOpenDocs",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/docs/recentOpenDocs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecentOpenDocsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近打开文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecentOpenDocsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecentOpenDocsResponse
        /// </returns>
        public GetRecentOpenDocsResponse GetRecentOpenDocs(GetRecentOpenDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecentOpenDocsHeaders headers = new GetRecentOpenDocsHeaders();
            return GetRecentOpenDocsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近打开文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecentOpenDocsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecentOpenDocsResponse
        /// </returns>
        public async Task<GetRecentOpenDocsResponse> GetRecentOpenDocsAsync(GetRecentOpenDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecentOpenDocsHeaders headers = new GetRecentOpenDocsHeaders();
            return await GetRecentOpenDocsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户有权限的知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelatedWorkspacesRequest
        /// </param>
        /// <param name="headers">
        /// GetRelatedWorkspacesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRelatedWorkspacesResponse
        /// </returns>
        public GetRelatedWorkspacesResponse GetRelatedWorkspacesWithOptions(GetRelatedWorkspacesRequest request, GetRelatedWorkspacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeRecent))
            {
                query["includeRecent"] = request.IncludeRecent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRelatedWorkspaces",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRelatedWorkspacesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户有权限的知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelatedWorkspacesRequest
        /// </param>
        /// <param name="headers">
        /// GetRelatedWorkspacesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRelatedWorkspacesResponse
        /// </returns>
        public async Task<GetRelatedWorkspacesResponse> GetRelatedWorkspacesWithOptionsAsync(GetRelatedWorkspacesRequest request, GetRelatedWorkspacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeRecent))
            {
                query["includeRecent"] = request.IncludeRecent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRelatedWorkspaces",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRelatedWorkspacesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户有权限的知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelatedWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRelatedWorkspacesResponse
        /// </returns>
        public GetRelatedWorkspacesResponse GetRelatedWorkspaces(GetRelatedWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRelatedWorkspacesHeaders headers = new GetRelatedWorkspacesHeaders();
            return GetRelatedWorkspacesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户有权限的知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelatedWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRelatedWorkspacesResponse
        /// </returns>
        public async Task<GetRelatedWorkspacesResponse> GetRelatedWorkspacesAsync(GetRelatedWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRelatedWorkspacesHeaders headers = new GetRelatedWorkspacesHeaders();
            return await GetRelatedWorkspacesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取上传信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceUploadInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetResourceUploadInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceUploadInfoResponse
        /// </returns>
        public GetResourceUploadInfoResponse GetResourceUploadInfoWithOptions(string docId, GetResourceUploadInfoRequest request, GetResourceUploadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                body["mediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                body["resourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceUploadInfo",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/docs/resources/" + docId + "/uploadInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceUploadInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取上传信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceUploadInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetResourceUploadInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceUploadInfoResponse
        /// </returns>
        public async Task<GetResourceUploadInfoResponse> GetResourceUploadInfoWithOptionsAsync(string docId, GetResourceUploadInfoRequest request, GetResourceUploadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                body["mediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                body["resourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceUploadInfo",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/docs/resources/" + docId + "/uploadInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceUploadInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取上传信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceUploadInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceUploadInfoResponse
        /// </returns>
        public GetResourceUploadInfoResponse GetResourceUploadInfo(string docId, GetResourceUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResourceUploadInfoHeaders headers = new GetResourceUploadInfoHeaders();
            return GetResourceUploadInfoWithOptions(docId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取上传信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceUploadInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceUploadInfoResponse
        /// </returns>
        public async Task<GetResourceUploadInfoResponse> GetResourceUploadInfoAsync(string docId, GetResourceUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResourceUploadInfoHeaders headers = new GetResourceUploadInfoHeaders();
            return await GetResourceUploadInfoWithOptionsAsync(docId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSheetRequest
        /// </param>
        /// <param name="headers">
        /// GetSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSheetResponse
        /// </returns>
        public GetSheetResponse GetSheetWithOptions(string workbookId, string sheetId, GetSheetRequest request, GetSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSheet",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSheetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSheetRequest
        /// </param>
        /// <param name="headers">
        /// GetSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSheetResponse
        /// </returns>
        public async Task<GetSheetResponse> GetSheetWithOptionsAsync(string workbookId, string sheetId, GetSheetRequest request, GetSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSheet",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSheetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSheetResponse
        /// </returns>
        public GetSheetResponse GetSheet(string workbookId, string sheetId, GetSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSheetHeaders headers = new GetSheetHeaders();
            return GetSheetWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSheetResponse
        /// </returns>
        public async Task<GetSheetResponse> GetSheetAsync(string workbookId, string sheetId, GetSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSheetHeaders headers = new GetSheetHeaders();
            return await GetSheetWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateByIdRequest
        /// </param>
        /// <param name="headers">
        /// GetTemplateByIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateByIdResponse
        /// </returns>
        public GetTemplateByIdResponse GetTemplateByIdWithOptions(string templateId, GetTemplateByIdRequest request, GetTemplateByIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Belong))
            {
                query["belong"] = request.Belong;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateById",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/templates/" + templateId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateByIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateByIdRequest
        /// </param>
        /// <param name="headers">
        /// GetTemplateByIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateByIdResponse
        /// </returns>
        public async Task<GetTemplateByIdResponse> GetTemplateByIdWithOptionsAsync(string templateId, GetTemplateByIdRequest request, GetTemplateByIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Belong))
            {
                query["belong"] = request.Belong;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateById",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/templates/" + templateId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateByIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateByIdResponse
        /// </returns>
        public GetTemplateByIdResponse GetTemplateById(string templateId, GetTemplateByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTemplateByIdHeaders headers = new GetTemplateByIdHeaders();
            return GetTemplateByIdWithOptions(templateId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateByIdResponse
        /// </returns>
        public async Task<GetTemplateByIdResponse> GetTemplateByIdAsync(string templateId, GetTemplateByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTemplateByIdHeaders headers = new GetTemplateByIdHeaders();
            return await GetTemplateByIdWithOptionsAsync(templateId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetWorkspaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public GetWorkspaceResponse GetWorkspaceWithOptions(string workspaceId, GetWorkspaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetWorkspaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public async Task<GetWorkspaceResponse> GetWorkspaceWithOptionsAsync(string workspaceId, GetWorkspaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public GetWorkspaceResponse GetWorkspace(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspaceHeaders headers = new GetWorkspaceHeaders();
            return GetWorkspaceWithOptions(workspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public async Task<GetWorkspaceResponse> GetWorkspaceAsync(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspaceHeaders headers = new GetWorkspaceHeaders();
            return await GetWorkspaceWithOptionsAsync(workspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkspaceNodeRequest
        /// </param>
        /// <param name="headers">
        /// GetWorkspaceNodeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceNodeResponse
        /// </returns>
        public GetWorkspaceNodeResponse GetWorkspaceNodeWithOptions(string workspaceId, string nodeId, GetWorkspaceNodeRequest request, GetWorkspaceNodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspaceNode",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceNodeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkspaceNodeRequest
        /// </param>
        /// <param name="headers">
        /// GetWorkspaceNodeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceNodeResponse
        /// </returns>
        public async Task<GetWorkspaceNodeResponse> GetWorkspaceNodeWithOptionsAsync(string workspaceId, string nodeId, GetWorkspaceNodeRequest request, GetWorkspaceNodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspaceNode",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceNodeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkspaceNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceNodeResponse
        /// </returns>
        public GetWorkspaceNodeResponse GetWorkspaceNode(string workspaceId, string nodeId, GetWorkspaceNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspaceNodeHeaders headers = new GetWorkspaceNodeHeaders();
            return GetWorkspaceNodeWithOptions(workspaceId, nodeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkspaceNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceNodeResponse
        /// </returns>
        public async Task<GetWorkspaceNodeResponse> GetWorkspaceNodeAsync(string workspaceId, string nodeId, GetWorkspaceNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspaceNodeHeaders headers = new GetWorkspaceNodeHeaders();
            return await GetWorkspaceNodeWithOptionsAsync(workspaceId, nodeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档初始化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitDocumentRequest
        /// </param>
        /// <param name="headers">
        /// InitDocumentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitDocumentResponse
        /// </returns>
        public InitDocumentResponse InitDocumentWithOptions(string docId, InitDocumentRequest request, InitDocumentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachmentsKey))
            {
                body["attachmentsKey"] = request.AttachmentsKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachmentsMap))
            {
                body["attachmentsMap"] = request.AttachmentsMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportType))
            {
                body["importType"] = request.ImportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinksKey))
            {
                body["linksKey"] = request.LinksKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitDocument",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/docs/" + docId + "/init",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitDocumentResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档初始化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitDocumentRequest
        /// </param>
        /// <param name="headers">
        /// InitDocumentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitDocumentResponse
        /// </returns>
        public async Task<InitDocumentResponse> InitDocumentWithOptionsAsync(string docId, InitDocumentRequest request, InitDocumentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachmentsKey))
            {
                body["attachmentsKey"] = request.AttachmentsKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachmentsMap))
            {
                body["attachmentsMap"] = request.AttachmentsMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportType))
            {
                body["importType"] = request.ImportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinksKey))
            {
                body["linksKey"] = request.LinksKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitDocument",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/docs/" + docId + "/init",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitDocumentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档初始化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// InitDocumentResponse
        /// </returns>
        public InitDocumentResponse InitDocument(string docId, InitDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InitDocumentHeaders headers = new InitDocumentHeaders();
            return InitDocumentWithOptions(docId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档初始化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// InitDocumentResponse
        /// </returns>
        public async Task<InitDocumentResponse> InitDocumentAsync(string docId, InitDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InitDocumentHeaders headers = new InitDocumentHeaders();
            return await InitDocumentWithOptionsAsync(docId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向文档内插入块级元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertBlocksRequest
        /// </param>
        /// <param name="headers">
        /// InsertBlocksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertBlocksResponse
        /// </returns>
        public InsertBlocksResponse InsertBlocksWithOptions(string documentId, InsertBlocksRequest request, InsertBlocksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Blocks))
            {
                body["blocks"] = request.Blocks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertBlocks",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/documents/" + documentId + "/blocks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<InsertBlocksResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向文档内插入块级元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertBlocksRequest
        /// </param>
        /// <param name="headers">
        /// InsertBlocksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertBlocksResponse
        /// </returns>
        public async Task<InsertBlocksResponse> InsertBlocksWithOptionsAsync(string documentId, InsertBlocksRequest request, InsertBlocksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Blocks))
            {
                body["blocks"] = request.Blocks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertBlocks",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/documents/" + documentId + "/blocks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<InsertBlocksResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向文档内插入块级元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertBlocksRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertBlocksResponse
        /// </returns>
        public InsertBlocksResponse InsertBlocks(string documentId, InsertBlocksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertBlocksHeaders headers = new InsertBlocksHeaders();
            return InsertBlocksWithOptions(documentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向文档内插入块级元素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertBlocksRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertBlocksResponse
        /// </returns>
        public async Task<InsertBlocksResponse> InsertBlocksAsync(string documentId, InsertBlocksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertBlocksHeaders headers = new InsertBlocksHeaders();
            return await InsertBlocksWithOptionsAsync(documentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定列左侧插入若干列</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertColumnsBeforeRequest
        /// </param>
        /// <param name="headers">
        /// InsertColumnsBeforeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertColumnsBeforeResponse
        /// </returns>
        public InsertColumnsBeforeResponse InsertColumnsBeforeWithOptions(string workbookId, string sheetId, InsertColumnsBeforeRequest request, InsertColumnsBeforeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnCount))
            {
                body["columnCount"] = request.ColumnCount;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertColumnsBefore",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/insertColumnsBefore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertColumnsBeforeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定列左侧插入若干列</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertColumnsBeforeRequest
        /// </param>
        /// <param name="headers">
        /// InsertColumnsBeforeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertColumnsBeforeResponse
        /// </returns>
        public async Task<InsertColumnsBeforeResponse> InsertColumnsBeforeWithOptionsAsync(string workbookId, string sheetId, InsertColumnsBeforeRequest request, InsertColumnsBeforeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnCount))
            {
                body["columnCount"] = request.ColumnCount;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertColumnsBefore",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/insertColumnsBefore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertColumnsBeforeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定列左侧插入若干列</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertColumnsBeforeRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertColumnsBeforeResponse
        /// </returns>
        public InsertColumnsBeforeResponse InsertColumnsBefore(string workbookId, string sheetId, InsertColumnsBeforeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertColumnsBeforeHeaders headers = new InsertColumnsBeforeHeaders();
            return InsertColumnsBeforeWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定列左侧插入若干列</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertColumnsBeforeRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertColumnsBeforeResponse
        /// </returns>
        public async Task<InsertColumnsBeforeResponse> InsertColumnsBeforeAsync(string workbookId, string sheetId, InsertColumnsBeforeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertColumnsBeforeHeaders headers = new InsertColumnsBeforeHeaders();
            return await InsertColumnsBeforeWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插入整段内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertContentRequest
        /// </param>
        /// <param name="headers">
        /// InsertContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertContentResponse
        /// </returns>
        public InsertContentResponse InsertContentWithOptions(string documentId, InsertContentRequest request, InsertContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertContent",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + documentId + "/content",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertContentResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插入整段内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertContentRequest
        /// </param>
        /// <param name="headers">
        /// InsertContentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertContentResponse
        /// </returns>
        public async Task<InsertContentResponse> InsertContentWithOptionsAsync(string documentId, InsertContentRequest request, InsertContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertContent",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/suites/documents/" + documentId + "/content",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertContentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插入整段内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertContentRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertContentResponse
        /// </returns>
        public InsertContentResponse InsertContent(string documentId, InsertContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertContentHeaders headers = new InsertContentHeaders();
            return InsertContentWithOptions(documentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插入整段内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertContentRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertContentResponse
        /// </returns>
        public async Task<InsertContentResponse> InsertContentAsync(string documentId, InsertContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertContentHeaders headers = new InsertContentHeaders();
            return await InsertContentWithOptionsAsync(documentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插入下拉列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertDropdownListsRequest
        /// </param>
        /// <param name="headers">
        /// InsertDropdownListsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertDropdownListsResponse
        /// </returns>
        public InsertDropdownListsResponse InsertDropdownListsWithOptions(string workbookId, string sheetId, string rangeAddress, InsertDropdownListsRequest request, InsertDropdownListsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertDropdownLists",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/insertDropdownLists",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertDropdownListsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插入下拉列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertDropdownListsRequest
        /// </param>
        /// <param name="headers">
        /// InsertDropdownListsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertDropdownListsResponse
        /// </returns>
        public async Task<InsertDropdownListsResponse> InsertDropdownListsWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, InsertDropdownListsRequest request, InsertDropdownListsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertDropdownLists",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/insertDropdownLists",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertDropdownListsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插入下拉列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertDropdownListsRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertDropdownListsResponse
        /// </returns>
        public InsertDropdownListsResponse InsertDropdownLists(string workbookId, string sheetId, string rangeAddress, InsertDropdownListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertDropdownListsHeaders headers = new InsertDropdownListsHeaders();
            return InsertDropdownListsWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插入下拉列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertDropdownListsRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertDropdownListsResponse
        /// </returns>
        public async Task<InsertDropdownListsResponse> InsertDropdownListsAsync(string workbookId, string sheetId, string rangeAddress, InsertDropdownListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertDropdownListsHeaders headers = new InsertDropdownListsHeaders();
            return await InsertDropdownListsWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定行上方插入若干行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertRowsBeforeRequest
        /// </param>
        /// <param name="headers">
        /// InsertRowsBeforeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertRowsBeforeResponse
        /// </returns>
        public InsertRowsBeforeResponse InsertRowsBeforeWithOptions(string workbookId, string sheetId, InsertRowsBeforeRequest request, InsertRowsBeforeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                body["rowCount"] = request.RowCount;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertRowsBefore",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/insertRowsBefore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertRowsBeforeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定行上方插入若干行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertRowsBeforeRequest
        /// </param>
        /// <param name="headers">
        /// InsertRowsBeforeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertRowsBeforeResponse
        /// </returns>
        public async Task<InsertRowsBeforeResponse> InsertRowsBeforeWithOptionsAsync(string workbookId, string sheetId, InsertRowsBeforeRequest request, InsertRowsBeforeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                body["rowCount"] = request.RowCount;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertRowsBefore",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/insertRowsBefore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertRowsBeforeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定行上方插入若干行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertRowsBeforeRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertRowsBeforeResponse
        /// </returns>
        public InsertRowsBeforeResponse InsertRowsBefore(string workbookId, string sheetId, InsertRowsBeforeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertRowsBeforeHeaders headers = new InsertRowsBeforeHeaders();
            return InsertRowsBeforeWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定行上方插入若干行</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertRowsBeforeRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertRowsBeforeResponse
        /// </returns>
        public async Task<InsertRowsBeforeResponse> InsertRowsBeforeAsync(string workbookId, string sheetId, InsertRowsBeforeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertRowsBeforeHeaders headers = new InsertRowsBeforeHeaders();
            return await InsertRowsBeforeWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档所有评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCommentsRequest
        /// </param>
        /// <param name="headers">
        /// ListCommentsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCommentsResponse
        /// </returns>
        public ListCommentsResponse ListCommentsWithOptions(string docId, ListCommentsRequest request, ListCommentsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsGlobal))
            {
                query["isGlobal"] = request.IsGlobal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSolved))
            {
                query["isSolved"] = request.IsSolved;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComments",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/docs/" + docId + "/comments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCommentsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档所有评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCommentsRequest
        /// </param>
        /// <param name="headers">
        /// ListCommentsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCommentsResponse
        /// </returns>
        public async Task<ListCommentsResponse> ListCommentsWithOptionsAsync(string docId, ListCommentsRequest request, ListCommentsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsGlobal))
            {
                query["isGlobal"] = request.IsGlobal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSolved))
            {
                query["isSolved"] = request.IsSolved;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComments",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/docs/" + docId + "/comments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCommentsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档所有评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCommentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCommentsResponse
        /// </returns>
        public ListCommentsResponse ListComments(string docId, ListCommentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCommentsHeaders headers = new ListCommentsHeaders();
            return ListCommentsWithOptions(docId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档所有评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCommentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCommentsResponse
        /// </returns>
        public async Task<ListCommentsResponse> ListCommentsAsync(string docId, ListCommentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCommentsHeaders headers = new ListCommentsHeaders();
            return await ListCommentsWithOptionsAsync(docId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateRequest
        /// </param>
        /// <param name="headers">
        /// ListTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateResponse
        /// </returns>
        public ListTemplateResponse ListTemplateWithOptions(ListTemplateRequest request, ListTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["templateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplate",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateRequest
        /// </param>
        /// <param name="headers">
        /// ListTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateResponse
        /// </returns>
        public async Task<ListTemplateResponse> ListTemplateWithOptionsAsync(ListTemplateRequest request, ListTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["templateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplate",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateResponse
        /// </returns>
        public ListTemplateResponse ListTemplate(ListTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTemplateHeaders headers = new ListTemplateHeaders();
            return ListTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateResponse
        /// </returns>
        public async Task<ListTemplateResponse> ListTemplateAsync(ListTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTemplateHeaders headers = new ListTemplateHeaders();
            return await ListTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合并单元格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MergeRangeRequest
        /// </param>
        /// <param name="headers">
        /// MergeRangeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MergeRangeResponse
        /// </returns>
        public MergeRangeResponse MergeRangeWithOptions(string workbookId, string sheetId, string rangeAddress, MergeRangeRequest request, MergeRangeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeType))
            {
                body["mergeType"] = request.MergeType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MergeRange",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/merge",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MergeRangeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合并单元格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MergeRangeRequest
        /// </param>
        /// <param name="headers">
        /// MergeRangeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MergeRangeResponse
        /// </returns>
        public async Task<MergeRangeResponse> MergeRangeWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, MergeRangeRequest request, MergeRangeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeType))
            {
                body["mergeType"] = request.MergeType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MergeRange",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/merge",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<MergeRangeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合并单元格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MergeRangeRequest
        /// </param>
        /// 
        /// <returns>
        /// MergeRangeResponse
        /// </returns>
        public MergeRangeResponse MergeRange(string workbookId, string sheetId, string rangeAddress, MergeRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MergeRangeHeaders headers = new MergeRangeHeaders();
            return MergeRangeWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合并单元格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MergeRangeRequest
        /// </param>
        /// 
        /// <returns>
        /// MergeRangeResponse
        /// </returns>
        public async Task<MergeRangeResponse> MergeRangeAsync(string workbookId, string sheetId, string rangeAddress, MergeRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MergeRangeHeaders headers = new MergeRangeHeaders();
            return await MergeRangeWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查找下一个符合条件的单元格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RangeFindNextRequest
        /// </param>
        /// <param name="headers">
        /// RangeFindNextHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RangeFindNextResponse
        /// </returns>
        public RangeFindNextResponse RangeFindNextWithOptions(string workbookId, string sheetId, string rangeAddress, RangeFindNextRequest request, RangeFindNextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FindOptions))
            {
                body["findOptions"] = request.FindOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RangeFindNext",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/findNext",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RangeFindNextResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查找下一个符合条件的单元格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RangeFindNextRequest
        /// </param>
        /// <param name="headers">
        /// RangeFindNextHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RangeFindNextResponse
        /// </returns>
        public async Task<RangeFindNextResponse> RangeFindNextWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, RangeFindNextRequest request, RangeFindNextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FindOptions))
            {
                body["findOptions"] = request.FindOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RangeFindNext",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/findNext",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RangeFindNextResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查找下一个符合条件的单元格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RangeFindNextRequest
        /// </param>
        /// 
        /// <returns>
        /// RangeFindNextResponse
        /// </returns>
        public RangeFindNextResponse RangeFindNext(string workbookId, string sheetId, string rangeAddress, RangeFindNextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RangeFindNextHeaders headers = new RangeFindNextHeaders();
            return RangeFindNextWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查找下一个符合条件的单元格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RangeFindNextRequest
        /// </param>
        /// 
        /// <returns>
        /// RangeFindNextResponse
        /// </returns>
        public async Task<RangeFindNextResponse> RangeFindNextAsync(string workbookId, string sheetId, string rangeAddress, RangeFindNextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RangeFindNextHeaders headers = new RangeFindNextHeaders();
            return await RangeFindNextWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索用户有权限的知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchWorkspaceDocsRequest
        /// </param>
        /// <param name="headers">
        /// SearchWorkspaceDocsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchWorkspaceDocsResponse
        /// </returns>
        public SearchWorkspaceDocsResponse SearchWorkspaceDocsWithOptions(SearchWorkspaceDocsRequest request, SearchWorkspaceDocsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchWorkspaceDocs",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/docs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchWorkspaceDocsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索用户有权限的知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchWorkspaceDocsRequest
        /// </param>
        /// <param name="headers">
        /// SearchWorkspaceDocsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchWorkspaceDocsResponse
        /// </returns>
        public async Task<SearchWorkspaceDocsResponse> SearchWorkspaceDocsWithOptionsAsync(SearchWorkspaceDocsRequest request, SearchWorkspaceDocsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchWorkspaceDocs",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/docs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchWorkspaceDocsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索用户有权限的知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchWorkspaceDocsRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchWorkspaceDocsResponse
        /// </returns>
        public SearchWorkspaceDocsResponse SearchWorkspaceDocs(SearchWorkspaceDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchWorkspaceDocsHeaders headers = new SearchWorkspaceDocsHeaders();
            return SearchWorkspaceDocsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索用户有权限的知识库文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchWorkspaceDocsRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchWorkspaceDocsResponse
        /// </returns>
        public async Task<SearchWorkspaceDocsResponse> SearchWorkspaceDocsAsync(SearchWorkspaceDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchWorkspaceDocsHeaders headers = new SearchWorkspaceDocsHeaders();
            return await SearchWorkspaceDocsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置单元格边框</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetBorderRequest
        /// </param>
        /// <param name="headers">
        /// SetBorderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetBorderResponse
        /// </returns>
        public SetBorderResponse SetBorderWithOptions(string workbookId, string sheetId, string rangeAddress, SetBorderRequest request, SetBorderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Color))
            {
                body["color"] = request.Color;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Style))
            {
                body["style"] = request.Style;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetBorder",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/setBorder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetBorderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置单元格边框</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetBorderRequest
        /// </param>
        /// <param name="headers">
        /// SetBorderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetBorderResponse
        /// </returns>
        public async Task<SetBorderResponse> SetBorderWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, SetBorderRequest request, SetBorderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Color))
            {
                body["color"] = request.Color;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Style))
            {
                body["style"] = request.Style;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetBorder",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/setBorder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetBorderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置单元格边框</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetBorderRequest
        /// </param>
        /// 
        /// <returns>
        /// SetBorderResponse
        /// </returns>
        public SetBorderResponse SetBorder(string workbookId, string sheetId, string rangeAddress, SetBorderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetBorderHeaders headers = new SetBorderHeaders();
            return SetBorderWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置单元格边框</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetBorderRequest
        /// </param>
        /// 
        /// <returns>
        /// SetBorderResponse
        /// </returns>
        public async Task<SetBorderResponse> SetBorderAsync(string workbookId, string sheetId, string rangeAddress, SetBorderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetBorderHeaders headers = new SetBorderHeaders();
            return await SetBorderWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置列宽</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetColumnWidthRequest
        /// </param>
        /// <param name="headers">
        /// SetColumnWidthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetColumnWidthResponse
        /// </returns>
        public SetColumnWidthResponse SetColumnWidthWithOptions(string workbookId, string sheetId, SetColumnWidthRequest request, SetColumnWidthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Width))
            {
                body["width"] = request.Width;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetColumnWidth",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setColumnWidth",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetColumnWidthResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置列宽</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetColumnWidthRequest
        /// </param>
        /// <param name="headers">
        /// SetColumnWidthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetColumnWidthResponse
        /// </returns>
        public async Task<SetColumnWidthResponse> SetColumnWidthWithOptionsAsync(string workbookId, string sheetId, SetColumnWidthRequest request, SetColumnWidthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Width))
            {
                body["width"] = request.Width;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetColumnWidth",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setColumnWidth",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetColumnWidthResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置列宽</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetColumnWidthRequest
        /// </param>
        /// 
        /// <returns>
        /// SetColumnWidthResponse
        /// </returns>
        public SetColumnWidthResponse SetColumnWidth(string workbookId, string sheetId, SetColumnWidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetColumnWidthHeaders headers = new SetColumnWidthHeaders();
            return SetColumnWidthWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置列宽</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetColumnWidthRequest
        /// </param>
        /// 
        /// <returns>
        /// SetColumnWidthResponse
        /// </returns>
        public async Task<SetColumnWidthResponse> SetColumnWidthAsync(string workbookId, string sheetId, SetColumnWidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetColumnWidthHeaders headers = new SetColumnWidthHeaders();
            return await SetColumnWidthWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置列隐藏或显示</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetColumnsVisibilityRequest
        /// </param>
        /// <param name="headers">
        /// SetColumnsVisibilityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetColumnsVisibilityResponse
        /// </returns>
        public SetColumnsVisibilityResponse SetColumnsVisibilityWithOptions(string workbookId, string sheetId, SetColumnsVisibilityRequest request, SetColumnsVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnCount))
            {
                body["columnCount"] = request.ColumnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["visibility"] = request.Visibility;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetColumnsVisibility",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setColumnsVisibility",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetColumnsVisibilityResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置列隐藏或显示</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetColumnsVisibilityRequest
        /// </param>
        /// <param name="headers">
        /// SetColumnsVisibilityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetColumnsVisibilityResponse
        /// </returns>
        public async Task<SetColumnsVisibilityResponse> SetColumnsVisibilityWithOptionsAsync(string workbookId, string sheetId, SetColumnsVisibilityRequest request, SetColumnsVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnCount))
            {
                body["columnCount"] = request.ColumnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["visibility"] = request.Visibility;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetColumnsVisibility",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setColumnsVisibility",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetColumnsVisibilityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置列隐藏或显示</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetColumnsVisibilityRequest
        /// </param>
        /// 
        /// <returns>
        /// SetColumnsVisibilityResponse
        /// </returns>
        public SetColumnsVisibilityResponse SetColumnsVisibility(string workbookId, string sheetId, SetColumnsVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetColumnsVisibilityHeaders headers = new SetColumnsVisibilityHeaders();
            return SetColumnsVisibilityWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置列隐藏或显示</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetColumnsVisibilityRequest
        /// </param>
        /// 
        /// <returns>
        /// SetColumnsVisibilityResponse
        /// </returns>
        public async Task<SetColumnsVisibilityResponse> SetColumnsVisibilityAsync(string workbookId, string sheetId, SetColumnsVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetColumnsVisibilityHeaders headers = new SetColumnsVisibilityHeaders();
            return await SetColumnsVisibilityWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量设置列宽</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetColumnsWidthRequest
        /// </param>
        /// <param name="headers">
        /// SetColumnsWidthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetColumnsWidthResponse
        /// </returns>
        public SetColumnsWidthResponse SetColumnsWidthWithOptions(string workbookId, string sheetId, SetColumnsWidthRequest request, SetColumnsWidthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnCount))
            {
                body["columnCount"] = request.ColumnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Width))
            {
                body["width"] = request.Width;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetColumnsWidth",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setColumnsWidth",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetColumnsWidthResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量设置列宽</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetColumnsWidthRequest
        /// </param>
        /// <param name="headers">
        /// SetColumnsWidthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetColumnsWidthResponse
        /// </returns>
        public async Task<SetColumnsWidthResponse> SetColumnsWidthWithOptionsAsync(string workbookId, string sheetId, SetColumnsWidthRequest request, SetColumnsWidthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnCount))
            {
                body["columnCount"] = request.ColumnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Width))
            {
                body["width"] = request.Width;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetColumnsWidth",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setColumnsWidth",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetColumnsWidthResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量设置列宽</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetColumnsWidthRequest
        /// </param>
        /// 
        /// <returns>
        /// SetColumnsWidthResponse
        /// </returns>
        public SetColumnsWidthResponse SetColumnsWidth(string workbookId, string sheetId, SetColumnsWidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetColumnsWidthHeaders headers = new SetColumnsWidthHeaders();
            return SetColumnsWidthWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量设置列宽</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetColumnsWidthRequest
        /// </param>
        /// 
        /// <returns>
        /// SetColumnsWidthResponse
        /// </returns>
        public async Task<SetColumnsWidthResponse> SetColumnsWidthAsync(string workbookId, string sheetId, SetColumnsWidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetColumnsWidthHeaders headers = new SetColumnsWidthHeaders();
            return await SetColumnsWidthWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置行高</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRowHeightRequest
        /// </param>
        /// <param name="headers">
        /// SetRowHeightHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetRowHeightResponse
        /// </returns>
        public SetRowHeightResponse SetRowHeightWithOptions(string workbookId, string sheetId, SetRowHeightRequest request, SetRowHeightHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                body["height"] = request.Height;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["row"] = request.Row;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetRowHeight",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setRowHeight",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRowHeightResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置行高</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRowHeightRequest
        /// </param>
        /// <param name="headers">
        /// SetRowHeightHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetRowHeightResponse
        /// </returns>
        public async Task<SetRowHeightResponse> SetRowHeightWithOptionsAsync(string workbookId, string sheetId, SetRowHeightRequest request, SetRowHeightHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                body["height"] = request.Height;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["row"] = request.Row;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetRowHeight",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setRowHeight",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRowHeightResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置行高</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRowHeightRequest
        /// </param>
        /// 
        /// <returns>
        /// SetRowHeightResponse
        /// </returns>
        public SetRowHeightResponse SetRowHeight(string workbookId, string sheetId, SetRowHeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRowHeightHeaders headers = new SetRowHeightHeaders();
            return SetRowHeightWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置行高</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRowHeightRequest
        /// </param>
        /// 
        /// <returns>
        /// SetRowHeightResponse
        /// </returns>
        public async Task<SetRowHeightResponse> SetRowHeightAsync(string workbookId, string sheetId, SetRowHeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRowHeightHeaders headers = new SetRowHeightHeaders();
            return await SetRowHeightWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量设置行高</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRowsHeightRequest
        /// </param>
        /// <param name="headers">
        /// SetRowsHeightHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetRowsHeightResponse
        /// </returns>
        public SetRowsHeightResponse SetRowsHeightWithOptions(string workbookId, string sheetId, SetRowsHeightRequest request, SetRowsHeightHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingAccessTokenType))
            {
                query["dingAccessTokenType"] = request.DingAccessTokenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                body["height"] = request.Height;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                body["rowCount"] = request.RowCount;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetRowsHeight",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setRowsHeight",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRowsHeightResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量设置行高</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRowsHeightRequest
        /// </param>
        /// <param name="headers">
        /// SetRowsHeightHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetRowsHeightResponse
        /// </returns>
        public async Task<SetRowsHeightResponse> SetRowsHeightWithOptionsAsync(string workbookId, string sheetId, SetRowsHeightRequest request, SetRowsHeightHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingAccessTokenType))
            {
                query["dingAccessTokenType"] = request.DingAccessTokenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                body["height"] = request.Height;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                body["rowCount"] = request.RowCount;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetRowsHeight",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setRowsHeight",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRowsHeightResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量设置行高</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRowsHeightRequest
        /// </param>
        /// 
        /// <returns>
        /// SetRowsHeightResponse
        /// </returns>
        public SetRowsHeightResponse SetRowsHeight(string workbookId, string sheetId, SetRowsHeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRowsHeightHeaders headers = new SetRowsHeightHeaders();
            return SetRowsHeightWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量设置行高</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRowsHeightRequest
        /// </param>
        /// 
        /// <returns>
        /// SetRowsHeightResponse
        /// </returns>
        public async Task<SetRowsHeightResponse> SetRowsHeightAsync(string workbookId, string sheetId, SetRowsHeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRowsHeightHeaders headers = new SetRowsHeightHeaders();
            return await SetRowsHeightWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置行隐藏或显示</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRowsVisibilityRequest
        /// </param>
        /// <param name="headers">
        /// SetRowsVisibilityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetRowsVisibilityResponse
        /// </returns>
        public SetRowsVisibilityResponse SetRowsVisibilityWithOptions(string workbookId, string sheetId, SetRowsVisibilityRequest request, SetRowsVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                body["rowCount"] = request.RowCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["visibility"] = request.Visibility;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetRowsVisibility",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setRowsVisibility",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRowsVisibilityResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置行隐藏或显示</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRowsVisibilityRequest
        /// </param>
        /// <param name="headers">
        /// SetRowsVisibilityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetRowsVisibilityResponse
        /// </returns>
        public async Task<SetRowsVisibilityResponse> SetRowsVisibilityWithOptionsAsync(string workbookId, string sheetId, SetRowsVisibilityRequest request, SetRowsVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                body["rowCount"] = request.RowCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["visibility"] = request.Visibility;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetRowsVisibility",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setRowsVisibility",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRowsVisibilityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置行隐藏或显示</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRowsVisibilityRequest
        /// </param>
        /// 
        /// <returns>
        /// SetRowsVisibilityResponse
        /// </returns>
        public SetRowsVisibilityResponse SetRowsVisibility(string workbookId, string sheetId, SetRowsVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRowsVisibilityHeaders headers = new SetRowsVisibilityHeaders();
            return SetRowsVisibilityWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置行隐藏或显示</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRowsVisibilityRequest
        /// </param>
        /// 
        /// <returns>
        /// SetRowsVisibilityResponse
        /// </returns>
        public async Task<SetRowsVisibilityResponse> SetRowsVisibilityAsync(string workbookId, string sheetId, SetRowsVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRowsVisibilityHeaders headers = new SetRowsVisibilityHeaders();
            return await SetRowsVisibilityWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SheetAutofitRows</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SheetAutofitRowsRequest
        /// </param>
        /// <param name="headers">
        /// SheetAutofitRowsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SheetAutofitRowsResponse
        /// </returns>
        public SheetAutofitRowsResponse SheetAutofitRowsWithOptions(string workbookId, string sheetId, SheetAutofitRowsRequest request, SheetAutofitRowsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FontWidth))
            {
                body["fontWidth"] = request.FontWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                body["rowCount"] = request.RowCount;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SheetAutofitRows",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/autofitRows",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SheetAutofitRowsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SheetAutofitRows</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SheetAutofitRowsRequest
        /// </param>
        /// <param name="headers">
        /// SheetAutofitRowsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SheetAutofitRowsResponse
        /// </returns>
        public async Task<SheetAutofitRowsResponse> SheetAutofitRowsWithOptionsAsync(string workbookId, string sheetId, SheetAutofitRowsRequest request, SheetAutofitRowsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FontWidth))
            {
                body["fontWidth"] = request.FontWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                body["rowCount"] = request.RowCount;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SheetAutofitRows",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/autofitRows",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SheetAutofitRowsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SheetAutofitRows</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SheetAutofitRowsRequest
        /// </param>
        /// 
        /// <returns>
        /// SheetAutofitRowsResponse
        /// </returns>
        public SheetAutofitRowsResponse SheetAutofitRows(string workbookId, string sheetId, SheetAutofitRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SheetAutofitRowsHeaders headers = new SheetAutofitRowsHeaders();
            return SheetAutofitRowsWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SheetAutofitRows</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SheetAutofitRowsRequest
        /// </param>
        /// 
        /// <returns>
        /// SheetAutofitRowsResponse
        /// </returns>
        public async Task<SheetAutofitRowsResponse> SheetAutofitRowsAsync(string workbookId, string sheetId, SheetAutofitRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SheetAutofitRowsHeaders headers = new SheetAutofitRowsHeaders();
            return await SheetAutofitRowsWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工作表上查找所有符合条件的单元格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SheetFindAllRequest
        /// </param>
        /// <param name="headers">
        /// SheetFindAllHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SheetFindAllResponse
        /// </returns>
        public SheetFindAllResponse SheetFindAllWithOptions(string workbookId, string sheetId, SheetFindAllRequest request, SheetFindAllHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Select))
            {
                query["select"] = request.Select;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FindOptions))
            {
                body["findOptions"] = request.FindOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SheetFindAll",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/findAll",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SheetFindAllResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工作表上查找所有符合条件的单元格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SheetFindAllRequest
        /// </param>
        /// <param name="headers">
        /// SheetFindAllHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SheetFindAllResponse
        /// </returns>
        public async Task<SheetFindAllResponse> SheetFindAllWithOptionsAsync(string workbookId, string sheetId, SheetFindAllRequest request, SheetFindAllHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Select))
            {
                query["select"] = request.Select;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FindOptions))
            {
                body["findOptions"] = request.FindOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SheetFindAll",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/findAll",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SheetFindAllResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工作表上查找所有符合条件的单元格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SheetFindAllRequest
        /// </param>
        /// 
        /// <returns>
        /// SheetFindAllResponse
        /// </returns>
        public SheetFindAllResponse SheetFindAll(string workbookId, string sheetId, SheetFindAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SheetFindAllHeaders headers = new SheetFindAllHeaders();
            return SheetFindAllWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工作表上查找所有符合条件的单元格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SheetFindAllRequest
        /// </param>
        /// 
        /// <returns>
        /// SheetFindAllResponse
        /// </returns>
        public async Task<SheetFindAllResponse> SheetFindAllAsync(string workbookId, string sheetId, SheetFindAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SheetFindAllHeaders headers = new SheetFindAllHeaders();
            return await SheetFindAllWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消文档酷应用和表格的关联</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindCoolAppToSheetRequest
        /// </param>
        /// <param name="headers">
        /// UnbindCoolAppToSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindCoolAppToSheetResponse
        /// </returns>
        public UnbindCoolAppToSheetResponse UnbindCoolAppToSheetWithOptions(string workbookId, UnbindCoolAppToSheetRequest request, UnbindCoolAppToSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                query["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindCoolAppToSheet",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/coolApps",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindCoolAppToSheetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消文档酷应用和表格的关联</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindCoolAppToSheetRequest
        /// </param>
        /// <param name="headers">
        /// UnbindCoolAppToSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindCoolAppToSheetResponse
        /// </returns>
        public async Task<UnbindCoolAppToSheetResponse> UnbindCoolAppToSheetWithOptionsAsync(string workbookId, UnbindCoolAppToSheetRequest request, UnbindCoolAppToSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                query["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindCoolAppToSheet",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/coolApps",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindCoolAppToSheetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消文档酷应用和表格的关联</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindCoolAppToSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindCoolAppToSheetResponse
        /// </returns>
        public UnbindCoolAppToSheetResponse UnbindCoolAppToSheet(string workbookId, UnbindCoolAppToSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnbindCoolAppToSheetHeaders headers = new UnbindCoolAppToSheetHeaders();
            return UnbindCoolAppToSheetWithOptions(workbookId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消文档酷应用和表格的关联</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindCoolAppToSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindCoolAppToSheetResponse
        /// </returns>
        public async Task<UnbindCoolAppToSheetResponse> UnbindCoolAppToSheetAsync(string workbookId, UnbindCoolAppToSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnbindCoolAppToSheetHeaders headers = new UnbindCoolAppToSheetHeaders();
            return await UnbindCoolAppToSheetWithOptionsAsync(workbookId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新单元格区域</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRangeRequest
        /// </param>
        /// <param name="headers">
        /// UpdateRangeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRangeResponse
        /// </returns>
        public UpdateRangeResponse UpdateRangeWithOptions(string workbookId, string sheetId, string rangeAddress, UpdateRangeRequest request, UpdateRangeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundColors))
            {
                body["backgroundColors"] = request.BackgroundColors;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplexValues))
            {
                body["complexValues"] = request.ComplexValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FontColors))
            {
                body["fontColors"] = request.FontColors;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FontSizes))
            {
                body["fontSizes"] = request.FontSizes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FontWeights))
            {
                body["fontWeights"] = request.FontWeights;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HorizontalAlignments))
            {
                body["horizontalAlignments"] = request.HorizontalAlignments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hyperlinks))
            {
                body["hyperlinks"] = request.Hyperlinks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberFormat))
            {
                body["numberFormat"] = request.NumberFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Values))
            {
                body["values"] = request.Values;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerticalAlignments))
            {
                body["verticalAlignments"] = request.VerticalAlignments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordWrap))
            {
                body["wordWrap"] = request.WordWrap;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRange",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRangeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新单元格区域</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRangeRequest
        /// </param>
        /// <param name="headers">
        /// UpdateRangeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRangeResponse
        /// </returns>
        public async Task<UpdateRangeResponse> UpdateRangeWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, UpdateRangeRequest request, UpdateRangeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundColors))
            {
                body["backgroundColors"] = request.BackgroundColors;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplexValues))
            {
                body["complexValues"] = request.ComplexValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FontColors))
            {
                body["fontColors"] = request.FontColors;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FontSizes))
            {
                body["fontSizes"] = request.FontSizes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FontWeights))
            {
                body["fontWeights"] = request.FontWeights;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HorizontalAlignments))
            {
                body["horizontalAlignments"] = request.HorizontalAlignments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hyperlinks))
            {
                body["hyperlinks"] = request.Hyperlinks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberFormat))
            {
                body["numberFormat"] = request.NumberFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Values))
            {
                body["values"] = request.Values;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerticalAlignments))
            {
                body["verticalAlignments"] = request.VerticalAlignments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordWrap))
            {
                body["wordWrap"] = request.WordWrap;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRange",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRangeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新单元格区域</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRangeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRangeResponse
        /// </returns>
        public UpdateRangeResponse UpdateRange(string workbookId, string sheetId, string rangeAddress, UpdateRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRangeHeaders headers = new UpdateRangeHeaders();
            return UpdateRangeWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新单元格区域</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRangeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRangeResponse
        /// </returns>
        public async Task<UpdateRangeResponse> UpdateRangeAsync(string workbookId, string sheetId, string rangeAddress, UpdateRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRangeHeaders headers = new UpdateRangeHeaders();
            return await UpdateRangeWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSheetRequest
        /// </param>
        /// <param name="headers">
        /// UpdateSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSheetResponse
        /// </returns>
        public UpdateSheetResponse UpdateSheetWithOptions(string workbookId, string sheetId, UpdateSheetRequest request, UpdateSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrozenColumnCount))
            {
                body["frozenColumnCount"] = request.FrozenColumnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrozenRowCount))
            {
                body["frozenRowCount"] = request.FrozenRowCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["visibility"] = request.Visibility;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSheet",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateSheetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSheetRequest
        /// </param>
        /// <param name="headers">
        /// UpdateSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSheetResponse
        /// </returns>
        public async Task<UpdateSheetResponse> UpdateSheetWithOptionsAsync(string workbookId, string sheetId, UpdateSheetRequest request, UpdateSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrozenColumnCount))
            {
                body["frozenColumnCount"] = request.FrozenColumnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrozenRowCount))
            {
                body["frozenRowCount"] = request.FrozenRowCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["visibility"] = request.Visibility;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSheet",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateSheetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSheetResponse
        /// </returns>
        public UpdateSheetResponse UpdateSheet(string workbookId, string sheetId, UpdateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSheetHeaders headers = new UpdateSheetHeaders();
            return UpdateSheetWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新工作表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSheetResponse
        /// </returns>
        public async Task<UpdateSheetResponse> UpdateSheetAsync(string workbookId, string sheetId, UpdateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSheetHeaders headers = new UpdateSheetHeaders();
            return await UpdateSheetWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改知识库文档成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceDocMembersRequest
        /// </param>
        /// <param name="headers">
        /// UpdateWorkspaceDocMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceDocMembersResponse
        /// </returns>
        public UpdateWorkspaceDocMembersResponse UpdateWorkspaceDocMembersWithOptions(string workspaceId, string nodeId, UpdateWorkspaceDocMembersRequest request, UpdateWorkspaceDocMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspaceDocMembers",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + "/members",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateWorkspaceDocMembersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改知识库文档成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceDocMembersRequest
        /// </param>
        /// <param name="headers">
        /// UpdateWorkspaceDocMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceDocMembersResponse
        /// </returns>
        public async Task<UpdateWorkspaceDocMembersResponse> UpdateWorkspaceDocMembersWithOptionsAsync(string workspaceId, string nodeId, UpdateWorkspaceDocMembersRequest request, UpdateWorkspaceDocMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspaceDocMembers",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + "/members",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateWorkspaceDocMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改知识库文档成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceDocMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceDocMembersResponse
        /// </returns>
        public UpdateWorkspaceDocMembersResponse UpdateWorkspaceDocMembers(string workspaceId, string nodeId, UpdateWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkspaceDocMembersHeaders headers = new UpdateWorkspaceDocMembersHeaders();
            return UpdateWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改知识库文档成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceDocMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceDocMembersResponse
        /// </returns>
        public async Task<UpdateWorkspaceDocMembersResponse> UpdateWorkspaceDocMembersAsync(string workspaceId, string nodeId, UpdateWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkspaceDocMembersHeaders headers = new UpdateWorkspaceDocMembersHeaders();
            return await UpdateWorkspaceDocMembersWithOptionsAsync(workspaceId, nodeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新知识库成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceMembersRequest
        /// </param>
        /// <param name="headers">
        /// UpdateWorkspaceMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceMembersResponse
        /// </returns>
        public UpdateWorkspaceMembersResponse UpdateWorkspaceMembersWithOptions(string workspaceId, UpdateWorkspaceMembersRequest request, UpdateWorkspaceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspaceMembers",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId + "/members",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateWorkspaceMembersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新知识库成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceMembersRequest
        /// </param>
        /// <param name="headers">
        /// UpdateWorkspaceMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceMembersResponse
        /// </returns>
        public async Task<UpdateWorkspaceMembersResponse> UpdateWorkspaceMembersWithOptionsAsync(string workspaceId, UpdateWorkspaceMembersRequest request, UpdateWorkspaceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspaceMembers",
                Version = "doc_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/doc/workspaces/" + workspaceId + "/members",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateWorkspaceMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新知识库成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceMembersResponse
        /// </returns>
        public UpdateWorkspaceMembersResponse UpdateWorkspaceMembers(string workspaceId, UpdateWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkspaceMembersHeaders headers = new UpdateWorkspaceMembersHeaders();
            return UpdateWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新知识库成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceMembersResponse
        /// </returns>
        public async Task<UpdateWorkspaceMembersResponse> UpdateWorkspaceMembersAsync(string workspaceId, UpdateWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkspaceMembersHeaders headers = new UpdateWorkspaceMembersHeaders();
            return await UpdateWorkspaceMembersWithOptionsAsync(workspaceId, request, headers, runtime);
        }

    }
}
