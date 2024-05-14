// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkwiki_2_0.Models;

namespace AlibabaCloud.SDK.Dingtalkwiki_2_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {
        protected AlibabaCloud.GatewaySpi.Client _client;

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._client = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = _client;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 新建知识小组
         *
         * @param request AddTeamRequest
         * @param headers AddTeamHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddTeamResponse
         */
        public AddTeamResponse AddTeamWithOptions(AddTeamRequest request, AddTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AddTeam",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/teams",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTeamResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 新建知识小组
         *
         * @param request AddTeamRequest
         * @param headers AddTeamHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddTeamResponse
         */
        public async Task<AddTeamResponse> AddTeamWithOptionsAsync(AddTeamRequest request, AddTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AddTeam",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/teams",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTeamResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 新建知识小组
         *
         * @param request AddTeamRequest
         * @return AddTeamResponse
         */
        public AddTeamResponse AddTeam(AddTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddTeamHeaders headers = new AddTeamHeaders();
            return AddTeamWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新建知识小组
         *
         * @param request AddTeamRequest
         * @return AddTeamResponse
         */
        public async Task<AddTeamResponse> AddTeamAsync(AddTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddTeamHeaders headers = new AddTeamHeaders();
            return await AddTeamWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 新建知识库
         *
         * @param request AddWorkspaceRequest
         * @param headers AddWorkspaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddWorkspaceResponse
         */
        public AddWorkspaceResponse AddWorkspaceWithOptions(AddWorkspaceRequest request, AddWorkspaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AddWorkspace",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/workspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWorkspaceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 新建知识库
         *
         * @param request AddWorkspaceRequest
         * @param headers AddWorkspaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddWorkspaceResponse
         */
        public async Task<AddWorkspaceResponse> AddWorkspaceWithOptionsAsync(AddWorkspaceRequest request, AddWorkspaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AddWorkspace",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/workspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWorkspaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 新建知识库
         *
         * @param request AddWorkspaceRequest
         * @return AddWorkspaceResponse
         */
        public AddWorkspaceResponse AddWorkspace(AddWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceHeaders headers = new AddWorkspaceHeaders();
            return AddWorkspaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新建知识库
         *
         * @param request AddWorkspaceRequest
         * @return AddWorkspaceResponse
         */
        public async Task<AddWorkspaceResponse> AddWorkspaceAsync(AddWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddWorkspaceHeaders headers = new AddWorkspaceHeaders();
            return await AddWorkspaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除知识小组
         *
         * @param request DeleteTeamRequest
         * @param headers DeleteTeamHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTeamResponse
         */
        public DeleteTeamResponse DeleteTeamWithOptions(string teamId, DeleteTeamRequest request, DeleteTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteTeam",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/teams/" + teamId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTeamResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除知识小组
         *
         * @param request DeleteTeamRequest
         * @param headers DeleteTeamHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTeamResponse
         */
        public async Task<DeleteTeamResponse> DeleteTeamWithOptionsAsync(string teamId, DeleteTeamRequest request, DeleteTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteTeam",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/teams/" + teamId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTeamResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除知识小组
         *
         * @param request DeleteTeamRequest
         * @return DeleteTeamResponse
         */
        public DeleteTeamResponse DeleteTeam(string teamId, DeleteTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTeamHeaders headers = new DeleteTeamHeaders();
            return DeleteTeamWithOptions(teamId, request, headers, runtime);
        }

        /**
         * @summary 删除知识小组
         *
         * @param request DeleteTeamRequest
         * @return DeleteTeamResponse
         */
        public async Task<DeleteTeamResponse> DeleteTeamAsync(string teamId, DeleteTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTeamHeaders headers = new DeleteTeamHeaders();
            return await DeleteTeamWithOptionsAsync(teamId, request, headers, runtime);
        }

        /**
         * @summary 查询员工离职时知识库默认转交人
         *
         * @param request GetDefaultHandOverUserRequest
         * @param headers GetDefaultHandOverUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDefaultHandOverUserResponse
         */
        public GetDefaultHandOverUserResponse GetDefaultHandOverUserWithOptions(GetDefaultHandOverUserRequest request, GetDefaultHandOverUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDefaultHandOverUser",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/managementSettings/defaultHandOverUsers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefaultHandOverUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询员工离职时知识库默认转交人
         *
         * @param request GetDefaultHandOverUserRequest
         * @param headers GetDefaultHandOverUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDefaultHandOverUserResponse
         */
        public async Task<GetDefaultHandOverUserResponse> GetDefaultHandOverUserWithOptionsAsync(GetDefaultHandOverUserRequest request, GetDefaultHandOverUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDefaultHandOverUser",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/managementSettings/defaultHandOverUsers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefaultHandOverUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询员工离职时知识库默认转交人
         *
         * @param request GetDefaultHandOverUserRequest
         * @return GetDefaultHandOverUserResponse
         */
        public GetDefaultHandOverUserResponse GetDefaultHandOverUser(GetDefaultHandOverUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDefaultHandOverUserHeaders headers = new GetDefaultHandOverUserHeaders();
            return GetDefaultHandOverUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询员工离职时知识库默认转交人
         *
         * @param request GetDefaultHandOverUserRequest
         * @return GetDefaultHandOverUserResponse
         */
        public async Task<GetDefaultHandOverUserResponse> GetDefaultHandOverUserAsync(GetDefaultHandOverUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDefaultHandOverUserHeaders headers = new GetDefaultHandOverUserHeaders();
            return await GetDefaultHandOverUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取我的文档
         *
         * @param request GetMineWorkspaceRequest
         * @param headers GetMineWorkspaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMineWorkspaceResponse
         */
        public GetMineWorkspaceResponse GetMineWorkspaceWithOptions(GetMineWorkspaceRequest request, GetMineWorkspaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetMineWorkspace",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/mineWorkspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMineWorkspaceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取我的文档
         *
         * @param request GetMineWorkspaceRequest
         * @param headers GetMineWorkspaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMineWorkspaceResponse
         */
        public async Task<GetMineWorkspaceResponse> GetMineWorkspaceWithOptionsAsync(GetMineWorkspaceRequest request, GetMineWorkspaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetMineWorkspace",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/mineWorkspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMineWorkspaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取我的文档
         *
         * @param request GetMineWorkspaceRequest
         * @return GetMineWorkspaceResponse
         */
        public GetMineWorkspaceResponse GetMineWorkspace(GetMineWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMineWorkspaceHeaders headers = new GetMineWorkspaceHeaders();
            return GetMineWorkspaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取我的文档
         *
         * @param request GetMineWorkspaceRequest
         * @return GetMineWorkspaceResponse
         */
        public async Task<GetMineWorkspaceResponse> GetMineWorkspaceAsync(GetMineWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMineWorkspaceHeaders headers = new GetMineWorkspaceHeaders();
            return await GetMineWorkspaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取节点
         *
         * @param request GetNodeRequest
         * @param headers GetNodeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNodeResponse
         */
        public GetNodeResponse GetNodeWithOptions(string nodeId, GetNodeRequest request, GetNodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPermissionRole))
            {
                query["withPermissionRole"] = request.WithPermissionRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithStatisticalInfo))
            {
                query["withStatisticalInfo"] = request.WithStatisticalInfo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetNode",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/nodes/" + nodeId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取节点
         *
         * @param request GetNodeRequest
         * @param headers GetNodeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNodeResponse
         */
        public async Task<GetNodeResponse> GetNodeWithOptionsAsync(string nodeId, GetNodeRequest request, GetNodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPermissionRole))
            {
                query["withPermissionRole"] = request.WithPermissionRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithStatisticalInfo))
            {
                query["withStatisticalInfo"] = request.WithStatisticalInfo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetNode",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/nodes/" + nodeId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取节点
         *
         * @param request GetNodeRequest
         * @return GetNodeResponse
         */
        public GetNodeResponse GetNode(string nodeId, GetNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNodeHeaders headers = new GetNodeHeaders();
            return GetNodeWithOptions(nodeId, request, headers, runtime);
        }

        /**
         * @summary 获取节点
         *
         * @param request GetNodeRequest
         * @return GetNodeResponse
         */
        public async Task<GetNodeResponse> GetNodeAsync(string nodeId, GetNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNodeHeaders headers = new GetNodeHeaders();
            return await GetNodeWithOptionsAsync(nodeId, request, headers, runtime);
        }

        /**
         * @summary 通过链接获取节点
         *
         * @param request GetNodeByUrlRequest
         * @param headers GetNodeByUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNodeByUrlResponse
         */
        public GetNodeByUrlResponse GetNodeByUrlWithOptions(GetNodeByUrlRequest request, GetNodeByUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetNodeByUrl",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/nodes/queryByUrl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeByUrlResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 通过链接获取节点
         *
         * @param request GetNodeByUrlRequest
         * @param headers GetNodeByUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNodeByUrlResponse
         */
        public async Task<GetNodeByUrlResponse> GetNodeByUrlWithOptionsAsync(GetNodeByUrlRequest request, GetNodeByUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetNodeByUrl",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/nodes/queryByUrl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeByUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 通过链接获取节点
         *
         * @param request GetNodeByUrlRequest
         * @return GetNodeByUrlResponse
         */
        public GetNodeByUrlResponse GetNodeByUrl(GetNodeByUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNodeByUrlHeaders headers = new GetNodeByUrlHeaders();
            return GetNodeByUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary 通过链接获取节点
         *
         * @param request GetNodeByUrlRequest
         * @return GetNodeByUrlResponse
         */
        public async Task<GetNodeByUrlResponse> GetNodeByUrlAsync(GetNodeByUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNodeByUrlHeaders headers = new GetNodeByUrlHeaders();
            return await GetNodeByUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量获取节点
         *
         * @param request GetNodesRequest
         * @param headers GetNodesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNodesResponse
         */
        public GetNodesResponse GetNodesWithOptions(GetNodesRequest request, GetNodesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                body["nodeIds"] = request.NodeIds;
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
                Action = "GetNodes",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/nodes/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量获取节点
         *
         * @param request GetNodesRequest
         * @param headers GetNodesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNodesResponse
         */
        public async Task<GetNodesResponse> GetNodesWithOptionsAsync(GetNodesRequest request, GetNodesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                body["nodeIds"] = request.NodeIds;
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
                Action = "GetNodes",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/nodes/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量获取节点
         *
         * @param request GetNodesRequest
         * @return GetNodesResponse
         */
        public GetNodesResponse GetNodes(GetNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNodesHeaders headers = new GetNodesHeaders();
            return GetNodesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量获取节点
         *
         * @param request GetNodesRequest
         * @return GetNodesResponse
         */
        public async Task<GetNodesResponse> GetNodesAsync(GetNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNodesHeaders headers = new GetNodesHeaders();
            return await GetNodesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取知识小组
         *
         * @param request GetTeamRequest
         * @param headers GetTeamHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTeamResponse
         */
        public GetTeamResponse GetTeamWithOptions(string teamId, GetTeamRequest request, GetTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTeam",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/teams/" + teamId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTeamResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取知识小组
         *
         * @param request GetTeamRequest
         * @param headers GetTeamHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTeamResponse
         */
        public async Task<GetTeamResponse> GetTeamWithOptionsAsync(string teamId, GetTeamRequest request, GetTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTeam",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/teams/" + teamId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTeamResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取知识小组
         *
         * @param request GetTeamRequest
         * @return GetTeamResponse
         */
        public GetTeamResponse GetTeam(string teamId, GetTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTeamHeaders headers = new GetTeamHeaders();
            return GetTeamWithOptions(teamId, request, headers, runtime);
        }

        /**
         * @summary 获取知识小组
         *
         * @param request GetTeamRequest
         * @return GetTeamResponse
         */
        public async Task<GetTeamResponse> GetTeamAsync(string teamId, GetTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTeamHeaders headers = new GetTeamHeaders();
            return await GetTeamWithOptionsAsync(teamId, request, headers, runtime);
        }

        /**
         * @summary 获取知识库
         *
         * @param request GetWorkspaceRequest
         * @param headers GetWorkspaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkspaceResponse
         */
        public GetWorkspaceResponse GetWorkspaceWithOptions(string workspaceId, GetWorkspaceRequest request, GetWorkspaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPermissionRole))
            {
                query["withPermissionRole"] = request.WithPermissionRole;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetWorkspace",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/workspaces/" + workspaceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取知识库
         *
         * @param request GetWorkspaceRequest
         * @param headers GetWorkspaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkspaceResponse
         */
        public async Task<GetWorkspaceResponse> GetWorkspaceWithOptionsAsync(string workspaceId, GetWorkspaceRequest request, GetWorkspaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPermissionRole))
            {
                query["withPermissionRole"] = request.WithPermissionRole;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetWorkspace",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/workspaces/" + workspaceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取知识库
         *
         * @param request GetWorkspaceRequest
         * @return GetWorkspaceResponse
         */
        public GetWorkspaceResponse GetWorkspace(string workspaceId, GetWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspaceHeaders headers = new GetWorkspaceHeaders();
            return GetWorkspaceWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取知识库
         *
         * @param request GetWorkspaceRequest
         * @return GetWorkspaceResponse
         */
        public async Task<GetWorkspaceResponse> GetWorkspaceAsync(string workspaceId, GetWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspaceHeaders headers = new GetWorkspaceHeaders();
            return await GetWorkspaceWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 批量获取知识库
         *
         * @param request GetWorkspacesRequest
         * @param headers GetWorkspacesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkspacesResponse
         */
        public GetWorkspacesResponse GetWorkspacesWithOptions(GetWorkspacesRequest request, GetWorkspacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspaces",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/workspaces/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspacesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量获取知识库
         *
         * @param request GetWorkspacesRequest
         * @param headers GetWorkspacesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkspacesResponse
         */
        public async Task<GetWorkspacesResponse> GetWorkspacesWithOptionsAsync(GetWorkspacesRequest request, GetWorkspacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspaces",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/workspaces/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspacesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量获取知识库
         *
         * @param request GetWorkspacesRequest
         * @return GetWorkspacesResponse
         */
        public GetWorkspacesResponse GetWorkspaces(GetWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspacesHeaders headers = new GetWorkspacesHeaders();
            return GetWorkspacesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量获取知识库
         *
         * @param request GetWorkspacesRequest
         * @return GetWorkspacesResponse
         */
        public async Task<GetWorkspacesResponse> GetWorkspacesAsync(GetWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkspacesHeaders headers = new GetWorkspacesHeaders();
            return await GetWorkspacesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 转交知识库
         *
         * @param request HandOverWorkspaceRequest
         * @param headers HandOverWorkspaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HandOverWorkspaceResponse
         */
        public HandOverWorkspaceResponse HandOverWorkspaceWithOptions(HandOverWorkspaceRequest request, HandOverWorkspaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOwnerId))
            {
                body["sourceOwnerId"] = request.SourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetOwnerId))
            {
                body["targetOwnerId"] = request.TargetOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "HandOverWorkspace",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/managementOperations/workspaces/handOver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HandOverWorkspaceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 转交知识库
         *
         * @param request HandOverWorkspaceRequest
         * @param headers HandOverWorkspaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HandOverWorkspaceResponse
         */
        public async Task<HandOverWorkspaceResponse> HandOverWorkspaceWithOptionsAsync(HandOverWorkspaceRequest request, HandOverWorkspaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOwnerId))
            {
                body["sourceOwnerId"] = request.SourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetOwnerId))
            {
                body["targetOwnerId"] = request.TargetOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "HandOverWorkspace",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/managementOperations/workspaces/handOver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HandOverWorkspaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 转交知识库
         *
         * @param request HandOverWorkspaceRequest
         * @return HandOverWorkspaceResponse
         */
        public HandOverWorkspaceResponse HandOverWorkspace(HandOverWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HandOverWorkspaceHeaders headers = new HandOverWorkspaceHeaders();
            return HandOverWorkspaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 转交知识库
         *
         * @param request HandOverWorkspaceRequest
         * @return HandOverWorkspaceResponse
         */
        public async Task<HandOverWorkspaceResponse> HandOverWorkspaceAsync(HandOverWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HandOverWorkspaceHeaders headers = new HandOverWorkspaceHeaders();
            return await HandOverWorkspaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取节点列表
         *
         * @param request ListNodesRequest
         * @param headers ListNodesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNodesResponse
         */
        public ListNodesResponse ListNodesWithOptions(ListNodesRequest request, ListNodesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentNodeId))
            {
                query["parentNodeId"] = request.ParentNodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPermissionRole))
            {
                query["withPermissionRole"] = request.WithPermissionRole;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListNodes",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/nodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取节点列表
         *
         * @param request ListNodesRequest
         * @param headers ListNodesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNodesResponse
         */
        public async Task<ListNodesResponse> ListNodesWithOptionsAsync(ListNodesRequest request, ListNodesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentNodeId))
            {
                query["parentNodeId"] = request.ParentNodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPermissionRole))
            {
                query["withPermissionRole"] = request.WithPermissionRole;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListNodes",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/nodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取节点列表
         *
         * @param request ListNodesRequest
         * @return ListNodesResponse
         */
        public ListNodesResponse ListNodes(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListNodesHeaders headers = new ListNodesHeaders();
            return ListNodesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取节点列表
         *
         * @param request ListNodesRequest
         * @return ListNodesResponse
         */
        public async Task<ListNodesResponse> ListNodesAsync(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListNodesHeaders headers = new ListNodesHeaders();
            return await ListNodesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取知识小组列表
         *
         * @param request ListTeamsRequest
         * @param headers ListTeamsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTeamsResponse
         */
        public ListTeamsResponse ListTeamsWithOptions(ListTeamsRequest request, ListTeamsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListTeams",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/teams",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTeamsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取知识小组列表
         *
         * @param request ListTeamsRequest
         * @param headers ListTeamsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTeamsResponse
         */
        public async Task<ListTeamsResponse> ListTeamsWithOptionsAsync(ListTeamsRequest request, ListTeamsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListTeams",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/teams",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTeamsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取知识小组列表
         *
         * @param request ListTeamsRequest
         * @return ListTeamsResponse
         */
        public ListTeamsResponse ListTeams(ListTeamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTeamsHeaders headers = new ListTeamsHeaders();
            return ListTeamsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取知识小组列表
         *
         * @param request ListTeamsRequest
         * @return ListTeamsResponse
         */
        public async Task<ListTeamsResponse> ListTeamsAsync(ListTeamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTeamsHeaders headers = new ListTeamsHeaders();
            return await ListTeamsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取知识库列表
         *
         * @param request ListWorkspacesRequest
         * @param headers ListWorkspacesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWorkspacesResponse
         */
        public ListWorkspacesResponse ListWorkspacesWithOptions(ListWorkspacesRequest request, ListWorkspacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamId))
            {
                query["teamId"] = request.TeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPermissionRole))
            {
                query["withPermissionRole"] = request.WithPermissionRole;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListWorkspaces",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/workspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取知识库列表
         *
         * @param request ListWorkspacesRequest
         * @param headers ListWorkspacesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWorkspacesResponse
         */
        public async Task<ListWorkspacesResponse> ListWorkspacesWithOptionsAsync(ListWorkspacesRequest request, ListWorkspacesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamId))
            {
                query["teamId"] = request.TeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithPermissionRole))
            {
                query["withPermissionRole"] = request.WithPermissionRole;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListWorkspaces",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/workspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取知识库列表
         *
         * @param request ListWorkspacesRequest
         * @return ListWorkspacesResponse
         */
        public ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListWorkspacesHeaders headers = new ListWorkspacesHeaders();
            return ListWorkspacesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取知识库列表
         *
         * @param request ListWorkspacesRequest
         * @return ListWorkspacesResponse
         */
        public async Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListWorkspacesHeaders headers = new ListWorkspacesHeaders();
            return await ListWorkspacesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 设置员工离职时知识库默认转交人
         *
         * @param request SetDefaultHandOverUserRequest
         * @param headers SetDefaultHandOverUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDefaultHandOverUserResponse
         */
        public SetDefaultHandOverUserResponse SetDefaultHandOverUserWithOptions(SetDefaultHandOverUserRequest request, SetDefaultHandOverUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultHandoverUserId))
            {
                body["defaultHandoverUserId"] = request.DefaultHandoverUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "SetDefaultHandOverUser",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/managementSettings/defaultHandOverUsers/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultHandOverUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 设置员工离职时知识库默认转交人
         *
         * @param request SetDefaultHandOverUserRequest
         * @param headers SetDefaultHandOverUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDefaultHandOverUserResponse
         */
        public async Task<SetDefaultHandOverUserResponse> SetDefaultHandOverUserWithOptionsAsync(SetDefaultHandOverUserRequest request, SetDefaultHandOverUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultHandoverUserId))
            {
                body["defaultHandoverUserId"] = request.DefaultHandoverUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "SetDefaultHandOverUser",
                Version = "wiki_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/wiki/managementSettings/defaultHandOverUsers/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultHandOverUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 设置员工离职时知识库默认转交人
         *
         * @param request SetDefaultHandOverUserRequest
         * @return SetDefaultHandOverUserResponse
         */
        public SetDefaultHandOverUserResponse SetDefaultHandOverUser(SetDefaultHandOverUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDefaultHandOverUserHeaders headers = new SetDefaultHandOverUserHeaders();
            return SetDefaultHandOverUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary 设置员工离职时知识库默认转交人
         *
         * @param request SetDefaultHandOverUserRequest
         * @return SetDefaultHandOverUserResponse
         */
        public async Task<SetDefaultHandOverUserResponse> SetDefaultHandOverUserAsync(SetDefaultHandOverUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDefaultHandOverUserHeaders headers = new SetDefaultHandOverUserHeaders();
            return await SetDefaultHandOverUserWithOptionsAsync(request, headers, runtime);
        }

    }
}
