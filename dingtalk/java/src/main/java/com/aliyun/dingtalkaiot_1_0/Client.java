// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkaiot_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>检查指定设备的固件升级</p>
     * 
     * @param request CheckDeviceUpdateRequest
     * @param headers CheckDeviceUpdateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CheckDeviceUpdateResponse
     */
    public CheckDeviceUpdateResponse checkDeviceUpdateWithOptions(String productKey, String deviceName, CheckDeviceUpdateRequest request, CheckDeviceUpdateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.teautil.Common.toArray(request.body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CheckDeviceUpdate"),
            new TeaPair("version", "aiot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiot/products/" + productKey + "/devices/" + deviceName + "/firmware/checkUpdate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CheckDeviceUpdateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>检查指定设备的固件升级</p>
     * 
     * @param request CheckDeviceUpdateRequest
     * @return CheckDeviceUpdateResponse
     */
    public CheckDeviceUpdateResponse checkDeviceUpdate(String productKey, String deviceName, CheckDeviceUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CheckDeviceUpdateHeaders headers = new CheckDeviceUpdateHeaders();
        return this.checkDeviceUpdateWithOptions(productKey, deviceName, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>确认执行设备固件升级</p>
     * 
     * @param request ConfirmFirmwareUpgradeRequest
     * @param headers ConfirmFirmwareUpgradeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ConfirmFirmwareUpgradeResponse
     */
    public ConfirmFirmwareUpgradeResponse confirmFirmwareUpgradeWithOptions(String productKey, String deviceName, ConfirmFirmwareUpgradeRequest request, ConfirmFirmwareUpgradeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.moduleName)) {
            query.put("moduleName", request.moduleName);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ConfirmFirmwareUpgrade"),
            new TeaPair("version", "aiot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiot/products/" + productKey + "/devices/" + deviceName + "/firmware/confirmUpgrade"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ConfirmFirmwareUpgradeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>确认执行设备固件升级</p>
     * 
     * @param request ConfirmFirmwareUpgradeRequest
     * @return ConfirmFirmwareUpgradeResponse
     */
    public ConfirmFirmwareUpgradeResponse confirmFirmwareUpgrade(String productKey, String deviceName, ConfirmFirmwareUpgradeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ConfirmFirmwareUpgradeHeaders headers = new ConfirmFirmwareUpgradeHeaders();
        return this.confirmFirmwareUpgradeWithOptions(productKey, deviceName, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询指定设备的详情</p>
     * 
     * @param headers GetDeviceDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDeviceDetailResponse
     */
    public GetDeviceDetailResponse getDeviceDetailWithOptions(String productKey, String deviceName, GetDeviceDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetDeviceDetail"),
            new TeaPair("version", "aiot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiot/products/" + productKey + "/devices/" + deviceName + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDeviceDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询指定设备的详情</p>
     * @return GetDeviceDetailResponse
     */
    public GetDeviceDetailResponse getDeviceDetail(String productKey, String deviceName) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDeviceDetailHeaders headers = new GetDeviceDetailHeaders();
        return this.getDeviceDetailWithOptions(productKey, deviceName, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>读取指定设备的属性快照</p>
     * 
     * @param request GetDevicePropertiesRequest
     * @param headers GetDevicePropertiesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDevicePropertiesResponse
     */
    public GetDevicePropertiesResponse getDevicePropertiesWithOptions(String productKey, String deviceName, GetDevicePropertiesRequest request, GetDevicePropertiesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", request.body)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetDeviceProperties"),
            new TeaPair("version", "aiot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiot/products/" + productKey + "/devices/" + deviceName + "/properties/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDevicePropertiesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>读取指定设备的属性快照</p>
     * 
     * @param request GetDevicePropertiesRequest
     * @return GetDevicePropertiesResponse
     */
    public GetDevicePropertiesResponse getDeviceProperties(String productKey, String deviceName, GetDevicePropertiesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDevicePropertiesHeaders headers = new GetDevicePropertiesHeaders();
        return this.getDevicePropertiesWithOptions(productKey, deviceName, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询设备服务调用记录</p>
     * 
     * @param headers GetServiceInvocationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetServiceInvocationResponse
     */
    public GetServiceInvocationResponse getServiceInvocationWithOptions(String invocationId, GetServiceInvocationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetServiceInvocation"),
            new TeaPair("version", "aiot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiot/serviceInvocations/" + invocationId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetServiceInvocationResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询设备服务调用记录</p>
     * @return GetServiceInvocationResponse
     */
    public GetServiceInvocationResponse getServiceInvocation(String invocationId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetServiceInvocationHeaders headers = new GetServiceInvocationHeaders();
        return this.getServiceInvocationWithOptions(invocationId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>调用指定设备的物模型服务</p>
     * 
     * @param request InvokeDeviceServiceRequest
     * @param headers InvokeDeviceServiceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InvokeDeviceServiceResponse
     */
    public InvokeDeviceServiceResponse invokeDeviceServiceWithOptions(String productKey, String deviceName, String serviceIdentifier, InvokeDeviceServiceRequest request, InvokeDeviceServiceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.args)) {
            body.put("args", request.args);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timeoutSeconds)) {
            body.put("timeoutSeconds", request.timeoutSeconds);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "InvokeDeviceService"),
            new TeaPair("version", "aiot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiot/products/" + productKey + "/devices/" + deviceName + "/services/" + serviceIdentifier + "/invoke"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InvokeDeviceServiceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>调用指定设备的物模型服务</p>
     * 
     * @param request InvokeDeviceServiceRequest
     * @return InvokeDeviceServiceResponse
     */
    public InvokeDeviceServiceResponse invokeDeviceService(String productKey, String deviceName, String serviceIdentifier, InvokeDeviceServiceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InvokeDeviceServiceHeaders headers = new InvokeDeviceServiceHeaders();
        return this.invokeDeviceServiceWithOptions(productKey, deviceName, serviceIdentifier, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>设置指定设备的属性</p>
     * 
     * @param request SetDevicePropertiesRequest
     * @param headers SetDevicePropertiesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetDevicePropertiesResponse
     */
    public SetDevicePropertiesResponse setDevicePropertiesWithOptions(String productKey, String deviceName, SetDevicePropertiesRequest request, SetDevicePropertiesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.body)) {
            body.put("body", request.body);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SetDeviceProperties"),
            new TeaPair("version", "aiot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiot/products/" + productKey + "/devices/" + deviceName + "/properties"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetDevicePropertiesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>设置指定设备的属性</p>
     * 
     * @param request SetDevicePropertiesRequest
     * @return SetDevicePropertiesResponse
     */
    public SetDevicePropertiesResponse setDeviceProperties(String productKey, String deviceName, SetDevicePropertiesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetDevicePropertiesHeaders headers = new SetDevicePropertiesHeaders();
        return this.setDevicePropertiesWithOptions(productKey, deviceName, request, headers, runtime);
    }
}
