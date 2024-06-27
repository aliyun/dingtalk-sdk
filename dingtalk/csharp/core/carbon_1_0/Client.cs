// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkcarbon_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkcarbon_1_0
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
         * @summary 获取用户的减碳明细
         *
         * @param request GetPersonalCarbonInfoRequest
         * @param headers GetPersonalCarbonInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPersonalCarbonInfoResponse
         */
        public GetPersonalCarbonInfoResponse GetPersonalCarbonInfoWithOptions(GetPersonalCarbonInfoRequest request, GetPersonalCarbonInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["actionType"] = request.ActionType;
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
                Action = "GetPersonalCarbonInfo",
                Version = "carbon_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/carbon/personals/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPersonalCarbonInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取用户的减碳明细
         *
         * @param request GetPersonalCarbonInfoRequest
         * @param headers GetPersonalCarbonInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPersonalCarbonInfoResponse
         */
        public async Task<GetPersonalCarbonInfoResponse> GetPersonalCarbonInfoWithOptionsAsync(GetPersonalCarbonInfoRequest request, GetPersonalCarbonInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["actionType"] = request.ActionType;
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
                Action = "GetPersonalCarbonInfo",
                Version = "carbon_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/carbon/personals/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPersonalCarbonInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户的减碳明细
         *
         * @param request GetPersonalCarbonInfoRequest
         * @return GetPersonalCarbonInfoResponse
         */
        public GetPersonalCarbonInfoResponse GetPersonalCarbonInfo(GetPersonalCarbonInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPersonalCarbonInfoHeaders headers = new GetPersonalCarbonInfoHeaders();
            return GetPersonalCarbonInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取用户的减碳明细
         *
         * @param request GetPersonalCarbonInfoRequest
         * @return GetPersonalCarbonInfoResponse
         */
        public async Task<GetPersonalCarbonInfoResponse> GetPersonalCarbonInfoAsync(GetPersonalCarbonInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPersonalCarbonInfoHeaders headers = new GetPersonalCarbonInfoHeaders();
            return await GetPersonalCarbonInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 写入阿里巴巴每日组织明细碳能量数据
         *
         * @param request WriteAlibabaOrgCarbonRequest
         * @param headers WriteAlibabaOrgCarbonHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return WriteAlibabaOrgCarbonResponse
         */
        public WriteAlibabaOrgCarbonResponse WriteAlibabaOrgCarbonWithOptions(WriteAlibabaOrgCarbonRequest request, WriteAlibabaOrgCarbonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgDetailsList))
            {
                body["orgDetailsList"] = request.OrgDetailsList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WriteAlibabaOrgCarbon",
                Version = "carbon_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/carbon/alibabaOrgDetails/write",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteAlibabaOrgCarbonResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 写入阿里巴巴每日组织明细碳能量数据
         *
         * @param request WriteAlibabaOrgCarbonRequest
         * @param headers WriteAlibabaOrgCarbonHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return WriteAlibabaOrgCarbonResponse
         */
        public async Task<WriteAlibabaOrgCarbonResponse> WriteAlibabaOrgCarbonWithOptionsAsync(WriteAlibabaOrgCarbonRequest request, WriteAlibabaOrgCarbonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgDetailsList))
            {
                body["orgDetailsList"] = request.OrgDetailsList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WriteAlibabaOrgCarbon",
                Version = "carbon_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/carbon/alibabaOrgDetails/write",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteAlibabaOrgCarbonResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 写入阿里巴巴每日组织明细碳能量数据
         *
         * @param request WriteAlibabaOrgCarbonRequest
         * @return WriteAlibabaOrgCarbonResponse
         */
        public WriteAlibabaOrgCarbonResponse WriteAlibabaOrgCarbon(WriteAlibabaOrgCarbonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteAlibabaOrgCarbonHeaders headers = new WriteAlibabaOrgCarbonHeaders();
            return WriteAlibabaOrgCarbonWithOptions(request, headers, runtime);
        }

        /**
         * @summary 写入阿里巴巴每日组织明细碳能量数据
         *
         * @param request WriteAlibabaOrgCarbonRequest
         * @return WriteAlibabaOrgCarbonResponse
         */
        public async Task<WriteAlibabaOrgCarbonResponse> WriteAlibabaOrgCarbonAsync(WriteAlibabaOrgCarbonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteAlibabaOrgCarbonHeaders headers = new WriteAlibabaOrgCarbonHeaders();
            return await WriteAlibabaOrgCarbonWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 写入阿里巴巴每日用户碳能量数据
         *
         * @param request WriteAlibabaUserCarbonRequest
         * @param headers WriteAlibabaUserCarbonHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return WriteAlibabaUserCarbonResponse
         */
        public WriteAlibabaUserCarbonResponse WriteAlibabaUserCarbonWithOptions(WriteAlibabaUserCarbonRequest request, WriteAlibabaUserCarbonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDetailsList))
            {
                body["userDetailsList"] = request.UserDetailsList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WriteAlibabaUserCarbon",
                Version = "carbon_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/carbon/alibabaUserDetails/write",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteAlibabaUserCarbonResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 写入阿里巴巴每日用户碳能量数据
         *
         * @param request WriteAlibabaUserCarbonRequest
         * @param headers WriteAlibabaUserCarbonHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return WriteAlibabaUserCarbonResponse
         */
        public async Task<WriteAlibabaUserCarbonResponse> WriteAlibabaUserCarbonWithOptionsAsync(WriteAlibabaUserCarbonRequest request, WriteAlibabaUserCarbonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDetailsList))
            {
                body["userDetailsList"] = request.UserDetailsList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WriteAlibabaUserCarbon",
                Version = "carbon_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/carbon/alibabaUserDetails/write",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteAlibabaUserCarbonResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 写入阿里巴巴每日用户碳能量数据
         *
         * @param request WriteAlibabaUserCarbonRequest
         * @return WriteAlibabaUserCarbonResponse
         */
        public WriteAlibabaUserCarbonResponse WriteAlibabaUserCarbon(WriteAlibabaUserCarbonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteAlibabaUserCarbonHeaders headers = new WriteAlibabaUserCarbonHeaders();
            return WriteAlibabaUserCarbonWithOptions(request, headers, runtime);
        }

        /**
         * @summary 写入阿里巴巴每日用户碳能量数据
         *
         * @param request WriteAlibabaUserCarbonRequest
         * @return WriteAlibabaUserCarbonResponse
         */
        public async Task<WriteAlibabaUserCarbonResponse> WriteAlibabaUserCarbonAsync(WriteAlibabaUserCarbonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteAlibabaUserCarbonHeaders headers = new WriteAlibabaUserCarbonHeaders();
            return await WriteAlibabaUserCarbonWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary ISV记录数据传输当前状态
         *
         * @param request WriteIsvStateRequest
         * @param headers WriteIsvStateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return WriteIsvStateResponse
         */
        public WriteIsvStateResponse WriteIsvStateWithOptions(WriteIsvStateRequest request, WriteIsvStateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isvName"] = request.IsvName;
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
                Action = "WriteIsvState",
                Version = "carbon_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/carbon/datas/states/write",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteIsvStateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary ISV记录数据传输当前状态
         *
         * @param request WriteIsvStateRequest
         * @param headers WriteIsvStateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return WriteIsvStateResponse
         */
        public async Task<WriteIsvStateResponse> WriteIsvStateWithOptionsAsync(WriteIsvStateRequest request, WriteIsvStateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvName))
            {
                query["isvName"] = request.IsvName;
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
                Action = "WriteIsvState",
                Version = "carbon_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/carbon/datas/states/write",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteIsvStateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary ISV记录数据传输当前状态
         *
         * @param request WriteIsvStateRequest
         * @return WriteIsvStateResponse
         */
        public WriteIsvStateResponse WriteIsvState(WriteIsvStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteIsvStateHeaders headers = new WriteIsvStateHeaders();
            return WriteIsvStateWithOptions(request, headers, runtime);
        }

        /**
         * @summary ISV记录数据传输当前状态
         *
         * @param request WriteIsvStateRequest
         * @return WriteIsvStateResponse
         */
        public async Task<WriteIsvStateResponse> WriteIsvStateAsync(WriteIsvStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteIsvStateHeaders headers = new WriteIsvStateHeaders();
            return await WriteIsvStateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 写入isv每日组织明细碳能量数据
         *
         * @param request WriteOrgCarbonRequest
         * @param headers WriteOrgCarbonHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return WriteOrgCarbonResponse
         */
        public WriteOrgCarbonResponse WriteOrgCarbonWithOptions(WriteOrgCarbonRequest request, WriteOrgCarbonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgDetailsList))
            {
                body["orgDetailsList"] = request.OrgDetailsList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WriteOrgCarbon",
                Version = "carbon_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/carbon/orgDetails/write",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteOrgCarbonResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 写入isv每日组织明细碳能量数据
         *
         * @param request WriteOrgCarbonRequest
         * @param headers WriteOrgCarbonHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return WriteOrgCarbonResponse
         */
        public async Task<WriteOrgCarbonResponse> WriteOrgCarbonWithOptionsAsync(WriteOrgCarbonRequest request, WriteOrgCarbonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgDetailsList))
            {
                body["orgDetailsList"] = request.OrgDetailsList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WriteOrgCarbon",
                Version = "carbon_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/carbon/orgDetails/write",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteOrgCarbonResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 写入isv每日组织明细碳能量数据
         *
         * @param request WriteOrgCarbonRequest
         * @return WriteOrgCarbonResponse
         */
        public WriteOrgCarbonResponse WriteOrgCarbon(WriteOrgCarbonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteOrgCarbonHeaders headers = new WriteOrgCarbonHeaders();
            return WriteOrgCarbonWithOptions(request, headers, runtime);
        }

        /**
         * @summary 写入isv每日组织明细碳能量数据
         *
         * @param request WriteOrgCarbonRequest
         * @return WriteOrgCarbonResponse
         */
        public async Task<WriteOrgCarbonResponse> WriteOrgCarbonAsync(WriteOrgCarbonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteOrgCarbonHeaders headers = new WriteOrgCarbonHeaders();
            return await WriteOrgCarbonWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 写入isv每日用户明细碳能量数据
         *
         * @param request WriteUserCarbonRequest
         * @param headers WriteUserCarbonHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return WriteUserCarbonResponse
         */
        public WriteUserCarbonResponse WriteUserCarbonWithOptions(WriteUserCarbonRequest request, WriteUserCarbonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDetailsList))
            {
                body["userDetailsList"] = request.UserDetailsList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WriteUserCarbon",
                Version = "carbon_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/carbon/userDetails/write",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteUserCarbonResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 写入isv每日用户明细碳能量数据
         *
         * @param request WriteUserCarbonRequest
         * @param headers WriteUserCarbonHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return WriteUserCarbonResponse
         */
        public async Task<WriteUserCarbonResponse> WriteUserCarbonWithOptionsAsync(WriteUserCarbonRequest request, WriteUserCarbonHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDetailsList))
            {
                body["userDetailsList"] = request.UserDetailsList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WriteUserCarbon",
                Version = "carbon_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/carbon/userDetails/write",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteUserCarbonResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 写入isv每日用户明细碳能量数据
         *
         * @param request WriteUserCarbonRequest
         * @return WriteUserCarbonResponse
         */
        public WriteUserCarbonResponse WriteUserCarbon(WriteUserCarbonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteUserCarbonHeaders headers = new WriteUserCarbonHeaders();
            return WriteUserCarbonWithOptions(request, headers, runtime);
        }

        /**
         * @summary 写入isv每日用户明细碳能量数据
         *
         * @param request WriteUserCarbonRequest
         * @return WriteUserCarbonResponse
         */
        public async Task<WriteUserCarbonResponse> WriteUserCarbonAsync(WriteUserCarbonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteUserCarbonHeaders headers = new WriteUserCarbonHeaders();
            return await WriteUserCarbonWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 写入isv能耗每日用户明细碳能量数据
         *
         * @param request WriteUserCarbonEnergyRequest
         * @param headers WriteUserCarbonEnergyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return WriteUserCarbonEnergyResponse
         */
        public WriteUserCarbonEnergyResponse WriteUserCarbonEnergyWithOptions(WriteUserCarbonEnergyRequest request, WriteUserCarbonEnergyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDetailsList))
            {
                body["userDetailsList"] = request.UserDetailsList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WriteUserCarbonEnergy",
                Version = "carbon_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/carbon/userDetails/energies/write",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteUserCarbonEnergyResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 写入isv能耗每日用户明细碳能量数据
         *
         * @param request WriteUserCarbonEnergyRequest
         * @param headers WriteUserCarbonEnergyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return WriteUserCarbonEnergyResponse
         */
        public async Task<WriteUserCarbonEnergyResponse> WriteUserCarbonEnergyWithOptionsAsync(WriteUserCarbonEnergyRequest request, WriteUserCarbonEnergyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDetailsList))
            {
                body["userDetailsList"] = request.UserDetailsList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WriteUserCarbonEnergy",
                Version = "carbon_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/carbon/userDetails/energies/write",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteUserCarbonEnergyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 写入isv能耗每日用户明细碳能量数据
         *
         * @param request WriteUserCarbonEnergyRequest
         * @return WriteUserCarbonEnergyResponse
         */
        public WriteUserCarbonEnergyResponse WriteUserCarbonEnergy(WriteUserCarbonEnergyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteUserCarbonEnergyHeaders headers = new WriteUserCarbonEnergyHeaders();
            return WriteUserCarbonEnergyWithOptions(request, headers, runtime);
        }

        /**
         * @summary 写入isv能耗每日用户明细碳能量数据
         *
         * @param request WriteUserCarbonEnergyRequest
         * @return WriteUserCarbonEnergyResponse
         */
        public async Task<WriteUserCarbonEnergyResponse> WriteUserCarbonEnergyAsync(WriteUserCarbonEnergyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteUserCarbonEnergyHeaders headers = new WriteUserCarbonEnergyHeaders();
            return await WriteUserCarbonEnergyWithOptionsAsync(request, headers, runtime);
        }

    }
}
