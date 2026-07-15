// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkaiot_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkaiot_1_0
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
        /// <para>检查指定设备的固件升级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDeviceUpdateRequest
        /// </param>
        /// <param name="headers">
        /// CheckDeviceUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDeviceUpdateResponse
        /// </returns>
        public CheckDeviceUpdateResponse CheckDeviceUpdateWithOptions(string productKey, string deviceName, CheckDeviceUpdateRequest request, CheckDeviceUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDeviceUpdate",
                Version = "aiot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiot/products/" + productKey + "/devices/" + deviceName + "/firmware/checkUpdate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDeviceUpdateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查指定设备的固件升级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDeviceUpdateRequest
        /// </param>
        /// <param name="headers">
        /// CheckDeviceUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDeviceUpdateResponse
        /// </returns>
        public async Task<CheckDeviceUpdateResponse> CheckDeviceUpdateWithOptionsAsync(string productKey, string deviceName, CheckDeviceUpdateRequest request, CheckDeviceUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDeviceUpdate",
                Version = "aiot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiot/products/" + productKey + "/devices/" + deviceName + "/firmware/checkUpdate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDeviceUpdateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查指定设备的固件升级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDeviceUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDeviceUpdateResponse
        /// </returns>
        public CheckDeviceUpdateResponse CheckDeviceUpdate(string productKey, string deviceName, CheckDeviceUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckDeviceUpdateHeaders headers = new CheckDeviceUpdateHeaders();
            return CheckDeviceUpdateWithOptions(productKey, deviceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查指定设备的固件升级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDeviceUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDeviceUpdateResponse
        /// </returns>
        public async Task<CheckDeviceUpdateResponse> CheckDeviceUpdateAsync(string productKey, string deviceName, CheckDeviceUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckDeviceUpdateHeaders headers = new CheckDeviceUpdateHeaders();
            return await CheckDeviceUpdateWithOptionsAsync(productKey, deviceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认执行设备固件升级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfirmFirmwareUpgradeRequest
        /// </param>
        /// <param name="headers">
        /// ConfirmFirmwareUpgradeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfirmFirmwareUpgradeResponse
        /// </returns>
        public ConfirmFirmwareUpgradeResponse ConfirmFirmwareUpgradeWithOptions(string productKey, string deviceName, ConfirmFirmwareUpgradeRequest request, ConfirmFirmwareUpgradeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["moduleName"] = request.ModuleName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmFirmwareUpgrade",
                Version = "aiot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiot/products/" + productKey + "/devices/" + deviceName + "/firmware/confirmUpgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmFirmwareUpgradeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认执行设备固件升级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfirmFirmwareUpgradeRequest
        /// </param>
        /// <param name="headers">
        /// ConfirmFirmwareUpgradeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfirmFirmwareUpgradeResponse
        /// </returns>
        public async Task<ConfirmFirmwareUpgradeResponse> ConfirmFirmwareUpgradeWithOptionsAsync(string productKey, string deviceName, ConfirmFirmwareUpgradeRequest request, ConfirmFirmwareUpgradeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["moduleName"] = request.ModuleName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmFirmwareUpgrade",
                Version = "aiot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiot/products/" + productKey + "/devices/" + deviceName + "/firmware/confirmUpgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmFirmwareUpgradeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认执行设备固件升级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfirmFirmwareUpgradeRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfirmFirmwareUpgradeResponse
        /// </returns>
        public ConfirmFirmwareUpgradeResponse ConfirmFirmwareUpgrade(string productKey, string deviceName, ConfirmFirmwareUpgradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConfirmFirmwareUpgradeHeaders headers = new ConfirmFirmwareUpgradeHeaders();
            return ConfirmFirmwareUpgradeWithOptions(productKey, deviceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认执行设备固件升级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfirmFirmwareUpgradeRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfirmFirmwareUpgradeResponse
        /// </returns>
        public async Task<ConfirmFirmwareUpgradeResponse> ConfirmFirmwareUpgradeAsync(string productKey, string deviceName, ConfirmFirmwareUpgradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConfirmFirmwareUpgradeHeaders headers = new ConfirmFirmwareUpgradeHeaders();
            return await ConfirmFirmwareUpgradeWithOptionsAsync(productKey, deviceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定设备的详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetDeviceDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceDetailResponse
        /// </returns>
        public GetDeviceDetailResponse GetDeviceDetailWithOptions(string productKey, string deviceName, GetDeviceDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDeviceDetail",
                Version = "aiot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiot/products/" + productKey + "/devices/" + deviceName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定设备的详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetDeviceDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceDetailResponse
        /// </returns>
        public async Task<GetDeviceDetailResponse> GetDeviceDetailWithOptionsAsync(string productKey, string deviceName, GetDeviceDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDeviceDetail",
                Version = "aiot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiot/products/" + productKey + "/devices/" + deviceName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定设备的详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDeviceDetailResponse
        /// </returns>
        public GetDeviceDetailResponse GetDeviceDetail(string productKey, string deviceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeviceDetailHeaders headers = new GetDeviceDetailHeaders();
            return GetDeviceDetailWithOptions(productKey, deviceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定设备的详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDeviceDetailResponse
        /// </returns>
        public async Task<GetDeviceDetailResponse> GetDeviceDetailAsync(string productKey, string deviceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeviceDetailHeaders headers = new GetDeviceDetailHeaders();
            return await GetDeviceDetailWithOptionsAsync(productKey, deviceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>读取指定设备的属性快照</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDevicePropertiesRequest
        /// </param>
        /// <param name="headers">
        /// GetDevicePropertiesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDevicePropertiesResponse
        /// </returns>
        public GetDevicePropertiesResponse GetDevicePropertiesWithOptions(string productKey, string deviceName, GetDevicePropertiesRequest request, GetDevicePropertiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceProperties",
                Version = "aiot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiot/products/" + productKey + "/devices/" + deviceName + "/properties/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDevicePropertiesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>读取指定设备的属性快照</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDevicePropertiesRequest
        /// </param>
        /// <param name="headers">
        /// GetDevicePropertiesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDevicePropertiesResponse
        /// </returns>
        public async Task<GetDevicePropertiesResponse> GetDevicePropertiesWithOptionsAsync(string productKey, string deviceName, GetDevicePropertiesRequest request, GetDevicePropertiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceProperties",
                Version = "aiot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiot/products/" + productKey + "/devices/" + deviceName + "/properties/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDevicePropertiesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>读取指定设备的属性快照</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDevicePropertiesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDevicePropertiesResponse
        /// </returns>
        public GetDevicePropertiesResponse GetDeviceProperties(string productKey, string deviceName, GetDevicePropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDevicePropertiesHeaders headers = new GetDevicePropertiesHeaders();
            return GetDevicePropertiesWithOptions(productKey, deviceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>读取指定设备的属性快照</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDevicePropertiesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDevicePropertiesResponse
        /// </returns>
        public async Task<GetDevicePropertiesResponse> GetDevicePropertiesAsync(string productKey, string deviceName, GetDevicePropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDevicePropertiesHeaders headers = new GetDevicePropertiesHeaders();
            return await GetDevicePropertiesWithOptionsAsync(productKey, deviceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备服务调用结果</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetServiceInvocationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceInvocationResponse
        /// </returns>
        public GetServiceInvocationResponse GetServiceInvocationWithOptions(string invocationId, GetServiceInvocationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetServiceInvocation",
                Version = "aiot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiot/serviceInvocations/" + invocationId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceInvocationResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备服务调用结果</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetServiceInvocationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceInvocationResponse
        /// </returns>
        public async Task<GetServiceInvocationResponse> GetServiceInvocationWithOptionsAsync(string invocationId, GetServiceInvocationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetServiceInvocation",
                Version = "aiot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiot/serviceInvocations/" + invocationId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceInvocationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备服务调用结果</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceInvocationResponse
        /// </returns>
        public GetServiceInvocationResponse GetServiceInvocation(string invocationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetServiceInvocationHeaders headers = new GetServiceInvocationHeaders();
            return GetServiceInvocationWithOptions(invocationId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备服务调用结果</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceInvocationResponse
        /// </returns>
        public async Task<GetServiceInvocationResponse> GetServiceInvocationAsync(string invocationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetServiceInvocationHeaders headers = new GetServiceInvocationHeaders();
            return await GetServiceInvocationWithOptionsAsync(invocationId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用指定设备的物模型服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokeDeviceServiceRequest
        /// </param>
        /// <param name="headers">
        /// InvokeDeviceServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokeDeviceServiceResponse
        /// </returns>
        public InvokeDeviceServiceResponse InvokeDeviceServiceWithOptions(string productKey, string deviceName, string serviceIdentifier, InvokeDeviceServiceRequest request, InvokeDeviceServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Args))
            {
                body["args"] = request.Args;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutSeconds))
            {
                body["timeoutSeconds"] = request.TimeoutSeconds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "InvokeDeviceService",
                Version = "aiot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiot/products/" + productKey + "/devices/" + deviceName + "/services/" + serviceIdentifier + "/invoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokeDeviceServiceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用指定设备的物模型服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokeDeviceServiceRequest
        /// </param>
        /// <param name="headers">
        /// InvokeDeviceServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokeDeviceServiceResponse
        /// </returns>
        public async Task<InvokeDeviceServiceResponse> InvokeDeviceServiceWithOptionsAsync(string productKey, string deviceName, string serviceIdentifier, InvokeDeviceServiceRequest request, InvokeDeviceServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Args))
            {
                body["args"] = request.Args;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutSeconds))
            {
                body["timeoutSeconds"] = request.TimeoutSeconds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "InvokeDeviceService",
                Version = "aiot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiot/products/" + productKey + "/devices/" + deviceName + "/services/" + serviceIdentifier + "/invoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokeDeviceServiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用指定设备的物模型服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokeDeviceServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokeDeviceServiceResponse
        /// </returns>
        public InvokeDeviceServiceResponse InvokeDeviceService(string productKey, string deviceName, string serviceIdentifier, InvokeDeviceServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvokeDeviceServiceHeaders headers = new InvokeDeviceServiceHeaders();
            return InvokeDeviceServiceWithOptions(productKey, deviceName, serviceIdentifier, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用指定设备的物模型服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokeDeviceServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokeDeviceServiceResponse
        /// </returns>
        public async Task<InvokeDeviceServiceResponse> InvokeDeviceServiceAsync(string productKey, string deviceName, string serviceIdentifier, InvokeDeviceServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvokeDeviceServiceHeaders headers = new InvokeDeviceServiceHeaders();
            return await InvokeDeviceServiceWithOptionsAsync(productKey, deviceName, serviceIdentifier, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置指定设备的属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDevicePropertiesRequest
        /// </param>
        /// <param name="headers">
        /// SetDevicePropertiesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDevicePropertiesResponse
        /// </returns>
        public SetDevicePropertiesResponse SetDevicePropertiesWithOptions(string productKey, string deviceName, SetDevicePropertiesRequest request, SetDevicePropertiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetDeviceProperties",
                Version = "aiot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiot/products/" + productKey + "/devices/" + deviceName + "/properties",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDevicePropertiesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置指定设备的属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDevicePropertiesRequest
        /// </param>
        /// <param name="headers">
        /// SetDevicePropertiesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDevicePropertiesResponse
        /// </returns>
        public async Task<SetDevicePropertiesResponse> SetDevicePropertiesWithOptionsAsync(string productKey, string deviceName, SetDevicePropertiesRequest request, SetDevicePropertiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetDeviceProperties",
                Version = "aiot_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiot/products/" + productKey + "/devices/" + deviceName + "/properties",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDevicePropertiesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置指定设备的属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDevicePropertiesRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDevicePropertiesResponse
        /// </returns>
        public SetDevicePropertiesResponse SetDeviceProperties(string productKey, string deviceName, SetDevicePropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDevicePropertiesHeaders headers = new SetDevicePropertiesHeaders();
            return SetDevicePropertiesWithOptions(productKey, deviceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置指定设备的属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDevicePropertiesRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDevicePropertiesResponse
        /// </returns>
        public async Task<SetDevicePropertiesResponse> SetDevicePropertiesAsync(string productKey, string deviceName, SetDevicePropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetDevicePropertiesHeaders headers = new SetDevicePropertiesHeaders();
            return await SetDevicePropertiesWithOptionsAsync(productKey, deviceName, request, headers, runtime);
        }

    }
}
