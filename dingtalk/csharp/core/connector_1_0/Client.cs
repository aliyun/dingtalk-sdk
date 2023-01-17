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

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public CreateActionResponse CreateAction(CreateActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateActionHeaders headers = new CreateActionHeaders();
            return CreateActionWithOptions(request, headers, runtime);
        }

        public async Task<CreateActionResponse> CreateActionAsync(CreateActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateActionHeaders headers = new CreateActionHeaders();
            return await CreateActionWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<CreateActionResponse>(DoROARequest("CreateAction", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/actions", "json", req, runtime));
        }

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
            return TeaModel.ToObject<CreateActionResponse>(await DoROARequestAsync("CreateAction", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/actions", "json", req, runtime));
        }

        public CreateConnectorResponse CreateConnector(CreateConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateConnectorHeaders headers = new CreateConnectorHeaders();
            return CreateConnectorWithOptions(request, headers, runtime);
        }

        public async Task<CreateConnectorResponse> CreateConnectorAsync(CreateConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateConnectorHeaders headers = new CreateConnectorHeaders();
            return await CreateConnectorWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<CreateConnectorResponse>(DoROARequest("CreateConnector", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/connectors", "json", req, runtime));
        }

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
            return TeaModel.ToObject<CreateConnectorResponse>(await DoROARequestAsync("CreateConnector", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/connectors", "json", req, runtime));
        }

        public CreateInvocableInstanceResponse CreateInvocableInstance(CreateInvocableInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateInvocableInstanceHeaders headers = new CreateInvocableInstanceHeaders();
            return CreateInvocableInstanceWithOptions(request, headers, runtime);
        }

        public async Task<CreateInvocableInstanceResponse> CreateInvocableInstanceAsync(CreateInvocableInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateInvocableInstanceHeaders headers = new CreateInvocableInstanceHeaders();
            return await CreateInvocableInstanceWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<CreateInvocableInstanceResponse>(DoROARequest("CreateInvocableInstance", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/instances", "json", req, runtime));
        }

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
            return TeaModel.ToObject<CreateInvocableInstanceResponse>(await DoROARequestAsync("CreateInvocableInstance", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/instances", "json", req, runtime));
        }

        public CreateTriggerResponse CreateTrigger(CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTriggerHeaders headers = new CreateTriggerHeaders();
            return CreateTriggerWithOptions(request, headers, runtime);
        }

        public async Task<CreateTriggerResponse> CreateTriggerAsync(CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTriggerHeaders headers = new CreateTriggerHeaders();
            return await CreateTriggerWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<CreateTriggerResponse>(DoROARequest("CreateTrigger", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/triggers", "json", req, runtime));
        }

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
            return TeaModel.ToObject<CreateTriggerResponse>(await DoROARequestAsync("CreateTrigger", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/triggers", "json", req, runtime));
        }

        public GetActionDetailResponse GetActionDetail(GetActionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetActionDetailHeaders headers = new GetActionDetailHeaders();
            return GetActionDetailWithOptions(request, headers, runtime);
        }

        public async Task<GetActionDetailResponse> GetActionDetailAsync(GetActionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetActionDetailHeaders headers = new GetActionDetailHeaders();
            return await GetActionDetailWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<GetActionDetailResponse>(DoROARequest("GetActionDetail", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/assets/actions/details/query", "json", req, runtime));
        }

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
            return TeaModel.ToObject<GetActionDetailResponse>(await DoROARequestAsync("GetActionDetail", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/assets/actions/details/query", "json", req, runtime));
        }

        public InvokeInstanceResponse InvokeInstance(InvokeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvokeInstanceHeaders headers = new InvokeInstanceHeaders();
            return InvokeInstanceWithOptions(request, headers, runtime);
        }

        public async Task<InvokeInstanceResponse> InvokeInstanceAsync(InvokeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvokeInstanceHeaders headers = new InvokeInstanceHeaders();
            return await InvokeInstanceWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<InvokeInstanceResponse>(DoROARequest("InvokeInstance", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/instances/invoke", "json", req, runtime));
        }

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
            return TeaModel.ToObject<InvokeInstanceResponse>(await DoROARequestAsync("InvokeInstance", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/instances/invoke", "json", req, runtime));
        }

        public PullDataByPageResponse PullDataByPage(PullDataByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PullDataByPageHeaders headers = new PullDataByPageHeaders();
            return PullDataByPageWithOptions(request, headers, runtime);
        }

        public async Task<PullDataByPageResponse> PullDataByPageAsync(PullDataByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PullDataByPageHeaders headers = new PullDataByPageHeaders();
            return await PullDataByPageWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<PullDataByPageResponse>(DoROARequest("PullDataByPage", "connector_1.0", "HTTP", "GET", "AK", "/v1.0/connector/data", "json", req, runtime));
        }

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
            return TeaModel.ToObject<PullDataByPageResponse>(await DoROARequestAsync("PullDataByPage", "connector_1.0", "HTTP", "GET", "AK", "/v1.0/connector/data", "json", req, runtime));
        }

        public PullDataByPkResponse PullDataByPk(string dataModelId, PullDataByPkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PullDataByPkHeaders headers = new PullDataByPkHeaders();
            return PullDataByPkWithOptions(dataModelId, request, headers, runtime);
        }

        public async Task<PullDataByPkResponse> PullDataByPkAsync(string dataModelId, PullDataByPkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PullDataByPkHeaders headers = new PullDataByPkHeaders();
            return await PullDataByPkWithOptionsAsync(dataModelId, request, headers, runtime);
        }

        public PullDataByPkResponse PullDataByPkWithOptions(string dataModelId, PullDataByPkRequest request, PullDataByPkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            dataModelId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataModelId);
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
            return TeaModel.ToObject<PullDataByPkResponse>(DoROARequest("PullDataByPk", "connector_1.0", "HTTP", "GET", "AK", "/v1.0/connector/data/" + dataModelId, "json", req, runtime));
        }

        public async Task<PullDataByPkResponse> PullDataByPkWithOptionsAsync(string dataModelId, PullDataByPkRequest request, PullDataByPkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            dataModelId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataModelId);
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
            return TeaModel.ToObject<PullDataByPkResponse>(await DoROARequestAsync("PullDataByPk", "connector_1.0", "HTTP", "GET", "AK", "/v1.0/connector/data/" + dataModelId, "json", req, runtime));
        }

        public SearchActionsResponse SearchActions(SearchActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchActionsHeaders headers = new SearchActionsHeaders();
            return SearchActionsWithOptions(request, headers, runtime);
        }

        public async Task<SearchActionsResponse> SearchActionsAsync(SearchActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchActionsHeaders headers = new SearchActionsHeaders();
            return await SearchActionsWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<SearchActionsResponse>(DoROARequest("SearchActions", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/assets/actions/search", "json", req, runtime));
        }

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
            return TeaModel.ToObject<SearchActionsResponse>(await DoROARequestAsync("SearchActions", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/assets/actions/search", "json", req, runtime));
        }

        public SearchConnectorsResponse SearchConnectors(SearchConnectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchConnectorsHeaders headers = new SearchConnectorsHeaders();
            return SearchConnectorsWithOptions(request, headers, runtime);
        }

        public async Task<SearchConnectorsResponse> SearchConnectorsAsync(SearchConnectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchConnectorsHeaders headers = new SearchConnectorsHeaders();
            return await SearchConnectorsWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<SearchConnectorsResponse>(DoROARequest("SearchConnectors", "connector_1.0", "HTTP", "GET", "AK", "/v1.0/connector/assets/connectors", "json", req, runtime));
        }

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
            return TeaModel.ToObject<SearchConnectorsResponse>(await DoROARequestAsync("SearchConnectors", "connector_1.0", "HTTP", "GET", "AK", "/v1.0/connector/assets/connectors", "json", req, runtime));
        }

        public SyncDataResponse SyncData(SyncDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncDataHeaders headers = new SyncDataHeaders();
            return SyncDataWithOptions(request, headers, runtime);
        }

        public async Task<SyncDataResponse> SyncDataAsync(SyncDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncDataHeaders headers = new SyncDataHeaders();
            return await SyncDataWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<SyncDataResponse>(DoROARequest("SyncData", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/triggers/data/sync", "json", req, runtime));
        }

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
            return TeaModel.ToObject<SyncDataResponse>(await DoROARequestAsync("SyncData", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/triggers/data/sync", "json", req, runtime));
        }

        public UpdateActionResponse UpdateAction(UpdateActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateActionHeaders headers = new UpdateActionHeaders();
            return UpdateActionWithOptions(request, headers, runtime);
        }

        public async Task<UpdateActionResponse> UpdateActionAsync(UpdateActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateActionHeaders headers = new UpdateActionHeaders();
            return await UpdateActionWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<UpdateActionResponse>(DoROARequest("UpdateAction", "connector_1.0", "HTTP", "PUT", "AK", "/v1.0/connector/actions", "json", req, runtime));
        }

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
            return TeaModel.ToObject<UpdateActionResponse>(await DoROARequestAsync("UpdateAction", "connector_1.0", "HTTP", "PUT", "AK", "/v1.0/connector/actions", "json", req, runtime));
        }

        public UpdateConnectorResponse UpdateConnector(UpdateConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateConnectorHeaders headers = new UpdateConnectorHeaders();
            return UpdateConnectorWithOptions(request, headers, runtime);
        }

        public async Task<UpdateConnectorResponse> UpdateConnectorAsync(UpdateConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateConnectorHeaders headers = new UpdateConnectorHeaders();
            return await UpdateConnectorWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<UpdateConnectorResponse>(DoROARequest("UpdateConnector", "connector_1.0", "HTTP", "PUT", "AK", "/v1.0/connector/connectors", "json", req, runtime));
        }

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
            return TeaModel.ToObject<UpdateConnectorResponse>(await DoROARequestAsync("UpdateConnector", "connector_1.0", "HTTP", "PUT", "AK", "/v1.0/connector/connectors", "json", req, runtime));
        }

        public UpdateTriggerResponse UpdateTrigger(UpdateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTriggerHeaders headers = new UpdateTriggerHeaders();
            return UpdateTriggerWithOptions(request, headers, runtime);
        }

        public async Task<UpdateTriggerResponse> UpdateTriggerAsync(UpdateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTriggerHeaders headers = new UpdateTriggerHeaders();
            return await UpdateTriggerWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<UpdateTriggerResponse>(DoROARequest("UpdateTrigger", "connector_1.0", "HTTP", "PUT", "AK", "/v1.0/connector/triggers", "json", req, runtime));
        }

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
            return TeaModel.ToObject<UpdateTriggerResponse>(await DoROARequestAsync("UpdateTrigger", "connector_1.0", "HTTP", "PUT", "AK", "/v1.0/connector/triggers", "json", req, runtime));
        }

    }
}
