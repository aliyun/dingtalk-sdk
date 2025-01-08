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


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭数据投递任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseDataDeliverRequest
        /// </param>
        /// <param name="headers">
        /// CloseDataDeliverHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseDataDeliverResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭数据投递任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseDataDeliverRequest
        /// </param>
        /// <param name="headers">
        /// CloseDataDeliverHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseDataDeliverResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭数据投递任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseDataDeliverRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseDataDeliverResponse
        /// </returns>
        public CloseDataDeliverResponse CloseDataDeliver(CloseDataDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseDataDeliverHeaders headers = new CloseDataDeliverHeaders();
            return CloseDataDeliverWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭数据投递任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseDataDeliverRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseDataDeliverResponse
        /// </returns>
        public async Task<CloseDataDeliverResponse> CloseDataDeliverAsync(CloseDataDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseDataDeliverHeaders headers = new CloseDataDeliverHeaders();
            return await CloseDataDeliverWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataDeliverRequest
        /// </param>
        /// <param name="headers">
        /// CreateDataDeliverHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataDeliverResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataDeliverRequest
        /// </param>
        /// <param name="headers">
        /// CreateDataDeliverHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataDeliverResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataDeliverRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataDeliverResponse
        /// </returns>
        public CreateDataDeliverResponse CreateDataDeliver(CreateDataDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDataDeliverHeaders headers = new CreateDataDeliverHeaders();
            return CreateDataDeliverWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataDeliverRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataDeliverResponse
        /// </returns>
        public async Task<CreateDataDeliverResponse> CreateDataDeliverAsync(CreateDataDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDataDeliverHeaders headers = new CreateDataDeliverHeaders();
            return await CreateDataDeliverWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增数据大屏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScreenRequest
        /// </param>
        /// <param name="headers">
        /// CreateScreenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScreenResponse
        /// </returns>
        public CreateScreenResponse CreateScreenWithOptions(CreateScreenRequest request, CreateScreenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScreen",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/screens",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScreenResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增数据大屏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScreenRequest
        /// </param>
        /// <param name="headers">
        /// CreateScreenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScreenResponse
        /// </returns>
        public async Task<CreateScreenResponse> CreateScreenWithOptionsAsync(CreateScreenRequest request, CreateScreenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScreen",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/screens",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScreenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增数据大屏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScreenRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScreenResponse
        /// </returns>
        public CreateScreenResponse CreateScreen(CreateScreenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateScreenHeaders headers = new CreateScreenHeaders();
            return CreateScreenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增数据大屏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScreenRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScreenResponse
        /// </returns>
        public async Task<CreateScreenResponse> CreateScreenAsync(CreateScreenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateScreenHeaders headers = new CreateScreenHeaders();
            return await CreateScreenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据流通中心获取数据服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DataMarketServiceRequest
        /// </param>
        /// <param name="headers">
        /// DataMarketServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DataMarketServiceResponse
        /// </returns>
        public DataMarketServiceResponse DataMarketServiceWithOptions(DataMarketServiceRequest request, DataMarketServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiId))
            {
                body["apiId"] = request.ApiId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Args))
            {
                body["args"] = request.Args;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DataMarketService",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dataMarketServices/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DataMarketServiceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据流通中心获取数据服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DataMarketServiceRequest
        /// </param>
        /// <param name="headers">
        /// DataMarketServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DataMarketServiceResponse
        /// </returns>
        public async Task<DataMarketServiceResponse> DataMarketServiceWithOptionsAsync(DataMarketServiceRequest request, DataMarketServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiId))
            {
                body["apiId"] = request.ApiId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Args))
            {
                body["args"] = request.Args;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DataMarketService",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dataMarketServices/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DataMarketServiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据流通中心获取数据服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DataMarketServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DataMarketServiceResponse
        /// </returns>
        public DataMarketServiceResponse DataMarketService(DataMarketServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DataMarketServiceHeaders headers = new DataMarketServiceHeaders();
            return DataMarketServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据流通中心获取数据服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DataMarketServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DataMarketServiceResponse
        /// </returns>
        public async Task<DataMarketServiceResponse> DataMarketServiceAsync(DataMarketServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DataMarketServiceHeaders headers = new DataMarketServiceHeaders();
            return await DataMarketServiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工商-经营异常</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAbnormalOperationRequest
        /// </param>
        /// <param name="headers">
        /// GetAbnormalOperationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAbnormalOperationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工商-经营异常</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAbnormalOperationRequest
        /// </param>
        /// <param name="headers">
        /// GetAbnormalOperationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAbnormalOperationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工商-经营异常</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAbnormalOperationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAbnormalOperationResponse
        /// </returns>
        public GetAbnormalOperationResponse GetAbnormalOperation(GetAbnormalOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAbnormalOperationHeaders headers = new GetAbnormalOperationHeaders();
            return GetAbnormalOperationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工商-经营异常</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAbnormalOperationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAbnormalOperationResponse
        /// </returns>
        public async Task<GetAbnormalOperationResponse> GetAbnormalOperationAsync(GetAbnormalOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAbnormalOperationHeaders headers = new GetAbnormalOperationHeaders();
            return await GetAbnormalOperationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-行政许可</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdministrativeLicensingRequest
        /// </param>
        /// <param name="headers">
        /// GetAdministrativeLicensingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAdministrativeLicensingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-行政许可</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdministrativeLicensingRequest
        /// </param>
        /// <param name="headers">
        /// GetAdministrativeLicensingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAdministrativeLicensingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-行政许可</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdministrativeLicensingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAdministrativeLicensingResponse
        /// </returns>
        public GetAdministrativeLicensingResponse GetAdministrativeLicensing(GetAdministrativeLicensingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAdministrativeLicensingHeaders headers = new GetAdministrativeLicensingHeaders();
            return GetAdministrativeLicensingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-行政许可</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdministrativeLicensingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAdministrativeLicensingResponse
        /// </returns>
        public async Task<GetAdministrativeLicensingResponse> GetAdministrativeLicensingAsync(GetAdministrativeLicensingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAdministrativeLicensingHeaders headers = new GetAdministrativeLicensingHeaders();
            return await GetAdministrativeLicensingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>负面-行政处罚</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdministrativePenaltiesRequest
        /// </param>
        /// <param name="headers">
        /// GetAdministrativePenaltiesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAdministrativePenaltiesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>负面-行政处罚</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdministrativePenaltiesRequest
        /// </param>
        /// <param name="headers">
        /// GetAdministrativePenaltiesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAdministrativePenaltiesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>负面-行政处罚</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdministrativePenaltiesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAdministrativePenaltiesResponse
        /// </returns>
        public GetAdministrativePenaltiesResponse GetAdministrativePenalties(GetAdministrativePenaltiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAdministrativePenaltiesHeaders headers = new GetAdministrativePenaltiesHeaders();
            return GetAdministrativePenaltiesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>负面-行政处罚</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdministrativePenaltiesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAdministrativePenaltiesResponse
        /// </returns>
        public async Task<GetAdministrativePenaltiesResponse> GetAdministrativePenaltiesAsync(GetAdministrativePenaltiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAdministrativePenaltiesHeaders headers = new GetAdministrativePenaltiesHeaders();
            return await GetAdministrativePenaltiesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工商-基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBasicInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetBasicInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBasicInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工商-基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBasicInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetBasicInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBasicInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工商-基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBasicInfoResponse
        /// </returns>
        public GetBasicInfoResponse GetBasicInfo(GetBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBasicInfoHeaders headers = new GetBasicInfoHeaders();
            return GetBasicInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工商-基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBasicInfoResponse
        /// </returns>
        public async Task<GetBasicInfoResponse> GetBasicInfoAsync(GetBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBasicInfoHeaders headers = new GetBasicInfoHeaders();
            return await GetBasicInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取经营-招投标信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBiddingInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetBiddingInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBiddingInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取经营-招投标信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBiddingInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetBiddingInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBiddingInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取经营-招投标信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBiddingInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBiddingInfoResponse
        /// </returns>
        public GetBiddingInfoResponse GetBiddingInfo(GetBiddingInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBiddingInfoHeaders headers = new GetBiddingInfoHeaders();
            return GetBiddingInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取经营-招投标信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBiddingInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBiddingInfoResponse
        /// </returns>
        public async Task<GetBiddingInfoResponse> GetBiddingInfoAsync(GetBiddingInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBiddingInfoHeaders headers = new GetBiddingInfoHeaders();
            return await GetBiddingInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-分支机构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBranchInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetBranchInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBranchInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-分支机构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBranchInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetBranchInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBranchInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-分支机构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBranchInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBranchInfoResponse
        /// </returns>
        public GetBranchInfoResponse GetBranchInfo(GetBranchInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBranchInfoHeaders headers = new GetBranchInfoHeaders();
            return GetBranchInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-分支机构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBranchInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBranchInfoResponse
        /// </returns>
        public async Task<GetBranchInfoResponse> GetBranchInfoAsync(GetBranchInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBranchInfoHeaders headers = new GetBranchInfoHeaders();
            return await GetBranchInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-变更记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChangeRecordRequest
        /// </param>
        /// <param name="headers">
        /// GetChangeRecordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChangeRecordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-变更记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChangeRecordRequest
        /// </param>
        /// <param name="headers">
        /// GetChangeRecordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChangeRecordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-变更记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChangeRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChangeRecordResponse
        /// </returns>
        public GetChangeRecordResponse GetChangeRecord(GetChangeRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetChangeRecordHeaders headers = new GetChangeRecordHeaders();
            return GetChangeRecordWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-变更记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChangeRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChangeRecordResponse
        /// </returns>
        public async Task<GetChangeRecordResponse> GetChangeRecordAsync(GetChangeRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetChangeRecordHeaders headers = new GetChangeRecordHeaders();
            return await GetChangeRecordWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取投递任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataDeliverRequest
        /// </param>
        /// <param name="headers">
        /// GetDataDeliverHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataDeliverResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取投递任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataDeliverRequest
        /// </param>
        /// <param name="headers">
        /// GetDataDeliverHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataDeliverResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取投递任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataDeliverRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataDeliverResponse
        /// </returns>
        public GetDataDeliverResponse GetDataDeliver(GetDataDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDataDeliverHeaders headers = new GetDataDeliverHeaders();
            return GetDataDeliverWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取投递任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataDeliverRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataDeliverResponse
        /// </returns>
        public async Task<GetDataDeliverResponse> GetDataDeliverAsync(GetDataDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDataDeliverHeaders headers = new GetDataDeliverHeaders();
            return await GetDataDeliverWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-域名信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDomainInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetDomainInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDomainInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-域名信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDomainInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetDomainInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDomainInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-域名信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDomainInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDomainInfoResponse
        /// </returns>
        public GetDomainInfoResponse GetDomainInfo(GetDomainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDomainInfoHeaders headers = new GetDomainInfoHeaders();
            return GetDomainInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-域名信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDomainInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDomainInfoResponse
        /// </returns>
        public async Task<GetDomainInfoResponse> GetDomainInfoAsync(GetDomainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDomainInfoHeaders headers = new GetDomainInfoHeaders();
            return await GetDomainInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-双随机抽查结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDoubleRandomRequest
        /// </param>
        /// <param name="headers">
        /// GetDoubleRandomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDoubleRandomResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-双随机抽查结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDoubleRandomRequest
        /// </param>
        /// <param name="headers">
        /// GetDoubleRandomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDoubleRandomResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-双随机抽查结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDoubleRandomRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDoubleRandomResponse
        /// </returns>
        public GetDoubleRandomResponse GetDoubleRandom(GetDoubleRandomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDoubleRandomHeaders headers = new GetDoubleRandomHeaders();
            return GetDoubleRandomWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-双随机抽查结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDoubleRandomRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDoubleRandomResponse
        /// </returns>
        public async Task<GetDoubleRandomResponse> GetDoubleRandomAsync(GetDoubleRandomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDoubleRandomHeaders headers = new GetDoubleRandomHeaders();
            return await GetDoubleRandomWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>负面-环保处罚</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEnvironmentalPenaltiesRequest
        /// </param>
        /// <param name="headers">
        /// GetEnvironmentalPenaltiesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEnvironmentalPenaltiesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>负面-环保处罚</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEnvironmentalPenaltiesRequest
        /// </param>
        /// <param name="headers">
        /// GetEnvironmentalPenaltiesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEnvironmentalPenaltiesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>负面-环保处罚</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEnvironmentalPenaltiesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEnvironmentalPenaltiesResponse
        /// </returns>
        public GetEnvironmentalPenaltiesResponse GetEnvironmentalPenalties(GetEnvironmentalPenaltiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEnvironmentalPenaltiesHeaders headers = new GetEnvironmentalPenaltiesHeaders();
            return GetEnvironmentalPenaltiesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>负面-环保处罚</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEnvironmentalPenaltiesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEnvironmentalPenaltiesResponse
        /// </returns>
        public async Task<GetEnvironmentalPenaltiesResponse> GetEnvironmentalPenaltiesAsync(GetEnvironmentalPenaltiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEnvironmentalPenaltiesHeaders headers = new GetEnvironmentalPenaltiesHeaders();
            return await GetEnvironmentalPenaltiesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取事件订阅的数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEventDataRequest
        /// </param>
        /// <param name="headers">
        /// GetEventDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEventDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取事件订阅的数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEventDataRequest
        /// </param>
        /// <param name="headers">
        /// GetEventDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEventDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取事件订阅的数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEventDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEventDataResponse
        /// </returns>
        public GetEventDataResponse GetEventData(GetEventDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEventDataHeaders headers = new GetEventDataHeaders();
            return GetEventDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取事件订阅的数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEventDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEventDataResponse
        /// </returns>
        public async Task<GetEventDataResponse> GetEventDataAsync(GetEventDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEventDataHeaders headers = new GetEventDataHeaders();
            return await GetEventDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工商-股东信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHolderInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetHolderInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHolderInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工商-股东信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHolderInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetHolderInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHolderInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工商-股东信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHolderInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHolderInfoResponse
        /// </returns>
        public GetHolderInfoResponse GetHolderInfo(GetHolderInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHolderInfoHeaders headers = new GetHolderInfoHeaders();
            return GetHolderInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工商-股东信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHolderInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHolderInfoResponse
        /// </returns>
        public async Task<GetHolderInfoResponse> GetHolderInfoAsync(GetHolderInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHolderInfoHeaders headers = new GetHolderInfoHeaders();
            return await GetHolderInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-知识产权出质</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIntellectualPropertyRequest
        /// </param>
        /// <param name="headers">
        /// GetIntellectualPropertyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIntellectualPropertyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-知识产权出质</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIntellectualPropertyRequest
        /// </param>
        /// <param name="headers">
        /// GetIntellectualPropertyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIntellectualPropertyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-知识产权出质</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIntellectualPropertyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIntellectualPropertyResponse
        /// </returns>
        public GetIntellectualPropertyResponse GetIntellectualProperty(GetIntellectualPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIntellectualPropertyHeaders headers = new GetIntellectualPropertyHeaders();
            return GetIntellectualPropertyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-知识产权出质</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIntellectualPropertyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIntellectualPropertyResponse
        /// </returns>
        public async Task<GetIntellectualPropertyResponse> GetIntellectualPropertyAsync(GetIntellectualPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIntellectualPropertyHeaders headers = new GetIntellectualPropertyHeaders();
            return await GetIntellectualPropertyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-对外投资</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInvestmentAbroadRequest
        /// </param>
        /// <param name="headers">
        /// GetInvestmentAbroadHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInvestmentAbroadResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-对外投资</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInvestmentAbroadRequest
        /// </param>
        /// <param name="headers">
        /// GetInvestmentAbroadHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInvestmentAbroadResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-对外投资</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInvestmentAbroadRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInvestmentAbroadResponse
        /// </returns>
        public GetInvestmentAbroadResponse GetInvestmentAbroad(GetInvestmentAbroadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInvestmentAbroadHeaders headers = new GetInvestmentAbroadHeaders();
            return GetInvestmentAbroadWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-对外投资</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInvestmentAbroadRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInvestmentAbroadResponse
        /// </returns>
        public async Task<GetInvestmentAbroadResponse> GetInvestmentAbroadAsync(GetInvestmentAbroadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInvestmentAbroadHeaders headers = new GetInvestmentAbroadHeaders();
            return await GetInvestmentAbroadWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取经营-招聘信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetJobInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取经营-招聘信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetJobInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取经营-招聘信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobInfoResponse
        /// </returns>
        public GetJobInfoResponse GetJobInfo(GetJobInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobInfoHeaders headers = new GetJobInfoHeaders();
            return GetJobInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取经营-招聘信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobInfoResponse
        /// </returns>
        public async Task<GetJobInfoResponse> GetJobInfoAsync(GetJobInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobInfoHeaders headers = new GetJobInfoHeaders();
            return await GetJobInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-专利信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPatentInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetPatentInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPatentInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-专利信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPatentInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetPatentInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPatentInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-专利信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPatentInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPatentInfoResponse
        /// </returns>
        public GetPatentInfoResponse GetPatentInfo(GetPatentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPatentInfoHeaders headers = new GetPatentInfoHeaders();
            return GetPatentInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-专利信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPatentInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPatentInfoResponse
        /// </returns>
        public async Task<GetPatentInfoResponse> GetPatentInfoAsync(GetPatentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPatentInfoHeaders headers = new GetPatentInfoHeaders();
            return await GetPatentInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-主要人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrincipalEmployeeRequest
        /// </param>
        /// <param name="headers">
        /// GetPrincipalEmployeeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPrincipalEmployeeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-主要人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrincipalEmployeeRequest
        /// </param>
        /// <param name="headers">
        /// GetPrincipalEmployeeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPrincipalEmployeeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-主要人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrincipalEmployeeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPrincipalEmployeeResponse
        /// </returns>
        public GetPrincipalEmployeeResponse GetPrincipalEmployee(GetPrincipalEmployeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPrincipalEmployeeHeaders headers = new GetPrincipalEmployeeHeaders();
            return GetPrincipalEmployeeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工商-主要人员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrincipalEmployeeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPrincipalEmployeeResponse
        /// </returns>
        public async Task<GetPrincipalEmployeeResponse> GetPrincipalEmployeeAsync(GetPrincipalEmployeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPrincipalEmployeeHeaders headers = new GetPrincipalEmployeeHeaders();
            return await GetPrincipalEmployeeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>经营-一般纳税人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQeneralTaxpayerInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetQeneralTaxpayerInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQeneralTaxpayerInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>经营-一般纳税人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQeneralTaxpayerInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetQeneralTaxpayerInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQeneralTaxpayerInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>经营-一般纳税人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQeneralTaxpayerInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQeneralTaxpayerInfoResponse
        /// </returns>
        public GetQeneralTaxpayerInfoResponse GetQeneralTaxpayerInfo(GetQeneralTaxpayerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetQeneralTaxpayerInfoHeaders headers = new GetQeneralTaxpayerInfoHeaders();
            return GetQeneralTaxpayerInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>经营-一般纳税人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQeneralTaxpayerInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQeneralTaxpayerInfoResponse
        /// </returns>
        public async Task<GetQeneralTaxpayerInfoResponse> GetQeneralTaxpayerInfoAsync(GetQeneralTaxpayerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetQeneralTaxpayerInfoHeaders headers = new GetQeneralTaxpayerInfoHeaders();
            return await GetQeneralTaxpayerInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-资质证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQualificationCertRequest
        /// </param>
        /// <param name="headers">
        /// GetQualificationCertHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualificationCertResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-资质证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQualificationCertRequest
        /// </param>
        /// <param name="headers">
        /// GetQualificationCertHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualificationCertResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-资质证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQualificationCertRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualificationCertResponse
        /// </returns>
        public GetQualificationCertResponse GetQualificationCert(GetQualificationCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetQualificationCertHeaders headers = new GetQualificationCertHeaders();
            return GetQualificationCertWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-资质证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQualificationCertRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualificationCertResponse
        /// </returns>
        public async Task<GetQualificationCertResponse> GetQualificationCertAsync(GetQualificationCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetQualificationCertHeaders headers = new GetQualificationCertHeaders();
            return await GetQualificationCertWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>负面-严重违法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSeriousViolationRequest
        /// </param>
        /// <param name="headers">
        /// GetSeriousViolationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSeriousViolationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>负面-严重违法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSeriousViolationRequest
        /// </param>
        /// <param name="headers">
        /// GetSeriousViolationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSeriousViolationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>负面-严重违法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSeriousViolationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSeriousViolationResponse
        /// </returns>
        public GetSeriousViolationResponse GetSeriousViolation(GetSeriousViolationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSeriousViolationHeaders headers = new GetSeriousViolationHeaders();
            return GetSeriousViolationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>负面-严重违法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSeriousViolationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSeriousViolationResponse
        /// </returns>
        public async Task<GetSeriousViolationResponse> GetSeriousViolationAsync(GetSeriousViolationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSeriousViolationHeaders headers = new GetSeriousViolationHeaders();
            return await GetSeriousViolationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-软件著作权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSoftwareCopyrightRequest
        /// </param>
        /// <param name="headers">
        /// GetSoftwareCopyrightHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSoftwareCopyrightResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-软件著作权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSoftwareCopyrightRequest
        /// </param>
        /// <param name="headers">
        /// GetSoftwareCopyrightHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSoftwareCopyrightResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-软件著作权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSoftwareCopyrightRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSoftwareCopyrightResponse
        /// </returns>
        public GetSoftwareCopyrightResponse GetSoftwareCopyright(GetSoftwareCopyrightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSoftwareCopyrightHeaders headers = new GetSoftwareCopyrightHeaders();
            return GetSoftwareCopyrightWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-软件著作权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSoftwareCopyrightRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSoftwareCopyrightResponse
        /// </returns>
        public async Task<GetSoftwareCopyrightResponse> GetSoftwareCopyrightAsync(GetSoftwareCopyrightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSoftwareCopyrightHeaders headers = new GetSoftwareCopyrightHeaders();
            return await GetSoftwareCopyrightWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-商标信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrademarkInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetTrademarkInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTrademarkInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-商标信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrademarkInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetTrademarkInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTrademarkInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-商标信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrademarkInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTrademarkInfoResponse
        /// </returns>
        public GetTrademarkInfoResponse GetTrademarkInfo(GetTrademarkInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTrademarkInfoHeaders headers = new GetTrademarkInfoHeaders();
            return GetTrademarkInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-商标信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrademarkInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTrademarkInfoResponse
        /// </returns>
        public async Task<GetTrademarkInfoResponse> GetTrademarkInfoAsync(GetTrademarkInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTrademarkInfoHeaders headers = new GetTrademarkInfoHeaders();
            return await GetTrademarkInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-作品著作权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkCopyrightRequest
        /// </param>
        /// <param name="headers">
        /// GetWorkCopyrightHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkCopyrightResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-作品著作权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkCopyrightRequest
        /// </param>
        /// <param name="headers">
        /// GetWorkCopyrightHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkCopyrightResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-作品著作权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkCopyrightRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkCopyrightResponse
        /// </returns>
        public GetWorkCopyrightResponse GetWorkCopyright(GetWorkCopyrightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkCopyrightHeaders headers = new GetWorkCopyrightHeaders();
            return GetWorkCopyrightWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识产权-作品著作权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkCopyrightRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkCopyrightResponse
        /// </returns>
        public async Task<GetWorkCopyrightResponse> GetWorkCopyrightAsync(GetWorkCopyrightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWorkCopyrightHeaders headers = new GetWorkCopyrightHeaders();
            return await GetWorkCopyrightWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据投递列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataDeliversRequest
        /// </param>
        /// <param name="headers">
        /// ListDataDeliversHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataDeliversResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据投递列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataDeliversRequest
        /// </param>
        /// <param name="headers">
        /// ListDataDeliversHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataDeliversResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据投递列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataDeliversRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataDeliversResponse
        /// </returns>
        public ListDataDeliversResponse ListDataDelivers(ListDataDeliversRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDataDeliversHeaders headers = new ListDataDeliversHeaders();
            return ListDataDeliversWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据投递列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataDeliversRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataDeliversResponse
        /// </returns>
        public async Task<ListDataDeliversResponse> ListDataDeliversAsync(ListDataDeliversRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDataDeliversHeaders headers = new ListDataDeliversHeaders();
            return await ListDataDeliversWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作表格配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateChartConfigRequest
        /// </param>
        /// <param name="headers">
        /// OperateChartConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateChartConfigResponse
        /// </returns>
        public OperateChartConfigResponse OperateChartConfigWithOptions(OperateChartConfigRequest request, OperateChartConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["apiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                body["ticket"] = request.Ticket;
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
                Action = "OperateChartConfig",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/chartConfigs/operate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateChartConfigResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作表格配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateChartConfigRequest
        /// </param>
        /// <param name="headers">
        /// OperateChartConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateChartConfigResponse
        /// </returns>
        public async Task<OperateChartConfigResponse> OperateChartConfigWithOptionsAsync(OperateChartConfigRequest request, OperateChartConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["apiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["param"] = request.Param;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                body["ticket"] = request.Ticket;
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
                Action = "OperateChartConfig",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/chartConfigs/operate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateChartConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作表格配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateChartConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateChartConfigResponse
        /// </returns>
        public OperateChartConfigResponse OperateChartConfig(OperateChartConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OperateChartConfigHeaders headers = new OperateChartConfigHeaders();
            return OperateChartConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作表格配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateChartConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateChartConfigResponse
        /// </returns>
        public async Task<OperateChartConfigResponse> OperateChartConfigAsync(OperateChartConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OperateChartConfigHeaders headers = new OperateChartConfigHeaders();
            return await OperateChartConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业授权信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// PostCorpAuthInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostCorpAuthInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业授权信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// PostCorpAuthInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostCorpAuthInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业授权信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// PostCorpAuthInfoResponse
        /// </returns>
        public PostCorpAuthInfoResponse PostCorpAuthInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PostCorpAuthInfoHeaders headers = new PostCorpAuthInfoHeaders();
            return PostCorpAuthInfoWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业授权信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// PostCorpAuthInfoResponse
        /// </returns>
        public async Task<PostCorpAuthInfoResponse> PostCorpAuthInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PostCorpAuthInfoHeaders headers = new PostCorpAuthInfoHeaders();
            return await PostCorpAuthInfoWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业用户激活状态统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryActiveUserStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryActiveUserStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryActiveUserStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业用户激活状态统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryActiveUserStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryActiveUserStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryActiveUserStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业用户激活状态统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryActiveUserStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryActiveUserStatisticalDataResponse
        /// </returns>
        public QueryActiveUserStatisticalDataResponse QueryActiveUserStatisticalData(QueryActiveUserStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryActiveUserStatisticalDataHeaders headers = new QueryActiveUserStatisticalDataHeaders();
            return QueryActiveUserStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业用户激活状态统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryActiveUserStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryActiveUserStatisticalDataResponse
        /// </returns>
        public async Task<QueryActiveUserStatisticalDataResponse> QueryActiveUserStatisticalDataAsync(QueryActiveUserStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryActiveUserStatisticalDataHeaders headers = new QueryActiveUserStatisticalDataHeaders();
            return await QueryActiveUserStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安恒密盾统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAnhmdStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryAnhmdStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAnhmdStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安恒密盾统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAnhmdStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryAnhmdStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAnhmdStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安恒密盾统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAnhmdStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAnhmdStatisticalDataResponse
        /// </returns>
        public QueryAnhmdStatisticalDataResponse QueryAnhmdStatisticalData(QueryAnhmdStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAnhmdStatisticalDataHeaders headers = new QueryAnhmdStatisticalDataHeaders();
            return QueryAnhmdStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安恒密盾统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAnhmdStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAnhmdStatisticalDataResponse
        /// </returns>
        public async Task<QueryAnhmdStatisticalDataResponse> QueryAnhmdStatisticalDataAsync(QueryAnhmdStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAnhmdStatisticalDataHeaders headers = new QueryAnhmdStatisticalDataHeaders();
            return await QueryAnhmdStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业审批统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryApprovalStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryApprovalStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryApprovalStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业审批统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryApprovalStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryApprovalStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryApprovalStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业审批统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryApprovalStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryApprovalStatisticalDataResponse
        /// </returns>
        public QueryApprovalStatisticalDataResponse QueryApprovalStatisticalData(QueryApprovalStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryApprovalStatisticalDataHeaders headers = new QueryApprovalStatisticalDataHeaders();
            return QueryApprovalStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业审批统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryApprovalStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryApprovalStatisticalDataResponse
        /// </returns>
        public async Task<QueryApprovalStatisticalDataResponse> QueryApprovalStatisticalDataAsync(QueryApprovalStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryApprovalStatisticalDataHeaders headers = new QueryApprovalStatisticalDataHeaders();
            return await QueryApprovalStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业考勤统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAttendanceStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryAttendanceStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAttendanceStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业考勤统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAttendanceStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryAttendanceStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAttendanceStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业考勤统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAttendanceStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAttendanceStatisticalDataResponse
        /// </returns>
        public QueryAttendanceStatisticalDataResponse QueryAttendanceStatisticalData(QueryAttendanceStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAttendanceStatisticalDataHeaders headers = new QueryAttendanceStatisticalDataHeaders();
            return QueryAttendanceStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业考勤统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAttendanceStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAttendanceStatisticalDataResponse
        /// </returns>
        public async Task<QueryAttendanceStatisticalDataResponse> QueryAttendanceStatisticalDataAsync(QueryAttendanceStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAttendanceStatisticalDataHeaders headers = new QueryAttendanceStatisticalDataHeaders();
            return await QueryAttendanceStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业公告统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBlackboardStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryBlackboardStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBlackboardStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业公告统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBlackboardStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryBlackboardStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBlackboardStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业公告统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBlackboardStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBlackboardStatisticalDataResponse
        /// </returns>
        public QueryBlackboardStatisticalDataResponse QueryBlackboardStatisticalData(QueryBlackboardStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBlackboardStatisticalDataHeaders headers = new QueryBlackboardStatisticalDataHeaders();
            return QueryBlackboardStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业公告统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBlackboardStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBlackboardStatisticalDataResponse
        /// </returns>
        public async Task<QueryBlackboardStatisticalDataResponse> QueryBlackboardStatisticalDataAsync(QueryBlackboardStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBlackboardStatisticalDataHeaders headers = new QueryBlackboardStatisticalDataHeaders();
            return await QueryBlackboardStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业日程统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCalendarStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryCalendarStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCalendarStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业日程统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCalendarStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryCalendarStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCalendarStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业日程统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCalendarStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCalendarStatisticalDataResponse
        /// </returns>
        public QueryCalendarStatisticalDataResponse QueryCalendarStatisticalData(QueryCalendarStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCalendarStatisticalDataHeaders headers = new QueryCalendarStatisticalDataHeaders();
            return QueryCalendarStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业日程统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCalendarStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCalendarStatisticalDataResponse
        /// </returns>
        public async Task<QueryCalendarStatisticalDataResponse> QueryCalendarStatisticalDataAsync(QueryCalendarStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCalendarStatisticalDataHeaders headers = new QueryCalendarStatisticalDataHeaders();
            return await QueryCalendarStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取图表数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChartDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryChartDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryChartDataResponse
        /// </returns>
        public QueryChartDataResponse QueryChartDataWithOptions(QueryChartDataRequest request, QueryChartDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                body["ticket"] = request.Ticket;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChartData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/chartDatas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChartDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取图表数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChartDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryChartDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryChartDataResponse
        /// </returns>
        public async Task<QueryChartDataResponse> QueryChartDataWithOptionsAsync(QueryChartDataRequest request, QueryChartDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                body["ticket"] = request.Ticket;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChartData",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/chartDatas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChartDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取图表数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChartDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryChartDataResponse
        /// </returns>
        public QueryChartDataResponse QueryChartData(QueryChartDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryChartDataHeaders headers = new QueryChartDataHeaders();
            return QueryChartDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取图表数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChartDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryChartDataResponse
        /// </returns>
        public async Task<QueryChartDataResponse> QueryChartDataAsync(QueryChartDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryChartDataHeaders headers = new QueryChartDataHeaders();
            return await QueryChartDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业签到统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCheckinStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryCheckinStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCheckinStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业签到统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCheckinStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryCheckinStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCheckinStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业签到统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCheckinStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCheckinStatisticalDataResponse
        /// </returns>
        public QueryCheckinStatisticalDataResponse QueryCheckinStatisticalData(QueryCheckinStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCheckinStatisticalDataHeaders headers = new QueryCheckinStatisticalDataHeaders();
            return QueryCheckinStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业签到统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCheckinStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCheckinStatisticalDataResponse
        /// </returns>
        public async Task<QueryCheckinStatisticalDataResponse> QueryCheckinStatisticalDataAsync(QueryCheckinStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCheckinStatisticalDataHeaders headers = new QueryCheckinStatisticalDataHeaders();
            return await QueryCheckinStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业全员圈统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCircleStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryCircleStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCircleStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业全员圈统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCircleStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryCircleStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCircleStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业全员圈统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCircleStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCircleStatisticalDataResponse
        /// </returns>
        public QueryCircleStatisticalDataResponse QueryCircleStatisticalData(QueryCircleStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCircleStatisticalDataHeaders headers = new QueryCircleStatisticalDataHeaders();
            return QueryCircleStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业全员圈统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCircleStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCircleStatisticalDataResponse
        /// </returns>
        public async Task<QueryCircleStatisticalDataResponse> QueryCircleStatisticalDataAsync(QueryCircleStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCircleStatisticalDataHeaders headers = new QueryCircleStatisticalDataHeaders();
            return await QueryCircleStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过企业名称/社会统一信用代码/工商注册号，查询企业的基本画像信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCompanyBasicInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryCompanyBasicInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCompanyBasicInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过企业名称/社会统一信用代码/工商注册号，查询企业的基本画像信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCompanyBasicInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryCompanyBasicInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCompanyBasicInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过企业名称/社会统一信用代码/工商注册号，查询企业的基本画像信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCompanyBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCompanyBasicInfoResponse
        /// </returns>
        public QueryCompanyBasicInfoResponse QueryCompanyBasicInfo(QueryCompanyBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCompanyBasicInfoHeaders headers = new QueryCompanyBasicInfoHeaders();
            return QueryCompanyBasicInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过企业名称/社会统一信用代码/工商注册号，查询企业的基本画像信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCompanyBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCompanyBasicInfoResponse
        /// </returns>
        public async Task<QueryCompanyBasicInfoResponse> QueryCompanyBasicInfoAsync(QueryCompanyBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCompanyBasicInfoHeaders headers = new QueryCompanyBasicInfoHeaders();
            return await QueryCompanyBasicInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数字区县组织信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDigitalDistrictOrgInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryDigitalDistrictOrgInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDigitalDistrictOrgInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数字区县组织信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDigitalDistrictOrgInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryDigitalDistrictOrgInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDigitalDistrictOrgInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数字区县组织信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDigitalDistrictOrgInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDigitalDistrictOrgInfoResponse
        /// </returns>
        public QueryDigitalDistrictOrgInfoResponse QueryDigitalDistrictOrgInfo(QueryDigitalDistrictOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDigitalDistrictOrgInfoHeaders headers = new QueryDigitalDistrictOrgInfoHeaders();
            return QueryDigitalDistrictOrgInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数字区县组织信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDigitalDistrictOrgInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDigitalDistrictOrgInfoResponse
        /// </returns>
        public async Task<QueryDigitalDistrictOrgInfoResponse> QueryDigitalDistrictOrgInfoAsync(QueryDigitalDistrictOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDigitalDistrictOrgInfoHeaders headers = new QueryDigitalDistrictOrgInfoHeaders();
            return await QueryDigitalDistrictOrgInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业DING接收及评论统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDingReciveStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryDingReciveStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDingReciveStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业DING接收及评论统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDingReciveStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryDingReciveStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDingReciveStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业DING接收及评论统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDingReciveStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDingReciveStatisticalDataResponse
        /// </returns>
        public QueryDingReciveStatisticalDataResponse QueryDingReciveStatisticalData(QueryDingReciveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDingReciveStatisticalDataHeaders headers = new QueryDingReciveStatisticalDataHeaders();
            return QueryDingReciveStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业DING接收及评论统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDingReciveStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDingReciveStatisticalDataResponse
        /// </returns>
        public async Task<QueryDingReciveStatisticalDataResponse> QueryDingReciveStatisticalDataAsync(QueryDingReciveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDingReciveStatisticalDataHeaders headers = new QueryDingReciveStatisticalDataHeaders();
            return await QueryDingReciveStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业DING发送统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDingSendStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryDingSendStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDingSendStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业DING发送统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDingSendStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryDingSendStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDingSendStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业DING发送统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDingSendStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDingSendStatisticalDataResponse
        /// </returns>
        public QueryDingSendStatisticalDataResponse QueryDingSendStatisticalData(QueryDingSendStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDingSendStatisticalDataHeaders headers = new QueryDingSendStatisticalDataHeaders();
            return QueryDingSendStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业DING发送统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDingSendStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDingSendStatisticalDataResponse
        /// </returns>
        public async Task<QueryDingSendStatisticalDataResponse> QueryDingSendStatisticalDataAsync(QueryDingSendStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDingSendStatisticalDataHeaders headers = new QueryDingSendStatisticalDataHeaders();
            return await QueryDingSendStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业文档统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDocumentStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryDocumentStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDocumentStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业文档统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDocumentStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryDocumentStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDocumentStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业文档统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDocumentStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDocumentStatisticalDataResponse
        /// </returns>
        public QueryDocumentStatisticalDataResponse QueryDocumentStatisticalData(QueryDocumentStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDocumentStatisticalDataHeaders headers = new QueryDocumentStatisticalDataHeaders();
            return QueryDocumentStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业文档统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDocumentStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDocumentStatisticalDataResponse
        /// </returns>
        public async Task<QueryDocumentStatisticalDataResponse> QueryDocumentStatisticalDataAsync(QueryDocumentStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDocumentStatisticalDataHeaders headers = new QueryDocumentStatisticalDataHeaders();
            return await QueryDocumentStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据资产平台增购包购买信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryDpaasDataPackageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDpaasDataPackageResponse
        /// </returns>
        public QueryDpaasDataPackageResponse QueryDpaasDataPackageWithOptions(QueryDpaasDataPackageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryDpaasDataPackage",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dpaas/dataPackages/purchaseInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDpaasDataPackageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据资产平台增购包购买信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryDpaasDataPackageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDpaasDataPackageResponse
        /// </returns>
        public async Task<QueryDpaasDataPackageResponse> QueryDpaasDataPackageWithOptionsAsync(QueryDpaasDataPackageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryDpaasDataPackage",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dpaas/dataPackages/purchaseInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDpaasDataPackageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据资产平台增购包购买信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryDpaasDataPackageResponse
        /// </returns>
        public QueryDpaasDataPackageResponse QueryDpaasDataPackage()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDpaasDataPackageHeaders headers = new QueryDpaasDataPackageHeaders();
            return QueryDpaasDataPackageWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据资产平台增购包购买信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryDpaasDataPackageResponse
        /// </returns>
        public async Task<QueryDpaasDataPackageResponse> QueryDpaasDataPackageAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDpaasDataPackageHeaders headers = new QueryDpaasDataPackageHeaders();
            return await QueryDpaasDataPackageWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业钉盘统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDriveStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryDriveStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDriveStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业钉盘统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDriveStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryDriveStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDriveStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业钉盘统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDriveStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDriveStatisticalDataResponse
        /// </returns>
        public QueryDriveStatisticalDataResponse QueryDriveStatisticalData(QueryDriveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDriveStatisticalDataHeaders headers = new QueryDriveStatisticalDataHeaders();
            return QueryDriveStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业钉盘统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDriveStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDriveStatisticalDataResponse
        /// </returns>
        public async Task<QueryDriveStatisticalDataResponse> QueryDriveStatisticalDataAsync(QueryDriveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDriveStatisticalDataHeaders headers = new QueryDriveStatisticalDataHeaders();
            return await QueryDriveStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业员工类型统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEmployeeTypeStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryEmployeeTypeStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEmployeeTypeStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业员工类型统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEmployeeTypeStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryEmployeeTypeStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEmployeeTypeStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业员工类型统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEmployeeTypeStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEmployeeTypeStatisticalDataResponse
        /// </returns>
        public QueryEmployeeTypeStatisticalDataResponse QueryEmployeeTypeStatisticalData(QueryEmployeeTypeStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryEmployeeTypeStatisticalDataHeaders headers = new QueryEmployeeTypeStatisticalDataHeaders();
            return QueryEmployeeTypeStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业员工类型统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEmployeeTypeStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEmployeeTypeStatisticalDataResponse
        /// </returns>
        public async Task<QueryEmployeeTypeStatisticalDataResponse> QueryEmployeeTypeStatisticalDataAsync(QueryEmployeeTypeStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryEmployeeTypeStatisticalDataHeaders headers = new QueryEmployeeTypeStatisticalDataHeaders();
            return await QueryEmployeeTypeStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据资产平台数据服务接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGeneralDataServiceRequest
        /// </param>
        /// <param name="headers">
        /// QueryGeneralDataServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGeneralDataServiceResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnTotal))
            {
                query["returnTotal"] = request.ReturnTotal;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据资产平台数据服务接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGeneralDataServiceRequest
        /// </param>
        /// <param name="headers">
        /// QueryGeneralDataServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGeneralDataServiceResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnTotal))
            {
                query["returnTotal"] = request.ReturnTotal;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据资产平台数据服务接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGeneralDataServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGeneralDataServiceResponse
        /// </returns>
        public QueryGeneralDataServiceResponse QueryGeneralDataService(QueryGeneralDataServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGeneralDataServiceHeaders headers = new QueryGeneralDataServiceHeaders();
            return QueryGeneralDataServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据资产平台数据服务接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGeneralDataServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGeneralDataServiceResponse
        /// </returns>
        public async Task<QueryGeneralDataServiceResponse> QueryGeneralDataServiceAsync(QueryGeneralDataServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGeneralDataServiceHeaders headers = new QueryGeneralDataServiceHeaders();
            return await QueryGeneralDataServiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据资产平台数据服务接口(支持部门、员工维度批量拉取)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGeneralDataServiceBatchRequest
        /// </param>
        /// <param name="headers">
        /// QueryGeneralDataServiceBatchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGeneralDataServiceBatchResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnTotal))
            {
                body["returnTotal"] = request.ReturnTotal;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据资产平台数据服务接口(支持部门、员工维度批量拉取)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGeneralDataServiceBatchRequest
        /// </param>
        /// <param name="headers">
        /// QueryGeneralDataServiceBatchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGeneralDataServiceBatchResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnTotal))
            {
                body["returnTotal"] = request.ReturnTotal;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据资产平台数据服务接口(支持部门、员工维度批量拉取)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGeneralDataServiceBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGeneralDataServiceBatchResponse
        /// </returns>
        public QueryGeneralDataServiceBatchResponse QueryGeneralDataServiceBatch(QueryGeneralDataServiceBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGeneralDataServiceBatchHeaders headers = new QueryGeneralDataServiceBatchHeaders();
            return QueryGeneralDataServiceBatchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据资产平台数据服务接口(支持部门、员工维度批量拉取)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGeneralDataServiceBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGeneralDataServiceBatchResponse
        /// </returns>
        public async Task<QueryGeneralDataServiceBatchResponse> QueryGeneralDataServiceBatchAsync(QueryGeneralDataServiceBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGeneralDataServiceBatchHeaders headers = new QueryGeneralDataServiceBatchHeaders();
            return await QueryGeneralDataServiceBatchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据资产平台数据服务接口(查询数据更新日期)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGeneralDataUpdateDateRequest
        /// </param>
        /// <param name="headers">
        /// QueryGeneralDataUpdateDateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGeneralDataUpdateDateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据资产平台数据服务接口(查询数据更新日期)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGeneralDataUpdateDateRequest
        /// </param>
        /// <param name="headers">
        /// QueryGeneralDataUpdateDateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGeneralDataUpdateDateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据资产平台数据服务接口(查询数据更新日期)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGeneralDataUpdateDateRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGeneralDataUpdateDateResponse
        /// </returns>
        public QueryGeneralDataUpdateDateResponse QueryGeneralDataUpdateDate(QueryGeneralDataUpdateDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGeneralDataUpdateDateHeaders headers = new QueryGeneralDataUpdateDateHeaders();
            return QueryGeneralDataUpdateDateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据资产平台数据服务接口(查询数据更新日期)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGeneralDataUpdateDateRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGeneralDataUpdateDateResponse
        /// </returns>
        public async Task<QueryGeneralDataUpdateDateResponse> QueryGeneralDataUpdateDateAsync(QueryGeneralDataUpdateDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGeneralDataUpdateDateHeaders headers = new QueryGeneralDataUpdateDateHeaders();
            return await QueryGeneralDataUpdateDateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业群直播统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupLiveStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryGroupLiveStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupLiveStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业群直播统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupLiveStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryGroupLiveStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupLiveStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业群直播统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupLiveStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupLiveStatisticalDataResponse
        /// </returns>
        public QueryGroupLiveStatisticalDataResponse QueryGroupLiveStatisticalData(QueryGroupLiveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupLiveStatisticalDataHeaders headers = new QueryGroupLiveStatisticalDataHeaders();
            return QueryGroupLiveStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业群直播统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupLiveStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupLiveStatisticalDataResponse
        /// </returns>
        public async Task<QueryGroupLiveStatisticalDataResponse> QueryGroupLiveStatisticalDataAsync(QueryGroupLiveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupLiveStatisticalDataHeaders headers = new QueryGroupLiveStatisticalDataHeaders();
            return await QueryGroupLiveStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业群聊统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupMessageStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryGroupMessageStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupMessageStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业群聊统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupMessageStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryGroupMessageStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupMessageStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业群聊统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupMessageStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupMessageStatisticalDataResponse
        /// </returns>
        public QueryGroupMessageStatisticalDataResponse QueryGroupMessageStatisticalData(QueryGroupMessageStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMessageStatisticalDataHeaders headers = new QueryGroupMessageStatisticalDataHeaders();
            return QueryGroupMessageStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业群聊统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupMessageStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupMessageStatisticalDataResponse
        /// </returns>
        public async Task<QueryGroupMessageStatisticalDataResponse> QueryGroupMessageStatisticalDataAsync(QueryGroupMessageStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMessageStatisticalDataHeaders headers = new QueryGroupMessageStatisticalDataHeaders();
            return await QueryGroupMessageStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业钉钉运动统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHealthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryHealthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryHealthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业钉钉运动统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHealthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryHealthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryHealthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业钉钉运动统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHealthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryHealthStatisticalDataResponse
        /// </returns>
        public QueryHealthStatisticalDataResponse QueryHealthStatisticalData(QueryHealthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHealthStatisticalDataHeaders headers = new QueryHealthStatisticalDataHeaders();
            return QueryHealthStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业钉钉运动统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHealthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryHealthStatisticalDataResponse
        /// </returns>
        public async Task<QueryHealthStatisticalDataResponse> QueryHealthStatisticalDataAsync(QueryHealthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHealthStatisticalDataHeaders headers = new QueryHealthStatisticalDataHeaders();
            return await QueryHealthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业邮箱统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMailStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryMailStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMailStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业邮箱统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMailStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryMailStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMailStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业邮箱统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMailStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMailStatisticalDataResponse
        /// </returns>
        public QueryMailStatisticalDataResponse QueryMailStatisticalData(QueryMailStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMailStatisticalDataHeaders headers = new QueryMailStatisticalDataHeaders();
            return QueryMailStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业邮箱统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMailStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMailStatisticalDataResponse
        /// </returns>
        public async Task<QueryMailStatisticalDataResponse> QueryMailStatisticalDataAsync(QueryMailStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMailStatisticalDataHeaders headers = new QueryMailStatisticalDataHeaders();
            return await QueryMailStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取官方数据集数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryOfficialDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取官方数据集数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryOfficialDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取官方数据集数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialDataResponse
        /// </returns>
        public QueryOfficialDataResponse QueryOfficialData(QueryOfficialDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialDataHeaders headers = new QueryOfficialDataHeaders();
            return QueryOfficialDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取官方数据集数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialDataResponse
        /// </returns>
        public async Task<QueryOfficialDataResponse> QueryOfficialDataAsync(QueryOfficialDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialDataHeaders headers = new QueryOfficialDataHeaders();
            return await QueryOfficialDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ISV获取官方数据集字段信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialDatasetFieldsRequest
        /// </param>
        /// <param name="headers">
        /// QueryOfficialDatasetFieldsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialDatasetFieldsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ISV获取官方数据集字段信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialDatasetFieldsRequest
        /// </param>
        /// <param name="headers">
        /// QueryOfficialDatasetFieldsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialDatasetFieldsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ISV获取官方数据集字段信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialDatasetFieldsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialDatasetFieldsResponse
        /// </returns>
        public QueryOfficialDatasetFieldsResponse QueryOfficialDatasetFields(QueryOfficialDatasetFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialDatasetFieldsHeaders headers = new QueryOfficialDatasetFieldsHeaders();
            return QueryOfficialDatasetFieldsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ISV获取官方数据集字段信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialDatasetFieldsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialDatasetFieldsResponse
        /// </returns>
        public async Task<QueryOfficialDatasetFieldsResponse> QueryOfficialDatasetFieldsAsync(QueryOfficialDatasetFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialDatasetFieldsHeaders headers = new QueryOfficialDatasetFieldsHeaders();
            return await QueryOfficialDatasetFieldsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ISV获取官方数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialDatasetListRequest
        /// </param>
        /// <param name="headers">
        /// QueryOfficialDatasetListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialDatasetListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ISV获取官方数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialDatasetListRequest
        /// </param>
        /// <param name="headers">
        /// QueryOfficialDatasetListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialDatasetListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ISV获取官方数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialDatasetListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialDatasetListResponse
        /// </returns>
        public QueryOfficialDatasetListResponse QueryOfficialDatasetList(QueryOfficialDatasetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialDatasetListHeaders headers = new QueryOfficialDatasetListHeaders();
            return QueryOfficialDatasetListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ISV获取官方数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialDatasetListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialDatasetListResponse
        /// </returns>
        public async Task<QueryOfficialDatasetListResponse> QueryOfficialDatasetListAsync(QueryOfficialDatasetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialDatasetListHeaders headers = new QueryOfficialDatasetListHeaders();
            return await QueryOfficialDatasetListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取官方数据集数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialFormDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryOfficialFormDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialFormDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取官方数据集数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialFormDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryOfficialFormDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialFormDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取官方数据集数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialFormDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialFormDataResponse
        /// </returns>
        public QueryOfficialFormDataResponse QueryOfficialFormData(QueryOfficialFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialFormDataHeaders headers = new QueryOfficialFormDataHeaders();
            return QueryOfficialFormDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取官方数据集数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialFormDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialFormDataResponse
        /// </returns>
        public async Task<QueryOfficialFormDataResponse> QueryOfficialFormDataAsync(QueryOfficialFormDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialFormDataHeaders headers = new QueryOfficialFormDataHeaders();
            return await QueryOfficialFormDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取HOLO中官方OA表单数据集数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialFormDataDirectHoloRequest
        /// </param>
        /// <param name="headers">
        /// QueryOfficialFormDataDirectHoloHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialFormDataDirectHoloResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取HOLO中官方OA表单数据集数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialFormDataDirectHoloRequest
        /// </param>
        /// <param name="headers">
        /// QueryOfficialFormDataDirectHoloHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialFormDataDirectHoloResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取HOLO中官方OA表单数据集数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialFormDataDirectHoloRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialFormDataDirectHoloResponse
        /// </returns>
        public QueryOfficialFormDataDirectHoloResponse QueryOfficialFormDataDirectHolo(QueryOfficialFormDataDirectHoloRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialFormDataDirectHoloHeaders headers = new QueryOfficialFormDataDirectHoloHeaders();
            return QueryOfficialFormDataDirectHoloWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取HOLO中官方OA表单数据集数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOfficialFormDataDirectHoloRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOfficialFormDataDirectHoloResponse
        /// </returns>
        public async Task<QueryOfficialFormDataDirectHoloResponse> QueryOfficialFormDataDirectHoloAsync(QueryOfficialFormDataDirectHoloRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialFormDataDirectHoloHeaders headers = new QueryOfficialFormDataDirectHoloHeaders();
            return await QueryOfficialFormDataDirectHoloWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业用户在线统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOnlineUserStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryOnlineUserStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOnlineUserStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业用户在线统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOnlineUserStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryOnlineUserStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOnlineUserStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业用户在线统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOnlineUserStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOnlineUserStatisticalDataResponse
        /// </returns>
        public QueryOnlineUserStatisticalDataResponse QueryOnlineUserStatisticalData(QueryOnlineUserStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOnlineUserStatisticalDataHeaders headers = new QueryOnlineUserStatisticalDataHeaders();
            return QueryOnlineUserStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业用户在线统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOnlineUserStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOnlineUserStatisticalDataResponse
        /// </returns>
        public async Task<QueryOnlineUserStatisticalDataResponse> QueryOnlineUserStatisticalDataAsync(QueryOnlineUserStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOnlineUserStatisticalDataHeaders headers = new QueryOnlineUserStatisticalDataHeaders();
            return await QueryOnlineUserStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业接收红包统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRedEnvelopeReciveStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryRedEnvelopeReciveStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRedEnvelopeReciveStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业接收红包统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRedEnvelopeReciveStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryRedEnvelopeReciveStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRedEnvelopeReciveStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业接收红包统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRedEnvelopeReciveStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRedEnvelopeReciveStatisticalDataResponse
        /// </returns>
        public QueryRedEnvelopeReciveStatisticalDataResponse QueryRedEnvelopeReciveStatisticalData(QueryRedEnvelopeReciveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRedEnvelopeReciveStatisticalDataHeaders headers = new QueryRedEnvelopeReciveStatisticalDataHeaders();
            return QueryRedEnvelopeReciveStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业接收红包统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRedEnvelopeReciveStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRedEnvelopeReciveStatisticalDataResponse
        /// </returns>
        public async Task<QueryRedEnvelopeReciveStatisticalDataResponse> QueryRedEnvelopeReciveStatisticalDataAsync(QueryRedEnvelopeReciveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRedEnvelopeReciveStatisticalDataHeaders headers = new QueryRedEnvelopeReciveStatisticalDataHeaders();
            return await QueryRedEnvelopeReciveStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业发送红包统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRedEnvelopeSendStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryRedEnvelopeSendStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRedEnvelopeSendStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业发送红包统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRedEnvelopeSendStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryRedEnvelopeSendStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRedEnvelopeSendStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业发送红包统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRedEnvelopeSendStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRedEnvelopeSendStatisticalDataResponse
        /// </returns>
        public QueryRedEnvelopeSendStatisticalDataResponse QueryRedEnvelopeSendStatisticalData(QueryRedEnvelopeSendStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRedEnvelopeSendStatisticalDataHeaders headers = new QueryRedEnvelopeSendStatisticalDataHeaders();
            return QueryRedEnvelopeSendStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业发送红包统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRedEnvelopeSendStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRedEnvelopeSendStatisticalDataResponse
        /// </returns>
        public async Task<QueryRedEnvelopeSendStatisticalDataResponse> QueryRedEnvelopeSendStatisticalDataAsync(QueryRedEnvelopeSendStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRedEnvelopeSendStatisticalDataHeaders headers = new QueryRedEnvelopeSendStatisticalDataHeaders();
            return await QueryRedEnvelopeSendStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业日志统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReportStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryReportStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryReportStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业日志统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReportStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryReportStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryReportStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业日志统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReportStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryReportStatisticalDataResponse
        /// </returns>
        public QueryReportStatisticalDataResponse QueryReportStatisticalData(QueryReportStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReportStatisticalDataHeaders headers = new QueryReportStatisticalDataHeaders();
            return QueryReportStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业日志统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReportStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryReportStatisticalDataResponse
        /// </returns>
        public async Task<QueryReportStatisticalDataResponse> QueryReportStatisticalDataAsync(QueryReportStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReportStatisticalDataHeaders headers = new QueryReportStatisticalDataHeaders();
            return await QueryReportStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据大屏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScreenRequest
        /// </param>
        /// <param name="headers">
        /// QueryScreenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScreenResponse
        /// </returns>
        public QueryScreenResponse QueryScreenWithOptions(QueryScreenRequest request, QueryScreenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryScreen",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/screens",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScreenResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据大屏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScreenRequest
        /// </param>
        /// <param name="headers">
        /// QueryScreenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScreenResponse
        /// </returns>
        public async Task<QueryScreenResponse> QueryScreenWithOptionsAsync(QueryScreenRequest request, QueryScreenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryScreen",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/screens",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScreenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据大屏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScreenRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScreenResponse
        /// </returns>
        public QueryScreenResponse QueryScreen(QueryScreenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScreenHeaders headers = new QueryScreenHeaders();
            return QueryScreenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据大屏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScreenRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScreenResponse
        /// </returns>
        public async Task<QueryScreenResponse> QueryScreenAsync(QueryScreenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScreenHeaders headers = new QueryScreenHeaders();
            return await QueryScreenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据大屏模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScreenTemplateRequest
        /// </param>
        /// <param name="headers">
        /// QueryScreenTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScreenTemplateResponse
        /// </returns>
        public QueryScreenTemplateResponse QueryScreenTemplateWithOptions(QueryScreenTemplateRequest request, QueryScreenTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sample))
            {
                query["sample"] = request.Sample;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryScreenTemplate",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/screenTemplates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScreenTemplateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据大屏模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScreenTemplateRequest
        /// </param>
        /// <param name="headers">
        /// QueryScreenTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScreenTemplateResponse
        /// </returns>
        public async Task<QueryScreenTemplateResponse> QueryScreenTemplateWithOptionsAsync(QueryScreenTemplateRequest request, QueryScreenTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sample))
            {
                query["sample"] = request.Sample;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryScreenTemplate",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/screenTemplates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScreenTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据大屏模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScreenTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScreenTemplateResponse
        /// </returns>
        public QueryScreenTemplateResponse QueryScreenTemplate(QueryScreenTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScreenTemplateHeaders headers = new QueryScreenTemplateHeaders();
            return QueryScreenTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据大屏模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScreenTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScreenTemplateResponse
        /// </returns>
        public async Task<QueryScreenTemplateResponse> QueryScreenTemplateAsync(QueryScreenTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScreenTemplateHeaders headers = new QueryScreenTemplateHeaders();
            return await QueryScreenTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业单聊统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySingleMessageStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QuerySingleMessageStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleMessageStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业单聊统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySingleMessageStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QuerySingleMessageStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleMessageStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业单聊统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySingleMessageStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleMessageStatisticalDataResponse
        /// </returns>
        public QuerySingleMessageStatisticalDataResponse QuerySingleMessageStatisticalData(QuerySingleMessageStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySingleMessageStatisticalDataHeaders headers = new QuerySingleMessageStatisticalDataHeaders();
            return QuerySingleMessageStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业单聊统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySingleMessageStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleMessageStatisticalDataResponse
        /// </returns>
        public async Task<QuerySingleMessageStatisticalDataResponse> QuerySingleMessageStatisticalDataAsync(QuerySingleMessageStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySingleMessageStatisticalDataHeaders headers = new QuerySingleMessageStatisticalDataHeaders();
            return await QuerySingleMessageStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业电话会议统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTelMeetingStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryTelMeetingStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTelMeetingStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业电话会议统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTelMeetingStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryTelMeetingStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTelMeetingStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业电话会议统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTelMeetingStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTelMeetingStatisticalDataResponse
        /// </returns>
        public QueryTelMeetingStatisticalDataResponse QueryTelMeetingStatisticalData(QueryTelMeetingStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTelMeetingStatisticalDataHeaders headers = new QueryTelMeetingStatisticalDataHeaders();
            return QueryTelMeetingStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业电话会议统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTelMeetingStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTelMeetingStatisticalDataResponse
        /// </returns>
        public async Task<QueryTelMeetingStatisticalDataResponse> QueryTelMeetingStatisticalDataAsync(QueryTelMeetingStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTelMeetingStatisticalDataHeaders headers = new QueryTelMeetingStatisticalDataHeaders();
            return await QueryTelMeetingStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业待办统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTodoStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryTodoStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTodoStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业待办统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTodoStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryTodoStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTodoStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业待办统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTodoStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTodoStatisticalDataResponse
        /// </returns>
        public QueryTodoStatisticalDataResponse QueryTodoStatisticalData(QueryTodoStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTodoStatisticalDataHeaders headers = new QueryTodoStatisticalDataHeaders();
            return QueryTodoStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业待办统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTodoStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTodoStatisticalDataResponse
        /// </returns>
        public async Task<QueryTodoStatisticalDataResponse> QueryTodoStatisticalDataAsync(QueryTodoStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTodoStatisticalDataHeaders headers = new QueryTodoStatisticalDataHeaders();
            return await QueryTodoStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据资产平台查询数据记录数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTotalDataCountServiceRequest
        /// </param>
        /// <param name="headers">
        /// QueryTotalDataCountServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTotalDataCountServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据资产平台查询数据记录数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTotalDataCountServiceRequest
        /// </param>
        /// <param name="headers">
        /// QueryTotalDataCountServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTotalDataCountServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据资产平台查询数据记录数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTotalDataCountServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTotalDataCountServiceResponse
        /// </returns>
        public QueryTotalDataCountServiceResponse QueryTotalDataCountService(QueryTotalDataCountServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTotalDataCountServiceHeaders headers = new QueryTotalDataCountServiceHeaders();
            return QueryTotalDataCountServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据资产平台查询数据记录数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTotalDataCountServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTotalDataCountServiceResponse
        /// </returns>
        public async Task<QueryTotalDataCountServiceResponse> QueryTotalDataCountServiceAsync(QueryTotalDataCountServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTotalDataCountServiceHeaders headers = new QueryTotalDataCountServiceHeaders();
            return await QueryTotalDataCountServiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业视频会议统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVedioMeetingStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryVedioMeetingStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryVedioMeetingStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业视频会议统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVedioMeetingStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryVedioMeetingStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryVedioMeetingStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业视频会议统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVedioMeetingStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryVedioMeetingStatisticalDataResponse
        /// </returns>
        public QueryVedioMeetingStatisticalDataResponse QueryVedioMeetingStatisticalData(QueryVedioMeetingStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryVedioMeetingStatisticalDataHeaders headers = new QueryVedioMeetingStatisticalDataHeaders();
            return QueryVedioMeetingStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业视频会议统计数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVedioMeetingStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryVedioMeetingStatisticalDataResponse
        /// </returns>
        public async Task<QueryVedioMeetingStatisticalDataResponse> QueryVedioMeetingStatisticalDataAsync(QueryVedioMeetingStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryVedioMeetingStatisticalDataHeaders headers = new QueryVedioMeetingStatisticalDataHeaders();
            return await QueryVedioMeetingStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋活跃分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydActiveDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydActiveDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydActiveDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋活跃分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydActiveDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydActiveDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydActiveDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋活跃分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydActiveDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydActiveDayStatisticalDataResponse
        /// </returns>
        public QueryYydActiveDayStatisticalDataResponse QueryYydActiveDayStatisticalData(QueryYydActiveDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydActiveDayStatisticalDataHeaders headers = new QueryYydActiveDayStatisticalDataHeaders();
            return QueryYydActiveDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋活跃分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydActiveDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydActiveDayStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydActiveDayStatisticalDataResponse> QueryYydActiveDayStatisticalDataAsync(QueryYydActiveDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydActiveDayStatisticalDataHeaders headers = new QueryYydActiveDayStatisticalDataHeaders();
            return await QueryYydActiveDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋活跃分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydActiveMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydActiveMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydActiveMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋活跃分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydActiveMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydActiveMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydActiveMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋活跃分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydActiveMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydActiveMonthStatisticalDataResponse
        /// </returns>
        public QueryYydActiveMonthStatisticalDataResponse QueryYydActiveMonthStatisticalData(QueryYydActiveMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydActiveMonthStatisticalDataHeaders headers = new QueryYydActiveMonthStatisticalDataHeaders();
            return QueryYydActiveMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋活跃分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydActiveMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydActiveMonthStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydActiveMonthStatisticalDataResponse> QueryYydActiveMonthStatisticalDataAsync(QueryYydActiveMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydActiveMonthStatisticalDataHeaders headers = new QueryYydActiveMonthStatisticalDataHeaders();
            return await QueryYydActiveMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋活跃分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydActiveWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydActiveWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydActiveWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋活跃分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydActiveWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydActiveWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydActiveWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋活跃分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydActiveWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydActiveWeekStatisticalDataResponse
        /// </returns>
        public QueryYydActiveWeekStatisticalDataResponse QueryYydActiveWeekStatisticalData(QueryYydActiveWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydActiveWeekStatisticalDataHeaders headers = new QueryYydActiveWeekStatisticalDataHeaders();
            return QueryYydActiveWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋活跃分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydActiveWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydActiveWeekStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydActiveWeekStatisticalDataResponse> QueryYydActiveWeekStatisticalDataAsync(QueryYydActiveWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydActiveWeekStatisticalDataHeaders headers = new QueryYydActiveWeekStatisticalDataHeaders();
            return await QueryYydActiveWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋应用概况（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydAppDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydAppDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydAppDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋应用概况（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydAppDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydAppDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydAppDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋应用概况（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydAppDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydAppDayStatisticalDataResponse
        /// </returns>
        public QueryYydAppDayStatisticalDataResponse QueryYydAppDayStatisticalData(QueryYydAppDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppDayStatisticalDataHeaders headers = new QueryYydAppDayStatisticalDataHeaders();
            return QueryYydAppDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋应用概况（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydAppDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydAppDayStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydAppDayStatisticalDataResponse> QueryYydAppDayStatisticalDataAsync(QueryYydAppDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppDayStatisticalDataHeaders headers = new QueryYydAppDayStatisticalDataHeaders();
            return await QueryYydAppDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋应用概况（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydAppMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydAppMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydAppMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋应用概况（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydAppMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydAppMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydAppMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋应用概况（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydAppMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydAppMonthStatisticalDataResponse
        /// </returns>
        public QueryYydAppMonthStatisticalDataResponse QueryYydAppMonthStatisticalData(QueryYydAppMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppMonthStatisticalDataHeaders headers = new QueryYydAppMonthStatisticalDataHeaders();
            return QueryYydAppMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋应用概况（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydAppMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydAppMonthStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydAppMonthStatisticalDataResponse> QueryYydAppMonthStatisticalDataAsync(QueryYydAppMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppMonthStatisticalDataHeaders headers = new QueryYydAppMonthStatisticalDataHeaders();
            return await QueryYydAppMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋应用概况（累计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydAppStdStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydAppStdStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydAppStdStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋应用概况（累计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydAppStdStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydAppStdStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydAppStdStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋应用概况（累计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydAppStdStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydAppStdStatisticalDataResponse
        /// </returns>
        public QueryYydAppStdStatisticalDataResponse QueryYydAppStdStatisticalData(QueryYydAppStdStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppStdStatisticalDataHeaders headers = new QueryYydAppStdStatisticalDataHeaders();
            return QueryYydAppStdStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋应用概况（累计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydAppStdStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydAppStdStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydAppStdStatisticalDataResponse> QueryYydAppStdStatisticalDataAsync(QueryYydAppStdStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppStdStatisticalDataHeaders headers = new QueryYydAppStdStatisticalDataHeaders();
            return await QueryYydAppStdStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋应用概况（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydAppWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydAppWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydAppWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋应用概况（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydAppWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydAppWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydAppWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋应用概况（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydAppWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydAppWeekStatisticalDataResponse
        /// </returns>
        public QueryYydAppWeekStatisticalDataResponse QueryYydAppWeekStatisticalData(QueryYydAppWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppWeekStatisticalDataHeaders headers = new QueryYydAppWeekStatisticalDataHeaders();
            return QueryYydAppWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋应用概况（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydAppWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydAppWeekStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydAppWeekStatisticalDataResponse> QueryYydAppWeekStatisticalDataAsync(QueryYydAppWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppWeekStatisticalDataHeaders headers = new QueryYydAppWeekStatisticalDataHeaders();
            return await QueryYydAppWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋会议日程分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydCalendarDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydCalendarDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydCalendarDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋会议日程分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydCalendarDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydCalendarDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydCalendarDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋会议日程分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydCalendarDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydCalendarDayStatisticalDataResponse
        /// </returns>
        public QueryYydCalendarDayStatisticalDataResponse QueryYydCalendarDayStatisticalData(QueryYydCalendarDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydCalendarDayStatisticalDataHeaders headers = new QueryYydCalendarDayStatisticalDataHeaders();
            return QueryYydCalendarDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋会议日程分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydCalendarDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydCalendarDayStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydCalendarDayStatisticalDataResponse> QueryYydCalendarDayStatisticalDataAsync(QueryYydCalendarDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydCalendarDayStatisticalDataHeaders headers = new QueryYydCalendarDayStatisticalDataHeaders();
            return await QueryYydCalendarDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋会议日程分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydCalendarMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydCalendarMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydCalendarMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋会议日程分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydCalendarMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydCalendarMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydCalendarMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋会议日程分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydCalendarMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydCalendarMonthStatisticalDataResponse
        /// </returns>
        public QueryYydCalendarMonthStatisticalDataResponse QueryYydCalendarMonthStatisticalData(QueryYydCalendarMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydCalendarMonthStatisticalDataHeaders headers = new QueryYydCalendarMonthStatisticalDataHeaders();
            return QueryYydCalendarMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋会议日程分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydCalendarMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydCalendarMonthStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydCalendarMonthStatisticalDataResponse> QueryYydCalendarMonthStatisticalDataAsync(QueryYydCalendarMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydCalendarMonthStatisticalDataHeaders headers = new QueryYydCalendarMonthStatisticalDataHeaders();
            return await QueryYydCalendarMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋会议日程分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydCalendarWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydCalendarWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydCalendarWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋会议日程分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydCalendarWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydCalendarWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydCalendarWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋会议日程分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydCalendarWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydCalendarWeekStatisticalDataResponse
        /// </returns>
        public QueryYydCalendarWeekStatisticalDataResponse QueryYydCalendarWeekStatisticalData(QueryYydCalendarWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydCalendarWeekStatisticalDataHeaders headers = new QueryYydCalendarWeekStatisticalDataHeaders();
            return QueryYydCalendarWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋会议日程分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydCalendarWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydCalendarWeekStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydCalendarWeekStatisticalDataResponse> QueryYydCalendarWeekStatisticalDataAsync(QueryYydCalendarWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydCalendarWeekStatisticalDataHeaders headers = new QueryYydCalendarWeekStatisticalDataHeaders();
            return await QueryYydCalendarWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉消息分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydDingMsgDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydDingMsgDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydDingMsgDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉消息分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydDingMsgDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydDingMsgDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydDingMsgDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉消息分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydDingMsgDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydDingMsgDayStatisticalDataResponse
        /// </returns>
        public QueryYydDingMsgDayStatisticalDataResponse QueryYydDingMsgDayStatisticalData(QueryYydDingMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydDingMsgDayStatisticalDataHeaders headers = new QueryYydDingMsgDayStatisticalDataHeaders();
            return QueryYydDingMsgDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉消息分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydDingMsgDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydDingMsgDayStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydDingMsgDayStatisticalDataResponse> QueryYydDingMsgDayStatisticalDataAsync(QueryYydDingMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydDingMsgDayStatisticalDataHeaders headers = new QueryYydDingMsgDayStatisticalDataHeaders();
            return await QueryYydDingMsgDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉消息分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydDingMsgMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydDingMsgMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydDingMsgMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉消息分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydDingMsgMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydDingMsgMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydDingMsgMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉消息分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydDingMsgMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydDingMsgMonthStatisticalDataResponse
        /// </returns>
        public QueryYydDingMsgMonthStatisticalDataResponse QueryYydDingMsgMonthStatisticalData(QueryYydDingMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydDingMsgMonthStatisticalDataHeaders headers = new QueryYydDingMsgMonthStatisticalDataHeaders();
            return QueryYydDingMsgMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉消息分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydDingMsgMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydDingMsgMonthStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydDingMsgMonthStatisticalDataResponse> QueryYydDingMsgMonthStatisticalDataAsync(QueryYydDingMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydDingMsgMonthStatisticalDataHeaders headers = new QueryYydDingMsgMonthStatisticalDataHeaders();
            return await QueryYydDingMsgMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉消息分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydDingMsgWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydDingMsgWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydDingMsgWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉消息分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydDingMsgWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydDingMsgWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydDingMsgWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉消息分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydDingMsgWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydDingMsgWeekStatisticalDataResponse
        /// </returns>
        public QueryYydDingMsgWeekStatisticalDataResponse QueryYydDingMsgWeekStatisticalData(QueryYydDingMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydDingMsgWeekStatisticalDataHeaders headers = new QueryYydDingMsgWeekStatisticalDataHeaders();
            return QueryYydDingMsgWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉消息分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydDingMsgWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydDingMsgWeekStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydDingMsgWeekStatisticalDataResponse> QueryYydDingMsgWeekStatisticalDataAsync(QueryYydDingMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydDingMsgWeekStatisticalDataHeaders headers = new QueryYydDingMsgWeekStatisticalDataHeaders();
            return await QueryYydDingMsgWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋群聊分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydGroupMsgDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydGroupMsgDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydGroupMsgDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋群聊分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydGroupMsgDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydGroupMsgDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydGroupMsgDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋群聊分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydGroupMsgDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydGroupMsgDayStatisticalDataResponse
        /// </returns>
        public QueryYydGroupMsgDayStatisticalDataResponse QueryYydGroupMsgDayStatisticalData(QueryYydGroupMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydGroupMsgDayStatisticalDataHeaders headers = new QueryYydGroupMsgDayStatisticalDataHeaders();
            return QueryYydGroupMsgDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋群聊分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydGroupMsgDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydGroupMsgDayStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydGroupMsgDayStatisticalDataResponse> QueryYydGroupMsgDayStatisticalDataAsync(QueryYydGroupMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydGroupMsgDayStatisticalDataHeaders headers = new QueryYydGroupMsgDayStatisticalDataHeaders();
            return await QueryYydGroupMsgDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋群聊分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydGroupMsgMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydGroupMsgMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydGroupMsgMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋群聊分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydGroupMsgMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydGroupMsgMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydGroupMsgMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋群聊分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydGroupMsgMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydGroupMsgMonthStatisticalDataResponse
        /// </returns>
        public QueryYydGroupMsgMonthStatisticalDataResponse QueryYydGroupMsgMonthStatisticalData(QueryYydGroupMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydGroupMsgMonthStatisticalDataHeaders headers = new QueryYydGroupMsgMonthStatisticalDataHeaders();
            return QueryYydGroupMsgMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋群聊分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydGroupMsgMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydGroupMsgMonthStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydGroupMsgMonthStatisticalDataResponse> QueryYydGroupMsgMonthStatisticalDataAsync(QueryYydGroupMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydGroupMsgMonthStatisticalDataHeaders headers = new QueryYydGroupMsgMonthStatisticalDataHeaders();
            return await QueryYydGroupMsgMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋群聊分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydGroupMsgWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydGroupMsgWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydGroupMsgWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋群聊分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydGroupMsgWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydGroupMsgWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydGroupMsgWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋群聊分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydGroupMsgWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydGroupMsgWeekStatisticalDataResponse
        /// </returns>
        public QueryYydGroupMsgWeekStatisticalDataResponse QueryYydGroupMsgWeekStatisticalData(QueryYydGroupMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydGroupMsgWeekStatisticalDataHeaders headers = new QueryYydGroupMsgWeekStatisticalDataHeaders();
            return QueryYydGroupMsgWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋群聊分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydGroupMsgWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydGroupMsgWeekStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydGroupMsgWeekStatisticalDataResponse> QueryYydGroupMsgWeekStatisticalDataAsync(QueryYydGroupMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydGroupMsgWeekStatisticalDataHeaders headers = new QueryYydGroupMsgWeekStatisticalDataHeaders();
            return await QueryYydGroupMsgWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋日志分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydLogDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydLogDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydLogDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋日志分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydLogDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydLogDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydLogDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋日志分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydLogDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydLogDayStatisticalDataResponse
        /// </returns>
        public QueryYydLogDayStatisticalDataResponse QueryYydLogDayStatisticalData(QueryYydLogDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydLogDayStatisticalDataHeaders headers = new QueryYydLogDayStatisticalDataHeaders();
            return QueryYydLogDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋日志分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydLogDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydLogDayStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydLogDayStatisticalDataResponse> QueryYydLogDayStatisticalDataAsync(QueryYydLogDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydLogDayStatisticalDataHeaders headers = new QueryYydLogDayStatisticalDataHeaders();
            return await QueryYydLogDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋日志分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydLogMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydLogMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydLogMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋日志分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydLogMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydLogMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydLogMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋日志分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydLogMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydLogMonthStatisticalDataResponse
        /// </returns>
        public QueryYydLogMonthStatisticalDataResponse QueryYydLogMonthStatisticalData(QueryYydLogMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydLogMonthStatisticalDataHeaders headers = new QueryYydLogMonthStatisticalDataHeaders();
            return QueryYydLogMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋日志分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydLogMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydLogMonthStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydLogMonthStatisticalDataResponse> QueryYydLogMonthStatisticalDataAsync(QueryYydLogMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydLogMonthStatisticalDataHeaders headers = new QueryYydLogMonthStatisticalDataHeaders();
            return await QueryYydLogMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋日志分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydLogWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydLogWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydLogWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋日志分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydLogWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydLogWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydLogWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋日志分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydLogWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydLogWeekStatisticalDataResponse
        /// </returns>
        public QueryYydLogWeekStatisticalDataResponse QueryYydLogWeekStatisticalData(QueryYydLogWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydLogWeekStatisticalDataHeaders headers = new QueryYydLogWeekStatisticalDataHeaders();
            return QueryYydLogWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋日志分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydLogWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydLogWeekStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydLogWeekStatisticalDataResponse> QueryYydLogWeekStatisticalDataAsync(QueryYydLogWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydLogWeekStatisticalDataHeaders headers = new QueryYydLogWeekStatisticalDataHeaders();
            return await QueryYydLogWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉会议分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydMeetingDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydMeetingDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydMeetingDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉会议分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydMeetingDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydMeetingDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydMeetingDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉会议分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydMeetingDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydMeetingDayStatisticalDataResponse
        /// </returns>
        public QueryYydMeetingDayStatisticalDataResponse QueryYydMeetingDayStatisticalData(QueryYydMeetingDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydMeetingDayStatisticalDataHeaders headers = new QueryYydMeetingDayStatisticalDataHeaders();
            return QueryYydMeetingDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉会议分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydMeetingDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydMeetingDayStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydMeetingDayStatisticalDataResponse> QueryYydMeetingDayStatisticalDataAsync(QueryYydMeetingDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydMeetingDayStatisticalDataHeaders headers = new QueryYydMeetingDayStatisticalDataHeaders();
            return await QueryYydMeetingDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉会议分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydMeetingMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydMeetingMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydMeetingMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉会议分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydMeetingMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydMeetingMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydMeetingMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉会议分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydMeetingMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydMeetingMonthStatisticalDataResponse
        /// </returns>
        public QueryYydMeetingMonthStatisticalDataResponse QueryYydMeetingMonthStatisticalData(QueryYydMeetingMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydMeetingMonthStatisticalDataHeaders headers = new QueryYydMeetingMonthStatisticalDataHeaders();
            return QueryYydMeetingMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉会议分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydMeetingMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydMeetingMonthStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydMeetingMonthStatisticalDataResponse> QueryYydMeetingMonthStatisticalDataAsync(QueryYydMeetingMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydMeetingMonthStatisticalDataHeaders headers = new QueryYydMeetingMonthStatisticalDataHeaders();
            return await QueryYydMeetingMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉会议分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydMeetingWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydMeetingWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydMeetingWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉会议分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydMeetingWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydMeetingWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydMeetingWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉会议分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydMeetingWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydMeetingWeekStatisticalDataResponse
        /// </returns>
        public QueryYydMeetingWeekStatisticalDataResponse QueryYydMeetingWeekStatisticalData(QueryYydMeetingWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydMeetingWeekStatisticalDataHeaders headers = new QueryYydMeetingWeekStatisticalDataHeaders();
            return QueryYydMeetingWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋钉会议分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydMeetingWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydMeetingWeekStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydMeetingWeekStatisticalDataResponse> QueryYydMeetingWeekStatisticalDataAsync(QueryYydMeetingWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydMeetingWeekStatisticalDataHeaders headers = new QueryYydMeetingWeekStatisticalDataHeaders();
            return await QueryYydMeetingWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋通知分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydNoticeDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydNoticeDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydNoticeDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋通知分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydNoticeDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydNoticeDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydNoticeDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋通知分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydNoticeDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydNoticeDayStatisticalDataResponse
        /// </returns>
        public QueryYydNoticeDayStatisticalDataResponse QueryYydNoticeDayStatisticalData(QueryYydNoticeDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydNoticeDayStatisticalDataHeaders headers = new QueryYydNoticeDayStatisticalDataHeaders();
            return QueryYydNoticeDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋通知分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydNoticeDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydNoticeDayStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydNoticeDayStatisticalDataResponse> QueryYydNoticeDayStatisticalDataAsync(QueryYydNoticeDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydNoticeDayStatisticalDataHeaders headers = new QueryYydNoticeDayStatisticalDataHeaders();
            return await QueryYydNoticeDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋通知分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydNoticeMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydNoticeMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydNoticeMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋通知分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydNoticeMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydNoticeMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydNoticeMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋通知分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydNoticeMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydNoticeMonthStatisticalDataResponse
        /// </returns>
        public QueryYydNoticeMonthStatisticalDataResponse QueryYydNoticeMonthStatisticalData(QueryYydNoticeMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydNoticeMonthStatisticalDataHeaders headers = new QueryYydNoticeMonthStatisticalDataHeaders();
            return QueryYydNoticeMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋通知分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydNoticeMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydNoticeMonthStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydNoticeMonthStatisticalDataResponse> QueryYydNoticeMonthStatisticalDataAsync(QueryYydNoticeMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydNoticeMonthStatisticalDataHeaders headers = new QueryYydNoticeMonthStatisticalDataHeaders();
            return await QueryYydNoticeMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋通知分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydNoticeWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydNoticeWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydNoticeWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋通知分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydNoticeWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydNoticeWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydNoticeWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋通知分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydNoticeWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydNoticeWeekStatisticalDataResponse
        /// </returns>
        public QueryYydNoticeWeekStatisticalDataResponse QueryYydNoticeWeekStatisticalData(QueryYydNoticeWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydNoticeWeekStatisticalDataHeaders headers = new QueryYydNoticeWeekStatisticalDataHeaders();
            return QueryYydNoticeWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋通知分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydNoticeWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydNoticeWeekStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydNoticeWeekStatisticalDataResponse> QueryYydNoticeWeekStatisticalDataAsync(QueryYydNoticeWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydNoticeWeekStatisticalDataHeaders headers = new QueryYydNoticeWeekStatisticalDataHeaders();
            return await QueryYydNoticeWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋单聊分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydSingleMsgDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydSingleMsgDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydSingleMsgDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋单聊分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydSingleMsgDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydSingleMsgDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydSingleMsgDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋单聊分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydSingleMsgDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydSingleMsgDayStatisticalDataResponse
        /// </returns>
        public QueryYydSingleMsgDayStatisticalDataResponse QueryYydSingleMsgDayStatisticalData(QueryYydSingleMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydSingleMsgDayStatisticalDataHeaders headers = new QueryYydSingleMsgDayStatisticalDataHeaders();
            return QueryYydSingleMsgDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋单聊分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydSingleMsgDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydSingleMsgDayStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydSingleMsgDayStatisticalDataResponse> QueryYydSingleMsgDayStatisticalDataAsync(QueryYydSingleMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydSingleMsgDayStatisticalDataHeaders headers = new QueryYydSingleMsgDayStatisticalDataHeaders();
            return await QueryYydSingleMsgDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋单聊分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydSingleMsgMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydSingleMsgMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydSingleMsgMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋单聊分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydSingleMsgMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydSingleMsgMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydSingleMsgMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋单聊分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydSingleMsgMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydSingleMsgMonthStatisticalDataResponse
        /// </returns>
        public QueryYydSingleMsgMonthStatisticalDataResponse QueryYydSingleMsgMonthStatisticalData(QueryYydSingleMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydSingleMsgMonthStatisticalDataHeaders headers = new QueryYydSingleMsgMonthStatisticalDataHeaders();
            return QueryYydSingleMsgMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋单聊分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydSingleMsgMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydSingleMsgMonthStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydSingleMsgMonthStatisticalDataResponse> QueryYydSingleMsgMonthStatisticalDataAsync(QueryYydSingleMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydSingleMsgMonthStatisticalDataHeaders headers = new QueryYydSingleMsgMonthStatisticalDataHeaders();
            return await QueryYydSingleMsgMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋单聊分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydSingleMsgWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydSingleMsgWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydSingleMsgWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋单聊分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydSingleMsgWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydSingleMsgWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydSingleMsgWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋单聊分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydSingleMsgWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydSingleMsgWeekStatisticalDataResponse
        /// </returns>
        public QueryYydSingleMsgWeekStatisticalDataResponse QueryYydSingleMsgWeekStatisticalData(QueryYydSingleMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydSingleMsgWeekStatisticalDataHeaders headers = new QueryYydSingleMsgWeekStatisticalDataHeaders();
            return QueryYydSingleMsgWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋单聊分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydSingleMsgWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydSingleMsgWeekStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydSingleMsgWeekStatisticalDataResponse> QueryYydSingleMsgWeekStatisticalDataAsync(QueryYydSingleMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydSingleMsgWeekStatisticalDataHeaders headers = new QueryYydSingleMsgWeekStatisticalDataHeaders();
            return await QueryYydSingleMsgWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋消息概览（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydToatlMsgDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydToatlMsgDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydToatlMsgDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋消息概览（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydToatlMsgDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydToatlMsgDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydToatlMsgDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋消息概览（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydToatlMsgDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydToatlMsgDayStatisticalDataResponse
        /// </returns>
        public QueryYydToatlMsgDayStatisticalDataResponse QueryYydToatlMsgDayStatisticalData(QueryYydToatlMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydToatlMsgDayStatisticalDataHeaders headers = new QueryYydToatlMsgDayStatisticalDataHeaders();
            return QueryYydToatlMsgDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋消息概览（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydToatlMsgDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydToatlMsgDayStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydToatlMsgDayStatisticalDataResponse> QueryYydToatlMsgDayStatisticalDataAsync(QueryYydToatlMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydToatlMsgDayStatisticalDataHeaders headers = new QueryYydToatlMsgDayStatisticalDataHeaders();
            return await QueryYydToatlMsgDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋消息概览（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydToatlMsgMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydToatlMsgMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydToatlMsgMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋消息概览（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydToatlMsgMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydToatlMsgMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydToatlMsgMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋消息概览（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydToatlMsgMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydToatlMsgMonthStatisticalDataResponse
        /// </returns>
        public QueryYydToatlMsgMonthStatisticalDataResponse QueryYydToatlMsgMonthStatisticalData(QueryYydToatlMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydToatlMsgMonthStatisticalDataHeaders headers = new QueryYydToatlMsgMonthStatisticalDataHeaders();
            return QueryYydToatlMsgMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋消息概览（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydToatlMsgMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydToatlMsgMonthStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydToatlMsgMonthStatisticalDataResponse> QueryYydToatlMsgMonthStatisticalDataAsync(QueryYydToatlMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydToatlMsgMonthStatisticalDataHeaders headers = new QueryYydToatlMsgMonthStatisticalDataHeaders();
            return await QueryYydToatlMsgMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋消息概览（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydToatlMsgWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydToatlMsgWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydToatlMsgWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋消息概览（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydToatlMsgWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydToatlMsgWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydToatlMsgWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋消息概览（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydToatlMsgWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydToatlMsgWeekStatisticalDataResponse
        /// </returns>
        public QueryYydToatlMsgWeekStatisticalDataResponse QueryYydToatlMsgWeekStatisticalData(QueryYydToatlMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydToatlMsgWeekStatisticalDataHeaders headers = new QueryYydToatlMsgWeekStatisticalDataHeaders();
            return QueryYydToatlMsgWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋消息概览（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydToatlMsgWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydToatlMsgWeekStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydToatlMsgWeekStatisticalDataResponse> QueryYydToatlMsgWeekStatisticalDataAsync(QueryYydToatlMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydToatlMsgWeekStatisticalDataHeaders headers = new QueryYydToatlMsgWeekStatisticalDataHeaders();
            return await QueryYydToatlMsgWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋待办分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTodoDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydTodoDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTodoDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋待办分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTodoDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydTodoDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTodoDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋待办分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTodoDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTodoDayStatisticalDataResponse
        /// </returns>
        public QueryYydTodoDayStatisticalDataResponse QueryYydTodoDayStatisticalData(QueryYydTodoDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTodoDayStatisticalDataHeaders headers = new QueryYydTodoDayStatisticalDataHeaders();
            return QueryYydTodoDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋待办分析（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTodoDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTodoDayStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydTodoDayStatisticalDataResponse> QueryYydTodoDayStatisticalDataAsync(QueryYydTodoDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTodoDayStatisticalDataHeaders headers = new QueryYydTodoDayStatisticalDataHeaders();
            return await QueryYydTodoDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋待办分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTodoMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydTodoMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTodoMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋待办分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTodoMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydTodoMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTodoMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋待办分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTodoMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTodoMonthStatisticalDataResponse
        /// </returns>
        public QueryYydTodoMonthStatisticalDataResponse QueryYydTodoMonthStatisticalData(QueryYydTodoMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTodoMonthStatisticalDataHeaders headers = new QueryYydTodoMonthStatisticalDataHeaders();
            return QueryYydTodoMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋待办分析（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTodoMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTodoMonthStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydTodoMonthStatisticalDataResponse> QueryYydTodoMonthStatisticalDataAsync(QueryYydTodoMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTodoMonthStatisticalDataHeaders headers = new QueryYydTodoMonthStatisticalDataHeaders();
            return await QueryYydTodoMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋待办分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTodoWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydTodoWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTodoWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋待办分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTodoWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydTodoWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTodoWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋待办分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTodoWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTodoWeekStatisticalDataResponse
        /// </returns>
        public QueryYydTodoWeekStatisticalDataResponse QueryYydTodoWeekStatisticalData(QueryYydTodoWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTodoWeekStatisticalDataHeaders headers = new QueryYydTodoWeekStatisticalDataHeaders();
            return QueryYydTodoWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉数字参谋待办分析（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTodoWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTodoWeekStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydTodoWeekStatisticalDataResponse> QueryYydTodoWeekStatisticalDataAsync(QueryYydTodoWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTodoWeekStatisticalDataHeaders headers = new QueryYydTodoWeekStatisticalDataHeaders();
            return await QueryYydTodoWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋全局概览（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTotalDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydTotalDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTotalDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋全局概览（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTotalDayStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydTotalDayStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTotalDayStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋全局概览（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTotalDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTotalDayStatisticalDataResponse
        /// </returns>
        public QueryYydTotalDayStatisticalDataResponse QueryYydTotalDayStatisticalData(QueryYydTotalDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalDayStatisticalDataHeaders headers = new QueryYydTotalDayStatisticalDataHeaders();
            return QueryYydTotalDayStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋全局概览（按日统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTotalDayStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTotalDayStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydTotalDayStatisticalDataResponse> QueryYydTotalDayStatisticalDataAsync(QueryYydTotalDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalDayStatisticalDataHeaders headers = new QueryYydTotalDayStatisticalDataHeaders();
            return await QueryYydTotalDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋全局概览（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTotalMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydTotalMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTotalMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋全局概览（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTotalMonthStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydTotalMonthStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTotalMonthStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋全局概览（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTotalMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTotalMonthStatisticalDataResponse
        /// </returns>
        public QueryYydTotalMonthStatisticalDataResponse QueryYydTotalMonthStatisticalData(QueryYydTotalMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalMonthStatisticalDataHeaders headers = new QueryYydTotalMonthStatisticalDataHeaders();
            return QueryYydTotalMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋全局概览（按月统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTotalMonthStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTotalMonthStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydTotalMonthStatisticalDataResponse> QueryYydTotalMonthStatisticalDataAsync(QueryYydTotalMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalMonthStatisticalDataHeaders headers = new QueryYydTotalMonthStatisticalDataHeaders();
            return await QueryYydTotalMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋全局概览（累计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTotalStdStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydTotalStdStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTotalStdStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋全局概览（累计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTotalStdStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydTotalStdStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTotalStdStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋全局概览（累计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTotalStdStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTotalStdStatisticalDataResponse
        /// </returns>
        public QueryYydTotalStdStatisticalDataResponse QueryYydTotalStdStatisticalData(QueryYydTotalStdStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalStdStatisticalDataHeaders headers = new QueryYydTotalStdStatisticalDataHeaders();
            return QueryYydTotalStdStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋全局概览（累计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTotalStdStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTotalStdStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydTotalStdStatisticalDataResponse> QueryYydTotalStdStatisticalDataAsync(QueryYydTotalStdStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalStdStatisticalDataHeaders headers = new QueryYydTotalStdStatisticalDataHeaders();
            return await QueryYydTotalStdStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋全局概览（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTotalWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydTotalWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTotalWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋全局概览（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTotalWeekStatisticalDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryYydTotalWeekStatisticalDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTotalWeekStatisticalDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋全局概览（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTotalWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTotalWeekStatisticalDataResponse
        /// </returns>
        public QueryYydTotalWeekStatisticalDataResponse QueryYydTotalWeekStatisticalData(QueryYydTotalWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalWeekStatisticalDataHeaders headers = new QueryYydTotalWeekStatisticalDataHeaders();
            return QueryYydTotalWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>亚运钉参谋全局概览（按周统计）指标接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryYydTotalWeekStatisticalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryYydTotalWeekStatisticalDataResponse
        /// </returns>
        public async Task<QueryYydTotalWeekStatisticalDataResponse> QueryYydTotalWeekStatisticalDataAsync(QueryYydTotalWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalWeekStatisticalDataHeaders headers = new QueryYydTotalWeekStatisticalDataHeaders();
            return await QueryYydTotalWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键词搜索企业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchCompanyRequest
        /// </param>
        /// <param name="headers">
        /// SearchCompanyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchCompanyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键词搜索企业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchCompanyRequest
        /// </param>
        /// <param name="headers">
        /// SearchCompanyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchCompanyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键词搜索企业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchCompanyRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchCompanyResponse
        /// </returns>
        public SearchCompanyResponse SearchCompany(SearchCompanyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchCompanyHeaders headers = new SearchCompanyHeaders();
            return SearchCompanyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键词搜索企业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchCompanyRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchCompanyResponse
        /// </returns>
        public async Task<SearchCompanyResponse> SearchCompanyAsync(SearchCompanyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchCompanyHeaders headers = new SearchCompanyHeaders();
            return await SearchCompanyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步数据大屏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncDataScreenRequest
        /// </param>
        /// <param name="headers">
        /// SyncDataScreenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncDataScreenResponse
        /// </returns>
        public SyncDataScreenResponse SyncDataScreenWithOptions(SyncDataScreenRequest request, SyncDataScreenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScreenId))
            {
                body["screenId"] = request.ScreenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                body["ticket"] = request.Ticket;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncDataScreen",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dataScreens/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncDataScreenResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步数据大屏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncDataScreenRequest
        /// </param>
        /// <param name="headers">
        /// SyncDataScreenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncDataScreenResponse
        /// </returns>
        public async Task<SyncDataScreenResponse> SyncDataScreenWithOptionsAsync(SyncDataScreenRequest request, SyncDataScreenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScreenId))
            {
                body["screenId"] = request.ScreenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                body["ticket"] = request.Ticket;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncDataScreen",
                Version = "datacenter_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/datacenter/dataScreens/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncDataScreenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步数据大屏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncDataScreenRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncDataScreenResponse
        /// </returns>
        public SyncDataScreenResponse SyncDataScreen(SyncDataScreenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncDataScreenHeaders headers = new SyncDataScreenHeaders();
            return SyncDataScreenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步数据大屏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncDataScreenRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncDataScreenResponse
        /// </returns>
        public async Task<SyncDataScreenResponse> SyncDataScreenAsync(SyncDataScreenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncDataScreenHeaders headers = new SyncDataScreenHeaders();
            return await SyncDataScreenWithOptionsAsync(request, headers, runtime);
        }

    }
}
