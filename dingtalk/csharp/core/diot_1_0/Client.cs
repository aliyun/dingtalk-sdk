// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkdiot_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0
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
         * @summary openAPI录入上线前的测试2
         *
         * @param request AyunOnlienTestRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AyunOnlienTestResponse
         */
        public AyunOnlienTestResponse AyunOnlienTestWithOptions(AyunOnlienTestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["reqId"] = request.ReqId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AyunOnlienTest",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/ayunTest",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AyunOnlienTestResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary openAPI录入上线前的测试2
         *
         * @param request AyunOnlienTestRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AyunOnlienTestResponse
         */
        public async Task<AyunOnlienTestResponse> AyunOnlienTestWithOptionsAsync(AyunOnlienTestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["reqId"] = request.ReqId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AyunOnlienTest",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/ayunTest",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AyunOnlienTestResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary openAPI录入上线前的测试2
         *
         * @param request AyunOnlienTestRequest
         * @return AyunOnlienTestResponse
         */
        public AyunOnlienTestResponse AyunOnlienTest(AyunOnlienTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AyunOnlienTestWithOptions(request, headers, runtime);
        }

        /**
         * @summary openAPI录入上线前的测试2
         *
         * @param request AyunOnlienTestRequest
         * @return AyunOnlienTestResponse
         */
        public async Task<AyunOnlienTestResponse> AyunOnlienTestAsync(AyunOnlienTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AyunOnlienTestWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除设备
         *
         * @param request BatchDeleteDeviceRequest
         * @param headers BatchDeleteDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchDeleteDeviceResponse
         */
        public BatchDeleteDeviceResponse BatchDeleteDeviceWithOptions(BatchDeleteDeviceRequest request, BatchDeleteDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIds))
            {
                body["deviceIds"] = request.DeviceIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchDeleteDevice",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/devices/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteDeviceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除设备
         *
         * @param request BatchDeleteDeviceRequest
         * @param headers BatchDeleteDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchDeleteDeviceResponse
         */
        public async Task<BatchDeleteDeviceResponse> BatchDeleteDeviceWithOptionsAsync(BatchDeleteDeviceRequest request, BatchDeleteDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIds))
            {
                body["deviceIds"] = request.DeviceIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchDeleteDevice",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/devices/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteDeviceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除设备
         *
         * @param request BatchDeleteDeviceRequest
         * @return BatchDeleteDeviceResponse
         */
        public BatchDeleteDeviceResponse BatchDeleteDevice(BatchDeleteDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchDeleteDeviceHeaders headers = new BatchDeleteDeviceHeaders();
            return BatchDeleteDeviceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除设备
         *
         * @param request BatchDeleteDeviceRequest
         * @return BatchDeleteDeviceResponse
         */
        public async Task<BatchDeleteDeviceResponse> BatchDeleteDeviceAsync(BatchDeleteDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchDeleteDeviceHeaders headers = new BatchDeleteDeviceHeaders();
            return await BatchDeleteDeviceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量注册设备
         *
         * @param request BatchRegisterDeviceRequest
         * @param headers BatchRegisterDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchRegisterDeviceResponse
         */
        public BatchRegisterDeviceResponse BatchRegisterDeviceWithOptions(BatchRegisterDeviceRequest request, BatchRegisterDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Devices))
            {
                body["devices"] = request.Devices;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchRegisterDevice",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/devices/registrations/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRegisterDeviceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量注册设备
         *
         * @param request BatchRegisterDeviceRequest
         * @param headers BatchRegisterDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchRegisterDeviceResponse
         */
        public async Task<BatchRegisterDeviceResponse> BatchRegisterDeviceWithOptionsAsync(BatchRegisterDeviceRequest request, BatchRegisterDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Devices))
            {
                body["devices"] = request.Devices;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchRegisterDevice",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/devices/registrations/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRegisterDeviceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量注册设备
         *
         * @param request BatchRegisterDeviceRequest
         * @return BatchRegisterDeviceResponse
         */
        public BatchRegisterDeviceResponse BatchRegisterDevice(BatchRegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRegisterDeviceHeaders headers = new BatchRegisterDeviceHeaders();
            return BatchRegisterDeviceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量注册设备
         *
         * @param request BatchRegisterDeviceRequest
         * @return BatchRegisterDeviceResponse
         */
        public async Task<BatchRegisterDeviceResponse> BatchRegisterDeviceAsync(BatchRegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRegisterDeviceHeaders headers = new BatchRegisterDeviceHeaders();
            return await BatchRegisterDeviceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量注册事件类型
         *
         * @param request BatchRegisterEventTypeRequest
         * @param headers BatchRegisterEventTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchRegisterEventTypeResponse
         */
        public BatchRegisterEventTypeResponse BatchRegisterEventTypeWithOptions(BatchRegisterEventTypeRequest request, BatchRegisterEventTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTypes))
            {
                body["eventTypes"] = request.EventTypes;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchRegisterEventType",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/eventTypes/registrations/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRegisterEventTypeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量注册事件类型
         *
         * @param request BatchRegisterEventTypeRequest
         * @param headers BatchRegisterEventTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchRegisterEventTypeResponse
         */
        public async Task<BatchRegisterEventTypeResponse> BatchRegisterEventTypeWithOptionsAsync(BatchRegisterEventTypeRequest request, BatchRegisterEventTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTypes))
            {
                body["eventTypes"] = request.EventTypes;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchRegisterEventType",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/eventTypes/registrations/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRegisterEventTypeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量注册事件类型
         *
         * @param request BatchRegisterEventTypeRequest
         * @return BatchRegisterEventTypeResponse
         */
        public BatchRegisterEventTypeResponse BatchRegisterEventType(BatchRegisterEventTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRegisterEventTypeHeaders headers = new BatchRegisterEventTypeHeaders();
            return BatchRegisterEventTypeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量注册事件类型
         *
         * @param request BatchRegisterEventTypeRequest
         * @return BatchRegisterEventTypeResponse
         */
        public async Task<BatchRegisterEventTypeResponse> BatchRegisterEventTypeAsync(BatchRegisterEventTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRegisterEventTypeHeaders headers = new BatchRegisterEventTypeHeaders();
            return await BatchRegisterEventTypeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量修改设备
         *
         * @param request BatchUpdateDeviceRequest
         * @param headers BatchUpdateDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchUpdateDeviceResponse
         */
        public BatchUpdateDeviceResponse BatchUpdateDeviceWithOptions(BatchUpdateDeviceRequest request, BatchUpdateDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Devices))
            {
                body["devices"] = request.Devices;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchUpdateDevice",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/devices/batch",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateDeviceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量修改设备
         *
         * @param request BatchUpdateDeviceRequest
         * @param headers BatchUpdateDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchUpdateDeviceResponse
         */
        public async Task<BatchUpdateDeviceResponse> BatchUpdateDeviceWithOptionsAsync(BatchUpdateDeviceRequest request, BatchUpdateDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Devices))
            {
                body["devices"] = request.Devices;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchUpdateDevice",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/devices/batch",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateDeviceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量修改设备
         *
         * @param request BatchUpdateDeviceRequest
         * @return BatchUpdateDeviceResponse
         */
        public BatchUpdateDeviceResponse BatchUpdateDevice(BatchUpdateDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateDeviceHeaders headers = new BatchUpdateDeviceHeaders();
            return BatchUpdateDeviceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量修改设备
         *
         * @param request BatchUpdateDeviceRequest
         * @return BatchUpdateDeviceResponse
         */
        public async Task<BatchUpdateDeviceResponse> BatchUpdateDeviceAsync(BatchUpdateDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateDeviceHeaders headers = new BatchUpdateDeviceHeaders();
            return await BatchUpdateDeviceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 系统绑定
         *
         * @param request BindSystemRequest
         * @param headers BindSystemHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindSystemResponse
         */
        public BindSystemResponse BindSystemWithOptions(BindSystemRequest request, BindSystemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                body["authCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["clientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientName))
            {
                body["clientName"] = request.ClientName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraData))
            {
                body["extraData"] = request.ExtraData;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BindSystem",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/systems/bind",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindSystemResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 系统绑定
         *
         * @param request BindSystemRequest
         * @param headers BindSystemHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindSystemResponse
         */
        public async Task<BindSystemResponse> BindSystemWithOptionsAsync(BindSystemRequest request, BindSystemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                body["authCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["clientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientName))
            {
                body["clientName"] = request.ClientName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraData))
            {
                body["extraData"] = request.ExtraData;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BindSystem",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/systems/bind",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindSystemResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 系统绑定
         *
         * @param request BindSystemRequest
         * @return BindSystemResponse
         */
        public BindSystemResponse BindSystem(BindSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BindSystemHeaders headers = new BindSystemHeaders();
            return BindSystemWithOptions(request, headers, runtime);
        }

        /**
         * @summary 系统绑定
         *
         * @param request BindSystemRequest
         * @return BindSystemResponse
         */
        public async Task<BindSystemResponse> BindSystemAsync(BindSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BindSystemHeaders headers = new BindSystemHeaders();
            return await BindSystemWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发起设备会议
         *
         * @param request DeviceConferenceRequest
         * @param headers DeviceConferenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeviceConferenceResponse
         */
        public DeviceConferenceResponse DeviceConferenceWithOptions(DeviceConferenceRequest request, DeviceConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfTitle))
            {
                body["confTitle"] = request.ConfTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceId))
            {
                body["conferenceId"] = request.ConferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferencePassword))
            {
                body["conferencePassword"] = request.ConferencePassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIds))
            {
                body["deviceIds"] = request.DeviceIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "DeviceConference",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/deviceConferences/initiate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeviceConferenceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发起设备会议
         *
         * @param request DeviceConferenceRequest
         * @param headers DeviceConferenceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeviceConferenceResponse
         */
        public async Task<DeviceConferenceResponse> DeviceConferenceWithOptionsAsync(DeviceConferenceRequest request, DeviceConferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfTitle))
            {
                body["confTitle"] = request.ConfTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceId))
            {
                body["conferenceId"] = request.ConferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferencePassword))
            {
                body["conferencePassword"] = request.ConferencePassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIds))
            {
                body["deviceIds"] = request.DeviceIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "DeviceConference",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/deviceConferences/initiate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeviceConferenceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发起设备会议
         *
         * @param request DeviceConferenceRequest
         * @return DeviceConferenceResponse
         */
        public DeviceConferenceResponse DeviceConference(DeviceConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeviceConferenceHeaders headers = new DeviceConferenceHeaders();
            return DeviceConferenceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发起设备会议
         *
         * @param request DeviceConferenceRequest
         * @return DeviceConferenceResponse
         */
        public async Task<DeviceConferenceResponse> DeviceConferenceAsync(DeviceConferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeviceConferenceHeaders headers = new DeviceConferenceHeaders();
            return await DeviceConferenceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 钉钉物联Mama接口
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DiotMamaResponse
         */
        public DiotMamaResponse DiotMamaWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DiotMama",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DiotMamaResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 钉钉物联Mama接口
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DiotMamaResponse
         */
        public async Task<DiotMamaResponse> DiotMamaWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DiotMama",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DiotMamaResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 钉钉物联Mama接口
         *
         * @return DiotMamaResponse
         */
        public DiotMamaResponse DiotMama()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DiotMamaWithOptions(headers, runtime);
        }

        /**
         * @summary 钉钉物联Mama接口
         *
         * @return DiotMamaResponse
         */
        public async Task<DiotMamaResponse> DiotMamaAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DiotMamaWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary diot官方市场处理
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DiotMarketManagerTestResponse
         */
        public DiotMarketManagerTestResponse DiotMarketManagerTestWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DiotMarketManagerTest",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/market/manager/test",
                Method = "PUT",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DiotMarketManagerTestResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary diot官方市场处理
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DiotMarketManagerTestResponse
         */
        public async Task<DiotMarketManagerTestResponse> DiotMarketManagerTestWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DiotMarketManagerTest",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/market/manager/test",
                Method = "PUT",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DiotMarketManagerTestResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary diot官方市场处理
         *
         * @return DiotMarketManagerTestResponse
         */
        public DiotMarketManagerTestResponse DiotMarketManagerTest()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DiotMarketManagerTestWithOptions(headers, runtime);
        }

        /**
         * @summary diot官方市场处理
         *
         * @return DiotMarketManagerTestResponse
         */
        public async Task<DiotMarketManagerTestResponse> DiotMarketManagerTestAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DiotMarketManagerTestWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 钉钉物联系统测试
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DiotSystemMarkTestResponse
         */
        public DiotSystemMarkTestResponse DiotSystemMarkTestWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DiotSystemMarkTest",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/sys/mark/test",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DiotSystemMarkTestResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 钉钉物联系统测试
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DiotSystemMarkTestResponse
         */
        public async Task<DiotSystemMarkTestResponse> DiotSystemMarkTestWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DiotSystemMarkTest",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/sys/mark/test",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DiotSystemMarkTestResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 钉钉物联系统测试
         *
         * @return DiotSystemMarkTestResponse
         */
        public DiotSystemMarkTestResponse DiotSystemMarkTest()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DiotSystemMarkTestWithOptions(headers, runtime);
        }

        /**
         * @summary 钉钉物联系统测试
         *
         * @return DiotSystemMarkTestResponse
         */
        public async Task<DiotSystemMarkTestResponse> DiotSystemMarkTestAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DiotSystemMarkTestWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 钉钉物联市场管理
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DiotMarketManagerResponse
         */
        public DiotMarketManagerResponse Diot_Market_ManagerWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Diot_Market_Manager",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/market/manager",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DiotMarketManagerResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 钉钉物联市场管理
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DiotMarketManagerResponse
         */
        public async Task<DiotMarketManagerResponse> Diot_Market_ManagerWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Diot_Market_Manager",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/market/manager",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DiotMarketManagerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 钉钉物联市场管理
         *
         * @return DiotMarketManagerResponse
         */
        public DiotMarketManagerResponse Diot_Market_Manager()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return Diot_Market_ManagerWithOptions(headers, runtime);
        }

        /**
         * @summary 钉钉物联市场管理
         *
         * @return DiotMarketManagerResponse
         */
        public async Task<DiotMarketManagerResponse> Diot_Market_ManagerAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await Diot_Market_ManagerWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 推送事件
         *
         * @param request PushEventRequest
         * @param headers PushEventHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushEventResponse
         */
        public PushEventResponse PushEventWithOptions(PushEventRequest request, PushEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                body["eventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                body["eventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                body["eventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraData))
            {
                body["extraData"] = request.ExtraData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msg))
            {
                body["msg"] = request.Msg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OccurrenceTime))
            {
                body["occurrenceTime"] = request.OccurrenceTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PicUrls))
            {
                body["picUrls"] = request.PicUrls;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PushEvent",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/events/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushEventResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 推送事件
         *
         * @param request PushEventRequest
         * @param headers PushEventHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushEventResponse
         */
        public async Task<PushEventResponse> PushEventWithOptionsAsync(PushEventRequest request, PushEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                body["eventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                body["eventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                body["eventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraData))
            {
                body["extraData"] = request.ExtraData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msg))
            {
                body["msg"] = request.Msg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OccurrenceTime))
            {
                body["occurrenceTime"] = request.OccurrenceTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PicUrls))
            {
                body["picUrls"] = request.PicUrls;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PushEvent",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/events/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 推送事件
         *
         * @param request PushEventRequest
         * @return PushEventResponse
         */
        public PushEventResponse PushEvent(PushEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushEventHeaders headers = new PushEventHeaders();
            return PushEventWithOptions(request, headers, runtime);
        }

        /**
         * @summary 推送事件
         *
         * @param request PushEventRequest
         * @return PushEventResponse
         */
        public async Task<PushEventResponse> PushEventAsync(PushEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushEventHeaders headers = new PushEventHeaders();
            return await PushEventWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询设备
         *
         * @param request QueryDeviceRequest
         * @param headers QueryDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDeviceResponse
         */
        public QueryDeviceResponse QueryDeviceWithOptions(QueryDeviceRequest request, QueryDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevice",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/devices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询设备
         *
         * @param request QueryDeviceRequest
         * @param headers QueryDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDeviceResponse
         */
        public async Task<QueryDeviceResponse> QueryDeviceWithOptionsAsync(QueryDeviceRequest request, QueryDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevice",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/devices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询设备
         *
         * @param request QueryDeviceRequest
         * @return QueryDeviceResponse
         */
        public QueryDeviceResponse QueryDevice(QueryDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceHeaders headers = new QueryDeviceHeaders();
            return QueryDeviceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询设备
         *
         * @param request QueryDeviceRequest
         * @return QueryDeviceResponse
         */
        public async Task<QueryDeviceResponse> QueryDeviceAsync(QueryDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceHeaders headers = new QueryDeviceHeaders();
            return await QueryDeviceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询硬件设备的PK值信息
         *
         * @param request QueryDevicePkRequest
         * @param headers QueryDevicePkHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDevicePkResponse
         */
        public QueryDevicePkResponse QueryDevicePkWithOptions(QueryDevicePkRequest request, QueryDevicePkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["deviceId"] = request.DeviceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryDevicePk",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/devices/pkInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicePkResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询硬件设备的PK值信息
         *
         * @param request QueryDevicePkRequest
         * @param headers QueryDevicePkHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDevicePkResponse
         */
        public async Task<QueryDevicePkResponse> QueryDevicePkWithOptionsAsync(QueryDevicePkRequest request, QueryDevicePkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["deviceId"] = request.DeviceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryDevicePk",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/devices/pkInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicePkResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询硬件设备的PK值信息
         *
         * @param request QueryDevicePkRequest
         * @return QueryDevicePkResponse
         */
        public QueryDevicePkResponse QueryDevicePk(QueryDevicePkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDevicePkHeaders headers = new QueryDevicePkHeaders();
            return QueryDevicePkWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询硬件设备的PK值信息
         *
         * @param request QueryDevicePkRequest
         * @return QueryDevicePkResponse
         */
        public async Task<QueryDevicePkResponse> QueryDevicePkAsync(QueryDevicePkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDevicePkHeaders headers = new QueryDevicePkHeaders();
            return await QueryDevicePkWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询事件
         *
         * @param request QueryEventRequest
         * @param headers QueryEventHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryEventResponse
         */
        public QueryEventResponse QueryEventWithOptions(QueryEventRequest request, QueryEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIdList))
            {
                body["deviceIdList"] = request.DeviceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                body["eventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStatusList))
            {
                body["eventStatusList"] = request.EventStatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTypeList))
            {
                body["eventTypeList"] = request.EventTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryEvent",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/events/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询事件
         *
         * @param request QueryEventRequest
         * @param headers QueryEventHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryEventResponse
         */
        public async Task<QueryEventResponse> QueryEventWithOptionsAsync(QueryEventRequest request, QueryEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIdList))
            {
                body["deviceIdList"] = request.DeviceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                body["eventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStatusList))
            {
                body["eventStatusList"] = request.EventStatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTypeList))
            {
                body["eventTypeList"] = request.EventTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryEvent",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/events/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询事件
         *
         * @param request QueryEventRequest
         * @return QueryEventResponse
         */
        public QueryEventResponse QueryEvent(QueryEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryEventHeaders headers = new QueryEventHeaders();
            return QueryEventWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询事件
         *
         * @param request QueryEventRequest
         * @return QueryEventResponse
         */
        public async Task<QueryEventResponse> QueryEventAsync(QueryEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryEventHeaders headers = new QueryEventHeaders();
            return await QueryEventWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 注册设备
         *
         * @param request RegisterDeviceRequest
         * @param headers RegisterDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterDeviceResponse
         */
        public RegisterDeviceResponse RegisterDeviceWithOptions(RegisterDeviceRequest request, RegisterDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceStatus))
            {
                body["deviceStatus"] = request.DeviceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["deviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTypeName))
            {
                body["deviceTypeName"] = request.DeviceTypeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveUrls))
            {
                body["liveUrls"] = request.LiveUrls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                body["nickName"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RegisterDevice",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/devices/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterDeviceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 注册设备
         *
         * @param request RegisterDeviceRequest
         * @param headers RegisterDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterDeviceResponse
         */
        public async Task<RegisterDeviceResponse> RegisterDeviceWithOptionsAsync(RegisterDeviceRequest request, RegisterDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceStatus))
            {
                body["deviceStatus"] = request.DeviceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["deviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTypeName))
            {
                body["deviceTypeName"] = request.DeviceTypeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveUrls))
            {
                body["liveUrls"] = request.LiveUrls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                body["nickName"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RegisterDevice",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/devices/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterDeviceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 注册设备
         *
         * @param request RegisterDeviceRequest
         * @return RegisterDeviceResponse
         */
        public RegisterDeviceResponse RegisterDevice(RegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterDeviceHeaders headers = new RegisterDeviceHeaders();
            return RegisterDeviceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 注册设备
         *
         * @param request RegisterDeviceRequest
         * @return RegisterDeviceResponse
         */
        public async Task<RegisterDeviceResponse> RegisterDeviceAsync(RegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterDeviceHeaders headers = new RegisterDeviceHeaders();
            return await RegisterDeviceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 升级设备
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeDeviceResponse
         */
        public UpgradeDeviceResponse UpgradeDeviceWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeDevice",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/upgrade/device",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeDeviceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 升级设备
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeDeviceResponse
         */
        public async Task<UpgradeDeviceResponse> UpgradeDeviceWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeDevice",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/upgrade/device",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeDeviceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 升级设备
         *
         * @return UpgradeDeviceResponse
         */
        public UpgradeDeviceResponse UpgradeDevice()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpgradeDeviceWithOptions(headers, runtime);
        }

        /**
         * @summary 升级设备
         *
         * @return UpgradeDeviceResponse
         */
        public async Task<UpgradeDeviceResponse> UpgradeDeviceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpgradeDeviceWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 获取工作台流转物联信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return WorkbenchTransformInfoResponse
         */
        public WorkbenchTransformInfoResponse WorkbenchTransformInfoWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WorkbenchTransformInfo",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/workbench/transform",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WorkbenchTransformInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取工作台流转物联信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return WorkbenchTransformInfoResponse
         */
        public async Task<WorkbenchTransformInfoResponse> WorkbenchTransformInfoWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WorkbenchTransformInfo",
                Version = "diot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/diot/workbench/transform",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WorkbenchTransformInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取工作台流转物联信息
         *
         * @return WorkbenchTransformInfoResponse
         */
        public WorkbenchTransformInfoResponse WorkbenchTransformInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return WorkbenchTransformInfoWithOptions(headers, runtime);
        }

        /**
         * @summary 获取工作台流转物联信息
         *
         * @return WorkbenchTransformInfoResponse
         */
        public async Task<WorkbenchTransformInfoResponse> WorkbenchTransformInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await WorkbenchTransformInfoWithOptionsAsync(headers, runtime);
        }

    }
}
