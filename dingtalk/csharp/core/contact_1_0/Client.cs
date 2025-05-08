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
        /// <para>创建账号映射</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddAccountMappingRequest
        /// </param>
        /// <param name="headers">
        /// AddAccountMappingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddAccountMappingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建账号映射</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddAccountMappingRequest
        /// </param>
        /// <param name="headers">
        /// AddAccountMappingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddAccountMappingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建账号映射</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddAccountMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// AddAccountMappingResponse
        /// </returns>
        public AddAccountMappingResponse AddAccountMapping(AddAccountMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAccountMappingHeaders headers = new AddAccountMappingHeaders();
            return AddAccountMappingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建账号映射</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddAccountMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// AddAccountMappingResponse
        /// </returns>
        public async Task<AddAccountMappingResponse> AddAccountMappingAsync(AddAccountMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAccountMappingHeaders headers = new AddAccountMappingHeaders();
            return await AddAccountMappingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加通讯录组织架构分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddContactHideBySceneSettingRequest
        /// </param>
        /// <param name="headers">
        /// AddContactHideBySceneSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddContactHideBySceneSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加通讯录组织架构分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddContactHideBySceneSettingRequest
        /// </param>
        /// <param name="headers">
        /// AddContactHideBySceneSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddContactHideBySceneSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加通讯录组织架构分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddContactHideBySceneSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// AddContactHideBySceneSettingResponse
        /// </returns>
        public AddContactHideBySceneSettingResponse AddContactHideBySceneSetting(AddContactHideBySceneSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddContactHideBySceneSettingHeaders headers = new AddContactHideBySceneSettingHeaders();
            return AddContactHideBySceneSettingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加通讯录组织架构分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddContactHideBySceneSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// AddContactHideBySceneSettingResponse
        /// </returns>
        public async Task<AddContactHideBySceneSettingResponse> AddContactHideBySceneSettingAsync(AddContactHideBySceneSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddContactHideBySceneSettingHeaders headers = new AddContactHideBySceneSettingHeaders();
            return await AddContactHideBySceneSettingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加员工属性分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddEmpAttributeHideBySceneSettingRequest
        /// </param>
        /// <param name="headers">
        /// AddEmpAttributeHideBySceneSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddEmpAttributeHideBySceneSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加员工属性分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddEmpAttributeHideBySceneSettingRequest
        /// </param>
        /// <param name="headers">
        /// AddEmpAttributeHideBySceneSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddEmpAttributeHideBySceneSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加员工属性分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddEmpAttributeHideBySceneSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// AddEmpAttributeHideBySceneSettingResponse
        /// </returns>
        public AddEmpAttributeHideBySceneSettingResponse AddEmpAttributeHideBySceneSetting(AddEmpAttributeHideBySceneSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddEmpAttributeHideBySceneSettingHeaders headers = new AddEmpAttributeHideBySceneSettingHeaders();
            return AddEmpAttributeHideBySceneSettingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加员工属性分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddEmpAttributeHideBySceneSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// AddEmpAttributeHideBySceneSettingResponse
        /// </returns>
        public async Task<AddEmpAttributeHideBySceneSettingResponse> AddEmpAttributeHideBySceneSettingAsync(AddEmpAttributeHideBySceneSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddEmpAttributeHideBySceneSettingHeaders headers = new AddEmpAttributeHideBySceneSettingHeaders();
            return await AddEmpAttributeHideBySceneSettingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增企业账号工作状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrgAccountOwnnessRequest
        /// </param>
        /// <param name="headers">
        /// AddOrgAccountOwnnessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddOrgAccountOwnnessResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增企业账号工作状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrgAccountOwnnessRequest
        /// </param>
        /// <param name="headers">
        /// AddOrgAccountOwnnessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddOrgAccountOwnnessResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增企业账号工作状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrgAccountOwnnessRequest
        /// </param>
        /// 
        /// <returns>
        /// AddOrgAccountOwnnessResponse
        /// </returns>
        public AddOrgAccountOwnnessResponse AddOrgAccountOwnness(AddOrgAccountOwnnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrgAccountOwnnessHeaders headers = new AddOrgAccountOwnnessHeaders();
            return AddOrgAccountOwnnessWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增企业账号工作状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrgAccountOwnnessRequest
        /// </param>
        /// 
        /// <returns>
        /// AddOrgAccountOwnnessResponse
        /// </returns>
        public async Task<AddOrgAccountOwnnessResponse> AddOrgAccountOwnnessAsync(AddOrgAccountOwnnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrgAccountOwnnessHeaders headers = new AddOrgAccountOwnnessHeaders();
            return await AddOrgAccountOwnnessWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>年检认证审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnnualCertificationAuditRequest
        /// </param>
        /// <param name="headers">
        /// AnnualCertificationAuditHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AnnualCertificationAuditResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>年检认证审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnnualCertificationAuditRequest
        /// </param>
        /// <param name="headers">
        /// AnnualCertificationAuditHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AnnualCertificationAuditResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>年检认证审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnnualCertificationAuditRequest
        /// </param>
        /// 
        /// <returns>
        /// AnnualCertificationAuditResponse
        /// </returns>
        public AnnualCertificationAuditResponse AnnualCertificationAudit(AnnualCertificationAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AnnualCertificationAuditHeaders headers = new AnnualCertificationAuditHeaders();
            return AnnualCertificationAuditWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>年检认证审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnnualCertificationAuditRequest
        /// </param>
        /// 
        /// <returns>
        /// AnnualCertificationAuditResponse
        /// </returns>
        public async Task<AnnualCertificationAuditResponse> AnnualCertificationAuditAsync(AnnualCertificationAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AnnualCertificationAuditHeaders headers = new AnnualCertificationAuditHeaders();
            return await AnnualCertificationAuditWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量同意(合作空间/集团)的关联申请</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchApproveUnionApplyRequest
        /// </param>
        /// <param name="headers">
        /// BatchApproveUnionApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchApproveUnionApplyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量同意(合作空间/集团)的关联申请</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchApproveUnionApplyRequest
        /// </param>
        /// <param name="headers">
        /// BatchApproveUnionApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchApproveUnionApplyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量同意(合作空间/集团)的关联申请</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchApproveUnionApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchApproveUnionApplyResponse
        /// </returns>
        public BatchApproveUnionApplyResponse BatchApproveUnionApply(BatchApproveUnionApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchApproveUnionApplyHeaders headers = new BatchApproveUnionApplyHeaders();
            return BatchApproveUnionApplyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量同意(合作空间/集团)的关联申请</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchApproveUnionApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchApproveUnionApplyResponse
        /// </returns>
        public async Task<BatchApproveUnionApplyResponse> BatchApproveUnionApplyAsync(BatchApproveUnionApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchApproveUnionApplyHeaders headers = new BatchApproveUnionApplyHeaders();
            return await BatchApproveUnionApplyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改企业员工对外职位信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateExternalTitleRequest
        /// </param>
        /// <param name="headers">
        /// BatchUpdateExternalTitleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateExternalTitleResponse
        /// </returns>
        public BatchUpdateExternalTitleResponse BatchUpdateExternalTitleWithOptions(BatchUpdateExternalTitleRequest request, BatchUpdateExternalTitleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTitleModelList))
            {
                body["updateTitleModelList"] = request.UpdateTitleModelList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchUpdateExternalTitle",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/externalTitles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateExternalTitleResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改企业员工对外职位信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateExternalTitleRequest
        /// </param>
        /// <param name="headers">
        /// BatchUpdateExternalTitleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateExternalTitleResponse
        /// </returns>
        public async Task<BatchUpdateExternalTitleResponse> BatchUpdateExternalTitleWithOptionsAsync(BatchUpdateExternalTitleRequest request, BatchUpdateExternalTitleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTitleModelList))
            {
                body["updateTitleModelList"] = request.UpdateTitleModelList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchUpdateExternalTitle",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/externalTitles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateExternalTitleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改企业员工对外职位信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateExternalTitleRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateExternalTitleResponse
        /// </returns>
        public BatchUpdateExternalTitleResponse BatchUpdateExternalTitle(BatchUpdateExternalTitleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateExternalTitleHeaders headers = new BatchUpdateExternalTitleHeaders();
            return BatchUpdateExternalTitleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改企业员工对外职位信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateExternalTitleRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateExternalTitleResponse
        /// </returns>
        public async Task<BatchUpdateExternalTitleResponse> BatchUpdateExternalTitleAsync(BatchUpdateExternalTitleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateExternalTitleHeaders headers = new BatchUpdateExternalTitleHeaders();
            return await BatchUpdateExternalTitleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改钉钉号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeDingTalkIdRequest
        /// </param>
        /// <param name="headers">
        /// ChangeDingTalkIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeDingTalkIdResponse
        /// </returns>
        public ChangeDingTalkIdResponse ChangeDingTalkIdWithOptions(ChangeDingTalkIdRequest request, ChangeDingTalkIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTalkId))
            {
                body["dingTalkId"] = request.DingTalkId;
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
                Action = "ChangeDingTalkId",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/dingTalkIds/change",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeDingTalkIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改钉钉号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeDingTalkIdRequest
        /// </param>
        /// <param name="headers">
        /// ChangeDingTalkIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeDingTalkIdResponse
        /// </returns>
        public async Task<ChangeDingTalkIdResponse> ChangeDingTalkIdWithOptionsAsync(ChangeDingTalkIdRequest request, ChangeDingTalkIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTalkId))
            {
                body["dingTalkId"] = request.DingTalkId;
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
                Action = "ChangeDingTalkId",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/dingTalkIds/change",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeDingTalkIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改钉钉号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeDingTalkIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeDingTalkIdResponse
        /// </returns>
        public ChangeDingTalkIdResponse ChangeDingTalkId(ChangeDingTalkIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeDingTalkIdHeaders headers = new ChangeDingTalkIdHeaders();
            return ChangeDingTalkIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改钉钉号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeDingTalkIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeDingTalkIdResponse
        /// </returns>
        public async Task<ChangeDingTalkIdResponse> ChangeDingTalkIdAsync(ChangeDingTalkIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeDingTalkIdHeaders headers = new ChangeDingTalkIdHeaders();
            return await ChangeDingTalkIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属帐号转交主管理员(创建者)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeMainAdminRequest
        /// </param>
        /// <param name="headers">
        /// ChangeMainAdminHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeMainAdminResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属帐号转交主管理员(创建者)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeMainAdminRequest
        /// </param>
        /// <param name="headers">
        /// ChangeMainAdminHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeMainAdminResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属帐号转交主管理员(创建者)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeMainAdminRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeMainAdminResponse
        /// </returns>
        public ChangeMainAdminResponse ChangeMainAdmin(ChangeMainAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeMainAdminHeaders headers = new ChangeMainAdminHeaders();
            return ChangeMainAdminWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属帐号转交主管理员(创建者)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeMainAdminRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeMainAdminResponse
        /// </returns>
        public async Task<ChangeMainAdminResponse> ChangeMainAdminAsync(ChangeMainAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeMainAdminHeaders headers = new ChangeMainAdminHeaders();
            return await ChangeMainAdminWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCooperateOrgRequest
        /// </param>
        /// <param name="headers">
        /// CreateCooperateOrgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCooperateOrgResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCooperateOrgRequest
        /// </param>
        /// <param name="headers">
        /// CreateCooperateOrgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCooperateOrgResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCooperateOrgRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCooperateOrgResponse
        /// </returns>
        public CreateCooperateOrgResponse CreateCooperateOrg(CreateCooperateOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCooperateOrgHeaders headers = new CreateCooperateOrgHeaders();
            return CreateCooperateOrgWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCooperateOrgRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCooperateOrgResponse
        /// </returns>
        public async Task<CreateCooperateOrgResponse> CreateCooperateOrgAsync(CreateCooperateOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCooperateOrgHeaders headers = new CreateCooperateOrgHeaders();
            return await CreateCooperateOrgWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建管理组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateManagementGroupRequest
        /// </param>
        /// <param name="headers">
        /// CreateManagementGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateManagementGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建管理组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateManagementGroupRequest
        /// </param>
        /// <param name="headers">
        /// CreateManagementGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateManagementGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建管理组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateManagementGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateManagementGroupResponse
        /// </returns>
        public CreateManagementGroupResponse CreateManagementGroup(CreateManagementGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateManagementGroupHeaders headers = new CreateManagementGroupHeaders();
            return CreateManagementGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建管理组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateManagementGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateManagementGroupResponse
        /// </returns>
        public async Task<CreateManagementGroupResponse> CreateManagementGroupAsync(CreateManagementGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateManagementGroupHeaders headers = new CreateManagementGroupHeaders();
            return await CreateManagementGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>子管理员创建管理组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSecondaryManagementGroupRequest
        /// </param>
        /// <param name="headers">
        /// CreateSecondaryManagementGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSecondaryManagementGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>子管理员创建管理组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSecondaryManagementGroupRequest
        /// </param>
        /// <param name="headers">
        /// CreateSecondaryManagementGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSecondaryManagementGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>子管理员创建管理组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSecondaryManagementGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSecondaryManagementGroupResponse
        /// </returns>
        public CreateSecondaryManagementGroupResponse CreateSecondaryManagementGroup(CreateSecondaryManagementGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSecondaryManagementGroupHeaders headers = new CreateSecondaryManagementGroupHeaders();
            return CreateSecondaryManagementGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>子管理员创建管理组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSecondaryManagementGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSecondaryManagementGroupResponse
        /// </returns>
        public async Task<CreateSecondaryManagementGroupResponse> CreateSecondaryManagementGroupAsync(CreateSecondaryManagementGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSecondaryManagementGroupHeaders headers = new CreateSecondaryManagementGroupHeaders();
            return await CreateSecondaryManagementGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除账号映射</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelAccountMappingRequest
        /// </param>
        /// <param name="headers">
        /// DelAccountMappingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DelAccountMappingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除账号映射</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelAccountMappingRequest
        /// </param>
        /// <param name="headers">
        /// DelAccountMappingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DelAccountMappingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除账号映射</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelAccountMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// DelAccountMappingResponse
        /// </returns>
        public DelAccountMappingResponse DelAccountMapping(DelAccountMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DelAccountMappingHeaders headers = new DelAccountMappingHeaders();
            return DelAccountMappingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除账号映射</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelAccountMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// DelAccountMappingResponse
        /// </returns>
        public async Task<DelAccountMappingResponse> DelAccountMappingAsync(DelAccountMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DelAccountMappingHeaders headers = new DelAccountMappingHeaders();
            return await DelAccountMappingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除企业账号工作状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelOrgAccUserOwnnessRequest
        /// </param>
        /// <param name="headers">
        /// DelOrgAccUserOwnnessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DelOrgAccUserOwnnessResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除企业账号工作状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelOrgAccUserOwnnessRequest
        /// </param>
        /// <param name="headers">
        /// DelOrgAccUserOwnnessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DelOrgAccUserOwnnessResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除企业账号工作状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelOrgAccUserOwnnessRequest
        /// </param>
        /// 
        /// <returns>
        /// DelOrgAccUserOwnnessResponse
        /// </returns>
        public DelOrgAccUserOwnnessResponse DelOrgAccUserOwnness(DelOrgAccUserOwnnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DelOrgAccUserOwnnessHeaders headers = new DelOrgAccUserOwnnessHeaders();
            return DelOrgAccUserOwnnessWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除企业账号工作状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelOrgAccUserOwnnessRequest
        /// </param>
        /// 
        /// <returns>
        /// DelOrgAccUserOwnnessResponse
        /// </returns>
        public async Task<DelOrgAccUserOwnnessResponse> DelOrgAccUserOwnnessAsync(DelOrgAccUserOwnnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DelOrgAccUserOwnnessHeaders headers = new DelOrgAccUserOwnnessHeaders();
            return await DelOrgAccUserOwnnessWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除通讯录组织架构分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteContactHideBySceneSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactHideBySceneSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除通讯录组织架构分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteContactHideBySceneSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactHideBySceneSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除通讯录组织架构分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteContactHideBySceneSettingResponse
        /// </returns>
        public DeleteContactHideBySceneSettingResponse DeleteContactHideBySceneSetting(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteContactHideBySceneSettingHeaders headers = new DeleteContactHideBySceneSettingHeaders();
            return DeleteContactHideBySceneSettingWithOptions(settingId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除通讯录组织架构分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteContactHideBySceneSettingResponse
        /// </returns>
        public async Task<DeleteContactHideBySceneSettingResponse> DeleteContactHideBySceneSettingAsync(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteContactHideBySceneSettingHeaders headers = new DeleteContactHideBySceneSettingHeaders();
            return await DeleteContactHideBySceneSettingWithOptionsAsync(settingId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除通讯录隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteContactHideSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactHideSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除通讯录隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteContactHideSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactHideSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除通讯录隐藏设置</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteContactHideSettingResponse
        /// </returns>
        public DeleteContactHideSettingResponse DeleteContactHideSetting(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteContactHideSettingHeaders headers = new DeleteContactHideSettingHeaders();
            return DeleteContactHideSettingWithOptions(settingId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除通讯录隐藏设置</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteContactHideSettingResponse
        /// </returns>
        public async Task<DeleteContactHideSettingResponse> DeleteContactHideSettingAsync(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteContactHideSettingHeaders headers = new DeleteContactHideSettingHeaders();
            return await DeleteContactHideSettingWithOptionsAsync(settingId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除限制查看通讯录设置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteContactRestrictSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactRestrictSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除限制查看通讯录设置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteContactRestrictSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactRestrictSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除限制查看通讯录设置</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteContactRestrictSettingResponse
        /// </returns>
        public DeleteContactRestrictSettingResponse DeleteContactRestrictSetting(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteContactRestrictSettingHeaders headers = new DeleteContactRestrictSettingHeaders();
            return DeleteContactRestrictSettingWithOptions(settingId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除限制查看通讯录设置</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteContactRestrictSettingResponse
        /// </returns>
        public async Task<DeleteContactRestrictSettingResponse> DeleteContactRestrictSettingAsync(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteContactRestrictSettingHeaders headers = new DeleteContactRestrictSettingHeaders();
            return await DeleteContactRestrictSettingWithOptionsAsync(settingId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除员工属性分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteEmpAttributeHideBySceneSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEmpAttributeHideBySceneSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除员工属性分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteEmpAttributeHideBySceneSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEmpAttributeHideBySceneSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除员工属性分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteEmpAttributeHideBySceneSettingResponse
        /// </returns>
        public DeleteEmpAttributeHideBySceneSettingResponse DeleteEmpAttributeHideBySceneSetting(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteEmpAttributeHideBySceneSettingHeaders headers = new DeleteEmpAttributeHideBySceneSettingHeaders();
            return DeleteEmpAttributeHideBySceneSettingWithOptions(settingId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除员工属性分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteEmpAttributeHideBySceneSettingResponse
        /// </returns>
        public async Task<DeleteEmpAttributeHideBySceneSettingResponse> DeleteEmpAttributeHideBySceneSettingAsync(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteEmpAttributeHideBySceneSettingHeaders headers = new DeleteEmpAttributeHideBySceneSettingHeaders();
            return await DeleteEmpAttributeHideBySceneSettingWithOptionsAsync(settingId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除员工字段可见性设置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteEmpAttributeVisibilityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEmpAttributeVisibilityResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除员工字段可见性设置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteEmpAttributeVisibilityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEmpAttributeVisibilityResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除员工字段可见性设置</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteEmpAttributeVisibilityResponse
        /// </returns>
        public DeleteEmpAttributeVisibilityResponse DeleteEmpAttributeVisibility(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteEmpAttributeVisibilityHeaders headers = new DeleteEmpAttributeVisibilityHeaders();
            return DeleteEmpAttributeVisibilityWithOptions(settingId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除员工字段可见性设置</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteEmpAttributeVisibilityResponse
        /// </returns>
        public async Task<DeleteEmpAttributeVisibilityResponse> DeleteEmpAttributeVisibilityAsync(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteEmpAttributeVisibilityHeaders headers = new DeleteEmpAttributeVisibilityHeaders();
            return await DeleteEmpAttributeVisibilityWithOptionsAsync(settingId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除管理组</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteManagementGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteManagementGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除管理组</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteManagementGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteManagementGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除管理组</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteManagementGroupResponse
        /// </returns>
        public DeleteManagementGroupResponse DeleteManagementGroup(string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteManagementGroupHeaders headers = new DeleteManagementGroupHeaders();
            return DeleteManagementGroupWithOptions(groupId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除管理组</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteManagementGroupResponse
        /// </returns>
        public async Task<DeleteManagementGroupResponse> DeleteManagementGroupAsync(string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteManagementGroupHeaders headers = new DeleteManagementGroupHeaders();
            return await DeleteManagementGroupWithOptionsAsync(groupId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取账号映射</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountMappingRequest
        /// </param>
        /// <param name="headers">
        /// GetAccountMappingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccountMappingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取账号映射</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountMappingRequest
        /// </param>
        /// <param name="headers">
        /// GetAccountMappingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccountMappingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取账号映射</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccountMappingResponse
        /// </returns>
        public GetAccountMappingResponse GetAccountMapping(GetAccountMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAccountMappingHeaders headers = new GetAccountMappingHeaders();
            return GetAccountMappingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取账号映射</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccountMappingResponse
        /// </returns>
        public async Task<GetAccountMappingResponse> GetAccountMappingAsync(GetAccountMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAccountMappingHeaders headers = new GetAccountMappingHeaders();
            return await GetAccountMappingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业的邀请信息，如果传部门ID则邀请链接为邀请加入部门，否则加入根部门；如果企业未开启邀请或者链接申请加入邀请链接为null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplyInviteInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetApplyInviteInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApplyInviteInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业的邀请信息，如果传部门ID则邀请链接为邀请加入部门，否则加入根部门；如果企业未开启邀请或者链接申请加入邀请链接为null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplyInviteInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetApplyInviteInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApplyInviteInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业的邀请信息，如果传部门ID则邀请链接为邀请加入部门，否则加入根部门；如果企业未开启邀请或者链接申请加入邀请链接为null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplyInviteInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApplyInviteInfoResponse
        /// </returns>
        public GetApplyInviteInfoResponse GetApplyInviteInfo(GetApplyInviteInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetApplyInviteInfoHeaders headers = new GetApplyInviteInfoHeaders();
            return GetApplyInviteInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业的邀请信息，如果传部门ID则邀请链接为邀请加入部门，否则加入根部门；如果企业未开启邀请或者链接申请加入邀请链接为null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplyInviteInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApplyInviteInfoResponse
        /// </returns>
        public async Task<GetApplyInviteInfoResponse> GetApplyInviteInfoAsync(GetApplyInviteInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetApplyInviteInfoHeaders headers = new GetApplyInviteInfoHeaders();
            return await GetApplyInviteInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分支授权主干的行业数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBranchAuthDataRequest
        /// </param>
        /// <param name="headers">
        /// GetBranchAuthDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBranchAuthDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分支授权主干的行业数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBranchAuthDataRequest
        /// </param>
        /// <param name="headers">
        /// GetBranchAuthDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBranchAuthDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分支授权主干的行业数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBranchAuthDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBranchAuthDataResponse
        /// </returns>
        public GetBranchAuthDataResponse GetBranchAuthData(GetBranchAuthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBranchAuthDataHeaders headers = new GetBranchAuthDataHeaders();
            return GetBranchAuthDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分支授权主干的行业数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBranchAuthDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBranchAuthDataResponse
        /// </returns>
        public async Task<GetBranchAuthDataResponse> GetBranchAuthDataAsync(GetBranchAuthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBranchAuthDataHeaders headers = new GetBranchAuthDataHeaders();
            return await GetBranchAuthDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户名片夹中的某张名片信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetCardInUserHolderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCardInUserHolderResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户名片夹中的某张名片信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetCardInUserHolderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCardInUserHolderResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户名片夹中的某张名片信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCardInUserHolderResponse
        /// </returns>
        public GetCardInUserHolderResponse GetCardInUserHolder(string cardId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCardInUserHolderHeaders headers = new GetCardInUserHolderHeaders();
            return GetCardInUserHolderWithOptions(cardId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户名片夹中的某张名片信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCardInUserHolderResponse
        /// </returns>
        public async Task<GetCardInUserHolderResponse> GetCardInUserHolderAsync(string cardId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCardInUserHolderHeaders headers = new GetCardInUserHolderHeaders();
            return await GetCardInUserHolderWithOptionsAsync(cardId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户名片信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetCardInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCardInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户名片信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetCardInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCardInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户名片信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCardInfoResponse
        /// </returns>
        public GetCardInfoResponse GetCardInfo(string cardId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCardInfoHeaders headers = new GetCardInfoHeaders();
            return GetCardInfoWithOptions(cardId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户名片信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCardInfoResponse
        /// </returns>
        public async Task<GetCardInfoResponse> GetCardInfoAsync(string cardId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCardInfoHeaders headers = new GetCardInfoHeaders();
            return await GetCardInfoWithOptionsAsync(cardId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取通讯录组织架构分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetContactHideBySceneSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContactHideBySceneSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取通讯录组织架构分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetContactHideBySceneSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContactHideBySceneSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取通讯录组织架构分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetContactHideBySceneSettingResponse
        /// </returns>
        public GetContactHideBySceneSettingResponse GetContactHideBySceneSetting(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetContactHideBySceneSettingHeaders headers = new GetContactHideBySceneSettingHeaders();
            return GetContactHideBySceneSettingWithOptions(settingId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取通讯录组织架构分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetContactHideBySceneSettingResponse
        /// </returns>
        public async Task<GetContactHideBySceneSettingResponse> GetContactHideBySceneSettingAsync(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetContactHideBySceneSettingHeaders headers = new GetContactHideBySceneSettingHeaders();
            return await GetContactHideBySceneSettingWithOptionsAsync(settingId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取邀请加入合作空间链接，分享链接之后企业可以申请加入</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetCooperateOrgInviteInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCooperateOrgInviteInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取邀请加入合作空间链接，分享链接之后企业可以申请加入</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetCooperateOrgInviteInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCooperateOrgInviteInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取邀请加入合作空间链接，分享链接之后企业可以申请加入</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCooperateOrgInviteInfoResponse
        /// </returns>
        public GetCooperateOrgInviteInfoResponse GetCooperateOrgInviteInfo(string cooperateCorpId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCooperateOrgInviteInfoHeaders headers = new GetCooperateOrgInviteInfoHeaders();
            return GetCooperateOrgInviteInfoWithOptions(cooperateCorpId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取邀请加入合作空间链接，分享链接之后企业可以申请加入</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCooperateOrgInviteInfoResponse
        /// </returns>
        public async Task<GetCooperateOrgInviteInfoResponse> GetCooperateOrgInviteInfoAsync(string cooperateCorpId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCooperateOrgInviteInfoHeaders headers = new GetCooperateOrgInviteInfoHeaders();
            return await GetCooperateOrgInviteInfoWithOptionsAsync(cooperateCorpId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业模板列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetCorpCardStyleListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCorpCardStyleListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业模板列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetCorpCardStyleListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCorpCardStyleListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业模板列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCorpCardStyleListResponse
        /// </returns>
        public GetCorpCardStyleListResponse GetCorpCardStyleList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpCardStyleListHeaders headers = new GetCorpCardStyleListHeaders();
            return GetCorpCardStyleListWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业模板列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCorpCardStyleListResponse
        /// </returns>
        public async Task<GetCorpCardStyleListResponse> GetCorpCardStyleListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpCardStyleListHeaders headers = new GetCorpCardStyleListHeaders();
            return await GetCorpCardStyleListWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号迁移为专属帐号后，根据迁移后的dingId查询原dingId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDingIdByMigrationDingIdRequest
        /// </param>
        /// <param name="headers">
        /// GetDingIdByMigrationDingIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDingIdByMigrationDingIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号迁移为专属帐号后，根据迁移后的dingId查询原dingId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDingIdByMigrationDingIdRequest
        /// </param>
        /// <param name="headers">
        /// GetDingIdByMigrationDingIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDingIdByMigrationDingIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号迁移为专属帐号后，根据迁移后的dingId查询原dingId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDingIdByMigrationDingIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDingIdByMigrationDingIdResponse
        /// </returns>
        public GetDingIdByMigrationDingIdResponse GetDingIdByMigrationDingId(GetDingIdByMigrationDingIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingIdByMigrationDingIdHeaders headers = new GetDingIdByMigrationDingIdHeaders();
            return GetDingIdByMigrationDingIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号迁移为专属帐号后，根据迁移后的dingId查询原dingId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDingIdByMigrationDingIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDingIdByMigrationDingIdResponse
        /// </returns>
        public async Task<GetDingIdByMigrationDingIdResponse> GetDingIdByMigrationDingIdAsync(GetDingIdByMigrationDingIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingIdByMigrationDingIdHeaders headers = new GetDingIdByMigrationDingIdHeaders();
            return await GetDingIdByMigrationDingIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取员工属性分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetEmpAttributeHideBySceneSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEmpAttributeHideBySceneSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取员工属性分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetEmpAttributeHideBySceneSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEmpAttributeHideBySceneSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取员工属性分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetEmpAttributeHideBySceneSettingResponse
        /// </returns>
        public GetEmpAttributeHideBySceneSettingResponse GetEmpAttributeHideBySceneSetting(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEmpAttributeHideBySceneSettingHeaders headers = new GetEmpAttributeHideBySceneSettingHeaders();
            return GetEmpAttributeHideBySceneSettingWithOptions(settingId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取员工属性分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetEmpAttributeHideBySceneSettingResponse
        /// </returns>
        public async Task<GetEmpAttributeHideBySceneSettingResponse> GetEmpAttributeHideBySceneSettingAsync(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEmpAttributeHideBySceneSettingHeaders headers = new GetEmpAttributeHideBySceneSettingHeaders();
            return await GetEmpAttributeHideBySceneSettingWithOptionsAsync(settingId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业最新的钉钉指数</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetLatestDingIndexHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLatestDingIndexResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业最新的钉钉指数</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetLatestDingIndexHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLatestDingIndexResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业最新的钉钉指数</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetLatestDingIndexResponse
        /// </returns>
        public GetLatestDingIndexResponse GetLatestDingIndex()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLatestDingIndexHeaders headers = new GetLatestDingIndexHeaders();
            return GetLatestDingIndexWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业最新的钉钉指数</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetLatestDingIndexResponse
        /// </returns>
        public async Task<GetLatestDingIndexResponse> GetLatestDingIndexAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLatestDingIndexHeaders headers = new GetLatestDingIndexHeaders();
            return await GetLatestDingIndexWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号迁移为专属帐号后，根据原dingId查询迁移后的dingId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMigrationDingIdByDingIdRequest
        /// </param>
        /// <param name="headers">
        /// GetMigrationDingIdByDingIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMigrationDingIdByDingIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号迁移为专属帐号后，根据原dingId查询迁移后的dingId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMigrationDingIdByDingIdRequest
        /// </param>
        /// <param name="headers">
        /// GetMigrationDingIdByDingIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMigrationDingIdByDingIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号迁移为专属帐号后，根据原dingId查询迁移后的dingId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMigrationDingIdByDingIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMigrationDingIdByDingIdResponse
        /// </returns>
        public GetMigrationDingIdByDingIdResponse GetMigrationDingIdByDingId(GetMigrationDingIdByDingIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMigrationDingIdByDingIdHeaders headers = new GetMigrationDingIdByDingIdHeaders();
            return GetMigrationDingIdByDingIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号迁移为专属帐号后，根据原dingId查询迁移后的dingId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMigrationDingIdByDingIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMigrationDingIdByDingIdResponse
        /// </returns>
        public async Task<GetMigrationDingIdByDingIdResponse> GetMigrationDingIdByDingIdAsync(GetMigrationDingIdByDingIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMigrationDingIdByDingIdHeaders headers = new GetMigrationDingIdByDingIdHeaders();
            return await GetMigrationDingIdByDingIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号迁移为专属帐号后，根据原unionId查询迁移后的unionId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMigrationUnionIdByUnionIdRequest
        /// </param>
        /// <param name="headers">
        /// GetMigrationUnionIdByUnionIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMigrationUnionIdByUnionIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号迁移为专属帐号后，根据原unionId查询迁移后的unionId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMigrationUnionIdByUnionIdRequest
        /// </param>
        /// <param name="headers">
        /// GetMigrationUnionIdByUnionIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMigrationUnionIdByUnionIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号迁移为专属帐号后，根据原unionId查询迁移后的unionId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMigrationUnionIdByUnionIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMigrationUnionIdByUnionIdResponse
        /// </returns>
        public GetMigrationUnionIdByUnionIdResponse GetMigrationUnionIdByUnionId(GetMigrationUnionIdByUnionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMigrationUnionIdByUnionIdHeaders headers = new GetMigrationUnionIdByUnionIdHeaders();
            return GetMigrationUnionIdByUnionIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号迁移为专属帐号后，根据原unionId查询迁移后的unionId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMigrationUnionIdByUnionIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMigrationUnionIdByUnionIdResponse
        /// </returns>
        public async Task<GetMigrationUnionIdByUnionIdResponse> GetMigrationUnionIdByUnionIdAsync(GetMigrationUnionIdByUnionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMigrationUnionIdByUnionIdHeaders headers = new GetMigrationUnionIdByUnionIdHeaders();
            return await GetMigrationUnionIdByUnionIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrgAuthInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetOrgAuthInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrgAuthInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrgAuthInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetOrgAuthInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrgAuthInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrgAuthInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrgAuthInfoResponse
        /// </returns>
        public GetOrgAuthInfoResponse GetOrgAuthInfo(GetOrgAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrgAuthInfoHeaders headers = new GetOrgAuthInfoHeaders();
            return GetOrgAuthInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrgAuthInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrgAuthInfoResponse
        /// </returns>
        public async Task<GetOrgAuthInfoResponse> GetOrgAuthInfoAsync(GetOrgAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrgAuthInfoHeaders headers = new GetOrgAuthInfoHeaders();
            return await GetOrgAuthInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步文件内容转译结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTranslateFileJobResultRequest
        /// </param>
        /// <param name="headers">
        /// GetTranslateFileJobResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTranslateFileJobResultResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步文件内容转译结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTranslateFileJobResultRequest
        /// </param>
        /// <param name="headers">
        /// GetTranslateFileJobResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTranslateFileJobResultResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步文件内容转译结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTranslateFileJobResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTranslateFileJobResultResponse
        /// </returns>
        public GetTranslateFileJobResultResponse GetTranslateFileJobResult(GetTranslateFileJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTranslateFileJobResultHeaders headers = new GetTranslateFileJobResultHeaders();
            return GetTranslateFileJobResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步文件内容转译结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTranslateFileJobResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTranslateFileJobResultResponse
        /// </returns>
        public async Task<GetTranslateFileJobResultResponse> GetTranslateFileJobResultAsync(GetTranslateFileJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTranslateFileJobResultHeaders headers = new GetTranslateFileJobResultHeaders();
            return await GetTranslateFileJobResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号迁移为专属帐号后，根据迁移后的unionId查询原unionId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUnionIdByMigrationUnionIdRequest
        /// </param>
        /// <param name="headers">
        /// GetUnionIdByMigrationUnionIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUnionIdByMigrationUnionIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号迁移为专属帐号后，根据迁移后的unionId查询原unionId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUnionIdByMigrationUnionIdRequest
        /// </param>
        /// <param name="headers">
        /// GetUnionIdByMigrationUnionIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUnionIdByMigrationUnionIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号迁移为专属帐号后，根据迁移后的unionId查询原unionId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUnionIdByMigrationUnionIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUnionIdByMigrationUnionIdResponse
        /// </returns>
        public GetUnionIdByMigrationUnionIdResponse GetUnionIdByMigrationUnionId(GetUnionIdByMigrationUnionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUnionIdByMigrationUnionIdHeaders headers = new GetUnionIdByMigrationUnionIdHeaders();
            return GetUnionIdByMigrationUnionIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号迁移为专属帐号后，根据迁移后的unionId查询原unionId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUnionIdByMigrationUnionIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUnionIdByMigrationUnionIdResponse
        /// </returns>
        public async Task<GetUnionIdByMigrationUnionIdResponse> GetUnionIdByMigrationUnionIdAsync(GetUnionIdByMigrationUnionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUnionIdByMigrationUnionIdHeaders headers = new GetUnionIdByMigrationUnionIdHeaders();
            return await GetUnionIdByMigrationUnionIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户个人信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
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
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户个人信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
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
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户个人信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public GetUserResponse GetUser(string unionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHeaders headers = new GetUserHeaders();
            return GetUserWithOptions(unionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户个人信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public async Task<GetUserResponse> GetUserAsync(string unionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHeaders headers = new GetUserHeaders();
            return await GetUserWithOptionsAsync(unionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户名片夹信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserCardHolderListRequest
        /// </param>
        /// <param name="headers">
        /// GetUserCardHolderListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserCardHolderListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户名片夹信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserCardHolderListRequest
        /// </param>
        /// <param name="headers">
        /// GetUserCardHolderListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserCardHolderListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户名片夹信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserCardHolderListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserCardHolderListResponse
        /// </returns>
        public GetUserCardHolderListResponse GetUserCardHolderList(GetUserCardHolderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserCardHolderListHeaders headers = new GetUserCardHolderListHeaders();
            return GetUserCardHolderListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户名片夹信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserCardHolderListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserCardHolderListResponse
        /// </returns>
        public async Task<GetUserCardHolderListResponse> GetUserCardHolderListAsync(GetUserCardHolderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserCardHolderListHeaders headers = new GetUserCardHolderListHeaders();
            return await GetUserCardHolderListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>初始化核身事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitVerifyEventRequest
        /// </param>
        /// <param name="headers">
        /// InitVerifyEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitVerifyEventResponse
        /// </returns>
        public InitVerifyEventResponse InitVerifyEventWithOptions(InitVerifyEventRequest request, InitVerifyEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerDeviceId))
            {
                body["callerDeviceId"] = request.CallerDeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactorCodeList))
            {
                body["factorCodeList"] = request.FactorCodeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                body["state"] = request.State;
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
                Action = "InitVerifyEvent",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/verifyIdentities/verifyEvents/init",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitVerifyEventResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>初始化核身事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitVerifyEventRequest
        /// </param>
        /// <param name="headers">
        /// InitVerifyEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitVerifyEventResponse
        /// </returns>
        public async Task<InitVerifyEventResponse> InitVerifyEventWithOptionsAsync(InitVerifyEventRequest request, InitVerifyEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerDeviceId))
            {
                body["callerDeviceId"] = request.CallerDeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactorCodeList))
            {
                body["factorCodeList"] = request.FactorCodeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                body["state"] = request.State;
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
                Action = "InitVerifyEvent",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/verifyIdentities/verifyEvents/init",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitVerifyEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>初始化核身事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitVerifyEventRequest
        /// </param>
        /// 
        /// <returns>
        /// InitVerifyEventResponse
        /// </returns>
        public InitVerifyEventResponse InitVerifyEvent(InitVerifyEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InitVerifyEventHeaders headers = new InitVerifyEventHeaders();
            return InitVerifyEventWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>初始化核身事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitVerifyEventRequest
        /// </param>
        /// 
        /// <returns>
        /// InitVerifyEventResponse
        /// </returns>
        public async Task<InitVerifyEventResponse> InitVerifyEventAsync(InitVerifyEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InitVerifyEventHeaders headers = new InitVerifyEventHeaders();
            return await InitVerifyEventWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>判断某用户跟给定专属账号是否存在好友关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IsFriendRequest
        /// </param>
        /// <param name="headers">
        /// IsFriendHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IsFriendResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>判断某用户跟给定专属账号是否存在好友关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IsFriendRequest
        /// </param>
        /// <param name="headers">
        /// IsFriendHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IsFriendResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>判断某用户跟给定专属账号是否存在好友关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IsFriendRequest
        /// </param>
        /// 
        /// <returns>
        /// IsFriendResponse
        /// </returns>
        public IsFriendResponse IsFriend(IsFriendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IsFriendHeaders headers = new IsFriendHeaders();
            return IsFriendWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>判断某用户跟给定专属账号是否存在好友关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IsFriendRequest
        /// </param>
        /// 
        /// <returns>
        /// IsFriendResponse
        /// </returns>
        public async Task<IsFriendResponse> IsFriendAsync(IsFriendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IsFriendHeaders headers = new IsFriendHeaders();
            return await IsFriendWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>名片事件推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IsvCardEventPushRequest
        /// </param>
        /// <param name="headers">
        /// IsvCardEventPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IsvCardEventPushResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>名片事件推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IsvCardEventPushRequest
        /// </param>
        /// <param name="headers">
        /// IsvCardEventPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IsvCardEventPushResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>名片事件推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IsvCardEventPushRequest
        /// </param>
        /// 
        /// <returns>
        /// IsvCardEventPushResponse
        /// </returns>
        public IsvCardEventPushResponse IsvCardEventPush(IsvCardEventPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IsvCardEventPushHeaders headers = new IsvCardEventPushHeaders();
            return IsvCardEventPushWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>名片事件推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IsvCardEventPushRequest
        /// </param>
        /// 
        /// <returns>
        /// IsvCardEventPushResponse
        /// </returns>
        public async Task<IsvCardEventPushResponse> IsvCardEventPushAsync(IsvCardEventPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IsvCardEventPushHeaders headers = new IsvCardEventPushHeaders();
            return await IsvCardEventPushWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉取管理组基本信息列表分页接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBasicRoleInPageRequest
        /// </param>
        /// <param name="headers">
        /// ListBasicRoleInPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBasicRoleInPageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉取管理组基本信息列表分页接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBasicRoleInPageRequest
        /// </param>
        /// <param name="headers">
        /// ListBasicRoleInPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBasicRoleInPageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉取管理组基本信息列表分页接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBasicRoleInPageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBasicRoleInPageResponse
        /// </returns>
        public ListBasicRoleInPageResponse ListBasicRoleInPage(ListBasicRoleInPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListBasicRoleInPageHeaders headers = new ListBasicRoleInPageHeaders();
            return ListBasicRoleInPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉取管理组基本信息列表分页接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBasicRoleInPageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBasicRoleInPageResponse
        /// </returns>
        public async Task<ListBasicRoleInPageResponse> ListBasicRoleInPageAsync(ListBasicRoleInPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListBasicRoleInPageHeaders headers = new ListBasicRoleInPageHeaders();
            return await ListBasicRoleInPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取通讯录隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContactHideSettingsRequest
        /// </param>
        /// <param name="headers">
        /// ListContactHideSettingsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContactHideSettingsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取通讯录隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContactHideSettingsRequest
        /// </param>
        /// <param name="headers">
        /// ListContactHideSettingsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContactHideSettingsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取通讯录隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContactHideSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContactHideSettingsResponse
        /// </returns>
        public ListContactHideSettingsResponse ListContactHideSettings(ListContactHideSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListContactHideSettingsHeaders headers = new ListContactHideSettingsHeaders();
            return ListContactHideSettingsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取通讯录隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContactHideSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContactHideSettingsResponse
        /// </returns>
        public async Task<ListContactHideSettingsResponse> ListContactHideSettingsAsync(ListContactHideSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListContactHideSettingsHeaders headers = new ListContactHideSettingsHeaders();
            return await ListContactHideSettingsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取限制查看通讯录设置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContactRestrictSettingRequest
        /// </param>
        /// <param name="headers">
        /// ListContactRestrictSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContactRestrictSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取限制查看通讯录设置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContactRestrictSettingRequest
        /// </param>
        /// <param name="headers">
        /// ListContactRestrictSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContactRestrictSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取限制查看通讯录设置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContactRestrictSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContactRestrictSettingResponse
        /// </returns>
        public ListContactRestrictSettingResponse ListContactRestrictSetting(ListContactRestrictSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListContactRestrictSettingHeaders headers = new ListContactRestrictSettingHeaders();
            return ListContactRestrictSettingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取限制查看通讯录设置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContactRestrictSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContactRestrictSettingResponse
        /// </returns>
        public async Task<ListContactRestrictSettingResponse> ListContactRestrictSettingAsync(ListContactRestrictSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListContactRestrictSettingHeaders headers = new ListContactRestrictSettingHeaders();
            return await ListContactRestrictSettingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取员工字段可见性设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEmpAttributeVisibilityRequest
        /// </param>
        /// <param name="headers">
        /// ListEmpAttributeVisibilityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEmpAttributeVisibilityResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取员工字段可见性设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEmpAttributeVisibilityRequest
        /// </param>
        /// <param name="headers">
        /// ListEmpAttributeVisibilityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEmpAttributeVisibilityResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取员工字段可见性设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEmpAttributeVisibilityRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEmpAttributeVisibilityResponse
        /// </returns>
        public ListEmpAttributeVisibilityResponse ListEmpAttributeVisibility(ListEmpAttributeVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEmpAttributeVisibilityHeaders headers = new ListEmpAttributeVisibilityHeaders();
            return ListEmpAttributeVisibilityWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取员工字段可见性设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEmpAttributeVisibilityRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEmpAttributeVisibilityResponse
        /// </returns>
        public async Task<ListEmpAttributeVisibilityResponse> ListEmpAttributeVisibilityAsync(ListEmpAttributeVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEmpAttributeVisibilityHeaders headers = new ListEmpAttributeVisibilityHeaders();
            return await ListEmpAttributeVisibilityWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询离职记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEmpLeaveRecordsRequest
        /// </param>
        /// <param name="headers">
        /// ListEmpLeaveRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEmpLeaveRecordsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询离职记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEmpLeaveRecordsRequest
        /// </param>
        /// <param name="headers">
        /// ListEmpLeaveRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEmpLeaveRecordsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询离职记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEmpLeaveRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEmpLeaveRecordsResponse
        /// </returns>
        public ListEmpLeaveRecordsResponse ListEmpLeaveRecords(ListEmpLeaveRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEmpLeaveRecordsHeaders headers = new ListEmpLeaveRecordsHeaders();
            return ListEmpLeaveRecordsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询离职记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEmpLeaveRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEmpLeaveRecordsResponse
        /// </returns>
        public async Task<ListEmpLeaveRecordsResponse> ListEmpLeaveRecordsAsync(ListEmpLeaveRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEmpLeaveRecordsHeaders headers = new ListEmpLeaveRecordsHeaders();
            return await ListEmpLeaveRecordsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询管理组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListManagementGroupsRequest
        /// </param>
        /// <param name="headers">
        /// ListManagementGroupsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListManagementGroupsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询管理组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListManagementGroupsRequest
        /// </param>
        /// <param name="headers">
        /// ListManagementGroupsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListManagementGroupsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询管理组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListManagementGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListManagementGroupsResponse
        /// </returns>
        public ListManagementGroupsResponse ListManagementGroups(ListManagementGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListManagementGroupsHeaders headers = new ListManagementGroupsHeaders();
            return ListManagementGroupsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询管理组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListManagementGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListManagementGroupsResponse
        /// </returns>
        public async Task<ListManagementGroupsResponse> ListManagementGroupsAsync(ListManagementGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListManagementGroupsHeaders headers = new ListManagementGroupsHeaders();
            return await ListManagementGroupsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询专属帐号拥有的组织(作为创建者的组织)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOwnedOrgByStaffIdRequest
        /// </param>
        /// <param name="headers">
        /// ListOwnedOrgByStaffIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOwnedOrgByStaffIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询专属帐号拥有的组织(作为创建者的组织)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOwnedOrgByStaffIdRequest
        /// </param>
        /// <param name="headers">
        /// ListOwnedOrgByStaffIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOwnedOrgByStaffIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询专属帐号拥有的组织(作为创建者的组织)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOwnedOrgByStaffIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOwnedOrgByStaffIdResponse
        /// </returns>
        public ListOwnedOrgByStaffIdResponse ListOwnedOrgByStaffId(ListOwnedOrgByStaffIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOwnedOrgByStaffIdHeaders headers = new ListOwnedOrgByStaffIdHeaders();
            return ListOwnedOrgByStaffIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询专属帐号拥有的组织(作为创建者的组织)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOwnedOrgByStaffIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOwnedOrgByStaffIdResponse
        /// </returns>
        public async Task<ListOwnedOrgByStaffIdResponse> ListOwnedOrgByStaffIdAsync(ListOwnedOrgByStaffIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOwnedOrgByStaffIdHeaders headers = new ListOwnedOrgByStaffIdHeaders();
            return await ListOwnedOrgByStaffIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取员工高管设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSeniorSettingsRequest
        /// </param>
        /// <param name="headers">
        /// ListSeniorSettingsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSeniorSettingsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取员工高管设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSeniorSettingsRequest
        /// </param>
        /// <param name="headers">
        /// ListSeniorSettingsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSeniorSettingsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取员工高管设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSeniorSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSeniorSettingsResponse
        /// </returns>
        public ListSeniorSettingsResponse ListSeniorSettings(ListSeniorSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSeniorSettingsHeaders headers = new ListSeniorSettingsHeaders();
            return ListSeniorSettingsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取员工高管设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSeniorSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSeniorSettingsResponse
        /// </returns>
        public async Task<ListSeniorSettingsResponse> ListSeniorSettingsAsync(ListSeniorSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSeniorSettingsHeaders headers = new ListSeniorSettingsHeaders();
            return await ListSeniorSettingsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新企业账号工作状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyOrgAccUserOwnnessRequest
        /// </param>
        /// <param name="headers">
        /// ModifyOrgAccUserOwnnessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyOrgAccUserOwnnessResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新企业账号工作状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyOrgAccUserOwnnessRequest
        /// </param>
        /// <param name="headers">
        /// ModifyOrgAccUserOwnnessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyOrgAccUserOwnnessResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新企业账号工作状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyOrgAccUserOwnnessRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyOrgAccUserOwnnessResponse
        /// </returns>
        public ModifyOrgAccUserOwnnessResponse ModifyOrgAccUserOwnness(ModifyOrgAccUserOwnnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifyOrgAccUserOwnnessHeaders headers = new ModifyOrgAccUserOwnnessHeaders();
            return ModifyOrgAccUserOwnnessWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新企业账号工作状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyOrgAccUserOwnnessRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyOrgAccUserOwnnessResponse
        /// </returns>
        public async Task<ModifyOrgAccUserOwnnessResponse> ModifyOrgAccUserOwnnessAsync(ModifyOrgAccUserOwnnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifyOrgAccUserOwnnessHeaders headers = new ModifyOrgAccUserOwnnessHeaders();
            return await ModifyOrgAccUserOwnnessWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权专属帐号可加入多组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiOrgPermissionGrantRequest
        /// </param>
        /// <param name="headers">
        /// MultiOrgPermissionGrantHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultiOrgPermissionGrantResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权专属帐号可加入多组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiOrgPermissionGrantRequest
        /// </param>
        /// <param name="headers">
        /// MultiOrgPermissionGrantHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultiOrgPermissionGrantResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权专属帐号可加入多组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiOrgPermissionGrantRequest
        /// </param>
        /// 
        /// <returns>
        /// MultiOrgPermissionGrantResponse
        /// </returns>
        public MultiOrgPermissionGrantResponse MultiOrgPermissionGrant(MultiOrgPermissionGrantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MultiOrgPermissionGrantHeaders headers = new MultiOrgPermissionGrantHeaders();
            return MultiOrgPermissionGrantWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权专属帐号可加入多组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiOrgPermissionGrantRequest
        /// </param>
        /// 
        /// <returns>
        /// MultiOrgPermissionGrantResponse
        /// </returns>
        public async Task<MultiOrgPermissionGrantResponse> MultiOrgPermissionGrantAsync(MultiOrgPermissionGrantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MultiOrgPermissionGrantHeaders headers = new MultiOrgPermissionGrantHeaders();
            return await MultiOrgPermissionGrantWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权其他组织查看本组织的企业账号信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgAccountMobileVisibleInOtherOrgRequest
        /// </param>
        /// <param name="headers">
        /// OrgAccountMobileVisibleInOtherOrgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OrgAccountMobileVisibleInOtherOrgResponse
        /// </returns>
        public OrgAccountMobileVisibleInOtherOrgResponse OrgAccountMobileVisibleInOtherOrgWithOptions(OrgAccountMobileVisibleInOtherOrgRequest request, OrgAccountMobileVisibleInOtherOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                body["optUserId"] = request.OptUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToCorpIds))
            {
                body["toCorpIds"] = request.ToCorpIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "OrgAccountMobileVisibleInOtherOrg",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/mobiles/visibleInOtherOrg",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrgAccountMobileVisibleInOtherOrgResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权其他组织查看本组织的企业账号信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgAccountMobileVisibleInOtherOrgRequest
        /// </param>
        /// <param name="headers">
        /// OrgAccountMobileVisibleInOtherOrgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OrgAccountMobileVisibleInOtherOrgResponse
        /// </returns>
        public async Task<OrgAccountMobileVisibleInOtherOrgResponse> OrgAccountMobileVisibleInOtherOrgWithOptionsAsync(OrgAccountMobileVisibleInOtherOrgRequest request, OrgAccountMobileVisibleInOtherOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                body["optUserId"] = request.OptUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToCorpIds))
            {
                body["toCorpIds"] = request.ToCorpIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "OrgAccountMobileVisibleInOtherOrg",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/mobiles/visibleInOtherOrg",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrgAccountMobileVisibleInOtherOrgResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权其他组织查看本组织的企业账号信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgAccountMobileVisibleInOtherOrgRequest
        /// </param>
        /// 
        /// <returns>
        /// OrgAccountMobileVisibleInOtherOrgResponse
        /// </returns>
        public OrgAccountMobileVisibleInOtherOrgResponse OrgAccountMobileVisibleInOtherOrg(OrgAccountMobileVisibleInOtherOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrgAccountMobileVisibleInOtherOrgHeaders headers = new OrgAccountMobileVisibleInOtherOrgHeaders();
            return OrgAccountMobileVisibleInOtherOrgWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权其他组织查看本组织的企业账号信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgAccountMobileVisibleInOtherOrgRequest
        /// </param>
        /// 
        /// <returns>
        /// OrgAccountMobileVisibleInOtherOrgResponse
        /// </returns>
        public async Task<OrgAccountMobileVisibleInOtherOrgResponse> OrgAccountMobileVisibleInOtherOrgAsync(OrgAccountMobileVisibleInOtherOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrgAccountMobileVisibleInOtherOrgHeaders headers = new OrgAccountMobileVisibleInOtherOrgHeaders();
            return await OrgAccountMobileVisibleInOtherOrgWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新企业账号电话可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgAccountMobileVisiblePermissonRequest
        /// </param>
        /// <param name="headers">
        /// OrgAccountMobileVisiblePermissonHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OrgAccountMobileVisiblePermissonResponse
        /// </returns>
        public OrgAccountMobileVisiblePermissonResponse OrgAccountMobileVisiblePermissonWithOptions(OrgAccountMobileVisiblePermissonRequest request, OrgAccountMobileVisiblePermissonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OrgAccountMobileVisiblePermisson",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/mobiles/visiblePermissions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrgAccountMobileVisiblePermissonResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新企业账号电话可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgAccountMobileVisiblePermissonRequest
        /// </param>
        /// <param name="headers">
        /// OrgAccountMobileVisiblePermissonHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OrgAccountMobileVisiblePermissonResponse
        /// </returns>
        public async Task<OrgAccountMobileVisiblePermissonResponse> OrgAccountMobileVisiblePermissonWithOptionsAsync(OrgAccountMobileVisiblePermissonRequest request, OrgAccountMobileVisiblePermissonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OrgAccountMobileVisiblePermisson",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/orgAccounts/mobiles/visiblePermissions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrgAccountMobileVisiblePermissonResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新企业账号电话可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgAccountMobileVisiblePermissonRequest
        /// </param>
        /// 
        /// <returns>
        /// OrgAccountMobileVisiblePermissonResponse
        /// </returns>
        public OrgAccountMobileVisiblePermissonResponse OrgAccountMobileVisiblePermisson(OrgAccountMobileVisiblePermissonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrgAccountMobileVisiblePermissonHeaders headers = new OrgAccountMobileVisiblePermissonHeaders();
            return OrgAccountMobileVisiblePermissonWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新企业账号电话可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrgAccountMobileVisiblePermissonRequest
        /// </param>
        /// 
        /// <returns>
        /// OrgAccountMobileVisiblePermissonResponse
        /// </returns>
        public async Task<OrgAccountMobileVisiblePermissonResponse> OrgAccountMobileVisiblePermissonAsync(OrgAccountMobileVisiblePermissonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrgAccountMobileVisiblePermissonHeaders headers = new OrgAccountMobileVisiblePermissonHeaders();
            return await OrgAccountMobileVisiblePermissonWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>给员工推送事件唤起核身组件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushVerifyEventRequest
        /// </param>
        /// <param name="headers">
        /// PushVerifyEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushVerifyEventResponse
        /// </returns>
        public PushVerifyEventResponse PushVerifyEventWithOptions(PushVerifyEventRequest request, PushVerifyEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerDeviceId))
            {
                body["callerDeviceId"] = request.CallerDeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactorCodeList))
            {
                body["factorCodeList"] = request.FactorCodeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                body["state"] = request.State;
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
                Action = "PushVerifyEvent",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/verifyIdentities/verifyEvents/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushVerifyEventResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>给员工推送事件唤起核身组件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushVerifyEventRequest
        /// </param>
        /// <param name="headers">
        /// PushVerifyEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushVerifyEventResponse
        /// </returns>
        public async Task<PushVerifyEventResponse> PushVerifyEventWithOptionsAsync(PushVerifyEventRequest request, PushVerifyEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerDeviceId))
            {
                body["callerDeviceId"] = request.CallerDeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactorCodeList))
            {
                body["factorCodeList"] = request.FactorCodeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                body["state"] = request.State;
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
                Action = "PushVerifyEvent",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/verifyIdentities/verifyEvents/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushVerifyEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>给员工推送事件唤起核身组件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushVerifyEventRequest
        /// </param>
        /// 
        /// <returns>
        /// PushVerifyEventResponse
        /// </returns>
        public PushVerifyEventResponse PushVerifyEvent(PushVerifyEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushVerifyEventHeaders headers = new PushVerifyEventHeaders();
            return PushVerifyEventWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>给员工推送事件唤起核身组件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushVerifyEventRequest
        /// </param>
        /// 
        /// <returns>
        /// PushVerifyEventResponse
        /// </returns>
        public async Task<PushVerifyEventResponse> PushVerifyEventAsync(PushVerifyEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushVerifyEventHeaders headers = new PushVerifyEventHeaders();
            return await PushVerifyEventWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询访客统计信息信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCardVisitorStatisticDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryCardVisitorStatisticDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCardVisitorStatisticDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询访客统计信息信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCardVisitorStatisticDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryCardVisitorStatisticDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCardVisitorStatisticDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询访客统计信息信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCardVisitorStatisticDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCardVisitorStatisticDataResponse
        /// </returns>
        public QueryCardVisitorStatisticDataResponse QueryCardVisitorStatisticData(QueryCardVisitorStatisticDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCardVisitorStatisticDataHeaders headers = new QueryCardVisitorStatisticDataHeaders();
            return QueryCardVisitorStatisticDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询访客统计信息信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCardVisitorStatisticDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCardVisitorStatisticDataResponse
        /// </returns>
        public async Task<QueryCardVisitorStatisticDataResponse> QueryCardVisitorStatisticDataAsync(QueryCardVisitorStatisticDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCardVisitorStatisticDataHeaders headers = new QueryCardVisitorStatisticDataHeaders();
            return await QueryCardVisitorStatisticDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业模版的统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCorpStatisticDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryCorpStatisticDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCorpStatisticDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业模版的统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCorpStatisticDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryCorpStatisticDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCorpStatisticDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业模版的统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCorpStatisticDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCorpStatisticDataResponse
        /// </returns>
        public QueryCorpStatisticDataResponse QueryCorpStatisticData(QueryCorpStatisticDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCorpStatisticDataHeaders headers = new QueryCorpStatisticDataHeaders();
            return QueryCorpStatisticDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业模版的统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCorpStatisticDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCorpStatisticDataResponse
        /// </returns>
        public async Task<QueryCorpStatisticDataResponse> QueryCorpStatisticDataAsync(QueryCorpStatisticDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCorpStatisticDataHeaders headers = new QueryCorpStatisticDataHeaders();
            return await QueryCorpStatisticDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业用户名片统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCorpUserStatisticRequest
        /// </param>
        /// <param name="headers">
        /// QueryCorpUserStatisticHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCorpUserStatisticResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业用户名片统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCorpUserStatisticRequest
        /// </param>
        /// <param name="headers">
        /// QueryCorpUserStatisticHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCorpUserStatisticResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业用户名片统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCorpUserStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCorpUserStatisticResponse
        /// </returns>
        public QueryCorpUserStatisticResponse QueryCorpUserStatistic(QueryCorpUserStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCorpUserStatisticHeaders headers = new QueryCorpUserStatisticHeaders();
            return QueryCorpUserStatisticWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业用户名片统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCorpUserStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCorpUserStatisticResponse
        /// </returns>
        public async Task<QueryCorpUserStatisticResponse> QueryCorpUserStatisticAsync(QueryCorpUserStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCorpUserStatisticHeaders headers = new QueryCorpUserStatisticHeaders();
            return await QueryCorpUserStatisticWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询可管理资源的成员</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryResourceManagementMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryResourceManagementMembersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询可管理资源的成员</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryResourceManagementMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryResourceManagementMembersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询可管理资源的成员</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryResourceManagementMembersResponse
        /// </returns>
        public QueryResourceManagementMembersResponse QueryResourceManagementMembers(string resourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryResourceManagementMembersHeaders headers = new QueryResourceManagementMembersHeaders();
            return QueryResourceManagementMembersWithOptions(resourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询可管理资源的成员</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryResourceManagementMembersResponse
        /// </returns>
        public async Task<QueryResourceManagementMembersResponse> QueryResourceManagementMembersAsync(string resourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryResourceManagementMembersHeaders headers = new QueryResourceManagementMembersHeaders();
            return await QueryResourceManagementMembersWithOptionsAsync(resourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询专属帐号状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询专属帐号状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询专属帐号状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryStatusResponse
        /// </returns>
        public QueryStatusResponse QueryStatus(QueryStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryStatusHeaders headers = new QueryStatusHeaders();
            return QueryStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询专属帐号状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryStatusResponse
        /// </returns>
        public async Task<QueryStatusResponse> QueryStatusAsync(QueryStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryStatusHeaders headers = new QueryStatusHeaders();
            return await QueryStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户可以管理的资源</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryUserManagementResourcesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUserManagementResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户可以管理的资源</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryUserManagementResourcesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUserManagementResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户可以管理的资源</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryUserManagementResourcesResponse
        /// </returns>
        public QueryUserManagementResourcesResponse QueryUserManagementResources(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserManagementResourcesHeaders headers = new QueryUserManagementResourcesHeaders();
            return QueryUserManagementResourcesWithOptions(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户可以管理的资源</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryUserManagementResourcesResponse
        /// </returns>
        public async Task<QueryUserManagementResourcesResponse> QueryUserManagementResourcesAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserManagementResourcesHeaders headers = new QueryUserManagementResourcesHeaders();
            return await QueryUserManagementResourcesWithOptionsAsync(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>读取员工核身结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVerifyResultRequest
        /// </param>
        /// <param name="headers">
        /// QueryVerifyResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryVerifyResultResponse
        /// </returns>
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
                Pathname = "/v1.0/contact/verifyIdentities/verifyResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVerifyResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>读取员工核身结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVerifyResultRequest
        /// </param>
        /// <param name="headers">
        /// QueryVerifyResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryVerifyResultResponse
        /// </returns>
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
                Pathname = "/v1.0/contact/verifyIdentities/verifyResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVerifyResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>读取员工核身结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVerifyResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryVerifyResultResponse
        /// </returns>
        public QueryVerifyResultResponse QueryVerifyResult(QueryVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryVerifyResultHeaders headers = new QueryVerifyResultHeaders();
            return QueryVerifyResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>读取员工核身结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVerifyResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryVerifyResultResponse
        /// </returns>
        public async Task<QueryVerifyResultResponse> QueryVerifyResultAsync(QueryVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryVerifyResultHeaders headers = new QueryVerifyResultHeaders();
            return await QueryVerifyResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchDepartmentRequest
        /// </param>
        /// <param name="headers">
        /// SearchDepartmentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchDepartmentResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchDepartmentRequest
        /// </param>
        /// <param name="headers">
        /// SearchDepartmentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchDepartmentResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchDepartmentResponse
        /// </returns>
        public SearchDepartmentResponse SearchDepartment(SearchDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchDepartmentHeaders headers = new SearchDepartmentHeaders();
            return SearchDepartmentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchDepartmentResponse
        /// </returns>
        public async Task<SearchDepartmentResponse> SearchDepartmentAsync(SearchDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchDepartmentHeaders headers = new SearchDepartmentHeaders();
            return await SearchDepartmentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchUserRequest
        /// </param>
        /// <param name="headers">
        /// SearchUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchUserResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchUserRequest
        /// </param>
        /// <param name="headers">
        /// SearchUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchUserResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchUserRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchUserResponse
        /// </returns>
        public SearchUserResponse SearchUser(SearchUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchUserHeaders headers = new SearchUserHeaders();
            return SearchUserWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchUserRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchUserResponse
        /// </returns>
        public async Task<SearchUserResponse> SearchUserAsync(SearchUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchUserHeaders headers = new SearchUserHeaders();
            return await SearchUserWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解除关联组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SeparateBranchOrgRequest
        /// </param>
        /// <param name="headers">
        /// SeparateBranchOrgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SeparateBranchOrgResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解除关联组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SeparateBranchOrgRequest
        /// </param>
        /// <param name="headers">
        /// SeparateBranchOrgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SeparateBranchOrgResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解除关联组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SeparateBranchOrgRequest
        /// </param>
        /// 
        /// <returns>
        /// SeparateBranchOrgResponse
        /// </returns>
        public SeparateBranchOrgResponse SeparateBranchOrg(SeparateBranchOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SeparateBranchOrgHeaders headers = new SeparateBranchOrgHeaders();
            return SeparateBranchOrgWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解除关联组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SeparateBranchOrgRequest
        /// </param>
        /// 
        /// <returns>
        /// SeparateBranchOrgResponse
        /// </returns>
        public async Task<SeparateBranchOrgResponse> SeparateBranchOrgAsync(SeparateBranchOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SeparateBranchOrgHeaders headers = new SeparateBranchOrgHeaders();
            return await SeparateBranchOrgWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停用专属帐号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDisableRequest
        /// </param>
        /// <param name="headers">
        /// SetDisableHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDisableResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停用专属帐号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDisableRequest
        /// </param>
        /// <param name="headers">
        /// SetDisableHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDisableResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停用专属帐号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDisableRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDisableResponse
        /// </returns>
        public SetDisableResponse SetDisable(SetDisableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDisableHeaders headers = new SetDisableHeaders();
            return SetDisableWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停用专属帐号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDisableRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDisableResponse
        /// </returns>
        public async Task<SetDisableResponse> SetDisableAsync(SetDisableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDisableHeaders headers = new SetDisableHeaders();
            return await SetDisableWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启用专属帐号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetEnableRequest
        /// </param>
        /// <param name="headers">
        /// SetEnableHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetEnableResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启用专属帐号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetEnableRequest
        /// </param>
        /// <param name="headers">
        /// SetEnableHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetEnableResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启用专属帐号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetEnableRequest
        /// </param>
        /// 
        /// <returns>
        /// SetEnableResponse
        /// </returns>
        public SetEnableResponse SetEnable(SetEnableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetEnableHeaders headers = new SetEnableHeaders();
            return SetEnableWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启用专属帐号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetEnableRequest
        /// </param>
        /// 
        /// <returns>
        /// SetEnableResponse
        /// </returns>
        public async Task<SetEnableResponse> SetEnableAsync(SetEnableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetEnableHeaders headers = new SetEnableHeaders();
            return await SetEnableWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>强制登出专属帐号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SignOutRequest
        /// </param>
        /// <param name="headers">
        /// SignOutHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SignOutResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>强制登出专属帐号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SignOutRequest
        /// </param>
        /// <param name="headers">
        /// SignOutHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SignOutResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>强制登出专属帐号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SignOutRequest
        /// </param>
        /// 
        /// <returns>
        /// SignOutResponse
        /// </returns>
        public SignOutResponse SignOut(SignOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SignOutHeaders headers = new SignOutHeaders();
            return SignOutWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>强制登出专属帐号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SignOutRequest
        /// </param>
        /// 
        /// <returns>
        /// SignOutResponse
        /// </returns>
        public async Task<SignOutResponse> SignOutAsync(SignOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SignOutHeaders headers = new SignOutHeaders();
            return await SignOutWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据用户名排序</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SortUserRequest
        /// </param>
        /// <param name="headers">
        /// SortUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SortUserResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据用户名排序</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SortUserRequest
        /// </param>
        /// <param name="headers">
        /// SortUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SortUserResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据用户名排序</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SortUserRequest
        /// </param>
        /// 
        /// <returns>
        /// SortUserResponse
        /// </returns>
        public SortUserResponse SortUser(SortUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SortUserHeaders headers = new SortUserHeaders();
            return SortUserWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据用户名排序</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SortUserRequest
        /// </param>
        /// 
        /// <returns>
        /// SortUserResponse
        /// </returns>
        public async Task<SortUserResponse> SortUserAsync(SortUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SortUserHeaders headers = new SortUserHeaders();
            return await SortUserWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号转换为专属帐号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransformToExclusiveAccountRequest
        /// </param>
        /// <param name="headers">
        /// TransformToExclusiveAccountHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransformToExclusiveAccountResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号转换为专属帐号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransformToExclusiveAccountRequest
        /// </param>
        /// <param name="headers">
        /// TransformToExclusiveAccountHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransformToExclusiveAccountResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号转换为专属帐号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransformToExclusiveAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// TransformToExclusiveAccountResponse
        /// </returns>
        public TransformToExclusiveAccountResponse TransformToExclusiveAccount(TransformToExclusiveAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TransformToExclusiveAccountHeaders headers = new TransformToExclusiveAccountHeaders();
            return TransformToExclusiveAccountWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>普通帐号转换为专属帐号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransformToExclusiveAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// TransformToExclusiveAccountResponse
        /// </returns>
        public async Task<TransformToExclusiveAccountResponse> TransformToExclusiveAccountAsync(TransformToExclusiveAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TransformToExclusiveAccountHeaders headers = new TransformToExclusiveAccountHeaders();
            return await TransformToExclusiveAccountWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步文件内容转译</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TranslateFileRequest
        /// </param>
        /// <param name="headers">
        /// TranslateFileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TranslateFileResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步文件内容转译</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TranslateFileRequest
        /// </param>
        /// <param name="headers">
        /// TranslateFileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TranslateFileResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步文件内容转译</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TranslateFileRequest
        /// </param>
        /// 
        /// <returns>
        /// TranslateFileResponse
        /// </returns>
        public TranslateFileResponse TranslateFile(TranslateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TranslateFileHeaders headers = new TranslateFileHeaders();
            return TranslateFileWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步文件内容转译</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TranslateFileRequest
        /// </param>
        /// 
        /// <returns>
        /// TranslateFileResponse
        /// </returns>
        public async Task<TranslateFileResponse> TranslateFileAsync(TranslateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TranslateFileHeaders headers = new TranslateFileHeaders();
            return await TranslateFileWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>唯一查询用户名片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UniqueQueryUserCardRequest
        /// </param>
        /// <param name="headers">
        /// UniqueQueryUserCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UniqueQueryUserCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>唯一查询用户名片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UniqueQueryUserCardRequest
        /// </param>
        /// <param name="headers">
        /// UniqueQueryUserCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UniqueQueryUserCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>唯一查询用户名片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UniqueQueryUserCardRequest
        /// </param>
        /// 
        /// <returns>
        /// UniqueQueryUserCardResponse
        /// </returns>
        public UniqueQueryUserCardResponse UniqueQueryUserCard(UniqueQueryUserCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UniqueQueryUserCardHeaders headers = new UniqueQueryUserCardHeaders();
            return UniqueQueryUserCardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>唯一查询用户名片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UniqueQueryUserCardRequest
        /// </param>
        /// 
        /// <returns>
        /// UniqueQueryUserCardResponse
        /// </returns>
        public async Task<UniqueQueryUserCardResponse> UniqueQueryUserCardAsync(UniqueQueryUserCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UniqueQueryUserCardHeaders headers = new UniqueQueryUserCardHeaders();
            return await UniqueQueryUserCardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新(分支/伙伴)在(集团/合作空间)的属性信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBranchAttributesInCooperateRequest
        /// </param>
        /// <param name="headers">
        /// UpdateBranchAttributesInCooperateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBranchAttributesInCooperateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新(分支/伙伴)在(集团/合作空间)的属性信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBranchAttributesInCooperateRequest
        /// </param>
        /// <param name="headers">
        /// UpdateBranchAttributesInCooperateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBranchAttributesInCooperateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新(分支/伙伴)在(集团/合作空间)的属性信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBranchAttributesInCooperateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBranchAttributesInCooperateResponse
        /// </returns>
        public UpdateBranchAttributesInCooperateResponse UpdateBranchAttributesInCooperate(UpdateBranchAttributesInCooperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateBranchAttributesInCooperateHeaders headers = new UpdateBranchAttributesInCooperateHeaders();
            return UpdateBranchAttributesInCooperateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新(分支/伙伴)在(集团/合作空间)的属性信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBranchAttributesInCooperateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBranchAttributesInCooperateResponse
        /// </returns>
        public async Task<UpdateBranchAttributesInCooperateResponse> UpdateBranchAttributesInCooperateAsync(UpdateBranchAttributesInCooperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateBranchAttributesInCooperateHeaders headers = new UpdateBranchAttributesInCooperateHeaders();
            return await UpdateBranchAttributesInCooperateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置(分支/伙伴)在(集团/合作空间)的可见范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBranchVisibleSettingInCooperateRequest
        /// </param>
        /// <param name="headers">
        /// UpdateBranchVisibleSettingInCooperateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBranchVisibleSettingInCooperateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置(分支/伙伴)在(集团/合作空间)的可见范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBranchVisibleSettingInCooperateRequest
        /// </param>
        /// <param name="headers">
        /// UpdateBranchVisibleSettingInCooperateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBranchVisibleSettingInCooperateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置(分支/伙伴)在(集团/合作空间)的可见范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBranchVisibleSettingInCooperateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBranchVisibleSettingInCooperateResponse
        /// </returns>
        public UpdateBranchVisibleSettingInCooperateResponse UpdateBranchVisibleSettingInCooperate(UpdateBranchVisibleSettingInCooperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateBranchVisibleSettingInCooperateHeaders headers = new UpdateBranchVisibleSettingInCooperateHeaders();
            return UpdateBranchVisibleSettingInCooperateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置(分支/伙伴)在(集团/合作空间)的可见范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBranchVisibleSettingInCooperateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBranchVisibleSettingInCooperateResponse
        /// </returns>
        public async Task<UpdateBranchVisibleSettingInCooperateResponse> UpdateBranchVisibleSettingInCooperateAsync(UpdateBranchVisibleSettingInCooperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateBranchVisibleSettingInCooperateHeaders headers = new UpdateBranchVisibleSettingInCooperateHeaders();
            return await UpdateBranchVisibleSettingInCooperateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新通讯录组织架构隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContactHideBySceneSettingRequest
        /// </param>
        /// <param name="headers">
        /// UpdateContactHideBySceneSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContactHideBySceneSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新通讯录组织架构隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContactHideBySceneSettingRequest
        /// </param>
        /// <param name="headers">
        /// UpdateContactHideBySceneSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContactHideBySceneSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新通讯录组织架构隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContactHideBySceneSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContactHideBySceneSettingResponse
        /// </returns>
        public UpdateContactHideBySceneSettingResponse UpdateContactHideBySceneSetting(string settingId, UpdateContactHideBySceneSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateContactHideBySceneSettingHeaders headers = new UpdateContactHideBySceneSettingHeaders();
            return UpdateContactHideBySceneSettingWithOptions(settingId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新通讯录组织架构隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContactHideBySceneSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContactHideBySceneSettingResponse
        /// </returns>
        public async Task<UpdateContactHideBySceneSettingResponse> UpdateContactHideBySceneSettingAsync(string settingId, UpdateContactHideBySceneSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateContactHideBySceneSettingHeaders headers = new UpdateContactHideBySceneSettingHeaders();
            return await UpdateContactHideBySceneSettingWithOptionsAsync(settingId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新通讯录隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContactHideSettingRequest
        /// </param>
        /// <param name="headers">
        /// UpdateContactHideSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContactHideSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新通讯录隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContactHideSettingRequest
        /// </param>
        /// <param name="headers">
        /// UpdateContactHideSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContactHideSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新通讯录隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContactHideSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContactHideSettingResponse
        /// </returns>
        public UpdateContactHideSettingResponse UpdateContactHideSetting(UpdateContactHideSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateContactHideSettingHeaders headers = new UpdateContactHideSettingHeaders();
            return UpdateContactHideSettingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新通讯录隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContactHideSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContactHideSettingResponse
        /// </returns>
        public async Task<UpdateContactHideSettingResponse> UpdateContactHideSettingAsync(UpdateContactHideSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateContactHideSettingHeaders headers = new UpdateContactHideSettingHeaders();
            return await UpdateContactHideSettingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或修改限制查看通讯录设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContactRestrictSettingRequest
        /// </param>
        /// <param name="headers">
        /// UpdateContactRestrictSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContactRestrictSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或修改限制查看通讯录设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContactRestrictSettingRequest
        /// </param>
        /// <param name="headers">
        /// UpdateContactRestrictSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContactRestrictSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或修改限制查看通讯录设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContactRestrictSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContactRestrictSettingResponse
        /// </returns>
        public UpdateContactRestrictSettingResponse UpdateContactRestrictSetting(UpdateContactRestrictSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateContactRestrictSettingHeaders headers = new UpdateContactRestrictSettingHeaders();
            return UpdateContactRestrictSettingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或修改限制查看通讯录设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContactRestrictSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContactRestrictSettingResponse
        /// </returns>
        public async Task<UpdateContactRestrictSettingResponse> UpdateContactRestrictSettingAsync(UpdateContactRestrictSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateContactRestrictSettingHeaders headers = new UpdateContactRestrictSettingHeaders();
            return await UpdateContactRestrictSettingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通讯录可见性部门设置子部门设置优先</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeptSettngTailFirstRequest
        /// </param>
        /// <param name="headers">
        /// UpdateDeptSettngTailFirstHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeptSettngTailFirstResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通讯录可见性部门设置子部门设置优先</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeptSettngTailFirstRequest
        /// </param>
        /// <param name="headers">
        /// UpdateDeptSettngTailFirstHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeptSettngTailFirstResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通讯录可见性部门设置子部门设置优先</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeptSettngTailFirstRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeptSettngTailFirstResponse
        /// </returns>
        public UpdateDeptSettngTailFirstResponse UpdateDeptSettngTailFirst(UpdateDeptSettngTailFirstRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeptSettngTailFirstHeaders headers = new UpdateDeptSettngTailFirstHeaders();
            return UpdateDeptSettngTailFirstWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通讯录可见性部门设置子部门设置优先</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeptSettngTailFirstRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeptSettngTailFirstResponse
        /// </returns>
        public async Task<UpdateDeptSettngTailFirstResponse> UpdateDeptSettngTailFirstAsync(UpdateDeptSettngTailFirstRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeptSettngTailFirstHeaders headers = new UpdateDeptSettngTailFirstHeaders();
            return await UpdateDeptSettngTailFirstWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新企业员工属性字段可见性设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEmpAttrbuteVisibilitySettingRequest
        /// </param>
        /// <param name="headers">
        /// UpdateEmpAttrbuteVisibilitySettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEmpAttrbuteVisibilitySettingResponse
        /// </returns>
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
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEmpAttrbuteVisibilitySettingResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新企业员工属性字段可见性设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEmpAttrbuteVisibilitySettingRequest
        /// </param>
        /// <param name="headers">
        /// UpdateEmpAttrbuteVisibilitySettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEmpAttrbuteVisibilitySettingResponse
        /// </returns>
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
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEmpAttrbuteVisibilitySettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新企业员工属性字段可见性设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEmpAttrbuteVisibilitySettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEmpAttrbuteVisibilitySettingResponse
        /// </returns>
        public UpdateEmpAttrbuteVisibilitySettingResponse UpdateEmpAttrbuteVisibilitySetting(UpdateEmpAttrbuteVisibilitySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateEmpAttrbuteVisibilitySettingHeaders headers = new UpdateEmpAttrbuteVisibilitySettingHeaders();
            return UpdateEmpAttrbuteVisibilitySettingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新企业员工属性字段可见性设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEmpAttrbuteVisibilitySettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEmpAttrbuteVisibilitySettingResponse
        /// </returns>
        public async Task<UpdateEmpAttrbuteVisibilitySettingResponse> UpdateEmpAttrbuteVisibilitySettingAsync(UpdateEmpAttrbuteVisibilitySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateEmpAttrbuteVisibilitySettingHeaders headers = new UpdateEmpAttrbuteVisibilitySettingHeaders();
            return await UpdateEmpAttrbuteVisibilitySettingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新员工属性分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEmpAttributeHideBySceneSettingRequest
        /// </param>
        /// <param name="headers">
        /// UpdateEmpAttributeHideBySceneSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEmpAttributeHideBySceneSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新员工属性分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEmpAttributeHideBySceneSettingRequest
        /// </param>
        /// <param name="headers">
        /// UpdateEmpAttributeHideBySceneSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEmpAttributeHideBySceneSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新员工属性分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEmpAttributeHideBySceneSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEmpAttributeHideBySceneSettingResponse
        /// </returns>
        public UpdateEmpAttributeHideBySceneSettingResponse UpdateEmpAttributeHideBySceneSetting(string settingId, UpdateEmpAttributeHideBySceneSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateEmpAttributeHideBySceneSettingHeaders headers = new UpdateEmpAttributeHideBySceneSettingHeaders();
            return UpdateEmpAttributeHideBySceneSettingWithOptions(settingId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新员工属性分场景隐藏设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEmpAttributeHideBySceneSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEmpAttributeHideBySceneSettingResponse
        /// </returns>
        public async Task<UpdateEmpAttributeHideBySceneSettingResponse> UpdateEmpAttributeHideBySceneSettingAsync(string settingId, UpdateEmpAttributeHideBySceneSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateEmpAttributeHideBySceneSettingHeaders headers = new UpdateEmpAttributeHideBySceneSettingHeaders();
            return await UpdateEmpAttributeHideBySceneSettingWithOptionsAsync(settingId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新管理组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateManagementGroupRequest
        /// </param>
        /// <param name="headers">
        /// UpdateManagementGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateManagementGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新管理组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateManagementGroupRequest
        /// </param>
        /// <param name="headers">
        /// UpdateManagementGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateManagementGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新管理组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateManagementGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateManagementGroupResponse
        /// </returns>
        public UpdateManagementGroupResponse UpdateManagementGroup(string groupId, UpdateManagementGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateManagementGroupHeaders headers = new UpdateManagementGroupHeaders();
            return UpdateManagementGroupWithOptions(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新管理组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateManagementGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateManagementGroupResponse
        /// </returns>
        public async Task<UpdateManagementGroupResponse> UpdateManagementGroupAsync(string groupId, UpdateManagementGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateManagementGroupHeaders headers = new UpdateManagementGroupHeaders();
            return await UpdateManagementGroupWithOptionsAsync(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置高管模式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSeniorSettingRequest
        /// </param>
        /// <param name="headers">
        /// UpdateSeniorSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSeniorSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置高管模式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSeniorSettingRequest
        /// </param>
        /// <param name="headers">
        /// UpdateSeniorSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSeniorSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置高管模式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSeniorSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSeniorSettingResponse
        /// </returns>
        public UpdateSeniorSettingResponse UpdateSeniorSetting(UpdateSeniorSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSeniorSettingHeaders headers = new UpdateSeniorSettingHeaders();
            return UpdateSeniorSettingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置高管模式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSeniorSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSeniorSettingResponse
        /// </returns>
        public async Task<UpdateSeniorSettingResponse> UpdateSeniorSettingAsync(UpdateSeniorSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSeniorSettingHeaders headers = new UpdateSeniorSettingHeaders();
            return await UpdateSeniorSettingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方通过该接口更新个人履历的审核状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTitleAuditStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateTitleAuditStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTitleAuditStatusResponse
        /// </returns>
        public UpdateTitleAuditStatusResponse UpdateTitleAuditStatusWithOptions(UpdateTitleAuditStatusRequest request, UpdateTitleAuditStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthStatus))
            {
                body["authStatus"] = request.AuthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EducationLevel))
            {
                body["educationLevel"] = request.EducationLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Major))
            {
                body["major"] = request.Major;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Position))
            {
                body["position"] = request.Position;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonCode))
            {
                body["reasonCode"] = request.ReasonCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonMsg))
            {
                body["reasonMsg"] = request.ReasonMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.School))
            {
                body["school"] = request.School;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateTitleAuditStatus",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/userTitles/auditStatuses",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTitleAuditStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方通过该接口更新个人履历的审核状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTitleAuditStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateTitleAuditStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTitleAuditStatusResponse
        /// </returns>
        public async Task<UpdateTitleAuditStatusResponse> UpdateTitleAuditStatusWithOptionsAsync(UpdateTitleAuditStatusRequest request, UpdateTitleAuditStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthStatus))
            {
                body["authStatus"] = request.AuthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EducationLevel))
            {
                body["educationLevel"] = request.EducationLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Major))
            {
                body["major"] = request.Major;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Position))
            {
                body["position"] = request.Position;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonCode))
            {
                body["reasonCode"] = request.ReasonCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonMsg))
            {
                body["reasonMsg"] = request.ReasonMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.School))
            {
                body["school"] = request.School;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateTitleAuditStatus",
                Version = "contact_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contact/userTitles/auditStatuses",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTitleAuditStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方通过该接口更新个人履历的审核状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTitleAuditStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTitleAuditStatusResponse
        /// </returns>
        public UpdateTitleAuditStatusResponse UpdateTitleAuditStatus(UpdateTitleAuditStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTitleAuditStatusHeaders headers = new UpdateTitleAuditStatusHeaders();
            return UpdateTitleAuditStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方通过该接口更新个人履历的审核状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTitleAuditStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTitleAuditStatusResponse
        /// </returns>
        public async Task<UpdateTitleAuditStatusResponse> UpdateTitleAuditStatusAsync(UpdateTitleAuditStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTitleAuditStatusHeaders headers = new UpdateTitleAuditStatusHeaders();
            return await UpdateTitleAuditStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新用户个人状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserOwnnessRequest
        /// </param>
        /// <param name="headers">
        /// UpdateUserOwnnessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserOwnnessResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新用户个人状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserOwnnessRequest
        /// </param>
        /// <param name="headers">
        /// UpdateUserOwnnessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserOwnnessResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新用户个人状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserOwnnessRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserOwnnessResponse
        /// </returns>
        public UpdateUserOwnnessResponse UpdateUserOwnness(string userId, UpdateUserOwnnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUserOwnnessHeaders headers = new UpdateUserOwnnessHeaders();
            return UpdateUserOwnnessWithOptions(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新用户个人状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserOwnnessRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserOwnnessResponse
        /// </returns>
        public async Task<UpdateUserOwnnessResponse> UpdateUserOwnnessAsync(string userId, UpdateUserOwnnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUserOwnnessHeaders headers = new UpdateUserOwnnessHeaders();
            return await UpdateUserOwnnessWithOptionsAsync(userId, request, headers, runtime);
        }

    }
}
