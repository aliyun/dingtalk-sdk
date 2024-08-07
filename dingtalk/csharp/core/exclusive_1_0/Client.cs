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


        /**
         * @summary 新增企业
         *
         * @param request AddOrgRequest
         * @param headers AddOrgHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddOrgResponse
         */
        public AddOrgResponse AddOrgWithOptions(AddOrgRequest request, AddOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNum))
            {
                body["mobileNum"] = request.MobileNum;
            }
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

        /**
         * @summary 新增企业
         *
         * @param request AddOrgRequest
         * @param headers AddOrgHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddOrgResponse
         */
        public async Task<AddOrgResponse> AddOrgWithOptionsAsync(AddOrgRequest request, AddOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNum))
            {
                body["mobileNum"] = request.MobileNum;
            }
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

        /**
         * @summary 新增企业
         *
         * @param request AddOrgRequest
         * @return AddOrgResponse
         */
        public AddOrgResponse AddOrg(AddOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrgHeaders headers = new AddOrgHeaders();
            return AddOrgWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新增企业
         *
         * @param request AddOrgRequest
         * @return AddOrgResponse
         */
        public async Task<AddOrgResponse> AddOrgAsync(AddOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrgHeaders headers = new AddOrgHeaders();
            return await AddOrgWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 专属审批结果回调
         *
         * @param request ApproveProcessCallbackRequest
         * @param headers ApproveProcessCallbackHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApproveProcessCallbackResponse
         */
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

        /**
         * @summary 专属审批结果回调
         *
         * @param request ApproveProcessCallbackRequest
         * @param headers ApproveProcessCallbackHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApproveProcessCallbackResponse
         */
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

        /**
         * @summary 专属审批结果回调
         *
         * @param request ApproveProcessCallbackRequest
         * @return ApproveProcessCallbackResponse
         */
        public ApproveProcessCallbackResponse ApproveProcessCallback(ApproveProcessCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApproveProcessCallbackHeaders headers = new ApproveProcessCallbackHeaders();
            return ApproveProcessCallbackWithOptions(request, headers, runtime);
        }

        /**
         * @summary 专属审批结果回调
         *
         * @param request ApproveProcessCallbackRequest
         * @return ApproveProcessCallbackResponse
         */
        public async Task<ApproveProcessCallbackResponse> ApproveProcessCallbackAsync(ApproveProcessCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApproveProcessCallbackHeaders headers = new ApproveProcessCallbackHeaders();
            return await ApproveProcessCallbackWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 群禁言或解禁
         *
         * @param request BanOrOpenGroupWordsRequest
         * @param headers BanOrOpenGroupWordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BanOrOpenGroupWordsResponse
         */
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

        /**
         * @summary 群禁言或解禁
         *
         * @param request BanOrOpenGroupWordsRequest
         * @param headers BanOrOpenGroupWordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BanOrOpenGroupWordsResponse
         */
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

        /**
         * @summary 群禁言或解禁
         *
         * @param request BanOrOpenGroupWordsRequest
         * @return BanOrOpenGroupWordsResponse
         */
        public BanOrOpenGroupWordsResponse BanOrOpenGroupWords(BanOrOpenGroupWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BanOrOpenGroupWordsHeaders headers = new BanOrOpenGroupWordsHeaders();
            return BanOrOpenGroupWordsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 群禁言或解禁
         *
         * @param request BanOrOpenGroupWordsRequest
         * @return BanOrOpenGroupWordsResponse
         */
        public async Task<BanOrOpenGroupWordsResponse> BanOrOpenGroupWordsAsync(BanOrOpenGroupWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BanOrOpenGroupWordsHeaders headers = new BanOrOpenGroupWordsHeaders();
            return await BanOrOpenGroupWordsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建分组并绑定会话
         *
         * @param request CreateCategoryAndBindingGroupsRequest
         * @param headers CreateCategoryAndBindingGroupsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCategoryAndBindingGroupsResponse
         */
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

        /**
         * @summary 创建分组并绑定会话
         *
         * @param request CreateCategoryAndBindingGroupsRequest
         * @param headers CreateCategoryAndBindingGroupsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCategoryAndBindingGroupsResponse
         */
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

        /**
         * @summary 创建分组并绑定会话
         *
         * @param request CreateCategoryAndBindingGroupsRequest
         * @return CreateCategoryAndBindingGroupsResponse
         */
        public CreateCategoryAndBindingGroupsResponse CreateCategoryAndBindingGroups(CreateCategoryAndBindingGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCategoryAndBindingGroupsHeaders headers = new CreateCategoryAndBindingGroupsHeaders();
            return CreateCategoryAndBindingGroupsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建分组并绑定会话
         *
         * @param request CreateCategoryAndBindingGroupsRequest
         * @return CreateCategoryAndBindingGroupsResponse
         */
        public async Task<CreateCategoryAndBindingGroupsResponse> CreateCategoryAndBindingGroupsAsync(CreateCategoryAndBindingGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCategoryAndBindingGroupsHeaders headers = new CreateCategoryAndBindingGroupsHeaders();
            return await CreateCategoryAndBindingGroupsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建文件检测任务
         *
         * @param request CreateDlpTaskRequest
         * @param headers CreateDlpTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDlpTaskResponse
         */
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

        /**
         * @summary 创建文件检测任务
         *
         * @param request CreateDlpTaskRequest
         * @param headers CreateDlpTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDlpTaskResponse
         */
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

        /**
         * @summary 创建文件检测任务
         *
         * @param request CreateDlpTaskRequest
         * @return CreateDlpTaskResponse
         */
        public CreateDlpTaskResponse CreateDlpTask(CreateDlpTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDlpTaskHeaders headers = new CreateDlpTaskHeaders();
            return CreateDlpTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建文件检测任务
         *
         * @param request CreateDlpTaskRequest
         * @return CreateDlpTaskResponse
         */
        public async Task<CreateDlpTaskResponse> CreateDlpTaskAsync(CreateDlpTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDlpTaskHeaders headers = new CreateDlpTaskHeaders();
            return await CreateDlpTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建分组并绑定会话
         *
         * @param request CreateMessageCategoryRequest
         * @param headers CreateMessageCategoryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMessageCategoryResponse
         */
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

        /**
         * @summary 创建分组并绑定会话
         *
         * @param request CreateMessageCategoryRequest
         * @param headers CreateMessageCategoryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMessageCategoryResponse
         */
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

        /**
         * @summary 创建分组并绑定会话
         *
         * @param request CreateMessageCategoryRequest
         * @return CreateMessageCategoryResponse
         */
        public CreateMessageCategoryResponse CreateMessageCategory(CreateMessageCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMessageCategoryHeaders headers = new CreateMessageCategoryHeaders();
            return CreateMessageCategoryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建分组并绑定会话
         *
         * @param request CreateMessageCategoryRequest
         * @return CreateMessageCategoryResponse
         */
        public async Task<CreateMessageCategoryResponse> CreateMessageCategoryAsync(CreateMessageCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMessageCategoryHeaders headers = new CreateMessageCategoryHeaders();
            return await CreateMessageCategoryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建规则
         *
         * @param request CreateRuleRequest
         * @param headers CreateRuleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRuleResponse
         */
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

        /**
         * @summary 创建规则
         *
         * @param request CreateRuleRequest
         * @param headers CreateRuleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRuleResponse
         */
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

        /**
         * @summary 创建规则
         *
         * @param request CreateRuleRequest
         * @return CreateRuleResponse
         */
        public CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRuleHeaders headers = new CreateRuleHeaders();
            return CreateRuleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建规则
         *
         * @param request CreateRuleRequest
         * @return CreateRuleResponse
         */
        public async Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateRuleHeaders headers = new CreateRuleHeaders();
            return await CreateRuleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 存入可信设备信息
         *
         * @param request CreateTrustedDeviceRequest
         * @param headers CreateTrustedDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTrustedDeviceResponse
         */
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

        /**
         * @summary 存入可信设备信息
         *
         * @param request CreateTrustedDeviceRequest
         * @param headers CreateTrustedDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTrustedDeviceResponse
         */
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

        /**
         * @summary 存入可信设备信息
         *
         * @param request CreateTrustedDeviceRequest
         * @return CreateTrustedDeviceResponse
         */
        public CreateTrustedDeviceResponse CreateTrustedDevice(CreateTrustedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTrustedDeviceHeaders headers = new CreateTrustedDeviceHeaders();
            return CreateTrustedDeviceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 存入可信设备信息
         *
         * @param request CreateTrustedDeviceRequest
         * @return CreateTrustedDeviceResponse
         */
        public async Task<CreateTrustedDeviceResponse> CreateTrustedDeviceAsync(CreateTrustedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTrustedDeviceHeaders headers = new CreateTrustedDeviceHeaders();
            return await CreateTrustedDeviceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量新增可信设备
         *
         * @param request CreateTrustedDeviceBatchRequest
         * @param headers CreateTrustedDeviceBatchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTrustedDeviceBatchResponse
         */
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

        /**
         * @summary 批量新增可信设备
         *
         * @param request CreateTrustedDeviceBatchRequest
         * @param headers CreateTrustedDeviceBatchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTrustedDeviceBatchResponse
         */
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

        /**
         * @summary 批量新增可信设备
         *
         * @param request CreateTrustedDeviceBatchRequest
         * @return CreateTrustedDeviceBatchResponse
         */
        public CreateTrustedDeviceBatchResponse CreateTrustedDeviceBatch(CreateTrustedDeviceBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTrustedDeviceBatchHeaders headers = new CreateTrustedDeviceBatchHeaders();
            return CreateTrustedDeviceBatchWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量新增可信设备
         *
         * @param request CreateTrustedDeviceBatchRequest
         * @return CreateTrustedDeviceBatchResponse
         */
        public async Task<CreateTrustedDeviceBatchResponse> CreateTrustedDeviceBatchAsync(CreateTrustedDeviceBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTrustedDeviceBatchHeaders headers = new CreateTrustedDeviceBatchHeaders();
            return await CreateTrustedDeviceBatchWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 触发文件病毒扫描任务
         *
         * @param request CreateVirusScanTaskRequest
         * @param headers CreateVirusScanTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVirusScanTaskResponse
         */
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

        /**
         * @summary 触发文件病毒扫描任务
         *
         * @param request CreateVirusScanTaskRequest
         * @param headers CreateVirusScanTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVirusScanTaskResponse
         */
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

        /**
         * @summary 触发文件病毒扫描任务
         *
         * @param request CreateVirusScanTaskRequest
         * @return CreateVirusScanTaskResponse
         */
        public CreateVirusScanTaskResponse CreateVirusScanTask(CreateVirusScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVirusScanTaskHeaders headers = new CreateVirusScanTaskHeaders();
            return CreateVirusScanTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 触发文件病毒扫描任务
         *
         * @param request CreateVirusScanTaskRequest
         * @return CreateVirusScanTaskResponse
         */
        public async Task<CreateVirusScanTaskResponse> CreateVirusScanTaskAsync(CreateVirusScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVirusScanTaskHeaders headers = new CreateVirusScanTaskHeaders();
            return await CreateVirusScanTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 为应用同步数据到专属存储
         *
         * @param request DataSyncRequest
         * @param headers DataSyncHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DataSyncResponse
         */
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

        /**
         * @summary 为应用同步数据到专属存储
         *
         * @param request DataSyncRequest
         * @param headers DataSyncHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DataSyncResponse
         */
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

        /**
         * @summary 为应用同步数据到专属存储
         *
         * @param request DataSyncRequest
         * @return DataSyncResponse
         */
        public DataSyncResponse DataSync(DataSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DataSyncHeaders headers = new DataSyncHeaders();
            return DataSyncWithOptions(request, headers, runtime);
        }

        /**
         * @summary 为应用同步数据到专属存储
         *
         * @param request DataSyncRequest
         * @return DataSyncResponse
         */
        public async Task<DataSyncResponse> DataSyncAsync(DataSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DataSyncHeaders headers = new DataSyncHeaders();
            return await DataSyncWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除跨云存储配置
         *
         * @param headers DeleteAcrossCloudStroageConfigsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAcrossCloudStroageConfigsResponse
         */
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

        /**
         * @summary 删除跨云存储配置
         *
         * @param headers DeleteAcrossCloudStroageConfigsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAcrossCloudStroageConfigsResponse
         */
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

        /**
         * @summary 删除跨云存储配置
         *
         * @return DeleteAcrossCloudStroageConfigsResponse
         */
        public DeleteAcrossCloudStroageConfigsResponse DeleteAcrossCloudStroageConfigs(string targetCorpId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAcrossCloudStroageConfigsHeaders headers = new DeleteAcrossCloudStroageConfigsHeaders();
            return DeleteAcrossCloudStroageConfigsWithOptions(targetCorpId, headers, runtime);
        }

        /**
         * @summary 删除跨云存储配置
         *
         * @return DeleteAcrossCloudStroageConfigsResponse
         */
        public async Task<DeleteAcrossCloudStroageConfigsResponse> DeleteAcrossCloudStroageConfigsAsync(string targetCorpId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAcrossCloudStroageConfigsHeaders headers = new DeleteAcrossCloudStroageConfigsHeaders();
            return await DeleteAcrossCloudStroageConfigsWithOptionsAsync(targetCorpId, headers, runtime);
        }

        /**
         * @summary 删除评论
         *
         * @param headers DeleteCommentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCommentResponse
         */
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

        /**
         * @summary 删除评论
         *
         * @param headers DeleteCommentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCommentResponse
         */
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

        /**
         * @summary 删除评论
         *
         * @return DeleteCommentResponse
         */
        public DeleteCommentResponse DeleteComment(string publisherId, string commentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCommentHeaders headers = new DeleteCommentHeaders();
            return DeleteCommentWithOptions(publisherId, commentId, headers, runtime);
        }

        /**
         * @summary 删除评论
         *
         * @return DeleteCommentResponse
         */
        public async Task<DeleteCommentResponse> DeleteCommentAsync(string publisherId, string commentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCommentHeaders headers = new DeleteCommentHeaders();
            return await DeleteCommentWithOptionsAsync(publisherId, commentId, headers, runtime);
        }

        /**
         * @summary 删除指定可信设备
         *
         * @param request DeleteTrustedDeviceRequest
         * @param headers DeleteTrustedDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTrustedDeviceResponse
         */
        public DeleteTrustedDeviceResponse DeleteTrustedDeviceWithOptions(DeleteTrustedDeviceRequest request, DeleteTrustedDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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

        /**
         * @summary 删除指定可信设备
         *
         * @param request DeleteTrustedDeviceRequest
         * @param headers DeleteTrustedDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTrustedDeviceResponse
         */
        public async Task<DeleteTrustedDeviceResponse> DeleteTrustedDeviceWithOptionsAsync(DeleteTrustedDeviceRequest request, DeleteTrustedDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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

        /**
         * @summary 删除指定可信设备
         *
         * @param request DeleteTrustedDeviceRequest
         * @return DeleteTrustedDeviceResponse
         */
        public DeleteTrustedDeviceResponse DeleteTrustedDevice(DeleteTrustedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTrustedDeviceHeaders headers = new DeleteTrustedDeviceHeaders();
            return DeleteTrustedDeviceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除指定可信设备
         *
         * @param request DeleteTrustedDeviceRequest
         * @return DeleteTrustedDeviceResponse
         */
        public async Task<DeleteTrustedDeviceResponse> DeleteTrustedDeviceAsync(DeleteTrustedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTrustedDeviceHeaders headers = new DeleteTrustedDeviceHeaders();
            return await DeleteTrustedDeviceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 分发伙伴应用
         *
         * @param request DistributePartnerAppRequest
         * @param headers DistributePartnerAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DistributePartnerAppResponse
         */
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

        /**
         * @summary 分发伙伴应用
         *
         * @param request DistributePartnerAppRequest
         * @param headers DistributePartnerAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DistributePartnerAppResponse
         */
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

        /**
         * @summary 分发伙伴应用
         *
         * @param request DistributePartnerAppRequest
         * @return DistributePartnerAppResponse
         */
        public DistributePartnerAppResponse DistributePartnerApp(DistributePartnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DistributePartnerAppHeaders headers = new DistributePartnerAppHeaders();
            return DistributePartnerAppWithOptions(request, headers, runtime);
        }

        /**
         * @summary 分发伙伴应用
         *
         * @param request DistributePartnerAppRequest
         * @return DistributePartnerAppResponse
         */
        public async Task<DistributePartnerAppResponse> DistributePartnerAppAsync(DistributePartnerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DistributePartnerAppHeaders headers = new DistributePartnerAppHeaders();
            return await DistributePartnerAppWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更换组织主管理员
         *
         * @param request ExchangeMainAdminRequest
         * @param headers ExchangeMainAdminHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExchangeMainAdminResponse
         */
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

        /**
         * @summary 更换组织主管理员
         *
         * @param request ExchangeMainAdminRequest
         * @param headers ExchangeMainAdminHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExchangeMainAdminResponse
         */
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

        /**
         * @summary 更换组织主管理员
         *
         * @param request ExchangeMainAdminRequest
         * @return ExchangeMainAdminResponse
         */
        public ExchangeMainAdminResponse ExchangeMainAdmin(ExchangeMainAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExchangeMainAdminHeaders headers = new ExchangeMainAdminHeaders();
            return ExchangeMainAdminWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更换组织主管理员
         *
         * @param request ExchangeMainAdminRequest
         * @return ExchangeMainAdminResponse
         */
        public async Task<ExchangeMainAdminResponse> ExchangeMainAdminAsync(ExchangeMainAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExchangeMainAdminHeaders headers = new ExchangeMainAdminHeaders();
            return await ExchangeMainAdminWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 分发工作台模版
         *
         * @param request ExclusiveCreateDingPortalRequest
         * @param headers ExclusiveCreateDingPortalHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExclusiveCreateDingPortalResponse
         */
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

        /**
         * @summary 分发工作台模版
         *
         * @param request ExclusiveCreateDingPortalRequest
         * @param headers ExclusiveCreateDingPortalHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExclusiveCreateDingPortalResponse
         */
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

        /**
         * @summary 分发工作台模版
         *
         * @param request ExclusiveCreateDingPortalRequest
         * @return ExclusiveCreateDingPortalResponse
         */
        public ExclusiveCreateDingPortalResponse ExclusiveCreateDingPortal(ExclusiveCreateDingPortalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExclusiveCreateDingPortalHeaders headers = new ExclusiveCreateDingPortalHeaders();
            return ExclusiveCreateDingPortalWithOptions(request, headers, runtime);
        }

        /**
         * @summary 分发工作台模版
         *
         * @param request ExclusiveCreateDingPortalRequest
         * @return ExclusiveCreateDingPortalResponse
         */
        public async Task<ExclusiveCreateDingPortalResponse> ExclusiveCreateDingPortalAsync(ExclusiveCreateDingPortalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExclusiveCreateDingPortalHeaders headers = new ExclusiveCreateDingPortalHeaders();
            return await ExclusiveCreateDingPortalWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 专属文件第一次设置，激活配置
         *
         * @param request FileStorageActiveStorageRequest
         * @param headers FileStorageActiveStorageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileStorageActiveStorageResponse
         */
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

        /**
         * @summary 专属文件第一次设置，激活配置
         *
         * @param request FileStorageActiveStorageRequest
         * @param headers FileStorageActiveStorageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileStorageActiveStorageResponse
         */
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

        /**
         * @summary 专属文件第一次设置，激活配置
         *
         * @param request FileStorageActiveStorageRequest
         * @return FileStorageActiveStorageResponse
         */
        public FileStorageActiveStorageResponse FileStorageActiveStorage(FileStorageActiveStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageActiveStorageHeaders headers = new FileStorageActiveStorageHeaders();
            return FileStorageActiveStorageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 专属文件第一次设置，激活配置
         *
         * @param request FileStorageActiveStorageRequest
         * @return FileStorageActiveStorageResponse
         */
        public async Task<FileStorageActiveStorageResponse> FileStorageActiveStorageAsync(FileStorageActiveStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageActiveStorageHeaders headers = new FileStorageActiveStorageHeaders();
            return await FileStorageActiveStorageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 检查专属存储OSS连接
         *
         * @param request FileStorageCheckConnectionRequest
         * @param headers FileStorageCheckConnectionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileStorageCheckConnectionResponse
         */
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

        /**
         * @summary 检查专属存储OSS连接
         *
         * @param request FileStorageCheckConnectionRequest
         * @param headers FileStorageCheckConnectionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileStorageCheckConnectionResponse
         */
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

        /**
         * @summary 检查专属存储OSS连接
         *
         * @param request FileStorageCheckConnectionRequest
         * @return FileStorageCheckConnectionResponse
         */
        public FileStorageCheckConnectionResponse FileStorageCheckConnection(FileStorageCheckConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageCheckConnectionHeaders headers = new FileStorageCheckConnectionHeaders();
            return FileStorageCheckConnectionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 检查专属存储OSS连接
         *
         * @param request FileStorageCheckConnectionRequest
         * @return FileStorageCheckConnectionResponse
         */
        public async Task<FileStorageCheckConnectionResponse> FileStorageCheckConnectionAsync(FileStorageCheckConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageCheckConnectionHeaders headers = new FileStorageCheckConnectionHeaders();
            return await FileStorageCheckConnectionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 专属文件存储获取存储情况(按时间区间)
         *
         * @param request FileStorageGetQuotaDataRequest
         * @param headers FileStorageGetQuotaDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileStorageGetQuotaDataResponse
         */
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

        /**
         * @summary 专属文件存储获取存储情况(按时间区间)
         *
         * @param request FileStorageGetQuotaDataRequest
         * @param headers FileStorageGetQuotaDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileStorageGetQuotaDataResponse
         */
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

        /**
         * @summary 专属文件存储获取存储情况(按时间区间)
         *
         * @param request FileStorageGetQuotaDataRequest
         * @return FileStorageGetQuotaDataResponse
         */
        public FileStorageGetQuotaDataResponse FileStorageGetQuotaData(FileStorageGetQuotaDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageGetQuotaDataHeaders headers = new FileStorageGetQuotaDataHeaders();
            return FileStorageGetQuotaDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 专属文件存储获取存储情况(按时间区间)
         *
         * @param request FileStorageGetQuotaDataRequest
         * @return FileStorageGetQuotaDataResponse
         */
        public async Task<FileStorageGetQuotaDataResponse> FileStorageGetQuotaDataAsync(FileStorageGetQuotaDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageGetQuotaDataHeaders headers = new FileStorageGetQuotaDataHeaders();
            return await FileStorageGetQuotaDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 专属文件存储获取存储情况和配置
         *
         * @param request FileStorageGetStorageStateRequest
         * @param headers FileStorageGetStorageStateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileStorageGetStorageStateResponse
         */
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

        /**
         * @summary 专属文件存储获取存储情况和配置
         *
         * @param request FileStorageGetStorageStateRequest
         * @param headers FileStorageGetStorageStateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileStorageGetStorageStateResponse
         */
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

        /**
         * @summary 专属文件存储获取存储情况和配置
         *
         * @param request FileStorageGetStorageStateRequest
         * @return FileStorageGetStorageStateResponse
         */
        public FileStorageGetStorageStateResponse FileStorageGetStorageState(FileStorageGetStorageStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageGetStorageStateHeaders headers = new FileStorageGetStorageStateHeaders();
            return FileStorageGetStorageStateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 专属文件存储获取存储情况和配置
         *
         * @param request FileStorageGetStorageStateRequest
         * @return FileStorageGetStorageStateResponse
         */
        public async Task<FileStorageGetStorageStateResponse> FileStorageGetStorageStateAsync(FileStorageGetStorageStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageGetStorageStateHeaders headers = new FileStorageGetStorageStateHeaders();
            return await FileStorageGetStorageStateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新文件专属存储配置
         *
         * @param request FileStorageUpdateStorageRequest
         * @param headers FileStorageUpdateStorageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileStorageUpdateStorageResponse
         */
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

        /**
         * @summary 更新文件专属存储配置
         *
         * @param request FileStorageUpdateStorageRequest
         * @param headers FileStorageUpdateStorageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileStorageUpdateStorageResponse
         */
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

        /**
         * @summary 更新文件专属存储配置
         *
         * @param request FileStorageUpdateStorageRequest
         * @return FileStorageUpdateStorageResponse
         */
        public FileStorageUpdateStorageResponse FileStorageUpdateStorage(FileStorageUpdateStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageUpdateStorageHeaders headers = new FileStorageUpdateStorageHeaders();
            return FileStorageUpdateStorageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新文件专属存储配置
         *
         * @param request FileStorageUpdateStorageRequest
         * @return FileStorageUpdateStorageResponse
         */
        public async Task<FileStorageUpdateStorageResponse> FileStorageUpdateStorageAsync(FileStorageUpdateStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FileStorageUpdateStorageHeaders headers = new FileStorageUpdateStorageHeaders();
            return await FileStorageUpdateStorageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 生成暗水印
         *
         * @param request GenerateDarkWaterMarkRequest
         * @param headers GenerateDarkWaterMarkHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateDarkWaterMarkResponse
         */
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

        /**
         * @summary 生成暗水印
         *
         * @param request GenerateDarkWaterMarkRequest
         * @param headers GenerateDarkWaterMarkHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateDarkWaterMarkResponse
         */
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

        /**
         * @summary 生成暗水印
         *
         * @param request GenerateDarkWaterMarkRequest
         * @return GenerateDarkWaterMarkResponse
         */
        public GenerateDarkWaterMarkResponse GenerateDarkWaterMark(GenerateDarkWaterMarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateDarkWaterMarkHeaders headers = new GenerateDarkWaterMarkHeaders();
            return GenerateDarkWaterMarkWithOptions(request, headers, runtime);
        }

        /**
         * @summary 生成暗水印
         *
         * @param request GenerateDarkWaterMarkRequest
         * @return GenerateDarkWaterMarkResponse
         */
        public async Task<GenerateDarkWaterMarkResponse> GenerateDarkWaterMarkAsync(GenerateDarkWaterMarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateDarkWaterMarkHeaders headers = new GenerateDarkWaterMarkHeaders();
            return await GenerateDarkWaterMarkWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取专属钉钉账号数据迁移结果
         *
         * @param request GetAccountTransferListRequest
         * @param headers GetAccountTransferListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAccountTransferListResponse
         */
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

        /**
         * @summary 获取专属钉钉账号数据迁移结果
         *
         * @param request GetAccountTransferListRequest
         * @param headers GetAccountTransferListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAccountTransferListResponse
         */
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

        /**
         * @summary 获取专属钉钉账号数据迁移结果
         *
         * @param request GetAccountTransferListRequest
         * @return GetAccountTransferListResponse
         */
        public GetAccountTransferListResponse GetAccountTransferList(GetAccountTransferListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAccountTransferListHeaders headers = new GetAccountTransferListHeaders();
            return GetAccountTransferListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取专属钉钉账号数据迁移结果
         *
         * @param request GetAccountTransferListRequest
         * @return GetAccountTransferListResponse
         */
        public async Task<GetAccountTransferListResponse> GetAccountTransferListAsync(GetAccountTransferListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAccountTransferListHeaders headers = new GetAccountTransferListHeaders();
            return await GetAccountTransferListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获得组织维度的用户dau
         *
         * @param headers GetActiveUserSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetActiveUserSummaryResponse
         */
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

        /**
         * @summary 获得组织维度的用户dau
         *
         * @param headers GetActiveUserSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetActiveUserSummaryResponse
         */
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

        /**
         * @summary 获得组织维度的用户dau
         *
         * @return GetActiveUserSummaryResponse
         */
        public GetActiveUserSummaryResponse GetActiveUserSummary(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetActiveUserSummaryHeaders headers = new GetActiveUserSummaryHeaders();
            return GetActiveUserSummaryWithOptions(dataId, headers, runtime);
        }

        /**
         * @summary 获得组织维度的用户dau
         *
         * @return GetActiveUserSummaryResponse
         */
        public async Task<GetActiveUserSummaryResponse> GetActiveUserSummaryAsync(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetActiveUserSummaryHeaders headers = new GetActiveUserSummaryHeaders();
            return await GetActiveUserSummaryWithOptionsAsync(dataId, headers, runtime);
        }

        /**
         * @summary 根据AppId获取微应用在该组织下的agentId
         *
         * @param request GetAgentIdByRelatedAppIdRequest
         * @param headers GetAgentIdByRelatedAppIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAgentIdByRelatedAppIdResponse
         */
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

        /**
         * @summary 根据AppId获取微应用在该组织下的agentId
         *
         * @param request GetAgentIdByRelatedAppIdRequest
         * @param headers GetAgentIdByRelatedAppIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAgentIdByRelatedAppIdResponse
         */
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

        /**
         * @summary 根据AppId获取微应用在该组织下的agentId
         *
         * @param request GetAgentIdByRelatedAppIdRequest
         * @return GetAgentIdByRelatedAppIdResponse
         */
        public GetAgentIdByRelatedAppIdResponse GetAgentIdByRelatedAppId(GetAgentIdByRelatedAppIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAgentIdByRelatedAppIdHeaders headers = new GetAgentIdByRelatedAppIdHeaders();
            return GetAgentIdByRelatedAppIdWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据AppId获取微应用在该组织下的agentId
         *
         * @param request GetAgentIdByRelatedAppIdRequest
         * @return GetAgentIdByRelatedAppIdResponse
         */
        public async Task<GetAgentIdByRelatedAppIdResponse> GetAgentIdByRelatedAppIdAsync(GetAgentIdByRelatedAppIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAgentIdByRelatedAppIdHeaders headers = new GetAgentIdByRelatedAppIdHeaders();
            return await GetAgentIdByRelatedAppIdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 伙伴钉可打标签部门查询
         *
         * @param headers GetAllLabelableDeptsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAllLabelableDeptsResponse
         */
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

        /**
         * @summary 伙伴钉可打标签部门查询
         *
         * @param headers GetAllLabelableDeptsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAllLabelableDeptsResponse
         */
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

        /**
         * @summary 伙伴钉可打标签部门查询
         *
         * @return GetAllLabelableDeptsResponse
         */
        public GetAllLabelableDeptsResponse GetAllLabelableDepts()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllLabelableDeptsHeaders headers = new GetAllLabelableDeptsHeaders();
            return GetAllLabelableDeptsWithOptions(headers, runtime);
        }

        /**
         * @summary 伙伴钉可打标签部门查询
         *
         * @return GetAllLabelableDeptsResponse
         */
        public async Task<GetAllLabelableDeptsResponse> GetAllLabelableDeptsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllLabelableDeptsHeaders headers = new GetAllLabelableDeptsHeaders();
            return await GetAllLabelableDeptsWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 获得app分发信息
         *
         * @param request GetAppDispatchInfoRequest
         * @param headers GetAppDispatchInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppDispatchInfoResponse
         */
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

        /**
         * @summary 获得app分发信息
         *
         * @param request GetAppDispatchInfoRequest
         * @param headers GetAppDispatchInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppDispatchInfoResponse
         */
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

        /**
         * @summary 获得app分发信息
         *
         * @param request GetAppDispatchInfoRequest
         * @return GetAppDispatchInfoResponse
         */
        public GetAppDispatchInfoResponse GetAppDispatchInfo(GetAppDispatchInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAppDispatchInfoHeaders headers = new GetAppDispatchInfoHeaders();
            return GetAppDispatchInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获得app分发信息
         *
         * @param request GetAppDispatchInfoRequest
         * @return GetAppDispatchInfoResponse
         */
        public async Task<GetAppDispatchInfoResponse> GetAppDispatchInfoAsync(GetAppDispatchInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAppDispatchInfoHeaders headers = new GetAppDispatchInfoHeaders();
            return await GetAppDispatchInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获得组织维度日程相关信息
         *
         * @param headers GetCalenderSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCalenderSummaryResponse
         */
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

        /**
         * @summary 获得组织维度日程相关信息
         *
         * @param headers GetCalenderSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCalenderSummaryResponse
         */
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

        /**
         * @summary 获得组织维度日程相关信息
         *
         * @return GetCalenderSummaryResponse
         */
        public GetCalenderSummaryResponse GetCalenderSummary(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCalenderSummaryHeaders headers = new GetCalenderSummaryHeaders();
            return GetCalenderSummaryWithOptions(dataId, headers, runtime);
        }

        /**
         * @summary 获得组织维度日程相关信息
         *
         * @return GetCalenderSummaryResponse
         */
        public async Task<GetCalenderSummaryResponse> GetCalenderSummaryAsync(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCalenderSummaryHeaders headers = new GetCalenderSummaryHeaders();
            return await GetCalenderSummaryWithOptionsAsync(dataId, headers, runtime);
        }

        /**
         * @summary 获取发布号的评论列表
         *
         * @param request GetCommentListRequest
         * @param headers GetCommentListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCommentListResponse
         */
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

        /**
         * @summary 获取发布号的评论列表
         *
         * @param request GetCommentListRequest
         * @param headers GetCommentListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCommentListResponse
         */
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

        /**
         * @summary 获取发布号的评论列表
         *
         * @param request GetCommentListRequest
         * @return GetCommentListResponse
         */
        public GetCommentListResponse GetCommentList(string publisherId, GetCommentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCommentListHeaders headers = new GetCommentListHeaders();
            return GetCommentListWithOptions(publisherId, request, headers, runtime);
        }

        /**
         * @summary 获取发布号的评论列表
         *
         * @param request GetCommentListRequest
         * @return GetCommentListResponse
         */
        public async Task<GetCommentListResponse> GetCommentListAsync(string publisherId, GetCommentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCommentListHeaders headers = new GetCommentListHeaders();
            return await GetCommentListWithOptionsAsync(publisherId, request, headers, runtime);
        }

        /**
         * @summary 根据逻辑会议id获取会议基本信息
         *
         * @param request GetConfBaseInfoByLogicalIdRequest
         * @param headers GetConfBaseInfoByLogicalIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConfBaseInfoByLogicalIdResponse
         */
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

        /**
         * @summary 根据逻辑会议id获取会议基本信息
         *
         * @param request GetConfBaseInfoByLogicalIdRequest
         * @param headers GetConfBaseInfoByLogicalIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConfBaseInfoByLogicalIdResponse
         */
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

        /**
         * @summary 根据逻辑会议id获取会议基本信息
         *
         * @param request GetConfBaseInfoByLogicalIdRequest
         * @return GetConfBaseInfoByLogicalIdResponse
         */
        public GetConfBaseInfoByLogicalIdResponse GetConfBaseInfoByLogicalId(GetConfBaseInfoByLogicalIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConfBaseInfoByLogicalIdHeaders headers = new GetConfBaseInfoByLogicalIdHeaders();
            return GetConfBaseInfoByLogicalIdWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据逻辑会议id获取会议基本信息
         *
         * @param request GetConfBaseInfoByLogicalIdRequest
         * @return GetConfBaseInfoByLogicalIdResponse
         */
        public async Task<GetConfBaseInfoByLogicalIdResponse> GetConfBaseInfoByLogicalIdAsync(GetConfBaseInfoByLogicalIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConfBaseInfoByLogicalIdHeaders headers = new GetConfBaseInfoByLogicalIdHeaders();
            return await GetConfBaseInfoByLogicalIdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取视频会议明细
         *
         * @param headers GetConferenceDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConferenceDetailResponse
         */
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

        /**
         * @summary 获取视频会议明细
         *
         * @param headers GetConferenceDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConferenceDetailResponse
         */
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

        /**
         * @summary 获取视频会议明细
         *
         * @return GetConferenceDetailResponse
         */
        public GetConferenceDetailResponse GetConferenceDetail(string conferenceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConferenceDetailHeaders headers = new GetConferenceDetailHeaders();
            return GetConferenceDetailWithOptions(conferenceId, headers, runtime);
        }

        /**
         * @summary 获取视频会议明细
         *
         * @return GetConferenceDetailResponse
         */
        public async Task<GetConferenceDetailResponse> GetConferenceDetailAsync(string conferenceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConferenceDetailHeaders headers = new GetConferenceDetailHeaders();
            return await GetConferenceDetailWithOptionsAsync(conferenceId, headers, runtime);
        }

        /**
         * @summary 获取会话分组数据
         *
         * @param headers GetConversationCategoryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConversationCategoryResponse
         */
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

        /**
         * @summary 获取会话分组数据
         *
         * @param headers GetConversationCategoryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConversationCategoryResponse
         */
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

        /**
         * @summary 获取会话分组数据
         *
         * @return GetConversationCategoryResponse
         */
        public GetConversationCategoryResponse GetConversationCategory()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationCategoryHeaders headers = new GetConversationCategoryHeaders();
            return GetConversationCategoryWithOptions(headers, runtime);
        }

        /**
         * @summary 获取会话分组数据
         *
         * @return GetConversationCategoryResponse
         */
        public async Task<GetConversationCategoryResponse> GetConversationCategoryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationCategoryHeaders headers = new GetConversationCategoryHeaders();
            return await GetConversationCategoryWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 获取部门维度发布日志信息
         *
         * @param request GetDingReportDeptSummaryRequest
         * @param headers GetDingReportDeptSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDingReportDeptSummaryResponse
         */
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

        /**
         * @summary 获取部门维度发布日志信息
         *
         * @param request GetDingReportDeptSummaryRequest
         * @param headers GetDingReportDeptSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDingReportDeptSummaryResponse
         */
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

        /**
         * @summary 获取部门维度发布日志信息
         *
         * @param request GetDingReportDeptSummaryRequest
         * @return GetDingReportDeptSummaryResponse
         */
        public GetDingReportDeptSummaryResponse GetDingReportDeptSummary(string dataId, GetDingReportDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingReportDeptSummaryHeaders headers = new GetDingReportDeptSummaryHeaders();
            return GetDingReportDeptSummaryWithOptions(dataId, request, headers, runtime);
        }

        /**
         * @summary 获取部门维度发布日志信息
         *
         * @param request GetDingReportDeptSummaryRequest
         * @return GetDingReportDeptSummaryResponse
         */
        public async Task<GetDingReportDeptSummaryResponse> GetDingReportDeptSummaryAsync(string dataId, GetDingReportDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingReportDeptSummaryHeaders headers = new GetDingReportDeptSummaryHeaders();
            return await GetDingReportDeptSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        /**
         * @summary 获取组织维度发布日志信息
         *
         * @param headers GetDingReportSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDingReportSummaryResponse
         */
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

        /**
         * @summary 获取组织维度发布日志信息
         *
         * @param headers GetDingReportSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDingReportSummaryResponse
         */
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

        /**
         * @summary 获取组织维度发布日志信息
         *
         * @return GetDingReportSummaryResponse
         */
        public GetDingReportSummaryResponse GetDingReportSummary(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingReportSummaryHeaders headers = new GetDingReportSummaryHeaders();
            return GetDingReportSummaryWithOptions(dataId, headers, runtime);
        }

        /**
         * @summary 获取组织维度发布日志信息
         *
         * @return GetDingReportSummaryResponse
         */
        public async Task<GetDingReportSummaryResponse> GetDingReportSummaryAsync(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingReportSummaryHeaders headers = new GetDingReportSummaryHeaders();
            return await GetDingReportSummaryWithOptionsAsync(dataId, headers, runtime);
        }

        /**
         * @summary 获得部门维度用户创建文档数和创建文档人数
         *
         * @param request GetDocCreatedDeptSummaryRequest
         * @param headers GetDocCreatedDeptSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocCreatedDeptSummaryResponse
         */
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

        /**
         * @summary 获得部门维度用户创建文档数和创建文档人数
         *
         * @param request GetDocCreatedDeptSummaryRequest
         * @param headers GetDocCreatedDeptSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocCreatedDeptSummaryResponse
         */
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

        /**
         * @summary 获得部门维度用户创建文档数和创建文档人数
         *
         * @param request GetDocCreatedDeptSummaryRequest
         * @return GetDocCreatedDeptSummaryResponse
         */
        public GetDocCreatedDeptSummaryResponse GetDocCreatedDeptSummary(string dataId, GetDocCreatedDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocCreatedDeptSummaryHeaders headers = new GetDocCreatedDeptSummaryHeaders();
            return GetDocCreatedDeptSummaryWithOptions(dataId, request, headers, runtime);
        }

        /**
         * @summary 获得部门维度用户创建文档数和创建文档人数
         *
         * @param request GetDocCreatedDeptSummaryRequest
         * @return GetDocCreatedDeptSummaryResponse
         */
        public async Task<GetDocCreatedDeptSummaryResponse> GetDocCreatedDeptSummaryAsync(string dataId, GetDocCreatedDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocCreatedDeptSummaryHeaders headers = new GetDocCreatedDeptSummaryHeaders();
            return await GetDocCreatedDeptSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        /**
         * @summary 获取组织维度用户创建文档数和创建文档人数
         *
         * @param headers GetDocCreatedSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocCreatedSummaryResponse
         */
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

        /**
         * @summary 获取组织维度用户创建文档数和创建文档人数
         *
         * @param headers GetDocCreatedSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocCreatedSummaryResponse
         */
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

        /**
         * @summary 获取组织维度用户创建文档数和创建文档人数
         *
         * @return GetDocCreatedSummaryResponse
         */
        public GetDocCreatedSummaryResponse GetDocCreatedSummary(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocCreatedSummaryHeaders headers = new GetDocCreatedSummaryHeaders();
            return GetDocCreatedSummaryWithOptions(dataId, headers, runtime);
        }

        /**
         * @summary 获取组织维度用户创建文档数和创建文档人数
         *
         * @return GetDocCreatedSummaryResponse
         */
        public async Task<GetDocCreatedSummaryResponse> GetDocCreatedSummaryAsync(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDocCreatedSummaryHeaders headers = new GetDocCreatedSummaryHeaders();
            return await GetDocCreatedSummaryWithOptionsAsync(dataId, headers, runtime);
        }

        /**
         * @summary 获取专属账号所有组织列表
         *
         * @param request GetExclusiveAccountAllOrgListRequest
         * @param headers GetExclusiveAccountAllOrgListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetExclusiveAccountAllOrgListResponse
         */
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

        /**
         * @summary 获取专属账号所有组织列表
         *
         * @param request GetExclusiveAccountAllOrgListRequest
         * @param headers GetExclusiveAccountAllOrgListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetExclusiveAccountAllOrgListResponse
         */
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

        /**
         * @summary 获取专属账号所有组织列表
         *
         * @param request GetExclusiveAccountAllOrgListRequest
         * @return GetExclusiveAccountAllOrgListResponse
         */
        public GetExclusiveAccountAllOrgListResponse GetExclusiveAccountAllOrgList(GetExclusiveAccountAllOrgListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetExclusiveAccountAllOrgListHeaders headers = new GetExclusiveAccountAllOrgListHeaders();
            return GetExclusiveAccountAllOrgListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取专属账号所有组织列表
         *
         * @param request GetExclusiveAccountAllOrgListRequest
         * @return GetExclusiveAccountAllOrgListResponse
         */
        public async Task<GetExclusiveAccountAllOrgListResponse> GetExclusiveAccountAllOrgListAsync(GetExclusiveAccountAllOrgListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetExclusiveAccountAllOrgListHeaders headers = new GetExclusiveAccountAllOrgListHeaders();
            return await GetExclusiveAccountAllOrgListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取部门维度发布智能填表数量和使用智能填表人数
         *
         * @param request GetGeneralFormCreatedDeptSummaryRequest
         * @param headers GetGeneralFormCreatedDeptSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGeneralFormCreatedDeptSummaryResponse
         */
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

        /**
         * @summary 获取部门维度发布智能填表数量和使用智能填表人数
         *
         * @param request GetGeneralFormCreatedDeptSummaryRequest
         * @param headers GetGeneralFormCreatedDeptSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGeneralFormCreatedDeptSummaryResponse
         */
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

        /**
         * @summary 获取部门维度发布智能填表数量和使用智能填表人数
         *
         * @param request GetGeneralFormCreatedDeptSummaryRequest
         * @return GetGeneralFormCreatedDeptSummaryResponse
         */
        public GetGeneralFormCreatedDeptSummaryResponse GetGeneralFormCreatedDeptSummary(string dataId, GetGeneralFormCreatedDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGeneralFormCreatedDeptSummaryHeaders headers = new GetGeneralFormCreatedDeptSummaryHeaders();
            return GetGeneralFormCreatedDeptSummaryWithOptions(dataId, request, headers, runtime);
        }

        /**
         * @summary 获取部门维度发布智能填表数量和使用智能填表人数
         *
         * @param request GetGeneralFormCreatedDeptSummaryRequest
         * @return GetGeneralFormCreatedDeptSummaryResponse
         */
        public async Task<GetGeneralFormCreatedDeptSummaryResponse> GetGeneralFormCreatedDeptSummaryAsync(string dataId, GetGeneralFormCreatedDeptSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGeneralFormCreatedDeptSummaryHeaders headers = new GetGeneralFormCreatedDeptSummaryHeaders();
            return await GetGeneralFormCreatedDeptSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        /**
         * @summary 获取组织维度发布智能填表数量和使用智能填表人数
         *
         * @param headers GetGeneralFormCreatedSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGeneralFormCreatedSummaryResponse
         */
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

        /**
         * @summary 获取组织维度发布智能填表数量和使用智能填表人数
         *
         * @param headers GetGeneralFormCreatedSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGeneralFormCreatedSummaryResponse
         */
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

        /**
         * @summary 获取组织维度发布智能填表数量和使用智能填表人数
         *
         * @return GetGeneralFormCreatedSummaryResponse
         */
        public GetGeneralFormCreatedSummaryResponse GetGeneralFormCreatedSummary(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGeneralFormCreatedSummaryHeaders headers = new GetGeneralFormCreatedSummaryHeaders();
            return GetGeneralFormCreatedSummaryWithOptions(dataId, headers, runtime);
        }

        /**
         * @summary 获取组织维度发布智能填表数量和使用智能填表人数
         *
         * @return GetGeneralFormCreatedSummaryResponse
         */
        public async Task<GetGeneralFormCreatedSummaryResponse> GetGeneralFormCreatedSummaryAsync(string dataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGeneralFormCreatedSummaryHeaders headers = new GetGeneralFormCreatedSummaryHeaders();
            return await GetGeneralFormCreatedSummaryWithOptionsAsync(dataId, headers, runtime);
        }

        /**
         * @summary 获取群活跃明细
         *
         * @param request GetGroupActiveInfoRequest
         * @param headers GetGroupActiveInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGroupActiveInfoResponse
         */
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

        /**
         * @summary 获取群活跃明细
         *
         * @param request GetGroupActiveInfoRequest
         * @param headers GetGroupActiveInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGroupActiveInfoResponse
         */
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

        /**
         * @summary 获取群活跃明细
         *
         * @param request GetGroupActiveInfoRequest
         * @return GetGroupActiveInfoResponse
         */
        public GetGroupActiveInfoResponse GetGroupActiveInfo(GetGroupActiveInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGroupActiveInfoHeaders headers = new GetGroupActiveInfoHeaders();
            return GetGroupActiveInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取群活跃明细
         *
         * @param request GetGroupActiveInfoRequest
         * @return GetGroupActiveInfoResponse
         */
        public async Task<GetGroupActiveInfoResponse> GetGroupActiveInfoAsync(GetGroupActiveInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGroupActiveInfoHeaders headers = new GetGroupActiveInfoHeaders();
            return await GetGroupActiveInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取未活跃用户登陆统计明细
         *
         * @param request GetInActiveUserListRequest
         * @param headers GetInActiveUserListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInActiveUserListResponse
         */
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

        /**
         * @summary 获取未活跃用户登陆统计明细
         *
         * @param request GetInActiveUserListRequest
         * @param headers GetInActiveUserListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInActiveUserListResponse
         */
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

        /**
         * @summary 获取未活跃用户登陆统计明细
         *
         * @param request GetInActiveUserListRequest
         * @return GetInActiveUserListResponse
         */
        public GetInActiveUserListResponse GetInActiveUserList(GetInActiveUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInActiveUserListHeaders headers = new GetInActiveUserListHeaders();
            return GetInActiveUserListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取未活跃用户登陆统计明细
         *
         * @param request GetInActiveUserListRequest
         * @return GetInActiveUserListResponse
         */
        public async Task<GetInActiveUserListResponse> GetInActiveUserListAsync(GetInActiveUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInActiveUserListHeaders headers = new GetInActiveUserListHeaders();
            return await GetInActiveUserListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取最后一次验证通过的企业认证信息
         *
         * @param request GetLastOrgAuthDataRequest
         * @param headers GetLastOrgAuthDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLastOrgAuthDataResponse
         */
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

        /**
         * @summary 获取最后一次验证通过的企业认证信息
         *
         * @param request GetLastOrgAuthDataRequest
         * @param headers GetLastOrgAuthDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLastOrgAuthDataResponse
         */
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

        /**
         * @summary 获取最后一次验证通过的企业认证信息
         *
         * @param request GetLastOrgAuthDataRequest
         * @return GetLastOrgAuthDataResponse
         */
        public GetLastOrgAuthDataResponse GetLastOrgAuthData(GetLastOrgAuthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLastOrgAuthDataHeaders headers = new GetLastOrgAuthDataHeaders();
            return GetLastOrgAuthDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取最后一次验证通过的企业认证信息
         *
         * @param request GetLastOrgAuthDataRequest
         * @return GetLastOrgAuthDataResponse
         */
        public async Task<GetLastOrgAuthDataResponse> GetLastOrgAuthDataAsync(GetLastOrgAuthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLastOrgAuthDataHeaders headers = new GetLastOrgAuthDataHeaders();
            return await GetLastOrgAuthDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 消息规则配置和群属性接口
         *
         * @param request GetMsgConfigRequest
         * @param headers GetMsgConfigHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMsgConfigResponse
         */
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

        /**
         * @summary 消息规则配置和群属性接口
         *
         * @param request GetMsgConfigRequest
         * @param headers GetMsgConfigHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMsgConfigResponse
         */
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

        /**
         * @summary 消息规则配置和群属性接口
         *
         * @param request GetMsgConfigRequest
         * @return GetMsgConfigResponse
         */
        public GetMsgConfigResponse GetMsgConfig(GetMsgConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMsgConfigHeaders headers = new GetMsgConfigHeaders();
            return GetMsgConfigWithOptions(request, headers, runtime);
        }

        /**
         * @summary 消息规则配置和群属性接口
         *
         * @param request GetMsgConfigRequest
         * @return GetMsgConfigResponse
         */
        public async Task<GetMsgConfigResponse> GetMsgConfigAsync(GetMsgConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMsgConfigHeaders headers = new GetMsgConfigHeaders();
            return await GetMsgConfigWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取消息定位链接
         *
         * @param request GetMsgLocationRequest
         * @param headers GetMsgLocationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMsgLocationResponse
         */
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

        /**
         * @summary 获取消息定位链接
         *
         * @param request GetMsgLocationRequest
         * @param headers GetMsgLocationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMsgLocationResponse
         */
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

        /**
         * @summary 获取消息定位链接
         *
         * @param request GetMsgLocationRequest
         * @return GetMsgLocationResponse
         */
        public GetMsgLocationResponse GetMsgLocation(GetMsgLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMsgLocationHeaders headers = new GetMsgLocationHeaders();
            return GetMsgLocationWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取消息定位链接
         *
         * @param request GetMsgLocationRequest
         * @return GetMsgLocationResponse
         */
        public async Task<GetMsgLocationResponse> GetMsgLocationAsync(GetMsgLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMsgLocationHeaders headers = new GetMsgLocationHeaders();
            return await GetMsgLocationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取oa后台操作日志记录
         *
         * @param request GetOaOperatorLogListRequest
         * @param headers GetOaOperatorLogListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOaOperatorLogListResponse
         */
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

        /**
         * @summary 获取oa后台操作日志记录
         *
         * @param request GetOaOperatorLogListRequest
         * @param headers GetOaOperatorLogListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOaOperatorLogListResponse
         */
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

        /**
         * @summary 获取oa后台操作日志记录
         *
         * @param request GetOaOperatorLogListRequest
         * @return GetOaOperatorLogListResponse
         */
        public GetOaOperatorLogListResponse GetOaOperatorLogList(GetOaOperatorLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOaOperatorLogListHeaders headers = new GetOaOperatorLogListHeaders();
            return GetOaOperatorLogListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取oa后台操作日志记录
         *
         * @param request GetOaOperatorLogListRequest
         * @return GetOaOperatorLogListResponse
         */
        public async Task<GetOaOperatorLogListResponse> GetOaOperatorLogListAsync(GetOaOperatorLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOaOperatorLogListHeaders headers = new GetOaOperatorLogListHeaders();
            return await GetOaOperatorLogListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业的外部审计群列表
         *
         * @param request GetOutGroupsByPageRequest
         * @param headers GetOutGroupsByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOutGroupsByPageResponse
         */
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

        /**
         * @summary 获取企业的外部审计群列表
         *
         * @param request GetOutGroupsByPageRequest
         * @param headers GetOutGroupsByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOutGroupsByPageResponse
         */
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

        /**
         * @summary 获取企业的外部审计群列表
         *
         * @param request GetOutGroupsByPageRequest
         * @return GetOutGroupsByPageResponse
         */
        public GetOutGroupsByPageResponse GetOutGroupsByPage(GetOutGroupsByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOutGroupsByPageHeaders headers = new GetOutGroupsByPageHeaders();
            return GetOutGroupsByPageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业的外部审计群列表
         *
         * @param request GetOutGroupsByPageRequest
         * @return GetOutGroupsByPageResponse
         */
        public async Task<GetOutGroupsByPageResponse> GetOutGroupsByPageAsync(GetOutGroupsByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOutGroupsByPageHeaders headers = new GetOutGroupsByPageHeaders();
            return await GetOutGroupsByPageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取外部审计群消息记录
         *
         * @param request GetOutsideAuditGroupMessageByPageRequest
         * @param headers GetOutsideAuditGroupMessageByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOutsideAuditGroupMessageByPageResponse
         */
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

        /**
         * @summary 获取外部审计群消息记录
         *
         * @param request GetOutsideAuditGroupMessageByPageRequest
         * @param headers GetOutsideAuditGroupMessageByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOutsideAuditGroupMessageByPageResponse
         */
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

        /**
         * @summary 获取外部审计群消息记录
         *
         * @param request GetOutsideAuditGroupMessageByPageRequest
         * @return GetOutsideAuditGroupMessageByPageResponse
         */
        public GetOutsideAuditGroupMessageByPageResponse GetOutsideAuditGroupMessageByPage(GetOutsideAuditGroupMessageByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOutsideAuditGroupMessageByPageHeaders headers = new GetOutsideAuditGroupMessageByPageHeaders();
            return GetOutsideAuditGroupMessageByPageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取外部审计群消息记录
         *
         * @param request GetOutsideAuditGroupMessageByPageRequest
         * @return GetOutsideAuditGroupMessageByPageResponse
         */
        public async Task<GetOutsideAuditGroupMessageByPageResponse> GetOutsideAuditGroupMessageByPageAsync(GetOutsideAuditGroupMessageByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOutsideAuditGroupMessageByPageHeaders headers = new GetOutsideAuditGroupMessageByPageHeaders();
            return await GetOutsideAuditGroupMessageByPageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 伙伴钉根据父标签查询子标签
         *
         * @param headers GetPartnerTypeByParentIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPartnerTypeByParentIdResponse
         */
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

        /**
         * @summary 伙伴钉根据父标签查询子标签
         *
         * @param headers GetPartnerTypeByParentIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPartnerTypeByParentIdResponse
         */
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

        /**
         * @summary 伙伴钉根据父标签查询子标签
         *
         * @return GetPartnerTypeByParentIdResponse
         */
        public GetPartnerTypeByParentIdResponse GetPartnerTypeByParentId(string parentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPartnerTypeByParentIdHeaders headers = new GetPartnerTypeByParentIdHeaders();
            return GetPartnerTypeByParentIdWithOptions(parentId, headers, runtime);
        }

        /**
         * @summary 伙伴钉根据父标签查询子标签
         *
         * @return GetPartnerTypeByParentIdResponse
         */
        public async Task<GetPartnerTypeByParentIdResponse> GetPartnerTypeByParentIdAsync(string parentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPartnerTypeByParentIdHeaders headers = new GetPartnerTypeByParentIdHeaders();
            return await GetPartnerTypeByParentIdWithOptionsAsync(parentId, headers, runtime);
        }

        /**
         * @summary 获取公共设备列表。
         *
         * @param request GetPublicDevicesRequest
         * @param headers GetPublicDevicesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPublicDevicesResponse
         */
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

        /**
         * @summary 获取公共设备列表。
         *
         * @param request GetPublicDevicesRequest
         * @param headers GetPublicDevicesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPublicDevicesResponse
         */
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

        /**
         * @summary 获取公共设备列表。
         *
         * @param request GetPublicDevicesRequest
         * @return GetPublicDevicesResponse
         */
        public GetPublicDevicesResponse GetPublicDevices(GetPublicDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPublicDevicesHeaders headers = new GetPublicDevicesHeaders();
            return GetPublicDevicesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取公共设备列表。
         *
         * @param request GetPublicDevicesRequest
         * @return GetPublicDevicesResponse
         */
        public async Task<GetPublicDevicesResponse> GetPublicDevicesAsync(GetPublicDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPublicDevicesHeaders headers = new GetPublicDevicesHeaders();
            return await GetPublicDevicesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取互动服务窗相关数据
         *
         * @param request GetPublisherSummaryRequest
         * @param headers GetPublisherSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPublisherSummaryResponse
         */
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

        /**
         * @summary 获取互动服务窗相关数据
         *
         * @param request GetPublisherSummaryRequest
         * @param headers GetPublisherSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPublisherSummaryResponse
         */
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

        /**
         * @summary 获取互动服务窗相关数据
         *
         * @param request GetPublisherSummaryRequest
         * @return GetPublisherSummaryResponse
         */
        public GetPublisherSummaryResponse GetPublisherSummary(string dataId, GetPublisherSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPublisherSummaryHeaders headers = new GetPublisherSummaryHeaders();
            return GetPublisherSummaryWithOptions(dataId, request, headers, runtime);
        }

        /**
         * @summary 获取互动服务窗相关数据
         *
         * @param request GetPublisherSummaryRequest
         * @return GetPublisherSummaryResponse
         */
        public async Task<GetPublisherSummaryResponse> GetPublisherSummaryAsync(string dataId, GetPublisherSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPublisherSummaryHeaders headers = new GetPublisherSummaryHeaders();
            return await GetPublisherSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        /**
         * @summary 获取实人认证接口调用记录
         *
         * @param request GetRealPeopleRecordsRequest
         * @param headers GetRealPeopleRecordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRealPeopleRecordsResponse
         */
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

        /**
         * @summary 获取实人认证接口调用记录
         *
         * @param request GetRealPeopleRecordsRequest
         * @param headers GetRealPeopleRecordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRealPeopleRecordsResponse
         */
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

        /**
         * @summary 获取实人认证接口调用记录
         *
         * @param request GetRealPeopleRecordsRequest
         * @return GetRealPeopleRecordsResponse
         */
        public GetRealPeopleRecordsResponse GetRealPeopleRecords(GetRealPeopleRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRealPeopleRecordsHeaders headers = new GetRealPeopleRecordsHeaders();
            return GetRealPeopleRecordsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取实人认证接口调用记录
         *
         * @param request GetRealPeopleRecordsRequest
         * @return GetRealPeopleRecordsResponse
         */
        public async Task<GetRealPeopleRecordsResponse> GetRealPeopleRecordsAsync(GetRealPeopleRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRealPeopleRecordsHeaders headers = new GetRealPeopleRecordsHeaders();
            return await GetRealPeopleRecordsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取人脸对比接口调用记录
         *
         * @param request GetRecognizeRecordsRequest
         * @param headers GetRecognizeRecordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRecognizeRecordsResponse
         */
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

        /**
         * @summary 获取人脸对比接口调用记录
         *
         * @param request GetRecognizeRecordsRequest
         * @param headers GetRecognizeRecordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRecognizeRecordsResponse
         */
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

        /**
         * @summary 获取人脸对比接口调用记录
         *
         * @param request GetRecognizeRecordsRequest
         * @return GetRecognizeRecordsResponse
         */
        public GetRecognizeRecordsResponse GetRecognizeRecords(GetRecognizeRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecognizeRecordsHeaders headers = new GetRecognizeRecordsHeaders();
            return GetRecognizeRecordsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取人脸对比接口调用记录
         *
         * @param request GetRecognizeRecordsRequest
         * @return GetRecognizeRecordsResponse
         */
        public async Task<GetRecognizeRecordsResponse> GetRecognizeRecordsAsync(GetRecognizeRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecognizeRecordsHeaders headers = new GetRecognizeRecordsHeaders();
            return await GetRecognizeRecordsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取审计协议签署人员信息
         *
         * @param request GetSignedDetailByPageRequest
         * @param headers GetSignedDetailByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSignedDetailByPageResponse
         */
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

        /**
         * @summary 获取审计协议签署人员信息
         *
         * @param request GetSignedDetailByPageRequest
         * @param headers GetSignedDetailByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSignedDetailByPageResponse
         */
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

        /**
         * @summary 获取审计协议签署人员信息
         *
         * @param request GetSignedDetailByPageRequest
         * @return GetSignedDetailByPageResponse
         */
        public GetSignedDetailByPageResponse GetSignedDetailByPage(GetSignedDetailByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignedDetailByPageHeaders headers = new GetSignedDetailByPageHeaders();
            return GetSignedDetailByPageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取审计协议签署人员信息
         *
         * @param request GetSignedDetailByPageRequest
         * @return GetSignedDetailByPageResponse
         */
        public async Task<GetSignedDetailByPageResponse> GetSignedDetailByPageAsync(GetSignedDetailByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignedDetailByPageHeaders headers = new GetSignedDetailByPageHeaders();
            return await GetSignedDetailByPageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取多个可信设备信息，包括mac地址、staffId、platform
         *
         * @param request GetTrustDeviceListRequest
         * @param headers GetTrustDeviceListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTrustDeviceListResponse
         */
        public GetTrustDeviceListResponse GetTrustDeviceListWithOptions(GetTrustDeviceListRequest request, GetTrustDeviceListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary 获取多个可信设备信息，包括mac地址、staffId、platform
         *
         * @param request GetTrustDeviceListRequest
         * @param headers GetTrustDeviceListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTrustDeviceListResponse
         */
        public async Task<GetTrustDeviceListResponse> GetTrustDeviceListWithOptionsAsync(GetTrustDeviceListRequest request, GetTrustDeviceListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary 获取多个可信设备信息，包括mac地址、staffId、platform
         *
         * @param request GetTrustDeviceListRequest
         * @return GetTrustDeviceListResponse
         */
        public GetTrustDeviceListResponse GetTrustDeviceList(GetTrustDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTrustDeviceListHeaders headers = new GetTrustDeviceListHeaders();
            return GetTrustDeviceListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取多个可信设备信息，包括mac地址、staffId、platform
         *
         * @param request GetTrustDeviceListRequest
         * @return GetTrustDeviceListResponse
         */
        public async Task<GetTrustDeviceListResponse> GetTrustDeviceListAsync(GetTrustDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTrustDeviceListHeaders headers = new GetTrustDeviceListHeaders();
            return await GetTrustDeviceListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获得组织维度用户版本分布情况
         *
         * @param request GetUserAppVersionSummaryRequest
         * @param headers GetUserAppVersionSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserAppVersionSummaryResponse
         */
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

        /**
         * @summary 获得组织维度用户版本分布情况
         *
         * @param request GetUserAppVersionSummaryRequest
         * @param headers GetUserAppVersionSummaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserAppVersionSummaryResponse
         */
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

        /**
         * @summary 获得组织维度用户版本分布情况
         *
         * @param request GetUserAppVersionSummaryRequest
         * @return GetUserAppVersionSummaryResponse
         */
        public GetUserAppVersionSummaryResponse GetUserAppVersionSummary(string dataId, GetUserAppVersionSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserAppVersionSummaryHeaders headers = new GetUserAppVersionSummaryHeaders();
            return GetUserAppVersionSummaryWithOptions(dataId, request, headers, runtime);
        }

        /**
         * @summary 获得组织维度用户版本分布情况
         *
         * @param request GetUserAppVersionSummaryRequest
         * @return GetUserAppVersionSummaryResponse
         */
        public async Task<GetUserAppVersionSummaryResponse> GetUserAppVersionSummaryAsync(string dataId, GetUserAppVersionSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserAppVersionSummaryHeaders headers = new GetUserAppVersionSummaryHeaders();
            return await GetUserAppVersionSummaryWithOptionsAsync(dataId, request, headers, runtime);
        }

        /**
         * @summary 人脸录入状态查询
         *
         * @param request GetUserFaceStateRequest
         * @param headers GetUserFaceStateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserFaceStateResponse
         */
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

        /**
         * @summary 人脸录入状态查询
         *
         * @param request GetUserFaceStateRequest
         * @param headers GetUserFaceStateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserFaceStateResponse
         */
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

        /**
         * @summary 人脸录入状态查询
         *
         * @param request GetUserFaceStateRequest
         * @return GetUserFaceStateResponse
         */
        public GetUserFaceStateResponse GetUserFaceState(GetUserFaceStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserFaceStateHeaders headers = new GetUserFaceStateHeaders();
            return GetUserFaceStateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 人脸录入状态查询
         *
         * @param request GetUserFaceStateRequest
         * @return GetUserFaceStateResponse
         */
        public async Task<GetUserFaceStateResponse> GetUserFaceStateAsync(GetUserFaceStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserFaceStateHeaders headers = new GetUserFaceStateHeaders();
            return await GetUserFaceStateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 实人认证状态查询
         *
         * @param request GetUserRealPeopleStateRequest
         * @param headers GetUserRealPeopleStateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserRealPeopleStateResponse
         */
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

        /**
         * @summary 实人认证状态查询
         *
         * @param request GetUserRealPeopleStateRequest
         * @param headers GetUserRealPeopleStateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserRealPeopleStateResponse
         */
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

        /**
         * @summary 实人认证状态查询
         *
         * @param request GetUserRealPeopleStateRequest
         * @return GetUserRealPeopleStateResponse
         */
        public GetUserRealPeopleStateResponse GetUserRealPeopleState(GetUserRealPeopleStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserRealPeopleStateHeaders headers = new GetUserRealPeopleStateHeaders();
            return GetUserRealPeopleStateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 实人认证状态查询
         *
         * @param request GetUserRealPeopleStateRequest
         * @return GetUserRealPeopleStateResponse
         */
        public async Task<GetUserRealPeopleStateResponse> GetUserRealPeopleStateAsync(GetUserRealPeopleStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserRealPeopleStateHeaders headers = new GetUserRealPeopleStateHeaders();
            return await GetUserRealPeopleStateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取用户停留时长
         *
         * @param request GetUserStayLengthRequest
         * @param headers GetUserStayLengthHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserStayLengthResponse
         */
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

        /**
         * @summary 获取用户停留时长
         *
         * @param request GetUserStayLengthRequest
         * @param headers GetUserStayLengthHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserStayLengthResponse
         */
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

        /**
         * @summary 获取用户停留时长
         *
         * @param request GetUserStayLengthRequest
         * @return GetUserStayLengthResponse
         */
        public GetUserStayLengthResponse GetUserStayLength(GetUserStayLengthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserStayLengthHeaders headers = new GetUserStayLengthHeaders();
            return GetUserStayLengthWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取用户停留时长
         *
         * @param request GetUserStayLengthRequest
         * @return GetUserStayLengthResponse
         */
        public async Task<GetUserStayLengthResponse> GetUserStayLengthAsync(GetUserStayLengthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserStayLengthHeaders headers = new GetUserStayLengthHeaders();
            return await GetUserStayLengthWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取文件病毒扫描结果
         *
         * @param request GetVirusScanResultRequest
         * @param headers GetVirusScanResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetVirusScanResultResponse
         */
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

        /**
         * @summary 获取文件病毒扫描结果
         *
         * @param request GetVirusScanResultRequest
         * @param headers GetVirusScanResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetVirusScanResultResponse
         */
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

        /**
         * @summary 获取文件病毒扫描结果
         *
         * @param request GetVirusScanResultRequest
         * @return GetVirusScanResultResponse
         */
        public GetVirusScanResultResponse GetVirusScanResult(GetVirusScanResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetVirusScanResultHeaders headers = new GetVirusScanResultHeaders();
            return GetVirusScanResultWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取文件病毒扫描结果
         *
         * @param request GetVirusScanResultRequest
         * @return GetVirusScanResultResponse
         */
        public async Task<GetVirusScanResultResponse> GetVirusScanResultAsync(GetVirusScanResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetVirusScanResultHeaders headers = new GetVirusScanResultHeaders();
            return await GetVirusScanResultWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业文件审计日志
         *
         * @param request ListAuditLogRequest
         * @param headers ListAuditLogHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAuditLogResponse
         */
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

        /**
         * @summary 获取企业文件审计日志
         *
         * @param request ListAuditLogRequest
         * @param headers ListAuditLogHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAuditLogResponse
         */
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

        /**
         * @summary 获取企业文件审计日志
         *
         * @param request ListAuditLogRequest
         * @return ListAuditLogResponse
         */
        public ListAuditLogResponse ListAuditLog(ListAuditLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAuditLogHeaders headers = new ListAuditLogHeaders();
            return ListAuditLogWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业文件审计日志
         *
         * @param request ListAuditLogRequest
         * @return ListAuditLogResponse
         */
        public async Task<ListAuditLogResponse> ListAuditLogAsync(ListAuditLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAuditLogHeaders headers = new ListAuditLogHeaders();
            return await ListAuditLogWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询分组列表
         *
         * @param tmpReq ListCategorysRequest
         * @param headers ListCategorysHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCategorysResponse
         */
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

        /**
         * @summary 查询分组列表
         *
         * @param tmpReq ListCategorysRequest
         * @param headers ListCategorysHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCategorysResponse
         */
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

        /**
         * @summary 查询分组列表
         *
         * @param request ListCategorysRequest
         * @return ListCategorysResponse
         */
        public ListCategorysResponse ListCategorys(ListCategorysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCategorysHeaders headers = new ListCategorysHeaders();
            return ListCategorysWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询分组列表
         *
         * @param request ListCategorysRequest
         * @return ListCategorysResponse
         */
        public async Task<ListCategorysResponse> ListCategorysAsync(ListCategorysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCategorysHeaders headers = new ListCategorysHeaders();
            return await ListCategorysWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 通过手机号获取已加入的属于渠道组织的列表信息
         *
         * @param request ListJoinOrgInfoRequest
         * @param headers ListJoinOrgInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListJoinOrgInfoResponse
         */
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

        /**
         * @summary 通过手机号获取已加入的属于渠道组织的列表信息
         *
         * @param request ListJoinOrgInfoRequest
         * @param headers ListJoinOrgInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListJoinOrgInfoResponse
         */
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

        /**
         * @summary 通过手机号获取已加入的属于渠道组织的列表信息
         *
         * @param request ListJoinOrgInfoRequest
         * @return ListJoinOrgInfoResponse
         */
        public ListJoinOrgInfoResponse ListJoinOrgInfo(ListJoinOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListJoinOrgInfoHeaders headers = new ListJoinOrgInfoHeaders();
            return ListJoinOrgInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 通过手机号获取已加入的属于渠道组织的列表信息
         *
         * @param request ListJoinOrgInfoRequest
         * @return ListJoinOrgInfoResponse
         */
        public async Task<ListJoinOrgInfoResponse> ListJoinOrgInfoAsync(ListJoinOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListJoinOrgInfoHeaders headers = new ListJoinOrgInfoHeaders();
            return await ListJoinOrgInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取小程序版本列表
         *
         * @param request ListMiniAppAvailableVersionRequest
         * @param headers ListMiniAppAvailableVersionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMiniAppAvailableVersionResponse
         */
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

        /**
         * @summary 获取小程序版本列表
         *
         * @param request ListMiniAppAvailableVersionRequest
         * @param headers ListMiniAppAvailableVersionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMiniAppAvailableVersionResponse
         */
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

        /**
         * @summary 获取小程序版本列表
         *
         * @param request ListMiniAppAvailableVersionRequest
         * @return ListMiniAppAvailableVersionResponse
         */
        public ListMiniAppAvailableVersionResponse ListMiniAppAvailableVersion(ListMiniAppAvailableVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMiniAppAvailableVersionHeaders headers = new ListMiniAppAvailableVersionHeaders();
            return ListMiniAppAvailableVersionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取小程序版本列表
         *
         * @param request ListMiniAppAvailableVersionRequest
         * @return ListMiniAppAvailableVersionResponse
         */
        public async Task<ListMiniAppAvailableVersionResponse> ListMiniAppAvailableVersionAsync(ListMiniAppAvailableVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMiniAppAvailableVersionHeaders headers = new ListMiniAppAvailableVersionHeaders();
            return await ListMiniAppAvailableVersionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取小程序历史版本列表
         *
         * @param request ListMiniAppHistoryVersionRequest
         * @param headers ListMiniAppHistoryVersionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMiniAppHistoryVersionResponse
         */
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

        /**
         * @summary 获取小程序历史版本列表
         *
         * @param request ListMiniAppHistoryVersionRequest
         * @param headers ListMiniAppHistoryVersionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMiniAppHistoryVersionResponse
         */
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

        /**
         * @summary 获取小程序历史版本列表
         *
         * @param request ListMiniAppHistoryVersionRequest
         * @return ListMiniAppHistoryVersionResponse
         */
        public ListMiniAppHistoryVersionResponse ListMiniAppHistoryVersion(ListMiniAppHistoryVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMiniAppHistoryVersionHeaders headers = new ListMiniAppHistoryVersionHeaders();
            return ListMiniAppHistoryVersionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取小程序历史版本列表
         *
         * @param request ListMiniAppHistoryVersionRequest
         * @return ListMiniAppHistoryVersionResponse
         */
        public async Task<ListMiniAppHistoryVersionResponse> ListMiniAppHistoryVersionAsync(ListMiniAppHistoryVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMiniAppHistoryVersionHeaders headers = new ListMiniAppHistoryVersionHeaders();
            return await ListMiniAppHistoryVersionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询伙伴角色
         *
         * @param headers ListPartnerRolesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPartnerRolesResponse
         */
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

        /**
         * @summary 查询伙伴角色
         *
         * @param headers ListPartnerRolesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPartnerRolesResponse
         */
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

        /**
         * @summary 查询伙伴角色
         *
         * @return ListPartnerRolesResponse
         */
        public ListPartnerRolesResponse ListPartnerRoles(string parentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPartnerRolesHeaders headers = new ListPartnerRolesHeaders();
            return ListPartnerRolesWithOptions(parentId, headers, runtime);
        }

        /**
         * @summary 查询伙伴角色
         *
         * @return ListPartnerRolesResponse
         */
        public async Task<ListPartnerRolesResponse> ListPartnerRolesAsync(string parentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPartnerRolesHeaders headers = new ListPartnerRolesHeaders();
            return await ListPartnerRolesWithOptionsAsync(parentId, headers, runtime);
        }

        /**
         * @summary 获取巡点信息列表
         *
         * @param request ListPunchScheduleByConditionWithPagingRequest
         * @param headers ListPunchScheduleByConditionWithPagingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPunchScheduleByConditionWithPagingResponse
         */
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

        /**
         * @summary 获取巡点信息列表
         *
         * @param request ListPunchScheduleByConditionWithPagingRequest
         * @param headers ListPunchScheduleByConditionWithPagingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPunchScheduleByConditionWithPagingResponse
         */
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

        /**
         * @summary 获取巡点信息列表
         *
         * @param request ListPunchScheduleByConditionWithPagingRequest
         * @return ListPunchScheduleByConditionWithPagingResponse
         */
        public ListPunchScheduleByConditionWithPagingResponse ListPunchScheduleByConditionWithPaging(ListPunchScheduleByConditionWithPagingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPunchScheduleByConditionWithPagingHeaders headers = new ListPunchScheduleByConditionWithPagingHeaders();
            return ListPunchScheduleByConditionWithPagingWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取巡点信息列表
         *
         * @param request ListPunchScheduleByConditionWithPagingRequest
         * @return ListPunchScheduleByConditionWithPagingResponse
         */
        public async Task<ListPunchScheduleByConditionWithPagingResponse> ListPunchScheduleByConditionWithPagingAsync(ListPunchScheduleByConditionWithPagingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListPunchScheduleByConditionWithPagingHeaders headers = new ListPunchScheduleByConditionWithPagingHeaders();
            return await ListPunchScheduleByConditionWithPagingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询规则列表
         *
         * @param tmpReq ListRulesRequest
         * @param headers ListRulesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRulesResponse
         */
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

        /**
         * @summary 查询规则列表
         *
         * @param tmpReq ListRulesRequest
         * @param headers ListRulesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRulesResponse
         */
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

        /**
         * @summary 查询规则列表
         *
         * @param request ListRulesRequest
         * @return ListRulesResponse
         */
        public ListRulesResponse ListRules(ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRulesHeaders headers = new ListRulesHeaders();
            return ListRulesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询规则列表
         *
         * @param request ListRulesRequest
         * @return ListRulesResponse
         */
        public async Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRulesHeaders headers = new ListRulesHeaders();
            return await ListRulesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 指定用户强制下线
         *
         * @param request LogoutRequest
         * @param headers LogoutHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return LogoutResponse
         */
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

        /**
         * @summary 指定用户强制下线
         *
         * @param request LogoutRequest
         * @param headers LogoutHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return LogoutResponse
         */
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

        /**
         * @summary 指定用户强制下线
         *
         * @param request LogoutRequest
         * @return LogoutResponse
         */
        public LogoutResponse Logout(LogoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LogoutHeaders headers = new LogoutHeaders();
            return LogoutWithOptions(request, headers, runtime);
        }

        /**
         * @summary 指定用户强制下线
         *
         * @param request LogoutRequest
         * @return LogoutResponse
         */
        public async Task<LogoutResponse> LogoutAsync(LogoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LogoutHeaders headers = new LogoutHeaders();
            return await LogoutWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 购买权益包
         *
         * @param request OpenBenefitPackageRequest
         * @param headers OpenBenefitPackageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenBenefitPackageResponse
         */
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

        /**
         * @summary 购买权益包
         *
         * @param request OpenBenefitPackageRequest
         * @param headers OpenBenefitPackageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenBenefitPackageResponse
         */
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

        /**
         * @summary 购买权益包
         *
         * @param request OpenBenefitPackageRequest
         * @return OpenBenefitPackageResponse
         */
        public OpenBenefitPackageResponse OpenBenefitPackage(OpenBenefitPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenBenefitPackageHeaders headers = new OpenBenefitPackageHeaders();
            return OpenBenefitPackageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 购买权益包
         *
         * @param request OpenBenefitPackageRequest
         * @return OpenBenefitPackageResponse
         */
        public async Task<OpenBenefitPackageResponse> OpenBenefitPackageAsync(OpenBenefitPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenBenefitPackageHeaders headers = new OpenBenefitPackageHeaders();
            return await OpenBenefitPackageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 防作弊风险检测
         *
         * @param request PreventCheatingCheckRiskRequest
         * @param headers PreventCheatingCheckRiskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PreventCheatingCheckRiskResponse
         */
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

        /**
         * @summary 防作弊风险检测
         *
         * @param request PreventCheatingCheckRiskRequest
         * @param headers PreventCheatingCheckRiskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PreventCheatingCheckRiskResponse
         */
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

        /**
         * @summary 防作弊风险检测
         *
         * @param request PreventCheatingCheckRiskRequest
         * @return PreventCheatingCheckRiskResponse
         */
        public PreventCheatingCheckRiskResponse PreventCheatingCheckRisk(PreventCheatingCheckRiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PreventCheatingCheckRiskHeaders headers = new PreventCheatingCheckRiskHeaders();
            return PreventCheatingCheckRiskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 防作弊风险检测
         *
         * @param request PreventCheatingCheckRiskRequest
         * @return PreventCheatingCheckRiskResponse
         */
        public async Task<PreventCheatingCheckRiskResponse> PreventCheatingCheckRiskAsync(PreventCheatingCheckRiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PreventCheatingCheckRiskHeaders headers = new PreventCheatingCheckRiskHeaders();
            return await PreventCheatingCheckRiskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发送文件更改的评论
         *
         * @param request PublishFileChangeNoticeRequest
         * @param headers PublishFileChangeNoticeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishFileChangeNoticeResponse
         */
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

        /**
         * @summary 发送文件更改的评论
         *
         * @param request PublishFileChangeNoticeRequest
         * @param headers PublishFileChangeNoticeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishFileChangeNoticeResponse
         */
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

        /**
         * @summary 发送文件更改的评论
         *
         * @param request PublishFileChangeNoticeRequest
         * @return PublishFileChangeNoticeResponse
         */
        public PublishFileChangeNoticeResponse PublishFileChangeNotice(PublishFileChangeNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishFileChangeNoticeHeaders headers = new PublishFileChangeNoticeHeaders();
            return PublishFileChangeNoticeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发送文件更改的评论
         *
         * @param request PublishFileChangeNoticeRequest
         * @return PublishFileChangeNoticeResponse
         */
        public async Task<PublishFileChangeNoticeResponse> PublishFileChangeNoticeAsync(PublishFileChangeNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishFileChangeNoticeHeaders headers = new PublishFileChangeNoticeHeaders();
            return await PublishFileChangeNoticeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发布规则
         *
         * @param request PublishRuleRequest
         * @param headers PublishRuleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishRuleResponse
         */
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

        /**
         * @summary 发布规则
         *
         * @param request PublishRuleRequest
         * @param headers PublishRuleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishRuleResponse
         */
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

        /**
         * @summary 发布规则
         *
         * @param request PublishRuleRequest
         * @return PublishRuleResponse
         */
        public PublishRuleResponse PublishRule(PublishRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishRuleHeaders headers = new PublishRuleHeaders();
            return PublishRuleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发布规则
         *
         * @param request PublishRuleRequest
         * @return PublishRuleResponse
         */
        public async Task<PublishRuleResponse> PublishRuleAsync(PublishRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishRuleHeaders headers = new PublishRuleHeaders();
            return await PublishRuleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 推送专属设计中自建/第三方应用的小红点
         *
         * @param request PushBadgeRequest
         * @param headers PushBadgeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushBadgeResponse
         */
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

        /**
         * @summary 推送专属设计中自建/第三方应用的小红点
         *
         * @param request PushBadgeRequest
         * @param headers PushBadgeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushBadgeResponse
         */
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

        /**
         * @summary 推送专属设计中自建/第三方应用的小红点
         *
         * @param request PushBadgeRequest
         * @return PushBadgeResponse
         */
        public PushBadgeResponse PushBadge(PushBadgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushBadgeHeaders headers = new PushBadgeHeaders();
            return PushBadgeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 推送专属设计中自建/第三方应用的小红点
         *
         * @param request PushBadgeRequest
         * @return PushBadgeResponse
         */
        public async Task<PushBadgeResponse> PushBadgeAsync(PushBadgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushBadgeHeaders headers = new PushBadgeHeaders();
            return await PushBadgeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询跨云存储配置
         *
         * @param request QueryAcrossCloudStroageConfigsRequest
         * @param headers QueryAcrossCloudStroageConfigsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAcrossCloudStroageConfigsResponse
         */
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

        /**
         * @summary 查询跨云存储配置
         *
         * @param request QueryAcrossCloudStroageConfigsRequest
         * @param headers QueryAcrossCloudStroageConfigsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAcrossCloudStroageConfigsResponse
         */
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

        /**
         * @summary 查询跨云存储配置
         *
         * @param request QueryAcrossCloudStroageConfigsRequest
         * @return QueryAcrossCloudStroageConfigsResponse
         */
        public QueryAcrossCloudStroageConfigsResponse QueryAcrossCloudStroageConfigs(QueryAcrossCloudStroageConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAcrossCloudStroageConfigsHeaders headers = new QueryAcrossCloudStroageConfigsHeaders();
            return QueryAcrossCloudStroageConfigsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询跨云存储配置
         *
         * @param request QueryAcrossCloudStroageConfigsRequest
         * @return QueryAcrossCloudStroageConfigsResponse
         */
        public async Task<QueryAcrossCloudStroageConfigsResponse> QueryAcrossCloudStroageConfigsAsync(QueryAcrossCloudStroageConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAcrossCloudStroageConfigsHeaders headers = new QueryAcrossCloudStroageConfigsHeaders();
            return await QueryAcrossCloudStroageConfigsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据手机号查询渠道组织中的员工信息
         *
         * @param request QueryChannelStaffInfoByMobileRequest
         * @param headers QueryChannelStaffInfoByMobileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryChannelStaffInfoByMobileResponse
         */
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

        /**
         * @summary 根据手机号查询渠道组织中的员工信息
         *
         * @param request QueryChannelStaffInfoByMobileRequest
         * @param headers QueryChannelStaffInfoByMobileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryChannelStaffInfoByMobileResponse
         */
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

        /**
         * @summary 根据手机号查询渠道组织中的员工信息
         *
         * @param request QueryChannelStaffInfoByMobileRequest
         * @return QueryChannelStaffInfoByMobileResponse
         */
        public QueryChannelStaffInfoByMobileResponse QueryChannelStaffInfoByMobile(QueryChannelStaffInfoByMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryChannelStaffInfoByMobileHeaders headers = new QueryChannelStaffInfoByMobileHeaders();
            return QueryChannelStaffInfoByMobileWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据手机号查询渠道组织中的员工信息
         *
         * @param request QueryChannelStaffInfoByMobileRequest
         * @return QueryChannelStaffInfoByMobileResponse
         */
        public async Task<QueryChannelStaffInfoByMobileResponse> QueryChannelStaffInfoByMobileAsync(QueryChannelStaffInfoByMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryChannelStaffInfoByMobileHeaders headers = new QueryChannelStaffInfoByMobileHeaders();
            return await QueryChannelStaffInfoByMobileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 伙伴钉根据uid查询人员的标签信息
         *
         * @param headers QueryPartnerInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPartnerInfoResponse
         */
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

        /**
         * @summary 伙伴钉根据uid查询人员的标签信息
         *
         * @param headers QueryPartnerInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPartnerInfoResponse
         */
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

        /**
         * @summary 伙伴钉根据uid查询人员的标签信息
         *
         * @return QueryPartnerInfoResponse
         */
        public QueryPartnerInfoResponse QueryPartnerInfo(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPartnerInfoHeaders headers = new QueryPartnerInfoHeaders();
            return QueryPartnerInfoWithOptions(userId, headers, runtime);
        }

        /**
         * @summary 伙伴钉根据uid查询人员的标签信息
         *
         * @return QueryPartnerInfoResponse
         */
        public async Task<QueryPartnerInfoResponse> QueryPartnerInfoAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPartnerInfoHeaders headers = new QueryPartnerInfoHeaders();
            return await QueryPartnerInfoWithOptionsAsync(userId, headers, runtime);
        }

        /**
         * @summary 获取用户截屏操作记录
         *
         * @param request QueryUserBehaviorRequest
         * @param headers QueryUserBehaviorHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserBehaviorResponse
         */
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

        /**
         * @summary 获取用户截屏操作记录
         *
         * @param request QueryUserBehaviorRequest
         * @param headers QueryUserBehaviorHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserBehaviorResponse
         */
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

        /**
         * @summary 获取用户截屏操作记录
         *
         * @param request QueryUserBehaviorRequest
         * @return QueryUserBehaviorResponse
         */
        public QueryUserBehaviorResponse QueryUserBehavior(QueryUserBehaviorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserBehaviorHeaders headers = new QueryUserBehaviorHeaders();
            return QueryUserBehaviorWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取用户截屏操作记录
         *
         * @param request QueryUserBehaviorRequest
         * @return QueryUserBehaviorResponse
         */
        public async Task<QueryUserBehaviorResponse> QueryUserBehaviorAsync(QueryUserBehaviorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserBehaviorHeaders headers = new QueryUserBehaviorHeaders();
            return await QueryUserBehaviorWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 小程序版本回滚
         *
         * @param request RollbackMiniAppVersionRequest
         * @param headers RollbackMiniAppVersionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RollbackMiniAppVersionResponse
         */
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

        /**
         * @summary 小程序版本回滚
         *
         * @param request RollbackMiniAppVersionRequest
         * @param headers RollbackMiniAppVersionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RollbackMiniAppVersionResponse
         */
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

        /**
         * @summary 小程序版本回滚
         *
         * @param request RollbackMiniAppVersionRequest
         * @return RollbackMiniAppVersionResponse
         */
        public RollbackMiniAppVersionResponse RollbackMiniAppVersion(RollbackMiniAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RollbackMiniAppVersionHeaders headers = new RollbackMiniAppVersionHeaders();
            return RollbackMiniAppVersionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 小程序版本回滚
         *
         * @param request RollbackMiniAppVersionRequest
         * @return RollbackMiniAppVersionResponse
         */
        public async Task<RollbackMiniAppVersionResponse> RollbackMiniAppVersionAsync(RollbackMiniAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RollbackMiniAppVersionHeaders headers = new RollbackMiniAppVersionHeaders();
            return await RollbackMiniAppVersionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 按规则批量发消息
         *
         * @param request RuleBatchReceiverRequest
         * @param headers RuleBatchReceiverHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RuleBatchReceiverResponse
         */
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

        /**
         * @summary 按规则批量发消息
         *
         * @param request RuleBatchReceiverRequest
         * @param headers RuleBatchReceiverHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RuleBatchReceiverResponse
         */
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

        /**
         * @summary 按规则批量发消息
         *
         * @param request RuleBatchReceiverRequest
         * @return RuleBatchReceiverResponse
         */
        public RuleBatchReceiverResponse RuleBatchReceiver(RuleBatchReceiverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RuleBatchReceiverHeaders headers = new RuleBatchReceiverHeaders();
            return RuleBatchReceiverWithOptions(request, headers, runtime);
        }

        /**
         * @summary 按规则批量发消息
         *
         * @param request RuleBatchReceiverRequest
         * @return RuleBatchReceiverResponse
         */
        public async Task<RuleBatchReceiverResponse> RuleBatchReceiverAsync(RuleBatchReceiverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RuleBatchReceiverHeaders headers = new RuleBatchReceiverHeaders();
            return await RuleBatchReceiverWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 新增跨云存储配置
         *
         * @param request SaveAcrossCloudStroageConfigsRequest
         * @param headers SaveAcrossCloudStroageConfigsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveAcrossCloudStroageConfigsResponse
         */
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

        /**
         * @summary 新增跨云存储配置
         *
         * @param request SaveAcrossCloudStroageConfigsRequest
         * @param headers SaveAcrossCloudStroageConfigsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveAcrossCloudStroageConfigsResponse
         */
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

        /**
         * @summary 新增跨云存储配置
         *
         * @param request SaveAcrossCloudStroageConfigsRequest
         * @return SaveAcrossCloudStroageConfigsResponse
         */
        public SaveAcrossCloudStroageConfigsResponse SaveAcrossCloudStroageConfigs(SaveAcrossCloudStroageConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveAcrossCloudStroageConfigsHeaders headers = new SaveAcrossCloudStroageConfigsHeaders();
            return SaveAcrossCloudStroageConfigsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新增跨云存储配置
         *
         * @param request SaveAcrossCloudStroageConfigsRequest
         * @return SaveAcrossCloudStroageConfigsResponse
         */
        public async Task<SaveAcrossCloudStroageConfigsResponse> SaveAcrossCloudStroageConfigsAsync(SaveAcrossCloudStroageConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveAcrossCloudStroageConfigsHeaders headers = new SaveAcrossCloudStroageConfigsHeaders();
            return await SaveAcrossCloudStroageConfigsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 保存并提交认证信息
         *
         * @param request SaveAndSubmitAuthInfoRequest
         * @param headers SaveAndSubmitAuthInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveAndSubmitAuthInfoResponse
         */
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

        /**
         * @summary 保存并提交认证信息
         *
         * @param request SaveAndSubmitAuthInfoRequest
         * @param headers SaveAndSubmitAuthInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveAndSubmitAuthInfoResponse
         */
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

        /**
         * @summary 保存并提交认证信息
         *
         * @param request SaveAndSubmitAuthInfoRequest
         * @return SaveAndSubmitAuthInfoResponse
         */
        public SaveAndSubmitAuthInfoResponse SaveAndSubmitAuthInfo(SaveAndSubmitAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveAndSubmitAuthInfoHeaders headers = new SaveAndSubmitAuthInfoHeaders();
            return SaveAndSubmitAuthInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 保存并提交认证信息
         *
         * @param request SaveAndSubmitAuthInfoRequest
         * @return SaveAndSubmitAuthInfoResponse
         */
        public async Task<SaveAndSubmitAuthInfoResponse> SaveAndSubmitAuthInfoAsync(SaveAndSubmitAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveAndSubmitAuthInfoHeaders headers = new SaveAndSubmitAuthInfoHeaders();
            return await SaveAndSubmitAuthInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亿格云能力结合
         *
         * @param request SaveOpenTerminalInfoRequest
         * @param headers SaveOpenTerminalInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveOpenTerminalInfoResponse
         */
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

        /**
         * @summary 亿格云能力结合
         *
         * @param request SaveOpenTerminalInfoRequest
         * @param headers SaveOpenTerminalInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveOpenTerminalInfoResponse
         */
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

        /**
         * @summary 亿格云能力结合
         *
         * @param request SaveOpenTerminalInfoRequest
         * @return SaveOpenTerminalInfoResponse
         */
        public SaveOpenTerminalInfoResponse SaveOpenTerminalInfo(SaveOpenTerminalInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveOpenTerminalInfoHeaders headers = new SaveOpenTerminalInfoHeaders();
            return SaveOpenTerminalInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亿格云能力结合
         *
         * @param request SaveOpenTerminalInfoRequest
         * @return SaveOpenTerminalInfoResponse
         */
        public async Task<SaveOpenTerminalInfoResponse> SaveOpenTerminalInfoAsync(SaveOpenTerminalInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveOpenTerminalInfoHeaders headers = new SaveOpenTerminalInfoHeaders();
            return await SaveOpenTerminalInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 保存专属文件存储的功能项
         *
         * @param request SaveStorageFunctionSwitchRequest
         * @param headers SaveStorageFunctionSwitchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveStorageFunctionSwitchResponse
         */
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

        /**
         * @summary 保存专属文件存储的功能项
         *
         * @param request SaveStorageFunctionSwitchRequest
         * @param headers SaveStorageFunctionSwitchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveStorageFunctionSwitchResponse
         */
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

        /**
         * @summary 保存专属文件存储的功能项
         *
         * @param request SaveStorageFunctionSwitchRequest
         * @return SaveStorageFunctionSwitchResponse
         */
        public SaveStorageFunctionSwitchResponse SaveStorageFunctionSwitch(SaveStorageFunctionSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveStorageFunctionSwitchHeaders headers = new SaveStorageFunctionSwitchHeaders();
            return SaveStorageFunctionSwitchWithOptions(request, headers, runtime);
        }

        /**
         * @summary 保存专属文件存储的功能项
         *
         * @param request SaveStorageFunctionSwitchRequest
         * @return SaveStorageFunctionSwitchResponse
         */
        public async Task<SaveStorageFunctionSwitchResponse> SaveStorageFunctionSwitchAsync(SaveStorageFunctionSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveStorageFunctionSwitchHeaders headers = new SaveStorageFunctionSwitchHeaders();
            return await SaveStorageFunctionSwitchWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 保存专属文件存储整体开关
         *
         * @param request SaveStorageSwitchRequest
         * @param headers SaveStorageSwitchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveStorageSwitchResponse
         */
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

        /**
         * @summary 保存专属文件存储整体开关
         *
         * @param request SaveStorageSwitchRequest
         * @param headers SaveStorageSwitchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveStorageSwitchResponse
         */
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

        /**
         * @summary 保存专属文件存储整体开关
         *
         * @param request SaveStorageSwitchRequest
         * @return SaveStorageSwitchResponse
         */
        public SaveStorageSwitchResponse SaveStorageSwitch(SaveStorageSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveStorageSwitchHeaders headers = new SaveStorageSwitchHeaders();
            return SaveStorageSwitchWithOptions(request, headers, runtime);
        }

        /**
         * @summary 保存专属文件存储整体开关
         *
         * @param request SaveStorageSwitchRequest
         * @return SaveStorageSwitchResponse
         */
        public async Task<SaveStorageSwitchResponse> SaveStorageSwitchAsync(SaveStorageSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveStorageSwitchHeaders headers = new SaveStorageSwitchHeaders();
            return await SaveStorageSwitchWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 用于提供mdm微应用白名单配置能力
         *
         * @param request SaveWhiteAppRequest
         * @param headers SaveWhiteAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveWhiteAppResponse
         */
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

        /**
         * @summary 用于提供mdm微应用白名单配置能力
         *
         * @param request SaveWhiteAppRequest
         * @param headers SaveWhiteAppHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveWhiteAppResponse
         */
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

        /**
         * @summary 用于提供mdm微应用白名单配置能力
         *
         * @param request SaveWhiteAppRequest
         * @return SaveWhiteAppResponse
         */
        public SaveWhiteAppResponse SaveWhiteApp(SaveWhiteAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveWhiteAppHeaders headers = new SaveWhiteAppHeaders();
            return SaveWhiteAppWithOptions(request, headers, runtime);
        }

        /**
         * @summary 用于提供mdm微应用白名单配置能力
         *
         * @param request SaveWhiteAppRequest
         * @return SaveWhiteAppResponse
         */
        public async Task<SaveWhiteAppResponse> SaveWhiteAppAsync(SaveWhiteAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveWhiteAppHeaders headers = new SaveWhiteAppHeaders();
            return await SaveWhiteAppWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询企业内部群信息
         *
         * @param request SearchOrgInnerGroupInfoRequest
         * @param headers SearchOrgInnerGroupInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchOrgInnerGroupInfoResponse
         */
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

        /**
         * @summary 查询企业内部群信息
         *
         * @param request SearchOrgInnerGroupInfoRequest
         * @param headers SearchOrgInnerGroupInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchOrgInnerGroupInfoResponse
         */
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

        /**
         * @summary 查询企业内部群信息
         *
         * @param request SearchOrgInnerGroupInfoRequest
         * @return SearchOrgInnerGroupInfoResponse
         */
        public SearchOrgInnerGroupInfoResponse SearchOrgInnerGroupInfo(SearchOrgInnerGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchOrgInnerGroupInfoHeaders headers = new SearchOrgInnerGroupInfoHeaders();
            return SearchOrgInnerGroupInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询企业内部群信息
         *
         * @param request SearchOrgInnerGroupInfoRequest
         * @return SearchOrgInnerGroupInfoResponse
         */
        public async Task<SearchOrgInnerGroupInfoResponse> SearchOrgInnerGroupInfoAsync(SearchOrgInnerGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchOrgInnerGroupInfoHeaders headers = new SearchOrgInnerGroupInfoHeaders();
            return await SearchOrgInnerGroupInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 通过接口发送应用内DING
         *
         * @param request SendAppDingRequest
         * @param headers SendAppDingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendAppDingResponse
         */
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

        /**
         * @summary 通过接口发送应用内DING
         *
         * @param request SendAppDingRequest
         * @param headers SendAppDingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendAppDingResponse
         */
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

        /**
         * @summary 通过接口发送应用内DING
         *
         * @param request SendAppDingRequest
         * @return SendAppDingResponse
         */
        public SendAppDingResponse SendAppDing(SendAppDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendAppDingHeaders headers = new SendAppDingHeaders();
            return SendAppDingWithOptions(request, headers, runtime);
        }

        /**
         * @summary 通过接口发送应用内DING
         *
         * @param request SendAppDingRequest
         * @return SendAppDingResponse
         */
        public async Task<SendAppDingResponse> SendAppDingAsync(SendAppDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendAppDingHeaders headers = new SendAppDingHeaders();
            return await SendAppDingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发送邀请函
         *
         * @param request SendInvitationRequest
         * @param headers SendInvitationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendInvitationResponse
         */
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

        /**
         * @summary 发送邀请函
         *
         * @param request SendInvitationRequest
         * @param headers SendInvitationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendInvitationResponse
         */
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

        /**
         * @summary 发送邀请函
         *
         * @param request SendInvitationRequest
         * @return SendInvitationResponse
         */
        public SendInvitationResponse SendInvitation(SendInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendInvitationHeaders headers = new SendInvitationHeaders();
            return SendInvitationWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发送邀请函
         *
         * @param request SendInvitationRequest
         * @return SendInvitationResponse
         */
        public async Task<SendInvitationResponse> SendInvitationAsync(SendInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendInvitationHeaders headers = new SendInvitationHeaders();
            return await SendInvitationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 通过接口发送电话DING
         *
         * @param request SendPhoneDingRequest
         * @param headers SendPhoneDingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendPhoneDingResponse
         */
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

        /**
         * @summary 通过接口发送电话DING
         *
         * @param request SendPhoneDingRequest
         * @param headers SendPhoneDingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendPhoneDingResponse
         */
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

        /**
         * @summary 通过接口发送电话DING
         *
         * @param request SendPhoneDingRequest
         * @return SendPhoneDingResponse
         */
        public SendPhoneDingResponse SendPhoneDing(SendPhoneDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendPhoneDingHeaders headers = new SendPhoneDingHeaders();
            return SendPhoneDingWithOptions(request, headers, runtime);
        }

        /**
         * @summary 通过接口发送电话DING
         *
         * @param request SendPhoneDingRequest
         * @return SendPhoneDingResponse
         */
        public async Task<SendPhoneDingResponse> SendPhoneDingAsync(SendPhoneDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendPhoneDingHeaders headers = new SendPhoneDingHeaders();
            return await SendPhoneDingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 设置会话所属分组
         *
         * @param request SetConversationCategoryRequest
         * @param headers SetConversationCategoryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetConversationCategoryResponse
         */
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

        /**
         * @summary 设置会话所属分组
         *
         * @param request SetConversationCategoryRequest
         * @param headers SetConversationCategoryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetConversationCategoryResponse
         */
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

        /**
         * @summary 设置会话所属分组
         *
         * @param request SetConversationCategoryRequest
         * @return SetConversationCategoryResponse
         */
        public SetConversationCategoryResponse SetConversationCategory(SetConversationCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetConversationCategoryHeaders headers = new SetConversationCategoryHeaders();
            return SetConversationCategoryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 设置会话所属分组
         *
         * @param request SetConversationCategoryRequest
         * @return SetConversationCategoryResponse
         */
        public async Task<SetConversationCategoryResponse> SetConversationCategoryAsync(SetConversationCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetConversationCategoryHeaders headers = new SetConversationCategoryHeaders();
            return await SetConversationCategoryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 伙伴钉设置部门伙伴编码和伙伴类型
         *
         * @param request SetDeptPartnerTypeAndNumRequest
         * @param headers SetDeptPartnerTypeAndNumHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDeptPartnerTypeAndNumResponse
         */
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

        /**
         * @summary 伙伴钉设置部门伙伴编码和伙伴类型
         *
         * @param request SetDeptPartnerTypeAndNumRequest
         * @param headers SetDeptPartnerTypeAndNumHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDeptPartnerTypeAndNumResponse
         */
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

        /**
         * @summary 伙伴钉设置部门伙伴编码和伙伴类型
         *
         * @param request SetDeptPartnerTypeAndNumRequest
         * @return SetDeptPartnerTypeAndNumResponse
         */
        public SetDeptPartnerTypeAndNumResponse SetDeptPartnerTypeAndNum(SetDeptPartnerTypeAndNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDeptPartnerTypeAndNumHeaders headers = new SetDeptPartnerTypeAndNumHeaders();
            return SetDeptPartnerTypeAndNumWithOptions(request, headers, runtime);
        }

        /**
         * @summary 伙伴钉设置部门伙伴编码和伙伴类型
         *
         * @param request SetDeptPartnerTypeAndNumRequest
         * @return SetDeptPartnerTypeAndNumResponse
         */
        public async Task<SetDeptPartnerTypeAndNumResponse> SetDeptPartnerTypeAndNumAsync(SetDeptPartnerTypeAndNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDeptPartnerTypeAndNumHeaders headers = new SetDeptPartnerTypeAndNumHeaders();
            return await SetDeptPartnerTypeAndNumWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 千人千面按规则批量发消息
         *
         * @param request SpecialRuleBatchReceiverRequest
         * @param headers SpecialRuleBatchReceiverHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SpecialRuleBatchReceiverResponse
         */
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

        /**
         * @summary 千人千面按规则批量发消息
         *
         * @param request SpecialRuleBatchReceiverRequest
         * @param headers SpecialRuleBatchReceiverHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SpecialRuleBatchReceiverResponse
         */
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

        /**
         * @summary 千人千面按规则批量发消息
         *
         * @param request SpecialRuleBatchReceiverRequest
         * @return SpecialRuleBatchReceiverResponse
         */
        public SpecialRuleBatchReceiverResponse SpecialRuleBatchReceiver(SpecialRuleBatchReceiverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SpecialRuleBatchReceiverHeaders headers = new SpecialRuleBatchReceiverHeaders();
            return SpecialRuleBatchReceiverWithOptions(request, headers, runtime);
        }

        /**
         * @summary 千人千面按规则批量发消息
         *
         * @param request SpecialRuleBatchReceiverRequest
         * @return SpecialRuleBatchReceiverResponse
         */
        public async Task<SpecialRuleBatchReceiverResponse> SpecialRuleBatchReceiverAsync(SpecialRuleBatchReceiverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SpecialRuleBatchReceiverHeaders headers = new SpecialRuleBatchReceiverHeaders();
            return await SpecialRuleBatchReceiverWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 增加/删除任务人员
         *
         * @param request TaskInfoAddDelTaskPersonRequest
         * @param headers TaskInfoAddDelTaskPersonHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskInfoAddDelTaskPersonResponse
         */
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

        /**
         * @summary 增加/删除任务人员
         *
         * @param request TaskInfoAddDelTaskPersonRequest
         * @param headers TaskInfoAddDelTaskPersonHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskInfoAddDelTaskPersonResponse
         */
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

        /**
         * @summary 增加/删除任务人员
         *
         * @param request TaskInfoAddDelTaskPersonRequest
         * @return TaskInfoAddDelTaskPersonResponse
         */
        public TaskInfoAddDelTaskPersonResponse TaskInfoAddDelTaskPerson(TaskInfoAddDelTaskPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoAddDelTaskPersonHeaders headers = new TaskInfoAddDelTaskPersonHeaders();
            return TaskInfoAddDelTaskPersonWithOptions(request, headers, runtime);
        }

        /**
         * @summary 增加/删除任务人员
         *
         * @param request TaskInfoAddDelTaskPersonRequest
         * @return TaskInfoAddDelTaskPersonResponse
         */
        public async Task<TaskInfoAddDelTaskPersonResponse> TaskInfoAddDelTaskPersonAsync(TaskInfoAddDelTaskPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoAddDelTaskPersonHeaders headers = new TaskInfoAddDelTaskPersonHeaders();
            return await TaskInfoAddDelTaskPersonWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除任务
         *
         * @param request TaskInfoCancelOrDelTaskRequest
         * @param headers TaskInfoCancelOrDelTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskInfoCancelOrDelTaskResponse
         */
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

        /**
         * @summary 删除任务
         *
         * @param request TaskInfoCancelOrDelTaskRequest
         * @param headers TaskInfoCancelOrDelTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskInfoCancelOrDelTaskResponse
         */
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

        /**
         * @summary 删除任务
         *
         * @param request TaskInfoCancelOrDelTaskRequest
         * @return TaskInfoCancelOrDelTaskResponse
         */
        public TaskInfoCancelOrDelTaskResponse TaskInfoCancelOrDelTask(TaskInfoCancelOrDelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoCancelOrDelTaskHeaders headers = new TaskInfoCancelOrDelTaskHeaders();
            return TaskInfoCancelOrDelTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除任务
         *
         * @param request TaskInfoCancelOrDelTaskRequest
         * @return TaskInfoCancelOrDelTaskResponse
         */
        public async Task<TaskInfoCancelOrDelTaskResponse> TaskInfoCancelOrDelTaskAsync(TaskInfoCancelOrDelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoCancelOrDelTaskHeaders headers = new TaskInfoCancelOrDelTaskHeaders();
            return await TaskInfoCancelOrDelTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建并启动任务
         *
         * @param request TaskInfoCreateAndStartTaskRequest
         * @param headers TaskInfoCreateAndStartTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskInfoCreateAndStartTaskResponse
         */
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

        /**
         * @summary 创建并启动任务
         *
         * @param request TaskInfoCreateAndStartTaskRequest
         * @param headers TaskInfoCreateAndStartTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskInfoCreateAndStartTaskResponse
         */
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

        /**
         * @summary 创建并启动任务
         *
         * @param request TaskInfoCreateAndStartTaskRequest
         * @return TaskInfoCreateAndStartTaskResponse
         */
        public TaskInfoCreateAndStartTaskResponse TaskInfoCreateAndStartTask(TaskInfoCreateAndStartTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoCreateAndStartTaskHeaders headers = new TaskInfoCreateAndStartTaskHeaders();
            return TaskInfoCreateAndStartTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建并启动任务
         *
         * @param request TaskInfoCreateAndStartTaskRequest
         * @return TaskInfoCreateAndStartTaskResponse
         */
        public async Task<TaskInfoCreateAndStartTaskResponse> TaskInfoCreateAndStartTaskAsync(TaskInfoCreateAndStartTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoCreateAndStartTaskHeaders headers = new TaskInfoCreateAndStartTaskHeaders();
            return await TaskInfoCreateAndStartTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 完成任务
         *
         * @param request TaskInfoFinishTaskRequest
         * @param headers TaskInfoFinishTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskInfoFinishTaskResponse
         */
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

        /**
         * @summary 完成任务
         *
         * @param request TaskInfoFinishTaskRequest
         * @param headers TaskInfoFinishTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskInfoFinishTaskResponse
         */
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

        /**
         * @summary 完成任务
         *
         * @param request TaskInfoFinishTaskRequest
         * @return TaskInfoFinishTaskResponse
         */
        public TaskInfoFinishTaskResponse TaskInfoFinishTask(TaskInfoFinishTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoFinishTaskHeaders headers = new TaskInfoFinishTaskHeaders();
            return TaskInfoFinishTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 完成任务
         *
         * @param request TaskInfoFinishTaskRequest
         * @return TaskInfoFinishTaskResponse
         */
        public async Task<TaskInfoFinishTaskResponse> TaskInfoFinishTaskAsync(TaskInfoFinishTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoFinishTaskHeaders headers = new TaskInfoFinishTaskHeaders();
            return await TaskInfoFinishTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新任务
         *
         * @param request TaskInfoUpdateTaskRequest
         * @param headers TaskInfoUpdateTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskInfoUpdateTaskResponse
         */
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

        /**
         * @summary 更新任务
         *
         * @param request TaskInfoUpdateTaskRequest
         * @param headers TaskInfoUpdateTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TaskInfoUpdateTaskResponse
         */
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

        /**
         * @summary 更新任务
         *
         * @param request TaskInfoUpdateTaskRequest
         * @return TaskInfoUpdateTaskResponse
         */
        public TaskInfoUpdateTaskResponse TaskInfoUpdateTask(TaskInfoUpdateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoUpdateTaskHeaders headers = new TaskInfoUpdateTaskHeaders();
            return TaskInfoUpdateTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新任务
         *
         * @param request TaskInfoUpdateTaskRequest
         * @return TaskInfoUpdateTaskResponse
         */
        public async Task<TaskInfoUpdateTaskResponse> TaskInfoUpdateTaskAsync(TaskInfoUpdateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TaskInfoUpdateTaskHeaders headers = new TaskInfoUpdateTaskHeaders();
            return await TaskInfoUpdateTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更改分组名称
         *
         * @param request UpdateCategoryNameRequest
         * @param headers UpdateCategoryNameHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCategoryNameResponse
         */
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

        /**
         * @summary 更改分组名称
         *
         * @param request UpdateCategoryNameRequest
         * @param headers UpdateCategoryNameHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCategoryNameResponse
         */
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

        /**
         * @summary 更改分组名称
         *
         * @param request UpdateCategoryNameRequest
         * @return UpdateCategoryNameResponse
         */
        public UpdateCategoryNameResponse UpdateCategoryName(UpdateCategoryNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCategoryNameHeaders headers = new UpdateCategoryNameHeaders();
            return UpdateCategoryNameWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更改分组名称
         *
         * @param request UpdateCategoryNameRequest
         * @return UpdateCategoryNameResponse
         */
        public async Task<UpdateCategoryNameResponse> UpdateCategoryNameAsync(UpdateCategoryNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCategoryNameHeaders headers = new UpdateCategoryNameHeaders();
            return await UpdateCategoryNameWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 变更群聊类型
         *
         * @param request UpdateConversationTypeRequest
         * @param headers UpdateConversationTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateConversationTypeResponse
         */
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

        /**
         * @summary 变更群聊类型
         *
         * @param request UpdateConversationTypeRequest
         * @param headers UpdateConversationTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateConversationTypeResponse
         */
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

        /**
         * @summary 变更群聊类型
         *
         * @param request UpdateConversationTypeRequest
         * @return UpdateConversationTypeResponse
         */
        public UpdateConversationTypeResponse UpdateConversationType(UpdateConversationTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateConversationTypeHeaders headers = new UpdateConversationTypeHeaders();
            return UpdateConversationTypeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 变更群聊类型
         *
         * @param request UpdateConversationTypeRequest
         * @return UpdateConversationTypeResponse
         */
        public async Task<UpdateConversationTypeResponse> UpdateConversationTypeAsync(UpdateConversationTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateConversationTypeHeaders headers = new UpdateConversationTypeHeaders();
            return await UpdateConversationTypeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新发送文件的检测状态
         *
         * @param request UpdateFileStatusRequest
         * @param headers UpdateFileStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFileStatusResponse
         */
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

        /**
         * @summary 更新发送文件的检测状态
         *
         * @param request UpdateFileStatusRequest
         * @param headers UpdateFileStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFileStatusResponse
         */
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

        /**
         * @summary 更新发送文件的检测状态
         *
         * @param request UpdateFileStatusRequest
         * @return UpdateFileStatusResponse
         */
        public UpdateFileStatusResponse UpdateFileStatus(UpdateFileStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFileStatusHeaders headers = new UpdateFileStatusHeaders();
            return UpdateFileStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新发送文件的检测状态
         *
         * @param request UpdateFileStatusRequest
         * @return UpdateFileStatusResponse
         */
        public async Task<UpdateFileStatusResponse> UpdateFileStatusAsync(UpdateFileStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFileStatusHeaders headers = new UpdateFileStatusHeaders();
            return await UpdateFileStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发布版本
         *
         * @param request UpdateMiniAppVersionStatusRequest
         * @param headers UpdateMiniAppVersionStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMiniAppVersionStatusResponse
         */
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

        /**
         * @summary 发布版本
         *
         * @param request UpdateMiniAppVersionStatusRequest
         * @param headers UpdateMiniAppVersionStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMiniAppVersionStatusResponse
         */
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

        /**
         * @summary 发布版本
         *
         * @param request UpdateMiniAppVersionStatusRequest
         * @return UpdateMiniAppVersionStatusResponse
         */
        public UpdateMiniAppVersionStatusResponse UpdateMiniAppVersionStatus(UpdateMiniAppVersionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMiniAppVersionStatusHeaders headers = new UpdateMiniAppVersionStatusHeaders();
            return UpdateMiniAppVersionStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发布版本
         *
         * @param request UpdateMiniAppVersionStatusRequest
         * @return UpdateMiniAppVersionStatusResponse
         */
        public async Task<UpdateMiniAppVersionStatusResponse> UpdateMiniAppVersionStatusAsync(UpdateMiniAppVersionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMiniAppVersionStatusHeaders headers = new UpdateMiniAppVersionStatusHeaders();
            return await UpdateMiniAppVersionStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 修改伙伴类型可见性
         *
         * @param request UpdatePartnerVisibilityRequest
         * @param headers UpdatePartnerVisibilityHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePartnerVisibilityResponse
         */
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

        /**
         * @summary 修改伙伴类型可见性
         *
         * @param request UpdatePartnerVisibilityRequest
         * @param headers UpdatePartnerVisibilityHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePartnerVisibilityResponse
         */
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

        /**
         * @summary 修改伙伴类型可见性
         *
         * @param request UpdatePartnerVisibilityRequest
         * @return UpdatePartnerVisibilityResponse
         */
        public UpdatePartnerVisibilityResponse UpdatePartnerVisibility(UpdatePartnerVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePartnerVisibilityHeaders headers = new UpdatePartnerVisibilityHeaders();
            return UpdatePartnerVisibilityWithOptions(request, headers, runtime);
        }

        /**
         * @summary 修改伙伴类型可见性
         *
         * @param request UpdatePartnerVisibilityRequest
         * @return UpdatePartnerVisibilityResponse
         */
        public async Task<UpdatePartnerVisibilityResponse> UpdatePartnerVisibilityAsync(UpdatePartnerVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePartnerVisibilityHeaders headers = new UpdatePartnerVisibilityHeaders();
            return await UpdatePartnerVisibilityWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 专属一线版-企业修改员工license
         *
         * @param request UpdateRealmLicenseRequest
         * @param headers UpdateRealmLicenseHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRealmLicenseResponse
         */
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

        /**
         * @summary 专属一线版-企业修改员工license
         *
         * @param request UpdateRealmLicenseRequest
         * @param headers UpdateRealmLicenseHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRealmLicenseResponse
         */
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

        /**
         * @summary 专属一线版-企业修改员工license
         *
         * @param request UpdateRealmLicenseRequest
         * @return UpdateRealmLicenseResponse
         */
        public UpdateRealmLicenseResponse UpdateRealmLicense(UpdateRealmLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRealmLicenseHeaders headers = new UpdateRealmLicenseHeaders();
            return UpdateRealmLicenseWithOptions(request, headers, runtime);
        }

        /**
         * @summary 专属一线版-企业修改员工license
         *
         * @param request UpdateRealmLicenseRequest
         * @return UpdateRealmLicenseResponse
         */
        public async Task<UpdateRealmLicenseResponse> UpdateRealmLicenseAsync(UpdateRealmLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRealmLicenseHeaders headers = new UpdateRealmLicenseHeaders();
            return await UpdateRealmLicenseWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 修改角色可见性
         *
         * @param request UpdateRoleVisibilityRequest
         * @param headers UpdateRoleVisibilityHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRoleVisibilityResponse
         */
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

        /**
         * @summary 修改角色可见性
         *
         * @param request UpdateRoleVisibilityRequest
         * @param headers UpdateRoleVisibilityHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRoleVisibilityResponse
         */
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

        /**
         * @summary 修改角色可见性
         *
         * @param request UpdateRoleVisibilityRequest
         * @return UpdateRoleVisibilityResponse
         */
        public UpdateRoleVisibilityResponse UpdateRoleVisibility(UpdateRoleVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRoleVisibilityHeaders headers = new UpdateRoleVisibilityHeaders();
            return UpdateRoleVisibilityWithOptions(request, headers, runtime);
        }

        /**
         * @summary 修改角色可见性
         *
         * @param request UpdateRoleVisibilityRequest
         * @return UpdateRoleVisibilityResponse
         */
        public async Task<UpdateRoleVisibilityResponse> UpdateRoleVisibilityAsync(UpdateRoleVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRoleVisibilityHeaders headers = new UpdateRoleVisibilityHeaders();
            return await UpdateRoleVisibilityWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新组织专属存储模式
         *
         * @param request UpdateStorageModeRequest
         * @param headers UpdateStorageModeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateStorageModeResponse
         */
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

        /**
         * @summary 更新组织专属存储模式
         *
         * @param request UpdateStorageModeRequest
         * @param headers UpdateStorageModeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateStorageModeResponse
         */
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

        /**
         * @summary 更新组织专属存储模式
         *
         * @param request UpdateStorageModeRequest
         * @return UpdateStorageModeResponse
         */
        public UpdateStorageModeResponse UpdateStorageMode(UpdateStorageModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateStorageModeHeaders headers = new UpdateStorageModeHeaders();
            return UpdateStorageModeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新组织专属存储模式
         *
         * @param request UpdateStorageModeRequest
         * @return UpdateStorageModeResponse
         */
        public async Task<UpdateStorageModeResponse> UpdateStorageModeAsync(UpdateStorageModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateStorageModeHeaders headers = new UpdateStorageModeHeaders();
            return await UpdateStorageModeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 允许三方调用该API，决定对应的语音消息管控状态
         *
         * @param request UpdateVoiceMsgCtrlStatusRequest
         * @param headers UpdateVoiceMsgCtrlStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateVoiceMsgCtrlStatusResponse
         */
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

        /**
         * @summary 允许三方调用该API，决定对应的语音消息管控状态
         *
         * @param request UpdateVoiceMsgCtrlStatusRequest
         * @param headers UpdateVoiceMsgCtrlStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateVoiceMsgCtrlStatusResponse
         */
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

        /**
         * @summary 允许三方调用该API，决定对应的语音消息管控状态
         *
         * @param request UpdateVoiceMsgCtrlStatusRequest
         * @return UpdateVoiceMsgCtrlStatusResponse
         */
        public UpdateVoiceMsgCtrlStatusResponse UpdateVoiceMsgCtrlStatus(UpdateVoiceMsgCtrlStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateVoiceMsgCtrlStatusHeaders headers = new UpdateVoiceMsgCtrlStatusHeaders();
            return UpdateVoiceMsgCtrlStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 允许三方调用该API，决定对应的语音消息管控状态
         *
         * @param request UpdateVoiceMsgCtrlStatusRequest
         * @return UpdateVoiceMsgCtrlStatusResponse
         */
        public async Task<UpdateVoiceMsgCtrlStatusResponse> UpdateVoiceMsgCtrlStatusAsync(UpdateVoiceMsgCtrlStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateVoiceMsgCtrlStatusHeaders headers = new UpdateVoiceMsgCtrlStatusHeaders();
            return await UpdateVoiceMsgCtrlStatusWithOptionsAsync(request, headers, runtime);
        }

    }
}
