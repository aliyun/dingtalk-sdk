// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkcontact_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0
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


        public AddAccountMappingResponse AddAccountMappingWithOptions(AddAccountMappingRequest request, AddAccountMappingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                body["outId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTenantId))
            {
                body["outTenantId"] = request.OutTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddAccountMapping",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/accountMappings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAccountMappingResponse>(Execute(params_, req, runtime));
        }

        public async Task<AddAccountMappingResponse> AddAccountMappingWithOptionsAsync(AddAccountMappingRequest request, AddAccountMappingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                body["outId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTenantId))
            {
                body["outTenantId"] = request.OutTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddAccountMapping",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/accountMappings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAccountMappingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AddAccountMappingResponse AddAccountMapping(AddAccountMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAccountMappingHeaders headers = new AddAccountMappingHeaders();
            return AddAccountMappingWithOptions(request, headers, runtime);
        }

        public async Task<AddAccountMappingResponse> AddAccountMappingAsync(AddAccountMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAccountMappingHeaders headers = new AddAccountMappingHeaders();
            return await AddAccountMappingWithOptionsAsync(request, headers, runtime);
        }

        public AddContactHideBySceneSettingResponse AddContactHideBySceneSettingWithOptions(AddContactHideBySceneSettingRequest request, AddContactHideBySceneSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDeptIds))
            {
                body["excludeDeptIds"] = request.ExcludeDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeTagIds))
            {
                body["excludeTagIds"] = request.ExcludeTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUserIds))
            {
                body["excludeUserIds"] = request.ExcludeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeListSceneConfig))
            {
                body["nodeListSceneConfig"] = request.NodeListSceneConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectDeptIds))
            {
                body["objectDeptIds"] = request.ObjectDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectTagIds))
            {
                body["objectTagIds"] = request.ObjectTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectUserIds))
            {
                body["objectUserIds"] = request.ObjectUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileSceneConfig))
            {
                body["profileSceneConfig"] = request.ProfileSceneConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchSceneConfig))
            {
                body["searchSceneConfig"] = request.SearchSceneConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddContactHideBySceneSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/organizations/hides/settings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddContactHideBySceneSettingResponse>(Execute(params_, req, runtime));
        }

        public async Task<AddContactHideBySceneSettingResponse> AddContactHideBySceneSettingWithOptionsAsync(AddContactHideBySceneSettingRequest request, AddContactHideBySceneSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDeptIds))
            {
                body["excludeDeptIds"] = request.ExcludeDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeTagIds))
            {
                body["excludeTagIds"] = request.ExcludeTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUserIds))
            {
                body["excludeUserIds"] = request.ExcludeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeListSceneConfig))
            {
                body["nodeListSceneConfig"] = request.NodeListSceneConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectDeptIds))
            {
                body["objectDeptIds"] = request.ObjectDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectTagIds))
            {
                body["objectTagIds"] = request.ObjectTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectUserIds))
            {
                body["objectUserIds"] = request.ObjectUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileSceneConfig))
            {
                body["profileSceneConfig"] = request.ProfileSceneConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchSceneConfig))
            {
                body["searchSceneConfig"] = request.SearchSceneConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddContactHideBySceneSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/organizations/hides/settings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddContactHideBySceneSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AddContactHideBySceneSettingResponse AddContactHideBySceneSetting(AddContactHideBySceneSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddContactHideBySceneSettingHeaders headers = new AddContactHideBySceneSettingHeaders();
            return AddContactHideBySceneSettingWithOptions(request, headers, runtime);
        }

        public async Task<AddContactHideBySceneSettingResponse> AddContactHideBySceneSettingAsync(AddContactHideBySceneSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddContactHideBySceneSettingHeaders headers = new AddContactHideBySceneSettingHeaders();
            return await AddContactHideBySceneSettingWithOptionsAsync(request, headers, runtime);
        }

        public AddEmpAttributeHideBySceneSettingResponse AddEmpAttributeHideBySceneSettingWithOptions(AddEmpAttributeHideBySceneSettingRequest request, AddEmpAttributeHideBySceneSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatSubtitleConfig))
            {
                body["chatSubtitleConfig"] = request.ChatSubtitleConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDeptIds))
            {
                body["excludeDeptIds"] = request.ExcludeDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeTagIds))
            {
                body["excludeTagIds"] = request.ExcludeTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUserIds))
            {
                body["excludeUserIds"] = request.ExcludeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideFields))
            {
                body["hideFields"] = request.HideFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectDeptIds))
            {
                body["objectDeptIds"] = request.ObjectDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectTagIds))
            {
                body["objectTagIds"] = request.ObjectTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectUserIds))
            {
                body["objectUserIds"] = request.ObjectUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileSceneConfig))
            {
                body["profileSceneConfig"] = request.ProfileSceneConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchSceneConfig))
            {
                body["searchSceneConfig"] = request.SearchSceneConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddEmpAttributeHideBySceneSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/empAttributes/hides/settings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddEmpAttributeHideBySceneSettingResponse>(Execute(params_, req, runtime));
        }

        public async Task<AddEmpAttributeHideBySceneSettingResponse> AddEmpAttributeHideBySceneSettingWithOptionsAsync(AddEmpAttributeHideBySceneSettingRequest request, AddEmpAttributeHideBySceneSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatSubtitleConfig))
            {
                body["chatSubtitleConfig"] = request.ChatSubtitleConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDeptIds))
            {
                body["excludeDeptIds"] = request.ExcludeDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeTagIds))
            {
                body["excludeTagIds"] = request.ExcludeTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUserIds))
            {
                body["excludeUserIds"] = request.ExcludeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideFields))
            {
                body["hideFields"] = request.HideFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectDeptIds))
            {
                body["objectDeptIds"] = request.ObjectDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectTagIds))
            {
                body["objectTagIds"] = request.ObjectTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectUserIds))
            {
                body["objectUserIds"] = request.ObjectUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileSceneConfig))
            {
                body["profileSceneConfig"] = request.ProfileSceneConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchSceneConfig))
            {
                body["searchSceneConfig"] = request.SearchSceneConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddEmpAttributeHideBySceneSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/empAttributes/hides/settings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddEmpAttributeHideBySceneSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AddEmpAttributeHideBySceneSettingResponse AddEmpAttributeHideBySceneSetting(AddEmpAttributeHideBySceneSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddEmpAttributeHideBySceneSettingHeaders headers = new AddEmpAttributeHideBySceneSettingHeaders();
            return AddEmpAttributeHideBySceneSettingWithOptions(request, headers, runtime);
        }

        public async Task<AddEmpAttributeHideBySceneSettingResponse> AddEmpAttributeHideBySceneSettingAsync(AddEmpAttributeHideBySceneSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddEmpAttributeHideBySceneSettingHeaders headers = new AddEmpAttributeHideBySceneSettingHeaders();
            return await AddEmpAttributeHideBySceneSettingWithOptionsAsync(request, headers, runtime);
        }

        public AddOrgAccountOwnnessResponse AddOrgAccountOwnnessWithOptions(AddOrgAccountOwnnessRequest request, AddOrgAccountOwnnessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnenssType))
            {
                body["ownenssType"] = request.OwnenssType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnnessId))
            {
                body["ownnessId"] = request.OwnnessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "AddOrgAccountOwnness",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/owness",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOrgAccountOwnnessResponse>(Execute(params_, req, runtime));
        }

        public async Task<AddOrgAccountOwnnessResponse> AddOrgAccountOwnnessWithOptionsAsync(AddOrgAccountOwnnessRequest request, AddOrgAccountOwnnessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnenssType))
            {
                body["ownenssType"] = request.OwnenssType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnnessId))
            {
                body["ownnessId"] = request.OwnnessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "AddOrgAccountOwnness",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/owness",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOrgAccountOwnnessResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AddOrgAccountOwnnessResponse AddOrgAccountOwnness(AddOrgAccountOwnnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrgAccountOwnnessHeaders headers = new AddOrgAccountOwnnessHeaders();
            return AddOrgAccountOwnnessWithOptions(request, headers, runtime);
        }

        public async Task<AddOrgAccountOwnnessResponse> AddOrgAccountOwnnessAsync(AddOrgAccountOwnnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrgAccountOwnnessHeaders headers = new AddOrgAccountOwnnessHeaders();
            return await AddOrgAccountOwnnessWithOptionsAsync(request, headers, runtime);
        }

        public AnnualCertificationAuditResponse AnnualCertificationAuditWithOptions(AnnualCertificationAuditRequest request, AnnualCertificationAuditHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantMobile))
            {
                body["applicantMobile"] = request.ApplicantMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantName))
            {
                body["applicantName"] = request.ApplicantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationLetter))
            {
                body["applicationLetter"] = request.ApplicationLetter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthStatus))
            {
                body["authStatus"] = request.AuthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateType))
            {
                body["certificateType"] = request.CertificateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpName))
            {
                body["corpName"] = request.CorpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepositaryBank))
            {
                body["depositaryBank"] = request.DepositaryBank;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPerson))
            {
                body["legalPerson"] = request.LegalPerson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseNumber))
            {
                body["licenseNumber"] = request.LicenseNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseUrl))
            {
                body["licenseUrl"] = request.LicenseUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicAccount))
            {
                body["publicAccount"] = request.PublicAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonCode))
            {
                body["reasonCode"] = request.ReasonCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonMsg))
            {
                body["reasonMsg"] = request.ReasonMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["tag"] = request.Tag;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AnnualCertificationAudit",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/organizations/authorities/audit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnnualCertificationAuditResponse>(Execute(params_, req, runtime));
        }

        public async Task<AnnualCertificationAuditResponse> AnnualCertificationAuditWithOptionsAsync(AnnualCertificationAuditRequest request, AnnualCertificationAuditHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantMobile))
            {
                body["applicantMobile"] = request.ApplicantMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantName))
            {
                body["applicantName"] = request.ApplicantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationLetter))
            {
                body["applicationLetter"] = request.ApplicationLetter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthStatus))
            {
                body["authStatus"] = request.AuthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateType))
            {
                body["certificateType"] = request.CertificateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpName))
            {
                body["corpName"] = request.CorpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepositaryBank))
            {
                body["depositaryBank"] = request.DepositaryBank;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPerson))
            {
                body["legalPerson"] = request.LegalPerson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseNumber))
            {
                body["licenseNumber"] = request.LicenseNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseUrl))
            {
                body["licenseUrl"] = request.LicenseUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicAccount))
            {
                body["publicAccount"] = request.PublicAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonCode))
            {
                body["reasonCode"] = request.ReasonCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonMsg))
            {
                body["reasonMsg"] = request.ReasonMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["tag"] = request.Tag;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AnnualCertificationAudit",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/organizations/authorities/audit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnnualCertificationAuditResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AnnualCertificationAuditResponse AnnualCertificationAudit(AnnualCertificationAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AnnualCertificationAuditHeaders headers = new AnnualCertificationAuditHeaders();
            return AnnualCertificationAuditWithOptions(request, headers, runtime);
        }

        public async Task<AnnualCertificationAuditResponse> AnnualCertificationAuditAsync(AnnualCertificationAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AnnualCertificationAuditHeaders headers = new AnnualCertificationAuditHeaders();
            return await AnnualCertificationAuditWithOptionsAsync(request, headers, runtime);
        }

        public BatchApproveUnionApplyResponse BatchApproveUnionApplyWithOptions(BatchApproveUnionApplyRequest request, BatchApproveUnionApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchApproveUnionApply",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cooperateCorps/unionApplications/approve",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchApproveUnionApplyResponse>(Execute(params_, req, runtime));
        }

        public async Task<BatchApproveUnionApplyResponse> BatchApproveUnionApplyWithOptionsAsync(BatchApproveUnionApplyRequest request, BatchApproveUnionApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchApproveUnionApply",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cooperateCorps/unionApplications/approve",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchApproveUnionApplyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public BatchApproveUnionApplyResponse BatchApproveUnionApply(BatchApproveUnionApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchApproveUnionApplyHeaders headers = new BatchApproveUnionApplyHeaders();
            return BatchApproveUnionApplyWithOptions(request, headers, runtime);
        }

        public async Task<BatchApproveUnionApplyResponse> BatchApproveUnionApplyAsync(BatchApproveUnionApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchApproveUnionApplyHeaders headers = new BatchApproveUnionApplyHeaders();
            return await BatchApproveUnionApplyWithOptionsAsync(request, headers, runtime);
        }

        public ChangeMainAdminResponse ChangeMainAdminWithOptions(ChangeMainAdminRequest request, ChangeMainAdminHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectCorpId))
            {
                body["effectCorpId"] = request.EffectCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUserId))
            {
                body["sourceUserId"] = request.SourceUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                body["targetUserId"] = request.TargetUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ChangeMainAdmin",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/mainAdministrators/change",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<ChangeMainAdminResponse>(Execute(params_, req, runtime));
        }

        public async Task<ChangeMainAdminResponse> ChangeMainAdminWithOptionsAsync(ChangeMainAdminRequest request, ChangeMainAdminHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectCorpId))
            {
                body["effectCorpId"] = request.EffectCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUserId))
            {
                body["sourceUserId"] = request.SourceUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                body["targetUserId"] = request.TargetUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ChangeMainAdmin",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/mainAdministrators/change",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<ChangeMainAdminResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ChangeMainAdminResponse ChangeMainAdmin(ChangeMainAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeMainAdminHeaders headers = new ChangeMainAdminHeaders();
            return ChangeMainAdminWithOptions(request, headers, runtime);
        }

        public async Task<ChangeMainAdminResponse> ChangeMainAdminAsync(ChangeMainAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeMainAdminHeaders headers = new ChangeMainAdminHeaders();
            return await ChangeMainAdminWithOptionsAsync(request, headers, runtime);
        }

        public CreateCooperateOrgResponse CreateCooperateOrgWithOptions(CreateCooperateOrgRequest request, CreateCooperateOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndustryCode))
            {
                body["industryCode"] = request.IndustryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogoMediaId))
            {
                body["logoMediaId"] = request.LogoMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["orgName"] = request.OrgName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateCooperateOrg",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cooperateCorps",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCooperateOrgResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateCooperateOrgResponse> CreateCooperateOrgWithOptionsAsync(CreateCooperateOrgRequest request, CreateCooperateOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndustryCode))
            {
                body["industryCode"] = request.IndustryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogoMediaId))
            {
                body["logoMediaId"] = request.LogoMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["orgName"] = request.OrgName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateCooperateOrg",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cooperateCorps",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCooperateOrgResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateCooperateOrgResponse CreateCooperateOrg(CreateCooperateOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCooperateOrgHeaders headers = new CreateCooperateOrgHeaders();
            return CreateCooperateOrgWithOptions(request, headers, runtime);
        }

        public async Task<CreateCooperateOrgResponse> CreateCooperateOrgAsync(CreateCooperateOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCooperateOrgHeaders headers = new CreateCooperateOrgHeaders();
            return await CreateCooperateOrgWithOptionsAsync(request, headers, runtime);
        }

        public CreateManagementGroupResponse CreateManagementGroupWithOptions(CreateManagementGroupRequest request, CreateManagementGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["resourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateManagementGroup",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/managementGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateManagementGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateManagementGroupResponse> CreateManagementGroupWithOptionsAsync(CreateManagementGroupRequest request, CreateManagementGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["resourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateManagementGroup",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/managementGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateManagementGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateManagementGroupResponse CreateManagementGroup(CreateManagementGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateManagementGroupHeaders headers = new CreateManagementGroupHeaders();
            return CreateManagementGroupWithOptions(request, headers, runtime);
        }

        public async Task<CreateManagementGroupResponse> CreateManagementGroupAsync(CreateManagementGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateManagementGroupHeaders headers = new CreateManagementGroupHeaders();
            return await CreateManagementGroupWithOptionsAsync(request, headers, runtime);
        }

        public CreateSecondaryManagementGroupResponse CreateSecondaryManagementGroupWithOptions(CreateSecondaryManagementGroupRequest request, CreateSecondaryManagementGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["resourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "CreateSecondaryManagementGroup",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/secondaryAdministrators/managementGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSecondaryManagementGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateSecondaryManagementGroupResponse> CreateSecondaryManagementGroupWithOptionsAsync(CreateSecondaryManagementGroupRequest request, CreateSecondaryManagementGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["resourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "CreateSecondaryManagementGroup",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/secondaryAdministrators/managementGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSecondaryManagementGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateSecondaryManagementGroupResponse CreateSecondaryManagementGroup(CreateSecondaryManagementGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSecondaryManagementGroupHeaders headers = new CreateSecondaryManagementGroupHeaders();
            return CreateSecondaryManagementGroupWithOptions(request, headers, runtime);
        }

        public async Task<CreateSecondaryManagementGroupResponse> CreateSecondaryManagementGroupAsync(CreateSecondaryManagementGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSecondaryManagementGroupHeaders headers = new CreateSecondaryManagementGroupHeaders();
            return await CreateSecondaryManagementGroupWithOptionsAsync(request, headers, runtime);
        }

        public DelAccountMappingResponse DelAccountMappingWithOptions(DelAccountMappingRequest request, DelAccountMappingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "DelAccountMapping",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/accountMappings",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelAccountMappingResponse>(Execute(params_, req, runtime));
        }

        public async Task<DelAccountMappingResponse> DelAccountMappingWithOptionsAsync(DelAccountMappingRequest request, DelAccountMappingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "DelAccountMapping",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/accountMappings",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelAccountMappingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DelAccountMappingResponse DelAccountMapping(DelAccountMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DelAccountMappingHeaders headers = new DelAccountMappingHeaders();
            return DelAccountMappingWithOptions(request, headers, runtime);
        }

        public async Task<DelAccountMappingResponse> DelAccountMappingAsync(DelAccountMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DelAccountMappingHeaders headers = new DelAccountMappingHeaders();
            return await DelAccountMappingWithOptionsAsync(request, headers, runtime);
        }

        public DelOrgAccUserOwnnessResponse DelOrgAccUserOwnnessWithOptions(DelOrgAccUserOwnnessRequest request, DelOrgAccUserOwnnessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnenssType))
            {
                query["ownenssType"] = request.OwnenssType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnnessId))
            {
                query["ownnessId"] = request.OwnnessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "DelOrgAccUserOwnness",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/ownness",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelOrgAccUserOwnnessResponse>(Execute(params_, req, runtime));
        }

        public async Task<DelOrgAccUserOwnnessResponse> DelOrgAccUserOwnnessWithOptionsAsync(DelOrgAccUserOwnnessRequest request, DelOrgAccUserOwnnessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnenssType))
            {
                query["ownenssType"] = request.OwnenssType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnnessId))
            {
                query["ownnessId"] = request.OwnnessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "DelOrgAccUserOwnness",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/ownness",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelOrgAccUserOwnnessResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DelOrgAccUserOwnnessResponse DelOrgAccUserOwnness(DelOrgAccUserOwnnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DelOrgAccUserOwnnessHeaders headers = new DelOrgAccUserOwnnessHeaders();
            return DelOrgAccUserOwnnessWithOptions(request, headers, runtime);
        }

        public async Task<DelOrgAccUserOwnnessResponse> DelOrgAccUserOwnnessAsync(DelOrgAccUserOwnnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DelOrgAccUserOwnnessHeaders headers = new DelOrgAccUserOwnnessHeaders();
            return await DelOrgAccUserOwnnessWithOptionsAsync(request, headers, runtime);
        }

        public DeleteContactHideBySceneSettingResponse DeleteContactHideBySceneSettingWithOptions(string settingId, DeleteContactHideBySceneSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteContactHideBySceneSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/organizations/hides/settings/" + settingId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactHideBySceneSettingResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteContactHideBySceneSettingResponse> DeleteContactHideBySceneSettingWithOptionsAsync(string settingId, DeleteContactHideBySceneSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteContactHideBySceneSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/organizations/hides/settings/" + settingId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactHideBySceneSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteContactHideBySceneSettingResponse DeleteContactHideBySceneSetting(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteContactHideBySceneSettingHeaders headers = new DeleteContactHideBySceneSettingHeaders();
            return DeleteContactHideBySceneSettingWithOptions(settingId, headers, runtime);
        }

        public async Task<DeleteContactHideBySceneSettingResponse> DeleteContactHideBySceneSettingAsync(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteContactHideBySceneSettingHeaders headers = new DeleteContactHideBySceneSettingHeaders();
            return await DeleteContactHideBySceneSettingWithOptionsAsync(settingId, headers, runtime);
        }

        public DeleteContactHideSettingResponse DeleteContactHideSettingWithOptions(string settingId, DeleteContactHideSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteContactHideSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/contactHideSettings/" + settingId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactHideSettingResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteContactHideSettingResponse> DeleteContactHideSettingWithOptionsAsync(string settingId, DeleteContactHideSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteContactHideSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/contactHideSettings/" + settingId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactHideSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteContactHideSettingResponse DeleteContactHideSetting(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteContactHideSettingHeaders headers = new DeleteContactHideSettingHeaders();
            return DeleteContactHideSettingWithOptions(settingId, headers, runtime);
        }

        public async Task<DeleteContactHideSettingResponse> DeleteContactHideSettingAsync(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteContactHideSettingHeaders headers = new DeleteContactHideSettingHeaders();
            return await DeleteContactHideSettingWithOptionsAsync(settingId, headers, runtime);
        }

        public DeleteContactRestrictSettingResponse DeleteContactRestrictSettingWithOptions(string settingId, DeleteContactRestrictSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteContactRestrictSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/restrictions/settings/" + settingId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactRestrictSettingResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteContactRestrictSettingResponse> DeleteContactRestrictSettingWithOptionsAsync(string settingId, DeleteContactRestrictSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteContactRestrictSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/restrictions/settings/" + settingId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactRestrictSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteContactRestrictSettingResponse DeleteContactRestrictSetting(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteContactRestrictSettingHeaders headers = new DeleteContactRestrictSettingHeaders();
            return DeleteContactRestrictSettingWithOptions(settingId, headers, runtime);
        }

        public async Task<DeleteContactRestrictSettingResponse> DeleteContactRestrictSettingAsync(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteContactRestrictSettingHeaders headers = new DeleteContactRestrictSettingHeaders();
            return await DeleteContactRestrictSettingWithOptionsAsync(settingId, headers, runtime);
        }

        public DeleteEmpAttributeHideBySceneSettingResponse DeleteEmpAttributeHideBySceneSettingWithOptions(string settingId, DeleteEmpAttributeHideBySceneSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteEmpAttributeHideBySceneSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/empAttributes/hides/settings/" + settingId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEmpAttributeHideBySceneSettingResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteEmpAttributeHideBySceneSettingResponse> DeleteEmpAttributeHideBySceneSettingWithOptionsAsync(string settingId, DeleteEmpAttributeHideBySceneSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteEmpAttributeHideBySceneSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/empAttributes/hides/settings/" + settingId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEmpAttributeHideBySceneSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteEmpAttributeHideBySceneSettingResponse DeleteEmpAttributeHideBySceneSetting(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteEmpAttributeHideBySceneSettingHeaders headers = new DeleteEmpAttributeHideBySceneSettingHeaders();
            return DeleteEmpAttributeHideBySceneSettingWithOptions(settingId, headers, runtime);
        }

        public async Task<DeleteEmpAttributeHideBySceneSettingResponse> DeleteEmpAttributeHideBySceneSettingAsync(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteEmpAttributeHideBySceneSettingHeaders headers = new DeleteEmpAttributeHideBySceneSettingHeaders();
            return await DeleteEmpAttributeHideBySceneSettingWithOptionsAsync(settingId, headers, runtime);
        }

        public DeleteEmpAttributeVisibilityResponse DeleteEmpAttributeVisibilityWithOptions(string settingId, DeleteEmpAttributeVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteEmpAttributeVisibility",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/staffAttributes/visibilitySettings/" + settingId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEmpAttributeVisibilityResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteEmpAttributeVisibilityResponse> DeleteEmpAttributeVisibilityWithOptionsAsync(string settingId, DeleteEmpAttributeVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteEmpAttributeVisibility",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/staffAttributes/visibilitySettings/" + settingId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEmpAttributeVisibilityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteEmpAttributeVisibilityResponse DeleteEmpAttributeVisibility(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteEmpAttributeVisibilityHeaders headers = new DeleteEmpAttributeVisibilityHeaders();
            return DeleteEmpAttributeVisibilityWithOptions(settingId, headers, runtime);
        }

        public async Task<DeleteEmpAttributeVisibilityResponse> DeleteEmpAttributeVisibilityAsync(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteEmpAttributeVisibilityHeaders headers = new DeleteEmpAttributeVisibilityHeaders();
            return await DeleteEmpAttributeVisibilityWithOptionsAsync(settingId, headers, runtime);
        }

        public DeleteManagementGroupResponse DeleteManagementGroupWithOptions(string groupId, DeleteManagementGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteManagementGroup",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/managementGroups/" + groupId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteManagementGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteManagementGroupResponse> DeleteManagementGroupWithOptionsAsync(string groupId, DeleteManagementGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteManagementGroup",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/managementGroups/" + groupId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteManagementGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteManagementGroupResponse DeleteManagementGroup(string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteManagementGroupHeaders headers = new DeleteManagementGroupHeaders();
            return DeleteManagementGroupWithOptions(groupId, headers, runtime);
        }

        public async Task<DeleteManagementGroupResponse> DeleteManagementGroupAsync(string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteManagementGroupHeaders headers = new DeleteManagementGroupHeaders();
            return await DeleteManagementGroupWithOptionsAsync(groupId, headers, runtime);
        }

        public GetAccountMappingResponse GetAccountMappingWithOptions(GetAccountMappingRequest request, GetAccountMappingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetAccountMapping",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/accountMappings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountMappingResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetAccountMappingResponse> GetAccountMappingWithOptionsAsync(GetAccountMappingRequest request, GetAccountMappingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetAccountMapping",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/accountMappings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountMappingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetAccountMappingResponse GetAccountMapping(GetAccountMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAccountMappingHeaders headers = new GetAccountMappingHeaders();
            return GetAccountMappingWithOptions(request, headers, runtime);
        }

        public async Task<GetAccountMappingResponse> GetAccountMappingAsync(GetAccountMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAccountMappingHeaders headers = new GetAccountMappingHeaders();
            return await GetAccountMappingWithOptionsAsync(request, headers, runtime);
        }

        public GetApplyInviteInfoResponse GetApplyInviteInfoWithOptions(GetApplyInviteInfoRequest request, GetApplyInviteInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviterUserId))
            {
                query["inviterUserId"] = request.InviterUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetApplyInviteInfo",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/invites/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplyInviteInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetApplyInviteInfoResponse> GetApplyInviteInfoWithOptionsAsync(GetApplyInviteInfoRequest request, GetApplyInviteInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviterUserId))
            {
                query["inviterUserId"] = request.InviterUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetApplyInviteInfo",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/invites/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplyInviteInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetApplyInviteInfoResponse GetApplyInviteInfo(GetApplyInviteInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetApplyInviteInfoHeaders headers = new GetApplyInviteInfoHeaders();
            return GetApplyInviteInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetApplyInviteInfoResponse> GetApplyInviteInfoAsync(GetApplyInviteInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetApplyInviteInfoHeaders headers = new GetApplyInviteInfoHeaders();
            return await GetApplyInviteInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetBranchAuthDataResponse GetBranchAuthDataWithOptions(GetBranchAuthDataRequest request, GetBranchAuthDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchCorpId))
            {
                query["branchCorpId"] = request.BranchCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetBranchAuthData",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/branchAuthDatas/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBranchAuthDataResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBranchAuthDataResponse> GetBranchAuthDataWithOptionsAsync(GetBranchAuthDataRequest request, GetBranchAuthDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchCorpId))
            {
                query["branchCorpId"] = request.BranchCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetBranchAuthData",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/branchAuthDatas/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBranchAuthDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBranchAuthDataResponse GetBranchAuthData(GetBranchAuthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBranchAuthDataHeaders headers = new GetBranchAuthDataHeaders();
            return GetBranchAuthDataWithOptions(request, headers, runtime);
        }

        public async Task<GetBranchAuthDataResponse> GetBranchAuthDataAsync(GetBranchAuthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBranchAuthDataHeaders headers = new GetBranchAuthDataHeaders();
            return await GetBranchAuthDataWithOptionsAsync(request, headers, runtime);
        }

        public GetCardInUserHolderResponse GetCardInUserHolderWithOptions(string cardId, GetCardInUserHolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCardInUserHolder",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cards/holders/infos/" + cardId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCardInUserHolderResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetCardInUserHolderResponse> GetCardInUserHolderWithOptionsAsync(string cardId, GetCardInUserHolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCardInUserHolder",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cards/holders/infos/" + cardId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCardInUserHolderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetCardInUserHolderResponse GetCardInUserHolder(string cardId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCardInUserHolderHeaders headers = new GetCardInUserHolderHeaders();
            return GetCardInUserHolderWithOptions(cardId, headers, runtime);
        }

        public async Task<GetCardInUserHolderResponse> GetCardInUserHolderAsync(string cardId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCardInUserHolderHeaders headers = new GetCardInUserHolderHeaders();
            return await GetCardInUserHolderWithOptionsAsync(cardId, headers, runtime);
        }

        public GetCardInfoResponse GetCardInfoWithOptions(string cardId, GetCardInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCardInfo",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cards/infos/" + cardId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCardInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetCardInfoResponse> GetCardInfoWithOptionsAsync(string cardId, GetCardInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCardInfo",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cards/infos/" + cardId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCardInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetCardInfoResponse GetCardInfo(string cardId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCardInfoHeaders headers = new GetCardInfoHeaders();
            return GetCardInfoWithOptions(cardId, headers, runtime);
        }

        public async Task<GetCardInfoResponse> GetCardInfoAsync(string cardId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCardInfoHeaders headers = new GetCardInfoHeaders();
            return await GetCardInfoWithOptionsAsync(cardId, headers, runtime);
        }

        public GetContactHideBySceneSettingResponse GetContactHideBySceneSettingWithOptions(string settingId, GetContactHideBySceneSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetContactHideBySceneSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/organizations/hides/settings/" + settingId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContactHideBySceneSettingResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetContactHideBySceneSettingResponse> GetContactHideBySceneSettingWithOptionsAsync(string settingId, GetContactHideBySceneSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetContactHideBySceneSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/organizations/hides/settings/" + settingId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContactHideBySceneSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetContactHideBySceneSettingResponse GetContactHideBySceneSetting(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetContactHideBySceneSettingHeaders headers = new GetContactHideBySceneSettingHeaders();
            return GetContactHideBySceneSettingWithOptions(settingId, headers, runtime);
        }

        public async Task<GetContactHideBySceneSettingResponse> GetContactHideBySceneSettingAsync(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetContactHideBySceneSettingHeaders headers = new GetContactHideBySceneSettingHeaders();
            return await GetContactHideBySceneSettingWithOptionsAsync(settingId, headers, runtime);
        }

        public GetCooperateOrgInviteInfoResponse GetCooperateOrgInviteInfoWithOptions(string cooperateCorpId, GetCooperateOrgInviteInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCooperateOrgInviteInfo",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cooperateCorps/" + cooperateCorpId + "/inviteInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCooperateOrgInviteInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetCooperateOrgInviteInfoResponse> GetCooperateOrgInviteInfoWithOptionsAsync(string cooperateCorpId, GetCooperateOrgInviteInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCooperateOrgInviteInfo",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cooperateCorps/" + cooperateCorpId + "/inviteInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCooperateOrgInviteInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetCooperateOrgInviteInfoResponse GetCooperateOrgInviteInfo(string cooperateCorpId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCooperateOrgInviteInfoHeaders headers = new GetCooperateOrgInviteInfoHeaders();
            return GetCooperateOrgInviteInfoWithOptions(cooperateCorpId, headers, runtime);
        }

        public async Task<GetCooperateOrgInviteInfoResponse> GetCooperateOrgInviteInfoAsync(string cooperateCorpId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCooperateOrgInviteInfoHeaders headers = new GetCooperateOrgInviteInfoHeaders();
            return await GetCooperateOrgInviteInfoWithOptionsAsync(cooperateCorpId, headers, runtime);
        }

        public GetCorpCardStyleListResponse GetCorpCardStyleListWithOptions(GetCorpCardStyleListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCorpCardStyleList",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cards/styles/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCorpCardStyleListResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetCorpCardStyleListResponse> GetCorpCardStyleListWithOptionsAsync(GetCorpCardStyleListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCorpCardStyleList",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cards/styles/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCorpCardStyleListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetCorpCardStyleListResponse GetCorpCardStyleList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpCardStyleListHeaders headers = new GetCorpCardStyleListHeaders();
            return GetCorpCardStyleListWithOptions(headers, runtime);
        }

        public async Task<GetCorpCardStyleListResponse> GetCorpCardStyleListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpCardStyleListHeaders headers = new GetCorpCardStyleListHeaders();
            return await GetCorpCardStyleListWithOptionsAsync(headers, runtime);
        }

        public GetDingIdByMigrationDingIdResponse GetDingIdByMigrationDingIdWithOptions(GetDingIdByMigrationDingIdRequest request, GetDingIdByMigrationDingIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationDingId))
            {
                query["migrationDingId"] = request.MigrationDingId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetDingIdByMigrationDingId",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccount/getDingIdByMigrationDingIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDingIdByMigrationDingIdResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetDingIdByMigrationDingIdResponse> GetDingIdByMigrationDingIdWithOptionsAsync(GetDingIdByMigrationDingIdRequest request, GetDingIdByMigrationDingIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationDingId))
            {
                query["migrationDingId"] = request.MigrationDingId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetDingIdByMigrationDingId",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccount/getDingIdByMigrationDingIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDingIdByMigrationDingIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetDingIdByMigrationDingIdResponse GetDingIdByMigrationDingId(GetDingIdByMigrationDingIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingIdByMigrationDingIdHeaders headers = new GetDingIdByMigrationDingIdHeaders();
            return GetDingIdByMigrationDingIdWithOptions(request, headers, runtime);
        }

        public async Task<GetDingIdByMigrationDingIdResponse> GetDingIdByMigrationDingIdAsync(GetDingIdByMigrationDingIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingIdByMigrationDingIdHeaders headers = new GetDingIdByMigrationDingIdHeaders();
            return await GetDingIdByMigrationDingIdWithOptionsAsync(request, headers, runtime);
        }

        public GetEmpAttributeHideBySceneSettingResponse GetEmpAttributeHideBySceneSettingWithOptions(string settingId, GetEmpAttributeHideBySceneSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetEmpAttributeHideBySceneSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/empAttributes/hides/settings/" + settingId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmpAttributeHideBySceneSettingResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetEmpAttributeHideBySceneSettingResponse> GetEmpAttributeHideBySceneSettingWithOptionsAsync(string settingId, GetEmpAttributeHideBySceneSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetEmpAttributeHideBySceneSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/empAttributes/hides/settings/" + settingId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmpAttributeHideBySceneSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetEmpAttributeHideBySceneSettingResponse GetEmpAttributeHideBySceneSetting(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEmpAttributeHideBySceneSettingHeaders headers = new GetEmpAttributeHideBySceneSettingHeaders();
            return GetEmpAttributeHideBySceneSettingWithOptions(settingId, headers, runtime);
        }

        public async Task<GetEmpAttributeHideBySceneSettingResponse> GetEmpAttributeHideBySceneSettingAsync(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEmpAttributeHideBySceneSettingHeaders headers = new GetEmpAttributeHideBySceneSettingHeaders();
            return await GetEmpAttributeHideBySceneSettingWithOptionsAsync(settingId, headers, runtime);
        }

        public GetLatestDingIndexResponse GetLatestDingIndexWithOptions(GetLatestDingIndexHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetLatestDingIndex",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/dingIndexs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLatestDingIndexResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetLatestDingIndexResponse> GetLatestDingIndexWithOptionsAsync(GetLatestDingIndexHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetLatestDingIndex",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/dingIndexs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLatestDingIndexResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetLatestDingIndexResponse GetLatestDingIndex()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLatestDingIndexHeaders headers = new GetLatestDingIndexHeaders();
            return GetLatestDingIndexWithOptions(headers, runtime);
        }

        public async Task<GetLatestDingIndexResponse> GetLatestDingIndexAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLatestDingIndexHeaders headers = new GetLatestDingIndexHeaders();
            return await GetLatestDingIndexWithOptionsAsync(headers, runtime);
        }

        public GetMigrationDingIdByDingIdResponse GetMigrationDingIdByDingIdWithOptions(GetMigrationDingIdByDingIdRequest request, GetMigrationDingIdByDingIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingId))
            {
                query["dingId"] = request.DingId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetMigrationDingIdByDingId",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccount/getMigrationDingIdByDingIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMigrationDingIdByDingIdResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetMigrationDingIdByDingIdResponse> GetMigrationDingIdByDingIdWithOptionsAsync(GetMigrationDingIdByDingIdRequest request, GetMigrationDingIdByDingIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingId))
            {
                query["dingId"] = request.DingId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetMigrationDingIdByDingId",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccount/getMigrationDingIdByDingIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMigrationDingIdByDingIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetMigrationDingIdByDingIdResponse GetMigrationDingIdByDingId(GetMigrationDingIdByDingIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMigrationDingIdByDingIdHeaders headers = new GetMigrationDingIdByDingIdHeaders();
            return GetMigrationDingIdByDingIdWithOptions(request, headers, runtime);
        }

        public async Task<GetMigrationDingIdByDingIdResponse> GetMigrationDingIdByDingIdAsync(GetMigrationDingIdByDingIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMigrationDingIdByDingIdHeaders headers = new GetMigrationDingIdByDingIdHeaders();
            return await GetMigrationDingIdByDingIdWithOptionsAsync(request, headers, runtime);
        }

        public GetMigrationUnionIdByUnionIdResponse GetMigrationUnionIdByUnionIdWithOptions(GetMigrationUnionIdByUnionIdRequest request, GetMigrationUnionIdByUnionIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetMigrationUnionIdByUnionId",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccount/getMigrationUnionIdByUnionIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMigrationUnionIdByUnionIdResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetMigrationUnionIdByUnionIdResponse> GetMigrationUnionIdByUnionIdWithOptionsAsync(GetMigrationUnionIdByUnionIdRequest request, GetMigrationUnionIdByUnionIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetMigrationUnionIdByUnionId",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccount/getMigrationUnionIdByUnionIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMigrationUnionIdByUnionIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetMigrationUnionIdByUnionIdResponse GetMigrationUnionIdByUnionId(GetMigrationUnionIdByUnionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMigrationUnionIdByUnionIdHeaders headers = new GetMigrationUnionIdByUnionIdHeaders();
            return GetMigrationUnionIdByUnionIdWithOptions(request, headers, runtime);
        }

        public async Task<GetMigrationUnionIdByUnionIdResponse> GetMigrationUnionIdByUnionIdAsync(GetMigrationUnionIdByUnionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMigrationUnionIdByUnionIdHeaders headers = new GetMigrationUnionIdByUnionIdHeaders();
            return await GetMigrationUnionIdByUnionIdWithOptionsAsync(request, headers, runtime);
        }

        public GetOrgAuthInfoResponse GetOrgAuthInfoWithOptions(GetOrgAuthInfoRequest request, GetOrgAuthInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                query["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetOrgAuthInfo",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/organizations/authInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrgAuthInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetOrgAuthInfoResponse> GetOrgAuthInfoWithOptionsAsync(GetOrgAuthInfoRequest request, GetOrgAuthInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                query["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetOrgAuthInfo",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/organizations/authInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrgAuthInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetOrgAuthInfoResponse GetOrgAuthInfo(GetOrgAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrgAuthInfoHeaders headers = new GetOrgAuthInfoHeaders();
            return GetOrgAuthInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetOrgAuthInfoResponse> GetOrgAuthInfoAsync(GetOrgAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrgAuthInfoHeaders headers = new GetOrgAuthInfoHeaders();
            return await GetOrgAuthInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetTranslateFileJobResultResponse GetTranslateFileJobResultWithOptions(GetTranslateFileJobResultRequest request, GetTranslateFileJobResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["jobId"] = request.JobId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetTranslateFileJobResult",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/files/translateResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTranslateFileJobResultResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetTranslateFileJobResultResponse> GetTranslateFileJobResultWithOptionsAsync(GetTranslateFileJobResultRequest request, GetTranslateFileJobResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["jobId"] = request.JobId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetTranslateFileJobResult",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/files/translateResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTranslateFileJobResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetTranslateFileJobResultResponse GetTranslateFileJobResult(GetTranslateFileJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTranslateFileJobResultHeaders headers = new GetTranslateFileJobResultHeaders();
            return GetTranslateFileJobResultWithOptions(request, headers, runtime);
        }

        public async Task<GetTranslateFileJobResultResponse> GetTranslateFileJobResultAsync(GetTranslateFileJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTranslateFileJobResultHeaders headers = new GetTranslateFileJobResultHeaders();
            return await GetTranslateFileJobResultWithOptionsAsync(request, headers, runtime);
        }

        public GetUnionIdByMigrationUnionIdResponse GetUnionIdByMigrationUnionIdWithOptions(GetUnionIdByMigrationUnionIdRequest request, GetUnionIdByMigrationUnionIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationUnionId))
            {
                query["migrationUnionId"] = request.MigrationUnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetUnionIdByMigrationUnionId",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccount/getUnionIdByMigrationUnionIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUnionIdByMigrationUnionIdResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetUnionIdByMigrationUnionIdResponse> GetUnionIdByMigrationUnionIdWithOptionsAsync(GetUnionIdByMigrationUnionIdRequest request, GetUnionIdByMigrationUnionIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationUnionId))
            {
                query["migrationUnionId"] = request.MigrationUnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetUnionIdByMigrationUnionId",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccount/getUnionIdByMigrationUnionIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUnionIdByMigrationUnionIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetUnionIdByMigrationUnionIdResponse GetUnionIdByMigrationUnionId(GetUnionIdByMigrationUnionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUnionIdByMigrationUnionIdHeaders headers = new GetUnionIdByMigrationUnionIdHeaders();
            return GetUnionIdByMigrationUnionIdWithOptions(request, headers, runtime);
        }

        public async Task<GetUnionIdByMigrationUnionIdResponse> GetUnionIdByMigrationUnionIdAsync(GetUnionIdByMigrationUnionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUnionIdByMigrationUnionIdHeaders headers = new GetUnionIdByMigrationUnionIdHeaders();
            return await GetUnionIdByMigrationUnionIdWithOptionsAsync(request, headers, runtime);
        }

        public GetUserResponse GetUserWithOptions(string unionId, GetUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetUser",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/users/" + unionId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetUserResponse> GetUserWithOptionsAsync(string unionId, GetUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetUser",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/users/" + unionId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetUserResponse GetUser(string unionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHeaders headers = new GetUserHeaders();
            return GetUserWithOptions(unionId, headers, runtime);
        }

        public async Task<GetUserResponse> GetUserAsync(string unionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHeaders headers = new GetUserHeaders();
            return await GetUserWithOptionsAsync(unionId, headers, runtime);
        }

        public GetUserCardHolderListResponse GetUserCardHolderListWithOptions(GetUserCardHolderListRequest request, GetUserCardHolderListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetUserCardHolderList",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cards/holders/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserCardHolderListResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetUserCardHolderListResponse> GetUserCardHolderListWithOptionsAsync(GetUserCardHolderListRequest request, GetUserCardHolderListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetUserCardHolderList",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cards/holders/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserCardHolderListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetUserCardHolderListResponse GetUserCardHolderList(GetUserCardHolderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserCardHolderListHeaders headers = new GetUserCardHolderListHeaders();
            return GetUserCardHolderListWithOptions(request, headers, runtime);
        }

        public async Task<GetUserCardHolderListResponse> GetUserCardHolderListAsync(GetUserCardHolderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserCardHolderListHeaders headers = new GetUserCardHolderListHeaders();
            return await GetUserCardHolderListWithOptionsAsync(request, headers, runtime);
        }

        public IsFriendResponse IsFriendWithOptions(IsFriendRequest request, IsFriendHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNo))
            {
                body["mobileNo"] = request.MobileNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "IsFriend",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/relationships/friends/judge",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsFriendResponse>(Execute(params_, req, runtime));
        }

        public async Task<IsFriendResponse> IsFriendWithOptionsAsync(IsFriendRequest request, IsFriendHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNo))
            {
                body["mobileNo"] = request.MobileNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "IsFriend",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/relationships/friends/judge",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsFriendResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public IsFriendResponse IsFriend(IsFriendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IsFriendHeaders headers = new IsFriendHeaders();
            return IsFriendWithOptions(request, headers, runtime);
        }

        public async Task<IsFriendResponse> IsFriendAsync(IsFriendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IsFriendHeaders headers = new IsFriendHeaders();
            return await IsFriendWithOptionsAsync(request, headers, runtime);
        }

        public IsvCardEventPushResponse IsvCardEventPushWithOptions(IsvCardEventPushRequest request, IsvCardEventPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCardId))
            {
                query["isvCardId"] = request.IsvCardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvToken))
            {
                query["isvToken"] = request.IsvToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvUid))
            {
                query["isvUid"] = request.IsvUid;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventParams))
            {
                body["eventParams"] = request.EventParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                body["eventType"] = request.EventType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "IsvCardEventPush",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cards/events/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsvCardEventPushResponse>(Execute(params_, req, runtime));
        }

        public async Task<IsvCardEventPushResponse> IsvCardEventPushWithOptionsAsync(IsvCardEventPushRequest request, IsvCardEventPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCardId))
            {
                query["isvCardId"] = request.IsvCardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvToken))
            {
                query["isvToken"] = request.IsvToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvUid))
            {
                query["isvUid"] = request.IsvUid;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventParams))
            {
                body["eventParams"] = request.EventParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                body["eventType"] = request.EventType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "IsvCardEventPush",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cards/events/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsvCardEventPushResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public IsvCardEventPushResponse IsvCardEventPush(IsvCardEventPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IsvCardEventPushHeaders headers = new IsvCardEventPushHeaders();
            return IsvCardEventPushWithOptions(request, headers, runtime);
        }

        public async Task<IsvCardEventPushResponse> IsvCardEventPushAsync(IsvCardEventPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IsvCardEventPushHeaders headers = new IsvCardEventPushHeaders();
            return await IsvCardEventPushWithOptionsAsync(request, headers, runtime);
        }

        public ListBasicRoleInPageResponse ListBasicRoleInPageWithOptions(ListBasicRoleInPageRequest request, ListBasicRoleInPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListBasicRoleInPage",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/rbac/administrativeGroups/baseInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBasicRoleInPageResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListBasicRoleInPageResponse> ListBasicRoleInPageWithOptionsAsync(ListBasicRoleInPageRequest request, ListBasicRoleInPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListBasicRoleInPage",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/rbac/administrativeGroups/baseInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBasicRoleInPageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListBasicRoleInPageResponse ListBasicRoleInPage(ListBasicRoleInPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListBasicRoleInPageHeaders headers = new ListBasicRoleInPageHeaders();
            return ListBasicRoleInPageWithOptions(request, headers, runtime);
        }

        public async Task<ListBasicRoleInPageResponse> ListBasicRoleInPageAsync(ListBasicRoleInPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListBasicRoleInPageHeaders headers = new ListBasicRoleInPageHeaders();
            return await ListBasicRoleInPageWithOptionsAsync(request, headers, runtime);
        }

        public ListContactHideSettingsResponse ListContactHideSettingsWithOptions(ListContactHideSettingsRequest request, ListContactHideSettingsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListContactHideSettings",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/contactHideSettings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContactHideSettingsResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListContactHideSettingsResponse> ListContactHideSettingsWithOptionsAsync(ListContactHideSettingsRequest request, ListContactHideSettingsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListContactHideSettings",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/contactHideSettings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContactHideSettingsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListContactHideSettingsResponse ListContactHideSettings(ListContactHideSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListContactHideSettingsHeaders headers = new ListContactHideSettingsHeaders();
            return ListContactHideSettingsWithOptions(request, headers, runtime);
        }

        public async Task<ListContactHideSettingsResponse> ListContactHideSettingsAsync(ListContactHideSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListContactHideSettingsHeaders headers = new ListContactHideSettingsHeaders();
            return await ListContactHideSettingsWithOptionsAsync(request, headers, runtime);
        }

        public ListContactRestrictSettingResponse ListContactRestrictSettingWithOptions(ListContactRestrictSettingRequest request, ListContactRestrictSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListContactRestrictSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/restrictions/settings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContactRestrictSettingResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListContactRestrictSettingResponse> ListContactRestrictSettingWithOptionsAsync(ListContactRestrictSettingRequest request, ListContactRestrictSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListContactRestrictSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/restrictions/settings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContactRestrictSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListContactRestrictSettingResponse ListContactRestrictSetting(ListContactRestrictSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListContactRestrictSettingHeaders headers = new ListContactRestrictSettingHeaders();
            return ListContactRestrictSettingWithOptions(request, headers, runtime);
        }

        public async Task<ListContactRestrictSettingResponse> ListContactRestrictSettingAsync(ListContactRestrictSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListContactRestrictSettingHeaders headers = new ListContactRestrictSettingHeaders();
            return await ListContactRestrictSettingWithOptionsAsync(request, headers, runtime);
        }

        public ListEmpAttributeVisibilityResponse ListEmpAttributeVisibilityWithOptions(ListEmpAttributeVisibilityRequest request, ListEmpAttributeVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListEmpAttributeVisibility",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/staffAttributes/visibilitySettings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEmpAttributeVisibilityResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListEmpAttributeVisibilityResponse> ListEmpAttributeVisibilityWithOptionsAsync(ListEmpAttributeVisibilityRequest request, ListEmpAttributeVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListEmpAttributeVisibility",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/staffAttributes/visibilitySettings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEmpAttributeVisibilityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListEmpAttributeVisibilityResponse ListEmpAttributeVisibility(ListEmpAttributeVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEmpAttributeVisibilityHeaders headers = new ListEmpAttributeVisibilityHeaders();
            return ListEmpAttributeVisibilityWithOptions(request, headers, runtime);
        }

        public async Task<ListEmpAttributeVisibilityResponse> ListEmpAttributeVisibilityAsync(ListEmpAttributeVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEmpAttributeVisibilityHeaders headers = new ListEmpAttributeVisibilityHeaders();
            return await ListEmpAttributeVisibilityWithOptionsAsync(request, headers, runtime);
        }

        public ListEmpLeaveRecordsResponse ListEmpLeaveRecordsWithOptions(ListEmpLeaveRecordsRequest request, ListEmpLeaveRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ListEmpLeaveRecords",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/empLeaveRecords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEmpLeaveRecordsResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListEmpLeaveRecordsResponse> ListEmpLeaveRecordsWithOptionsAsync(ListEmpLeaveRecordsRequest request, ListEmpLeaveRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ListEmpLeaveRecords",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/empLeaveRecords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEmpLeaveRecordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListEmpLeaveRecordsResponse ListEmpLeaveRecords(ListEmpLeaveRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEmpLeaveRecordsHeaders headers = new ListEmpLeaveRecordsHeaders();
            return ListEmpLeaveRecordsWithOptions(request, headers, runtime);
        }

        public async Task<ListEmpLeaveRecordsResponse> ListEmpLeaveRecordsAsync(ListEmpLeaveRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEmpLeaveRecordsHeaders headers = new ListEmpLeaveRecordsHeaders();
            return await ListEmpLeaveRecordsWithOptionsAsync(request, headers, runtime);
        }

        public ListManagementGroupsResponse ListManagementGroupsWithOptions(ListManagementGroupsRequest request, ListManagementGroupsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListManagementGroups",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/managementGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListManagementGroupsResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListManagementGroupsResponse> ListManagementGroupsWithOptionsAsync(ListManagementGroupsRequest request, ListManagementGroupsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListManagementGroups",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/managementGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListManagementGroupsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListManagementGroupsResponse ListManagementGroups(ListManagementGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListManagementGroupsHeaders headers = new ListManagementGroupsHeaders();
            return ListManagementGroupsWithOptions(request, headers, runtime);
        }

        public async Task<ListManagementGroupsResponse> ListManagementGroupsAsync(ListManagementGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListManagementGroupsHeaders headers = new ListManagementGroupsHeaders();
            return await ListManagementGroupsWithOptionsAsync(request, headers, runtime);
        }

        public ListOwnedOrgByStaffIdResponse ListOwnedOrgByStaffIdWithOptions(ListOwnedOrgByStaffIdRequest request, ListOwnedOrgByStaffIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListOwnedOrgByStaffId",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/ownedOrganizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOwnedOrgByStaffIdResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListOwnedOrgByStaffIdResponse> ListOwnedOrgByStaffIdWithOptionsAsync(ListOwnedOrgByStaffIdRequest request, ListOwnedOrgByStaffIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListOwnedOrgByStaffId",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/ownedOrganizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOwnedOrgByStaffIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListOwnedOrgByStaffIdResponse ListOwnedOrgByStaffId(ListOwnedOrgByStaffIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOwnedOrgByStaffIdHeaders headers = new ListOwnedOrgByStaffIdHeaders();
            return ListOwnedOrgByStaffIdWithOptions(request, headers, runtime);
        }

        public async Task<ListOwnedOrgByStaffIdResponse> ListOwnedOrgByStaffIdAsync(ListOwnedOrgByStaffIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOwnedOrgByStaffIdHeaders headers = new ListOwnedOrgByStaffIdHeaders();
            return await ListOwnedOrgByStaffIdWithOptionsAsync(request, headers, runtime);
        }

        public ListSeniorSettingsResponse ListSeniorSettingsWithOptions(ListSeniorSettingsRequest request, ListSeniorSettingsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeniorStaffId))
            {
                query["seniorStaffId"] = request.SeniorStaffId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListSeniorSettings",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/seniorSettings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSeniorSettingsResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListSeniorSettingsResponse> ListSeniorSettingsWithOptionsAsync(ListSeniorSettingsRequest request, ListSeniorSettingsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeniorStaffId))
            {
                query["seniorStaffId"] = request.SeniorStaffId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListSeniorSettings",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/seniorSettings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSeniorSettingsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListSeniorSettingsResponse ListSeniorSettings(ListSeniorSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSeniorSettingsHeaders headers = new ListSeniorSettingsHeaders();
            return ListSeniorSettingsWithOptions(request, headers, runtime);
        }

        public async Task<ListSeniorSettingsResponse> ListSeniorSettingsAsync(ListSeniorSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSeniorSettingsHeaders headers = new ListSeniorSettingsHeaders();
            return await ListSeniorSettingsWithOptionsAsync(request, headers, runtime);
        }

        public ModifyOrgAccUserOwnnessResponse ModifyOrgAccUserOwnnessWithOptions(ModifyOrgAccUserOwnnessRequest request, ModifyOrgAccUserOwnnessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnenssType))
            {
                body["ownenssType"] = request.OwnenssType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnnessId))
            {
                body["ownnessId"] = request.OwnnessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "ModifyOrgAccUserOwnness",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/owness",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyOrgAccUserOwnnessResponse>(Execute(params_, req, runtime));
        }

        public async Task<ModifyOrgAccUserOwnnessResponse> ModifyOrgAccUserOwnnessWithOptionsAsync(ModifyOrgAccUserOwnnessRequest request, ModifyOrgAccUserOwnnessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnenssType))
            {
                body["ownenssType"] = request.OwnenssType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnnessId))
            {
                body["ownnessId"] = request.OwnnessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "ModifyOrgAccUserOwnness",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/owness",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyOrgAccUserOwnnessResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ModifyOrgAccUserOwnnessResponse ModifyOrgAccUserOwnness(ModifyOrgAccUserOwnnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifyOrgAccUserOwnnessHeaders headers = new ModifyOrgAccUserOwnnessHeaders();
            return ModifyOrgAccUserOwnnessWithOptions(request, headers, runtime);
        }

        public async Task<ModifyOrgAccUserOwnnessResponse> ModifyOrgAccUserOwnnessAsync(ModifyOrgAccUserOwnnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifyOrgAccUserOwnnessHeaders headers = new ModifyOrgAccUserOwnnessHeaders();
            return await ModifyOrgAccUserOwnnessWithOptionsAsync(request, headers, runtime);
        }

        public MultiOrgPermissionGrantResponse MultiOrgPermissionGrantWithOptions(MultiOrgPermissionGrantRequest request, MultiOrgPermissionGrantHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantDeptIdList))
            {
                body["grantDeptIdList"] = request.GrantDeptIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinCorpId))
            {
                body["joinCorpId"] = request.JoinCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "MultiOrgPermissionGrant",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/multiOrgPermissions/auth",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<MultiOrgPermissionGrantResponse>(Execute(params_, req, runtime));
        }

        public async Task<MultiOrgPermissionGrantResponse> MultiOrgPermissionGrantWithOptionsAsync(MultiOrgPermissionGrantRequest request, MultiOrgPermissionGrantHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantDeptIdList))
            {
                body["grantDeptIdList"] = request.GrantDeptIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinCorpId))
            {
                body["joinCorpId"] = request.JoinCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "MultiOrgPermissionGrant",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/multiOrgPermissions/auth",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<MultiOrgPermissionGrantResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public MultiOrgPermissionGrantResponse MultiOrgPermissionGrant(MultiOrgPermissionGrantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MultiOrgPermissionGrantHeaders headers = new MultiOrgPermissionGrantHeaders();
            return MultiOrgPermissionGrantWithOptions(request, headers, runtime);
        }

        public async Task<MultiOrgPermissionGrantResponse> MultiOrgPermissionGrantAsync(MultiOrgPermissionGrantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MultiOrgPermissionGrantHeaders headers = new MultiOrgPermissionGrantHeaders();
            return await MultiOrgPermissionGrantWithOptionsAsync(request, headers, runtime);
        }

        public QueryCardVisitorStatisticDataResponse QueryCardVisitorStatisticDataWithOptions(QueryCardVisitorStatisticDataRequest request, QueryCardVisitorStatisticDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "QueryCardVisitorStatisticData",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cards/visitors/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCardVisitorStatisticDataResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryCardVisitorStatisticDataResponse> QueryCardVisitorStatisticDataWithOptionsAsync(QueryCardVisitorStatisticDataRequest request, QueryCardVisitorStatisticDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "QueryCardVisitorStatisticData",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cards/visitors/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCardVisitorStatisticDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryCardVisitorStatisticDataResponse QueryCardVisitorStatisticData(QueryCardVisitorStatisticDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCardVisitorStatisticDataHeaders headers = new QueryCardVisitorStatisticDataHeaders();
            return QueryCardVisitorStatisticDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryCardVisitorStatisticDataResponse> QueryCardVisitorStatisticDataAsync(QueryCardVisitorStatisticDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCardVisitorStatisticDataHeaders headers = new QueryCardVisitorStatisticDataHeaders();
            return await QueryCardVisitorStatisticDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryCorpStatisticDataResponse QueryCorpStatisticDataWithOptions(QueryCorpStatisticDataRequest request, QueryCorpStatisticDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                body["templateIds"] = request.TemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryCorpStatisticData",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cards/templates/statistics/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCorpStatisticDataResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryCorpStatisticDataResponse> QueryCorpStatisticDataWithOptionsAsync(QueryCorpStatisticDataRequest request, QueryCorpStatisticDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                body["templateIds"] = request.TemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryCorpStatisticData",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cards/templates/statistics/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCorpStatisticDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryCorpStatisticDataResponse QueryCorpStatisticData(QueryCorpStatisticDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCorpStatisticDataHeaders headers = new QueryCorpStatisticDataHeaders();
            return QueryCorpStatisticDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryCorpStatisticDataResponse> QueryCorpStatisticDataAsync(QueryCorpStatisticDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCorpStatisticDataHeaders headers = new QueryCorpStatisticDataHeaders();
            return await QueryCorpStatisticDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryCorpUserStatisticResponse QueryCorpUserStatisticWithOptions(QueryCorpUserStatisticRequest request, QueryCorpUserStatisticHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                body["templateIds"] = request.TemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryCorpUserStatistic",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cards/users/statistics/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCorpUserStatisticResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryCorpUserStatisticResponse> QueryCorpUserStatisticWithOptionsAsync(QueryCorpUserStatisticRequest request, QueryCorpUserStatisticHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                body["templateIds"] = request.TemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryCorpUserStatistic",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cards/users/statistics/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCorpUserStatisticResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryCorpUserStatisticResponse QueryCorpUserStatistic(QueryCorpUserStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCorpUserStatisticHeaders headers = new QueryCorpUserStatisticHeaders();
            return QueryCorpUserStatisticWithOptions(request, headers, runtime);
        }

        public async Task<QueryCorpUserStatisticResponse> QueryCorpUserStatisticAsync(QueryCorpUserStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCorpUserStatisticHeaders headers = new QueryCorpUserStatisticHeaders();
            return await QueryCorpUserStatisticWithOptionsAsync(request, headers, runtime);
        }

        public QueryResourceManagementMembersResponse QueryResourceManagementMembersWithOptions(string resourceId, QueryResourceManagementMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryResourceManagementMembers",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/resources/" + resourceId + "/managementMembers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryResourceManagementMembersResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryResourceManagementMembersResponse> QueryResourceManagementMembersWithOptionsAsync(string resourceId, QueryResourceManagementMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryResourceManagementMembers",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/resources/" + resourceId + "/managementMembers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryResourceManagementMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryResourceManagementMembersResponse QueryResourceManagementMembers(string resourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryResourceManagementMembersHeaders headers = new QueryResourceManagementMembersHeaders();
            return QueryResourceManagementMembersWithOptions(resourceId, headers, runtime);
        }

        public async Task<QueryResourceManagementMembersResponse> QueryResourceManagementMembersAsync(string resourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryResourceManagementMembersHeaders headers = new QueryResourceManagementMembersHeaders();
            return await QueryResourceManagementMembersWithOptionsAsync(resourceId, headers, runtime);
        }

        public QueryStatusResponse QueryStatusWithOptions(QueryStatusRequest request, QueryStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "QueryStatus",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryStatusResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryStatusResponse> QueryStatusWithOptionsAsync(QueryStatusRequest request, QueryStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "QueryStatus",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryStatusResponse QueryStatus(QueryStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryStatusHeaders headers = new QueryStatusHeaders();
            return QueryStatusWithOptions(request, headers, runtime);
        }

        public async Task<QueryStatusResponse> QueryStatusAsync(QueryStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryStatusHeaders headers = new QueryStatusHeaders();
            return await QueryStatusWithOptionsAsync(request, headers, runtime);
        }

        public QueryUserManagementResourcesResponse QueryUserManagementResourcesWithOptions(string userId, QueryUserManagementResourcesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUserManagementResources",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/users/" + userId + "/managemementResources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserManagementResourcesResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryUserManagementResourcesResponse> QueryUserManagementResourcesWithOptionsAsync(string userId, QueryUserManagementResourcesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUserManagementResources",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/users/" + userId + "/managemementResources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserManagementResourcesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryUserManagementResourcesResponse QueryUserManagementResources(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserManagementResourcesHeaders headers = new QueryUserManagementResourcesHeaders();
            return QueryUserManagementResourcesWithOptions(userId, headers, runtime);
        }

        public async Task<QueryUserManagementResourcesResponse> QueryUserManagementResourcesAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserManagementResourcesHeaders headers = new QueryUserManagementResourcesHeaders();
            return await QueryUserManagementResourcesWithOptionsAsync(userId, headers, runtime);
        }

        public QueryVerifyResultResponse QueryVerifyResultWithOptions(QueryVerifyResultRequest request, QueryVerifyResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyId))
            {
                query["verifyId"] = request.VerifyId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "QueryVerifyResult",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/verifyIdentitys/verifyResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVerifyResultResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryVerifyResultResponse> QueryVerifyResultWithOptionsAsync(QueryVerifyResultRequest request, QueryVerifyResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyId))
            {
                query["verifyId"] = request.VerifyId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "QueryVerifyResult",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/verifyIdentitys/verifyResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVerifyResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryVerifyResultResponse QueryVerifyResult(QueryVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryVerifyResultHeaders headers = new QueryVerifyResultHeaders();
            return QueryVerifyResultWithOptions(request, headers, runtime);
        }

        public async Task<QueryVerifyResultResponse> QueryVerifyResultAsync(QueryVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryVerifyResultHeaders headers = new QueryVerifyResultHeaders();
            return await QueryVerifyResultWithOptionsAsync(request, headers, runtime);
        }

        public SearchDepartmentResponse SearchDepartmentWithOptions(SearchDepartmentRequest request, SearchDepartmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryWord))
            {
                body["queryWord"] = request.QueryWord;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchDepartment",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/departments/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchDepartmentResponse>(Execute(params_, req, runtime));
        }

        public async Task<SearchDepartmentResponse> SearchDepartmentWithOptionsAsync(SearchDepartmentRequest request, SearchDepartmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryWord))
            {
                body["queryWord"] = request.QueryWord;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchDepartment",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/departments/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchDepartmentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SearchDepartmentResponse SearchDepartment(SearchDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchDepartmentHeaders headers = new SearchDepartmentHeaders();
            return SearchDepartmentWithOptions(request, headers, runtime);
        }

        public async Task<SearchDepartmentResponse> SearchDepartmentAsync(SearchDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchDepartmentHeaders headers = new SearchDepartmentHeaders();
            return await SearchDepartmentWithOptionsAsync(request, headers, runtime);
        }

        public SearchUserResponse SearchUserWithOptions(SearchUserRequest request, SearchUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullMatchField))
            {
                body["fullMatchField"] = request.FullMatchField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryWord))
            {
                body["queryWord"] = request.QueryWord;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchUser",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/users/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchUserResponse>(Execute(params_, req, runtime));
        }

        public async Task<SearchUserResponse> SearchUserWithOptionsAsync(SearchUserRequest request, SearchUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullMatchField))
            {
                body["fullMatchField"] = request.FullMatchField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryWord))
            {
                body["queryWord"] = request.QueryWord;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchUser",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/users/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SearchUserResponse SearchUser(SearchUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchUserHeaders headers = new SearchUserHeaders();
            return SearchUserWithOptions(request, headers, runtime);
        }

        public async Task<SearchUserResponse> SearchUserAsync(SearchUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchUserHeaders headers = new SearchUserHeaders();
            return await SearchUserWithOptionsAsync(request, headers, runtime);
        }

        public SeparateBranchOrgResponse SeparateBranchOrgWithOptions(SeparateBranchOrgRequest request, SeparateBranchOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachDeptId))
            {
                body["attachDeptId"] = request.AttachDeptId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SeparateBranchOrg",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cooperateCorps/separate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SeparateBranchOrgResponse>(Execute(params_, req, runtime));
        }

        public async Task<SeparateBranchOrgResponse> SeparateBranchOrgWithOptionsAsync(SeparateBranchOrgRequest request, SeparateBranchOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachDeptId))
            {
                body["attachDeptId"] = request.AttachDeptId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SeparateBranchOrg",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cooperateCorps/separate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SeparateBranchOrgResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SeparateBranchOrgResponse SeparateBranchOrg(SeparateBranchOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SeparateBranchOrgHeaders headers = new SeparateBranchOrgHeaders();
            return SeparateBranchOrgWithOptions(request, headers, runtime);
        }

        public async Task<SeparateBranchOrgResponse> SeparateBranchOrgAsync(SeparateBranchOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SeparateBranchOrgHeaders headers = new SeparateBranchOrgHeaders();
            return await SeparateBranchOrgWithOptionsAsync(request, headers, runtime);
        }

        public SetDisableResponse SetDisableWithOptions(SetDisableRequest request, SetDisableHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetDisable",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/disable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDisableResponse>(Execute(params_, req, runtime));
        }

        public async Task<SetDisableResponse> SetDisableWithOptionsAsync(SetDisableRequest request, SetDisableHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetDisable",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/disable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDisableResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SetDisableResponse SetDisable(SetDisableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDisableHeaders headers = new SetDisableHeaders();
            return SetDisableWithOptions(request, headers, runtime);
        }

        public async Task<SetDisableResponse> SetDisableAsync(SetDisableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDisableHeaders headers = new SetDisableHeaders();
            return await SetDisableWithOptionsAsync(request, headers, runtime);
        }

        public SetEnableResponse SetEnableWithOptions(SetEnableRequest request, SetEnableHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetEnable",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/enable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetEnableResponse>(Execute(params_, req, runtime));
        }

        public async Task<SetEnableResponse> SetEnableWithOptionsAsync(SetEnableRequest request, SetEnableHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetEnable",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/enable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetEnableResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SetEnableResponse SetEnable(SetEnableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetEnableHeaders headers = new SetEnableHeaders();
            return SetEnableWithOptions(request, headers, runtime);
        }

        public async Task<SetEnableResponse> SetEnableAsync(SetEnableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetEnableHeaders headers = new SetEnableHeaders();
            return await SetEnableWithOptionsAsync(request, headers, runtime);
        }

        public SignOutResponse SignOutWithOptions(SignOutRequest request, SignOutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SignOut",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/signOut",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SignOutResponse>(Execute(params_, req, runtime));
        }

        public async Task<SignOutResponse> SignOutWithOptionsAsync(SignOutRequest request, SignOutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SignOut",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/signOut",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SignOutResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SignOutResponse SignOut(SignOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SignOutHeaders headers = new SignOutHeaders();
            return SignOutWithOptions(request, headers, runtime);
        }

        public async Task<SignOutResponse> SignOutAsync(SignOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SignOutHeaders headers = new SignOutHeaders();
            return await SignOutWithOptionsAsync(request, headers, runtime);
        }

        public SortUserResponse SortUserWithOptions(SortUserRequest request, SortUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                body["sortType"] = request.SortType;
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
                Action = "SortUser",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/users/sort",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SortUserResponse>(Execute(params_, req, runtime));
        }

        public async Task<SortUserResponse> SortUserWithOptionsAsync(SortUserRequest request, SortUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                body["sortType"] = request.SortType;
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
                Action = "SortUser",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/users/sort",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SortUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SortUserResponse SortUser(SortUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SortUserHeaders headers = new SortUserHeaders();
            return SortUserWithOptions(request, headers, runtime);
        }

        public async Task<SortUserResponse> SortUserAsync(SortUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SortUserHeaders headers = new SortUserHeaders();
            return await SortUserWithOptionsAsync(request, headers, runtime);
        }

        public TransformToExclusiveAccountResponse TransformToExclusiveAccountWithOptions(TransformToExclusiveAccountRequest request, TransformToExclusiveAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpDingTalk))
            {
                body["idpDingTalk"] = request.IdpDingTalk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitPassword))
            {
                body["initPassword"] = request.InitPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginId))
            {
                body["loginId"] = request.LoginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransformType))
            {
                body["transformType"] = request.TransformType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TransformToExclusiveAccount",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccount/transformToExclusiveAccounts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransformToExclusiveAccountResponse>(Execute(params_, req, runtime));
        }

        public async Task<TransformToExclusiveAccountResponse> TransformToExclusiveAccountWithOptionsAsync(TransformToExclusiveAccountRequest request, TransformToExclusiveAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpDingTalk))
            {
                body["idpDingTalk"] = request.IdpDingTalk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitPassword))
            {
                body["initPassword"] = request.InitPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginId))
            {
                body["loginId"] = request.LoginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransformType))
            {
                body["transformType"] = request.TransformType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TransformToExclusiveAccount",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccount/transformToExclusiveAccounts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransformToExclusiveAccountResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public TransformToExclusiveAccountResponse TransformToExclusiveAccount(TransformToExclusiveAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TransformToExclusiveAccountHeaders headers = new TransformToExclusiveAccountHeaders();
            return TransformToExclusiveAccountWithOptions(request, headers, runtime);
        }

        public async Task<TransformToExclusiveAccountResponse> TransformToExclusiveAccountAsync(TransformToExclusiveAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TransformToExclusiveAccountHeaders headers = new TransformToExclusiveAccountHeaders();
            return await TransformToExclusiveAccountWithOptionsAsync(request, headers, runtime);
        }

        public TranslateFileResponse TranslateFileWithOptions(TranslateFileRequest request, TranslateFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Medias))
            {
                body["medias"] = request.Medias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFileName))
            {
                body["outputFileName"] = request.OutputFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TranslateFile",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/files/translate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TranslateFileResponse>(Execute(params_, req, runtime));
        }

        public async Task<TranslateFileResponse> TranslateFileWithOptionsAsync(TranslateFileRequest request, TranslateFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Medias))
            {
                body["medias"] = request.Medias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFileName))
            {
                body["outputFileName"] = request.OutputFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TranslateFile",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/files/translate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TranslateFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public TranslateFileResponse TranslateFile(TranslateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TranslateFileHeaders headers = new TranslateFileHeaders();
            return TranslateFileWithOptions(request, headers, runtime);
        }

        public async Task<TranslateFileResponse> TranslateFileAsync(TranslateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TranslateFileHeaders headers = new TranslateFileHeaders();
            return await TranslateFileWithOptionsAsync(request, headers, runtime);
        }

        public UniqueQueryUserCardResponse UniqueQueryUserCardWithOptions(UniqueQueryUserCardRequest request, UniqueQueryUserCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "UniqueQueryUserCard",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/uniques/cards",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UniqueQueryUserCardResponse>(Execute(params_, req, runtime));
        }

        public async Task<UniqueQueryUserCardResponse> UniqueQueryUserCardWithOptionsAsync(UniqueQueryUserCardRequest request, UniqueQueryUserCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "UniqueQueryUserCard",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/uniques/cards",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UniqueQueryUserCardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UniqueQueryUserCardResponse UniqueQueryUserCard(UniqueQueryUserCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UniqueQueryUserCardHeaders headers = new UniqueQueryUserCardHeaders();
            return UniqueQueryUserCardWithOptions(request, headers, runtime);
        }

        public async Task<UniqueQueryUserCardResponse> UniqueQueryUserCardAsync(UniqueQueryUserCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UniqueQueryUserCardHeaders headers = new UniqueQueryUserCardHeaders();
            return await UniqueQueryUserCardWithOptionsAsync(request, headers, runtime);
        }

        public UpdateBranchAttributesInCooperateResponse UpdateBranchAttributesInCooperateWithOptions(UpdateBranchAttributesInCooperateRequest request, UpdateBranchAttributesInCooperateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBranchAttributesInCooperate",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cooperateCorps/branchAttributes",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBranchAttributesInCooperateResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateBranchAttributesInCooperateResponse> UpdateBranchAttributesInCooperateWithOptionsAsync(UpdateBranchAttributesInCooperateRequest request, UpdateBranchAttributesInCooperateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBranchAttributesInCooperate",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cooperateCorps/branchAttributes",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBranchAttributesInCooperateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateBranchAttributesInCooperateResponse UpdateBranchAttributesInCooperate(UpdateBranchAttributesInCooperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateBranchAttributesInCooperateHeaders headers = new UpdateBranchAttributesInCooperateHeaders();
            return UpdateBranchAttributesInCooperateWithOptions(request, headers, runtime);
        }

        public async Task<UpdateBranchAttributesInCooperateResponse> UpdateBranchAttributesInCooperateAsync(UpdateBranchAttributesInCooperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateBranchAttributesInCooperateHeaders headers = new UpdateBranchAttributesInCooperateHeaders();
            return await UpdateBranchAttributesInCooperateWithOptionsAsync(request, headers, runtime);
        }

        public UpdateBranchVisibleSettingInCooperateResponse UpdateBranchVisibleSettingInCooperateWithOptions(UpdateBranchVisibleSettingInCooperateRequest request, UpdateBranchVisibleSettingInCooperateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBranchVisibleSettingInCooperate",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cooperateCorps/branchVisibleSettings",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateBranchVisibleSettingInCooperateResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateBranchVisibleSettingInCooperateResponse> UpdateBranchVisibleSettingInCooperateWithOptionsAsync(UpdateBranchVisibleSettingInCooperateRequest request, UpdateBranchVisibleSettingInCooperateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBranchVisibleSettingInCooperate",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/cooperateCorps/branchVisibleSettings",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateBranchVisibleSettingInCooperateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateBranchVisibleSettingInCooperateResponse UpdateBranchVisibleSettingInCooperate(UpdateBranchVisibleSettingInCooperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateBranchVisibleSettingInCooperateHeaders headers = new UpdateBranchVisibleSettingInCooperateHeaders();
            return UpdateBranchVisibleSettingInCooperateWithOptions(request, headers, runtime);
        }

        public async Task<UpdateBranchVisibleSettingInCooperateResponse> UpdateBranchVisibleSettingInCooperateAsync(UpdateBranchVisibleSettingInCooperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateBranchVisibleSettingInCooperateHeaders headers = new UpdateBranchVisibleSettingInCooperateHeaders();
            return await UpdateBranchVisibleSettingInCooperateWithOptionsAsync(request, headers, runtime);
        }

        public UpdateContactHideBySceneSettingResponse UpdateContactHideBySceneSettingWithOptions(string settingId, UpdateContactHideBySceneSettingRequest request, UpdateContactHideBySceneSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDeptIds))
            {
                body["excludeDeptIds"] = request.ExcludeDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeTagIds))
            {
                body["excludeTagIds"] = request.ExcludeTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUserIds))
            {
                body["excludeUserIds"] = request.ExcludeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeListSceneConfig))
            {
                body["nodeListSceneConfig"] = request.NodeListSceneConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectDeptIds))
            {
                body["objectDeptIds"] = request.ObjectDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectTagIds))
            {
                body["objectTagIds"] = request.ObjectTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectUserIds))
            {
                body["objectUserIds"] = request.ObjectUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileSceneConfig))
            {
                body["profileSceneConfig"] = request.ProfileSceneConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchSceneConfig))
            {
                body["searchSceneConfig"] = request.SearchSceneConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateContactHideBySceneSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/organizations/hides/settings/" + settingId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContactHideBySceneSettingResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateContactHideBySceneSettingResponse> UpdateContactHideBySceneSettingWithOptionsAsync(string settingId, UpdateContactHideBySceneSettingRequest request, UpdateContactHideBySceneSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDeptIds))
            {
                body["excludeDeptIds"] = request.ExcludeDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeTagIds))
            {
                body["excludeTagIds"] = request.ExcludeTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUserIds))
            {
                body["excludeUserIds"] = request.ExcludeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeListSceneConfig))
            {
                body["nodeListSceneConfig"] = request.NodeListSceneConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectDeptIds))
            {
                body["objectDeptIds"] = request.ObjectDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectTagIds))
            {
                body["objectTagIds"] = request.ObjectTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectUserIds))
            {
                body["objectUserIds"] = request.ObjectUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileSceneConfig))
            {
                body["profileSceneConfig"] = request.ProfileSceneConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchSceneConfig))
            {
                body["searchSceneConfig"] = request.SearchSceneConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateContactHideBySceneSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/organizations/hides/settings/" + settingId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContactHideBySceneSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateContactHideBySceneSettingResponse UpdateContactHideBySceneSetting(string settingId, UpdateContactHideBySceneSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateContactHideBySceneSettingHeaders headers = new UpdateContactHideBySceneSettingHeaders();
            return UpdateContactHideBySceneSettingWithOptions(settingId, request, headers, runtime);
        }

        public async Task<UpdateContactHideBySceneSettingResponse> UpdateContactHideBySceneSettingAsync(string settingId, UpdateContactHideBySceneSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateContactHideBySceneSettingHeaders headers = new UpdateContactHideBySceneSettingHeaders();
            return await UpdateContactHideBySceneSettingWithOptionsAsync(settingId, request, headers, runtime);
        }

        public UpdateContactHideSettingResponse UpdateContactHideSettingWithOptions(UpdateContactHideSettingRequest request, UpdateContactHideSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                body["active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDeptIds))
            {
                body["excludeDeptIds"] = request.ExcludeDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeStaffIds))
            {
                body["excludeStaffIds"] = request.ExcludeStaffIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeTagIds))
            {
                body["excludeTagIds"] = request.ExcludeTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideInSearch))
            {
                body["hideInSearch"] = request.HideInSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideInUserProfile))
            {
                body["hideInUserProfile"] = request.HideInUserProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectDeptIds))
            {
                body["objectDeptIds"] = request.ObjectDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectStaffIds))
            {
                body["objectStaffIds"] = request.ObjectStaffIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectTagIds))
            {
                body["objectTagIds"] = request.ObjectTagIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateContactHideSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/contactHideSettings",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContactHideSettingResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateContactHideSettingResponse> UpdateContactHideSettingWithOptionsAsync(UpdateContactHideSettingRequest request, UpdateContactHideSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                body["active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDeptIds))
            {
                body["excludeDeptIds"] = request.ExcludeDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeStaffIds))
            {
                body["excludeStaffIds"] = request.ExcludeStaffIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeTagIds))
            {
                body["excludeTagIds"] = request.ExcludeTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideInSearch))
            {
                body["hideInSearch"] = request.HideInSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideInUserProfile))
            {
                body["hideInUserProfile"] = request.HideInUserProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectDeptIds))
            {
                body["objectDeptIds"] = request.ObjectDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectStaffIds))
            {
                body["objectStaffIds"] = request.ObjectStaffIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectTagIds))
            {
                body["objectTagIds"] = request.ObjectTagIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateContactHideSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/contactHideSettings",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContactHideSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateContactHideSettingResponse UpdateContactHideSetting(UpdateContactHideSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateContactHideSettingHeaders headers = new UpdateContactHideSettingHeaders();
            return UpdateContactHideSettingWithOptions(request, headers, runtime);
        }

        public async Task<UpdateContactHideSettingResponse> UpdateContactHideSettingAsync(UpdateContactHideSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateContactHideSettingHeaders headers = new UpdateContactHideSettingHeaders();
            return await UpdateContactHideSettingWithOptionsAsync(request, headers, runtime);
        }

        public UpdateContactRestrictSettingResponse UpdateContactRestrictSettingWithOptions(UpdateContactRestrictSettingRequest request, UpdateContactRestrictSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                body["active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDeptIds))
            {
                body["excludeDeptIds"] = request.ExcludeDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeTagIds))
            {
                body["excludeTagIds"] = request.ExcludeTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUserIds))
            {
                body["excludeUserIds"] = request.ExcludeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestrictInSearch))
            {
                body["restrictInSearch"] = request.RestrictInSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestrictInUserProfile))
            {
                body["restrictInUserProfile"] = request.RestrictInUserProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubjectDeptIds))
            {
                body["subjectDeptIds"] = request.SubjectDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubjectTagIds))
            {
                body["subjectTagIds"] = request.SubjectTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubjectUserIds))
            {
                body["subjectUserIds"] = request.SubjectUserIds;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContactRestrictSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/restrictions/settings",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContactRestrictSettingResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateContactRestrictSettingResponse> UpdateContactRestrictSettingWithOptionsAsync(UpdateContactRestrictSettingRequest request, UpdateContactRestrictSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                body["active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDeptIds))
            {
                body["excludeDeptIds"] = request.ExcludeDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeTagIds))
            {
                body["excludeTagIds"] = request.ExcludeTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUserIds))
            {
                body["excludeUserIds"] = request.ExcludeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestrictInSearch))
            {
                body["restrictInSearch"] = request.RestrictInSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestrictInUserProfile))
            {
                body["restrictInUserProfile"] = request.RestrictInUserProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubjectDeptIds))
            {
                body["subjectDeptIds"] = request.SubjectDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubjectTagIds))
            {
                body["subjectTagIds"] = request.SubjectTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubjectUserIds))
            {
                body["subjectUserIds"] = request.SubjectUserIds;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContactRestrictSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/restrictions/settings",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContactRestrictSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateContactRestrictSettingResponse UpdateContactRestrictSetting(UpdateContactRestrictSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateContactRestrictSettingHeaders headers = new UpdateContactRestrictSettingHeaders();
            return UpdateContactRestrictSettingWithOptions(request, headers, runtime);
        }

        public async Task<UpdateContactRestrictSettingResponse> UpdateContactRestrictSettingAsync(UpdateContactRestrictSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateContactRestrictSettingHeaders headers = new UpdateContactRestrictSettingHeaders();
            return await UpdateContactRestrictSettingWithOptionsAsync(request, headers, runtime);
        }

        public UpdateDeptSettngTailFirstResponse UpdateDeptSettngTailFirstWithOptions(UpdateDeptSettngTailFirstRequest request, UpdateDeptSettngTailFirstHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateDeptSettngTailFirst",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/depts/settings/priorities",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeptSettngTailFirstResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateDeptSettngTailFirstResponse> UpdateDeptSettngTailFirstWithOptionsAsync(UpdateDeptSettngTailFirstRequest request, UpdateDeptSettngTailFirstHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateDeptSettngTailFirst",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/depts/settings/priorities",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeptSettngTailFirstResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateDeptSettngTailFirstResponse UpdateDeptSettngTailFirst(UpdateDeptSettngTailFirstRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeptSettngTailFirstHeaders headers = new UpdateDeptSettngTailFirstHeaders();
            return UpdateDeptSettngTailFirstWithOptions(request, headers, runtime);
        }

        public async Task<UpdateDeptSettngTailFirstResponse> UpdateDeptSettngTailFirstAsync(UpdateDeptSettngTailFirstRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeptSettngTailFirstHeaders headers = new UpdateDeptSettngTailFirstHeaders();
            return await UpdateDeptSettngTailFirstWithOptionsAsync(request, headers, runtime);
        }

        public UpdateEmpAttrbuteVisibilitySettingResponse UpdateEmpAttrbuteVisibilitySettingWithOptions(UpdateEmpAttrbuteVisibilitySettingRequest request, UpdateEmpAttrbuteVisibilitySettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                body["active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDeptIds))
            {
                body["excludeDeptIds"] = request.ExcludeDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeStaffIds))
            {
                body["excludeStaffIds"] = request.ExcludeStaffIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeTagIds))
            {
                body["excludeTagIds"] = request.ExcludeTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideFields))
            {
                body["hideFields"] = request.HideFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectDeptIds))
            {
                body["objectDeptIds"] = request.ObjectDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectStaffIds))
            {
                body["objectStaffIds"] = request.ObjectStaffIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectTagIds))
            {
                body["objectTagIds"] = request.ObjectTagIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateEmpAttrbuteVisibilitySetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/staffAttributes/visibilitySettings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEmpAttrbuteVisibilitySettingResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateEmpAttrbuteVisibilitySettingResponse> UpdateEmpAttrbuteVisibilitySettingWithOptionsAsync(UpdateEmpAttrbuteVisibilitySettingRequest request, UpdateEmpAttrbuteVisibilitySettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                body["active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDeptIds))
            {
                body["excludeDeptIds"] = request.ExcludeDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeStaffIds))
            {
                body["excludeStaffIds"] = request.ExcludeStaffIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeTagIds))
            {
                body["excludeTagIds"] = request.ExcludeTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideFields))
            {
                body["hideFields"] = request.HideFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectDeptIds))
            {
                body["objectDeptIds"] = request.ObjectDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectStaffIds))
            {
                body["objectStaffIds"] = request.ObjectStaffIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectTagIds))
            {
                body["objectTagIds"] = request.ObjectTagIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateEmpAttrbuteVisibilitySetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/staffAttributes/visibilitySettings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEmpAttrbuteVisibilitySettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateEmpAttrbuteVisibilitySettingResponse UpdateEmpAttrbuteVisibilitySetting(UpdateEmpAttrbuteVisibilitySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateEmpAttrbuteVisibilitySettingHeaders headers = new UpdateEmpAttrbuteVisibilitySettingHeaders();
            return UpdateEmpAttrbuteVisibilitySettingWithOptions(request, headers, runtime);
        }

        public async Task<UpdateEmpAttrbuteVisibilitySettingResponse> UpdateEmpAttrbuteVisibilitySettingAsync(UpdateEmpAttrbuteVisibilitySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateEmpAttrbuteVisibilitySettingHeaders headers = new UpdateEmpAttrbuteVisibilitySettingHeaders();
            return await UpdateEmpAttrbuteVisibilitySettingWithOptionsAsync(request, headers, runtime);
        }

        public UpdateEmpAttributeHideBySceneSettingResponse UpdateEmpAttributeHideBySceneSettingWithOptions(string settingId, UpdateEmpAttributeHideBySceneSettingRequest request, UpdateEmpAttributeHideBySceneSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatSubtitleConfig))
            {
                body["chatSubtitleConfig"] = request.ChatSubtitleConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDeptIds))
            {
                body["excludeDeptIds"] = request.ExcludeDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeTagIds))
            {
                body["excludeTagIds"] = request.ExcludeTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUserIds))
            {
                body["excludeUserIds"] = request.ExcludeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideFields))
            {
                body["hideFields"] = request.HideFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectDeptIds))
            {
                body["objectDeptIds"] = request.ObjectDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectTagIds))
            {
                body["objectTagIds"] = request.ObjectTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectUserIds))
            {
                body["objectUserIds"] = request.ObjectUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileSceneConfig))
            {
                body["profileSceneConfig"] = request.ProfileSceneConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchSceneConfig))
            {
                body["searchSceneConfig"] = request.SearchSceneConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateEmpAttributeHideBySceneSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/empAttributes/hides/settings/" + settingId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEmpAttributeHideBySceneSettingResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateEmpAttributeHideBySceneSettingResponse> UpdateEmpAttributeHideBySceneSettingWithOptionsAsync(string settingId, UpdateEmpAttributeHideBySceneSettingRequest request, UpdateEmpAttributeHideBySceneSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatSubtitleConfig))
            {
                body["chatSubtitleConfig"] = request.ChatSubtitleConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDeptIds))
            {
                body["excludeDeptIds"] = request.ExcludeDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeTagIds))
            {
                body["excludeTagIds"] = request.ExcludeTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUserIds))
            {
                body["excludeUserIds"] = request.ExcludeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideFields))
            {
                body["hideFields"] = request.HideFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectDeptIds))
            {
                body["objectDeptIds"] = request.ObjectDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectTagIds))
            {
                body["objectTagIds"] = request.ObjectTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectUserIds))
            {
                body["objectUserIds"] = request.ObjectUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileSceneConfig))
            {
                body["profileSceneConfig"] = request.ProfileSceneConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchSceneConfig))
            {
                body["searchSceneConfig"] = request.SearchSceneConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateEmpAttributeHideBySceneSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/empAttributes/hides/settings/" + settingId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEmpAttributeHideBySceneSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateEmpAttributeHideBySceneSettingResponse UpdateEmpAttributeHideBySceneSetting(string settingId, UpdateEmpAttributeHideBySceneSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateEmpAttributeHideBySceneSettingHeaders headers = new UpdateEmpAttributeHideBySceneSettingHeaders();
            return UpdateEmpAttributeHideBySceneSettingWithOptions(settingId, request, headers, runtime);
        }

        public async Task<UpdateEmpAttributeHideBySceneSettingResponse> UpdateEmpAttributeHideBySceneSettingAsync(string settingId, UpdateEmpAttributeHideBySceneSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateEmpAttributeHideBySceneSettingHeaders headers = new UpdateEmpAttributeHideBySceneSettingHeaders();
            return await UpdateEmpAttributeHideBySceneSettingWithOptionsAsync(settingId, request, headers, runtime);
        }

        public UpdateManagementGroupResponse UpdateManagementGroupWithOptions(string groupId, UpdateManagementGroupRequest request, UpdateManagementGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["resourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateManagementGroup",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/managementGroups/" + groupId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateManagementGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateManagementGroupResponse> UpdateManagementGroupWithOptionsAsync(string groupId, UpdateManagementGroupRequest request, UpdateManagementGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["resourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateManagementGroup",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/managementGroups/" + groupId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateManagementGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateManagementGroupResponse UpdateManagementGroup(string groupId, UpdateManagementGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateManagementGroupHeaders headers = new UpdateManagementGroupHeaders();
            return UpdateManagementGroupWithOptions(groupId, request, headers, runtime);
        }

        public async Task<UpdateManagementGroupResponse> UpdateManagementGroupAsync(string groupId, UpdateManagementGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateManagementGroupHeaders headers = new UpdateManagementGroupHeaders();
            return await UpdateManagementGroupWithOptionsAsync(groupId, request, headers, runtime);
        }

        public UpdateSeniorSettingResponse UpdateSeniorSettingWithOptions(UpdateSeniorSettingRequest request, UpdateSeniorSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Open))
            {
                body["open"] = request.Open;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitDeptIds))
            {
                body["permitDeptIds"] = request.PermitDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitStaffIds))
            {
                body["permitStaffIds"] = request.PermitStaffIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitTagIds))
            {
                body["permitTagIds"] = request.PermitTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectScenes))
            {
                body["protectScenes"] = request.ProtectScenes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeniorStaffId))
            {
                body["seniorStaffId"] = request.SeniorStaffId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateSeniorSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/seniorSettings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateSeniorSettingResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateSeniorSettingResponse> UpdateSeniorSettingWithOptionsAsync(UpdateSeniorSettingRequest request, UpdateSeniorSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Open))
            {
                body["open"] = request.Open;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitDeptIds))
            {
                body["permitDeptIds"] = request.PermitDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitStaffIds))
            {
                body["permitStaffIds"] = request.PermitStaffIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitTagIds))
            {
                body["permitTagIds"] = request.PermitTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectScenes))
            {
                body["protectScenes"] = request.ProtectScenes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeniorStaffId))
            {
                body["seniorStaffId"] = request.SeniorStaffId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateSeniorSetting",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/seniorSettings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateSeniorSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateSeniorSettingResponse UpdateSeniorSetting(UpdateSeniorSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSeniorSettingHeaders headers = new UpdateSeniorSettingHeaders();
            return UpdateSeniorSettingWithOptions(request, headers, runtime);
        }

        public async Task<UpdateSeniorSettingResponse> UpdateSeniorSettingAsync(UpdateSeniorSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSeniorSettingHeaders headers = new UpdateSeniorSettingHeaders();
            return await UpdateSeniorSettingWithOptionsAsync(request, headers, runtime);
        }

        public UpdateUserOwnnessResponse UpdateUserOwnnessWithOptions(string userId, UpdateUserOwnnessRequest request, UpdateUserOwnnessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletedFlag))
            {
                body["deletedFlag"] = request.DeletedFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnenssType))
            {
                body["ownenssType"] = request.OwnenssType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateUserOwnness",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/user/" + userId + "/ownness",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserOwnnessResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateUserOwnnessResponse> UpdateUserOwnnessWithOptionsAsync(string userId, UpdateUserOwnnessRequest request, UpdateUserOwnnessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletedFlag))
            {
                body["deletedFlag"] = request.DeletedFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnenssType))
            {
                body["ownenssType"] = request.OwnenssType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateUserOwnness",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/user/" + userId + "/ownness",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserOwnnessResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateUserOwnnessResponse UpdateUserOwnness(string userId, UpdateUserOwnnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUserOwnnessHeaders headers = new UpdateUserOwnnessHeaders();
            return UpdateUserOwnnessWithOptions(userId, request, headers, runtime);
        }

        public async Task<UpdateUserOwnnessResponse> UpdateUserOwnnessAsync(string userId, UpdateUserOwnnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUserOwnnessHeaders headers = new UpdateUserOwnnessHeaders();
            return await UpdateUserOwnnessWithOptionsAsync(userId, request, headers, runtime);
        }

    }
}
