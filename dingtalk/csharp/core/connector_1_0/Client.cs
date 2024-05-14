// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkconnector_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {
        protected AlibabaCloud.GatewaySpi.Client _client;

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._client = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = _client;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 创建执行动作
         *
         * @param request CreateActionRequest
         * @param headers CreateActionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateActionResponse
         */
        public CreateActionResponse CreateActionWithOptions(CreateActionRequest request, CreateActionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionInfo))
            {
                body["actionInfo"] = request.ActionInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegratorFlag))
            {
                body["integratorFlag"] = request.IntegratorFlag;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAction",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/actions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateActionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建执行动作
         *
         * @param request CreateActionRequest
         * @param headers CreateActionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateActionResponse
         */
        public async Task<CreateActionResponse> CreateActionWithOptionsAsync(CreateActionRequest request, CreateActionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionInfo))
            {
                body["actionInfo"] = request.ActionInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegratorFlag))
            {
                body["integratorFlag"] = request.IntegratorFlag;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAction",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/actions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateActionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建执行动作
         *
         * @param request CreateActionRequest
         * @return CreateActionResponse
         */
        public CreateActionResponse CreateAction(CreateActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateActionHeaders headers = new CreateActionHeaders();
            return CreateActionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建执行动作
         *
         * @param request CreateActionRequest
         * @return CreateActionResponse
         */
        public async Task<CreateActionResponse> CreateActionAsync(CreateActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateActionHeaders headers = new CreateActionHeaders();
            return await CreateActionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建连接器
         *
         * @param request CreateConnectorRequest
         * @param headers CreateConnectorHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConnectorResponse
         */
        public CreateConnectorResponse CreateConnectorWithOptions(CreateConnectorRequest request, CreateConnectorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorInfo))
            {
                body["connectorInfo"] = request.ConnectorInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegratorFlag))
            {
                body["integratorFlag"] = request.IntegratorFlag;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConnector",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/connectors",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConnectorResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建连接器
         *
         * @param request CreateConnectorRequest
         * @param headers CreateConnectorHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConnectorResponse
         */
        public async Task<CreateConnectorResponse> CreateConnectorWithOptionsAsync(CreateConnectorRequest request, CreateConnectorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorInfo))
            {
                body["connectorInfo"] = request.ConnectorInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegratorFlag))
            {
                body["integratorFlag"] = request.IntegratorFlag;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConnector",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/connectors",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConnectorResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建连接器
         *
         * @param request CreateConnectorRequest
         * @return CreateConnectorResponse
         */
        public CreateConnectorResponse CreateConnector(CreateConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateConnectorHeaders headers = new CreateConnectorHeaders();
            return CreateConnectorWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建连接器
         *
         * @param request CreateConnectorRequest
         * @return CreateConnectorResponse
         */
        public async Task<CreateConnectorResponse> CreateConnectorAsync(CreateConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateConnectorHeaders headers = new CreateConnectorHeaders();
            return await CreateConnectorWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建一个用于运行执行动作/集成流的可调用实例
         *
         * @param request CreateInvocableInstanceRequest
         * @param headers CreateInvocableInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInvocableInstanceResponse
         */
        public CreateInvocableInstanceResponse CreateInvocableInstanceWithOptions(CreateInvocableInstanceRequest request, CreateInvocableInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectAssetUri))
            {
                body["connectAssetUri"] = request.ConnectAssetUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceKey))
            {
                body["instanceKey"] = request.InstanceKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInvocableInstance",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInvocableInstanceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建一个用于运行执行动作/集成流的可调用实例
         *
         * @param request CreateInvocableInstanceRequest
         * @param headers CreateInvocableInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInvocableInstanceResponse
         */
        public async Task<CreateInvocableInstanceResponse> CreateInvocableInstanceWithOptionsAsync(CreateInvocableInstanceRequest request, CreateInvocableInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectAssetUri))
            {
                body["connectAssetUri"] = request.ConnectAssetUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceKey))
            {
                body["instanceKey"] = request.InstanceKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInvocableInstance",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInvocableInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建一个用于运行执行动作/集成流的可调用实例
         *
         * @param request CreateInvocableInstanceRequest
         * @return CreateInvocableInstanceResponse
         */
        public CreateInvocableInstanceResponse CreateInvocableInstance(CreateInvocableInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateInvocableInstanceHeaders headers = new CreateInvocableInstanceHeaders();
            return CreateInvocableInstanceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建一个用于运行执行动作/集成流的可调用实例
         *
         * @param request CreateInvocableInstanceRequest
         * @return CreateInvocableInstanceResponse
         */
        public async Task<CreateInvocableInstanceResponse> CreateInvocableInstanceAsync(CreateInvocableInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateInvocableInstanceHeaders headers = new CreateInvocableInstanceHeaders();
            return await CreateInvocableInstanceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建触发器
         *
         * @param request CreateTriggerRequest
         * @param headers CreateTriggerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTriggerResponse
         */
        public CreateTriggerResponse CreateTriggerWithOptions(CreateTriggerRequest request, CreateTriggerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegratorFlag))
            {
                body["integratorFlag"] = request.IntegratorFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerInfo))
            {
                body["triggerInfo"] = request.TriggerInfo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrigger",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/triggers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTriggerResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建触发器
         *
         * @param request CreateTriggerRequest
         * @param headers CreateTriggerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTriggerResponse
         */
        public async Task<CreateTriggerResponse> CreateTriggerWithOptionsAsync(CreateTriggerRequest request, CreateTriggerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegratorFlag))
            {
                body["integratorFlag"] = request.IntegratorFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerInfo))
            {
                body["triggerInfo"] = request.TriggerInfo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrigger",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/triggers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTriggerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建触发器
         *
         * @param request CreateTriggerRequest
         * @return CreateTriggerResponse
         */
        public CreateTriggerResponse CreateTrigger(CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTriggerHeaders headers = new CreateTriggerHeaders();
            return CreateTriggerWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建触发器
         *
         * @param request CreateTriggerRequest
         * @return CreateTriggerResponse
         */
        public async Task<CreateTriggerResponse> CreateTriggerAsync(CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTriggerHeaders headers = new CreateTriggerHeaders();
            return await CreateTriggerWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取执行动作详情
         *
         * @param request GetActionDetailRequest
         * @param headers GetActionDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetActionDetailResponse
         */
        public GetActionDetailResponse GetActionDetailWithOptions(GetActionDetailRequest request, GetActionDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectAssetUri))
            {
                body["connectAssetUri"] = request.ConnectAssetUri;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetActionDetail",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/assets/actions/details/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetActionDetailResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取执行动作详情
         *
         * @param request GetActionDetailRequest
         * @param headers GetActionDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetActionDetailResponse
         */
        public async Task<GetActionDetailResponse> GetActionDetailWithOptionsAsync(GetActionDetailRequest request, GetActionDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectAssetUri))
            {
                body["connectAssetUri"] = request.ConnectAssetUri;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetActionDetail",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/assets/actions/details/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetActionDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取执行动作详情
         *
         * @param request GetActionDetailRequest
         * @return GetActionDetailResponse
         */
        public GetActionDetailResponse GetActionDetail(GetActionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetActionDetailHeaders headers = new GetActionDetailHeaders();
            return GetActionDetailWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取执行动作详情
         *
         * @param request GetActionDetailRequest
         * @return GetActionDetailResponse
         */
        public async Task<GetActionDetailResponse> GetActionDetailAsync(GetActionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetActionDetailHeaders headers = new GetActionDetailHeaders();
            return await GetActionDetailWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 调用执行实例
         *
         * @param request InvokeInstanceRequest
         * @param headers InvokeInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InvokeInstanceResponse
         */
        public InvokeInstanceResponse InvokeInstanceWithOptions(InvokeInstanceRequest request, InvokeInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectAssetUri))
            {
                body["connectAssetUri"] = request.ConnectAssetUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputJsonString))
            {
                body["inputJsonString"] = request.InputJsonString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceKey))
            {
                body["instanceKey"] = request.InstanceKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokeInstance",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/instances/invoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokeInstanceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 调用执行实例
         *
         * @param request InvokeInstanceRequest
         * @param headers InvokeInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InvokeInstanceResponse
         */
        public async Task<InvokeInstanceResponse> InvokeInstanceWithOptionsAsync(InvokeInstanceRequest request, InvokeInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectAssetUri))
            {
                body["connectAssetUri"] = request.ConnectAssetUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputJsonString))
            {
                body["inputJsonString"] = request.InputJsonString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceKey))
            {
                body["instanceKey"] = request.InstanceKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokeInstance",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/instances/invoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokeInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 调用执行实例
         *
         * @param request InvokeInstanceRequest
         * @return InvokeInstanceResponse
         */
        public InvokeInstanceResponse InvokeInstance(InvokeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvokeInstanceHeaders headers = new InvokeInstanceHeaders();
            return InvokeInstanceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 调用执行实例
         *
         * @param request InvokeInstanceRequest
         * @return InvokeInstanceResponse
         */
        public async Task<InvokeInstanceResponse> InvokeInstanceAsync(InvokeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvokeInstanceHeaders headers = new InvokeInstanceHeaders();
            return await InvokeInstanceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 分页拉取连接器主数据
         *
         * @param request PullDataByPageRequest
         * @param headers PullDataByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PullDataByPageResponse
         */
        public PullDataByPageResponse PullDataByPageWithOptions(PullDataByPageRequest request, PullDataByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataModelId))
            {
                query["dataModelId"] = request.DataModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatetimeFilterField))
            {
                query["datetimeFilterField"] = request.DatetimeFilterField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDatetime))
            {
                query["maxDatetime"] = request.MaxDatetime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDatetime))
            {
                query["minDatetime"] = request.MinDatetime;
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
                Action = "PullDataByPage",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/data",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PullDataByPageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 分页拉取连接器主数据
         *
         * @param request PullDataByPageRequest
         * @param headers PullDataByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PullDataByPageResponse
         */
        public async Task<PullDataByPageResponse> PullDataByPageWithOptionsAsync(PullDataByPageRequest request, PullDataByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataModelId))
            {
                query["dataModelId"] = request.DataModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatetimeFilterField))
            {
                query["datetimeFilterField"] = request.DatetimeFilterField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDatetime))
            {
                query["maxDatetime"] = request.MaxDatetime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDatetime))
            {
                query["minDatetime"] = request.MinDatetime;
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
                Action = "PullDataByPage",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/data",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PullDataByPageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 分页拉取连接器主数据
         *
         * @param request PullDataByPageRequest
         * @return PullDataByPageResponse
         */
        public PullDataByPageResponse PullDataByPage(PullDataByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PullDataByPageHeaders headers = new PullDataByPageHeaders();
            return PullDataByPageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 分页拉取连接器主数据
         *
         * @param request PullDataByPageRequest
         * @return PullDataByPageResponse
         */
        public async Task<PullDataByPageResponse> PullDataByPageAsync(PullDataByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PullDataByPageHeaders headers = new PullDataByPageHeaders();
            return await PullDataByPageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 通过业务主键拉取单条连接器主数据
         *
         * @param request PullDataByPkRequest
         * @param headers PullDataByPkHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PullDataByPkResponse
         */
        public PullDataByPkResponse PullDataByPkWithOptions(string dataModelId, PullDataByPkRequest request, PullDataByPkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryKey))
            {
                query["primaryKey"] = request.PrimaryKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PullDataByPk",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/data/" + dataModelId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PullDataByPkResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 通过业务主键拉取单条连接器主数据
         *
         * @param request PullDataByPkRequest
         * @param headers PullDataByPkHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PullDataByPkResponse
         */
        public async Task<PullDataByPkResponse> PullDataByPkWithOptionsAsync(string dataModelId, PullDataByPkRequest request, PullDataByPkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryKey))
            {
                query["primaryKey"] = request.PrimaryKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PullDataByPk",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/data/" + dataModelId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PullDataByPkResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 通过业务主键拉取单条连接器主数据
         *
         * @param request PullDataByPkRequest
         * @return PullDataByPkResponse
         */
        public PullDataByPkResponse PullDataByPk(string dataModelId, PullDataByPkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PullDataByPkHeaders headers = new PullDataByPkHeaders();
            return PullDataByPkWithOptions(dataModelId, request, headers, runtime);
        }

        /**
         * @summary 通过业务主键拉取单条连接器主数据
         *
         * @param request PullDataByPkRequest
         * @return PullDataByPkResponse
         */
        public async Task<PullDataByPkResponse> PullDataByPkAsync(string dataModelId, PullDataByPkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PullDataByPkHeaders headers = new PullDataByPkHeaders();
            return await PullDataByPkWithOptionsAsync(dataModelId, request, headers, runtime);
        }

        /**
         * @summary 搜索执行动作
         *
         * @param request SearchActionsRequest
         * @param headers SearchActionsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchActionsResponse
         */
        public SearchActionsResponse SearchActionsWithOptions(SearchActionsRequest request, SearchActionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                body["connectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorProviderCorpId))
            {
                body["connectorProviderCorpId"] = request.ConnectorProviderCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationTypes))
            {
                body["integrationTypes"] = request.IntegrationTypes;
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
                Action = "SearchActions",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/assets/actions/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchActionsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 搜索执行动作
         *
         * @param request SearchActionsRequest
         * @param headers SearchActionsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchActionsResponse
         */
        public async Task<SearchActionsResponse> SearchActionsWithOptionsAsync(SearchActionsRequest request, SearchActionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                body["connectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorProviderCorpId))
            {
                body["connectorProviderCorpId"] = request.ConnectorProviderCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrationTypes))
            {
                body["integrationTypes"] = request.IntegrationTypes;
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
                Action = "SearchActions",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/assets/actions/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchActionsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 搜索执行动作
         *
         * @param request SearchActionsRequest
         * @return SearchActionsResponse
         */
        public SearchActionsResponse SearchActions(SearchActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchActionsHeaders headers = new SearchActionsHeaders();
            return SearchActionsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 搜索执行动作
         *
         * @param request SearchActionsRequest
         * @return SearchActionsResponse
         */
        public async Task<SearchActionsResponse> SearchActionsAsync(SearchActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchActionsHeaders headers = new SearchActionsHeaders();
            return await SearchActionsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 搜索连接器
         *
         * @param request SearchConnectorsRequest
         * @param headers SearchConnectorsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchConnectorsResponse
         */
        public SearchConnectorsResponse SearchConnectorsWithOptions(SearchConnectorsRequest request, SearchConnectorsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SearchConnectors",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/assets/connectors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchConnectorsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 搜索连接器
         *
         * @param request SearchConnectorsRequest
         * @param headers SearchConnectorsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchConnectorsResponse
         */
        public async Task<SearchConnectorsResponse> SearchConnectorsWithOptionsAsync(SearchConnectorsRequest request, SearchConnectorsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SearchConnectors",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/assets/connectors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchConnectorsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 搜索连接器
         *
         * @param request SearchConnectorsRequest
         * @return SearchConnectorsResponse
         */
        public SearchConnectorsResponse SearchConnectors(SearchConnectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchConnectorsHeaders headers = new SearchConnectorsHeaders();
            return SearchConnectorsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 搜索连接器
         *
         * @param request SearchConnectorsRequest
         * @return SearchConnectorsResponse
         */
        public async Task<SearchConnectorsResponse> SearchConnectorsAsync(SearchConnectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchConnectorsHeaders headers = new SearchConnectorsHeaders();
            return await SearchConnectorsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 同步连接器数据
         *
         * @param request SyncDataRequest
         * @param headers SyncDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncDataResponse
         */
        public SyncDataResponse SyncDataWithOptions(SyncDataRequest request, SyncDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerDataList))
            {
                body["triggerDataList"] = request.TriggerDataList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncData",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/triggers/data/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncDataResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 同步连接器数据
         *
         * @param request SyncDataRequest
         * @param headers SyncDataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncDataResponse
         */
        public async Task<SyncDataResponse> SyncDataWithOptionsAsync(SyncDataRequest request, SyncDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerDataList))
            {
                body["triggerDataList"] = request.TriggerDataList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncData",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/triggers/data/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 同步连接器数据
         *
         * @param request SyncDataRequest
         * @return SyncDataResponse
         */
        public SyncDataResponse SyncData(SyncDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncDataHeaders headers = new SyncDataHeaders();
            return SyncDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 同步连接器数据
         *
         * @param request SyncDataRequest
         * @return SyncDataResponse
         */
        public async Task<SyncDataResponse> SyncDataAsync(SyncDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncDataHeaders headers = new SyncDataHeaders();
            return await SyncDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新执行动作信息
         *
         * @param request UpdateActionRequest
         * @param headers UpdateActionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateActionResponse
         */
        public UpdateActionResponse UpdateActionWithOptions(UpdateActionRequest request, UpdateActionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionInfo))
            {
                body["actionInfo"] = request.ActionInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegratorFlag))
            {
                body["integratorFlag"] = request.IntegratorFlag;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAction",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/actions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateActionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新执行动作信息
         *
         * @param request UpdateActionRequest
         * @param headers UpdateActionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateActionResponse
         */
        public async Task<UpdateActionResponse> UpdateActionWithOptionsAsync(UpdateActionRequest request, UpdateActionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionInfo))
            {
                body["actionInfo"] = request.ActionInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegratorFlag))
            {
                body["integratorFlag"] = request.IntegratorFlag;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAction",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/actions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateActionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新执行动作信息
         *
         * @param request UpdateActionRequest
         * @return UpdateActionResponse
         */
        public UpdateActionResponse UpdateAction(UpdateActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateActionHeaders headers = new UpdateActionHeaders();
            return UpdateActionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新执行动作信息
         *
         * @param request UpdateActionRequest
         * @return UpdateActionResponse
         */
        public async Task<UpdateActionResponse> UpdateActionAsync(UpdateActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateActionHeaders headers = new UpdateActionHeaders();
            return await UpdateActionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新连接器信息
         *
         * @param request UpdateConnectorRequest
         * @param headers UpdateConnectorHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateConnectorResponse
         */
        public UpdateConnectorResponse UpdateConnectorWithOptions(UpdateConnectorRequest request, UpdateConnectorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorInfo))
            {
                body["connectorInfo"] = request.ConnectorInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegratorFlag))
            {
                body["integratorFlag"] = request.IntegratorFlag;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConnector",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/connectors",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConnectorResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新连接器信息
         *
         * @param request UpdateConnectorRequest
         * @param headers UpdateConnectorHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateConnectorResponse
         */
        public async Task<UpdateConnectorResponse> UpdateConnectorWithOptionsAsync(UpdateConnectorRequest request, UpdateConnectorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorInfo))
            {
                body["connectorInfo"] = request.ConnectorInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegratorFlag))
            {
                body["integratorFlag"] = request.IntegratorFlag;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConnector",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/connectors",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConnectorResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新连接器信息
         *
         * @param request UpdateConnectorRequest
         * @return UpdateConnectorResponse
         */
        public UpdateConnectorResponse UpdateConnector(UpdateConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateConnectorHeaders headers = new UpdateConnectorHeaders();
            return UpdateConnectorWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新连接器信息
         *
         * @param request UpdateConnectorRequest
         * @return UpdateConnectorResponse
         */
        public async Task<UpdateConnectorResponse> UpdateConnectorAsync(UpdateConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateConnectorHeaders headers = new UpdateConnectorHeaders();
            return await UpdateConnectorWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新触发事件信息
         *
         * @param request UpdateTriggerRequest
         * @param headers UpdateTriggerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTriggerResponse
         */
        public UpdateTriggerResponse UpdateTriggerWithOptions(UpdateTriggerRequest request, UpdateTriggerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegratorFlag))
            {
                body["integratorFlag"] = request.IntegratorFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerInfo))
            {
                body["triggerInfo"] = request.TriggerInfo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrigger",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/triggers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTriggerResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新触发事件信息
         *
         * @param request UpdateTriggerRequest
         * @param headers UpdateTriggerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTriggerResponse
         */
        public async Task<UpdateTriggerResponse> UpdateTriggerWithOptionsAsync(UpdateTriggerRequest request, UpdateTriggerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegratorFlag))
            {
                body["integratorFlag"] = request.IntegratorFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerInfo))
            {
                body["triggerInfo"] = request.TriggerInfo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrigger",
                Version = "connector_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/connector/triggers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTriggerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新触发事件信息
         *
         * @param request UpdateTriggerRequest
         * @return UpdateTriggerResponse
         */
        public UpdateTriggerResponse UpdateTrigger(UpdateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTriggerHeaders headers = new UpdateTriggerHeaders();
            return UpdateTriggerWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新触发事件信息
         *
         * @param request UpdateTriggerRequest
         * @return UpdateTriggerResponse
         */
        public async Task<UpdateTriggerResponse> UpdateTriggerAsync(UpdateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTriggerHeaders headers = new UpdateTriggerHeaders();
            return await UpdateTriggerWithOptionsAsync(request, headers, runtime);
        }

    }
}
