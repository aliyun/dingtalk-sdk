// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0
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
        /// <para>同步第三方市内用车申请单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCityCarApplyRequest
        /// </param>
        /// <param name="headers">
        /// AddCityCarApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCityCarApplyResponse
        /// </returns>
        public AddCityCarApplyResponse AddCityCarApplyWithOptions(AddCityCarApplyRequest request, AddCityCarApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cause))
            {
                body["cause"] = request.Cause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["city"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                body["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishedDate))
            {
                body["finishedDate"] = request.FinishedDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectCode))
            {
                body["projectCode"] = request.ProjectCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["projectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                body["thirdPartApplyId"] = request.ThirdPartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartCostCenterId))
            {
                body["thirdPartCostCenterId"] = request.ThirdPartCostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartInvoiceId))
            {
                body["thirdPartInvoiceId"] = request.ThirdPartInvoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimesTotal))
            {
                body["timesTotal"] = request.TimesTotal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimesType))
            {
                body["timesType"] = request.TimesType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimesUsed))
            {
                body["timesUsed"] = request.TimesUsed;
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
                Action = "AddCityCarApply",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/cityCarApprovals",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCityCarApplyResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步第三方市内用车申请单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCityCarApplyRequest
        /// </param>
        /// <param name="headers">
        /// AddCityCarApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCityCarApplyResponse
        /// </returns>
        public async Task<AddCityCarApplyResponse> AddCityCarApplyWithOptionsAsync(AddCityCarApplyRequest request, AddCityCarApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cause))
            {
                body["cause"] = request.Cause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["city"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                body["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishedDate))
            {
                body["finishedDate"] = request.FinishedDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectCode))
            {
                body["projectCode"] = request.ProjectCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["projectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                body["thirdPartApplyId"] = request.ThirdPartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartCostCenterId))
            {
                body["thirdPartCostCenterId"] = request.ThirdPartCostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartInvoiceId))
            {
                body["thirdPartInvoiceId"] = request.ThirdPartInvoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimesTotal))
            {
                body["timesTotal"] = request.TimesTotal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimesType))
            {
                body["timesType"] = request.TimesType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimesUsed))
            {
                body["timesUsed"] = request.TimesUsed;
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
                Action = "AddCityCarApply",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/cityCarApprovals",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCityCarApplyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步第三方市内用车申请单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCityCarApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCityCarApplyResponse
        /// </returns>
        public AddCityCarApplyResponse AddCityCarApply(AddCityCarApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCityCarApplyHeaders headers = new AddCityCarApplyHeaders();
            return AddCityCarApplyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步第三方市内用车申请单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCityCarApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCityCarApplyResponse
        /// </returns>
        public async Task<AddCityCarApplyResponse> AddCityCarApplyAsync(AddCityCarApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCityCarApplyHeaders headers = new AddCityCarApplyHeaders();
            return await AddCityCarApplyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方市内用车申请单审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveCityCarApplyRequest
        /// </param>
        /// <param name="headers">
        /// ApproveCityCarApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApproveCityCarApplyResponse
        /// </returns>
        public ApproveCityCarApplyResponse ApproveCityCarApplyWithOptions(ApproveCityCarApplyRequest request, ApproveCityCarApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateTime))
            {
                body["operateTime"] = request.OperateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                body["thirdPartApplyId"] = request.ThirdPartApplyId;
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
                Action = "ApproveCityCarApply",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/cityCarApprovals",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApproveCityCarApplyResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方市内用车申请单审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveCityCarApplyRequest
        /// </param>
        /// <param name="headers">
        /// ApproveCityCarApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApproveCityCarApplyResponse
        /// </returns>
        public async Task<ApproveCityCarApplyResponse> ApproveCityCarApplyWithOptionsAsync(ApproveCityCarApplyRequest request, ApproveCityCarApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateTime))
            {
                body["operateTime"] = request.OperateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                body["thirdPartApplyId"] = request.ThirdPartApplyId;
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
                Action = "ApproveCityCarApply",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/cityCarApprovals",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApproveCityCarApplyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方市内用车申请单审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveCityCarApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// ApproveCityCarApplyResponse
        /// </returns>
        public ApproveCityCarApplyResponse ApproveCityCarApply(ApproveCityCarApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApproveCityCarApplyHeaders headers = new ApproveCityCarApplyHeaders();
            return ApproveCityCarApplyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方市内用车申请单审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveCityCarApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// ApproveCityCarApplyResponse
        /// </returns>
        public async Task<ApproveCityCarApplyResponse> ApproveCityCarApplyAsync(ApproveCityCarApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApproveCityCarApplyHeaders headers = new ApproveCityCarApplyHeaders();
            return await ApproveCityCarApplyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商旅火车票结算记账查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BillSettementBtripTrainRequest
        /// </param>
        /// <param name="headers">
        /// BillSettementBtripTrainHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BillSettementBtripTrainResponse
        /// </returns>
        public BillSettementBtripTrainResponse BillSettementBtripTrainWithOptions(BillSettementBtripTrainRequest request, BillSettementBtripTrainHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["periodEnd"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["periodStart"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BillSettementBtripTrain",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/billSettlements/btripTrains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BillSettementBtripTrainResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商旅火车票结算记账查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BillSettementBtripTrainRequest
        /// </param>
        /// <param name="headers">
        /// BillSettementBtripTrainHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BillSettementBtripTrainResponse
        /// </returns>
        public async Task<BillSettementBtripTrainResponse> BillSettementBtripTrainWithOptionsAsync(BillSettementBtripTrainRequest request, BillSettementBtripTrainHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["periodEnd"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["periodStart"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BillSettementBtripTrain",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/billSettlements/btripTrains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BillSettementBtripTrainResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商旅火车票结算记账查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BillSettementBtripTrainRequest
        /// </param>
        /// 
        /// <returns>
        /// BillSettementBtripTrainResponse
        /// </returns>
        public BillSettementBtripTrainResponse BillSettementBtripTrain(BillSettementBtripTrainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BillSettementBtripTrainHeaders headers = new BillSettementBtripTrainHeaders();
            return BillSettementBtripTrainWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商旅火车票结算记账查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BillSettementBtripTrainRequest
        /// </param>
        /// 
        /// <returns>
        /// BillSettementBtripTrainResponse
        /// </returns>
        public async Task<BillSettementBtripTrainResponse> BillSettementBtripTrainAsync(BillSettementBtripTrainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BillSettementBtripTrainHeaders headers = new BillSettementBtripTrainHeaders();
            return await BillSettementBtripTrainWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用车结算记账查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BillSettementCarRequest
        /// </param>
        /// <param name="headers">
        /// BillSettementCarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BillSettementCarResponse
        /// </returns>
        public BillSettementCarResponse BillSettementCarWithOptions(BillSettementCarRequest request, BillSettementCarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["periodEnd"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["periodStart"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BillSettementCar",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/billSettlements/cars",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BillSettementCarResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用车结算记账查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BillSettementCarRequest
        /// </param>
        /// <param name="headers">
        /// BillSettementCarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BillSettementCarResponse
        /// </returns>
        public async Task<BillSettementCarResponse> BillSettementCarWithOptionsAsync(BillSettementCarRequest request, BillSettementCarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["periodEnd"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["periodStart"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BillSettementCar",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/billSettlements/cars",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BillSettementCarResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用车结算记账查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BillSettementCarRequest
        /// </param>
        /// 
        /// <returns>
        /// BillSettementCarResponse
        /// </returns>
        public BillSettementCarResponse BillSettementCar(BillSettementCarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BillSettementCarHeaders headers = new BillSettementCarHeaders();
            return BillSettementCarWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用车结算记账查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BillSettementCarRequest
        /// </param>
        /// 
        /// <returns>
        /// BillSettementCarResponse
        /// </returns>
        public async Task<BillSettementCarResponse> BillSettementCarAsync(BillSettementCarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BillSettementCarHeaders headers = new BillSettementCarHeaders();
            return await BillSettementCarWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机票结算记账查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BillSettementFlightRequest
        /// </param>
        /// <param name="headers">
        /// BillSettementFlightHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BillSettementFlightResponse
        /// </returns>
        public BillSettementFlightResponse BillSettementFlightWithOptions(BillSettementFlightRequest request, BillSettementFlightHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["periodEnd"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["periodStart"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BillSettementFlight",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/billSettlements/flights",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BillSettementFlightResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机票结算记账查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BillSettementFlightRequest
        /// </param>
        /// <param name="headers">
        /// BillSettementFlightHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BillSettementFlightResponse
        /// </returns>
        public async Task<BillSettementFlightResponse> BillSettementFlightWithOptionsAsync(BillSettementFlightRequest request, BillSettementFlightHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["periodEnd"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["periodStart"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BillSettementFlight",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/billSettlements/flights",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BillSettementFlightResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机票结算记账查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BillSettementFlightRequest
        /// </param>
        /// 
        /// <returns>
        /// BillSettementFlightResponse
        /// </returns>
        public BillSettementFlightResponse BillSettementFlight(BillSettementFlightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BillSettementFlightHeaders headers = new BillSettementFlightHeaders();
            return BillSettementFlightWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机票结算记账查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BillSettementFlightRequest
        /// </param>
        /// 
        /// <returns>
        /// BillSettementFlightResponse
        /// </returns>
        public async Task<BillSettementFlightResponse> BillSettementFlightAsync(BillSettementFlightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BillSettementFlightHeaders headers = new BillSettementFlightHeaders();
            return await BillSettementFlightWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店结算记账查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BillSettementHotelRequest
        /// </param>
        /// <param name="headers">
        /// BillSettementHotelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BillSettementHotelResponse
        /// </returns>
        public BillSettementHotelResponse BillSettementHotelWithOptions(BillSettementHotelRequest request, BillSettementHotelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["periodEnd"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["periodStart"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BillSettementHotel",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/billSettlements/hotels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BillSettementHotelResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店结算记账查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BillSettementHotelRequest
        /// </param>
        /// <param name="headers">
        /// BillSettementHotelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BillSettementHotelResponse
        /// </returns>
        public async Task<BillSettementHotelResponse> BillSettementHotelWithOptionsAsync(BillSettementHotelRequest request, BillSettementHotelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodEnd))
            {
                query["periodEnd"] = request.PeriodEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodStart))
            {
                query["periodStart"] = request.PeriodStart;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BillSettementHotel",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/billSettlements/hotels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BillSettementHotelResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店结算记账查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BillSettementHotelRequest
        /// </param>
        /// 
        /// <returns>
        /// BillSettementHotelResponse
        /// </returns>
        public BillSettementHotelResponse BillSettementHotel(BillSettementHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BillSettementHotelHeaders headers = new BillSettementHotelHeaders();
            return BillSettementHotelWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>酒店结算记账查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BillSettementHotelRequest
        /// </param>
        /// 
        /// <returns>
        /// BillSettementHotelResponse
        /// </returns>
        public async Task<BillSettementHotelResponse> BillSettementHotelAsync(BillSettementHotelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BillSettementHotelHeaders headers = new BillSettementHotelHeaders();
            return await BillSettementHotelWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商旅机票第三方超标审批单搜索接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFlightExceedApplyRequest
        /// </param>
        /// <param name="headers">
        /// GetFlightExceedApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFlightExceedApplyResponse
        /// </returns>
        public GetFlightExceedApplyResponse GetFlightExceedApplyWithOptions(GetFlightExceedApplyRequest request, GetFlightExceedApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["applyId"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetFlightExceedApply",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/exceedapply/getFlight",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlightExceedApplyResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商旅机票第三方超标审批单搜索接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFlightExceedApplyRequest
        /// </param>
        /// <param name="headers">
        /// GetFlightExceedApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFlightExceedApplyResponse
        /// </returns>
        public async Task<GetFlightExceedApplyResponse> GetFlightExceedApplyWithOptionsAsync(GetFlightExceedApplyRequest request, GetFlightExceedApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["applyId"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetFlightExceedApply",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/exceedapply/getFlight",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlightExceedApplyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商旅机票第三方超标审批单搜索接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFlightExceedApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFlightExceedApplyResponse
        /// </returns>
        public GetFlightExceedApplyResponse GetFlightExceedApply(GetFlightExceedApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlightExceedApplyHeaders headers = new GetFlightExceedApplyHeaders();
            return GetFlightExceedApplyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商旅机票第三方超标审批单搜索接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFlightExceedApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFlightExceedApplyResponse
        /// </returns>
        public async Task<GetFlightExceedApplyResponse> GetFlightExceedApplyAsync(GetFlightExceedApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlightExceedApplyHeaders headers = new GetFlightExceedApplyHeaders();
            return await GetFlightExceedApplyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索酒店超标审批单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelExceedApplyRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelExceedApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelExceedApplyResponse
        /// </returns>
        public GetHotelExceedApplyResponse GetHotelExceedApplyWithOptions(GetHotelExceedApplyRequest request, GetHotelExceedApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["applyId"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetHotelExceedApply",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/exceedapply/getHotel",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelExceedApplyResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索酒店超标审批单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelExceedApplyRequest
        /// </param>
        /// <param name="headers">
        /// GetHotelExceedApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotelExceedApplyResponse
        /// </returns>
        public async Task<GetHotelExceedApplyResponse> GetHotelExceedApplyWithOptionsAsync(GetHotelExceedApplyRequest request, GetHotelExceedApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["applyId"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetHotelExceedApply",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/exceedapply/getHotel",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotelExceedApplyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索酒店超标审批单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelExceedApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelExceedApplyResponse
        /// </returns>
        public GetHotelExceedApplyResponse GetHotelExceedApply(GetHotelExceedApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelExceedApplyHeaders headers = new GetHotelExceedApplyHeaders();
            return GetHotelExceedApplyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索酒店超标审批单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotelExceedApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotelExceedApplyResponse
        /// </returns>
        public async Task<GetHotelExceedApplyResponse> GetHotelExceedApplyAsync(GetHotelExceedApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelExceedApplyHeaders headers = new GetHotelExceedApplyHeaders();
            return await GetHotelExceedApplyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商旅火车票第三方超标审批单搜索接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrainExceedApplyRequest
        /// </param>
        /// <param name="headers">
        /// GetTrainExceedApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTrainExceedApplyResponse
        /// </returns>
        public GetTrainExceedApplyResponse GetTrainExceedApplyWithOptions(GetTrainExceedApplyRequest request, GetTrainExceedApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["applyId"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetTrainExceedApply",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/exceedapply/getTrain",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrainExceedApplyResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商旅火车票第三方超标审批单搜索接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrainExceedApplyRequest
        /// </param>
        /// <param name="headers">
        /// GetTrainExceedApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTrainExceedApplyResponse
        /// </returns>
        public async Task<GetTrainExceedApplyResponse> GetTrainExceedApplyWithOptionsAsync(GetTrainExceedApplyRequest request, GetTrainExceedApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["applyId"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetTrainExceedApply",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/exceedapply/getTrain",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrainExceedApplyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商旅火车票第三方超标审批单搜索接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrainExceedApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTrainExceedApplyResponse
        /// </returns>
        public GetTrainExceedApplyResponse GetTrainExceedApply(GetTrainExceedApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTrainExceedApplyHeaders headers = new GetTrainExceedApplyHeaders();
            return GetTrainExceedApplyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商旅火车票第三方超标审批单搜索接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrainExceedApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTrainExceedApplyResponse
        /// </returns>
        public async Task<GetTrainExceedApplyResponse> GetTrainExceedApplyAsync(GetTrainExceedApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTrainExceedApplyHeaders headers = new GetTrainExceedApplyHeaders();
            return await GetTrainExceedApplyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方市内用车申请单查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCityCarApplyRequest
        /// </param>
        /// <param name="headers">
        /// QueryCityCarApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCityCarApplyResponse
        /// </returns>
        public QueryCityCarApplyResponse QueryCityCarApplyWithOptions(QueryCityCarApplyRequest request, QueryCityCarApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedEndAt))
            {
                query["createdEndAt"] = request.CreatedEndAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedStartAt))
            {
                query["createdStartAt"] = request.CreatedStartAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                query["thirdPartApplyId"] = request.ThirdPartApplyId;
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
                Action = "QueryCityCarApply",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/cityCarApprovals",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCityCarApplyResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方市内用车申请单查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCityCarApplyRequest
        /// </param>
        /// <param name="headers">
        /// QueryCityCarApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCityCarApplyResponse
        /// </returns>
        public async Task<QueryCityCarApplyResponse> QueryCityCarApplyWithOptionsAsync(QueryCityCarApplyRequest request, QueryCityCarApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedEndAt))
            {
                query["createdEndAt"] = request.CreatedEndAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedStartAt))
            {
                query["createdStartAt"] = request.CreatedStartAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                query["thirdPartApplyId"] = request.ThirdPartApplyId;
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
                Action = "QueryCityCarApply",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/cityCarApprovals",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCityCarApplyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方市内用车申请单查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCityCarApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCityCarApplyResponse
        /// </returns>
        public QueryCityCarApplyResponse QueryCityCarApply(QueryCityCarApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCityCarApplyHeaders headers = new QueryCityCarApplyHeaders();
            return QueryCityCarApplyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方市内用车申请单查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCityCarApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCityCarApplyResponse
        /// </returns>
        public async Task<QueryCityCarApplyResponse> QueryCityCarApplyAsync(QueryCityCarApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCityCarApplyHeaders headers = new QueryCityCarApplyHeaders();
            return await QueryCityCarApplyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请单关联单号查询相关订单信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnionOrderRequest
        /// </param>
        /// <param name="headers">
        /// QueryUnionOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUnionOrderResponse
        /// </returns>
        public QueryUnionOrderResponse QueryUnionOrderWithOptions(QueryUnionOrderRequest request, QueryUnionOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                query["thirdPartApplyId"] = request.ThirdPartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionNo))
            {
                query["unionNo"] = request.UnionNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryUnionOrder",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/unionOrders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnionOrderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请单关联单号查询相关订单信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnionOrderRequest
        /// </param>
        /// <param name="headers">
        /// QueryUnionOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUnionOrderResponse
        /// </returns>
        public async Task<QueryUnionOrderResponse> QueryUnionOrderWithOptionsAsync(QueryUnionOrderRequest request, QueryUnionOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                query["thirdPartApplyId"] = request.ThirdPartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionNo))
            {
                query["unionNo"] = request.UnionNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryUnionOrder",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/unionOrders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnionOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请单关联单号查询相关订单信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnionOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUnionOrderResponse
        /// </returns>
        public QueryUnionOrderResponse QueryUnionOrder(QueryUnionOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUnionOrderHeaders headers = new QueryUnionOrderHeaders();
            return QueryUnionOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请单关联单号查询相关订单信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnionOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUnionOrderResponse
        /// </returns>
        public async Task<QueryUnionOrderResponse> QueryUnionOrderAsync(QueryUnionOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUnionOrderHeaders headers = new QueryUnionOrderHeaders();
            return await QueryUnionOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步超标审批结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncExceedApplyRequest
        /// </param>
        /// <param name="headers">
        /// SyncExceedApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncExceedApplyResponse
        /// </returns>
        public SyncExceedApplyResponse SyncExceedApplyWithOptions(SyncExceedApplyRequest request, SyncExceedApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["applyId"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartyFlowId))
            {
                query["thirdpartyFlowId"] = request.ThirdpartyFlowId;
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
                Action = "SyncExceedApply",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/exceedapply/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncExceedApplyResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步超标审批结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncExceedApplyRequest
        /// </param>
        /// <param name="headers">
        /// SyncExceedApplyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncExceedApplyResponse
        /// </returns>
        public async Task<SyncExceedApplyResponse> SyncExceedApplyWithOptionsAsync(SyncExceedApplyRequest request, SyncExceedApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["applyId"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartyFlowId))
            {
                query["thirdpartyFlowId"] = request.ThirdpartyFlowId;
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
                Action = "SyncExceedApply",
                Version = "alitrip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/alitrip/exceedapply/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncExceedApplyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步超标审批结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncExceedApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncExceedApplyResponse
        /// </returns>
        public SyncExceedApplyResponse SyncExceedApply(SyncExceedApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncExceedApplyHeaders headers = new SyncExceedApplyHeaders();
            return SyncExceedApplyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步超标审批结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncExceedApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncExceedApplyResponse
        /// </returns>
        public async Task<SyncExceedApplyResponse> SyncExceedApplyAsync(SyncExceedApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncExceedApplyHeaders headers = new SyncExceedApplyHeaders();
            return await SyncExceedApplyWithOptionsAsync(request, headers, runtime);
        }

    }
}
