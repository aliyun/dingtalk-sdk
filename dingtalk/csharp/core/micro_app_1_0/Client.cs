// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {
        protected AlibabaCloud.GatewaySpi.Client _client;

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._client = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = _client;
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 给指定成员添加角色
         *
         * @param request AddAppRolesToMemberRequest
         * @param headers AddAppRolesToMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddAppRolesToMemberResponse
         */
        public AddAppRolesToMemberResponse AddAppRolesToMemberWithOptions(string agentId, AddAppRolesToMemberRequest request, AddAppRolesToMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                body["memberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberType))
            {
                body["memberType"] = request.MemberType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleList))
            {
                body["roleList"] = request.RoleList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddAppRolesToMember",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/members/roles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAppRolesToMemberResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 给指定成员添加角色
         *
         * @param request AddAppRolesToMemberRequest
         * @param headers AddAppRolesToMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddAppRolesToMemberResponse
         */
        public async Task<AddAppRolesToMemberResponse> AddAppRolesToMemberWithOptionsAsync(string agentId, AddAppRolesToMemberRequest request, AddAppRolesToMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                body["memberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberType))
            {
                body["memberType"] = request.MemberType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleList))
            {
                body["roleList"] = request.RoleList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddAppRolesToMember",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/members/roles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAppRolesToMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 给指定成员添加角色
         *
         * @param request AddAppRolesToMemberRequest
         * @return AddAppRolesToMemberResponse
         */
        public AddAppRolesToMemberResponse AddAppRolesToMember(string agentId, AddAppRolesToMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAppRolesToMemberHeaders headers = new AddAppRolesToMemberHeaders();
            return AddAppRolesToMemberWithOptions(agentId, request, headers, runtime);
        }

        /**
         * @summary 给指定成员添加角色
         *
         * @param request AddAppRolesToMemberRequest
         * @return AddAppRolesToMemberResponse
         */
        public async Task<AddAppRolesToMemberResponse> AddAppRolesToMemberAsync(string agentId, AddAppRolesToMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAppRolesToMemberHeaders headers = new AddAppRolesToMemberHeaders();
            return await AddAppRolesToMemberWithOptionsAsync(agentId, request, headers, runtime);
        }

        /**
         * @summary 添加应用到工作台分组
         *
         * @param request AddAppToWorkBenchGroupRequest
         * @param headers AddAppToWorkBenchGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddAppToWorkBenchGroupResponse
         */
        public AddAppToWorkBenchGroupResponse AddAppToWorkBenchGroupWithOptions(string agentId, AddAppToWorkBenchGroupRequest request, AddAppToWorkBenchGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentId))
            {
                body["componentId"] = request.ComponentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                body["ecologicalCorpId"] = request.EcologicalCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                body["opUnionId"] = request.OpUnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddAppToWorkBenchGroup",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/addToWorkBenchGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAppToWorkBenchGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 添加应用到工作台分组
         *
         * @param request AddAppToWorkBenchGroupRequest
         * @param headers AddAppToWorkBenchGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddAppToWorkBenchGroupResponse
         */
        public async Task<AddAppToWorkBenchGroupResponse> AddAppToWorkBenchGroupWithOptionsAsync(string agentId, AddAppToWorkBenchGroupRequest request, AddAppToWorkBenchGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentId))
            {
                body["componentId"] = request.ComponentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                body["ecologicalCorpId"] = request.EcologicalCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                body["opUnionId"] = request.OpUnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddAppToWorkBenchGroup",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/addToWorkBenchGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAppToWorkBenchGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 添加应用到工作台分组
         *
         * @param request AddAppToWorkBenchGroupRequest
         * @return AddAppToWorkBenchGroupResponse
         */
        public AddAppToWorkBenchGroupResponse AddAppToWorkBenchGroup(string agentId, AddAppToWorkBenchGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAppToWorkBenchGroupHeaders headers = new AddAppToWorkBenchGroupHeaders();
            return AddAppToWorkBenchGroupWithOptions(agentId, request, headers, runtime);
        }

        /**
         * @summary 添加应用到工作台分组
         *
         * @param request AddAppToWorkBenchGroupRequest
         * @return AddAppToWorkBenchGroupResponse
         */
        public async Task<AddAppToWorkBenchGroupResponse> AddAppToWorkBenchGroupAsync(string agentId, AddAppToWorkBenchGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAppToWorkBenchGroupHeaders headers = new AddAppToWorkBenchGroupHeaders();
            return await AddAppToWorkBenchGroupWithOptionsAsync(agentId, request, headers, runtime);
        }

        /**
         * @summary 给指定角色添加人员
         *
         * @param request AddMemberToAppRoleRequest
         * @param headers AddMemberToAppRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddMemberToAppRoleResponse
         */
        public AddMemberToAppRoleResponse AddMemberToAppRoleWithOptions(string agentId, string roleId, AddMemberToAppRoleRequest request, AddMemberToAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIdList))
            {
                body["deptIdList"] = request.DeptIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeVersion))
            {
                body["scopeVersion"] = request.ScopeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddMemberToAppRole",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMemberToAppRoleResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 给指定角色添加人员
         *
         * @param request AddMemberToAppRoleRequest
         * @param headers AddMemberToAppRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddMemberToAppRoleResponse
         */
        public async Task<AddMemberToAppRoleResponse> AddMemberToAppRoleWithOptionsAsync(string agentId, string roleId, AddMemberToAppRoleRequest request, AddMemberToAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIdList))
            {
                body["deptIdList"] = request.DeptIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeVersion))
            {
                body["scopeVersion"] = request.ScopeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddMemberToAppRole",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMemberToAppRoleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 给指定角色添加人员
         *
         * @param request AddMemberToAppRoleRequest
         * @return AddMemberToAppRoleResponse
         */
        public AddMemberToAppRoleResponse AddMemberToAppRole(string agentId, string roleId, AddMemberToAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddMemberToAppRoleHeaders headers = new AddMemberToAppRoleHeaders();
            return AddMemberToAppRoleWithOptions(agentId, roleId, request, headers, runtime);
        }

        /**
         * @summary 给指定角色添加人员
         *
         * @param request AddMemberToAppRoleRequest
         * @return AddMemberToAppRoleResponse
         */
        public async Task<AddMemberToAppRoleResponse> AddMemberToAppRoleAsync(string agentId, string roleId, AddMemberToAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddMemberToAppRoleHeaders headers = new AddMemberToAppRoleHeaders();
            return await AddMemberToAppRoleWithOptionsAsync(agentId, roleId, request, headers, runtime);
        }

        /**
         * @summary AnheiP
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AnheiPResponse
         */
        public AnheiPResponse AnheiPWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnheiP",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/anheiP",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnheiPResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary AnheiP
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AnheiPResponse
         */
        public async Task<AnheiPResponse> AnheiPWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnheiP",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/anheiP",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnheiPResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary AnheiP
         *
         * @return AnheiPResponse
         */
        public AnheiPResponse AnheiP()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AnheiPWithOptions(headers, runtime);
        }

        /**
         * @summary AnheiP
         *
         * @return AnheiPResponse
         */
        public async Task<AnheiPResponse> AnheiPAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AnheiPWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary AnheiTest888
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AnheiTest888Response
         */
        public AnheiTest888Response AnheiTest888WithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnheiTest888",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/anheiTest888",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnheiTest888Response>(Execute(params_, req, runtime));
        }

        /**
         * @summary AnheiTest888
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AnheiTest888Response
         */
        public async Task<AnheiTest888Response> AnheiTest888WithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnheiTest888",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/anheiTest888",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnheiTest888Response>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary AnheiTest888
         *
         * @return AnheiTest888Response
         */
        public AnheiTest888Response AnheiTest888()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AnheiTest888WithOptions(headers, runtime);
        }

        /**
         * @summary AnheiTest888
         *
         * @return AnheiTest888Response
         */
        public async Task<AnheiTest888Response> AnheiTest888Async()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AnheiTest888WithOptionsAsync(headers, runtime);
        }

        /**
         * @summary AnheiTestB
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AnheiTestBResponse
         */
        public AnheiTestBResponse AnheiTestBWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnheiTestB",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/anheiTestB",
                Method = "PUT",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnheiTestBResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary AnheiTestB
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AnheiTestBResponse
         */
        public async Task<AnheiTestBResponse> AnheiTestBWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnheiTestB",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/anheiTestB",
                Method = "PUT",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnheiTestBResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary AnheiTestB
         *
         * @return AnheiTestBResponse
         */
        public AnheiTestBResponse AnheiTestB()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AnheiTestBWithOptions(headers, runtime);
        }

        /**
         * @summary AnheiTestB
         *
         * @return AnheiTestBResponse
         */
        public async Task<AnheiTestBResponse> AnheiTestBAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AnheiTestBWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 暗黑测试
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AnheiTestNineResponse
         */
        public AnheiTestNineResponse AnheiTestNineWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnheiTestNine",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/anheiTestNine",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnheiTestNineResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 暗黑测试
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AnheiTestNineResponse
         */
        public async Task<AnheiTestNineResponse> AnheiTestNineWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnheiTestNine",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/anheiTestNine",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnheiTestNineResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 暗黑测试
         *
         * @return AnheiTestNineResponse
         */
        public AnheiTestNineResponse AnheiTestNine()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AnheiTestNineWithOptions(headers, runtime);
        }

        /**
         * @summary 暗黑测试
         *
         * @return AnheiTestNineResponse
         */
        public async Task<AnheiTestNineResponse> AnheiTestNineAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AnheiTestNineWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 应用状态管理测试
         *
         * @param request AppStatusManagerTestRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AppStatusManagerTestResponse
         */
        public AppStatusManagerTestResponse AppStatusManagerTestWithOptions(AppStatusManagerTestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["requestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AppStatusManagerTest",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/manager/test",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AppStatusManagerTestResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 应用状态管理测试
         *
         * @param request AppStatusManagerTestRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AppStatusManagerTestResponse
         */
        public async Task<AppStatusManagerTestResponse> AppStatusManagerTestWithOptionsAsync(AppStatusManagerTestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["requestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AppStatusManagerTest",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/manager/test",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AppStatusManagerTestResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 应用状态管理测试
         *
         * @param request AppStatusManagerTestRequest
         * @return AppStatusManagerTestResponse
         */
        public AppStatusManagerTestResponse AppStatusManagerTest(AppStatusManagerTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AppStatusManagerTestWithOptions(request, headers, runtime);
        }

        /**
         * @summary 应用状态管理测试
         *
         * @param request AppStatusManagerTestRequest
         * @return AppStatusManagerTestResponse
         */
        public async Task<AppStatusManagerTestResponse> AppStatusManagerTestAsync(AppStatusManagerTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AppStatusManagerTestWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 能力开放中心录入测试数据
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AyunTestResponse
         */
        public AyunTestResponse AyunTestWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AyunTest",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/ayun/test",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AyunTestResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 能力开放中心录入测试数据
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AyunTestResponse
         */
        public async Task<AyunTestResponse> AyunTestWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AyunTest",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/ayun/test",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AyunTestResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 能力开放中心录入测试数据
         *
         * @return AyunTestResponse
         */
        public AyunTestResponse AyunTest()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AyunTestWithOptions(headers, runtime);
        }

        /**
         * @summary 能力开放中心录入测试数据
         *
         * @return AyunTestResponse
         */
        public async Task<AyunTestResponse> AyunTestAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AyunTestWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary openAPI录入上线后的测试
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AyunTestOnlineResponse
         */
        public AyunTestOnlineResponse AyunTestOnlineWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AyunTestOnline",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/ayunTest",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AyunTestOnlineResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary openAPI录入上线后的测试
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AyunTestOnlineResponse
         */
        public async Task<AyunTestOnlineResponse> AyunTestOnlineWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AyunTestOnline",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/ayunTest",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AyunTestOnlineResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary openAPI录入上线后的测试
         *
         * @return AyunTestOnlineResponse
         */
        public AyunTestOnlineResponse AyunTestOnline()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AyunTestOnlineWithOptions(headers, runtime);
        }

        /**
         * @summary openAPI录入上线后的测试
         *
         * @return AyunTestOnlineResponse
         */
        public async Task<AyunTestOnlineResponse> AyunTestOnlineAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AyunTestOnlineWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 创建Apaas应用
         *
         * @param request CreateApaasAppRequest
         * @param headers CreateApaasAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateApaasAppResponse
         */
        public CreateApaasAppResponse CreateApaasAppWithOptions(CreateApaasAppRequest request, CreateApaasAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppDesc))
            {
                body["appDesc"] = request.AppDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIcon))
            {
                body["appIcon"] = request.AppIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizAppId))
            {
                body["bizAppId"] = request.BizAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HomepageEditLink))
            {
                body["homepageEditLink"] = request.HomepageEditLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HomepageLink))
            {
                body["homepageLink"] = request.HomepageLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsShortCut))
            {
                body["isShortCut"] = request.IsShortCut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OmpLink))
            {
                body["ompLink"] = request.OmpLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcHomepageEditLink))
            {
                body["pcHomepageEditLink"] = request.PcHomepageEditLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcHomepageLink))
            {
                body["pcHomepageLink"] = request.PcHomepageLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateKey))
            {
                body["templateKey"] = request.TemplateKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateApaasApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apaasApps",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApaasAppResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建Apaas应用
         *
         * @param request CreateApaasAppRequest
         * @param headers CreateApaasAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateApaasAppResponse
         */
        public async Task<CreateApaasAppResponse> CreateApaasAppWithOptionsAsync(CreateApaasAppRequest request, CreateApaasAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppDesc))
            {
                body["appDesc"] = request.AppDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIcon))
            {
                body["appIcon"] = request.AppIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizAppId))
            {
                body["bizAppId"] = request.BizAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HomepageEditLink))
            {
                body["homepageEditLink"] = request.HomepageEditLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HomepageLink))
            {
                body["homepageLink"] = request.HomepageLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsShortCut))
            {
                body["isShortCut"] = request.IsShortCut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OmpLink))
            {
                body["ompLink"] = request.OmpLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcHomepageEditLink))
            {
                body["pcHomepageEditLink"] = request.PcHomepageEditLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcHomepageLink))
            {
                body["pcHomepageLink"] = request.PcHomepageLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateKey))
            {
                body["templateKey"] = request.TemplateKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateApaasApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apaasApps",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApaasAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建Apaas应用
         *
         * @param request CreateApaasAppRequest
         * @return CreateApaasAppResponse
         */
        public CreateApaasAppResponse CreateApaasApp(CreateApaasAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateApaasAppHeaders headers = new CreateApaasAppHeaders();
            return CreateApaasAppWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建Apaas应用
         *
         * @param request CreateApaasAppRequest
         * @return CreateApaasAppResponse
         */
        public async Task<CreateApaasAppResponse> CreateApaasAppAsync(CreateApaasAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateApaasAppHeaders headers = new CreateApaasAppHeaders();
            return await CreateApaasAppWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建企业内部应用
         *
         * @param request CreateInnerAppRequest
         * @param headers CreateInnerAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInnerAppResponse
         */
        public CreateInnerAppResponse CreateInnerAppWithOptions(CreateInnerAppRequest request, CreateInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DevelopType))
            {
                body["developType"] = request.DevelopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HomepageLink))
            {
                body["homepageLink"] = request.HomepageLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhiteList))
            {
                body["ipWhiteList"] = request.IpWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OmpLink))
            {
                body["ompLink"] = request.OmpLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                body["opUnionId"] = request.OpUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcHomepageLink))
            {
                body["pcHomepageLink"] = request.PcHomepageLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                body["scopeType"] = request.ScopeType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateInnerApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInnerAppResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建企业内部应用
         *
         * @param request CreateInnerAppRequest
         * @param headers CreateInnerAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInnerAppResponse
         */
        public async Task<CreateInnerAppResponse> CreateInnerAppWithOptionsAsync(CreateInnerAppRequest request, CreateInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DevelopType))
            {
                body["developType"] = request.DevelopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HomepageLink))
            {
                body["homepageLink"] = request.HomepageLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhiteList))
            {
                body["ipWhiteList"] = request.IpWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OmpLink))
            {
                body["ompLink"] = request.OmpLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                body["opUnionId"] = request.OpUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcHomepageLink))
            {
                body["pcHomepageLink"] = request.PcHomepageLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                body["scopeType"] = request.ScopeType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateInnerApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInnerAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建企业内部应用
         *
         * @param request CreateInnerAppRequest
         * @return CreateInnerAppResponse
         */
        public CreateInnerAppResponse CreateInnerApp(CreateInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateInnerAppHeaders headers = new CreateInnerAppHeaders();
            return CreateInnerAppWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建企业内部应用
         *
         * @param request CreateInnerAppRequest
         * @return CreateInnerAppResponse
         */
        public async Task<CreateInnerAppResponse> CreateInnerAppAsync(CreateInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateInnerAppHeaders headers = new CreateInnerAppHeaders();
            return await CreateInnerAppWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除应用角色
         *
         * @param request DeleteAppRoleRequest
         * @param headers DeleteAppRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppRoleResponse
         */
        public DeleteAppRoleResponse DeleteAppRoleWithOptions(string agentId, string roleId, DeleteAppRoleRequest request, DeleteAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "DeleteAppRole",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppRoleResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除应用角色
         *
         * @param request DeleteAppRoleRequest
         * @param headers DeleteAppRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppRoleResponse
         */
        public async Task<DeleteAppRoleResponse> DeleteAppRoleWithOptionsAsync(string agentId, string roleId, DeleteAppRoleRequest request, DeleteAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                query["opUserId"] = request.OpUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "DeleteAppRole",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppRoleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除应用角色
         *
         * @param request DeleteAppRoleRequest
         * @return DeleteAppRoleResponse
         */
        public DeleteAppRoleResponse DeleteAppRole(string agentId, string roleId, DeleteAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAppRoleHeaders headers = new DeleteAppRoleHeaders();
            return DeleteAppRoleWithOptions(agentId, roleId, request, headers, runtime);
        }

        /**
         * @summary 删除应用角色
         *
         * @param request DeleteAppRoleRequest
         * @return DeleteAppRoleResponse
         */
        public async Task<DeleteAppRoleResponse> DeleteAppRoleAsync(string agentId, string roleId, DeleteAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAppRoleHeaders headers = new DeleteAppRoleHeaders();
            return await DeleteAppRoleWithOptionsAsync(agentId, roleId, request, headers, runtime);
        }

        /**
         * @summary 删除企业内部应用
         *
         * @param request DeleteInnerAppRequest
         * @param headers DeleteInnerAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInnerAppResponse
         */
        public DeleteInnerAppResponse DeleteInnerAppWithOptions(string agentId, DeleteInnerAppRequest request, DeleteInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                query["opUnionId"] = request.OpUnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "DeleteInnerApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInnerAppResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除企业内部应用
         *
         * @param request DeleteInnerAppRequest
         * @param headers DeleteInnerAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInnerAppResponse
         */
        public async Task<DeleteInnerAppResponse> DeleteInnerAppWithOptionsAsync(string agentId, DeleteInnerAppRequest request, DeleteInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                query["opUnionId"] = request.OpUnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "DeleteInnerApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInnerAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除企业内部应用
         *
         * @param request DeleteInnerAppRequest
         * @return DeleteInnerAppResponse
         */
        public DeleteInnerAppResponse DeleteInnerApp(string agentId, DeleteInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteInnerAppHeaders headers = new DeleteInnerAppHeaders();
            return DeleteInnerAppWithOptions(agentId, request, headers, runtime);
        }

        /**
         * @summary 删除企业内部应用
         *
         * @param request DeleteInnerAppRequest
         * @return DeleteInnerAppResponse
         */
        public async Task<DeleteInnerAppResponse> DeleteInnerAppAsync(string agentId, DeleteInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteInnerAppHeaders headers = new DeleteInnerAppHeaders();
            return await DeleteInnerAppWithOptionsAsync(agentId, request, headers, runtime);
        }

        /**
         * @summary 查询Apaas应用
         *
         * @param headers GetApaasAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetApaasAppResponse
         */
        public GetApaasAppResponse GetApaasAppWithOptions(string bizAppId, GetApaasAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetApaasApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apaasApps/" + bizAppId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApaasAppResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询Apaas应用
         *
         * @param headers GetApaasAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetApaasAppResponse
         */
        public async Task<GetApaasAppResponse> GetApaasAppWithOptionsAsync(string bizAppId, GetApaasAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetApaasApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apaasApps/" + bizAppId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApaasAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询Apaas应用
         *
         * @return GetApaasAppResponse
         */
        public GetApaasAppResponse GetApaasApp(string bizAppId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetApaasAppHeaders headers = new GetApaasAppHeaders();
            return GetApaasAppWithOptions(bizAppId, headers, runtime);
        }

        /**
         * @summary 查询Apaas应用
         *
         * @return GetApaasAppResponse
         */
        public async Task<GetApaasAppResponse> GetApaasAppAsync(string bizAppId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetApaasAppHeaders headers = new GetApaasAppHeaders();
            return await GetApaasAppWithOptionsAsync(bizAppId, headers, runtime);
        }

        /**
         * @summary 获取应用资源用量信息
         *
         * @param request GetAppResourceUseInfoRequest
         * @param headers GetAppResourceUseInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppResourceUseInfoResponse
         */
        public GetAppResourceUseInfoResponse GetAppResourceUseInfoWithOptions(GetAppResourceUseInfoRequest request, GetAppResourceUseInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCode))
            {
                query["benefitCode"] = request.BenefitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["periodType"] = request.PeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetAppResourceUseInfo",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/resources/useInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetAppResourceUseInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取应用资源用量信息
         *
         * @param request GetAppResourceUseInfoRequest
         * @param headers GetAppResourceUseInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppResourceUseInfoResponse
         */
        public async Task<GetAppResourceUseInfoResponse> GetAppResourceUseInfoWithOptionsAsync(GetAppResourceUseInfoRequest request, GetAppResourceUseInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCode))
            {
                query["benefitCode"] = request.BenefitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["periodType"] = request.PeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetAppResourceUseInfo",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/resources/useInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetAppResourceUseInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取应用资源用量信息
         *
         * @param request GetAppResourceUseInfoRequest
         * @return GetAppResourceUseInfoResponse
         */
        public GetAppResourceUseInfoResponse GetAppResourceUseInfo(GetAppResourceUseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAppResourceUseInfoHeaders headers = new GetAppResourceUseInfoHeaders();
            return GetAppResourceUseInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取应用资源用量信息
         *
         * @param request GetAppResourceUseInfoRequest
         * @return GetAppResourceUseInfoResponse
         */
        public async Task<GetAppResourceUseInfoResponse> GetAppResourceUseInfoAsync(GetAppResourceUseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAppResourceUseInfoHeaders headers = new GetAppResourceUseInfoHeaders();
            return await GetAppResourceUseInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询指定角色的角色范围
         *
         * @param headers GetAppRoleScopeByRoleIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppRoleScopeByRoleIdResponse
         */
        public GetAppRoleScopeByRoleIdResponse GetAppRoleScopeByRoleIdWithOptions(string agentId, string roleId, GetAppRoleScopeByRoleIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAppRoleScopeByRoleId",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/scopes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppRoleScopeByRoleIdResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询指定角色的角色范围
         *
         * @param headers GetAppRoleScopeByRoleIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppRoleScopeByRoleIdResponse
         */
        public async Task<GetAppRoleScopeByRoleIdResponse> GetAppRoleScopeByRoleIdWithOptionsAsync(string agentId, string roleId, GetAppRoleScopeByRoleIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAppRoleScopeByRoleId",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/scopes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppRoleScopeByRoleIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询指定角色的角色范围
         *
         * @return GetAppRoleScopeByRoleIdResponse
         */
        public GetAppRoleScopeByRoleIdResponse GetAppRoleScopeByRoleId(string agentId, string roleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAppRoleScopeByRoleIdHeaders headers = new GetAppRoleScopeByRoleIdHeaders();
            return GetAppRoleScopeByRoleIdWithOptions(agentId, roleId, headers, runtime);
        }

        /**
         * @summary 查询指定角色的角色范围
         *
         * @return GetAppRoleScopeByRoleIdResponse
         */
        public async Task<GetAppRoleScopeByRoleIdResponse> GetAppRoleScopeByRoleIdAsync(string agentId, string roleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAppRoleScopeByRoleIdHeaders headers = new GetAppRoleScopeByRoleIdHeaders();
            return await GetAppRoleScopeByRoleIdWithOptionsAsync(agentId, roleId, headers, runtime);
        }

        /**
         * @summary 获取企业内部H5应用
         *
         * @param request GetInnerAppRequest
         * @param headers GetInnerAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInnerAppResponse
         */
        public GetInnerAppResponse GetInnerAppWithOptions(string agentId, GetInnerAppRequest request, GetInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                query["ecologicalCorpId"] = request.EcologicalCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                query["opUnionId"] = request.OpUnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetInnerApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInnerAppResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业内部H5应用
         *
         * @param request GetInnerAppRequest
         * @param headers GetInnerAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInnerAppResponse
         */
        public async Task<GetInnerAppResponse> GetInnerAppWithOptionsAsync(string agentId, GetInnerAppRequest request, GetInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                query["ecologicalCorpId"] = request.EcologicalCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                query["opUnionId"] = request.OpUnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetInnerApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInnerAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业内部H5应用
         *
         * @param request GetInnerAppRequest
         * @return GetInnerAppResponse
         */
        public GetInnerAppResponse GetInnerApp(string agentId, GetInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInnerAppHeaders headers = new GetInnerAppHeaders();
            return GetInnerAppWithOptions(agentId, request, headers, runtime);
        }

        /**
         * @summary 获取企业内部H5应用
         *
         * @param request GetInnerAppRequest
         * @return GetInnerAppResponse
         */
        public async Task<GetInnerAppResponse> GetInnerAppAsync(string agentId, GetInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInnerAppHeaders headers = new GetInnerAppHeaders();
            return await GetInnerAppWithOptionsAsync(agentId, request, headers, runtime);
        }

        /**
         * @summary 获取应用可见范围
         *
         * @param headers GetMicroAppScopeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMicroAppScopeResponse
         */
        public GetMicroAppScopeResponse GetMicroAppScopeWithOptions(string agentId, GetMicroAppScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetMicroAppScope",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/scopes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMicroAppScopeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取应用可见范围
         *
         * @param headers GetMicroAppScopeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMicroAppScopeResponse
         */
        public async Task<GetMicroAppScopeResponse> GetMicroAppScopeWithOptionsAsync(string agentId, GetMicroAppScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetMicroAppScope",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/scopes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMicroAppScopeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取应用可见范围
         *
         * @return GetMicroAppScopeResponse
         */
        public GetMicroAppScopeResponse GetMicroAppScope(string agentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMicroAppScopeHeaders headers = new GetMicroAppScopeHeaders();
            return GetMicroAppScopeWithOptions(agentId, headers, runtime);
        }

        /**
         * @summary 获取应用可见范围
         *
         * @return GetMicroAppScopeResponse
         */
        public async Task<GetMicroAppScopeResponse> GetMicroAppScopeAsync(string agentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMicroAppScopeHeaders headers = new GetMicroAppScopeHeaders();
            return await GetMicroAppScopeWithOptionsAsync(agentId, headers, runtime);
        }

        /**
         * @summary 获取用户对应用的管理权限
         *
         * @param headers GetMicroAppUserAccessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMicroAppUserAccessResponse
         */
        public GetMicroAppUserAccessResponse GetMicroAppUserAccessWithOptions(string agentId, string userId, GetMicroAppUserAccessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetMicroAppUserAccess",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/users/" + userId + "/adminAccess",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMicroAppUserAccessResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取用户对应用的管理权限
         *
         * @param headers GetMicroAppUserAccessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMicroAppUserAccessResponse
         */
        public async Task<GetMicroAppUserAccessResponse> GetMicroAppUserAccessWithOptionsAsync(string agentId, string userId, GetMicroAppUserAccessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetMicroAppUserAccess",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/users/" + userId + "/adminAccess",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMicroAppUserAccessResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户对应用的管理权限
         *
         * @return GetMicroAppUserAccessResponse
         */
        public GetMicroAppUserAccessResponse GetMicroAppUserAccess(string agentId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMicroAppUserAccessHeaders headers = new GetMicroAppUserAccessHeaders();
            return GetMicroAppUserAccessWithOptions(agentId, userId, headers, runtime);
        }

        /**
         * @summary 获取用户对应用的管理权限
         *
         * @return GetMicroAppUserAccessResponse
         */
        public async Task<GetMicroAppUserAccessResponse> GetMicroAppUserAccessAsync(string agentId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMicroAppUserAccessHeaders headers = new GetMicroAppUserAccessHeaders();
            return await GetMicroAppUserAccessWithOptionsAsync(agentId, userId, headers, runtime);
        }

        /**
         * @summary 用户是否拥有开发者权限
         *
         * @param headers GetUserAppDevAccessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserAppDevAccessResponse
         */
        public GetUserAppDevAccessResponse GetUserAppDevAccessWithOptions(string userId, GetUserAppDevAccessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetUserAppDevAccess",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/users/" + userId + "/devAccesses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserAppDevAccessResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 用户是否拥有开发者权限
         *
         * @param headers GetUserAppDevAccessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserAppDevAccessResponse
         */
        public async Task<GetUserAppDevAccessResponse> GetUserAppDevAccessWithOptionsAsync(string userId, GetUserAppDevAccessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetUserAppDevAccess",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/users/" + userId + "/devAccesses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserAppDevAccessResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 用户是否拥有开发者权限
         *
         * @return GetUserAppDevAccessResponse
         */
        public GetUserAppDevAccessResponse GetUserAppDevAccess(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserAppDevAccessHeaders headers = new GetUserAppDevAccessHeaders();
            return GetUserAppDevAccessWithOptions(userId, headers, runtime);
        }

        /**
         * @summary 用户是否拥有开发者权限
         *
         * @return GetUserAppDevAccessResponse
         */
        public async Task<GetUserAppDevAccessResponse> GetUserAppDevAccessAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserAppDevAccessHeaders headers = new GetUserAppDevAccessHeaders();
            return await GetUserAppDevAccessWithOptionsAsync(userId, headers, runtime);
        }

        /**
         * @summary 获取企业所有应用列表
         *
         * @param headers ListAllAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAllAppResponse
         */
        public ListAllAppResponse ListAllAppWithOptions(ListAllAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/allApps",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllAppResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业所有应用列表
         *
         * @param headers ListAllAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAllAppResponse
         */
        public async Task<ListAllAppResponse> ListAllAppWithOptionsAsync(ListAllAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/allApps",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业所有应用列表
         *
         * @return ListAllAppResponse
         */
        public ListAllAppResponse ListAllApp()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAllAppHeaders headers = new ListAllAppHeaders();
            return ListAllAppWithOptions(headers, runtime);
        }

        /**
         * @summary 获取企业所有应用列表
         *
         * @return ListAllAppResponse
         */
        public async Task<ListAllAppResponse> ListAllAppAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAllAppHeaders headers = new ListAllAppHeaders();
            return await ListAllAppWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 获取企业所有内部应用列表
         *
         * @param headers ListAllInnerAppsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAllInnerAppsResponse
         */
        public ListAllInnerAppsResponse ListAllInnerAppsWithOptions(ListAllInnerAppsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllInnerApps",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/allInnerApps",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllInnerAppsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业所有内部应用列表
         *
         * @param headers ListAllInnerAppsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAllInnerAppsResponse
         */
        public async Task<ListAllInnerAppsResponse> ListAllInnerAppsWithOptionsAsync(ListAllInnerAppsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllInnerApps",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/allInnerApps",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllInnerAppsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业所有内部应用列表
         *
         * @return ListAllInnerAppsResponse
         */
        public ListAllInnerAppsResponse ListAllInnerApps()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAllInnerAppsHeaders headers = new ListAllInnerAppsHeaders();
            return ListAllInnerAppsWithOptions(headers, runtime);
        }

        /**
         * @summary 获取企业所有内部应用列表
         *
         * @return ListAllInnerAppsResponse
         */
        public async Task<ListAllInnerAppsResponse> ListAllInnerAppsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAllInnerAppsHeaders headers = new ListAllInnerAppsHeaders();
            return await ListAllInnerAppsWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 获取企业应用的角色完整信息
         *
         * @param request ListAppRoleScopesRequest
         * @param headers ListAppRoleScopesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppRoleScopesResponse
         */
        public ListAppRoleScopesResponse ListAppRoleScopesWithOptions(string agentId, ListAppRoleScopesRequest request, ListAppRoleScopesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListAppRoleScopes",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppRoleScopesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业应用的角色完整信息
         *
         * @param request ListAppRoleScopesRequest
         * @param headers ListAppRoleScopesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppRoleScopesResponse
         */
        public async Task<ListAppRoleScopesResponse> ListAppRoleScopesWithOptionsAsync(string agentId, ListAppRoleScopesRequest request, ListAppRoleScopesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListAppRoleScopes",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppRoleScopesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业应用的角色完整信息
         *
         * @param request ListAppRoleScopesRequest
         * @return ListAppRoleScopesResponse
         */
        public ListAppRoleScopesResponse ListAppRoleScopes(string agentId, ListAppRoleScopesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAppRoleScopesHeaders headers = new ListAppRoleScopesHeaders();
            return ListAppRoleScopesWithOptions(agentId, request, headers, runtime);
        }

        /**
         * @summary 获取企业应用的角色完整信息
         *
         * @param request ListAppRoleScopesRequest
         * @return ListAppRoleScopesResponse
         */
        public async Task<ListAppRoleScopesResponse> ListAppRoleScopesAsync(string agentId, ListAppRoleScopesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAppRoleScopesHeaders headers = new ListAppRoleScopesHeaders();
            return await ListAppRoleScopesWithOptionsAsync(agentId, request, headers, runtime);
        }

        /**
         * @summary 列出企业内部H5应用
         *
         * @param request ListInnerAppRequest
         * @param headers ListInnerAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInnerAppResponse
         */
        public ListInnerAppResponse ListInnerAppWithOptions(ListInnerAppRequest request, ListInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                query["ecologicalCorpId"] = request.EcologicalCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListInnerApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInnerAppResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 列出企业内部H5应用
         *
         * @param request ListInnerAppRequest
         * @param headers ListInnerAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInnerAppResponse
         */
        public async Task<ListInnerAppResponse> ListInnerAppWithOptionsAsync(ListInnerAppRequest request, ListInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                query["ecologicalCorpId"] = request.EcologicalCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListInnerApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInnerAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 列出企业内部H5应用
         *
         * @param request ListInnerAppRequest
         * @return ListInnerAppResponse
         */
        public ListInnerAppResponse ListInnerApp(ListInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInnerAppHeaders headers = new ListInnerAppHeaders();
            return ListInnerAppWithOptions(request, headers, runtime);
        }

        /**
         * @summary 列出企业内部H5应用
         *
         * @param request ListInnerAppRequest
         * @return ListInnerAppResponse
         */
        public async Task<ListInnerAppResponse> ListInnerAppAsync(ListInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInnerAppHeaders headers = new ListInnerAppHeaders();
            return await ListInnerAppWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业内部小程序的版本列表
         *
         * @param headers ListInnerAppVersionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInnerAppVersionResponse
         */
        public ListInnerAppVersionResponse ListInnerAppVersionWithOptions(string agentId, ListInnerAppVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListInnerAppVersion",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/innerMiniApps/" + agentId + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInnerAppVersionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业内部小程序的版本列表
         *
         * @param headers ListInnerAppVersionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInnerAppVersionResponse
         */
        public async Task<ListInnerAppVersionResponse> ListInnerAppVersionWithOptionsAsync(string agentId, ListInnerAppVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListInnerAppVersion",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/innerMiniApps/" + agentId + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInnerAppVersionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业内部小程序的版本列表
         *
         * @return ListInnerAppVersionResponse
         */
        public ListInnerAppVersionResponse ListInnerAppVersion(string agentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInnerAppVersionHeaders headers = new ListInnerAppVersionHeaders();
            return ListInnerAppVersionWithOptions(agentId, headers, runtime);
        }

        /**
         * @summary 获取企业内部小程序的版本列表
         *
         * @return ListInnerAppVersionResponse
         */
        public async Task<ListInnerAppVersionResponse> ListInnerAppVersionAsync(string agentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInnerAppVersionHeaders headers = new ListInnerAppVersionHeaders();
            return await ListInnerAppVersionWithOptionsAsync(agentId, headers, runtime);
        }

        /**
         * @summary 获取用户在应用中的角色信息列表
         *
         * @param headers ListRoleInfoByUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRoleInfoByUserResponse
         */
        public ListRoleInfoByUserResponse ListRoleInfoByUserWithOptions(string agentId, string userId, ListRoleInfoByUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListRoleInfoByUser",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/users/" + userId + "/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRoleInfoByUserResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取用户在应用中的角色信息列表
         *
         * @param headers ListRoleInfoByUserHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRoleInfoByUserResponse
         */
        public async Task<ListRoleInfoByUserResponse> ListRoleInfoByUserWithOptionsAsync(string agentId, string userId, ListRoleInfoByUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListRoleInfoByUser",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/users/" + userId + "/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRoleInfoByUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户在应用中的角色信息列表
         *
         * @return ListRoleInfoByUserResponse
         */
        public ListRoleInfoByUserResponse ListRoleInfoByUser(string agentId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRoleInfoByUserHeaders headers = new ListRoleInfoByUserHeaders();
            return ListRoleInfoByUserWithOptions(agentId, userId, headers, runtime);
        }

        /**
         * @summary 获取用户在应用中的角色信息列表
         *
         * @return ListRoleInfoByUserResponse
         */
        public async Task<ListRoleInfoByUserResponse> ListRoleInfoByUserAsync(string agentId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRoleInfoByUserHeaders headers = new ListRoleInfoByUserHeaders();
            return await ListRoleInfoByUserWithOptionsAsync(agentId, userId, headers, runtime);
        }

        /**
         * @summary 列出用户可见的企业应用
         *
         * @param headers ListUserVilebleAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserVilebleAppResponse
         */
        public ListUserVilebleAppResponse ListUserVilebleAppWithOptions(string userId, ListUserVilebleAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListUserVilebleApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/users/" + userId + "/apps",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserVilebleAppResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 列出用户可见的企业应用
         *
         * @param headers ListUserVilebleAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserVilebleAppResponse
         */
        public async Task<ListUserVilebleAppResponse> ListUserVilebleAppWithOptionsAsync(string userId, ListUserVilebleAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListUserVilebleApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/users/" + userId + "/apps",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserVilebleAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 列出用户可见的企业应用
         *
         * @return ListUserVilebleAppResponse
         */
        public ListUserVilebleAppResponse ListUserVilebleApp(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserVilebleAppHeaders headers = new ListUserVilebleAppHeaders();
            return ListUserVilebleAppWithOptions(userId, headers, runtime);
        }

        /**
         * @summary 列出用户可见的企业应用
         *
         * @return ListUserVilebleAppResponse
         */
        public async Task<ListUserVilebleAppResponse> ListUserVilebleAppAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserVilebleAppHeaders headers = new ListUserVilebleAppHeaders();
            return await ListUserVilebleAppWithOptionsAsync(userId, headers, runtime);
        }

        /**
         * @summary 获取企业内部小程序历史版本列表
         *
         * @param request PageInnerAppHistoryVersionRequest
         * @param headers PageInnerAppHistoryVersionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageInnerAppHistoryVersionResponse
         */
        public PageInnerAppHistoryVersionResponse PageInnerAppHistoryVersionWithOptions(string agentId, PageInnerAppHistoryVersionRequest request, PageInnerAppHistoryVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "PageInnerAppHistoryVersion",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/innerMiniApps/" + agentId + "/historyVersions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageInnerAppHistoryVersionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业内部小程序历史版本列表
         *
         * @param request PageInnerAppHistoryVersionRequest
         * @param headers PageInnerAppHistoryVersionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageInnerAppHistoryVersionResponse
         */
        public async Task<PageInnerAppHistoryVersionResponse> PageInnerAppHistoryVersionWithOptionsAsync(string agentId, PageInnerAppHistoryVersionRequest request, PageInnerAppHistoryVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "PageInnerAppHistoryVersion",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/innerMiniApps/" + agentId + "/historyVersions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageInnerAppHistoryVersionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业内部小程序历史版本列表
         *
         * @param request PageInnerAppHistoryVersionRequest
         * @return PageInnerAppHistoryVersionResponse
         */
        public PageInnerAppHistoryVersionResponse PageInnerAppHistoryVersion(string agentId, PageInnerAppHistoryVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageInnerAppHistoryVersionHeaders headers = new PageInnerAppHistoryVersionHeaders();
            return PageInnerAppHistoryVersionWithOptions(agentId, request, headers, runtime);
        }

        /**
         * @summary 获取企业内部小程序历史版本列表
         *
         * @param request PageInnerAppHistoryVersionRequest
         * @return PageInnerAppHistoryVersionResponse
         */
        public async Task<PageInnerAppHistoryVersionResponse> PageInnerAppHistoryVersionAsync(string agentId, PageInnerAppHistoryVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PageInnerAppHistoryVersionHeaders headers = new PageInnerAppHistoryVersionHeaders();
            return await PageInnerAppHistoryVersionWithOptionsAsync(agentId, request, headers, runtime);
        }

        /**
         * @summary 发布企业内部小程序版本
         *
         * @param request PublishInnerAppVersionRequest
         * @param headers PublishInnerAppVersionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishInnerAppVersionResponse
         */
        public PublishInnerAppVersionResponse PublishInnerAppVersionWithOptions(string agentId, PublishInnerAppVersionRequest request, PublishInnerAppVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionId))
            {
                body["appVersionId"] = request.AppVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppOnPc))
            {
                body["miniAppOnPc"] = request.MiniAppOnPc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                body["opUnionId"] = request.OpUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishType))
            {
                body["publishType"] = request.PublishType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PublishInnerAppVersion",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/innerMiniApps/" + agentId + "/versions/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishInnerAppVersionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发布企业内部小程序版本
         *
         * @param request PublishInnerAppVersionRequest
         * @param headers PublishInnerAppVersionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishInnerAppVersionResponse
         */
        public async Task<PublishInnerAppVersionResponse> PublishInnerAppVersionWithOptionsAsync(string agentId, PublishInnerAppVersionRequest request, PublishInnerAppVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionId))
            {
                body["appVersionId"] = request.AppVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppOnPc))
            {
                body["miniAppOnPc"] = request.MiniAppOnPc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                body["opUnionId"] = request.OpUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishType))
            {
                body["publishType"] = request.PublishType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PublishInnerAppVersion",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/innerMiniApps/" + agentId + "/versions/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishInnerAppVersionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发布企业内部小程序版本
         *
         * @param request PublishInnerAppVersionRequest
         * @return PublishInnerAppVersionResponse
         */
        public PublishInnerAppVersionResponse PublishInnerAppVersion(string agentId, PublishInnerAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishInnerAppVersionHeaders headers = new PublishInnerAppVersionHeaders();
            return PublishInnerAppVersionWithOptions(agentId, request, headers, runtime);
        }

        /**
         * @summary 发布企业内部小程序版本
         *
         * @param request PublishInnerAppVersionRequest
         * @return PublishInnerAppVersionResponse
         */
        public async Task<PublishInnerAppVersionResponse> PublishInnerAppVersionAsync(string agentId, PublishInnerAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishInnerAppVersionHeaders headers = new PublishInnerAppVersionHeaders();
            return await PublishInnerAppVersionWithOptionsAsync(agentId, request, headers, runtime);
        }

        /**
         * @summary 重设角色范围
         *
         * @param request RebuildRoleScopeForAppRoleRequest
         * @param headers RebuildRoleScopeForAppRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RebuildRoleScopeForAppRoleResponse
         */
        public RebuildRoleScopeForAppRoleResponse RebuildRoleScopeForAppRoleWithOptions(string agentId, string roleId, RebuildRoleScopeForAppRoleRequest request, RebuildRoleScopeForAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIdList))
            {
                body["deptIdList"] = request.DeptIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                body["scopeType"] = request.ScopeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeVersion))
            {
                body["scopeVersion"] = request.ScopeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RebuildRoleScopeForAppRole",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/scopes/rebuild",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebuildRoleScopeForAppRoleResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 重设角色范围
         *
         * @param request RebuildRoleScopeForAppRoleRequest
         * @param headers RebuildRoleScopeForAppRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RebuildRoleScopeForAppRoleResponse
         */
        public async Task<RebuildRoleScopeForAppRoleResponse> RebuildRoleScopeForAppRoleWithOptionsAsync(string agentId, string roleId, RebuildRoleScopeForAppRoleRequest request, RebuildRoleScopeForAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIdList))
            {
                body["deptIdList"] = request.DeptIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                body["scopeType"] = request.ScopeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeVersion))
            {
                body["scopeVersion"] = request.ScopeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RebuildRoleScopeForAppRole",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/scopes/rebuild",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebuildRoleScopeForAppRoleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 重设角色范围
         *
         * @param request RebuildRoleScopeForAppRoleRequest
         * @return RebuildRoleScopeForAppRoleResponse
         */
        public RebuildRoleScopeForAppRoleResponse RebuildRoleScopeForAppRole(string agentId, string roleId, RebuildRoleScopeForAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RebuildRoleScopeForAppRoleHeaders headers = new RebuildRoleScopeForAppRoleHeaders();
            return RebuildRoleScopeForAppRoleWithOptions(agentId, roleId, request, headers, runtime);
        }

        /**
         * @summary 重设角色范围
         *
         * @param request RebuildRoleScopeForAppRoleRequest
         * @return RebuildRoleScopeForAppRoleResponse
         */
        public async Task<RebuildRoleScopeForAppRoleResponse> RebuildRoleScopeForAppRoleAsync(string agentId, string roleId, RebuildRoleScopeForAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RebuildRoleScopeForAppRoleHeaders headers = new RebuildRoleScopeForAppRoleHeaders();
            return await RebuildRoleScopeForAppRoleWithOptionsAsync(agentId, roleId, request, headers, runtime);
        }

        /**
         * @summary 注册自定义应用角色
         *
         * @param request RegisterCustomAppRoleRequest
         * @param headers RegisterCustomAppRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterCustomAppRoleResponse
         */
        public RegisterCustomAppRoleResponse RegisterCustomAppRoleWithOptions(string agentId, RegisterCustomAppRoleRequest request, RegisterCustomAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CanManageRole))
            {
                body["canManageRole"] = request.CanManageRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["roleName"] = request.RoleName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RegisterCustomAppRole",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/roles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterCustomAppRoleResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 注册自定义应用角色
         *
         * @param request RegisterCustomAppRoleRequest
         * @param headers RegisterCustomAppRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterCustomAppRoleResponse
         */
        public async Task<RegisterCustomAppRoleResponse> RegisterCustomAppRoleWithOptionsAsync(string agentId, RegisterCustomAppRoleRequest request, RegisterCustomAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CanManageRole))
            {
                body["canManageRole"] = request.CanManageRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["roleName"] = request.RoleName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RegisterCustomAppRole",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/roles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterCustomAppRoleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 注册自定义应用角色
         *
         * @param request RegisterCustomAppRoleRequest
         * @return RegisterCustomAppRoleResponse
         */
        public RegisterCustomAppRoleResponse RegisterCustomAppRole(string agentId, RegisterCustomAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCustomAppRoleHeaders headers = new RegisterCustomAppRoleHeaders();
            return RegisterCustomAppRoleWithOptions(agentId, request, headers, runtime);
        }

        /**
         * @summary 注册自定义应用角色
         *
         * @param request RegisterCustomAppRoleRequest
         * @return RegisterCustomAppRoleResponse
         */
        public async Task<RegisterCustomAppRoleResponse> RegisterCustomAppRoleAsync(string agentId, RegisterCustomAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCustomAppRoleHeaders headers = new RegisterCustomAppRoleHeaders();
            return await RegisterCustomAppRoleWithOptionsAsync(agentId, request, headers, runtime);
        }

        /**
         * @summary 删除apaas应用
         *
         * @param request RemoveApaasAppRequest
         * @param headers RemoveApaasAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveApaasAppResponse
         */
        public RemoveApaasAppResponse RemoveApaasAppWithOptions(RemoveApaasAppRequest request, RemoveApaasAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizAppId))
            {
                body["bizAppId"] = request.BizAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RemoveApaasApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apaasApps/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveApaasAppResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除apaas应用
         *
         * @param request RemoveApaasAppRequest
         * @param headers RemoveApaasAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveApaasAppResponse
         */
        public async Task<RemoveApaasAppResponse> RemoveApaasAppWithOptionsAsync(RemoveApaasAppRequest request, RemoveApaasAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizAppId))
            {
                body["bizAppId"] = request.BizAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RemoveApaasApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apaasApps/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveApaasAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除apaas应用
         *
         * @param request RemoveApaasAppRequest
         * @return RemoveApaasAppResponse
         */
        public RemoveApaasAppResponse RemoveApaasApp(RemoveApaasAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveApaasAppHeaders headers = new RemoveApaasAppHeaders();
            return RemoveApaasAppWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除apaas应用
         *
         * @param request RemoveApaasAppRequest
         * @return RemoveApaasAppResponse
         */
        public async Task<RemoveApaasAppResponse> RemoveApaasAppAsync(RemoveApaasAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveApaasAppHeaders headers = new RemoveApaasAppHeaders();
            return await RemoveApaasAppWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除指定角色下的成员
         *
         * @param request RemoveMemberForAppRoleRequest
         * @param headers RemoveMemberForAppRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveMemberForAppRoleResponse
         */
        public RemoveMemberForAppRoleResponse RemoveMemberForAppRoleWithOptions(string agentId, string roleId, RemoveMemberForAppRoleRequest request, RemoveMemberForAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIdList))
            {
                body["deptIdList"] = request.DeptIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeVersion))
            {
                body["scopeVersion"] = request.ScopeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RemoveMemberForAppRole",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/members/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveMemberForAppRoleResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除指定角色下的成员
         *
         * @param request RemoveMemberForAppRoleRequest
         * @param headers RemoveMemberForAppRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveMemberForAppRoleResponse
         */
        public async Task<RemoveMemberForAppRoleResponse> RemoveMemberForAppRoleWithOptionsAsync(string agentId, string roleId, RemoveMemberForAppRoleRequest request, RemoveMemberForAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIdList))
            {
                body["deptIdList"] = request.DeptIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeVersion))
            {
                body["scopeVersion"] = request.ScopeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RemoveMemberForAppRole",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/members/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveMemberForAppRoleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除指定角色下的成员
         *
         * @param request RemoveMemberForAppRoleRequest
         * @return RemoveMemberForAppRoleResponse
         */
        public RemoveMemberForAppRoleResponse RemoveMemberForAppRole(string agentId, string roleId, RemoveMemberForAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveMemberForAppRoleHeaders headers = new RemoveMemberForAppRoleHeaders();
            return RemoveMemberForAppRoleWithOptions(agentId, roleId, request, headers, runtime);
        }

        /**
         * @summary 删除指定角色下的成员
         *
         * @param request RemoveMemberForAppRoleRequest
         * @return RemoveMemberForAppRoleResponse
         */
        public async Task<RemoveMemberForAppRoleResponse> RemoveMemberForAppRoleAsync(string agentId, string roleId, RemoveMemberForAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveMemberForAppRoleHeaders headers = new RemoveMemberForAppRoleHeaders();
            return await RemoveMemberForAppRoleWithOptionsAsync(agentId, roleId, request, headers, runtime);
        }

        /**
         * @summary 回滚企业内部小程序版本
         *
         * @param request RollbackInnerAppVersionRequest
         * @param headers RollbackInnerAppVersionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RollbackInnerAppVersionResponse
         */
        public RollbackInnerAppVersionResponse RollbackInnerAppVersionWithOptions(string agentId, RollbackInnerAppVersionRequest request, RollbackInnerAppVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionId))
            {
                body["appVersionId"] = request.AppVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                body["opUnionId"] = request.OpUnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RollbackInnerAppVersion",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/innerMiniApps/" + agentId + "/versions/rollback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackInnerAppVersionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 回滚企业内部小程序版本
         *
         * @param request RollbackInnerAppVersionRequest
         * @param headers RollbackInnerAppVersionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RollbackInnerAppVersionResponse
         */
        public async Task<RollbackInnerAppVersionResponse> RollbackInnerAppVersionWithOptionsAsync(string agentId, RollbackInnerAppVersionRequest request, RollbackInnerAppVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionId))
            {
                body["appVersionId"] = request.AppVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                body["opUnionId"] = request.OpUnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RollbackInnerAppVersion",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/innerMiniApps/" + agentId + "/versions/rollback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackInnerAppVersionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 回滚企业内部小程序版本
         *
         * @param request RollbackInnerAppVersionRequest
         * @return RollbackInnerAppVersionResponse
         */
        public RollbackInnerAppVersionResponse RollbackInnerAppVersion(string agentId, RollbackInnerAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RollbackInnerAppVersionHeaders headers = new RollbackInnerAppVersionHeaders();
            return RollbackInnerAppVersionWithOptions(agentId, request, headers, runtime);
        }

        /**
         * @summary 回滚企业内部小程序版本
         *
         * @param request RollbackInnerAppVersionRequest
         * @return RollbackInnerAppVersionResponse
         */
        public async Task<RollbackInnerAppVersionResponse> RollbackInnerAppVersionAsync(string agentId, RollbackInnerAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RollbackInnerAppVersionHeaders headers = new RollbackInnerAppVersionHeaders();
            return await RollbackInnerAppVersionWithOptionsAsync(agentId, request, headers, runtime);
        }

        /**
         * @summary 设置应用可见范围
         *
         * @param request SetMicroAppScopeRequest
         * @param headers SetMicroAppScopeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetMicroAppScopeResponse
         */
        public SetMicroAppScopeResponse SetMicroAppScopeWithOptions(string agentId, SetMicroAppScopeRequest request, SetMicroAppScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddDeptIds))
            {
                body["addDeptIds"] = request.AddDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddRoleIds))
            {
                body["addRoleIds"] = request.AddRoleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddUserIds))
            {
                body["addUserIds"] = request.AddUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelDeptIds))
            {
                body["delDeptIds"] = request.DelDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelRoleIds))
            {
                body["delRoleIds"] = request.DelRoleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelUserIds))
            {
                body["delUserIds"] = request.DelUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyAdminVisible))
            {
                body["onlyAdminVisible"] = request.OnlyAdminVisible;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetMicroAppScope",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/scopes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetMicroAppScopeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 设置应用可见范围
         *
         * @param request SetMicroAppScopeRequest
         * @param headers SetMicroAppScopeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetMicroAppScopeResponse
         */
        public async Task<SetMicroAppScopeResponse> SetMicroAppScopeWithOptionsAsync(string agentId, SetMicroAppScopeRequest request, SetMicroAppScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddDeptIds))
            {
                body["addDeptIds"] = request.AddDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddRoleIds))
            {
                body["addRoleIds"] = request.AddRoleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddUserIds))
            {
                body["addUserIds"] = request.AddUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelDeptIds))
            {
                body["delDeptIds"] = request.DelDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelRoleIds))
            {
                body["delRoleIds"] = request.DelRoleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelUserIds))
            {
                body["delUserIds"] = request.DelUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyAdminVisible))
            {
                body["onlyAdminVisible"] = request.OnlyAdminVisible;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetMicroAppScope",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/scopes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetMicroAppScopeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 设置应用可见范围
         *
         * @param request SetMicroAppScopeRequest
         * @return SetMicroAppScopeResponse
         */
        public SetMicroAppScopeResponse SetMicroAppScope(string agentId, SetMicroAppScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetMicroAppScopeHeaders headers = new SetMicroAppScopeHeaders();
            return SetMicroAppScopeWithOptions(agentId, request, headers, runtime);
        }

        /**
         * @summary 设置应用可见范围
         *
         * @param request SetMicroAppScopeRequest
         * @return SetMicroAppScopeResponse
         */
        public async Task<SetMicroAppScopeResponse> SetMicroAppScopeAsync(string agentId, SetMicroAppScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetMicroAppScopeHeaders headers = new SetMicroAppScopeHeaders();
            return await SetMicroAppScopeWithOptionsAsync(agentId, request, headers, runtime);
        }

        /**
         * @summary 更新apaas应用
         *
         * @param request UpdateApaasAppRequest
         * @param headers UpdateApaasAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApaasAppResponse
         */
        public UpdateApaasAppResponse UpdateApaasAppWithOptions(UpdateApaasAppRequest request, UpdateApaasAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIcon))
            {
                body["appIcon"] = request.AppIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppStatus))
            {
                body["appStatus"] = request.AppStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizAppId))
            {
                body["bizAppId"] = request.BizAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateApaasApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apaasApps",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApaasAppResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新apaas应用
         *
         * @param request UpdateApaasAppRequest
         * @param headers UpdateApaasAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApaasAppResponse
         */
        public async Task<UpdateApaasAppResponse> UpdateApaasAppWithOptionsAsync(UpdateApaasAppRequest request, UpdateApaasAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIcon))
            {
                body["appIcon"] = request.AppIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppStatus))
            {
                body["appStatus"] = request.AppStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizAppId))
            {
                body["bizAppId"] = request.BizAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateApaasApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apaasApps",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApaasAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新apaas应用
         *
         * @param request UpdateApaasAppRequest
         * @return UpdateApaasAppResponse
         */
        public UpdateApaasAppResponse UpdateApaasApp(UpdateApaasAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateApaasAppHeaders headers = new UpdateApaasAppHeaders();
            return UpdateApaasAppWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新apaas应用
         *
         * @param request UpdateApaasAppRequest
         * @return UpdateApaasAppResponse
         */
        public async Task<UpdateApaasAppResponse> UpdateApaasAppAsync(UpdateApaasAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateApaasAppHeaders headers = new UpdateApaasAppHeaders();
            return await UpdateApaasAppWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新应用角色信息
         *
         * @param request UpdateAppRoleInfoRequest
         * @param headers UpdateAppRoleInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAppRoleInfoResponse
         */
        public UpdateAppRoleInfoResponse UpdateAppRoleInfoWithOptions(string agentId, string roleId, UpdateAppRoleInfoRequest request, UpdateAppRoleInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CanManageRole))
            {
                body["canManageRole"] = request.CanManageRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewRoleName))
            {
                body["newRoleName"] = request.NewRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateAppRoleInfo",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppRoleInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新应用角色信息
         *
         * @param request UpdateAppRoleInfoRequest
         * @param headers UpdateAppRoleInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAppRoleInfoResponse
         */
        public async Task<UpdateAppRoleInfoResponse> UpdateAppRoleInfoWithOptionsAsync(string agentId, string roleId, UpdateAppRoleInfoRequest request, UpdateAppRoleInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CanManageRole))
            {
                body["canManageRole"] = request.CanManageRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewRoleName))
            {
                body["newRoleName"] = request.NewRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateAppRoleInfo",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppRoleInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新应用角色信息
         *
         * @param request UpdateAppRoleInfoRequest
         * @return UpdateAppRoleInfoResponse
         */
        public UpdateAppRoleInfoResponse UpdateAppRoleInfo(string agentId, string roleId, UpdateAppRoleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateAppRoleInfoHeaders headers = new UpdateAppRoleInfoHeaders();
            return UpdateAppRoleInfoWithOptions(agentId, roleId, request, headers, runtime);
        }

        /**
         * @summary 更新应用角色信息
         *
         * @param request UpdateAppRoleInfoRequest
         * @return UpdateAppRoleInfoResponse
         */
        public async Task<UpdateAppRoleInfoResponse> UpdateAppRoleInfoAsync(string agentId, string roleId, UpdateAppRoleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateAppRoleInfoHeaders headers = new UpdateAppRoleInfoHeaders();
            return await UpdateAppRoleInfoWithOptionsAsync(agentId, roleId, request, headers, runtime);
        }

        /**
         * @summary 更新企业内部应用
         *
         * @param request UpdateInnerAppRequest
         * @param headers UpdateInnerAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInnerAppResponse
         */
        public UpdateInnerAppResponse UpdateInnerAppWithOptions(string agentId, UpdateInnerAppRequest request, UpdateInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HomepageLink))
            {
                body["homepageLink"] = request.HomepageLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhiteList))
            {
                body["ipWhiteList"] = request.IpWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OmpLink))
            {
                body["ompLink"] = request.OmpLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                body["opUnionId"] = request.OpUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcHomepageLink))
            {
                body["pcHomepageLink"] = request.PcHomepageLink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateInnerApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInnerAppResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新企业内部应用
         *
         * @param request UpdateInnerAppRequest
         * @param headers UpdateInnerAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInnerAppResponse
         */
        public async Task<UpdateInnerAppResponse> UpdateInnerAppWithOptionsAsync(string agentId, UpdateInnerAppRequest request, UpdateInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HomepageLink))
            {
                body["homepageLink"] = request.HomepageLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhiteList))
            {
                body["ipWhiteList"] = request.IpWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OmpLink))
            {
                body["ompLink"] = request.OmpLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                body["opUnionId"] = request.OpUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcHomepageLink))
            {
                body["pcHomepageLink"] = request.PcHomepageLink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateInnerApp",
                Version = "microApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/microApp/apps/" + agentId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInnerAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新企业内部应用
         *
         * @param request UpdateInnerAppRequest
         * @return UpdateInnerAppResponse
         */
        public UpdateInnerAppResponse UpdateInnerApp(string agentId, UpdateInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInnerAppHeaders headers = new UpdateInnerAppHeaders();
            return UpdateInnerAppWithOptions(agentId, request, headers, runtime);
        }

        /**
         * @summary 更新企业内部应用
         *
         * @param request UpdateInnerAppRequest
         * @return UpdateInnerAppResponse
         */
        public async Task<UpdateInnerAppResponse> UpdateInnerAppAsync(string agentId, UpdateInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInnerAppHeaders headers = new UpdateInnerAppHeaders();
            return await UpdateInnerAppWithOptionsAsync(agentId, request, headers, runtime);
        }

    }
}
