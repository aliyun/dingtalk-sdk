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


        public AddWorkspaceDocMembersResponse AddWorkspaceDocMembers(string nodeId, string workspaceId, AddWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceDocMembersHeaders headers = new AddWorkspaceDocMembersHeaders();
            return AddWorkspaceDocMembersWithOptions(nodeId, workspaceId, request, headers, runtime);
        }

        public async Task<AddWorkspaceDocMembersResponse> AddWorkspaceDocMembersAsync(string nodeId, string workspaceId, AddWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceDocMembersHeaders headers = new AddWorkspaceDocMembersHeaders();
            return await AddWorkspaceDocMembersWithOptionsAsync(nodeId, workspaceId, request, headers, runtime);
        }

        public AddWorkspaceDocMembersResponse AddWorkspaceDocMembersWithOptions(string nodeId, string workspaceId, AddWorkspaceDocMembersRequest request, AddWorkspaceDocMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            nodeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddWorkspaceDocMembersResponse>(DoROARequest("AddWorkspaceDocMembers", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + "/members", "none", req, runtime));
        }

        public async Task<AddWorkspaceDocMembersResponse> AddWorkspaceDocMembersWithOptionsAsync(string nodeId, string workspaceId, AddWorkspaceDocMembersRequest request, AddWorkspaceDocMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            nodeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddWorkspaceMembersResponse>(await DoROARequestAsync("AddWorkspaceMembers", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/members", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingAccessTokenType))
            {
                body["dingAccessTokenType"] = request.DingAccessTokenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUid))
            {
                body["dingUid"] = request.DingUid;
            }
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingAccessTokenType))
            {
                body["dingAccessTokenType"] = request.DingAccessTokenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUid))
            {
                body["dingUid"] = request.DingUid;
            }
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingAccessTokenType))
            {
                body["dingAccessTokenType"] = request.DingAccessTokenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUid))
            {
                body["dingUid"] = request.DingUid;
            }
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingAccessTokenType))
            {
                body["dingAccessTokenType"] = request.DingAccessTokenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUid))
            {
                body["dingUid"] = request.DingUid;
            }
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<BatchGetWorkspacesResponse>(await DoROARequestAsync("BatchGetWorkspaces", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/infos/query", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingAccessTokenType))
            {
                body["dingAccessTokenType"] = request.DingAccessTokenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUid))
            {
                body["dingUid"] = request.DingUid;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingAccessTokenType))
            {
                body["dingAccessTokenType"] = request.DingAccessTokenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUid))
            {
                body["dingUid"] = request.DingUid;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateWorkspaceDocResponse>(await DoROARequestAsync("CreateWorkspaceDoc", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/docs", "json", req, runtime));
        }

        public DeleteWorkspaceDocMembersResponse DeleteWorkspaceDocMembers(string nodeId, string workspaceId, DeleteWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceDocMembersHeaders headers = new DeleteWorkspaceDocMembersHeaders();
            return DeleteWorkspaceDocMembersWithOptions(nodeId, workspaceId, request, headers, runtime);
        }

        public async Task<DeleteWorkspaceDocMembersResponse> DeleteWorkspaceDocMembersAsync(string nodeId, string workspaceId, DeleteWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteWorkspaceDocMembersHeaders headers = new DeleteWorkspaceDocMembersHeaders();
            return await DeleteWorkspaceDocMembersWithOptionsAsync(nodeId, workspaceId, request, headers, runtime);
        }

        public DeleteWorkspaceDocMembersResponse DeleteWorkspaceDocMembersWithOptions(string nodeId, string workspaceId, DeleteWorkspaceDocMembersRequest request, DeleteWorkspaceDocMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            nodeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteWorkspaceDocMembersResponse>(DoROARequest("DeleteWorkspaceDocMembers", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + "/members/remove", "none", req, runtime));
        }

        public async Task<DeleteWorkspaceDocMembersResponse> DeleteWorkspaceDocMembersWithOptionsAsync(string nodeId, string workspaceId, DeleteWorkspaceDocMembersRequest request, DeleteWorkspaceDocMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            nodeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeleteWorkspaceMembersResponse>(await DoROARequestAsync("DeleteWorkspaceMembers", "doc_1.0", "HTTP", "POST", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/members/remove", "none", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetRecentEditDocsResponse>(await DoROARequestAsync("GetRecentEditDocs", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workspaces/docs/recentEditDocs", "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetRelatedWorkspacesResponse>(await DoROARequestAsync("GetRelatedWorkspaces", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workspaces", "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(await DoROARequestAsync("GetWorkspace", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workspaces/" + workspaceId, "json", req, runtime));
        }

        public GetWorkspaceNodeResponse GetWorkspaceNode(string nodeId, string workspaceId, GetWorkspaceNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspaceNodeHeaders headers = new GetWorkspaceNodeHeaders();
            return GetWorkspaceNodeWithOptions(nodeId, workspaceId, request, headers, runtime);
        }

        public async Task<GetWorkspaceNodeResponse> GetWorkspaceNodeAsync(string nodeId, string workspaceId, GetWorkspaceNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspaceNodeHeaders headers = new GetWorkspaceNodeHeaders();
            return await GetWorkspaceNodeWithOptionsAsync(nodeId, workspaceId, request, headers, runtime);
        }

        public GetWorkspaceNodeResponse GetWorkspaceNodeWithOptions(string nodeId, string workspaceId, GetWorkspaceNodeRequest request, GetWorkspaceNodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            nodeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeId);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetWorkspaceNodeResponse>(DoROARequest("GetWorkspaceNode", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId, "json", req, runtime));
        }

        public async Task<GetWorkspaceNodeResponse> GetWorkspaceNodeWithOptionsAsync(string nodeId, string workspaceId, GetWorkspaceNodeRequest request, GetWorkspaceNodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            nodeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeId);
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetWorkspaceNodeResponse>(await DoROARequestAsync("GetWorkspaceNode", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId, "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<SearchWorkspaceDocsResponse>(await DoROARequestAsync("SearchWorkspaceDocs", "doc_1.0", "HTTP", "GET", "AK", "/v1.0/doc/docs", "json", req, runtime));
        }

        public UpdateWorkspaceDocMembersResponse UpdateWorkspaceDocMembers(string nodeId, string workspaceId, UpdateWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkspaceDocMembersHeaders headers = new UpdateWorkspaceDocMembersHeaders();
            return UpdateWorkspaceDocMembersWithOptions(nodeId, workspaceId, request, headers, runtime);
        }

        public async Task<UpdateWorkspaceDocMembersResponse> UpdateWorkspaceDocMembersAsync(string nodeId, string workspaceId, UpdateWorkspaceDocMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkspaceDocMembersHeaders headers = new UpdateWorkspaceDocMembersHeaders();
            return await UpdateWorkspaceDocMembersWithOptionsAsync(nodeId, workspaceId, request, headers, runtime);
        }

        public UpdateWorkspaceDocMembersResponse UpdateWorkspaceDocMembersWithOptions(string nodeId, string workspaceId, UpdateWorkspaceDocMembersRequest request, UpdateWorkspaceDocMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            nodeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateWorkspaceDocMembersResponse>(DoROARequest("UpdateWorkspaceDocMembers", "doc_1.0", "HTTP", "PUT", "AK", "/v1.0/doc/workspaces/" + workspaceId + "/docs/" + nodeId + "/members", "none", req, runtime));
        }

        public async Task<UpdateWorkspaceDocMembersResponse> UpdateWorkspaceDocMembersWithOptionsAsync(string nodeId, string workspaceId, UpdateWorkspaceDocMembersRequest request, UpdateWorkspaceDocMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            nodeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
