// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkyida_2_0.Models;

namespace AlibabaCloud.SDK.Dingtalkyida_2_0
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
         * @summary 新增或更新表单实例
         *
         * @param request CreateOrUpdateFormDataRequest
         * @param headers CreateOrUpdateFormDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOrUpdateFormDataResponse
         */
        public CreateOrUpdateFormDataResponse CreateOrUpdateFormDataWithOptions(CreateOrUpdateFormDataRequest request, CreateOrUpdateFormDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataJson))
            {
                body["formDataJson"] = request.FormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoExecuteExpression))
            {
                body["noExecuteExpression"] = request.NoExecuteExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchCondition))
            {
                body["searchCondition"] = request.SearchCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
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
                Action = "CreateOrUpdateFormData",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/insertOrUpdate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrUpdateFormDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 新增或更新表单实例
         *
         * @param request CreateOrUpdateFormDataRequest
         * @param headers CreateOrUpdateFormDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOrUpdateFormDataResponse
         */
        public async Task<CreateOrUpdateFormDataResponse> CreateOrUpdateFormDataWithOptionsAsync(CreateOrUpdateFormDataRequest request, CreateOrUpdateFormDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataJson))
            {
                body["formDataJson"] = request.FormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoExecuteExpression))
            {
                body["noExecuteExpression"] = request.NoExecuteExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchCondition))
            {
                body["searchCondition"] = request.SearchCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
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
                Action = "CreateOrUpdateFormData",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/insertOrUpdate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrUpdateFormDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 新增或更新表单实例
         *
         * @param request CreateOrUpdateFormDataRequest
         * @return CreateOrUpdateFormDataResponse
         */
        public CreateOrUpdateFormDataResponse CreateOrUpdateFormData(CreateOrUpdateFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOrUpdateFormDataHeaders headers = new CreateOrUpdateFormDataHeaders();
            return CreateOrUpdateFormDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新增或更新表单实例
         *
         * @param request CreateOrUpdateFormDataRequest
         * @return CreateOrUpdateFormDataResponse
         */
        public async Task<CreateOrUpdateFormDataResponse> CreateOrUpdateFormDataAsync(CreateOrUpdateFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOrUpdateFormDataHeaders headers = new CreateOrUpdateFormDataHeaders();
            return await CreateOrUpdateFormDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取表单组件别名列表
         *
         * @param request GetFormComponentAliasListRequest
         * @param headers GetFormComponentAliasListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFormComponentAliasListResponse
         */
        public GetFormComponentAliasListResponse GetFormComponentAliasListWithOptions(string appType, string formUuid, GetFormComponentAliasListRequest request, GetFormComponentAliasListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFormComponentAliasList",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/component/alias/" + appType + "/" + formUuid,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFormComponentAliasListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取表单组件别名列表
         *
         * @param request GetFormComponentAliasListRequest
         * @param headers GetFormComponentAliasListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFormComponentAliasListResponse
         */
        public async Task<GetFormComponentAliasListResponse> GetFormComponentAliasListWithOptionsAsync(string appType, string formUuid, GetFormComponentAliasListRequest request, GetFormComponentAliasListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFormComponentAliasList",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/component/alias/" + appType + "/" + formUuid,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFormComponentAliasListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取表单组件别名列表
         *
         * @param request GetFormComponentAliasListRequest
         * @return GetFormComponentAliasListResponse
         */
        public GetFormComponentAliasListResponse GetFormComponentAliasList(string appType, string formUuid, GetFormComponentAliasListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFormComponentAliasListHeaders headers = new GetFormComponentAliasListHeaders();
            return GetFormComponentAliasListWithOptions(appType, formUuid, request, headers, runtime);
        }

        /**
         * @summary 获取表单组件别名列表
         *
         * @param request GetFormComponentAliasListRequest
         * @return GetFormComponentAliasListResponse
         */
        public async Task<GetFormComponentAliasListResponse> GetFormComponentAliasListAsync(string appType, string formUuid, GetFormComponentAliasListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFormComponentAliasListHeaders headers = new GetFormComponentAliasListHeaders();
            return await GetFormComponentAliasListWithOptionsAsync(appType, formUuid, request, headers, runtime);
        }

        /**
         * @summary 根据表单 ID 查询实例详情
         *
         * @param request GetFormDataByIDRequest
         * @param headers GetFormDataByIDHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFormDataByIDResponse
         */
        public GetFormDataByIDResponse GetFormDataByIDWithOptions(string id, GetFormDataByIDRequest request, GetFormDataByIDHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                query["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                query["useAlias"] = request.UseAlias;
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
                Action = "GetFormDataByID",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/" + id,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFormDataByIDResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据表单 ID 查询实例详情
         *
         * @param request GetFormDataByIDRequest
         * @param headers GetFormDataByIDHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFormDataByIDResponse
         */
        public async Task<GetFormDataByIDResponse> GetFormDataByIDWithOptionsAsync(string id, GetFormDataByIDRequest request, GetFormDataByIDHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                query["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                query["useAlias"] = request.UseAlias;
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
                Action = "GetFormDataByID",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/" + id,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFormDataByIDResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据表单 ID 查询实例详情
         *
         * @param request GetFormDataByIDRequest
         * @return GetFormDataByIDResponse
         */
        public GetFormDataByIDResponse GetFormDataByID(string id, GetFormDataByIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFormDataByIDHeaders headers = new GetFormDataByIDHeaders();
            return GetFormDataByIDWithOptions(id, request, headers, runtime);
        }

        /**
         * @summary 根据表单 ID 查询实例详情
         *
         * @param request GetFormDataByIDRequest
         * @return GetFormDataByIDResponse
         */
        public async Task<GetFormDataByIDResponse> GetFormDataByIDAsync(string id, GetFormDataByIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFormDataByIDHeaders headers = new GetFormDataByIDHeaders();
            return await GetFormDataByIDWithOptionsAsync(id, request, headers, runtime);
        }

        /**
         * @summary 根据实例 ID 获取流程实例详情
         *
         * @param request GetInstanceByIdRequest
         * @param headers GetInstanceByIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceByIdResponse
         */
        public GetInstanceByIdResponse GetInstanceByIdWithOptions(string id, GetInstanceByIdRequest request, GetInstanceByIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                query["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                query["useAlias"] = request.UseAlias;
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
                Action = "GetInstanceById",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/processes/instancesInfos/" + id,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceByIdResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据实例 ID 获取流程实例详情
         *
         * @param request GetInstanceByIdRequest
         * @param headers GetInstanceByIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceByIdResponse
         */
        public async Task<GetInstanceByIdResponse> GetInstanceByIdWithOptionsAsync(string id, GetInstanceByIdRequest request, GetInstanceByIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                query["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                query["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                query["useAlias"] = request.UseAlias;
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
                Action = "GetInstanceById",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/processes/instancesInfos/" + id,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceByIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据实例 ID 获取流程实例详情
         *
         * @param request GetInstanceByIdRequest
         * @return GetInstanceByIdResponse
         */
        public GetInstanceByIdResponse GetInstanceById(string id, GetInstanceByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInstanceByIdHeaders headers = new GetInstanceByIdHeaders();
            return GetInstanceByIdWithOptions(id, request, headers, runtime);
        }

        /**
         * @summary 根据实例 ID 获取流程实例详情
         *
         * @param request GetInstanceByIdRequest
         * @return GetInstanceByIdResponse
         */
        public async Task<GetInstanceByIdResponse> GetInstanceByIdAsync(string id, GetInstanceByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInstanceByIdHeaders headers = new GetInstanceByIdHeaders();
            return await GetInstanceByIdWithOptionsAsync(id, request, headers, runtime);
        }

        /**
         * @summary 根据条件搜索流程实例 ID
         *
         * @param request GetInstanceIdListRequest
         * @param headers GetInstanceIdListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceIdListResponse
         */
        public GetInstanceIdListResponse GetInstanceIdListWithOptions(GetInstanceIdListRequest request, GetInstanceIdListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedResult))
            {
                body["approvedResult"] = request.ApprovedResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                body["instanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFieldJson))
            {
                body["searchFieldJson"] = request.SearchFieldJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceIdList",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/processes/instanceIds",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceIdListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据条件搜索流程实例 ID
         *
         * @param request GetInstanceIdListRequest
         * @param headers GetInstanceIdListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceIdListResponse
         */
        public async Task<GetInstanceIdListResponse> GetInstanceIdListWithOptionsAsync(GetInstanceIdListRequest request, GetInstanceIdListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedResult))
            {
                body["approvedResult"] = request.ApprovedResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                body["instanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFieldJson))
            {
                body["searchFieldJson"] = request.SearchFieldJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceIdList",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/processes/instanceIds",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceIdListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据条件搜索流程实例 ID
         *
         * @param request GetInstanceIdListRequest
         * @return GetInstanceIdListResponse
         */
        public GetInstanceIdListResponse GetInstanceIdList(GetInstanceIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInstanceIdListHeaders headers = new GetInstanceIdListHeaders();
            return GetInstanceIdListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据条件搜索流程实例 ID
         *
         * @param request GetInstanceIdListRequest
         * @return GetInstanceIdListResponse
         */
        public async Task<GetInstanceIdListResponse> GetInstanceIdListAsync(GetInstanceIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInstanceIdListHeaders headers = new GetInstanceIdListHeaders();
            return await GetInstanceIdListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据搜索条件获取流程表单实例详情
         *
         * @param request GetInstancesRequest
         * @param headers GetInstancesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstancesResponse
         */
        public GetInstancesResponse GetInstancesWithOptions(GetInstancesRequest request, GetInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedResult))
            {
                body["approvedResult"] = request.ApprovedResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                body["instanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderConfigJson))
            {
                body["orderConfigJson"] = request.OrderConfigJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFieldJson))
            {
                body["searchFieldJson"] = request.SearchFieldJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstances",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/processes/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstancesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据搜索条件获取流程表单实例详情
         *
         * @param request GetInstancesRequest
         * @param headers GetInstancesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstancesResponse
         */
        public async Task<GetInstancesResponse> GetInstancesWithOptionsAsync(GetInstancesRequest request, GetInstancesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedResult))
            {
                body["approvedResult"] = request.ApprovedResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                body["instanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderConfigJson))
            {
                body["orderConfigJson"] = request.OrderConfigJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFieldJson))
            {
                body["searchFieldJson"] = request.SearchFieldJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstances",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/processes/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstancesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据搜索条件获取流程表单实例详情
         *
         * @param request GetInstancesRequest
         * @return GetInstancesResponse
         */
        public GetInstancesResponse GetInstances(GetInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInstancesHeaders headers = new GetInstancesHeaders();
            return GetInstancesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据搜索条件获取流程表单实例详情
         *
         * @param request GetInstancesRequest
         * @return GetInstancesResponse
         */
        public async Task<GetInstancesResponse> GetInstancesAsync(GetInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInstancesHeaders headers = new GetInstancesHeaders();
            return await GetInstancesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 新增表单实例
         *
         * @param request SaveFormDataRequest
         * @param headers SaveFormDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveFormDataResponse
         */
        public SaveFormDataResponse SaveFormDataWithOptions(SaveFormDataRequest request, SaveFormDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataJson))
            {
                body["formDataJson"] = request.FormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
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
                Action = "SaveFormData",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveFormDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 新增表单实例
         *
         * @param request SaveFormDataRequest
         * @param headers SaveFormDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveFormDataResponse
         */
        public async Task<SaveFormDataResponse> SaveFormDataWithOptionsAsync(SaveFormDataRequest request, SaveFormDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataJson))
            {
                body["formDataJson"] = request.FormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
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
                Action = "SaveFormData",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveFormDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 新增表单实例
         *
         * @param request SaveFormDataRequest
         * @return SaveFormDataResponse
         */
        public SaveFormDataResponse SaveFormData(SaveFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveFormDataHeaders headers = new SaveFormDataHeaders();
            return SaveFormDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新增表单实例
         *
         * @param request SaveFormDataRequest
         * @return SaveFormDataResponse
         */
        public async Task<SaveFormDataResponse> SaveFormDataAsync(SaveFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveFormDataHeaders headers = new SaveFormDataHeaders();
            return await SaveFormDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据条件搜索表单实例 ID 列表
         *
         * @param request SearchFormDataIdListRequest
         * @param headers SearchFormDataIdListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchFormDataIdListResponse
         */
        public SearchFormDataIdListResponse SearchFormDataIdListWithOptions(string appType, string formUuid, SearchFormDataIdListRequest request, SearchFormDataIdListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFieldJson))
            {
                body["searchFieldJson"] = request.SearchFieldJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchFormDataIdList",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/ids/" + appType + "/" + formUuid,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchFormDataIdListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据条件搜索表单实例 ID 列表
         *
         * @param request SearchFormDataIdListRequest
         * @param headers SearchFormDataIdListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchFormDataIdListResponse
         */
        public async Task<SearchFormDataIdListResponse> SearchFormDataIdListWithOptionsAsync(string appType, string formUuid, SearchFormDataIdListRequest request, SearchFormDataIdListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFieldJson))
            {
                body["searchFieldJson"] = request.SearchFieldJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchFormDataIdList",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/ids/" + appType + "/" + formUuid,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchFormDataIdListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据条件搜索表单实例 ID 列表
         *
         * @param request SearchFormDataIdListRequest
         * @return SearchFormDataIdListResponse
         */
        public SearchFormDataIdListResponse SearchFormDataIdList(string appType, string formUuid, SearchFormDataIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchFormDataIdListHeaders headers = new SearchFormDataIdListHeaders();
            return SearchFormDataIdListWithOptions(appType, formUuid, request, headers, runtime);
        }

        /**
         * @summary 根据条件搜索表单实例 ID 列表
         *
         * @param request SearchFormDataIdListRequest
         * @return SearchFormDataIdListResponse
         */
        public async Task<SearchFormDataIdListResponse> SearchFormDataIdListAsync(string appType, string formUuid, SearchFormDataIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchFormDataIdListHeaders headers = new SearchFormDataIdListHeaders();
            return await SearchFormDataIdListWithOptionsAsync(appType, formUuid, request, headers, runtime);
        }

        /**
         * @summary 通过高级检索条件查询表单实例
         *
         * @param request SearchFormDataSecondGenerationRequest
         * @param headers SearchFormDataSecondGenerationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchFormDataSecondGenerationResponse
         */
        public SearchFormDataSecondGenerationResponse SearchFormDataSecondGenerationWithOptions(SearchFormDataSecondGenerationRequest request, SearchFormDataSecondGenerationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderConfigJson))
            {
                body["orderConfigJson"] = request.OrderConfigJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchCondition))
            {
                body["searchCondition"] = request.SearchCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
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
                Action = "SearchFormDataSecondGeneration",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/advances/queryAll",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchFormDataSecondGenerationResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 通过高级检索条件查询表单实例
         *
         * @param request SearchFormDataSecondGenerationRequest
         * @param headers SearchFormDataSecondGenerationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchFormDataSecondGenerationResponse
         */
        public async Task<SearchFormDataSecondGenerationResponse> SearchFormDataSecondGenerationWithOptionsAsync(SearchFormDataSecondGenerationRequest request, SearchFormDataSecondGenerationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderConfigJson))
            {
                body["orderConfigJson"] = request.OrderConfigJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchCondition))
            {
                body["searchCondition"] = request.SearchCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
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
                Action = "SearchFormDataSecondGeneration",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/advances/queryAll",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchFormDataSecondGenerationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 通过高级检索条件查询表单实例
         *
         * @param request SearchFormDataSecondGenerationRequest
         * @return SearchFormDataSecondGenerationResponse
         */
        public SearchFormDataSecondGenerationResponse SearchFormDataSecondGeneration(SearchFormDataSecondGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchFormDataSecondGenerationHeaders headers = new SearchFormDataSecondGenerationHeaders();
            return SearchFormDataSecondGenerationWithOptions(request, headers, runtime);
        }

        /**
         * @summary 通过高级检索条件查询表单实例
         *
         * @param request SearchFormDataSecondGenerationRequest
         * @return SearchFormDataSecondGenerationResponse
         */
        public async Task<SearchFormDataSecondGenerationResponse> SearchFormDataSecondGenerationAsync(SearchFormDataSecondGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchFormDataSecondGenerationHeaders headers = new SearchFormDataSecondGenerationHeaders();
            return await SearchFormDataSecondGenerationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据条件搜索表单实例详情列表
         *
         * @param request SearchFormDatasRequest
         * @param headers SearchFormDatasHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchFormDatasResponse
         */
        public SearchFormDatasResponse SearchFormDatasWithOptions(SearchFormDatasRequest request, SearchFormDatasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["currentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicOrder))
            {
                body["dynamicOrder"] = request.DynamicOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFieldJson))
            {
                body["searchFieldJson"] = request.SearchFieldJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
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
                Action = "SearchFormDatas",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchFormDatasResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据条件搜索表单实例详情列表
         *
         * @param request SearchFormDatasRequest
         * @param headers SearchFormDatasHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchFormDatasResponse
         */
        public async Task<SearchFormDatasResponse> SearchFormDatasWithOptionsAsync(SearchFormDatasRequest request, SearchFormDatasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromTimeGMT))
            {
                body["createFromTimeGMT"] = request.CreateFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateToTimeGMT))
            {
                body["createToTimeGMT"] = request.CreateToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["currentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicOrder))
            {
                body["dynamicOrder"] = request.DynamicOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedFromTimeGMT))
            {
                body["modifiedFromTimeGMT"] = request.ModifiedFromTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedToTimeGMT))
            {
                body["modifiedToTimeGMT"] = request.ModifiedToTimeGMT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginatorId))
            {
                body["originatorId"] = request.OriginatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFieldJson))
            {
                body["searchFieldJson"] = request.SearchFieldJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
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
                Action = "SearchFormDatas",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchFormDatasResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据条件搜索表单实例详情列表
         *
         * @param request SearchFormDatasRequest
         * @return SearchFormDatasResponse
         */
        public SearchFormDatasResponse SearchFormDatas(SearchFormDatasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchFormDatasHeaders headers = new SearchFormDatasHeaders();
            return SearchFormDatasWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据条件搜索表单实例详情列表
         *
         * @param request SearchFormDatasRequest
         * @return SearchFormDatasResponse
         */
        public async Task<SearchFormDatasResponse> SearchFormDatasAsync(SearchFormDatasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchFormDatasHeaders headers = new SearchFormDatasHeaders();
            return await SearchFormDatasWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发起新的流程实例
         *
         * @param request StartInstanceRequest
         * @param headers StartInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartInstanceResponse
         */
        public StartInstanceResponse StartInstanceWithOptions(StartInstanceRequest request, StartInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                body["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataJson))
            {
                body["formDataJson"] = request.FormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessData))
            {
                body["processData"] = request.ProcessData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
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
                Action = "StartInstance",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/processes/instances/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartInstanceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发起新的流程实例
         *
         * @param request StartInstanceRequest
         * @param headers StartInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartInstanceResponse
         */
        public async Task<StartInstanceResponse> StartInstanceWithOptionsAsync(StartInstanceRequest request, StartInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                body["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataJson))
            {
                body["formDataJson"] = request.FormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCode))
            {
                body["processCode"] = request.ProcessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessData))
            {
                body["processData"] = request.ProcessData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
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
                Action = "StartInstance",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/processes/instances/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发起新的流程实例
         *
         * @param request StartInstanceRequest
         * @return StartInstanceResponse
         */
        public StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartInstanceHeaders headers = new StartInstanceHeaders();
            return StartInstanceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发起新的流程实例
         *
         * @param request StartInstanceRequest
         * @return StartInstanceResponse
         */
        public async Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartInstanceHeaders headers = new StartInstanceHeaders();
            return await StartInstanceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新表单实例
         *
         * @param request UpdateFormDataRequest
         * @param headers UpdateFormDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFormDataResponse
         */
        public UpdateFormDataResponse UpdateFormDataWithOptions(UpdateFormDataRequest request, UpdateFormDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceId))
            {
                body["formInstanceId"] = request.FormInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateFormDataJson))
            {
                body["updateFormDataJson"] = request.UpdateFormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseLatestVersion))
            {
                body["useLatestVersion"] = request.UseLatestVersion;
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
                Action = "UpdateFormData",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateFormDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新表单实例
         *
         * @param request UpdateFormDataRequest
         * @param headers UpdateFormDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFormDataResponse
         */
        public async Task<UpdateFormDataResponse> UpdateFormDataWithOptionsAsync(UpdateFormDataRequest request, UpdateFormDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormInstanceId))
            {
                body["formInstanceId"] = request.FormInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormUuid))
            {
                body["formUuid"] = request.FormUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemToken))
            {
                body["systemToken"] = request.SystemToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateFormDataJson))
            {
                body["updateFormDataJson"] = request.UpdateFormDataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAlias))
            {
                body["useAlias"] = request.UseAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseLatestVersion))
            {
                body["useLatestVersion"] = request.UseLatestVersion;
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
                Action = "UpdateFormData",
                Version = "yida_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/yida/forms/instances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateFormDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新表单实例
         *
         * @param request UpdateFormDataRequest
         * @return UpdateFormDataResponse
         */
        public UpdateFormDataResponse UpdateFormData(UpdateFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFormDataHeaders headers = new UpdateFormDataHeaders();
            return UpdateFormDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新表单实例
         *
         * @param request UpdateFormDataRequest
         * @return UpdateFormDataResponse
         */
        public async Task<UpdateFormDataResponse> UpdateFormDataAsync(UpdateFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFormDataHeaders headers = new UpdateFormDataHeaders();
            return await UpdateFormDataWithOptionsAsync(request, headers, runtime);
        }

    }
}
