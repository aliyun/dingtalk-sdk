// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalktrip_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "dingtalk";
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
        /// <para>获取差旅审批实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTravelProcessDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetTravelProcessDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTravelProcessDetailResponse
        /// </returns>
        public GetTravelProcessDetailResponse GetTravelProcessDetailWithOptions(GetTravelProcessDetailRequest request, GetTravelProcessDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCorpId))
            {
                query["processCorpId"] = request.ProcessCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["processInstanceId"] = request.ProcessInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetTravelProcessDetail",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/processes/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTravelProcessDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取差旅审批实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTravelProcessDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetTravelProcessDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTravelProcessDetailResponse
        /// </returns>
        public async Task<GetTravelProcessDetailResponse> GetTravelProcessDetailWithOptionsAsync(GetTravelProcessDetailRequest request, GetTravelProcessDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessCorpId))
            {
                query["processCorpId"] = request.ProcessCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["processInstanceId"] = request.ProcessInstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetTravelProcessDetail",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/processes/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTravelProcessDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取差旅审批实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTravelProcessDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTravelProcessDetailResponse
        /// </returns>
        public GetTravelProcessDetailResponse GetTravelProcessDetail(GetTravelProcessDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTravelProcessDetailHeaders headers = new GetTravelProcessDetailHeaders();
            return GetTravelProcessDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取差旅审批实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTravelProcessDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTravelProcessDetailResponse
        /// </returns>
        public async Task<GetTravelProcessDetailResponse> GetTravelProcessDetailAsync(GetTravelProcessDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTravelProcessDetailHeaders headers = new GetTravelProcessDetailHeaders();
            return await GetTravelProcessDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表单升级预校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreCheckTemplateRequest
        /// </param>
        /// <param name="headers">
        /// PreCheckTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreCheckTemplateResponse
        /// </returns>
        public PreCheckTemplateResponse PreCheckTemplateWithOptions(PreCheckTemplateRequest request, PreCheckTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerCorpId))
            {
                body["customerCorpId"] = request.CustomerCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreCheckTemplate",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/processes/templateUpgrades/preCheck",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreCheckTemplateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表单升级预校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreCheckTemplateRequest
        /// </param>
        /// <param name="headers">
        /// PreCheckTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreCheckTemplateResponse
        /// </returns>
        public async Task<PreCheckTemplateResponse> PreCheckTemplateWithOptionsAsync(PreCheckTemplateRequest request, PreCheckTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerCorpId))
            {
                body["customerCorpId"] = request.CustomerCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreCheckTemplate",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/processes/templateUpgrades/preCheck",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreCheckTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表单升级预校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreCheckTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// PreCheckTemplateResponse
        /// </returns>
        public PreCheckTemplateResponse PreCheckTemplate(PreCheckTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PreCheckTemplateHeaders headers = new PreCheckTemplateHeaders();
            return PreCheckTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表单升级预校验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreCheckTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// PreCheckTemplateResponse
        /// </returns>
        public async Task<PreCheckTemplateResponse> PreCheckTemplateAsync(PreCheckTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PreCheckTemplateHeaders headers = new PreCheckTemplateHeaders();
            return await PreCheckTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批套件详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTripProcessTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// QueryTripProcessTemplatesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTripProcessTemplatesResponse
        /// </returns>
        public QueryTripProcessTemplatesResponse QueryTripProcessTemplatesWithOptions(QueryTripProcessTemplatesRequest request, QueryTripProcessTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerCorpId))
            {
                query["customerCorpId"] = request.CustomerCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "QueryTripProcessTemplates",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/processes/templatesDetails",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTripProcessTemplatesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批套件详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTripProcessTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// QueryTripProcessTemplatesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTripProcessTemplatesResponse
        /// </returns>
        public async Task<QueryTripProcessTemplatesResponse> QueryTripProcessTemplatesWithOptionsAsync(QueryTripProcessTemplatesRequest request, QueryTripProcessTemplatesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerCorpId))
            {
                query["customerCorpId"] = request.CustomerCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "QueryTripProcessTemplates",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/processes/templatesDetails",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTripProcessTemplatesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批套件详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTripProcessTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTripProcessTemplatesResponse
        /// </returns>
        public QueryTripProcessTemplatesResponse QueryTripProcessTemplates(QueryTripProcessTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTripProcessTemplatesHeaders headers = new QueryTripProcessTemplatesHeaders();
            return QueryTripProcessTemplatesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批套件详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTripProcessTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTripProcessTemplatesResponse
        /// </returns>
        public async Task<QueryTripProcessTemplatesResponse> QueryTripProcessTemplatesAsync(QueryTripProcessTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTripProcessTemplatesHeaders headers = new QueryTripProcessTemplatesHeaders();
            return await QueryTripProcessTemplatesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步服务商企业签约变更事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncBusinessSignInfoRequest
        /// </param>
        /// <param name="headers">
        /// SyncBusinessSignInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncBusinessSignInfoResponse
        /// </returns>
        public SyncBusinessSignInfoResponse SyncBusinessSignInfoWithOptions(SyncBusinessSignInfoRequest request, SyncBusinessSignInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTypeList))
            {
                body["bizTypeList"] = request.BizTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtOrgPay))
            {
                body["gmtOrgPay"] = request.GmtOrgPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtSign))
            {
                body["gmtSign"] = request.GmtSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgPayStatus))
            {
                body["orgPayStatus"] = request.OrgPayStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignStatus))
            {
                body["signStatus"] = request.SignStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmcProductDetailList))
            {
                body["tmcProductDetailList"] = request.TmcProductDetailList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmcProductList))
            {
                body["tmcProductList"] = request.TmcProductList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncBusinessSignInfo",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/businessSignInfos/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncBusinessSignInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步服务商企业签约变更事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncBusinessSignInfoRequest
        /// </param>
        /// <param name="headers">
        /// SyncBusinessSignInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncBusinessSignInfoResponse
        /// </returns>
        public async Task<SyncBusinessSignInfoResponse> SyncBusinessSignInfoWithOptionsAsync(SyncBusinessSignInfoRequest request, SyncBusinessSignInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTypeList))
            {
                body["bizTypeList"] = request.BizTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtOrgPay))
            {
                body["gmtOrgPay"] = request.GmtOrgPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtSign))
            {
                body["gmtSign"] = request.GmtSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgPayStatus))
            {
                body["orgPayStatus"] = request.OrgPayStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignStatus))
            {
                body["signStatus"] = request.SignStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmcProductDetailList))
            {
                body["tmcProductDetailList"] = request.TmcProductDetailList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmcProductList))
            {
                body["tmcProductList"] = request.TmcProductList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncBusinessSignInfo",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/businessSignInfos/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncBusinessSignInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步服务商企业签约变更事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncBusinessSignInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncBusinessSignInfoResponse
        /// </returns>
        public SyncBusinessSignInfoResponse SyncBusinessSignInfo(SyncBusinessSignInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncBusinessSignInfoHeaders headers = new SyncBusinessSignInfoHeaders();
            return SyncBusinessSignInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步服务商企业签约变更事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncBusinessSignInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncBusinessSignInfoResponse
        /// </returns>
        public async Task<SyncBusinessSignInfoResponse> SyncBusinessSignInfoAsync(SyncBusinessSignInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncBusinessSignInfoHeaders headers = new SyncBusinessSignInfoHeaders();
            return await SyncBusinessSignInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单成本中心同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncCostCenterRequest
        /// </param>
        /// <param name="headers">
        /// SyncCostCenterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncCostCenterResponse
        /// </returns>
        public SyncCostCenterResponse SyncCostCenterWithOptions(SyncCostCenterRequest request, SyncCostCenterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCorpId))
            {
                body["channelCorpId"] = request.ChannelCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostCenterId))
            {
                body["costCenterId"] = request.CostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteFlag))
            {
                body["deleteFlag"] = request.DeleteFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtAction))
            {
                body["gmtAction"] = request.GmtAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                body["number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["thirdPartId"] = request.ThirdPartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Action = "SyncCostCenter",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/processes/costCenters/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncCostCenterResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单成本中心同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncCostCenterRequest
        /// </param>
        /// <param name="headers">
        /// SyncCostCenterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncCostCenterResponse
        /// </returns>
        public async Task<SyncCostCenterResponse> SyncCostCenterWithOptionsAsync(SyncCostCenterRequest request, SyncCostCenterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCorpId))
            {
                body["channelCorpId"] = request.ChannelCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostCenterId))
            {
                body["costCenterId"] = request.CostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteFlag))
            {
                body["deleteFlag"] = request.DeleteFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtAction))
            {
                body["gmtAction"] = request.GmtAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                body["number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["thirdPartId"] = request.ThirdPartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Action = "SyncCostCenter",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/processes/costCenters/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncCostCenterResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单成本中心同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncCostCenterRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncCostCenterResponse
        /// </returns>
        public SyncCostCenterResponse SyncCostCenter(SyncCostCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncCostCenterHeaders headers = new SyncCostCenterHeaders();
            return SyncCostCenterWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单成本中心同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncCostCenterRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncCostCenterResponse
        /// </returns>
        public async Task<SyncCostCenterResponse> SyncCostCenterAsync(SyncCostCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncCostCenterHeaders headers = new SyncCostCenterHeaders();
            return await SyncCostCenterWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单成本中心可用范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncCostCenterEntityRequest
        /// </param>
        /// <param name="headers">
        /// SyncCostCenterEntityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncCostCenterEntityResponse
        /// </returns>
        public SyncCostCenterEntityResponse SyncCostCenterEntityWithOptions(SyncCostCenterEntityRequest request, SyncCostCenterEntityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCorpId))
            {
                body["channelCorpId"] = request.ChannelCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostCenterId))
            {
                body["costCenterId"] = request.CostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelAll))
            {
                body["delAll"] = request.DelAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityList))
            {
                body["entityList"] = request.EntityList;
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
                Action = "SyncCostCenterEntity",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/processes/costCenters/applicableScopes/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncCostCenterEntityResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单成本中心可用范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncCostCenterEntityRequest
        /// </param>
        /// <param name="headers">
        /// SyncCostCenterEntityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncCostCenterEntityResponse
        /// </returns>
        public async Task<SyncCostCenterEntityResponse> SyncCostCenterEntityWithOptionsAsync(SyncCostCenterEntityRequest request, SyncCostCenterEntityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCorpId))
            {
                body["channelCorpId"] = request.ChannelCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostCenterId))
            {
                body["costCenterId"] = request.CostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelAll))
            {
                body["delAll"] = request.DelAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityList))
            {
                body["entityList"] = request.EntityList;
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
                Action = "SyncCostCenterEntity",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/processes/costCenters/applicableScopes/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncCostCenterEntityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单成本中心可用范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncCostCenterEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncCostCenterEntityResponse
        /// </returns>
        public SyncCostCenterEntityResponse SyncCostCenterEntity(SyncCostCenterEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncCostCenterEntityHeaders headers = new SyncCostCenterEntityHeaders();
            return SyncCostCenterEntityWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单成本中心可用范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncCostCenterEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncCostCenterEntityResponse
        /// </returns>
        public async Task<SyncCostCenterEntityResponse> SyncCostCenterEntityAsync(SyncCostCenterEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncCostCenterEntityHeaders headers = new SyncCostCenterEntityHeaders();
            return await SyncCostCenterEntityWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单发票抬头</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncInvoiceRequest
        /// </param>
        /// <param name="headers">
        /// SyncInvoiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncInvoiceResponse
        /// </returns>
        public SyncInvoiceResponse SyncInvoiceWithOptions(SyncInvoiceRequest request, SyncInvoiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankName))
            {
                body["bankName"] = request.BankName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankNo))
            {
                body["bankNo"] = request.BankNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCorpId))
            {
                body["channelCorpId"] = request.ChannelCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteFlag))
            {
                body["deleteFlag"] = request.DeleteFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtAction))
            {
                body["gmtAction"] = request.GmtAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceId))
            {
                body["invoiceId"] = request.InvoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIds))
            {
                body["projectIds"] = request.ProjectIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNo))
            {
                body["taxNo"] = request.TaxNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tel))
            {
                body["tel"] = request.Tel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["thirdPartId"] = request.ThirdPartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitType))
            {
                body["unitType"] = request.UnitType;
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
                Action = "SyncInvoice",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/processes/invoiceTitles/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncInvoiceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单发票抬头</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncInvoiceRequest
        /// </param>
        /// <param name="headers">
        /// SyncInvoiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncInvoiceResponse
        /// </returns>
        public async Task<SyncInvoiceResponse> SyncInvoiceWithOptionsAsync(SyncInvoiceRequest request, SyncInvoiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankName))
            {
                body["bankName"] = request.BankName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankNo))
            {
                body["bankNo"] = request.BankNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCorpId))
            {
                body["channelCorpId"] = request.ChannelCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteFlag))
            {
                body["deleteFlag"] = request.DeleteFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtAction))
            {
                body["gmtAction"] = request.GmtAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceId))
            {
                body["invoiceId"] = request.InvoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIds))
            {
                body["projectIds"] = request.ProjectIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNo))
            {
                body["taxNo"] = request.TaxNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tel))
            {
                body["tel"] = request.Tel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["thirdPartId"] = request.ThirdPartId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitType))
            {
                body["unitType"] = request.UnitType;
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
                Action = "SyncInvoice",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/processes/invoiceTitles/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncInvoiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单发票抬头</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncInvoiceResponse
        /// </returns>
        public SyncInvoiceResponse SyncInvoice(SyncInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncInvoiceHeaders headers = new SyncInvoiceHeaders();
            return SyncInvoiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单发票抬头</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncInvoiceResponse
        /// </returns>
        public async Task<SyncInvoiceResponse> SyncInvoiceAsync(SyncInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncInvoiceHeaders headers = new SyncInvoiceHeaders();
            return await SyncInvoiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单发票抬头可用范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncInvoiceEntityRequest
        /// </param>
        /// <param name="headers">
        /// SyncInvoiceEntityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncInvoiceEntityResponse
        /// </returns>
        public SyncInvoiceEntityResponse SyncInvoiceEntityWithOptions(SyncInvoiceEntityRequest request, SyncInvoiceEntityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCorpId))
            {
                body["channelCorpId"] = request.ChannelCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelAll))
            {
                body["delAll"] = request.DelAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityList))
            {
                body["entityList"] = request.EntityList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceId))
            {
                body["invoiceId"] = request.InvoiceId;
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
                Action = "SyncInvoiceEntity",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/processes/invoiceTitles/applicableScopes/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncInvoiceEntityResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单发票抬头可用范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncInvoiceEntityRequest
        /// </param>
        /// <param name="headers">
        /// SyncInvoiceEntityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncInvoiceEntityResponse
        /// </returns>
        public async Task<SyncInvoiceEntityResponse> SyncInvoiceEntityWithOptionsAsync(SyncInvoiceEntityRequest request, SyncInvoiceEntityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCorpId))
            {
                body["channelCorpId"] = request.ChannelCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelAll))
            {
                body["delAll"] = request.DelAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityList))
            {
                body["entityList"] = request.EntityList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceId))
            {
                body["invoiceId"] = request.InvoiceId;
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
                Action = "SyncInvoiceEntity",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/processes/invoiceTitles/applicableScopes/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncInvoiceEntityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单发票抬头可用范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncInvoiceEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncInvoiceEntityResponse
        /// </returns>
        public SyncInvoiceEntityResponse SyncInvoiceEntity(SyncInvoiceEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncInvoiceEntityHeaders headers = new SyncInvoiceEntityHeaders();
            return SyncInvoiceEntityWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单发票抬头可用范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncInvoiceEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncInvoiceEntityResponse
        /// </returns>
        public async Task<SyncInvoiceEntityResponse> SyncInvoiceEntityAsync(SyncInvoiceEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncInvoiceEntityHeaders headers = new SyncInvoiceEntityHeaders();
            return await SyncInvoiceEntityWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncProjectRequest
        /// </param>
        /// <param name="headers">
        /// SyncProjectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncProjectResponse
        /// </returns>
        public SyncProjectResponse SyncProjectWithOptions(SyncProjectRequest request, SyncProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCorpId))
            {
                body["channelCorpId"] = request.ChannelCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostCenterId))
            {
                body["costCenterId"] = request.CostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteFlag))
            {
                body["deleteFlag"] = request.DeleteFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtAction))
            {
                body["gmtAction"] = request.GmtAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceId))
            {
                body["invoiceId"] = request.InvoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIds))
            {
                body["managerIds"] = request.ManagerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["projectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["thirdPartId"] = request.ThirdPartId;
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
                Action = "SyncProject",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/processes/projects/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncProjectResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncProjectRequest
        /// </param>
        /// <param name="headers">
        /// SyncProjectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncProjectResponse
        /// </returns>
        public async Task<SyncProjectResponse> SyncProjectWithOptionsAsync(SyncProjectRequest request, SyncProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCorpId))
            {
                body["channelCorpId"] = request.ChannelCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostCenterId))
            {
                body["costCenterId"] = request.CostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteFlag))
            {
                body["deleteFlag"] = request.DeleteFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtAction))
            {
                body["gmtAction"] = request.GmtAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceId))
            {
                body["invoiceId"] = request.InvoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIds))
            {
                body["managerIds"] = request.ManagerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["projectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartId))
            {
                body["thirdPartId"] = request.ThirdPartId;
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
                Action = "SyncProject",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/processes/projects/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncProjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncProjectResponse
        /// </returns>
        public SyncProjectResponse SyncProject(SyncProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncProjectHeaders headers = new SyncProjectHeaders();
            return SyncProjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncProjectResponse
        /// </returns>
        public async Task<SyncProjectResponse> SyncProjectAsync(SyncProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncProjectHeaders headers = new SyncProjectHeaders();
            return await SyncProjectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单项目可用范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncProjectEntityRequest
        /// </param>
        /// <param name="headers">
        /// SyncProjectEntityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncProjectEntityResponse
        /// </returns>
        public SyncProjectEntityResponse SyncProjectEntityWithOptions(SyncProjectEntityRequest request, SyncProjectEntityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCorpId))
            {
                body["channelCorpId"] = request.ChannelCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelAll))
            {
                body["delAll"] = request.DelAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityList))
            {
                body["entityList"] = request.EntityList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
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
                Action = "SyncProjectEntity",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/processes/projects/applicableScopes/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncProjectEntityResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单项目可用范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncProjectEntityRequest
        /// </param>
        /// <param name="headers">
        /// SyncProjectEntityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncProjectEntityResponse
        /// </returns>
        public async Task<SyncProjectEntityResponse> SyncProjectEntityWithOptionsAsync(SyncProjectEntityRequest request, SyncProjectEntityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCorpId))
            {
                body["channelCorpId"] = request.ChannelCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelAll))
            {
                body["delAll"] = request.DelAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityList))
            {
                body["entityList"] = request.EntityList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
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
                Action = "SyncProjectEntity",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/processes/projects/applicableScopes/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncProjectEntityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单项目可用范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncProjectEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncProjectEntityResponse
        /// </returns>
        public SyncProjectEntityResponse SyncProjectEntity(SyncProjectEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncProjectEntityHeaders headers = new SyncProjectEntityHeaders();
            return SyncProjectEntityWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>出差表单项目可用范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncProjectEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncProjectEntityResponse
        /// </returns>
        public async Task<SyncProjectEntityResponse> SyncProjectEntityAsync(SyncProjectEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncProjectEntityHeaders headers = new SyncProjectEntityHeaders();
            return await SyncProjectEntityWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用本接口同步公司密钥信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncSecretKeyRequest
        /// </param>
        /// <param name="headers">
        /// SyncSecretKeyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncSecretKeyResponse
        /// </returns>
        public SyncSecretKeyResponse SyncSecretKeyWithOptions(SyncSecretKeyRequest request, SyncSecretKeyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["actionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretString))
            {
                body["secretString"] = request.SecretString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripAppKey))
            {
                body["tripAppKey"] = request.TripAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripAppSecurity))
            {
                body["tripAppSecurity"] = request.TripAppSecurity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripCorpId))
            {
                body["tripCorpId"] = request.TripCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncSecretKey",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/secretKeys/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncSecretKeyResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用本接口同步公司密钥信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncSecretKeyRequest
        /// </param>
        /// <param name="headers">
        /// SyncSecretKeyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncSecretKeyResponse
        /// </returns>
        public async Task<SyncSecretKeyResponse> SyncSecretKeyWithOptionsAsync(SyncSecretKeyRequest request, SyncSecretKeyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["actionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretString))
            {
                body["secretString"] = request.SecretString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripAppKey))
            {
                body["tripAppKey"] = request.TripAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripAppSecurity))
            {
                body["tripAppSecurity"] = request.TripAppSecurity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripCorpId))
            {
                body["tripCorpId"] = request.TripCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncSecretKey",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/secretKeys/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncSecretKeyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用本接口同步公司密钥信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncSecretKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncSecretKeyResponse
        /// </returns>
        public SyncSecretKeyResponse SyncSecretKey(SyncSecretKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncSecretKeyHeaders headers = new SyncSecretKeyHeaders();
            return SyncSecretKeyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用本接口同步公司密钥信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncSecretKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncSecretKeyResponse
        /// </returns>
        public async Task<SyncSecretKeyResponse> SyncSecretKeyAsync(SyncSecretKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncSecretKeyHeaders headers = new SyncSecretKeyHeaders();
            return await SyncSecretKeyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步出行订单变更事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncTripOrderRequest
        /// </param>
        /// <param name="headers">
        /// SyncTripOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncTripOrderResponse
        /// </returns>
        public SyncTripOrderResponse SyncTripOrderWithOptions(SyncTripOrderRequest request, SyncTripOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizExtension))
            {
                body["bizExtension"] = request.BizExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["channelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserId))
            {
                body["dingUserId"] = request.DingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscountAmount))
            {
                body["discountAmount"] = request.DiscountAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndorseFlag))
            {
                body["endorseFlag"] = request.EndorseFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Event))
            {
                body["event"] = request.Event;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtOrder))
            {
                body["gmtOrder"] = request.GmtOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtPay))
            {
                body["gmtPay"] = request.GmtPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtRefund))
            {
                body["gmtRefund"] = request.GmtRefund;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceApplyUrl))
            {
                body["invoiceApplyUrl"] = request.InvoiceApplyUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JourneyBizNo))
            {
                body["journeyBizNo"] = request.JourneyBizNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDetails))
            {
                body["orderDetails"] = request.OrderDetails;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["orderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderUrl))
            {
                body["orderUrl"] = request.OrderUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessId))
            {
                body["processId"] = request.ProcessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealAmount))
            {
                body["realAmount"] = request.RealAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundAmount))
            {
                body["refundAmount"] = request.RefundAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelativeOrderNo))
            {
                body["relativeOrderNo"] = request.RelativeOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyLogo))
            {
                body["supplyLogo"] = request.SupplyLogo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyName))
            {
                body["supplyName"] = request.SupplyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmcCorpId))
            {
                body["tmcCorpId"] = request.TmcCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalAmount))
            {
                body["totalAmount"] = request.TotalAmount;
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
                Action = "SyncTripOrder",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/tripOrders/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncTripOrderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步出行订单变更事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncTripOrderRequest
        /// </param>
        /// <param name="headers">
        /// SyncTripOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncTripOrderResponse
        /// </returns>
        public async Task<SyncTripOrderResponse> SyncTripOrderWithOptionsAsync(SyncTripOrderRequest request, SyncTripOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizExtension))
            {
                body["bizExtension"] = request.BizExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["channelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserId))
            {
                body["dingUserId"] = request.DingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscountAmount))
            {
                body["discountAmount"] = request.DiscountAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndorseFlag))
            {
                body["endorseFlag"] = request.EndorseFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Event))
            {
                body["event"] = request.Event;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtOrder))
            {
                body["gmtOrder"] = request.GmtOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtPay))
            {
                body["gmtPay"] = request.GmtPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtRefund))
            {
                body["gmtRefund"] = request.GmtRefund;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceApplyUrl))
            {
                body["invoiceApplyUrl"] = request.InvoiceApplyUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JourneyBizNo))
            {
                body["journeyBizNo"] = request.JourneyBizNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDetails))
            {
                body["orderDetails"] = request.OrderDetails;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["orderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderUrl))
            {
                body["orderUrl"] = request.OrderUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessId))
            {
                body["processId"] = request.ProcessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealAmount))
            {
                body["realAmount"] = request.RealAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundAmount))
            {
                body["refundAmount"] = request.RefundAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelativeOrderNo))
            {
                body["relativeOrderNo"] = request.RelativeOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyLogo))
            {
                body["supplyLogo"] = request.SupplyLogo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyName))
            {
                body["supplyName"] = request.SupplyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmcCorpId))
            {
                body["tmcCorpId"] = request.TmcCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalAmount))
            {
                body["totalAmount"] = request.TotalAmount;
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
                Action = "SyncTripOrder",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/tripOrders/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncTripOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步出行订单变更事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncTripOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncTripOrderResponse
        /// </returns>
        public SyncTripOrderResponse SyncTripOrder(SyncTripOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncTripOrderHeaders headers = new SyncTripOrderHeaders();
            return SyncTripOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步出行订单变更事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncTripOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncTripOrderResponse
        /// </returns>
        public async Task<SyncTripOrderResponse> SyncTripOrderAsync(SyncTripOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncTripOrderHeaders headers = new SyncTripOrderHeaders();
            return await SyncTripOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预订管理产品线配置同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncTripProductConfigRequest
        /// </param>
        /// <param name="headers">
        /// SyncTripProductConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncTripProductConfigResponse
        /// </returns>
        public SyncTripProductConfigResponse SyncTripProductConfigWithOptions(SyncTripProductConfigRequest request, SyncTripProductConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripProductConfigList))
            {
                body["tripProductConfigList"] = request.TripProductConfigList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncTripProductConfig",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/productConfigs/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncTripProductConfigResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预订管理产品线配置同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncTripProductConfigRequest
        /// </param>
        /// <param name="headers">
        /// SyncTripProductConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncTripProductConfigResponse
        /// </returns>
        public async Task<SyncTripProductConfigResponse> SyncTripProductConfigWithOptionsAsync(SyncTripProductConfigRequest request, SyncTripProductConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripProductConfigList))
            {
                body["tripProductConfigList"] = request.TripProductConfigList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncTripProductConfig",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/productConfigs/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncTripProductConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预订管理产品线配置同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncTripProductConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncTripProductConfigResponse
        /// </returns>
        public SyncTripProductConfigResponse SyncTripProductConfig(SyncTripProductConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncTripProductConfigHeaders headers = new SyncTripProductConfigHeaders();
            return SyncTripProductConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预订管理产品线配置同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncTripProductConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncTripProductConfigResponse
        /// </returns>
        public async Task<SyncTripProductConfigResponse> SyncTripProductConfigAsync(SyncTripProductConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncTripProductConfigHeaders headers = new SyncTripProductConfigHeaders();
            return await SyncTripProductConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能差旅平台数据互通统一入口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TripPlatformUnifiedEntryRequest
        /// </param>
        /// <param name="headers">
        /// TripPlatformUnifiedEntryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TripPlatformUnifiedEntryResponse
        /// </returns>
        public TripPlatformUnifiedEntryResponse TripPlatformUnifiedEntryWithOptions(TripPlatformUnifiedEntryRequest request, TripPlatformUnifiedEntryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["method"] = request.Method;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TripPlatformUnifiedEntry",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/platforms/entrances/unify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TripPlatformUnifiedEntryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能差旅平台数据互通统一入口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TripPlatformUnifiedEntryRequest
        /// </param>
        /// <param name="headers">
        /// TripPlatformUnifiedEntryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TripPlatformUnifiedEntryResponse
        /// </returns>
        public async Task<TripPlatformUnifiedEntryResponse> TripPlatformUnifiedEntryWithOptionsAsync(TripPlatformUnifiedEntryRequest request, TripPlatformUnifiedEntryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["method"] = request.Method;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TripPlatformUnifiedEntry",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/platforms/entrances/unify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TripPlatformUnifiedEntryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能差旅平台数据互通统一入口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TripPlatformUnifiedEntryRequest
        /// </param>
        /// 
        /// <returns>
        /// TripPlatformUnifiedEntryResponse
        /// </returns>
        public TripPlatformUnifiedEntryResponse TripPlatformUnifiedEntry(TripPlatformUnifiedEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TripPlatformUnifiedEntryHeaders headers = new TripPlatformUnifiedEntryHeaders();
            return TripPlatformUnifiedEntryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能差旅平台数据互通统一入口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TripPlatformUnifiedEntryRequest
        /// </param>
        /// 
        /// <returns>
        /// TripPlatformUnifiedEntryResponse
        /// </returns>
        public async Task<TripPlatformUnifiedEntryResponse> TripPlatformUnifiedEntryAsync(TripPlatformUnifiedEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TripPlatformUnifiedEntryHeaders headers = new TripPlatformUnifiedEntryHeaders();
            return await TripPlatformUnifiedEntryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>升级套件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeTemplateRequest
        /// </param>
        /// <param name="headers">
        /// UpgradeTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeTemplateResponse
        /// </returns>
        public UpgradeTemplateResponse UpgradeTemplateWithOptions(UpgradeTemplateRequest request, UpgradeTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCorpId))
            {
                body["channelCorpId"] = request.ChannelCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceUpgrade))
            {
                body["forceUpgrade"] = request.ForceUpgrade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmcCorpId))
            {
                body["tmcCorpId"] = request.TmcCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeTemplate",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/process/templates/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeTemplateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>升级套件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeTemplateRequest
        /// </param>
        /// <param name="headers">
        /// UpgradeTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeTemplateResponse
        /// </returns>
        public async Task<UpgradeTemplateResponse> UpgradeTemplateWithOptionsAsync(UpgradeTemplateRequest request, UpgradeTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCorpId))
            {
                body["channelCorpId"] = request.ChannelCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceUpgrade))
            {
                body["forceUpgrade"] = request.ForceUpgrade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmcCorpId))
            {
                body["tmcCorpId"] = request.TmcCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeTemplate",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/process/templates/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>升级套件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeTemplateResponse
        /// </returns>
        public UpgradeTemplateResponse UpgradeTemplate(UpgradeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpgradeTemplateHeaders headers = new UpgradeTemplateHeaders();
            return UpgradeTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>升级套件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeTemplateResponse
        /// </returns>
        public async Task<UpgradeTemplateResponse> UpgradeTemplateAsync(UpgradeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpgradeTemplateHeaders headers = new UpgradeTemplateHeaders();
            return await UpgradeTemplateWithOptionsAsync(request, headers, runtime);
        }

    }
}
