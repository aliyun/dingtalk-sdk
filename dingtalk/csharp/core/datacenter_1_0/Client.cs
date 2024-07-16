// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0
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
         * @summary 关闭数据投递任务
         *
         * @param request CloseDataDeliverRequest
         * @param headers CloseDataDeliverHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloseDataDeliverResponse
         */
        public CloseDataDeliverResponse CloseDataDeliverWithOptions(CloseDataDeliverRequest request, CloseDataDeliverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverId))
            {
                query["deliverId"] = request.DeliverId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchingItemType))
            {
                query["dispatchingItemType"] = request.DispatchingItemType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "CloseDataDeliver",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dataDeliverServices/close",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseDataDeliverResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 关闭数据投递任务
         *
         * @param request CloseDataDeliverRequest
         * @param headers CloseDataDeliverHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloseDataDeliverResponse
         */
        public async Task<CloseDataDeliverResponse> CloseDataDeliverWithOptionsAsync(CloseDataDeliverRequest request, CloseDataDeliverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverId))
            {
                query["deliverId"] = request.DeliverId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchingItemType))
            {
                query["dispatchingItemType"] = request.DispatchingItemType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "CloseDataDeliver",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dataDeliverServices/close",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseDataDeliverResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 关闭数据投递任务
         *
         * @param request CloseDataDeliverRequest
         * @return CloseDataDeliverResponse
         */
        public CloseDataDeliverResponse CloseDataDeliver(CloseDataDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseDataDeliverHeaders headers = new CloseDataDeliverHeaders();
            return CloseDataDeliverWithOptions(request, headers, runtime);
        }

        /**
         * @summary 关闭数据投递任务
         *
         * @param request CloseDataDeliverRequest
         * @return CloseDataDeliverResponse
         */
        public async Task<CloseDataDeliverResponse> CloseDataDeliverAsync(CloseDataDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseDataDeliverHeaders headers = new CloseDataDeliverHeaders();
            return await CloseDataDeliverWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建数据投递
         *
         * @param request CreateDataDeliverRequest
         * @param headers CreateDataDeliverHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDataDeliverResponse
         */
        public CreateDataDeliverResponse CreateDataDeliverWithOptions(CreateDataDeliverRequest request, CreateDataDeliverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bizcode))
            {
                query["bizcode"] = request.Bizcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchingCycle))
            {
                query["dispatchingCycle"] = request.DispatchingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchingItemType))
            {
                query["dispatchingItemType"] = request.DispatchingItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchingStartDate))
            {
                query["dispatchingStartDate"] = request.DispatchingStartDate;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "CreateDataDeliver",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dataDeliveries",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataDeliverResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建数据投递
         *
         * @param request CreateDataDeliverRequest
         * @param headers CreateDataDeliverHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDataDeliverResponse
         */
        public async Task<CreateDataDeliverResponse> CreateDataDeliverWithOptionsAsync(CreateDataDeliverRequest request, CreateDataDeliverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bizcode))
            {
                query["bizcode"] = request.Bizcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchingCycle))
            {
                query["dispatchingCycle"] = request.DispatchingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchingItemType))
            {
                query["dispatchingItemType"] = request.DispatchingItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchingStartDate))
            {
                query["dispatchingStartDate"] = request.DispatchingStartDate;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "CreateDataDeliver",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dataDeliveries",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataDeliverResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建数据投递
         *
         * @param request CreateDataDeliverRequest
         * @return CreateDataDeliverResponse
         */
        public CreateDataDeliverResponse CreateDataDeliver(CreateDataDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDataDeliverHeaders headers = new CreateDataDeliverHeaders();
            return CreateDataDeliverWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建数据投递
         *
         * @param request CreateDataDeliverRequest
         * @return CreateDataDeliverResponse
         */
        public async Task<CreateDataDeliverResponse> CreateDataDeliverAsync(CreateDataDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDataDeliverHeaders headers = new CreateDataDeliverHeaders();
            return await CreateDataDeliverWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 工商-经营异常
         *
         * @param request GetAbnormalOperationRequest
         * @param headers GetAbnormalOperationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAbnormalOperationResponse
         */
        public GetAbnormalOperationResponse GetAbnormalOperationWithOptions(GetAbnormalOperationRequest request, GetAbnormalOperationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetAbnormalOperation",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/abnormalOperations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAbnormalOperationResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 工商-经营异常
         *
         * @param request GetAbnormalOperationRequest
         * @param headers GetAbnormalOperationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAbnormalOperationResponse
         */
        public async Task<GetAbnormalOperationResponse> GetAbnormalOperationWithOptionsAsync(GetAbnormalOperationRequest request, GetAbnormalOperationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetAbnormalOperation",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/abnormalOperations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAbnormalOperationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 工商-经营异常
         *
         * @param request GetAbnormalOperationRequest
         * @return GetAbnormalOperationResponse
         */
        public GetAbnormalOperationResponse GetAbnormalOperation(GetAbnormalOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAbnormalOperationHeaders headers = new GetAbnormalOperationHeaders();
            return GetAbnormalOperationWithOptions(request, headers, runtime);
        }

        /**
         * @summary 工商-经营异常
         *
         * @param request GetAbnormalOperationRequest
         * @return GetAbnormalOperationResponse
         */
        public async Task<GetAbnormalOperationResponse> GetAbnormalOperationAsync(GetAbnormalOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAbnormalOperationHeaders headers = new GetAbnormalOperationHeaders();
            return await GetAbnormalOperationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取工商-行政许可
         *
         * @param request GetAdministrativeLicensingRequest
         * @param headers GetAdministrativeLicensingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAdministrativeLicensingResponse
         */
        public GetAdministrativeLicensingResponse GetAdministrativeLicensingWithOptions(GetAdministrativeLicensingRequest request, GetAdministrativeLicensingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetAdministrativeLicensing",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/administrativeLicenses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdministrativeLicensingResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取工商-行政许可
         *
         * @param request GetAdministrativeLicensingRequest
         * @param headers GetAdministrativeLicensingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAdministrativeLicensingResponse
         */
        public async Task<GetAdministrativeLicensingResponse> GetAdministrativeLicensingWithOptionsAsync(GetAdministrativeLicensingRequest request, GetAdministrativeLicensingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetAdministrativeLicensing",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/administrativeLicenses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdministrativeLicensingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取工商-行政许可
         *
         * @param request GetAdministrativeLicensingRequest
         * @return GetAdministrativeLicensingResponse
         */
        public GetAdministrativeLicensingResponse GetAdministrativeLicensing(GetAdministrativeLicensingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAdministrativeLicensingHeaders headers = new GetAdministrativeLicensingHeaders();
            return GetAdministrativeLicensingWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取工商-行政许可
         *
         * @param request GetAdministrativeLicensingRequest
         * @return GetAdministrativeLicensingResponse
         */
        public async Task<GetAdministrativeLicensingResponse> GetAdministrativeLicensingAsync(GetAdministrativeLicensingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAdministrativeLicensingHeaders headers = new GetAdministrativeLicensingHeaders();
            return await GetAdministrativeLicensingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 负面-行政处罚
         *
         * @param request GetAdministrativePenaltiesRequest
         * @param headers GetAdministrativePenaltiesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAdministrativePenaltiesResponse
         */
        public GetAdministrativePenaltiesResponse GetAdministrativePenaltiesWithOptions(GetAdministrativePenaltiesRequest request, GetAdministrativePenaltiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetAdministrativePenalties",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/administrativePenalties",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdministrativePenaltiesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 负面-行政处罚
         *
         * @param request GetAdministrativePenaltiesRequest
         * @param headers GetAdministrativePenaltiesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAdministrativePenaltiesResponse
         */
        public async Task<GetAdministrativePenaltiesResponse> GetAdministrativePenaltiesWithOptionsAsync(GetAdministrativePenaltiesRequest request, GetAdministrativePenaltiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetAdministrativePenalties",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/administrativePenalties",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdministrativePenaltiesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 负面-行政处罚
         *
         * @param request GetAdministrativePenaltiesRequest
         * @return GetAdministrativePenaltiesResponse
         */
        public GetAdministrativePenaltiesResponse GetAdministrativePenalties(GetAdministrativePenaltiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAdministrativePenaltiesHeaders headers = new GetAdministrativePenaltiesHeaders();
            return GetAdministrativePenaltiesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 负面-行政处罚
         *
         * @param request GetAdministrativePenaltiesRequest
         * @return GetAdministrativePenaltiesResponse
         */
        public async Task<GetAdministrativePenaltiesResponse> GetAdministrativePenaltiesAsync(GetAdministrativePenaltiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAdministrativePenaltiesHeaders headers = new GetAdministrativePenaltiesHeaders();
            return await GetAdministrativePenaltiesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 工商-基础信息
         *
         * @param request GetBasicInfoRequest
         * @param headers GetBasicInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBasicInfoResponse
         */
        public GetBasicInfoResponse GetBasicInfoWithOptions(GetBasicInfoRequest request, GetBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetBasicInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/businessBasicInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBasicInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 工商-基础信息
         *
         * @param request GetBasicInfoRequest
         * @param headers GetBasicInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBasicInfoResponse
         */
        public async Task<GetBasicInfoResponse> GetBasicInfoWithOptionsAsync(GetBasicInfoRequest request, GetBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetBasicInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/businessBasicInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBasicInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 工商-基础信息
         *
         * @param request GetBasicInfoRequest
         * @return GetBasicInfoResponse
         */
        public GetBasicInfoResponse GetBasicInfo(GetBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBasicInfoHeaders headers = new GetBasicInfoHeaders();
            return GetBasicInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 工商-基础信息
         *
         * @param request GetBasicInfoRequest
         * @return GetBasicInfoResponse
         */
        public async Task<GetBasicInfoResponse> GetBasicInfoAsync(GetBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBasicInfoHeaders headers = new GetBasicInfoHeaders();
            return await GetBasicInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取经营-招投标信息
         *
         * @param request GetBiddingInfoRequest
         * @param headers GetBiddingInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBiddingInfoResponse
         */
        public GetBiddingInfoResponse GetBiddingInfoWithOptions(GetBiddingInfoRequest request, GetBiddingInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetBiddingInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/biddingInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBiddingInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取经营-招投标信息
         *
         * @param request GetBiddingInfoRequest
         * @param headers GetBiddingInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBiddingInfoResponse
         */
        public async Task<GetBiddingInfoResponse> GetBiddingInfoWithOptionsAsync(GetBiddingInfoRequest request, GetBiddingInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetBiddingInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/biddingInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBiddingInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取经营-招投标信息
         *
         * @param request GetBiddingInfoRequest
         * @return GetBiddingInfoResponse
         */
        public GetBiddingInfoResponse GetBiddingInfo(GetBiddingInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBiddingInfoHeaders headers = new GetBiddingInfoHeaders();
            return GetBiddingInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取经营-招投标信息
         *
         * @param request GetBiddingInfoRequest
         * @return GetBiddingInfoResponse
         */
        public async Task<GetBiddingInfoResponse> GetBiddingInfoAsync(GetBiddingInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBiddingInfoHeaders headers = new GetBiddingInfoHeaders();
            return await GetBiddingInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取工商-分支机构
         *
         * @param request GetBranchInfoRequest
         * @param headers GetBranchInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBranchInfoResponse
         */
        public GetBranchInfoResponse GetBranchInfoWithOptions(GetBranchInfoRequest request, GetBranchInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetBranchInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/branchInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBranchInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取工商-分支机构
         *
         * @param request GetBranchInfoRequest
         * @param headers GetBranchInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBranchInfoResponse
         */
        public async Task<GetBranchInfoResponse> GetBranchInfoWithOptionsAsync(GetBranchInfoRequest request, GetBranchInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetBranchInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/branchInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBranchInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取工商-分支机构
         *
         * @param request GetBranchInfoRequest
         * @return GetBranchInfoResponse
         */
        public GetBranchInfoResponse GetBranchInfo(GetBranchInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBranchInfoHeaders headers = new GetBranchInfoHeaders();
            return GetBranchInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取工商-分支机构
         *
         * @param request GetBranchInfoRequest
         * @return GetBranchInfoResponse
         */
        public async Task<GetBranchInfoResponse> GetBranchInfoAsync(GetBranchInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBranchInfoHeaders headers = new GetBranchInfoHeaders();
            return await GetBranchInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取工商-变更记录
         *
         * @param request GetChangeRecordRequest
         * @param headers GetChangeRecordHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetChangeRecordResponse
         */
        public GetChangeRecordResponse GetChangeRecordWithOptions(GetChangeRecordRequest request, GetChangeRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetChangeRecord",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/changeRecords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChangeRecordResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取工商-变更记录
         *
         * @param request GetChangeRecordRequest
         * @param headers GetChangeRecordHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetChangeRecordResponse
         */
        public async Task<GetChangeRecordResponse> GetChangeRecordWithOptionsAsync(GetChangeRecordRequest request, GetChangeRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetChangeRecord",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/changeRecords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChangeRecordResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取工商-变更记录
         *
         * @param request GetChangeRecordRequest
         * @return GetChangeRecordResponse
         */
        public GetChangeRecordResponse GetChangeRecord(GetChangeRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetChangeRecordHeaders headers = new GetChangeRecordHeaders();
            return GetChangeRecordWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取工商-变更记录
         *
         * @param request GetChangeRecordRequest
         * @return GetChangeRecordResponse
         */
        public async Task<GetChangeRecordResponse> GetChangeRecordAsync(GetChangeRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetChangeRecordHeaders headers = new GetChangeRecordHeaders();
            return await GetChangeRecordWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取投递任务信息
         *
         * @param request GetDataDeliverRequest
         * @param headers GetDataDeliverHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDataDeliverResponse
         */
        public GetDataDeliverResponse GetDataDeliverWithOptions(GetDataDeliverRequest request, GetDataDeliverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverId))
            {
                query["deliverId"] = request.DeliverId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchingItemType))
            {
                query["dispatchingItemType"] = request.DispatchingItemType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetDataDeliver",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dataDeliverServices/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataDeliverResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取投递任务信息
         *
         * @param request GetDataDeliverRequest
         * @param headers GetDataDeliverHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDataDeliverResponse
         */
        public async Task<GetDataDeliverResponse> GetDataDeliverWithOptionsAsync(GetDataDeliverRequest request, GetDataDeliverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverId))
            {
                query["deliverId"] = request.DeliverId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchingItemType))
            {
                query["dispatchingItemType"] = request.DispatchingItemType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetDataDeliver",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dataDeliverServices/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataDeliverResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取投递任务信息
         *
         * @param request GetDataDeliverRequest
         * @return GetDataDeliverResponse
         */
        public GetDataDeliverResponse GetDataDeliver(GetDataDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDataDeliverHeaders headers = new GetDataDeliverHeaders();
            return GetDataDeliverWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取投递任务信息
         *
         * @param request GetDataDeliverRequest
         * @return GetDataDeliverResponse
         */
        public async Task<GetDataDeliverResponse> GetDataDeliverAsync(GetDataDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDataDeliverHeaders headers = new GetDataDeliverHeaders();
            return await GetDataDeliverWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取知识产权-域名信息
         *
         * @param request GetDomainInfoRequest
         * @param headers GetDomainInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDomainInfoResponse
         */
        public GetDomainInfoResponse GetDomainInfoWithOptions(GetDomainInfoRequest request, GetDomainInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetDomainInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/domainInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取知识产权-域名信息
         *
         * @param request GetDomainInfoRequest
         * @param headers GetDomainInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDomainInfoResponse
         */
        public async Task<GetDomainInfoResponse> GetDomainInfoWithOptionsAsync(GetDomainInfoRequest request, GetDomainInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetDomainInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/domainInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取知识产权-域名信息
         *
         * @param request GetDomainInfoRequest
         * @return GetDomainInfoResponse
         */
        public GetDomainInfoResponse GetDomainInfo(GetDomainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDomainInfoHeaders headers = new GetDomainInfoHeaders();
            return GetDomainInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取知识产权-域名信息
         *
         * @param request GetDomainInfoRequest
         * @return GetDomainInfoResponse
         */
        public async Task<GetDomainInfoResponse> GetDomainInfoAsync(GetDomainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDomainInfoHeaders headers = new GetDomainInfoHeaders();
            return await GetDomainInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取工商-双随机抽查结果
         *
         * @param request GetDoubleRandomRequest
         * @param headers GetDoubleRandomHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoubleRandomResponse
         */
        public GetDoubleRandomResponse GetDoubleRandomWithOptions(GetDoubleRandomRequest request, GetDoubleRandomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetDoubleRandom",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/doubleRandomness",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoubleRandomResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取工商-双随机抽查结果
         *
         * @param request GetDoubleRandomRequest
         * @param headers GetDoubleRandomHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoubleRandomResponse
         */
        public async Task<GetDoubleRandomResponse> GetDoubleRandomWithOptionsAsync(GetDoubleRandomRequest request, GetDoubleRandomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetDoubleRandom",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/doubleRandomness",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoubleRandomResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取工商-双随机抽查结果
         *
         * @param request GetDoubleRandomRequest
         * @return GetDoubleRandomResponse
         */
        public GetDoubleRandomResponse GetDoubleRandom(GetDoubleRandomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDoubleRandomHeaders headers = new GetDoubleRandomHeaders();
            return GetDoubleRandomWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取工商-双随机抽查结果
         *
         * @param request GetDoubleRandomRequest
         * @return GetDoubleRandomResponse
         */
        public async Task<GetDoubleRandomResponse> GetDoubleRandomAsync(GetDoubleRandomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDoubleRandomHeaders headers = new GetDoubleRandomHeaders();
            return await GetDoubleRandomWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 负面-环保处罚
         *
         * @param request GetEnvironmentalPenaltiesRequest
         * @param headers GetEnvironmentalPenaltiesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEnvironmentalPenaltiesResponse
         */
        public GetEnvironmentalPenaltiesResponse GetEnvironmentalPenaltiesWithOptions(GetEnvironmentalPenaltiesRequest request, GetEnvironmentalPenaltiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetEnvironmentalPenalties",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/environmentalPenalties",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnvironmentalPenaltiesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 负面-环保处罚
         *
         * @param request GetEnvironmentalPenaltiesRequest
         * @param headers GetEnvironmentalPenaltiesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEnvironmentalPenaltiesResponse
         */
        public async Task<GetEnvironmentalPenaltiesResponse> GetEnvironmentalPenaltiesWithOptionsAsync(GetEnvironmentalPenaltiesRequest request, GetEnvironmentalPenaltiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetEnvironmentalPenalties",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/environmentalPenalties",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnvironmentalPenaltiesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 负面-环保处罚
         *
         * @param request GetEnvironmentalPenaltiesRequest
         * @return GetEnvironmentalPenaltiesResponse
         */
        public GetEnvironmentalPenaltiesResponse GetEnvironmentalPenalties(GetEnvironmentalPenaltiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEnvironmentalPenaltiesHeaders headers = new GetEnvironmentalPenaltiesHeaders();
            return GetEnvironmentalPenaltiesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 负面-环保处罚
         *
         * @param request GetEnvironmentalPenaltiesRequest
         * @return GetEnvironmentalPenaltiesResponse
         */
        public async Task<GetEnvironmentalPenaltiesResponse> GetEnvironmentalPenaltiesAsync(GetEnvironmentalPenaltiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEnvironmentalPenaltiesHeaders headers = new GetEnvironmentalPenaltiesHeaders();
            return await GetEnvironmentalPenaltiesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取事件订阅的数据
         *
         * @param request GetEventDataRequest
         * @param headers GetEventDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEventDataResponse
         */
        public GetEventDataResponse GetEventDataWithOptions(GetEventDataRequest request, GetEventDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventUid))
            {
                body["eventUid"] = request.EventUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubId))
            {
                body["subId"] = request.SubId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEventData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/eventDatas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取事件订阅的数据
         *
         * @param request GetEventDataRequest
         * @param headers GetEventDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEventDataResponse
         */
        public async Task<GetEventDataResponse> GetEventDataWithOptionsAsync(GetEventDataRequest request, GetEventDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventUid))
            {
                body["eventUid"] = request.EventUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubId))
            {
                body["subId"] = request.SubId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEventData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/eventDatas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取事件订阅的数据
         *
         * @param request GetEventDataRequest
         * @return GetEventDataResponse
         */
        public GetEventDataResponse GetEventData(GetEventDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEventDataHeaders headers = new GetEventDataHeaders();
            return GetEventDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取事件订阅的数据
         *
         * @param request GetEventDataRequest
         * @return GetEventDataResponse
         */
        public async Task<GetEventDataResponse> GetEventDataAsync(GetEventDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEventDataHeaders headers = new GetEventDataHeaders();
            return await GetEventDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 工商-股东信息
         *
         * @param request GetHolderInfoRequest
         * @param headers GetHolderInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHolderInfoResponse
         */
        public GetHolderInfoResponse GetHolderInfoWithOptions(GetHolderInfoRequest request, GetHolderInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetHolderInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/shareholderInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHolderInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 工商-股东信息
         *
         * @param request GetHolderInfoRequest
         * @param headers GetHolderInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHolderInfoResponse
         */
        public async Task<GetHolderInfoResponse> GetHolderInfoWithOptionsAsync(GetHolderInfoRequest request, GetHolderInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetHolderInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/shareholderInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHolderInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 工商-股东信息
         *
         * @param request GetHolderInfoRequest
         * @return GetHolderInfoResponse
         */
        public GetHolderInfoResponse GetHolderInfo(GetHolderInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHolderInfoHeaders headers = new GetHolderInfoHeaders();
            return GetHolderInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 工商-股东信息
         *
         * @param request GetHolderInfoRequest
         * @return GetHolderInfoResponse
         */
        public async Task<GetHolderInfoResponse> GetHolderInfoAsync(GetHolderInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHolderInfoHeaders headers = new GetHolderInfoHeaders();
            return await GetHolderInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取工商-知识产权出质
         *
         * @param request GetIntellectualPropertyRequest
         * @param headers GetIntellectualPropertyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIntellectualPropertyResponse
         */
        public GetIntellectualPropertyResponse GetIntellectualPropertyWithOptions(GetIntellectualPropertyRequest request, GetIntellectualPropertyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetIntellectualProperty",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/intellectualProperties",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIntellectualPropertyResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取工商-知识产权出质
         *
         * @param request GetIntellectualPropertyRequest
         * @param headers GetIntellectualPropertyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIntellectualPropertyResponse
         */
        public async Task<GetIntellectualPropertyResponse> GetIntellectualPropertyWithOptionsAsync(GetIntellectualPropertyRequest request, GetIntellectualPropertyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetIntellectualProperty",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/intellectualProperties",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIntellectualPropertyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取工商-知识产权出质
         *
         * @param request GetIntellectualPropertyRequest
         * @return GetIntellectualPropertyResponse
         */
        public GetIntellectualPropertyResponse GetIntellectualProperty(GetIntellectualPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIntellectualPropertyHeaders headers = new GetIntellectualPropertyHeaders();
            return GetIntellectualPropertyWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取工商-知识产权出质
         *
         * @param request GetIntellectualPropertyRequest
         * @return GetIntellectualPropertyResponse
         */
        public async Task<GetIntellectualPropertyResponse> GetIntellectualPropertyAsync(GetIntellectualPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIntellectualPropertyHeaders headers = new GetIntellectualPropertyHeaders();
            return await GetIntellectualPropertyWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取工商-对外投资
         *
         * @param request GetInvestmentAbroadRequest
         * @param headers GetInvestmentAbroadHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInvestmentAbroadResponse
         */
        public GetInvestmentAbroadResponse GetInvestmentAbroadWithOptions(GetInvestmentAbroadRequest request, GetInvestmentAbroadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetInvestmentAbroad",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/abroadInvestments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInvestmentAbroadResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取工商-对外投资
         *
         * @param request GetInvestmentAbroadRequest
         * @param headers GetInvestmentAbroadHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInvestmentAbroadResponse
         */
        public async Task<GetInvestmentAbroadResponse> GetInvestmentAbroadWithOptionsAsync(GetInvestmentAbroadRequest request, GetInvestmentAbroadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetInvestmentAbroad",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/abroadInvestments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInvestmentAbroadResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取工商-对外投资
         *
         * @param request GetInvestmentAbroadRequest
         * @return GetInvestmentAbroadResponse
         */
        public GetInvestmentAbroadResponse GetInvestmentAbroad(GetInvestmentAbroadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInvestmentAbroadHeaders headers = new GetInvestmentAbroadHeaders();
            return GetInvestmentAbroadWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取工商-对外投资
         *
         * @param request GetInvestmentAbroadRequest
         * @return GetInvestmentAbroadResponse
         */
        public async Task<GetInvestmentAbroadResponse> GetInvestmentAbroadAsync(GetInvestmentAbroadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInvestmentAbroadHeaders headers = new GetInvestmentAbroadHeaders();
            return await GetInvestmentAbroadWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取经营-招聘信息
         *
         * @param request GetJobInfoRequest
         * @param headers GetJobInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobInfoResponse
         */
        public GetJobInfoResponse GetJobInfoWithOptions(GetJobInfoRequest request, GetJobInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetJobInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/jobInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取经营-招聘信息
         *
         * @param request GetJobInfoRequest
         * @param headers GetJobInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobInfoResponse
         */
        public async Task<GetJobInfoResponse> GetJobInfoWithOptionsAsync(GetJobInfoRequest request, GetJobInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetJobInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/jobInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取经营-招聘信息
         *
         * @param request GetJobInfoRequest
         * @return GetJobInfoResponse
         */
        public GetJobInfoResponse GetJobInfo(GetJobInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobInfoHeaders headers = new GetJobInfoHeaders();
            return GetJobInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取经营-招聘信息
         *
         * @param request GetJobInfoRequest
         * @return GetJobInfoResponse
         */
        public async Task<GetJobInfoResponse> GetJobInfoAsync(GetJobInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobInfoHeaders headers = new GetJobInfoHeaders();
            return await GetJobInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取知识产权-专利信息
         *
         * @param request GetPatentInfoRequest
         * @param headers GetPatentInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPatentInfoResponse
         */
        public GetPatentInfoResponse GetPatentInfoWithOptions(GetPatentInfoRequest request, GetPatentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetPatentInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/patentInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPatentInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取知识产权-专利信息
         *
         * @param request GetPatentInfoRequest
         * @param headers GetPatentInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPatentInfoResponse
         */
        public async Task<GetPatentInfoResponse> GetPatentInfoWithOptionsAsync(GetPatentInfoRequest request, GetPatentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetPatentInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/patentInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPatentInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取知识产权-专利信息
         *
         * @param request GetPatentInfoRequest
         * @return GetPatentInfoResponse
         */
        public GetPatentInfoResponse GetPatentInfo(GetPatentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPatentInfoHeaders headers = new GetPatentInfoHeaders();
            return GetPatentInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取知识产权-专利信息
         *
         * @param request GetPatentInfoRequest
         * @return GetPatentInfoResponse
         */
        public async Task<GetPatentInfoResponse> GetPatentInfoAsync(GetPatentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPatentInfoHeaders headers = new GetPatentInfoHeaders();
            return await GetPatentInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取工商-主要人员
         *
         * @param request GetPrincipalEmployeeRequest
         * @param headers GetPrincipalEmployeeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPrincipalEmployeeResponse
         */
        public GetPrincipalEmployeeResponse GetPrincipalEmployeeWithOptions(GetPrincipalEmployeeRequest request, GetPrincipalEmployeeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetPrincipalEmployee",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/principalEmployees",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrincipalEmployeeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取工商-主要人员
         *
         * @param request GetPrincipalEmployeeRequest
         * @param headers GetPrincipalEmployeeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPrincipalEmployeeResponse
         */
        public async Task<GetPrincipalEmployeeResponse> GetPrincipalEmployeeWithOptionsAsync(GetPrincipalEmployeeRequest request, GetPrincipalEmployeeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetPrincipalEmployee",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/principalEmployees",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrincipalEmployeeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取工商-主要人员
         *
         * @param request GetPrincipalEmployeeRequest
         * @return GetPrincipalEmployeeResponse
         */
        public GetPrincipalEmployeeResponse GetPrincipalEmployee(GetPrincipalEmployeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPrincipalEmployeeHeaders headers = new GetPrincipalEmployeeHeaders();
            return GetPrincipalEmployeeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取工商-主要人员
         *
         * @param request GetPrincipalEmployeeRequest
         * @return GetPrincipalEmployeeResponse
         */
        public async Task<GetPrincipalEmployeeResponse> GetPrincipalEmployeeAsync(GetPrincipalEmployeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPrincipalEmployeeHeaders headers = new GetPrincipalEmployeeHeaders();
            return await GetPrincipalEmployeeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 经营-一般纳税人
         *
         * @param request GetQeneralTaxpayerInfoRequest
         * @param headers GetQeneralTaxpayerInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQeneralTaxpayerInfoResponse
         */
        public GetQeneralTaxpayerInfoResponse GetQeneralTaxpayerInfoWithOptions(GetQeneralTaxpayerInfoRequest request, GetQeneralTaxpayerInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetQeneralTaxpayerInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/generalTaxpayerInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQeneralTaxpayerInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 经营-一般纳税人
         *
         * @param request GetQeneralTaxpayerInfoRequest
         * @param headers GetQeneralTaxpayerInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQeneralTaxpayerInfoResponse
         */
        public async Task<GetQeneralTaxpayerInfoResponse> GetQeneralTaxpayerInfoWithOptionsAsync(GetQeneralTaxpayerInfoRequest request, GetQeneralTaxpayerInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetQeneralTaxpayerInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/generalTaxpayerInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQeneralTaxpayerInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 经营-一般纳税人
         *
         * @param request GetQeneralTaxpayerInfoRequest
         * @return GetQeneralTaxpayerInfoResponse
         */
        public GetQeneralTaxpayerInfoResponse GetQeneralTaxpayerInfo(GetQeneralTaxpayerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetQeneralTaxpayerInfoHeaders headers = new GetQeneralTaxpayerInfoHeaders();
            return GetQeneralTaxpayerInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 经营-一般纳税人
         *
         * @param request GetQeneralTaxpayerInfoRequest
         * @return GetQeneralTaxpayerInfoResponse
         */
        public async Task<GetQeneralTaxpayerInfoResponse> GetQeneralTaxpayerInfoAsync(GetQeneralTaxpayerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetQeneralTaxpayerInfoHeaders headers = new GetQeneralTaxpayerInfoHeaders();
            return await GetQeneralTaxpayerInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取知识产权-资质证书
         *
         * @param request GetQualificationCertRequest
         * @param headers GetQualificationCertHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQualificationCertResponse
         */
        public GetQualificationCertResponse GetQualificationCertWithOptions(GetQualificationCertRequest request, GetQualificationCertHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetQualificationCert",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/qualificationCerts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualificationCertResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取知识产权-资质证书
         *
         * @param request GetQualificationCertRequest
         * @param headers GetQualificationCertHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQualificationCertResponse
         */
        public async Task<GetQualificationCertResponse> GetQualificationCertWithOptionsAsync(GetQualificationCertRequest request, GetQualificationCertHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetQualificationCert",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/qualificationCerts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualificationCertResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取知识产权-资质证书
         *
         * @param request GetQualificationCertRequest
         * @return GetQualificationCertResponse
         */
        public GetQualificationCertResponse GetQualificationCert(GetQualificationCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetQualificationCertHeaders headers = new GetQualificationCertHeaders();
            return GetQualificationCertWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取知识产权-资质证书
         *
         * @param request GetQualificationCertRequest
         * @return GetQualificationCertResponse
         */
        public async Task<GetQualificationCertResponse> GetQualificationCertAsync(GetQualificationCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetQualificationCertHeaders headers = new GetQualificationCertHeaders();
            return await GetQualificationCertWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 负面-严重违法
         *
         * @param request GetSeriousViolationRequest
         * @param headers GetSeriousViolationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSeriousViolationResponse
         */
        public GetSeriousViolationResponse GetSeriousViolationWithOptions(GetSeriousViolationRequest request, GetSeriousViolationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetSeriousViolation",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/seriousViolations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSeriousViolationResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 负面-严重违法
         *
         * @param request GetSeriousViolationRequest
         * @param headers GetSeriousViolationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSeriousViolationResponse
         */
        public async Task<GetSeriousViolationResponse> GetSeriousViolationWithOptionsAsync(GetSeriousViolationRequest request, GetSeriousViolationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetSeriousViolation",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/seriousViolations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSeriousViolationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 负面-严重违法
         *
         * @param request GetSeriousViolationRequest
         * @return GetSeriousViolationResponse
         */
        public GetSeriousViolationResponse GetSeriousViolation(GetSeriousViolationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSeriousViolationHeaders headers = new GetSeriousViolationHeaders();
            return GetSeriousViolationWithOptions(request, headers, runtime);
        }

        /**
         * @summary 负面-严重违法
         *
         * @param request GetSeriousViolationRequest
         * @return GetSeriousViolationResponse
         */
        public async Task<GetSeriousViolationResponse> GetSeriousViolationAsync(GetSeriousViolationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSeriousViolationHeaders headers = new GetSeriousViolationHeaders();
            return await GetSeriousViolationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取知识产权-软件著作权
         *
         * @param request GetSoftwareCopyrightRequest
         * @param headers GetSoftwareCopyrightHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSoftwareCopyrightResponse
         */
        public GetSoftwareCopyrightResponse GetSoftwareCopyrightWithOptions(GetSoftwareCopyrightRequest request, GetSoftwareCopyrightHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetSoftwareCopyright",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/softwareCopyrights",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSoftwareCopyrightResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取知识产权-软件著作权
         *
         * @param request GetSoftwareCopyrightRequest
         * @param headers GetSoftwareCopyrightHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSoftwareCopyrightResponse
         */
        public async Task<GetSoftwareCopyrightResponse> GetSoftwareCopyrightWithOptionsAsync(GetSoftwareCopyrightRequest request, GetSoftwareCopyrightHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetSoftwareCopyright",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/softwareCopyrights",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSoftwareCopyrightResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取知识产权-软件著作权
         *
         * @param request GetSoftwareCopyrightRequest
         * @return GetSoftwareCopyrightResponse
         */
        public GetSoftwareCopyrightResponse GetSoftwareCopyright(GetSoftwareCopyrightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSoftwareCopyrightHeaders headers = new GetSoftwareCopyrightHeaders();
            return GetSoftwareCopyrightWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取知识产权-软件著作权
         *
         * @param request GetSoftwareCopyrightRequest
         * @return GetSoftwareCopyrightResponse
         */
        public async Task<GetSoftwareCopyrightResponse> GetSoftwareCopyrightAsync(GetSoftwareCopyrightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSoftwareCopyrightHeaders headers = new GetSoftwareCopyrightHeaders();
            return await GetSoftwareCopyrightWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取知识产权-商标信息
         *
         * @param request GetTrademarkInfoRequest
         * @param headers GetTrademarkInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTrademarkInfoResponse
         */
        public GetTrademarkInfoResponse GetTrademarkInfoWithOptions(GetTrademarkInfoRequest request, GetTrademarkInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetTrademarkInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/trademarkInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrademarkInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取知识产权-商标信息
         *
         * @param request GetTrademarkInfoRequest
         * @param headers GetTrademarkInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTrademarkInfoResponse
         */
        public async Task<GetTrademarkInfoResponse> GetTrademarkInfoWithOptionsAsync(GetTrademarkInfoRequest request, GetTrademarkInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetTrademarkInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/trademarkInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrademarkInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取知识产权-商标信息
         *
         * @param request GetTrademarkInfoRequest
         * @return GetTrademarkInfoResponse
         */
        public GetTrademarkInfoResponse GetTrademarkInfo(GetTrademarkInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTrademarkInfoHeaders headers = new GetTrademarkInfoHeaders();
            return GetTrademarkInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取知识产权-商标信息
         *
         * @param request GetTrademarkInfoRequest
         * @return GetTrademarkInfoResponse
         */
        public async Task<GetTrademarkInfoResponse> GetTrademarkInfoAsync(GetTrademarkInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTrademarkInfoHeaders headers = new GetTrademarkInfoHeaders();
            return await GetTrademarkInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取知识产权-作品著作权
         *
         * @param request GetWorkCopyrightRequest
         * @param headers GetWorkCopyrightHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkCopyrightResponse
         */
        public GetWorkCopyrightResponse GetWorkCopyrightWithOptions(GetWorkCopyrightRequest request, GetWorkCopyrightHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetWorkCopyright",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/workCopyrights",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkCopyrightResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取知识产权-作品著作权
         *
         * @param request GetWorkCopyrightRequest
         * @param headers GetWorkCopyrightHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkCopyrightResponse
         */
        public async Task<GetWorkCopyrightResponse> GetWorkCopyrightWithOptionsAsync(GetWorkCopyrightRequest request, GetWorkCopyrightHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "GetWorkCopyright",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/workCopyrights",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkCopyrightResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取知识产权-作品著作权
         *
         * @param request GetWorkCopyrightRequest
         * @return GetWorkCopyrightResponse
         */
        public GetWorkCopyrightResponse GetWorkCopyright(GetWorkCopyrightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkCopyrightHeaders headers = new GetWorkCopyrightHeaders();
            return GetWorkCopyrightWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取知识产权-作品著作权
         *
         * @param request GetWorkCopyrightRequest
         * @return GetWorkCopyrightResponse
         */
        public async Task<GetWorkCopyrightResponse> GetWorkCopyrightAsync(GetWorkCopyrightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkCopyrightHeaders headers = new GetWorkCopyrightHeaders();
            return await GetWorkCopyrightWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 数据投递列表
         *
         * @param request ListDataDeliversRequest
         * @param headers ListDataDeliversHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDataDeliversResponse
         */
        public ListDataDeliversResponse ListDataDeliversWithOptions(ListDataDeliversRequest request, ListDataDeliversHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchingItemType))
            {
                query["dispatchingItemType"] = request.DispatchingItemType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListDataDelivers",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dataDeliverServices/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataDeliversResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 数据投递列表
         *
         * @param request ListDataDeliversRequest
         * @param headers ListDataDeliversHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDataDeliversResponse
         */
        public async Task<ListDataDeliversResponse> ListDataDeliversWithOptionsAsync(ListDataDeliversRequest request, ListDataDeliversHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchingItemType))
            {
                query["dispatchingItemType"] = request.DispatchingItemType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "ListDataDelivers",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dataDeliverServices/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataDeliversResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 数据投递列表
         *
         * @param request ListDataDeliversRequest
         * @return ListDataDeliversResponse
         */
        public ListDataDeliversResponse ListDataDelivers(ListDataDeliversRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDataDeliversHeaders headers = new ListDataDeliversHeaders();
            return ListDataDeliversWithOptions(request, headers, runtime);
        }

        /**
         * @summary 数据投递列表
         *
         * @param request ListDataDeliversRequest
         * @return ListDataDeliversResponse
         */
        public async Task<ListDataDeliversResponse> ListDataDeliversAsync(ListDataDeliversRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDataDeliversHeaders headers = new ListDataDeliversHeaders();
            return await ListDataDeliversWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 企业授权信息
         *
         * @param headers PostCorpAuthInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PostCorpAuthInfoResponse
         */
        public PostCorpAuthInfoResponse PostCorpAuthInfoWithOptions(PostCorpAuthInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "PostCorpAuthInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/corporations/authorize",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostCorpAuthInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 企业授权信息
         *
         * @param headers PostCorpAuthInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PostCorpAuthInfoResponse
         */
        public async Task<PostCorpAuthInfoResponse> PostCorpAuthInfoWithOptionsAsync(PostCorpAuthInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "PostCorpAuthInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/corporations/authorize",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostCorpAuthInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 企业授权信息
         *
         * @return PostCorpAuthInfoResponse
         */
        public PostCorpAuthInfoResponse PostCorpAuthInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PostCorpAuthInfoHeaders headers = new PostCorpAuthInfoHeaders();
            return PostCorpAuthInfoWithOptions(headers, runtime);
        }

        /**
         * @summary 企业授权信息
         *
         * @return PostCorpAuthInfoResponse
         */
        public async Task<PostCorpAuthInfoResponse> PostCorpAuthInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PostCorpAuthInfoHeaders headers = new PostCorpAuthInfoHeaders();
            return await PostCorpAuthInfoWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 获取企业用户激活状态统计数据
         *
         * @param request QueryActiveUserStatisticalDataRequest
         * @param headers QueryActiveUserStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryActiveUserStatisticalDataResponse
         */
        public QueryActiveUserStatisticalDataResponse QueryActiveUserStatisticalDataWithOptions(QueryActiveUserStatisticalDataRequest request, QueryActiveUserStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryActiveUserStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/activeUserData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryActiveUserStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业用户激活状态统计数据
         *
         * @param request QueryActiveUserStatisticalDataRequest
         * @param headers QueryActiveUserStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryActiveUserStatisticalDataResponse
         */
        public async Task<QueryActiveUserStatisticalDataResponse> QueryActiveUserStatisticalDataWithOptionsAsync(QueryActiveUserStatisticalDataRequest request, QueryActiveUserStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryActiveUserStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/activeUserData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryActiveUserStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业用户激活状态统计数据
         *
         * @param request QueryActiveUserStatisticalDataRequest
         * @return QueryActiveUserStatisticalDataResponse
         */
        public QueryActiveUserStatisticalDataResponse QueryActiveUserStatisticalData(QueryActiveUserStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryActiveUserStatisticalDataHeaders headers = new QueryActiveUserStatisticalDataHeaders();
            return QueryActiveUserStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业用户激活状态统计数据
         *
         * @param request QueryActiveUserStatisticalDataRequest
         * @return QueryActiveUserStatisticalDataResponse
         */
        public async Task<QueryActiveUserStatisticalDataResponse> QueryActiveUserStatisticalDataAsync(QueryActiveUserStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryActiveUserStatisticalDataHeaders headers = new QueryActiveUserStatisticalDataHeaders();
            return await QueryActiveUserStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取安恒密盾统计数据
         *
         * @param request QueryAnhmdStatisticalDataRequest
         * @param headers QueryAnhmdStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAnhmdStatisticalDataResponse
         */
        public QueryAnhmdStatisticalDataResponse QueryAnhmdStatisticalDataWithOptions(QueryAnhmdStatisticalDataRequest request, QueryAnhmdStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryAnhmdStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/statisticDatas/anHmd",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAnhmdStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取安恒密盾统计数据
         *
         * @param request QueryAnhmdStatisticalDataRequest
         * @param headers QueryAnhmdStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAnhmdStatisticalDataResponse
         */
        public async Task<QueryAnhmdStatisticalDataResponse> QueryAnhmdStatisticalDataWithOptionsAsync(QueryAnhmdStatisticalDataRequest request, QueryAnhmdStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryAnhmdStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/statisticDatas/anHmd",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAnhmdStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取安恒密盾统计数据
         *
         * @param request QueryAnhmdStatisticalDataRequest
         * @return QueryAnhmdStatisticalDataResponse
         */
        public QueryAnhmdStatisticalDataResponse QueryAnhmdStatisticalData(QueryAnhmdStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAnhmdStatisticalDataHeaders headers = new QueryAnhmdStatisticalDataHeaders();
            return QueryAnhmdStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取安恒密盾统计数据
         *
         * @param request QueryAnhmdStatisticalDataRequest
         * @return QueryAnhmdStatisticalDataResponse
         */
        public async Task<QueryAnhmdStatisticalDataResponse> QueryAnhmdStatisticalDataAsync(QueryAnhmdStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAnhmdStatisticalDataHeaders headers = new QueryAnhmdStatisticalDataHeaders();
            return await QueryAnhmdStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业审批统计数据
         *
         * @param request QueryApprovalStatisticalDataRequest
         * @param headers QueryApprovalStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryApprovalStatisticalDataResponse
         */
        public QueryApprovalStatisticalDataResponse QueryApprovalStatisticalDataWithOptions(QueryApprovalStatisticalDataRequest request, QueryApprovalStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryApprovalStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/approvalData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryApprovalStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业审批统计数据
         *
         * @param request QueryApprovalStatisticalDataRequest
         * @param headers QueryApprovalStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryApprovalStatisticalDataResponse
         */
        public async Task<QueryApprovalStatisticalDataResponse> QueryApprovalStatisticalDataWithOptionsAsync(QueryApprovalStatisticalDataRequest request, QueryApprovalStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryApprovalStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/approvalData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryApprovalStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业审批统计数据
         *
         * @param request QueryApprovalStatisticalDataRequest
         * @return QueryApprovalStatisticalDataResponse
         */
        public QueryApprovalStatisticalDataResponse QueryApprovalStatisticalData(QueryApprovalStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryApprovalStatisticalDataHeaders headers = new QueryApprovalStatisticalDataHeaders();
            return QueryApprovalStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业审批统计数据
         *
         * @param request QueryApprovalStatisticalDataRequest
         * @return QueryApprovalStatisticalDataResponse
         */
        public async Task<QueryApprovalStatisticalDataResponse> QueryApprovalStatisticalDataAsync(QueryApprovalStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryApprovalStatisticalDataHeaders headers = new QueryApprovalStatisticalDataHeaders();
            return await QueryApprovalStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业考勤统计数据
         *
         * @param request QueryAttendanceStatisticalDataRequest
         * @param headers QueryAttendanceStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAttendanceStatisticalDataResponse
         */
        public QueryAttendanceStatisticalDataResponse QueryAttendanceStatisticalDataWithOptions(QueryAttendanceStatisticalDataRequest request, QueryAttendanceStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryAttendanceStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/attendanceData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAttendanceStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业考勤统计数据
         *
         * @param request QueryAttendanceStatisticalDataRequest
         * @param headers QueryAttendanceStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAttendanceStatisticalDataResponse
         */
        public async Task<QueryAttendanceStatisticalDataResponse> QueryAttendanceStatisticalDataWithOptionsAsync(QueryAttendanceStatisticalDataRequest request, QueryAttendanceStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryAttendanceStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/attendanceData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAttendanceStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业考勤统计数据
         *
         * @param request QueryAttendanceStatisticalDataRequest
         * @return QueryAttendanceStatisticalDataResponse
         */
        public QueryAttendanceStatisticalDataResponse QueryAttendanceStatisticalData(QueryAttendanceStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAttendanceStatisticalDataHeaders headers = new QueryAttendanceStatisticalDataHeaders();
            return QueryAttendanceStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业考勤统计数据
         *
         * @param request QueryAttendanceStatisticalDataRequest
         * @return QueryAttendanceStatisticalDataResponse
         */
        public async Task<QueryAttendanceStatisticalDataResponse> QueryAttendanceStatisticalDataAsync(QueryAttendanceStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAttendanceStatisticalDataHeaders headers = new QueryAttendanceStatisticalDataHeaders();
            return await QueryAttendanceStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业公告统计数据
         *
         * @param request QueryBlackboardStatisticalDataRequest
         * @param headers QueryBlackboardStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBlackboardStatisticalDataResponse
         */
        public QueryBlackboardStatisticalDataResponse QueryBlackboardStatisticalDataWithOptions(QueryBlackboardStatisticalDataRequest request, QueryBlackboardStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryBlackboardStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/blackboardData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBlackboardStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业公告统计数据
         *
         * @param request QueryBlackboardStatisticalDataRequest
         * @param headers QueryBlackboardStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBlackboardStatisticalDataResponse
         */
        public async Task<QueryBlackboardStatisticalDataResponse> QueryBlackboardStatisticalDataWithOptionsAsync(QueryBlackboardStatisticalDataRequest request, QueryBlackboardStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryBlackboardStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/blackboardData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBlackboardStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业公告统计数据
         *
         * @param request QueryBlackboardStatisticalDataRequest
         * @return QueryBlackboardStatisticalDataResponse
         */
        public QueryBlackboardStatisticalDataResponse QueryBlackboardStatisticalData(QueryBlackboardStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBlackboardStatisticalDataHeaders headers = new QueryBlackboardStatisticalDataHeaders();
            return QueryBlackboardStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业公告统计数据
         *
         * @param request QueryBlackboardStatisticalDataRequest
         * @return QueryBlackboardStatisticalDataResponse
         */
        public async Task<QueryBlackboardStatisticalDataResponse> QueryBlackboardStatisticalDataAsync(QueryBlackboardStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBlackboardStatisticalDataHeaders headers = new QueryBlackboardStatisticalDataHeaders();
            return await QueryBlackboardStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业日程统计数据
         *
         * @param request QueryCalendarStatisticalDataRequest
         * @param headers QueryCalendarStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCalendarStatisticalDataResponse
         */
        public QueryCalendarStatisticalDataResponse QueryCalendarStatisticalDataWithOptions(QueryCalendarStatisticalDataRequest request, QueryCalendarStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryCalendarStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/calendarData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCalendarStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业日程统计数据
         *
         * @param request QueryCalendarStatisticalDataRequest
         * @param headers QueryCalendarStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCalendarStatisticalDataResponse
         */
        public async Task<QueryCalendarStatisticalDataResponse> QueryCalendarStatisticalDataWithOptionsAsync(QueryCalendarStatisticalDataRequest request, QueryCalendarStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryCalendarStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/calendarData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCalendarStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业日程统计数据
         *
         * @param request QueryCalendarStatisticalDataRequest
         * @return QueryCalendarStatisticalDataResponse
         */
        public QueryCalendarStatisticalDataResponse QueryCalendarStatisticalData(QueryCalendarStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCalendarStatisticalDataHeaders headers = new QueryCalendarStatisticalDataHeaders();
            return QueryCalendarStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业日程统计数据
         *
         * @param request QueryCalendarStatisticalDataRequest
         * @return QueryCalendarStatisticalDataResponse
         */
        public async Task<QueryCalendarStatisticalDataResponse> QueryCalendarStatisticalDataAsync(QueryCalendarStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCalendarStatisticalDataHeaders headers = new QueryCalendarStatisticalDataHeaders();
            return await QueryCalendarStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业签到统计数据
         *
         * @param request QueryCheckinStatisticalDataRequest
         * @param headers QueryCheckinStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCheckinStatisticalDataResponse
         */
        public QueryCheckinStatisticalDataResponse QueryCheckinStatisticalDataWithOptions(QueryCheckinStatisticalDataRequest request, QueryCheckinStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryCheckinStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/checkinData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCheckinStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业签到统计数据
         *
         * @param request QueryCheckinStatisticalDataRequest
         * @param headers QueryCheckinStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCheckinStatisticalDataResponse
         */
        public async Task<QueryCheckinStatisticalDataResponse> QueryCheckinStatisticalDataWithOptionsAsync(QueryCheckinStatisticalDataRequest request, QueryCheckinStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryCheckinStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/checkinData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCheckinStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业签到统计数据
         *
         * @param request QueryCheckinStatisticalDataRequest
         * @return QueryCheckinStatisticalDataResponse
         */
        public QueryCheckinStatisticalDataResponse QueryCheckinStatisticalData(QueryCheckinStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCheckinStatisticalDataHeaders headers = new QueryCheckinStatisticalDataHeaders();
            return QueryCheckinStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业签到统计数据
         *
         * @param request QueryCheckinStatisticalDataRequest
         * @return QueryCheckinStatisticalDataResponse
         */
        public async Task<QueryCheckinStatisticalDataResponse> QueryCheckinStatisticalDataAsync(QueryCheckinStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCheckinStatisticalDataHeaders headers = new QueryCheckinStatisticalDataHeaders();
            return await QueryCheckinStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业全员圈统计数据
         *
         * @param request QueryCircleStatisticalDataRequest
         * @param headers QueryCircleStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCircleStatisticalDataResponse
         */
        public QueryCircleStatisticalDataResponse QueryCircleStatisticalDataWithOptions(QueryCircleStatisticalDataRequest request, QueryCircleStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryCircleStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/circleData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCircleStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业全员圈统计数据
         *
         * @param request QueryCircleStatisticalDataRequest
         * @param headers QueryCircleStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCircleStatisticalDataResponse
         */
        public async Task<QueryCircleStatisticalDataResponse> QueryCircleStatisticalDataWithOptionsAsync(QueryCircleStatisticalDataRequest request, QueryCircleStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryCircleStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/circleData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCircleStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业全员圈统计数据
         *
         * @param request QueryCircleStatisticalDataRequest
         * @return QueryCircleStatisticalDataResponse
         */
        public QueryCircleStatisticalDataResponse QueryCircleStatisticalData(QueryCircleStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCircleStatisticalDataHeaders headers = new QueryCircleStatisticalDataHeaders();
            return QueryCircleStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业全员圈统计数据
         *
         * @param request QueryCircleStatisticalDataRequest
         * @return QueryCircleStatisticalDataResponse
         */
        public async Task<QueryCircleStatisticalDataResponse> QueryCircleStatisticalDataAsync(QueryCircleStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCircleStatisticalDataHeaders headers = new QueryCircleStatisticalDataHeaders();
            return await QueryCircleStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 通过企业名称/社会统一信用代码/工商注册号，查询企业的基本画像信息。
         *
         * @param request QueryCompanyBasicInfoRequest
         * @param headers QueryCompanyBasicInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCompanyBasicInfoResponse
         */
        public QueryCompanyBasicInfoResponse QueryCompanyBasicInfoWithOptions(QueryCompanyBasicInfoRequest request, QueryCompanyBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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
                Action = "QueryCompanyBasicInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/basicInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCompanyBasicInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 通过企业名称/社会统一信用代码/工商注册号，查询企业的基本画像信息。
         *
         * @param request QueryCompanyBasicInfoRequest
         * @param headers QueryCompanyBasicInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCompanyBasicInfoResponse
         */
        public async Task<QueryCompanyBasicInfoResponse> QueryCompanyBasicInfoWithOptionsAsync(QueryCompanyBasicInfoRequest request, QueryCompanyBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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
                Action = "QueryCompanyBasicInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/companies/basicInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCompanyBasicInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 通过企业名称/社会统一信用代码/工商注册号，查询企业的基本画像信息。
         *
         * @param request QueryCompanyBasicInfoRequest
         * @return QueryCompanyBasicInfoResponse
         */
        public QueryCompanyBasicInfoResponse QueryCompanyBasicInfo(QueryCompanyBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCompanyBasicInfoHeaders headers = new QueryCompanyBasicInfoHeaders();
            return QueryCompanyBasicInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 通过企业名称/社会统一信用代码/工商注册号，查询企业的基本画像信息。
         *
         * @param request QueryCompanyBasicInfoRequest
         * @return QueryCompanyBasicInfoResponse
         */
        public async Task<QueryCompanyBasicInfoResponse> QueryCompanyBasicInfoAsync(QueryCompanyBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCompanyBasicInfoHeaders headers = new QueryCompanyBasicInfoHeaders();
            return await QueryCompanyBasicInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取数字区县组织信息
         *
         * @param request QueryDigitalDistrictOrgInfoRequest
         * @param headers QueryDigitalDistrictOrgInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDigitalDistrictOrgInfoResponse
         */
        public QueryDigitalDistrictOrgInfoResponse QueryDigitalDistrictOrgInfoWithOptions(QueryDigitalDistrictOrgInfoRequest request, QueryDigitalDistrictOrgInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpIds))
            {
                body["corpIds"] = request.CorpIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDates))
            {
                body["statDates"] = request.StatDates;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDigitalDistrictOrgInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/digitalCounty/orgInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDigitalDistrictOrgInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取数字区县组织信息
         *
         * @param request QueryDigitalDistrictOrgInfoRequest
         * @param headers QueryDigitalDistrictOrgInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDigitalDistrictOrgInfoResponse
         */
        public async Task<QueryDigitalDistrictOrgInfoResponse> QueryDigitalDistrictOrgInfoWithOptionsAsync(QueryDigitalDistrictOrgInfoRequest request, QueryDigitalDistrictOrgInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpIds))
            {
                body["corpIds"] = request.CorpIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDates))
            {
                body["statDates"] = request.StatDates;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDigitalDistrictOrgInfo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/digitalCounty/orgInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDigitalDistrictOrgInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取数字区县组织信息
         *
         * @param request QueryDigitalDistrictOrgInfoRequest
         * @return QueryDigitalDistrictOrgInfoResponse
         */
        public QueryDigitalDistrictOrgInfoResponse QueryDigitalDistrictOrgInfo(QueryDigitalDistrictOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDigitalDistrictOrgInfoHeaders headers = new QueryDigitalDistrictOrgInfoHeaders();
            return QueryDigitalDistrictOrgInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取数字区县组织信息
         *
         * @param request QueryDigitalDistrictOrgInfoRequest
         * @return QueryDigitalDistrictOrgInfoResponse
         */
        public async Task<QueryDigitalDistrictOrgInfoResponse> QueryDigitalDistrictOrgInfoAsync(QueryDigitalDistrictOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDigitalDistrictOrgInfoHeaders headers = new QueryDigitalDistrictOrgInfoHeaders();
            return await QueryDigitalDistrictOrgInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业DING接收及评论统计数据
         *
         * @param request QueryDingReciveStatisticalDataRequest
         * @param headers QueryDingReciveStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDingReciveStatisticalDataResponse
         */
        public QueryDingReciveStatisticalDataResponse QueryDingReciveStatisticalDataWithOptions(QueryDingReciveStatisticalDataRequest request, QueryDingReciveStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryDingReciveStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dingReciveData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDingReciveStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业DING接收及评论统计数据
         *
         * @param request QueryDingReciveStatisticalDataRequest
         * @param headers QueryDingReciveStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDingReciveStatisticalDataResponse
         */
        public async Task<QueryDingReciveStatisticalDataResponse> QueryDingReciveStatisticalDataWithOptionsAsync(QueryDingReciveStatisticalDataRequest request, QueryDingReciveStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryDingReciveStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dingReciveData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDingReciveStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业DING接收及评论统计数据
         *
         * @param request QueryDingReciveStatisticalDataRequest
         * @return QueryDingReciveStatisticalDataResponse
         */
        public QueryDingReciveStatisticalDataResponse QueryDingReciveStatisticalData(QueryDingReciveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDingReciveStatisticalDataHeaders headers = new QueryDingReciveStatisticalDataHeaders();
            return QueryDingReciveStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业DING接收及评论统计数据
         *
         * @param request QueryDingReciveStatisticalDataRequest
         * @return QueryDingReciveStatisticalDataResponse
         */
        public async Task<QueryDingReciveStatisticalDataResponse> QueryDingReciveStatisticalDataAsync(QueryDingReciveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDingReciveStatisticalDataHeaders headers = new QueryDingReciveStatisticalDataHeaders();
            return await QueryDingReciveStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业DING发送统计数据
         *
         * @param request QueryDingSendStatisticalDataRequest
         * @param headers QueryDingSendStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDingSendStatisticalDataResponse
         */
        public QueryDingSendStatisticalDataResponse QueryDingSendStatisticalDataWithOptions(QueryDingSendStatisticalDataRequest request, QueryDingSendStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryDingSendStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dingSendData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDingSendStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业DING发送统计数据
         *
         * @param request QueryDingSendStatisticalDataRequest
         * @param headers QueryDingSendStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDingSendStatisticalDataResponse
         */
        public async Task<QueryDingSendStatisticalDataResponse> QueryDingSendStatisticalDataWithOptionsAsync(QueryDingSendStatisticalDataRequest request, QueryDingSendStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryDingSendStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dingSendData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDingSendStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业DING发送统计数据
         *
         * @param request QueryDingSendStatisticalDataRequest
         * @return QueryDingSendStatisticalDataResponse
         */
        public QueryDingSendStatisticalDataResponse QueryDingSendStatisticalData(QueryDingSendStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDingSendStatisticalDataHeaders headers = new QueryDingSendStatisticalDataHeaders();
            return QueryDingSendStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业DING发送统计数据
         *
         * @param request QueryDingSendStatisticalDataRequest
         * @return QueryDingSendStatisticalDataResponse
         */
        public async Task<QueryDingSendStatisticalDataResponse> QueryDingSendStatisticalDataAsync(QueryDingSendStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDingSendStatisticalDataHeaders headers = new QueryDingSendStatisticalDataHeaders();
            return await QueryDingSendStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业文档统计数据
         *
         * @param request QueryDocumentStatisticalDataRequest
         * @param headers QueryDocumentStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDocumentStatisticalDataResponse
         */
        public QueryDocumentStatisticalDataResponse QueryDocumentStatisticalDataWithOptions(QueryDocumentStatisticalDataRequest request, QueryDocumentStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryDocumentStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/documentData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDocumentStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业文档统计数据
         *
         * @param request QueryDocumentStatisticalDataRequest
         * @param headers QueryDocumentStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDocumentStatisticalDataResponse
         */
        public async Task<QueryDocumentStatisticalDataResponse> QueryDocumentStatisticalDataWithOptionsAsync(QueryDocumentStatisticalDataRequest request, QueryDocumentStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryDocumentStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/documentData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDocumentStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业文档统计数据
         *
         * @param request QueryDocumentStatisticalDataRequest
         * @return QueryDocumentStatisticalDataResponse
         */
        public QueryDocumentStatisticalDataResponse QueryDocumentStatisticalData(QueryDocumentStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDocumentStatisticalDataHeaders headers = new QueryDocumentStatisticalDataHeaders();
            return QueryDocumentStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业文档统计数据
         *
         * @param request QueryDocumentStatisticalDataRequest
         * @return QueryDocumentStatisticalDataResponse
         */
        public async Task<QueryDocumentStatisticalDataResponse> QueryDocumentStatisticalDataAsync(QueryDocumentStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDocumentStatisticalDataHeaders headers = new QueryDocumentStatisticalDataHeaders();
            return await QueryDocumentStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业钉盘统计数据
         *
         * @param request QueryDriveStatisticalDataRequest
         * @param headers QueryDriveStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDriveStatisticalDataResponse
         */
        public QueryDriveStatisticalDataResponse QueryDriveStatisticalDataWithOptions(QueryDriveStatisticalDataRequest request, QueryDriveStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryDriveStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/driveData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDriveStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业钉盘统计数据
         *
         * @param request QueryDriveStatisticalDataRequest
         * @param headers QueryDriveStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDriveStatisticalDataResponse
         */
        public async Task<QueryDriveStatisticalDataResponse> QueryDriveStatisticalDataWithOptionsAsync(QueryDriveStatisticalDataRequest request, QueryDriveStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryDriveStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/driveData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDriveStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业钉盘统计数据
         *
         * @param request QueryDriveStatisticalDataRequest
         * @return QueryDriveStatisticalDataResponse
         */
        public QueryDriveStatisticalDataResponse QueryDriveStatisticalData(QueryDriveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDriveStatisticalDataHeaders headers = new QueryDriveStatisticalDataHeaders();
            return QueryDriveStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业钉盘统计数据
         *
         * @param request QueryDriveStatisticalDataRequest
         * @return QueryDriveStatisticalDataResponse
         */
        public async Task<QueryDriveStatisticalDataResponse> QueryDriveStatisticalDataAsync(QueryDriveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDriveStatisticalDataHeaders headers = new QueryDriveStatisticalDataHeaders();
            return await QueryDriveStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业员工类型统计数据
         *
         * @param request QueryEmployeeTypeStatisticalDataRequest
         * @param headers QueryEmployeeTypeStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryEmployeeTypeStatisticalDataResponse
         */
        public QueryEmployeeTypeStatisticalDataResponse QueryEmployeeTypeStatisticalDataWithOptions(QueryEmployeeTypeStatisticalDataRequest request, QueryEmployeeTypeStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryEmployeeTypeStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/employeeTypeData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEmployeeTypeStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业员工类型统计数据
         *
         * @param request QueryEmployeeTypeStatisticalDataRequest
         * @param headers QueryEmployeeTypeStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryEmployeeTypeStatisticalDataResponse
         */
        public async Task<QueryEmployeeTypeStatisticalDataResponse> QueryEmployeeTypeStatisticalDataWithOptionsAsync(QueryEmployeeTypeStatisticalDataRequest request, QueryEmployeeTypeStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryEmployeeTypeStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/employeeTypeData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEmployeeTypeStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业员工类型统计数据
         *
         * @param request QueryEmployeeTypeStatisticalDataRequest
         * @return QueryEmployeeTypeStatisticalDataResponse
         */
        public QueryEmployeeTypeStatisticalDataResponse QueryEmployeeTypeStatisticalData(QueryEmployeeTypeStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryEmployeeTypeStatisticalDataHeaders headers = new QueryEmployeeTypeStatisticalDataHeaders();
            return QueryEmployeeTypeStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业员工类型统计数据
         *
         * @param request QueryEmployeeTypeStatisticalDataRequest
         * @return QueryEmployeeTypeStatisticalDataResponse
         */
        public async Task<QueryEmployeeTypeStatisticalDataResponse> QueryEmployeeTypeStatisticalDataAsync(QueryEmployeeTypeStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryEmployeeTypeStatisticalDataHeaders headers = new QueryEmployeeTypeStatisticalDataHeaders();
            return await QueryEmployeeTypeStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 数据资产平台数据服务接口
         *
         * @param request QueryGeneralDataServiceRequest
         * @param headers QueryGeneralDataServiceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGeneralDataServiceResponse
         */
        public QueryGeneralDataServiceResponse QueryGeneralDataServiceWithOptions(QueryGeneralDataServiceRequest request, QueryGeneralDataServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["startDate"] = request.StartDate;
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
                Action = "QueryGeneralDataService",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/generalDataServices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGeneralDataServiceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 数据资产平台数据服务接口
         *
         * @param request QueryGeneralDataServiceRequest
         * @param headers QueryGeneralDataServiceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGeneralDataServiceResponse
         */
        public async Task<QueryGeneralDataServiceResponse> QueryGeneralDataServiceWithOptionsAsync(QueryGeneralDataServiceRequest request, QueryGeneralDataServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["startDate"] = request.StartDate;
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
                Action = "QueryGeneralDataService",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/generalDataServices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGeneralDataServiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 数据资产平台数据服务接口
         *
         * @param request QueryGeneralDataServiceRequest
         * @return QueryGeneralDataServiceResponse
         */
        public QueryGeneralDataServiceResponse QueryGeneralDataService(QueryGeneralDataServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGeneralDataServiceHeaders headers = new QueryGeneralDataServiceHeaders();
            return QueryGeneralDataServiceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 数据资产平台数据服务接口
         *
         * @param request QueryGeneralDataServiceRequest
         * @return QueryGeneralDataServiceResponse
         */
        public async Task<QueryGeneralDataServiceResponse> QueryGeneralDataServiceAsync(QueryGeneralDataServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGeneralDataServiceHeaders headers = new QueryGeneralDataServiceHeaders();
            return await QueryGeneralDataServiceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 数据资产平台数据服务接口(支持部门、员工维度批量拉取)
         *
         * @param request QueryGeneralDataServiceBatchRequest
         * @param headers QueryGeneralDataServiceBatchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGeneralDataServiceBatchResponse
         */
        public QueryGeneralDataServiceBatchResponse QueryGeneralDataServiceBatchWithOptions(QueryGeneralDataServiceBatchRequest request, QueryGeneralDataServiceBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "QueryGeneralDataServiceBatch",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dataServices/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGeneralDataServiceBatchResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 数据资产平台数据服务接口(支持部门、员工维度批量拉取)
         *
         * @param request QueryGeneralDataServiceBatchRequest
         * @param headers QueryGeneralDataServiceBatchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGeneralDataServiceBatchResponse
         */
        public async Task<QueryGeneralDataServiceBatchResponse> QueryGeneralDataServiceBatchWithOptionsAsync(QueryGeneralDataServiceBatchRequest request, QueryGeneralDataServiceBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "QueryGeneralDataServiceBatch",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dataServices/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGeneralDataServiceBatchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 数据资产平台数据服务接口(支持部门、员工维度批量拉取)
         *
         * @param request QueryGeneralDataServiceBatchRequest
         * @return QueryGeneralDataServiceBatchResponse
         */
        public QueryGeneralDataServiceBatchResponse QueryGeneralDataServiceBatch(QueryGeneralDataServiceBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGeneralDataServiceBatchHeaders headers = new QueryGeneralDataServiceBatchHeaders();
            return QueryGeneralDataServiceBatchWithOptions(request, headers, runtime);
        }

        /**
         * @summary 数据资产平台数据服务接口(支持部门、员工维度批量拉取)
         *
         * @param request QueryGeneralDataServiceBatchRequest
         * @return QueryGeneralDataServiceBatchResponse
         */
        public async Task<QueryGeneralDataServiceBatchResponse> QueryGeneralDataServiceBatchAsync(QueryGeneralDataServiceBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGeneralDataServiceBatchHeaders headers = new QueryGeneralDataServiceBatchHeaders();
            return await QueryGeneralDataServiceBatchWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 数据资产平台数据服务接口(查询数据更新日期)
         *
         * @param request QueryGeneralDataUpdateDateRequest
         * @param headers QueryGeneralDataUpdateDateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGeneralDataUpdateDateResponse
         */
        public QueryGeneralDataUpdateDateResponse QueryGeneralDataUpdateDateWithOptions(QueryGeneralDataUpdateDateRequest request, QueryGeneralDataUpdateDateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "QueryGeneralDataUpdateDate",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dataUpdateDates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGeneralDataUpdateDateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 数据资产平台数据服务接口(查询数据更新日期)
         *
         * @param request QueryGeneralDataUpdateDateRequest
         * @param headers QueryGeneralDataUpdateDateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGeneralDataUpdateDateResponse
         */
        public async Task<QueryGeneralDataUpdateDateResponse> QueryGeneralDataUpdateDateWithOptionsAsync(QueryGeneralDataUpdateDateRequest request, QueryGeneralDataUpdateDateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "QueryGeneralDataUpdateDate",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dataUpdateDates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGeneralDataUpdateDateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 数据资产平台数据服务接口(查询数据更新日期)
         *
         * @param request QueryGeneralDataUpdateDateRequest
         * @return QueryGeneralDataUpdateDateResponse
         */
        public QueryGeneralDataUpdateDateResponse QueryGeneralDataUpdateDate(QueryGeneralDataUpdateDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGeneralDataUpdateDateHeaders headers = new QueryGeneralDataUpdateDateHeaders();
            return QueryGeneralDataUpdateDateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 数据资产平台数据服务接口(查询数据更新日期)
         *
         * @param request QueryGeneralDataUpdateDateRequest
         * @return QueryGeneralDataUpdateDateResponse
         */
        public async Task<QueryGeneralDataUpdateDateResponse> QueryGeneralDataUpdateDateAsync(QueryGeneralDataUpdateDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGeneralDataUpdateDateHeaders headers = new QueryGeneralDataUpdateDateHeaders();
            return await QueryGeneralDataUpdateDateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业群直播统计数据
         *
         * @param request QueryGroupLiveStatisticalDataRequest
         * @param headers QueryGroupLiveStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGroupLiveStatisticalDataResponse
         */
        public QueryGroupLiveStatisticalDataResponse QueryGroupLiveStatisticalDataWithOptions(QueryGroupLiveStatisticalDataRequest request, QueryGroupLiveStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryGroupLiveStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/groupLiveData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupLiveStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业群直播统计数据
         *
         * @param request QueryGroupLiveStatisticalDataRequest
         * @param headers QueryGroupLiveStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGroupLiveStatisticalDataResponse
         */
        public async Task<QueryGroupLiveStatisticalDataResponse> QueryGroupLiveStatisticalDataWithOptionsAsync(QueryGroupLiveStatisticalDataRequest request, QueryGroupLiveStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryGroupLiveStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/groupLiveData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupLiveStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业群直播统计数据
         *
         * @param request QueryGroupLiveStatisticalDataRequest
         * @return QueryGroupLiveStatisticalDataResponse
         */
        public QueryGroupLiveStatisticalDataResponse QueryGroupLiveStatisticalData(QueryGroupLiveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupLiveStatisticalDataHeaders headers = new QueryGroupLiveStatisticalDataHeaders();
            return QueryGroupLiveStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业群直播统计数据
         *
         * @param request QueryGroupLiveStatisticalDataRequest
         * @return QueryGroupLiveStatisticalDataResponse
         */
        public async Task<QueryGroupLiveStatisticalDataResponse> QueryGroupLiveStatisticalDataAsync(QueryGroupLiveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupLiveStatisticalDataHeaders headers = new QueryGroupLiveStatisticalDataHeaders();
            return await QueryGroupLiveStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业群聊统计数据
         *
         * @param request QueryGroupMessageStatisticalDataRequest
         * @param headers QueryGroupMessageStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGroupMessageStatisticalDataResponse
         */
        public QueryGroupMessageStatisticalDataResponse QueryGroupMessageStatisticalDataWithOptions(QueryGroupMessageStatisticalDataRequest request, QueryGroupMessageStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryGroupMessageStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/groupMessageData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupMessageStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业群聊统计数据
         *
         * @param request QueryGroupMessageStatisticalDataRequest
         * @param headers QueryGroupMessageStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGroupMessageStatisticalDataResponse
         */
        public async Task<QueryGroupMessageStatisticalDataResponse> QueryGroupMessageStatisticalDataWithOptionsAsync(QueryGroupMessageStatisticalDataRequest request, QueryGroupMessageStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryGroupMessageStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/groupMessageData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupMessageStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业群聊统计数据
         *
         * @param request QueryGroupMessageStatisticalDataRequest
         * @return QueryGroupMessageStatisticalDataResponse
         */
        public QueryGroupMessageStatisticalDataResponse QueryGroupMessageStatisticalData(QueryGroupMessageStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMessageStatisticalDataHeaders headers = new QueryGroupMessageStatisticalDataHeaders();
            return QueryGroupMessageStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业群聊统计数据
         *
         * @param request QueryGroupMessageStatisticalDataRequest
         * @return QueryGroupMessageStatisticalDataResponse
         */
        public async Task<QueryGroupMessageStatisticalDataResponse> QueryGroupMessageStatisticalDataAsync(QueryGroupMessageStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMessageStatisticalDataHeaders headers = new QueryGroupMessageStatisticalDataHeaders();
            return await QueryGroupMessageStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业钉钉运动统计数据
         *
         * @param request QueryHealthStatisticalDataRequest
         * @param headers QueryHealthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryHealthStatisticalDataResponse
         */
        public QueryHealthStatisticalDataResponse QueryHealthStatisticalDataWithOptions(QueryHealthStatisticalDataRequest request, QueryHealthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryHealthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/healtheUserData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHealthStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业钉钉运动统计数据
         *
         * @param request QueryHealthStatisticalDataRequest
         * @param headers QueryHealthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryHealthStatisticalDataResponse
         */
        public async Task<QueryHealthStatisticalDataResponse> QueryHealthStatisticalDataWithOptionsAsync(QueryHealthStatisticalDataRequest request, QueryHealthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryHealthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/healtheUserData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHealthStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业钉钉运动统计数据
         *
         * @param request QueryHealthStatisticalDataRequest
         * @return QueryHealthStatisticalDataResponse
         */
        public QueryHealthStatisticalDataResponse QueryHealthStatisticalData(QueryHealthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHealthStatisticalDataHeaders headers = new QueryHealthStatisticalDataHeaders();
            return QueryHealthStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业钉钉运动统计数据
         *
         * @param request QueryHealthStatisticalDataRequest
         * @return QueryHealthStatisticalDataResponse
         */
        public async Task<QueryHealthStatisticalDataResponse> QueryHealthStatisticalDataAsync(QueryHealthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHealthStatisticalDataHeaders headers = new QueryHealthStatisticalDataHeaders();
            return await QueryHealthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业邮箱统计数据
         *
         * @param request QueryMailStatisticalDataRequest
         * @param headers QueryMailStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMailStatisticalDataResponse
         */
        public QueryMailStatisticalDataResponse QueryMailStatisticalDataWithOptions(QueryMailStatisticalDataRequest request, QueryMailStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryMailStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/mailData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMailStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业邮箱统计数据
         *
         * @param request QueryMailStatisticalDataRequest
         * @param headers QueryMailStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMailStatisticalDataResponse
         */
        public async Task<QueryMailStatisticalDataResponse> QueryMailStatisticalDataWithOptionsAsync(QueryMailStatisticalDataRequest request, QueryMailStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryMailStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/mailData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMailStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业邮箱统计数据
         *
         * @param request QueryMailStatisticalDataRequest
         * @return QueryMailStatisticalDataResponse
         */
        public QueryMailStatisticalDataResponse QueryMailStatisticalData(QueryMailStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMailStatisticalDataHeaders headers = new QueryMailStatisticalDataHeaders();
            return QueryMailStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业邮箱统计数据
         *
         * @param request QueryMailStatisticalDataRequest
         * @return QueryMailStatisticalDataResponse
         */
        public async Task<QueryMailStatisticalDataResponse> QueryMailStatisticalDataAsync(QueryMailStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMailStatisticalDataHeaders headers = new QueryMailStatisticalDataHeaders();
            return await QueryMailStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取官方数据集数据
         *
         * @param request QueryOfficialDataRequest
         * @param headers QueryOfficialDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOfficialDataResponse
         */
        public QueryOfficialDataResponse QueryOfficialDataWithOptions(QueryOfficialDataRequest request, QueryOfficialDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                query["param"] = request.Param;
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
                Action = "QueryOfficialData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/datas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOfficialDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取官方数据集数据
         *
         * @param request QueryOfficialDataRequest
         * @param headers QueryOfficialDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOfficialDataResponse
         */
        public async Task<QueryOfficialDataResponse> QueryOfficialDataWithOptionsAsync(QueryOfficialDataRequest request, QueryOfficialDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                query["param"] = request.Param;
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
                Action = "QueryOfficialData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/datas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOfficialDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取官方数据集数据
         *
         * @param request QueryOfficialDataRequest
         * @return QueryOfficialDataResponse
         */
        public QueryOfficialDataResponse QueryOfficialData(QueryOfficialDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialDataHeaders headers = new QueryOfficialDataHeaders();
            return QueryOfficialDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取官方数据集数据
         *
         * @param request QueryOfficialDataRequest
         * @return QueryOfficialDataResponse
         */
        public async Task<QueryOfficialDataResponse> QueryOfficialDataAsync(QueryOfficialDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialDataHeaders headers = new QueryOfficialDataHeaders();
            return await QueryOfficialDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary ISV获取官方数据集字段信息
         *
         * @param request QueryOfficialDatasetFieldsRequest
         * @param headers QueryOfficialDatasetFieldsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOfficialDatasetFieldsResponse
         */
        public QueryOfficialDatasetFieldsResponse QueryOfficialDatasetFieldsWithOptions(QueryOfficialDatasetFieldsRequest request, QueryOfficialDatasetFieldsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsId))
            {
                query["dsId"] = request.DsId;
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
                Action = "QueryOfficialDatasetFields",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/datasetFields",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOfficialDatasetFieldsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary ISV获取官方数据集字段信息
         *
         * @param request QueryOfficialDatasetFieldsRequest
         * @param headers QueryOfficialDatasetFieldsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOfficialDatasetFieldsResponse
         */
        public async Task<QueryOfficialDatasetFieldsResponse> QueryOfficialDatasetFieldsWithOptionsAsync(QueryOfficialDatasetFieldsRequest request, QueryOfficialDatasetFieldsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsId))
            {
                query["dsId"] = request.DsId;
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
                Action = "QueryOfficialDatasetFields",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/datasetFields",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOfficialDatasetFieldsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary ISV获取官方数据集字段信息
         *
         * @param request QueryOfficialDatasetFieldsRequest
         * @return QueryOfficialDatasetFieldsResponse
         */
        public QueryOfficialDatasetFieldsResponse QueryOfficialDatasetFields(QueryOfficialDatasetFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialDatasetFieldsHeaders headers = new QueryOfficialDatasetFieldsHeaders();
            return QueryOfficialDatasetFieldsWithOptions(request, headers, runtime);
        }

        /**
         * @summary ISV获取官方数据集字段信息
         *
         * @param request QueryOfficialDatasetFieldsRequest
         * @return QueryOfficialDatasetFieldsResponse
         */
        public async Task<QueryOfficialDatasetFieldsResponse> QueryOfficialDatasetFieldsAsync(QueryOfficialDatasetFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialDatasetFieldsHeaders headers = new QueryOfficialDatasetFieldsHeaders();
            return await QueryOfficialDatasetFieldsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary ISV获取官方数据集列表
         *
         * @param request QueryOfficialDatasetListRequest
         * @param headers QueryOfficialDatasetListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOfficialDatasetListResponse
         */
        public QueryOfficialDatasetListResponse QueryOfficialDatasetListWithOptions(QueryOfficialDatasetListRequest request, QueryOfficialDatasetListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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
                Action = "QueryOfficialDatasetList",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/datasetLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOfficialDatasetListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary ISV获取官方数据集列表
         *
         * @param request QueryOfficialDatasetListRequest
         * @param headers QueryOfficialDatasetListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOfficialDatasetListResponse
         */
        public async Task<QueryOfficialDatasetListResponse> QueryOfficialDatasetListWithOptionsAsync(QueryOfficialDatasetListRequest request, QueryOfficialDatasetListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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
                Action = "QueryOfficialDatasetList",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/datasetLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOfficialDatasetListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary ISV获取官方数据集列表
         *
         * @param request QueryOfficialDatasetListRequest
         * @return QueryOfficialDatasetListResponse
         */
        public QueryOfficialDatasetListResponse QueryOfficialDatasetList(QueryOfficialDatasetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialDatasetListHeaders headers = new QueryOfficialDatasetListHeaders();
            return QueryOfficialDatasetListWithOptions(request, headers, runtime);
        }

        /**
         * @summary ISV获取官方数据集列表
         *
         * @param request QueryOfficialDatasetListRequest
         * @return QueryOfficialDatasetListResponse
         */
        public async Task<QueryOfficialDatasetListResponse> QueryOfficialDatasetListAsync(QueryOfficialDatasetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialDatasetListHeaders headers = new QueryOfficialDatasetListHeaders();
            return await QueryOfficialDatasetListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取官方数据集数据
         *
         * @param request QueryOfficialFormDataRequest
         * @param headers QueryOfficialFormDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOfficialFormDataResponse
         */
        public QueryOfficialFormDataResponse QueryOfficialFormDataWithOptions(QueryOfficialFormDataRequest request, QueryOfficialFormDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "QueryOfficialFormData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/datas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOfficialFormDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取官方数据集数据
         *
         * @param request QueryOfficialFormDataRequest
         * @param headers QueryOfficialFormDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOfficialFormDataResponse
         */
        public async Task<QueryOfficialFormDataResponse> QueryOfficialFormDataWithOptionsAsync(QueryOfficialFormDataRequest request, QueryOfficialFormDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "QueryOfficialFormData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/datas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOfficialFormDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取官方数据集数据
         *
         * @param request QueryOfficialFormDataRequest
         * @return QueryOfficialFormDataResponse
         */
        public QueryOfficialFormDataResponse QueryOfficialFormData(QueryOfficialFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialFormDataHeaders headers = new QueryOfficialFormDataHeaders();
            return QueryOfficialFormDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取官方数据集数据
         *
         * @param request QueryOfficialFormDataRequest
         * @return QueryOfficialFormDataResponse
         */
        public async Task<QueryOfficialFormDataResponse> QueryOfficialFormDataAsync(QueryOfficialFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialFormDataHeaders headers = new QueryOfficialFormDataHeaders();
            return await QueryOfficialFormDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取HOLO中官方OA表单数据集数据
         *
         * @param request QueryOfficialFormDataDirectHoloRequest
         * @param headers QueryOfficialFormDataDirectHoloHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOfficialFormDataDirectHoloResponse
         */
        public QueryOfficialFormDataDirectHoloResponse QueryOfficialFormDataDirectHoloWithOptions(QueryOfficialFormDataDirectHoloRequest request, QueryOfficialFormDataDirectHoloHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "QueryOfficialFormDataDirectHolo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/oaDatas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOfficialFormDataDirectHoloResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取HOLO中官方OA表单数据集数据
         *
         * @param request QueryOfficialFormDataDirectHoloRequest
         * @param headers QueryOfficialFormDataDirectHoloHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOfficialFormDataDirectHoloResponse
         */
        public async Task<QueryOfficialFormDataDirectHoloResponse> QueryOfficialFormDataDirectHoloWithOptionsAsync(QueryOfficialFormDataDirectHoloRequest request, QueryOfficialFormDataDirectHoloHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
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
                Action = "QueryOfficialFormDataDirectHolo",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/oaDatas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOfficialFormDataDirectHoloResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取HOLO中官方OA表单数据集数据
         *
         * @param request QueryOfficialFormDataDirectHoloRequest
         * @return QueryOfficialFormDataDirectHoloResponse
         */
        public QueryOfficialFormDataDirectHoloResponse QueryOfficialFormDataDirectHolo(QueryOfficialFormDataDirectHoloRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialFormDataDirectHoloHeaders headers = new QueryOfficialFormDataDirectHoloHeaders();
            return QueryOfficialFormDataDirectHoloWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取HOLO中官方OA表单数据集数据
         *
         * @param request QueryOfficialFormDataDirectHoloRequest
         * @return QueryOfficialFormDataDirectHoloResponse
         */
        public async Task<QueryOfficialFormDataDirectHoloResponse> QueryOfficialFormDataDirectHoloAsync(QueryOfficialFormDataDirectHoloRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialFormDataDirectHoloHeaders headers = new QueryOfficialFormDataDirectHoloHeaders();
            return await QueryOfficialFormDataDirectHoloWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业用户在线统计数据
         *
         * @param request QueryOnlineUserStatisticalDataRequest
         * @param headers QueryOnlineUserStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOnlineUserStatisticalDataResponse
         */
        public QueryOnlineUserStatisticalDataResponse QueryOnlineUserStatisticalDataWithOptions(QueryOnlineUserStatisticalDataRequest request, QueryOnlineUserStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryOnlineUserStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/onlineUserData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOnlineUserStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业用户在线统计数据
         *
         * @param request QueryOnlineUserStatisticalDataRequest
         * @param headers QueryOnlineUserStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOnlineUserStatisticalDataResponse
         */
        public async Task<QueryOnlineUserStatisticalDataResponse> QueryOnlineUserStatisticalDataWithOptionsAsync(QueryOnlineUserStatisticalDataRequest request, QueryOnlineUserStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryOnlineUserStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/onlineUserData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOnlineUserStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业用户在线统计数据
         *
         * @param request QueryOnlineUserStatisticalDataRequest
         * @return QueryOnlineUserStatisticalDataResponse
         */
        public QueryOnlineUserStatisticalDataResponse QueryOnlineUserStatisticalData(QueryOnlineUserStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOnlineUserStatisticalDataHeaders headers = new QueryOnlineUserStatisticalDataHeaders();
            return QueryOnlineUserStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业用户在线统计数据
         *
         * @param request QueryOnlineUserStatisticalDataRequest
         * @return QueryOnlineUserStatisticalDataResponse
         */
        public async Task<QueryOnlineUserStatisticalDataResponse> QueryOnlineUserStatisticalDataAsync(QueryOnlineUserStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOnlineUserStatisticalDataHeaders headers = new QueryOnlineUserStatisticalDataHeaders();
            return await QueryOnlineUserStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业接收红包统计数据
         *
         * @param request QueryRedEnvelopeReciveStatisticalDataRequest
         * @param headers QueryRedEnvelopeReciveStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRedEnvelopeReciveStatisticalDataResponse
         */
        public QueryRedEnvelopeReciveStatisticalDataResponse QueryRedEnvelopeReciveStatisticalDataWithOptions(QueryRedEnvelopeReciveStatisticalDataRequest request, QueryRedEnvelopeReciveStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryRedEnvelopeReciveStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/redEnvelopeReciveData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRedEnvelopeReciveStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业接收红包统计数据
         *
         * @param request QueryRedEnvelopeReciveStatisticalDataRequest
         * @param headers QueryRedEnvelopeReciveStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRedEnvelopeReciveStatisticalDataResponse
         */
        public async Task<QueryRedEnvelopeReciveStatisticalDataResponse> QueryRedEnvelopeReciveStatisticalDataWithOptionsAsync(QueryRedEnvelopeReciveStatisticalDataRequest request, QueryRedEnvelopeReciveStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryRedEnvelopeReciveStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/redEnvelopeReciveData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRedEnvelopeReciveStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业接收红包统计数据
         *
         * @param request QueryRedEnvelopeReciveStatisticalDataRequest
         * @return QueryRedEnvelopeReciveStatisticalDataResponse
         */
        public QueryRedEnvelopeReciveStatisticalDataResponse QueryRedEnvelopeReciveStatisticalData(QueryRedEnvelopeReciveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRedEnvelopeReciveStatisticalDataHeaders headers = new QueryRedEnvelopeReciveStatisticalDataHeaders();
            return QueryRedEnvelopeReciveStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业接收红包统计数据
         *
         * @param request QueryRedEnvelopeReciveStatisticalDataRequest
         * @return QueryRedEnvelopeReciveStatisticalDataResponse
         */
        public async Task<QueryRedEnvelopeReciveStatisticalDataResponse> QueryRedEnvelopeReciveStatisticalDataAsync(QueryRedEnvelopeReciveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRedEnvelopeReciveStatisticalDataHeaders headers = new QueryRedEnvelopeReciveStatisticalDataHeaders();
            return await QueryRedEnvelopeReciveStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业发送红包统计数据
         *
         * @param request QueryRedEnvelopeSendStatisticalDataRequest
         * @param headers QueryRedEnvelopeSendStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRedEnvelopeSendStatisticalDataResponse
         */
        public QueryRedEnvelopeSendStatisticalDataResponse QueryRedEnvelopeSendStatisticalDataWithOptions(QueryRedEnvelopeSendStatisticalDataRequest request, QueryRedEnvelopeSendStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryRedEnvelopeSendStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/redEnvelopeSendData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRedEnvelopeSendStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业发送红包统计数据
         *
         * @param request QueryRedEnvelopeSendStatisticalDataRequest
         * @param headers QueryRedEnvelopeSendStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRedEnvelopeSendStatisticalDataResponse
         */
        public async Task<QueryRedEnvelopeSendStatisticalDataResponse> QueryRedEnvelopeSendStatisticalDataWithOptionsAsync(QueryRedEnvelopeSendStatisticalDataRequest request, QueryRedEnvelopeSendStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryRedEnvelopeSendStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/redEnvelopeSendData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRedEnvelopeSendStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业发送红包统计数据
         *
         * @param request QueryRedEnvelopeSendStatisticalDataRequest
         * @return QueryRedEnvelopeSendStatisticalDataResponse
         */
        public QueryRedEnvelopeSendStatisticalDataResponse QueryRedEnvelopeSendStatisticalData(QueryRedEnvelopeSendStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRedEnvelopeSendStatisticalDataHeaders headers = new QueryRedEnvelopeSendStatisticalDataHeaders();
            return QueryRedEnvelopeSendStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业发送红包统计数据
         *
         * @param request QueryRedEnvelopeSendStatisticalDataRequest
         * @return QueryRedEnvelopeSendStatisticalDataResponse
         */
        public async Task<QueryRedEnvelopeSendStatisticalDataResponse> QueryRedEnvelopeSendStatisticalDataAsync(QueryRedEnvelopeSendStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRedEnvelopeSendStatisticalDataHeaders headers = new QueryRedEnvelopeSendStatisticalDataHeaders();
            return await QueryRedEnvelopeSendStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业日志统计数据
         *
         * @param request QueryReportStatisticalDataRequest
         * @param headers QueryReportStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryReportStatisticalDataResponse
         */
        public QueryReportStatisticalDataResponse QueryReportStatisticalDataWithOptions(QueryReportStatisticalDataRequest request, QueryReportStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryReportStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/reportData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryReportStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业日志统计数据
         *
         * @param request QueryReportStatisticalDataRequest
         * @param headers QueryReportStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryReportStatisticalDataResponse
         */
        public async Task<QueryReportStatisticalDataResponse> QueryReportStatisticalDataWithOptionsAsync(QueryReportStatisticalDataRequest request, QueryReportStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryReportStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/reportData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryReportStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业日志统计数据
         *
         * @param request QueryReportStatisticalDataRequest
         * @return QueryReportStatisticalDataResponse
         */
        public QueryReportStatisticalDataResponse QueryReportStatisticalData(QueryReportStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReportStatisticalDataHeaders headers = new QueryReportStatisticalDataHeaders();
            return QueryReportStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业日志统计数据
         *
         * @param request QueryReportStatisticalDataRequest
         * @return QueryReportStatisticalDataResponse
         */
        public async Task<QueryReportStatisticalDataResponse> QueryReportStatisticalDataAsync(QueryReportStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReportStatisticalDataHeaders headers = new QueryReportStatisticalDataHeaders();
            return await QueryReportStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业单聊统计数据
         *
         * @param request QuerySingleMessageStatisticalDataRequest
         * @param headers QuerySingleMessageStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySingleMessageStatisticalDataResponse
         */
        public QuerySingleMessageStatisticalDataResponse QuerySingleMessageStatisticalDataWithOptions(QuerySingleMessageStatisticalDataRequest request, QuerySingleMessageStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QuerySingleMessageStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/singleMessagerData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySingleMessageStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业单聊统计数据
         *
         * @param request QuerySingleMessageStatisticalDataRequest
         * @param headers QuerySingleMessageStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySingleMessageStatisticalDataResponse
         */
        public async Task<QuerySingleMessageStatisticalDataResponse> QuerySingleMessageStatisticalDataWithOptionsAsync(QuerySingleMessageStatisticalDataRequest request, QuerySingleMessageStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QuerySingleMessageStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/singleMessagerData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySingleMessageStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业单聊统计数据
         *
         * @param request QuerySingleMessageStatisticalDataRequest
         * @return QuerySingleMessageStatisticalDataResponse
         */
        public QuerySingleMessageStatisticalDataResponse QuerySingleMessageStatisticalData(QuerySingleMessageStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySingleMessageStatisticalDataHeaders headers = new QuerySingleMessageStatisticalDataHeaders();
            return QuerySingleMessageStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业单聊统计数据
         *
         * @param request QuerySingleMessageStatisticalDataRequest
         * @return QuerySingleMessageStatisticalDataResponse
         */
        public async Task<QuerySingleMessageStatisticalDataResponse> QuerySingleMessageStatisticalDataAsync(QuerySingleMessageStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySingleMessageStatisticalDataHeaders headers = new QuerySingleMessageStatisticalDataHeaders();
            return await QuerySingleMessageStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业电话会议统计数据
         *
         * @param request QueryTelMeetingStatisticalDataRequest
         * @param headers QueryTelMeetingStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTelMeetingStatisticalDataResponse
         */
        public QueryTelMeetingStatisticalDataResponse QueryTelMeetingStatisticalDataWithOptions(QueryTelMeetingStatisticalDataRequest request, QueryTelMeetingStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryTelMeetingStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/telMeetingData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTelMeetingStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业电话会议统计数据
         *
         * @param request QueryTelMeetingStatisticalDataRequest
         * @param headers QueryTelMeetingStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTelMeetingStatisticalDataResponse
         */
        public async Task<QueryTelMeetingStatisticalDataResponse> QueryTelMeetingStatisticalDataWithOptionsAsync(QueryTelMeetingStatisticalDataRequest request, QueryTelMeetingStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryTelMeetingStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/telMeetingData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTelMeetingStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业电话会议统计数据
         *
         * @param request QueryTelMeetingStatisticalDataRequest
         * @return QueryTelMeetingStatisticalDataResponse
         */
        public QueryTelMeetingStatisticalDataResponse QueryTelMeetingStatisticalData(QueryTelMeetingStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTelMeetingStatisticalDataHeaders headers = new QueryTelMeetingStatisticalDataHeaders();
            return QueryTelMeetingStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业电话会议统计数据
         *
         * @param request QueryTelMeetingStatisticalDataRequest
         * @return QueryTelMeetingStatisticalDataResponse
         */
        public async Task<QueryTelMeetingStatisticalDataResponse> QueryTelMeetingStatisticalDataAsync(QueryTelMeetingStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTelMeetingStatisticalDataHeaders headers = new QueryTelMeetingStatisticalDataHeaders();
            return await QueryTelMeetingStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业待办统计数据
         *
         * @param request QueryTodoStatisticalDataRequest
         * @param headers QueryTodoStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTodoStatisticalDataResponse
         */
        public QueryTodoStatisticalDataResponse QueryTodoStatisticalDataWithOptions(QueryTodoStatisticalDataRequest request, QueryTodoStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryTodoStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/todoUserData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTodoStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业待办统计数据
         *
         * @param request QueryTodoStatisticalDataRequest
         * @param headers QueryTodoStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTodoStatisticalDataResponse
         */
        public async Task<QueryTodoStatisticalDataResponse> QueryTodoStatisticalDataWithOptionsAsync(QueryTodoStatisticalDataRequest request, QueryTodoStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryTodoStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/todoUserData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTodoStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业待办统计数据
         *
         * @param request QueryTodoStatisticalDataRequest
         * @return QueryTodoStatisticalDataResponse
         */
        public QueryTodoStatisticalDataResponse QueryTodoStatisticalData(QueryTodoStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTodoStatisticalDataHeaders headers = new QueryTodoStatisticalDataHeaders();
            return QueryTodoStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业待办统计数据
         *
         * @param request QueryTodoStatisticalDataRequest
         * @return QueryTodoStatisticalDataResponse
         */
        public async Task<QueryTodoStatisticalDataResponse> QueryTodoStatisticalDataAsync(QueryTodoStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTodoStatisticalDataHeaders headers = new QueryTodoStatisticalDataHeaders();
            return await QueryTodoStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 数据资产平台查询数据记录数
         *
         * @param request QueryTotalDataCountServiceRequest
         * @param headers QueryTotalDataCountServiceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTotalDataCountServiceResponse
         */
        public QueryTotalDataCountServiceResponse QueryTotalDataCountServiceWithOptions(QueryTotalDataCountServiceRequest request, QueryTotalDataCountServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "QueryTotalDataCountService",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/datas/totalCounts/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTotalDataCountServiceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 数据资产平台查询数据记录数
         *
         * @param request QueryTotalDataCountServiceRequest
         * @param headers QueryTotalDataCountServiceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTotalDataCountServiceResponse
         */
        public async Task<QueryTotalDataCountServiceResponse> QueryTotalDataCountServiceWithOptionsAsync(QueryTotalDataCountServiceRequest request, QueryTotalDataCountServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "QueryTotalDataCountService",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/datas/totalCounts/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTotalDataCountServiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 数据资产平台查询数据记录数
         *
         * @param request QueryTotalDataCountServiceRequest
         * @return QueryTotalDataCountServiceResponse
         */
        public QueryTotalDataCountServiceResponse QueryTotalDataCountService(QueryTotalDataCountServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTotalDataCountServiceHeaders headers = new QueryTotalDataCountServiceHeaders();
            return QueryTotalDataCountServiceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 数据资产平台查询数据记录数
         *
         * @param request QueryTotalDataCountServiceRequest
         * @return QueryTotalDataCountServiceResponse
         */
        public async Task<QueryTotalDataCountServiceResponse> QueryTotalDataCountServiceAsync(QueryTotalDataCountServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTotalDataCountServiceHeaders headers = new QueryTotalDataCountServiceHeaders();
            return await QueryTotalDataCountServiceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业视频会议统计数据
         *
         * @param request QueryVedioMeetingStatisticalDataRequest
         * @param headers QueryVedioMeetingStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryVedioMeetingStatisticalDataResponse
         */
        public QueryVedioMeetingStatisticalDataResponse QueryVedioMeetingStatisticalDataWithOptions(QueryVedioMeetingStatisticalDataRequest request, QueryVedioMeetingStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryVedioMeetingStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/vedioMeetingData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVedioMeetingStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业视频会议统计数据
         *
         * @param request QueryVedioMeetingStatisticalDataRequest
         * @param headers QueryVedioMeetingStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryVedioMeetingStatisticalDataResponse
         */
        public async Task<QueryVedioMeetingStatisticalDataResponse> QueryVedioMeetingStatisticalDataWithOptionsAsync(QueryVedioMeetingStatisticalDataRequest request, QueryVedioMeetingStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryVedioMeetingStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/vedioMeetingData",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVedioMeetingStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业视频会议统计数据
         *
         * @param request QueryVedioMeetingStatisticalDataRequest
         * @return QueryVedioMeetingStatisticalDataResponse
         */
        public QueryVedioMeetingStatisticalDataResponse QueryVedioMeetingStatisticalData(QueryVedioMeetingStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryVedioMeetingStatisticalDataHeaders headers = new QueryVedioMeetingStatisticalDataHeaders();
            return QueryVedioMeetingStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业视频会议统计数据
         *
         * @param request QueryVedioMeetingStatisticalDataRequest
         * @return QueryVedioMeetingStatisticalDataResponse
         */
        public async Task<QueryVedioMeetingStatisticalDataResponse> QueryVedioMeetingStatisticalDataAsync(QueryVedioMeetingStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryVedioMeetingStatisticalDataHeaders headers = new QueryVedioMeetingStatisticalDataHeaders();
            return await QueryVedioMeetingStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉参谋活跃分析（按日统计）指标接口
         *
         * @param request QueryYydActiveDayStatisticalDataRequest
         * @param headers QueryYydActiveDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydActiveDayStatisticalDataResponse
         */
        public QueryYydActiveDayStatisticalDataResponse QueryYydActiveDayStatisticalDataWithOptions(QueryYydActiveDayStatisticalDataRequest request, QueryYydActiveDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydActiveDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydActiveDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydActiveDayStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉参谋活跃分析（按日统计）指标接口
         *
         * @param request QueryYydActiveDayStatisticalDataRequest
         * @param headers QueryYydActiveDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydActiveDayStatisticalDataResponse
         */
        public async Task<QueryYydActiveDayStatisticalDataResponse> QueryYydActiveDayStatisticalDataWithOptionsAsync(QueryYydActiveDayStatisticalDataRequest request, QueryYydActiveDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydActiveDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydActiveDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydActiveDayStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉参谋活跃分析（按日统计）指标接口
         *
         * @param request QueryYydActiveDayStatisticalDataRequest
         * @return QueryYydActiveDayStatisticalDataResponse
         */
        public QueryYydActiveDayStatisticalDataResponse QueryYydActiveDayStatisticalData(QueryYydActiveDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydActiveDayStatisticalDataHeaders headers = new QueryYydActiveDayStatisticalDataHeaders();
            return QueryYydActiveDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉参谋活跃分析（按日统计）指标接口
         *
         * @param request QueryYydActiveDayStatisticalDataRequest
         * @return QueryYydActiveDayStatisticalDataResponse
         */
        public async Task<QueryYydActiveDayStatisticalDataResponse> QueryYydActiveDayStatisticalDataAsync(QueryYydActiveDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydActiveDayStatisticalDataHeaders headers = new QueryYydActiveDayStatisticalDataHeaders();
            return await QueryYydActiveDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉参谋活跃分析（按月统计）指标接口
         *
         * @param request QueryYydActiveMonthStatisticalDataRequest
         * @param headers QueryYydActiveMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydActiveMonthStatisticalDataResponse
         */
        public QueryYydActiveMonthStatisticalDataResponse QueryYydActiveMonthStatisticalDataWithOptions(QueryYydActiveMonthStatisticalDataRequest request, QueryYydActiveMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydActiveMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydActiveMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydActiveMonthStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉参谋活跃分析（按月统计）指标接口
         *
         * @param request QueryYydActiveMonthStatisticalDataRequest
         * @param headers QueryYydActiveMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydActiveMonthStatisticalDataResponse
         */
        public async Task<QueryYydActiveMonthStatisticalDataResponse> QueryYydActiveMonthStatisticalDataWithOptionsAsync(QueryYydActiveMonthStatisticalDataRequest request, QueryYydActiveMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydActiveMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydActiveMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydActiveMonthStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉参谋活跃分析（按月统计）指标接口
         *
         * @param request QueryYydActiveMonthStatisticalDataRequest
         * @return QueryYydActiveMonthStatisticalDataResponse
         */
        public QueryYydActiveMonthStatisticalDataResponse QueryYydActiveMonthStatisticalData(QueryYydActiveMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydActiveMonthStatisticalDataHeaders headers = new QueryYydActiveMonthStatisticalDataHeaders();
            return QueryYydActiveMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉参谋活跃分析（按月统计）指标接口
         *
         * @param request QueryYydActiveMonthStatisticalDataRequest
         * @return QueryYydActiveMonthStatisticalDataResponse
         */
        public async Task<QueryYydActiveMonthStatisticalDataResponse> QueryYydActiveMonthStatisticalDataAsync(QueryYydActiveMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydActiveMonthStatisticalDataHeaders headers = new QueryYydActiveMonthStatisticalDataHeaders();
            return await QueryYydActiveMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉参谋活跃分析（按周统计）指标接口
         *
         * @param request QueryYydActiveWeekStatisticalDataRequest
         * @param headers QueryYydActiveWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydActiveWeekStatisticalDataResponse
         */
        public QueryYydActiveWeekStatisticalDataResponse QueryYydActiveWeekStatisticalDataWithOptions(QueryYydActiveWeekStatisticalDataRequest request, QueryYydActiveWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydActiveWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydActiveWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydActiveWeekStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉参谋活跃分析（按周统计）指标接口
         *
         * @param request QueryYydActiveWeekStatisticalDataRequest
         * @param headers QueryYydActiveWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydActiveWeekStatisticalDataResponse
         */
        public async Task<QueryYydActiveWeekStatisticalDataResponse> QueryYydActiveWeekStatisticalDataWithOptionsAsync(QueryYydActiveWeekStatisticalDataRequest request, QueryYydActiveWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydActiveWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydActiveWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydActiveWeekStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉参谋活跃分析（按周统计）指标接口
         *
         * @param request QueryYydActiveWeekStatisticalDataRequest
         * @return QueryYydActiveWeekStatisticalDataResponse
         */
        public QueryYydActiveWeekStatisticalDataResponse QueryYydActiveWeekStatisticalData(QueryYydActiveWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydActiveWeekStatisticalDataHeaders headers = new QueryYydActiveWeekStatisticalDataHeaders();
            return QueryYydActiveWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉参谋活跃分析（按周统计）指标接口
         *
         * @param request QueryYydActiveWeekStatisticalDataRequest
         * @return QueryYydActiveWeekStatisticalDataResponse
         */
        public async Task<QueryYydActiveWeekStatisticalDataResponse> QueryYydActiveWeekStatisticalDataAsync(QueryYydActiveWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydActiveWeekStatisticalDataHeaders headers = new QueryYydActiveWeekStatisticalDataHeaders();
            return await QueryYydActiveWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋应用概况（按日统计）指标接口
         *
         * @param request QueryYydAppDayStatisticalDataRequest
         * @param headers QueryYydAppDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydAppDayStatisticalDataResponse
         */
        public QueryYydAppDayStatisticalDataResponse QueryYydAppDayStatisticalDataWithOptions(QueryYydAppDayStatisticalDataRequest request, QueryYydAppDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydAppDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydAppDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydAppDayStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋应用概况（按日统计）指标接口
         *
         * @param request QueryYydAppDayStatisticalDataRequest
         * @param headers QueryYydAppDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydAppDayStatisticalDataResponse
         */
        public async Task<QueryYydAppDayStatisticalDataResponse> QueryYydAppDayStatisticalDataWithOptionsAsync(QueryYydAppDayStatisticalDataRequest request, QueryYydAppDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydAppDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydAppDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydAppDayStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋应用概况（按日统计）指标接口
         *
         * @param request QueryYydAppDayStatisticalDataRequest
         * @return QueryYydAppDayStatisticalDataResponse
         */
        public QueryYydAppDayStatisticalDataResponse QueryYydAppDayStatisticalData(QueryYydAppDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppDayStatisticalDataHeaders headers = new QueryYydAppDayStatisticalDataHeaders();
            return QueryYydAppDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋应用概况（按日统计）指标接口
         *
         * @param request QueryYydAppDayStatisticalDataRequest
         * @return QueryYydAppDayStatisticalDataResponse
         */
        public async Task<QueryYydAppDayStatisticalDataResponse> QueryYydAppDayStatisticalDataAsync(QueryYydAppDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppDayStatisticalDataHeaders headers = new QueryYydAppDayStatisticalDataHeaders();
            return await QueryYydAppDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋应用概况（按月统计）指标接口
         *
         * @param request QueryYydAppMonthStatisticalDataRequest
         * @param headers QueryYydAppMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydAppMonthStatisticalDataResponse
         */
        public QueryYydAppMonthStatisticalDataResponse QueryYydAppMonthStatisticalDataWithOptions(QueryYydAppMonthStatisticalDataRequest request, QueryYydAppMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydAppMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydAppMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydAppMonthStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋应用概况（按月统计）指标接口
         *
         * @param request QueryYydAppMonthStatisticalDataRequest
         * @param headers QueryYydAppMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydAppMonthStatisticalDataResponse
         */
        public async Task<QueryYydAppMonthStatisticalDataResponse> QueryYydAppMonthStatisticalDataWithOptionsAsync(QueryYydAppMonthStatisticalDataRequest request, QueryYydAppMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydAppMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydAppMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydAppMonthStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋应用概况（按月统计）指标接口
         *
         * @param request QueryYydAppMonthStatisticalDataRequest
         * @return QueryYydAppMonthStatisticalDataResponse
         */
        public QueryYydAppMonthStatisticalDataResponse QueryYydAppMonthStatisticalData(QueryYydAppMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppMonthStatisticalDataHeaders headers = new QueryYydAppMonthStatisticalDataHeaders();
            return QueryYydAppMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋应用概况（按月统计）指标接口
         *
         * @param request QueryYydAppMonthStatisticalDataRequest
         * @return QueryYydAppMonthStatisticalDataResponse
         */
        public async Task<QueryYydAppMonthStatisticalDataResponse> QueryYydAppMonthStatisticalDataAsync(QueryYydAppMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppMonthStatisticalDataHeaders headers = new QueryYydAppMonthStatisticalDataHeaders();
            return await QueryYydAppMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋应用概况（累计）指标接口
         *
         * @param request QueryYydAppStdStatisticalDataRequest
         * @param headers QueryYydAppStdStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydAppStdStatisticalDataResponse
         */
        public QueryYydAppStdStatisticalDataResponse QueryYydAppStdStatisticalDataWithOptions(QueryYydAppStdStatisticalDataRequest request, QueryYydAppStdStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydAppStdStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydAppStdDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydAppStdStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋应用概况（累计）指标接口
         *
         * @param request QueryYydAppStdStatisticalDataRequest
         * @param headers QueryYydAppStdStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydAppStdStatisticalDataResponse
         */
        public async Task<QueryYydAppStdStatisticalDataResponse> QueryYydAppStdStatisticalDataWithOptionsAsync(QueryYydAppStdStatisticalDataRequest request, QueryYydAppStdStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydAppStdStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydAppStdDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydAppStdStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋应用概况（累计）指标接口
         *
         * @param request QueryYydAppStdStatisticalDataRequest
         * @return QueryYydAppStdStatisticalDataResponse
         */
        public QueryYydAppStdStatisticalDataResponse QueryYydAppStdStatisticalData(QueryYydAppStdStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppStdStatisticalDataHeaders headers = new QueryYydAppStdStatisticalDataHeaders();
            return QueryYydAppStdStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋应用概况（累计）指标接口
         *
         * @param request QueryYydAppStdStatisticalDataRequest
         * @return QueryYydAppStdStatisticalDataResponse
         */
        public async Task<QueryYydAppStdStatisticalDataResponse> QueryYydAppStdStatisticalDataAsync(QueryYydAppStdStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppStdStatisticalDataHeaders headers = new QueryYydAppStdStatisticalDataHeaders();
            return await QueryYydAppStdStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋应用概况（按周统计）指标接口
         *
         * @param request QueryYydAppWeekStatisticalDataRequest
         * @param headers QueryYydAppWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydAppWeekStatisticalDataResponse
         */
        public QueryYydAppWeekStatisticalDataResponse QueryYydAppWeekStatisticalDataWithOptions(QueryYydAppWeekStatisticalDataRequest request, QueryYydAppWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydAppWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydAppWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydAppWeekStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋应用概况（按周统计）指标接口
         *
         * @param request QueryYydAppWeekStatisticalDataRequest
         * @param headers QueryYydAppWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydAppWeekStatisticalDataResponse
         */
        public async Task<QueryYydAppWeekStatisticalDataResponse> QueryYydAppWeekStatisticalDataWithOptionsAsync(QueryYydAppWeekStatisticalDataRequest request, QueryYydAppWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydAppWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydAppWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydAppWeekStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋应用概况（按周统计）指标接口
         *
         * @param request QueryYydAppWeekStatisticalDataRequest
         * @return QueryYydAppWeekStatisticalDataResponse
         */
        public QueryYydAppWeekStatisticalDataResponse QueryYydAppWeekStatisticalData(QueryYydAppWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppWeekStatisticalDataHeaders headers = new QueryYydAppWeekStatisticalDataHeaders();
            return QueryYydAppWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋应用概况（按周统计）指标接口
         *
         * @param request QueryYydAppWeekStatisticalDataRequest
         * @return QueryYydAppWeekStatisticalDataResponse
         */
        public async Task<QueryYydAppWeekStatisticalDataResponse> QueryYydAppWeekStatisticalDataAsync(QueryYydAppWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppWeekStatisticalDataHeaders headers = new QueryYydAppWeekStatisticalDataHeaders();
            return await QueryYydAppWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋会议日程分析（按日统计）指标接口
         *
         * @param request QueryYydCalendarDayStatisticalDataRequest
         * @param headers QueryYydCalendarDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydCalendarDayStatisticalDataResponse
         */
        public QueryYydCalendarDayStatisticalDataResponse QueryYydCalendarDayStatisticalDataWithOptions(QueryYydCalendarDayStatisticalDataRequest request, QueryYydCalendarDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydCalendarDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydCalendarDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydCalendarDayStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋会议日程分析（按日统计）指标接口
         *
         * @param request QueryYydCalendarDayStatisticalDataRequest
         * @param headers QueryYydCalendarDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydCalendarDayStatisticalDataResponse
         */
        public async Task<QueryYydCalendarDayStatisticalDataResponse> QueryYydCalendarDayStatisticalDataWithOptionsAsync(QueryYydCalendarDayStatisticalDataRequest request, QueryYydCalendarDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydCalendarDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydCalendarDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydCalendarDayStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋会议日程分析（按日统计）指标接口
         *
         * @param request QueryYydCalendarDayStatisticalDataRequest
         * @return QueryYydCalendarDayStatisticalDataResponse
         */
        public QueryYydCalendarDayStatisticalDataResponse QueryYydCalendarDayStatisticalData(QueryYydCalendarDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydCalendarDayStatisticalDataHeaders headers = new QueryYydCalendarDayStatisticalDataHeaders();
            return QueryYydCalendarDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋会议日程分析（按日统计）指标接口
         *
         * @param request QueryYydCalendarDayStatisticalDataRequest
         * @return QueryYydCalendarDayStatisticalDataResponse
         */
        public async Task<QueryYydCalendarDayStatisticalDataResponse> QueryYydCalendarDayStatisticalDataAsync(QueryYydCalendarDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydCalendarDayStatisticalDataHeaders headers = new QueryYydCalendarDayStatisticalDataHeaders();
            return await QueryYydCalendarDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋会议日程分析（按月统计）指标接口
         *
         * @param request QueryYydCalendarMonthStatisticalDataRequest
         * @param headers QueryYydCalendarMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydCalendarMonthStatisticalDataResponse
         */
        public QueryYydCalendarMonthStatisticalDataResponse QueryYydCalendarMonthStatisticalDataWithOptions(QueryYydCalendarMonthStatisticalDataRequest request, QueryYydCalendarMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydCalendarMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydCalendarMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydCalendarMonthStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋会议日程分析（按月统计）指标接口
         *
         * @param request QueryYydCalendarMonthStatisticalDataRequest
         * @param headers QueryYydCalendarMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydCalendarMonthStatisticalDataResponse
         */
        public async Task<QueryYydCalendarMonthStatisticalDataResponse> QueryYydCalendarMonthStatisticalDataWithOptionsAsync(QueryYydCalendarMonthStatisticalDataRequest request, QueryYydCalendarMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydCalendarMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydCalendarMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydCalendarMonthStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋会议日程分析（按月统计）指标接口
         *
         * @param request QueryYydCalendarMonthStatisticalDataRequest
         * @return QueryYydCalendarMonthStatisticalDataResponse
         */
        public QueryYydCalendarMonthStatisticalDataResponse QueryYydCalendarMonthStatisticalData(QueryYydCalendarMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydCalendarMonthStatisticalDataHeaders headers = new QueryYydCalendarMonthStatisticalDataHeaders();
            return QueryYydCalendarMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋会议日程分析（按月统计）指标接口
         *
         * @param request QueryYydCalendarMonthStatisticalDataRequest
         * @return QueryYydCalendarMonthStatisticalDataResponse
         */
        public async Task<QueryYydCalendarMonthStatisticalDataResponse> QueryYydCalendarMonthStatisticalDataAsync(QueryYydCalendarMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydCalendarMonthStatisticalDataHeaders headers = new QueryYydCalendarMonthStatisticalDataHeaders();
            return await QueryYydCalendarMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋会议日程分析（按周统计）指标接口
         *
         * @param request QueryYydCalendarWeekStatisticalDataRequest
         * @param headers QueryYydCalendarWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydCalendarWeekStatisticalDataResponse
         */
        public QueryYydCalendarWeekStatisticalDataResponse QueryYydCalendarWeekStatisticalDataWithOptions(QueryYydCalendarWeekStatisticalDataRequest request, QueryYydCalendarWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydCalendarWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydCalendarWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydCalendarWeekStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋会议日程分析（按周统计）指标接口
         *
         * @param request QueryYydCalendarWeekStatisticalDataRequest
         * @param headers QueryYydCalendarWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydCalendarWeekStatisticalDataResponse
         */
        public async Task<QueryYydCalendarWeekStatisticalDataResponse> QueryYydCalendarWeekStatisticalDataWithOptionsAsync(QueryYydCalendarWeekStatisticalDataRequest request, QueryYydCalendarWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydCalendarWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydCalendarWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydCalendarWeekStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋会议日程分析（按周统计）指标接口
         *
         * @param request QueryYydCalendarWeekStatisticalDataRequest
         * @return QueryYydCalendarWeekStatisticalDataResponse
         */
        public QueryYydCalendarWeekStatisticalDataResponse QueryYydCalendarWeekStatisticalData(QueryYydCalendarWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydCalendarWeekStatisticalDataHeaders headers = new QueryYydCalendarWeekStatisticalDataHeaders();
            return QueryYydCalendarWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋会议日程分析（按周统计）指标接口
         *
         * @param request QueryYydCalendarWeekStatisticalDataRequest
         * @return QueryYydCalendarWeekStatisticalDataResponse
         */
        public async Task<QueryYydCalendarWeekStatisticalDataResponse> QueryYydCalendarWeekStatisticalDataAsync(QueryYydCalendarWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydCalendarWeekStatisticalDataHeaders headers = new QueryYydCalendarWeekStatisticalDataHeaders();
            return await QueryYydCalendarWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋钉消息分析（按日统计）指标接口
         *
         * @param request QueryYydDingMsgDayStatisticalDataRequest
         * @param headers QueryYydDingMsgDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydDingMsgDayStatisticalDataResponse
         */
        public QueryYydDingMsgDayStatisticalDataResponse QueryYydDingMsgDayStatisticalDataWithOptions(QueryYydDingMsgDayStatisticalDataRequest request, QueryYydDingMsgDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydDingMsgDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydDingMsgDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydDingMsgDayStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋钉消息分析（按日统计）指标接口
         *
         * @param request QueryYydDingMsgDayStatisticalDataRequest
         * @param headers QueryYydDingMsgDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydDingMsgDayStatisticalDataResponse
         */
        public async Task<QueryYydDingMsgDayStatisticalDataResponse> QueryYydDingMsgDayStatisticalDataWithOptionsAsync(QueryYydDingMsgDayStatisticalDataRequest request, QueryYydDingMsgDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydDingMsgDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydDingMsgDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydDingMsgDayStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋钉消息分析（按日统计）指标接口
         *
         * @param request QueryYydDingMsgDayStatisticalDataRequest
         * @return QueryYydDingMsgDayStatisticalDataResponse
         */
        public QueryYydDingMsgDayStatisticalDataResponse QueryYydDingMsgDayStatisticalData(QueryYydDingMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydDingMsgDayStatisticalDataHeaders headers = new QueryYydDingMsgDayStatisticalDataHeaders();
            return QueryYydDingMsgDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋钉消息分析（按日统计）指标接口
         *
         * @param request QueryYydDingMsgDayStatisticalDataRequest
         * @return QueryYydDingMsgDayStatisticalDataResponse
         */
        public async Task<QueryYydDingMsgDayStatisticalDataResponse> QueryYydDingMsgDayStatisticalDataAsync(QueryYydDingMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydDingMsgDayStatisticalDataHeaders headers = new QueryYydDingMsgDayStatisticalDataHeaders();
            return await QueryYydDingMsgDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋钉消息分析（按月统计）指标接口
         *
         * @param request QueryYydDingMsgMonthStatisticalDataRequest
         * @param headers QueryYydDingMsgMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydDingMsgMonthStatisticalDataResponse
         */
        public QueryYydDingMsgMonthStatisticalDataResponse QueryYydDingMsgMonthStatisticalDataWithOptions(QueryYydDingMsgMonthStatisticalDataRequest request, QueryYydDingMsgMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydDingMsgMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydDingMsgMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydDingMsgMonthStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋钉消息分析（按月统计）指标接口
         *
         * @param request QueryYydDingMsgMonthStatisticalDataRequest
         * @param headers QueryYydDingMsgMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydDingMsgMonthStatisticalDataResponse
         */
        public async Task<QueryYydDingMsgMonthStatisticalDataResponse> QueryYydDingMsgMonthStatisticalDataWithOptionsAsync(QueryYydDingMsgMonthStatisticalDataRequest request, QueryYydDingMsgMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydDingMsgMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydDingMsgMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydDingMsgMonthStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋钉消息分析（按月统计）指标接口
         *
         * @param request QueryYydDingMsgMonthStatisticalDataRequest
         * @return QueryYydDingMsgMonthStatisticalDataResponse
         */
        public QueryYydDingMsgMonthStatisticalDataResponse QueryYydDingMsgMonthStatisticalData(QueryYydDingMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydDingMsgMonthStatisticalDataHeaders headers = new QueryYydDingMsgMonthStatisticalDataHeaders();
            return QueryYydDingMsgMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋钉消息分析（按月统计）指标接口
         *
         * @param request QueryYydDingMsgMonthStatisticalDataRequest
         * @return QueryYydDingMsgMonthStatisticalDataResponse
         */
        public async Task<QueryYydDingMsgMonthStatisticalDataResponse> QueryYydDingMsgMonthStatisticalDataAsync(QueryYydDingMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydDingMsgMonthStatisticalDataHeaders headers = new QueryYydDingMsgMonthStatisticalDataHeaders();
            return await QueryYydDingMsgMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋钉消息分析（按周统计）指标接口
         *
         * @param request QueryYydDingMsgWeekStatisticalDataRequest
         * @param headers QueryYydDingMsgWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydDingMsgWeekStatisticalDataResponse
         */
        public QueryYydDingMsgWeekStatisticalDataResponse QueryYydDingMsgWeekStatisticalDataWithOptions(QueryYydDingMsgWeekStatisticalDataRequest request, QueryYydDingMsgWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydDingMsgWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydDingMsgWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydDingMsgWeekStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋钉消息分析（按周统计）指标接口
         *
         * @param request QueryYydDingMsgWeekStatisticalDataRequest
         * @param headers QueryYydDingMsgWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydDingMsgWeekStatisticalDataResponse
         */
        public async Task<QueryYydDingMsgWeekStatisticalDataResponse> QueryYydDingMsgWeekStatisticalDataWithOptionsAsync(QueryYydDingMsgWeekStatisticalDataRequest request, QueryYydDingMsgWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydDingMsgWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydDingMsgWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydDingMsgWeekStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋钉消息分析（按周统计）指标接口
         *
         * @param request QueryYydDingMsgWeekStatisticalDataRequest
         * @return QueryYydDingMsgWeekStatisticalDataResponse
         */
        public QueryYydDingMsgWeekStatisticalDataResponse QueryYydDingMsgWeekStatisticalData(QueryYydDingMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydDingMsgWeekStatisticalDataHeaders headers = new QueryYydDingMsgWeekStatisticalDataHeaders();
            return QueryYydDingMsgWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋钉消息分析（按周统计）指标接口
         *
         * @param request QueryYydDingMsgWeekStatisticalDataRequest
         * @return QueryYydDingMsgWeekStatisticalDataResponse
         */
        public async Task<QueryYydDingMsgWeekStatisticalDataResponse> QueryYydDingMsgWeekStatisticalDataAsync(QueryYydDingMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydDingMsgWeekStatisticalDataHeaders headers = new QueryYydDingMsgWeekStatisticalDataHeaders();
            return await QueryYydDingMsgWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋群聊分析（按日统计）指标接口
         *
         * @param request QueryYydGroupMsgDayStatisticalDataRequest
         * @param headers QueryYydGroupMsgDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydGroupMsgDayStatisticalDataResponse
         */
        public QueryYydGroupMsgDayStatisticalDataResponse QueryYydGroupMsgDayStatisticalDataWithOptions(QueryYydGroupMsgDayStatisticalDataRequest request, QueryYydGroupMsgDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydGroupMsgDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydGroupMsgDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydGroupMsgDayStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋群聊分析（按日统计）指标接口
         *
         * @param request QueryYydGroupMsgDayStatisticalDataRequest
         * @param headers QueryYydGroupMsgDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydGroupMsgDayStatisticalDataResponse
         */
        public async Task<QueryYydGroupMsgDayStatisticalDataResponse> QueryYydGroupMsgDayStatisticalDataWithOptionsAsync(QueryYydGroupMsgDayStatisticalDataRequest request, QueryYydGroupMsgDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydGroupMsgDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydGroupMsgDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydGroupMsgDayStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋群聊分析（按日统计）指标接口
         *
         * @param request QueryYydGroupMsgDayStatisticalDataRequest
         * @return QueryYydGroupMsgDayStatisticalDataResponse
         */
        public QueryYydGroupMsgDayStatisticalDataResponse QueryYydGroupMsgDayStatisticalData(QueryYydGroupMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydGroupMsgDayStatisticalDataHeaders headers = new QueryYydGroupMsgDayStatisticalDataHeaders();
            return QueryYydGroupMsgDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋群聊分析（按日统计）指标接口
         *
         * @param request QueryYydGroupMsgDayStatisticalDataRequest
         * @return QueryYydGroupMsgDayStatisticalDataResponse
         */
        public async Task<QueryYydGroupMsgDayStatisticalDataResponse> QueryYydGroupMsgDayStatisticalDataAsync(QueryYydGroupMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydGroupMsgDayStatisticalDataHeaders headers = new QueryYydGroupMsgDayStatisticalDataHeaders();
            return await QueryYydGroupMsgDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋群聊分析（按月统计）指标接口
         *
         * @param request QueryYydGroupMsgMonthStatisticalDataRequest
         * @param headers QueryYydGroupMsgMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydGroupMsgMonthStatisticalDataResponse
         */
        public QueryYydGroupMsgMonthStatisticalDataResponse QueryYydGroupMsgMonthStatisticalDataWithOptions(QueryYydGroupMsgMonthStatisticalDataRequest request, QueryYydGroupMsgMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydGroupMsgMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydGroupMsgMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydGroupMsgMonthStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋群聊分析（按月统计）指标接口
         *
         * @param request QueryYydGroupMsgMonthStatisticalDataRequest
         * @param headers QueryYydGroupMsgMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydGroupMsgMonthStatisticalDataResponse
         */
        public async Task<QueryYydGroupMsgMonthStatisticalDataResponse> QueryYydGroupMsgMonthStatisticalDataWithOptionsAsync(QueryYydGroupMsgMonthStatisticalDataRequest request, QueryYydGroupMsgMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydGroupMsgMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydGroupMsgMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydGroupMsgMonthStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋群聊分析（按月统计）指标接口
         *
         * @param request QueryYydGroupMsgMonthStatisticalDataRequest
         * @return QueryYydGroupMsgMonthStatisticalDataResponse
         */
        public QueryYydGroupMsgMonthStatisticalDataResponse QueryYydGroupMsgMonthStatisticalData(QueryYydGroupMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydGroupMsgMonthStatisticalDataHeaders headers = new QueryYydGroupMsgMonthStatisticalDataHeaders();
            return QueryYydGroupMsgMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋群聊分析（按月统计）指标接口
         *
         * @param request QueryYydGroupMsgMonthStatisticalDataRequest
         * @return QueryYydGroupMsgMonthStatisticalDataResponse
         */
        public async Task<QueryYydGroupMsgMonthStatisticalDataResponse> QueryYydGroupMsgMonthStatisticalDataAsync(QueryYydGroupMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydGroupMsgMonthStatisticalDataHeaders headers = new QueryYydGroupMsgMonthStatisticalDataHeaders();
            return await QueryYydGroupMsgMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋群聊分析（按周统计）指标接口
         *
         * @param request QueryYydGroupMsgWeekStatisticalDataRequest
         * @param headers QueryYydGroupMsgWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydGroupMsgWeekStatisticalDataResponse
         */
        public QueryYydGroupMsgWeekStatisticalDataResponse QueryYydGroupMsgWeekStatisticalDataWithOptions(QueryYydGroupMsgWeekStatisticalDataRequest request, QueryYydGroupMsgWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydGroupMsgWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydGroupMsgWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydGroupMsgWeekStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋群聊分析（按周统计）指标接口
         *
         * @param request QueryYydGroupMsgWeekStatisticalDataRequest
         * @param headers QueryYydGroupMsgWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydGroupMsgWeekStatisticalDataResponse
         */
        public async Task<QueryYydGroupMsgWeekStatisticalDataResponse> QueryYydGroupMsgWeekStatisticalDataWithOptionsAsync(QueryYydGroupMsgWeekStatisticalDataRequest request, QueryYydGroupMsgWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydGroupMsgWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydGroupMsgWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydGroupMsgWeekStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋群聊分析（按周统计）指标接口
         *
         * @param request QueryYydGroupMsgWeekStatisticalDataRequest
         * @return QueryYydGroupMsgWeekStatisticalDataResponse
         */
        public QueryYydGroupMsgWeekStatisticalDataResponse QueryYydGroupMsgWeekStatisticalData(QueryYydGroupMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydGroupMsgWeekStatisticalDataHeaders headers = new QueryYydGroupMsgWeekStatisticalDataHeaders();
            return QueryYydGroupMsgWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋群聊分析（按周统计）指标接口
         *
         * @param request QueryYydGroupMsgWeekStatisticalDataRequest
         * @return QueryYydGroupMsgWeekStatisticalDataResponse
         */
        public async Task<QueryYydGroupMsgWeekStatisticalDataResponse> QueryYydGroupMsgWeekStatisticalDataAsync(QueryYydGroupMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydGroupMsgWeekStatisticalDataHeaders headers = new QueryYydGroupMsgWeekStatisticalDataHeaders();
            return await QueryYydGroupMsgWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋日志分析（按日统计）指标接口
         *
         * @param request QueryYydLogDayStatisticalDataRequest
         * @param headers QueryYydLogDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydLogDayStatisticalDataResponse
         */
        public QueryYydLogDayStatisticalDataResponse QueryYydLogDayStatisticalDataWithOptions(QueryYydLogDayStatisticalDataRequest request, QueryYydLogDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydLogDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydLogDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydLogDayStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋日志分析（按日统计）指标接口
         *
         * @param request QueryYydLogDayStatisticalDataRequest
         * @param headers QueryYydLogDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydLogDayStatisticalDataResponse
         */
        public async Task<QueryYydLogDayStatisticalDataResponse> QueryYydLogDayStatisticalDataWithOptionsAsync(QueryYydLogDayStatisticalDataRequest request, QueryYydLogDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydLogDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydLogDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydLogDayStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋日志分析（按日统计）指标接口
         *
         * @param request QueryYydLogDayStatisticalDataRequest
         * @return QueryYydLogDayStatisticalDataResponse
         */
        public QueryYydLogDayStatisticalDataResponse QueryYydLogDayStatisticalData(QueryYydLogDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydLogDayStatisticalDataHeaders headers = new QueryYydLogDayStatisticalDataHeaders();
            return QueryYydLogDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋日志分析（按日统计）指标接口
         *
         * @param request QueryYydLogDayStatisticalDataRequest
         * @return QueryYydLogDayStatisticalDataResponse
         */
        public async Task<QueryYydLogDayStatisticalDataResponse> QueryYydLogDayStatisticalDataAsync(QueryYydLogDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydLogDayStatisticalDataHeaders headers = new QueryYydLogDayStatisticalDataHeaders();
            return await QueryYydLogDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋日志分析（按月统计）指标接口
         *
         * @param request QueryYydLogMonthStatisticalDataRequest
         * @param headers QueryYydLogMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydLogMonthStatisticalDataResponse
         */
        public QueryYydLogMonthStatisticalDataResponse QueryYydLogMonthStatisticalDataWithOptions(QueryYydLogMonthStatisticalDataRequest request, QueryYydLogMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydLogMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydLogMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydLogMonthStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋日志分析（按月统计）指标接口
         *
         * @param request QueryYydLogMonthStatisticalDataRequest
         * @param headers QueryYydLogMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydLogMonthStatisticalDataResponse
         */
        public async Task<QueryYydLogMonthStatisticalDataResponse> QueryYydLogMonthStatisticalDataWithOptionsAsync(QueryYydLogMonthStatisticalDataRequest request, QueryYydLogMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydLogMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydLogMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydLogMonthStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋日志分析（按月统计）指标接口
         *
         * @param request QueryYydLogMonthStatisticalDataRequest
         * @return QueryYydLogMonthStatisticalDataResponse
         */
        public QueryYydLogMonthStatisticalDataResponse QueryYydLogMonthStatisticalData(QueryYydLogMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydLogMonthStatisticalDataHeaders headers = new QueryYydLogMonthStatisticalDataHeaders();
            return QueryYydLogMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋日志分析（按月统计）指标接口
         *
         * @param request QueryYydLogMonthStatisticalDataRequest
         * @return QueryYydLogMonthStatisticalDataResponse
         */
        public async Task<QueryYydLogMonthStatisticalDataResponse> QueryYydLogMonthStatisticalDataAsync(QueryYydLogMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydLogMonthStatisticalDataHeaders headers = new QueryYydLogMonthStatisticalDataHeaders();
            return await QueryYydLogMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋日志分析（按周统计）指标接口
         *
         * @param request QueryYydLogWeekStatisticalDataRequest
         * @param headers QueryYydLogWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydLogWeekStatisticalDataResponse
         */
        public QueryYydLogWeekStatisticalDataResponse QueryYydLogWeekStatisticalDataWithOptions(QueryYydLogWeekStatisticalDataRequest request, QueryYydLogWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydLogWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydLogWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydLogWeekStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋日志分析（按周统计）指标接口
         *
         * @param request QueryYydLogWeekStatisticalDataRequest
         * @param headers QueryYydLogWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydLogWeekStatisticalDataResponse
         */
        public async Task<QueryYydLogWeekStatisticalDataResponse> QueryYydLogWeekStatisticalDataWithOptionsAsync(QueryYydLogWeekStatisticalDataRequest request, QueryYydLogWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydLogWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydLogWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydLogWeekStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋日志分析（按周统计）指标接口
         *
         * @param request QueryYydLogWeekStatisticalDataRequest
         * @return QueryYydLogWeekStatisticalDataResponse
         */
        public QueryYydLogWeekStatisticalDataResponse QueryYydLogWeekStatisticalData(QueryYydLogWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydLogWeekStatisticalDataHeaders headers = new QueryYydLogWeekStatisticalDataHeaders();
            return QueryYydLogWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋日志分析（按周统计）指标接口
         *
         * @param request QueryYydLogWeekStatisticalDataRequest
         * @return QueryYydLogWeekStatisticalDataResponse
         */
        public async Task<QueryYydLogWeekStatisticalDataResponse> QueryYydLogWeekStatisticalDataAsync(QueryYydLogWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydLogWeekStatisticalDataHeaders headers = new QueryYydLogWeekStatisticalDataHeaders();
            return await QueryYydLogWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋钉会议分析（按日统计）指标接口
         *
         * @param request QueryYydMeetingDayStatisticalDataRequest
         * @param headers QueryYydMeetingDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydMeetingDayStatisticalDataResponse
         */
        public QueryYydMeetingDayStatisticalDataResponse QueryYydMeetingDayStatisticalDataWithOptions(QueryYydMeetingDayStatisticalDataRequest request, QueryYydMeetingDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydMeetingDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydMeetingDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydMeetingDayStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋钉会议分析（按日统计）指标接口
         *
         * @param request QueryYydMeetingDayStatisticalDataRequest
         * @param headers QueryYydMeetingDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydMeetingDayStatisticalDataResponse
         */
        public async Task<QueryYydMeetingDayStatisticalDataResponse> QueryYydMeetingDayStatisticalDataWithOptionsAsync(QueryYydMeetingDayStatisticalDataRequest request, QueryYydMeetingDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydMeetingDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydMeetingDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydMeetingDayStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋钉会议分析（按日统计）指标接口
         *
         * @param request QueryYydMeetingDayStatisticalDataRequest
         * @return QueryYydMeetingDayStatisticalDataResponse
         */
        public QueryYydMeetingDayStatisticalDataResponse QueryYydMeetingDayStatisticalData(QueryYydMeetingDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydMeetingDayStatisticalDataHeaders headers = new QueryYydMeetingDayStatisticalDataHeaders();
            return QueryYydMeetingDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋钉会议分析（按日统计）指标接口
         *
         * @param request QueryYydMeetingDayStatisticalDataRequest
         * @return QueryYydMeetingDayStatisticalDataResponse
         */
        public async Task<QueryYydMeetingDayStatisticalDataResponse> QueryYydMeetingDayStatisticalDataAsync(QueryYydMeetingDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydMeetingDayStatisticalDataHeaders headers = new QueryYydMeetingDayStatisticalDataHeaders();
            return await QueryYydMeetingDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋钉会议分析（按月统计）指标接口
         *
         * @param request QueryYydMeetingMonthStatisticalDataRequest
         * @param headers QueryYydMeetingMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydMeetingMonthStatisticalDataResponse
         */
        public QueryYydMeetingMonthStatisticalDataResponse QueryYydMeetingMonthStatisticalDataWithOptions(QueryYydMeetingMonthStatisticalDataRequest request, QueryYydMeetingMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydMeetingMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydMeetingMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydMeetingMonthStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋钉会议分析（按月统计）指标接口
         *
         * @param request QueryYydMeetingMonthStatisticalDataRequest
         * @param headers QueryYydMeetingMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydMeetingMonthStatisticalDataResponse
         */
        public async Task<QueryYydMeetingMonthStatisticalDataResponse> QueryYydMeetingMonthStatisticalDataWithOptionsAsync(QueryYydMeetingMonthStatisticalDataRequest request, QueryYydMeetingMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydMeetingMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydMeetingMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydMeetingMonthStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋钉会议分析（按月统计）指标接口
         *
         * @param request QueryYydMeetingMonthStatisticalDataRequest
         * @return QueryYydMeetingMonthStatisticalDataResponse
         */
        public QueryYydMeetingMonthStatisticalDataResponse QueryYydMeetingMonthStatisticalData(QueryYydMeetingMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydMeetingMonthStatisticalDataHeaders headers = new QueryYydMeetingMonthStatisticalDataHeaders();
            return QueryYydMeetingMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋钉会议分析（按月统计）指标接口
         *
         * @param request QueryYydMeetingMonthStatisticalDataRequest
         * @return QueryYydMeetingMonthStatisticalDataResponse
         */
        public async Task<QueryYydMeetingMonthStatisticalDataResponse> QueryYydMeetingMonthStatisticalDataAsync(QueryYydMeetingMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydMeetingMonthStatisticalDataHeaders headers = new QueryYydMeetingMonthStatisticalDataHeaders();
            return await QueryYydMeetingMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋钉会议分析（按周统计）指标接口
         *
         * @param request QueryYydMeetingWeekStatisticalDataRequest
         * @param headers QueryYydMeetingWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydMeetingWeekStatisticalDataResponse
         */
        public QueryYydMeetingWeekStatisticalDataResponse QueryYydMeetingWeekStatisticalDataWithOptions(QueryYydMeetingWeekStatisticalDataRequest request, QueryYydMeetingWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydMeetingWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydMeetingWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydMeetingWeekStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋钉会议分析（按周统计）指标接口
         *
         * @param request QueryYydMeetingWeekStatisticalDataRequest
         * @param headers QueryYydMeetingWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydMeetingWeekStatisticalDataResponse
         */
        public async Task<QueryYydMeetingWeekStatisticalDataResponse> QueryYydMeetingWeekStatisticalDataWithOptionsAsync(QueryYydMeetingWeekStatisticalDataRequest request, QueryYydMeetingWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydMeetingWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydMeetingWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydMeetingWeekStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋钉会议分析（按周统计）指标接口
         *
         * @param request QueryYydMeetingWeekStatisticalDataRequest
         * @return QueryYydMeetingWeekStatisticalDataResponse
         */
        public QueryYydMeetingWeekStatisticalDataResponse QueryYydMeetingWeekStatisticalData(QueryYydMeetingWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydMeetingWeekStatisticalDataHeaders headers = new QueryYydMeetingWeekStatisticalDataHeaders();
            return QueryYydMeetingWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋钉会议分析（按周统计）指标接口
         *
         * @param request QueryYydMeetingWeekStatisticalDataRequest
         * @return QueryYydMeetingWeekStatisticalDataResponse
         */
        public async Task<QueryYydMeetingWeekStatisticalDataResponse> QueryYydMeetingWeekStatisticalDataAsync(QueryYydMeetingWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydMeetingWeekStatisticalDataHeaders headers = new QueryYydMeetingWeekStatisticalDataHeaders();
            return await QueryYydMeetingWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋通知分析（按日统计）指标接口
         *
         * @param request QueryYydNoticeDayStatisticalDataRequest
         * @param headers QueryYydNoticeDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydNoticeDayStatisticalDataResponse
         */
        public QueryYydNoticeDayStatisticalDataResponse QueryYydNoticeDayStatisticalDataWithOptions(QueryYydNoticeDayStatisticalDataRequest request, QueryYydNoticeDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydNoticeDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydNoticeDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydNoticeDayStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋通知分析（按日统计）指标接口
         *
         * @param request QueryYydNoticeDayStatisticalDataRequest
         * @param headers QueryYydNoticeDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydNoticeDayStatisticalDataResponse
         */
        public async Task<QueryYydNoticeDayStatisticalDataResponse> QueryYydNoticeDayStatisticalDataWithOptionsAsync(QueryYydNoticeDayStatisticalDataRequest request, QueryYydNoticeDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydNoticeDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydNoticeDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydNoticeDayStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋通知分析（按日统计）指标接口
         *
         * @param request QueryYydNoticeDayStatisticalDataRequest
         * @return QueryYydNoticeDayStatisticalDataResponse
         */
        public QueryYydNoticeDayStatisticalDataResponse QueryYydNoticeDayStatisticalData(QueryYydNoticeDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydNoticeDayStatisticalDataHeaders headers = new QueryYydNoticeDayStatisticalDataHeaders();
            return QueryYydNoticeDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋通知分析（按日统计）指标接口
         *
         * @param request QueryYydNoticeDayStatisticalDataRequest
         * @return QueryYydNoticeDayStatisticalDataResponse
         */
        public async Task<QueryYydNoticeDayStatisticalDataResponse> QueryYydNoticeDayStatisticalDataAsync(QueryYydNoticeDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydNoticeDayStatisticalDataHeaders headers = new QueryYydNoticeDayStatisticalDataHeaders();
            return await QueryYydNoticeDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋通知分析（按月统计）指标接口
         *
         * @param request QueryYydNoticeMonthStatisticalDataRequest
         * @param headers QueryYydNoticeMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydNoticeMonthStatisticalDataResponse
         */
        public QueryYydNoticeMonthStatisticalDataResponse QueryYydNoticeMonthStatisticalDataWithOptions(QueryYydNoticeMonthStatisticalDataRequest request, QueryYydNoticeMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydNoticeMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydNoticeMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydNoticeMonthStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋通知分析（按月统计）指标接口
         *
         * @param request QueryYydNoticeMonthStatisticalDataRequest
         * @param headers QueryYydNoticeMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydNoticeMonthStatisticalDataResponse
         */
        public async Task<QueryYydNoticeMonthStatisticalDataResponse> QueryYydNoticeMonthStatisticalDataWithOptionsAsync(QueryYydNoticeMonthStatisticalDataRequest request, QueryYydNoticeMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydNoticeMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydNoticeMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydNoticeMonthStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋通知分析（按月统计）指标接口
         *
         * @param request QueryYydNoticeMonthStatisticalDataRequest
         * @return QueryYydNoticeMonthStatisticalDataResponse
         */
        public QueryYydNoticeMonthStatisticalDataResponse QueryYydNoticeMonthStatisticalData(QueryYydNoticeMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydNoticeMonthStatisticalDataHeaders headers = new QueryYydNoticeMonthStatisticalDataHeaders();
            return QueryYydNoticeMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋通知分析（按月统计）指标接口
         *
         * @param request QueryYydNoticeMonthStatisticalDataRequest
         * @return QueryYydNoticeMonthStatisticalDataResponse
         */
        public async Task<QueryYydNoticeMonthStatisticalDataResponse> QueryYydNoticeMonthStatisticalDataAsync(QueryYydNoticeMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydNoticeMonthStatisticalDataHeaders headers = new QueryYydNoticeMonthStatisticalDataHeaders();
            return await QueryYydNoticeMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋通知分析（按周统计）指标接口
         *
         * @param request QueryYydNoticeWeekStatisticalDataRequest
         * @param headers QueryYydNoticeWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydNoticeWeekStatisticalDataResponse
         */
        public QueryYydNoticeWeekStatisticalDataResponse QueryYydNoticeWeekStatisticalDataWithOptions(QueryYydNoticeWeekStatisticalDataRequest request, QueryYydNoticeWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydNoticeWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydNoticeWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydNoticeWeekStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋通知分析（按周统计）指标接口
         *
         * @param request QueryYydNoticeWeekStatisticalDataRequest
         * @param headers QueryYydNoticeWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydNoticeWeekStatisticalDataResponse
         */
        public async Task<QueryYydNoticeWeekStatisticalDataResponse> QueryYydNoticeWeekStatisticalDataWithOptionsAsync(QueryYydNoticeWeekStatisticalDataRequest request, QueryYydNoticeWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydNoticeWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydNoticeWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydNoticeWeekStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋通知分析（按周统计）指标接口
         *
         * @param request QueryYydNoticeWeekStatisticalDataRequest
         * @return QueryYydNoticeWeekStatisticalDataResponse
         */
        public QueryYydNoticeWeekStatisticalDataResponse QueryYydNoticeWeekStatisticalData(QueryYydNoticeWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydNoticeWeekStatisticalDataHeaders headers = new QueryYydNoticeWeekStatisticalDataHeaders();
            return QueryYydNoticeWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋通知分析（按周统计）指标接口
         *
         * @param request QueryYydNoticeWeekStatisticalDataRequest
         * @return QueryYydNoticeWeekStatisticalDataResponse
         */
        public async Task<QueryYydNoticeWeekStatisticalDataResponse> QueryYydNoticeWeekStatisticalDataAsync(QueryYydNoticeWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydNoticeWeekStatisticalDataHeaders headers = new QueryYydNoticeWeekStatisticalDataHeaders();
            return await QueryYydNoticeWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋单聊分析（按日统计）指标接口
         *
         * @param request QueryYydSingleMsgDayStatisticalDataRequest
         * @param headers QueryYydSingleMsgDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydSingleMsgDayStatisticalDataResponse
         */
        public QueryYydSingleMsgDayStatisticalDataResponse QueryYydSingleMsgDayStatisticalDataWithOptions(QueryYydSingleMsgDayStatisticalDataRequest request, QueryYydSingleMsgDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydSingleMsgDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydSingleMsgDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydSingleMsgDayStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋单聊分析（按日统计）指标接口
         *
         * @param request QueryYydSingleMsgDayStatisticalDataRequest
         * @param headers QueryYydSingleMsgDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydSingleMsgDayStatisticalDataResponse
         */
        public async Task<QueryYydSingleMsgDayStatisticalDataResponse> QueryYydSingleMsgDayStatisticalDataWithOptionsAsync(QueryYydSingleMsgDayStatisticalDataRequest request, QueryYydSingleMsgDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydSingleMsgDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydSingleMsgDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydSingleMsgDayStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋单聊分析（按日统计）指标接口
         *
         * @param request QueryYydSingleMsgDayStatisticalDataRequest
         * @return QueryYydSingleMsgDayStatisticalDataResponse
         */
        public QueryYydSingleMsgDayStatisticalDataResponse QueryYydSingleMsgDayStatisticalData(QueryYydSingleMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydSingleMsgDayStatisticalDataHeaders headers = new QueryYydSingleMsgDayStatisticalDataHeaders();
            return QueryYydSingleMsgDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋单聊分析（按日统计）指标接口
         *
         * @param request QueryYydSingleMsgDayStatisticalDataRequest
         * @return QueryYydSingleMsgDayStatisticalDataResponse
         */
        public async Task<QueryYydSingleMsgDayStatisticalDataResponse> QueryYydSingleMsgDayStatisticalDataAsync(QueryYydSingleMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydSingleMsgDayStatisticalDataHeaders headers = new QueryYydSingleMsgDayStatisticalDataHeaders();
            return await QueryYydSingleMsgDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋单聊分析（按月统计）指标接口
         *
         * @param request QueryYydSingleMsgMonthStatisticalDataRequest
         * @param headers QueryYydSingleMsgMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydSingleMsgMonthStatisticalDataResponse
         */
        public QueryYydSingleMsgMonthStatisticalDataResponse QueryYydSingleMsgMonthStatisticalDataWithOptions(QueryYydSingleMsgMonthStatisticalDataRequest request, QueryYydSingleMsgMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydSingleMsgMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydSingleMsgMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydSingleMsgMonthStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋单聊分析（按月统计）指标接口
         *
         * @param request QueryYydSingleMsgMonthStatisticalDataRequest
         * @param headers QueryYydSingleMsgMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydSingleMsgMonthStatisticalDataResponse
         */
        public async Task<QueryYydSingleMsgMonthStatisticalDataResponse> QueryYydSingleMsgMonthStatisticalDataWithOptionsAsync(QueryYydSingleMsgMonthStatisticalDataRequest request, QueryYydSingleMsgMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydSingleMsgMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydSingleMsgMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydSingleMsgMonthStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋单聊分析（按月统计）指标接口
         *
         * @param request QueryYydSingleMsgMonthStatisticalDataRequest
         * @return QueryYydSingleMsgMonthStatisticalDataResponse
         */
        public QueryYydSingleMsgMonthStatisticalDataResponse QueryYydSingleMsgMonthStatisticalData(QueryYydSingleMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydSingleMsgMonthStatisticalDataHeaders headers = new QueryYydSingleMsgMonthStatisticalDataHeaders();
            return QueryYydSingleMsgMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋单聊分析（按月统计）指标接口
         *
         * @param request QueryYydSingleMsgMonthStatisticalDataRequest
         * @return QueryYydSingleMsgMonthStatisticalDataResponse
         */
        public async Task<QueryYydSingleMsgMonthStatisticalDataResponse> QueryYydSingleMsgMonthStatisticalDataAsync(QueryYydSingleMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydSingleMsgMonthStatisticalDataHeaders headers = new QueryYydSingleMsgMonthStatisticalDataHeaders();
            return await QueryYydSingleMsgMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋单聊分析（按周统计）指标接口
         *
         * @param request QueryYydSingleMsgWeekStatisticalDataRequest
         * @param headers QueryYydSingleMsgWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydSingleMsgWeekStatisticalDataResponse
         */
        public QueryYydSingleMsgWeekStatisticalDataResponse QueryYydSingleMsgWeekStatisticalDataWithOptions(QueryYydSingleMsgWeekStatisticalDataRequest request, QueryYydSingleMsgWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydSingleMsgWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydSingleMsgWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydSingleMsgWeekStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋单聊分析（按周统计）指标接口
         *
         * @param request QueryYydSingleMsgWeekStatisticalDataRequest
         * @param headers QueryYydSingleMsgWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydSingleMsgWeekStatisticalDataResponse
         */
        public async Task<QueryYydSingleMsgWeekStatisticalDataResponse> QueryYydSingleMsgWeekStatisticalDataWithOptionsAsync(QueryYydSingleMsgWeekStatisticalDataRequest request, QueryYydSingleMsgWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydSingleMsgWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydSingleMsgWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydSingleMsgWeekStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋单聊分析（按周统计）指标接口
         *
         * @param request QueryYydSingleMsgWeekStatisticalDataRequest
         * @return QueryYydSingleMsgWeekStatisticalDataResponse
         */
        public QueryYydSingleMsgWeekStatisticalDataResponse QueryYydSingleMsgWeekStatisticalData(QueryYydSingleMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydSingleMsgWeekStatisticalDataHeaders headers = new QueryYydSingleMsgWeekStatisticalDataHeaders();
            return QueryYydSingleMsgWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋单聊分析（按周统计）指标接口
         *
         * @param request QueryYydSingleMsgWeekStatisticalDataRequest
         * @return QueryYydSingleMsgWeekStatisticalDataResponse
         */
        public async Task<QueryYydSingleMsgWeekStatisticalDataResponse> QueryYydSingleMsgWeekStatisticalDataAsync(QueryYydSingleMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydSingleMsgWeekStatisticalDataHeaders headers = new QueryYydSingleMsgWeekStatisticalDataHeaders();
            return await QueryYydSingleMsgWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋消息概览（按日统计）指标接口
         *
         * @param request QueryYydToatlMsgDayStatisticalDataRequest
         * @param headers QueryYydToatlMsgDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydToatlMsgDayStatisticalDataResponse
         */
        public QueryYydToatlMsgDayStatisticalDataResponse QueryYydToatlMsgDayStatisticalDataWithOptions(QueryYydToatlMsgDayStatisticalDataRequest request, QueryYydToatlMsgDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydToatlMsgDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydToatlMsgDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydToatlMsgDayStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋消息概览（按日统计）指标接口
         *
         * @param request QueryYydToatlMsgDayStatisticalDataRequest
         * @param headers QueryYydToatlMsgDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydToatlMsgDayStatisticalDataResponse
         */
        public async Task<QueryYydToatlMsgDayStatisticalDataResponse> QueryYydToatlMsgDayStatisticalDataWithOptionsAsync(QueryYydToatlMsgDayStatisticalDataRequest request, QueryYydToatlMsgDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydToatlMsgDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydToatlMsgDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydToatlMsgDayStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋消息概览（按日统计）指标接口
         *
         * @param request QueryYydToatlMsgDayStatisticalDataRequest
         * @return QueryYydToatlMsgDayStatisticalDataResponse
         */
        public QueryYydToatlMsgDayStatisticalDataResponse QueryYydToatlMsgDayStatisticalData(QueryYydToatlMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydToatlMsgDayStatisticalDataHeaders headers = new QueryYydToatlMsgDayStatisticalDataHeaders();
            return QueryYydToatlMsgDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋消息概览（按日统计）指标接口
         *
         * @param request QueryYydToatlMsgDayStatisticalDataRequest
         * @return QueryYydToatlMsgDayStatisticalDataResponse
         */
        public async Task<QueryYydToatlMsgDayStatisticalDataResponse> QueryYydToatlMsgDayStatisticalDataAsync(QueryYydToatlMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydToatlMsgDayStatisticalDataHeaders headers = new QueryYydToatlMsgDayStatisticalDataHeaders();
            return await QueryYydToatlMsgDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋消息概览（按月统计）指标接口
         *
         * @param request QueryYydToatlMsgMonthStatisticalDataRequest
         * @param headers QueryYydToatlMsgMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydToatlMsgMonthStatisticalDataResponse
         */
        public QueryYydToatlMsgMonthStatisticalDataResponse QueryYydToatlMsgMonthStatisticalDataWithOptions(QueryYydToatlMsgMonthStatisticalDataRequest request, QueryYydToatlMsgMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydToatlMsgMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydToatlMsgMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydToatlMsgMonthStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋消息概览（按月统计）指标接口
         *
         * @param request QueryYydToatlMsgMonthStatisticalDataRequest
         * @param headers QueryYydToatlMsgMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydToatlMsgMonthStatisticalDataResponse
         */
        public async Task<QueryYydToatlMsgMonthStatisticalDataResponse> QueryYydToatlMsgMonthStatisticalDataWithOptionsAsync(QueryYydToatlMsgMonthStatisticalDataRequest request, QueryYydToatlMsgMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydToatlMsgMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydToatlMsgMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydToatlMsgMonthStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋消息概览（按月统计）指标接口
         *
         * @param request QueryYydToatlMsgMonthStatisticalDataRequest
         * @return QueryYydToatlMsgMonthStatisticalDataResponse
         */
        public QueryYydToatlMsgMonthStatisticalDataResponse QueryYydToatlMsgMonthStatisticalData(QueryYydToatlMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydToatlMsgMonthStatisticalDataHeaders headers = new QueryYydToatlMsgMonthStatisticalDataHeaders();
            return QueryYydToatlMsgMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋消息概览（按月统计）指标接口
         *
         * @param request QueryYydToatlMsgMonthStatisticalDataRequest
         * @return QueryYydToatlMsgMonthStatisticalDataResponse
         */
        public async Task<QueryYydToatlMsgMonthStatisticalDataResponse> QueryYydToatlMsgMonthStatisticalDataAsync(QueryYydToatlMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydToatlMsgMonthStatisticalDataHeaders headers = new QueryYydToatlMsgMonthStatisticalDataHeaders();
            return await QueryYydToatlMsgMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋消息概览（按周统计）指标接口
         *
         * @param request QueryYydToatlMsgWeekStatisticalDataRequest
         * @param headers QueryYydToatlMsgWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydToatlMsgWeekStatisticalDataResponse
         */
        public QueryYydToatlMsgWeekStatisticalDataResponse QueryYydToatlMsgWeekStatisticalDataWithOptions(QueryYydToatlMsgWeekStatisticalDataRequest request, QueryYydToatlMsgWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydToatlMsgWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydToatlMsgWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydToatlMsgWeekStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋消息概览（按周统计）指标接口
         *
         * @param request QueryYydToatlMsgWeekStatisticalDataRequest
         * @param headers QueryYydToatlMsgWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydToatlMsgWeekStatisticalDataResponse
         */
        public async Task<QueryYydToatlMsgWeekStatisticalDataResponse> QueryYydToatlMsgWeekStatisticalDataWithOptionsAsync(QueryYydToatlMsgWeekStatisticalDataRequest request, QueryYydToatlMsgWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydToatlMsgWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydToatlMsgWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydToatlMsgWeekStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋消息概览（按周统计）指标接口
         *
         * @param request QueryYydToatlMsgWeekStatisticalDataRequest
         * @return QueryYydToatlMsgWeekStatisticalDataResponse
         */
        public QueryYydToatlMsgWeekStatisticalDataResponse QueryYydToatlMsgWeekStatisticalData(QueryYydToatlMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydToatlMsgWeekStatisticalDataHeaders headers = new QueryYydToatlMsgWeekStatisticalDataHeaders();
            return QueryYydToatlMsgWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋消息概览（按周统计）指标接口
         *
         * @param request QueryYydToatlMsgWeekStatisticalDataRequest
         * @return QueryYydToatlMsgWeekStatisticalDataResponse
         */
        public async Task<QueryYydToatlMsgWeekStatisticalDataResponse> QueryYydToatlMsgWeekStatisticalDataAsync(QueryYydToatlMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydToatlMsgWeekStatisticalDataHeaders headers = new QueryYydToatlMsgWeekStatisticalDataHeaders();
            return await QueryYydToatlMsgWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋待办分析（按日统计）指标接口
         *
         * @param request QueryYydTodoDayStatisticalDataRequest
         * @param headers QueryYydTodoDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydTodoDayStatisticalDataResponse
         */
        public QueryYydTodoDayStatisticalDataResponse QueryYydTodoDayStatisticalDataWithOptions(QueryYydTodoDayStatisticalDataRequest request, QueryYydTodoDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydTodoDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydTodoDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydTodoDayStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋待办分析（按日统计）指标接口
         *
         * @param request QueryYydTodoDayStatisticalDataRequest
         * @param headers QueryYydTodoDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydTodoDayStatisticalDataResponse
         */
        public async Task<QueryYydTodoDayStatisticalDataResponse> QueryYydTodoDayStatisticalDataWithOptionsAsync(QueryYydTodoDayStatisticalDataRequest request, QueryYydTodoDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydTodoDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydTodoDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydTodoDayStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋待办分析（按日统计）指标接口
         *
         * @param request QueryYydTodoDayStatisticalDataRequest
         * @return QueryYydTodoDayStatisticalDataResponse
         */
        public QueryYydTodoDayStatisticalDataResponse QueryYydTodoDayStatisticalData(QueryYydTodoDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTodoDayStatisticalDataHeaders headers = new QueryYydTodoDayStatisticalDataHeaders();
            return QueryYydTodoDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋待办分析（按日统计）指标接口
         *
         * @param request QueryYydTodoDayStatisticalDataRequest
         * @return QueryYydTodoDayStatisticalDataResponse
         */
        public async Task<QueryYydTodoDayStatisticalDataResponse> QueryYydTodoDayStatisticalDataAsync(QueryYydTodoDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTodoDayStatisticalDataHeaders headers = new QueryYydTodoDayStatisticalDataHeaders();
            return await QueryYydTodoDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋待办分析（按月统计）指标接口
         *
         * @param request QueryYydTodoMonthStatisticalDataRequest
         * @param headers QueryYydTodoMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydTodoMonthStatisticalDataResponse
         */
        public QueryYydTodoMonthStatisticalDataResponse QueryYydTodoMonthStatisticalDataWithOptions(QueryYydTodoMonthStatisticalDataRequest request, QueryYydTodoMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydTodoMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydTodoMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydTodoMonthStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋待办分析（按月统计）指标接口
         *
         * @param request QueryYydTodoMonthStatisticalDataRequest
         * @param headers QueryYydTodoMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydTodoMonthStatisticalDataResponse
         */
        public async Task<QueryYydTodoMonthStatisticalDataResponse> QueryYydTodoMonthStatisticalDataWithOptionsAsync(QueryYydTodoMonthStatisticalDataRequest request, QueryYydTodoMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydTodoMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydTodoMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydTodoMonthStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋待办分析（按月统计）指标接口
         *
         * @param request QueryYydTodoMonthStatisticalDataRequest
         * @return QueryYydTodoMonthStatisticalDataResponse
         */
        public QueryYydTodoMonthStatisticalDataResponse QueryYydTodoMonthStatisticalData(QueryYydTodoMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTodoMonthStatisticalDataHeaders headers = new QueryYydTodoMonthStatisticalDataHeaders();
            return QueryYydTodoMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋待办分析（按月统计）指标接口
         *
         * @param request QueryYydTodoMonthStatisticalDataRequest
         * @return QueryYydTodoMonthStatisticalDataResponse
         */
        public async Task<QueryYydTodoMonthStatisticalDataResponse> QueryYydTodoMonthStatisticalDataAsync(QueryYydTodoMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTodoMonthStatisticalDataHeaders headers = new QueryYydTodoMonthStatisticalDataHeaders();
            return await QueryYydTodoMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋待办分析（按周统计）指标接口
         *
         * @param request QueryYydTodoWeekStatisticalDataRequest
         * @param headers QueryYydTodoWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydTodoWeekStatisticalDataResponse
         */
        public QueryYydTodoWeekStatisticalDataResponse QueryYydTodoWeekStatisticalDataWithOptions(QueryYydTodoWeekStatisticalDataRequest request, QueryYydTodoWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydTodoWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydTodoWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydTodoWeekStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋待办分析（按周统计）指标接口
         *
         * @param request QueryYydTodoWeekStatisticalDataRequest
         * @param headers QueryYydTodoWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydTodoWeekStatisticalDataResponse
         */
        public async Task<QueryYydTodoWeekStatisticalDataResponse> QueryYydTodoWeekStatisticalDataWithOptionsAsync(QueryYydTodoWeekStatisticalDataRequest request, QueryYydTodoWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydTodoWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydTodoWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydTodoWeekStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉数字参谋待办分析（按周统计）指标接口
         *
         * @param request QueryYydTodoWeekStatisticalDataRequest
         * @return QueryYydTodoWeekStatisticalDataResponse
         */
        public QueryYydTodoWeekStatisticalDataResponse QueryYydTodoWeekStatisticalData(QueryYydTodoWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTodoWeekStatisticalDataHeaders headers = new QueryYydTodoWeekStatisticalDataHeaders();
            return QueryYydTodoWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉数字参谋待办分析（按周统计）指标接口
         *
         * @param request QueryYydTodoWeekStatisticalDataRequest
         * @return QueryYydTodoWeekStatisticalDataResponse
         */
        public async Task<QueryYydTodoWeekStatisticalDataResponse> QueryYydTodoWeekStatisticalDataAsync(QueryYydTodoWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTodoWeekStatisticalDataHeaders headers = new QueryYydTodoWeekStatisticalDataHeaders();
            return await QueryYydTodoWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉参谋全局概览（按日统计）指标接口
         *
         * @param request QueryYydTotalDayStatisticalDataRequest
         * @param headers QueryYydTotalDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydTotalDayStatisticalDataResponse
         */
        public QueryYydTotalDayStatisticalDataResponse QueryYydTotalDayStatisticalDataWithOptions(QueryYydTotalDayStatisticalDataRequest request, QueryYydTotalDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydTotalDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydTotalDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydTotalDayStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉参谋全局概览（按日统计）指标接口
         *
         * @param request QueryYydTotalDayStatisticalDataRequest
         * @param headers QueryYydTotalDayStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydTotalDayStatisticalDataResponse
         */
        public async Task<QueryYydTotalDayStatisticalDataResponse> QueryYydTotalDayStatisticalDataWithOptionsAsync(QueryYydTotalDayStatisticalDataRequest request, QueryYydTotalDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydTotalDayStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydTotalDayDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydTotalDayStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉参谋全局概览（按日统计）指标接口
         *
         * @param request QueryYydTotalDayStatisticalDataRequest
         * @return QueryYydTotalDayStatisticalDataResponse
         */
        public QueryYydTotalDayStatisticalDataResponse QueryYydTotalDayStatisticalData(QueryYydTotalDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalDayStatisticalDataHeaders headers = new QueryYydTotalDayStatisticalDataHeaders();
            return QueryYydTotalDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉参谋全局概览（按日统计）指标接口
         *
         * @param request QueryYydTotalDayStatisticalDataRequest
         * @return QueryYydTotalDayStatisticalDataResponse
         */
        public async Task<QueryYydTotalDayStatisticalDataResponse> QueryYydTotalDayStatisticalDataAsync(QueryYydTotalDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalDayStatisticalDataHeaders headers = new QueryYydTotalDayStatisticalDataHeaders();
            return await QueryYydTotalDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉参谋全局概览（按月统计）指标接口
         *
         * @param request QueryYydTotalMonthStatisticalDataRequest
         * @param headers QueryYydTotalMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydTotalMonthStatisticalDataResponse
         */
        public QueryYydTotalMonthStatisticalDataResponse QueryYydTotalMonthStatisticalDataWithOptions(QueryYydTotalMonthStatisticalDataRequest request, QueryYydTotalMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydTotalMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydTotalMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydTotalMonthStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉参谋全局概览（按月统计）指标接口
         *
         * @param request QueryYydTotalMonthStatisticalDataRequest
         * @param headers QueryYydTotalMonthStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydTotalMonthStatisticalDataResponse
         */
        public async Task<QueryYydTotalMonthStatisticalDataResponse> QueryYydTotalMonthStatisticalDataWithOptionsAsync(QueryYydTotalMonthStatisticalDataRequest request, QueryYydTotalMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydTotalMonthStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydTotalMonthDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydTotalMonthStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉参谋全局概览（按月统计）指标接口
         *
         * @param request QueryYydTotalMonthStatisticalDataRequest
         * @return QueryYydTotalMonthStatisticalDataResponse
         */
        public QueryYydTotalMonthStatisticalDataResponse QueryYydTotalMonthStatisticalData(QueryYydTotalMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalMonthStatisticalDataHeaders headers = new QueryYydTotalMonthStatisticalDataHeaders();
            return QueryYydTotalMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉参谋全局概览（按月统计）指标接口
         *
         * @param request QueryYydTotalMonthStatisticalDataRequest
         * @return QueryYydTotalMonthStatisticalDataResponse
         */
        public async Task<QueryYydTotalMonthStatisticalDataResponse> QueryYydTotalMonthStatisticalDataAsync(QueryYydTotalMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalMonthStatisticalDataHeaders headers = new QueryYydTotalMonthStatisticalDataHeaders();
            return await QueryYydTotalMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉参谋全局概览（累计）指标接口
         *
         * @param request QueryYydTotalStdStatisticalDataRequest
         * @param headers QueryYydTotalStdStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydTotalStdStatisticalDataResponse
         */
        public QueryYydTotalStdStatisticalDataResponse QueryYydTotalStdStatisticalDataWithOptions(QueryYydTotalStdStatisticalDataRequest request, QueryYydTotalStdStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydTotalStdStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydTotalStdDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydTotalStdStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉参谋全局概览（累计）指标接口
         *
         * @param request QueryYydTotalStdStatisticalDataRequest
         * @param headers QueryYydTotalStdStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydTotalStdStatisticalDataResponse
         */
        public async Task<QueryYydTotalStdStatisticalDataResponse> QueryYydTotalStdStatisticalDataWithOptionsAsync(QueryYydTotalStdStatisticalDataRequest request, QueryYydTotalStdStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydTotalStdStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydTotalStdDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydTotalStdStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉参谋全局概览（累计）指标接口
         *
         * @param request QueryYydTotalStdStatisticalDataRequest
         * @return QueryYydTotalStdStatisticalDataResponse
         */
        public QueryYydTotalStdStatisticalDataResponse QueryYydTotalStdStatisticalData(QueryYydTotalStdStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalStdStatisticalDataHeaders headers = new QueryYydTotalStdStatisticalDataHeaders();
            return QueryYydTotalStdStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉参谋全局概览（累计）指标接口
         *
         * @param request QueryYydTotalStdStatisticalDataRequest
         * @return QueryYydTotalStdStatisticalDataResponse
         */
        public async Task<QueryYydTotalStdStatisticalDataResponse> QueryYydTotalStdStatisticalDataAsync(QueryYydTotalStdStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalStdStatisticalDataHeaders headers = new QueryYydTotalStdStatisticalDataHeaders();
            return await QueryYydTotalStdStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 亚运钉参谋全局概览（按周统计）指标接口
         *
         * @param request QueryYydTotalWeekStatisticalDataRequest
         * @param headers QueryYydTotalWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydTotalWeekStatisticalDataResponse
         */
        public QueryYydTotalWeekStatisticalDataResponse QueryYydTotalWeekStatisticalDataWithOptions(QueryYydTotalWeekStatisticalDataRequest request, QueryYydTotalWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydTotalWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydTotalWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydTotalWeekStatisticalDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 亚运钉参谋全局概览（按周统计）指标接口
         *
         * @param request QueryYydTotalWeekStatisticalDataRequest
         * @param headers QueryYydTotalWeekStatisticalDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryYydTotalWeekStatisticalDataResponse
         */
        public async Task<QueryYydTotalWeekStatisticalDataResponse> QueryYydTotalWeekStatisticalDataWithOptionsAsync(QueryYydTotalWeekStatisticalDataRequest request, QueryYydTotalWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryYydTotalWeekStatisticalData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/yydTotalWeekDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryYydTotalWeekStatisticalDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 亚运钉参谋全局概览（按周统计）指标接口
         *
         * @param request QueryYydTotalWeekStatisticalDataRequest
         * @return QueryYydTotalWeekStatisticalDataResponse
         */
        public QueryYydTotalWeekStatisticalDataResponse QueryYydTotalWeekStatisticalData(QueryYydTotalWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalWeekStatisticalDataHeaders headers = new QueryYydTotalWeekStatisticalDataHeaders();
            return QueryYydTotalWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 亚运钉参谋全局概览（按周统计）指标接口
         *
         * @param request QueryYydTotalWeekStatisticalDataRequest
         * @return QueryYydTotalWeekStatisticalDataResponse
         */
        public async Task<QueryYydTotalWeekStatisticalDataResponse> QueryYydTotalWeekStatisticalDataAsync(QueryYydTotalWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalWeekStatisticalDataHeaders headers = new QueryYydTotalWeekStatisticalDataHeaders();
            return await QueryYydTotalWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 通过关键词搜索企业
         *
         * @param request SearchCompanyRequest
         * @param headers SearchCompanyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchCompanyResponse
         */
        public SearchCompanyResponse SearchCompanyWithOptions(SearchCompanyRequest request, SearchCompanyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "SearchCompany",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/keywords/companies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchCompanyResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 通过关键词搜索企业
         *
         * @param request SearchCompanyRequest
         * @param headers SearchCompanyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchCompanyResponse
         */
        public async Task<SearchCompanyResponse> SearchCompanyWithOptionsAsync(SearchCompanyRequest request, SearchCompanyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["searchKey"] = request.SearchKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
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
                Action = "SearchCompany",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/keywords/companies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchCompanyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 通过关键词搜索企业
         *
         * @param request SearchCompanyRequest
         * @return SearchCompanyResponse
         */
        public SearchCompanyResponse SearchCompany(SearchCompanyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchCompanyHeaders headers = new SearchCompanyHeaders();
            return SearchCompanyWithOptions(request, headers, runtime);
        }

        /**
         * @summary 通过关键词搜索企业
         *
         * @param request SearchCompanyRequest
         * @return SearchCompanyResponse
         */
        public async Task<SearchCompanyResponse> SearchCompanyAsync(SearchCompanyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchCompanyHeaders headers = new SearchCompanyHeaders();
            return await SearchCompanyWithOptionsAsync(request, headers, runtime);
        }

    }
}
