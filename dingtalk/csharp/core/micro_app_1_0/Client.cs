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

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public AddAppRolesToMemberResponse AddAppRolesToMember(string agentId, AddAppRolesToMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAppRolesToMemberHeaders headers = new AddAppRolesToMemberHeaders();
            return AddAppRolesToMemberWithOptions(agentId, request, headers, runtime);
        }

        public async Task<AddAppRolesToMemberResponse> AddAppRolesToMemberAsync(string agentId, AddAppRolesToMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAppRolesToMemberHeaders headers = new AddAppRolesToMemberHeaders();
            return await AddAppRolesToMemberWithOptionsAsync(agentId, request, headers, runtime);
        }

        public AddAppRolesToMemberResponse AddAppRolesToMemberWithOptions(string agentId, AddAppRolesToMemberRequest request, AddAppRolesToMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddAppRolesToMemberResponse>(DoROARequest("AddAppRolesToMember", "microApp_1.0", "HTTP", "PUT", "AK", "/v1.0/microApp/apps/" + agentId + "/members/roles", "json", req, runtime));
        }

        public async Task<AddAppRolesToMemberResponse> AddAppRolesToMemberWithOptionsAsync(string agentId, AddAppRolesToMemberRequest request, AddAppRolesToMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddAppRolesToMemberResponse>(await DoROARequestAsync("AddAppRolesToMember", "microApp_1.0", "HTTP", "PUT", "AK", "/v1.0/microApp/apps/" + agentId + "/members/roles", "json", req, runtime));
        }

        public AddAppToWorkBenchGroupResponse AddAppToWorkBenchGroup(string agentId, AddAppToWorkBenchGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAppToWorkBenchGroupHeaders headers = new AddAppToWorkBenchGroupHeaders();
            return AddAppToWorkBenchGroupWithOptions(agentId, request, headers, runtime);
        }

        public async Task<AddAppToWorkBenchGroupResponse> AddAppToWorkBenchGroupAsync(string agentId, AddAppToWorkBenchGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAppToWorkBenchGroupHeaders headers = new AddAppToWorkBenchGroupHeaders();
            return await AddAppToWorkBenchGroupWithOptionsAsync(agentId, request, headers, runtime);
        }

        public AddAppToWorkBenchGroupResponse AddAppToWorkBenchGroupWithOptions(string agentId, AddAppToWorkBenchGroupRequest request, AddAppToWorkBenchGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddAppToWorkBenchGroupResponse>(DoROARequest("AddAppToWorkBenchGroup", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps/" + agentId + "/addToWorkBenchGroup", "json", req, runtime));
        }

        public async Task<AddAppToWorkBenchGroupResponse> AddAppToWorkBenchGroupWithOptionsAsync(string agentId, AddAppToWorkBenchGroupRequest request, AddAppToWorkBenchGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddAppToWorkBenchGroupResponse>(await DoROARequestAsync("AddAppToWorkBenchGroup", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps/" + agentId + "/addToWorkBenchGroup", "json", req, runtime));
        }

        public AddMemberToAppRoleResponse AddMemberToAppRole(string agentId, string roleId, AddMemberToAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddMemberToAppRoleHeaders headers = new AddMemberToAppRoleHeaders();
            return AddMemberToAppRoleWithOptions(agentId, roleId, request, headers, runtime);
        }

        public async Task<AddMemberToAppRoleResponse> AddMemberToAppRoleAsync(string agentId, string roleId, AddMemberToAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddMemberToAppRoleHeaders headers = new AddMemberToAppRoleHeaders();
            return await AddMemberToAppRoleWithOptionsAsync(agentId, roleId, request, headers, runtime);
        }

        public AddMemberToAppRoleResponse AddMemberToAppRoleWithOptions(string agentId, string roleId, AddMemberToAppRoleRequest request, AddMemberToAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
            roleId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddMemberToAppRoleResponse>(DoROARequest("AddMemberToAppRole", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/members", "json", req, runtime));
        }

        public async Task<AddMemberToAppRoleResponse> AddMemberToAppRoleWithOptionsAsync(string agentId, string roleId, AddMemberToAppRoleRequest request, AddMemberToAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
            roleId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddMemberToAppRoleResponse>(await DoROARequestAsync("AddMemberToAppRole", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/members", "json", req, runtime));
        }

        public CreateApaasAppResponse CreateApaasApp(CreateApaasAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateApaasAppHeaders headers = new CreateApaasAppHeaders();
            return CreateApaasAppWithOptions(request, headers, runtime);
        }

        public async Task<CreateApaasAppResponse> CreateApaasAppAsync(CreateApaasAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateApaasAppHeaders headers = new CreateApaasAppHeaders();
            return await CreateApaasAppWithOptionsAsync(request, headers, runtime);
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateApaasAppResponse>(DoROARequest("CreateApaasApp", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apaasApps", "json", req, runtime));
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateApaasAppResponse>(await DoROARequestAsync("CreateApaasApp", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apaasApps", "json", req, runtime));
        }

        public CreateInnerAppResponse CreateInnerApp(CreateInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateInnerAppHeaders headers = new CreateInnerAppHeaders();
            return CreateInnerAppWithOptions(request, headers, runtime);
        }

        public async Task<CreateInnerAppResponse> CreateInnerAppAsync(CreateInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateInnerAppHeaders headers = new CreateInnerAppHeaders();
            return await CreateInnerAppWithOptionsAsync(request, headers, runtime);
        }

        public CreateInnerAppResponse CreateInnerAppWithOptions(CreateInnerAppRequest request, CreateInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateInnerAppResponse>(DoROARequest("CreateInnerApp", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps", "json", req, runtime));
        }

        public async Task<CreateInnerAppResponse> CreateInnerAppWithOptionsAsync(CreateInnerAppRequest request, CreateInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateInnerAppResponse>(await DoROARequestAsync("CreateInnerApp", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps", "json", req, runtime));
        }

        public DeleteAppRoleResponse DeleteAppRole(string agentId, string roleId, DeleteAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAppRoleHeaders headers = new DeleteAppRoleHeaders();
            return DeleteAppRoleWithOptions(agentId, roleId, request, headers, runtime);
        }

        public async Task<DeleteAppRoleResponse> DeleteAppRoleAsync(string agentId, string roleId, DeleteAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAppRoleHeaders headers = new DeleteAppRoleHeaders();
            return await DeleteAppRoleWithOptionsAsync(agentId, roleId, request, headers, runtime);
        }

        public DeleteAppRoleResponse DeleteAppRoleWithOptions(string agentId, string roleId, DeleteAppRoleRequest request, DeleteAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
            roleId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteAppRoleResponse>(DoROARequest("DeleteAppRole", "microApp_1.0", "HTTP", "DELETE", "AK", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId, "json", req, runtime));
        }

        public async Task<DeleteAppRoleResponse> DeleteAppRoleWithOptionsAsync(string agentId, string roleId, DeleteAppRoleRequest request, DeleteAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
            roleId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteAppRoleResponse>(await DoROARequestAsync("DeleteAppRole", "microApp_1.0", "HTTP", "DELETE", "AK", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId, "json", req, runtime));
        }

        public DeleteInnerAppResponse DeleteInnerApp(string agentId, DeleteInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteInnerAppHeaders headers = new DeleteInnerAppHeaders();
            return DeleteInnerAppWithOptions(agentId, request, headers, runtime);
        }

        public async Task<DeleteInnerAppResponse> DeleteInnerAppAsync(string agentId, DeleteInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteInnerAppHeaders headers = new DeleteInnerAppHeaders();
            return await DeleteInnerAppWithOptionsAsync(agentId, request, headers, runtime);
        }

        public DeleteInnerAppResponse DeleteInnerAppWithOptions(string agentId, DeleteInnerAppRequest request, DeleteInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteInnerAppResponse>(DoROARequest("DeleteInnerApp", "microApp_1.0", "HTTP", "DELETE", "AK", "/v1.0/microApp/apps/" + agentId, "json", req, runtime));
        }

        public async Task<DeleteInnerAppResponse> DeleteInnerAppWithOptionsAsync(string agentId, DeleteInnerAppRequest request, DeleteInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteInnerAppResponse>(await DoROARequestAsync("DeleteInnerApp", "microApp_1.0", "HTTP", "DELETE", "AK", "/v1.0/microApp/apps/" + agentId, "json", req, runtime));
        }

        public GetApaasAppResponse GetApaasApp(string bizAppId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetApaasAppHeaders headers = new GetApaasAppHeaders();
            return GetApaasAppWithOptions(bizAppId, headers, runtime);
        }

        public async Task<GetApaasAppResponse> GetApaasAppAsync(string bizAppId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetApaasAppHeaders headers = new GetApaasAppHeaders();
            return await GetApaasAppWithOptionsAsync(bizAppId, headers, runtime);
        }

        public GetApaasAppResponse GetApaasAppWithOptions(string bizAppId, GetApaasAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            bizAppId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(bizAppId);
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
            return TeaModel.ToObject<GetApaasAppResponse>(DoROARequest("GetApaasApp", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apaasApps/" + bizAppId, "json", req, runtime));
        }

        public async Task<GetApaasAppResponse> GetApaasAppWithOptionsAsync(string bizAppId, GetApaasAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            bizAppId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(bizAppId);
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
            return TeaModel.ToObject<GetApaasAppResponse>(await DoROARequestAsync("GetApaasApp", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apaasApps/" + bizAppId, "json", req, runtime));
        }

        public GetAppRoleScopeByRoleIdResponse GetAppRoleScopeByRoleId(string agentId, string roleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAppRoleScopeByRoleIdHeaders headers = new GetAppRoleScopeByRoleIdHeaders();
            return GetAppRoleScopeByRoleIdWithOptions(agentId, roleId, headers, runtime);
        }

        public async Task<GetAppRoleScopeByRoleIdResponse> GetAppRoleScopeByRoleIdAsync(string agentId, string roleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAppRoleScopeByRoleIdHeaders headers = new GetAppRoleScopeByRoleIdHeaders();
            return await GetAppRoleScopeByRoleIdWithOptionsAsync(agentId, roleId, headers, runtime);
        }

        public GetAppRoleScopeByRoleIdResponse GetAppRoleScopeByRoleIdWithOptions(string agentId, string roleId, GetAppRoleScopeByRoleIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
            roleId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleId);
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
            return TeaModel.ToObject<GetAppRoleScopeByRoleIdResponse>(DoROARequest("GetAppRoleScopeByRoleId", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/scopes", "json", req, runtime));
        }

        public async Task<GetAppRoleScopeByRoleIdResponse> GetAppRoleScopeByRoleIdWithOptionsAsync(string agentId, string roleId, GetAppRoleScopeByRoleIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
            roleId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleId);
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
            return TeaModel.ToObject<GetAppRoleScopeByRoleIdResponse>(await DoROARequestAsync("GetAppRoleScopeByRoleId", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/scopes", "json", req, runtime));
        }

        public GetInnerAppResponse GetInnerApp(string agentId, GetInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInnerAppHeaders headers = new GetInnerAppHeaders();
            return GetInnerAppWithOptions(agentId, request, headers, runtime);
        }

        public async Task<GetInnerAppResponse> GetInnerAppAsync(string agentId, GetInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInnerAppHeaders headers = new GetInnerAppHeaders();
            return await GetInnerAppWithOptionsAsync(agentId, request, headers, runtime);
        }

        public GetInnerAppResponse GetInnerAppWithOptions(string agentId, GetInnerAppRequest request, GetInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetInnerAppResponse>(DoROARequest("GetInnerApp", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apps/" + agentId, "json", req, runtime));
        }

        public async Task<GetInnerAppResponse> GetInnerAppWithOptionsAsync(string agentId, GetInnerAppRequest request, GetInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetInnerAppResponse>(await DoROARequestAsync("GetInnerApp", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apps/" + agentId, "json", req, runtime));
        }

        public ListAllAppResponse ListAllApp()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAllAppHeaders headers = new ListAllAppHeaders();
            return ListAllAppWithOptions(headers, runtime);
        }

        public async Task<ListAllAppResponse> ListAllAppAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAllAppHeaders headers = new ListAllAppHeaders();
            return await ListAllAppWithOptionsAsync(headers, runtime);
        }

        public ListAllAppResponse ListAllAppWithOptions(ListAllAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            return TeaModel.ToObject<ListAllAppResponse>(DoROARequest("ListAllApp", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/allApps", "json", req, runtime));
        }

        public async Task<ListAllAppResponse> ListAllAppWithOptionsAsync(ListAllAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            return TeaModel.ToObject<ListAllAppResponse>(await DoROARequestAsync("ListAllApp", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/allApps", "json", req, runtime));
        }

        public ListAppRoleScopesResponse ListAppRoleScopes(string agentId, ListAppRoleScopesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAppRoleScopesHeaders headers = new ListAppRoleScopesHeaders();
            return ListAppRoleScopesWithOptions(agentId, request, headers, runtime);
        }

        public async Task<ListAppRoleScopesResponse> ListAppRoleScopesAsync(string agentId, ListAppRoleScopesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAppRoleScopesHeaders headers = new ListAppRoleScopesHeaders();
            return await ListAppRoleScopesWithOptionsAsync(agentId, request, headers, runtime);
        }

        public ListAppRoleScopesResponse ListAppRoleScopesWithOptions(string agentId, ListAppRoleScopesRequest request, ListAppRoleScopesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListAppRoleScopesResponse>(DoROARequest("ListAppRoleScopes", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apps/" + agentId + "/roles", "json", req, runtime));
        }

        public async Task<ListAppRoleScopesResponse> ListAppRoleScopesWithOptionsAsync(string agentId, ListAppRoleScopesRequest request, ListAppRoleScopesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListAppRoleScopesResponse>(await DoROARequestAsync("ListAppRoleScopes", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apps/" + agentId + "/roles", "json", req, runtime));
        }

        public ListInnerAppResponse ListInnerApp(ListInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInnerAppHeaders headers = new ListInnerAppHeaders();
            return ListInnerAppWithOptions(request, headers, runtime);
        }

        public async Task<ListInnerAppResponse> ListInnerAppAsync(ListInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInnerAppHeaders headers = new ListInnerAppHeaders();
            return await ListInnerAppWithOptionsAsync(request, headers, runtime);
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListInnerAppResponse>(DoROARequest("ListInnerApp", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apps", "json", req, runtime));
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListInnerAppResponse>(await DoROARequestAsync("ListInnerApp", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apps", "json", req, runtime));
        }

        public ListRoleInfoByUserResponse ListRoleInfoByUser(string agentId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRoleInfoByUserHeaders headers = new ListRoleInfoByUserHeaders();
            return ListRoleInfoByUserWithOptions(agentId, userId, headers, runtime);
        }

        public async Task<ListRoleInfoByUserResponse> ListRoleInfoByUserAsync(string agentId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRoleInfoByUserHeaders headers = new ListRoleInfoByUserHeaders();
            return await ListRoleInfoByUserWithOptionsAsync(agentId, userId, headers, runtime);
        }

        public ListRoleInfoByUserResponse ListRoleInfoByUserWithOptions(string agentId, string userId, ListRoleInfoByUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
            return TeaModel.ToObject<ListRoleInfoByUserResponse>(DoROARequest("ListRoleInfoByUser", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apps/" + agentId + "/users/" + userId + "/roles", "json", req, runtime));
        }

        public async Task<ListRoleInfoByUserResponse> ListRoleInfoByUserWithOptionsAsync(string agentId, string userId, ListRoleInfoByUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
            return TeaModel.ToObject<ListRoleInfoByUserResponse>(await DoROARequestAsync("ListRoleInfoByUser", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apps/" + agentId + "/users/" + userId + "/roles", "json", req, runtime));
        }

        public ListUserVilebleAppResponse ListUserVilebleApp(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserVilebleAppHeaders headers = new ListUserVilebleAppHeaders();
            return ListUserVilebleAppWithOptions(userId, headers, runtime);
        }

        public async Task<ListUserVilebleAppResponse> ListUserVilebleAppAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserVilebleAppHeaders headers = new ListUserVilebleAppHeaders();
            return await ListUserVilebleAppWithOptionsAsync(userId, headers, runtime);
        }

        public ListUserVilebleAppResponse ListUserVilebleAppWithOptions(string userId, ListUserVilebleAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
            return TeaModel.ToObject<ListUserVilebleAppResponse>(DoROARequest("ListUserVilebleApp", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/users/" + userId + "/apps", "json", req, runtime));
        }

        public async Task<ListUserVilebleAppResponse> ListUserVilebleAppWithOptionsAsync(string userId, ListUserVilebleAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
            return TeaModel.ToObject<ListUserVilebleAppResponse>(await DoROARequestAsync("ListUserVilebleApp", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/users/" + userId + "/apps", "json", req, runtime));
        }

        public RebuildRoleScopeForAppRoleResponse RebuildRoleScopeForAppRole(string agentId, string roleId, RebuildRoleScopeForAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RebuildRoleScopeForAppRoleHeaders headers = new RebuildRoleScopeForAppRoleHeaders();
            return RebuildRoleScopeForAppRoleWithOptions(agentId, roleId, request, headers, runtime);
        }

        public async Task<RebuildRoleScopeForAppRoleResponse> RebuildRoleScopeForAppRoleAsync(string agentId, string roleId, RebuildRoleScopeForAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RebuildRoleScopeForAppRoleHeaders headers = new RebuildRoleScopeForAppRoleHeaders();
            return await RebuildRoleScopeForAppRoleWithOptionsAsync(agentId, roleId, request, headers, runtime);
        }

        public RebuildRoleScopeForAppRoleResponse RebuildRoleScopeForAppRoleWithOptions(string agentId, string roleId, RebuildRoleScopeForAppRoleRequest request, RebuildRoleScopeForAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
            roleId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RebuildRoleScopeForAppRoleResponse>(DoROARequest("RebuildRoleScopeForAppRole", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/scopes/rebuild", "json", req, runtime));
        }

        public async Task<RebuildRoleScopeForAppRoleResponse> RebuildRoleScopeForAppRoleWithOptionsAsync(string agentId, string roleId, RebuildRoleScopeForAppRoleRequest request, RebuildRoleScopeForAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
            roleId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RebuildRoleScopeForAppRoleResponse>(await DoROARequestAsync("RebuildRoleScopeForAppRole", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/scopes/rebuild", "json", req, runtime));
        }

        public RegisterCustomAppRoleResponse RegisterCustomAppRole(string agentId, RegisterCustomAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCustomAppRoleHeaders headers = new RegisterCustomAppRoleHeaders();
            return RegisterCustomAppRoleWithOptions(agentId, request, headers, runtime);
        }

        public async Task<RegisterCustomAppRoleResponse> RegisterCustomAppRoleAsync(string agentId, RegisterCustomAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCustomAppRoleHeaders headers = new RegisterCustomAppRoleHeaders();
            return await RegisterCustomAppRoleWithOptionsAsync(agentId, request, headers, runtime);
        }

        public RegisterCustomAppRoleResponse RegisterCustomAppRoleWithOptions(string agentId, RegisterCustomAppRoleRequest request, RegisterCustomAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RegisterCustomAppRoleResponse>(DoROARequest("RegisterCustomAppRole", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps/" + agentId + "/roles", "json", req, runtime));
        }

        public async Task<RegisterCustomAppRoleResponse> RegisterCustomAppRoleWithOptionsAsync(string agentId, RegisterCustomAppRoleRequest request, RegisterCustomAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RegisterCustomAppRoleResponse>(await DoROARequestAsync("RegisterCustomAppRole", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps/" + agentId + "/roles", "json", req, runtime));
        }

        public RemoveApaasAppResponse RemoveApaasApp(RemoveApaasAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveApaasAppHeaders headers = new RemoveApaasAppHeaders();
            return RemoveApaasAppWithOptions(request, headers, runtime);
        }

        public async Task<RemoveApaasAppResponse> RemoveApaasAppAsync(RemoveApaasAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveApaasAppHeaders headers = new RemoveApaasAppHeaders();
            return await RemoveApaasAppWithOptionsAsync(request, headers, runtime);
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RemoveApaasAppResponse>(DoROARequest("RemoveApaasApp", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apaasApps/remove", "json", req, runtime));
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RemoveApaasAppResponse>(await DoROARequestAsync("RemoveApaasApp", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apaasApps/remove", "json", req, runtime));
        }

        public RemoveMemberForAppRoleResponse RemoveMemberForAppRole(string agentId, string roleId, RemoveMemberForAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveMemberForAppRoleHeaders headers = new RemoveMemberForAppRoleHeaders();
            return RemoveMemberForAppRoleWithOptions(agentId, roleId, request, headers, runtime);
        }

        public async Task<RemoveMemberForAppRoleResponse> RemoveMemberForAppRoleAsync(string agentId, string roleId, RemoveMemberForAppRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveMemberForAppRoleHeaders headers = new RemoveMemberForAppRoleHeaders();
            return await RemoveMemberForAppRoleWithOptionsAsync(agentId, roleId, request, headers, runtime);
        }

        public RemoveMemberForAppRoleResponse RemoveMemberForAppRoleWithOptions(string agentId, string roleId, RemoveMemberForAppRoleRequest request, RemoveMemberForAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
            roleId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RemoveMemberForAppRoleResponse>(DoROARequest("RemoveMemberForAppRole", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/members/batchRemove", "json", req, runtime));
        }

        public async Task<RemoveMemberForAppRoleResponse> RemoveMemberForAppRoleWithOptionsAsync(string agentId, string roleId, RemoveMemberForAppRoleRequest request, RemoveMemberForAppRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
            roleId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RemoveMemberForAppRoleResponse>(await DoROARequestAsync("RemoveMemberForAppRole", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/members/batchRemove", "json", req, runtime));
        }

        public UpdateApaasAppResponse UpdateApaasApp(UpdateApaasAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateApaasAppHeaders headers = new UpdateApaasAppHeaders();
            return UpdateApaasAppWithOptions(request, headers, runtime);
        }

        public async Task<UpdateApaasAppResponse> UpdateApaasAppAsync(UpdateApaasAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateApaasAppHeaders headers = new UpdateApaasAppHeaders();
            return await UpdateApaasAppWithOptionsAsync(request, headers, runtime);
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateApaasAppResponse>(DoROARequest("UpdateApaasApp", "microApp_1.0", "HTTP", "PUT", "AK", "/v1.0/microApp/apaasApps", "json", req, runtime));
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateApaasAppResponse>(await DoROARequestAsync("UpdateApaasApp", "microApp_1.0", "HTTP", "PUT", "AK", "/v1.0/microApp/apaasApps", "json", req, runtime));
        }

        public UpdateAppRoleInfoResponse UpdateAppRoleInfo(string agentId, string roleId, UpdateAppRoleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateAppRoleInfoHeaders headers = new UpdateAppRoleInfoHeaders();
            return UpdateAppRoleInfoWithOptions(agentId, roleId, request, headers, runtime);
        }

        public async Task<UpdateAppRoleInfoResponse> UpdateAppRoleInfoAsync(string agentId, string roleId, UpdateAppRoleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateAppRoleInfoHeaders headers = new UpdateAppRoleInfoHeaders();
            return await UpdateAppRoleInfoWithOptionsAsync(agentId, roleId, request, headers, runtime);
        }

        public UpdateAppRoleInfoResponse UpdateAppRoleInfoWithOptions(string agentId, string roleId, UpdateAppRoleInfoRequest request, UpdateAppRoleInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
            roleId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateAppRoleInfoResponse>(DoROARequest("UpdateAppRoleInfo", "microApp_1.0", "HTTP", "PUT", "AK", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId, "json", req, runtime));
        }

        public async Task<UpdateAppRoleInfoResponse> UpdateAppRoleInfoWithOptionsAsync(string agentId, string roleId, UpdateAppRoleInfoRequest request, UpdateAppRoleInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
            roleId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateAppRoleInfoResponse>(await DoROARequestAsync("UpdateAppRoleInfo", "microApp_1.0", "HTTP", "PUT", "AK", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId, "json", req, runtime));
        }

        public UpdateInnerAppResponse UpdateInnerApp(string agentId, UpdateInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInnerAppHeaders headers = new UpdateInnerAppHeaders();
            return UpdateInnerAppWithOptions(agentId, request, headers, runtime);
        }

        public async Task<UpdateInnerAppResponse> UpdateInnerAppAsync(string agentId, UpdateInnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInnerAppHeaders headers = new UpdateInnerAppHeaders();
            return await UpdateInnerAppWithOptionsAsync(agentId, request, headers, runtime);
        }

        public UpdateInnerAppResponse UpdateInnerAppWithOptions(string agentId, UpdateInnerAppRequest request, UpdateInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateInnerAppResponse>(DoROARequest("UpdateInnerApp", "microApp_1.0", "HTTP", "PUT", "AK", "/v1.0/microApp/apps/" + agentId, "json", req, runtime));
        }

        public async Task<UpdateInnerAppResponse> UpdateInnerAppWithOptionsAsync(string agentId, UpdateInnerAppRequest request, UpdateInnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            agentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId);
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateInnerAppResponse>(await DoROARequestAsync("UpdateInnerApp", "microApp_1.0", "HTTP", "PUT", "AK", "/v1.0/microApp/apps/" + agentId, "json", req, runtime));
        }

    }
}
