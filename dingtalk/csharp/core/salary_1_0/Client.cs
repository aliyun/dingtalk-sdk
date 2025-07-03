// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalksalary_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalksalary_1_0
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
        /// <para>小微薪酬获取薪资记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSalaryCalculationRequest
        /// </param>
        /// <param name="headers">
        /// GetSalaryCalculationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSalaryCalculationResponse
        /// </returns>
        public GetSalaryCalculationResponse GetSalaryCalculationWithOptions(GetSalaryCalculationRequest request, GetSalaryCalculationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SalaryGroupId))
            {
                query["salaryGroupId"] = request.SalaryGroupId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetSalaryCalculation",
                Version = "salary_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/salary/calculation",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSalaryCalculationResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSalaryCalculationRequest
        /// </param>
        /// <param name="headers">
        /// GetSalaryCalculationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSalaryCalculationResponse
        /// </returns>
        public async Task<GetSalaryCalculationResponse> GetSalaryCalculationWithOptionsAsync(GetSalaryCalculationRequest request, GetSalaryCalculationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SalaryGroupId))
            {
                query["salaryGroupId"] = request.SalaryGroupId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetSalaryCalculation",
                Version = "salary_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/salary/calculation",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSalaryCalculationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSalaryCalculationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSalaryCalculationResponse
        /// </returns>
        public GetSalaryCalculationResponse GetSalaryCalculation(GetSalaryCalculationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSalaryCalculationHeaders headers = new GetSalaryCalculationHeaders();
            return GetSalaryCalculationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSalaryCalculationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSalaryCalculationResponse
        /// </returns>
        public async Task<GetSalaryCalculationResponse> GetSalaryCalculationAsync(GetSalaryCalculationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSalaryCalculationHeaders headers = new GetSalaryCalculationHeaders();
            return await GetSalaryCalculationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资组</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSalaryGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSalaryGroupResponse
        /// </returns>
        public GetSalaryGroupResponse GetSalaryGroupWithOptions(GetSalaryGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSalaryGroup",
                Version = "salary_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/salary/group",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSalaryGroupResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资组</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSalaryGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSalaryGroupResponse
        /// </returns>
        public async Task<GetSalaryGroupResponse> GetSalaryGroupWithOptionsAsync(GetSalaryGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSalaryGroup",
                Version = "salary_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/salary/group",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSalaryGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资组</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSalaryGroupResponse
        /// </returns>
        public GetSalaryGroupResponse GetSalaryGroup()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSalaryGroupHeaders headers = new GetSalaryGroupHeaders();
            return GetSalaryGroupWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资组</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSalaryGroupResponse
        /// </returns>
        public async Task<GetSalaryGroupResponse> GetSalaryGroupAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSalaryGroupHeaders headers = new GetSalaryGroupHeaders();
            return await GetSalaryGroupWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSalaryItemRequest
        /// </param>
        /// <param name="headers">
        /// GetSalaryItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSalaryItemResponse
        /// </returns>
        public GetSalaryItemResponse GetSalaryItemWithOptions(GetSalaryItemRequest request, GetSalaryItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SalaryItemGroupId))
            {
                query["salaryItemGroupId"] = request.SalaryItemGroupId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetSalaryItem",
                Version = "salary_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/salary/item",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSalaryItemResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSalaryItemRequest
        /// </param>
        /// <param name="headers">
        /// GetSalaryItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSalaryItemResponse
        /// </returns>
        public async Task<GetSalaryItemResponse> GetSalaryItemWithOptionsAsync(GetSalaryItemRequest request, GetSalaryItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SalaryItemGroupId))
            {
                query["salaryItemGroupId"] = request.SalaryItemGroupId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetSalaryItem",
                Version = "salary_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/salary/item",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSalaryItemResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSalaryItemRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSalaryItemResponse
        /// </returns>
        public GetSalaryItemResponse GetSalaryItem(GetSalaryItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSalaryItemHeaders headers = new GetSalaryItemHeaders();
            return GetSalaryItemWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSalaryItemRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSalaryItemResponse
        /// </returns>
        public async Task<GetSalaryItemResponse> GetSalaryItemAsync(GetSalaryItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSalaryItemHeaders headers = new GetSalaryItemHeaders();
            return await GetSalaryItemWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资项目大类</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSalaryItemGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSalaryItemGroupResponse
        /// </returns>
        public GetSalaryItemGroupResponse GetSalaryItemGroupWithOptions(GetSalaryItemGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSalaryItemGroup",
                Version = "salary_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/salary/itemGroup",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSalaryItemGroupResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资项目大类</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSalaryItemGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSalaryItemGroupResponse
        /// </returns>
        public async Task<GetSalaryItemGroupResponse> GetSalaryItemGroupWithOptionsAsync(GetSalaryItemGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSalaryItemGroup",
                Version = "salary_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/salary/itemGroup",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSalaryItemGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资项目大类</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSalaryItemGroupResponse
        /// </returns>
        public GetSalaryItemGroupResponse GetSalaryItemGroup()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSalaryItemGroupHeaders headers = new GetSalaryItemGroupHeaders();
            return GetSalaryItemGroupWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资项目大类</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSalaryItemGroupResponse
        /// </returns>
        public async Task<GetSalaryItemGroupResponse> GetSalaryItemGroupAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSalaryItemGroupHeaders headers = new GetSalaryItemGroupHeaders();
            return await GetSalaryItemGroupWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资记录数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSalaryCalculationRequest
        /// </param>
        /// <param name="headers">
        /// ListSalaryCalculationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSalaryCalculationResponse
        /// </returns>
        public ListSalaryCalculationResponse ListSalaryCalculationWithOptions(ListSalaryCalculationRequest request, ListSalaryCalculationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                body["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SalaryGroupId))
            {
                body["salaryGroupId"] = request.SalaryGroupId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSalaryCalculation",
                Version = "salary_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/salary/calculation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSalaryCalculationResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资记录数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSalaryCalculationRequest
        /// </param>
        /// <param name="headers">
        /// ListSalaryCalculationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSalaryCalculationResponse
        /// </returns>
        public async Task<ListSalaryCalculationResponse> ListSalaryCalculationWithOptionsAsync(ListSalaryCalculationRequest request, ListSalaryCalculationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                body["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SalaryGroupId))
            {
                body["salaryGroupId"] = request.SalaryGroupId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSalaryCalculation",
                Version = "salary_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/salary/calculation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSalaryCalculationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资记录数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSalaryCalculationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSalaryCalculationResponse
        /// </returns>
        public ListSalaryCalculationResponse ListSalaryCalculation(ListSalaryCalculationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSalaryCalculationHeaders headers = new ListSalaryCalculationHeaders();
            return ListSalaryCalculationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资记录数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSalaryCalculationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSalaryCalculationResponse
        /// </returns>
        public async Task<ListSalaryCalculationResponse> ListSalaryCalculationAsync(ListSalaryCalculationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSalaryCalculationHeaders headers = new ListSalaryCalculationHeaders();
            return await ListSalaryCalculationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资记录写入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WriteSalaryCalculationRequest
        /// </param>
        /// <param name="headers">
        /// WriteSalaryCalculationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WriteSalaryCalculationResponse
        /// </returns>
        public WriteSalaryCalculationResponse WriteSalaryCalculationWithOptions(WriteSalaryCalculationRequest request, WriteSalaryCalculationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                body["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Items))
            {
                body["items"] = request.Items;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WriteSalaryCalculation",
                Version = "salary_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/salary/calculation/write",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteSalaryCalculationResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资记录写入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WriteSalaryCalculationRequest
        /// </param>
        /// <param name="headers">
        /// WriteSalaryCalculationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WriteSalaryCalculationResponse
        /// </returns>
        public async Task<WriteSalaryCalculationResponse> WriteSalaryCalculationWithOptionsAsync(WriteSalaryCalculationRequest request, WriteSalaryCalculationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                body["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Items))
            {
                body["items"] = request.Items;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WriteSalaryCalculation",
                Version = "salary_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/salary/calculation/write",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteSalaryCalculationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资记录写入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WriteSalaryCalculationRequest
        /// </param>
        /// 
        /// <returns>
        /// WriteSalaryCalculationResponse
        /// </returns>
        public WriteSalaryCalculationResponse WriteSalaryCalculation(WriteSalaryCalculationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteSalaryCalculationHeaders headers = new WriteSalaryCalculationHeaders();
            return WriteSalaryCalculationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小微薪酬获取薪资记录写入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WriteSalaryCalculationRequest
        /// </param>
        /// 
        /// <returns>
        /// WriteSalaryCalculationResponse
        /// </returns>
        public async Task<WriteSalaryCalculationResponse> WriteSalaryCalculationAsync(WriteSalaryCalculationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WriteSalaryCalculationHeaders headers = new WriteSalaryCalculationHeaders();
            return await WriteSalaryCalculationWithOptionsAsync(request, headers, runtime);
        }

    }
}
