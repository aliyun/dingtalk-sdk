// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkwatt_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkwatt_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 根据加密后的用户手机号检查该用户是否在某人群中
         *
         * @param request CheckInCrowdsByMobileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckInCrowdsByMobileResponse
         */
        public CheckInCrowdsByMobileResponse CheckInCrowdsByMobileWithOptions(CheckInCrowdsByMobileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdIds))
            {
                query["crowdIds"] = request.CrowdIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckInCrowdsByMobile",
                Version = "watt_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/watt/crowdIdentifications/query",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckInCrowdsByMobileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据加密后的用户手机号检查该用户是否在某人群中
         *
         * @param request CheckInCrowdsByMobileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckInCrowdsByMobileResponse
         */
        public async Task<CheckInCrowdsByMobileResponse> CheckInCrowdsByMobileWithOptionsAsync(CheckInCrowdsByMobileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdIds))
            {
                query["crowdIds"] = request.CrowdIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckInCrowdsByMobile",
                Version = "watt_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/watt/crowdIdentifications/query",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckInCrowdsByMobileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据加密后的用户手机号检查该用户是否在某人群中
         *
         * @param request CheckInCrowdsByMobileRequest
         * @return CheckInCrowdsByMobileResponse
         */
        public CheckInCrowdsByMobileResponse CheckInCrowdsByMobile(CheckInCrowdsByMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckInCrowdsByMobileWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据加密后的用户手机号检查该用户是否在某人群中
         *
         * @param request CheckInCrowdsByMobileRequest
         * @return CheckInCrowdsByMobileResponse
         */
        public async Task<CheckInCrowdsByMobileResponse> CheckInCrowdsByMobileAsync(CheckInCrowdsByMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckInCrowdsByMobileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 消耗用户积分
         *
         * @param tmpReq ConsumePointRequest
         * @param headers ConsumePointHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConsumePointResponse
         */
        public ConsumePointResponse ConsumePointWithOptions(ConsumePointRequest tmpReq, ConsumePointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ConsumePointShrinkRequest request = new ConsumePointShrinkRequest();
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
                Action = "ConsumePoint",
                Version = "watt_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/watt/points/consume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConsumePointResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 消耗用户积分
         *
         * @param tmpReq ConsumePointRequest
         * @param headers ConsumePointHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConsumePointResponse
         */
        public async Task<ConsumePointResponse> ConsumePointWithOptionsAsync(ConsumePointRequest tmpReq, ConsumePointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ConsumePointShrinkRequest request = new ConsumePointShrinkRequest();
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
                Action = "ConsumePoint",
                Version = "watt_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/watt/points/consume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConsumePointResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 消耗用户积分
         *
         * @param request ConsumePointRequest
         * @return ConsumePointResponse
         */
        public ConsumePointResponse ConsumePoint(ConsumePointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConsumePointHeaders headers = new ConsumePointHeaders();
            return ConsumePointWithOptions(request, headers, runtime);
        }

        /**
         * @summary 消耗用户积分
         *
         * @param request ConsumePointRequest
         * @return ConsumePointResponse
         */
        public async Task<ConsumePointResponse> ConsumePointAsync(ConsumePointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConsumePointHeaders headers = new ConsumePointHeaders();
            return await ConsumePointWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发布钉钉投放任务（搜索穹顶、搜索发现、搜索关键字）
         *
         * @param request CreateDeliveryPlanRequest
         * @param headers CreateDeliveryPlanHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDeliveryPlanResponse
         */
        public CreateDeliveryPlanResponse CreateDeliveryPlanWithOptions(CreateDeliveryPlanRequest request, CreateDeliveryPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResId))
            {
                body["resId"] = request.ResId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "CreateDeliveryPlan",
                Version = "watt_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/watt/deliveryPlans/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeliveryPlanResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发布钉钉投放任务（搜索穹顶、搜索发现、搜索关键字）
         *
         * @param request CreateDeliveryPlanRequest
         * @param headers CreateDeliveryPlanHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDeliveryPlanResponse
         */
        public async Task<CreateDeliveryPlanResponse> CreateDeliveryPlanWithOptionsAsync(CreateDeliveryPlanRequest request, CreateDeliveryPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResId))
            {
                body["resId"] = request.ResId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "CreateDeliveryPlan",
                Version = "watt_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/watt/deliveryPlans/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeliveryPlanResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发布钉钉投放任务（搜索穹顶、搜索发现、搜索关键字）
         *
         * @param request CreateDeliveryPlanRequest
         * @return CreateDeliveryPlanResponse
         */
        public CreateDeliveryPlanResponse CreateDeliveryPlan(CreateDeliveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeliveryPlanHeaders headers = new CreateDeliveryPlanHeaders();
            return CreateDeliveryPlanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发布钉钉投放任务（搜索穹顶、搜索发现、搜索关键字）
         *
         * @param request CreateDeliveryPlanRequest
         * @return CreateDeliveryPlanResponse
         */
        public async Task<CreateDeliveryPlanResponse> CreateDeliveryPlanAsync(CreateDeliveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeliveryPlanHeaders headers = new CreateDeliveryPlanHeaders();
            return await CreateDeliveryPlanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询用户积分
         *
         * @param request GetPointInfoRequest
         * @param headers GetPointInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPointInfoResponse
         */
        public GetPointInfoResponse GetPointInfoWithOptions(GetPointInfoRequest request, GetPointInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PointPoolCode))
            {
                query["pointPoolCode"] = request.PointPoolCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetPointInfo",
                Version = "watt_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/watt/points",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPointInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询用户积分
         *
         * @param request GetPointInfoRequest
         * @param headers GetPointInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPointInfoResponse
         */
        public async Task<GetPointInfoResponse> GetPointInfoWithOptionsAsync(GetPointInfoRequest request, GetPointInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PointPoolCode))
            {
                query["pointPoolCode"] = request.PointPoolCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetPointInfo",
                Version = "watt_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/watt/points",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPointInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询用户积分
         *
         * @param request GetPointInfoRequest
         * @return GetPointInfoResponse
         */
        public GetPointInfoResponse GetPointInfo(GetPointInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPointInfoHeaders headers = new GetPointInfoHeaders();
            return GetPointInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询用户积分
         *
         * @param request GetPointInfoRequest
         * @return GetPointInfoResponse
         */
        public async Task<GetPointInfoResponse> GetPointInfoAsync(GetPointInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPointInfoHeaders headers = new GetPointInfoHeaders();
            return await GetPointInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 撤销用户单笔积分消耗
         *
         * @param tmpReq RevertPointRequest
         * @param headers RevertPointHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevertPointResponse
         */
        public RevertPointResponse RevertPointWithOptions(RevertPointRequest tmpReq, RevertPointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RevertPointShrinkRequest request = new RevertPointShrinkRequest();
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
                Action = "RevertPoint",
                Version = "watt_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/watt/points/revert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevertPointResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 撤销用户单笔积分消耗
         *
         * @param tmpReq RevertPointRequest
         * @param headers RevertPointHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevertPointResponse
         */
        public async Task<RevertPointResponse> RevertPointWithOptionsAsync(RevertPointRequest tmpReq, RevertPointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RevertPointShrinkRequest request = new RevertPointShrinkRequest();
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
                Action = "RevertPoint",
                Version = "watt_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/watt/points/revert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevertPointResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 撤销用户单笔积分消耗
         *
         * @param request RevertPointRequest
         * @return RevertPointResponse
         */
        public RevertPointResponse RevertPoint(RevertPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RevertPointHeaders headers = new RevertPointHeaders();
            return RevertPointWithOptions(request, headers, runtime);
        }

        /**
         * @summary 撤销用户单笔积分消耗
         *
         * @param request RevertPointRequest
         * @return RevertPointResponse
         */
        public async Task<RevertPointResponse> RevertPointAsync(RevertPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RevertPointHeaders headers = new RevertPointHeaders();
            return await RevertPointWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发送钉钉统一引导Banner
         *
         * @param request SendBannerRequest
         * @param headers SendBannerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendBannerResponse
         */
        public SendBannerResponse SendBannerWithOptions(SendBannerRequest request, SendBannerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "SendBanner",
                Version = "watt_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/watt/banners/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendBannerResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发送钉钉统一引导Banner
         *
         * @param request SendBannerRequest
         * @param headers SendBannerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendBannerResponse
         */
        public async Task<SendBannerResponse> SendBannerWithOptionsAsync(SendBannerRequest request, SendBannerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "SendBanner",
                Version = "watt_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/watt/banners/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendBannerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发送钉钉统一引导Banner
         *
         * @param request SendBannerRequest
         * @return SendBannerResponse
         */
        public SendBannerResponse SendBanner(SendBannerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendBannerHeaders headers = new SendBannerHeaders();
            return SendBannerWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发送钉钉统一引导Banner
         *
         * @param request SendBannerRequest
         * @return SendBannerResponse
         */
        public async Task<SendBannerResponse> SendBannerAsync(SendBannerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendBannerHeaders headers = new SendBannerHeaders();
            return await SendBannerWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发送钉钉首页弹窗
         *
         * @param request SendPopupRequest
         * @param headers SendPopupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendPopupResponse
         */
        public SendPopupResponse SendPopupWithOptions(SendPopupRequest request, SendPopupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "SendPopup",
                Version = "watt_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/watt/popups/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendPopupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发送钉钉首页弹窗
         *
         * @param request SendPopupRequest
         * @param headers SendPopupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendPopupResponse
         */
        public async Task<SendPopupResponse> SendPopupWithOptionsAsync(SendPopupRequest request, SendPopupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "SendPopup",
                Version = "watt_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/watt/popups/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendPopupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发送钉钉首页弹窗
         *
         * @param request SendPopupRequest
         * @return SendPopupResponse
         */
        public SendPopupResponse SendPopup(SendPopupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendPopupHeaders headers = new SendPopupHeaders();
            return SendPopupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发送钉钉首页弹窗
         *
         * @param request SendPopupRequest
         * @return SendPopupResponse
         */
        public async Task<SendPopupResponse> SendPopupAsync(SendPopupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendPopupHeaders headers = new SendPopupHeaders();
            return await SendPopupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发送钉钉搜索底纹
         *
         * @param request SendSearchShadeRequest
         * @param headers SendSearchShadeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendSearchShadeResponse
         */
        public SendSearchShadeResponse SendSearchShadeWithOptions(SendSearchShadeRequest request, SendSearchShadeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "SendSearchShade",
                Version = "watt_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/watt/searchShades/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendSearchShadeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发送钉钉搜索底纹
         *
         * @param request SendSearchShadeRequest
         * @param headers SendSearchShadeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendSearchShadeResponse
         */
        public async Task<SendSearchShadeResponse> SendSearchShadeWithOptionsAsync(SendSearchShadeRequest request, SendSearchShadeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
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
                Action = "SendSearchShade",
                Version = "watt_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/watt/searchShades/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendSearchShadeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发送钉钉搜索底纹
         *
         * @param request SendSearchShadeRequest
         * @return SendSearchShadeResponse
         */
        public SendSearchShadeResponse SendSearchShade(SendSearchShadeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendSearchShadeHeaders headers = new SendSearchShadeHeaders();
            return SendSearchShadeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发送钉钉搜索底纹
         *
         * @param request SendSearchShadeRequest
         * @return SendSearchShadeResponse
         */
        public async Task<SendSearchShadeResponse> SendSearchShadeAsync(SendSearchShadeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendSearchShadeHeaders headers = new SendSearchShadeHeaders();
            return await SendSearchShadeWithOptionsAsync(request, headers, runtime);
        }

    }
}
