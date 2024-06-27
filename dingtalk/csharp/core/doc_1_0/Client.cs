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


        /**
         * @summary 添加评论
         *
         * @param request AddCommentRequest
         * @param headers AddCommentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddCommentResponse
         */
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

        /**
         * @summary 添加评论
         *
         * @param request AddCommentRequest
         * @param headers AddCommentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddCommentResponse
         */
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

        /**
         * @summary 添加评论
         *
         * @param request AddCommentRequest
         * @return AddCommentResponse
         */
        public AddCommentResponse AddComment(string docId, AddCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCommentHeaders headers = new AddCommentHeaders();
            return AddCommentWithOptions(docId, request, headers, runtime);
        }

        /**
         * @summary 添加评论
         *
         * @param request AddCommentRequest
         * @return AddCommentResponse
         */
        public async Task<AddCommentResponse> AddCommentAsync(string docId, AddCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCommentHeaders headers = new AddCommentHeaders();
            return await AddCommentWithOptionsAsync(docId, request, headers, runtime);
        }

        /**
         * @summary 添加知识库文档成员
         *
         * @param request AddWorkspaceDocMembersRequest
         * @param headers AddWorkspaceDocMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddWorkspaceDocMembersResponse
         */
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

        /**
         * @summary 添加知识库文档成员
         *
         * @param request AddWorkspaceDocMembersRequest
         * @param headers AddWorkspaceDocMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddWorkspaceDocMembersResponse
         */
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

        /**
         * @summary 添加知识库文档成员
         *
         * @param request AddWorkspaceDocMembersRequest
         * @return AddWorkspaceDocMembersResponse
         */
        public AddWorkspaceDocMembersResponse AddWorkspaceDocMembers(string workspaceId, string nodeId, AddWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceDocMembersHeaders headers = new AddWorkspaceDocMembersHeaders();
            return AddWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
        }

        /**
         * @summary 添加知识库文档成员
         *
         * @param request AddWorkspaceDocMembersRequest
         * @return AddWorkspaceDocMembersResponse
         */
        public async Task<AddWorkspaceDocMembersResponse> AddWorkspaceDocMembersAsync(string workspaceId, string nodeId, AddWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceDocMembersHeaders headers = new AddWorkspaceDocMembersHeaders();
            return await AddWorkspaceDocMembersWithOptionsAsync(workspaceId, nodeId, request, headers, runtime);
        }

        /**
         * @summary 添加知识库成员
         *
         * @param request AddWorkspaceMembersRequest
         * @param headers AddWorkspaceMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddWorkspaceMembersResponse
         */
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

        /**
         * @summary 添加知识库成员
         *
         * @param request AddWorkspaceMembersRequest
         * @param headers AddWorkspaceMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddWorkspaceMembersResponse
         */
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

        /**
         * @summary 添加知识库成员
         *
         * @param request AddWorkspaceMembersRequest
         * @return AddWorkspaceMembersResponse
         */
        public AddWorkspaceMembersResponse AddWorkspaceMembers(string workspaceId, AddWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceMembersHeaders headers = new AddWorkspaceMembersHeaders();
            return AddWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 添加知识库成员
         *
         * @param request AddWorkspaceMembersRequest
         * @return AddWorkspaceMembersResponse
         */
        public async Task<AddWorkspaceMembersResponse> AddWorkspaceMembersAsync(string workspaceId, AddWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceMembersHeaders headers = new AddWorkspaceMembersHeaders();
            return await AddWorkspaceMembersWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 追加行
         *
         * @param request AppendRowsRequest
         * @param headers AppendRowsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AppendRowsResponse
         */
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

        /**
         * @summary 追加行
         *
         * @param request AppendRowsRequest
         * @param headers AppendRowsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AppendRowsResponse
         */
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

        /**
         * @summary 追加行
         *
         * @param request AppendRowsRequest
         * @return AppendRowsResponse
         */
        public AppendRowsResponse AppendRows(string workbookId, string sheetId, AppendRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendRowsHeaders headers = new AppendRowsHeaders();
            return AppendRowsWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 追加行
         *
         * @param request AppendRowsRequest
         * @return AppendRowsResponse
         */
        public async Task<AppendRowsResponse> AppendRowsAsync(string workbookId, string sheetId, AppendRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendRowsHeaders headers = new AppendRowsHeaders();
            return await AppendRowsWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 批量执行表格操作
         *
         * @param request BatchRequest
         * @param headers BatchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchResponse
         */
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

        /**
         * @summary 批量执行表格操作
         *
         * @param request BatchRequest
         * @param headers BatchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchResponse
         */
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

        /**
         * @summary 批量执行表格操作
         *
         * @param request BatchRequest
         * @return BatchResponse
         */
        public BatchResponse Batch(string workbookId, BatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchHeaders headers = new BatchHeaders();
            return BatchWithOptions(workbookId, request, headers, runtime);
        }

        /**
         * @summary 批量执行表格操作
         *
         * @param request BatchRequest
         * @return BatchResponse
         */
        public async Task<BatchResponse> BatchAsync(string workbookId, BatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchHeaders headers = new BatchHeaders();
            return await BatchWithOptionsAsync(workbookId, request, headers, runtime);
        }

        /**
         * @summary 批量查询知识库文档
         *
         * @param request BatchGetWorkspaceDocsRequest
         * @param headers BatchGetWorkspaceDocsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchGetWorkspaceDocsResponse
         */
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

        /**
         * @summary 批量查询知识库文档
         *
         * @param request BatchGetWorkspaceDocsRequest
         * @param headers BatchGetWorkspaceDocsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchGetWorkspaceDocsResponse
         */
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

        /**
         * @summary 批量查询知识库文档
         *
         * @param request BatchGetWorkspaceDocsRequest
         * @return BatchGetWorkspaceDocsResponse
         */
        public BatchGetWorkspaceDocsResponse BatchGetWorkspaceDocs(BatchGetWorkspaceDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetWorkspaceDocsHeaders headers = new BatchGetWorkspaceDocsHeaders();
            return BatchGetWorkspaceDocsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询知识库文档
         *
         * @param request BatchGetWorkspaceDocsRequest
         * @return BatchGetWorkspaceDocsResponse
         */
        public async Task<BatchGetWorkspaceDocsResponse> BatchGetWorkspaceDocsAsync(BatchGetWorkspaceDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetWorkspaceDocsHeaders headers = new BatchGetWorkspaceDocsHeaders();
            return await BatchGetWorkspaceDocsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 知识库批量查询
         *
         * @param request BatchGetWorkspacesRequest
         * @param headers BatchGetWorkspacesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchGetWorkspacesResponse
         */
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

        /**
         * @summary 知识库批量查询
         *
         * @param request BatchGetWorkspacesRequest
         * @param headers BatchGetWorkspacesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchGetWorkspacesResponse
         */
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

        /**
         * @summary 知识库批量查询
         *
         * @param request BatchGetWorkspacesRequest
         * @return BatchGetWorkspacesResponse
         */
        public BatchGetWorkspacesResponse BatchGetWorkspaces(BatchGetWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetWorkspacesHeaders headers = new BatchGetWorkspacesHeaders();
            return BatchGetWorkspacesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 知识库批量查询
         *
         * @param request BatchGetWorkspacesRequest
         * @return BatchGetWorkspacesResponse
         */
        public async Task<BatchGetWorkspacesResponse> BatchGetWorkspacesAsync(BatchGetWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetWorkspacesHeaders headers = new BatchGetWorkspacesHeaders();
            return await BatchGetWorkspacesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 关联文档酷应用到表格
         *
         * @param request BindCoolAppToSheetRequest
         * @param headers BindCoolAppToSheetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindCoolAppToSheetResponse
         */
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

        /**
         * @summary 关联文档酷应用到表格
         *
         * @param request BindCoolAppToSheetRequest
         * @param headers BindCoolAppToSheetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindCoolAppToSheetResponse
         */
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

        /**
         * @summary 关联文档酷应用到表格
         *
         * @param request BindCoolAppToSheetRequest
         * @return BindCoolAppToSheetResponse
         */
        public BindCoolAppToSheetResponse BindCoolAppToSheet(string workbookId, BindCoolAppToSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BindCoolAppToSheetHeaders headers = new BindCoolAppToSheetHeaders();
            return BindCoolAppToSheetWithOptions(workbookId, request, headers, runtime);
        }

        /**
         * @summary 关联文档酷应用到表格
         *
         * @param request BindCoolAppToSheetRequest
         * @return BindCoolAppToSheetResponse
         */
        public async Task<BindCoolAppToSheetResponse> BindCoolAppToSheetAsync(string workbookId, BindCoolAppToSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BindCoolAppToSheetHeaders headers = new BindCoolAppToSheetHeaders();
            return await BindCoolAppToSheetWithOptionsAsync(workbookId, request, headers, runtime);
        }

        /**
         * @summary 清除单元格区域内所有内容
         *
         * @param request ClearRequest
         * @param headers ClearHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ClearResponse
         */
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

        /**
         * @summary 清除单元格区域内所有内容
         *
         * @param request ClearRequest
         * @param headers ClearHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ClearResponse
         */
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

        /**
         * @summary 清除单元格区域内所有内容
         *
         * @param request ClearRequest
         * @return ClearResponse
         */
        public ClearResponse Clear(string workbookId, string sheetId, string rangeAddress, ClearRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearHeaders headers = new ClearHeaders();
            return ClearWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /**
         * @summary 清除单元格区域内所有内容
         *
         * @param request ClearRequest
         * @return ClearResponse
         */
        public async Task<ClearResponse> ClearAsync(string workbookId, string sheetId, string rangeAddress, ClearRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearHeaders headers = new ClearHeaders();
            return await ClearWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /**
         * @summary 清除单元格区域内数据
         *
         * @param request ClearDataRequest
         * @param headers ClearDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ClearDataResponse
         */
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

        /**
         * @summary 清除单元格区域内数据
         *
         * @param request ClearDataRequest
         * @param headers ClearDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ClearDataResponse
         */
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

        /**
         * @summary 清除单元格区域内数据
         *
         * @param request ClearDataRequest
         * @return ClearDataResponse
         */
        public ClearDataResponse ClearData(string workbookId, string sheetId, string rangeAddress, ClearDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearDataHeaders headers = new ClearDataHeaders();
            return ClearDataWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /**
         * @summary 清除单元格区域内数据
         *
         * @param request ClearDataRequest
         * @return ClearDataResponse
         */
        public async Task<ClearDataResponse> ClearDataAsync(string workbookId, string sheetId, string rangeAddress, ClearDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearDataHeaders headers = new ClearDataHeaders();
            return await ClearDataWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /**
         * @summary 创建条件格式
         *
         * @param request CreateConditionalFormattingRuleRequest
         * @param headers CreateConditionalFormattingRuleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConditionalFormattingRuleResponse
         */
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

        /**
         * @summary 创建条件格式
         *
         * @param request CreateConditionalFormattingRuleRequest
         * @param headers CreateConditionalFormattingRuleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConditionalFormattingRuleResponse
         */
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

        /**
         * @summary 创建条件格式
         *
         * @param request CreateConditionalFormattingRuleRequest
         * @return CreateConditionalFormattingRuleResponse
         */
        public CreateConditionalFormattingRuleResponse CreateConditionalFormattingRule(string workbookId, string sheetId, CreateConditionalFormattingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateConditionalFormattingRuleHeaders headers = new CreateConditionalFormattingRuleHeaders();
            return CreateConditionalFormattingRuleWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 创建条件格式
         *
         * @param request CreateConditionalFormattingRuleRequest
         * @return CreateConditionalFormattingRuleResponse
         */
        public async Task<CreateConditionalFormattingRuleResponse> CreateConditionalFormattingRuleAsync(string workbookId, string sheetId, CreateConditionalFormattingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateConditionalFormattingRuleHeaders headers = new CreateConditionalFormattingRuleHeaders();
            return await CreateConditionalFormattingRuleWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 创建开发者元数据
         *
         * @param request CreateDeveloperMetadataRequest
         * @param headers CreateDeveloperMetadataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDeveloperMetadataResponse
         */
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

        /**
         * @summary 创建开发者元数据
         *
         * @param request CreateDeveloperMetadataRequest
         * @param headers CreateDeveloperMetadataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDeveloperMetadataResponse
         */
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

        /**
         * @summary 创建开发者元数据
         *
         * @param request CreateDeveloperMetadataRequest
         * @return CreateDeveloperMetadataResponse
         */
        public CreateDeveloperMetadataResponse CreateDeveloperMetadata(string workbookId, CreateDeveloperMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeveloperMetadataHeaders headers = new CreateDeveloperMetadataHeaders();
            return CreateDeveloperMetadataWithOptions(workbookId, request, headers, runtime);
        }

        /**
         * @summary 创建开发者元数据
         *
         * @param request CreateDeveloperMetadataRequest
         * @return CreateDeveloperMetadataResponse
         */
        public async Task<CreateDeveloperMetadataResponse> CreateDeveloperMetadataAsync(string workbookId, CreateDeveloperMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeveloperMetadataHeaders headers = new CreateDeveloperMetadataHeaders();
            return await CreateDeveloperMetadataWithOptionsAsync(workbookId, request, headers, runtime);
        }

        /**
         * @summary 创建单元格锁定
         *
         * @param request CreateRangeProtectionRequest
         * @param headers CreateRangeProtectionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRangeProtectionResponse
         */
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

        /**
         * @summary 创建单元格锁定
         *
         * @param request CreateRangeProtectionRequest
         * @param headers CreateRangeProtectionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRangeProtectionResponse
         */
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

        /**
         * @summary 创建单元格锁定
         *
         * @param request CreateRangeProtectionRequest
         * @return CreateRangeProtectionResponse
         */
        public CreateRangeProtectionResponse CreateRangeProtection(string workbookId, string sheetId, string rangeAddress, CreateRangeProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRangeProtectionHeaders headers = new CreateRangeProtectionHeaders();
            return CreateRangeProtectionWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /**
         * @summary 创建单元格锁定
         *
         * @param request CreateRangeProtectionRequest
         * @return CreateRangeProtectionResponse
         */
        public async Task<CreateRangeProtectionResponse> CreateRangeProtectionAsync(string workbookId, string sheetId, string rangeAddress, CreateRangeProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRangeProtectionHeaders headers = new CreateRangeProtectionHeaders();
            return await CreateRangeProtectionWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /**
         * @summary 创建工作表
         *
         * @param request CreateSheetRequest
         * @param headers CreateSheetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSheetResponse
         */
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

        /**
         * @summary 创建工作表
         *
         * @param request CreateSheetRequest
         * @param headers CreateSheetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSheetResponse
         */
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

        /**
         * @summary 创建工作表
         *
         * @param request CreateSheetRequest
         * @return CreateSheetResponse
         */
        public CreateSheetResponse CreateSheet(string workbookId, CreateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSheetHeaders headers = new CreateSheetHeaders();
            return CreateSheetWithOptions(workbookId, request, headers, runtime);
        }

        /**
         * @summary 创建工作表
         *
         * @param request CreateSheetRequest
         * @return CreateSheetResponse
         */
        public async Task<CreateSheetResponse> CreateSheetAsync(string workbookId, CreateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSheetHeaders headers = new CreateSheetHeaders();
            return await CreateSheetWithOptionsAsync(workbookId, request, headers, runtime);
        }

        /**
         * @summary 新建知识库
         *
         * @param request CreateWorkspaceRequest
         * @param headers CreateWorkspaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWorkspaceResponse
         */
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

        /**
         * @summary 新建知识库
         *
         * @param request CreateWorkspaceRequest
         * @param headers CreateWorkspaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWorkspaceResponse
         */
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

        /**
         * @summary 新建知识库
         *
         * @param request CreateWorkspaceRequest
         * @return CreateWorkspaceResponse
         */
        public CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkspaceHeaders headers = new CreateWorkspaceHeaders();
            return CreateWorkspaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新建知识库
         *
         * @param request CreateWorkspaceRequest
         * @return CreateWorkspaceResponse
         */
        public async Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkspaceHeaders headers = new CreateWorkspaceHeaders();
            return await CreateWorkspaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建知识库文档
         *
         * @param request CreateWorkspaceDocRequest
         * @param headers CreateWorkspaceDocHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWorkspaceDocResponse
         */
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

        /**
         * @summary 创建知识库文档
         *
         * @param request CreateWorkspaceDocRequest
         * @param headers CreateWorkspaceDocHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWorkspaceDocResponse
         */
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

        /**
         * @summary 创建知识库文档
         *
         * @param request CreateWorkspaceDocRequest
         * @return CreateWorkspaceDocResponse
         */
        public CreateWorkspaceDocResponse CreateWorkspaceDoc(string workspaceId, CreateWorkspaceDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkspaceDocHeaders headers = new CreateWorkspaceDocHeaders();
            return CreateWorkspaceDocWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 创建知识库文档
         *
         * @param request CreateWorkspaceDocRequest
         * @return CreateWorkspaceDocResponse
         */
        public async Task<CreateWorkspaceDocResponse> CreateWorkspaceDocAsync(string workspaceId, CreateWorkspaceDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkspaceDocHeaders headers = new CreateWorkspaceDocHeaders();
            return await CreateWorkspaceDocWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 删除列
         *
         * @param request DeleteColumnsRequest
         * @param headers DeleteColumnsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteColumnsResponse
         */
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

        /**
         * @summary 删除列
         *
         * @param request DeleteColumnsRequest
         * @param headers DeleteColumnsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteColumnsResponse
         */
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

        /**
         * @summary 删除列
         *
         * @param request DeleteColumnsRequest
         * @return DeleteColumnsResponse
         */
        public DeleteColumnsResponse DeleteColumns(string workbookId, string sheetId, DeleteColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteColumnsHeaders headers = new DeleteColumnsHeaders();
            return DeleteColumnsWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 删除列
         *
         * @param request DeleteColumnsRequest
         * @return DeleteColumnsResponse
         */
        public async Task<DeleteColumnsResponse> DeleteColumnsAsync(string workbookId, string sheetId, DeleteColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteColumnsHeaders headers = new DeleteColumnsHeaders();
            return await DeleteColumnsWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 删除下拉列表
         *
         * @param request DeleteDropdownListsRequest
         * @param headers DeleteDropdownListsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDropdownListsResponse
         */
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

        /**
         * @summary 删除下拉列表
         *
         * @param request DeleteDropdownListsRequest
         * @param headers DeleteDropdownListsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDropdownListsResponse
         */
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

        /**
         * @summary 删除下拉列表
         *
         * @param request DeleteDropdownListsRequest
         * @return DeleteDropdownListsResponse
         */
        public DeleteDropdownListsResponse DeleteDropdownLists(string workbookId, string sheetId, string rangeAddress, DeleteDropdownListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDropdownListsHeaders headers = new DeleteDropdownListsHeaders();
            return DeleteDropdownListsWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /**
         * @summary 删除下拉列表
         *
         * @param request DeleteDropdownListsRequest
         * @return DeleteDropdownListsResponse
         */
        public async Task<DeleteDropdownListsResponse> DeleteDropdownListsAsync(string workbookId, string sheetId, string rangeAddress, DeleteDropdownListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDropdownListsHeaders headers = new DeleteDropdownListsHeaders();
            return await DeleteDropdownListsWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /**
         * @summary 删除单元格锁定
         *
         * @param request DeleteRangeProtectionRequest
         * @param headers DeleteRangeProtectionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRangeProtectionResponse
         */
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

        /**
         * @summary 删除单元格锁定
         *
         * @param request DeleteRangeProtectionRequest
         * @param headers DeleteRangeProtectionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRangeProtectionResponse
         */
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

        /**
         * @summary 删除单元格锁定
         *
         * @param request DeleteRangeProtectionRequest
         * @return DeleteRangeProtectionResponse
         */
        public DeleteRangeProtectionResponse DeleteRangeProtection(string workbookId, string sheetId, string rangeAddress, string protectionId, DeleteRangeProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRangeProtectionHeaders headers = new DeleteRangeProtectionHeaders();
            return DeleteRangeProtectionWithOptions(workbookId, sheetId, rangeAddress, protectionId, request, headers, runtime);
        }

        /**
         * @summary 删除单元格锁定
         *
         * @param request DeleteRangeProtectionRequest
         * @return DeleteRangeProtectionResponse
         */
        public async Task<DeleteRangeProtectionResponse> DeleteRangeProtectionAsync(string workbookId, string sheetId, string rangeAddress, string protectionId, DeleteRangeProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRangeProtectionHeaders headers = new DeleteRangeProtectionHeaders();
            return await DeleteRangeProtectionWithOptionsAsync(workbookId, sheetId, rangeAddress, protectionId, request, headers, runtime);
        }

        /**
         * @summary 删除行
         *
         * @param request DeleteRowsRequest
         * @param headers DeleteRowsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRowsResponse
         */
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

        /**
         * @summary 删除行
         *
         * @param request DeleteRowsRequest
         * @param headers DeleteRowsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRowsResponse
         */
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

        /**
         * @summary 删除行
         *
         * @param request DeleteRowsRequest
         * @return DeleteRowsResponse
         */
        public DeleteRowsResponse DeleteRows(string workbookId, string sheetId, DeleteRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRowsHeaders headers = new DeleteRowsHeaders();
            return DeleteRowsWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 删除行
         *
         * @param request DeleteRowsRequest
         * @return DeleteRowsResponse
         */
        public async Task<DeleteRowsResponse> DeleteRowsAsync(string workbookId, string sheetId, DeleteRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRowsHeaders headers = new DeleteRowsHeaders();
            return await DeleteRowsWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 删除工作表
         *
         * @param request DeleteSheetRequest
         * @param headers DeleteSheetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSheetResponse
         */
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

        /**
         * @summary 删除工作表
         *
         * @param request DeleteSheetRequest
         * @param headers DeleteSheetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSheetResponse
         */
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

        /**
         * @summary 删除工作表
         *
         * @param request DeleteSheetRequest
         * @return DeleteSheetResponse
         */
        public DeleteSheetResponse DeleteSheet(string workbookId, string sheetId, DeleteSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSheetHeaders headers = new DeleteSheetHeaders();
            return DeleteSheetWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 删除工作表
         *
         * @param request DeleteSheetRequest
         * @return DeleteSheetResponse
         */
        public async Task<DeleteSheetResponse> DeleteSheetAsync(string workbookId, string sheetId, DeleteSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSheetHeaders headers = new DeleteSheetHeaders();
            return await DeleteSheetWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 删除知识库文档
         *
         * @param request DeleteWorkspaceDocRequest
         * @param headers DeleteWorkspaceDocHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWorkspaceDocResponse
         */
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

        /**
         * @summary 删除知识库文档
         *
         * @param request DeleteWorkspaceDocRequest
         * @param headers DeleteWorkspaceDocHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWorkspaceDocResponse
         */
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

        /**
         * @summary 删除知识库文档
         *
         * @param request DeleteWorkspaceDocRequest
         * @return DeleteWorkspaceDocResponse
         */
        public DeleteWorkspaceDocResponse DeleteWorkspaceDoc(string workspaceId, string nodeId, DeleteWorkspaceDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceDocHeaders headers = new DeleteWorkspaceDocHeaders();
            return DeleteWorkspaceDocWithOptions(workspaceId, nodeId, request, headers, runtime);
        }

        /**
         * @summary 删除知识库文档
         *
         * @param request DeleteWorkspaceDocRequest
         * @return DeleteWorkspaceDocResponse
         */
        public async Task<DeleteWorkspaceDocResponse> DeleteWorkspaceDocAsync(string workspaceId, string nodeId, DeleteWorkspaceDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceDocHeaders headers = new DeleteWorkspaceDocHeaders();
            return await DeleteWorkspaceDocWithOptionsAsync(workspaceId, nodeId, request, headers, runtime);
        }

        /**
         * @summary 删除知识库文档成员
         *
         * @param request DeleteWorkspaceDocMembersRequest
         * @param headers DeleteWorkspaceDocMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWorkspaceDocMembersResponse
         */
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

        /**
         * @summary 删除知识库文档成员
         *
         * @param request DeleteWorkspaceDocMembersRequest
         * @param headers DeleteWorkspaceDocMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWorkspaceDocMembersResponse
         */
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

        /**
         * @summary 删除知识库文档成员
         *
         * @param request DeleteWorkspaceDocMembersRequest
         * @return DeleteWorkspaceDocMembersResponse
         */
        public DeleteWorkspaceDocMembersResponse DeleteWorkspaceDocMembers(string workspaceId, string nodeId, DeleteWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceDocMembersHeaders headers = new DeleteWorkspaceDocMembersHeaders();
            return DeleteWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
        }

        /**
         * @summary 删除知识库文档成员
         *
         * @param request DeleteWorkspaceDocMembersRequest
         * @return DeleteWorkspaceDocMembersResponse
         */
        public async Task<DeleteWorkspaceDocMembersResponse> DeleteWorkspaceDocMembersAsync(string workspaceId, string nodeId, DeleteWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceDocMembersHeaders headers = new DeleteWorkspaceDocMembersHeaders();
            return await DeleteWorkspaceDocMembersWithOptionsAsync(workspaceId, nodeId, request, headers, runtime);
        }

        /**
         * @summary 删除知识库成员
         *
         * @param request DeleteWorkspaceMembersRequest
         * @param headers DeleteWorkspaceMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWorkspaceMembersResponse
         */
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

        /**
         * @summary 删除知识库成员
         *
         * @param request DeleteWorkspaceMembersRequest
         * @param headers DeleteWorkspaceMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWorkspaceMembersResponse
         */
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

        /**
         * @summary 删除知识库成员
         *
         * @param request DeleteWorkspaceMembersRequest
         * @return DeleteWorkspaceMembersResponse
         */
        public DeleteWorkspaceMembersResponse DeleteWorkspaceMembers(string workspaceId, DeleteWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceMembersHeaders headers = new DeleteWorkspaceMembersHeaders();
            return DeleteWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 删除知识库成员
         *
         * @param request DeleteWorkspaceMembersRequest
         * @return DeleteWorkspaceMembersResponse
         */
        public async Task<DeleteWorkspaceMembersResponse> DeleteWorkspaceMembersAsync(string workspaceId, DeleteWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceMembersHeaders headers = new DeleteWorkspaceMembersHeaders();
            return await DeleteWorkspaceMembersWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 追加指定段落元素
         *
         * @param request DocAppendParagraphRequest
         * @param headers DocAppendParagraphHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DocAppendParagraphResponse
         */
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

        /**
         * @summary 追加指定段落元素
         *
         * @param request DocAppendParagraphRequest
         * @param headers DocAppendParagraphHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DocAppendParagraphResponse
         */
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

        /**
         * @summary 追加指定段落元素
         *
         * @param request DocAppendParagraphRequest
         * @return DocAppendParagraphResponse
         */
        public DocAppendParagraphResponse DocAppendParagraph(string docKey, string blockId, DocAppendParagraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocAppendParagraphHeaders headers = new DocAppendParagraphHeaders();
            return DocAppendParagraphWithOptions(docKey, blockId, request, headers, runtime);
        }

        /**
         * @summary 追加指定段落元素
         *
         * @param request DocAppendParagraphRequest
         * @return DocAppendParagraphResponse
         */
        public async Task<DocAppendParagraphResponse> DocAppendParagraphAsync(string docKey, string blockId, DocAppendParagraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocAppendParagraphHeaders headers = new DocAppendParagraphHeaders();
            return await DocAppendParagraphWithOptionsAsync(docKey, blockId, request, headers, runtime);
        }

        /**
         * @summary 在段落后追加文本
         *
         * @param request DocAppendTextRequest
         * @param headers DocAppendTextHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DocAppendTextResponse
         */
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

        /**
         * @summary 在段落后追加文本
         *
         * @param request DocAppendTextRequest
         * @param headers DocAppendTextHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DocAppendTextResponse
         */
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

        /**
         * @summary 在段落后追加文本
         *
         * @param request DocAppendTextRequest
         * @return DocAppendTextResponse
         */
        public DocAppendTextResponse DocAppendText(string docKey, string blockId, DocAppendTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocAppendTextHeaders headers = new DocAppendTextHeaders();
            return DocAppendTextWithOptions(docKey, blockId, request, headers, runtime);
        }

        /**
         * @summary 在段落后追加文本
         *
         * @param request DocAppendTextRequest
         * @return DocAppendTextResponse
         */
        public async Task<DocAppendTextResponse> DocAppendTextAsync(string docKey, string blockId, DocAppendTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocAppendTextHeaders headers = new DocAppendTextHeaders();
            return await DocAppendTextWithOptionsAsync(docKey, blockId, request, headers, runtime);
        }

        /**
         * @summary 查询指定Block元素
         *
         * @param request DocBlocksQueryRequest
         * @param headers DocBlocksQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DocBlocksQueryResponse
         */
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

        /**
         * @summary 查询指定Block元素
         *
         * @param request DocBlocksQueryRequest
         * @param headers DocBlocksQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DocBlocksQueryResponse
         */
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

        /**
         * @summary 查询指定Block元素
         *
         * @param request DocBlocksQueryRequest
         * @return DocBlocksQueryResponse
         */
        public DocBlocksQueryResponse DocBlocksQuery(string docKey, DocBlocksQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocBlocksQueryHeaders headers = new DocBlocksQueryHeaders();
            return DocBlocksQueryWithOptions(docKey, request, headers, runtime);
        }

        /**
         * @summary 查询指定Block元素
         *
         * @param request DocBlocksQueryRequest
         * @return DocBlocksQueryResponse
         */
        public async Task<DocBlocksQueryResponse> DocBlocksQueryAsync(string docKey, DocBlocksQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocBlocksQueryHeaders headers = new DocBlocksQueryHeaders();
            return await DocBlocksQueryWithOptionsAsync(docKey, request, headers, runtime);
        }

        /**
         * @summary 删除指定位置的 Block
         *
         * @param request DocDeleteBlockRequest
         * @param headers DocDeleteBlockHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DocDeleteBlockResponse
         */
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

        /**
         * @summary 删除指定位置的 Block
         *
         * @param request DocDeleteBlockRequest
         * @param headers DocDeleteBlockHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DocDeleteBlockResponse
         */
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

        /**
         * @summary 删除指定位置的 Block
         *
         * @param request DocDeleteBlockRequest
         * @return DocDeleteBlockResponse
         */
        public DocDeleteBlockResponse DocDeleteBlock(string docKey, string blockId, DocDeleteBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocDeleteBlockHeaders headers = new DocDeleteBlockHeaders();
            return DocDeleteBlockWithOptions(docKey, blockId, request, headers, runtime);
        }

        /**
         * @summary 删除指定位置的 Block
         *
         * @param request DocDeleteBlockRequest
         * @return DocDeleteBlockResponse
         */
        public async Task<DocDeleteBlockResponse> DocDeleteBlockAsync(string docKey, string blockId, DocDeleteBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocDeleteBlockHeaders headers = new DocDeleteBlockHeaders();
            return await DocDeleteBlockWithOptionsAsync(docKey, blockId, request, headers, runtime);
        }

        /**
         * @summary 插入指定Block元素
         *
         * @param request DocInsertBlocksRequest
         * @param headers DocInsertBlocksHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DocInsertBlocksResponse
         */
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

        /**
         * @summary 插入指定Block元素
         *
         * @param request DocInsertBlocksRequest
         * @param headers DocInsertBlocksHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DocInsertBlocksResponse
         */
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

        /**
         * @summary 插入指定Block元素
         *
         * @param request DocInsertBlocksRequest
         * @return DocInsertBlocksResponse
         */
        public DocInsertBlocksResponse DocInsertBlocks(string docKey, DocInsertBlocksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocInsertBlocksHeaders headers = new DocInsertBlocksHeaders();
            return DocInsertBlocksWithOptions(docKey, request, headers, runtime);
        }

        /**
         * @summary 插入指定Block元素
         *
         * @param request DocInsertBlocksRequest
         * @return DocInsertBlocksResponse
         */
        public async Task<DocInsertBlocksResponse> DocInsertBlocksAsync(string docKey, DocInsertBlocksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocInsertBlocksHeaders headers = new DocInsertBlocksHeaders();
            return await DocInsertBlocksWithOptionsAsync(docKey, request, headers, runtime);
        }

        /**
         * @summary 覆写全文
         *
         * @param request DocUpdateContentRequest
         * @param headers DocUpdateContentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DocUpdateContentResponse
         */
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

        /**
         * @summary 覆写全文
         *
         * @param request DocUpdateContentRequest
         * @param headers DocUpdateContentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DocUpdateContentResponse
         */
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

        /**
         * @summary 覆写全文
         *
         * @param request DocUpdateContentRequest
         * @return DocUpdateContentResponse
         */
        public DocUpdateContentResponse DocUpdateContent(string docKey, DocUpdateContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocUpdateContentHeaders headers = new DocUpdateContentHeaders();
            return DocUpdateContentWithOptions(docKey, request, headers, runtime);
        }

        /**
         * @summary 覆写全文
         *
         * @param request DocUpdateContentRequest
         * @return DocUpdateContentResponse
         */
        public async Task<DocUpdateContentResponse> DocUpdateContentAsync(string docKey, DocUpdateContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DocUpdateContentHeaders headers = new DocUpdateContentHeaders();
            return await DocUpdateContentWithOptionsAsync(docKey, request, headers, runtime);
        }

        /**
         * @summary 获取所有工作表
         *
         * @param request GetAllSheetsRequest
         * @param headers GetAllSheetsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAllSheetsResponse
         */
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

        /**
         * @summary 获取所有工作表
         *
         * @param request GetAllSheetsRequest
         * @param headers GetAllSheetsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAllSheetsResponse
         */
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

        /**
         * @summary 获取所有工作表
         *
         * @param request GetAllSheetsRequest
         * @return GetAllSheetsResponse
         */
        public GetAllSheetsResponse GetAllSheets(string workbookId, GetAllSheetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllSheetsHeaders headers = new GetAllSheetsHeaders();
            return GetAllSheetsWithOptions(workbookId, request, headers, runtime);
        }

        /**
         * @summary 获取所有工作表
         *
         * @param request GetAllSheetsRequest
         * @return GetAllSheetsResponse
         */
        public async Task<GetAllSheetsResponse> GetAllSheetsAsync(string workbookId, GetAllSheetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllSheetsHeaders headers = new GetAllSheetsHeaders();
            return await GetAllSheetsWithOptionsAsync(workbookId, request, headers, runtime);
        }

        /**
         * @summary 获取开发者元数据
         *
         * @param request GetDeveloperMetadataRequest
         * @param headers GetDeveloperMetadataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeveloperMetadataResponse
         */
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

        /**
         * @summary 获取开发者元数据
         *
         * @param request GetDeveloperMetadataRequest
         * @param headers GetDeveloperMetadataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeveloperMetadataResponse
         */
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

        /**
         * @summary 获取开发者元数据
         *
         * @param request GetDeveloperMetadataRequest
         * @return GetDeveloperMetadataResponse
         */
        public GetDeveloperMetadataResponse GetDeveloperMetadata(string workbookId, string developerMetadataId, GetDeveloperMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeveloperMetadataHeaders headers = new GetDeveloperMetadataHeaders();
            return GetDeveloperMetadataWithOptions(workbookId, developerMetadataId, request, headers, runtime);
        }

        /**
         * @summary 获取开发者元数据
         *
         * @param request GetDeveloperMetadataRequest
         * @return GetDeveloperMetadataResponse
         */
        public async Task<GetDeveloperMetadataResponse> GetDeveloperMetadataAsync(string workbookId, string developerMetadataId, GetDeveloperMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeveloperMetadataHeaders headers = new GetDeveloperMetadataHeaders();
            return await GetDeveloperMetadataWithOptionsAsync(workbookId, developerMetadataId, request, headers, runtime);
        }

        /**
         * @summary 获取单元格区域
         *
         * @param request GetRangeRequest
         * @param headers GetRangeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRangeResponse
         */
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

        /**
         * @summary 获取单元格区域
         *
         * @param request GetRangeRequest
         * @param headers GetRangeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRangeResponse
         */
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

        /**
         * @summary 获取单元格区域
         *
         * @param request GetRangeRequest
         * @return GetRangeResponse
         */
        public GetRangeResponse GetRange(string workbookId, string sheetId, string rangeAddress, GetRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRangeHeaders headers = new GetRangeHeaders();
            return GetRangeWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /**
         * @summary 获取单元格区域
         *
         * @param request GetRangeRequest
         * @return GetRangeResponse
         */
        public async Task<GetRangeResponse> GetRangeAsync(string workbookId, string sheetId, string rangeAddress, GetRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRangeHeaders headers = new GetRangeHeaders();
            return await GetRangeWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /**
         * @summary 获取最近编辑文档
         *
         * @param request GetRecentEditDocsRequest
         * @param headers GetRecentEditDocsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRecentEditDocsResponse
         */
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

        /**
         * @summary 获取最近编辑文档
         *
         * @param request GetRecentEditDocsRequest
         * @param headers GetRecentEditDocsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRecentEditDocsResponse
         */
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

        /**
         * @summary 获取最近编辑文档
         *
         * @param request GetRecentEditDocsRequest
         * @return GetRecentEditDocsResponse
         */
        public GetRecentEditDocsResponse GetRecentEditDocs(GetRecentEditDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecentEditDocsHeaders headers = new GetRecentEditDocsHeaders();
            return GetRecentEditDocsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取最近编辑文档
         *
         * @param request GetRecentEditDocsRequest
         * @return GetRecentEditDocsResponse
         */
        public async Task<GetRecentEditDocsResponse> GetRecentEditDocsAsync(GetRecentEditDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecentEditDocsHeaders headers = new GetRecentEditDocsHeaders();
            return await GetRecentEditDocsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取最近打开文档
         *
         * @param request GetRecentOpenDocsRequest
         * @param headers GetRecentOpenDocsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRecentOpenDocsResponse
         */
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

        /**
         * @summary 获取最近打开文档
         *
         * @param request GetRecentOpenDocsRequest
         * @param headers GetRecentOpenDocsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRecentOpenDocsResponse
         */
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

        /**
         * @summary 获取最近打开文档
         *
         * @param request GetRecentOpenDocsRequest
         * @return GetRecentOpenDocsResponse
         */
        public GetRecentOpenDocsResponse GetRecentOpenDocs(GetRecentOpenDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecentOpenDocsHeaders headers = new GetRecentOpenDocsHeaders();
            return GetRecentOpenDocsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取最近打开文档
         *
         * @param request GetRecentOpenDocsRequest
         * @return GetRecentOpenDocsResponse
         */
        public async Task<GetRecentOpenDocsResponse> GetRecentOpenDocsAsync(GetRecentOpenDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecentOpenDocsHeaders headers = new GetRecentOpenDocsHeaders();
            return await GetRecentOpenDocsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询用户有权限的知识库
         *
         * @param request GetRelatedWorkspacesRequest
         * @param headers GetRelatedWorkspacesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRelatedWorkspacesResponse
         */
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

        /**
         * @summary 查询用户有权限的知识库
         *
         * @param request GetRelatedWorkspacesRequest
         * @param headers GetRelatedWorkspacesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRelatedWorkspacesResponse
         */
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

        /**
         * @summary 查询用户有权限的知识库
         *
         * @param request GetRelatedWorkspacesRequest
         * @return GetRelatedWorkspacesResponse
         */
        public GetRelatedWorkspacesResponse GetRelatedWorkspaces(GetRelatedWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRelatedWorkspacesHeaders headers = new GetRelatedWorkspacesHeaders();
            return GetRelatedWorkspacesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询用户有权限的知识库
         *
         * @param request GetRelatedWorkspacesRequest
         * @return GetRelatedWorkspacesResponse
         */
        public async Task<GetRelatedWorkspacesResponse> GetRelatedWorkspacesAsync(GetRelatedWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRelatedWorkspacesHeaders headers = new GetRelatedWorkspacesHeaders();
            return await GetRelatedWorkspacesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取工作表
         *
         * @param request GetSheetRequest
         * @param headers GetSheetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSheetResponse
         */
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

        /**
         * @summary 获取工作表
         *
         * @param request GetSheetRequest
         * @param headers GetSheetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSheetResponse
         */
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

        /**
         * @summary 获取工作表
         *
         * @param request GetSheetRequest
         * @return GetSheetResponse
         */
        public GetSheetResponse GetSheet(string workbookId, string sheetId, GetSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSheetHeaders headers = new GetSheetHeaders();
            return GetSheetWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 获取工作表
         *
         * @param request GetSheetRequest
         * @return GetSheetResponse
         */
        public async Task<GetSheetResponse> GetSheetAsync(string workbookId, string sheetId, GetSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSheetHeaders headers = new GetSheetHeaders();
            return await GetSheetWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 查询文档模版
         *
         * @param request GetTemplateByIdRequest
         * @param headers GetTemplateByIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTemplateByIdResponse
         */
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

        /**
         * @summary 查询文档模版
         *
         * @param request GetTemplateByIdRequest
         * @param headers GetTemplateByIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTemplateByIdResponse
         */
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

        /**
         * @summary 查询文档模版
         *
         * @param request GetTemplateByIdRequest
         * @return GetTemplateByIdResponse
         */
        public GetTemplateByIdResponse GetTemplateById(string templateId, GetTemplateByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTemplateByIdHeaders headers = new GetTemplateByIdHeaders();
            return GetTemplateByIdWithOptions(templateId, request, headers, runtime);
        }

        /**
         * @summary 查询文档模版
         *
         * @param request GetTemplateByIdRequest
         * @return GetTemplateByIdResponse
         */
        public async Task<GetTemplateByIdResponse> GetTemplateByIdAsync(string templateId, GetTemplateByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTemplateByIdHeaders headers = new GetTemplateByIdHeaders();
            return await GetTemplateByIdWithOptionsAsync(templateId, request, headers, runtime);
        }

        /**
         * @summary 查询知识库信息
         *
         * @param headers GetWorkspaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkspaceResponse
         */
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

        /**
         * @summary 查询知识库信息
         *
         * @param headers GetWorkspaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkspaceResponse
         */
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

        /**
         * @summary 查询知识库信息
         *
         * @return GetWorkspaceResponse
         */
        public GetWorkspaceResponse GetWorkspace(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspaceHeaders headers = new GetWorkspaceHeaders();
            return GetWorkspaceWithOptions(workspaceId, headers, runtime);
        }

        /**
         * @summary 查询知识库信息
         *
         * @return GetWorkspaceResponse
         */
        public async Task<GetWorkspaceResponse> GetWorkspaceAsync(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspaceHeaders headers = new GetWorkspaceHeaders();
            return await GetWorkspaceWithOptionsAsync(workspaceId, headers, runtime);
        }

        /**
         * @summary 查询知识库文档
         *
         * @param request GetWorkspaceNodeRequest
         * @param headers GetWorkspaceNodeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkspaceNodeResponse
         */
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

        /**
         * @summary 查询知识库文档
         *
         * @param request GetWorkspaceNodeRequest
         * @param headers GetWorkspaceNodeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkspaceNodeResponse
         */
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

        /**
         * @summary 查询知识库文档
         *
         * @param request GetWorkspaceNodeRequest
         * @return GetWorkspaceNodeResponse
         */
        public GetWorkspaceNodeResponse GetWorkspaceNode(string workspaceId, string nodeId, GetWorkspaceNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspaceNodeHeaders headers = new GetWorkspaceNodeHeaders();
            return GetWorkspaceNodeWithOptions(workspaceId, nodeId, request, headers, runtime);
        }

        /**
         * @summary 查询知识库文档
         *
         * @param request GetWorkspaceNodeRequest
         * @return GetWorkspaceNodeResponse
         */
        public async Task<GetWorkspaceNodeResponse> GetWorkspaceNodeAsync(string workspaceId, string nodeId, GetWorkspaceNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspaceNodeHeaders headers = new GetWorkspaceNodeHeaders();
            return await GetWorkspaceNodeWithOptionsAsync(workspaceId, nodeId, request, headers, runtime);
        }

        /**
         * @summary 文档初始化
         *
         * @param request InitDocumentRequest
         * @param headers InitDocumentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InitDocumentResponse
         */
        public InitDocumentResponse InitDocumentWithOptions(string docId, InitDocumentRequest request, InitDocumentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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

        /**
         * @summary 文档初始化
         *
         * @param request InitDocumentRequest
         * @param headers InitDocumentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InitDocumentResponse
         */
        public async Task<InitDocumentResponse> InitDocumentWithOptionsAsync(string docId, InitDocumentRequest request, InitDocumentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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

        /**
         * @summary 文档初始化
         *
         * @param request InitDocumentRequest
         * @return InitDocumentResponse
         */
        public InitDocumentResponse InitDocument(string docId, InitDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InitDocumentHeaders headers = new InitDocumentHeaders();
            return InitDocumentWithOptions(docId, request, headers, runtime);
        }

        /**
         * @summary 文档初始化
         *
         * @param request InitDocumentRequest
         * @return InitDocumentResponse
         */
        public async Task<InitDocumentResponse> InitDocumentAsync(string docId, InitDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InitDocumentHeaders headers = new InitDocumentHeaders();
            return await InitDocumentWithOptionsAsync(docId, request, headers, runtime);
        }

        /**
         * @summary 向文档内插入块级元素
         *
         * @param request InsertBlocksRequest
         * @param headers InsertBlocksHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertBlocksResponse
         */
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

        /**
         * @summary 向文档内插入块级元素
         *
         * @param request InsertBlocksRequest
         * @param headers InsertBlocksHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertBlocksResponse
         */
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

        /**
         * @summary 向文档内插入块级元素
         *
         * @param request InsertBlocksRequest
         * @return InsertBlocksResponse
         */
        public InsertBlocksResponse InsertBlocks(string documentId, InsertBlocksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertBlocksHeaders headers = new InsertBlocksHeaders();
            return InsertBlocksWithOptions(documentId, request, headers, runtime);
        }

        /**
         * @summary 向文档内插入块级元素
         *
         * @param request InsertBlocksRequest
         * @return InsertBlocksResponse
         */
        public async Task<InsertBlocksResponse> InsertBlocksAsync(string documentId, InsertBlocksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertBlocksHeaders headers = new InsertBlocksHeaders();
            return await InsertBlocksWithOptionsAsync(documentId, request, headers, runtime);
        }

        /**
         * @summary 指定列左侧插入若干列
         *
         * @param request InsertColumnsBeforeRequest
         * @param headers InsertColumnsBeforeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertColumnsBeforeResponse
         */
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

        /**
         * @summary 指定列左侧插入若干列
         *
         * @param request InsertColumnsBeforeRequest
         * @param headers InsertColumnsBeforeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertColumnsBeforeResponse
         */
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

        /**
         * @summary 指定列左侧插入若干列
         *
         * @param request InsertColumnsBeforeRequest
         * @return InsertColumnsBeforeResponse
         */
        public InsertColumnsBeforeResponse InsertColumnsBefore(string workbookId, string sheetId, InsertColumnsBeforeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertColumnsBeforeHeaders headers = new InsertColumnsBeforeHeaders();
            return InsertColumnsBeforeWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 指定列左侧插入若干列
         *
         * @param request InsertColumnsBeforeRequest
         * @return InsertColumnsBeforeResponse
         */
        public async Task<InsertColumnsBeforeResponse> InsertColumnsBeforeAsync(string workbookId, string sheetId, InsertColumnsBeforeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertColumnsBeforeHeaders headers = new InsertColumnsBeforeHeaders();
            return await InsertColumnsBeforeWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 插入下拉列表
         *
         * @param request InsertDropdownListsRequest
         * @param headers InsertDropdownListsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertDropdownListsResponse
         */
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

        /**
         * @summary 插入下拉列表
         *
         * @param request InsertDropdownListsRequest
         * @param headers InsertDropdownListsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertDropdownListsResponse
         */
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

        /**
         * @summary 插入下拉列表
         *
         * @param request InsertDropdownListsRequest
         * @return InsertDropdownListsResponse
         */
        public InsertDropdownListsResponse InsertDropdownLists(string workbookId, string sheetId, string rangeAddress, InsertDropdownListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertDropdownListsHeaders headers = new InsertDropdownListsHeaders();
            return InsertDropdownListsWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /**
         * @summary 插入下拉列表
         *
         * @param request InsertDropdownListsRequest
         * @return InsertDropdownListsResponse
         */
        public async Task<InsertDropdownListsResponse> InsertDropdownListsAsync(string workbookId, string sheetId, string rangeAddress, InsertDropdownListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertDropdownListsHeaders headers = new InsertDropdownListsHeaders();
            return await InsertDropdownListsWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /**
         * @summary 指定行上方插入若干行
         *
         * @param request InsertRowsBeforeRequest
         * @param headers InsertRowsBeforeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertRowsBeforeResponse
         */
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

        /**
         * @summary 指定行上方插入若干行
         *
         * @param request InsertRowsBeforeRequest
         * @param headers InsertRowsBeforeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertRowsBeforeResponse
         */
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

        /**
         * @summary 指定行上方插入若干行
         *
         * @param request InsertRowsBeforeRequest
         * @return InsertRowsBeforeResponse
         */
        public InsertRowsBeforeResponse InsertRowsBefore(string workbookId, string sheetId, InsertRowsBeforeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertRowsBeforeHeaders headers = new InsertRowsBeforeHeaders();
            return InsertRowsBeforeWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 指定行上方插入若干行
         *
         * @param request InsertRowsBeforeRequest
         * @return InsertRowsBeforeResponse
         */
        public async Task<InsertRowsBeforeResponse> InsertRowsBeforeAsync(string workbookId, string sheetId, InsertRowsBeforeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertRowsBeforeHeaders headers = new InsertRowsBeforeHeaders();
            return await InsertRowsBeforeWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 查询文档模版
         *
         * @param request ListTemplateRequest
         * @param headers ListTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTemplateResponse
         */
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

        /**
         * @summary 查询文档模版
         *
         * @param request ListTemplateRequest
         * @param headers ListTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTemplateResponse
         */
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

        /**
         * @summary 查询文档模版
         *
         * @param request ListTemplateRequest
         * @return ListTemplateResponse
         */
        public ListTemplateResponse ListTemplate(ListTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTemplateHeaders headers = new ListTemplateHeaders();
            return ListTemplateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询文档模版
         *
         * @param request ListTemplateRequest
         * @return ListTemplateResponse
         */
        public async Task<ListTemplateResponse> ListTemplateAsync(ListTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTemplateHeaders headers = new ListTemplateHeaders();
            return await ListTemplateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 合并单元格
         *
         * @param request MergeRangeRequest
         * @param headers MergeRangeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MergeRangeResponse
         */
        public MergeRangeResponse MergeRangeWithOptions(string workbookId, string sheetId, string rangeAddress, MergeRangeRequest request, MergeRangeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary 合并单元格
         *
         * @param request MergeRangeRequest
         * @param headers MergeRangeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return MergeRangeResponse
         */
        public async Task<MergeRangeResponse> MergeRangeWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, MergeRangeRequest request, MergeRangeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary 合并单元格
         *
         * @param request MergeRangeRequest
         * @return MergeRangeResponse
         */
        public MergeRangeResponse MergeRange(string workbookId, string sheetId, string rangeAddress, MergeRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MergeRangeHeaders headers = new MergeRangeHeaders();
            return MergeRangeWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /**
         * @summary 合并单元格
         *
         * @param request MergeRangeRequest
         * @return MergeRangeResponse
         */
        public async Task<MergeRangeResponse> MergeRangeAsync(string workbookId, string sheetId, string rangeAddress, MergeRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MergeRangeHeaders headers = new MergeRangeHeaders();
            return await MergeRangeWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /**
         * @summary 查找下一个符合条件的单元格
         *
         * @param request RangeFindNextRequest
         * @param headers RangeFindNextHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RangeFindNextResponse
         */
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

        /**
         * @summary 查找下一个符合条件的单元格
         *
         * @param request RangeFindNextRequest
         * @param headers RangeFindNextHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RangeFindNextResponse
         */
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

        /**
         * @summary 查找下一个符合条件的单元格
         *
         * @param request RangeFindNextRequest
         * @return RangeFindNextResponse
         */
        public RangeFindNextResponse RangeFindNext(string workbookId, string sheetId, string rangeAddress, RangeFindNextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RangeFindNextHeaders headers = new RangeFindNextHeaders();
            return RangeFindNextWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /**
         * @summary 查找下一个符合条件的单元格
         *
         * @param request RangeFindNextRequest
         * @return RangeFindNextResponse
         */
        public async Task<RangeFindNextResponse> RangeFindNextAsync(string workbookId, string sheetId, string rangeAddress, RangeFindNextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RangeFindNextHeaders headers = new RangeFindNextHeaders();
            return await RangeFindNextWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /**
         * @summary 搜索用户有权限的知识库文档
         *
         * @param request SearchWorkspaceDocsRequest
         * @param headers SearchWorkspaceDocsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchWorkspaceDocsResponse
         */
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

        /**
         * @summary 搜索用户有权限的知识库文档
         *
         * @param request SearchWorkspaceDocsRequest
         * @param headers SearchWorkspaceDocsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchWorkspaceDocsResponse
         */
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

        /**
         * @summary 搜索用户有权限的知识库文档
         *
         * @param request SearchWorkspaceDocsRequest
         * @return SearchWorkspaceDocsResponse
         */
        public SearchWorkspaceDocsResponse SearchWorkspaceDocs(SearchWorkspaceDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchWorkspaceDocsHeaders headers = new SearchWorkspaceDocsHeaders();
            return SearchWorkspaceDocsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 搜索用户有权限的知识库文档
         *
         * @param request SearchWorkspaceDocsRequest
         * @return SearchWorkspaceDocsResponse
         */
        public async Task<SearchWorkspaceDocsResponse> SearchWorkspaceDocsAsync(SearchWorkspaceDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchWorkspaceDocsHeaders headers = new SearchWorkspaceDocsHeaders();
            return await SearchWorkspaceDocsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 设置列宽
         *
         * @param request SetColumnWidthRequest
         * @param headers SetColumnWidthHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetColumnWidthResponse
         */
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

        /**
         * @summary 设置列宽
         *
         * @param request SetColumnWidthRequest
         * @param headers SetColumnWidthHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetColumnWidthResponse
         */
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

        /**
         * @summary 设置列宽
         *
         * @param request SetColumnWidthRequest
         * @return SetColumnWidthResponse
         */
        public SetColumnWidthResponse SetColumnWidth(string workbookId, string sheetId, SetColumnWidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetColumnWidthHeaders headers = new SetColumnWidthHeaders();
            return SetColumnWidthWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 设置列宽
         *
         * @param request SetColumnWidthRequest
         * @return SetColumnWidthResponse
         */
        public async Task<SetColumnWidthResponse> SetColumnWidthAsync(string workbookId, string sheetId, SetColumnWidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetColumnWidthHeaders headers = new SetColumnWidthHeaders();
            return await SetColumnWidthWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 设置列隐藏或显示
         *
         * @param request SetColumnsVisibilityRequest
         * @param headers SetColumnsVisibilityHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetColumnsVisibilityResponse
         */
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

        /**
         * @summary 设置列隐藏或显示
         *
         * @param request SetColumnsVisibilityRequest
         * @param headers SetColumnsVisibilityHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetColumnsVisibilityResponse
         */
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

        /**
         * @summary 设置列隐藏或显示
         *
         * @param request SetColumnsVisibilityRequest
         * @return SetColumnsVisibilityResponse
         */
        public SetColumnsVisibilityResponse SetColumnsVisibility(string workbookId, string sheetId, SetColumnsVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetColumnsVisibilityHeaders headers = new SetColumnsVisibilityHeaders();
            return SetColumnsVisibilityWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 设置列隐藏或显示
         *
         * @param request SetColumnsVisibilityRequest
         * @return SetColumnsVisibilityResponse
         */
        public async Task<SetColumnsVisibilityResponse> SetColumnsVisibilityAsync(string workbookId, string sheetId, SetColumnsVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetColumnsVisibilityHeaders headers = new SetColumnsVisibilityHeaders();
            return await SetColumnsVisibilityWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 设置行高
         *
         * @param request SetRowHeightRequest
         * @param headers SetRowHeightHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetRowHeightResponse
         */
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

        /**
         * @summary 设置行高
         *
         * @param request SetRowHeightRequest
         * @param headers SetRowHeightHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetRowHeightResponse
         */
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

        /**
         * @summary 设置行高
         *
         * @param request SetRowHeightRequest
         * @return SetRowHeightResponse
         */
        public SetRowHeightResponse SetRowHeight(string workbookId, string sheetId, SetRowHeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRowHeightHeaders headers = new SetRowHeightHeaders();
            return SetRowHeightWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 设置行高
         *
         * @param request SetRowHeightRequest
         * @return SetRowHeightResponse
         */
        public async Task<SetRowHeightResponse> SetRowHeightAsync(string workbookId, string sheetId, SetRowHeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRowHeightHeaders headers = new SetRowHeightHeaders();
            return await SetRowHeightWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 设置行隐藏或显示
         *
         * @param request SetRowsVisibilityRequest
         * @param headers SetRowsVisibilityHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetRowsVisibilityResponse
         */
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

        /**
         * @summary 设置行隐藏或显示
         *
         * @param request SetRowsVisibilityRequest
         * @param headers SetRowsVisibilityHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetRowsVisibilityResponse
         */
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

        /**
         * @summary 设置行隐藏或显示
         *
         * @param request SetRowsVisibilityRequest
         * @return SetRowsVisibilityResponse
         */
        public SetRowsVisibilityResponse SetRowsVisibility(string workbookId, string sheetId, SetRowsVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRowsVisibilityHeaders headers = new SetRowsVisibilityHeaders();
            return SetRowsVisibilityWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 设置行隐藏或显示
         *
         * @param request SetRowsVisibilityRequest
         * @return SetRowsVisibilityResponse
         */
        public async Task<SetRowsVisibilityResponse> SetRowsVisibilityAsync(string workbookId, string sheetId, SetRowsVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRowsVisibilityHeaders headers = new SetRowsVisibilityHeaders();
            return await SetRowsVisibilityWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary SheetAutofitRows
         *
         * @param request SheetAutofitRowsRequest
         * @param headers SheetAutofitRowsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SheetAutofitRowsResponse
         */
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

        /**
         * @summary SheetAutofitRows
         *
         * @param request SheetAutofitRowsRequest
         * @param headers SheetAutofitRowsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SheetAutofitRowsResponse
         */
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

        /**
         * @summary SheetAutofitRows
         *
         * @param request SheetAutofitRowsRequest
         * @return SheetAutofitRowsResponse
         */
        public SheetAutofitRowsResponse SheetAutofitRows(string workbookId, string sheetId, SheetAutofitRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SheetAutofitRowsHeaders headers = new SheetAutofitRowsHeaders();
            return SheetAutofitRowsWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary SheetAutofitRows
         *
         * @param request SheetAutofitRowsRequest
         * @return SheetAutofitRowsResponse
         */
        public async Task<SheetAutofitRowsResponse> SheetAutofitRowsAsync(string workbookId, string sheetId, SheetAutofitRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SheetAutofitRowsHeaders headers = new SheetAutofitRowsHeaders();
            return await SheetAutofitRowsWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 工作表上查找所有符合条件的单元格
         *
         * @param request SheetFindAllRequest
         * @param headers SheetFindAllHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SheetFindAllResponse
         */
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

        /**
         * @summary 工作表上查找所有符合条件的单元格
         *
         * @param request SheetFindAllRequest
         * @param headers SheetFindAllHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SheetFindAllResponse
         */
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

        /**
         * @summary 工作表上查找所有符合条件的单元格
         *
         * @param request SheetFindAllRequest
         * @return SheetFindAllResponse
         */
        public SheetFindAllResponse SheetFindAll(string workbookId, string sheetId, SheetFindAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SheetFindAllHeaders headers = new SheetFindAllHeaders();
            return SheetFindAllWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 工作表上查找所有符合条件的单元格
         *
         * @param request SheetFindAllRequest
         * @return SheetFindAllResponse
         */
        public async Task<SheetFindAllResponse> SheetFindAllAsync(string workbookId, string sheetId, SheetFindAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SheetFindAllHeaders headers = new SheetFindAllHeaders();
            return await SheetFindAllWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 取消文档酷应用和表格的关联
         *
         * @param request UnbindCoolAppToSheetRequest
         * @param headers UnbindCoolAppToSheetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindCoolAppToSheetResponse
         */
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

        /**
         * @summary 取消文档酷应用和表格的关联
         *
         * @param request UnbindCoolAppToSheetRequest
         * @param headers UnbindCoolAppToSheetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindCoolAppToSheetResponse
         */
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

        /**
         * @summary 取消文档酷应用和表格的关联
         *
         * @param request UnbindCoolAppToSheetRequest
         * @return UnbindCoolAppToSheetResponse
         */
        public UnbindCoolAppToSheetResponse UnbindCoolAppToSheet(string workbookId, UnbindCoolAppToSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnbindCoolAppToSheetHeaders headers = new UnbindCoolAppToSheetHeaders();
            return UnbindCoolAppToSheetWithOptions(workbookId, request, headers, runtime);
        }

        /**
         * @summary 取消文档酷应用和表格的关联
         *
         * @param request UnbindCoolAppToSheetRequest
         * @return UnbindCoolAppToSheetResponse
         */
        public async Task<UnbindCoolAppToSheetResponse> UnbindCoolAppToSheetAsync(string workbookId, UnbindCoolAppToSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnbindCoolAppToSheetHeaders headers = new UnbindCoolAppToSheetHeaders();
            return await UnbindCoolAppToSheetWithOptionsAsync(workbookId, request, headers, runtime);
        }

        /**
         * @summary 更新单元格区域
         *
         * @param request UpdateRangeRequest
         * @param headers UpdateRangeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRangeResponse
         */
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

        /**
         * @summary 更新单元格区域
         *
         * @param request UpdateRangeRequest
         * @param headers UpdateRangeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRangeResponse
         */
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

        /**
         * @summary 更新单元格区域
         *
         * @param request UpdateRangeRequest
         * @return UpdateRangeResponse
         */
        public UpdateRangeResponse UpdateRange(string workbookId, string sheetId, string rangeAddress, UpdateRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRangeHeaders headers = new UpdateRangeHeaders();
            return UpdateRangeWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /**
         * @summary 更新单元格区域
         *
         * @param request UpdateRangeRequest
         * @return UpdateRangeResponse
         */
        public async Task<UpdateRangeResponse> UpdateRangeAsync(string workbookId, string sheetId, string rangeAddress, UpdateRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRangeHeaders headers = new UpdateRangeHeaders();
            return await UpdateRangeWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        /**
         * @summary 更新工作表
         *
         * @param request UpdateSheetRequest
         * @param headers UpdateSheetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSheetResponse
         */
        public UpdateSheetResponse UpdateSheetWithOptions(string workbookId, string sheetId, UpdateSheetRequest request, UpdateSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary 更新工作表
         *
         * @param request UpdateSheetRequest
         * @param headers UpdateSheetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSheetResponse
         */
        public async Task<UpdateSheetResponse> UpdateSheetWithOptionsAsync(string workbookId, string sheetId, UpdateSheetRequest request, UpdateSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary 更新工作表
         *
         * @param request UpdateSheetRequest
         * @return UpdateSheetResponse
         */
        public UpdateSheetResponse UpdateSheet(string workbookId, string sheetId, UpdateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSheetHeaders headers = new UpdateSheetHeaders();
            return UpdateSheetWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 更新工作表
         *
         * @param request UpdateSheetRequest
         * @return UpdateSheetResponse
         */
        public async Task<UpdateSheetResponse> UpdateSheetAsync(string workbookId, string sheetId, UpdateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSheetHeaders headers = new UpdateSheetHeaders();
            return await UpdateSheetWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        /**
         * @summary 修改知识库文档成员
         *
         * @param request UpdateWorkspaceDocMembersRequest
         * @param headers UpdateWorkspaceDocMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWorkspaceDocMembersResponse
         */
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

        /**
         * @summary 修改知识库文档成员
         *
         * @param request UpdateWorkspaceDocMembersRequest
         * @param headers UpdateWorkspaceDocMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWorkspaceDocMembersResponse
         */
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

        /**
         * @summary 修改知识库文档成员
         *
         * @param request UpdateWorkspaceDocMembersRequest
         * @return UpdateWorkspaceDocMembersResponse
         */
        public UpdateWorkspaceDocMembersResponse UpdateWorkspaceDocMembers(string workspaceId, string nodeId, UpdateWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkspaceDocMembersHeaders headers = new UpdateWorkspaceDocMembersHeaders();
            return UpdateWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
        }

        /**
         * @summary 修改知识库文档成员
         *
         * @param request UpdateWorkspaceDocMembersRequest
         * @return UpdateWorkspaceDocMembersResponse
         */
        public async Task<UpdateWorkspaceDocMembersResponse> UpdateWorkspaceDocMembersAsync(string workspaceId, string nodeId, UpdateWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkspaceDocMembersHeaders headers = new UpdateWorkspaceDocMembersHeaders();
            return await UpdateWorkspaceDocMembersWithOptionsAsync(workspaceId, nodeId, request, headers, runtime);
        }

        /**
         * @summary 更新知识库成员
         *
         * @param request UpdateWorkspaceMembersRequest
         * @param headers UpdateWorkspaceMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWorkspaceMembersResponse
         */
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

        /**
         * @summary 更新知识库成员
         *
         * @param request UpdateWorkspaceMembersRequest
         * @param headers UpdateWorkspaceMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWorkspaceMembersResponse
         */
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

        /**
         * @summary 更新知识库成员
         *
         * @param request UpdateWorkspaceMembersRequest
         * @return UpdateWorkspaceMembersResponse
         */
        public UpdateWorkspaceMembersResponse UpdateWorkspaceMembers(string workspaceId, UpdateWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkspaceMembersHeaders headers = new UpdateWorkspaceMembersHeaders();
            return UpdateWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 更新知识库成员
         *
         * @param request UpdateWorkspaceMembersRequest
         * @return UpdateWorkspaceMembersResponse
         */
        public async Task<UpdateWorkspaceMembersResponse> UpdateWorkspaceMembersAsync(string workspaceId, UpdateWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkspaceMembersHeaders headers = new UpdateWorkspaceMembersHeaders();
            return await UpdateWorkspaceMembersWithOptionsAsync(workspaceId, request, headers, runtime);
        }

    }
}
