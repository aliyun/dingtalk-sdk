// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0
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
        /// <para>新增企业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrgRequest
        /// </param>
        /// <param name="headers">
        /// AddOrgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddOrgResponse
        /// </returns>
        public AddOrgResponse AddOrgWithOptions(AddOrgRequest request, AddOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["city"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                body["industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndustryCode))
            {
                body["industryCode"] = request.IndustryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNum))
            {
                body["mobileNum"] = request.MobileNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["province"] = request.Province;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddOrg",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/orgnizations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOrgResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增企业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrgRequest
        /// </param>
        /// <param name="headers">
        /// AddOrgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddOrgResponse
        /// </returns>
        public async Task<AddOrgResponse> AddOrgWithOptionsAsync(AddOrgRequest request, AddOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["city"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                body["industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndustryCode))
            {
                body["industryCode"] = request.IndustryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNum))
            {
                body["mobileNum"] = request.MobileNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["province"] = request.Province;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddOrg",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/orgnizations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOrgResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增企业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrgRequest
        /// </param>
        /// 
        /// <returns>
        /// AddOrgResponse
        /// </returns>
        public AddOrgResponse AddOrg(AddOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrgHeaders headers = new AddOrgHeaders();
            return AddOrgWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增企业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrgRequest
        /// </param>
        /// 
        /// <returns>
        /// AddOrgResponse
        /// </returns>
        public async Task<AddOrgResponse> AddOrgAsync(AddOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrgHeaders headers = new AddOrgHeaders();
            return await AddOrgWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属审批结果回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveProcessCallbackRequest
        /// </param>
        /// <param name="headers">
        /// ApproveProcessCallbackHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApproveProcessCallbackResponse
        /// </returns>
        public ApproveProcessCallbackResponse ApproveProcessCallbackWithOptions(ApproveProcessCallbackRequest request, ApproveProcessCallbackHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["request"] = request.Request;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ApproveProcessCallback",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/approvalResults/callback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApproveProcessCallbackResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属审批结果回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveProcessCallbackRequest
        /// </param>
        /// <param name="headers">
        /// ApproveProcessCallbackHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApproveProcessCallbackResponse
        /// </returns>
        public async Task<ApproveProcessCallbackResponse> ApproveProcessCallbackWithOptionsAsync(ApproveProcessCallbackRequest request, ApproveProcessCallbackHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["request"] = request.Request;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ApproveProcessCallback",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/approvalResults/callback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApproveProcessCallbackResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属审批结果回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveProcessCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// ApproveProcessCallbackResponse
        /// </returns>
        public ApproveProcessCallbackResponse ApproveProcessCallback(ApproveProcessCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApproveProcessCallbackHeaders headers = new ApproveProcessCallbackHeaders();
            return ApproveProcessCallbackWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属审批结果回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveProcessCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// ApproveProcessCallbackResponse
        /// </returns>
        public async Task<ApproveProcessCallbackResponse> ApproveProcessCallbackAsync(ApproveProcessCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApproveProcessCallbackHeaders headers = new ApproveProcessCallbackHeaders();
            return await ApproveProcessCallbackWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群禁言或解禁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BanOrOpenGroupWordsRequest
        /// </param>
        /// <param name="headers">
        /// BanOrOpenGroupWordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BanOrOpenGroupWordsResponse
        /// </returns>
        public BanOrOpenGroupWordsResponse BanOrOpenGroupWordsWithOptions(BanOrOpenGroupWordsRequest request, BanOrOpenGroupWordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BanWordsType))
            {
                body["banWordsType"] = request.BanWordsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConverationId))
            {
                body["openConverationId"] = request.OpenConverationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BanOrOpenGroupWords",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/enterpriseSecurities/banOrOpenGroupWords",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BanOrOpenGroupWordsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群禁言或解禁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BanOrOpenGroupWordsRequest
        /// </param>
        /// <param name="headers">
        /// BanOrOpenGroupWordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BanOrOpenGroupWordsResponse
        /// </returns>
        public async Task<BanOrOpenGroupWordsResponse> BanOrOpenGroupWordsWithOptionsAsync(BanOrOpenGroupWordsRequest request, BanOrOpenGroupWordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BanWordsType))
            {
                body["banWordsType"] = request.BanWordsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConverationId))
            {
                body["openConverationId"] = request.OpenConverationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BanOrOpenGroupWords",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/enterpriseSecurities/banOrOpenGroupWords",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BanOrOpenGroupWordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群禁言或解禁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BanOrOpenGroupWordsRequest
        /// </param>
        /// 
        /// <returns>
        /// BanOrOpenGroupWordsResponse
        /// </returns>
        public BanOrOpenGroupWordsResponse BanOrOpenGroupWords(BanOrOpenGroupWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BanOrOpenGroupWordsHeaders headers = new BanOrOpenGroupWordsHeaders();
            return BanOrOpenGroupWordsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群禁言或解禁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BanOrOpenGroupWordsRequest
        /// </param>
        /// 
        /// <returns>
        /// BanOrOpenGroupWordsResponse
        /// </returns>
        public async Task<BanOrOpenGroupWordsResponse> BanOrOpenGroupWordsAsync(BanOrOpenGroupWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BanOrOpenGroupWordsHeaders headers = new BanOrOpenGroupWordsHeaders();
            return await BanOrOpenGroupWordsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建分组并绑定会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCategoryAndBindingGroupsRequest
        /// </param>
        /// <param name="headers">
        /// CreateCategoryAndBindingGroupsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCategoryAndBindingGroupsResponse
        /// </returns>
        public CreateCategoryAndBindingGroupsResponse CreateCategoryAndBindingGroupsWithOptions(CreateCategoryAndBindingGroupsRequest request, CreateCategoryAndBindingGroupsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["categoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                body["groupIds"] = request.GroupIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateCategoryAndBindingGroups",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/messageCategories/categories/createAndBind",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCategoryAndBindingGroupsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建分组并绑定会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCategoryAndBindingGroupsRequest
        /// </param>
        /// <param name="headers">
        /// CreateCategoryAndBindingGroupsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCategoryAndBindingGroupsResponse
        /// </returns>
        public async Task<CreateCategoryAndBindingGroupsResponse> CreateCategoryAndBindingGroupsWithOptionsAsync(CreateCategoryAndBindingGroupsRequest request, CreateCategoryAndBindingGroupsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["categoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                body["groupIds"] = request.GroupIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateCategoryAndBindingGroups",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/messageCategories/categories/createAndBind",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCategoryAndBindingGroupsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建分组并绑定会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCategoryAndBindingGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCategoryAndBindingGroupsResponse
        /// </returns>
        public CreateCategoryAndBindingGroupsResponse CreateCategoryAndBindingGroups(CreateCategoryAndBindingGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCategoryAndBindingGroupsHeaders headers = new CreateCategoryAndBindingGroupsHeaders();
            return CreateCategoryAndBindingGroupsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建分组并绑定会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCategoryAndBindingGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCategoryAndBindingGroupsResponse
        /// </returns>
        public async Task<CreateCategoryAndBindingGroupsResponse> CreateCategoryAndBindingGroupsAsync(CreateCategoryAndBindingGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCategoryAndBindingGroupsHeaders headers = new CreateCategoryAndBindingGroupsHeaders();
            return await CreateCategoryAndBindingGroupsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文件检测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDlpTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateDlpTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDlpTaskResponse
        /// </returns>
        public CreateDlpTaskResponse CreateDlpTaskWithOptions(CreateDlpTaskRequest request, CreateDlpTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryId))
            {
                body["dentryId"] = request.DentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                body["spaceId"] = request.SpaceId;
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
                Action = "CreateDlpTask",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/dlpTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDlpTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文件检测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDlpTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateDlpTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDlpTaskResponse
        /// </returns>
        public async Task<CreateDlpTaskResponse> CreateDlpTaskWithOptionsAsync(CreateDlpTaskRequest request, CreateDlpTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryId))
            {
                body["dentryId"] = request.DentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                body["spaceId"] = request.SpaceId;
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
                Action = "CreateDlpTask",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/dlpTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDlpTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文件检测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDlpTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDlpTaskResponse
        /// </returns>
        public CreateDlpTaskResponse CreateDlpTask(CreateDlpTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDlpTaskHeaders headers = new CreateDlpTaskHeaders();
            return CreateDlpTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文件检测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDlpTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDlpTaskResponse
        /// </returns>
        public async Task<CreateDlpTaskResponse> CreateDlpTaskAsync(CreateDlpTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDlpTaskHeaders headers = new CreateDlpTaskHeaders();
            return await CreateDlpTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建分组并绑定会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMessageCategoryRequest
        /// </param>
        /// <param name="headers">
        /// CreateMessageCategoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMessageCategoryResponse
        /// </returns>
        public CreateMessageCategoryResponse CreateMessageCategoryWithOptions(CreateMessageCategoryRequest request, CreateMessageCategoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["categoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                body["groupIds"] = request.GroupIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateMessageCategory",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/messageCategories/categories/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMessageCategoryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建分组并绑定会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMessageCategoryRequest
        /// </param>
        /// <param name="headers">
        /// CreateMessageCategoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMessageCategoryResponse
        /// </returns>
        public async Task<CreateMessageCategoryResponse> CreateMessageCategoryWithOptionsAsync(CreateMessageCategoryRequest request, CreateMessageCategoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["categoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                body["groupIds"] = request.GroupIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateMessageCategory",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/messageCategories/categories/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMessageCategoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建分组并绑定会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMessageCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMessageCategoryResponse
        /// </returns>
        public CreateMessageCategoryResponse CreateMessageCategory(CreateMessageCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMessageCategoryHeaders headers = new CreateMessageCategoryHeaders();
            return CreateMessageCategoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建分组并绑定会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMessageCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMessageCategoryResponse
        /// </returns>
        public async Task<CreateMessageCategoryResponse> CreateMessageCategoryAsync(CreateMessageCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMessageCategoryHeaders headers = new CreateMessageCategoryHeaders();
            return await CreateMessageCategoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRuleRequest
        /// </param>
        /// <param name="headers">
        /// CreateRuleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRuleResponse
        /// </returns>
        public CreateRuleResponse CreateRuleWithOptions(CreateRuleRequest request, CreateRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPlan))
            {
                body["customPlan"] = request.CustomPlan;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateRule",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/messageCategories/rules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRuleResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRuleRequest
        /// </param>
        /// <param name="headers">
        /// CreateRuleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRuleResponse
        /// </returns>
        public async Task<CreateRuleResponse> CreateRuleWithOptionsAsync(CreateRuleRequest request, CreateRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPlan))
            {
                body["customPlan"] = request.CustomPlan;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateRule",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/messageCategories/rules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRuleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRuleResponse
        /// </returns>
        public CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRuleHeaders headers = new CreateRuleHeaders();
            return CreateRuleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRuleResponse
        /// </returns>
        public async Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRuleHeaders headers = new CreateRuleHeaders();
            return await CreateRuleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>存入可信设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrustedDeviceRequest
        /// </param>
        /// <param name="headers">
        /// CreateTrustedDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTrustedDeviceResponse
        /// </returns>
        public CreateTrustedDeviceResponse CreateTrustedDeviceWithOptions(CreateTrustedDeviceRequest request, CreateTrustedDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Did))
            {
                body["did"] = request.Did;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MacAddress))
            {
                body["macAddress"] = request.MacAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "CreateTrustedDevice",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/trustedDevices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrustedDeviceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>存入可信设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrustedDeviceRequest
        /// </param>
        /// <param name="headers">
        /// CreateTrustedDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTrustedDeviceResponse
        /// </returns>
        public async Task<CreateTrustedDeviceResponse> CreateTrustedDeviceWithOptionsAsync(CreateTrustedDeviceRequest request, CreateTrustedDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Did))
            {
                body["did"] = request.Did;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MacAddress))
            {
                body["macAddress"] = request.MacAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "CreateTrustedDevice",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/trustedDevices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrustedDeviceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>存入可信设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrustedDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTrustedDeviceResponse
        /// </returns>
        public CreateTrustedDeviceResponse CreateTrustedDevice(CreateTrustedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTrustedDeviceHeaders headers = new CreateTrustedDeviceHeaders();
            return CreateTrustedDeviceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>存入可信设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrustedDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTrustedDeviceResponse
        /// </returns>
        public async Task<CreateTrustedDeviceResponse> CreateTrustedDeviceAsync(CreateTrustedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTrustedDeviceHeaders headers = new CreateTrustedDeviceHeaders();
            return await CreateTrustedDeviceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增可信设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrustedDeviceBatchRequest
        /// </param>
        /// <param name="headers">
        /// CreateTrustedDeviceBatchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTrustedDeviceBatchResponse
        /// </returns>
        public CreateTrustedDeviceBatchResponse CreateTrustedDeviceBatchWithOptions(CreateTrustedDeviceBatchRequest request, CreateTrustedDeviceBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MacAddressList))
            {
                body["macAddressList"] = request.MacAddressList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
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
                Action = "CreateTrustedDeviceBatch",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/trusts/devices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrustedDeviceBatchResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增可信设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrustedDeviceBatchRequest
        /// </param>
        /// <param name="headers">
        /// CreateTrustedDeviceBatchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTrustedDeviceBatchResponse
        /// </returns>
        public async Task<CreateTrustedDeviceBatchResponse> CreateTrustedDeviceBatchWithOptionsAsync(CreateTrustedDeviceBatchRequest request, CreateTrustedDeviceBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MacAddressList))
            {
                body["macAddressList"] = request.MacAddressList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
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
                Action = "CreateTrustedDeviceBatch",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/trusts/devices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrustedDeviceBatchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增可信设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrustedDeviceBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTrustedDeviceBatchResponse
        /// </returns>
        public CreateTrustedDeviceBatchResponse CreateTrustedDeviceBatch(CreateTrustedDeviceBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTrustedDeviceBatchHeaders headers = new CreateTrustedDeviceBatchHeaders();
            return CreateTrustedDeviceBatchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增可信设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrustedDeviceBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTrustedDeviceBatchResponse
        /// </returns>
        public async Task<CreateTrustedDeviceBatchResponse> CreateTrustedDeviceBatchAsync(CreateTrustedDeviceBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTrustedDeviceBatchHeaders headers = new CreateTrustedDeviceBatchHeaders();
            return await CreateTrustedDeviceBatchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>触发文件病毒扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirusScanTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateVirusScanTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVirusScanTaskResponse
        /// </returns>
        public CreateVirusScanTaskResponse CreateVirusScanTaskWithOptions(CreateVirusScanTaskRequest request, CreateVirusScanTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryId))
            {
                body["dentryId"] = request.DentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadUrl))
            {
                body["downloadUrl"] = request.DownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileMd5))
            {
                body["fileMd5"] = request.FileMd5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                body["fileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                body["spaceId"] = request.SpaceId;
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
                Action = "CreateVirusScanTask",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/virusScanTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirusScanTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>触发文件病毒扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirusScanTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateVirusScanTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVirusScanTaskResponse
        /// </returns>
        public async Task<CreateVirusScanTaskResponse> CreateVirusScanTaskWithOptionsAsync(CreateVirusScanTaskRequest request, CreateVirusScanTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryId))
            {
                body["dentryId"] = request.DentryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadUrl))
            {
                body["downloadUrl"] = request.DownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileMd5))
            {
                body["fileMd5"] = request.FileMd5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                body["fileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                body["spaceId"] = request.SpaceId;
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
                Action = "CreateVirusScanTask",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/virusScanTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirusScanTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>触发文件病毒扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirusScanTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVirusScanTaskResponse
        /// </returns>
        public CreateVirusScanTaskResponse CreateVirusScanTask(CreateVirusScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVirusScanTaskHeaders headers = new CreateVirusScanTaskHeaders();
            return CreateVirusScanTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>触发文件病毒扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirusScanTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVirusScanTaskResponse
        /// </returns>
        public async Task<CreateVirusScanTaskResponse> CreateVirusScanTaskAsync(CreateVirusScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVirusScanTaskHeaders headers = new CreateVirusScanTaskHeaders();
            return await CreateVirusScanTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为应用同步数据到专属存储</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DataSyncRequest
        /// </param>
        /// <param name="headers">
        /// DataSyncHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DataSyncResponse
        /// </returns>
        public DataSyncResponse DataSyncWithOptions(DataSyncRequest request, DataSyncHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                body["sql"] = request.Sql;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "DataSync",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/datas/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DataSyncResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为应用同步数据到专属存储</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DataSyncRequest
        /// </param>
        /// <param name="headers">
        /// DataSyncHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DataSyncResponse
        /// </returns>
        public async Task<DataSyncResponse> DataSyncWithOptionsAsync(DataSyncRequest request, DataSyncHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                body["sql"] = request.Sql;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "DataSync",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/datas/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DataSyncResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为应用同步数据到专属存储</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DataSyncRequest
        /// </param>
        /// 
        /// <returns>
        /// DataSyncResponse
        /// </returns>
        public DataSyncResponse DataSync(DataSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DataSyncHeaders headers = new DataSyncHeaders();
            return DataSyncWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为应用同步数据到专属存储</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DataSyncRequest
        /// </param>
        /// 
        /// <returns>
        /// DataSyncResponse
        /// </returns>
        public async Task<DataSyncResponse> DataSyncAsync(DataSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DataSyncHeaders headers = new DataSyncHeaders();
            return await DataSyncWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除跨云存储配置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteAcrossCloudStroageConfigsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAcrossCloudStroageConfigsResponse
        /// </returns>
        public DeleteAcrossCloudStroageConfigsResponse DeleteAcrossCloudStroageConfigsWithOptions(string targetCorpId, DeleteAcrossCloudStroageConfigsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAcrossCloudStroageConfigs",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileStorages/acrossClouds/configurations/" + targetCorpId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAcrossCloudStroageConfigsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除跨云存储配置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteAcrossCloudStroageConfigsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAcrossCloudStroageConfigsResponse
        /// </returns>
        public async Task<DeleteAcrossCloudStroageConfigsResponse> DeleteAcrossCloudStroageConfigsWithOptionsAsync(string targetCorpId, DeleteAcrossCloudStroageConfigsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAcrossCloudStroageConfigs",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileStorages/acrossClouds/configurations/" + targetCorpId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAcrossCloudStroageConfigsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除跨云存储配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteAcrossCloudStroageConfigsResponse
        /// </returns>
        public DeleteAcrossCloudStroageConfigsResponse DeleteAcrossCloudStroageConfigs(string targetCorpId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAcrossCloudStroageConfigsHeaders headers = new DeleteAcrossCloudStroageConfigsHeaders();
            return DeleteAcrossCloudStroageConfigsWithOptions(targetCorpId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除跨云存储配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteAcrossCloudStroageConfigsResponse
        /// </returns>
        public async Task<DeleteAcrossCloudStroageConfigsResponse> DeleteAcrossCloudStroageConfigsAsync(string targetCorpId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAcrossCloudStroageConfigsHeaders headers = new DeleteAcrossCloudStroageConfigsHeaders();
            return await DeleteAcrossCloudStroageConfigsWithOptionsAsync(targetCorpId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除评论</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteCommentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCommentResponse
        /// </returns>
        public DeleteCommentResponse DeleteCommentWithOptions(string publisherId, string commentId, DeleteCommentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteComment",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/publishers/" + publisherId + "/comments/" + commentId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "boolean",
            };
            return TeaModel.ToObject<DeleteCommentResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除评论</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteCommentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCommentResponse
        /// </returns>
        public async Task<DeleteCommentResponse> DeleteCommentWithOptionsAsync(string publisherId, string commentId, DeleteCommentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteComment",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/publishers/" + publisherId + "/comments/" + commentId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "boolean",
            };
            return TeaModel.ToObject<DeleteCommentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除评论</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteCommentResponse
        /// </returns>
        public DeleteCommentResponse DeleteComment(string publisherId, string commentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCommentHeaders headers = new DeleteCommentHeaders();
            return DeleteCommentWithOptions(publisherId, commentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除评论</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteCommentResponse
        /// </returns>
        public async Task<DeleteCommentResponse> DeleteCommentAsync(string publisherId, string commentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCommentHeaders headers = new DeleteCommentHeaders();
            return await DeleteCommentWithOptionsAsync(publisherId, commentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定可信设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTrustedDeviceRequest
        /// </param>
        /// <param name="headers">
        /// DeleteTrustedDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrustedDeviceResponse
        /// </returns>
        public DeleteTrustedDeviceResponse DeleteTrustedDeviceWithOptions(DeleteTrustedDeviceRequest request, DeleteTrustedDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KickOff))
            {
                body["kickOff"] = request.KickOff;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MacAddress))
            {
                body["macAddress"] = request.MacAddress;
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
                Action = "DeleteTrustedDevice",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/trustedDevices/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTrustedDeviceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定可信设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTrustedDeviceRequest
        /// </param>
        /// <param name="headers">
        /// DeleteTrustedDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrustedDeviceResponse
        /// </returns>
        public async Task<DeleteTrustedDeviceResponse> DeleteTrustedDeviceWithOptionsAsync(DeleteTrustedDeviceRequest request, DeleteTrustedDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KickOff))
            {
                body["kickOff"] = request.KickOff;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MacAddress))
            {
                body["macAddress"] = request.MacAddress;
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
                Action = "DeleteTrustedDevice",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/trustedDevices/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTrustedDeviceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定可信设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTrustedDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrustedDeviceResponse
        /// </returns>
        public DeleteTrustedDeviceResponse DeleteTrustedDevice(DeleteTrustedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTrustedDeviceHeaders headers = new DeleteTrustedDeviceHeaders();
            return DeleteTrustedDeviceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定可信设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTrustedDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrustedDeviceResponse
        /// </returns>
        public async Task<DeleteTrustedDeviceResponse> DeleteTrustedDeviceAsync(DeleteTrustedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTrustedDeviceHeaders headers = new DeleteTrustedDeviceHeaders();
            return await DeleteTrustedDeviceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分发伙伴应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DistributePartnerAppRequest
        /// </param>
        /// <param name="headers">
        /// DistributePartnerAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DistributePartnerAppResponse
        /// </returns>
        public DistributePartnerAppResponse DistributePartnerAppWithOptions(DistributePartnerAppRequest request, DistributePartnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                body["subCorpId"] = request.SubCorpId;
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
                Action = "DistributePartnerApp",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/partners/applications/distribute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DistributePartnerAppResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分发伙伴应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DistributePartnerAppRequest
        /// </param>
        /// <param name="headers">
        /// DistributePartnerAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DistributePartnerAppResponse
        /// </returns>
        public async Task<DistributePartnerAppResponse> DistributePartnerAppWithOptionsAsync(DistributePartnerAppRequest request, DistributePartnerAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCorpId))
            {
                body["subCorpId"] = request.SubCorpId;
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
                Action = "DistributePartnerApp",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/partners/applications/distribute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DistributePartnerAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分发伙伴应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DistributePartnerAppRequest
        /// </param>
        /// 
        /// <returns>
        /// DistributePartnerAppResponse
        /// </returns>
        public DistributePartnerAppResponse DistributePartnerApp(DistributePartnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DistributePartnerAppHeaders headers = new DistributePartnerAppHeaders();
            return DistributePartnerAppWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分发伙伴应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DistributePartnerAppRequest
        /// </param>
        /// 
        /// <returns>
        /// DistributePartnerAppResponse
        /// </returns>
        public async Task<DistributePartnerAppResponse> DistributePartnerAppAsync(DistributePartnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DistributePartnerAppHeaders headers = new DistributePartnerAppHeaders();
            return await DistributePartnerAppWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑安全卡片管控成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditSecurityConfigMemberRequest
        /// </param>
        /// <param name="headers">
        /// EditSecurityConfigMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditSecurityConfigMemberResponse
        /// </returns>
        public EditSecurityConfigMemberResponse EditSecurityConfigMemberWithOptions(EditSecurityConfigMemberRequest request, EditSecurityConfigMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKey))
            {
                body["configKey"] = request.ConfigKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["operateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                body["operateUserId"] = request.OperateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditSecurityConfigMember",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/securities/configs/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditSecurityConfigMemberResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑安全卡片管控成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditSecurityConfigMemberRequest
        /// </param>
        /// <param name="headers">
        /// EditSecurityConfigMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditSecurityConfigMemberResponse
        /// </returns>
        public async Task<EditSecurityConfigMemberResponse> EditSecurityConfigMemberWithOptionsAsync(EditSecurityConfigMemberRequest request, EditSecurityConfigMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKey))
            {
                body["configKey"] = request.ConfigKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["operateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                body["operateUserId"] = request.OperateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "EditSecurityConfigMember",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/securities/configs/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditSecurityConfigMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑安全卡片管控成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditSecurityConfigMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// EditSecurityConfigMemberResponse
        /// </returns>
        public EditSecurityConfigMemberResponse EditSecurityConfigMember(EditSecurityConfigMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditSecurityConfigMemberHeaders headers = new EditSecurityConfigMemberHeaders();
            return EditSecurityConfigMemberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑安全卡片管控成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditSecurityConfigMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// EditSecurityConfigMemberResponse
        /// </returns>
        public async Task<EditSecurityConfigMemberResponse> EditSecurityConfigMemberAsync(EditSecurityConfigMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditSecurityConfigMemberHeaders headers = new EditSecurityConfigMemberHeaders();
            return await EditSecurityConfigMemberWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更换组织主管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExchangeMainAdminRequest
        /// </param>
        /// <param name="headers">
        /// ExchangeMainAdminHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExchangeMainAdminResponse
        /// </returns>
        public ExchangeMainAdminResponse ExchangeMainAdminWithOptions(ExchangeMainAdminRequest request, ExchangeMainAdminHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewAdminUserId))
            {
                body["newAdminUserId"] = request.NewAdminUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldAdminUserId))
            {
                body["oldAdminUserId"] = request.OldAdminUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ExchangeMainAdmin",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/orgnizations/mainAdministrators/exchange",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExchangeMainAdminResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更换组织主管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExchangeMainAdminRequest
        /// </param>
        /// <param name="headers">
        /// ExchangeMainAdminHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExchangeMainAdminResponse
        /// </returns>
        public async Task<ExchangeMainAdminResponse> ExchangeMainAdminWithOptionsAsync(ExchangeMainAdminRequest request, ExchangeMainAdminHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewAdminUserId))
            {
                body["newAdminUserId"] = request.NewAdminUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldAdminUserId))
            {
                body["oldAdminUserId"] = request.OldAdminUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ExchangeMainAdmin",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/orgnizations/mainAdministrators/exchange",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExchangeMainAdminResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更换组织主管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExchangeMainAdminRequest
        /// </param>
        /// 
        /// <returns>
        /// ExchangeMainAdminResponse
        /// </returns>
        public ExchangeMainAdminResponse ExchangeMainAdmin(ExchangeMainAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExchangeMainAdminHeaders headers = new ExchangeMainAdminHeaders();
            return ExchangeMainAdminWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更换组织主管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExchangeMainAdminRequest
        /// </param>
        /// 
        /// <returns>
        /// ExchangeMainAdminResponse
        /// </returns>
        public async Task<ExchangeMainAdminResponse> ExchangeMainAdminAsync(ExchangeMainAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExchangeMainAdminHeaders headers = new ExchangeMainAdminHeaders();
            return await ExchangeMainAdminWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分发工作台模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExclusiveCreateDingPortalRequest
        /// </param>
        /// <param name="headers">
        /// ExclusiveCreateDingPortalHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExclusiveCreateDingPortalResponse
        /// </returns>
        public ExclusiveCreateDingPortalResponse ExclusiveCreateDingPortalWithOptions(ExclusiveCreateDingPortalRequest request, ExclusiveCreateDingPortalHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingPortalName))
            {
                body["dingPortalName"] = request.DingPortalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateAppUuid))
            {
                body["templateAppUuid"] = request.TemplateAppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCorpId))
            {
                body["templateCorpId"] = request.TemplateCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ExclusiveCreateDingPortal",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/workbenches/templates/spread",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExclusiveCreateDingPortalResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分发工作台模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExclusiveCreateDingPortalRequest
        /// </param>
        /// <param name="headers">
        /// ExclusiveCreateDingPortalHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExclusiveCreateDingPortalResponse
        /// </returns>
        public async Task<ExclusiveCreateDingPortalResponse> ExclusiveCreateDingPortalWithOptionsAsync(ExclusiveCreateDingPortalRequest request, ExclusiveCreateDingPortalHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingPortalName))
            {
                body["dingPortalName"] = request.DingPortalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateAppUuid))
            {
                body["templateAppUuid"] = request.TemplateAppUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCorpId))
            {
                body["templateCorpId"] = request.TemplateCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ExclusiveCreateDingPortal",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/workbenches/templates/spread",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExclusiveCreateDingPortalResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分发工作台模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExclusiveCreateDingPortalRequest
        /// </param>
        /// 
        /// <returns>
        /// ExclusiveCreateDingPortalResponse
        /// </returns>
        public ExclusiveCreateDingPortalResponse ExclusiveCreateDingPortal(ExclusiveCreateDingPortalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExclusiveCreateDingPortalHeaders headers = new ExclusiveCreateDingPortalHeaders();
            return ExclusiveCreateDingPortalWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分发工作台模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExclusiveCreateDingPortalRequest
        /// </param>
        /// 
        /// <returns>
        /// ExclusiveCreateDingPortalResponse
        /// </returns>
        public async Task<ExclusiveCreateDingPortalResponse> ExclusiveCreateDingPortalAsync(ExclusiveCreateDingPortalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExclusiveCreateDingPortalHeaders headers = new ExclusiveCreateDingPortalHeaders();
            return await ExclusiveCreateDingPortalWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属文件第一次设置，激活配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageActiveStorageRequest
        /// </param>
        /// <param name="headers">
        /// FileStorageActiveStorageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FileStorageActiveStorageResponse
        /// </returns>
        public FileStorageActiveStorageResponse FileStorageActiveStorageWithOptions(FileStorageActiveStorageRequest request, FileStorageActiveStorageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Oss))
            {
                body["oss"] = request.Oss;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "FileStorageActiveStorage",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileStorages/active",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileStorageActiveStorageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属文件第一次设置，激活配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageActiveStorageRequest
        /// </param>
        /// <param name="headers">
        /// FileStorageActiveStorageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FileStorageActiveStorageResponse
        /// </returns>
        public async Task<FileStorageActiveStorageResponse> FileStorageActiveStorageWithOptionsAsync(FileStorageActiveStorageRequest request, FileStorageActiveStorageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Oss))
            {
                body["oss"] = request.Oss;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "FileStorageActiveStorage",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileStorages/active",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileStorageActiveStorageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属文件第一次设置，激活配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageActiveStorageRequest
        /// </param>
        /// 
        /// <returns>
        /// FileStorageActiveStorageResponse
        /// </returns>
        public FileStorageActiveStorageResponse FileStorageActiveStorage(FileStorageActiveStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageActiveStorageHeaders headers = new FileStorageActiveStorageHeaders();
            return FileStorageActiveStorageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属文件第一次设置，激活配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageActiveStorageRequest
        /// </param>
        /// 
        /// <returns>
        /// FileStorageActiveStorageResponse
        /// </returns>
        public async Task<FileStorageActiveStorageResponse> FileStorageActiveStorageAsync(FileStorageActiveStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageActiveStorageHeaders headers = new FileStorageActiveStorageHeaders();
            return await FileStorageActiveStorageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查专属存储OSS连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageCheckConnectionRequest
        /// </param>
        /// <param name="headers">
        /// FileStorageCheckConnectionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FileStorageCheckConnectionResponse
        /// </returns>
        public FileStorageCheckConnectionResponse FileStorageCheckConnectionWithOptions(FileStorageCheckConnectionRequest request, FileStorageCheckConnectionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Oss))
            {
                body["oss"] = request.Oss;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "FileStorageCheckConnection",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileStorages/connections/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileStorageCheckConnectionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查专属存储OSS连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageCheckConnectionRequest
        /// </param>
        /// <param name="headers">
        /// FileStorageCheckConnectionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FileStorageCheckConnectionResponse
        /// </returns>
        public async Task<FileStorageCheckConnectionResponse> FileStorageCheckConnectionWithOptionsAsync(FileStorageCheckConnectionRequest request, FileStorageCheckConnectionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Oss))
            {
                body["oss"] = request.Oss;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "FileStorageCheckConnection",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileStorages/connections/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileStorageCheckConnectionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查专属存储OSS连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageCheckConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// FileStorageCheckConnectionResponse
        /// </returns>
        public FileStorageCheckConnectionResponse FileStorageCheckConnection(FileStorageCheckConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageCheckConnectionHeaders headers = new FileStorageCheckConnectionHeaders();
            return FileStorageCheckConnectionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查专属存储OSS连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageCheckConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// FileStorageCheckConnectionResponse
        /// </returns>
        public async Task<FileStorageCheckConnectionResponse> FileStorageCheckConnectionAsync(FileStorageCheckConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageCheckConnectionHeaders headers = new FileStorageCheckConnectionHeaders();
            return await FileStorageCheckConnectionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属文件存储获取存储情况(按时间区间)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageGetQuotaDataRequest
        /// </param>
        /// <param name="headers">
        /// FileStorageGetQuotaDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FileStorageGetQuotaDataResponse
        /// </returns>
        public FileStorageGetQuotaDataResponse FileStorageGetQuotaDataWithOptions(FileStorageGetQuotaDataRequest request, FileStorageGetQuotaDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                query["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "FileStorageGetQuotaData",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileStorages/quotaDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileStorageGetQuotaDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属文件存储获取存储情况(按时间区间)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageGetQuotaDataRequest
        /// </param>
        /// <param name="headers">
        /// FileStorageGetQuotaDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FileStorageGetQuotaDataResponse
        /// </returns>
        public async Task<FileStorageGetQuotaDataResponse> FileStorageGetQuotaDataWithOptionsAsync(FileStorageGetQuotaDataRequest request, FileStorageGetQuotaDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                query["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "FileStorageGetQuotaData",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileStorages/quotaDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileStorageGetQuotaDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属文件存储获取存储情况(按时间区间)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageGetQuotaDataRequest
        /// </param>
        /// 
        /// <returns>
        /// FileStorageGetQuotaDataResponse
        /// </returns>
        public FileStorageGetQuotaDataResponse FileStorageGetQuotaData(FileStorageGetQuotaDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageGetQuotaDataHeaders headers = new FileStorageGetQuotaDataHeaders();
            return FileStorageGetQuotaDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属文件存储获取存储情况(按时间区间)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageGetQuotaDataRequest
        /// </param>
        /// 
        /// <returns>
        /// FileStorageGetQuotaDataResponse
        /// </returns>
        public async Task<FileStorageGetQuotaDataResponse> FileStorageGetQuotaDataAsync(FileStorageGetQuotaDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageGetQuotaDataHeaders headers = new FileStorageGetQuotaDataHeaders();
            return await FileStorageGetQuotaDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属文件存储获取存储情况和配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageGetStorageStateRequest
        /// </param>
        /// <param name="headers">
        /// FileStorageGetStorageStateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FileStorageGetStorageStateResponse
        /// </returns>
        public FileStorageGetStorageStateResponse FileStorageGetStorageStateWithOptions(FileStorageGetStorageStateRequest request, FileStorageGetStorageStateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "FileStorageGetStorageState",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileStorages/states",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileStorageGetStorageStateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属文件存储获取存储情况和配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageGetStorageStateRequest
        /// </param>
        /// <param name="headers">
        /// FileStorageGetStorageStateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FileStorageGetStorageStateResponse
        /// </returns>
        public async Task<FileStorageGetStorageStateResponse> FileStorageGetStorageStateWithOptionsAsync(FileStorageGetStorageStateRequest request, FileStorageGetStorageStateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "FileStorageGetStorageState",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileStorages/states",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileStorageGetStorageStateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属文件存储获取存储情况和配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageGetStorageStateRequest
        /// </param>
        /// 
        /// <returns>
        /// FileStorageGetStorageStateResponse
        /// </returns>
        public FileStorageGetStorageStateResponse FileStorageGetStorageState(FileStorageGetStorageStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageGetStorageStateHeaders headers = new FileStorageGetStorageStateHeaders();
            return FileStorageGetStorageStateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属文件存储获取存储情况和配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageGetStorageStateRequest
        /// </param>
        /// 
        /// <returns>
        /// FileStorageGetStorageStateResponse
        /// </returns>
        public async Task<FileStorageGetStorageStateResponse> FileStorageGetStorageStateAsync(FileStorageGetStorageStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageGetStorageStateHeaders headers = new FileStorageGetStorageStateHeaders();
            return await FileStorageGetStorageStateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文件专属存储配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageUpdateStorageRequest
        /// </param>
        /// <param name="headers">
        /// FileStorageUpdateStorageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FileStorageUpdateStorageResponse
        /// </returns>
        public FileStorageUpdateStorageResponse FileStorageUpdateStorageWithOptions(FileStorageUpdateStorageRequest request, FileStorageUpdateStorageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "FileStorageUpdateStorage",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileStorages/configurations",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileStorageUpdateStorageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文件专属存储配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageUpdateStorageRequest
        /// </param>
        /// <param name="headers">
        /// FileStorageUpdateStorageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FileStorageUpdateStorageResponse
        /// </returns>
        public async Task<FileStorageUpdateStorageResponse> FileStorageUpdateStorageWithOptionsAsync(FileStorageUpdateStorageRequest request, FileStorageUpdateStorageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "FileStorageUpdateStorage",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileStorages/configurations",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileStorageUpdateStorageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文件专属存储配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageUpdateStorageRequest
        /// </param>
        /// 
        /// <returns>
        /// FileStorageUpdateStorageResponse
        /// </returns>
        public FileStorageUpdateStorageResponse FileStorageUpdateStorage(FileStorageUpdateStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageUpdateStorageHeaders headers = new FileStorageUpdateStorageHeaders();
            return FileStorageUpdateStorageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文件专属存储配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileStorageUpdateStorageRequest
        /// </param>
        /// 
        /// <returns>
        /// FileStorageUpdateStorageResponse
        /// </returns>
        public async Task<FileStorageUpdateStorageResponse> FileStorageUpdateStorageAsync(FileStorageUpdateStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageUpdateStorageHeaders headers = new FileStorageUpdateStorageHeaders();
            return await FileStorageUpdateStorageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成暗水印</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateDarkWaterMarkRequest
        /// </param>
        /// <param name="headers">
        /// GenerateDarkWaterMarkHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateDarkWaterMarkResponse
        /// </returns>
        public GenerateDarkWaterMarkResponse GenerateDarkWaterMarkWithOptions(GenerateDarkWaterMarkRequest request, GenerateDarkWaterMarkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "GenerateDarkWaterMark",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/enterpriseSecurities/darkWatermarks/generate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateDarkWaterMarkResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成暗水印</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateDarkWaterMarkRequest
        /// </param>
        /// <param name="headers">
        /// GenerateDarkWaterMarkHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateDarkWaterMarkResponse
        /// </returns>
        public async Task<GenerateDarkWaterMarkResponse> GenerateDarkWaterMarkWithOptionsAsync(GenerateDarkWaterMarkRequest request, GenerateDarkWaterMarkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "GenerateDarkWaterMark",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/enterpriseSecurities/darkWatermarks/generate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateDarkWaterMarkResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成暗水印</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateDarkWaterMarkRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateDarkWaterMarkResponse
        /// </returns>
        public GenerateDarkWaterMarkResponse GenerateDarkWaterMark(GenerateDarkWaterMarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateDarkWaterMarkHeaders headers = new GenerateDarkWaterMarkHeaders();
            return GenerateDarkWaterMarkWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成暗水印</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateDarkWaterMarkRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateDarkWaterMarkResponse
        /// </returns>
        public async Task<GenerateDarkWaterMarkResponse> GenerateDarkWaterMarkAsync(GenerateDarkWaterMarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateDarkWaterMarkHeaders headers = new GenerateDarkWaterMarkHeaders();
            return await GenerateDarkWaterMarkWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取专属钉钉账号数据迁移结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountTransferListRequest
        /// </param>
        /// <param name="headers">
        /// GetAccountTransferListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccountTransferListResponse
        /// </returns>
        public GetAccountTransferListResponse GetAccountTransferListWithOptions(GetAccountTransferListRequest request, GetAccountTransferListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetAccountTransferList",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/dataTransfer/accounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountTransferListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取专属钉钉账号数据迁移结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountTransferListRequest
        /// </param>
        /// <param name="headers">
        /// GetAccountTransferListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccountTransferListResponse
        /// </returns>
        public async Task<GetAccountTransferListResponse> GetAccountTransferListWithOptionsAsync(GetAccountTransferListRequest request, GetAccountTransferListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetAccountTransferList",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/dataTransfer/accounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountTransferListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取专属钉钉账号数据迁移结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountTransferListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccountTransferListResponse
        /// </returns>
        public GetAccountTransferListResponse GetAccountTransferList(GetAccountTransferListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAccountTransferListHeaders headers = new GetAccountTransferListHeaders();
            return GetAccountTransferListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取专属钉钉账号数据迁移结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountTransferListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccountTransferListResponse
        /// </returns>
        public async Task<GetAccountTransferListResponse> GetAccountTransferListAsync(GetAccountTransferListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAccountTransferListHeaders headers = new GetAccountTransferListHeaders();
            return await GetAccountTransferListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得组织维度的用户dau</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetActiveUserSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetActiveUserSummaryResponse
        /// </returns>
        public GetActiveUserSummaryResponse GetActiveUserSummaryWithOptions(string dataId, GetActiveUserSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetActiveUserSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/dau/org/" + dataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetActiveUserSummaryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得组织维度的用户dau</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetActiveUserSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetActiveUserSummaryResponse
        /// </returns>
        public async Task<GetActiveUserSummaryResponse> GetActiveUserSummaryWithOptionsAsync(string dataId, GetActiveUserSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetActiveUserSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/dau/org/" + dataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetActiveUserSummaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得组织维度的用户dau</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetActiveUserSummaryResponse
        /// </returns>
        public GetActiveUserSummaryResponse GetActiveUserSummary(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetActiveUserSummaryHeaders headers = new GetActiveUserSummaryHeaders();
            return GetActiveUserSummaryWithOptions(dataId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得组织维度的用户dau</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetActiveUserSummaryResponse
        /// </returns>
        public async Task<GetActiveUserSummaryResponse> GetActiveUserSummaryAsync(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetActiveUserSummaryHeaders headers = new GetActiveUserSummaryHeaders();
            return await GetActiveUserSummaryWithOptionsAsync(dataId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据AppId获取微应用在该组织下的agentId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentIdByRelatedAppIdRequest
        /// </param>
        /// <param name="headers">
        /// GetAgentIdByRelatedAppIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentIdByRelatedAppIdResponse
        /// </returns>
        public GetAgentIdByRelatedAppIdResponse GetAgentIdByRelatedAppIdWithOptions(GetAgentIdByRelatedAppIdRequest request, GetAgentIdByRelatedAppIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
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
                Action = "GetAgentIdByRelatedAppId",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/exclusiveDesigns/agentId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentIdByRelatedAppIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据AppId获取微应用在该组织下的agentId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentIdByRelatedAppIdRequest
        /// </param>
        /// <param name="headers">
        /// GetAgentIdByRelatedAppIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentIdByRelatedAppIdResponse
        /// </returns>
        public async Task<GetAgentIdByRelatedAppIdResponse> GetAgentIdByRelatedAppIdWithOptionsAsync(GetAgentIdByRelatedAppIdRequest request, GetAgentIdByRelatedAppIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
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
                Action = "GetAgentIdByRelatedAppId",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/exclusiveDesigns/agentId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentIdByRelatedAppIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据AppId获取微应用在该组织下的agentId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentIdByRelatedAppIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentIdByRelatedAppIdResponse
        /// </returns>
        public GetAgentIdByRelatedAppIdResponse GetAgentIdByRelatedAppId(GetAgentIdByRelatedAppIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAgentIdByRelatedAppIdHeaders headers = new GetAgentIdByRelatedAppIdHeaders();
            return GetAgentIdByRelatedAppIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据AppId获取微应用在该组织下的agentId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentIdByRelatedAppIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentIdByRelatedAppIdResponse
        /// </returns>
        public async Task<GetAgentIdByRelatedAppIdResponse> GetAgentIdByRelatedAppIdAsync(GetAgentIdByRelatedAppIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAgentIdByRelatedAppIdHeaders headers = new GetAgentIdByRelatedAppIdHeaders();
            return await GetAgentIdByRelatedAppIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>伙伴钉可打标签部门查询</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetAllLabelableDeptsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllLabelableDeptsResponse
        /// </returns>
        public GetAllLabelableDeptsResponse GetAllLabelableDeptsWithOptions(GetAllLabelableDeptsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAllLabelableDepts",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/partnerDepartments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllLabelableDeptsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>伙伴钉可打标签部门查询</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetAllLabelableDeptsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllLabelableDeptsResponse
        /// </returns>
        public async Task<GetAllLabelableDeptsResponse> GetAllLabelableDeptsWithOptionsAsync(GetAllLabelableDeptsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAllLabelableDepts",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/partnerDepartments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllLabelableDeptsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>伙伴钉可打标签部门查询</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAllLabelableDeptsResponse
        /// </returns>
        public GetAllLabelableDeptsResponse GetAllLabelableDepts()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllLabelableDeptsHeaders headers = new GetAllLabelableDeptsHeaders();
            return GetAllLabelableDeptsWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>伙伴钉可打标签部门查询</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAllLabelableDeptsResponse
        /// </returns>
        public async Task<GetAllLabelableDeptsResponse> GetAllLabelableDeptsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllLabelableDeptsHeaders headers = new GetAllLabelableDeptsHeaders();
            return await GetAllLabelableDeptsWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得app分发信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppDispatchInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetAppDispatchInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAppDispatchInfoResponse
        /// </returns>
        public GetAppDispatchInfoResponse GetAppDispatchInfoWithOptions(GetAppDispatchInfoRequest request, GetAppDispatchInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
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
                Action = "GetAppDispatchInfo",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/apps/distributionInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppDispatchInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得app分发信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppDispatchInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetAppDispatchInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAppDispatchInfoResponse
        /// </returns>
        public async Task<GetAppDispatchInfoResponse> GetAppDispatchInfoWithOptionsAsync(GetAppDispatchInfoRequest request, GetAppDispatchInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
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
                Action = "GetAppDispatchInfo",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/apps/distributionInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppDispatchInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得app分发信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppDispatchInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAppDispatchInfoResponse
        /// </returns>
        public GetAppDispatchInfoResponse GetAppDispatchInfo(GetAppDispatchInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAppDispatchInfoHeaders headers = new GetAppDispatchInfoHeaders();
            return GetAppDispatchInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得app分发信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppDispatchInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAppDispatchInfoResponse
        /// </returns>
        public async Task<GetAppDispatchInfoResponse> GetAppDispatchInfoAsync(GetAppDispatchInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAppDispatchInfoHeaders headers = new GetAppDispatchInfoHeaders();
            return await GetAppDispatchInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得组织维度日程相关信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetCalenderSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCalenderSummaryResponse
        /// </returns>
        public GetCalenderSummaryResponse GetCalenderSummaryWithOptions(string dataId, GetCalenderSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCalenderSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/calendar/org/" + dataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCalenderSummaryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得组织维度日程相关信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetCalenderSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCalenderSummaryResponse
        /// </returns>
        public async Task<GetCalenderSummaryResponse> GetCalenderSummaryWithOptionsAsync(string dataId, GetCalenderSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCalenderSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/calendar/org/" + dataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCalenderSummaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得组织维度日程相关信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCalenderSummaryResponse
        /// </returns>
        public GetCalenderSummaryResponse GetCalenderSummary(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCalenderSummaryHeaders headers = new GetCalenderSummaryHeaders();
            return GetCalenderSummaryWithOptions(dataId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得组织维度日程相关信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCalenderSummaryResponse
        /// </returns>
        public async Task<GetCalenderSummaryResponse> GetCalenderSummaryAsync(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCalenderSummaryHeaders headers = new GetCalenderSummaryHeaders();
            return await GetCalenderSummaryWithOptionsAsync(dataId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取发布号的评论列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCommentListRequest
        /// </param>
        /// <param name="headers">
        /// GetCommentListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCommentListResponse
        /// </returns>
        public GetCommentListResponse GetCommentListWithOptions(string publisherId, GetCommentListRequest request, GetCommentListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCommentList",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/publishers/" + publisherId + "/comments/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCommentListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取发布号的评论列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCommentListRequest
        /// </param>
        /// <param name="headers">
        /// GetCommentListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCommentListResponse
        /// </returns>
        public async Task<GetCommentListResponse> GetCommentListWithOptionsAsync(string publisherId, GetCommentListRequest request, GetCommentListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCommentList",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/publishers/" + publisherId + "/comments/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCommentListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取发布号的评论列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCommentListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCommentListResponse
        /// </returns>
        public GetCommentListResponse GetCommentList(string publisherId, GetCommentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCommentListHeaders headers = new GetCommentListHeaders();
            return GetCommentListWithOptions(publisherId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取发布号的评论列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCommentListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCommentListResponse
        /// </returns>
        public async Task<GetCommentListResponse> GetCommentListAsync(string publisherId, GetCommentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCommentListHeaders headers = new GetCommentListHeaders();
            return await GetCommentListWithOptionsAsync(publisherId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据逻辑会议id获取会议基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfBaseInfoByLogicalIdRequest
        /// </param>
        /// <param name="headers">
        /// GetConfBaseInfoByLogicalIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConfBaseInfoByLogicalIdResponse
        /// </returns>
        public GetConfBaseInfoByLogicalIdResponse GetConfBaseInfoByLogicalIdWithOptions(GetConfBaseInfoByLogicalIdRequest request, GetConfBaseInfoByLogicalIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalConferenceId))
            {
                query["logicalConferenceId"] = request.LogicalConferenceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetConfBaseInfoByLogicalId",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/conferences",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfBaseInfoByLogicalIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据逻辑会议id获取会议基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfBaseInfoByLogicalIdRequest
        /// </param>
        /// <param name="headers">
        /// GetConfBaseInfoByLogicalIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConfBaseInfoByLogicalIdResponse
        /// </returns>
        public async Task<GetConfBaseInfoByLogicalIdResponse> GetConfBaseInfoByLogicalIdWithOptionsAsync(GetConfBaseInfoByLogicalIdRequest request, GetConfBaseInfoByLogicalIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalConferenceId))
            {
                query["logicalConferenceId"] = request.LogicalConferenceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetConfBaseInfoByLogicalId",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/conferences",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfBaseInfoByLogicalIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据逻辑会议id获取会议基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfBaseInfoByLogicalIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConfBaseInfoByLogicalIdResponse
        /// </returns>
        public GetConfBaseInfoByLogicalIdResponse GetConfBaseInfoByLogicalId(GetConfBaseInfoByLogicalIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConfBaseInfoByLogicalIdHeaders headers = new GetConfBaseInfoByLogicalIdHeaders();
            return GetConfBaseInfoByLogicalIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据逻辑会议id获取会议基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfBaseInfoByLogicalIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConfBaseInfoByLogicalIdResponse
        /// </returns>
        public async Task<GetConfBaseInfoByLogicalIdResponse> GetConfBaseInfoByLogicalIdAsync(GetConfBaseInfoByLogicalIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConfBaseInfoByLogicalIdHeaders headers = new GetConfBaseInfoByLogicalIdHeaders();
            return await GetConfBaseInfoByLogicalIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频会议明细</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetConferenceDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConferenceDetailResponse
        /// </returns>
        public GetConferenceDetailResponse GetConferenceDetailWithOptions(string conferenceId, GetConferenceDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetConferenceDetail",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/conferences/" + conferenceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConferenceDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频会议明细</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetConferenceDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConferenceDetailResponse
        /// </returns>
        public async Task<GetConferenceDetailResponse> GetConferenceDetailWithOptionsAsync(string conferenceId, GetConferenceDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetConferenceDetail",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/conferences/" + conferenceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConferenceDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频会议明细</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetConferenceDetailResponse
        /// </returns>
        public GetConferenceDetailResponse GetConferenceDetail(string conferenceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConferenceDetailHeaders headers = new GetConferenceDetailHeaders();
            return GetConferenceDetailWithOptions(conferenceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频会议明细</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetConferenceDetailResponse
        /// </returns>
        public async Task<GetConferenceDetailResponse> GetConferenceDetailAsync(string conferenceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConferenceDetailHeaders headers = new GetConferenceDetailHeaders();
            return await GetConferenceDetailWithOptionsAsync(conferenceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话分组数据</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetConversationCategoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConversationCategoryResponse
        /// </returns>
        public GetConversationCategoryResponse GetConversationCategoryWithOptions(GetConversationCategoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetConversationCategory",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/conversationCategories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConversationCategoryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话分组数据</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetConversationCategoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConversationCategoryResponse
        /// </returns>
        public async Task<GetConversationCategoryResponse> GetConversationCategoryWithOptionsAsync(GetConversationCategoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetConversationCategory",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/conversationCategories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConversationCategoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话分组数据</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetConversationCategoryResponse
        /// </returns>
        public GetConversationCategoryResponse GetConversationCategory()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationCategoryHeaders headers = new GetConversationCategoryHeaders();
            return GetConversationCategoryWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话分组数据</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetConversationCategoryResponse
        /// </returns>
        public async Task<GetConversationCategoryResponse> GetConversationCategoryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationCategoryHeaders headers = new GetConversationCategoryHeaders();
            return await GetConversationCategoryWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话分组详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConversationDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetConversationDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConversationDetailResponse
        /// </returns>
        public GetConversationDetailResponse GetConversationDetailWithOptions(GetConversationDetailRequest request, GetConversationDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetConversationDetail",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/categories/conversations/details/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConversationDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话分组详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConversationDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetConversationDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConversationDetailResponse
        /// </returns>
        public async Task<GetConversationDetailResponse> GetConversationDetailWithOptionsAsync(GetConversationDetailRequest request, GetConversationDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetConversationDetail",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/categories/conversations/details/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConversationDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话分组详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConversationDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConversationDetailResponse
        /// </returns>
        public GetConversationDetailResponse GetConversationDetail(GetConversationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationDetailHeaders headers = new GetConversationDetailHeaders();
            return GetConversationDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话分组详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConversationDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConversationDetailResponse
        /// </returns>
        public async Task<GetConversationDetailResponse> GetConversationDetailAsync(GetConversationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationDetailHeaders headers = new GetConversationDetailHeaders();
            return await GetConversationDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取部门维度发布日志信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDingReportDeptSummaryRequest
        /// </param>
        /// <param name="headers">
        /// GetDingReportDeptSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDingReportDeptSummaryResponse
        /// </returns>
        public GetDingReportDeptSummaryResponse GetDingReportDeptSummaryWithOptions(string dataId, GetDingReportDeptSummaryRequest request, GetDingReportDeptSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDingReportDeptSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/report/dept/" + dataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDingReportDeptSummaryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取部门维度发布日志信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDingReportDeptSummaryRequest
        /// </param>
        /// <param name="headers">
        /// GetDingReportDeptSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDingReportDeptSummaryResponse
        /// </returns>
        public async Task<GetDingReportDeptSummaryResponse> GetDingReportDeptSummaryWithOptionsAsync(string dataId, GetDingReportDeptSummaryRequest request, GetDingReportDeptSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDingReportDeptSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/report/dept/" + dataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDingReportDeptSummaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取部门维度发布日志信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDingReportDeptSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDingReportDeptSummaryResponse
        /// </returns>
        public GetDingReportDeptSummaryResponse GetDingReportDeptSummary(string dataId, GetDingReportDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingReportDeptSummaryHeaders headers = new GetDingReportDeptSummaryHeaders();
            return GetDingReportDeptSummaryWithOptions(dataId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取部门维度发布日志信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDingReportDeptSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDingReportDeptSummaryResponse
        /// </returns>
        public async Task<GetDingReportDeptSummaryResponse> GetDingReportDeptSummaryAsync(string dataId, GetDingReportDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingReportDeptSummaryHeaders headers = new GetDingReportDeptSummaryHeaders();
            return await GetDingReportDeptSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织维度发布日志信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetDingReportSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDingReportSummaryResponse
        /// </returns>
        public GetDingReportSummaryResponse GetDingReportSummaryWithOptions(string dataId, GetDingReportSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDingReportSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/datas/" + dataId + "/reports/organizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDingReportSummaryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织维度发布日志信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetDingReportSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDingReportSummaryResponse
        /// </returns>
        public async Task<GetDingReportSummaryResponse> GetDingReportSummaryWithOptionsAsync(string dataId, GetDingReportSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDingReportSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/datas/" + dataId + "/reports/organizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDingReportSummaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织维度发布日志信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDingReportSummaryResponse
        /// </returns>
        public GetDingReportSummaryResponse GetDingReportSummary(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingReportSummaryHeaders headers = new GetDingReportSummaryHeaders();
            return GetDingReportSummaryWithOptions(dataId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织维度发布日志信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDingReportSummaryResponse
        /// </returns>
        public async Task<GetDingReportSummaryResponse> GetDingReportSummaryAsync(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingReportSummaryHeaders headers = new GetDingReportSummaryHeaders();
            return await GetDingReportSummaryWithOptionsAsync(dataId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得部门维度用户创建文档数和创建文档人数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocCreatedDeptSummaryRequest
        /// </param>
        /// <param name="headers">
        /// GetDocCreatedDeptSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocCreatedDeptSummaryResponse
        /// </returns>
        public GetDocCreatedDeptSummaryResponse GetDocCreatedDeptSummaryWithOptions(string dataId, GetDocCreatedDeptSummaryRequest request, GetDocCreatedDeptSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDocCreatedDeptSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/doc/dept/" + dataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocCreatedDeptSummaryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得部门维度用户创建文档数和创建文档人数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocCreatedDeptSummaryRequest
        /// </param>
        /// <param name="headers">
        /// GetDocCreatedDeptSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocCreatedDeptSummaryResponse
        /// </returns>
        public async Task<GetDocCreatedDeptSummaryResponse> GetDocCreatedDeptSummaryWithOptionsAsync(string dataId, GetDocCreatedDeptSummaryRequest request, GetDocCreatedDeptSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDocCreatedDeptSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/doc/dept/" + dataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocCreatedDeptSummaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得部门维度用户创建文档数和创建文档人数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocCreatedDeptSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocCreatedDeptSummaryResponse
        /// </returns>
        public GetDocCreatedDeptSummaryResponse GetDocCreatedDeptSummary(string dataId, GetDocCreatedDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocCreatedDeptSummaryHeaders headers = new GetDocCreatedDeptSummaryHeaders();
            return GetDocCreatedDeptSummaryWithOptions(dataId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得部门维度用户创建文档数和创建文档人数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocCreatedDeptSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocCreatedDeptSummaryResponse
        /// </returns>
        public async Task<GetDocCreatedDeptSummaryResponse> GetDocCreatedDeptSummaryAsync(string dataId, GetDocCreatedDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocCreatedDeptSummaryHeaders headers = new GetDocCreatedDeptSummaryHeaders();
            return await GetDocCreatedDeptSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织维度用户创建文档数和创建文档人数</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetDocCreatedSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocCreatedSummaryResponse
        /// </returns>
        public GetDocCreatedSummaryResponse GetDocCreatedSummaryWithOptions(string dataId, GetDocCreatedSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDocCreatedSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/doc/org/" + dataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocCreatedSummaryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织维度用户创建文档数和创建文档人数</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetDocCreatedSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocCreatedSummaryResponse
        /// </returns>
        public async Task<GetDocCreatedSummaryResponse> GetDocCreatedSummaryWithOptionsAsync(string dataId, GetDocCreatedSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDocCreatedSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/doc/org/" + dataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocCreatedSummaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织维度用户创建文档数和创建文档人数</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDocCreatedSummaryResponse
        /// </returns>
        public GetDocCreatedSummaryResponse GetDocCreatedSummary(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocCreatedSummaryHeaders headers = new GetDocCreatedSummaryHeaders();
            return GetDocCreatedSummaryWithOptions(dataId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织维度用户创建文档数和创建文档人数</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDocCreatedSummaryResponse
        /// </returns>
        public async Task<GetDocCreatedSummaryResponse> GetDocCreatedSummaryAsync(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocCreatedSummaryHeaders headers = new GetDocCreatedSummaryHeaders();
            return await GetDocCreatedSummaryWithOptionsAsync(dataId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取专属账号所有组织列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExclusiveAccountAllOrgListRequest
        /// </param>
        /// <param name="headers">
        /// GetExclusiveAccountAllOrgListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExclusiveAccountAllOrgListResponse
        /// </returns>
        public GetExclusiveAccountAllOrgListResponse GetExclusiveAccountAllOrgListWithOptions(GetExclusiveAccountAllOrgListRequest request, GetExclusiveAccountAllOrgListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetExclusiveAccountAllOrgList",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/exclusiveAccounts/organizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExclusiveAccountAllOrgListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取专属账号所有组织列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExclusiveAccountAllOrgListRequest
        /// </param>
        /// <param name="headers">
        /// GetExclusiveAccountAllOrgListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExclusiveAccountAllOrgListResponse
        /// </returns>
        public async Task<GetExclusiveAccountAllOrgListResponse> GetExclusiveAccountAllOrgListWithOptionsAsync(GetExclusiveAccountAllOrgListRequest request, GetExclusiveAccountAllOrgListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetExclusiveAccountAllOrgList",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/exclusiveAccounts/organizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExclusiveAccountAllOrgListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取专属账号所有组织列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExclusiveAccountAllOrgListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExclusiveAccountAllOrgListResponse
        /// </returns>
        public GetExclusiveAccountAllOrgListResponse GetExclusiveAccountAllOrgList(GetExclusiveAccountAllOrgListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetExclusiveAccountAllOrgListHeaders headers = new GetExclusiveAccountAllOrgListHeaders();
            return GetExclusiveAccountAllOrgListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取专属账号所有组织列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExclusiveAccountAllOrgListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExclusiveAccountAllOrgListResponse
        /// </returns>
        public async Task<GetExclusiveAccountAllOrgListResponse> GetExclusiveAccountAllOrgListAsync(GetExclusiveAccountAllOrgListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetExclusiveAccountAllOrgListHeaders headers = new GetExclusiveAccountAllOrgListHeaders();
            return await GetExclusiveAccountAllOrgListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取部门维度发布智能填表数量和使用智能填表人数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGeneralFormCreatedDeptSummaryRequest
        /// </param>
        /// <param name="headers">
        /// GetGeneralFormCreatedDeptSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGeneralFormCreatedDeptSummaryResponse
        /// </returns>
        public GetGeneralFormCreatedDeptSummaryResponse GetGeneralFormCreatedDeptSummaryWithOptions(string dataId, GetGeneralFormCreatedDeptSummaryRequest request, GetGeneralFormCreatedDeptSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetGeneralFormCreatedDeptSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/generalForm/dept/" + dataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGeneralFormCreatedDeptSummaryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取部门维度发布智能填表数量和使用智能填表人数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGeneralFormCreatedDeptSummaryRequest
        /// </param>
        /// <param name="headers">
        /// GetGeneralFormCreatedDeptSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGeneralFormCreatedDeptSummaryResponse
        /// </returns>
        public async Task<GetGeneralFormCreatedDeptSummaryResponse> GetGeneralFormCreatedDeptSummaryWithOptionsAsync(string dataId, GetGeneralFormCreatedDeptSummaryRequest request, GetGeneralFormCreatedDeptSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetGeneralFormCreatedDeptSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/generalForm/dept/" + dataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGeneralFormCreatedDeptSummaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取部门维度发布智能填表数量和使用智能填表人数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGeneralFormCreatedDeptSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGeneralFormCreatedDeptSummaryResponse
        /// </returns>
        public GetGeneralFormCreatedDeptSummaryResponse GetGeneralFormCreatedDeptSummary(string dataId, GetGeneralFormCreatedDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGeneralFormCreatedDeptSummaryHeaders headers = new GetGeneralFormCreatedDeptSummaryHeaders();
            return GetGeneralFormCreatedDeptSummaryWithOptions(dataId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取部门维度发布智能填表数量和使用智能填表人数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGeneralFormCreatedDeptSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGeneralFormCreatedDeptSummaryResponse
        /// </returns>
        public async Task<GetGeneralFormCreatedDeptSummaryResponse> GetGeneralFormCreatedDeptSummaryAsync(string dataId, GetGeneralFormCreatedDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGeneralFormCreatedDeptSummaryHeaders headers = new GetGeneralFormCreatedDeptSummaryHeaders();
            return await GetGeneralFormCreatedDeptSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织维度发布智能填表数量和使用智能填表人数</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetGeneralFormCreatedSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGeneralFormCreatedSummaryResponse
        /// </returns>
        public GetGeneralFormCreatedSummaryResponse GetGeneralFormCreatedSummaryWithOptions(string dataId, GetGeneralFormCreatedSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetGeneralFormCreatedSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/generalForm/org/" + dataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGeneralFormCreatedSummaryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织维度发布智能填表数量和使用智能填表人数</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetGeneralFormCreatedSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGeneralFormCreatedSummaryResponse
        /// </returns>
        public async Task<GetGeneralFormCreatedSummaryResponse> GetGeneralFormCreatedSummaryWithOptionsAsync(string dataId, GetGeneralFormCreatedSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetGeneralFormCreatedSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/generalForm/org/" + dataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGeneralFormCreatedSummaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织维度发布智能填表数量和使用智能填表人数</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetGeneralFormCreatedSummaryResponse
        /// </returns>
        public GetGeneralFormCreatedSummaryResponse GetGeneralFormCreatedSummary(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGeneralFormCreatedSummaryHeaders headers = new GetGeneralFormCreatedSummaryHeaders();
            return GetGeneralFormCreatedSummaryWithOptions(dataId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取组织维度发布智能填表数量和使用智能填表人数</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetGeneralFormCreatedSummaryResponse
        /// </returns>
        public async Task<GetGeneralFormCreatedSummaryResponse> GetGeneralFormCreatedSummaryAsync(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGeneralFormCreatedSummaryHeaders headers = new GetGeneralFormCreatedSummaryHeaders();
            return await GetGeneralFormCreatedSummaryWithOptionsAsync(dataId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取群活跃明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGroupActiveInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetGroupActiveInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGroupActiveInfoResponse
        /// </returns>
        public GetGroupActiveInfoResponse GetGroupActiveInfoWithOptions(GetGroupActiveInfoRequest request, GetGroupActiveInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingGroupId))
            {
                query["dingGroupId"] = request.DingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["groupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetGroupActiveInfo",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/activeGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupActiveInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取群活跃明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGroupActiveInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetGroupActiveInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGroupActiveInfoResponse
        /// </returns>
        public async Task<GetGroupActiveInfoResponse> GetGroupActiveInfoWithOptionsAsync(GetGroupActiveInfoRequest request, GetGroupActiveInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingGroupId))
            {
                query["dingGroupId"] = request.DingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["groupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetGroupActiveInfo",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/activeGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupActiveInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取群活跃明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGroupActiveInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGroupActiveInfoResponse
        /// </returns>
        public GetGroupActiveInfoResponse GetGroupActiveInfo(GetGroupActiveInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGroupActiveInfoHeaders headers = new GetGroupActiveInfoHeaders();
            return GetGroupActiveInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取群活跃明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGroupActiveInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGroupActiveInfoResponse
        /// </returns>
        public async Task<GetGroupActiveInfoResponse> GetGroupActiveInfoAsync(GetGroupActiveInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGroupActiveInfoHeaders headers = new GetGroupActiveInfoHeaders();
            return await GetGroupActiveInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取未活跃用户登陆统计明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInActiveUserListRequest
        /// </param>
        /// <param name="headers">
        /// GetInActiveUserListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInActiveUserListResponse
        /// </returns>
        public GetInActiveUserListResponse GetInActiveUserListWithOptions(GetInActiveUserListRequest request, GetInActiveUserListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                body["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetInActiveUserList",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/inactives/users/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInActiveUserListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取未活跃用户登陆统计明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInActiveUserListRequest
        /// </param>
        /// <param name="headers">
        /// GetInActiveUserListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInActiveUserListResponse
        /// </returns>
        public async Task<GetInActiveUserListResponse> GetInActiveUserListWithOptionsAsync(GetInActiveUserListRequest request, GetInActiveUserListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                body["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetInActiveUserList",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/inactives/users/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInActiveUserListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取未活跃用户登陆统计明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInActiveUserListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInActiveUserListResponse
        /// </returns>
        public GetInActiveUserListResponse GetInActiveUserList(GetInActiveUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInActiveUserListHeaders headers = new GetInActiveUserListHeaders();
            return GetInActiveUserListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取未活跃用户登陆统计明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInActiveUserListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInActiveUserListResponse
        /// </returns>
        public async Task<GetInActiveUserListResponse> GetInActiveUserListAsync(GetInActiveUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInActiveUserListHeaders headers = new GetInActiveUserListHeaders();
            return await GetInActiveUserListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最后一次验证通过的企业认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLastOrgAuthDataRequest
        /// </param>
        /// <param name="headers">
        /// GetLastOrgAuthDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLastOrgAuthDataResponse
        /// </returns>
        public GetLastOrgAuthDataResponse GetLastOrgAuthDataWithOptions(GetLastOrgAuthDataRequest request, GetLastOrgAuthDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetLastOrgAuthData",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/organizations/authInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLastOrgAuthDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最后一次验证通过的企业认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLastOrgAuthDataRequest
        /// </param>
        /// <param name="headers">
        /// GetLastOrgAuthDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLastOrgAuthDataResponse
        /// </returns>
        public async Task<GetLastOrgAuthDataResponse> GetLastOrgAuthDataWithOptionsAsync(GetLastOrgAuthDataRequest request, GetLastOrgAuthDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetLastOrgAuthData",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/organizations/authInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLastOrgAuthDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最后一次验证通过的企业认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLastOrgAuthDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLastOrgAuthDataResponse
        /// </returns>
        public GetLastOrgAuthDataResponse GetLastOrgAuthData(GetLastOrgAuthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLastOrgAuthDataHeaders headers = new GetLastOrgAuthDataHeaders();
            return GetLastOrgAuthDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最后一次验证通过的企业认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLastOrgAuthDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLastOrgAuthDataResponse
        /// </returns>
        public async Task<GetLastOrgAuthDataResponse> GetLastOrgAuthDataAsync(GetLastOrgAuthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLastOrgAuthDataHeaders headers = new GetLastOrgAuthDataHeaders();
            return await GetLastOrgAuthDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>消息规则配置和群属性接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMsgConfigRequest
        /// </param>
        /// <param name="headers">
        /// GetMsgConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMsgConfigResponse
        /// </returns>
        public GetMsgConfigResponse GetMsgConfigWithOptions(GetMsgConfigRequest request, GetMsgConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTopic))
            {
                body["groupTopic"] = request.GroupTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                body["groupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListDynamicAttr))
            {
                body["listDynamicAttr"] = request.ListDynamicAttr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListEmployeeCode))
            {
                body["listEmployeeCode"] = request.ListEmployeeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListUnitId))
            {
                body["listUnitId"] = request.ListUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerJobNo))
            {
                body["ownerJobNo"] = request.OwnerJobNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleBusinessCode))
            {
                body["ruleBusinessCode"] = request.RuleBusinessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCategory))
            {
                body["ruleCategory"] = request.RuleCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCode))
            {
                body["ruleCode"] = request.RuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SysCode))
            {
                body["sysCode"] = request.SysCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetMsgConfig",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/portals/msgConfigs/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMsgConfigResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>消息规则配置和群属性接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMsgConfigRequest
        /// </param>
        /// <param name="headers">
        /// GetMsgConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMsgConfigResponse
        /// </returns>
        public async Task<GetMsgConfigResponse> GetMsgConfigWithOptionsAsync(GetMsgConfigRequest request, GetMsgConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTopic))
            {
                body["groupTopic"] = request.GroupTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                body["groupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListDynamicAttr))
            {
                body["listDynamicAttr"] = request.ListDynamicAttr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListEmployeeCode))
            {
                body["listEmployeeCode"] = request.ListEmployeeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListUnitId))
            {
                body["listUnitId"] = request.ListUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerJobNo))
            {
                body["ownerJobNo"] = request.OwnerJobNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleBusinessCode))
            {
                body["ruleBusinessCode"] = request.RuleBusinessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCategory))
            {
                body["ruleCategory"] = request.RuleCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCode))
            {
                body["ruleCode"] = request.RuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SysCode))
            {
                body["sysCode"] = request.SysCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetMsgConfig",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/portals/msgConfigs/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMsgConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>消息规则配置和群属性接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMsgConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMsgConfigResponse
        /// </returns>
        public GetMsgConfigResponse GetMsgConfig(GetMsgConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMsgConfigHeaders headers = new GetMsgConfigHeaders();
            return GetMsgConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>消息规则配置和群属性接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMsgConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMsgConfigResponse
        /// </returns>
        public async Task<GetMsgConfigResponse> GetMsgConfigAsync(GetMsgConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMsgConfigHeaders headers = new GetMsgConfigHeaders();
            return await GetMsgConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取消息定位链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMsgLocationRequest
        /// </param>
        /// <param name="headers">
        /// GetMsgLocationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMsgLocationResponse
        /// </returns>
        public GetMsgLocationResponse GetMsgLocationWithOptions(GetMsgLocationRequest request, GetMsgLocationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenMsgId))
            {
                body["openMsgId"] = request.OpenMsgId;
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
                Action = "GetMsgLocation",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/messageLocations/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMsgLocationResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取消息定位链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMsgLocationRequest
        /// </param>
        /// <param name="headers">
        /// GetMsgLocationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMsgLocationResponse
        /// </returns>
        public async Task<GetMsgLocationResponse> GetMsgLocationWithOptionsAsync(GetMsgLocationRequest request, GetMsgLocationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenMsgId))
            {
                body["openMsgId"] = request.OpenMsgId;
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
                Action = "GetMsgLocation",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/messageLocations/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMsgLocationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取消息定位链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMsgLocationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMsgLocationResponse
        /// </returns>
        public GetMsgLocationResponse GetMsgLocation(GetMsgLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMsgLocationHeaders headers = new GetMsgLocationHeaders();
            return GetMsgLocationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取消息定位链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMsgLocationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMsgLocationResponse
        /// </returns>
        public async Task<GetMsgLocationResponse> GetMsgLocationAsync(GetMsgLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMsgLocationHeaders headers = new GetMsgLocationHeaders();
            return await GetMsgLocationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取oa后台操作日志记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOaOperatorLogListRequest
        /// </param>
        /// <param name="headers">
        /// GetOaOperatorLogListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOaOperatorLogListResponse
        /// </returns>
        public GetOaOperatorLogListResponse GetOaOperatorLogListWithOptions(GetOaOperatorLogListRequest request, GetOaOperatorLogListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryList))
            {
                body["categoryList"] = request.CategoryList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
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
                Action = "GetOaOperatorLogList",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/oaOperatorLogs/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOaOperatorLogListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取oa后台操作日志记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOaOperatorLogListRequest
        /// </param>
        /// <param name="headers">
        /// GetOaOperatorLogListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOaOperatorLogListResponse
        /// </returns>
        public async Task<GetOaOperatorLogListResponse> GetOaOperatorLogListWithOptionsAsync(GetOaOperatorLogListRequest request, GetOaOperatorLogListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryList))
            {
                body["categoryList"] = request.CategoryList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
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
                Action = "GetOaOperatorLogList",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/oaOperatorLogs/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOaOperatorLogListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取oa后台操作日志记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOaOperatorLogListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOaOperatorLogListResponse
        /// </returns>
        public GetOaOperatorLogListResponse GetOaOperatorLogList(GetOaOperatorLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOaOperatorLogListHeaders headers = new GetOaOperatorLogListHeaders();
            return GetOaOperatorLogListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取oa后台操作日志记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOaOperatorLogListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOaOperatorLogListResponse
        /// </returns>
        public async Task<GetOaOperatorLogListResponse> GetOaOperatorLogListAsync(GetOaOperatorLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOaOperatorLogListHeaders headers = new GetOaOperatorLogListHeaders();
            return await GetOaOperatorLogListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业的外部审计群列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOutGroupsByPageRequest
        /// </param>
        /// <param name="headers">
        /// GetOutGroupsByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOutGroupsByPageResponse
        /// </returns>
        public GetOutGroupsByPageResponse GetOutGroupsByPageWithOptions(GetOutGroupsByPageRequest request, GetOutGroupsByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetOutGroupsByPage",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/audits/outsideGroups/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOutGroupsByPageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业的外部审计群列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOutGroupsByPageRequest
        /// </param>
        /// <param name="headers">
        /// GetOutGroupsByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOutGroupsByPageResponse
        /// </returns>
        public async Task<GetOutGroupsByPageResponse> GetOutGroupsByPageWithOptionsAsync(GetOutGroupsByPageRequest request, GetOutGroupsByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetOutGroupsByPage",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/audits/outsideGroups/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOutGroupsByPageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业的外部审计群列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOutGroupsByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOutGroupsByPageResponse
        /// </returns>
        public GetOutGroupsByPageResponse GetOutGroupsByPage(GetOutGroupsByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOutGroupsByPageHeaders headers = new GetOutGroupsByPageHeaders();
            return GetOutGroupsByPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业的外部审计群列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOutGroupsByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOutGroupsByPageResponse
        /// </returns>
        public async Task<GetOutGroupsByPageResponse> GetOutGroupsByPageAsync(GetOutGroupsByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOutGroupsByPageHeaders headers = new GetOutGroupsByPageHeaders();
            return await GetOutGroupsByPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取外部审计群消息记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOutsideAuditGroupMessageByPageRequest
        /// </param>
        /// <param name="headers">
        /// GetOutsideAuditGroupMessageByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOutsideAuditGroupMessageByPageResponse
        /// </returns>
        public GetOutsideAuditGroupMessageByPageResponse GetOutsideAuditGroupMessageByPageWithOptions(GetOutsideAuditGroupMessageByPageRequest request, GetOutsideAuditGroupMessageByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetOutsideAuditGroupMessageByPage",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/audits/outsideGroups/messages/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOutsideAuditGroupMessageByPageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取外部审计群消息记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOutsideAuditGroupMessageByPageRequest
        /// </param>
        /// <param name="headers">
        /// GetOutsideAuditGroupMessageByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOutsideAuditGroupMessageByPageResponse
        /// </returns>
        public async Task<GetOutsideAuditGroupMessageByPageResponse> GetOutsideAuditGroupMessageByPageWithOptionsAsync(GetOutsideAuditGroupMessageByPageRequest request, GetOutsideAuditGroupMessageByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetOutsideAuditGroupMessageByPage",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/audits/outsideGroups/messages/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOutsideAuditGroupMessageByPageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取外部审计群消息记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOutsideAuditGroupMessageByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOutsideAuditGroupMessageByPageResponse
        /// </returns>
        public GetOutsideAuditGroupMessageByPageResponse GetOutsideAuditGroupMessageByPage(GetOutsideAuditGroupMessageByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOutsideAuditGroupMessageByPageHeaders headers = new GetOutsideAuditGroupMessageByPageHeaders();
            return GetOutsideAuditGroupMessageByPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取外部审计群消息记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOutsideAuditGroupMessageByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOutsideAuditGroupMessageByPageResponse
        /// </returns>
        public async Task<GetOutsideAuditGroupMessageByPageResponse> GetOutsideAuditGroupMessageByPageAsync(GetOutsideAuditGroupMessageByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOutsideAuditGroupMessageByPageHeaders headers = new GetOutsideAuditGroupMessageByPageHeaders();
            return await GetOutsideAuditGroupMessageByPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>伙伴钉根据父标签查询子标签</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetPartnerTypeByParentIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPartnerTypeByParentIdResponse
        /// </returns>
        public GetPartnerTypeByParentIdResponse GetPartnerTypeByParentIdWithOptions(string parentId, GetPartnerTypeByParentIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPartnerTypeByParentId",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/partnerLabels/" + parentId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPartnerTypeByParentIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>伙伴钉根据父标签查询子标签</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetPartnerTypeByParentIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPartnerTypeByParentIdResponse
        /// </returns>
        public async Task<GetPartnerTypeByParentIdResponse> GetPartnerTypeByParentIdWithOptionsAsync(string parentId, GetPartnerTypeByParentIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPartnerTypeByParentId",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/partnerLabels/" + parentId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPartnerTypeByParentIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>伙伴钉根据父标签查询子标签</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPartnerTypeByParentIdResponse
        /// </returns>
        public GetPartnerTypeByParentIdResponse GetPartnerTypeByParentId(string parentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPartnerTypeByParentIdHeaders headers = new GetPartnerTypeByParentIdHeaders();
            return GetPartnerTypeByParentIdWithOptions(parentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>伙伴钉根据父标签查询子标签</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPartnerTypeByParentIdResponse
        /// </returns>
        public async Task<GetPartnerTypeByParentIdResponse> GetPartnerTypeByParentIdAsync(string parentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPartnerTypeByParentIdHeaders headers = new GetPartnerTypeByParentIdHeaders();
            return await GetPartnerTypeByParentIdWithOptionsAsync(parentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取公共设备列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPublicDevicesRequest
        /// </param>
        /// <param name="headers">
        /// GetPublicDevicesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPublicDevicesResponse
        /// </returns>
        public GetPublicDevicesResponse GetPublicDevicesWithOptions(GetPublicDevicesRequest request, GetPublicDevicesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MacAddress))
            {
                query["macAddress"] = request.MacAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetPublicDevices",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/trusts/publicDevices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPublicDevicesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取公共设备列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPublicDevicesRequest
        /// </param>
        /// <param name="headers">
        /// GetPublicDevicesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPublicDevicesResponse
        /// </returns>
        public async Task<GetPublicDevicesResponse> GetPublicDevicesWithOptionsAsync(GetPublicDevicesRequest request, GetPublicDevicesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MacAddress))
            {
                query["macAddress"] = request.MacAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetPublicDevices",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/trusts/publicDevices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPublicDevicesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取公共设备列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPublicDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPublicDevicesResponse
        /// </returns>
        public GetPublicDevicesResponse GetPublicDevices(GetPublicDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPublicDevicesHeaders headers = new GetPublicDevicesHeaders();
            return GetPublicDevicesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取公共设备列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPublicDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPublicDevicesResponse
        /// </returns>
        public async Task<GetPublicDevicesResponse> GetPublicDevicesAsync(GetPublicDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPublicDevicesHeaders headers = new GetPublicDevicesHeaders();
            return await GetPublicDevicesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取互动服务窗相关数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPublisherSummaryRequest
        /// </param>
        /// <param name="headers">
        /// GetPublisherSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPublisherSummaryResponse
        /// </returns>
        public GetPublisherSummaryResponse GetPublisherSummaryWithOptions(string dataId, GetPublisherSummaryRequest request, GetPublisherSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPublisherSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/publisher/" + dataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPublisherSummaryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取互动服务窗相关数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPublisherSummaryRequest
        /// </param>
        /// <param name="headers">
        /// GetPublisherSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPublisherSummaryResponse
        /// </returns>
        public async Task<GetPublisherSummaryResponse> GetPublisherSummaryWithOptionsAsync(string dataId, GetPublisherSummaryRequest request, GetPublisherSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPublisherSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/publisher/" + dataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPublisherSummaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取互动服务窗相关数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPublisherSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPublisherSummaryResponse
        /// </returns>
        public GetPublisherSummaryResponse GetPublisherSummary(string dataId, GetPublisherSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPublisherSummaryHeaders headers = new GetPublisherSummaryHeaders();
            return GetPublisherSummaryWithOptions(dataId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取互动服务窗相关数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPublisherSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPublisherSummaryResponse
        /// </returns>
        public async Task<GetPublisherSummaryResponse> GetPublisherSummaryAsync(string dataId, GetPublisherSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPublisherSummaryHeaders headers = new GetPublisherSummaryHeaders();
            return await GetPublisherSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实人认证接口调用记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRealPeopleRecordsRequest
        /// </param>
        /// <param name="headers">
        /// GetRealPeopleRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRealPeopleRecordsResponse
        /// </returns>
        public GetRealPeopleRecordsResponse GetRealPeopleRecordsWithOptions(GetRealPeopleRecordsRequest request, GetRealPeopleRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromTime))
            {
                body["fromTime"] = request.FromTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonIdentification))
            {
                body["personIdentification"] = request.PersonIdentification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToTime))
            {
                body["toTime"] = request.ToTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetRealPeopleRecords",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/persons/identificationRecords/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRealPeopleRecordsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实人认证接口调用记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRealPeopleRecordsRequest
        /// </param>
        /// <param name="headers">
        /// GetRealPeopleRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRealPeopleRecordsResponse
        /// </returns>
        public async Task<GetRealPeopleRecordsResponse> GetRealPeopleRecordsWithOptionsAsync(GetRealPeopleRecordsRequest request, GetRealPeopleRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromTime))
            {
                body["fromTime"] = request.FromTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonIdentification))
            {
                body["personIdentification"] = request.PersonIdentification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToTime))
            {
                body["toTime"] = request.ToTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetRealPeopleRecords",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/persons/identificationRecords/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRealPeopleRecordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实人认证接口调用记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRealPeopleRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRealPeopleRecordsResponse
        /// </returns>
        public GetRealPeopleRecordsResponse GetRealPeopleRecords(GetRealPeopleRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRealPeopleRecordsHeaders headers = new GetRealPeopleRecordsHeaders();
            return GetRealPeopleRecordsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实人认证接口调用记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRealPeopleRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRealPeopleRecordsResponse
        /// </returns>
        public async Task<GetRealPeopleRecordsResponse> GetRealPeopleRecordsAsync(GetRealPeopleRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRealPeopleRecordsHeaders headers = new GetRealPeopleRecordsHeaders();
            return await GetRealPeopleRecordsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取人脸对比接口调用记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecognizeRecordsRequest
        /// </param>
        /// <param name="headers">
        /// GetRecognizeRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecognizeRecordsResponse
        /// </returns>
        public GetRecognizeRecordsResponse GetRecognizeRecordsWithOptions(GetRecognizeRecordsRequest request, GetRecognizeRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceCompareResult))
            {
                body["faceCompareResult"] = request.FaceCompareResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromTime))
            {
                body["fromTime"] = request.FromTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToTime))
            {
                body["toTime"] = request.ToTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetRecognizeRecords",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/faces/recognizeRecords/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecognizeRecordsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取人脸对比接口调用记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecognizeRecordsRequest
        /// </param>
        /// <param name="headers">
        /// GetRecognizeRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecognizeRecordsResponse
        /// </returns>
        public async Task<GetRecognizeRecordsResponse> GetRecognizeRecordsWithOptionsAsync(GetRecognizeRecordsRequest request, GetRecognizeRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceCompareResult))
            {
                body["faceCompareResult"] = request.FaceCompareResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromTime))
            {
                body["fromTime"] = request.FromTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToTime))
            {
                body["toTime"] = request.ToTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetRecognizeRecords",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/faces/recognizeRecords/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecognizeRecordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取人脸对比接口调用记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecognizeRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecognizeRecordsResponse
        /// </returns>
        public GetRecognizeRecordsResponse GetRecognizeRecords(GetRecognizeRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecognizeRecordsHeaders headers = new GetRecognizeRecordsHeaders();
            return GetRecognizeRecordsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取人脸对比接口调用记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecognizeRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecognizeRecordsResponse
        /// </returns>
        public async Task<GetRecognizeRecordsResponse> GetRecognizeRecordsAsync(GetRecognizeRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecognizeRecordsHeaders headers = new GetRecognizeRecordsHeaders();
            return await GetRecognizeRecordsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全管控卡片成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecurityConfigMemberRequest
        /// </param>
        /// <param name="headers">
        /// GetSecurityConfigMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecurityConfigMemberResponse
        /// </returns>
        public GetSecurityConfigMemberResponse GetSecurityConfigMemberWithOptions(GetSecurityConfigMemberRequest request, GetSecurityConfigMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKey))
            {
                body["configKey"] = request.ConfigKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetSecurityConfigMember",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/securities/configs/members/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecurityConfigMemberResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全管控卡片成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecurityConfigMemberRequest
        /// </param>
        /// <param name="headers">
        /// GetSecurityConfigMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecurityConfigMemberResponse
        /// </returns>
        public async Task<GetSecurityConfigMemberResponse> GetSecurityConfigMemberWithOptionsAsync(GetSecurityConfigMemberRequest request, GetSecurityConfigMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKey))
            {
                body["configKey"] = request.ConfigKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetSecurityConfigMember",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/securities/configs/members/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecurityConfigMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全管控卡片成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecurityConfigMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecurityConfigMemberResponse
        /// </returns>
        public GetSecurityConfigMemberResponse GetSecurityConfigMember(GetSecurityConfigMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSecurityConfigMemberHeaders headers = new GetSecurityConfigMemberHeaders();
            return GetSecurityConfigMemberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全管控卡片成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecurityConfigMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecurityConfigMemberResponse
        /// </returns>
        public async Task<GetSecurityConfigMemberResponse> GetSecurityConfigMemberAsync(GetSecurityConfigMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSecurityConfigMemberHeaders headers = new GetSecurityConfigMemberHeaders();
            return await GetSecurityConfigMemberWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审计协议签署人员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSignedDetailByPageRequest
        /// </param>
        /// <param name="headers">
        /// GetSignedDetailByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSignedDetailByPageResponse
        /// </returns>
        public GetSignedDetailByPageResponse GetSignedDetailByPageWithOptions(GetSignedDetailByPageRequest request, GetSignedDetailByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignStatus))
            {
                query["signStatus"] = request.SignStatus;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetSignedDetailByPage",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/audits/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSignedDetailByPageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审计协议签署人员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSignedDetailByPageRequest
        /// </param>
        /// <param name="headers">
        /// GetSignedDetailByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSignedDetailByPageResponse
        /// </returns>
        public async Task<GetSignedDetailByPageResponse> GetSignedDetailByPageWithOptionsAsync(GetSignedDetailByPageRequest request, GetSignedDetailByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignStatus))
            {
                query["signStatus"] = request.SignStatus;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetSignedDetailByPage",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/audits/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSignedDetailByPageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审计协议签署人员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSignedDetailByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSignedDetailByPageResponse
        /// </returns>
        public GetSignedDetailByPageResponse GetSignedDetailByPage(GetSignedDetailByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignedDetailByPageHeaders headers = new GetSignedDetailByPageHeaders();
            return GetSignedDetailByPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取审计协议签署人员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSignedDetailByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSignedDetailByPageResponse
        /// </returns>
        public async Task<GetSignedDetailByPageResponse> GetSignedDetailByPageAsync(GetSignedDetailByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignedDetailByPageHeaders headers = new GetSignedDetailByPageHeaders();
            return await GetSignedDetailByPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取多个可信设备信息，包括mac地址、staffId、platform</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrustDeviceListRequest
        /// </param>
        /// <param name="headers">
        /// GetTrustDeviceListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTrustDeviceListResponse
        /// </returns>
        public GetTrustDeviceListResponse GetTrustDeviceListWithOptions(GetTrustDeviceListRequest request, GetTrustDeviceListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreateEnd))
            {
                body["gmtCreateEnd"] = request.GmtCreateEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreateStart))
            {
                body["gmtCreateStart"] = request.GmtCreateStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtModifiedEnd))
            {
                body["gmtModifiedEnd"] = request.GmtModifiedEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtModifiedStart))
            {
                body["gmtModifiedStart"] = request.GmtModifiedStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MacAddress))
            {
                body["macAddress"] = request.MacAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetTrustDeviceList",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/trustedDevices/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrustDeviceListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取多个可信设备信息，包括mac地址、staffId、platform</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrustDeviceListRequest
        /// </param>
        /// <param name="headers">
        /// GetTrustDeviceListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTrustDeviceListResponse
        /// </returns>
        public async Task<GetTrustDeviceListResponse> GetTrustDeviceListWithOptionsAsync(GetTrustDeviceListRequest request, GetTrustDeviceListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreateEnd))
            {
                body["gmtCreateEnd"] = request.GmtCreateEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreateStart))
            {
                body["gmtCreateStart"] = request.GmtCreateStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtModifiedEnd))
            {
                body["gmtModifiedEnd"] = request.GmtModifiedEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtModifiedStart))
            {
                body["gmtModifiedStart"] = request.GmtModifiedStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MacAddress))
            {
                body["macAddress"] = request.MacAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetTrustDeviceList",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/trustedDevices/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrustDeviceListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取多个可信设备信息，包括mac地址、staffId、platform</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrustDeviceListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTrustDeviceListResponse
        /// </returns>
        public GetTrustDeviceListResponse GetTrustDeviceList(GetTrustDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTrustDeviceListHeaders headers = new GetTrustDeviceListHeaders();
            return GetTrustDeviceListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取多个可信设备信息，包括mac地址、staffId、platform</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrustDeviceListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTrustDeviceListResponse
        /// </returns>
        public async Task<GetTrustDeviceListResponse> GetTrustDeviceListAsync(GetTrustDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTrustDeviceListHeaders headers = new GetTrustDeviceListHeaders();
            return await GetTrustDeviceListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得组织维度用户版本分布情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserAppVersionSummaryRequest
        /// </param>
        /// <param name="headers">
        /// GetUserAppVersionSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserAppVersionSummaryResponse
        /// </returns>
        public GetUserAppVersionSummaryResponse GetUserAppVersionSummaryWithOptions(string dataId, GetUserAppVersionSummaryRequest request, GetUserAppVersionSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetUserAppVersionSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/appVersion/org/" + dataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserAppVersionSummaryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得组织维度用户版本分布情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserAppVersionSummaryRequest
        /// </param>
        /// <param name="headers">
        /// GetUserAppVersionSummaryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserAppVersionSummaryResponse
        /// </returns>
        public async Task<GetUserAppVersionSummaryResponse> GetUserAppVersionSummaryWithOptionsAsync(string dataId, GetUserAppVersionSummaryRequest request, GetUserAppVersionSummaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetUserAppVersionSummary",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/appVersion/org/" + dataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserAppVersionSummaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得组织维度用户版本分布情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserAppVersionSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserAppVersionSummaryResponse
        /// </returns>
        public GetUserAppVersionSummaryResponse GetUserAppVersionSummary(string dataId, GetUserAppVersionSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserAppVersionSummaryHeaders headers = new GetUserAppVersionSummaryHeaders();
            return GetUserAppVersionSummaryWithOptions(dataId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得组织维度用户版本分布情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserAppVersionSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserAppVersionSummaryResponse
        /// </returns>
        public async Task<GetUserAppVersionSummaryResponse> GetUserAppVersionSummaryAsync(string dataId, GetUserAppVersionSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserAppVersionSummaryHeaders headers = new GetUserAppVersionSummaryHeaders();
            return await GetUserAppVersionSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人脸录入状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserFaceStateRequest
        /// </param>
        /// <param name="headers">
        /// GetUserFaceStateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserFaceStateResponse
        /// </returns>
        public GetUserFaceStateResponse GetUserFaceStateWithOptions(GetUserFaceStateRequest request, GetUserFaceStateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetUserFaceState",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/faces/recognizeStates/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserFaceStateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人脸录入状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserFaceStateRequest
        /// </param>
        /// <param name="headers">
        /// GetUserFaceStateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserFaceStateResponse
        /// </returns>
        public async Task<GetUserFaceStateResponse> GetUserFaceStateWithOptionsAsync(GetUserFaceStateRequest request, GetUserFaceStateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetUserFaceState",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/faces/recognizeStates/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserFaceStateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人脸录入状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserFaceStateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserFaceStateResponse
        /// </returns>
        public GetUserFaceStateResponse GetUserFaceState(GetUserFaceStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserFaceStateHeaders headers = new GetUserFaceStateHeaders();
            return GetUserFaceStateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人脸录入状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserFaceStateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserFaceStateResponse
        /// </returns>
        public async Task<GetUserFaceStateResponse> GetUserFaceStateAsync(GetUserFaceStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserFaceStateHeaders headers = new GetUserFaceStateHeaders();
            return await GetUserFaceStateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实人认证状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRealPeopleStateRequest
        /// </param>
        /// <param name="headers">
        /// GetUserRealPeopleStateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserRealPeopleStateResponse
        /// </returns>
        public GetUserRealPeopleStateResponse GetUserRealPeopleStateWithOptions(GetUserRealPeopleStateRequest request, GetUserRealPeopleStateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetUserRealPeopleState",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/persons/identificationStates/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserRealPeopleStateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实人认证状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRealPeopleStateRequest
        /// </param>
        /// <param name="headers">
        /// GetUserRealPeopleStateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserRealPeopleStateResponse
        /// </returns>
        public async Task<GetUserRealPeopleStateResponse> GetUserRealPeopleStateWithOptionsAsync(GetUserRealPeopleStateRequest request, GetUserRealPeopleStateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetUserRealPeopleState",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/persons/identificationStates/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserRealPeopleStateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实人认证状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRealPeopleStateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserRealPeopleStateResponse
        /// </returns>
        public GetUserRealPeopleStateResponse GetUserRealPeopleState(GetUserRealPeopleStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserRealPeopleStateHeaders headers = new GetUserRealPeopleStateHeaders();
            return GetUserRealPeopleStateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实人认证状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRealPeopleStateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserRealPeopleStateResponse
        /// </returns>
        public async Task<GetUserRealPeopleStateResponse> GetUserRealPeopleStateAsync(GetUserRealPeopleStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserRealPeopleStateHeaders headers = new GetUserRealPeopleStateHeaders();
            return await GetUserRealPeopleStateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户停留时长</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserStayLengthRequest
        /// </param>
        /// <param name="headers">
        /// GetUserStayLengthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserStayLengthResponse
        /// </returns>
        public GetUserStayLengthResponse GetUserStayLengthWithOptions(GetUserStayLengthRequest request, GetUserStayLengthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetUserStayLength",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/users/stayTimes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserStayLengthResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户停留时长</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserStayLengthRequest
        /// </param>
        /// <param name="headers">
        /// GetUserStayLengthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserStayLengthResponse
        /// </returns>
        public async Task<GetUserStayLengthResponse> GetUserStayLengthWithOptionsAsync(GetUserStayLengthRequest request, GetUserStayLengthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetUserStayLength",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/data/users/stayTimes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserStayLengthResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户停留时长</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserStayLengthRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserStayLengthResponse
        /// </returns>
        public GetUserStayLengthResponse GetUserStayLength(GetUserStayLengthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserStayLengthHeaders headers = new GetUserStayLengthHeaders();
            return GetUserStayLengthWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户停留时长</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserStayLengthRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserStayLengthResponse
        /// </returns>
        public async Task<GetUserStayLengthResponse> GetUserStayLengthAsync(GetUserStayLengthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserStayLengthHeaders headers = new GetUserStayLengthHeaders();
            return await GetUserStayLengthWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件病毒扫描结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVirusScanResultRequest
        /// </param>
        /// <param name="headers">
        /// GetVirusScanResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVirusScanResultResponse
        /// </returns>
        public GetVirusScanResultResponse GetVirusScanResultWithOptions(GetVirusScanResultRequest request, GetVirusScanResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetVirusScanResult",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/virusScanTasks/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVirusScanResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件病毒扫描结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVirusScanResultRequest
        /// </param>
        /// <param name="headers">
        /// GetVirusScanResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVirusScanResultResponse
        /// </returns>
        public async Task<GetVirusScanResultResponse> GetVirusScanResultWithOptionsAsync(GetVirusScanResultRequest request, GetVirusScanResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetVirusScanResult",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/virusScanTasks/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVirusScanResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件病毒扫描结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVirusScanResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVirusScanResultResponse
        /// </returns>
        public GetVirusScanResultResponse GetVirusScanResult(GetVirusScanResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetVirusScanResultHeaders headers = new GetVirusScanResultHeaders();
            return GetVirusScanResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件病毒扫描结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVirusScanResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVirusScanResultResponse
        /// </returns>
        public async Task<GetVirusScanResultResponse> GetVirusScanResultAsync(GetVirusScanResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetVirusScanResultHeaders headers = new GetVirusScanResultHeaders();
            return await GetVirusScanResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据群属性查询群ID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupQueryByAttrRequest
        /// </param>
        /// <param name="headers">
        /// GroupQueryByAttrHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GroupQueryByAttrResponse
        /// </returns>
        public GroupQueryByAttrResponse GroupQueryByAttrWithOptions(GroupQueryByAttrRequest request, GroupQueryByAttrHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTopic))
            {
                body["groupTopic"] = request.GroupTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                body["groupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListDynamicAttr))
            {
                body["listDynamicAttr"] = request.ListDynamicAttr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GroupQueryByAttr",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/portals/groups/queryGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupQueryByAttrResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据群属性查询群ID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupQueryByAttrRequest
        /// </param>
        /// <param name="headers">
        /// GroupQueryByAttrHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GroupQueryByAttrResponse
        /// </returns>
        public async Task<GroupQueryByAttrResponse> GroupQueryByAttrWithOptionsAsync(GroupQueryByAttrRequest request, GroupQueryByAttrHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTopic))
            {
                body["groupTopic"] = request.GroupTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                body["groupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListDynamicAttr))
            {
                body["listDynamicAttr"] = request.ListDynamicAttr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GroupQueryByAttr",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/portals/groups/queryGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupQueryByAttrResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据群属性查询群ID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupQueryByAttrRequest
        /// </param>
        /// 
        /// <returns>
        /// GroupQueryByAttrResponse
        /// </returns>
        public GroupQueryByAttrResponse GroupQueryByAttr(GroupQueryByAttrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupQueryByAttrHeaders headers = new GroupQueryByAttrHeaders();
            return GroupQueryByAttrWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据群属性查询群ID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupQueryByAttrRequest
        /// </param>
        /// 
        /// <returns>
        /// GroupQueryByAttrResponse
        /// </returns>
        public async Task<GroupQueryByAttrResponse> GroupQueryByAttrAsync(GroupQueryByAttrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupQueryByAttrHeaders headers = new GroupQueryByAttrHeaders();
            return await GroupQueryByAttrWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据群ID查询群属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupQueryByOpenIdRequest
        /// </param>
        /// <param name="headers">
        /// GroupQueryByOpenIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GroupQueryByOpenIdResponse
        /// </returns>
        public GroupQueryByOpenIdResponse GroupQueryByOpenIdWithOptions(GroupQueryByOpenIdRequest request, GroupQueryByOpenIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GroupQueryByOpenId",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/portals/groups/getGroupByOpenConversationId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupQueryByOpenIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据群ID查询群属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupQueryByOpenIdRequest
        /// </param>
        /// <param name="headers">
        /// GroupQueryByOpenIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GroupQueryByOpenIdResponse
        /// </returns>
        public async Task<GroupQueryByOpenIdResponse> GroupQueryByOpenIdWithOptionsAsync(GroupQueryByOpenIdRequest request, GroupQueryByOpenIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GroupQueryByOpenId",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/portals/groups/getGroupByOpenConversationId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupQueryByOpenIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据群ID查询群属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupQueryByOpenIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GroupQueryByOpenIdResponse
        /// </returns>
        public GroupQueryByOpenIdResponse GroupQueryByOpenId(GroupQueryByOpenIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupQueryByOpenIdHeaders headers = new GroupQueryByOpenIdHeaders();
            return GroupQueryByOpenIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据群ID查询群属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupQueryByOpenIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GroupQueryByOpenIdResponse
        /// </returns>
        public async Task<GroupQueryByOpenIdResponse> GroupQueryByOpenIdAsync(GroupQueryByOpenIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupQueryByOpenIdHeaders headers = new GroupQueryByOpenIdHeaders();
            return await GroupQueryByOpenIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业文件审计日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuditLogRequest
        /// </param>
        /// <param name="headers">
        /// ListAuditLogHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuditLogResponse
        /// </returns>
        public ListAuditLogResponse ListAuditLogWithOptions(ListAuditLogRequest request, ListAuditLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextBizId))
            {
                query["nextBizId"] = request.NextBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextGmtCreate))
            {
                query["nextGmtCreate"] = request.NextGmtCreate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["startDate"] = request.StartDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListAuditLog",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileAuditLogs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuditLogResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业文件审计日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuditLogRequest
        /// </param>
        /// <param name="headers">
        /// ListAuditLogHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuditLogResponse
        /// </returns>
        public async Task<ListAuditLogResponse> ListAuditLogWithOptionsAsync(ListAuditLogRequest request, ListAuditLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextBizId))
            {
                query["nextBizId"] = request.NextBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextGmtCreate))
            {
                query["nextGmtCreate"] = request.NextGmtCreate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["startDate"] = request.StartDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListAuditLog",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileAuditLogs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuditLogResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业文件审计日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuditLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuditLogResponse
        /// </returns>
        public ListAuditLogResponse ListAuditLog(ListAuditLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAuditLogHeaders headers = new ListAuditLogHeaders();
            return ListAuditLogWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业文件审计日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuditLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuditLogResponse
        /// </returns>
        public async Task<ListAuditLogResponse> ListAuditLogAsync(ListAuditLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAuditLogHeaders headers = new ListAuditLogHeaders();
            return await ListAuditLogWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据机器人code列表查询机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListByCodesRequest
        /// </param>
        /// <param name="headers">
        /// ListByCodesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListByCodesResponse
        /// </returns>
        public ListByCodesResponse ListByCodesWithOptions(ListByCodesRequest request, ListByCodesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListByCodes",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/sceneGroups/robotInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListByCodesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据机器人code列表查询机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListByCodesRequest
        /// </param>
        /// <param name="headers">
        /// ListByCodesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListByCodesResponse
        /// </returns>
        public async Task<ListByCodesResponse> ListByCodesWithOptionsAsync(ListByCodesRequest request, ListByCodesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListByCodes",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/sceneGroups/robotInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListByCodesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据机器人code列表查询机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListByCodesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListByCodesResponse
        /// </returns>
        public ListByCodesResponse ListByCodes(ListByCodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListByCodesHeaders headers = new ListByCodesHeaders();
            return ListByCodesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据机器人code列表查询机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListByCodesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListByCodesResponse
        /// </returns>
        public async Task<ListByCodesResponse> ListByCodesAsync(ListByCodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListByCodesHeaders headers = new ListByCodesHeaders();
            return await ListByCodesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据插件id列表查询插件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListByPluginIdsRequest
        /// </param>
        /// <param name="headers">
        /// ListByPluginIdsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListByPluginIdsResponse
        /// </returns>
        public ListByPluginIdsResponse ListByPluginIdsWithOptions(ListByPluginIdsRequest request, ListByPluginIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListByPluginIds",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/sceneGroups/pluginInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListByPluginIdsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据插件id列表查询插件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListByPluginIdsRequest
        /// </param>
        /// <param name="headers">
        /// ListByPluginIdsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListByPluginIdsResponse
        /// </returns>
        public async Task<ListByPluginIdsResponse> ListByPluginIdsWithOptionsAsync(ListByPluginIdsRequest request, ListByPluginIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListByPluginIds",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/sceneGroups/pluginInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListByPluginIdsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据插件id列表查询插件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListByPluginIdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListByPluginIdsResponse
        /// </returns>
        public ListByPluginIdsResponse ListByPluginIds(ListByPluginIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListByPluginIdsHeaders headers = new ListByPluginIdsHeaders();
            return ListByPluginIdsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据插件id列表查询插件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListByPluginIdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListByPluginIdsResponse
        /// </returns>
        public async Task<ListByPluginIdsResponse> ListByPluginIdsAsync(ListByPluginIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListByPluginIdsHeaders headers = new ListByPluginIdsHeaders();
            return await ListByPluginIdsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分组列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListCategorysRequest
        /// </param>
        /// <param name="headers">
        /// ListCategorysHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCategorysResponse
        /// </returns>
        public ListCategorysResponse ListCategorysWithOptions(ListCategorysRequest tmpReq, ListCategorysHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCategorysShrinkRequest request = new ListCategorysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListCategorys",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/messageCategories/categories/listCategories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCategorysResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分组列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListCategorysRequest
        /// </param>
        /// <param name="headers">
        /// ListCategorysHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCategorysResponse
        /// </returns>
        public async Task<ListCategorysResponse> ListCategorysWithOptionsAsync(ListCategorysRequest tmpReq, ListCategorysHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCategorysShrinkRequest request = new ListCategorysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListCategorys",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/messageCategories/categories/listCategories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCategorysResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCategorysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCategorysResponse
        /// </returns>
        public ListCategorysResponse ListCategorys(ListCategorysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCategorysHeaders headers = new ListCategorysHeaders();
            return ListCategorysWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCategorysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCategorysResponse
        /// </returns>
        public async Task<ListCategorysResponse> ListCategorysAsync(ListCategorysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCategorysHeaders headers = new ListCategorysHeaders();
            return await ListCategorysWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过手机号获取已加入的属于渠道组织的列表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJoinOrgInfoRequest
        /// </param>
        /// <param name="headers">
        /// ListJoinOrgInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJoinOrgInfoResponse
        /// </returns>
        public ListJoinOrgInfoResponse ListJoinOrgInfoWithOptions(ListJoinOrgInfoRequest request, ListJoinOrgInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListJoinOrgInfo",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/exclusiveAccounts/organizations/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJoinOrgInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过手机号获取已加入的属于渠道组织的列表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJoinOrgInfoRequest
        /// </param>
        /// <param name="headers">
        /// ListJoinOrgInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJoinOrgInfoResponse
        /// </returns>
        public async Task<ListJoinOrgInfoResponse> ListJoinOrgInfoWithOptionsAsync(ListJoinOrgInfoRequest request, ListJoinOrgInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListJoinOrgInfo",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/exclusiveAccounts/organizations/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJoinOrgInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过手机号获取已加入的属于渠道组织的列表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJoinOrgInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJoinOrgInfoResponse
        /// </returns>
        public ListJoinOrgInfoResponse ListJoinOrgInfo(ListJoinOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListJoinOrgInfoHeaders headers = new ListJoinOrgInfoHeaders();
            return ListJoinOrgInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过手机号获取已加入的属于渠道组织的列表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJoinOrgInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJoinOrgInfoResponse
        /// </returns>
        public async Task<ListJoinOrgInfoResponse> ListJoinOrgInfoAsync(ListJoinOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListJoinOrgInfoHeaders headers = new ListJoinOrgInfoHeaders();
            return await ListJoinOrgInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小程序版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMiniAppAvailableVersionRequest
        /// </param>
        /// <param name="headers">
        /// ListMiniAppAvailableVersionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMiniAppAvailableVersionResponse
        /// </returns>
        public ListMiniAppAvailableVersionResponse ListMiniAppAvailableVersionWithOptions(ListMiniAppAvailableVersionRequest request, ListMiniAppAvailableVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionTypeSet))
            {
                body["versionTypeSet"] = request.VersionTypeSet;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ListMiniAppAvailableVersion",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/miniApps/versions/availableLists",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMiniAppAvailableVersionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小程序版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMiniAppAvailableVersionRequest
        /// </param>
        /// <param name="headers">
        /// ListMiniAppAvailableVersionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMiniAppAvailableVersionResponse
        /// </returns>
        public async Task<ListMiniAppAvailableVersionResponse> ListMiniAppAvailableVersionWithOptionsAsync(ListMiniAppAvailableVersionRequest request, ListMiniAppAvailableVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionTypeSet))
            {
                body["versionTypeSet"] = request.VersionTypeSet;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ListMiniAppAvailableVersion",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/miniApps/versions/availableLists",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMiniAppAvailableVersionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小程序版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMiniAppAvailableVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMiniAppAvailableVersionResponse
        /// </returns>
        public ListMiniAppAvailableVersionResponse ListMiniAppAvailableVersion(ListMiniAppAvailableVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMiniAppAvailableVersionHeaders headers = new ListMiniAppAvailableVersionHeaders();
            return ListMiniAppAvailableVersionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小程序版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMiniAppAvailableVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMiniAppAvailableVersionResponse
        /// </returns>
        public async Task<ListMiniAppAvailableVersionResponse> ListMiniAppAvailableVersionAsync(ListMiniAppAvailableVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMiniAppAvailableVersionHeaders headers = new ListMiniAppAvailableVersionHeaders();
            return await ListMiniAppAvailableVersionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小程序历史版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMiniAppHistoryVersionRequest
        /// </param>
        /// <param name="headers">
        /// ListMiniAppHistoryVersionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMiniAppHistoryVersionResponse
        /// </returns>
        public ListMiniAppHistoryVersionResponse ListMiniAppHistoryVersionWithOptions(ListMiniAppHistoryVersionRequest request, ListMiniAppHistoryVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
            }
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
                Action = "ListMiniAppHistoryVersion",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/miniApps/versions/historyLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMiniAppHistoryVersionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小程序历史版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMiniAppHistoryVersionRequest
        /// </param>
        /// <param name="headers">
        /// ListMiniAppHistoryVersionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMiniAppHistoryVersionResponse
        /// </returns>
        public async Task<ListMiniAppHistoryVersionResponse> ListMiniAppHistoryVersionWithOptionsAsync(ListMiniAppHistoryVersionRequest request, ListMiniAppHistoryVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
            }
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
                Action = "ListMiniAppHistoryVersion",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/miniApps/versions/historyLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMiniAppHistoryVersionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小程序历史版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMiniAppHistoryVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMiniAppHistoryVersionResponse
        /// </returns>
        public ListMiniAppHistoryVersionResponse ListMiniAppHistoryVersion(ListMiniAppHistoryVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMiniAppHistoryVersionHeaders headers = new ListMiniAppHistoryVersionHeaders();
            return ListMiniAppHistoryVersionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取小程序历史版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMiniAppHistoryVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMiniAppHistoryVersionResponse
        /// </returns>
        public async Task<ListMiniAppHistoryVersionResponse> ListMiniAppHistoryVersionAsync(ListMiniAppHistoryVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMiniAppHistoryVersionHeaders headers = new ListMiniAppHistoryVersionHeaders();
            return await ListMiniAppHistoryVersionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询伙伴角色</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListPartnerRolesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPartnerRolesResponse
        /// </returns>
        public ListPartnerRolesResponse ListPartnerRolesWithOptions(string parentId, ListPartnerRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListPartnerRoles",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/partners/roles/" + parentId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPartnerRolesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询伙伴角色</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListPartnerRolesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPartnerRolesResponse
        /// </returns>
        public async Task<ListPartnerRolesResponse> ListPartnerRolesWithOptionsAsync(string parentId, ListPartnerRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListPartnerRoles",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/partners/roles/" + parentId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPartnerRolesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询伙伴角色</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListPartnerRolesResponse
        /// </returns>
        public ListPartnerRolesResponse ListPartnerRoles(string parentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPartnerRolesHeaders headers = new ListPartnerRolesHeaders();
            return ListPartnerRolesWithOptions(parentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询伙伴角色</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListPartnerRolesResponse
        /// </returns>
        public async Task<ListPartnerRolesResponse> ListPartnerRolesAsync(string parentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPartnerRolesHeaders headers = new ListPartnerRolesHeaders();
            return await ListPartnerRolesWithOptionsAsync(parentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取巡点信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPunchScheduleByConditionWithPagingRequest
        /// </param>
        /// <param name="headers">
        /// ListPunchScheduleByConditionWithPagingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPunchScheduleByConditionWithPagingResponse
        /// </returns>
        public ListPunchScheduleByConditionWithPagingResponse ListPunchScheduleByConditionWithPagingWithOptions(ListPunchScheduleByConditionWithPagingRequest request, ListPunchScheduleByConditionWithPagingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizInstanceId))
            {
                body["bizInstanceId"] = request.BizInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleDateEnd))
            {
                body["scheduleDateEnd"] = request.ScheduleDateEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleDateStart))
            {
                body["scheduleDateStart"] = request.ScheduleDateStart;
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
                Action = "ListPunchScheduleByConditionWithPaging",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/punchSchedules/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPunchScheduleByConditionWithPagingResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取巡点信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPunchScheduleByConditionWithPagingRequest
        /// </param>
        /// <param name="headers">
        /// ListPunchScheduleByConditionWithPagingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPunchScheduleByConditionWithPagingResponse
        /// </returns>
        public async Task<ListPunchScheduleByConditionWithPagingResponse> ListPunchScheduleByConditionWithPagingWithOptionsAsync(ListPunchScheduleByConditionWithPagingRequest request, ListPunchScheduleByConditionWithPagingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizInstanceId))
            {
                body["bizInstanceId"] = request.BizInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleDateEnd))
            {
                body["scheduleDateEnd"] = request.ScheduleDateEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleDateStart))
            {
                body["scheduleDateStart"] = request.ScheduleDateStart;
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
                Action = "ListPunchScheduleByConditionWithPaging",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/punchSchedules/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPunchScheduleByConditionWithPagingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取巡点信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPunchScheduleByConditionWithPagingRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPunchScheduleByConditionWithPagingResponse
        /// </returns>
        public ListPunchScheduleByConditionWithPagingResponse ListPunchScheduleByConditionWithPaging(ListPunchScheduleByConditionWithPagingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPunchScheduleByConditionWithPagingHeaders headers = new ListPunchScheduleByConditionWithPagingHeaders();
            return ListPunchScheduleByConditionWithPagingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取巡点信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPunchScheduleByConditionWithPagingRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPunchScheduleByConditionWithPagingResponse
        /// </returns>
        public async Task<ListPunchScheduleByConditionWithPagingResponse> ListPunchScheduleByConditionWithPagingAsync(ListPunchScheduleByConditionWithPagingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPunchScheduleByConditionWithPagingHeaders headers = new ListPunchScheduleByConditionWithPagingHeaders();
            return await ListPunchScheduleByConditionWithPagingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询规则列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListRulesRequest
        /// </param>
        /// <param name="headers">
        /// ListRulesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        public ListRulesResponse ListRulesWithOptions(ListRulesRequest tmpReq, ListRulesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListRulesShrinkRequest request = new ListRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListRules",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/messageCategories/rules/listRules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRulesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询规则列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListRulesRequest
        /// </param>
        /// <param name="headers">
        /// ListRulesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        public async Task<ListRulesResponse> ListRulesWithOptionsAsync(ListRulesRequest tmpReq, ListRulesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListRulesShrinkRequest request = new ListRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListRules",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/messageCategories/rules/listRules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRulesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        public ListRulesResponse ListRules(ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRulesHeaders headers = new ListRulesHeaders();
            return ListRulesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        public async Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRulesHeaders headers = new ListRulesHeaders();
            return await ListRulesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定用户强制下线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LogoutRequest
        /// </param>
        /// <param name="headers">
        /// LogoutHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LogoutResponse
        /// </returns>
        public LogoutResponse LogoutWithOptions(LogoutRequest request, LogoutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["deviceType"] = request.DeviceType;
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
                Action = "Logout",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/users/logout",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LogoutResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定用户强制下线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LogoutRequest
        /// </param>
        /// <param name="headers">
        /// LogoutHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LogoutResponse
        /// </returns>
        public async Task<LogoutResponse> LogoutWithOptionsAsync(LogoutRequest request, LogoutHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["deviceType"] = request.DeviceType;
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
                Action = "Logout",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/users/logout",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LogoutResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定用户强制下线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LogoutRequest
        /// </param>
        /// 
        /// <returns>
        /// LogoutResponse
        /// </returns>
        public LogoutResponse Logout(LogoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LogoutHeaders headers = new LogoutHeaders();
            return LogoutWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定用户强制下线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LogoutRequest
        /// </param>
        /// 
        /// <returns>
        /// LogoutResponse
        /// </returns>
        public async Task<LogoutResponse> LogoutAsync(LogoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LogoutHeaders headers = new LogoutHeaders();
            return await LogoutWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>购买权益包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenBenefitPackageRequest
        /// </param>
        /// <param name="headers">
        /// OpenBenefitPackageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenBenefitPackageResponse
        /// </returns>
        public OpenBenefitPackageResponse OpenBenefitPackageWithOptions(OpenBenefitPackageRequest request, OpenBenefitPackageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitPackage))
            {
                body["benefitPackage"] = request.BenefitPackage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "OpenBenefitPackage",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/benefitPackages/purchase",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenBenefitPackageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>购买权益包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenBenefitPackageRequest
        /// </param>
        /// <param name="headers">
        /// OpenBenefitPackageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenBenefitPackageResponse
        /// </returns>
        public async Task<OpenBenefitPackageResponse> OpenBenefitPackageWithOptionsAsync(OpenBenefitPackageRequest request, OpenBenefitPackageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitPackage))
            {
                body["benefitPackage"] = request.BenefitPackage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "OpenBenefitPackage",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/benefitPackages/purchase",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenBenefitPackageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>购买权益包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenBenefitPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenBenefitPackageResponse
        /// </returns>
        public OpenBenefitPackageResponse OpenBenefitPackage(OpenBenefitPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenBenefitPackageHeaders headers = new OpenBenefitPackageHeaders();
            return OpenBenefitPackageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>购买权益包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenBenefitPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenBenefitPackageResponse
        /// </returns>
        public async Task<OpenBenefitPackageResponse> OpenBenefitPackageAsync(OpenBenefitPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenBenefitPackageHeaders headers = new OpenBenefitPackageHeaders();
            return await OpenBenefitPackageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>防作弊风险检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreventCheatingCheckRiskRequest
        /// </param>
        /// <param name="headers">
        /// PreventCheatingCheckRiskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreventCheatingCheckRiskResponse
        /// </returns>
        public PreventCheatingCheckRiskResponse PreventCheatingCheckRiskWithOptions(PreventCheatingCheckRiskRequest request, PreventCheatingCheckRiskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVer))
            {
                body["clientVer"] = request.ClientVer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformVer))
            {
                body["platformVer"] = request.PlatformVer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sec))
            {
                body["sec"] = request.Sec;
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
                Action = "PreventCheatingCheckRisk",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/preventCheats/risks/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreventCheatingCheckRiskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>防作弊风险检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreventCheatingCheckRiskRequest
        /// </param>
        /// <param name="headers">
        /// PreventCheatingCheckRiskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreventCheatingCheckRiskResponse
        /// </returns>
        public async Task<PreventCheatingCheckRiskResponse> PreventCheatingCheckRiskWithOptionsAsync(PreventCheatingCheckRiskRequest request, PreventCheatingCheckRiskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVer))
            {
                body["clientVer"] = request.ClientVer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformVer))
            {
                body["platformVer"] = request.PlatformVer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sec))
            {
                body["sec"] = request.Sec;
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
                Action = "PreventCheatingCheckRisk",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/preventCheats/risks/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreventCheatingCheckRiskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>防作弊风险检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreventCheatingCheckRiskRequest
        /// </param>
        /// 
        /// <returns>
        /// PreventCheatingCheckRiskResponse
        /// </returns>
        public PreventCheatingCheckRiskResponse PreventCheatingCheckRisk(PreventCheatingCheckRiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PreventCheatingCheckRiskHeaders headers = new PreventCheatingCheckRiskHeaders();
            return PreventCheatingCheckRiskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>防作弊风险检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreventCheatingCheckRiskRequest
        /// </param>
        /// 
        /// <returns>
        /// PreventCheatingCheckRiskResponse
        /// </returns>
        public async Task<PreventCheatingCheckRiskResponse> PreventCheatingCheckRiskAsync(PreventCheatingCheckRiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PreventCheatingCheckRiskHeaders headers = new PreventCheatingCheckRiskHeaders();
            return await PreventCheatingCheckRiskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送文件更改的评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishFileChangeNoticeRequest
        /// </param>
        /// <param name="headers">
        /// PublishFileChangeNoticeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishFileChangeNoticeResponse
        /// </returns>
        public PublishFileChangeNoticeResponse PublishFileChangeNoticeWithOptions(PublishFileChangeNoticeRequest request, PublishFileChangeNoticeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["operateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                body["spaceId"] = request.SpaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PublishFileChangeNotice",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/comments/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<PublishFileChangeNoticeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送文件更改的评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishFileChangeNoticeRequest
        /// </param>
        /// <param name="headers">
        /// PublishFileChangeNoticeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishFileChangeNoticeResponse
        /// </returns>
        public async Task<PublishFileChangeNoticeResponse> PublishFileChangeNoticeWithOptionsAsync(PublishFileChangeNoticeRequest request, PublishFileChangeNoticeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["operateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                body["spaceId"] = request.SpaceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PublishFileChangeNotice",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/comments/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<PublishFileChangeNoticeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送文件更改的评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishFileChangeNoticeRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishFileChangeNoticeResponse
        /// </returns>
        public PublishFileChangeNoticeResponse PublishFileChangeNotice(PublishFileChangeNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishFileChangeNoticeHeaders headers = new PublishFileChangeNoticeHeaders();
            return PublishFileChangeNoticeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送文件更改的评论</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishFileChangeNoticeRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishFileChangeNoticeResponse
        /// </returns>
        public async Task<PublishFileChangeNoticeResponse> PublishFileChangeNoticeAsync(PublishFileChangeNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishFileChangeNoticeHeaders headers = new PublishFileChangeNoticeHeaders();
            return await PublishFileChangeNoticeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishRuleRequest
        /// </param>
        /// <param name="headers">
        /// PublishRuleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishRuleResponse
        /// </returns>
        public PublishRuleResponse PublishRuleWithOptions(PublishRuleRequest request, PublishRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PublishRule",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/messageCategories/rules/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishRuleResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishRuleRequest
        /// </param>
        /// <param name="headers">
        /// PublishRuleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishRuleResponse
        /// </returns>
        public async Task<PublishRuleResponse> PublishRuleWithOptionsAsync(PublishRuleRequest request, PublishRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PublishRule",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/messageCategories/rules/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishRuleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishRuleResponse
        /// </returns>
        public PublishRuleResponse PublishRule(PublishRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishRuleHeaders headers = new PublishRuleHeaders();
            return PublishRuleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishRuleResponse
        /// </returns>
        public async Task<PublishRuleResponse> PublishRuleAsync(PublishRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishRuleHeaders headers = new PublishRuleHeaders();
            return await PublishRuleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送专属设计中自建/第三方应用的小红点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushBadgeRequest
        /// </param>
        /// <param name="headers">
        /// PushBadgeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushBadgeResponse
        /// </returns>
        public PushBadgeResponse PushBadgeWithOptions(PushBadgeRequest request, PushBadgeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BadgeItems))
            {
                body["badgeItems"] = request.BadgeItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                body["pushType"] = request.PushType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PushBadge",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/exclusiveDesigns/redPoints/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushBadgeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送专属设计中自建/第三方应用的小红点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushBadgeRequest
        /// </param>
        /// <param name="headers">
        /// PushBadgeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushBadgeResponse
        /// </returns>
        public async Task<PushBadgeResponse> PushBadgeWithOptionsAsync(PushBadgeRequest request, PushBadgeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BadgeItems))
            {
                body["badgeItems"] = request.BadgeItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                body["pushType"] = request.PushType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PushBadge",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/exclusiveDesigns/redPoints/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushBadgeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送专属设计中自建/第三方应用的小红点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushBadgeRequest
        /// </param>
        /// 
        /// <returns>
        /// PushBadgeResponse
        /// </returns>
        public PushBadgeResponse PushBadge(PushBadgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushBadgeHeaders headers = new PushBadgeHeaders();
            return PushBadgeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送专属设计中自建/第三方应用的小红点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushBadgeRequest
        /// </param>
        /// 
        /// <returns>
        /// PushBadgeResponse
        /// </returns>
        public async Task<PushBadgeResponse> PushBadgeAsync(PushBadgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushBadgeHeaders headers = new PushBadgeHeaders();
            return await PushBadgeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询跨云存储配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAcrossCloudStroageConfigsRequest
        /// </param>
        /// <param name="headers">
        /// QueryAcrossCloudStroageConfigsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAcrossCloudStroageConfigsResponse
        /// </returns>
        public QueryAcrossCloudStroageConfigsResponse QueryAcrossCloudStroageConfigsWithOptions(QueryAcrossCloudStroageConfigsRequest request, QueryAcrossCloudStroageConfigsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCloudType))
            {
                query["targetCloudType"] = request.TargetCloudType;
            }
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
                Action = "QueryAcrossCloudStroageConfigs",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileStorages/acrossClouds/configurations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAcrossCloudStroageConfigsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询跨云存储配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAcrossCloudStroageConfigsRequest
        /// </param>
        /// <param name="headers">
        /// QueryAcrossCloudStroageConfigsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAcrossCloudStroageConfigsResponse
        /// </returns>
        public async Task<QueryAcrossCloudStroageConfigsResponse> QueryAcrossCloudStroageConfigsWithOptionsAsync(QueryAcrossCloudStroageConfigsRequest request, QueryAcrossCloudStroageConfigsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCloudType))
            {
                query["targetCloudType"] = request.TargetCloudType;
            }
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
                Action = "QueryAcrossCloudStroageConfigs",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileStorages/acrossClouds/configurations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAcrossCloudStroageConfigsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询跨云存储配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAcrossCloudStroageConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAcrossCloudStroageConfigsResponse
        /// </returns>
        public QueryAcrossCloudStroageConfigsResponse QueryAcrossCloudStroageConfigs(QueryAcrossCloudStroageConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAcrossCloudStroageConfigsHeaders headers = new QueryAcrossCloudStroageConfigsHeaders();
            return QueryAcrossCloudStroageConfigsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询跨云存储配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAcrossCloudStroageConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAcrossCloudStroageConfigsResponse
        /// </returns>
        public async Task<QueryAcrossCloudStroageConfigsResponse> QueryAcrossCloudStroageConfigsAsync(QueryAcrossCloudStroageConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAcrossCloudStroageConfigsHeaders headers = new QueryAcrossCloudStroageConfigsHeaders();
            return await QueryAcrossCloudStroageConfigsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据手机号查询渠道组织中的员工信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChannelStaffInfoByMobileRequest
        /// </param>
        /// <param name="headers">
        /// QueryChannelStaffInfoByMobileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryChannelStaffInfoByMobileResponse
        /// </returns>
        public QueryChannelStaffInfoByMobileResponse QueryChannelStaffInfoByMobileWithOptions(QueryChannelStaffInfoByMobileRequest request, QueryChannelStaffInfoByMobileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
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
                Action = "QueryChannelStaffInfoByMobile",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/channelOrganizations/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChannelStaffInfoByMobileResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据手机号查询渠道组织中的员工信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChannelStaffInfoByMobileRequest
        /// </param>
        /// <param name="headers">
        /// QueryChannelStaffInfoByMobileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryChannelStaffInfoByMobileResponse
        /// </returns>
        public async Task<QueryChannelStaffInfoByMobileResponse> QueryChannelStaffInfoByMobileWithOptionsAsync(QueryChannelStaffInfoByMobileRequest request, QueryChannelStaffInfoByMobileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
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
                Action = "QueryChannelStaffInfoByMobile",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/channelOrganizations/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChannelStaffInfoByMobileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据手机号查询渠道组织中的员工信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChannelStaffInfoByMobileRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryChannelStaffInfoByMobileResponse
        /// </returns>
        public QueryChannelStaffInfoByMobileResponse QueryChannelStaffInfoByMobile(QueryChannelStaffInfoByMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryChannelStaffInfoByMobileHeaders headers = new QueryChannelStaffInfoByMobileHeaders();
            return QueryChannelStaffInfoByMobileWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据手机号查询渠道组织中的员工信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChannelStaffInfoByMobileRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryChannelStaffInfoByMobileResponse
        /// </returns>
        public async Task<QueryChannelStaffInfoByMobileResponse> QueryChannelStaffInfoByMobileAsync(QueryChannelStaffInfoByMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryChannelStaffInfoByMobileHeaders headers = new QueryChannelStaffInfoByMobileHeaders();
            return await QueryChannelStaffInfoByMobileWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取分组下会话列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConversationPageRequest
        /// </param>
        /// <param name="headers">
        /// QueryConversationPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConversationPageResponse
        /// </returns>
        public QueryConversationPageResponse QueryConversationPageWithOptions(QueryConversationPageRequest request, QueryConversationPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["categoryId"] = request.CategoryId;
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
                Action = "QueryConversationPage",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/categories/conversations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConversationPageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取分组下会话列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConversationPageRequest
        /// </param>
        /// <param name="headers">
        /// QueryConversationPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConversationPageResponse
        /// </returns>
        public async Task<QueryConversationPageResponse> QueryConversationPageWithOptionsAsync(QueryConversationPageRequest request, QueryConversationPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["categoryId"] = request.CategoryId;
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
                Action = "QueryConversationPage",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/categories/conversations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConversationPageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取分组下会话列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConversationPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryConversationPageResponse
        /// </returns>
        public QueryConversationPageResponse QueryConversationPage(QueryConversationPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConversationPageHeaders headers = new QueryConversationPageHeaders();
            return QueryConversationPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取分组下会话列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConversationPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryConversationPageResponse
        /// </returns>
        public async Task<QueryConversationPageResponse> QueryConversationPageAsync(QueryConversationPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConversationPageHeaders headers = new QueryConversationPageHeaders();
            return await QueryConversationPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询专属版权益</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryExclusiveBenefitsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryExclusiveBenefitsResponse
        /// </returns>
        public QueryExclusiveBenefitsResponse QueryExclusiveBenefitsWithOptions(QueryExclusiveBenefitsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryExclusiveBenefits",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/benefits",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryExclusiveBenefitsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询专属版权益</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryExclusiveBenefitsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryExclusiveBenefitsResponse
        /// </returns>
        public async Task<QueryExclusiveBenefitsResponse> QueryExclusiveBenefitsWithOptionsAsync(QueryExclusiveBenefitsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryExclusiveBenefits",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/benefits",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryExclusiveBenefitsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询专属版权益</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryExclusiveBenefitsResponse
        /// </returns>
        public QueryExclusiveBenefitsResponse QueryExclusiveBenefits()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryExclusiveBenefitsHeaders headers = new QueryExclusiveBenefitsHeaders();
            return QueryExclusiveBenefitsWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询专属版权益</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryExclusiveBenefitsResponse
        /// </returns>
        public async Task<QueryExclusiveBenefitsResponse> QueryExclusiveBenefitsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryExclusiveBenefitsHeaders headers = new QueryExclusiveBenefitsHeaders();
            return await QueryExclusiveBenefitsWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>伙伴钉根据uid查询人员的标签信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryPartnerInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPartnerInfoResponse
        /// </returns>
        public QueryPartnerInfoResponse QueryPartnerInfoWithOptions(string userId, QueryPartnerInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryPartnerInfo",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/partners/users/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPartnerInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>伙伴钉根据uid查询人员的标签信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryPartnerInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPartnerInfoResponse
        /// </returns>
        public async Task<QueryPartnerInfoResponse> QueryPartnerInfoWithOptionsAsync(string userId, QueryPartnerInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryPartnerInfo",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/partners/users/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPartnerInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>伙伴钉根据uid查询人员的标签信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryPartnerInfoResponse
        /// </returns>
        public QueryPartnerInfoResponse QueryPartnerInfo(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPartnerInfoHeaders headers = new QueryPartnerInfoHeaders();
            return QueryPartnerInfoWithOptions(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>伙伴钉根据uid查询人员的标签信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryPartnerInfoResponse
        /// </returns>
        public async Task<QueryPartnerInfoResponse> QueryPartnerInfoAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPartnerInfoHeaders headers = new QueryPartnerInfoHeaders();
            return await QueryPartnerInfoWithOptionsAsync(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据templateId查询模版信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryTemplateInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTemplateInfoResponse
        /// </returns>
        public QueryTemplateInfoResponse QueryTemplateInfoWithOptions(string templateId, QueryTemplateInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryTemplateInfo",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/sceneGroups/templates/" + templateId + "/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTemplateInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据templateId查询模版信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryTemplateInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTemplateInfoResponse
        /// </returns>
        public async Task<QueryTemplateInfoResponse> QueryTemplateInfoWithOptionsAsync(string templateId, QueryTemplateInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryTemplateInfo",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/sceneGroups/templates/" + templateId + "/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTemplateInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据templateId查询模版信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryTemplateInfoResponse
        /// </returns>
        public QueryTemplateInfoResponse QueryTemplateInfo(string templateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTemplateInfoHeaders headers = new QueryTemplateInfoHeaders();
            return QueryTemplateInfoWithOptions(templateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据templateId查询模版信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryTemplateInfoResponse
        /// </returns>
        public async Task<QueryTemplateInfoResponse> QueryTemplateInfoAsync(string templateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTemplateInfoHeaders headers = new QueryTemplateInfoHeaders();
            return await QueryTemplateInfoWithOptionsAsync(templateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户截屏操作记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserBehaviorRequest
        /// </param>
        /// <param name="headers">
        /// QueryUserBehaviorHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUserBehaviorResponse
        /// </returns>
        public QueryUserBehaviorResponse QueryUserBehaviorWithOptions(QueryUserBehaviorRequest request, QueryUserBehaviorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Action = "QueryUserBehavior",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/enterpriseSecurities/userBehaviors/screenshots/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserBehaviorResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户截屏操作记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserBehaviorRequest
        /// </param>
        /// <param name="headers">
        /// QueryUserBehaviorHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUserBehaviorResponse
        /// </returns>
        public async Task<QueryUserBehaviorResponse> QueryUserBehaviorWithOptionsAsync(QueryUserBehaviorRequest request, QueryUserBehaviorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Action = "QueryUserBehavior",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/enterpriseSecurities/userBehaviors/screenshots/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserBehaviorResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户截屏操作记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserBehaviorRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUserBehaviorResponse
        /// </returns>
        public QueryUserBehaviorResponse QueryUserBehavior(QueryUserBehaviorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserBehaviorHeaders headers = new QueryUserBehaviorHeaders();
            return QueryUserBehaviorWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户截屏操作记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserBehaviorRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUserBehaviorResponse
        /// </returns>
        public async Task<QueryUserBehaviorResponse> QueryUserBehaviorAsync(QueryUserBehaviorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserBehaviorHeaders headers = new QueryUserBehaviorHeaders();
            return await QueryUserBehaviorWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小程序版本回滚</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackMiniAppVersionRequest
        /// </param>
        /// <param name="headers">
        /// RollbackMiniAppVersionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RollbackMiniAppVersionResponse
        /// </returns>
        public RollbackMiniAppVersionResponse RollbackMiniAppVersionWithOptions(RollbackMiniAppVersionRequest request, RollbackMiniAppVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RollbackVersion))
            {
                body["rollbackVersion"] = request.RollbackVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVersion))
            {
                body["targetVersion"] = request.TargetVersion;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RollbackMiniAppVersion",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/miniApps/versions/rollback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackMiniAppVersionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小程序版本回滚</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackMiniAppVersionRequest
        /// </param>
        /// <param name="headers">
        /// RollbackMiniAppVersionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RollbackMiniAppVersionResponse
        /// </returns>
        public async Task<RollbackMiniAppVersionResponse> RollbackMiniAppVersionWithOptionsAsync(RollbackMiniAppVersionRequest request, RollbackMiniAppVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RollbackVersion))
            {
                body["rollbackVersion"] = request.RollbackVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVersion))
            {
                body["targetVersion"] = request.TargetVersion;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RollbackMiniAppVersion",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/miniApps/versions/rollback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackMiniAppVersionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小程序版本回滚</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackMiniAppVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// RollbackMiniAppVersionResponse
        /// </returns>
        public RollbackMiniAppVersionResponse RollbackMiniAppVersion(RollbackMiniAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RollbackMiniAppVersionHeaders headers = new RollbackMiniAppVersionHeaders();
            return RollbackMiniAppVersionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小程序版本回滚</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackMiniAppVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// RollbackMiniAppVersionResponse
        /// </returns>
        public async Task<RollbackMiniAppVersionResponse> RollbackMiniAppVersionAsync(RollbackMiniAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RollbackMiniAppVersionHeaders headers = new RollbackMiniAppVersionHeaders();
            return await RollbackMiniAppVersionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按规则批量发消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RuleBatchReceiverRequest
        /// </param>
        /// <param name="headers">
        /// RuleBatchReceiverHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RuleBatchReceiverResponse
        /// </returns>
        public RuleBatchReceiverResponse RuleBatchReceiverWithOptions(RuleBatchReceiverRequest request, RuleBatchReceiverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchNo))
            {
                body["batchNo"] = request.BatchNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardOptions))
            {
                body["cardOptions"] = request.CardOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCode))
            {
                body["ruleCode"] = request.RuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecialStrategy))
            {
                body["specialStrategy"] = request.SpecialStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskBatchNo))
            {
                body["taskBatchNo"] = request.TaskBatchNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RuleBatchReceiver",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/dmc/rules/messages/batchSend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RuleBatchReceiverResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按规则批量发消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RuleBatchReceiverRequest
        /// </param>
        /// <param name="headers">
        /// RuleBatchReceiverHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RuleBatchReceiverResponse
        /// </returns>
        public async Task<RuleBatchReceiverResponse> RuleBatchReceiverWithOptionsAsync(RuleBatchReceiverRequest request, RuleBatchReceiverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchNo))
            {
                body["batchNo"] = request.BatchNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardOptions))
            {
                body["cardOptions"] = request.CardOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCode))
            {
                body["ruleCode"] = request.RuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecialStrategy))
            {
                body["specialStrategy"] = request.SpecialStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskBatchNo))
            {
                body["taskBatchNo"] = request.TaskBatchNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RuleBatchReceiver",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/dmc/rules/messages/batchSend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RuleBatchReceiverResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按规则批量发消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RuleBatchReceiverRequest
        /// </param>
        /// 
        /// <returns>
        /// RuleBatchReceiverResponse
        /// </returns>
        public RuleBatchReceiverResponse RuleBatchReceiver(RuleBatchReceiverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RuleBatchReceiverHeaders headers = new RuleBatchReceiverHeaders();
            return RuleBatchReceiverWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按规则批量发消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RuleBatchReceiverRequest
        /// </param>
        /// 
        /// <returns>
        /// RuleBatchReceiverResponse
        /// </returns>
        public async Task<RuleBatchReceiverResponse> RuleBatchReceiverAsync(RuleBatchReceiverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RuleBatchReceiverHeaders headers = new RuleBatchReceiverHeaders();
            return await RuleBatchReceiverWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增跨云存储配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAcrossCloudStroageConfigsRequest
        /// </param>
        /// <param name="headers">
        /// SaveAcrossCloudStroageConfigsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveAcrossCloudStroageConfigsResponse
        /// </returns>
        public SaveAcrossCloudStroageConfigsResponse SaveAcrossCloudStroageConfigsWithOptions(SaveAcrossCloudStroageConfigsRequest request, SaveAcrossCloudStroageConfigsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                body["bucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudType))
            {
                body["cloudType"] = request.CloudType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                body["endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SaveAcrossCloudStroageConfigs",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileStorages/acrossClouds/configurations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveAcrossCloudStroageConfigsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增跨云存储配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAcrossCloudStroageConfigsRequest
        /// </param>
        /// <param name="headers">
        /// SaveAcrossCloudStroageConfigsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveAcrossCloudStroageConfigsResponse
        /// </returns>
        public async Task<SaveAcrossCloudStroageConfigsResponse> SaveAcrossCloudStroageConfigsWithOptionsAsync(SaveAcrossCloudStroageConfigsRequest request, SaveAcrossCloudStroageConfigsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                body["bucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudType))
            {
                body["cloudType"] = request.CloudType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                body["endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SaveAcrossCloudStroageConfigs",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileStorages/acrossClouds/configurations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveAcrossCloudStroageConfigsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增跨云存储配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAcrossCloudStroageConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveAcrossCloudStroageConfigsResponse
        /// </returns>
        public SaveAcrossCloudStroageConfigsResponse SaveAcrossCloudStroageConfigs(SaveAcrossCloudStroageConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveAcrossCloudStroageConfigsHeaders headers = new SaveAcrossCloudStroageConfigsHeaders();
            return SaveAcrossCloudStroageConfigsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增跨云存储配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAcrossCloudStroageConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveAcrossCloudStroageConfigsResponse
        /// </returns>
        public async Task<SaveAcrossCloudStroageConfigsResponse> SaveAcrossCloudStroageConfigsAsync(SaveAcrossCloudStroageConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveAcrossCloudStroageConfigsHeaders headers = new SaveAcrossCloudStroageConfigsHeaders();
            return await SaveAcrossCloudStroageConfigsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存并提交认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAndSubmitAuthInfoRequest
        /// </param>
        /// <param name="headers">
        /// SaveAndSubmitAuthInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveAndSubmitAuthInfoResponse
        /// </returns>
        public SaveAndSubmitAuthInfoResponse SaveAndSubmitAuthInfoWithOptions(SaveAndSubmitAuthInfoRequest request, SaveAndSubmitAuthInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRemark))
            {
                body["applyRemark"] = request.ApplyRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeMediaId))
            {
                body["authorizeMediaId"] = request.AuthorizeMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                body["industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPerson))
            {
                body["legalPerson"] = request.LegalPerson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIdCard))
            {
                body["legalPersonIdCard"] = request.LegalPersonIdCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseMediaId))
            {
                body["licenseMediaId"] = request.LicenseMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocCity))
            {
                body["locCity"] = request.LocCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocCityName))
            {
                body["locCityName"] = request.LocCityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocProvince))
            {
                body["locProvince"] = request.LocProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocProvinceName))
            {
                body["locProvinceName"] = request.LocProvinceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNum))
            {
                body["mobileNum"] = request.MobileNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["orgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationCode))
            {
                body["organizationCode"] = request.OrganizationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationCodeMediaId))
            {
                body["organizationCodeMediaId"] = request.OrganizationCodeMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistLocation))
            {
                body["registLocation"] = request.RegistLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistNum))
            {
                body["registNum"] = request.RegistNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnifiedSocialCredit))
            {
                body["unifiedSocialCredit"] = request.UnifiedSocialCredit;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SaveAndSubmitAuthInfo",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/ognizations/authInfos/saveAndSubmit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveAndSubmitAuthInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存并提交认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAndSubmitAuthInfoRequest
        /// </param>
        /// <param name="headers">
        /// SaveAndSubmitAuthInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveAndSubmitAuthInfoResponse
        /// </returns>
        public async Task<SaveAndSubmitAuthInfoResponse> SaveAndSubmitAuthInfoWithOptionsAsync(SaveAndSubmitAuthInfoRequest request, SaveAndSubmitAuthInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRemark))
            {
                body["applyRemark"] = request.ApplyRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeMediaId))
            {
                body["authorizeMediaId"] = request.AuthorizeMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                body["industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPerson))
            {
                body["legalPerson"] = request.LegalPerson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonIdCard))
            {
                body["legalPersonIdCard"] = request.LegalPersonIdCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseMediaId))
            {
                body["licenseMediaId"] = request.LicenseMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocCity))
            {
                body["locCity"] = request.LocCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocCityName))
            {
                body["locCityName"] = request.LocCityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocProvince))
            {
                body["locProvince"] = request.LocProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocProvinceName))
            {
                body["locProvinceName"] = request.LocProvinceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNum))
            {
                body["mobileNum"] = request.MobileNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["orgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationCode))
            {
                body["organizationCode"] = request.OrganizationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationCodeMediaId))
            {
                body["organizationCodeMediaId"] = request.OrganizationCodeMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistLocation))
            {
                body["registLocation"] = request.RegistLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistNum))
            {
                body["registNum"] = request.RegistNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnifiedSocialCredit))
            {
                body["unifiedSocialCredit"] = request.UnifiedSocialCredit;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SaveAndSubmitAuthInfo",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/ognizations/authInfos/saveAndSubmit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveAndSubmitAuthInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存并提交认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAndSubmitAuthInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveAndSubmitAuthInfoResponse
        /// </returns>
        public SaveAndSubmitAuthInfoResponse SaveAndSubmitAuthInfo(SaveAndSubmitAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveAndSubmitAuthInfoHeaders headers = new SaveAndSubmitAuthInfoHeaders();
            return SaveAndSubmitAuthInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存并提交认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAndSubmitAuthInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveAndSubmitAuthInfoResponse
        /// </returns>
        public async Task<SaveAndSubmitAuthInfoResponse> SaveAndSubmitAuthInfoAsync(SaveAndSubmitAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveAndSubmitAuthInfoHeaders headers = new SaveAndSubmitAuthInfoHeaders();
            return await SaveAndSubmitAuthInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亿格云能力结合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveOpenTerminalInfoRequest
        /// </param>
        /// <param name="headers">
        /// SaveOpenTerminalInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveOpenTerminalInfoResponse
        /// </returns>
        public SaveOpenTerminalInfoResponse SaveOpenTerminalInfoWithOptions(SaveOpenTerminalInfoRequest request, SaveOpenTerminalInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSource))
            {
                body["logSource"] = request.LogSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                body["logType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenExt))
            {
                body["openExt"] = request.OpenExt;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SaveOpenTerminalInfo",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/externalLogs/terminalInfos/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveOpenTerminalInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亿格云能力结合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveOpenTerminalInfoRequest
        /// </param>
        /// <param name="headers">
        /// SaveOpenTerminalInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveOpenTerminalInfoResponse
        /// </returns>
        public async Task<SaveOpenTerminalInfoResponse> SaveOpenTerminalInfoWithOptionsAsync(SaveOpenTerminalInfoRequest request, SaveOpenTerminalInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSource))
            {
                body["logSource"] = request.LogSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                body["logType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenExt))
            {
                body["openExt"] = request.OpenExt;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SaveOpenTerminalInfo",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/externalLogs/terminalInfos/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveOpenTerminalInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亿格云能力结合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveOpenTerminalInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveOpenTerminalInfoResponse
        /// </returns>
        public SaveOpenTerminalInfoResponse SaveOpenTerminalInfo(SaveOpenTerminalInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveOpenTerminalInfoHeaders headers = new SaveOpenTerminalInfoHeaders();
            return SaveOpenTerminalInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亿格云能力结合</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveOpenTerminalInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveOpenTerminalInfoResponse
        /// </returns>
        public async Task<SaveOpenTerminalInfoResponse> SaveOpenTerminalInfoAsync(SaveOpenTerminalInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveOpenTerminalInfoHeaders headers = new SaveOpenTerminalInfoHeaders();
            return await SaveOpenTerminalInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存专属文件存储的功能项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveStorageFunctionSwitchRequest
        /// </param>
        /// <param name="headers">
        /// SaveStorageFunctionSwitchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveStorageFunctionSwitchResponse
        /// </returns>
        public SaveStorageFunctionSwitchResponse SaveStorageFunctionSwitchWithOptions(SaveStorageFunctionSwitchRequest request, SaveStorageFunctionSwitchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionList))
            {
                body["functionList"] = request.FunctionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SaveStorageFunctionSwitch",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/storages/functions/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveStorageFunctionSwitchResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存专属文件存储的功能项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveStorageFunctionSwitchRequest
        /// </param>
        /// <param name="headers">
        /// SaveStorageFunctionSwitchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveStorageFunctionSwitchResponse
        /// </returns>
        public async Task<SaveStorageFunctionSwitchResponse> SaveStorageFunctionSwitchWithOptionsAsync(SaveStorageFunctionSwitchRequest request, SaveStorageFunctionSwitchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionList))
            {
                body["functionList"] = request.FunctionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SaveStorageFunctionSwitch",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/storages/functions/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveStorageFunctionSwitchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存专属文件存储的功能项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveStorageFunctionSwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveStorageFunctionSwitchResponse
        /// </returns>
        public SaveStorageFunctionSwitchResponse SaveStorageFunctionSwitch(SaveStorageFunctionSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveStorageFunctionSwitchHeaders headers = new SaveStorageFunctionSwitchHeaders();
            return SaveStorageFunctionSwitchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存专属文件存储的功能项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveStorageFunctionSwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveStorageFunctionSwitchResponse
        /// </returns>
        public async Task<SaveStorageFunctionSwitchResponse> SaveStorageFunctionSwitchAsync(SaveStorageFunctionSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveStorageFunctionSwitchHeaders headers = new SaveStorageFunctionSwitchHeaders();
            return await SaveStorageFunctionSwitchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存专属文件存储整体开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveStorageSwitchRequest
        /// </param>
        /// <param name="headers">
        /// SaveStorageSwitchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveStorageSwitchResponse
        /// </returns>
        public SaveStorageSwitchResponse SaveStorageSwitchWithOptions(SaveStorageSwitchRequest request, SaveStorageSwitchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenStorage))
            {
                body["openStorage"] = request.OpenStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SaveStorageSwitch",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/storages/switches/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveStorageSwitchResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存专属文件存储整体开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveStorageSwitchRequest
        /// </param>
        /// <param name="headers">
        /// SaveStorageSwitchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveStorageSwitchResponse
        /// </returns>
        public async Task<SaveStorageSwitchResponse> SaveStorageSwitchWithOptionsAsync(SaveStorageSwitchRequest request, SaveStorageSwitchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenStorage))
            {
                body["openStorage"] = request.OpenStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SaveStorageSwitch",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/storages/switches/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveStorageSwitchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存专属文件存储整体开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveStorageSwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveStorageSwitchResponse
        /// </returns>
        public SaveStorageSwitchResponse SaveStorageSwitch(SaveStorageSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveStorageSwitchHeaders headers = new SaveStorageSwitchHeaders();
            return SaveStorageSwitchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存专属文件存储整体开关</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveStorageSwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveStorageSwitchResponse
        /// </returns>
        public async Task<SaveStorageSwitchResponse> SaveStorageSwitchAsync(SaveStorageSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveStorageSwitchHeaders headers = new SaveStorageSwitchHeaders();
            return await SaveStorageSwitchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于提供mdm微应用白名单配置能力</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveWhiteAppRequest
        /// </param>
        /// <param name="headers">
        /// SaveWhiteAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveWhiteAppResponse
        /// </returns>
        public SaveWhiteAppResponse SaveWhiteAppWithOptions(SaveWhiteAppRequest request, SaveWhiteAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentIdList))
            {
                body["agentIdList"] = request.AgentIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentIdMap))
            {
                body["agentIdMap"] = request.AgentIdMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["operation"] = request.Operation;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SaveWhiteApp",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/miniApps/whiteLists/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveWhiteAppResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于提供mdm微应用白名单配置能力</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveWhiteAppRequest
        /// </param>
        /// <param name="headers">
        /// SaveWhiteAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveWhiteAppResponse
        /// </returns>
        public async Task<SaveWhiteAppResponse> SaveWhiteAppWithOptionsAsync(SaveWhiteAppRequest request, SaveWhiteAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentIdList))
            {
                body["agentIdList"] = request.AgentIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentIdMap))
            {
                body["agentIdMap"] = request.AgentIdMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["operation"] = request.Operation;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SaveWhiteApp",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/miniApps/whiteLists/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveWhiteAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于提供mdm微应用白名单配置能力</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveWhiteAppRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveWhiteAppResponse
        /// </returns>
        public SaveWhiteAppResponse SaveWhiteApp(SaveWhiteAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveWhiteAppHeaders headers = new SaveWhiteAppHeaders();
            return SaveWhiteAppWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于提供mdm微应用白名单配置能力</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveWhiteAppRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveWhiteAppResponse
        /// </returns>
        public async Task<SaveWhiteAppResponse> SaveWhiteAppAsync(SaveWhiteAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveWhiteAppHeaders headers = new SaveWhiteAppHeaders();
            return await SaveWhiteAppWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业内部群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchOrgInnerGroupInfoRequest
        /// </param>
        /// <param name="headers">
        /// SearchOrgInnerGroupInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchOrgInnerGroupInfoResponse
        /// </returns>
        public SearchOrgInnerGroupInfoResponse SearchOrgInnerGroupInfoWithOptions(SearchOrgInnerGroupInfoRequest request, SearchOrgInnerGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                query["createTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["createTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupMembersCountEnd))
            {
                query["groupMembersCountEnd"] = request.GroupMembersCountEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupMembersCountStart))
            {
                query["groupMembersCountStart"] = request.GroupMembersCountStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwner))
            {
                query["groupOwner"] = request.GroupOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastActiveTimeEnd))
            {
                query["lastActiveTimeEnd"] = request.LastActiveTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastActiveTimeStart))
            {
                query["lastActiveTimeStart"] = request.LastActiveTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                query["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["pageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncToDingpan))
            {
                query["syncToDingpan"] = request.SyncToDingpan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "SearchOrgInnerGroupInfo",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/securities/orgGroupInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchOrgInnerGroupInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业内部群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchOrgInnerGroupInfoRequest
        /// </param>
        /// <param name="headers">
        /// SearchOrgInnerGroupInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchOrgInnerGroupInfoResponse
        /// </returns>
        public async Task<SearchOrgInnerGroupInfoResponse> SearchOrgInnerGroupInfoWithOptionsAsync(SearchOrgInnerGroupInfoRequest request, SearchOrgInnerGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                query["createTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["createTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupMembersCountEnd))
            {
                query["groupMembersCountEnd"] = request.GroupMembersCountEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupMembersCountStart))
            {
                query["groupMembersCountStart"] = request.GroupMembersCountStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwner))
            {
                query["groupOwner"] = request.GroupOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastActiveTimeEnd))
            {
                query["lastActiveTimeEnd"] = request.LastActiveTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastActiveTimeStart))
            {
                query["lastActiveTimeStart"] = request.LastActiveTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                query["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["pageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncToDingpan))
            {
                query["syncToDingpan"] = request.SyncToDingpan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "SearchOrgInnerGroupInfo",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/securities/orgGroupInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchOrgInnerGroupInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业内部群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchOrgInnerGroupInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchOrgInnerGroupInfoResponse
        /// </returns>
        public SearchOrgInnerGroupInfoResponse SearchOrgInnerGroupInfo(SearchOrgInnerGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchOrgInnerGroupInfoHeaders headers = new SearchOrgInnerGroupInfoHeaders();
            return SearchOrgInnerGroupInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业内部群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchOrgInnerGroupInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchOrgInnerGroupInfoResponse
        /// </returns>
        public async Task<SearchOrgInnerGroupInfoResponse> SearchOrgInnerGroupInfoAsync(SearchOrgInnerGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchOrgInnerGroupInfoHeaders headers = new SearchOrgInnerGroupInfoHeaders();
            return await SearchOrgInnerGroupInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过接口发送应用内DING</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendAppDingRequest
        /// </param>
        /// <param name="headers">
        /// SendAppDingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendAppDingResponse
        /// </returns>
        public SendAppDingResponse SendAppDingWithOptions(SendAppDingRequest request, SendAppDingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userids))
            {
                body["userids"] = request.Userids;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendAppDing",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/appDings/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<SendAppDingResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过接口发送应用内DING</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendAppDingRequest
        /// </param>
        /// <param name="headers">
        /// SendAppDingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendAppDingResponse
        /// </returns>
        public async Task<SendAppDingResponse> SendAppDingWithOptionsAsync(SendAppDingRequest request, SendAppDingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userids))
            {
                body["userids"] = request.Userids;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendAppDing",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/appDings/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<SendAppDingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过接口发送应用内DING</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendAppDingRequest
        /// </param>
        /// 
        /// <returns>
        /// SendAppDingResponse
        /// </returns>
        public SendAppDingResponse SendAppDing(SendAppDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendAppDingHeaders headers = new SendAppDingHeaders();
            return SendAppDingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过接口发送应用内DING</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendAppDingRequest
        /// </param>
        /// 
        /// <returns>
        /// SendAppDingResponse
        /// </returns>
        public async Task<SendAppDingResponse> SendAppDingAsync(SendAppDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendAppDingHeaders headers = new SendAppDingHeaders();
            return await SendAppDingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送邀请函</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendInvitationRequest
        /// </param>
        /// <param name="headers">
        /// SendInvitationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendInvitationResponse
        /// </returns>
        public SendInvitationResponse SendInvitationWithOptions(SendInvitationRequest request, SendInvitationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgAlias))
            {
                body["orgAlias"] = request.OrgAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerLabelId))
            {
                body["partnerLabelId"] = request.PartnerLabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerNum))
            {
                body["partnerNum"] = request.PartnerNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendInvitation",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/partnerDepartments/invitations/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<SendInvitationResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送邀请函</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendInvitationRequest
        /// </param>
        /// <param name="headers">
        /// SendInvitationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendInvitationResponse
        /// </returns>
        public async Task<SendInvitationResponse> SendInvitationWithOptionsAsync(SendInvitationRequest request, SendInvitationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgAlias))
            {
                body["orgAlias"] = request.OrgAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerLabelId))
            {
                body["partnerLabelId"] = request.PartnerLabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerNum))
            {
                body["partnerNum"] = request.PartnerNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendInvitation",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/partnerDepartments/invitations/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<SendInvitationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送邀请函</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendInvitationRequest
        /// </param>
        /// 
        /// <returns>
        /// SendInvitationResponse
        /// </returns>
        public SendInvitationResponse SendInvitation(SendInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendInvitationHeaders headers = new SendInvitationHeaders();
            return SendInvitationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送邀请函</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendInvitationRequest
        /// </param>
        /// 
        /// <returns>
        /// SendInvitationResponse
        /// </returns>
        public async Task<SendInvitationResponse> SendInvitationAsync(SendInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendInvitationHeaders headers = new SendInvitationHeaders();
            return await SendInvitationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过接口发送电话DING</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendPhoneDingRequest
        /// </param>
        /// <param name="headers">
        /// SendPhoneDingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendPhoneDingResponse
        /// </returns>
        public SendPhoneDingResponse SendPhoneDingWithOptions(SendPhoneDingRequest request, SendPhoneDingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userids))
            {
                body["userids"] = request.Userids;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendPhoneDing",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/phoneDings/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendPhoneDingResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过接口发送电话DING</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendPhoneDingRequest
        /// </param>
        /// <param name="headers">
        /// SendPhoneDingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendPhoneDingResponse
        /// </returns>
        public async Task<SendPhoneDingResponse> SendPhoneDingWithOptionsAsync(SendPhoneDingRequest request, SendPhoneDingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userids))
            {
                body["userids"] = request.Userids;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendPhoneDing",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/phoneDings/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendPhoneDingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过接口发送电话DING</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendPhoneDingRequest
        /// </param>
        /// 
        /// <returns>
        /// SendPhoneDingResponse
        /// </returns>
        public SendPhoneDingResponse SendPhoneDing(SendPhoneDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendPhoneDingHeaders headers = new SendPhoneDingHeaders();
            return SendPhoneDingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过接口发送电话DING</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendPhoneDingRequest
        /// </param>
        /// 
        /// <returns>
        /// SendPhoneDingResponse
        /// </returns>
        public async Task<SendPhoneDingResponse> SendPhoneDingAsync(SendPhoneDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendPhoneDingHeaders headers = new SendPhoneDingHeaders();
            return await SendPhoneDingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会话所属分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetConversationCategoryRequest
        /// </param>
        /// <param name="headers">
        /// SetConversationCategoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetConversationCategoryResponse
        /// </returns>
        public SetConversationCategoryResponse SetConversationCategoryWithOptions(SetConversationCategoryRequest request, SetConversationCategoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["categoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetConversationCategory",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/conversationCategories/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetConversationCategoryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会话所属分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetConversationCategoryRequest
        /// </param>
        /// <param name="headers">
        /// SetConversationCategoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetConversationCategoryResponse
        /// </returns>
        public async Task<SetConversationCategoryResponse> SetConversationCategoryWithOptionsAsync(SetConversationCategoryRequest request, SetConversationCategoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["categoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetConversationCategory",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/conversationCategories/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetConversationCategoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会话所属分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetConversationCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// SetConversationCategoryResponse
        /// </returns>
        public SetConversationCategoryResponse SetConversationCategory(SetConversationCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetConversationCategoryHeaders headers = new SetConversationCategoryHeaders();
            return SetConversationCategoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置会话所属分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetConversationCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// SetConversationCategoryResponse
        /// </returns>
        public async Task<SetConversationCategoryResponse> SetConversationCategoryAsync(SetConversationCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetConversationCategoryHeaders headers = new SetConversationCategoryHeaders();
            return await SetConversationCategoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>伙伴钉设置部门伙伴编码和伙伴类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDeptPartnerTypeAndNumRequest
        /// </param>
        /// <param name="headers">
        /// SetDeptPartnerTypeAndNumHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDeptPartnerTypeAndNumResponse
        /// </returns>
        public SetDeptPartnerTypeAndNumResponse SetDeptPartnerTypeAndNumWithOptions(SetDeptPartnerTypeAndNumRequest request, SetDeptPartnerTypeAndNumHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelIds))
            {
                body["labelIds"] = request.LabelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerNum))
            {
                body["partnerNum"] = request.PartnerNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetDeptPartnerTypeAndNum",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/partnerDepartments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDeptPartnerTypeAndNumResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>伙伴钉设置部门伙伴编码和伙伴类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDeptPartnerTypeAndNumRequest
        /// </param>
        /// <param name="headers">
        /// SetDeptPartnerTypeAndNumHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDeptPartnerTypeAndNumResponse
        /// </returns>
        public async Task<SetDeptPartnerTypeAndNumResponse> SetDeptPartnerTypeAndNumWithOptionsAsync(SetDeptPartnerTypeAndNumRequest request, SetDeptPartnerTypeAndNumHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelIds))
            {
                body["labelIds"] = request.LabelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerNum))
            {
                body["partnerNum"] = request.PartnerNum;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetDeptPartnerTypeAndNum",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/partnerDepartments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDeptPartnerTypeAndNumResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>伙伴钉设置部门伙伴编码和伙伴类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDeptPartnerTypeAndNumRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDeptPartnerTypeAndNumResponse
        /// </returns>
        public SetDeptPartnerTypeAndNumResponse SetDeptPartnerTypeAndNum(SetDeptPartnerTypeAndNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDeptPartnerTypeAndNumHeaders headers = new SetDeptPartnerTypeAndNumHeaders();
            return SetDeptPartnerTypeAndNumWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>伙伴钉设置部门伙伴编码和伙伴类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDeptPartnerTypeAndNumRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDeptPartnerTypeAndNumResponse
        /// </returns>
        public async Task<SetDeptPartnerTypeAndNumResponse> SetDeptPartnerTypeAndNumAsync(SetDeptPartnerTypeAndNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDeptPartnerTypeAndNumHeaders headers = new SetDeptPartnerTypeAndNumHeaders();
            return await SetDeptPartnerTypeAndNumWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>千人千面按规则批量发消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SpecialRuleBatchReceiverRequest
        /// </param>
        /// <param name="headers">
        /// SpecialRuleBatchReceiverHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SpecialRuleBatchReceiverResponse
        /// </returns>
        public SpecialRuleBatchReceiverResponse SpecialRuleBatchReceiverWithOptions(SpecialRuleBatchReceiverRequest request, SpecialRuleBatchReceiverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchNo))
            {
                body["batchNo"] = request.BatchNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardOptions))
            {
                body["cardOptions"] = request.CardOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCode))
            {
                body["ruleCode"] = request.RuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecialStrategy))
            {
                body["specialStrategy"] = request.SpecialStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskBatchNo))
            {
                body["taskBatchNo"] = request.TaskBatchNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SpecialRuleBatchReceiver",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/dmc/rules/specialMessages/batchSend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SpecialRuleBatchReceiverResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>千人千面按规则批量发消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SpecialRuleBatchReceiverRequest
        /// </param>
        /// <param name="headers">
        /// SpecialRuleBatchReceiverHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SpecialRuleBatchReceiverResponse
        /// </returns>
        public async Task<SpecialRuleBatchReceiverResponse> SpecialRuleBatchReceiverWithOptionsAsync(SpecialRuleBatchReceiverRequest request, SpecialRuleBatchReceiverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchNo))
            {
                body["batchNo"] = request.BatchNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardOptions))
            {
                body["cardOptions"] = request.CardOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCode))
            {
                body["ruleCode"] = request.RuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecialStrategy))
            {
                body["specialStrategy"] = request.SpecialStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskBatchNo))
            {
                body["taskBatchNo"] = request.TaskBatchNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SpecialRuleBatchReceiver",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/dmc/rules/specialMessages/batchSend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SpecialRuleBatchReceiverResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>千人千面按规则批量发消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SpecialRuleBatchReceiverRequest
        /// </param>
        /// 
        /// <returns>
        /// SpecialRuleBatchReceiverResponse
        /// </returns>
        public SpecialRuleBatchReceiverResponse SpecialRuleBatchReceiver(SpecialRuleBatchReceiverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SpecialRuleBatchReceiverHeaders headers = new SpecialRuleBatchReceiverHeaders();
            return SpecialRuleBatchReceiverWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>千人千面按规则批量发消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SpecialRuleBatchReceiverRequest
        /// </param>
        /// 
        /// <returns>
        /// SpecialRuleBatchReceiverResponse
        /// </returns>
        public async Task<SpecialRuleBatchReceiverResponse> SpecialRuleBatchReceiverAsync(SpecialRuleBatchReceiverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SpecialRuleBatchReceiverHeaders headers = new SpecialRuleBatchReceiverHeaders();
            return await SpecialRuleBatchReceiverWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加/删除任务人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoAddDelTaskPersonRequest
        /// </param>
        /// <param name="headers">
        /// TaskInfoAddDelTaskPersonHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoAddDelTaskPersonResponse
        /// </returns>
        public TaskInfoAddDelTaskPersonResponse TaskInfoAddDelTaskPersonWithOptions(TaskInfoAddDelTaskPersonRequest request, TaskInfoAddDelTaskPersonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["operateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorAccount))
            {
                body["operatorAccount"] = request.OperatorAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTaskId))
            {
                body["outTaskId"] = request.OutTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjId))
            {
                body["projId"] = request.ProjId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutePersonDTOS))
            {
                body["taskExecutePersonDTOS"] = request.TaskExecutePersonDTOS;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TaskInfoAddDelTaskPerson",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/taskCenters/taskInfos/addDelTaskPerson",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskInfoAddDelTaskPersonResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加/删除任务人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoAddDelTaskPersonRequest
        /// </param>
        /// <param name="headers">
        /// TaskInfoAddDelTaskPersonHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoAddDelTaskPersonResponse
        /// </returns>
        public async Task<TaskInfoAddDelTaskPersonResponse> TaskInfoAddDelTaskPersonWithOptionsAsync(TaskInfoAddDelTaskPersonRequest request, TaskInfoAddDelTaskPersonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["operateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorAccount))
            {
                body["operatorAccount"] = request.OperatorAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTaskId))
            {
                body["outTaskId"] = request.OutTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjId))
            {
                body["projId"] = request.ProjId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutePersonDTOS))
            {
                body["taskExecutePersonDTOS"] = request.TaskExecutePersonDTOS;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TaskInfoAddDelTaskPerson",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/taskCenters/taskInfos/addDelTaskPerson",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskInfoAddDelTaskPersonResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加/删除任务人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoAddDelTaskPersonRequest
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoAddDelTaskPersonResponse
        /// </returns>
        public TaskInfoAddDelTaskPersonResponse TaskInfoAddDelTaskPerson(TaskInfoAddDelTaskPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoAddDelTaskPersonHeaders headers = new TaskInfoAddDelTaskPersonHeaders();
            return TaskInfoAddDelTaskPersonWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增加/删除任务人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoAddDelTaskPersonRequest
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoAddDelTaskPersonResponse
        /// </returns>
        public async Task<TaskInfoAddDelTaskPersonResponse> TaskInfoAddDelTaskPersonAsync(TaskInfoAddDelTaskPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoAddDelTaskPersonHeaders headers = new TaskInfoAddDelTaskPersonHeaders();
            return await TaskInfoAddDelTaskPersonWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoCancelOrDelTaskRequest
        /// </param>
        /// <param name="headers">
        /// TaskInfoCancelOrDelTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoCancelOrDelTaskResponse
        /// </returns>
        public TaskInfoCancelOrDelTaskResponse TaskInfoCancelOrDelTaskWithOptions(TaskInfoCancelOrDelTaskRequest request, TaskInfoCancelOrDelTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardDTO))
            {
                body["cardDTO"] = request.CardDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorAccount))
            {
                body["operatorAccount"] = request.OperatorAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTaskId))
            {
                body["outTaskId"] = request.OutTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjId))
            {
                body["projId"] = request.ProjId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendMsgFlag))
            {
                body["sendMsgFlag"] = request.SendMsgFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutePersonDTOS))
            {
                body["taskExecutePersonDTOS"] = request.TaskExecutePersonDTOS;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TaskInfoCancelOrDelTask",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/taskCenters/taskInfos/cancelOrDelTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskInfoCancelOrDelTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoCancelOrDelTaskRequest
        /// </param>
        /// <param name="headers">
        /// TaskInfoCancelOrDelTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoCancelOrDelTaskResponse
        /// </returns>
        public async Task<TaskInfoCancelOrDelTaskResponse> TaskInfoCancelOrDelTaskWithOptionsAsync(TaskInfoCancelOrDelTaskRequest request, TaskInfoCancelOrDelTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardDTO))
            {
                body["cardDTO"] = request.CardDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorAccount))
            {
                body["operatorAccount"] = request.OperatorAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTaskId))
            {
                body["outTaskId"] = request.OutTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjId))
            {
                body["projId"] = request.ProjId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendMsgFlag))
            {
                body["sendMsgFlag"] = request.SendMsgFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutePersonDTOS))
            {
                body["taskExecutePersonDTOS"] = request.TaskExecutePersonDTOS;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TaskInfoCancelOrDelTask",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/taskCenters/taskInfos/cancelOrDelTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskInfoCancelOrDelTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoCancelOrDelTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoCancelOrDelTaskResponse
        /// </returns>
        public TaskInfoCancelOrDelTaskResponse TaskInfoCancelOrDelTask(TaskInfoCancelOrDelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoCancelOrDelTaskHeaders headers = new TaskInfoCancelOrDelTaskHeaders();
            return TaskInfoCancelOrDelTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoCancelOrDelTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoCancelOrDelTaskResponse
        /// </returns>
        public async Task<TaskInfoCancelOrDelTaskResponse> TaskInfoCancelOrDelTaskAsync(TaskInfoCancelOrDelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoCancelOrDelTaskHeaders headers = new TaskInfoCancelOrDelTaskHeaders();
            return await TaskInfoCancelOrDelTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建并启动任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoCreateAndStartTaskRequest
        /// </param>
        /// <param name="headers">
        /// TaskInfoCreateAndStartTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoCreateAndStartTaskResponse
        /// </returns>
        public TaskInfoCreateAndStartTaskResponse TaskInfoCreateAndStartTaskWithOptions(TaskInfoCreateAndStartTaskRequest request, TaskInfoCreateAndStartTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attr))
            {
                body["attr"] = request.Attr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BacklogDTO))
            {
                body["backlogDTO"] = request.BacklogDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BacklogGenerateFlag))
            {
                body["backlogGenerateFlag"] = request.BacklogGenerateFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessCode))
            {
                body["businessCode"] = request.BusinessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CanceldelTaskCardId))
            {
                body["canceldelTaskCardId"] = request.CanceldelTaskCardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardDTO))
            {
                body["cardDTO"] = request.CardDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFlag))
            {
                body["customFlag"] = request.CustomFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailUrl))
            {
                body["detailUrl"] = request.DetailUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishTaskCardId))
            {
                body["finishTaskCardId"] = request.FinishTaskCardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorAccount))
            {
                body["operatorAccount"] = request.OperatorAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTaskId))
            {
                body["outTaskId"] = request.OutTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjId))
            {
                body["projId"] = request.ProjId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendMsgFlag))
            {
                body["sendMsgFlag"] = request.SendMsgFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                body["sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTaskCardId))
            {
                body["startTaskCardId"] = request.StartTaskCardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                body["state"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskContent))
            {
                body["taskContent"] = request.TaskContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskEndTime))
            {
                body["taskEndTime"] = request.TaskEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutePersonDTOS))
            {
                body["taskExecutePersonDTOS"] = request.TaskExecutePersonDTOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskGroupDTOList))
            {
                body["taskGroupDTOList"] = request.TaskGroupDTOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskSystem))
            {
                body["taskSystem"] = request.TaskSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTemplCode))
            {
                body["taskTemplCode"] = request.TaskTemplCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTitle))
            {
                body["taskTitle"] = request.TaskTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUrlMobile))
            {
                body["taskUrlMobile"] = request.TaskUrlMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUrlPc))
            {
                body["taskUrlPc"] = request.TaskUrlPc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTaskCardId))
            {
                body["updateTaskCardId"] = request.UpdateTaskCardId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TaskInfoCreateAndStartTask",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/taskCenters/taskInfos/createAndStart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskInfoCreateAndStartTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建并启动任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoCreateAndStartTaskRequest
        /// </param>
        /// <param name="headers">
        /// TaskInfoCreateAndStartTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoCreateAndStartTaskResponse
        /// </returns>
        public async Task<TaskInfoCreateAndStartTaskResponse> TaskInfoCreateAndStartTaskWithOptionsAsync(TaskInfoCreateAndStartTaskRequest request, TaskInfoCreateAndStartTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attr))
            {
                body["attr"] = request.Attr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BacklogDTO))
            {
                body["backlogDTO"] = request.BacklogDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BacklogGenerateFlag))
            {
                body["backlogGenerateFlag"] = request.BacklogGenerateFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessCode))
            {
                body["businessCode"] = request.BusinessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CanceldelTaskCardId))
            {
                body["canceldelTaskCardId"] = request.CanceldelTaskCardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardDTO))
            {
                body["cardDTO"] = request.CardDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFlag))
            {
                body["customFlag"] = request.CustomFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailUrl))
            {
                body["detailUrl"] = request.DetailUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishTaskCardId))
            {
                body["finishTaskCardId"] = request.FinishTaskCardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorAccount))
            {
                body["operatorAccount"] = request.OperatorAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTaskId))
            {
                body["outTaskId"] = request.OutTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjId))
            {
                body["projId"] = request.ProjId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendMsgFlag))
            {
                body["sendMsgFlag"] = request.SendMsgFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                body["sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTaskCardId))
            {
                body["startTaskCardId"] = request.StartTaskCardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                body["state"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskContent))
            {
                body["taskContent"] = request.TaskContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskEndTime))
            {
                body["taskEndTime"] = request.TaskEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutePersonDTOS))
            {
                body["taskExecutePersonDTOS"] = request.TaskExecutePersonDTOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskGroupDTOList))
            {
                body["taskGroupDTOList"] = request.TaskGroupDTOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskSystem))
            {
                body["taskSystem"] = request.TaskSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTemplCode))
            {
                body["taskTemplCode"] = request.TaskTemplCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTitle))
            {
                body["taskTitle"] = request.TaskTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUrlMobile))
            {
                body["taskUrlMobile"] = request.TaskUrlMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUrlPc))
            {
                body["taskUrlPc"] = request.TaskUrlPc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTaskCardId))
            {
                body["updateTaskCardId"] = request.UpdateTaskCardId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TaskInfoCreateAndStartTask",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/taskCenters/taskInfos/createAndStart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskInfoCreateAndStartTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建并启动任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoCreateAndStartTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoCreateAndStartTaskResponse
        /// </returns>
        public TaskInfoCreateAndStartTaskResponse TaskInfoCreateAndStartTask(TaskInfoCreateAndStartTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoCreateAndStartTaskHeaders headers = new TaskInfoCreateAndStartTaskHeaders();
            return TaskInfoCreateAndStartTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建并启动任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoCreateAndStartTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoCreateAndStartTaskResponse
        /// </returns>
        public async Task<TaskInfoCreateAndStartTaskResponse> TaskInfoCreateAndStartTaskAsync(TaskInfoCreateAndStartTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoCreateAndStartTaskHeaders headers = new TaskInfoCreateAndStartTaskHeaders();
            return await TaskInfoCreateAndStartTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>完成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoFinishTaskRequest
        /// </param>
        /// <param name="headers">
        /// TaskInfoFinishTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoFinishTaskResponse
        /// </returns>
        public TaskInfoFinishTaskResponse TaskInfoFinishTaskWithOptions(TaskInfoFinishTaskRequest request, TaskInfoFinishTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardDTO))
            {
                body["cardDTO"] = request.CardDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorAccount))
            {
                body["operatorAccount"] = request.OperatorAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTaskId))
            {
                body["outTaskId"] = request.OutTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjId))
            {
                body["projId"] = request.ProjId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendMsgFlag))
            {
                body["sendMsgFlag"] = request.SendMsgFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutePersonDTOS))
            {
                body["taskExecutePersonDTOS"] = request.TaskExecutePersonDTOS;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TaskInfoFinishTask",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/taskCenters/taskInfos/finishTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskInfoFinishTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>完成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoFinishTaskRequest
        /// </param>
        /// <param name="headers">
        /// TaskInfoFinishTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoFinishTaskResponse
        /// </returns>
        public async Task<TaskInfoFinishTaskResponse> TaskInfoFinishTaskWithOptionsAsync(TaskInfoFinishTaskRequest request, TaskInfoFinishTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardDTO))
            {
                body["cardDTO"] = request.CardDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorAccount))
            {
                body["operatorAccount"] = request.OperatorAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTaskId))
            {
                body["outTaskId"] = request.OutTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjId))
            {
                body["projId"] = request.ProjId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendMsgFlag))
            {
                body["sendMsgFlag"] = request.SendMsgFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutePersonDTOS))
            {
                body["taskExecutePersonDTOS"] = request.TaskExecutePersonDTOS;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TaskInfoFinishTask",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/taskCenters/taskInfos/finishTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskInfoFinishTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>完成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoFinishTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoFinishTaskResponse
        /// </returns>
        public TaskInfoFinishTaskResponse TaskInfoFinishTask(TaskInfoFinishTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoFinishTaskHeaders headers = new TaskInfoFinishTaskHeaders();
            return TaskInfoFinishTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>完成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoFinishTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoFinishTaskResponse
        /// </returns>
        public async Task<TaskInfoFinishTaskResponse> TaskInfoFinishTaskAsync(TaskInfoFinishTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoFinishTaskHeaders headers = new TaskInfoFinishTaskHeaders();
            return await TaskInfoFinishTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoUpdateTaskRequest
        /// </param>
        /// <param name="headers">
        /// TaskInfoUpdateTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoUpdateTaskResponse
        /// </returns>
        public TaskInfoUpdateTaskResponse TaskInfoUpdateTaskWithOptions(TaskInfoUpdateTaskRequest request, TaskInfoUpdateTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attr))
            {
                body["attr"] = request.Attr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CanceldelTaskCardId))
            {
                body["canceldelTaskCardId"] = request.CanceldelTaskCardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardDTO))
            {
                body["cardDTO"] = request.CardDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailUrl))
            {
                body["detailUrl"] = request.DetailUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishTaskCardId))
            {
                body["finishTaskCardId"] = request.FinishTaskCardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListOpenConversationId))
            {
                body["listOpenConversationId"] = request.ListOpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["operateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorAccount))
            {
                body["operatorAccount"] = request.OperatorAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTaskId))
            {
                body["outTaskId"] = request.OutTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjId))
            {
                body["projId"] = request.ProjId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendMsgFlag))
            {
                body["sendMsgFlag"] = request.SendMsgFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTaskCardId))
            {
                body["startTaskCardId"] = request.StartTaskCardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskContent))
            {
                body["taskContent"] = request.TaskContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskEndTime))
            {
                body["taskEndTime"] = request.TaskEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutePersonDTOS))
            {
                body["taskExecutePersonDTOS"] = request.TaskExecutePersonDTOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTitle))
            {
                body["taskTitle"] = request.TaskTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUrlMobile))
            {
                body["taskUrlMobile"] = request.TaskUrlMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUrlPc))
            {
                body["taskUrlPc"] = request.TaskUrlPc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTaskCardId))
            {
                body["updateTaskCardId"] = request.UpdateTaskCardId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TaskInfoUpdateTask",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/taskCenters/taskInfos/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskInfoUpdateTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoUpdateTaskRequest
        /// </param>
        /// <param name="headers">
        /// TaskInfoUpdateTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoUpdateTaskResponse
        /// </returns>
        public async Task<TaskInfoUpdateTaskResponse> TaskInfoUpdateTaskWithOptionsAsync(TaskInfoUpdateTaskRequest request, TaskInfoUpdateTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attr))
            {
                body["attr"] = request.Attr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CanceldelTaskCardId))
            {
                body["canceldelTaskCardId"] = request.CanceldelTaskCardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardDTO))
            {
                body["cardDTO"] = request.CardDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailUrl))
            {
                body["detailUrl"] = request.DetailUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishTaskCardId))
            {
                body["finishTaskCardId"] = request.FinishTaskCardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListOpenConversationId))
            {
                body["listOpenConversationId"] = request.ListOpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["operateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorAccount))
            {
                body["operatorAccount"] = request.OperatorAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTaskId))
            {
                body["outTaskId"] = request.OutTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjId))
            {
                body["projId"] = request.ProjId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                body["secretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendMsgFlag))
            {
                body["sendMsgFlag"] = request.SendMsgFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTaskCardId))
            {
                body["startTaskCardId"] = request.StartTaskCardId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskContent))
            {
                body["taskContent"] = request.TaskContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskEndTime))
            {
                body["taskEndTime"] = request.TaskEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutePersonDTOS))
            {
                body["taskExecutePersonDTOS"] = request.TaskExecutePersonDTOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTitle))
            {
                body["taskTitle"] = request.TaskTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUrlMobile))
            {
                body["taskUrlMobile"] = request.TaskUrlMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUrlPc))
            {
                body["taskUrlPc"] = request.TaskUrlPc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTaskCardId))
            {
                body["updateTaskCardId"] = request.UpdateTaskCardId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TaskInfoUpdateTask",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/taskCenters/taskInfos/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaskInfoUpdateTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoUpdateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoUpdateTaskResponse
        /// </returns>
        public TaskInfoUpdateTaskResponse TaskInfoUpdateTask(TaskInfoUpdateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoUpdateTaskHeaders headers = new TaskInfoUpdateTaskHeaders();
            return TaskInfoUpdateTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaskInfoUpdateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// TaskInfoUpdateTaskResponse
        /// </returns>
        public async Task<TaskInfoUpdateTaskResponse> TaskInfoUpdateTaskAsync(TaskInfoUpdateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoUpdateTaskHeaders headers = new TaskInfoUpdateTaskHeaders();
            return await TaskInfoUpdateTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>切换组织归属</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferExclusiveAccountOrgRequest
        /// </param>
        /// <param name="headers">
        /// TransferExclusiveAccountOrgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferExclusiveAccountOrgResponse
        /// </returns>
        public TransferExclusiveAccountOrgResponse TransferExclusiveAccountOrgWithOptions(TransferExclusiveAccountOrgRequest request, TransferExclusiveAccountOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSettingMainOrg))
            {
                body["isSettingMainOrg"] = request.IsSettingMainOrg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TransferExclusiveAccountOrg",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/organizations/transfer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferExclusiveAccountOrgResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>切换组织归属</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferExclusiveAccountOrgRequest
        /// </param>
        /// <param name="headers">
        /// TransferExclusiveAccountOrgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferExclusiveAccountOrgResponse
        /// </returns>
        public async Task<TransferExclusiveAccountOrgResponse> TransferExclusiveAccountOrgWithOptionsAsync(TransferExclusiveAccountOrgRequest request, TransferExclusiveAccountOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSettingMainOrg))
            {
                body["isSettingMainOrg"] = request.IsSettingMainOrg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TransferExclusiveAccountOrg",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/organizations/transfer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferExclusiveAccountOrgResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>切换组织归属</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferExclusiveAccountOrgRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferExclusiveAccountOrgResponse
        /// </returns>
        public TransferExclusiveAccountOrgResponse TransferExclusiveAccountOrg(TransferExclusiveAccountOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TransferExclusiveAccountOrgHeaders headers = new TransferExclusiveAccountOrgHeaders();
            return TransferExclusiveAccountOrgWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>切换组织归属</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferExclusiveAccountOrgRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferExclusiveAccountOrgResponse
        /// </returns>
        public async Task<TransferExclusiveAccountOrgResponse> TransferExclusiveAccountOrgAsync(TransferExclusiveAccountOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TransferExclusiveAccountOrgHeaders headers = new TransferExclusiveAccountOrgHeaders();
            return await TransferExclusiveAccountOrgWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改分组名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCategoryNameRequest
        /// </param>
        /// <param name="headers">
        /// UpdateCategoryNameHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCategoryNameResponse
        /// </returns>
        public UpdateCategoryNameResponse UpdateCategoryNameWithOptions(UpdateCategoryNameRequest request, UpdateCategoryNameHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentCategoryName))
            {
                body["currentCategoryName"] = request.CurrentCategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCategoryName))
            {
                body["targetCategoryName"] = request.TargetCategoryName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateCategoryName",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/messageCategories/categories/names",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCategoryNameResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改分组名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCategoryNameRequest
        /// </param>
        /// <param name="headers">
        /// UpdateCategoryNameHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCategoryNameResponse
        /// </returns>
        public async Task<UpdateCategoryNameResponse> UpdateCategoryNameWithOptionsAsync(UpdateCategoryNameRequest request, UpdateCategoryNameHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentCategoryName))
            {
                body["currentCategoryName"] = request.CurrentCategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCategoryName))
            {
                body["targetCategoryName"] = request.TargetCategoryName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateCategoryName",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/messageCategories/categories/names",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCategoryNameResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改分组名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCategoryNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCategoryNameResponse
        /// </returns>
        public UpdateCategoryNameResponse UpdateCategoryName(UpdateCategoryNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCategoryNameHeaders headers = new UpdateCategoryNameHeaders();
            return UpdateCategoryNameWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改分组名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCategoryNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCategoryNameResponse
        /// </returns>
        public async Task<UpdateCategoryNameResponse> UpdateCategoryNameAsync(UpdateCategoryNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCategoryNameHeaders headers = new UpdateCategoryNameHeaders();
            return await UpdateCategoryNameWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更群聊类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConversationTypeRequest
        /// </param>
        /// <param name="headers">
        /// UpdateConversationTypeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConversationTypeResponse
        /// </returns>
        public UpdateConversationTypeResponse UpdateConversationTypeWithOptions(UpdateConversationTypeRequest request, UpdateConversationTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManageSign))
            {
                body["manageSign"] = request.ManageSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateConversationType",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/conversationTypes",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConversationTypeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更群聊类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConversationTypeRequest
        /// </param>
        /// <param name="headers">
        /// UpdateConversationTypeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConversationTypeResponse
        /// </returns>
        public async Task<UpdateConversationTypeResponse> UpdateConversationTypeWithOptionsAsync(UpdateConversationTypeRequest request, UpdateConversationTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManageSign))
            {
                body["manageSign"] = request.ManageSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateConversationType",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/conversationTypes",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConversationTypeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更群聊类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConversationTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConversationTypeResponse
        /// </returns>
        public UpdateConversationTypeResponse UpdateConversationType(UpdateConversationTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateConversationTypeHeaders headers = new UpdateConversationTypeHeaders();
            return UpdateConversationTypeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更群聊类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConversationTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConversationTypeResponse
        /// </returns>
        public async Task<UpdateConversationTypeResponse> UpdateConversationTypeAsync(UpdateConversationTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateConversationTypeHeaders headers = new UpdateConversationTypeHeaders();
            return await UpdateConversationTypeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发送文件的检测状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFileStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateFileStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFileStatusResponse
        /// </returns>
        public UpdateFileStatusResponse UpdateFileStatusWithOptions(UpdateFileStatusRequest request, UpdateFileStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestIds))
            {
                body["requestIds"] = request.RequestIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateFileStatus",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/sending/files/status",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFileStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发送文件的检测状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFileStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateFileStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFileStatusResponse
        /// </returns>
        public async Task<UpdateFileStatusResponse> UpdateFileStatusWithOptionsAsync(UpdateFileStatusRequest request, UpdateFileStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestIds))
            {
                body["requestIds"] = request.RequestIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateFileStatus",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/sending/files/status",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFileStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发送文件的检测状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFileStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFileStatusResponse
        /// </returns>
        public UpdateFileStatusResponse UpdateFileStatus(UpdateFileStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFileStatusHeaders headers = new UpdateFileStatusHeaders();
            return UpdateFileStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发送文件的检测状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFileStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFileStatusResponse
        /// </returns>
        public async Task<UpdateFileStatusResponse> UpdateFileStatusAsync(UpdateFileStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFileStatusHeaders headers = new UpdateFileStatusHeaders();
            return await UpdateFileStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMiniAppVersionStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMiniAppVersionStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMiniAppVersionStatusResponse
        /// </returns>
        public UpdateMiniAppVersionStatusResponse UpdateMiniAppVersionStatusWithOptions(UpdateMiniAppVersionStatusRequest request, UpdateMiniAppVersionStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionType))
            {
                body["versionType"] = request.VersionType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateMiniAppVersionStatus",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/miniApps/versions/versionStatus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMiniAppVersionStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMiniAppVersionStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMiniAppVersionStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMiniAppVersionStatusResponse
        /// </returns>
        public async Task<UpdateMiniAppVersionStatusResponse> UpdateMiniAppVersionStatusWithOptionsAsync(UpdateMiniAppVersionStatusRequest request, UpdateMiniAppVersionStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                body["miniAppId"] = request.MiniAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionType))
            {
                body["versionType"] = request.VersionType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateMiniAppVersionStatus",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/miniApps/versions/versionStatus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMiniAppVersionStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMiniAppVersionStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMiniAppVersionStatusResponse
        /// </returns>
        public UpdateMiniAppVersionStatusResponse UpdateMiniAppVersionStatus(UpdateMiniAppVersionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMiniAppVersionStatusHeaders headers = new UpdateMiniAppVersionStatusHeaders();
            return UpdateMiniAppVersionStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMiniAppVersionStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMiniAppVersionStatusResponse
        /// </returns>
        public async Task<UpdateMiniAppVersionStatusResponse> UpdateMiniAppVersionStatusAsync(UpdateMiniAppVersionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMiniAppVersionStatusHeaders headers = new UpdateMiniAppVersionStatusHeaders();
            return await UpdateMiniAppVersionStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改伙伴类型可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePartnerVisibilityRequest
        /// </param>
        /// <param name="headers">
        /// UpdatePartnerVisibilityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePartnerVisibilityResponse
        /// </returns>
        public UpdatePartnerVisibilityResponse UpdatePartnerVisibilityWithOptions(UpdatePartnerVisibilityRequest request, UpdatePartnerVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["labelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdatePartnerVisibility",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/partnerDepartments/visibilityPartners",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "boolean",
            };
            return TeaModel.ToObject<UpdatePartnerVisibilityResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改伙伴类型可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePartnerVisibilityRequest
        /// </param>
        /// <param name="headers">
        /// UpdatePartnerVisibilityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePartnerVisibilityResponse
        /// </returns>
        public async Task<UpdatePartnerVisibilityResponse> UpdatePartnerVisibilityWithOptionsAsync(UpdatePartnerVisibilityRequest request, UpdatePartnerVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["labelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdatePartnerVisibility",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/partnerDepartments/visibilityPartners",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "boolean",
            };
            return TeaModel.ToObject<UpdatePartnerVisibilityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改伙伴类型可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePartnerVisibilityRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePartnerVisibilityResponse
        /// </returns>
        public UpdatePartnerVisibilityResponse UpdatePartnerVisibility(UpdatePartnerVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePartnerVisibilityHeaders headers = new UpdatePartnerVisibilityHeaders();
            return UpdatePartnerVisibilityWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改伙伴类型可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePartnerVisibilityRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePartnerVisibilityResponse
        /// </returns>
        public async Task<UpdatePartnerVisibilityResponse> UpdatePartnerVisibilityAsync(UpdatePartnerVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePartnerVisibilityHeaders headers = new UpdatePartnerVisibilityHeaders();
            return await UpdatePartnerVisibilityWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属一线版-企业修改员工license</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRealmLicenseRequest
        /// </param>
        /// <param name="headers">
        /// UpdateRealmLicenseHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRealmLicenseResponse
        /// </returns>
        public UpdateRealmLicenseResponse UpdateRealmLicenseWithOptions(UpdateRealmLicenseRequest request, UpdateRealmLicenseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailList))
            {
                body["detailList"] = request.DetailList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateRealmLicense",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/frontLines/licenses",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRealmLicenseResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属一线版-企业修改员工license</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRealmLicenseRequest
        /// </param>
        /// <param name="headers">
        /// UpdateRealmLicenseHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRealmLicenseResponse
        /// </returns>
        public async Task<UpdateRealmLicenseResponse> UpdateRealmLicenseWithOptionsAsync(UpdateRealmLicenseRequest request, UpdateRealmLicenseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailList))
            {
                body["detailList"] = request.DetailList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateRealmLicense",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/frontLines/licenses",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRealmLicenseResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属一线版-企业修改员工license</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRealmLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRealmLicenseResponse
        /// </returns>
        public UpdateRealmLicenseResponse UpdateRealmLicense(UpdateRealmLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRealmLicenseHeaders headers = new UpdateRealmLicenseHeaders();
            return UpdateRealmLicenseWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属一线版-企业修改员工license</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRealmLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRealmLicenseResponse
        /// </returns>
        public async Task<UpdateRealmLicenseResponse> UpdateRealmLicenseAsync(UpdateRealmLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRealmLicenseHeaders headers = new UpdateRealmLicenseHeaders();
            return await UpdateRealmLicenseWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改角色可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRoleVisibilityRequest
        /// </param>
        /// <param name="headers">
        /// UpdateRoleVisibilityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRoleVisibilityResponse
        /// </returns>
        public UpdateRoleVisibilityResponse UpdateRoleVisibilityWithOptions(UpdateRoleVisibilityRequest request, UpdateRoleVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["labelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateRoleVisibility",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/partnerDepartments/visibilityRoles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "boolean",
            };
            return TeaModel.ToObject<UpdateRoleVisibilityResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改角色可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRoleVisibilityRequest
        /// </param>
        /// <param name="headers">
        /// UpdateRoleVisibilityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRoleVisibilityResponse
        /// </returns>
        public async Task<UpdateRoleVisibilityResponse> UpdateRoleVisibilityWithOptionsAsync(UpdateRoleVisibilityRequest request, UpdateRoleVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["labelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateRoleVisibility",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/partnerDepartments/visibilityRoles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "boolean",
            };
            return TeaModel.ToObject<UpdateRoleVisibilityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改角色可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRoleVisibilityRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRoleVisibilityResponse
        /// </returns>
        public UpdateRoleVisibilityResponse UpdateRoleVisibility(UpdateRoleVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRoleVisibilityHeaders headers = new UpdateRoleVisibilityHeaders();
            return UpdateRoleVisibilityWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改角色可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRoleVisibilityRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRoleVisibilityResponse
        /// </returns>
        public async Task<UpdateRoleVisibilityResponse> UpdateRoleVisibilityAsync(UpdateRoleVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRoleVisibilityHeaders headers = new UpdateRoleVisibilityHeaders();
            return await UpdateRoleVisibilityWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新组织专属存储模式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateStorageModeRequest
        /// </param>
        /// <param name="headers">
        /// UpdateStorageModeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateStorageModeResponse
        /// </returns>
        public UpdateStorageModeResponse UpdateStorageModeWithOptions(UpdateStorageModeRequest request, UpdateStorageModeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileStorageMode))
            {
                body["fileStorageMode"] = request.FileStorageMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateStorageMode",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileStorages/acrossClouds/storageModes",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStorageModeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新组织专属存储模式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateStorageModeRequest
        /// </param>
        /// <param name="headers">
        /// UpdateStorageModeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateStorageModeResponse
        /// </returns>
        public async Task<UpdateStorageModeResponse> UpdateStorageModeWithOptionsAsync(UpdateStorageModeRequest request, UpdateStorageModeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileStorageMode))
            {
                body["fileStorageMode"] = request.FileStorageMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateStorageMode",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/fileStorages/acrossClouds/storageModes",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStorageModeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新组织专属存储模式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateStorageModeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateStorageModeResponse
        /// </returns>
        public UpdateStorageModeResponse UpdateStorageMode(UpdateStorageModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateStorageModeHeaders headers = new UpdateStorageModeHeaders();
            return UpdateStorageModeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新组织专属存储模式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateStorageModeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateStorageModeResponse
        /// </returns>
        public async Task<UpdateStorageModeResponse> UpdateStorageModeAsync(UpdateStorageModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateStorageModeHeaders headers = new UpdateStorageModeHeaders();
            return await UpdateStorageModeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>允许三方调用该API，决定对应的语音消息管控状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVoiceMsgCtrlStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateVoiceMsgCtrlStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVoiceMsgCtrlStatusResponse
        /// </returns>
        public UpdateVoiceMsgCtrlStatusResponse UpdateVoiceMsgCtrlStatusWithOptions(UpdateVoiceMsgCtrlStatusRequest request, UpdateVoiceMsgCtrlStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceMsgCtrlInfo))
            {
                body["voiceMsgCtrlInfo"] = request.VoiceMsgCtrlInfo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateVoiceMsgCtrlStatus",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/voiceMessages/ctrlStatuses",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVoiceMsgCtrlStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>允许三方调用该API，决定对应的语音消息管控状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVoiceMsgCtrlStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateVoiceMsgCtrlStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVoiceMsgCtrlStatusResponse
        /// </returns>
        public async Task<UpdateVoiceMsgCtrlStatusResponse> UpdateVoiceMsgCtrlStatusWithOptionsAsync(UpdateVoiceMsgCtrlStatusRequest request, UpdateVoiceMsgCtrlStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceMsgCtrlInfo))
            {
                body["voiceMsgCtrlInfo"] = request.VoiceMsgCtrlInfo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateVoiceMsgCtrlStatus",
                Version = "exclusive_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/exclusive/voiceMessages/ctrlStatuses",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVoiceMsgCtrlStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>允许三方调用该API，决定对应的语音消息管控状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVoiceMsgCtrlStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVoiceMsgCtrlStatusResponse
        /// </returns>
        public UpdateVoiceMsgCtrlStatusResponse UpdateVoiceMsgCtrlStatus(UpdateVoiceMsgCtrlStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateVoiceMsgCtrlStatusHeaders headers = new UpdateVoiceMsgCtrlStatusHeaders();
            return UpdateVoiceMsgCtrlStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>允许三方调用该API，决定对应的语音消息管控状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVoiceMsgCtrlStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVoiceMsgCtrlStatusResponse
        /// </returns>
        public async Task<UpdateVoiceMsgCtrlStatusResponse> UpdateVoiceMsgCtrlStatusAsync(UpdateVoiceMsgCtrlStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateVoiceMsgCtrlStatusHeaders headers = new UpdateVoiceMsgCtrlStatusHeaders();
            return await UpdateVoiceMsgCtrlStatusWithOptionsAsync(request, headers, runtime);
        }

    }
}
