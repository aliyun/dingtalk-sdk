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
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public AddWorkspaceDocMembersResponse AddWorkspaceDocMembers(string workspaceId, string nodeId, AddWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceDocMembersHeaders headers = new AddWorkspaceDocMembersHeaders();
            return AddWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
        }

        public async Task<AddWorkspaceDocMembersResponse> AddWorkspaceDocMembersAsync(string workspaceId, string nodeId, AddWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceDocMembersHeaders headers = new AddWorkspaceDocMembersHeaders();
            return await AddWorkspaceDocMembersWithOptionsAsync(workspaceId, nodeId, request, headers, runtime);
        }

        public AddWorkspaceDocMembersResponse AddWorkspaceDocMembersWithOptions(string workspaceId, string nodeId, AddWorkspaceDocMembersRequest request, AddWorkspaceDocMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            nodeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeId);
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
            return TeaModel.ToObject<AddWorkspaceDocMembersResponse>(DoROARequest("AddWorkspaceDocMembers", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + "/members", "none", req, runtime));
        }

        public async Task<AddWorkspaceDocMembersResponse> AddWorkspaceDocMembersWithOptionsAsync(string workspaceId, string nodeId, AddWorkspaceDocMembersRequest request, AddWorkspaceDocMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            nodeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeId);
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
            return TeaModel.ToObject<AddWorkspaceDocMembersResponse>(await DoROARequestAsync("AddWorkspaceDocMembers", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + "/members", "none", req, runtime));
        }

        public AddWorkspaceMembersResponse AddWorkspaceMembers(string workspaceId, AddWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceMembersHeaders headers = new AddWorkspaceMembersHeaders();
            return AddWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
        }

        public async Task<AddWorkspaceMembersResponse> AddWorkspaceMembersAsync(string workspaceId, AddWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceMembersHeaders headers = new AddWorkspaceMembersHeaders();
            return await AddWorkspaceMembersWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        public AddWorkspaceMembersResponse AddWorkspaceMembersWithOptions(string workspaceId, AddWorkspaceMembersRequest request, AddWorkspaceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
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
            return TeaModel.ToObject<AddWorkspaceMembersResponse>(DoROARequest("AddWorkspaceMembers", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/members", "json", req, runtime));
        }

        public async Task<AddWorkspaceMembersResponse> AddWorkspaceMembersWithOptionsAsync(string workspaceId, AddWorkspaceMembersRequest request, AddWorkspaceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
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
            return TeaModel.ToObject<AddWorkspaceMembersResponse>(await DoROARequestAsync("AddWorkspaceMembers", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/members", "json", req, runtime));
        }

        public AppendRowsResponse AppendRows(string workbookId, string sheetId, AppendRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendRowsHeaders headers = new AppendRowsHeaders();
            return AppendRowsWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        public async Task<AppendRowsResponse> AppendRowsAsync(string workbookId, string sheetId, AppendRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendRowsHeaders headers = new AppendRowsHeaders();
            return await AppendRowsWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        public AppendRowsResponse AppendRowsWithOptions(string workbookId, string sheetId, AppendRowsRequest request, AppendRowsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<AppendRowsResponse>(DoROARequest("AppendRows", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/appendRows", "none", req, runtime));
        }

        public async Task<AppendRowsResponse> AppendRowsWithOptionsAsync(string workbookId, string sheetId, AppendRowsRequest request, AppendRowsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<AppendRowsResponse>(await DoROARequestAsync("AppendRows", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/appendRows", "none", req, runtime));
        }

        public BatchGetWorkspaceDocsResponse BatchGetWorkspaceDocs(BatchGetWorkspaceDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetWorkspaceDocsHeaders headers = new BatchGetWorkspaceDocsHeaders();
            return BatchGetWorkspaceDocsWithOptions(request, headers, runtime);
        }

        public async Task<BatchGetWorkspaceDocsResponse> BatchGetWorkspaceDocsAsync(BatchGetWorkspaceDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetWorkspaceDocsHeaders headers = new BatchGetWorkspaceDocsHeaders();
            return await BatchGetWorkspaceDocsWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<BatchGetWorkspaceDocsResponse>(DoROARequest("BatchGetWorkspaceDocs", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/docs/infos/query", "json", req, runtime));
        }

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
            return TeaModel.ToObject<BatchGetWorkspaceDocsResponse>(await DoROARequestAsync("BatchGetWorkspaceDocs", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/docs/infos/query", "json", req, runtime));
        }

        public BatchGetWorkspacesResponse BatchGetWorkspaces(BatchGetWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetWorkspacesHeaders headers = new BatchGetWorkspacesHeaders();
            return BatchGetWorkspacesWithOptions(request, headers, runtime);
        }

        public async Task<BatchGetWorkspacesResponse> BatchGetWorkspacesAsync(BatchGetWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetWorkspacesHeaders headers = new BatchGetWorkspacesHeaders();
            return await BatchGetWorkspacesWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<BatchGetWorkspacesResponse>(DoROARequest("BatchGetWorkspaces", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/infos/query", "json", req, runtime));
        }

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
            return TeaModel.ToObject<BatchGetWorkspacesResponse>(await DoROARequestAsync("BatchGetWorkspaces", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/infos/query", "json", req, runtime));
        }

        public ClearResponse Clear(string workbookId, string sheetId, string rangeAddress, ClearRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearHeaders headers = new ClearHeaders();
            return ClearWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        public async Task<ClearResponse> ClearAsync(string workbookId, string sheetId, string rangeAddress, ClearRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearHeaders headers = new ClearHeaders();
            return await ClearWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        public ClearResponse ClearWithOptions(string workbookId, string sheetId, string rangeAddress, ClearRequest request, ClearHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
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
            return TeaModel.ToObject<ClearResponse>(DoROARequest("Clear", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/clear", "json", req, runtime));
        }

        public async Task<ClearResponse> ClearWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, ClearRequest request, ClearHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
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
            return TeaModel.ToObject<ClearResponse>(await DoROARequestAsync("Clear", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/clear", "json", req, runtime));
        }

        public ClearDataResponse ClearData(string workbookId, string sheetId, string rangeAddress, ClearDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearDataHeaders headers = new ClearDataHeaders();
            return ClearDataWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        public async Task<ClearDataResponse> ClearDataAsync(string workbookId, string sheetId, string rangeAddress, ClearDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ClearDataHeaders headers = new ClearDataHeaders();
            return await ClearDataWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        public ClearDataResponse ClearDataWithOptions(string workbookId, string sheetId, string rangeAddress, ClearDataRequest request, ClearDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
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
            return TeaModel.ToObject<ClearDataResponse>(DoROARequest("ClearData", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/clearData", "json", req, runtime));
        }

        public async Task<ClearDataResponse> ClearDataWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, ClearDataRequest request, ClearDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
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
            return TeaModel.ToObject<ClearDataResponse>(await DoROARequestAsync("ClearData", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/clearData", "json", req, runtime));
        }

        public CreateConditionalFormattingRuleResponse CreateConditionalFormattingRule(string workbookId, string sheetId, CreateConditionalFormattingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateConditionalFormattingRuleHeaders headers = new CreateConditionalFormattingRuleHeaders();
            return CreateConditionalFormattingRuleWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        public async Task<CreateConditionalFormattingRuleResponse> CreateConditionalFormattingRuleAsync(string workbookId, string sheetId, CreateConditionalFormattingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateConditionalFormattingRuleHeaders headers = new CreateConditionalFormattingRuleHeaders();
            return await CreateConditionalFormattingRuleWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        public CreateConditionalFormattingRuleResponse CreateConditionalFormattingRuleWithOptions(string workbookId, string sheetId, CreateConditionalFormattingRuleRequest request, CreateConditionalFormattingRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<CreateConditionalFormattingRuleResponse>(DoROARequest("CreateConditionalFormattingRule", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/conditionalFormattingRules", "json", req, runtime));
        }

        public async Task<CreateConditionalFormattingRuleResponse> CreateConditionalFormattingRuleWithOptionsAsync(string workbookId, string sheetId, CreateConditionalFormattingRuleRequest request, CreateConditionalFormattingRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<CreateConditionalFormattingRuleResponse>(await DoROARequestAsync("CreateConditionalFormattingRule", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/conditionalFormattingRules", "json", req, runtime));
        }

        public CreateDeveloperMetadataResponse CreateDeveloperMetadata(string workbookId, CreateDeveloperMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeveloperMetadataHeaders headers = new CreateDeveloperMetadataHeaders();
            return CreateDeveloperMetadataWithOptions(workbookId, request, headers, runtime);
        }

        public async Task<CreateDeveloperMetadataResponse> CreateDeveloperMetadataAsync(string workbookId, CreateDeveloperMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeveloperMetadataHeaders headers = new CreateDeveloperMetadataHeaders();
            return await CreateDeveloperMetadataWithOptionsAsync(workbookId, request, headers, runtime);
        }

        public CreateDeveloperMetadataResponse CreateDeveloperMetadataWithOptions(string workbookId, CreateDeveloperMetadataRequest request, CreateDeveloperMetadataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
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
            return TeaModel.ToObject<CreateDeveloperMetadataResponse>(DoROARequest("CreateDeveloperMetadata", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/developerMetadatas", "json", req, runtime));
        }

        public async Task<CreateDeveloperMetadataResponse> CreateDeveloperMetadataWithOptionsAsync(string workbookId, CreateDeveloperMetadataRequest request, CreateDeveloperMetadataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
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
            return TeaModel.ToObject<CreateDeveloperMetadataResponse>(await DoROARequestAsync("CreateDeveloperMetadata", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/developerMetadatas", "json", req, runtime));
        }

        public CreateRangeProtectionResponse CreateRangeProtection(string workbookId, string sheetId, string rangeAddress, CreateRangeProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRangeProtectionHeaders headers = new CreateRangeProtectionHeaders();
            return CreateRangeProtectionWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        public async Task<CreateRangeProtectionResponse> CreateRangeProtectionAsync(string workbookId, string sheetId, string rangeAddress, CreateRangeProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRangeProtectionHeaders headers = new CreateRangeProtectionHeaders();
            return await CreateRangeProtectionWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        public CreateRangeProtectionResponse CreateRangeProtectionWithOptions(string workbookId, string sheetId, string rangeAddress, CreateRangeProtectionRequest request, CreateRangeProtectionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
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
            return TeaModel.ToObject<CreateRangeProtectionResponse>(DoROARequest("CreateRangeProtection", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/protections", "json", req, runtime));
        }

        public async Task<CreateRangeProtectionResponse> CreateRangeProtectionWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, CreateRangeProtectionRequest request, CreateRangeProtectionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
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
            return TeaModel.ToObject<CreateRangeProtectionResponse>(await DoROARequestAsync("CreateRangeProtection", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/protections", "json", req, runtime));
        }

        public CreateSheetResponse CreateSheet(string workbookId, CreateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSheetHeaders headers = new CreateSheetHeaders();
            return CreateSheetWithOptions(workbookId, request, headers, runtime);
        }

        public async Task<CreateSheetResponse> CreateSheetAsync(string workbookId, CreateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSheetHeaders headers = new CreateSheetHeaders();
            return await CreateSheetWithOptionsAsync(workbookId, request, headers, runtime);
        }

        public CreateSheetResponse CreateSheetWithOptions(string workbookId, CreateSheetRequest request, CreateSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
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
            return TeaModel.ToObject<CreateSheetResponse>(DoROARequest("CreateSheet", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets", "json", req, runtime));
        }

        public async Task<CreateSheetResponse> CreateSheetWithOptionsAsync(string workbookId, CreateSheetRequest request, CreateSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
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
            return TeaModel.ToObject<CreateSheetResponse>(await DoROARequestAsync("CreateSheet", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets", "json", req, runtime));
        }

        public CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkspaceHeaders headers = new CreateWorkspaceHeaders();
            return CreateWorkspaceWithOptions(request, headers, runtime);
        }

        public async Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkspaceHeaders headers = new CreateWorkspaceHeaders();
            return await CreateWorkspaceWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<CreateWorkspaceResponse>(DoROARequest("CreateWorkspace", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces", "json", req, runtime));
        }

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
            return TeaModel.ToObject<CreateWorkspaceResponse>(await DoROARequestAsync("CreateWorkspace", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces", "json", req, runtime));
        }

        public CreateWorkspaceDocResponse CreateWorkspaceDoc(string workspaceId, CreateWorkspaceDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkspaceDocHeaders headers = new CreateWorkspaceDocHeaders();
            return CreateWorkspaceDocWithOptions(workspaceId, request, headers, runtime);
        }

        public async Task<CreateWorkspaceDocResponse> CreateWorkspaceDocAsync(string workspaceId, CreateWorkspaceDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkspaceDocHeaders headers = new CreateWorkspaceDocHeaders();
            return await CreateWorkspaceDocWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        public CreateWorkspaceDocResponse CreateWorkspaceDocWithOptions(string workspaceId, CreateWorkspaceDocRequest request, CreateWorkspaceDocHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
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
            return TeaModel.ToObject<CreateWorkspaceDocResponse>(DoROARequest("CreateWorkspaceDoc", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/docs", "json", req, runtime));
        }

        public async Task<CreateWorkspaceDocResponse> CreateWorkspaceDocWithOptionsAsync(string workspaceId, CreateWorkspaceDocRequest request, CreateWorkspaceDocHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
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
            return TeaModel.ToObject<CreateWorkspaceDocResponse>(await DoROARequestAsync("CreateWorkspaceDoc", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/docs", "json", req, runtime));
        }

        public DeleteColumnsResponse DeleteColumns(string workbookId, string sheetId, DeleteColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteColumnsHeaders headers = new DeleteColumnsHeaders();
            return DeleteColumnsWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        public async Task<DeleteColumnsResponse> DeleteColumnsAsync(string workbookId, string sheetId, DeleteColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteColumnsHeaders headers = new DeleteColumnsHeaders();
            return await DeleteColumnsWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        public DeleteColumnsResponse DeleteColumnsWithOptions(string workbookId, string sheetId, DeleteColumnsRequest request, DeleteColumnsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<DeleteColumnsResponse>(DoROARequest("DeleteColumns", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/deleteColumns", "json", req, runtime));
        }

        public async Task<DeleteColumnsResponse> DeleteColumnsWithOptionsAsync(string workbookId, string sheetId, DeleteColumnsRequest request, DeleteColumnsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<DeleteColumnsResponse>(await DoROARequestAsync("DeleteColumns", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/deleteColumns", "json", req, runtime));
        }

        public DeleteDropdownListsResponse DeleteDropdownLists(string workbookId, string sheetId, string rangeAddress, DeleteDropdownListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDropdownListsHeaders headers = new DeleteDropdownListsHeaders();
            return DeleteDropdownListsWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        public async Task<DeleteDropdownListsResponse> DeleteDropdownListsAsync(string workbookId, string sheetId, string rangeAddress, DeleteDropdownListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDropdownListsHeaders headers = new DeleteDropdownListsHeaders();
            return await DeleteDropdownListsWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        public DeleteDropdownListsResponse DeleteDropdownListsWithOptions(string workbookId, string sheetId, string rangeAddress, DeleteDropdownListsRequest request, DeleteDropdownListsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
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
            return TeaModel.ToObject<DeleteDropdownListsResponse>(DoROARequest("DeleteDropdownLists", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/deleteDropdownLists", "json", req, runtime));
        }

        public async Task<DeleteDropdownListsResponse> DeleteDropdownListsWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, DeleteDropdownListsRequest request, DeleteDropdownListsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
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
            return TeaModel.ToObject<DeleteDropdownListsResponse>(await DoROARequestAsync("DeleteDropdownLists", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/deleteDropdownLists", "json", req, runtime));
        }

        public DeleteRangeProtectionResponse DeleteRangeProtection(string workbookId, string sheetId, string rangeAddress, string protectionId, DeleteRangeProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRangeProtectionHeaders headers = new DeleteRangeProtectionHeaders();
            return DeleteRangeProtectionWithOptions(workbookId, sheetId, rangeAddress, protectionId, request, headers, runtime);
        }

        public async Task<DeleteRangeProtectionResponse> DeleteRangeProtectionAsync(string workbookId, string sheetId, string rangeAddress, string protectionId, DeleteRangeProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRangeProtectionHeaders headers = new DeleteRangeProtectionHeaders();
            return await DeleteRangeProtectionWithOptionsAsync(workbookId, sheetId, rangeAddress, protectionId, request, headers, runtime);
        }

        public DeleteRangeProtectionResponse DeleteRangeProtectionWithOptions(string workbookId, string sheetId, string rangeAddress, string protectionId, DeleteRangeProtectionRequest request, DeleteRangeProtectionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
            protectionId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(protectionId);
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
            return TeaModel.ToObject<DeleteRangeProtectionResponse>(DoROARequest("DeleteRangeProtection", "doc_1.0", "HTTP", "DELETE", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/protections/" + protectionId, "json", req, runtime));
        }

        public async Task<DeleteRangeProtectionResponse> DeleteRangeProtectionWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, string protectionId, DeleteRangeProtectionRequest request, DeleteRangeProtectionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
            protectionId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(protectionId);
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
            return TeaModel.ToObject<DeleteRangeProtectionResponse>(await DoROARequestAsync("DeleteRangeProtection", "doc_1.0", "HTTP", "DELETE", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/protections/" + protectionId, "json", req, runtime));
        }

        public DeleteRowsResponse DeleteRows(string workbookId, string sheetId, DeleteRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRowsHeaders headers = new DeleteRowsHeaders();
            return DeleteRowsWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        public async Task<DeleteRowsResponse> DeleteRowsAsync(string workbookId, string sheetId, DeleteRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRowsHeaders headers = new DeleteRowsHeaders();
            return await DeleteRowsWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        public DeleteRowsResponse DeleteRowsWithOptions(string workbookId, string sheetId, DeleteRowsRequest request, DeleteRowsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<DeleteRowsResponse>(DoROARequest("DeleteRows", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/deleteRows", "json", req, runtime));
        }

        public async Task<DeleteRowsResponse> DeleteRowsWithOptionsAsync(string workbookId, string sheetId, DeleteRowsRequest request, DeleteRowsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<DeleteRowsResponse>(await DoROARequestAsync("DeleteRows", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/deleteRows", "json", req, runtime));
        }

        public DeleteSheetResponse DeleteSheet(string workbookId, string sheetId, DeleteSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSheetHeaders headers = new DeleteSheetHeaders();
            return DeleteSheetWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        public async Task<DeleteSheetResponse> DeleteSheetAsync(string workbookId, string sheetId, DeleteSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSheetHeaders headers = new DeleteSheetHeaders();
            return await DeleteSheetWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        public DeleteSheetResponse DeleteSheetWithOptions(string workbookId, string sheetId, DeleteSheetRequest request, DeleteSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<DeleteSheetResponse>(DoROARequest("DeleteSheet", "doc_1.0", "HTTP", "DELETE", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId, "json", req, runtime));
        }

        public async Task<DeleteSheetResponse> DeleteSheetWithOptionsAsync(string workbookId, string sheetId, DeleteSheetRequest request, DeleteSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<DeleteSheetResponse>(await DoROARequestAsync("DeleteSheet", "doc_1.0", "HTTP", "DELETE", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId, "json", req, runtime));
        }

        public DeleteWorkspaceDocResponse DeleteWorkspaceDoc(string workspaceId, string nodeId, DeleteWorkspaceDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceDocHeaders headers = new DeleteWorkspaceDocHeaders();
            return DeleteWorkspaceDocWithOptions(workspaceId, nodeId, request, headers, runtime);
        }

        public async Task<DeleteWorkspaceDocResponse> DeleteWorkspaceDocAsync(string workspaceId, string nodeId, DeleteWorkspaceDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceDocHeaders headers = new DeleteWorkspaceDocHeaders();
            return await DeleteWorkspaceDocWithOptionsAsync(workspaceId, nodeId, request, headers, runtime);
        }

        public DeleteWorkspaceDocResponse DeleteWorkspaceDocWithOptions(string workspaceId, string nodeId, DeleteWorkspaceDocRequest request, DeleteWorkspaceDocHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            nodeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeId);
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
            return TeaModel.ToObject<DeleteWorkspaceDocResponse>(DoROARequest("DeleteWorkspaceDoc", "doc_1.0", "HTTP", "DELETE", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId, "none", req, runtime));
        }

        public async Task<DeleteWorkspaceDocResponse> DeleteWorkspaceDocWithOptionsAsync(string workspaceId, string nodeId, DeleteWorkspaceDocRequest request, DeleteWorkspaceDocHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            nodeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeId);
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
            return TeaModel.ToObject<DeleteWorkspaceDocResponse>(await DoROARequestAsync("DeleteWorkspaceDoc", "doc_1.0", "HTTP", "DELETE", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId, "none", req, runtime));
        }

        public DeleteWorkspaceDocMembersResponse DeleteWorkspaceDocMembers(string workspaceId, string nodeId, DeleteWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceDocMembersHeaders headers = new DeleteWorkspaceDocMembersHeaders();
            return DeleteWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
        }

        public async Task<DeleteWorkspaceDocMembersResponse> DeleteWorkspaceDocMembersAsync(string workspaceId, string nodeId, DeleteWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceDocMembersHeaders headers = new DeleteWorkspaceDocMembersHeaders();
            return await DeleteWorkspaceDocMembersWithOptionsAsync(workspaceId, nodeId, request, headers, runtime);
        }

        public DeleteWorkspaceDocMembersResponse DeleteWorkspaceDocMembersWithOptions(string workspaceId, string nodeId, DeleteWorkspaceDocMembersRequest request, DeleteWorkspaceDocMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            nodeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeId);
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
            return TeaModel.ToObject<DeleteWorkspaceDocMembersResponse>(DoROARequest("DeleteWorkspaceDocMembers", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + "/members/remove", "none", req, runtime));
        }

        public async Task<DeleteWorkspaceDocMembersResponse> DeleteWorkspaceDocMembersWithOptionsAsync(string workspaceId, string nodeId, DeleteWorkspaceDocMembersRequest request, DeleteWorkspaceDocMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            nodeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeId);
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
            return TeaModel.ToObject<DeleteWorkspaceDocMembersResponse>(await DoROARequestAsync("DeleteWorkspaceDocMembers", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + "/members/remove", "none", req, runtime));
        }

        public DeleteWorkspaceMembersResponse DeleteWorkspaceMembers(string workspaceId, DeleteWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceMembersHeaders headers = new DeleteWorkspaceMembersHeaders();
            return DeleteWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
        }

        public async Task<DeleteWorkspaceMembersResponse> DeleteWorkspaceMembersAsync(string workspaceId, DeleteWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceMembersHeaders headers = new DeleteWorkspaceMembersHeaders();
            return await DeleteWorkspaceMembersWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        public DeleteWorkspaceMembersResponse DeleteWorkspaceMembersWithOptions(string workspaceId, DeleteWorkspaceMembersRequest request, DeleteWorkspaceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
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
            return TeaModel.ToObject<DeleteWorkspaceMembersResponse>(DoROARequest("DeleteWorkspaceMembers", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/members/remove", "none", req, runtime));
        }

        public async Task<DeleteWorkspaceMembersResponse> DeleteWorkspaceMembersWithOptionsAsync(string workspaceId, DeleteWorkspaceMembersRequest request, DeleteWorkspaceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
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
            return TeaModel.ToObject<DeleteWorkspaceMembersResponse>(await DoROARequestAsync("DeleteWorkspaceMembers", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/members/remove", "none", req, runtime));
        }

        public GetAllSheetsResponse GetAllSheets(string workbookId, GetAllSheetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllSheetsHeaders headers = new GetAllSheetsHeaders();
            return GetAllSheetsWithOptions(workbookId, request, headers, runtime);
        }

        public async Task<GetAllSheetsResponse> GetAllSheetsAsync(string workbookId, GetAllSheetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllSheetsHeaders headers = new GetAllSheetsHeaders();
            return await GetAllSheetsWithOptionsAsync(workbookId, request, headers, runtime);
        }

        public GetAllSheetsResponse GetAllSheetsWithOptions(string workbookId, GetAllSheetsRequest request, GetAllSheetsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
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
            return TeaModel.ToObject<GetAllSheetsResponse>(DoROARequest("GetAllSheets", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets", "json", req, runtime));
        }

        public async Task<GetAllSheetsResponse> GetAllSheetsWithOptionsAsync(string workbookId, GetAllSheetsRequest request, GetAllSheetsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
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
            return TeaModel.ToObject<GetAllSheetsResponse>(await DoROARequestAsync("GetAllSheets", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets", "json", req, runtime));
        }

        public GetDeveloperMetadataResponse GetDeveloperMetadata(string workbookId, string developerMetadataId, GetDeveloperMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeveloperMetadataHeaders headers = new GetDeveloperMetadataHeaders();
            return GetDeveloperMetadataWithOptions(workbookId, developerMetadataId, request, headers, runtime);
        }

        public async Task<GetDeveloperMetadataResponse> GetDeveloperMetadataAsync(string workbookId, string developerMetadataId, GetDeveloperMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeveloperMetadataHeaders headers = new GetDeveloperMetadataHeaders();
            return await GetDeveloperMetadataWithOptionsAsync(workbookId, developerMetadataId, request, headers, runtime);
        }

        public GetDeveloperMetadataResponse GetDeveloperMetadataWithOptions(string workbookId, string developerMetadataId, GetDeveloperMetadataRequest request, GetDeveloperMetadataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            developerMetadataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(developerMetadataId);
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
            return TeaModel.ToObject<GetDeveloperMetadataResponse>(DoROARequest("GetDeveloperMetadata", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workbooks/" + workbookId + "/developerMetadatas/" + developerMetadataId, "json", req, runtime));
        }

        public async Task<GetDeveloperMetadataResponse> GetDeveloperMetadataWithOptionsAsync(string workbookId, string developerMetadataId, GetDeveloperMetadataRequest request, GetDeveloperMetadataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            developerMetadataId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(developerMetadataId);
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
            return TeaModel.ToObject<GetDeveloperMetadataResponse>(await DoROARequestAsync("GetDeveloperMetadata", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workbooks/" + workbookId + "/developerMetadatas/" + developerMetadataId, "json", req, runtime));
        }

        public GetRangeResponse GetRange(string workbookId, string sheetId, string rangeAddress, GetRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRangeHeaders headers = new GetRangeHeaders();
            return GetRangeWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        public async Task<GetRangeResponse> GetRangeAsync(string workbookId, string sheetId, string rangeAddress, GetRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRangeHeaders headers = new GetRangeHeaders();
            return await GetRangeWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        public GetRangeResponse GetRangeWithOptions(string workbookId, string sheetId, string rangeAddress, GetRangeRequest request, GetRangeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
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
            return TeaModel.ToObject<GetRangeResponse>(DoROARequest("GetRange", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress, "json", req, runtime));
        }

        public async Task<GetRangeResponse> GetRangeWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, GetRangeRequest request, GetRangeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
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
            return TeaModel.ToObject<GetRangeResponse>(await DoROARequestAsync("GetRange", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress, "json", req, runtime));
        }

        public GetRecentEditDocsResponse GetRecentEditDocs(GetRecentEditDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecentEditDocsHeaders headers = new GetRecentEditDocsHeaders();
            return GetRecentEditDocsWithOptions(request, headers, runtime);
        }

        public async Task<GetRecentEditDocsResponse> GetRecentEditDocsAsync(GetRecentEditDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecentEditDocsHeaders headers = new GetRecentEditDocsHeaders();
            return await GetRecentEditDocsWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<GetRecentEditDocsResponse>(DoROARequest("GetRecentEditDocs", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workspaces/docs/recentEditDocs", "json", req, runtime));
        }

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
            return TeaModel.ToObject<GetRecentEditDocsResponse>(await DoROARequestAsync("GetRecentEditDocs", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workspaces/docs/recentEditDocs", "json", req, runtime));
        }

        public GetRecentOpenDocsResponse GetRecentOpenDocs(GetRecentOpenDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecentOpenDocsHeaders headers = new GetRecentOpenDocsHeaders();
            return GetRecentOpenDocsWithOptions(request, headers, runtime);
        }

        public async Task<GetRecentOpenDocsResponse> GetRecentOpenDocsAsync(GetRecentOpenDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecentOpenDocsHeaders headers = new GetRecentOpenDocsHeaders();
            return await GetRecentOpenDocsWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<GetRecentOpenDocsResponse>(DoROARequest("GetRecentOpenDocs", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workspaces/docs/recentOpenDocs", "json", req, runtime));
        }

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
            return TeaModel.ToObject<GetRecentOpenDocsResponse>(await DoROARequestAsync("GetRecentOpenDocs", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workspaces/docs/recentOpenDocs", "json", req, runtime));
        }

        public GetRelatedWorkspacesResponse GetRelatedWorkspaces(GetRelatedWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRelatedWorkspacesHeaders headers = new GetRelatedWorkspacesHeaders();
            return GetRelatedWorkspacesWithOptions(request, headers, runtime);
        }

        public async Task<GetRelatedWorkspacesResponse> GetRelatedWorkspacesAsync(GetRelatedWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRelatedWorkspacesHeaders headers = new GetRelatedWorkspacesHeaders();
            return await GetRelatedWorkspacesWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<GetRelatedWorkspacesResponse>(DoROARequest("GetRelatedWorkspaces", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workspaces", "json", req, runtime));
        }

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
            return TeaModel.ToObject<GetRelatedWorkspacesResponse>(await DoROARequestAsync("GetRelatedWorkspaces", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workspaces", "json", req, runtime));
        }

        public GetSheetResponse GetSheet(string workbookId, string sheetId, GetSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSheetHeaders headers = new GetSheetHeaders();
            return GetSheetWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        public async Task<GetSheetResponse> GetSheetAsync(string workbookId, string sheetId, GetSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSheetHeaders headers = new GetSheetHeaders();
            return await GetSheetWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        public GetSheetResponse GetSheetWithOptions(string workbookId, string sheetId, GetSheetRequest request, GetSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<GetSheetResponse>(DoROARequest("GetSheet", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId, "json", req, runtime));
        }

        public async Task<GetSheetResponse> GetSheetWithOptionsAsync(string workbookId, string sheetId, GetSheetRequest request, GetSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<GetSheetResponse>(await DoROARequestAsync("GetSheet", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId, "json", req, runtime));
        }

        public GetTemplateByIdResponse GetTemplateById(string templateId, GetTemplateByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTemplateByIdHeaders headers = new GetTemplateByIdHeaders();
            return GetTemplateByIdWithOptions(templateId, request, headers, runtime);
        }

        public async Task<GetTemplateByIdResponse> GetTemplateByIdAsync(string templateId, GetTemplateByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTemplateByIdHeaders headers = new GetTemplateByIdHeaders();
            return await GetTemplateByIdWithOptionsAsync(templateId, request, headers, runtime);
        }

        public GetTemplateByIdResponse GetTemplateByIdWithOptions(string templateId, GetTemplateByIdRequest request, GetTemplateByIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            templateId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateId);
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
            return TeaModel.ToObject<GetTemplateByIdResponse>(DoROARequest("GetTemplateById", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/templates/" + templateId, "json", req, runtime));
        }

        public async Task<GetTemplateByIdResponse> GetTemplateByIdWithOptionsAsync(string templateId, GetTemplateByIdRequest request, GetTemplateByIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            templateId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateId);
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
            return TeaModel.ToObject<GetTemplateByIdResponse>(await DoROARequestAsync("GetTemplateById", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/templates/" + templateId, "json", req, runtime));
        }

        public GetWorkspaceResponse GetWorkspace(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspaceHeaders headers = new GetWorkspaceHeaders();
            return GetWorkspaceWithOptions(workspaceId, headers, runtime);
        }

        public async Task<GetWorkspaceResponse> GetWorkspaceAsync(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspaceHeaders headers = new GetWorkspaceHeaders();
            return await GetWorkspaceWithOptionsAsync(workspaceId, headers, runtime);
        }

        public GetWorkspaceResponse GetWorkspaceWithOptions(string workspaceId, GetWorkspaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<GetWorkspaceResponse>(DoROARequest("GetWorkspace", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workspaces/" + workspaceId, "json", req, runtime));
        }

        public async Task<GetWorkspaceResponse> GetWorkspaceWithOptionsAsync(string workspaceId, GetWorkspaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<GetWorkspaceResponse>(await DoROARequestAsync("GetWorkspace", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workspaces/" + workspaceId, "json", req, runtime));
        }

        public GetWorkspaceNodeResponse GetWorkspaceNode(string workspaceId, string nodeId, GetWorkspaceNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspaceNodeHeaders headers = new GetWorkspaceNodeHeaders();
            return GetWorkspaceNodeWithOptions(workspaceId, nodeId, request, headers, runtime);
        }

        public async Task<GetWorkspaceNodeResponse> GetWorkspaceNodeAsync(string workspaceId, string nodeId, GetWorkspaceNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspaceNodeHeaders headers = new GetWorkspaceNodeHeaders();
            return await GetWorkspaceNodeWithOptionsAsync(workspaceId, nodeId, request, headers, runtime);
        }

        public GetWorkspaceNodeResponse GetWorkspaceNodeWithOptions(string workspaceId, string nodeId, GetWorkspaceNodeRequest request, GetWorkspaceNodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            nodeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeId);
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
            return TeaModel.ToObject<GetWorkspaceNodeResponse>(DoROARequest("GetWorkspaceNode", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId, "json", req, runtime));
        }

        public async Task<GetWorkspaceNodeResponse> GetWorkspaceNodeWithOptionsAsync(string workspaceId, string nodeId, GetWorkspaceNodeRequest request, GetWorkspaceNodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            nodeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeId);
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
            return TeaModel.ToObject<GetWorkspaceNodeResponse>(await DoROARequestAsync("GetWorkspaceNode", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId, "json", req, runtime));
        }

        public InsertBlocksResponse InsertBlocks(string documentId, InsertBlocksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertBlocksHeaders headers = new InsertBlocksHeaders();
            return InsertBlocksWithOptions(documentId, request, headers, runtime);
        }

        public async Task<InsertBlocksResponse> InsertBlocksAsync(string documentId, InsertBlocksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertBlocksHeaders headers = new InsertBlocksHeaders();
            return await InsertBlocksWithOptionsAsync(documentId, request, headers, runtime);
        }

        public InsertBlocksResponse InsertBlocksWithOptions(string documentId, InsertBlocksRequest request, InsertBlocksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            documentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(documentId);
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
            return TeaModel.ToObject<InsertBlocksResponse>(DoROARequest("InsertBlocks", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/documents/" + documentId + "/blocks", "none", req, runtime));
        }

        public async Task<InsertBlocksResponse> InsertBlocksWithOptionsAsync(string documentId, InsertBlocksRequest request, InsertBlocksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            documentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(documentId);
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
            return TeaModel.ToObject<InsertBlocksResponse>(await DoROARequestAsync("InsertBlocks", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/documents/" + documentId + "/blocks", "none", req, runtime));
        }

        public InsertColumnsBeforeResponse InsertColumnsBefore(string workbookId, string sheetId, InsertColumnsBeforeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertColumnsBeforeHeaders headers = new InsertColumnsBeforeHeaders();
            return InsertColumnsBeforeWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        public async Task<InsertColumnsBeforeResponse> InsertColumnsBeforeAsync(string workbookId, string sheetId, InsertColumnsBeforeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertColumnsBeforeHeaders headers = new InsertColumnsBeforeHeaders();
            return await InsertColumnsBeforeWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        public InsertColumnsBeforeResponse InsertColumnsBeforeWithOptions(string workbookId, string sheetId, InsertColumnsBeforeRequest request, InsertColumnsBeforeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<InsertColumnsBeforeResponse>(DoROARequest("InsertColumnsBefore", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/insertColumnsBefore", "json", req, runtime));
        }

        public async Task<InsertColumnsBeforeResponse> InsertColumnsBeforeWithOptionsAsync(string workbookId, string sheetId, InsertColumnsBeforeRequest request, InsertColumnsBeforeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<InsertColumnsBeforeResponse>(await DoROARequestAsync("InsertColumnsBefore", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/insertColumnsBefore", "json", req, runtime));
        }

        public InsertDropdownListsResponse InsertDropdownLists(string workbookId, string sheetId, string rangeAddress, InsertDropdownListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertDropdownListsHeaders headers = new InsertDropdownListsHeaders();
            return InsertDropdownListsWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        public async Task<InsertDropdownListsResponse> InsertDropdownListsAsync(string workbookId, string sheetId, string rangeAddress, InsertDropdownListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertDropdownListsHeaders headers = new InsertDropdownListsHeaders();
            return await InsertDropdownListsWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        public InsertDropdownListsResponse InsertDropdownListsWithOptions(string workbookId, string sheetId, string rangeAddress, InsertDropdownListsRequest request, InsertDropdownListsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
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
            return TeaModel.ToObject<InsertDropdownListsResponse>(DoROARequest("InsertDropdownLists", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/insertDropdownLists", "json", req, runtime));
        }

        public async Task<InsertDropdownListsResponse> InsertDropdownListsWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, InsertDropdownListsRequest request, InsertDropdownListsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
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
            return TeaModel.ToObject<InsertDropdownListsResponse>(await DoROARequestAsync("InsertDropdownLists", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/insertDropdownLists", "json", req, runtime));
        }

        public InsertRowsBeforeResponse InsertRowsBefore(string workbookId, string sheetId, InsertRowsBeforeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertRowsBeforeHeaders headers = new InsertRowsBeforeHeaders();
            return InsertRowsBeforeWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        public async Task<InsertRowsBeforeResponse> InsertRowsBeforeAsync(string workbookId, string sheetId, InsertRowsBeforeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertRowsBeforeHeaders headers = new InsertRowsBeforeHeaders();
            return await InsertRowsBeforeWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        public InsertRowsBeforeResponse InsertRowsBeforeWithOptions(string workbookId, string sheetId, InsertRowsBeforeRequest request, InsertRowsBeforeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<InsertRowsBeforeResponse>(DoROARequest("InsertRowsBefore", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/insertRowsBefore", "json", req, runtime));
        }

        public async Task<InsertRowsBeforeResponse> InsertRowsBeforeWithOptionsAsync(string workbookId, string sheetId, InsertRowsBeforeRequest request, InsertRowsBeforeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<InsertRowsBeforeResponse>(await DoROARequestAsync("InsertRowsBefore", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/insertRowsBefore", "json", req, runtime));
        }

        public ListTemplateResponse ListTemplate(ListTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTemplateHeaders headers = new ListTemplateHeaders();
            return ListTemplateWithOptions(request, headers, runtime);
        }

        public async Task<ListTemplateResponse> ListTemplateAsync(ListTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTemplateHeaders headers = new ListTemplateHeaders();
            return await ListTemplateWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<ListTemplateResponse>(DoROARequest("ListTemplate", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/templates", "json", req, runtime));
        }

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
            return TeaModel.ToObject<ListTemplateResponse>(await DoROARequestAsync("ListTemplate", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/templates", "json", req, runtime));
        }

        public MergeRangeResponse MergeRange(string workbookId, string sheetId, string rangeAddress, MergeRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MergeRangeHeaders headers = new MergeRangeHeaders();
            return MergeRangeWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        public async Task<MergeRangeResponse> MergeRangeAsync(string workbookId, string sheetId, string rangeAddress, MergeRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MergeRangeHeaders headers = new MergeRangeHeaders();
            return await MergeRangeWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        public MergeRangeResponse MergeRangeWithOptions(string workbookId, string sheetId, string rangeAddress, MergeRangeRequest request, MergeRangeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
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
            return TeaModel.ToObject<MergeRangeResponse>(DoROARequest("MergeRange", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/merge", "json", req, runtime));
        }

        public async Task<MergeRangeResponse> MergeRangeWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, MergeRangeRequest request, MergeRangeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
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
            return TeaModel.ToObject<MergeRangeResponse>(await DoROARequestAsync("MergeRange", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/merge", "json", req, runtime));
        }

        public RangeFindNextResponse RangeFindNext(string workbookId, string sheetId, string rangeAddress, RangeFindNextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RangeFindNextHeaders headers = new RangeFindNextHeaders();
            return RangeFindNextWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        public async Task<RangeFindNextResponse> RangeFindNextAsync(string workbookId, string sheetId, string rangeAddress, RangeFindNextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RangeFindNextHeaders headers = new RangeFindNextHeaders();
            return await RangeFindNextWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        public RangeFindNextResponse RangeFindNextWithOptions(string workbookId, string sheetId, string rangeAddress, RangeFindNextRequest request, RangeFindNextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
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
            return TeaModel.ToObject<RangeFindNextResponse>(DoROARequest("RangeFindNext", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/findNext", "json", req, runtime));
        }

        public async Task<RangeFindNextResponse> RangeFindNextWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, RangeFindNextRequest request, RangeFindNextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
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
            return TeaModel.ToObject<RangeFindNextResponse>(await DoROARequestAsync("RangeFindNext", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress + "/findNext", "json", req, runtime));
        }

        public SearchWorkspaceDocsResponse SearchWorkspaceDocs(SearchWorkspaceDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchWorkspaceDocsHeaders headers = new SearchWorkspaceDocsHeaders();
            return SearchWorkspaceDocsWithOptions(request, headers, runtime);
        }

        public async Task<SearchWorkspaceDocsResponse> SearchWorkspaceDocsAsync(SearchWorkspaceDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchWorkspaceDocsHeaders headers = new SearchWorkspaceDocsHeaders();
            return await SearchWorkspaceDocsWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<SearchWorkspaceDocsResponse>(DoROARequest("SearchWorkspaceDocs", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/docs", "json", req, runtime));
        }

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
            return TeaModel.ToObject<SearchWorkspaceDocsResponse>(await DoROARequestAsync("SearchWorkspaceDocs", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/docs", "json", req, runtime));
        }

        public SetColumnsVisibilityResponse SetColumnsVisibility(string workbookId, string sheetId, SetColumnsVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetColumnsVisibilityHeaders headers = new SetColumnsVisibilityHeaders();
            return SetColumnsVisibilityWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        public async Task<SetColumnsVisibilityResponse> SetColumnsVisibilityAsync(string workbookId, string sheetId, SetColumnsVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetColumnsVisibilityHeaders headers = new SetColumnsVisibilityHeaders();
            return await SetColumnsVisibilityWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        public SetColumnsVisibilityResponse SetColumnsVisibilityWithOptions(string workbookId, string sheetId, SetColumnsVisibilityRequest request, SetColumnsVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<SetColumnsVisibilityResponse>(DoROARequest("SetColumnsVisibility", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setColumnsVisibility", "json", req, runtime));
        }

        public async Task<SetColumnsVisibilityResponse> SetColumnsVisibilityWithOptionsAsync(string workbookId, string sheetId, SetColumnsVisibilityRequest request, SetColumnsVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<SetColumnsVisibilityResponse>(await DoROARequestAsync("SetColumnsVisibility", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setColumnsVisibility", "json", req, runtime));
        }

        public SetRowsVisibilityResponse SetRowsVisibility(string workbookId, string sheetId, SetRowsVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRowsVisibilityHeaders headers = new SetRowsVisibilityHeaders();
            return SetRowsVisibilityWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        public async Task<SetRowsVisibilityResponse> SetRowsVisibilityAsync(string workbookId, string sheetId, SetRowsVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRowsVisibilityHeaders headers = new SetRowsVisibilityHeaders();
            return await SetRowsVisibilityWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        public SetRowsVisibilityResponse SetRowsVisibilityWithOptions(string workbookId, string sheetId, SetRowsVisibilityRequest request, SetRowsVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<SetRowsVisibilityResponse>(DoROARequest("SetRowsVisibility", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setRowsVisibility", "json", req, runtime));
        }

        public async Task<SetRowsVisibilityResponse> SetRowsVisibilityWithOptionsAsync(string workbookId, string sheetId, SetRowsVisibilityRequest request, SetRowsVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<SetRowsVisibilityResponse>(await DoROARequestAsync("SetRowsVisibility", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/setRowsVisibility", "json", req, runtime));
        }

        public SheetAutofitRowsResponse SheetAutofitRows(string workbookId, string sheetId, SheetAutofitRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SheetAutofitRowsHeaders headers = new SheetAutofitRowsHeaders();
            return SheetAutofitRowsWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        public async Task<SheetAutofitRowsResponse> SheetAutofitRowsAsync(string workbookId, string sheetId, SheetAutofitRowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SheetAutofitRowsHeaders headers = new SheetAutofitRowsHeaders();
            return await SheetAutofitRowsWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        public SheetAutofitRowsResponse SheetAutofitRowsWithOptions(string workbookId, string sheetId, SheetAutofitRowsRequest request, SheetAutofitRowsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<SheetAutofitRowsResponse>(DoROARequest("SheetAutofitRows", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/autofitRows", "json", req, runtime));
        }

        public async Task<SheetAutofitRowsResponse> SheetAutofitRowsWithOptionsAsync(string workbookId, string sheetId, SheetAutofitRowsRequest request, SheetAutofitRowsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<SheetAutofitRowsResponse>(await DoROARequestAsync("SheetAutofitRows", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/autofitRows", "json", req, runtime));
        }

        public SheetFindAllResponse SheetFindAll(string workbookId, string sheetId, SheetFindAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SheetFindAllHeaders headers = new SheetFindAllHeaders();
            return SheetFindAllWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        public async Task<SheetFindAllResponse> SheetFindAllAsync(string workbookId, string sheetId, SheetFindAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SheetFindAllHeaders headers = new SheetFindAllHeaders();
            return await SheetFindAllWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        public SheetFindAllResponse SheetFindAllWithOptions(string workbookId, string sheetId, SheetFindAllRequest request, SheetFindAllHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<SheetFindAllResponse>(DoROARequest("SheetFindAll", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/findAll", "json", req, runtime));
        }

        public async Task<SheetFindAllResponse> SheetFindAllWithOptionsAsync(string workbookId, string sheetId, SheetFindAllRequest request, SheetFindAllHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<SheetFindAllResponse>(await DoROARequestAsync("SheetFindAll", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/findAll", "json", req, runtime));
        }

        public UpdateRangeResponse UpdateRange(string workbookId, string sheetId, string rangeAddress, UpdateRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRangeHeaders headers = new UpdateRangeHeaders();
            return UpdateRangeWithOptions(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        public async Task<UpdateRangeResponse> UpdateRangeAsync(string workbookId, string sheetId, string rangeAddress, UpdateRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRangeHeaders headers = new UpdateRangeHeaders();
            return await UpdateRangeWithOptionsAsync(workbookId, sheetId, rangeAddress, request, headers, runtime);
        }

        public UpdateRangeResponse UpdateRangeWithOptions(string workbookId, string sheetId, string rangeAddress, UpdateRangeRequest request, UpdateRangeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<UpdateRangeResponse>(DoROARequest("UpdateRange", "doc_1.0", "HTTP", "PUT", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress, "json", req, runtime));
        }

        public async Task<UpdateRangeResponse> UpdateRangeWithOptionsAsync(string workbookId, string sheetId, string rangeAddress, UpdateRangeRequest request, UpdateRangeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
            rangeAddress = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rangeAddress);
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<UpdateRangeResponse>(await DoROARequestAsync("UpdateRange", "doc_1.0", "HTTP", "PUT", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId + "/ranges/" + rangeAddress, "json", req, runtime));
        }

        public UpdateSheetResponse UpdateSheet(string workbookId, string sheetId, UpdateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSheetHeaders headers = new UpdateSheetHeaders();
            return UpdateSheetWithOptions(workbookId, sheetId, request, headers, runtime);
        }

        public async Task<UpdateSheetResponse> UpdateSheetAsync(string workbookId, string sheetId, UpdateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSheetHeaders headers = new UpdateSheetHeaders();
            return await UpdateSheetWithOptionsAsync(workbookId, sheetId, request, headers, runtime);
        }

        public UpdateSheetResponse UpdateSheetWithOptions(string workbookId, string sheetId, UpdateSheetRequest request, UpdateSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<UpdateSheetResponse>(DoROARequest("UpdateSheet", "doc_1.0", "HTTP", "PUT", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId, "none", req, runtime));
        }

        public async Task<UpdateSheetResponse> UpdateSheetWithOptionsAsync(string workbookId, string sheetId, UpdateSheetRequest request, UpdateSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workbookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workbookId);
            sheetId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sheetId);
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
            return TeaModel.ToObject<UpdateSheetResponse>(await DoROARequestAsync("UpdateSheet", "doc_1.0", "HTTP", "PUT", "AK", "/v1.0/doc/workbooks/" + workbookId + "/sheets/" + sheetId, "none", req, runtime));
        }

        public UpdateWorkspaceDocMembersResponse UpdateWorkspaceDocMembers(string workspaceId, string nodeId, UpdateWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkspaceDocMembersHeaders headers = new UpdateWorkspaceDocMembersHeaders();
            return UpdateWorkspaceDocMembersWithOptions(workspaceId, nodeId, request, headers, runtime);
        }

        public async Task<UpdateWorkspaceDocMembersResponse> UpdateWorkspaceDocMembersAsync(string workspaceId, string nodeId, UpdateWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkspaceDocMembersHeaders headers = new UpdateWorkspaceDocMembersHeaders();
            return await UpdateWorkspaceDocMembersWithOptionsAsync(workspaceId, nodeId, request, headers, runtime);
        }

        public UpdateWorkspaceDocMembersResponse UpdateWorkspaceDocMembersWithOptions(string workspaceId, string nodeId, UpdateWorkspaceDocMembersRequest request, UpdateWorkspaceDocMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            nodeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeId);
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
            return TeaModel.ToObject<UpdateWorkspaceDocMembersResponse>(DoROARequest("UpdateWorkspaceDocMembers", "doc_1.0", "HTTP", "PUT", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + "/members", "none", req, runtime));
        }

        public async Task<UpdateWorkspaceDocMembersResponse> UpdateWorkspaceDocMembersWithOptionsAsync(string workspaceId, string nodeId, UpdateWorkspaceDocMembersRequest request, UpdateWorkspaceDocMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            nodeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeId);
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
            return TeaModel.ToObject<UpdateWorkspaceDocMembersResponse>(await DoROARequestAsync("UpdateWorkspaceDocMembers", "doc_1.0", "HTTP", "PUT", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + "/members", "none", req, runtime));
        }

        public UpdateWorkspaceMembersResponse UpdateWorkspaceMembers(string workspaceId, UpdateWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkspaceMembersHeaders headers = new UpdateWorkspaceMembersHeaders();
            return UpdateWorkspaceMembersWithOptions(workspaceId, request, headers, runtime);
        }

        public async Task<UpdateWorkspaceMembersResponse> UpdateWorkspaceMembersAsync(string workspaceId, UpdateWorkspaceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkspaceMembersHeaders headers = new UpdateWorkspaceMembersHeaders();
            return await UpdateWorkspaceMembersWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        public UpdateWorkspaceMembersResponse UpdateWorkspaceMembersWithOptions(string workspaceId, UpdateWorkspaceMembersRequest request, UpdateWorkspaceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
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
            return TeaModel.ToObject<UpdateWorkspaceMembersResponse>(DoROARequest("UpdateWorkspaceMembers", "doc_1.0", "HTTP", "PUT", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/members", "none", req, runtime));
        }

        public async Task<UpdateWorkspaceMembersResponse> UpdateWorkspaceMembersWithOptionsAsync(string workspaceId, UpdateWorkspaceMembersRequest request, UpdateWorkspaceMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
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
            return TeaModel.ToObject<UpdateWorkspaceMembersResponse>(await DoROARequestAsync("UpdateWorkspaceMembers", "doc_1.0", "HTTP", "PUT", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/members", "none", req, runtime));
        }

    }
}
